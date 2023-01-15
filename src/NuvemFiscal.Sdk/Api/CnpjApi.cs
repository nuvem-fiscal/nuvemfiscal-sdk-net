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
    public interface ICnpjApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consultar dados do CNPJ
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <returns>CnpjEmpresa</returns>
        CnpjEmpresa ConsultarCnpj(string cnpj);

        /// <summary>
        /// Consultar dados do CNPJ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <returns>ApiResponse of CnpjEmpresa</returns>
        ApiResponse<CnpjEmpresa> ConsultarCnpjWithHttpInfo(string cnpj);
        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ
        /// </summary>
        /// <remarks>
        /// Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <returns>CnpjListagem</returns>
        CnpjListagem ListarCnpj(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?));

        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ
        /// </summary>
        /// <remarks>
        /// Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <returns>ApiResponse of CnpjListagem</returns>
        ApiResponse<CnpjListagem> ListarCnpjWithHttpInfo(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICnpjApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Consultar dados do CNPJ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CnpjEmpresa</returns>
        System.Threading.Tasks.Task<CnpjEmpresa> ConsultarCnpjAsync(string cnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar dados do CNPJ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CnpjEmpresa)</returns>
        System.Threading.Tasks.Task<ApiResponse<CnpjEmpresa>> ConsultarCnpjWithHttpInfoAsync(string cnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ
        /// </summary>
        /// <remarks>
        /// Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CnpjListagem</returns>
        System.Threading.Tasks.Task<CnpjListagem> ListarCnpjAsync(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ
        /// </summary>
        /// <remarks>
        /// Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CnpjListagem)</returns>
        System.Threading.Tasks.Task<ApiResponse<CnpjListagem>> ListarCnpjWithHttpInfoAsync(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICnpjApi : ICnpjApiSync, ICnpjApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CnpjApi : IDisposable, ICnpjApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public CnpjApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public CnpjApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CnpjApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public CnpjApi(NuvemFiscal.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CnpjApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public CnpjApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjApi"/> class.
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
        public CnpjApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="CnpjApi"/> class using Configuration object.
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
        public CnpjApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="CnpjApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public CnpjApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
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
        /// Consultar dados do CNPJ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <returns>CnpjEmpresa</returns>
        public CnpjEmpresa ConsultarCnpj(string cnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CnpjEmpresa> localVarResponse = ConsultarCnpjWithHttpInfo(cnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar dados do CNPJ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <returns>ApiResponse of CnpjEmpresa</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<CnpjEmpresa> ConsultarCnpjWithHttpInfo(string cnpj)
        {
            // verify the required parameter 'cnpj' is set
            if (cnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cnpj' when calling CnpjApi->ConsultarCnpj");

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

            localVarRequestOptions.PathParameters.Add("Cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<CnpjEmpresa>("/cnpj/{Cnpj}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCnpj", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar dados do CNPJ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CnpjEmpresa</returns>
        public async System.Threading.Tasks.Task<CnpjEmpresa> ConsultarCnpjAsync(string cnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CnpjEmpresa> localVarResponse = await ConsultarCnpjWithHttpInfoAsync(cnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar dados do CNPJ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnpj">CNPJ sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CnpjEmpresa)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<CnpjEmpresa>> ConsultarCnpjWithHttpInfoAsync(string cnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cnpj' is set
            if (cnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cnpj' when calling CnpjApi->ConsultarCnpj");


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

            localVarRequestOptions.PathParameters.Add("Cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CnpjEmpresa>("/cnpj/{Cnpj}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCnpj", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <returns>CnpjListagem</returns>
        public CnpjListagem ListarCnpj(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CnpjListagem> localVarResponse = ListarCnpjWithHttpInfo(cnaePrincipal, municipio, naturezaJuridica, top, skip, inlinecount);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <returns>ApiResponse of CnpjListagem</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<CnpjListagem> ListarCnpjWithHttpInfo(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?))
        {
            // verify the required parameter 'cnaePrincipal' is set
            if (cnaePrincipal == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cnaePrincipal' when calling CnpjApi->ListarCnpj");

            // verify the required parameter 'municipio' is set
            if (municipio == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'municipio' when calling CnpjApi->ListarCnpj");

            // verify the required parameter 'naturezaJuridica' is set
            if (naturezaJuridica == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'naturezaJuridica' when calling CnpjApi->ListarCnpj");

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

            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (inlinecount != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$inlinecount", inlinecount));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cnae_principal", cnaePrincipal));
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "municipio", municipio));
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "natureza_juridica", naturezaJuridica));

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
            var localVarResponse = this.Client.Get<CnpjListagem>("/cnpj", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarCnpj", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CnpjListagem</returns>
        public async System.Threading.Tasks.Task<CnpjListagem> ListarCnpjAsync(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CnpjListagem> localVarResponse = await ListarCnpjWithHttpInfoAsync(cnaePrincipal, municipio, naturezaJuridica, top, skip, inlinecount, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar estabelecimentos ativos a partir da base de CNPJ Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \&quot;Ativa\&quot;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cnaePrincipal">Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="municipio">Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.</param>
        /// <param name="naturezaJuridica">Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CnpjListagem)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<CnpjListagem>> ListarCnpjWithHttpInfoAsync(string cnaePrincipal, string municipio, string naturezaJuridica, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cnaePrincipal' is set
            if (cnaePrincipal == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cnaePrincipal' when calling CnpjApi->ListarCnpj");

            // verify the required parameter 'municipio' is set
            if (municipio == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'municipio' when calling CnpjApi->ListarCnpj");

            // verify the required parameter 'naturezaJuridica' is set
            if (naturezaJuridica == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'naturezaJuridica' when calling CnpjApi->ListarCnpj");


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

            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (inlinecount != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$inlinecount", inlinecount));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cnae_principal", cnaePrincipal));
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "municipio", municipio));
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "natureza_juridica", naturezaJuridica));

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CnpjListagem>("/cnpj", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarCnpj", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
