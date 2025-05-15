# NuvemFiscal.Sdk.Api.DistribuioNFEApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**BaixarPdfDocumentoDistribuicaoNfe**](DistribuioNFEApi.md#baixarpdfdocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos/{id}/pdf | Baixar PDF do documento |
| [**BaixarXmlDocumentoDistribuicaoNfe**](DistribuioNFEApi.md#baixarxmldocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos/{id}/xml | Baixar XML do documento |
| [**ConsultarDistribuicaoNfe**](DistribuioNFEApi.md#consultardistribuicaonfe) | **GET** /distribuicao/nfe/{id} | Consultar distribuição |
| [**ConsultarDocumentoDistribuicaoNfe**](DistribuioNFEApi.md#consultardocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos/{id} | Consultar documento |
| [**ConsultarManifestacaoNfe**](DistribuioNFEApi.md#consultarmanifestacaonfe) | **GET** /distribuicao/nfe/manifestacoes/{id} | Consultar manifestação |
| [**GerarDistribuicaoNfe**](DistribuioNFEApi.md#gerardistribuicaonfe) | **POST** /distribuicao/nfe | Distribuir documentos |
| [**ListarDistribuicaoNfe**](DistribuioNFEApi.md#listardistribuicaonfe) | **GET** /distribuicao/nfe | Listar distribuições |
| [**ListarDocumentoDistribuicaoNfe**](DistribuioNFEApi.md#listardocumentodistribuicaonfe) | **GET** /distribuicao/nfe/documentos | Listar documentos |
| [**ListarManifestacaoNfe**](DistribuioNFEApi.md#listarmanifestacaonfe) | **GET** /distribuicao/nfe/manifestacoes | Listar Manifestações |
| [**ListarNfeSemManifestacao**](DistribuioNFEApi.md#listarnfesemmanifestacao) | **GET** /distribuicao/nfe/notas-sem-manifestacao | Listar notas sem manifestação |
| [**ManifestarNfe**](DistribuioNFEApi.md#manifestarnfe) | **POST** /distribuicao/nfe/manifestacoes | Manifestar nota |

<a name="baixarpdfdocumentodistribuicaonfe"></a>
# **BaixarPdfDocumentoDistribuicaoNfe**
> FileParameter BaixarPdfDocumentoDistribuicaoNfe (string id)

Baixar PDF do documento

Utilize esse endpoint para obter o PDF do documento.    Schemas suportados:  * procNFe_v4.00.xsd

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class BaixarPdfDocumentoDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do documento gerado pela Nuvem Fiscal.

            try
            {
                // Baixar PDF do documento
                FileParameter result = apiInstance.BaixarPdfDocumentoDistribuicaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.BaixarPdfDocumentoDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarPdfDocumentoDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar PDF do documento
    ApiResponse<FileParameter> response = apiInstance.BaixarPdfDocumentoDistribuicaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.BaixarPdfDocumentoDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do documento gerado pela Nuvem Fiscal. |  |

### Tipo de retorno

[**FileParameter**](FileParameter.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: */*


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="baixarxmldocumentodistribuicaonfe"></a>
# **BaixarXmlDocumentoDistribuicaoNfe**
> FileParameter BaixarXmlDocumentoDistribuicaoNfe (string id)

Baixar XML do documento

Utilize esse endpoint para obter o XML das informações resumidas ou documento fiscal de interesse da pessoa ou empresa interessada.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class BaixarXmlDocumentoDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do documento gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML do documento
                FileParameter result = apiInstance.BaixarXmlDocumentoDistribuicaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.BaixarXmlDocumentoDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlDocumentoDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do documento
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlDocumentoDistribuicaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.BaixarXmlDocumentoDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do documento gerado pela Nuvem Fiscal. |  |

### Tipo de retorno

[**FileParameter**](FileParameter.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: */*


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="consultardistribuicaonfe"></a>
# **ConsultarDistribuicaoNfe**
> DistribuicaoNfe ConsultarDistribuicaoNfe (string id)

Consultar distribuição

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ConsultarDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da distribuição de NF-e gerada pela Nuvem Fiscal.

            try
            {
                // Consultar distribuição
                DistribuicaoNfe result = apiInstance.ConsultarDistribuicaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ConsultarDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar distribuição
    ApiResponse<DistribuicaoNfe> response = apiInstance.ConsultarDistribuicaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ConsultarDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da distribuição de NF-e gerada pela Nuvem Fiscal. |  |

### Tipo de retorno

[**DistribuicaoNfe**](DistribuicaoNfe.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="consultardocumentodistribuicaonfe"></a>
# **ConsultarDocumentoDistribuicaoNfe**
> DistribuicaoNfeDocumento ConsultarDocumentoDistribuicaoNfe (string id)

Consultar documento

Utilize esse endpoint para obter as informações resumidas ou documento fiscal de interesse da pessoa ou empresa interessada.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ConsultarDocumentoDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do documento gerado pela Nuvem Fiscal.

            try
            {
                // Consultar documento
                DistribuicaoNfeDocumento result = apiInstance.ConsultarDocumentoDistribuicaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ConsultarDocumentoDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarDocumentoDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar documento
    ApiResponse<DistribuicaoNfeDocumento> response = apiInstance.ConsultarDocumentoDistribuicaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ConsultarDocumentoDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do documento gerado pela Nuvem Fiscal. |  |

### Tipo de retorno

[**DistribuicaoNfeDocumento**](DistribuicaoNfeDocumento.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="consultarmanifestacaonfe"></a>
# **ConsultarManifestacaoNfe**
> DistribuicaoNfeEvento ConsultarManifestacaoNfe (string id)

Consultar manifestação

Consulta os detalhes de uma manifestação de NF-e já existente. Forneça o ID único obtido de uma requisição de manifestação ou de listagem de manifestações e a Nuvem Fiscal irá retornar as informações da manifestação correspondente.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ConsultarManifestacaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da manifestação gerado pela Nuvem Fiscal.

            try
            {
                // Consultar manifestação
                DistribuicaoNfeEvento result = apiInstance.ConsultarManifestacaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ConsultarManifestacaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarManifestacaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar manifestação
    ApiResponse<DistribuicaoNfeEvento> response = apiInstance.ConsultarManifestacaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ConsultarManifestacaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da manifestação gerado pela Nuvem Fiscal. |  |

### Tipo de retorno

[**DistribuicaoNfeEvento**](DistribuicaoNfeEvento.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="gerardistribuicaonfe"></a>
# **GerarDistribuicaoNfe**
> DistribuicaoNfe GerarDistribuicaoNfe (DistribuicaoNfePedido body)

Distribuir documentos

Este endpoint permite que o destinatário obtenha Documentos Fiscais  Eletrônicos (DF-e) emitidos contra o seu CNPJ ou CPF ou que seja de  seu interesse. A distribuição pode ser feita de três formas:  *dist-nsu*, *cons-nsu* e *cons-chave*.    **Formas de Consulta**:  - *dist-nsu*: Consulta pelo último NSU recebido.  - *cons-nsu*: Consulta por um NSU específico.  - *cons-chave*: Consulta pela chave de acesso da NF-e.    **Retorno da Solicitação**    A resposta da solicitação inclui a propriedade *status* no JSON, que  pode ter os seguintes valores:  - *processando*: A solicitação está em andamento.  - *concluido*: A solicitação foi processada com sucesso.  - *erro*: Ocorreu um erro no processamento da solicitação.    Se o status retornado for *processando*, significa que a solicitação está  sendo realizada de forma assíncrona pela API. Nesse caso, o usuário deverá  adotar um fluxo que consiste em requisitar periodicamente o endpoint  <a href=\"#tag/Distribuicao-NF-e/operation/ConsultarDistribuicaoNfe\">consultar distribuição</a> até que  a API retorne o pedido com um status indicando o fim do  processamento (concluido ou erro).    **Informações adicionais**:  - Cota: <a href=\"/docs/limites#dfe-eventos\">dfe-eventos</a>  - Consumo: 1 unidade por documento distribuído (retornado) ou requisição.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class GerarDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var body = new DistribuicaoNfePedido(); // DistribuicaoNfePedido | 

            try
            {
                // Distribuir documentos
                DistribuicaoNfe result = apiInstance.GerarDistribuicaoNfe(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.GerarDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante GerarDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Distribuir documentos
    ApiResponse<DistribuicaoNfe> response = apiInstance.GerarDistribuicaoNfeWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.GerarDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**DistribuicaoNfePedido**](DistribuicaoNfePedido.md) |  |  |

### Tipo de retorno

[**DistribuicaoNfe**](DistribuicaoNfe.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: application/json
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listardistribuicaonfe"></a>
# **ListarDistribuicaoNfe**
> DistribuicaoNfeListagem ListarDistribuicaoNfe (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null)

Listar distribuições

Retorna a lista de distribuições de NF-e de acordo com os critérios de busca utilizados. As distribuições são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ListarDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ da pessoa ou empresa interessada.    Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = false;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional)  (default to false)

            try
            {
                // Listar distribuições
                DistribuicaoNfeListagem result = apiInstance.ListarDistribuicaoNfe(cpfCnpj, ambiente, top, skip, inlinecount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ListarDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar distribuições
    ApiResponse<DistribuicaoNfeListagem> response = apiInstance.ListarDistribuicaoNfeWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ListarDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ da pessoa ou empresa interessada.    Utilize o valor sem máscara. |  |
| **ambiente** | **string** | Identificação do Ambiente.    Valores aceitos: homologacao, producao |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional] [default to false] |

### Tipo de retorno

[**DistribuicaoNfeListagem**](DistribuicaoNfeListagem.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listardocumentodistribuicaonfe"></a>
# **ListarDocumentoDistribuicaoNfe**
> DistribuicaoNfeDocumentoListagem ListarDocumentoDistribuicaoNfe (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null, long? distNsu = null, string tipoDocumento = null, string formaDistribuicao = null, string chaveAcesso = null)

Listar documentos

Retorna a lista de documentos fiscais eletrônicos de interesse da pessoa ou empresa de acordo com os critérios de busca utilizados. Os documentos são retornadas ordenados pela data da criação, com os mais recentes aparecendo primeiro.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ListarDocumentoDistribuicaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ da pessoa ou empresa interessada.    Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = false;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional)  (default to false)
            var distNsu = 789L;  // long? | Filtrar por documentos a partir do NSU informado. (optional) 
            var tipoDocumento = "tipoDocumento_example";  // string | Filtrar pelo tipo do documento de interesse da pessoa ou empresa.    Valores aceitos: `nota`, `evento` (optional) 
            var formaDistribuicao = "formaDistribuicao_example";  // string | Filtrar por documentos que foram distribuídos em sua forma resumida ou completa.    Valores aceitos: `resumida`, `completa` (optional) 
            var chaveAcesso = "chaveAcesso_example";  // string | Filtrar pela chave de acesso da NF-e. (optional) 

            try
            {
                // Listar documentos
                DistribuicaoNfeDocumentoListagem result = apiInstance.ListarDocumentoDistribuicaoNfe(cpfCnpj, ambiente, top, skip, inlinecount, distNsu, tipoDocumento, formaDistribuicao, chaveAcesso);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ListarDocumentoDistribuicaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarDocumentoDistribuicaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar documentos
    ApiResponse<DistribuicaoNfeDocumentoListagem> response = apiInstance.ListarDocumentoDistribuicaoNfeWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, distNsu, tipoDocumento, formaDistribuicao, chaveAcesso);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ListarDocumentoDistribuicaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ da pessoa ou empresa interessada.    Utilize o valor sem máscara. |  |
| **ambiente** | **string** | Identificação do Ambiente.    Valores aceitos: homologacao, producao |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional] [default to false] |
| **distNsu** | **long?** | Filtrar por documentos a partir do NSU informado. | [optional]  |
| **tipoDocumento** | **string** | Filtrar pelo tipo do documento de interesse da pessoa ou empresa.    Valores aceitos: &#x60;nota&#x60;, &#x60;evento&#x60; | [optional]  |
| **formaDistribuicao** | **string** | Filtrar por documentos que foram distribuídos em sua forma resumida ou completa.    Valores aceitos: &#x60;resumida&#x60;, &#x60;completa&#x60; | [optional]  |
| **chaveAcesso** | **string** | Filtrar pela chave de acesso da NF-e. | [optional]  |

### Tipo de retorno

[**DistribuicaoNfeDocumentoListagem**](DistribuicaoNfeDocumentoListagem.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listarmanifestacaonfe"></a>
# **ListarManifestacaoNfe**
> ManifestacaoNfeListagem ListarManifestacaoNfe (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null)

Listar Manifestações

Retorna a lista de manifestações de NF-e de acordo com os critérios de busca utilizados. As manifestações são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ListarManifestacaoNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do autor do evento.    Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = false;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional)  (default to false)

            try
            {
                // Listar Manifestações
                ManifestacaoNfeListagem result = apiInstance.ListarManifestacaoNfe(cpfCnpj, ambiente, top, skip, inlinecount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ListarManifestacaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarManifestacaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar Manifestações
    ApiResponse<ManifestacaoNfeListagem> response = apiInstance.ListarManifestacaoNfeWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ListarManifestacaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ do autor do evento.    Utilize o valor sem máscara. |  |
| **ambiente** | **string** | Identificação do Ambiente.    Valores aceitos: homologacao, producao |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional] [default to false] |

### Tipo de retorno

[**ManifestacaoNfeListagem**](ManifestacaoNfeListagem.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listarnfesemmanifestacao"></a>
# **ListarNfeSemManifestacao**
> DistribuicaoNfeNotaListagem ListarNfeSemManifestacao (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null, bool? conclusiva = null)

Listar notas sem manifestação

No processo de distribuição de DF-e, as notas fiscais eletrônicas (NF-e)  são inicialmente disponibilizadas de forma resumida. Para obter o XML  completo, o destinatário deve manifestar a ciência da operação e,  posteriormente, uma manifestação conclusiva dentro de um prazo legal.    Para facilitar essa gestão e o cumprimento dos prazos legais de manifestação,  a API da Nuvem Fiscal permite listar as notas que ainda não  possuem manifestação, ajudando os usuários a identificar rapidamente as  notas que necessitam de ação.    O usuário pode optar por listar apenas as notas que não possuem manifestação  conclusiva ou que não possuem qualquer tipo de manifestação. Essa flexibilidade  permite um controle mais preciso e adequado às necessidades operacionais  de cada empresa.    Os documentos são retornados ordenados decrescentemente pela data de  distribuição, permitindo uma visualização clara e organizada das notas  mais recentes.    **Cenários de uso:**  * Identificar rapidamente as notas que ainda precisam de manifestação para obter o XML completo.  * Listar todas as notas fiscais eletrônicas que foram registradas com ciência da operação, mas ainda não possuem uma manifestação conclusiva (confirmação da operação, desconhecimento da operação ou operação não realizada).  * Listar todas as notas fiscais eletrônicas que não possuem nenhum tipo de manifestação registrada (nem ciência da operação, nem manifestação conclusiva).

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ListarNfeSemManifestacaoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ da pessoa ou empresa interessada.    Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = false;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional)  (default to false)
            var conclusiva = false;  // bool? | Indica se serão consideradas apenas as manifestações conclusivas.    Valores:  * `false`: serão retornadas notas que não possuírem qualquer tipo de    manifestação.    * `true`: apenas as notas que não possuírem manifestação conclusiva    serão retornadas. Ou seja, notas que tenham sido manifestadas apenas    com Ciência da Operação (210210) continuarão sendo retornadas por    esse endpoint até que recebam uma manifestação conclusiva. (optional)  (default to false)

            try
            {
                // Listar notas sem manifestação
                DistribuicaoNfeNotaListagem result = apiInstance.ListarNfeSemManifestacao(cpfCnpj, ambiente, top, skip, inlinecount, conclusiva);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ListarNfeSemManifestacao: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarNfeSemManifestacaoWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar notas sem manifestação
    ApiResponse<DistribuicaoNfeNotaListagem> response = apiInstance.ListarNfeSemManifestacaoWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, conclusiva);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ListarNfeSemManifestacaoWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ da pessoa ou empresa interessada.    Utilize o valor sem máscara. |  |
| **ambiente** | **string** | Identificação do Ambiente.    Valores aceitos: homologacao, producao |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional] [default to false] |
| **conclusiva** | **bool?** | Indica se serão consideradas apenas as manifestações conclusivas.    Valores:  * &#x60;false&#x60;: serão retornadas notas que não possuírem qualquer tipo de    manifestação.    * &#x60;true&#x60;: apenas as notas que não possuírem manifestação conclusiva    serão retornadas. Ou seja, notas que tenham sido manifestadas apenas    com Ciência da Operação (210210) continuarão sendo retornadas por    esse endpoint até que recebam uma manifestação conclusiva. | [optional] [default to false] |

### Tipo de retorno

[**DistribuicaoNfeNotaListagem**](DistribuicaoNfeNotaListagem.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="manifestarnfe"></a>
# **ManifestarNfe**
> DistribuicaoNfeEvento ManifestarNfe (DistribuicaoNfePedidoManifestacao body)

Manifestar nota

O processo de manifestação do destinatário permite que os destinatários  de Notas Fiscais Eletrônicas (NF-e) registrem formalmente sua posição em  relação às operações descritas nesses documentos fiscais. Ele envolve  eventos que indicam se a operação foi confirmada, desconhecida ou  não realizada.    Os seguintes tipos de manifestação são suportados pela NF-e:  * **Confirmação da Operação (210200)**: Manifestação do destinatário confirmando que a operação descrita na NF-e ocorreu exatamente como informado na NF-e. Esse evento libera a possibilidade de download da NF-e pelo destinatário e impede que a empresa emitente cancele a NF-e após a confirmação.  * **Ciência da Operação (210210)**: Declara que o destinatário tem ciência da existência da NF-e, mas ainda não possui elementos suficientes para manifestar-se conclusivamente. Este é um evento opcional que pode ser usado pelo destinatário para indicar que está ciente da NF-e enquanto coleta mais informações. Esse evento libera a possibilidade de download da NF-e pelo destinatário.  * **Desconhecimento da Operação (210220)**: Manifestação do destinatário declarando que a operação descrita da NF-e não foi por ele solicitada.  * **Operação não Realizada (210240)**: Manifestação do destinatário reconhecendo sua participação na operação descrita na NF-e, mas declarando que a operação não ocorreu ou não se efetivou como informado nesta NF-e.    **Informações adicionais**:  - Cota: <a href=\"/docs/limites#dfe-eventos\">dfe-eventos</a>  - Consumo: 1 unidade por requisição.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NuvemFiscal.Sdk.Api;
using NuvemFiscal.Sdk.Client;
using NuvemFiscal.Sdk.Model;

namespace Example
{
    public class ManifestarNfeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.nuvemfiscal.com.br";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DistribuioNFEApi(httpClient, config, httpClientHandler);
            var body = new DistribuicaoNfePedidoManifestacao(); // DistribuicaoNfePedidoManifestacao | Contém os dados do pedido para manifestação do destinatário.

            try
            {
                // Manifestar nota
                DistribuicaoNfeEvento result = apiInstance.ManifestarNfe(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DistribuioNFEApi.ManifestarNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ManifestarNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Manifestar nota
    ApiResponse<DistribuicaoNfeEvento> response = apiInstance.ManifestarNfeWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DistribuioNFEApi.ManifestarNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**DistribuicaoNfePedidoManifestacao**](DistribuicaoNfePedidoManifestacao.md) | Contém os dados do pedido para manifestação do destinatário. |  |

### Tipo de retorno

[**DistribuicaoNfeEvento**](DistribuicaoNfeEvento.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: application/json
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

