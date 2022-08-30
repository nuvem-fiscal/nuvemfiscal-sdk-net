# NuvemFiscal.Sdk.Api.CteApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Verbo HTTP | Descrição |
|--------|--------------|-------------|
| [**BaixarXmlCancelamentoCte**](CteApi.md#baixarxmlcancelamentocte) | **GET** /cte/{id}/cancelamento/xml | Baixar XML do cancelamento |
| [**BaixarXmlCartaCorrecaoCte**](CteApi.md#baixarxmlcartacorrecaocte) | **GET** /cte/{id}/carta-correcao/xml | Baixar XML da carta de correção |
| [**BaixarXmlCte**](CteApi.md#baixarxmlcte) | **GET** /cte/{id}/xml | Baixar XML do CT-e processado |
| [**BaixarXmlEventoCte**](CteApi.md#baixarxmleventocte) | **GET** /cte/eventos/{id}/xml | Baixar XML do evento |
| [**BaixarXmlInutilizacaoCte**](CteApi.md#baixarxmlinutilizacaocte) | **GET** /cte/inutilizacoes/{id}/xml | Baixar XML da inutilização |
| [**CancelarCte**](CteApi.md#cancelarcte) | **POST** /cte/{id}/cancelamento | Cancelar um CT-e autorizado |
| [**ConsultarCancelamentoCte**](CteApi.md#consultarcancelamentocte) | **GET** /cte/{id}/cancelamento | Consultar o cancelamento do CT-e |
| [**ConsultarCartaCorrecaoCte**](CteApi.md#consultarcartacorrecaocte) | **GET** /cte/{id}/carta-correcao | Consultar a solicitação de correção do CT-e |
| [**ConsultarCte**](CteApi.md#consultarcte) | **GET** /cte/{id} | Consultar CT-e |
| [**ConsultarEventoCte**](CteApi.md#consultareventocte) | **GET** /cte/eventos/{id} | Consultar evento |
| [**ConsultarInutilizacaoCte**](CteApi.md#consultarinutilizacaocte) | **GET** /cte/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração |
| [**ConsultarLoteCte**](CteApi.md#consultarlotecte) | **GET** /cte/lotes/{id} | Consultar lote de CT-e |
| [**ConsultarStatusSefazCte**](CteApi.md#consultarstatussefazcte) | **GET** /cte/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora |
| [**CriarCartaCorrecaoCte**](CteApi.md#criarcartacorrecaocte) | **POST** /cte/{id}/carta-correcao | Solicitar correção do CT-e |
| [**EmitirCte**](CteApi.md#emitircte) | **POST** /cte | Emitir CT-e |
| [**EmitirLoteCte**](CteApi.md#emitirlotecte) | **POST** /cte/lotes | Emitir lote de CT-e |
| [**InutilizarCte**](CteApi.md#inutilizarcte) | **POST** /cte/inutilizacoes | Inutilizar uma sequência de numeração de CT-e |

<a name="baixarxmlcancelamentocte"></a>
# **BaixarXmlCancelamentoCte**
> FileParameter BaixarXmlCancelamentoCte (string id)

Baixar XML do cancelamento

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
    public class BaixarXmlCancelamentoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.

            try
            {
                // Baixar XML do cancelamento
                FileParameter result = apiInstance.BaixarXmlCancelamentoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.BaixarXmlCancelamentoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlCancelamentoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do cancelamento
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlCancelamentoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.BaixarXmlCancelamentoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |

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

<a name="baixarxmlcartacorrecaocte"></a>
# **BaixarXmlCartaCorrecaoCte**
> FileParameter BaixarXmlCartaCorrecaoCte (string id)

Baixar XML da carta de correção

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
    public class BaixarXmlCartaCorrecaoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.

            try
            {
                // Baixar XML da carta de correção
                FileParameter result = apiInstance.BaixarXmlCartaCorrecaoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.BaixarXmlCartaCorrecaoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlCartaCorrecaoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da carta de correção
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlCartaCorrecaoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.BaixarXmlCartaCorrecaoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |

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

<a name="baixarxmlcte"></a>
# **BaixarXmlCte**
> FileParameter BaixarXmlCte (string id)

Baixar XML do CT-e processado

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
    public class BaixarXmlCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.

            try
            {
                // Baixar XML do CT-e processado
                FileParameter result = apiInstance.BaixarXmlCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.BaixarXmlCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do CT-e processado
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.BaixarXmlCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |

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

<a name="baixarxmleventocte"></a>
# **BaixarXmlEventoCte**
> FileParameter BaixarXmlEventoCte (string id)

Baixar XML do evento

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
    public class BaixarXmlEventoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do evento.

            try
            {
                // Baixar XML do evento
                FileParameter result = apiInstance.BaixarXmlEventoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.BaixarXmlEventoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlEventoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do evento
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlEventoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.BaixarXmlEventoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do evento. |  |

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

<a name="baixarxmlinutilizacaocte"></a>
# **BaixarXmlInutilizacaoCte**
> FileParameter BaixarXmlInutilizacaoCte (string id)

Baixar XML da inutilização

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
    public class BaixarXmlInutilizacaoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do evento.

            try
            {
                // Baixar XML da inutilização
                FileParameter result = apiInstance.BaixarXmlInutilizacaoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.BaixarXmlInutilizacaoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlInutilizacaoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da inutilização
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlInutilizacaoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.BaixarXmlInutilizacaoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do evento. |  |

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

<a name="cancelarcte"></a>
# **CancelarCte**
> DfeCancelamento CancelarCte (string id, CtePedidoCancelamento body)

Cancelar um CT-e autorizado

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
    public class CancelarCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.
            var body = new CtePedidoCancelamento(); // CtePedidoCancelamento | 

            try
            {
                // Cancelar um CT-e autorizado
                DfeCancelamento result = apiInstance.CancelarCte(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.CancelarCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CancelarCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Cancelar um CT-e autorizado
    ApiResponse<DfeCancelamento> response = apiInstance.CancelarCteWithHttpInfo(id, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.CancelarCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |
| **body** | [**CtePedidoCancelamento**](CtePedidoCancelamento.md) |  |  |

### Tipo de retorno

[**DfeCancelamento**](DfeCancelamento.md)

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

<a name="consultarcancelamentocte"></a>
# **ConsultarCancelamentoCte**
> DfeCancelamento ConsultarCancelamentoCte (string id)

Consultar o cancelamento do CT-e

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
    public class ConsultarCancelamentoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.

            try
            {
                // Consultar o cancelamento do CT-e
                DfeCancelamento result = apiInstance.ConsultarCancelamentoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarCancelamentoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCancelamentoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o cancelamento do CT-e
    ApiResponse<DfeCancelamento> response = apiInstance.ConsultarCancelamentoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarCancelamentoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |

### Tipo de retorno

[**DfeCancelamento**](DfeCancelamento.md)

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

<a name="consultarcartacorrecaocte"></a>
# **ConsultarCartaCorrecaoCte**
> CteCartaCorrecao ConsultarCartaCorrecaoCte (string id)

Consultar a solicitação de correção do CT-e

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
    public class ConsultarCartaCorrecaoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.

            try
            {
                // Consultar a solicitação de correção do CT-e
                CteCartaCorrecao result = apiInstance.ConsultarCartaCorrecaoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarCartaCorrecaoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCartaCorrecaoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar a solicitação de correção do CT-e
    ApiResponse<CteCartaCorrecao> response = apiInstance.ConsultarCartaCorrecaoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarCartaCorrecaoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |

### Tipo de retorno

[**CteCartaCorrecao**](CteCartaCorrecao.md)

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

<a name="consultarcte"></a>
# **ConsultarCte**
> Dfe ConsultarCte (string id)

Consultar CT-e

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
    public class ConsultarCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.

            try
            {
                // Consultar CT-e
                Dfe result = apiInstance.ConsultarCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar CT-e
    ApiResponse<Dfe> response = apiInstance.ConsultarCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |

### Tipo de retorno

[**Dfe**](Dfe.md)

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

<a name="consultareventocte"></a>
# **ConsultarEventoCte**
> DfeEvento ConsultarEventoCte (string id)

Consultar evento

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
    public class ConsultarEventoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do evento.

            try
            {
                // Consultar evento
                DfeEvento result = apiInstance.ConsultarEventoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarEventoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarEventoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar evento
    ApiResponse<DfeEvento> response = apiInstance.ConsultarEventoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarEventoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do evento. |  |

### Tipo de retorno

[**DfeEvento**](DfeEvento.md)

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

<a name="consultarinutilizacaocte"></a>
# **ConsultarInutilizacaoCte**
> DfeInutilizacao ConsultarInutilizacaoCte (string id)

Consultar a inutilização de sequência de numeração

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
    public class ConsultarInutilizacaoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do evento.

            try
            {
                // Consultar a inutilização de sequência de numeração
                DfeInutilizacao result = apiInstance.ConsultarInutilizacaoCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarInutilizacaoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarInutilizacaoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar a inutilização de sequência de numeração
    ApiResponse<DfeInutilizacao> response = apiInstance.ConsultarInutilizacaoCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarInutilizacaoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do evento. |  |

### Tipo de retorno

[**DfeInutilizacao**](DfeInutilizacao.md)

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

<a name="consultarlotecte"></a>
# **ConsultarLoteCte**
> DfeLote ConsultarLoteCte (string id)

Consultar lote de CT-e

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
    public class ConsultarLoteCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do lote.

            try
            {
                // Consultar lote de CT-e
                DfeLote result = apiInstance.ConsultarLoteCte(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarLoteCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarLoteCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar lote de CT-e
    ApiResponse<DfeLote> response = apiInstance.ConsultarLoteCteWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarLoteCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do lote. |  |

### Tipo de retorno

[**DfeLote**](DfeLote.md)

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

<a name="consultarstatussefazcte"></a>
# **ConsultarStatusSefazCte**
> DfeVisaoGeralSefazStatus ConsultarStatusSefazCte (string cpfCnpj = null)

Consulta do Status do Serviço na SEFAZ Autorizadora

Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 3.0.0a, item 4.6.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).

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
    public class ConsultarStatusSefazCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF/CNPJ do emitente.  Utilize o valor sem máscara. (optional) 

            try
            {
                // Consulta do Status do Serviço na SEFAZ Autorizadora
                DfeVisaoGeralSefazStatus result = apiInstance.ConsultarStatusSefazCte(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.ConsultarStatusSefazCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarStatusSefazCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consulta do Status do Serviço na SEFAZ Autorizadora
    ApiResponse<DfeVisaoGeralSefazStatus> response = apiInstance.ConsultarStatusSefazCteWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.ConsultarStatusSefazCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF/CNPJ do emitente.  Utilize o valor sem máscara. | [optional]  |

### Tipo de retorno

[**DfeVisaoGeralSefazStatus**](DfeVisaoGeralSefazStatus.md)

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

<a name="criarcartacorrecaocte"></a>
# **CriarCartaCorrecaoCte**
> CteCartaCorrecao CriarCartaCorrecaoCte (string id, CtePedidoCartaCorrecao body)

Solicitar correção do CT-e

É possível enviar até 20 correções diferentes, sendo que será válido sempre a última correção enviada.

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
    public class CriarCartaCorrecaoCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Identificador único do CT-e.
            var body = new CtePedidoCartaCorrecao(); // CtePedidoCartaCorrecao | 

            try
            {
                // Solicitar correção do CT-e
                CteCartaCorrecao result = apiInstance.CriarCartaCorrecaoCte(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.CriarCartaCorrecaoCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CriarCartaCorrecaoCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Solicitar correção do CT-e
    ApiResponse<CteCartaCorrecao> response = apiInstance.CriarCartaCorrecaoCteWithHttpInfo(id, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.CriarCartaCorrecaoCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | Identificador único do CT-e. |  |
| **body** | [**CtePedidoCartaCorrecao**](CtePedidoCartaCorrecao.md) |  |  |

### Tipo de retorno

[**CteCartaCorrecao**](CteCartaCorrecao.md)

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

<a name="emitircte"></a>
# **EmitirCte**
> Dfe EmitirCte (CtePedidoEmissao body)

Emitir CT-e

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
    public class EmitirCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var body = new CtePedidoEmissao(); // CtePedidoEmissao | 

            try
            {
                // Emitir CT-e
                Dfe result = apiInstance.EmitirCte(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.EmitirCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Emitir CT-e
    ApiResponse<Dfe> response = apiInstance.EmitirCteWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.EmitirCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**CtePedidoEmissao**](CtePedidoEmissao.md) |  |  |

### Tipo de retorno

[**Dfe**](Dfe.md)

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

<a name="emitirlotecte"></a>
# **EmitirLoteCte**
> DfeLote EmitirLoteCte (CtePedidoEmissaoLote body)

Emitir lote de CT-e

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
    public class EmitirLoteCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var body = new CtePedidoEmissaoLote(); // CtePedidoEmissaoLote | 

            try
            {
                // Emitir lote de CT-e
                DfeLote result = apiInstance.EmitirLoteCte(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.EmitirLoteCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirLoteCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Emitir lote de CT-e
    ApiResponse<DfeLote> response = apiInstance.EmitirLoteCteWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.EmitirLoteCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**CtePedidoEmissaoLote**](CtePedidoEmissaoLote.md) |  |  |

### Tipo de retorno

[**DfeLote**](DfeLote.md)

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

<a name="inutilizarcte"></a>
# **InutilizarCte**
> DfeInutilizacao InutilizarCte (DfePedidoInutilizacao body)

Inutilizar uma sequência de numeração de CT-e

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
    public class InutilizarCteExample
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
            var apiInstance = new CteApi(httpClient, config, httpClientHandler);
            var body = new DfePedidoInutilizacao(); // DfePedidoInutilizacao | 

            try
            {
                // Inutilizar uma sequência de numeração de CT-e
                DfeInutilizacao result = apiInstance.InutilizarCte(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CteApi.InutilizarCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante InutilizarCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Inutilizar uma sequência de numeração de CT-e
    ApiResponse<DfeInutilizacao> response = apiInstance.InutilizarCteWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CteApi.InutilizarCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**DfePedidoInutilizacao**](DfePedidoInutilizacao.md) |  |  |

### Tipo de retorno

[**DfeInutilizacao**](DfeInutilizacao.md)

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

