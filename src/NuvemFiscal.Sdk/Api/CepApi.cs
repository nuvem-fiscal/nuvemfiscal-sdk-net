/*
 * Nuvem Fiscal - SDK para .NET
 * https://www.nuvemfiscal.com.br
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace NuvemFiscal.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICepApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consultar endereço através do CEP
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <returns>CepEndereco</returns>
        CepEndereco ConsultarCep(string cep);

        /// <summary>
        /// Consultar endereço através do CEP
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <returns>ApiResponse of CepEndereco</returns>
        ApiResponse<CepEndereco> ConsultarCepWithHttpInfo(string cep);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICepApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Consultar endereço através do CEP
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CepEndereco</returns>
        System.Threading.Tasks.Task<CepEndereco> ConsultarCepAsync(string cep, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar endereço através do CEP
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CepEndereco)</returns>
        System.Threading.Tasks.Task<ApiResponse<CepEndereco>> ConsultarCepWithHttpInfoAsync(string cep, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICepApi : ICepApiSync, ICepApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CepApi : IDisposable, ICepApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public CepApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public CepApi(string basePath)
        {
            this.Configuration = NuvemFiscal.Sdk.Client.Configuration.MergeConfigurations(
                NuvemFiscal.Sdk.Client.GlobalConfiguration.Instance,
                new NuvemFiscal.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new NuvemFiscal.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = NuvemFiscal.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public CepApi(NuvemFiscal.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = NuvemFiscal.Sdk.Client.Configuration.MergeConfigurations(
                NuvemFiscal.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new NuvemFiscal.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = NuvemFiscal.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public CepApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public CepApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = NuvemFiscal.Sdk.Client.Configuration.MergeConfigurations(
                NuvemFiscal.Sdk.Client.GlobalConfiguration.Instance,
                new NuvemFiscal.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new NuvemFiscal.Sdk.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = NuvemFiscal.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public CepApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = NuvemFiscal.Sdk.Client.Configuration.MergeConfigurations(
                NuvemFiscal.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new NuvemFiscal.Sdk.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = NuvemFiscal.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CepApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public CepApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = NuvemFiscal.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public NuvemFiscal.Sdk.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public NuvemFiscal.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public NuvemFiscal.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public NuvemFiscal.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public NuvemFiscal.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Consultar endereço através do CEP **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <returns>CepEndereco</returns>
        public CepEndereco ConsultarCep(string cep)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CepEndereco> localVarResponse = ConsultarCepWithHttpInfo(cep);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar endereço através do CEP **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <returns>ApiResponse of CepEndereco</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<CepEndereco> ConsultarCepWithHttpInfo(string cep)
        {
            // verify the required parameter 'cep' is set
            if (cep == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cep' when calling CepApi->ConsultarCep");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("Cep", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cep)); // path parameter

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CepEndereco>("/cep/{Cep}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCep", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar endereço através do CEP **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CepEndereco</returns>
        public async System.Threading.Tasks.Task<CepEndereco> ConsultarCepAsync(string cep, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CepEndereco> localVarResponse = await ConsultarCepWithHttpInfoAsync(cep, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar endereço através do CEP **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#cep-consultas\&quot;&gt;cep-consultas&lt;/a&gt;  - Consumo: 1 unidade requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cep">CEP sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CepEndereco)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<CepEndereco>> ConsultarCepWithHttpInfoAsync(string cep, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cep' is set
            if (cep == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cep' when calling CepApi->ConsultarCep");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("Cep", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cep)); // path parameter

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CepEndereco>("/cep/{Cep}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCep", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
