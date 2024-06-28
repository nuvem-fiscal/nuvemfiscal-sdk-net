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
    public interface IEmpresaApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Alterar configuração de CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigCte</returns>
        EmpresaConfigCte AlterarConfigCte(string cpfCnpj, EmpresaConfigCte body);

        /// <summary>
        /// Alterar configuração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigCte</returns>
        ApiResponse<EmpresaConfigCte> AlterarConfigCteWithHttpInfo(string cpfCnpj, EmpresaConfigCte body);
        /// <summary>
        /// Alterar configuração de Distribuição de NF-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigDistribuicaoNfe</returns>
        EmpresaConfigDistribuicaoNfe AlterarConfigDistribuicaoNfe(string cpfCnpj, EmpresaConfigDistribuicaoNfe body);

        /// <summary>
        /// Alterar configuração de Distribuição de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigDistribuicaoNfe</returns>
        ApiResponse<EmpresaConfigDistribuicaoNfe> AlterarConfigDistribuicaoNfeWithHttpInfo(string cpfCnpj, EmpresaConfigDistribuicaoNfe body);
        /// <summary>
        /// Alterar configuração de MDF-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigMdfe</returns>
        EmpresaConfigMdfe AlterarConfigMdfe(string cpfCnpj, EmpresaConfigMdfe body);

        /// <summary>
        /// Alterar configuração de MDF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigMdfe</returns>
        ApiResponse<EmpresaConfigMdfe> AlterarConfigMdfeWithHttpInfo(string cpfCnpj, EmpresaConfigMdfe body);
        /// <summary>
        /// Alterar configuração de NFC-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfce</returns>
        EmpresaConfigNfce AlterarConfigNfce(string cpfCnpj, EmpresaConfigNfce body);

        /// <summary>
        /// Alterar configuração de NFC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfce</returns>
        ApiResponse<EmpresaConfigNfce> AlterarConfigNfceWithHttpInfo(string cpfCnpj, EmpresaConfigNfce body);
        /// <summary>
        /// Alterar configuração de NFCom
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfcom</returns>
        EmpresaConfigNfcom AlterarConfigNfcom(string cpfCnpj, EmpresaConfigNfcom body);

        /// <summary>
        /// Alterar configuração de NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfcom</returns>
        ApiResponse<EmpresaConfigNfcom> AlterarConfigNfcomWithHttpInfo(string cpfCnpj, EmpresaConfigNfcom body);
        /// <summary>
        /// Alterar configuração de NF-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfe</returns>
        EmpresaConfigNfe AlterarConfigNfe(string cpfCnpj, EmpresaConfigNfe body);

        /// <summary>
        /// Alterar configuração de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfe</returns>
        ApiResponse<EmpresaConfigNfe> AlterarConfigNfeWithHttpInfo(string cpfCnpj, EmpresaConfigNfe body);
        /// <summary>
        /// Alterar configuração de NFS-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfse</returns>
        EmpresaConfigNfse AlterarConfigNfse(string cpfCnpj, EmpresaConfigNfse body);

        /// <summary>
        /// Alterar configuração de NFS-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfse</returns>
        ApiResponse<EmpresaConfigNfse> AlterarConfigNfseWithHttpInfo(string cpfCnpj, EmpresaConfigNfse body);
        /// <summary>
        /// Alterar empresa
        /// </summary>
        /// <remarks>
        /// Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>Empresa</returns>
        Empresa AtualizarEmpresa(string cpfCnpj, Empresa body);

        /// <summary>
        /// Alterar empresa
        /// </summary>
        /// <remarks>
        /// Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Empresa</returns>
        ApiResponse<Empresa> AtualizarEmpresaWithHttpInfo(string cpfCnpj, Empresa body);
        /// <summary>
        /// Baixar logotipo
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>FileParameter</returns>
        FileParameter BaixarLogotipoEmpresa(string cpfCnpj);

        /// <summary>
        /// Baixar logotipo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> BaixarLogotipoEmpresaWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Cadastrar certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaCertificado</returns>
        EmpresaCertificado CadastrarCertificadoEmpresa(string cpfCnpj, EmpresaPedidoCadastroCertificado body);

        /// <summary>
        /// Cadastrar certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaCertificado</returns>
        ApiResponse<EmpresaCertificado> CadastrarCertificadoEmpresaWithHttpInfo(string cpfCnpj, EmpresaPedidoCadastroCertificado body);
        /// <summary>
        /// Consultar certificado
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaCertificado</returns>
        EmpresaCertificado ConsultarCertificadoEmpresa(string cpfCnpj);

        /// <summary>
        /// Consultar certificado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaCertificado</returns>
        ApiResponse<EmpresaCertificado> ConsultarCertificadoEmpresaWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de CT-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigCte</returns>
        EmpresaConfigCte ConsultarConfigCte(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigCte</returns>
        ApiResponse<EmpresaConfigCte> ConsultarConfigCteWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de Distribuição de NF-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigDistribuicaoNfe</returns>
        EmpresaConfigDistribuicaoNfe ConsultarConfigDistribuicaoNfe(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de Distribuição de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigDistribuicaoNfe</returns>
        ApiResponse<EmpresaConfigDistribuicaoNfe> ConsultarConfigDistribuicaoNfeWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de MDF-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigMdfe</returns>
        EmpresaConfigMdfe ConsultarConfigMdfe(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de MDF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigMdfe</returns>
        ApiResponse<EmpresaConfigMdfe> ConsultarConfigMdfeWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de NFC-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfce</returns>
        EmpresaConfigNfce ConsultarConfigNfce(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de NFC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfce</returns>
        ApiResponse<EmpresaConfigNfce> ConsultarConfigNfceWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de NFCom
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfcom</returns>
        EmpresaConfigNfcom ConsultarConfigNfcom(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfcom</returns>
        ApiResponse<EmpresaConfigNfcom> ConsultarConfigNfcomWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de NF-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfe</returns>
        EmpresaConfigNfe ConsultarConfigNfe(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfe</returns>
        ApiResponse<EmpresaConfigNfe> ConsultarConfigNfeWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar configuração de NFS-e
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfse</returns>
        EmpresaConfigNfse ConsultarConfigNfse(string cpfCnpj);

        /// <summary>
        /// Consultar configuração de NFS-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfse</returns>
        ApiResponse<EmpresaConfigNfse> ConsultarConfigNfseWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Consultar empresa
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>Empresa</returns>
        Empresa ConsultarEmpresa(string cpfCnpj);

        /// <summary>
        /// Consultar empresa
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Empresa</returns>
        ApiResponse<Empresa> ConsultarEmpresaWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Cadastrar empresa
        /// </summary>
        /// <remarks>
        /// Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Empresa</returns>
        Empresa CriarEmpresa(Empresa body);

        /// <summary>
        /// Cadastrar empresa
        /// </summary>
        /// <remarks>
        /// Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Empresa</returns>
        ApiResponse<Empresa> CriarEmpresaWithHttpInfo(Empresa body);
        /// <summary>
        /// Upload de certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns>EmpresaCertificado</returns>
        EmpresaCertificado EnviarCertificadoEmpresa(string cpfCnpj, FileParameter input = default(FileParameter));

        /// <summary>
        /// Upload de certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns>ApiResponse of EmpresaCertificado</returns>
        ApiResponse<EmpresaCertificado> EnviarCertificadoEmpresaWithHttpInfo(string cpfCnpj, FileParameter input = default(FileParameter));
        /// <summary>
        /// Enviar logotipo
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns></returns>
        void EnviarLogotipoEmpresa(string cpfCnpj, FileParameter input = default(FileParameter));

        /// <summary>
        /// Enviar logotipo
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> EnviarLogotipoEmpresaWithHttpInfo(string cpfCnpj, FileParameter input = default(FileParameter));
        /// <summary>
        /// Deletar certificado
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns></returns>
        void ExcluirCertificadoEmpresa(string cpfCnpj);

        /// <summary>
        /// Deletar certificado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExcluirCertificadoEmpresaWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Deletar empresa
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns></returns>
        void ExcluirEmpresa(string cpfCnpj);

        /// <summary>
        /// Deletar empresa
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExcluirEmpresaWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Deletar logotipo
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns></returns>
        void ExcluirLogotipoEmpresa(string cpfCnpj);

        /// <summary>
        /// Deletar logotipo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExcluirLogotipoEmpresaWithHttpInfo(string cpfCnpj);
        /// <summary>
        /// Listar empresas
        /// </summary>
        /// <remarks>
        /// Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <returns>EmpresaListagem</returns>
        EmpresaListagem ListarEmpresas(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string));

        /// <summary>
        /// Listar empresas
        /// </summary>
        /// <remarks>
        /// Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <returns>ApiResponse of EmpresaListagem</returns>
        ApiResponse<EmpresaListagem> ListarEmpresasWithHttpInfo(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmpresaApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Alterar configuração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigCte</returns>
        System.Threading.Tasks.Task<EmpresaConfigCte> AlterarConfigCteAsync(string cpfCnpj, EmpresaConfigCte body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigCte)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigCte>> AlterarConfigCteWithHttpInfoAsync(string cpfCnpj, EmpresaConfigCte body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar configuração de Distribuição de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigDistribuicaoNfe</returns>
        System.Threading.Tasks.Task<EmpresaConfigDistribuicaoNfe> AlterarConfigDistribuicaoNfeAsync(string cpfCnpj, EmpresaConfigDistribuicaoNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de Distribuição de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigDistribuicaoNfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigDistribuicaoNfe>> AlterarConfigDistribuicaoNfeWithHttpInfoAsync(string cpfCnpj, EmpresaConfigDistribuicaoNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar configuração de MDF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigMdfe</returns>
        System.Threading.Tasks.Task<EmpresaConfigMdfe> AlterarConfigMdfeAsync(string cpfCnpj, EmpresaConfigMdfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de MDF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigMdfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigMdfe>> AlterarConfigMdfeWithHttpInfoAsync(string cpfCnpj, EmpresaConfigMdfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar configuração de NFC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfce</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfce> AlterarConfigNfceAsync(string cpfCnpj, EmpresaConfigNfce body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de NFC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfce)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfce>> AlterarConfigNfceWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfce body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar configuração de NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfcom</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfcom> AlterarConfigNfcomAsync(string cpfCnpj, EmpresaConfigNfcom body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfcom)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfcom>> AlterarConfigNfcomWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfcom body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar configuração de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfe</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfe> AlterarConfigNfeAsync(string cpfCnpj, EmpresaConfigNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfe>> AlterarConfigNfeWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar configuração de NFS-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfse</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfse> AlterarConfigNfseAsync(string cpfCnpj, EmpresaConfigNfse body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar configuração de NFS-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfse>> AlterarConfigNfseWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfse body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Alterar empresa
        /// </summary>
        /// <remarks>
        /// Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Empresa</returns>
        System.Threading.Tasks.Task<Empresa> AtualizarEmpresaAsync(string cpfCnpj, Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Alterar empresa
        /// </summary>
        /// <remarks>
        /// Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Empresa)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empresa>> AtualizarEmpresaWithHttpInfoAsync(string cpfCnpj, Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Baixar logotipo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> BaixarLogotipoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Baixar logotipo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> BaixarLogotipoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cadastrar certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaCertificado</returns>
        System.Threading.Tasks.Task<EmpresaCertificado> CadastrarCertificadoEmpresaAsync(string cpfCnpj, EmpresaPedidoCadastroCertificado body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cadastrar certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaCertificado)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaCertificado>> CadastrarCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, EmpresaPedidoCadastroCertificado body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar certificado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaCertificado</returns>
        System.Threading.Tasks.Task<EmpresaCertificado> ConsultarCertificadoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar certificado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaCertificado)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaCertificado>> ConsultarCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigCte</returns>
        System.Threading.Tasks.Task<EmpresaConfigCte> ConsultarConfigCteAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de CT-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigCte)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigCte>> ConsultarConfigCteWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de Distribuição de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigDistribuicaoNfe</returns>
        System.Threading.Tasks.Task<EmpresaConfigDistribuicaoNfe> ConsultarConfigDistribuicaoNfeAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de Distribuição de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigDistribuicaoNfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigDistribuicaoNfe>> ConsultarConfigDistribuicaoNfeWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de MDF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigMdfe</returns>
        System.Threading.Tasks.Task<EmpresaConfigMdfe> ConsultarConfigMdfeAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de MDF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigMdfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigMdfe>> ConsultarConfigMdfeWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de NFC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfce</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfce> ConsultarConfigNfceAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de NFC-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfce)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfce>> ConsultarConfigNfceWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfcom</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfcom> ConsultarConfigNfcomAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de NFCom
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfcom)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfcom>> ConsultarConfigNfcomWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfe</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfe> ConsultarConfigNfeAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de NF-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfe)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfe>> ConsultarConfigNfeWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar configuração de NFS-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfse</returns>
        System.Threading.Tasks.Task<EmpresaConfigNfse> ConsultarConfigNfseAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar configuração de NFS-e
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaConfigNfse>> ConsultarConfigNfseWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Consultar empresa
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Empresa</returns>
        System.Threading.Tasks.Task<Empresa> ConsultarEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar empresa
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Empresa)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empresa>> ConsultarEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cadastrar empresa
        /// </summary>
        /// <remarks>
        /// Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Empresa</returns>
        System.Threading.Tasks.Task<Empresa> CriarEmpresaAsync(Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cadastrar empresa
        /// </summary>
        /// <remarks>
        /// Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Empresa)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empresa>> CriarEmpresaWithHttpInfoAsync(Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Upload de certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaCertificado</returns>
        System.Threading.Tasks.Task<EmpresaCertificado> EnviarCertificadoEmpresaAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Upload de certificado
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaCertificado)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaCertificado>> EnviarCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Enviar logotipo
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task EnviarLogotipoEmpresaAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Enviar logotipo
        /// </summary>
        /// <remarks>
        /// Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarLogotipoEmpresaWithHttpInfoAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletar certificado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExcluirCertificadoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletar certificado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletar empresa
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExcluirEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletar empresa
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletar logotipo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExcluirLogotipoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletar logotipo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirLogotipoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar empresas
        /// </summary>
        /// <remarks>
        /// Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaListagem</returns>
        System.Threading.Tasks.Task<EmpresaListagem> ListarEmpresasAsync(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar empresas
        /// </summary>
        /// <remarks>
        /// Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </remarks>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaListagem)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmpresaListagem>> ListarEmpresasWithHttpInfoAsync(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmpresaApi : IEmpresaApiSync, IEmpresaApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EmpresaApi : IDisposable, IEmpresaApi
    {
        private NuvemFiscal.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public EmpresaApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public EmpresaApi(string basePath)
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
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public EmpresaApi(NuvemFiscal.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public EmpresaApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class.
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
        public EmpresaApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class using Configuration object.
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
        public EmpresaApi(HttpClient client, NuvemFiscal.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="EmpresaApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public EmpresaApi(NuvemFiscal.Sdk.Client.ISynchronousClient client, NuvemFiscal.Sdk.Client.IAsynchronousClient asyncClient, NuvemFiscal.Sdk.Client.IReadableConfiguration configuration)
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
        /// Alterar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigCte</returns>
        public EmpresaConfigCte AlterarConfigCte(string cpfCnpj, EmpresaConfigCte body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte> localVarResponse = AlterarConfigCteWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigCte</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte> AlterarConfigCteWithHttpInfo(string cpfCnpj, EmpresaConfigCte body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigCte");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigCte");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigCte>("/empresas/{cpf_cnpj}/cte", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigCte</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigCte> AlterarConfigCteAsync(string cpfCnpj, EmpresaConfigCte body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte> localVarResponse = await AlterarConfigCteWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigCte)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte>> AlterarConfigCteWithHttpInfoAsync(string cpfCnpj, EmpresaConfigCte body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigCte");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigCte");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigCte>("/empresas/{cpf_cnpj}/cte", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigDistribuicaoNfe</returns>
        public EmpresaConfigDistribuicaoNfe AlterarConfigDistribuicaoNfe(string cpfCnpj, EmpresaConfigDistribuicaoNfe body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe> localVarResponse = AlterarConfigDistribuicaoNfeWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigDistribuicaoNfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe> AlterarConfigDistribuicaoNfeWithHttpInfo(string cpfCnpj, EmpresaConfigDistribuicaoNfe body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigDistribuicaoNfe");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigDistribuicaoNfe");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigDistribuicaoNfe>("/empresas/{cpf_cnpj}/distnfe", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigDistribuicaoNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigDistribuicaoNfe</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigDistribuicaoNfe> AlterarConfigDistribuicaoNfeAsync(string cpfCnpj, EmpresaConfigDistribuicaoNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe> localVarResponse = await AlterarConfigDistribuicaoNfeWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigDistribuicaoNfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe>> AlterarConfigDistribuicaoNfeWithHttpInfoAsync(string cpfCnpj, EmpresaConfigDistribuicaoNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigDistribuicaoNfe");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigDistribuicaoNfe");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigDistribuicaoNfe>("/empresas/{cpf_cnpj}/distnfe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigDistribuicaoNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigMdfe</returns>
        public EmpresaConfigMdfe AlterarConfigMdfe(string cpfCnpj, EmpresaConfigMdfe body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe> localVarResponse = AlterarConfigMdfeWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigMdfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe> AlterarConfigMdfeWithHttpInfo(string cpfCnpj, EmpresaConfigMdfe body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigMdfe");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigMdfe");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigMdfe>("/empresas/{cpf_cnpj}/mdfe", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigMdfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigMdfe</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigMdfe> AlterarConfigMdfeAsync(string cpfCnpj, EmpresaConfigMdfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe> localVarResponse = await AlterarConfigMdfeWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigMdfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe>> AlterarConfigMdfeWithHttpInfoAsync(string cpfCnpj, EmpresaConfigMdfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigMdfe");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigMdfe");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigMdfe>("/empresas/{cpf_cnpj}/mdfe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigMdfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfce</returns>
        public EmpresaConfigNfce AlterarConfigNfce(string cpfCnpj, EmpresaConfigNfce body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce> localVarResponse = AlterarConfigNfceWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfce</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce> AlterarConfigNfceWithHttpInfo(string cpfCnpj, EmpresaConfigNfce body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfce");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfce");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigNfce>("/empresas/{cpf_cnpj}/nfce", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfce</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfce> AlterarConfigNfceAsync(string cpfCnpj, EmpresaConfigNfce body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce> localVarResponse = await AlterarConfigNfceWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfce)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce>> AlterarConfigNfceWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfce body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfce");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfce");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigNfce>("/empresas/{cpf_cnpj}/nfce", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfcom</returns>
        public EmpresaConfigNfcom AlterarConfigNfcom(string cpfCnpj, EmpresaConfigNfcom body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom> localVarResponse = AlterarConfigNfcomWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfcom</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom> AlterarConfigNfcomWithHttpInfo(string cpfCnpj, EmpresaConfigNfcom body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfcom");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfcom");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigNfcom>("/empresas/{cpf_cnpj}/nfcom", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfcom</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfcom> AlterarConfigNfcomAsync(string cpfCnpj, EmpresaConfigNfcom body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom> localVarResponse = await AlterarConfigNfcomWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfcom)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom>> AlterarConfigNfcomWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfcom body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfcom");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfcom");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigNfcom>("/empresas/{cpf_cnpj}/nfcom", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfe</returns>
        public EmpresaConfigNfe AlterarConfigNfe(string cpfCnpj, EmpresaConfigNfe body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe> localVarResponse = AlterarConfigNfeWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe> AlterarConfigNfeWithHttpInfo(string cpfCnpj, EmpresaConfigNfe body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfe");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfe");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigNfe>("/empresas/{cpf_cnpj}/nfe", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfe</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfe> AlterarConfigNfeAsync(string cpfCnpj, EmpresaConfigNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe> localVarResponse = await AlterarConfigNfeWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe>> AlterarConfigNfeWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfe body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfe");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfe");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigNfe>("/empresas/{cpf_cnpj}/nfe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaConfigNfse</returns>
        public EmpresaConfigNfse AlterarConfigNfse(string cpfCnpj, EmpresaConfigNfse body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse> localVarResponse = AlterarConfigNfseWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaConfigNfse</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse> AlterarConfigNfseWithHttpInfo(string cpfCnpj, EmpresaConfigNfse body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfse");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfse");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaConfigNfse>("/empresas/{cpf_cnpj}/nfse", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfse", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfse</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfse> AlterarConfigNfseAsync(string cpfCnpj, EmpresaConfigNfse body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse> localVarResponse = await AlterarConfigNfseWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfse)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse>> AlterarConfigNfseWithHttpInfoAsync(string cpfCnpj, EmpresaConfigNfse body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AlterarConfigNfse");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AlterarConfigNfse");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaConfigNfse>("/empresas/{cpf_cnpj}/nfse", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AlterarConfigNfse", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar empresa Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>Empresa</returns>
        public Empresa AtualizarEmpresa(string cpfCnpj, Empresa body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Empresa> localVarResponse = AtualizarEmpresaWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar empresa Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Empresa</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Empresa> AtualizarEmpresaWithHttpInfo(string cpfCnpj, Empresa body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AtualizarEmpresa");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AtualizarEmpresa");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<Empresa>("/empresas/{cpf_cnpj}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AtualizarEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Alterar empresa Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Empresa</returns>
        public async System.Threading.Tasks.Task<Empresa> AtualizarEmpresaAsync(string cpfCnpj, Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Empresa> localVarResponse = await AtualizarEmpresaWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar empresa Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Empresa)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Empresa>> AtualizarEmpresaWithHttpInfoAsync(string cpfCnpj, Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->AtualizarEmpresa");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->AtualizarEmpresa");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<Empresa>("/empresas/{cpf_cnpj}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AtualizarEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>FileParameter</returns>
        public FileParameter BaixarLogotipoEmpresa(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = BaixarLogotipoEmpresaWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> BaixarLogotipoEmpresaWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->BaixarLogotipoEmpresa");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<FileParameter>("/empresas/{cpf_cnpj}/logotipo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarLogotipoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Baixar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> BaixarLogotipoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<FileParameter> localVarResponse = await BaixarLogotipoEmpresaWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Baixar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<FileParameter>> BaixarLogotipoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->BaixarLogotipoEmpresa");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/empresas/{cpf_cnpj}/logotipo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BaixarLogotipoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cadastrar certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>EmpresaCertificado</returns>
        public EmpresaCertificado CadastrarCertificadoEmpresa(string cpfCnpj, EmpresaPedidoCadastroCertificado body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> localVarResponse = CadastrarCertificadoEmpresaWithHttpInfo(cpfCnpj, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmpresaCertificado</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> CadastrarCertificadoEmpresaWithHttpInfo(string cpfCnpj, EmpresaPedidoCadastroCertificado body)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->CadastrarCertificadoEmpresa");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->CadastrarCertificadoEmpresa");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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
            var localVarResponse = this.Client.Put<EmpresaCertificado>("/empresas/{cpf_cnpj}/certificado", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CadastrarCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cadastrar certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaCertificado</returns>
        public async System.Threading.Tasks.Task<EmpresaCertificado> CadastrarCertificadoEmpresaAsync(string cpfCnpj, EmpresaPedidoCadastroCertificado body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> localVarResponse = await CadastrarCertificadoEmpresaWithHttpInfoAsync(cpfCnpj, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro &#x60;certificado&#x60;, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaCertificado)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado>> CadastrarCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, EmpresaPedidoCadastroCertificado body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->CadastrarCertificadoEmpresa");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->CadastrarCertificadoEmpresa");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaCertificado>("/empresas/{cpf_cnpj}/certificado", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CadastrarCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaCertificado</returns>
        public EmpresaCertificado ConsultarCertificadoEmpresa(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> localVarResponse = ConsultarCertificadoEmpresaWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaCertificado</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> ConsultarCertificadoEmpresaWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarCertificadoEmpresa");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaCertificado>("/empresas/{cpf_cnpj}/certificado", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaCertificado</returns>
        public async System.Threading.Tasks.Task<EmpresaCertificado> ConsultarCertificadoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> localVarResponse = await ConsultarCertificadoEmpresaWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaCertificado)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado>> ConsultarCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarCertificadoEmpresa");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaCertificado>("/empresas/{cpf_cnpj}/certificado", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigCte</returns>
        public EmpresaConfigCte ConsultarConfigCte(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte> localVarResponse = ConsultarConfigCteWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigCte</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte> ConsultarConfigCteWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigCte");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigCte>("/empresas/{cpf_cnpj}/cte", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigCte</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigCte> ConsultarConfigCteAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte> localVarResponse = await ConsultarConfigCteWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de CT-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigCte)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigCte>> ConsultarConfigCteWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigCte");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigCte>("/empresas/{cpf_cnpj}/cte", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigCte", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigDistribuicaoNfe</returns>
        public EmpresaConfigDistribuicaoNfe ConsultarConfigDistribuicaoNfe(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe> localVarResponse = ConsultarConfigDistribuicaoNfeWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigDistribuicaoNfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe> ConsultarConfigDistribuicaoNfeWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigDistribuicaoNfe");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigDistribuicaoNfe>("/empresas/{cpf_cnpj}/distnfe", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigDistribuicaoNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigDistribuicaoNfe</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigDistribuicaoNfe> ConsultarConfigDistribuicaoNfeAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe> localVarResponse = await ConsultarConfigDistribuicaoNfeWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de Distribuição de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigDistribuicaoNfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigDistribuicaoNfe>> ConsultarConfigDistribuicaoNfeWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigDistribuicaoNfe");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigDistribuicaoNfe>("/empresas/{cpf_cnpj}/distnfe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigDistribuicaoNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigMdfe</returns>
        public EmpresaConfigMdfe ConsultarConfigMdfe(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe> localVarResponse = ConsultarConfigMdfeWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigMdfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe> ConsultarConfigMdfeWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigMdfe");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigMdfe>("/empresas/{cpf_cnpj}/mdfe", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigMdfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigMdfe</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigMdfe> ConsultarConfigMdfeAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe> localVarResponse = await ConsultarConfigMdfeWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de MDF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigMdfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigMdfe>> ConsultarConfigMdfeWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigMdfe");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigMdfe>("/empresas/{cpf_cnpj}/mdfe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigMdfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfce</returns>
        public EmpresaConfigNfce ConsultarConfigNfce(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce> localVarResponse = ConsultarConfigNfceWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfce</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce> ConsultarConfigNfceWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfce");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigNfce>("/empresas/{cpf_cnpj}/nfce", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfce</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfce> ConsultarConfigNfceAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce> localVarResponse = await ConsultarConfigNfceWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NFC-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfce)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfce>> ConsultarConfigNfceWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfce");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigNfce>("/empresas/{cpf_cnpj}/nfce", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfce", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfcom</returns>
        public EmpresaConfigNfcom ConsultarConfigNfcom(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom> localVarResponse = ConsultarConfigNfcomWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfcom</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom> ConsultarConfigNfcomWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfcom");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigNfcom>("/empresas/{cpf_cnpj}/nfcom", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfcom</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfcom> ConsultarConfigNfcomAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom> localVarResponse = await ConsultarConfigNfcomWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NFCom 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfcom)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfcom>> ConsultarConfigNfcomWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfcom");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigNfcom>("/empresas/{cpf_cnpj}/nfcom", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfcom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfe</returns>
        public EmpresaConfigNfe ConsultarConfigNfe(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe> localVarResponse = ConsultarConfigNfeWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfe</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe> ConsultarConfigNfeWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfe");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigNfe>("/empresas/{cpf_cnpj}/nfe", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfe</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfe> ConsultarConfigNfeAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe> localVarResponse = await ConsultarConfigNfeWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NF-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfe)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfe>> ConsultarConfigNfeWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfe");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigNfe>("/empresas/{cpf_cnpj}/nfe", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfe", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>EmpresaConfigNfse</returns>
        public EmpresaConfigNfse ConsultarConfigNfse(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse> localVarResponse = ConsultarConfigNfseWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of EmpresaConfigNfse</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse> ConsultarConfigNfseWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfse");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<EmpresaConfigNfse>("/empresas/{cpf_cnpj}/nfse", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfse", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaConfigNfse</returns>
        public async System.Threading.Tasks.Task<EmpresaConfigNfse> ConsultarConfigNfseAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse> localVarResponse = await ConsultarConfigNfseWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar configuração de NFS-e 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaConfigNfse)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaConfigNfse>> ConsultarConfigNfseWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarConfigNfse");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaConfigNfse>("/empresas/{cpf_cnpj}/nfse", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarConfigNfse", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>Empresa</returns>
        public Empresa ConsultarEmpresa(string cpfCnpj)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Empresa> localVarResponse = ConsultarEmpresaWithHttpInfo(cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Empresa</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Empresa> ConsultarEmpresaWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarEmpresa");

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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Get<Empresa>("/empresas/{cpf_cnpj}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Empresa</returns>
        public async System.Threading.Tasks.Task<Empresa> ConsultarEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Empresa> localVarResponse = await ConsultarEmpresaWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Empresa)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Empresa>> ConsultarEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ConsultarEmpresa");


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

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Empresa>("/empresas/{cpf_cnpj}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cadastrar empresa Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Empresa</returns>
        public Empresa CriarEmpresa(Empresa body)
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Empresa> localVarResponse = CriarEmpresaWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar empresa Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Empresa</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Empresa> CriarEmpresaWithHttpInfo(Empresa body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->CriarEmpresa");

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
            var localVarResponse = this.Client.Post<Empresa>("/empresas", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CriarEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cadastrar empresa Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Empresa</returns>
        public async System.Threading.Tasks.Task<Empresa> CriarEmpresaAsync(Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<Empresa> localVarResponse = await CriarEmpresaWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar empresa Cadastre uma nova empresa (emitente ou prestador) à sua conta.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Empresa)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Empresa>> CriarEmpresaWithHttpInfoAsync(Empresa body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'body' when calling EmpresaApi->CriarEmpresa");


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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Empresa>("/empresas", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CriarEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload de certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns>EmpresaCertificado</returns>
        public EmpresaCertificado EnviarCertificadoEmpresa(string cpfCnpj, FileParameter input = default(FileParameter))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> localVarResponse = EnviarCertificadoEmpresaWithHttpInfo(cpfCnpj, input);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload de certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns>ApiResponse of EmpresaCertificado</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> EnviarCertificadoEmpresaWithHttpInfo(string cpfCnpj, FileParameter input = default(FileParameter))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->EnviarCertificadoEmpresa");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
            if (input != null)
            {
                localVarRequestOptions.FileParameters.Add("Input", input);
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
            var localVarResponse = this.Client.Put<EmpresaCertificado>("/empresas/{cpf_cnpj}/certificado/upload", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EnviarCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload de certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaCertificado</returns>
        public async System.Threading.Tasks.Task<EmpresaCertificado> EnviarCertificadoEmpresaAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado> localVarResponse = await EnviarCertificadoEmpresaWithHttpInfoAsync(cpfCnpj, input, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload de certificado Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o &#x60;content-type&#x60; igual a &#x60;multipart/form-data&#x60;.  * No parâmetro &#x60;file&#x60;, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro &#x60;password&#x60;, envie a senha do certificado.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaCertificado)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaCertificado>> EnviarCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->EnviarCertificadoEmpresa");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
            if (input != null)
            {
                localVarRequestOptions.FileParameters.Add("Input", input);
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmpresaCertificado>("/empresas/{cpf_cnpj}/certificado/upload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EnviarCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enviar logotipo Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns></returns>
        public void EnviarLogotipoEmpresa(string cpfCnpj, FileParameter input = default(FileParameter))
        {
            EnviarLogotipoEmpresaWithHttpInfo(cpfCnpj, input);
        }

        /// <summary>
        /// Enviar logotipo Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Object> EnviarLogotipoEmpresaWithHttpInfo(string cpfCnpj, FileParameter input = default(FileParameter))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->EnviarLogotipoEmpresa");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
            if (input != null)
            {
                localVarRequestOptions.FileParameters.Add("Input", input);
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
            var localVarResponse = this.Client.Put<Object>("/empresas/{cpf_cnpj}/logotipo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EnviarLogotipoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enviar logotipo Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task EnviarLogotipoEmpresaAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await EnviarLogotipoEmpresaWithHttpInfoAsync(cpfCnpj, input, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Enviar logotipo Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: &#x60;image/png&#x60; e &#x60;image/jpeg&#x60;  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="input"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Object>> EnviarLogotipoEmpresaWithHttpInfoAsync(string cpfCnpj, FileParameter input = default(FileParameter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->EnviarLogotipoEmpresa");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter
            if (input != null)
            {
                localVarRequestOptions.FileParameters.Add("Input", input);
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/empresas/{cpf_cnpj}/logotipo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EnviarLogotipoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns></returns>
        public void ExcluirCertificadoEmpresa(string cpfCnpj)
        {
            ExcluirCertificadoEmpresaWithHttpInfo(cpfCnpj);
        }

        /// <summary>
        /// Deletar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Object> ExcluirCertificadoEmpresaWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ExcluirCertificadoEmpresa");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Delete<Object>("/empresas/{cpf_cnpj}/certificado", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExcluirCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExcluirCertificadoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ExcluirCertificadoEmpresaWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletar certificado 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Object>> ExcluirCertificadoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ExcluirCertificadoEmpresa");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/empresas/{cpf_cnpj}/certificado", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExcluirCertificadoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns></returns>
        public void ExcluirEmpresa(string cpfCnpj)
        {
            ExcluirEmpresaWithHttpInfo(cpfCnpj);
        }

        /// <summary>
        /// Deletar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Object> ExcluirEmpresaWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ExcluirEmpresa");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Delete<Object>("/empresas/{cpf_cnpj}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExcluirEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExcluirEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ExcluirEmpresaWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletar empresa 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Object>> ExcluirEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ExcluirEmpresa");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/empresas/{cpf_cnpj}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExcluirEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns></returns>
        public void ExcluirLogotipoEmpresa(string cpfCnpj)
        {
            ExcluirLogotipoEmpresaWithHttpInfo(cpfCnpj);
        }

        /// <summary>
        /// Deletar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<Object> ExcluirLogotipoEmpresaWithHttpInfo(string cpfCnpj)
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ExcluirLogotipoEmpresa");

            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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
            var localVarResponse = this.Client.Delete<Object>("/empresas/{cpf_cnpj}/logotipo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExcluirLogotipoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExcluirLogotipoEmpresaAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ExcluirLogotipoEmpresaWithHttpInfoAsync(cpfCnpj, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletar logotipo 
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<Object>> ExcluirLogotipoEmpresaWithHttpInfoAsync(string cpfCnpj, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new NuvemFiscal.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmpresaApi->ExcluirLogotipoEmpresa");


            NuvemFiscal.Sdk.Client.RequestOptions localVarRequestOptions = new NuvemFiscal.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = NuvemFiscal.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("cpf_cnpj", NuvemFiscal.Sdk.Client.ClientUtils.ParameterToString(cpfCnpj)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/empresas/{cpf_cnpj}/logotipo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExcluirLogotipoEmpresa", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar empresas Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <returns>EmpresaListagem</returns>
        public EmpresaListagem ListarEmpresas(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaListagem> localVarResponse = ListarEmpresasWithHttpInfo(top, skip, inlinecount, cpfCnpj);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar empresas Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <returns>ApiResponse of EmpresaListagem</returns>
        public NuvemFiscal.Sdk.Client.ApiResponse<EmpresaListagem> ListarEmpresasWithHttpInfo(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string))
        {
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
            if (cpfCnpj != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
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
            var localVarResponse = this.Client.Get<EmpresaListagem>("/empresas", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarEmpresas", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar empresas Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmpresaListagem</returns>
        public async System.Threading.Tasks.Task<EmpresaListagem> ListarEmpresasAsync(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NuvemFiscal.Sdk.Client.ApiResponse<EmpresaListagem> localVarResponse = await ListarEmpresasWithHttpInfoAsync(top, skip, inlinecount, cpfCnpj, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar empresas Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.
        /// </summary>
        /// <exception cref="NuvemFiscal.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="cpfCnpj">Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmpresaListagem)</returns>
        public async System.Threading.Tasks.Task<NuvemFiscal.Sdk.Client.ApiResponse<EmpresaListagem>> ListarEmpresasWithHttpInfoAsync(int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), string cpfCnpj = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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
            if (cpfCnpj != null)
            {
                localVarRequestOptions.QueryParameters.Add(NuvemFiscal.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmpresaListagem>("/empresas", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarEmpresas", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
