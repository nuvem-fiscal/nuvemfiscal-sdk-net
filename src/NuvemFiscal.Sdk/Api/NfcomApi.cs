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
    public interface INfcomApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlCancelamentoNfcom(string id);

        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlCancelamentoNfcomWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML da NFCom processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlNfcom(string id);

        /// <summary>
        /// Baixar XML da NFCom processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlNfcomWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML da NFCom
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlNfcomNota(string id);

        /// <summary>
        /// Baixar XML da NFCom
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlNfcomNotaWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlNfcomProtocolo(string id);

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlNfcomProtocoloWithHttpInfo(string id);
        /// <summary>
        /// Cancelar uma NFCom autorizada
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DfeCancelamento</returns>
        DfeCancelamento CancelarNfcom(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento));

        /// <summary>
        /// Cancelar uma NFCom autorizada
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        ApiResponse<DfeCancelamento> CancelarNfcomWithHttpInfo(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento));
        /// <summary>
        /// Consultar o cancelamento da NFCom
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>DfeCancelamento</returns>
        DfeCancelamento ConsultarCancelamentoNfcom(string id);

        /// <summary>
        /// Consultar o cancelamento da NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        ApiResponse<DfeCancelamento> ConsultarCancelamentoNfcomWithHttpInfo(string id);
        /// <summary>
        /// Consultar NFCom
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>Dfe</returns>
        Dfe ConsultarNfcom(string id);

        /// <summary>
        /// Consultar NFCom
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of Dfe</returns>
        ApiResponse<Dfe> ConsultarNfcomWithHttpInfo(string id);
        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>DfeSefazStatus</returns>
        DfeSefazStatus ConsultarStatusSefazNfcom(string cpfCnpj, string autorizador = default(string));

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>ApiResponse of DfeSefazStatus</returns>
        ApiResponse<DfeSefazStatus> ConsultarStatusSefazNfcomWithHttpInfo(string cpfCnpj, string autorizador = default(string));
        /// <summary>
        /// Emitir NFCom
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Dfe</returns>
        Dfe EmitirNfcom(NfcomPedidoEmissao body);

        /// <summary>
        /// Emitir NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Dfe</returns>
        ApiResponse<Dfe> EmitirNfcomWithHttpInfo(NfcomPedidoEmissao body);
        /// <summary>
        /// Listar NFCom
        /// </summary>
        /// <remarks>
        /// Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <returns>DfeListagem</returns>
        DfeListagem ListarNfcom(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string));

        /// <summary>
        /// Listar NFCom
        /// </summary>
        /// <remarks>
        /// Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <returns>ApiResponse of DfeListagem</returns>
        ApiResponse<DfeListagem> ListarNfcomWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INfcomApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlCancelamentoNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlCancelamentoNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML da NFCom processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML da NFCom processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML da NFCom
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlNfcomNotaAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML da NFCom
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlNfcomNotaWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlNfcomProtocoloAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlNfcomProtocoloWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancelar uma NFCom autorizada
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        System.Threading.Tasks.Task<DfeCancelamento> CancelarNfcomAsync(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancelar uma NFCom autorizada
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeCancelamento>> CancelarNfcomWithHttpInfoAsync(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar o cancelamento da NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        System.Threading.Tasks.Task<DfeCancelamento> ConsultarCancelamentoNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar o cancelamento da NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeCancelamento>> ConsultarCancelamentoNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar NFCom
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        System.Threading.Tasks.Task<Dfe> ConsultarNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar NFCom
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dfe>> ConsultarNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeSefazStatus</returns>
        System.Threading.Tasks.Task<DfeSefazStatus> ConsultarStatusSefazNfcomAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeSefazStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeSefazStatus>> ConsultarStatusSefazNfcomWithHttpInfoAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Emitir NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        System.Threading.Tasks.Task<Dfe> EmitirNfcomAsync(NfcomPedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Emitir NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dfe>> EmitirNfcomWithHttpInfoAsync(NfcomPedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar NFCom
        /// </summary>
        /// <remarks>
        /// Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeListagem</returns>
        System.Threading.Tasks.Task<DfeListagem> ListarNfcomAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar NFCom
        /// </summary>
        /// <remarks>
        /// Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeListagem)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeListagem>> ListarNfcomWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INfcomApi : INfcomApiSync, INfcomApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NfcomApi : IDisposable, INfcomApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public NfcomApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public NfcomApi(string basePath)
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
        /// Initializes a new instance of the <see cref="NfcomApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public NfcomApi(NuvemFiscal.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="NfcomApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public NfcomApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomApi"/> class.
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
        public NfcomApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="NfcomApi"/> class using Configuration object.
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
        public NfcomApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="NfcomApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public NfcomApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
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
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlCancelamentoNfcom(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlCancelamentoNfcomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlCancelamentoNfcomWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlCancelamentoNfcom");

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
            var localVarResponse = this.Client.Get<FileParameter>("/nfcom/{id}/cancelamento/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCancelamentoNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlCancelamentoNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlCancelamentoNfcomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlCancelamentoNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlCancelamentoNfcom");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/nfcom/{id}/cancelamento/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCancelamentoNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da NFCom processada Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlNfcom(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlNfcomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da NFCom processada Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlNfcomWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlNfcom");

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
            var localVarResponse = this.Client.Get<FileParameter>("/nfcom/{id}/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da NFCom processada Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlNfcomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da NFCom processada Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;nfcomProc&#x60;).    O XML só estará disponível nesse endpoint caso a nota tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /nfcom/{id}/xml/nota&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlNfcom");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/nfcom/{id}/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da NFCom Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlNfcomNota(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlNfcomNotaWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da NFCom Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlNfcomNotaWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlNfcomNota");

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
            var localVarResponse = this.Client.Get<FileParameter>("/nfcom/{id}/xml/nota", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlNfcomNota", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da NFCom Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlNfcomNotaAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlNfcomNotaWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da NFCom Utilize esse endpoint para obter o XML da nota enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a nota tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlNfcomNotaWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlNfcomNota");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/nfcom/{id}/xml/nota", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlNfcomNota", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlNfcomProtocolo(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlNfcomProtocoloWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlNfcomProtocoloWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlNfcomProtocolo");

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
            var localVarResponse = this.Client.Get<FileParameter>("/nfcom/{id}/xml/protocolo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlNfcomProtocolo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlNfcomProtocoloAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlNfcomProtocoloWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlNfcomProtocoloWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->BaixarXmlNfcomProtocolo");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/nfcom/{id}/xml/protocolo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlNfcomProtocolo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancelar uma NFCom autorizada 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DfeCancelamento</returns>
        public DfeCancelamento CancelarNfcom(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = CancelarNfcomWithHttpInfo(id, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar uma NFCom autorizada 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> CancelarNfcomWithHttpInfo(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->CancelarNfcom");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = body;

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
            var localVarResponse = this.Client.Post<DfeCancelamento>("/nfcom/{id}/cancelamento", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelarNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancelar uma NFCom autorizada 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        public async System.Threading.Tasks.Task<DfeCancelamento> CancelarNfcomAsync(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = await CancelarNfcomWithHttpInfoAsync(id, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar uma NFCom autorizada 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento>> CancelarNfcomWithHttpInfoAsync(string id, NfcomPedidoCancelamento body = default(NfcomPedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->CancelarNfcom");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = body;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<DfeCancelamento>("/nfcom/{id}/cancelamento", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelarNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar o cancelamento da NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>DfeCancelamento</returns>
        public DfeCancelamento ConsultarCancelamentoNfcom(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = ConsultarCancelamentoNfcomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar o cancelamento da NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> ConsultarCancelamentoNfcomWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->ConsultarCancelamentoNfcom");

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
            var localVarResponse = this.Client.Get<DfeCancelamento>("/nfcom/{id}/cancelamento", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCancelamentoNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar o cancelamento da NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        public async System.Threading.Tasks.Task<DfeCancelamento> ConsultarCancelamentoNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = await ConsultarCancelamentoNfcomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar o cancelamento da NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento>> ConsultarCancelamentoNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->ConsultarCancelamentoNfcom");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeCancelamento>("/nfcom/{id}/cancelamento", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCancelamentoNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar NFCom Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>Dfe</returns>
        public Dfe ConsultarNfcom(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = ConsultarNfcomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar NFCom Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of Dfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Dfe> ConsultarNfcomWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->ConsultarNfcom");

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
            var localVarResponse = this.Client.Get<Dfe>("/nfcom/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar NFCom Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        public async System.Threading.Tasks.Task<Dfe> ConsultarNfcomAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = await ConsultarNfcomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar NFCom Consulta os detalhes de uma NFCom já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de NFCom e a Nuvem Fiscal irá retornar as informações da NFCom correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da NFCom gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Dfe>> ConsultarNfcomWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling NfcomApi->ConsultarNfcom");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dfe>("/nfcom/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>DfeSefazStatus</returns>
        public DfeSefazStatus ConsultarStatusSefazNfcom(string cpfCnpj, string autorizador = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> localVarResponse = ConsultarStatusSefazNfcomWithHttpInfo(cpfCnpj, autorizador);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>ApiResponse of DfeSefazStatus</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> ConsultarStatusSefazNfcomWithHttpInfo(string cpfCnpj, string autorizador = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling NfcomApi->ConsultarStatusSefazNfcom");

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

            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (autorizador != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "autorizador", autorizador));
            }

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
            var localVarResponse = this.Client.Get<DfeSefazStatus>("/nfcom/sefaz/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarStatusSefazNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeSefazStatus</returns>
        public async System.Threading.Tasks.Task<DfeSefazStatus> ConsultarStatusSefazNfcomAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> localVarResponse = await ConsultarStatusSefazNfcomWithHttpInfoAsync(cpfCnpj, autorizador, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;SVRS&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeSefazStatus)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus>> ConsultarStatusSefazNfcomWithHttpInfoAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling NfcomApi->ConsultarStatusSefazNfcom");


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

            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (autorizador != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "autorizador", autorizador));
            }

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeSefazStatus>("/nfcom/sefaz/status", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarStatusSefazNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Dfe</returns>
        public Dfe EmitirNfcom(NfcomPedidoEmissao body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = EmitirNfcomWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Dfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Dfe> EmitirNfcomWithHttpInfo(NfcomPedidoEmissao body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling NfcomApi->EmitirNfcom");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

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
            var localVarResponse = this.Client.Post<Dfe>("/nfcom", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        public async System.Threading.Tasks.Task<Dfe> EmitirNfcomAsync(NfcomPedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = await EmitirNfcomWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Dfe>> EmitirNfcomWithHttpInfoAsync(NfcomPedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling NfcomApi->EmitirNfcom");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Dfe>("/nfcom", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar NFCom Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <returns>DfeListagem</returns>
        public DfeListagem ListarNfcom(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> localVarResponse = ListarNfcomWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave, serie);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar NFCom Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <returns>ApiResponse of DfeListagem</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> ListarNfcomWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling NfcomApi->ListarNfcom");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling NfcomApi->ListarNfcom");

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
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (referencia != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "referencia", referencia));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "ambiente", ambiente));
            if (chave != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "chave", chave));
            }
            if (serie != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "serie", serie));
            }

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
            var localVarResponse = this.Client.Get<DfeListagem>("/nfcom", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar NFCom Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeListagem</returns>
        public async System.Threading.Tasks.Task<DfeListagem> ListarNfcomAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> localVarResponse = await ListarNfcomWithHttpInfoAsync(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave, serie, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar NFCom Retorna a lista de NFCom de acordo com os critérios de busca utilizados. As NFCom são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.    Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="referencia">Seu identificador único para o documento. (optional)</param>
        /// <param name="chave">Chave de acesso do DF-e. (optional)</param>
        /// <param name="serie">Série do DF-e. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeListagem)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem>> ListarNfcomWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling NfcomApi->ListarNfcom");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling NfcomApi->ListarNfcom");


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
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (referencia != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "referencia", referencia));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "ambiente", ambiente));
            if (chave != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "chave", chave));
            }
            if (serie != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "serie", serie));
            }

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeListagem>("/nfcom", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
