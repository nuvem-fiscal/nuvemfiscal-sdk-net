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
    public interface IDceApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Baixar PDF do DACE
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarPdfDce(string id);

        /// <summary>
        /// Baixar PDF do DACE
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarPdfDceWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlCancelamentoDce(string id);

        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlCancelamentoDceWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML da DC-e processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlDce(string id);

        /// <summary>
        /// Baixar XML da DC-e processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlDceWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML da DC-e
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlDceDeclaracao(string id);

        /// <summary>
        /// Baixar XML da DC-e
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlDceDeclaracaoWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlDceProtocolo(string id);

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlDceProtocoloWithHttpInfo(string id);
        /// <summary>
        /// Cancelar uma DC-e autorizada
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DfeCancelamento</returns>
        DfeCancelamento CancelarDce(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento));

        /// <summary>
        /// Cancelar uma DC-e autorizada
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        ApiResponse<DfeCancelamento> CancelarDceWithHttpInfo(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento));
        /// <summary>
        /// Consultar o cancelamento da DC-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>DfeCancelamento</returns>
        DfeCancelamento ConsultarCancelamentoDce(string id);

        /// <summary>
        /// Consultar o cancelamento da DC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        ApiResponse<DfeCancelamento> ConsultarCancelamentoDceWithHttpInfo(string id);
        /// <summary>
        /// Consultar DC-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>Dfe</returns>
        Dfe ConsultarDce(string id);

        /// <summary>
        /// Consultar DC-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of Dfe</returns>
        ApiResponse<Dfe> ConsultarDceWithHttpInfo(string id);
        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>DfeSefazStatus</returns>
        DfeSefazStatus ConsultarStatusSefazDce(string cpfCnpj, string autorizador = default(string));

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>ApiResponse of DfeSefazStatus</returns>
        ApiResponse<DfeSefazStatus> ConsultarStatusSefazDceWithHttpInfo(string cpfCnpj, string autorizador = default(string));
        /// <summary>
        /// Emitir DC-e
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Dfe</returns>
        Dfe EmitirDce(DcePedidoEmissao body);

        /// <summary>
        /// Emitir DC-e
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Dfe</returns>
        ApiResponse<Dfe> EmitirDceWithHttpInfo(DcePedidoEmissao body);
        /// <summary>
        /// Listar DC-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        DfeListagem ListarDce(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string));

        /// <summary>
        /// Listar DC-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        ApiResponse<DfeListagem> ListarDceWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDceApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Baixar PDF do DACE
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarPdfDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar PDF do DACE
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarPdfDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlCancelamentoDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlCancelamentoDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML da DC-e processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML da DC-e processada
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML da DC-e
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlDceDeclaracaoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML da DC-e
        /// </summary>
        /// <remarks>
        /// Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlDceDeclaracaoWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlDceProtocoloAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlDceProtocoloWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancelar uma DC-e autorizada
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        System.Threading.Tasks.Task<DfeCancelamento> CancelarDceAsync(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancelar uma DC-e autorizada
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeCancelamento>> CancelarDceWithHttpInfoAsync(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar o cancelamento da DC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        System.Threading.Tasks.Task<DfeCancelamento> ConsultarCancelamentoDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar o cancelamento da DC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeCancelamento>> ConsultarCancelamentoDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar DC-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        System.Threading.Tasks.Task<Dfe> ConsultarDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar DC-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dfe>> ConsultarDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeSefazStatus</returns>
        System.Threading.Tasks.Task<DfeSefazStatus> ConsultarStatusSefazDceAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeSefazStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeSefazStatus>> ConsultarStatusSefazDceWithHttpInfoAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Emitir DC-e
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        System.Threading.Tasks.Task<Dfe> EmitirDceAsync(DcePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Emitir DC-e
        /// </summary>
        /// <remarks>
        /// **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dfe>> EmitirDceWithHttpInfoAsync(DcePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar DC-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        System.Threading.Tasks.Task<DfeListagem> ListarDceAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar DC-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        System.Threading.Tasks.Task<ApiResponse<DfeListagem>> ListarDceWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDceApi : IDceApiSync, IDceApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DceApi : IDisposable, IDceApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DceApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public DceApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DceApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public DceApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DceApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public DceApi(NuvemFiscal.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DceApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public DceApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DceApi"/> class.
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
        public DceApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="DceApi"/> class using Configuration object.
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
        public DceApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="DceApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public DceApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
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
        /// Baixar PDF do DACE 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarPdfDce(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarPdfDceWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar PDF do DACE 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarPdfDceWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarPdfDce");

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
            var localVarResponse = this.Client.Get<FileParameter>("/dce/{id}/pdf", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarPdfDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar PDF do DACE 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarPdfDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarPdfDceWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar PDF do DACE 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarPdfDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarPdfDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/dce/{id}/pdf", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarPdfDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlCancelamentoDce(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlCancelamentoDceWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlCancelamentoDceWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlCancelamentoDce");

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
            var localVarResponse = this.Client.Get<FileParameter>("/dce/{id}/cancelamento/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCancelamentoDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlCancelamentoDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlCancelamentoDceWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlCancelamentoDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlCancelamentoDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/dce/{id}/cancelamento/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCancelamentoDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da DC-e processada Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlDce(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlDceWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da DC-e processada Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlDceWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlDce");

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
            var localVarResponse = this.Client.Get<FileParameter>("/dce/{id}/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da DC-e processada Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlDceWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da DC-e processada Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ, complementado com a informação do protocolo de autorização de uso (TAG raiz &#x60;dceProc&#x60;).    O XML só estará disponível nesse endpoint caso a DC-e tenha sido autorizada pela SEFAZ. Para obter o XML nos demais casos, utilize o endpoint &#x60;GET /dce/{id}/xml/declaracao&#x60;.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/dce/{id}/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da DC-e Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlDceDeclaracao(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlDceDeclaracaoWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da DC-e Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlDceDeclaracaoWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlDceDeclaracao");

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
            var localVarResponse = this.Client.Get<FileParameter>("/dce/{id}/xml/declaracao", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlDceDeclaracao", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da DC-e Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlDceDeclaracaoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlDceDeclaracaoWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da DC-e Utilize esse endpoint para obter o XML da DC-e enviada para a SEFAZ.    O XML estará disponível nesse endpoint mesmo em casos que a declaração tenha sido rejeitada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlDceDeclaracaoWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlDceDeclaracao");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/dce/{id}/xml/declaracao", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlDceDeclaracao", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlDceProtocolo(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlDceProtocoloWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlDceProtocoloWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlDceProtocolo");

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
            var localVarResponse = this.Client.Get<FileParameter>("/dce/{id}/xml/protocolo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlDceProtocolo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlDceProtocoloAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlDceProtocoloWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do Protocolo da SEFAZ 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlDceProtocoloWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->BaixarXmlDceProtocolo");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/dce/{id}/xml/protocolo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlDceProtocolo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancelar uma DC-e autorizada **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DfeCancelamento</returns>
        public DfeCancelamento CancelarDce(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = CancelarDceWithHttpInfo(id, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar uma DC-e autorizada **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> CancelarDceWithHttpInfo(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->CancelarDce");

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
            var localVarResponse = this.Client.Post<DfeCancelamento>("/dce/{id}/cancelamento", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelarDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancelar uma DC-e autorizada **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        public async System.Threading.Tasks.Task<DfeCancelamento> CancelarDceAsync(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = await CancelarDceWithHttpInfoAsync(id, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar uma DC-e autorizada **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="body"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento>> CancelarDceWithHttpInfoAsync(string id, DcePedidoCancelamento body = default(DcePedidoCancelamento), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->CancelarDce");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<DfeCancelamento>("/dce/{id}/cancelamento", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelarDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar o cancelamento da DC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>DfeCancelamento</returns>
        public DfeCancelamento ConsultarCancelamentoDce(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = ConsultarCancelamentoDceWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar o cancelamento da DC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> ConsultarCancelamentoDceWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->ConsultarCancelamentoDce");

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
            var localVarResponse = this.Client.Get<DfeCancelamento>("/dce/{id}/cancelamento", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCancelamentoDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar o cancelamento da DC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        public async System.Threading.Tasks.Task<DfeCancelamento> ConsultarCancelamentoDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = await ConsultarCancelamentoDceWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar o cancelamento da DC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento>> ConsultarCancelamentoDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->ConsultarCancelamentoDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeCancelamento>("/dce/{id}/cancelamento", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCancelamentoDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar DC-e Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>Dfe</returns>
        public Dfe ConsultarDce(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = ConsultarDceWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar DC-e Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of Dfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Dfe> ConsultarDceWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->ConsultarDce");

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
            var localVarResponse = this.Client.Get<Dfe>("/dce/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar DC-e Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        public async System.Threading.Tasks.Task<Dfe> ConsultarDceAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = await ConsultarDceWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar DC-e Consulta os detalhes de uma DC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de DC-e e a Nuvem Fiscal irá retornar as informações da DC-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único da DC-e gerada pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Dfe>> ConsultarDceWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling DceApi->ConsultarDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dfe>("/dce/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>DfeSefazStatus</returns>
        public DfeSefazStatus ConsultarStatusSefazDce(string cpfCnpj, string autorizador = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> localVarResponse = ConsultarStatusSefazDceWithHttpInfo(cpfCnpj, autorizador);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <returns>ApiResponse of DfeSefazStatus</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> ConsultarStatusSefazDceWithHttpInfo(string cpfCnpj, string autorizador = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling DceApi->ConsultarStatusSefazDce");

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
            var localVarResponse = this.Client.Get<DfeSefazStatus>("/dce/sefaz/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarStatusSefazDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeSefazStatus</returns>
        public async System.Threading.Tasks.Task<DfeSefazStatus> ConsultarStatusSefazDceAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> localVarResponse = await ConsultarStatusSefazDceWithHttpInfoAsync(cpfCnpj, autorizador, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="autorizador">Ambiente Autorizador.    Autorizadores disponíveis: &#x60;AN&#x60;.    *Caso não seja informado, será utilizado o ambiente autorizador da UF do emitente.* (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeSefazStatus)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus>> ConsultarStatusSefazDceWithHttpInfoAsync(string cpfCnpj, string autorizador = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling DceApi->ConsultarStatusSefazDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeSefazStatus>("/dce/sefaz/status", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarStatusSefazDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir DC-e **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Dfe</returns>
        public Dfe EmitirDce(DcePedidoEmissao body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = EmitirDceWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir DC-e **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Dfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Dfe> EmitirDceWithHttpInfo(DcePedidoEmissao body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling DceApi->EmitirDce");

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
            var localVarResponse = this.Client.Post<Dfe>("/dce", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir DC-e **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        public async System.Threading.Tasks.Task<Dfe> EmitirDceAsync(DcePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = await EmitirDceWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir DC-e **Informações adicionais**:  - Cota: &lt;a href&#x3D;\&quot;/docs/limites#dfe-eventos\&quot;&gt;dfe-eventos&lt;/a&gt;  - Consumo: 1 unidade por requisição.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Dfe>> EmitirDceWithHttpInfoAsync(DcePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling DceApi->EmitirDce");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Dfe>("/dce", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar DC-e Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        public DfeListagem ListarDce(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> localVarResponse = ListarDceWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave, serie);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar DC-e Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> ListarDceWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling DceApi->ListarDce");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling DceApi->ListarDce");

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
            var localVarResponse = this.Client.Get<DfeListagem>("/dce", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar DC-e Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        public async System.Threading.Tasks.Task<DfeListagem> ListarDceAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> localVarResponse = await ListarDceWithHttpInfoAsync(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave, serie, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar DC-e Retorna a lista de DC-e de acordo com os critérios de busca utilizados. As DC-e são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
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
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem>> ListarDceWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string referencia = default(string), string chave = default(string), string serie = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling DceApi->ListarDce");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling DceApi->ListarDce");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeListagem>("/dce", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarDce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
