/*
 * Nuvem Fiscal - SDK para .NET
 * https://www.nuvemfiscal.com.br
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;
using System.Net.Http;
using System.Net.Http.Headers;
using Polly;

namespace NuvemFiscal.Sdk.Client
{
    /// <summary>
    /// To Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
    /// </summary>
    internal class CustomJsonCodec
    {
        private readonly IReadableConfiguration _configuration;
        private static readonly string _contentType = "application/json";
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(IReadableConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        /// <summary>
        /// Serialize the object into a JSON string.
        /// </summary>
        /// <param name="obj">Object to be serialized.</param>
        /// <returns>A JSON string.</returns>
        public string Serialize(object obj)
        {
            if (obj != null && obj is NuvemFiscal.Sdk.Model.AbstractOpenAPISchema)
            {
                // the object to be serialized is an oneOf/anyOf schema
                return ((NuvemFiscal.Sdk.Model.AbstractOpenAPISchema)obj).ToJson();
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _serializerSettings);
            }
        }

        public async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            var result = (T) await Deserialize(response, typeof(T)).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal async Task<object> Deserialize(HttpResponseMessage response, Type type)
        {
            IList<string> headers = new List<string>();
            // process response headers, e.g. Access-Control-Allow-Methods
            foreach (var responseHeader in response.Headers)
            {
                headers.Add(responseHeader.Key + "=" +  ClientUtils.ParameterToString(responseHeader.Value));
            }

            // process response content headers, e.g. Content-Type
            foreach (var responseHeader in response.Content.Headers)
            {
                headers.Add(responseHeader.Key + "=" +  ClientUtils.ParameterToString(responseHeader.Value));
            }

            // RFC 2183 & RFC 2616
            var fileNameRegex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$", RegexOptions.IgnoreCase);
            if (type == typeof(byte[])) // return byte array
            {
                return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }
            else if (type == typeof(FileParameter))
            {
                if (headers != null) {
                    foreach (var header in headers)
                    {
                        var match = fileNameRegex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            return new FileParameter(fileName, await response.Content.ReadAsStreamAsync().ConfigureAwait(false));
                        }
                    }
                }
                return new FileParameter(await response.Content.ReadAsStreamAsync().ConfigureAwait(false));
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                var bytes = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                if (headers != null)
                {
                    var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : _configuration.TempFolderPath;

                    foreach (var header in headers)
                    {
                        var match = fileNameRegex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(bytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(await response.Content.ReadAsStringAsync().ConfigureAwait(false), null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(await response.Content.ReadAsStringAsync().ConfigureAwait(false), type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync().ConfigureAwait(false), type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public string ContentType
        {
            get { return _contentType; }
            set { throw new InvalidOperationException("Not allowed to set content type."); }
        }
    }
    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementations),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    /// <remarks>
    /// The Dispose method will manage the HttpClient lifecycle when not passed by constructor.
    /// </remarks>
    public partial class ApiClient : IDisposable, ISynchronousClient, IAsynchronousClient
    {
        private readonly string _baseUrl;

        private readonly HttpClientHandler _httpClientHandler;
        private readonly HttpClient _httpClient;
        private readonly bool _disposeClient;

        /// <summary>
        /// Specifies the settings on a <see cref="JsonSerializer" /> object.
        /// These settings can be adjusted to accommodate custom serialization rules.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />, defaulting to the global configurations' base url.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        public ApiClient() :
                 this(NuvemFiscal.Sdk.Client.GlobalConfiguration.Instance.BasePath)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(string basePath)
        {
            if (string.IsNullOrEmpty(basePath)) throw new ArgumentException("basePath cannot be empty");

            _httpClientHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpClientHandler, true);
            _disposeClient = true;
            _baseUrl = basePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />, defaulting to the global configurations' base url.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ApiClient(HttpClient client, HttpClientHandler handler = null) :
                 this(client, NuvemFiscal.Sdk.Client.GlobalConfiguration.Instance.BasePath, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ApiClient(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client cannot be null");
            if (string.IsNullOrEmpty(basePath)) throw new ArgumentException("basePath cannot be empty");

            _httpClientHandler = handler;
            _httpClient = client;
            _baseUrl = basePath;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            if(_disposeClient) {
                _httpClient.Dispose();
            }
        }

        /// Prepares multipart/form-data content
        HttpContent PrepareMultipartFormDataContent(RequestOptions options)
        {
            string boundary = "---------" + Guid.NewGuid().ToString().ToUpperInvariant();
            var multipartContent = new MultipartFormDataContent(boundary);
            foreach (var formParameter in options.FormParameters)
            {
                multipartContent.Add(new StringContent(formParameter.Value), formParameter.Key);
            }

            if (options.FileParameters != null && options.FileParameters.Count > 0)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    foreach (var file in fileParam.Value)
                    {
                        var content = new StreamContent(file.Content);
                        content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
                        multipartContent.Add(content, fileParam.Key, file.Name);
                    }
                }
            }
            return multipartContent;
        }

        /// <summary>
        /// Provides all logic for constructing a new HttpRequestMessage.
        /// At this point, all information for querying the service is known. Here, it is simply
        /// mapped into the a HttpRequestMessage.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>[private] A new HttpRequestMessage instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private HttpRequestMessage NewRequest(
            HttpMethod method,
            string path,
            RequestOptions options,
            IReadableConfiguration configuration)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");
            if (configuration == null) throw new ArgumentNullException("configuration");

            WebRequestPathBuilder builder = new WebRequestPathBuilder(_baseUrl, path);

            builder.AddPathParameters(options.PathParameters);

            builder.AddQueryParameters(options.QueryParameters);

            HttpRequestMessage request = new HttpRequestMessage(method, builder.GetFullUri());

            if (configuration.UserAgent != null)
            {
                request.Headers.TryAddWithoutValidation("User-Agent", configuration.UserAgent);
            }

            if (configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in configuration.DefaultHeaders)
                {
                    request.Headers.Add(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        // Todo make content headers actually content headers
                        request.Headers.TryAddWithoutValidation(headerParam.Key, value);
                    }
                }
            }

            List<Tuple<HttpContent, string, string>> contentList = new List<Tuple<HttpContent, string, string>>();

            string contentType = null;
            if (options.HeaderParameters != null && options.HeaderParameters.ContainsKey("Content-Type"))
            {
                var contentTypes = options.HeaderParameters["Content-Type"];
                contentType = contentTypes.FirstOrDefault();
            }

            if (contentType == "multipart/form-data")
            {
                request.Content = PrepareMultipartFormDataContent(options);
            }
            else if (contentType == "application/x-www-form-urlencoded")
            {
                request.Content = new FormUrlEncodedContent(options.FormParameters);
            }
            else
            {
                if (options.Data != null)
                {
                    if (options.Data is FileParameter fp)
                    {
                        contentType = contentType ?? "application/octet-stream";

                        var streamContent = new StreamContent(fp.Content);
                        streamContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                        request.Content = streamContent;
                    }
                    else
                    {
                        var serializer = new CustomJsonCodec(SerializerSettings, configuration);
                        request.Content = new StringContent(serializer.Serialize(options.Data), new UTF8Encoding(),
                            "application/json");
                    }
                }
            }



            // TODO provide an alternative that allows cookies per request instead of per API client
            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                request.Properties["CookieContainer"] = options.Cookies;
            }

            return request;
        }

        partial void InterceptRequest(HttpRequestMessage req);
        partial void InterceptResponse(HttpRequestMessage req, HttpResponseMessage response);

        private async Task<ApiResponse<T>> ToApiResponse<T>(HttpResponseMessage response, object responseData, Uri uri)
        {
            T result = (T) responseData;
            string rawContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ReasonPhrase,
                Cookies = new List<Cookie>()
            };

            // process response headers, e.g. Access-Control-Allow-Methods
            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            // process response content headers, e.g. Content-Type
            if (response.Content.Headers != null)
            {
                foreach (var responseHeader in response.Content.Headers)
                {
                    transformed.Headers.Add(responseHeader.Key, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (_httpClientHandler != null && response != null)
            {
                try {
                    foreach (Cookie cookie in _httpClientHandler.CookieContainer.GetCookies(uri))
                    {
                        transformed.Cookies.Add(cookie);
                    }
                }
                catch (PlatformNotSupportedException) {}
            }

            return transformed;
        }

        private ApiResponse<T> Exec<T>(HttpRequestMessage req, IReadableConfiguration configuration)
        {
            return ExecAsync<T>(req, configuration).GetAwaiter().GetResult();
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(HttpRequestMessage req,
            IReadableConfiguration configuration,
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            CancellationTokenSource timeoutTokenSource = null;
            CancellationTokenSource finalTokenSource = null;
            var deserializer = new CustomJsonCodec(SerializerSettings, configuration);
            var finalToken = cancellationToken;

            try
            {
                if (configuration.Timeout > 0)
                {
                    timeoutTokenSource = new CancellationTokenSource(configuration.Timeout);
                    finalTokenSource = CancellationTokenSource.CreateLinkedTokenSource(finalToken, timeoutTokenSource.Token);
                    finalToken = finalTokenSource.Token;
                }

                if (configuration.Proxy != null)
                {
                    if(_httpClientHandler == null) throw new InvalidOperationException("Configuration `Proxy` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
                    _httpClientHandler.Proxy = configuration.Proxy;
                }

                if (configuration.ClientCertificates != null)
                {
                    if(_httpClientHandler == null) throw new InvalidOperationException("Configuration `ClientCertificates` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
                    _httpClientHandler.ClientCertificates.AddRange(configuration.ClientCertificates);
                }

                var cookieContainer = req.Properties.ContainsKey("CookieContainer") ? req.Properties["CookieContainer"] as List<Cookie> : null;

                if (cookieContainer != null)
                {
                    if(_httpClientHandler == null) throw new InvalidOperationException("Request property `CookieContainer` not supported when the client is explicitly created without an HttpClientHandler, use the proper constructor.");
                    foreach (var cookie in cookieContainer)
                    {
                        _httpClientHandler.CookieContainer.Add(cookie);
                    }
                }

                InterceptRequest(req);

                HttpResponseMessage response;
                if (RetryConfiguration.AsyncRetryPolicy != null)
                {
                    var policy = RetryConfiguration.AsyncRetryPolicy;
                    var policyResult = await policy
                        .ExecuteAndCaptureAsync(() => _httpClient.SendAsync(req, finalToken))
                        .ConfigureAwait(false);
                    response = (policyResult.Outcome == OutcomeType.Successful) ?
                        policyResult.Result : new HttpResponseMessage()
                        {
                            ReasonPhrase = policyResult.FinalException.ToString(),
                            RequestMessage = req
                        };
                }
                else
                {
                    response = await _httpClient.SendAsync(req, finalToken).ConfigureAwait(false);
                }

                if (!response.IsSuccessStatusCode)
                {
                    return await ToApiResponse<T>(response, default(T), req.RequestUri).ConfigureAwait(false);
                }

                object responseData = await deserializer.Deserialize<T>(response).ConfigureAwait(false);

                // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
                if (typeof(NuvemFiscal.Sdk.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
                {
                    responseData = (T) typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
                }
                else if (typeof(T).Name == "Stream") // for binary response
                {
                    responseData = (T) (object) await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                }

                InterceptResponse(req, response);

                return await ToApiResponse<T>(response, responseData, req.RequestUri).ConfigureAwait(false);
            }
            catch (OperationCanceledException original)
            {
                if (timeoutTokenSource != null && timeoutTokenSource.IsCancellationRequested)
                {
                    throw new TaskCanceledException($"[{req.Method}] {req.RequestUri} was timeout.",
                        new TimeoutException(original.Message, original));
                }
                throw;
            }
            finally
            {
                if (timeoutTokenSource != null)
                {
                    timeoutTokenSource.Dispose();
                }

                if (finalTokenSource != null)
                {
                    finalTokenSource.Dispose();
                }
            }
        }

        #region IAsynchronousClient
        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PUT request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP DELETE request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP HEAD request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP OPTION request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options, config), config, cancellationToken);
        }

        /// <summary>
        /// Make a HTTP PATCH request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(new HttpMethod("PATCH"), path, options, config), config, cancellationToken);
        }
        #endregion IAsynchronousClient

        #region ISynchronousClient
        /// <summary>
        /// Make a HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Get, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Post, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP PUT request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Put<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Put, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP DELETE request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Delete, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP HEAD request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Head<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Head, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP OPTION request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Options<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Options, path, options, config), config);
        }

        /// <summary>
        /// Make a HTTP PATCH request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Patch<T>(string path, RequestOptions options, IReadableConfiguration configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(new HttpMethod("PATCH"), path, options, config), config);
        }
        #endregion ISynchronousClient
    }
}
