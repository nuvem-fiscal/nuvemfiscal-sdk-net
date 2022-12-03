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
    public interface ICteApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlCancelamentoCte(string id);

        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlCancelamentoCteWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML da carta de correção
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlCartaCorrecaoCte(string id);

        /// <summary>
        /// Baixar XML da carta de correção
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlCartaCorrecaoCteWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML do CT-e processado
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlCte(string id);

        /// <summary>
        /// Baixar XML do CT-e processado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlCteWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML do evento
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlEventoCte(string id);

        /// <summary>
        /// Baixar XML do evento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlEventoCteWithHttpInfo(string id);
        /// <summary>
        /// Baixar XML da inutilização
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarXmlInutilizacaoCte(string id);

        /// <summary>
        /// Baixar XML da inutilização
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarXmlInutilizacaoCteWithHttpInfo(string id);
        /// <summary>
        /// Cancelar um CT-e autorizado
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>DfeCancelamento</returns>
        DfeCancelamento CancelarCte(string id, CtePedidoCancelamento body);

        /// <summary>
        /// Cancelar um CT-e autorizado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        ApiResponse<DfeCancelamento> CancelarCteWithHttpInfo(string id, CtePedidoCancelamento body);
        /// <summary>
        /// Consultar o cancelamento do CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeCancelamento</returns>
        DfeCancelamento ConsultarCancelamentoCte(string id);

        /// <summary>
        /// Consultar o cancelamento do CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        ApiResponse<DfeCancelamento> ConsultarCancelamentoCteWithHttpInfo(string id);
        /// <summary>
        /// Consultar a solicitação de correção do CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>CteCartaCorrecao</returns>
        CteCartaCorrecao ConsultarCartaCorrecaoCte(string id);

        /// <summary>
        /// Consultar a solicitação de correção do CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of CteCartaCorrecao</returns>
        ApiResponse<CteCartaCorrecao> ConsultarCartaCorrecaoCteWithHttpInfo(string id);
        /// <summary>
        /// Consultar CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>Dfe</returns>
        Dfe ConsultarCte(string id);

        /// <summary>
        /// Consultar CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of Dfe</returns>
        ApiResponse<Dfe> ConsultarCteWithHttpInfo(string id);
        /// <summary>
        /// Consultar evento
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeEvento</returns>
        DfeEvento ConsultarEventoCte(string id);

        /// <summary>
        /// Consultar evento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeEvento</returns>
        ApiResponse<DfeEvento> ConsultarEventoCteWithHttpInfo(string id);
        /// <summary>
        /// Consultar a inutilização de sequência de numeração
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeInutilizacao</returns>
        DfeInutilizacao ConsultarInutilizacaoCte(string id);

        /// <summary>
        /// Consultar a inutilização de sequência de numeração
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeInutilizacao</returns>
        ApiResponse<DfeInutilizacao> ConsultarInutilizacaoCteWithHttpInfo(string id);
        /// <summary>
        /// Consultar lote de CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeLote</returns>
        DfeLote ConsultarLoteCte(string id);

        /// <summary>
        /// Consultar lote de CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeLote</returns>
        ApiResponse<DfeLote> ConsultarLoteCteWithHttpInfo(string id);
        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <returns>DfeSefazStatus</returns>
        DfeSefazStatus ConsultarStatusSefazCte(string cpfCnpj);

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of DfeSefazStatus</returns>
        ApiResponse<DfeSefazStatus> ConsultarStatusSefazCteWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Solicitar correção do CT-e
        /// </summary>
        /// <remarks>
        /// É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>CteCartaCorrecao</returns>
        CteCartaCorrecao CriarCartaCorrecaoCte(string id, CtePedidoCartaCorrecao body);

        /// <summary>
        /// Solicitar correção do CT-e
        /// </summary>
        /// <remarks>
        /// É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of CteCartaCorrecao</returns>
        ApiResponse<CteCartaCorrecao> CriarCartaCorrecaoCteWithHttpInfo(string id, CtePedidoCartaCorrecao body);
        /// <summary>
        /// Emitir CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Dfe</returns>
        Dfe EmitirCte(CtePedidoEmissao body);

        /// <summary>
        /// Emitir CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Dfe</returns>
        ApiResponse<Dfe> EmitirCteWithHttpInfo(CtePedidoEmissao body);
        /// <summary>
        /// Emitir lote de CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DfeLote</returns>
        DfeLote EmitirLoteCte(CtePedidoEmissaoLote body);

        /// <summary>
        /// Emitir lote de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DfeLote</returns>
        ApiResponse<DfeLote> EmitirLoteCteWithHttpInfo(CtePedidoEmissaoLote body);
        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DfeInutilizacao</returns>
        DfeInutilizacao InutilizarCte(DfePedidoInutilizacao body);

        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DfeInutilizacao</returns>
        ApiResponse<DfeInutilizacao> InutilizarCteWithHttpInfo(DfePedidoInutilizacao body);
        /// <summary>
        /// Listar CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>DfeListagem</returns>
        DfeListagem ListarCte(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string));

        /// <summary>
        /// Listar CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>ApiResponse of DfeListagem</returns>
        ApiResponse<DfeListagem> ListarCteWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string));
        /// <summary>
        /// Listar lotes de CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>DfeLoteListagem</returns>
        DfeLoteListagem ListarLotesCte(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string));

        /// <summary>
        /// Listar lotes de CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>ApiResponse of DfeLoteListagem</returns>
        ApiResponse<DfeLoteListagem> ListarLotesCteWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICteApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlCancelamentoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do cancelamento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlCancelamentoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML da carta de correção
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlCartaCorrecaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML da carta de correção
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlCartaCorrecaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML do CT-e processado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do CT-e processado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML do evento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlEventoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML do evento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlEventoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar XML da inutilização
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarXmlInutilizacaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar XML da inutilização
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarXmlInutilizacaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancelar um CT-e autorizado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        System.Threading.Tasks.Task<DfeCancelamento> CancelarCteAsync(string id, CtePedidoCancelamento body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancelar um CT-e autorizado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeCancelamento>> CancelarCteWithHttpInfoAsync(string id, CtePedidoCancelamento body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar o cancelamento do CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        System.Threading.Tasks.Task<DfeCancelamento> ConsultarCancelamentoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar o cancelamento do CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeCancelamento>> ConsultarCancelamentoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar a solicitação de correção do CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CteCartaCorrecao</returns>
        System.Threading.Tasks.Task<CteCartaCorrecao> ConsultarCartaCorrecaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar a solicitação de correção do CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CteCartaCorrecao)</returns>
        System.Threading.Tasks.Task<ApiResponse<CteCartaCorrecao>> ConsultarCartaCorrecaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        System.Threading.Tasks.Task<Dfe> ConsultarCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dfe>> ConsultarCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar evento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeEvento</returns>
        System.Threading.Tasks.Task<DfeEvento> ConsultarEventoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar evento
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeEvento)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeEvento>> ConsultarEventoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar a inutilização de sequência de numeração
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeInutilizacao</returns>
        System.Threading.Tasks.Task<DfeInutilizacao> ConsultarInutilizacaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar a inutilização de sequência de numeração
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeInutilizacao)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeInutilizacao>> ConsultarInutilizacaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar lote de CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeLote</returns>
        System.Threading.Tasks.Task<DfeLote> ConsultarLoteCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar lote de CT-e
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeLote)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeLote>> ConsultarLoteCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeSefazStatus</returns>
        System.Threading.Tasks.Task<DfeSefazStatus> ConsultarStatusSefazCteAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora
        /// </summary>
        /// <remarks>
        /// Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeSefazStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeSefazStatus>> ConsultarStatusSefazCteWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Solicitar correção do CT-e
        /// </summary>
        /// <remarks>
        /// É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CteCartaCorrecao</returns>
        System.Threading.Tasks.Task<CteCartaCorrecao> CriarCartaCorrecaoCteAsync(string id, CtePedidoCartaCorrecao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Solicitar correção do CT-e
        /// </summary>
        /// <remarks>
        /// É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CteCartaCorrecao)</returns>
        System.Threading.Tasks.Task<ApiResponse<CteCartaCorrecao>> CriarCartaCorrecaoCteWithHttpInfoAsync(string id, CtePedidoCartaCorrecao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Emitir CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        System.Threading.Tasks.Task<Dfe> EmitirCteAsync(CtePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Emitir CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dfe>> EmitirCteWithHttpInfoAsync(CtePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Emitir lote de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeLote</returns>
        System.Threading.Tasks.Task<DfeLote> EmitirLoteCteAsync(CtePedidoEmissaoLote body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Emitir lote de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeLote)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeLote>> EmitirLoteCteWithHttpInfoAsync(CtePedidoEmissaoLote body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeInutilizacao</returns>
        System.Threading.Tasks.Task<DfeInutilizacao> InutilizarCteAsync(DfePedidoInutilizacao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeInutilizacao)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeInutilizacao>> InutilizarCteWithHttpInfoAsync(DfePedidoInutilizacao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeListagem</returns>
        System.Threading.Tasks.Task<DfeListagem> ListarCteAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeListagem)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeListagem>> ListarCteWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar lotes de CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeLoteListagem</returns>
        System.Threading.Tasks.Task<DfeLoteListagem> ListarLotesCteAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar lotes de CT-e
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeLoteListagem)</returns>
        System.Threading.Tasks.Task<ApiResponse<DfeLoteListagem>> ListarLotesCteWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICteApi : ICteApiSync, ICteApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CteApi : IDisposable, ICteApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CteApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public CteApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CteApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public CteApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CteApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public CteApi(NuvemFiscal.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CteApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public CteApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CteApi"/> class.
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
        public CteApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="CteApi"/> class using Configuration object.
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
        public CteApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="CteApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public CteApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
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
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlCancelamentoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlCancelamentoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlCancelamentoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlCancelamentoCte");

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
            var localVarResponse = this.Client.Get<FileParameter>("/cte/{id}/cancelamento/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCancelamentoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlCancelamentoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlCancelamentoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do cancelamento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlCancelamentoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlCancelamentoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/cte/{id}/cancelamento/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCancelamentoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da carta de correção 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlCartaCorrecaoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlCartaCorrecaoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da carta de correção 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlCartaCorrecaoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlCartaCorrecaoCte");

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
            var localVarResponse = this.Client.Get<FileParameter>("/cte/{id}/carta-correcao/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCartaCorrecaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da carta de correção 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlCartaCorrecaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlCartaCorrecaoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da carta de correção 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlCartaCorrecaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlCartaCorrecaoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/cte/{id}/carta-correcao/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCartaCorrecaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do CT-e processado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do CT-e processado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlCte");

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
            var localVarResponse = this.Client.Get<FileParameter>("/cte/{id}/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do CT-e processado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do CT-e processado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/cte/{id}/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlEventoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlEventoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlEventoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlEventoCte");

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
            var localVarResponse = this.Client.Get<FileParameter>("/cte/eventos/{id}/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlEventoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML do evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlEventoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlEventoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML do evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlEventoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlEventoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/cte/eventos/{id}/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlEventoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da inutilização 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarXmlInutilizacaoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarXmlInutilizacaoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da inutilização 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarXmlInutilizacaoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlInutilizacaoCte");

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
            var localVarResponse = this.Client.Get<FileParameter>("/cte/inutilizacoes/{id}/xml", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlInutilizacaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar XML da inutilização 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarXmlInutilizacaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarXmlInutilizacaoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar XML da inutilização 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarXmlInutilizacaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->BaixarXmlInutilizacaoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/cte/inutilizacoes/{id}/xml", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarXmlInutilizacaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancelar um CT-e autorizado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>DfeCancelamento</returns>
        public DfeCancelamento CancelarCte(string id, CtePedidoCancelamento body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = CancelarCteWithHttpInfo(id, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar um CT-e autorizado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> CancelarCteWithHttpInfo(string id, CtePedidoCancelamento body)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->CancelarCte");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->CancelarCte");

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
            var localVarResponse = this.Client.Post<DfeCancelamento>("/cte/{id}/cancelamento", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancelar um CT-e autorizado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        public async System.Threading.Tasks.Task<DfeCancelamento> CancelarCteAsync(string id, CtePedidoCancelamento body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = await CancelarCteWithHttpInfoAsync(id, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar um CT-e autorizado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento>> CancelarCteWithHttpInfoAsync(string id, CtePedidoCancelamento body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->CancelarCte");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->CancelarCte");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<DfeCancelamento>("/cte/{id}/cancelamento", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar o cancelamento do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeCancelamento</returns>
        public DfeCancelamento ConsultarCancelamentoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = ConsultarCancelamentoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar o cancelamento do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeCancelamento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> ConsultarCancelamentoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarCancelamentoCte");

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
            var localVarResponse = this.Client.Get<DfeCancelamento>("/cte/{id}/cancelamento", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCancelamentoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar o cancelamento do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeCancelamento</returns>
        public async System.Threading.Tasks.Task<DfeCancelamento> ConsultarCancelamentoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento> localVarResponse = await ConsultarCancelamentoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar o cancelamento do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeCancelamento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeCancelamento>> ConsultarCancelamentoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarCancelamentoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeCancelamento>("/cte/{id}/cancelamento", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCancelamentoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar a solicitação de correção do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>CteCartaCorrecao</returns>
        public CteCartaCorrecao ConsultarCartaCorrecaoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao> localVarResponse = ConsultarCartaCorrecaoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar a solicitação de correção do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of CteCartaCorrecao</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao> ConsultarCartaCorrecaoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarCartaCorrecaoCte");

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
            var localVarResponse = this.Client.Get<CteCartaCorrecao>("/cte/{id}/carta-correcao", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCartaCorrecaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar a solicitação de correção do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CteCartaCorrecao</returns>
        public async System.Threading.Tasks.Task<CteCartaCorrecao> ConsultarCartaCorrecaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao> localVarResponse = await ConsultarCartaCorrecaoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar a solicitação de correção do CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CteCartaCorrecao)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao>> ConsultarCartaCorrecaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarCartaCorrecaoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CteCartaCorrecao>("/cte/{id}/carta-correcao", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCartaCorrecaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar CT-e Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>Dfe</returns>
        public Dfe ConsultarCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = ConsultarCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar CT-e Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of Dfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Dfe> ConsultarCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarCte");

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
            var localVarResponse = this.Client.Get<Dfe>("/cte/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar CT-e Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        public async System.Threading.Tasks.Task<Dfe> ConsultarCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = await ConsultarCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar CT-e Consulta os detalhes de um CT-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de CT-e e a Nuvem Fiscal irá retornar as informações do CT-e correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Dfe>> ConsultarCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dfe>("/cte/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeEvento</returns>
        public DfeEvento ConsultarEventoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeEvento> localVarResponse = ConsultarEventoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeEvento</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeEvento> ConsultarEventoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarEventoCte");

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
            var localVarResponse = this.Client.Get<DfeEvento>("/cte/eventos/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarEventoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeEvento</returns>
        public async System.Threading.Tasks.Task<DfeEvento> ConsultarEventoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeEvento> localVarResponse = await ConsultarEventoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar evento 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeEvento)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeEvento>> ConsultarEventoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarEventoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeEvento>("/cte/eventos/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarEventoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar a inutilização de sequência de numeração 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeInutilizacao</returns>
        public DfeInutilizacao ConsultarInutilizacaoCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao> localVarResponse = ConsultarInutilizacaoCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar a inutilização de sequência de numeração 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeInutilizacao</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao> ConsultarInutilizacaoCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarInutilizacaoCte");

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
            var localVarResponse = this.Client.Get<DfeInutilizacao>("/cte/inutilizacoes/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarInutilizacaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar a inutilização de sequência de numeração 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeInutilizacao</returns>
        public async System.Threading.Tasks.Task<DfeInutilizacao> ConsultarInutilizacaoCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao> localVarResponse = await ConsultarInutilizacaoCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar a inutilização de sequência de numeração 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do evento gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeInutilizacao)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao>> ConsultarInutilizacaoCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarInutilizacaoCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeInutilizacao>("/cte/inutilizacoes/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarInutilizacaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar lote de CT-e Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <returns>DfeLote</returns>
        public DfeLote ConsultarLoteCte(string id)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeLote> localVarResponse = ConsultarLoteCteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar lote de CT-e Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <returns>ApiResponse of DfeLote</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeLote> ConsultarLoteCteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarLoteCte");

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
            var localVarResponse = this.Client.Get<DfeLote>("/cte/lotes/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarLoteCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar lote de CT-e Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeLote</returns>
        public async System.Threading.Tasks.Task<DfeLote> ConsultarLoteCteAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeLote> localVarResponse = await ConsultarLoteCteWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar lote de CT-e Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do lote gerado pela Nuvem Fiscal.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeLote)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeLote>> ConsultarLoteCteWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->ConsultarLoteCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeLote>("/cte/lotes/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarLoteCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <returns>DfeSefazStatus</returns>
        public DfeSefazStatus ConsultarStatusSefazCte(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> localVarResponse = ConsultarStatusSefazCteWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of DfeSefazStatus</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> ConsultarStatusSefazCteWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling CteApi->ConsultarStatusSefazCte");

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
            var localVarResponse = this.Client.Get<DfeSefazStatus>("/cte/sefaz/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarStatusSefazCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeSefazStatus</returns>
        public async System.Threading.Tasks.Task<DfeSefazStatus> ConsultarStatusSefazCteAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus> localVarResponse = await ConsultarStatusSefazCteWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta do Status do Serviço na SEFAZ Autorizadora Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF/CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeSefazStatus)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeSefazStatus>> ConsultarStatusSefazCteWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling CteApi->ConsultarStatusSefazCte");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeSefazStatus>("/cte/sefaz/status", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarStatusSefazCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Solicitar correção do CT-e É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>CteCartaCorrecao</returns>
        public CteCartaCorrecao CriarCartaCorrecaoCte(string id, CtePedidoCartaCorrecao body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao> localVarResponse = CriarCartaCorrecaoCteWithHttpInfo(id, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Solicitar correção do CT-e É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of CteCartaCorrecao</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao> CriarCartaCorrecaoCteWithHttpInfo(string id, CtePedidoCartaCorrecao body)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->CriarCartaCorrecaoCte");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->CriarCartaCorrecaoCte");

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
            var localVarResponse = this.Client.Post<CteCartaCorrecao>("/cte/{id}/carta-correcao", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CriarCartaCorrecaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Solicitar correção do CT-e É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CteCartaCorrecao</returns>
        public async System.Threading.Tasks.Task<CteCartaCorrecao> CriarCartaCorrecaoCteAsync(string id, CtePedidoCartaCorrecao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao> localVarResponse = await CriarCartaCorrecaoCteWithHttpInfoAsync(id, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Solicitar correção do CT-e É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do CT-e gerado pela Nuvem Fiscal.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CteCartaCorrecao)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<CteCartaCorrecao>> CriarCartaCorrecaoCteWithHttpInfoAsync(string id, CtePedidoCartaCorrecao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling CteApi->CriarCartaCorrecaoCte");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->CriarCartaCorrecaoCte");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<CteCartaCorrecao>("/cte/{id}/carta-correcao", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CriarCartaCorrecaoCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Dfe</returns>
        public Dfe EmitirCte(CtePedidoEmissao body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = EmitirCteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Dfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Dfe> EmitirCteWithHttpInfo(CtePedidoEmissao body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->EmitirCte");

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
            var localVarResponse = this.Client.Post<Dfe>("/cte", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Dfe</returns>
        public async System.Threading.Tasks.Task<Dfe> EmitirCteAsync(CtePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Dfe> localVarResponse = await EmitirCteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Dfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Dfe>> EmitirCteWithHttpInfoAsync(CtePedidoEmissao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->EmitirCte");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Dfe>("/cte", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir lote de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DfeLote</returns>
        public DfeLote EmitirLoteCte(CtePedidoEmissaoLote body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeLote> localVarResponse = EmitirLoteCteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir lote de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DfeLote</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeLote> EmitirLoteCteWithHttpInfo(CtePedidoEmissaoLote body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->EmitirLoteCte");

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
            var localVarResponse = this.Client.Post<DfeLote>("/cte/lotes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirLoteCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Emitir lote de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeLote</returns>
        public async System.Threading.Tasks.Task<DfeLote> EmitirLoteCteAsync(CtePedidoEmissaoLote body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeLote> localVarResponse = await EmitirLoteCteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir lote de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeLote)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeLote>> EmitirLoteCteWithHttpInfoAsync(CtePedidoEmissaoLote body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->EmitirLoteCte");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<DfeLote>("/cte/lotes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EmitirLoteCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DfeInutilizacao</returns>
        public DfeInutilizacao InutilizarCte(DfePedidoInutilizacao body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao> localVarResponse = InutilizarCteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DfeInutilizacao</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao> InutilizarCteWithHttpInfo(DfePedidoInutilizacao body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->InutilizarCte");

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
            var localVarResponse = this.Client.Post<DfeInutilizacao>("/cte/inutilizacoes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InutilizarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeInutilizacao</returns>
        public async System.Threading.Tasks.Task<DfeInutilizacao> InutilizarCteAsync(DfePedidoInutilizacao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao> localVarResponse = await InutilizarCteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Inutilizar uma sequência de numeração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeInutilizacao)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeInutilizacao>> InutilizarCteWithHttpInfoAsync(DfePedidoInutilizacao body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling CteApi->InutilizarCte");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<DfeInutilizacao>("/cte/inutilizacoes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InutilizarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar CT-e Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>DfeListagem</returns>
        public DfeListagem ListarCte(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> localVarResponse = ListarCteWithHttpInfo(cpfCnpj, ambiente, top, skip, referencia);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar CT-e Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>ApiResponse of DfeListagem</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> ListarCteWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling CteApi->ListarCte");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling CteApi->ListarCte");

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
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (referencia != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "referencia", referencia));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "ambiente", ambiente));

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
            var localVarResponse = this.Client.Get<DfeListagem>("/cte", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar CT-e Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeListagem</returns>
        public async System.Threading.Tasks.Task<DfeListagem> ListarCteAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem> localVarResponse = await ListarCteWithHttpInfoAsync(cpfCnpj, ambiente, top, skip, referencia, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar CT-e Retorna a lista de CT-e de acordo com os critérios de busca utilizados. Os CT-e são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeListagem)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeListagem>> ListarCteWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling CteApi->ListarCte");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling CteApi->ListarCte");


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
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (referencia != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "referencia", referencia));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "ambiente", ambiente));

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeListagem>("/cte", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar lotes de CT-e Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>DfeLoteListagem</returns>
        public DfeLoteListagem ListarLotesCte(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeLoteListagem> localVarResponse = ListarLotesCteWithHttpInfo(cpfCnpj, ambiente, top, skip, referencia);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar lotes de CT-e Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <returns>ApiResponse of DfeLoteListagem</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<DfeLoteListagem> ListarLotesCteWithHttpInfo(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling CteApi->ListarLotesCte");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling CteApi->ListarLotesCte");

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
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (referencia != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "referencia", referencia));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "ambiente", ambiente));

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
            var localVarResponse = this.Client.Get<DfeLoteListagem>("/cte/lotes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarLotesCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar lotes de CT-e Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DfeLoteListagem</returns>
        public async System.Threading.Tasks.Task<DfeLoteListagem> ListarLotesCteAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<DfeLoteListagem> localVarResponse = await ListarLotesCteWithHttpInfoAsync(cpfCnpj, ambiente, top, skip, referencia, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar lotes de CT-e Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.</param>
        /// <param name="ambiente">Identificação do Ambiente.  Valores aceitos: homologacao, producao</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100.  Valor padrão: &#x60;10&#x60;. (optional)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)</param>
        /// <param name="referencia"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DfeLoteListagem)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<DfeLoteListagem>> ListarLotesCteWithHttpInfoAsync(string cpfCnpj, string ambiente, int? top = default(int?), int? skip = default(int?), string referencia = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling CteApi->ListarLotesCte");

            // verify the required parameter 'ambiente' is set
            if (ambiente == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'ambiente' when calling CteApi->ListarLotesCte");


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
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (referencia != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "referencia", referencia));
            }
            localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "ambiente", ambiente));

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DfeLoteListagem>("/cte/lotes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarLotesCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
