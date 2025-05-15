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
    public interface IDebugApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Debug de DF-e
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeDebug</returns>
        DfeDebug DebugDfe(string id);

        /// <summary>
        /// Debug de DF-e
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeDebug</returns>
        ApiResponse<DfeDebug> DebugDfeWithHttpInfo(string id);
        /// <summary>
        /// Payload original recebido
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter DebugDfeOriginalPayload(string id);

        /// <summary>
        /// Payload original recebido
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> DebugDfeOriginalPayloadWithHttpInfo(string id);
        /// <summary>
        /// Corpo da requisição HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>FileParameter</returns>
        FileParameter DebugHttpRequestContent(string id);

        /// <summary>
        /// Corpo da requisição HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> DebugHttpRequestContentWithHttpInfo(string id);
        /// <summary>
        /// Corpo da resposta HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>FileParameter</returns>
        FileParameter DebugHttpResponseContent(string id);

        /// <summary>
        /// Corpo da resposta HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> DebugHttpResponseContentWithHttpInfo(string id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDebugApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Debug de DF-e
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeDebug</returns>
        System.Threading.Tasks.Task<DfeDebug> DebugDfeAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Debug de DF-e
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeDebug)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeDebug>> DebugDfeWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Payload original recebido
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> DebugDfeOriginalPayloadAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Payload original recebido
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> DebugDfeOriginalPayloadWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Corpo da requisição HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> DebugHttpRequestContentAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Corpo da requisição HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> DebugHttpRequestContentWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Corpo da resposta HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> DebugHttpResponseContentAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Corpo da resposta HTTP
        /// </summary>
        /// <remarks>
        /// Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> DebugHttpResponseContentWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDebugApi : IDebugApiSync, IDebugApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DebugApi : IDisposable, IDebugApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public DebugApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public DebugApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DebugApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public DebugApi(NuvemFiscal.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DebugApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public DebugApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugApi"/> class.
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
        public DebugApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="DebugApi"/> class using Configuration object.
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
        public DebugApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="DebugApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public DebugApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
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
        /// Debug de DF-e Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeDebug</returns>
        public DfeDebug DebugDfe(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeDebug> localVarResponse = DebugDfeWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Debug de DF-e Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeDebug</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeDebug> DebugDfeWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugDfe");

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

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = this.Client.Get<DfeDebug>("/debug/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugDfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Debug de DF-e Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeDebug</returns>
        public async System.Threading.Tasks.Task<DfeDebug> DebugDfeAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeDebug> localVarResponse = await DebugDfeWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Debug de DF-e Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeDebug)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeDebug>> DebugDfeWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugDfe");


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

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeDebug>("/debug/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugDfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Payload original recebido Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter DebugDfeOriginalPayload(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = DebugDfeOriginalPayloadWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Payload original recebido Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> DebugDfeOriginalPayloadWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugDfeOriginalPayload");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = this.Client.Get<FileParameter>("/debug/{id}/original-payload", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugDfeOriginalPayload", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Payload original recebido Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> DebugDfeOriginalPayloadAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await DebugDfeOriginalPayloadWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Payload original recebido Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID do documento fiscal gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> DebugDfeOriginalPayloadWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugDfeOriginalPayload");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/debug/{id}/original-payload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugDfeOriginalPayload", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Corpo da requisição HTTP Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>FileParameter</returns>
        public FileParameter DebugHttpRequestContent(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = DebugHttpRequestContentWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Corpo da requisição HTTP Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> DebugHttpRequestContentWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugHttpRequestContent");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = this.Client.Get<FileParameter>("/debug/http-requests/{id}/request-content", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugHttpRequestContent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Corpo da requisição HTTP Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> DebugHttpRequestContentAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await DebugHttpRequestContentWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Corpo da requisição HTTP Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> DebugHttpRequestContentWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugHttpRequestContent");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/debug/http-requests/{id}/request-content", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugHttpRequestContent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Corpo da resposta HTTP Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>FileParameter</returns>
        public FileParameter DebugHttpResponseContent(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = DebugHttpResponseContentWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Corpo da resposta HTTP Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> DebugHttpResponseContentWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugHttpResponseContent");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = this.Client.Get<FileParameter>("/debug/http-requests/{id}/response-content", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugHttpResponseContent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Corpo da resposta HTTP Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> DebugHttpResponseContentAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await DebugHttpResponseContentWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Corpo da resposta HTTP Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da requisição HTTP.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> DebugHttpResponseContentWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DebugApi->DebugHttpResponseContent");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/debug/http-requests/{id}/response-content", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DebugHttpResponseContent", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
