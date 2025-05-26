# Nuvem Fiscal: SDK para .NET

Biblioteca para uso da API da [Nuvem Fiscal](https://www.nuvemfiscal.com.br) com Microsoft .NET. 
Consultar também a [documentação oficial da Nuvem Fiscal](https://dev.nuvemfiscal.com.br/docs).

- Versão da API: 2.57.0
- Versão do SDK: 2.57.0

<a name="frameworks-supported"></a>
## Frameworks suportadas
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="installation"></a>
## Instalação

O SDK da Nuvem Fiscal para .NET está [disponível no Nuget](https://www.nuget.org/packages/NuvemFiscal.Sdk). 
Para adicionar o SDK ao seu projeto, basta instalar o package `NuvemFiscal.Sdk` utilizando sua ferramenta preferida de gerenciamento de packages do Nuget.

Se preferir instalar a partir do console/terminal:

```
PM> Install-Package NuvemFiscal.Sdk
```

Ou a partir do .NET CLI (cross-platform:

```
dotnet add package NuvemFiscal.Sdk
```

<a name="usage"></a>
## Utilização

Após adicionar o package `NuvemFiscal.Sdk` ao seu projeto C#, use os namespaces:
```csharp
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;
```


### Instanciando a API 
Cada ApiClass (mais especificamente o ApiClient dentro dela) irá criar uma instância de HttpClient, e irá usá-la 
durante todo o ciclo de vida da ApiClass, e fará um dispose quando o método Dispose for chamado.

Para melhor gerenciar as conexões, é uma boa prática reutilizar os objetos HttpClient e HttpClientHandler 
(visite [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) para mais informações). 
Para usar sua própria instância de HttpClient, simplesmente passe-a ao construtor da ApiClass. 
Também é importante **habilitar a descompactação automática para conteúdos gzip**, para ser possível receber XML e PDF (DANFE) via SDK:

```csharp
HttpClientHandler httpClientHandler = new HttpClientHandler();
httpClientHandler.AutomaticDecompression = DecompressionMethods.All;
HttpClient httpClient = new HttpClient(httpClientHandler);
var api = new CepApi(httpClient, httpClientHandler);
```

Caso queira usar o HttpClient e não tiver acesso ao handler (por exemplo, em um contexto DI no Asp.net Core onde esitver usando o IHttpClientFactory):

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new CepApi(yourHttpClient);
```

Você perderá algumas configurações, por exemplo: Setar e obter Cookies, Client Certificates, Proxy settings. 
Você precisará gerenciar isso manualmente no setup do seu HttpClient, caso contrário esses recursos não estarão disponíveis.

Segue um exemplo de setup do DI em um projeto web:

```csharp
services.AddHttpClient<CepApi>(httpClient => new CepApi(httpClient)
  .ConfigurePrimaryHttpMessageHandler(config => new HttpClientHandler
    {
       AutomaticDecompression = DecompressionMethods.All
    });
```


### Uso opcional de proxy

Para usar o client da API com um proxy HTTP, configure um `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Exemplo

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // cria instâncias de HttpClient, HttpClientHandler para serem reutilizadas em qualquer Api
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CepApi(httpClient, config, httpClientHandler);
            var cep = "cep_example";  // string | CEP sem máscara.

            try
            {
                // Consultar endereço através do CEP
                CepEndereco result = apiInstance.ConsultarCep(cep);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Erro ao chamar CepApi.ConsultarCep: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentação dos endpoints

Todas as URIs são relativas a *https://api.nuvemfiscal.com.br*

Classe | Método | Endpoint | Descrição
------------ | ------------- | ------------- | -------------
*CepApi* | [**ConsultarCep**](docs/CepApi.md#consultarcep) | **GET** /cep/{Cep} | Consultar endereço através do CEP
*CnpjApi* | [**ConsultarCnpj**](docs/CnpjApi.md#consultarcnpj) | **GET** /cnpj/{Cnpj} | Consultar dados do CNPJ
*CnpjApi* | [**ListarCnpj**](docs/CnpjApi.md#listarcnpj) | **GET** /cnpj | Listar estabelecimentos ativos a partir da base de CNPJ
*ContaApi* | [**ConsultarCotaConta**](docs/ContaApi.md#consultarcotaconta) | **GET** /conta/cotas/{nome} | Consultar o limite de uso e o consumo de uma cota específica.
*ContaApi* | [**ListarCotasConta**](docs/ContaApi.md#listarcotasconta) | **GET** /conta/cotas | Consultar os limites de uso e consumo de todas as cotas existentes.
*CteApi* | [**BaixarPdfCancelamentoCte**](docs/CteApi.md#baixarpdfcancelamentocte) | **GET** /cte/{id}/cancelamento/pdf | Baixar PDF do cancelamento
*CteApi* | [**BaixarPdfCartaCorrecaoCte**](docs/CteApi.md#baixarpdfcartacorrecaocte) | **GET** /cte/{id}/carta-correcao/pdf | Baixar PDF da carta de correção
*CteApi* | [**BaixarPdfCte**](docs/CteApi.md#baixarpdfcte) | **GET** /cte/{id}/pdf | Baixar PDF do DACTE
*CteApi* | [**BaixarPdfEventoCte**](docs/CteApi.md#baixarpdfeventocte) | **GET** /cte/eventos/{id}/pdf | Baixar PDF do evento
*CteApi* | [**BaixarXmlCancelamentoCte**](docs/CteApi.md#baixarxmlcancelamentocte) | **GET** /cte/{id}/cancelamento/xml | Baixar XML do cancelamento
*CteApi* | [**BaixarXmlCartaCorrecaoCte**](docs/CteApi.md#baixarxmlcartacorrecaocte) | **GET** /cte/{id}/carta-correcao/xml | Baixar XML da carta de correção
*CteApi* | [**BaixarXmlCte**](docs/CteApi.md#baixarxmlcte) | **GET** /cte/{id}/xml | Baixar XML do CT-e processado
*CteApi* | [**BaixarXmlCteConhecimento**](docs/CteApi.md#baixarxmlcteconhecimento) | **GET** /cte/{id}/xml/conhecimento | Baixar XML do CT-e
*CteApi* | [**BaixarXmlCteProtocolo**](docs/CteApi.md#baixarxmlcteprotocolo) | **GET** /cte/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*CteApi* | [**BaixarXmlEventoCte**](docs/CteApi.md#baixarxmleventocte) | **GET** /cte/eventos/{id}/xml | Baixar XML do evento
*CteApi* | [**CancelarCte**](docs/CteApi.md#cancelarcte) | **POST** /cte/{id}/cancelamento | Cancelar um CT-e autorizado
*CteApi* | [**ConsultarCancelamentoCte**](docs/CteApi.md#consultarcancelamentocte) | **GET** /cte/{id}/cancelamento | Consultar o cancelamento do CT-e
*CteApi* | [**ConsultarCartaCorrecaoCte**](docs/CteApi.md#consultarcartacorrecaocte) | **GET** /cte/{id}/carta-correcao | Consultar a solicitação de correção do CT-e
*CteApi* | [**ConsultarCte**](docs/CteApi.md#consultarcte) | **GET** /cte/{id} | Consultar CT-e
*CteApi* | [**ConsultarEventoCte**](docs/CteApi.md#consultareventocte) | **GET** /cte/eventos/{id} | Consultar evento
*CteApi* | [**ConsultarStatusSefazCte**](docs/CteApi.md#consultarstatussefazcte) | **GET** /cte/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*CteApi* | [**CriarCartaCorrecaoCte**](docs/CteApi.md#criarcartacorrecaocte) | **POST** /cte/{id}/carta-correcao | Solicitar correção do CT-e
*CteApi* | [**EmitirCte**](docs/CteApi.md#emitircte) | **POST** /cte | Emitir CT-e
*CteApi* | [**EmitirCteSimp**](docs/CteApi.md#emitirctesimp) | **POST** /cte/simp | Emitir CT-e Simplificado
*CteApi* | [**ListarCte**](docs/CteApi.md#listarcte) | **GET** /cte | Listar CT-e
*CteApi* | [**SincronizarCte**](docs/CteApi.md#sincronizarcte) | **POST** /cte/{id}/sincronizar | Sincroniza dados no CT-e a partir da SEFAZ
*CteOsApi* | [**BaixarPdfCancelamentoCteOs**](docs/CteOsApi.md#baixarpdfcancelamentocteos) | **GET** /cteos/{id}/cancelamento/pdf | Baixar PDF do cancelamento
*CteOsApi* | [**BaixarPdfCartaCorrecaoCteOs**](docs/CteOsApi.md#baixarpdfcartacorrecaocteos) | **GET** /cteos/{id}/carta-correcao/pdf | Baixar PDF da carta de correção
*CteOsApi* | [**BaixarPdfCteOs**](docs/CteOsApi.md#baixarpdfcteos) | **GET** /cteos/{id}/pdf | Baixar PDF do DACTE
*CteOsApi* | [**BaixarPdfEventoCteOs**](docs/CteOsApi.md#baixarpdfeventocteos) | **GET** /cteos/eventos/{id}/pdf | Baixar PDF do evento
*CteOsApi* | [**BaixarXmlCancelamentoCteOs**](docs/CteOsApi.md#baixarxmlcancelamentocteos) | **GET** /cteos/{id}/cancelamento/xml | Baixar XML do cancelamento
*CteOsApi* | [**BaixarXmlCartaCorrecaoCteOs**](docs/CteOsApi.md#baixarxmlcartacorrecaocteos) | **GET** /cteos/{id}/carta-correcao/xml | Baixar XML da carta de correção
*CteOsApi* | [**BaixarXmlCteOs**](docs/CteOsApi.md#baixarxmlcteos) | **GET** /cteos/{id}/xml | Baixar XML do CT-e OS processado
*CteOsApi* | [**BaixarXmlCteOsConhecimento**](docs/CteOsApi.md#baixarxmlcteosconhecimento) | **GET** /cteos/{id}/xml/conhecimento | Baixar XML do CT-e OS
*CteOsApi* | [**BaixarXmlCteOsProtocolo**](docs/CteOsApi.md#baixarxmlcteosprotocolo) | **GET** /cteos/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*CteOsApi* | [**BaixarXmlEventoCteOs**](docs/CteOsApi.md#baixarxmleventocteos) | **GET** /cteos/eventos/{id}/xml | Baixar XML do evento
*CteOsApi* | [**CancelarCteOs**](docs/CteOsApi.md#cancelarcteos) | **POST** /cteos/{id}/cancelamento | Cancelar um CT-e OS autorizado
*CteOsApi* | [**ConsultarCancelamentoCteOs**](docs/CteOsApi.md#consultarcancelamentocteos) | **GET** /cteos/{id}/cancelamento | Consultar o cancelamento do CT-e OS
*CteOsApi* | [**ConsultarCartaCorrecaoCteOs**](docs/CteOsApi.md#consultarcartacorrecaocteos) | **GET** /cteos/{id}/carta-correcao | Consultar a solicitação de correção do CT-e OS
*CteOsApi* | [**ConsultarCteOs**](docs/CteOsApi.md#consultarcteos) | **GET** /cteos/{id} | Consultar CT-e OS
*CteOsApi* | [**ConsultarEventoCteOs**](docs/CteOsApi.md#consultareventocteos) | **GET** /cteos/eventos/{id} | Consultar evento
*CteOsApi* | [**ConsultarStatusSefazCteOs**](docs/CteOsApi.md#consultarstatussefazcteos) | **GET** /cteos/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*CteOsApi* | [**CriarCartaCorrecaoCteOs**](docs/CteOsApi.md#criarcartacorrecaocteos) | **POST** /cteos/{id}/carta-correcao | Solicitar correção do CT-e OS
*CteOsApi* | [**EmitirCteOs**](docs/CteOsApi.md#emitircteos) | **POST** /cteos | Emitir CT-e OS
*CteOsApi* | [**ListarCteOs**](docs/CteOsApi.md#listarcteos) | **GET** /cteos | Listar CT-e OS
*CteOsApi* | [**SincronizarCteOs**](docs/CteOsApi.md#sincronizarcteos) | **POST** /cteos/{id}/sincronizar | Sincroniza dados no CT-e OS a partir da SEFAZ
*DceApi* | [**BaixarPdfDce**](docs/DceApi.md#baixarpdfdce) | **GET** /dce/{id}/pdf | Baixar PDF do DACE
*DceApi* | [**BaixarXmlCancelamentoDce**](docs/DceApi.md#baixarxmlcancelamentodce) | **GET** /dce/{id}/cancelamento/xml | Baixar XML do cancelamento
*DceApi* | [**BaixarXmlDce**](docs/DceApi.md#baixarxmldce) | **GET** /dce/{id}/xml | Baixar XML da DC-e processada
*DceApi* | [**BaixarXmlDceDeclaracao**](docs/DceApi.md#baixarxmldcedeclaracao) | **GET** /dce/{id}/xml/declaracao | Baixar XML da DC-e
*DceApi* | [**BaixarXmlDceProtocolo**](docs/DceApi.md#baixarxmldceprotocolo) | **GET** /dce/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*DceApi* | [**CancelarDce**](docs/DceApi.md#cancelardce) | **POST** /dce/{id}/cancelamento | Cancelar uma DC-e autorizada
*DceApi* | [**ConsultarCancelamentoDce**](docs/DceApi.md#consultarcancelamentodce) | **GET** /dce/{id}/cancelamento | Consultar o cancelamento da DC-e
*DceApi* | [**ConsultarDce**](docs/DceApi.md#consultardce) | **GET** /dce/{id} | Consultar DC-e
*DceApi* | [**ConsultarStatusSefazDce**](docs/DceApi.md#consultarstatussefazdce) | **GET** /dce/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*DceApi* | [**EmitirDce**](docs/DceApi.md#emitirdce) | **POST** /dce | Emitir DC-e
*DceApi* | [**ListarDce**](docs/DceApi.md#listardce) | **GET** /dce | Listar DC-e
*DebugApi* | [**DebugDfe**](docs/DebugApi.md#debugdfe) | **GET** /debug/{id} | Debug de DF-e
*DebugApi* | [**DebugDfeOriginalPayload**](docs/DebugApi.md#debugdfeoriginalpayload) | **GET** /debug/{id}/original-payload | Payload original recebido
*DebugApi* | [**DebugHttpRequestContent**](docs/DebugApi.md#debughttprequestcontent) | **GET** /debug/http-requests/{id}/request-content | Corpo da requisição HTTP
*DebugApi* | [**DebugHttpResponseContent**](docs/DebugApi.md#debughttpresponsecontent) | **GET** /debug/http-requests/{id}/response-content | Corpo da resposta HTTP
*DistribuioNFEApi* | [**BaixarPdfDocumentoDistribuicaoNfe**](docs/DistribuioNFEApi.md#baixarpdfdocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos/{id}/pdf | Baixar PDF do documento
*DistribuioNFEApi* | [**BaixarXmlDocumentoDistribuicaoNfe**](docs/DistribuioNFEApi.md#baixarxmldocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos/{id}/xml | Baixar XML do documento
*DistribuioNFEApi* | [**ConsultarDistribuicaoNfe**](docs/DistribuioNFEApi.md#consultardistribuicaonfe) | **GET** /distribuicao/nfe/{id} | Consultar distribuição
*DistribuioNFEApi* | [**ConsultarDocumentoDistribuicaoNfe**](docs/DistribuioNFEApi.md#consultardocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos/{id} | Consultar documento
*DistribuioNFEApi* | [**ConsultarManifestacaoNfe**](docs/DistribuioNFEApi.md#consultarmanifestacaonfe) | **GET** /distribuicao/nfe/manifestacoes/{id} | Consultar manifestação
*DistribuioNFEApi* | [**GerarDistribuicaoNfe**](docs/DistribuioNFEApi.md#gerardistribuicaonfe) | **POST** /distribuicao/nfe | Distribuir documentos
*DistribuioNFEApi* | [**ListarDistribuicaoNfe**](docs/DistribuioNFEApi.md#listardistribuicaonfe) | **GET** /distribuicao/nfe | Listar distribuições
*DistribuioNFEApi* | [**ListarDocumentoDistribuicaoNfe**](docs/DistribuioNFEApi.md#listardocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos | Listar documentos
*DistribuioNFEApi* | [**ListarManifestacaoNfe**](docs/DistribuioNFEApi.md#listarmanifestacaonfe) | **GET** /distribuicao/nfe/manifestacoes | Listar Manifestações
*DistribuioNFEApi* | [**ListarNfeSemManifestacao**](docs/DistribuioNFEApi.md#listarnfesemmanifestacao) | **GET** /distribuicao/nfe/notas-sem-manifestacao | Listar notas sem manifestação
*DistribuioNFEApi* | [**ManifestarNfe**](docs/DistribuioNFEApi.md#manifestarnfe) | **POST** /distribuicao/nfe/manifestacoes | Manifestar nota
*EmailApi* | [**ConsultarEmail**](docs/EmailApi.md#consultaremail) | **GET** /emails/{id} | Consultar e-mail
*EmailApi* | [**ListarEmails**](docs/EmailApi.md#listaremails) | **GET** /emails | Listar e-mails
*EmpresaApi* | [**AlterarConfigCte**](docs/EmpresaApi.md#alterarconfigcte) | **PUT** /empresas/{cpf_cnpj}/cte | Alterar configuração de CT-e
*EmpresaApi* | [**AlterarConfigCteOs**](docs/EmpresaApi.md#alterarconfigcteos) | **PUT** /empresas/{cpf_cnpj}/cteos | Alterar configuração de CT-e OS
*EmpresaApi* | [**AlterarConfigDce**](docs/EmpresaApi.md#alterarconfigdce) | **PUT** /empresas/{cpf_cnpj}/dce | Alterar configuração de DC-e
*EmpresaApi* | [**AlterarConfigDistribuicaoNfe**](docs/EmpresaApi.md#alterarconfigdistribuicaonfe) | **PUT** /empresas/{cpf_cnpj}/distnfe | Alterar configuração de Distribuição de NF-e
*EmpresaApi* | [**AlterarConfigMdfe**](docs/EmpresaApi.md#alterarconfigmdfe) | **PUT** /empresas/{cpf_cnpj}/mdfe | Alterar configuração de MDF-e
*EmpresaApi* | [**AlterarConfigNfce**](docs/EmpresaApi.md#alterarconfignfce) | **PUT** /empresas/{cpf_cnpj}/nfce | Alterar configuração de NFC-e
*EmpresaApi* | [**AlterarConfigNfcom**](docs/EmpresaApi.md#alterarconfignfcom) | **PUT** /empresas/{cpf_cnpj}/nfcom | Alterar configuração de NFCom
*EmpresaApi* | [**AlterarConfigNfe**](docs/EmpresaApi.md#alterarconfignfe) | **PUT** /empresas/{cpf_cnpj}/nfe | Alterar configuração de NF-e
*EmpresaApi* | [**AlterarConfigNfse**](docs/EmpresaApi.md#alterarconfignfse) | **PUT** /empresas/{cpf_cnpj}/nfse | Alterar configuração de NFS-e
*EmpresaApi* | [**AtualizarEmpresa**](docs/EmpresaApi.md#atualizarempresa) | **PUT** /empresas/{cpf_cnpj} | Alterar empresa
*EmpresaApi* | [**BaixarLogotipoEmpresa**](docs/EmpresaApi.md#baixarlogotipoempresa) | **GET** /empresas/{cpf_cnpj}/logotipo | Baixar logotipo
*EmpresaApi* | [**CadastrarCertificadoEmpresa**](docs/EmpresaApi.md#cadastrarcertificadoempresa) | **PUT** /empresas/{cpf_cnpj}/certificado | Cadastrar certificado
*EmpresaApi* | [**ConsultarCertificadoEmpresa**](docs/EmpresaApi.md#consultarcertificadoempresa) | **GET** /empresas/{cpf_cnpj}/certificado | Consultar certificado
*EmpresaApi* | [**ConsultarConfigCte**](docs/EmpresaApi.md#consultarconfigcte) | **GET** /empresas/{cpf_cnpj}/cte | Consultar configuração de CT-e
*EmpresaApi* | [**ConsultarConfigCteOs**](docs/EmpresaApi.md#consultarconfigcteos) | **GET** /empresas/{cpf_cnpj}/cteos | Consultar configuração de CT-e OS
*EmpresaApi* | [**ConsultarConfigDce**](docs/EmpresaApi.md#consultarconfigdce) | **GET** /empresas/{cpf_cnpj}/dce | Consultar configuração de DC-e
*EmpresaApi* | [**ConsultarConfigDistribuicaoNfe**](docs/EmpresaApi.md#consultarconfigdistribuicaonfe) | **GET** /empresas/{cpf_cnpj}/distnfe | Consultar configuração de Distribuição de NF-e
*EmpresaApi* | [**ConsultarConfigMdfe**](docs/EmpresaApi.md#consultarconfigmdfe) | **GET** /empresas/{cpf_cnpj}/mdfe | Consultar configuração de MDF-e
*EmpresaApi* | [**ConsultarConfigNfce**](docs/EmpresaApi.md#consultarconfignfce) | **GET** /empresas/{cpf_cnpj}/nfce | Consultar configuração de NFC-e
*EmpresaApi* | [**ConsultarConfigNfcom**](docs/EmpresaApi.md#consultarconfignfcom) | **GET** /empresas/{cpf_cnpj}/nfcom | Consultar configuração de NFCom
*EmpresaApi* | [**ConsultarConfigNfe**](docs/EmpresaApi.md#consultarconfignfe) | **GET** /empresas/{cpf_cnpj}/nfe | Consultar configuração de NF-e
*EmpresaApi* | [**ConsultarConfigNfse**](docs/EmpresaApi.md#consultarconfignfse) | **GET** /empresas/{cpf_cnpj}/nfse | Consultar configuração de NFS-e
*EmpresaApi* | [**ConsultarEmpresa**](docs/EmpresaApi.md#consultarempresa) | **GET** /empresas/{cpf_cnpj} | Consultar empresa
*EmpresaApi* | [**CriarEmpresa**](docs/EmpresaApi.md#criarempresa) | **POST** /empresas | Cadastrar empresa
*EmpresaApi* | [**EnviarCertificadoEmpresa**](docs/EmpresaApi.md#enviarcertificadoempresa) | **PUT** /empresas/{cpf_cnpj}/certificado/upload | Upload de certificado
*EmpresaApi* | [**EnviarLogotipoEmpresa**](docs/EmpresaApi.md#enviarlogotipoempresa) | **PUT** /empresas/{cpf_cnpj}/logotipo | Enviar logotipo
*EmpresaApi* | [**ExcluirCertificadoEmpresa**](docs/EmpresaApi.md#excluircertificadoempresa) | **DELETE** /empresas/{cpf_cnpj}/certificado | Deletar certificado
*EmpresaApi* | [**ExcluirEmpresa**](docs/EmpresaApi.md#excluirempresa) | **DELETE** /empresas/{cpf_cnpj} | Deletar empresa
*EmpresaApi* | [**ExcluirLogotipoEmpresa**](docs/EmpresaApi.md#excluirlogotipoempresa) | **DELETE** /empresas/{cpf_cnpj}/logotipo | Deletar logotipo
*EmpresaApi* | [**ListarEmpresas**](docs/EmpresaApi.md#listarempresas) | **GET** /empresas | Listar empresas
*MdfeApi* | [**BaixarPdfCancelamentoMdfe**](docs/MdfeApi.md#baixarpdfcancelamentomdfe) | **GET** /mdfe/{id}/cancelamento/pdf | Baixar PDF do cancelamento
*MdfeApi* | [**BaixarPdfEncerramentoMdfe**](docs/MdfeApi.md#baixarpdfencerramentomdfe) | **GET** /mdfe/{id}/encerramento/pdf | Baixar PDF do encerramento
*MdfeApi* | [**BaixarPdfEventoMdfe**](docs/MdfeApi.md#baixarpdfeventomdfe) | **GET** /mdfe/eventos/{id}/pdf | Baixar PDF do evento
*MdfeApi* | [**BaixarPdfMdfe**](docs/MdfeApi.md#baixarpdfmdfe) | **GET** /mdfe/{id}/pdf | Baixar PDF do DAMDFE
*MdfeApi* | [**BaixarXmlCancelamentoMdfe**](docs/MdfeApi.md#baixarxmlcancelamentomdfe) | **GET** /mdfe/{id}/cancelamento/xml | Baixar XML do cancelamento
*MdfeApi* | [**BaixarXmlEncerramentoMdfe**](docs/MdfeApi.md#baixarxmlencerramentomdfe) | **GET** /mdfe/{id}/encerramento/xml | Baixar XML do encerramento
*MdfeApi* | [**BaixarXmlEventoMdfe**](docs/MdfeApi.md#baixarxmleventomdfe) | **GET** /mdfe/eventos/{id}/xml | Baixar XML do evento
*MdfeApi* | [**BaixarXmlMdfe**](docs/MdfeApi.md#baixarxmlmdfe) | **GET** /mdfe/{id}/xml | Baixar XML do MDF-e processado
*MdfeApi* | [**BaixarXmlMdfeManifesto**](docs/MdfeApi.md#baixarxmlmdfemanifesto) | **GET** /mdfe/{id}/xml/manifesto | Baixar XML do MDF-e
*MdfeApi* | [**BaixarXmlMdfeProtocolo**](docs/MdfeApi.md#baixarxmlmdfeprotocolo) | **GET** /mdfe/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*MdfeApi* | [**CancelarMdfe**](docs/MdfeApi.md#cancelarmdfe) | **POST** /mdfe/{id}/cancelamento | Cancelar um MDF-e autorizado
*MdfeApi* | [**ConsultarCancelamentoMdfe**](docs/MdfeApi.md#consultarcancelamentomdfe) | **GET** /mdfe/{id}/cancelamento | Consultar o cancelamento do MDF-e
*MdfeApi* | [**ConsultarEncerramentoMdfe**](docs/MdfeApi.md#consultarencerramentomdfe) | **GET** /mdfe/{id}/encerramento | Consultar encerramento do MDF-e
*MdfeApi* | [**ConsultarEventoMdfe**](docs/MdfeApi.md#consultareventomdfe) | **GET** /mdfe/eventos/{id} | Consultar evento do MDF-e
*MdfeApi* | [**ConsultarLoteMdfe**](docs/MdfeApi.md#consultarlotemdfe) | **GET** /mdfe/lotes/{id} | Consultar lote de MDF-e
*MdfeApi* | [**ConsultarMdfe**](docs/MdfeApi.md#consultarmdfe) | **GET** /mdfe/{id} | Consultar manifesto
*MdfeApi* | [**ConsultarMdfeNaoEncerrados**](docs/MdfeApi.md#consultarmdfenaoencerrados) | **GET** /mdfe/nao-encerrados | Consulta MDF-e não encerrados
*MdfeApi* | [**ConsultarStatusSefazMdfe**](docs/MdfeApi.md#consultarstatussefazmdfe) | **GET** /mdfe/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*MdfeApi* | [**EmitirLoteMdfe**](docs/MdfeApi.md#emitirlotemdfe) | **POST** /mdfe/lotes | Emitir lote de MDF-e
*MdfeApi* | [**EmitirMdfe**](docs/MdfeApi.md#emitirmdfe) | **POST** /mdfe | Emitir MDF-e
*MdfeApi* | [**EncerrarMdfe**](docs/MdfeApi.md#encerrarmdfe) | **POST** /mdfe/{id}/encerramento | Encerrar um MDF-e autorizado
*MdfeApi* | [**IncluirCondutorMdfe**](docs/MdfeApi.md#incluircondutormdfe) | **POST** /mdfe/{id}/inclusao-condutor | Incluir um condutor em um MDF-e autorizado
*MdfeApi* | [**IncluirDfeMdfe**](docs/MdfeApi.md#incluirdfemdfe) | **POST** /mdfe/{id}/inclusao-dfe | Incluir um DF-e em um MDF-e autorizado
*MdfeApi* | [**ListarLotesMdfe**](docs/MdfeApi.md#listarlotesmdfe) | **GET** /mdfe/lotes | Listar lotes de MDF-e
*MdfeApi* | [**ListarMdfe**](docs/MdfeApi.md#listarmdfe) | **GET** /mdfe | Listar MDF-e
*MdfeApi* | [**SincronizarMdfe**](docs/MdfeApi.md#sincronizarmdfe) | **POST** /mdfe/{id}/sincronizar | Sincroniza dados no MDF-e a partir da SEFAZ
*NfceApi* | [**BaixarEscPosNfce**](docs/NfceApi.md#baixarescposnfce) | **GET** /nfce/{id}/escpos | Comandos ESC/POS para impressão do DANFCE
*NfceApi* | [**BaixarPdfCancelamentoNfce**](docs/NfceApi.md#baixarpdfcancelamentonfce) | **GET** /nfce/{id}/cancelamento/pdf | Baixar PDF do cancelamento
*NfceApi* | [**BaixarPdfEventoNfce**](docs/NfceApi.md#baixarpdfeventonfce) | **GET** /nfce/eventos/{id}/pdf | Baixar PDF do evento
*NfceApi* | [**BaixarPdfInutilizacaoNfce**](docs/NfceApi.md#baixarpdfinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id}/pdf | Baixar PDF da inutilização
*NfceApi* | [**BaixarPdfNfce**](docs/NfceApi.md#baixarpdfnfce) | **GET** /nfce/{id}/pdf | Baixar PDF do DANFCE
*NfceApi* | [**BaixarPreviaPdfNfce**](docs/NfceApi.md#baixarpreviapdfnfce) | **POST** /nfce/previa/pdf | Prévia do PDF do DANFCE
*NfceApi* | [**BaixarPreviaXmlNfce**](docs/NfceApi.md#baixarpreviaxmlnfce) | **POST** /nfce/previa/xml | Prévia do XML da NFC-e
*NfceApi* | [**BaixarXmlCancelamentoNfce**](docs/NfceApi.md#baixarxmlcancelamentonfce) | **GET** /nfce/{id}/cancelamento/xml | Baixar XML do cancelamento
*NfceApi* | [**BaixarXmlEventoNfce**](docs/NfceApi.md#baixarxmleventonfce) | **GET** /nfce/eventos/{id}/xml | Baixar XML do evento
*NfceApi* | [**BaixarXmlInutilizacaoNfce**](docs/NfceApi.md#baixarxmlinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id}/xml | Baixar XML da inutilização
*NfceApi* | [**BaixarXmlNfce**](docs/NfceApi.md#baixarxmlnfce) | **GET** /nfce/{id}/xml | Baixar XML da NFC-e processada
*NfceApi* | [**BaixarXmlNfceNota**](docs/NfceApi.md#baixarxmlnfcenota) | **GET** /nfce/{id}/xml/nota | Baixar XML da NFC-e
*NfceApi* | [**BaixarXmlNfceProtocolo**](docs/NfceApi.md#baixarxmlnfceprotocolo) | **GET** /nfce/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*NfceApi* | [**CancelarNfce**](docs/NfceApi.md#cancelarnfce) | **POST** /nfce/{id}/cancelamento | Cancelar uma NFC-e autorizada
*NfceApi* | [**ConsultarCancelamentoNfce**](docs/NfceApi.md#consultarcancelamentonfce) | **GET** /nfce/{id}/cancelamento | Consultar o cancelamento da NFC-e
*NfceApi* | [**ConsultarEventoNfce**](docs/NfceApi.md#consultareventonfce) | **GET** /nfce/eventos/{id} | Consultar evento
*NfceApi* | [**ConsultarInutilizacaoNfce**](docs/NfceApi.md#consultarinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração
*NfceApi* | [**ConsultarLoteNfce**](docs/NfceApi.md#consultarlotenfce) | **GET** /nfce/lotes/{id} | Consultar lote de NFC-e
*NfceApi* | [**ConsultarNfce**](docs/NfceApi.md#consultarnfce) | **GET** /nfce/{id} | Consultar NFC-e
*NfceApi* | [**ConsultarStatusSefazNfce**](docs/NfceApi.md#consultarstatussefaznfce) | **GET** /nfce/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*NfceApi* | [**EmitirLoteNfce**](docs/NfceApi.md#emitirlotenfce) | **POST** /nfce/lotes | Emitir lote de NFC-e
*NfceApi* | [**EmitirNfce**](docs/NfceApi.md#emitirnfce) | **POST** /nfce | Emitir NFC-e
*NfceApi* | [**EnviarEmailNfce**](docs/NfceApi.md#enviaremailnfce) | **POST** /nfce/{id}/email | Enviar e-mail
*NfceApi* | [**InutilizarNumeracaoNfce**](docs/NfceApi.md#inutilizarnumeracaonfce) | **POST** /nfce/inutilizacoes | Inutilizar uma sequência de numeração de NFC-e
*NfceApi* | [**ListarEventosNfce**](docs/NfceApi.md#listareventosnfce) | **GET** /nfce/eventos | Listar eventos
*NfceApi* | [**ListarLotesNfce**](docs/NfceApi.md#listarlotesnfce) | **GET** /nfce/lotes | Listar lotes de NFC-e
*NfceApi* | [**ListarNfce**](docs/NfceApi.md#listarnfce) | **GET** /nfce | Listar NFC-e
*NfceApi* | [**SincronizarNfce**](docs/NfceApi.md#sincronizarnfce) | **POST** /nfce/{id}/sincronizar | Sincroniza dados na NFC-e a partir da SEFAZ
*NfcomApi* | [**BaixarPdfNfcom**](docs/NfcomApi.md#baixarpdfnfcom) | **GET** /nfcom/{id}/pdf | Baixar PDF do DANFE-COM
*NfcomApi* | [**BaixarXmlCancelamentoNfcom**](docs/NfcomApi.md#baixarxmlcancelamentonfcom) | **GET** /nfcom/{id}/cancelamento/xml | Baixar XML do cancelamento
*NfcomApi* | [**BaixarXmlNfcom**](docs/NfcomApi.md#baixarxmlnfcom) | **GET** /nfcom/{id}/xml | Baixar XML da NFCom processada
*NfcomApi* | [**BaixarXmlNfcomNota**](docs/NfcomApi.md#baixarxmlnfcomnota) | **GET** /nfcom/{id}/xml/nota | Baixar XML da NFCom
*NfcomApi* | [**BaixarXmlNfcomProtocolo**](docs/NfcomApi.md#baixarxmlnfcomprotocolo) | **GET** /nfcom/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*NfcomApi* | [**CancelarNfcom**](docs/NfcomApi.md#cancelarnfcom) | **POST** /nfcom/{id}/cancelamento | Cancelar uma NFCom autorizada
*NfcomApi* | [**ConsultarCancelamentoNfcom**](docs/NfcomApi.md#consultarcancelamentonfcom) | **GET** /nfcom/{id}/cancelamento | Consultar o cancelamento da NFCom
*NfcomApi* | [**ConsultarNfcom**](docs/NfcomApi.md#consultarnfcom) | **GET** /nfcom/{id} | Consultar NFCom
*NfcomApi* | [**ConsultarStatusSefazNfcom**](docs/NfcomApi.md#consultarstatussefaznfcom) | **GET** /nfcom/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*NfcomApi* | [**EmitirNfcom**](docs/NfcomApi.md#emitirnfcom) | **POST** /nfcom | Emitir NFCom
*NfcomApi* | [**ListarNfcom**](docs/NfcomApi.md#listarnfcom) | **GET** /nfcom | Listar NFCom
*NfeApi* | [**BaixarPdfCancelamentoNfe**](docs/NfeApi.md#baixarpdfcancelamentonfe) | **GET** /nfe/{id}/cancelamento/pdf | Baixar PDF do cancelamento
*NfeApi* | [**BaixarPdfCartaCorrecaoNfe**](docs/NfeApi.md#baixarpdfcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao/pdf | Baixar PDF da carta de correção
*NfeApi* | [**BaixarPdfEventoNfe**](docs/NfeApi.md#baixarpdfeventonfe) | **GET** /nfe/eventos/{id}/pdf | Baixar PDF do evento
*NfeApi* | [**BaixarPdfInutilizacaoNfe**](docs/NfeApi.md#baixarpdfinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id}/pdf | Baixar PDF da inutilização
*NfeApi* | [**BaixarPdfNfe**](docs/NfeApi.md#baixarpdfnfe) | **GET** /nfe/{id}/pdf | Baixar PDF do DANFE
*NfeApi* | [**BaixarPreviaPdfNfe**](docs/NfeApi.md#baixarpreviapdfnfe) | **POST** /nfe/previa/pdf | Prévia do PDF do DANFE
*NfeApi* | [**BaixarPreviaXmlNfe**](docs/NfeApi.md#baixarpreviaxmlnfe) | **POST** /nfe/previa/xml | Prévia do XML da NF-e
*NfeApi* | [**BaixarXmlCancelamentoNfe**](docs/NfeApi.md#baixarxmlcancelamentonfe) | **GET** /nfe/{id}/cancelamento/xml | Baixar XML do cancelamento
*NfeApi* | [**BaixarXmlCartaCorrecaoNfe**](docs/NfeApi.md#baixarxmlcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao/xml | Baixar XML da carta de correção
*NfeApi* | [**BaixarXmlEventoNfe**](docs/NfeApi.md#baixarxmleventonfe) | **GET** /nfe/eventos/{id}/xml | Baixar XML do evento
*NfeApi* | [**BaixarXmlInutilizacaoNfe**](docs/NfeApi.md#baixarxmlinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id}/xml | Baixar XML da inutilização
*NfeApi* | [**BaixarXmlNfe**](docs/NfeApi.md#baixarxmlnfe) | **GET** /nfe/{id}/xml | Baixar XML da NF-e processada
*NfeApi* | [**BaixarXmlNfeNota**](docs/NfeApi.md#baixarxmlnfenota) | **GET** /nfe/{id}/xml/nota | Baixar XML da NF-e
*NfeApi* | [**BaixarXmlNfeProtocolo**](docs/NfeApi.md#baixarxmlnfeprotocolo) | **GET** /nfe/{id}/xml/protocolo | Baixar XML do Protocolo da SEFAZ
*NfeApi* | [**CancelarNfe**](docs/NfeApi.md#cancelarnfe) | **POST** /nfe/{id}/cancelamento | Cancelar uma NF-e autorizada
*NfeApi* | [**ConsultarCancelamentoNfe**](docs/NfeApi.md#consultarcancelamentonfe) | **GET** /nfe/{id}/cancelamento | Consultar o cancelamento da NF-e
*NfeApi* | [**ConsultarCartaCorrecaoNfe**](docs/NfeApi.md#consultarcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao | Consultar a solicitação de correção da NF-e
*NfeApi* | [**ConsultarContribuinteNfe**](docs/NfeApi.md#consultarcontribuintenfe) | **GET** /nfe/cadastro-contribuinte | Consultar contribuinte
*NfeApi* | [**ConsultarEventoNfe**](docs/NfeApi.md#consultareventonfe) | **GET** /nfe/eventos/{id} | Consultar evento
*NfeApi* | [**ConsultarInutilizacaoNfe**](docs/NfeApi.md#consultarinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração
*NfeApi* | [**ConsultarLoteNfe**](docs/NfeApi.md#consultarlotenfe) | **GET** /nfe/lotes/{id} | Consultar lote de NF-e
*NfeApi* | [**ConsultarNfe**](docs/NfeApi.md#consultarnfe) | **GET** /nfe/{id} | Consultar NF-e
*NfeApi* | [**ConsultarStatusSefazNfe**](docs/NfeApi.md#consultarstatussefaznfe) | **GET** /nfe/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*NfeApi* | [**CriarCartaCorrecaoNfe**](docs/NfeApi.md#criarcartacorrecaonfe) | **POST** /nfe/{id}/carta-correcao | Solicitar correção da NF-e
*NfeApi* | [**EmitirLoteNfe**](docs/NfeApi.md#emitirlotenfe) | **POST** /nfe/lotes | Emitir lote de NF-e
*NfeApi* | [**EmitirNfe**](docs/NfeApi.md#emitirnfe) | **POST** /nfe | Emitir NF-e
*NfeApi* | [**EnviarEmailNfe**](docs/NfeApi.md#enviaremailnfe) | **POST** /nfe/{id}/email | Enviar e-mail
*NfeApi* | [**InutilizarNumeracaoNfe**](docs/NfeApi.md#inutilizarnumeracaonfe) | **POST** /nfe/inutilizacoes | Inutilizar uma sequência de numeração de NF-e
*NfeApi* | [**ListarEventosNfe**](docs/NfeApi.md#listareventosnfe) | **GET** /nfe/eventos | Listar eventos
*NfeApi* | [**ListarLotesNfe**](docs/NfeApi.md#listarlotesnfe) | **GET** /nfe/lotes | Listar lotes de NF-e
*NfeApi* | [**ListarNfe**](docs/NfeApi.md#listarnfe) | **GET** /nfe | Listar NF-e
*NfeApi* | [**SincronizarNfe**](docs/NfeApi.md#sincronizarnfe) | **POST** /nfe/{id}/sincronizar | Sincroniza dados na NF-e a partir da SEFAZ
*NfseApi* | [**BaixarPdfNfse**](docs/NfseApi.md#baixarpdfnfse) | **GET** /nfse/{id}/pdf | Baixar PDF do DANFSE
*NfseApi* | [**BaixarXmlCancelamentoNfse**](docs/NfseApi.md#baixarxmlcancelamentonfse) | **GET** /nfse/{Id}/cancelamento/xml | Baixar XML do evento de cancelamento
*NfseApi* | [**BaixarXmlDps**](docs/NfseApi.md#baixarxmldps) | **GET** /nfse/{id}/xml/dps | Baixar XML da DPS
*NfseApi* | [**BaixarXmlNfse**](docs/NfseApi.md#baixarxmlnfse) | **GET** /nfse/{id}/xml | Baixar XML da NFS-e processada
*NfseApi* | [**CancelarNfse**](docs/NfseApi.md#cancelarnfse) | **POST** /nfse/{id}/cancelamento | Cancelar uma NFS-e autorizada
*NfseApi* | [**CidadesAtendidas**](docs/NfseApi.md#cidadesatendidas) | **GET** /nfse/cidades | Cidades atendidas
*NfseApi* | [**ConsultarCancelamentoNfse**](docs/NfseApi.md#consultarcancelamentonfse) | **GET** /nfse/{id}/cancelamento | Consultar o cancelamento da NFS-e
*NfseApi* | [**ConsultarLoteNfse**](docs/NfseApi.md#consultarlotenfse) | **GET** /nfse/lotes/{id} | Consultar lote de NFS-e
*NfseApi* | [**ConsultarMetadados**](docs/NfseApi.md#consultarmetadados) | **GET** /nfse/cidades/{codigo_ibge} | Consultar metadados
*NfseApi* | [**ConsultarNfse**](docs/NfseApi.md#consultarnfse) | **GET** /nfse/{id} | Consultar NFS-e
*NfseApi* | [**EmitirLoteNfse**](docs/NfseApi.md#emitirlotenfse) | **POST** /nfse/lotes | Emitir lote de NFS-e
*NfseApi* | [**EmitirLoteNfseDps**](docs/NfseApi.md#emitirlotenfsedps) | **POST** /nfse/dps/lotes | Emitir lote de NFS-e
*NfseApi* | [**EmitirNfse**](docs/NfseApi.md#emitirnfse) | **POST** /nfse | Emitir NFS-e
*NfseApi* | [**EmitirNfseDps**](docs/NfseApi.md#emitirnfsedps) | **POST** /nfse/dps | Emitir NFS-e
*NfseApi* | [**ListarLotesNfse**](docs/NfseApi.md#listarlotesnfse) | **GET** /nfse/lotes | Listar lotes de NFS-e
*NfseApi* | [**ListarNfse**](docs/NfseApi.md#listarnfse) | **GET** /nfse | Listar NFS-e
*NfseApi* | [**SincronizarNfse**](docs/NfseApi.md#sincronizarnfse) | **POST** /nfse/{id}/sincronizar | Sincroniza dados na NFS-e a partir da Prefeitura


<a name="documentation-for-models"></a>
## Documentação dos DTOs

 - [Model.AtvEvento](docs/AtvEvento.md)
 - [Model.BeneficioMunicipal](docs/BeneficioMunicipal.md)
 - [Model.CServ](docs/CServ.md)
 - [Model.CepEndereco](docs/CepEndereco.md)
 - [Model.CnpjCnae](docs/CnpjCnae.md)
 - [Model.CnpjCnaeSecundario](docs/CnpjCnaeSecundario.md)
 - [Model.CnpjEmpresa](docs/CnpjEmpresa.md)
 - [Model.CnpjEndereco](docs/CnpjEndereco.md)
 - [Model.CnpjFaixaEtaria](docs/CnpjFaixaEtaria.md)
 - [Model.CnpjIdentificadorSocio](docs/CnpjIdentificadorSocio.md)
 - [Model.CnpjListagem](docs/CnpjListagem.md)
 - [Model.CnpjMotivoSituacaoCadastral](docs/CnpjMotivoSituacaoCadastral.md)
 - [Model.CnpjMunicipio](docs/CnpjMunicipio.md)
 - [Model.CnpjNaturezaJuridica](docs/CnpjNaturezaJuridica.md)
 - [Model.CnpjOpcaoSimei](docs/CnpjOpcaoSimei.md)
 - [Model.CnpjOpcaoSimples](docs/CnpjOpcaoSimples.md)
 - [Model.CnpjPais](docs/CnpjPais.md)
 - [Model.CnpjPorteEmpresa](docs/CnpjPorteEmpresa.md)
 - [Model.CnpjQualificacaoSocio](docs/CnpjQualificacaoSocio.md)
 - [Model.CnpjRepresentanteLegal](docs/CnpjRepresentanteLegal.md)
 - [Model.CnpjSituacaoCadastral](docs/CnpjSituacaoCadastral.md)
 - [Model.CnpjSituacaoEspecial](docs/CnpjSituacaoEspecial.md)
 - [Model.CnpjSocio](docs/CnpjSocio.md)
 - [Model.CnpjTelefone](docs/CnpjTelefone.md)
 - [Model.ComExterior](docs/ComExterior.md)
 - [Model.ContaCota](docs/ContaCota.md)
 - [Model.ContaCotaListagem](docs/ContaCotaListagem.md)
 - [Model.CteCartaCorrecao](docs/CteCartaCorrecao.md)
 - [Model.CteInfCorrecao](docs/CteInfCorrecao.md)
 - [Model.CteOsCartaCorrecao](docs/CteOsCartaCorrecao.md)
 - [Model.CteOsInfCorrecao](docs/CteOsInfCorrecao.md)
 - [Model.CteOsPedidoCancelamento](docs/CteOsPedidoCancelamento.md)
 - [Model.CteOsPedidoCartaCorrecao](docs/CteOsPedidoCartaCorrecao.md)
 - [Model.CteOsPedidoEmissao](docs/CteOsPedidoEmissao.md)
 - [Model.CteOsSefazAutXMLOS](docs/CteOsSefazAutXMLOS.md)
 - [Model.CteOsSefazCobrOS](docs/CteOsSefazCobrOS.md)
 - [Model.CteOsSefazCompOS](docs/CteOsSefazCompOS.md)
 - [Model.CteOsSefazComplOS](docs/CteOsSefazComplOS.md)
 - [Model.CteOsSefazDupOS](docs/CteOsSefazDupOS.md)
 - [Model.CteOsSefazEmitOS](docs/CteOsSefazEmitOS.md)
 - [Model.CteOsSefazEndeEmiOS](docs/CteOsSefazEndeEmiOS.md)
 - [Model.CteOsSefazEnderecoOS](docs/CteOsSefazEnderecoOS.md)
 - [Model.CteOsSefazFatOS](docs/CteOsSefazFatOS.md)
 - [Model.CteOsSefazICMS00OS](docs/CteOsSefazICMS00OS.md)
 - [Model.CteOsSefazICMS20OS](docs/CteOsSefazICMS20OS.md)
 - [Model.CteOsSefazICMS45OS](docs/CteOsSefazICMS45OS.md)
 - [Model.CteOsSefazICMS90OS](docs/CteOsSefazICMS90OS.md)
 - [Model.CteOsSefazICMSOutraUFOS](docs/CteOsSefazICMSOutraUFOS.md)
 - [Model.CteOsSefazICMSSNOS](docs/CteOsSefazICMSSNOS.md)
 - [Model.CteOsSefazICMSUFFimOS](docs/CteOsSefazICMSUFFimOS.md)
 - [Model.CteOsSefazIdeOS](docs/CteOsSefazIdeOS.md)
 - [Model.CteOsSefazImpOS](docs/CteOsSefazImpOS.md)
 - [Model.CteOsSefazInfCTeNormOS](docs/CteOsSefazInfCTeNormOS.md)
 - [Model.CteOsSefazInfCTeSuplOS](docs/CteOsSefazInfCTeSuplOS.md)
 - [Model.CteOsSefazInfCteCompOS](docs/CteOsSefazInfCteCompOS.md)
 - [Model.CteOsSefazInfCteImpOS](docs/CteOsSefazInfCteImpOS.md)
 - [Model.CteOsSefazInfCteOS](docs/CteOsSefazInfCteOS.md)
 - [Model.CteOsSefazInfCteSubOS](docs/CteOsSefazInfCteSubOS.md)
 - [Model.CteOsSefazInfDocRefOS](docs/CteOsSefazInfDocRefOS.md)
 - [Model.CteOsSefazInfFretamentoOS](docs/CteOsSefazInfFretamentoOS.md)
 - [Model.CteOsSefazInfGTVeCompOS](docs/CteOsSefazInfGTVeCompOS.md)
 - [Model.CteOsSefazInfGTVeOS](docs/CteOsSefazInfGTVeOS.md)
 - [Model.CteOsSefazInfModalOS](docs/CteOsSefazInfModalOS.md)
 - [Model.CteOsSefazInfPercursoOS](docs/CteOsSefazInfPercursoOS.md)
 - [Model.CteOsSefazInfQOS](docs/CteOsSefazInfQOS.md)
 - [Model.CteOsSefazInfServicoOS](docs/CteOsSefazInfServicoOS.md)
 - [Model.CteOsSefazInfTribFedOS](docs/CteOsSefazInfTribFedOS.md)
 - [Model.CteOsSefazObsContOS](docs/CteOsSefazObsContOS.md)
 - [Model.CteOsSefazObsFiscoOS](docs/CteOsSefazObsFiscoOS.md)
 - [Model.CteOsSefazPropOS](docs/CteOsSefazPropOS.md)
 - [Model.CteOsSefazRespTecOS](docs/CteOsSefazRespTecOS.md)
 - [Model.CteOsSefazRodoOS](docs/CteOsSefazRodoOS.md)
 - [Model.CteOsSefazSegOS](docs/CteOsSefazSegOS.md)
 - [Model.CteOsSefazTomaOS](docs/CteOsSefazTomaOS.md)
 - [Model.CteOsSefazVPrestOS](docs/CteOsSefazVPrestOS.md)
 - [Model.CteOsSefazVeicOS](docs/CteOsSefazVeicOS.md)
 - [Model.CtePedidoCancelamento](docs/CtePedidoCancelamento.md)
 - [Model.CtePedidoCartaCorrecao](docs/CtePedidoCartaCorrecao.md)
 - [Model.CtePedidoEmissao](docs/CtePedidoEmissao.md)
 - [Model.CteSefazAereo](docs/CteSefazAereo.md)
 - [Model.CteSefazAquav](docs/CteSefazAquav.md)
 - [Model.CteSefazAutXML](docs/CteSefazAutXML.md)
 - [Model.CteSefazBalsa](docs/CteSefazBalsa.md)
 - [Model.CteSefazCobr](docs/CteSefazCobr.md)
 - [Model.CteSefazComData](docs/CteSefazComData.md)
 - [Model.CteSefazComHora](docs/CteSefazComHora.md)
 - [Model.CteSefazComp](docs/CteSefazComp.md)
 - [Model.CteSefazCompl](docs/CteSefazCompl.md)
 - [Model.CteSefazDest](docs/CteSefazDest.md)
 - [Model.CteSefazDetCont](docs/CteSefazDetCont.md)
 - [Model.CteSefazDetContInfDoc](docs/CteSefazDetContInfDoc.md)
 - [Model.CteSefazDetContInfDocInfNF](docs/CteSefazDetContInfDocInfNF.md)
 - [Model.CteSefazDetContInfDocInfNFe](docs/CteSefazDetContInfDocInfNFe.md)
 - [Model.CteSefazDocAnt](docs/CteSefazDocAnt.md)
 - [Model.CteSefazDup](docs/CteSefazDup.md)
 - [Model.CteSefazDuto](docs/CteSefazDuto.md)
 - [Model.CteSefazEmiDocAnt](docs/CteSefazEmiDocAnt.md)
 - [Model.CteSefazEmiOcc](docs/CteSefazEmiOcc.md)
 - [Model.CteSefazEmit](docs/CteSefazEmit.md)
 - [Model.CteSefazEndeEmi](docs/CteSefazEndeEmi.md)
 - [Model.CteSefazEnderFer](docs/CteSefazEnderFer.md)
 - [Model.CteSefazEndereco](docs/CteSefazEndereco.md)
 - [Model.CteSefazEntrega](docs/CteSefazEntrega.md)
 - [Model.CteSefazExped](docs/CteSefazExped.md)
 - [Model.CteSefazFat](docs/CteSefazFat.md)
 - [Model.CteSefazFerroEnv](docs/CteSefazFerroEnv.md)
 - [Model.CteSefazFerrov](docs/CteSefazFerrov.md)
 - [Model.CteSefazFluxo](docs/CteSefazFluxo.md)
 - [Model.CteSefazICMS00](docs/CteSefazICMS00.md)
 - [Model.CteSefazICMS20](docs/CteSefazICMS20.md)
 - [Model.CteSefazICMS45](docs/CteSefazICMS45.md)
 - [Model.CteSefazICMS60](docs/CteSefazICMS60.md)
 - [Model.CteSefazICMS90](docs/CteSefazICMS90.md)
 - [Model.CteSefazICMSOutraUF](docs/CteSefazICMSOutraUF.md)
 - [Model.CteSefazICMSSN](docs/CteSefazICMSSN.md)
 - [Model.CteSefazICMSUFFim](docs/CteSefazICMSUFFim.md)
 - [Model.CteSefazIdDocAnt](docs/CteSefazIdDocAnt.md)
 - [Model.CteSefazIdDocAntEle](docs/CteSefazIdDocAntEle.md)
 - [Model.CteSefazIdDocAntPap](docs/CteSefazIdDocAntPap.md)
 - [Model.CteSefazIde](docs/CteSefazIde.md)
 - [Model.CteSefazImp](docs/CteSefazImp.md)
 - [Model.CteSefazInfCTeMultimodal](docs/CteSefazInfCTeMultimodal.md)
 - [Model.CteSefazInfCTeNorm](docs/CteSefazInfCTeNorm.md)
 - [Model.CteSefazInfCTeSupl](docs/CteSefazInfCTeSupl.md)
 - [Model.CteSefazInfCarga](docs/CteSefazInfCarga.md)
 - [Model.CteSefazInfCte](docs/CteSefazInfCte.md)
 - [Model.CteSefazInfCteComp](docs/CteSefazInfCteComp.md)
 - [Model.CteSefazInfCteImp](docs/CteSefazInfCteImp.md)
 - [Model.CteSefazInfCteSub](docs/CteSefazInfCteSub.md)
 - [Model.CteSefazInfDoc](docs/CteSefazInfDoc.md)
 - [Model.CteSefazInfGlobalizado](docs/CteSefazInfGlobalizado.md)
 - [Model.CteSefazInfModal](docs/CteSefazInfModal.md)
 - [Model.CteSefazInfNF](docs/CteSefazInfNF.md)
 - [Model.CteSefazInfNFe](docs/CteSefazInfNFe.md)
 - [Model.CteSefazInfOutros](docs/CteSefazInfOutros.md)
 - [Model.CteSefazInfQ](docs/CteSefazInfQ.md)
 - [Model.CteSefazInfSeg](docs/CteSefazInfSeg.md)
 - [Model.CteSefazInfServVinc](docs/CteSefazInfServVinc.md)
 - [Model.CteSefazInfSolicNFF](docs/CteSefazInfSolicNFF.md)
 - [Model.CteSefazInfTotAP](docs/CteSefazInfTotAP.md)
 - [Model.CteSefazLacUnidCarga](docs/CteSefazLacUnidCarga.md)
 - [Model.CteSefazLacUnidTransp](docs/CteSefazLacUnidTransp.md)
 - [Model.CteSefazLacre](docs/CteSefazLacre.md)
 - [Model.CteSefazMultimodal](docs/CteSefazMultimodal.md)
 - [Model.CteSefazNatCarga](docs/CteSefazNatCarga.md)
 - [Model.CteSefazNoInter](docs/CteSefazNoInter.md)
 - [Model.CteSefazNoPeriodo](docs/CteSefazNoPeriodo.md)
 - [Model.CteSefazObsCont](docs/CteSefazObsCont.md)
 - [Model.CteSefazObsFisco](docs/CteSefazObsFisco.md)
 - [Model.CteSefazOcc](docs/CteSefazOcc.md)
 - [Model.CteSefazPass](docs/CteSefazPass.md)
 - [Model.CteSefazPeri](docs/CteSefazPeri.md)
 - [Model.CteSefazReceb](docs/CteSefazReceb.md)
 - [Model.CteSefazRem](docs/CteSefazRem.md)
 - [Model.CteSefazRespTec](docs/CteSefazRespTec.md)
 - [Model.CteSefazRodo](docs/CteSefazRodo.md)
 - [Model.CteSefazSeg](docs/CteSefazSeg.md)
 - [Model.CteSefazSemData](docs/CteSefazSemData.md)
 - [Model.CteSefazSemHora](docs/CteSefazSemHora.md)
 - [Model.CteSefazTarifa](docs/CteSefazTarifa.md)
 - [Model.CteSefazToma3](docs/CteSefazToma3.md)
 - [Model.CteSefazToma4](docs/CteSefazToma4.md)
 - [Model.CteSefazTrafMut](docs/CteSefazTrafMut.md)
 - [Model.CteSefazUnidCarga](docs/CteSefazUnidCarga.md)
 - [Model.CteSefazUnidadeTransp](docs/CteSefazUnidadeTransp.md)
 - [Model.CteSefazVPrest](docs/CteSefazVPrest.md)
 - [Model.CteSefazVeicNovos](docs/CteSefazVeicNovos.md)
 - [Model.CteSimpPedidoEmissao](docs/CteSimpPedidoEmissao.md)
 - [Model.CteSimpSefazAereoSimp](docs/CteSimpSefazAereoSimp.md)
 - [Model.CteSimpSefazAquavSimp](docs/CteSimpSefazAquavSimp.md)
 - [Model.CteSimpSefazAutXMLSimp](docs/CteSimpSefazAutXMLSimp.md)
 - [Model.CteSimpSefazBalsaSimp](docs/CteSimpSefazBalsaSimp.md)
 - [Model.CteSimpSefazCobrSimp](docs/CteSimpSefazCobrSimp.md)
 - [Model.CteSimpSefazCompSimp](docs/CteSimpSefazCompSimp.md)
 - [Model.CteSimpSefazComplSimp](docs/CteSimpSefazComplSimp.md)
 - [Model.CteSimpSefazDetContSimp](docs/CteSimpSefazDetContSimp.md)
 - [Model.CteSimpSefazDetSimp](docs/CteSimpSefazDetSimp.md)
 - [Model.CteSimpSefazDupSimp](docs/CteSimpSefazDupSimp.md)
 - [Model.CteSimpSefazDutoSimp](docs/CteSimpSefazDutoSimp.md)
 - [Model.CteSimpSefazEmiOccSimp](docs/CteSimpSefazEmiOccSimp.md)
 - [Model.CteSimpSefazEmitSimp](docs/CteSimpSefazEmitSimp.md)
 - [Model.CteSimpSefazEndeEmiSimp](docs/CteSimpSefazEndeEmiSimp.md)
 - [Model.CteSimpSefazEnderFerSimp](docs/CteSimpSefazEnderFerSimp.md)
 - [Model.CteSimpSefazEnderecoSimp](docs/CteSimpSefazEnderecoSimp.md)
 - [Model.CteSimpSefazFatSimp](docs/CteSimpSefazFatSimp.md)
 - [Model.CteSimpSefazFerroEnvSimp](docs/CteSimpSefazFerroEnvSimp.md)
 - [Model.CteSimpSefazFerrovSimp](docs/CteSimpSefazFerrovSimp.md)
 - [Model.CteSimpSefazFluxoSimp](docs/CteSimpSefazFluxoSimp.md)
 - [Model.CteSimpSefazICMS00Simp](docs/CteSimpSefazICMS00Simp.md)
 - [Model.CteSimpSefazICMS20Simp](docs/CteSimpSefazICMS20Simp.md)
 - [Model.CteSimpSefazICMS45Simp](docs/CteSimpSefazICMS45Simp.md)
 - [Model.CteSimpSefazICMS60Simp](docs/CteSimpSefazICMS60Simp.md)
 - [Model.CteSimpSefazICMS90Simp](docs/CteSimpSefazICMS90Simp.md)
 - [Model.CteSimpSefazICMSOutraUFSimp](docs/CteSimpSefazICMSOutraUFSimp.md)
 - [Model.CteSimpSefazICMSSNSimp](docs/CteSimpSefazICMSSNSimp.md)
 - [Model.CteSimpSefazICMSUFFimSimp](docs/CteSimpSefazICMSUFFimSimp.md)
 - [Model.CteSimpSefazIdeSimp](docs/CteSimpSefazIdeSimp.md)
 - [Model.CteSimpSefazImpSimp](docs/CteSimpSefazImpSimp.md)
 - [Model.CteSimpSefazInfCTeSuplSimp](docs/CteSimpSefazInfCTeSuplSimp.md)
 - [Model.CteSimpSefazInfCargaSimp](docs/CteSimpSefazInfCargaSimp.md)
 - [Model.CteSimpSefazInfCteImpSimp](docs/CteSimpSefazInfCteImpSimp.md)
 - [Model.CteSimpSefazInfCteSimp](docs/CteSimpSefazInfCteSimp.md)
 - [Model.CteSimpSefazInfCteSubSimp](docs/CteSimpSefazInfCteSubSimp.md)
 - [Model.CteSimpSefazInfDocAntSimp](docs/CteSimpSefazInfDocAntSimp.md)
 - [Model.CteSimpSefazInfDocInfNFeSimp](docs/CteSimpSefazInfDocInfNFeSimp.md)
 - [Model.CteSimpSefazInfDocSimp](docs/CteSimpSefazInfDocSimp.md)
 - [Model.CteSimpSefazInfModalSimp](docs/CteSimpSefazInfModalSimp.md)
 - [Model.CteSimpSefazInfNFSimp](docs/CteSimpSefazInfNFSimp.md)
 - [Model.CteSimpSefazInfNFeSimp](docs/CteSimpSefazInfNFeSimp.md)
 - [Model.CteSimpSefazInfNFeTranspParcialSimp](docs/CteSimpSefazInfNFeTranspParcialSimp.md)
 - [Model.CteSimpSefazInfQSimp](docs/CteSimpSefazInfQSimp.md)
 - [Model.CteSimpSefazInfSegSimp](docs/CteSimpSefazInfSegSimp.md)
 - [Model.CteSimpSefazInfSolicNFFSimp](docs/CteSimpSefazInfSolicNFFSimp.md)
 - [Model.CteSimpSefazInfTotAPSimp](docs/CteSimpSefazInfTotAPSimp.md)
 - [Model.CteSimpSefazLacUnidCargaSimp](docs/CteSimpSefazLacUnidCargaSimp.md)
 - [Model.CteSimpSefazLacUnidTranspSimp](docs/CteSimpSefazLacUnidTranspSimp.md)
 - [Model.CteSimpSefazLacreSimp](docs/CteSimpSefazLacreSimp.md)
 - [Model.CteSimpSefazMultimodalSimp](docs/CteSimpSefazMultimodalSimp.md)
 - [Model.CteSimpSefazNatCargaSimp](docs/CteSimpSefazNatCargaSimp.md)
 - [Model.CteSimpSefazObsContSimp](docs/CteSimpSefazObsContSimp.md)
 - [Model.CteSimpSefazObsFiscoSimp](docs/CteSimpSefazObsFiscoSimp.md)
 - [Model.CteSimpSefazOccSimp](docs/CteSimpSefazOccSimp.md)
 - [Model.CteSimpSefazPassSimp](docs/CteSimpSefazPassSimp.md)
 - [Model.CteSimpSefazPeriSimp](docs/CteSimpSefazPeriSimp.md)
 - [Model.CteSimpSefazRespTecSimp](docs/CteSimpSefazRespTecSimp.md)
 - [Model.CteSimpSefazRodoSimp](docs/CteSimpSefazRodoSimp.md)
 - [Model.CteSimpSefazSegSimp](docs/CteSimpSefazSegSimp.md)
 - [Model.CteSimpSefazTarifaSimp](docs/CteSimpSefazTarifaSimp.md)
 - [Model.CteSimpSefazTomaSimp](docs/CteSimpSefazTomaSimp.md)
 - [Model.CteSimpSefazTotalSimp](docs/CteSimpSefazTotalSimp.md)
 - [Model.CteSimpSefazTrafMutSimp](docs/CteSimpSefazTrafMutSimp.md)
 - [Model.CteSimpSefazUnidCargaSimp](docs/CteSimpSefazUnidCargaSimp.md)
 - [Model.CteSimpSefazUnidadeTranspSimp](docs/CteSimpSefazUnidadeTranspSimp.md)
 - [Model.DPS](docs/DPS.md)
 - [Model.DcePedidoCancelamento](docs/DcePedidoCancelamento.md)
 - [Model.DcePedidoEmissao](docs/DcePedidoEmissao.md)
 - [Model.DceSefazAutXML](docs/DceSefazAutXML.md)
 - [Model.DceSefazDest](docs/DceSefazDest.md)
 - [Model.DceSefazDet](docs/DceSefazDet.md)
 - [Model.DceSefazECT](docs/DceSefazECT.md)
 - [Model.DceSefazEmit](docs/DceSefazEmit.md)
 - [Model.DceSefazEndeDest](docs/DceSefazEndeDest.md)
 - [Model.DceSefazEndeEmi](docs/DceSefazEndeEmi.md)
 - [Model.DceSefazFisco](docs/DceSefazFisco.md)
 - [Model.DceSefazIde](docs/DceSefazIde.md)
 - [Model.DceSefazInfAdic](docs/DceSefazInfAdic.md)
 - [Model.DceSefazInfDCe](docs/DceSefazInfDCe.md)
 - [Model.DceSefazInfDec](docs/DceSefazInfDec.md)
 - [Model.DceSefazInfSolicDCe](docs/DceSefazInfSolicDCe.md)
 - [Model.DceSefazMarketplace](docs/DceSefazMarketplace.md)
 - [Model.DceSefazObsECT](docs/DceSefazObsECT.md)
 - [Model.DceSefazObsEmit](docs/DceSefazObsEmit.md)
 - [Model.DceSefazObsFisco](docs/DceSefazObsFisco.md)
 - [Model.DceSefazObsMarketplace](docs/DceSefazObsMarketplace.md)
 - [Model.DceSefazProd](docs/DceSefazProd.md)
 - [Model.DceSefazTotal](docs/DceSefazTotal.md)
 - [Model.DceSefazTransp](docs/DceSefazTransp.md)
 - [Model.DceSefazTransportadora](docs/DceSefazTransportadora.md)
 - [Model.Dfe](docs/Dfe.md)
 - [Model.DfeAutorEvento](docs/DfeAutorEvento.md)
 - [Model.DfeAutorizacao](docs/DfeAutorizacao.md)
 - [Model.DfeCancelamento](docs/DfeCancelamento.md)
 - [Model.DfeCartaCorrecao](docs/DfeCartaCorrecao.md)
 - [Model.DfeContribuinteEndereco](docs/DfeContribuinteEndereco.md)
 - [Model.DfeContribuinteInfCad](docs/DfeContribuinteInfCad.md)
 - [Model.DfeContribuinteInfCons](docs/DfeContribuinteInfCons.md)
 - [Model.DfeDebug](docs/DfeDebug.md)
 - [Model.DfeEvento](docs/DfeEvento.md)
 - [Model.DfeEventoListagem](docs/DfeEventoListagem.md)
 - [Model.DfeInutilizacao](docs/DfeInutilizacao.md)
 - [Model.DfeListagem](docs/DfeListagem.md)
 - [Model.DfeLote](docs/DfeLote.md)
 - [Model.DfeLoteListagem](docs/DfeLoteListagem.md)
 - [Model.DfePedidoEnvioEmail](docs/DfePedidoEnvioEmail.md)
 - [Model.DfePedidoInutilizacao](docs/DfePedidoInutilizacao.md)
 - [Model.DfeRecibo](docs/DfeRecibo.md)
 - [Model.DfeRequisicaoDebug](docs/DfeRequisicaoDebug.md)
 - [Model.DfeSefazStatus](docs/DfeSefazStatus.md)
 - [Model.DfeSincronizacao](docs/DfeSincronizacao.md)
 - [Model.DistribuicaoNfe](docs/DistribuicaoNfe.md)
 - [Model.DistribuicaoNfeDocumento](docs/DistribuicaoNfeDocumento.md)
 - [Model.DistribuicaoNfeDocumentoListagem](docs/DistribuicaoNfeDocumentoListagem.md)
 - [Model.DistribuicaoNfeEvento](docs/DistribuicaoNfeEvento.md)
 - [Model.DistribuicaoNfeListagem](docs/DistribuicaoNfeListagem.md)
 - [Model.DistribuicaoNfeNota](docs/DistribuicaoNfeNota.md)
 - [Model.DistribuicaoNfeNotaListagem](docs/DistribuicaoNfeNotaListagem.md)
 - [Model.DistribuicaoNfePedido](docs/DistribuicaoNfePedido.md)
 - [Model.DistribuicaoNfePedidoManifestacao](docs/DistribuicaoNfePedidoManifestacao.md)
 - [Model.DocDedRed](docs/DocDedRed.md)
 - [Model.DocNFNFS](docs/DocNFNFS.md)
 - [Model.DocOutNFSe](docs/DocOutNFSe.md)
 - [Model.Email](docs/Email.md)
 - [Model.EmailAttachment](docs/EmailAttachment.md)
 - [Model.EmailEvent](docs/EmailEvent.md)
 - [Model.EmailListagem](docs/EmailListagem.md)
 - [Model.EmailResumo](docs/EmailResumo.md)
 - [Model.EmailStatusResponse](docs/EmailStatusResponse.md)
 - [Model.Empresa](docs/Empresa.md)
 - [Model.EmpresaCertificado](docs/EmpresaCertificado.md)
 - [Model.EmpresaConfigCte](docs/EmpresaConfigCte.md)
 - [Model.EmpresaConfigCteOs](docs/EmpresaConfigCteOs.md)
 - [Model.EmpresaConfigDce](docs/EmpresaConfigDce.md)
 - [Model.EmpresaConfigDistribuicaoNfe](docs/EmpresaConfigDistribuicaoNfe.md)
 - [Model.EmpresaConfigMdfe](docs/EmpresaConfigMdfe.md)
 - [Model.EmpresaConfigNfce](docs/EmpresaConfigNfce.md)
 - [Model.EmpresaConfigNfceSefaz](docs/EmpresaConfigNfceSefaz.md)
 - [Model.EmpresaConfigNfcom](docs/EmpresaConfigNfcom.md)
 - [Model.EmpresaConfigNfe](docs/EmpresaConfigNfe.md)
 - [Model.EmpresaConfigNfse](docs/EmpresaConfigNfse.md)
 - [Model.EmpresaConfigNfseRegTrib](docs/EmpresaConfigNfseRegTrib.md)
 - [Model.EmpresaConfigPrefeitura](docs/EmpresaConfigPrefeitura.md)
 - [Model.EmpresaConfigRps](docs/EmpresaConfigRps.md)
 - [Model.EmpresaEndereco](docs/EmpresaEndereco.md)
 - [Model.EmpresaListagem](docs/EmpresaListagem.md)
 - [Model.EmpresaPedidoCadastroCertificado](docs/EmpresaPedidoCadastroCertificado.md)
 - [Model.EnderExt](docs/EnderExt.md)
 - [Model.EnderExtSimples](docs/EnderExtSimples.md)
 - [Model.EnderNac](docs/EnderNac.md)
 - [Model.Endereco](docs/Endereco.md)
 - [Model.EnderecoEmail](docs/EnderecoEmail.md)
 - [Model.EnderecoSimples](docs/EnderecoSimples.md)
 - [Model.ExigSuspensa](docs/ExigSuspensa.md)
 - [Model.ExploracaoRodoviaria](docs/ExploracaoRodoviaria.md)
 - [Model.HttpRequestDebug](docs/HttpRequestDebug.md)
 - [Model.InfDPS](docs/InfDPS.md)
 - [Model.InfoCompl](docs/InfoCompl.md)
 - [Model.InfoDedRed](docs/InfoDedRed.md)
 - [Model.InfoFornecDocDedRed](docs/InfoFornecDocDedRed.md)
 - [Model.InfoIntermediario](docs/InfoIntermediario.md)
 - [Model.InfoObra](docs/InfoObra.md)
 - [Model.InfoPrestador](docs/InfoPrestador.md)
 - [Model.InfoTomador](docs/InfoTomador.md)
 - [Model.InfoTributacao](docs/InfoTributacao.md)
 - [Model.InfoValores](docs/InfoValores.md)
 - [Model.ListaDocDedRed](docs/ListaDocDedRed.md)
 - [Model.LocPrest](docs/LocPrest.md)
 - [Model.LocacaoSublocacao](docs/LocacaoSublocacao.md)
 - [Model.ManifestacaoNfeListagem](docs/ManifestacaoNfeListagem.md)
 - [Model.MdfeDocumentoVinculado](docs/MdfeDocumentoVinculado.md)
 - [Model.MdfeEncerramento](docs/MdfeEncerramento.md)
 - [Model.MdfeInclusaoCondutor](docs/MdfeInclusaoCondutor.md)
 - [Model.MdfeInclusaoDfe](docs/MdfeInclusaoDfe.md)
 - [Model.MdfeNaoEncerrado](docs/MdfeNaoEncerrado.md)
 - [Model.MdfeNaoEncerrados](docs/MdfeNaoEncerrados.md)
 - [Model.MdfePedidoCancelamento](docs/MdfePedidoCancelamento.md)
 - [Model.MdfePedidoEmissao](docs/MdfePedidoEmissao.md)
 - [Model.MdfePedidoEmissaoLote](docs/MdfePedidoEmissaoLote.md)
 - [Model.MdfePedidoEncerramento](docs/MdfePedidoEncerramento.md)
 - [Model.MdfePedidoInclusaoCondutor](docs/MdfePedidoInclusaoCondutor.md)
 - [Model.MdfePedidoInclusaoDfe](docs/MdfePedidoInclusaoDfe.md)
 - [Model.MdfeSefazAereo](docs/MdfeSefazAereo.md)
 - [Model.MdfeSefazAquav](docs/MdfeSefazAquav.md)
 - [Model.MdfeSefazAutXML](docs/MdfeSefazAutXML.md)
 - [Model.MdfeSefazComp](docs/MdfeSefazComp.md)
 - [Model.MdfeSefazCondutor](docs/MdfeSefazCondutor.md)
 - [Model.MdfeSefazDisp](docs/MdfeSefazDisp.md)
 - [Model.MdfeSefazEmit](docs/MdfeSefazEmit.md)
 - [Model.MdfeSefazEndeEmi](docs/MdfeSefazEndeEmi.md)
 - [Model.MdfeSefazFerrov](docs/MdfeSefazFerrov.md)
 - [Model.MdfeSefazIde](docs/MdfeSefazIde.md)
 - [Model.MdfeSefazInfANTT](docs/MdfeSefazInfANTT.md)
 - [Model.MdfeSefazInfAdic](docs/MdfeSefazInfAdic.md)
 - [Model.MdfeSefazInfBanc](docs/MdfeSefazInfBanc.md)
 - [Model.MdfeSefazInfCIOT](docs/MdfeSefazInfCIOT.md)
 - [Model.MdfeSefazInfCTe](docs/MdfeSefazInfCTe.md)
 - [Model.MdfeSefazInfContratante](docs/MdfeSefazInfContratante.md)
 - [Model.MdfeSefazInfContrato](docs/MdfeSefazInfContrato.md)
 - [Model.MdfeSefazInfDoc](docs/MdfeSefazInfDoc.md)
 - [Model.MdfeSefazInfEmbComb](docs/MdfeSefazInfEmbComb.md)
 - [Model.MdfeSefazInfEntregaParcial](docs/MdfeSefazInfEntregaParcial.md)
 - [Model.MdfeSefazInfLocalCarrega](docs/MdfeSefazInfLocalCarrega.md)
 - [Model.MdfeSefazInfLocalDescarrega](docs/MdfeSefazInfLocalDescarrega.md)
 - [Model.MdfeSefazInfLotacao](docs/MdfeSefazInfLotacao.md)
 - [Model.MdfeSefazInfMDFe](docs/MdfeSefazInfMDFe.md)
 - [Model.MdfeSefazInfMDFeSupl](docs/MdfeSefazInfMDFeSupl.md)
 - [Model.MdfeSefazInfMDFeTransp](docs/MdfeSefazInfMDFeTransp.md)
 - [Model.MdfeSefazInfMDFeTranspPeri](docs/MdfeSefazInfMDFeTranspPeri.md)
 - [Model.MdfeSefazInfModal](docs/MdfeSefazInfModal.md)
 - [Model.MdfeSefazInfMunCarrega](docs/MdfeSefazInfMunCarrega.md)
 - [Model.MdfeSefazInfMunDescarga](docs/MdfeSefazInfMunDescarga.md)
 - [Model.MdfeSefazInfNFe](docs/MdfeSefazInfNFe.md)
 - [Model.MdfeSefazInfNFePeri](docs/MdfeSefazInfNFePeri.md)
 - [Model.MdfeSefazInfPag](docs/MdfeSefazInfPag.md)
 - [Model.MdfeSefazInfPercurso](docs/MdfeSefazInfPercurso.md)
 - [Model.MdfeSefazInfPrazo](docs/MdfeSefazInfPrazo.md)
 - [Model.MdfeSefazInfResp](docs/MdfeSefazInfResp.md)
 - [Model.MdfeSefazInfSeg](docs/MdfeSefazInfSeg.md)
 - [Model.MdfeSefazInfSolicNFF](docs/MdfeSefazInfSolicNFF.md)
 - [Model.MdfeSefazInfTermCarreg](docs/MdfeSefazInfTermCarreg.md)
 - [Model.MdfeSefazInfTermDescarreg](docs/MdfeSefazInfTermDescarreg.md)
 - [Model.MdfeSefazInfUnidCargaVazia](docs/MdfeSefazInfUnidCargaVazia.md)
 - [Model.MdfeSefazInfUnidTranspVazia](docs/MdfeSefazInfUnidTranspVazia.md)
 - [Model.MdfeSefazLacRodo](docs/MdfeSefazLacRodo.md)
 - [Model.MdfeSefazLacUnidCarga](docs/MdfeSefazLacUnidCarga.md)
 - [Model.MdfeSefazLacUnidTransp](docs/MdfeSefazLacUnidTransp.md)
 - [Model.MdfeSefazLacres](docs/MdfeSefazLacres.md)
 - [Model.MdfeSefazPeri](docs/MdfeSefazPeri.md)
 - [Model.MdfeSefazProdPred](docs/MdfeSefazProdPred.md)
 - [Model.MdfeSefazProp](docs/MdfeSefazProp.md)
 - [Model.MdfeSefazRespTec](docs/MdfeSefazRespTec.md)
 - [Model.MdfeSefazRodo](docs/MdfeSefazRodo.md)
 - [Model.MdfeSefazSeg](docs/MdfeSefazSeg.md)
 - [Model.MdfeSefazTot](docs/MdfeSefazTot.md)
 - [Model.MdfeSefazTrem](docs/MdfeSefazTrem.md)
 - [Model.MdfeSefazUnidCarga](docs/MdfeSefazUnidCarga.md)
 - [Model.MdfeSefazUnidadeTransp](docs/MdfeSefazUnidadeTransp.md)
 - [Model.MdfeSefazVag](docs/MdfeSefazVag.md)
 - [Model.MdfeSefazValePed](docs/MdfeSefazValePed.md)
 - [Model.MdfeSefazVeicReboque](docs/MdfeSefazVeicReboque.md)
 - [Model.MdfeSefazVeicReboqueProp](docs/MdfeSefazVeicReboqueProp.md)
 - [Model.MdfeSefazVeicTracao](docs/MdfeSefazVeicTracao.md)
 - [Model.NfcomPedidoCancelamento](docs/NfcomPedidoCancelamento.md)
 - [Model.NfcomPedidoEmissao](docs/NfcomPedidoEmissao.md)
 - [Model.NfcomSefazAssinante](docs/NfcomSefazAssinante.md)
 - [Model.NfcomSefazAutXML](docs/NfcomSefazAutXML.md)
 - [Model.NfcomSefazCOFINS](docs/NfcomSefazCOFINS.md)
 - [Model.NfcomSefazDest](docs/NfcomSefazDest.md)
 - [Model.NfcomSefazDet](docs/NfcomSefazDet.md)
 - [Model.NfcomSefazEmit](docs/NfcomSefazEmit.md)
 - [Model.NfcomSefazEndeDest](docs/NfcomSefazEndeDest.md)
 - [Model.NfcomSefazEndeEmi](docs/NfcomSefazEndeEmi.md)
 - [Model.NfcomSefazFUNTTEL](docs/NfcomSefazFUNTTEL.md)
 - [Model.NfcomSefazFUST](docs/NfcomSefazFUST.md)
 - [Model.NfcomSefazGCofat](docs/NfcomSefazGCofat.md)
 - [Model.NfcomSefazGCofatGNF](docs/NfcomSefazGCofatGNF.md)
 - [Model.NfcomSefazGFat](docs/NfcomSefazGFat.md)
 - [Model.NfcomSefazGFatCentral](docs/NfcomSefazGFatCentral.md)
 - [Model.NfcomSefazGFidelidade](docs/NfcomSefazGFidelidade.md)
 - [Model.NfcomSefazGNF](docs/NfcomSefazGNF.md)
 - [Model.NfcomSefazGPIX](docs/NfcomSefazGPIX.md)
 - [Model.NfcomSefazGProc](docs/NfcomSefazGProc.md)
 - [Model.NfcomSefazGProcRef](docs/NfcomSefazGProcRef.md)
 - [Model.NfcomSefazGRessarc](docs/NfcomSefazGRessarc.md)
 - [Model.NfcomSefazGSub](docs/NfcomSefazGSub.md)
 - [Model.NfcomSefazICMS00](docs/NfcomSefazICMS00.md)
 - [Model.NfcomSefazICMS20](docs/NfcomSefazICMS20.md)
 - [Model.NfcomSefazICMS40](docs/NfcomSefazICMS40.md)
 - [Model.NfcomSefazICMS51](docs/NfcomSefazICMS51.md)
 - [Model.NfcomSefazICMS90](docs/NfcomSefazICMS90.md)
 - [Model.NfcomSefazICMSSN](docs/NfcomSefazICMSSN.md)
 - [Model.NfcomSefazICMSTot](docs/NfcomSefazICMSTot.md)
 - [Model.NfcomSefazICMSUFDest](docs/NfcomSefazICMSUFDest.md)
 - [Model.NfcomSefazIde](docs/NfcomSefazIde.md)
 - [Model.NfcomSefazImposto](docs/NfcomSefazImposto.md)
 - [Model.NfcomSefazInfAdic](docs/NfcomSefazInfAdic.md)
 - [Model.NfcomSefazInfNFCom](docs/NfcomSefazInfNFCom.md)
 - [Model.NfcomSefazPIS](docs/NfcomSefazPIS.md)
 - [Model.NfcomSefazProd](docs/NfcomSefazProd.md)
 - [Model.NfcomSefazRespTec](docs/NfcomSefazRespTec.md)
 - [Model.NfcomSefazRetTrib](docs/NfcomSefazRetTrib.md)
 - [Model.NfcomSefazTotal](docs/NfcomSefazTotal.md)
 - [Model.NfcomSefazVRetTribTot](docs/NfcomSefazVRetTribTot.md)
 - [Model.NfePedidoCancelamento](docs/NfePedidoCancelamento.md)
 - [Model.NfePedidoCartaCorrecao](docs/NfePedidoCartaCorrecao.md)
 - [Model.NfePedidoEmissao](docs/NfePedidoEmissao.md)
 - [Model.NfePedidoEmissaoLote](docs/NfePedidoEmissaoLote.md)
 - [Model.NfeSefazAdi](docs/NfeSefazAdi.md)
 - [Model.NfeSefazAgropecuario](docs/NfeSefazAgropecuario.md)
 - [Model.NfeSefazArma](docs/NfeSefazArma.md)
 - [Model.NfeSefazAutXML](docs/NfeSefazAutXML.md)
 - [Model.NfeSefazAvulsa](docs/NfeSefazAvulsa.md)
 - [Model.NfeSefazCIDE](docs/NfeSefazCIDE.md)
 - [Model.NfeSefazCOFINS](docs/NfeSefazCOFINS.md)
 - [Model.NfeSefazCOFINSAliq](docs/NfeSefazCOFINSAliq.md)
 - [Model.NfeSefazCOFINSNT](docs/NfeSefazCOFINSNT.md)
 - [Model.NfeSefazCOFINSOutr](docs/NfeSefazCOFINSOutr.md)
 - [Model.NfeSefazCOFINSQtde](docs/NfeSefazCOFINSQtde.md)
 - [Model.NfeSefazCOFINSST](docs/NfeSefazCOFINSST.md)
 - [Model.NfeSefazCana](docs/NfeSefazCana.md)
 - [Model.NfeSefazCard](docs/NfeSefazCard.md)
 - [Model.NfeSefazCobr](docs/NfeSefazCobr.md)
 - [Model.NfeSefazComb](docs/NfeSefazComb.md)
 - [Model.NfeSefazCompra](docs/NfeSefazCompra.md)
 - [Model.NfeSefazDI](docs/NfeSefazDI.md)
 - [Model.NfeSefazDeduc](docs/NfeSefazDeduc.md)
 - [Model.NfeSefazDefensivo](docs/NfeSefazDefensivo.md)
 - [Model.NfeSefazDest](docs/NfeSefazDest.md)
 - [Model.NfeSefazDet](docs/NfeSefazDet.md)
 - [Model.NfeSefazDetExport](docs/NfeSefazDetExport.md)
 - [Model.NfeSefazDetPag](docs/NfeSefazDetPag.md)
 - [Model.NfeSefazDup](docs/NfeSefazDup.md)
 - [Model.NfeSefazEmit](docs/NfeSefazEmit.md)
 - [Model.NfeSefazEncerrante](docs/NfeSefazEncerrante.md)
 - [Model.NfeSefazEnderEmi](docs/NfeSefazEnderEmi.md)
 - [Model.NfeSefazEndereco](docs/NfeSefazEndereco.md)
 - [Model.NfeSefazExportInd](docs/NfeSefazExportInd.md)
 - [Model.NfeSefazExporta](docs/NfeSefazExporta.md)
 - [Model.NfeSefazFat](docs/NfeSefazFat.md)
 - [Model.NfeSefazForDia](docs/NfeSefazForDia.md)
 - [Model.NfeSefazGCred](docs/NfeSefazGCred.md)
 - [Model.NfeSefazGuiaTransito](docs/NfeSefazGuiaTransito.md)
 - [Model.NfeSefazICMS](docs/NfeSefazICMS.md)
 - [Model.NfeSefazICMS00](docs/NfeSefazICMS00.md)
 - [Model.NfeSefazICMS02](docs/NfeSefazICMS02.md)
 - [Model.NfeSefazICMS10](docs/NfeSefazICMS10.md)
 - [Model.NfeSefazICMS15](docs/NfeSefazICMS15.md)
 - [Model.NfeSefazICMS20](docs/NfeSefazICMS20.md)
 - [Model.NfeSefazICMS30](docs/NfeSefazICMS30.md)
 - [Model.NfeSefazICMS40](docs/NfeSefazICMS40.md)
 - [Model.NfeSefazICMS51](docs/NfeSefazICMS51.md)
 - [Model.NfeSefazICMS53](docs/NfeSefazICMS53.md)
 - [Model.NfeSefazICMS60](docs/NfeSefazICMS60.md)
 - [Model.NfeSefazICMS61](docs/NfeSefazICMS61.md)
 - [Model.NfeSefazICMS70](docs/NfeSefazICMS70.md)
 - [Model.NfeSefazICMS90](docs/NfeSefazICMS90.md)
 - [Model.NfeSefazICMSPart](docs/NfeSefazICMSPart.md)
 - [Model.NfeSefazICMSSN101](docs/NfeSefazICMSSN101.md)
 - [Model.NfeSefazICMSSN102](docs/NfeSefazICMSSN102.md)
 - [Model.NfeSefazICMSSN201](docs/NfeSefazICMSSN201.md)
 - [Model.NfeSefazICMSSN202](docs/NfeSefazICMSSN202.md)
 - [Model.NfeSefazICMSSN500](docs/NfeSefazICMSSN500.md)
 - [Model.NfeSefazICMSSN900](docs/NfeSefazICMSSN900.md)
 - [Model.NfeSefazICMSST](docs/NfeSefazICMSST.md)
 - [Model.NfeSefazICMSTot](docs/NfeSefazICMSTot.md)
 - [Model.NfeSefazICMSUFDest](docs/NfeSefazICMSUFDest.md)
 - [Model.NfeSefazII](docs/NfeSefazII.md)
 - [Model.NfeSefazIPINT](docs/NfeSefazIPINT.md)
 - [Model.NfeSefazIPITrib](docs/NfeSefazIPITrib.md)
 - [Model.NfeSefazISSQN](docs/NfeSefazISSQN.md)
 - [Model.NfeSefazISSQNtot](docs/NfeSefazISSQNtot.md)
 - [Model.NfeSefazIde](docs/NfeSefazIde.md)
 - [Model.NfeSefazImposto](docs/NfeSefazImposto.md)
 - [Model.NfeSefazImpostoDevol](docs/NfeSefazImpostoDevol.md)
 - [Model.NfeSefazImpostoDevolIPI](docs/NfeSefazImpostoDevolIPI.md)
 - [Model.NfeSefazInfAdic](docs/NfeSefazInfAdic.md)
 - [Model.NfeSefazInfAdicObsCont](docs/NfeSefazInfAdicObsCont.md)
 - [Model.NfeSefazInfAdicObsFisco](docs/NfeSefazInfAdicObsFisco.md)
 - [Model.NfeSefazInfIntermed](docs/NfeSefazInfIntermed.md)
 - [Model.NfeSefazInfNFe](docs/NfeSefazInfNFe.md)
 - [Model.NfeSefazInfNFeSupl](docs/NfeSefazInfNFeSupl.md)
 - [Model.NfeSefazInfProdEmb](docs/NfeSefazInfProdEmb.md)
 - [Model.NfeSefazInfProdNFF](docs/NfeSefazInfProdNFF.md)
 - [Model.NfeSefazInfRespTec](docs/NfeSefazInfRespTec.md)
 - [Model.NfeSefazInfSolicNFF](docs/NfeSefazInfSolicNFF.md)
 - [Model.NfeSefazIpi](docs/NfeSefazIpi.md)
 - [Model.NfeSefazLacres](docs/NfeSefazLacres.md)
 - [Model.NfeSefazLocal](docs/NfeSefazLocal.md)
 - [Model.NfeSefazMed](docs/NfeSefazMed.md)
 - [Model.NfeSefazNFref](docs/NfeSefazNFref.md)
 - [Model.NfeSefazObsCont](docs/NfeSefazObsCont.md)
 - [Model.NfeSefazObsFisco](docs/NfeSefazObsFisco.md)
 - [Model.NfeSefazObsItem](docs/NfeSefazObsItem.md)
 - [Model.NfeSefazOrigComb](docs/NfeSefazOrigComb.md)
 - [Model.NfeSefazPIS](docs/NfeSefazPIS.md)
 - [Model.NfeSefazPISAliq](docs/NfeSefazPISAliq.md)
 - [Model.NfeSefazPISNT](docs/NfeSefazPISNT.md)
 - [Model.NfeSefazPISOutr](docs/NfeSefazPISOutr.md)
 - [Model.NfeSefazPISQtde](docs/NfeSefazPISQtde.md)
 - [Model.NfeSefazPISST](docs/NfeSefazPISST.md)
 - [Model.NfeSefazPag](docs/NfeSefazPag.md)
 - [Model.NfeSefazProcRef](docs/NfeSefazProcRef.md)
 - [Model.NfeSefazProd](docs/NfeSefazProd.md)
 - [Model.NfeSefazRastro](docs/NfeSefazRastro.md)
 - [Model.NfeSefazRefECF](docs/NfeSefazRefECF.md)
 - [Model.NfeSefazRefNF](docs/NfeSefazRefNF.md)
 - [Model.NfeSefazRefNFP](docs/NfeSefazRefNFP.md)
 - [Model.NfeSefazRetTransp](docs/NfeSefazRetTransp.md)
 - [Model.NfeSefazRetTrib](docs/NfeSefazRetTrib.md)
 - [Model.NfeSefazTotal](docs/NfeSefazTotal.md)
 - [Model.NfeSefazTransp](docs/NfeSefazTransp.md)
 - [Model.NfeSefazTransporta](docs/NfeSefazTransporta.md)
 - [Model.NfeSefazVeicProd](docs/NfeSefazVeicProd.md)
 - [Model.NfeSefazVeiculo](docs/NfeSefazVeiculo.md)
 - [Model.NfeSefazVol](docs/NfeSefazVol.md)
 - [Model.Nfse](docs/Nfse.md)
 - [Model.NfseCancelamento](docs/NfseCancelamento.md)
 - [Model.NfseCidadeMetadados](docs/NfseCidadeMetadados.md)
 - [Model.NfseCidadesAtendidas](docs/NfseCidadesAtendidas.md)
 - [Model.NfseDpsPedidoEmissao](docs/NfseDpsPedidoEmissao.md)
 - [Model.NfseListagem](docs/NfseListagem.md)
 - [Model.NfseLoteDpsPedidoEmissao](docs/NfseLoteDpsPedidoEmissao.md)
 - [Model.NfseMensagemRetorno](docs/NfseMensagemRetorno.md)
 - [Model.NfsePedidoCancelamento](docs/NfsePedidoCancelamento.md)
 - [Model.NfsePedidoEmissao](docs/NfsePedidoEmissao.md)
 - [Model.NfsePedidoSincronizacao](docs/NfsePedidoSincronizacao.md)
 - [Model.NfseSincronizacao](docs/NfseSincronizacao.md)
 - [Model.RegTrib](docs/RegTrib.md)
 - [Model.Rps](docs/Rps.md)
 - [Model.RpsDados](docs/RpsDados.md)
 - [Model.RpsDadosConstrucaoCivil](docs/RpsDadosConstrucaoCivil.md)
 - [Model.RpsDadosIntermediario](docs/RpsDadosIntermediario.md)
 - [Model.RpsDadosPrestador](docs/RpsDadosPrestador.md)
 - [Model.RpsDadosServico](docs/RpsDadosServico.md)
 - [Model.RpsDadosTomador](docs/RpsDadosTomador.md)
 - [Model.RpsDadosTomadorEndereco](docs/RpsDadosTomadorEndereco.md)
 - [Model.RpsIdentificacao](docs/RpsIdentificacao.md)
 - [Model.RpsIdentificacaoPrestador](docs/RpsIdentificacaoPrestador.md)
 - [Model.RpsLote](docs/RpsLote.md)
 - [Model.RpsLoteListagem](docs/RpsLoteListagem.md)
 - [Model.RpsPedidoEmissao](docs/RpsPedidoEmissao.md)
 - [Model.RpsPedidoEmissaoLote](docs/RpsPedidoEmissaoLote.md)
 - [Model.RpsServicoValores](docs/RpsServicoValores.md)
 - [Model.Serv](docs/Serv.md)
 - [Model.Substituicao](docs/Substituicao.md)
 - [Model.TribFederal](docs/TribFederal.md)
 - [Model.TribMunicipal](docs/TribMunicipal.md)
 - [Model.TribOutrosPisCofins](docs/TribOutrosPisCofins.md)
 - [Model.TribTotal](docs/TribTotal.md)
 - [Model.TribTotalMonet](docs/TribTotalMonet.md)
 - [Model.TribTotalPercent](docs/TribTotalPercent.md)
 - [Model.VDescCondIncond](docs/VDescCondIncond.md)
 - [Model.VServPrest](docs/VServPrest.md)


<a name="documentation-for-authorization"></a>
## Documentação da autorização

<a name="jwt"></a>
### jwt

- **Tipo**: Access token
- **Nome do parâmetro do access token**: Authorization
- **Localização**: HTTP header

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: application
- **URL de autorização**: 
- **Scopes**: 
  - conta: 
  - empresa: 
  - cep: 
  - cnpj: 
  - mdfe: 
  - cte: 
  - nfse: 
  - nfe: 

