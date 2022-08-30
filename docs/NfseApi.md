# NuvemFiscal.Sdk.Api.NfseApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**BaixarXmlNfse**](NfseApi.md#baixarxmlnfse) | **GET** /nfse/{id}/xml |  |
| [**CancelarNfse**](NfseApi.md#cancelarnfse) | **POST** /nfse/{id}/cancelamento |  |
| [**ConsultarCancelamentoNfse**](NfseApi.md#consultarcancelamentonfse) | **GET** /nfse/{id}/cancelamento |  |
| [**ConsultarLoteNfse**](NfseApi.md#consultarlotenfse) | **GET** /nfse/lotes/{id} |  |
| [**ConsultarNfse**](NfseApi.md#consultarnfse) | **GET** /nfse/{id} |  |
| [**EmitirLoteNfse**](NfseApi.md#emitirlotenfse) | **POST** /nfse/lotes |  |
| [**EmitirNfse**](NfseApi.md#emitirnfse) | **POST** /nfse |  |
| [**ListarLotesNfse**](NfseApi.md#listarlotesnfse) | **GET** /nfse/lotes |  |
| [**ListarNfse**](NfseApi.md#listarnfse) | **GET** /nfse |  |

<a name="baixarxmlnfse"></a>
# **BaixarXmlNfse**
> FileParameter BaixarXmlNfse (string id)



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
    public class BaixarXmlNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                FileParameter result = apiInstance.BaixarXmlNfse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.BaixarXmlNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlNfseWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.BaixarXmlNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a name="cancelarnfse"></a>
# **CancelarNfse**
> NfseCancelamento CancelarNfse (string id)



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
    public class CancelarNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                NfseCancelamento result = apiInstance.CancelarNfse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.CancelarNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CancelarNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<NfseCancelamento> response = apiInstance.CancelarNfseWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.CancelarNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Tipo de retorno

[**NfseCancelamento**](NfseCancelamento.md)

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

<a name="consultarcancelamentonfse"></a>
# **ConsultarCancelamentoNfse**
> NfseCancelamento ConsultarCancelamentoNfse (string id)



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
    public class ConsultarCancelamentoNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                NfseCancelamento result = apiInstance.ConsultarCancelamentoNfse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.ConsultarCancelamentoNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCancelamentoNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<NfseCancelamento> response = apiInstance.ConsultarCancelamentoNfseWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.ConsultarCancelamentoNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Tipo de retorno

[**NfseCancelamento**](NfseCancelamento.md)

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

<a name="consultarlotenfse"></a>
# **ConsultarLoteNfse**
> RpsLote ConsultarLoteNfse (string id)



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
    public class ConsultarLoteNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                RpsLote result = apiInstance.ConsultarLoteNfse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.ConsultarLoteNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarLoteNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<RpsLote> response = apiInstance.ConsultarLoteNfseWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.ConsultarLoteNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Tipo de retorno

[**RpsLote**](RpsLote.md)

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

<a name="consultarnfse"></a>
# **ConsultarNfse**
> Nfse ConsultarNfse (string id)



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
    public class ConsultarNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                Nfse result = apiInstance.ConsultarNfse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.ConsultarNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<Nfse> response = apiInstance.ConsultarNfseWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.ConsultarNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Tipo de retorno

[**Nfse**](Nfse.md)

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

<a name="emitirlotenfse"></a>
# **EmitirLoteNfse**
> RpsLote EmitirLoteNfse (RpsPedidoEmissaoLote body)



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
    public class EmitirLoteNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var body = new RpsPedidoEmissaoLote(); // RpsPedidoEmissaoLote | 

            try
            {
                RpsLote result = apiInstance.EmitirLoteNfse(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.EmitirLoteNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirLoteNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<RpsLote> response = apiInstance.EmitirLoteNfseWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.EmitirLoteNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**RpsPedidoEmissaoLote**](RpsPedidoEmissaoLote.md) |  |  |

### Tipo de retorno

[**RpsLote**](RpsLote.md)

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

<a name="emitirnfse"></a>
# **EmitirNfse**
> Nfse EmitirNfse (NfsePedidoEmissao body)



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
    public class EmitirNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var body = new NfsePedidoEmissao(); // NfsePedidoEmissao | 

            try
            {
                Nfse result = apiInstance.EmitirNfse(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.EmitirNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<Nfse> response = apiInstance.EmitirNfseWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.EmitirNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**NfsePedidoEmissao**](NfsePedidoEmissao.md) |  |  |

### Tipo de retorno

[**Nfse**](Nfse.md)

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

<a name="listarlotesnfse"></a>
# **ListarLotesNfse**
> RpsLoteListagem ListarLotesNfse (int? top = null, int? skip = null, string cpfCnpj = null, string referencia = null, string ambiente = null)



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
    public class ListarLotesNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do prestador.  Utilize o valor sem máscara. (optional) 
            var referencia = "referencia_example";  // string |  (optional) 
            var ambiente = "ambiente_example";  // string |  (optional) 

            try
            {
                RpsLoteListagem result = apiInstance.ListarLotesNfse(top, skip, cpfCnpj, referencia, ambiente);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.ListarLotesNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarLotesNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<RpsLoteListagem> response = apiInstance.ListarLotesNfseWithHttpInfo(top, skip, cpfCnpj, referencia, ambiente);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.ListarLotesNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **top** | **int?** |  | [optional]  |
| **skip** | **int?** |  | [optional]  |
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ do prestador.  Utilize o valor sem máscara. | [optional]  |
| **referencia** | **string** |  | [optional]  |
| **ambiente** | **string** |  | [optional]  |

### Tipo de retorno

[**RpsLoteListagem**](RpsLoteListagem.md)

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

<a name="listarnfse"></a>
# **ListarNfse**
> NfseListagem ListarNfse (int? top = null, int? skip = null, string cpfCnpj = null, string referencia = null, string ambiente = null)



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
    public class ListarNfseExample
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
            var apiInstance = new NfseApi(httpClient, config, httpClientHandler);
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do prestador.  Utilize o valor sem máscara. (optional) 
            var referencia = "referencia_example";  // string |  (optional) 
            var ambiente = "ambiente_example";  // string |  (optional) 

            try
            {
                NfseListagem result = apiInstance.ListarNfse(top, skip, cpfCnpj, referencia, ambiente);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfseApi.ListarNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    ApiResponse<NfseListagem> response = apiInstance.ListarNfseWithHttpInfo(top, skip, cpfCnpj, referencia, ambiente);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfseApi.ListarNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **top** | **int?** |  | [optional]  |
| **skip** | **int?** |  | [optional]  |
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ do prestador.  Utilize o valor sem máscara. | [optional]  |
| **referencia** | **string** |  | [optional]  |
| **ambiente** | **string** |  | [optional]  |

### Tipo de retorno

[**NfseListagem**](NfseListagem.md)

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

