# Nuvem Fiscal: SDK para .NET

Biblioteca para uso da API da [Nuvem Fiscal](https://www.nuvemfiscal.com.br) com Microsoft .NET. 
Consultar também a [documentação oficial da Nuvem Fiscal](https://dev.nuvemfiscal.com.br/docs).

- Versão da API: 1.0
- Versão do SDK: 1.0.0

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

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new CepApi(yourHttpClient, yourHandler);
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
services.AddHttpClient<CepApi>(httpClient =>
   new CepApi(httpClient));
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
*CteApi* | [**BaixarXmlCancelamentoCte**](docs/CteApi.md#baixarxmlcancelamentocte) | **GET** /cte/{id}/cancelamento/xml | Baixar XML do cancelamento
*CteApi* | [**BaixarXmlCartaCorrecaoCte**](docs/CteApi.md#baixarxmlcartacorrecaocte) | **GET** /cte/{id}/carta-correcao/xml | Baixar XML da carta de correção
*CteApi* | [**BaixarXmlCte**](docs/CteApi.md#baixarxmlcte) | **GET** /cte/{id}/xml | Baixar XML do CT-e processado
*CteApi* | [**BaixarXmlEventoCte**](docs/CteApi.md#baixarxmleventocte) | **GET** /cte/eventos/{id}/xml | Baixar XML do evento
*CteApi* | [**BaixarXmlInutilizacaoCte**](docs/CteApi.md#baixarxmlinutilizacaocte) | **GET** /cte/inutilizacoes/{id}/xml | Baixar XML da inutilização
*CteApi* | [**CancelarCte**](docs/CteApi.md#cancelarcte) | **POST** /cte/{id}/cancelamento | Cancelar um CT-e autorizado
*CteApi* | [**ConsultarCancelamentoCte**](docs/CteApi.md#consultarcancelamentocte) | **GET** /cte/{id}/cancelamento | Consultar o cancelamento do CT-e
*CteApi* | [**ConsultarCartaCorrecaoCte**](docs/CteApi.md#consultarcartacorrecaocte) | **GET** /cte/{id}/carta-correcao | Consultar a solicitação de correção do CT-e
*CteApi* | [**ConsultarCte**](docs/CteApi.md#consultarcte) | **GET** /cte/{id} | Consultar CT-e
*CteApi* | [**ConsultarEventoCte**](docs/CteApi.md#consultareventocte) | **GET** /cte/eventos/{id} | Consultar evento
*CteApi* | [**ConsultarInutilizacaoCte**](docs/CteApi.md#consultarinutilizacaocte) | **GET** /cte/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração
*CteApi* | [**ConsultarLoteCte**](docs/CteApi.md#consultarlotecte) | **GET** /cte/lotes/{id} | Consultar lote de CT-e
*CteApi* | [**ConsultarStatusSefazCte**](docs/CteApi.md#consultarstatussefazcte) | **GET** /cte/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*CteApi* | [**CriarCartaCorrecaoCte**](docs/CteApi.md#criarcartacorrecaocte) | **POST** /cte/{id}/carta-correcao | Solicitar correção do CT-e
*CteApi* | [**EmitirCte**](docs/CteApi.md#emitircte) | **POST** /cte | Emitir CT-e
*CteApi* | [**EmitirLoteCte**](docs/CteApi.md#emitirlotecte) | **POST** /cte/lotes | Emitir lote de CT-e
*CteApi* | [**InutilizarCte**](docs/CteApi.md#inutilizarcte) | **POST** /cte/inutilizacoes | Inutilizar uma sequência de numeração de CT-e
*EmpresaApi* | [**AlterarConfigCte**](docs/EmpresaApi.md#alterarconfigcte) | **PUT** /empresas/{cpf_cnpj}/cte | Alterar configuração de CT-e
*EmpresaApi* | [**AlterarConfigMdfe**](docs/EmpresaApi.md#alterarconfigmdfe) | **PUT** /empresas/{cpf_cnpj}/mdfe | Alterar configuração de MDF-e
*EmpresaApi* | [**AlterarConfigNfce**](docs/EmpresaApi.md#alterarconfignfce) | **PUT** /empresas/{cpf_cnpj}/nfce | Alterar configuração de NFC-e
*EmpresaApi* | [**AlterarConfigNfe**](docs/EmpresaApi.md#alterarconfignfe) | **PUT** /empresas/{cpf_cnpj}/nfe | Alterar configuração de NF-e
*EmpresaApi* | [**AlterarConfigNfse**](docs/EmpresaApi.md#alterarconfignfse) | **PUT** /empresas/{cpf_cnpj}/nfse | Alterar configuração de NFS-e
*EmpresaApi* | [**AtualizarEmpresa**](docs/EmpresaApi.md#atualizarempresa) | **PUT** /empresas/{cpf_cnpj} | Alterar empresa
*EmpresaApi* | [**CadastrarCertificadoEmpresa**](docs/EmpresaApi.md#cadastrarcertificadoempresa) | **PUT** /empresas/{cpf_cnpj}/certificado | Cadastrar certificado
*EmpresaApi* | [**ConsultarCertificadoEmpresa**](docs/EmpresaApi.md#consultarcertificadoempresa) | **GET** /empresas/{cpf_cnpj}/certificado | Consultar certificado
*EmpresaApi* | [**ConsultarConfigCte**](docs/EmpresaApi.md#consultarconfigcte) | **GET** /empresas/{cpf_cnpj}/cte | Consultar configuração de CT-e
*EmpresaApi* | [**ConsultarConfigMdfe**](docs/EmpresaApi.md#consultarconfigmdfe) | **GET** /empresas/{cpf_cnpj}/mdfe | Consultar configuração de MDF-e
*EmpresaApi* | [**ConsultarConfigNfce**](docs/EmpresaApi.md#consultarconfignfce) | **GET** /empresas/{cpf_cnpj}/nfce | Consultar configuração de NFC-e
*EmpresaApi* | [**ConsultarConfigNfe**](docs/EmpresaApi.md#consultarconfignfe) | **GET** /empresas/{cpf_cnpj}/nfe | Consultar configuração de NF-e
*EmpresaApi* | [**ConsultarConfigNfse**](docs/EmpresaApi.md#consultarconfignfse) | **GET** /empresas/{cpf_cnpj}/nfse | Consultar configuração de NFS-e
*EmpresaApi* | [**ConsultarEmpresa**](docs/EmpresaApi.md#consultarempresa) | **GET** /empresas/{cpf_cnpj} | Consultar empresa
*EmpresaApi* | [**CriarEmpresa**](docs/EmpresaApi.md#criarempresa) | **POST** /empresas | Cadastrar empresa
*EmpresaApi* | [**EnviarCertificadoEmpresa**](docs/EmpresaApi.md#enviarcertificadoempresa) | **PUT** /empresas/{cpf_cnpj}/certificado/upload | Upload de certificado
*EmpresaApi* | [**ExcluirCertificadoEmpresa**](docs/EmpresaApi.md#excluircertificadoempresa) | **DELETE** /empresas/{cpf_cnpj}/certificado | Deletar certificado
*EmpresaApi* | [**ExcluirEmpresa**](docs/EmpresaApi.md#excluirempresa) | **DELETE** /empresas/{cpf_cnpj} | Deletar empresa
*EmpresaApi* | [**ListarEmpresas**](docs/EmpresaApi.md#listarempresas) | **GET** /empresas | Consultar empresas
*MdfeApi* | [**BaixarXmlCancelamentoMdfe**](docs/MdfeApi.md#baixarxmlcancelamentomdfe) | **GET** /mdfe/{id}/cancelamento/xml | Baixar XML do cancelamento
*MdfeApi* | [**BaixarXmlEncerramentoMdfe**](docs/MdfeApi.md#baixarxmlencerramentomdfe) | **GET** /mdfe/{id}/encerramento/xml | Baixar XML do encerramento
*MdfeApi* | [**BaixarXmlEventoMdfe**](docs/MdfeApi.md#baixarxmleventomdfe) | **GET** /mdfe/eventos/{id}/xml | Baixar XML do evento
*MdfeApi* | [**BaixarXmlMdfe**](docs/MdfeApi.md#baixarxmlmdfe) | **GET** /mdfe/{id}/xml | Baixar XML do MDF-e processado
*MdfeApi* | [**CancelarMdfe**](docs/MdfeApi.md#cancelarmdfe) | **POST** /mdfe/{id}/cancelamento | Cancelar um MDF-e autorizado
*MdfeApi* | [**ConsultarCancelamentoMdfe**](docs/MdfeApi.md#consultarcancelamentomdfe) | **GET** /mdfe/{id}/cancelamento | Consultar o cancelamento do MDF-e
*MdfeApi* | [**ConsultarEncerramentoMdfe**](docs/MdfeApi.md#consultarencerramentomdfe) | **GET** /mdfe/{id}/encerramento | Consultar encerramento do MDF-e
*MdfeApi* | [**ConsultarEventoMdfe**](docs/MdfeApi.md#consultareventomdfe) | **GET** /mdfe/eventos/{id} | Consultar evento do MDF-e
*MdfeApi* | [**ConsultarLoteMdfe**](docs/MdfeApi.md#consultarlotemdfe) | **GET** /mdfe/lotes/{id} | Consultar lote de MDF-e
*MdfeApi* | [**ConsultarMdfe**](docs/MdfeApi.md#consultarmdfe) | **GET** /mdfe/{id} | Consultar MDF-e
*MdfeApi* | [**ConsultarStatusSefazMdfe**](docs/MdfeApi.md#consultarstatussefazmdfe) | **GET** /mdfe/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*MdfeApi* | [**EmitirLoteMdfe**](docs/MdfeApi.md#emitirlotemdfe) | **POST** /mdfe/lotes | Emitir lote de MDF-e
*MdfeApi* | [**EmitirMdfe**](docs/MdfeApi.md#emitirmdfe) | **POST** /mdfe | Emitir MDF-e
*MdfeApi* | [**EncerrarMdfe**](docs/MdfeApi.md#encerrarmdfe) | **POST** /mdfe/{id}/encerramento | Encerrar um MDF-e autorizado
*MdfeApi* | [**IncluirCondutorMdfe**](docs/MdfeApi.md#incluircondutormdfe) | **POST** /mdfe/{id}/inclusao-condutor | Incluir um condutor em um MDF-e autorizado
*MdfeApi* | [**IncluirDfeMdfe**](docs/MdfeApi.md#incluirdfemdfe) | **POST** /mdfe/{id}/inclusao-dfe | Incluir um DF-e em um MDF-e autorizado
*NfceApi* | [**BaixarPdfNfce**](docs/NfceApi.md#baixarpdfnfce) | **GET** /nfce/{id}/pdf | Baixar PDF do DANFCE
*NfceApi* | [**BaixarXmlCancelamentoNfce**](docs/NfceApi.md#baixarxmlcancelamentonfce) | **GET** /nfce/{id}/cancelamento/xml | Baixar XML do cancelamento
*NfceApi* | [**BaixarXmlInutilizacaoNfce**](docs/NfceApi.md#baixarxmlinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id}/xml | Baixar XML da inutilização
*NfceApi* | [**BaixarXmlNfce**](docs/NfceApi.md#baixarxmlnfce) | **GET** /nfce/{id}/xml | Baixar XML da NFC-e processada
*NfceApi* | [**CancelarNfce**](docs/NfceApi.md#cancelarnfce) | **POST** /nfce/{id}/cancelamento | Cancelar uma NFC-e autorizada
*NfceApi* | [**ConsultarCancelamentoNfce**](docs/NfceApi.md#consultarcancelamentonfce) | **GET** /nfce/{id}/cancelamento | Consultar o cancelamento da NFC-e
*NfceApi* | [**ConsultarInutilizacaoNfce**](docs/NfceApi.md#consultarinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração
*NfceApi* | [**ConsultarLoteNfce**](docs/NfceApi.md#consultarlotenfce) | **GET** /nfce/lotes/{id} | Consultar lote de NFC-e
*NfceApi* | [**ConsultarNfce**](docs/NfceApi.md#consultarnfce) | **GET** /nfce/{id} | Consultar NFC-e
*NfceApi* | [**ConsultarStatusSefazNfce**](docs/NfceApi.md#consultarstatussefaznfce) | **GET** /nfce/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*NfceApi* | [**EmitirLoteNfce**](docs/NfceApi.md#emitirlotenfce) | **POST** /nfce/lotes | Emitir lote de NFC-e
*NfceApi* | [**EmitirNfce**](docs/NfceApi.md#emitirnfce) | **POST** /nfce | Emitir NFC-e
*NfceApi* | [**InutilizarNfce**](docs/NfceApi.md#inutilizarnfce) | **POST** /nfce/inutilizacoes | Inutilizar uma sequência de numeração de NFC-e
*NfeApi* | [**BaixarPdfNfe**](docs/NfeApi.md#baixarpdfnfe) | **GET** /nfe/{id}/pdf | Baixar PDF do DANFE
*NfeApi* | [**BaixarXmlCancelamentoNfe**](docs/NfeApi.md#baixarxmlcancelamentonfe) | **GET** /nfe/{id}/cancelamento/xml | Baixar XML do cancelamento
*NfeApi* | [**BaixarXmlCartaCorrecaoNfe**](docs/NfeApi.md#baixarxmlcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao/xml | Baixar XML da carta de correção
*NfeApi* | [**BaixarXmlEventoNfe**](docs/NfeApi.md#baixarxmleventonfe) | **GET** /nfe/eventos/{id}/xml | Baixar XML do evento
*NfeApi* | [**BaixarXmlInutilizacaoNfe**](docs/NfeApi.md#baixarxmlinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id}/xml | Baixar XML da inutilização
*NfeApi* | [**BaixarXmlNfe**](docs/NfeApi.md#baixarxmlnfe) | **GET** /nfe/{id}/xml | Baixar XML da NF-e processada
*NfeApi* | [**CancelarNfe**](docs/NfeApi.md#cancelarnfe) | **POST** /nfe/{id}/cancelamento | Cancelar uma NF-e autorizada
*NfeApi* | [**ConsultarCancelamentoNfe**](docs/NfeApi.md#consultarcancelamentonfe) | **GET** /nfe/{id}/cancelamento | Consultar o cancelamento da NF-e
*NfeApi* | [**ConsultarCartaCorrecaoNfe**](docs/NfeApi.md#consultarcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao | Consultar a solicitação de correção da NF-e
*NfeApi* | [**ConsultarEventoNfe**](docs/NfeApi.md#consultareventonfe) | **GET** /nfe/eventos/{id} | Consultar evento
*NfeApi* | [**ConsultarInutilizacaoNfe**](docs/NfeApi.md#consultarinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração
*NfeApi* | [**ConsultarLoteNfe**](docs/NfeApi.md#consultarlotenfe) | **GET** /nfe/lotes/{id} | Consultar lote de NF-e
*NfeApi* | [**ConsultarNfe**](docs/NfeApi.md#consultarnfe) | **GET** /nfe/{id} | Consultar NF-e
*NfeApi* | [**ConsultarStatusSefazNfe**](docs/NfeApi.md#consultarstatussefaznfe) | **GET** /nfe/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora
*NfeApi* | [**CriarCartaCorrecaoNfe**](docs/NfeApi.md#criarcartacorrecaonfe) | **POST** /nfe/{id}/carta-correcao | Solicitar correção da NF-e
*NfeApi* | [**EmitirLoteNfe**](docs/NfeApi.md#emitirlotenfe) | **POST** /nfe/lotes | Emitir lote de NF-e
*NfeApi* | [**EmitirNfe**](docs/NfeApi.md#emitirnfe) | **POST** /nfe | Emitir NF-e
*NfeApi* | [**InutilizarNfe**](docs/NfeApi.md#inutilizarnfe) | **POST** /nfe/inutilizacoes | Inutilizar uma sequência de numeração de NF-e
*NfseApi* | [**BaixarXmlNfse**](docs/NfseApi.md#baixarxmlnfse) | **GET** /nfse/{id}/xml | 
*NfseApi* | [**CancelarNfse**](docs/NfseApi.md#cancelarnfse) | **POST** /nfse/{id}/cancelamento | 
*NfseApi* | [**ConsultarCancelamentoNfse**](docs/NfseApi.md#consultarcancelamentonfse) | **GET** /nfse/{id}/cancelamento | 
*NfseApi* | [**ConsultarLoteNfse**](docs/NfseApi.md#consultarlotenfse) | **GET** /nfse/lotes/{id} | 
*NfseApi* | [**ConsultarNfse**](docs/NfseApi.md#consultarnfse) | **GET** /nfse/{id} | 
*NfseApi* | [**EmitirLoteNfse**](docs/NfseApi.md#emitirlotenfse) | **POST** /nfse/lotes | 
*NfseApi* | [**EmitirNfse**](docs/NfseApi.md#emitirnfse) | **POST** /nfse | 
*NfseApi* | [**ListarLotesNfse**](docs/NfseApi.md#listarlotesnfse) | **GET** /nfse/lotes | 
*NfseApi* | [**ListarNfse**](docs/NfseApi.md#listarnfse) | **GET** /nfse | 


<a name="documentation-for-models"></a>
## Documentação dos DTOs

 - [Model.CepEndereco](docs/CepEndereco.md)
 - [Model.CnpjCnae](docs/CnpjCnae.md)
 - [Model.CnpjEmpresa](docs/CnpjEmpresa.md)
 - [Model.CnpjEndereco](docs/CnpjEndereco.md)
 - [Model.CnpjMunicipio](docs/CnpjMunicipio.md)
 - [Model.CnpjNaturezaJuridica](docs/CnpjNaturezaJuridica.md)
 - [Model.CnpjOpcaoSimples](docs/CnpjOpcaoSimples.md)
 - [Model.CnpjPais](docs/CnpjPais.md)
 - [Model.CnpjPorteEmpresa](docs/CnpjPorteEmpresa.md)
 - [Model.CnpjSituacaoCadastral](docs/CnpjSituacaoCadastral.md)
 - [Model.CnpjTelefone](docs/CnpjTelefone.md)
 - [Model.CteCartaCorrecao](docs/CteCartaCorrecao.md)
 - [Model.CteInfCorrecao](docs/CteInfCorrecao.md)
 - [Model.CtePedidoCancelamento](docs/CtePedidoCancelamento.md)
 - [Model.CtePedidoCartaCorrecao](docs/CtePedidoCartaCorrecao.md)
 - [Model.CtePedidoEmissao](docs/CtePedidoEmissao.md)
 - [Model.CtePedidoEmissaoLote](docs/CtePedidoEmissaoLote.md)
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
 - [Model.CteSefazInfCteAnu](docs/CteSefazInfCteAnu.md)
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
 - [Model.CteSefazRefNF](docs/CteSefazRefNF.md)
 - [Model.CteSefazRem](docs/CteSefazRem.md)
 - [Model.CteSefazRespTec](docs/CteSefazRespTec.md)
 - [Model.CteSefazRodo](docs/CteSefazRodo.md)
 - [Model.CteSefazSeg](docs/CteSefazSeg.md)
 - [Model.CteSefazSemData](docs/CteSefazSemData.md)
 - [Model.CteSefazSemHora](docs/CteSefazSemHora.md)
 - [Model.CteSefazTarifa](docs/CteSefazTarifa.md)
 - [Model.CteSefazToma3](docs/CteSefazToma3.md)
 - [Model.CteSefazToma4](docs/CteSefazToma4.md)
 - [Model.CteSefazTomaICMS](docs/CteSefazTomaICMS.md)
 - [Model.CteSefazTrafMut](docs/CteSefazTrafMut.md)
 - [Model.CteSefazUnidCarga](docs/CteSefazUnidCarga.md)
 - [Model.CteSefazUnidadeTransp](docs/CteSefazUnidadeTransp.md)
 - [Model.CteSefazVPrest](docs/CteSefazVPrest.md)
 - [Model.CteSefazVeicNovos](docs/CteSefazVeicNovos.md)
 - [Model.Dfe](docs/Dfe.md)
 - [Model.DfeAutorEvento](docs/DfeAutorEvento.md)
 - [Model.DfeAutorizacao](docs/DfeAutorizacao.md)
 - [Model.DfeCancelamento](docs/DfeCancelamento.md)
 - [Model.DfeCartaCorrecao](docs/DfeCartaCorrecao.md)
 - [Model.DfeEvento](docs/DfeEvento.md)
 - [Model.DfeInutilizacao](docs/DfeInutilizacao.md)
 - [Model.DfeLote](docs/DfeLote.md)
 - [Model.DfePedidoInutilizacao](docs/DfePedidoInutilizacao.md)
 - [Model.DfeRecibo](docs/DfeRecibo.md)
 - [Model.DfeSefazStatus](docs/DfeSefazStatus.md)
 - [Model.DfeVisaoGeralSefazStatus](docs/DfeVisaoGeralSefazStatus.md)
 - [Model.Empresa](docs/Empresa.md)
 - [Model.EmpresaCertificado](docs/EmpresaCertificado.md)
 - [Model.EmpresaConfigCte](docs/EmpresaConfigCte.md)
 - [Model.EmpresaConfigMdfe](docs/EmpresaConfigMdfe.md)
 - [Model.EmpresaConfigNfce](docs/EmpresaConfigNfce.md)
 - [Model.EmpresaConfigNfceSefaz](docs/EmpresaConfigNfceSefaz.md)
 - [Model.EmpresaConfigNfe](docs/EmpresaConfigNfe.md)
 - [Model.EmpresaConfigNfse](docs/EmpresaConfigNfse.md)
 - [Model.EmpresaConfigPrefeitura](docs/EmpresaConfigPrefeitura.md)
 - [Model.EmpresaConfigRps](docs/EmpresaConfigRps.md)
 - [Model.EmpresaEndereco](docs/EmpresaEndereco.md)
 - [Model.EmpresaListagem](docs/EmpresaListagem.md)
 - [Model.EmpresaPedidoCadastroCertificado](docs/EmpresaPedidoCadastroCertificado.md)
 - [Model.MdfeDocumentoVinculado](docs/MdfeDocumentoVinculado.md)
 - [Model.MdfeEncerramento](docs/MdfeEncerramento.md)
 - [Model.MdfeInclusaoCondutor](docs/MdfeInclusaoCondutor.md)
 - [Model.MdfeInclusaoDfe](docs/MdfeInclusaoDfe.md)
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
 - [Model.NfePedidoCancelamento](docs/NfePedidoCancelamento.md)
 - [Model.NfePedidoCartaCorrecao](docs/NfePedidoCartaCorrecao.md)
 - [Model.NfePedidoEmissao](docs/NfePedidoEmissao.md)
 - [Model.NfePedidoEmissaoLote](docs/NfePedidoEmissaoLote.md)
 - [Model.NfeSefazAdi](docs/NfeSefazAdi.md)
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
 - [Model.NfeSefazICMS](docs/NfeSefazICMS.md)
 - [Model.NfeSefazICMS00](docs/NfeSefazICMS00.md)
 - [Model.NfeSefazICMS10](docs/NfeSefazICMS10.md)
 - [Model.NfeSefazICMS20](docs/NfeSefazICMS20.md)
 - [Model.NfeSefazICMS30](docs/NfeSefazICMS30.md)
 - [Model.NfeSefazICMS40](docs/NfeSefazICMS40.md)
 - [Model.NfeSefazICMS51](docs/NfeSefazICMS51.md)
 - [Model.NfeSefazICMS60](docs/NfeSefazICMS60.md)
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
 - [Model.NfseListagem](docs/NfseListagem.md)
 - [Model.NfseMensagemRetorno](docs/NfseMensagemRetorno.md)
 - [Model.NfsePedidoEmissao](docs/NfsePedidoEmissao.md)
 - [Model.Rps](docs/Rps.md)
 - [Model.RpsDados](docs/RpsDados.md)
 - [Model.RpsDadosConstrucaoCivil](docs/RpsDadosConstrucaoCivil.md)
 - [Model.RpsDadosIntermediario](docs/RpsDadosIntermediario.md)
 - [Model.RpsDadosPrestador](docs/RpsDadosPrestador.md)
 - [Model.RpsDadosServico](docs/RpsDadosServico.md)
 - [Model.RpsDadosTomador](docs/RpsDadosTomador.md)
 - [Model.RpsIdentificacao](docs/RpsIdentificacao.md)
 - [Model.RpsIdentificacaoPrestador](docs/RpsIdentificacaoPrestador.md)
 - [Model.RpsLote](docs/RpsLote.md)
 - [Model.RpsLoteListagem](docs/RpsLoteListagem.md)
 - [Model.RpsPedidoEmissao](docs/RpsPedidoEmissao.md)
 - [Model.RpsPedidoEmissaoLote](docs/RpsPedidoEmissaoLote.md)
 - [Model.RpsServicoValores](docs/RpsServicoValores.md)


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
  - empresa: 
  - cep: 
  - cnpj: 
  - mdfe: 
  - cte: 
  - nfse: 
  - nfe: 

