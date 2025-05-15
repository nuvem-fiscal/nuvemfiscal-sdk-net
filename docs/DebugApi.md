# NuvemFiscal.Sdk.Api.DebugApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**DebugDfe**](DebugApi.md#debugdfe) | **GET** /debug/{id} | Debug de DF-e |
| [**DebugDfeOriginalPayload**](DebugApi.md#debugdfeoriginalpayload) | **GET** /debug/{id}/original-payload | Payload original recebido |
| [**DebugHttpRequestContent**](DebugApi.md#debughttprequestcontent) | **GET** /debug/http-requests/{id}/request-content | Corpo da requisição HTTP |
| [**DebugHttpResponseContent**](DebugApi.md#debughttpresponsecontent) | **GET** /debug/http-requests/{id}/response-content | Corpo da resposta HTTP |

<a name="debugdfe"></a>
# **DebugDfe**
> DfeDebug DebugDfe (string id)

Debug de DF-e

Este endpoint retorna informações detalhadas de debug sobre o processamento de um documento fiscal eletrônico (DFe),  como NF-e, NFC-e, MDF-e, CT-e, NFS-e, dentre outros. Ele permite inspecionar o conteúdo original enviado à Nuvem Fiscal e analisar  todas as interações realizadas com os serviços autorizadores (SEFAZ ou prefeituras) durante o fluxo de emissão.    **Informações retornadas**:  - JSON original recebido no momento da criação do documento.  - Histórico das etapas de envio e consulta.  - Status e mensagens retornadas pelo autorizador.    **Cenários de uso**:  - Diagnóstico de falhas no processamento do documento.  - Verificação da resposta da SEFAZ ou prefeitura.  - Apoio ao suporte técnico e análise de integração.

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
    public class DebugDfeExample
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
            var apiInstance = new DebugApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do documento fiscal gerado pela Nuvem Fiscal.

            try
            {
                // Debug de DF-e
                DfeDebug result = apiInstance.DebugDfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DebugApi.DebugDfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante DebugDfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Debug de DF-e
    ApiResponse<DfeDebug> response = apiInstance.DebugDfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DebugApi.DebugDfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do documento fiscal gerado pela Nuvem Fiscal. |  |

### Tipo de retorno

[**DfeDebug**](DfeDebug.md)

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

<a name="debugdfeoriginalpayload"></a>
# **DebugDfeOriginalPayload**
> FileParameter DebugDfeOriginalPayload (string id)

Payload original recebido

Este endpoint retorna o conteúdo original recebido pela Nuvem Fiscal no momento da criação do documento fiscal.    **Cenários de uso**:  - Inspeção detalhada dos dados enviados à API.  - Verificação de divergências entre o payload fornecido e o processado.  - Encaminhamento do conteúdo original ao suporte da Nuvem Fiscal.

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
    public class DebugDfeOriginalPayloadExample
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
            var apiInstance = new DebugApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID do documento fiscal gerado pela Nuvem Fiscal.

            try
            {
                // Payload original recebido
                FileParameter result = apiInstance.DebugDfeOriginalPayload(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DebugApi.DebugDfeOriginalPayload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante DebugDfeOriginalPayloadWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Payload original recebido
    ApiResponse<FileParameter> response = apiInstance.DebugDfeOriginalPayloadWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DebugApi.DebugDfeOriginalPayloadWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID do documento fiscal gerado pela Nuvem Fiscal. |  |

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

<a name="debughttprequestcontent"></a>
# **DebugHttpRequestContent**
> FileParameter DebugHttpRequestContent (string id)

Corpo da requisição HTTP

Este endpoint retorna apenas o corpo da requisição HTTP enviada ao autorizador,  preservando o conteúdo exatamente como foi armazenado pela Nuvem Fiscal.    **Informações retornadas**:  - Envelope SOAP da requisição, possivelmente compactado.    **Cenários de uso**:  - Verificação do XML ou SOAP efetivamente enviado.  - Encaminhamento ao suporte da SEFAZ ou prefeitura para análise.  - Diagnóstico técnico do conteúdo de envio.

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
    public class DebugHttpRequestContentExample
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
            var apiInstance = new DebugApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID da requisição HTTP.

            try
            {
                // Corpo da requisição HTTP
                FileParameter result = apiInstance.DebugHttpRequestContent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DebugApi.DebugHttpRequestContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante DebugHttpRequestContentWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Corpo da requisição HTTP
    ApiResponse<FileParameter> response = apiInstance.DebugHttpRequestContentWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DebugApi.DebugHttpRequestContentWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID da requisição HTTP. |  |

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

<a name="debughttpresponsecontent"></a>
# **DebugHttpResponseContent**
> FileParameter DebugHttpResponseContent (string id)

Corpo da resposta HTTP

Este endpoint retorna apenas o corpo da resposta HTTP recebida do autorizador,  permitindo análise técnica da mensagem retornada pela SEFAZ ou prefeitura.    **Informações retornadas**:  - Envelope SOAP da resposta, ou mensagem de erro (ex: HTML, XML), no formato original.    **Cenários de uso**:  - Inspeção da resposta real retornada pelo autorizador.  - Encaminhamento do conteúdo ao suporte técnico.  - Diagnóstico de rejeições, falhas de processamento ou erros de infraestrutura.

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
    public class DebugHttpResponseContentExample
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
            var apiInstance = new DebugApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID da requisição HTTP.

            try
            {
                // Corpo da resposta HTTP
                FileParameter result = apiInstance.DebugHttpResponseContent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DebugApi.DebugHttpResponseContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante DebugHttpResponseContentWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Corpo da resposta HTTP
    ApiResponse<FileParameter> response = apiInstance.DebugHttpResponseContentWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar DebugApi.DebugHttpResponseContentWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID da requisição HTTP. |  |

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

