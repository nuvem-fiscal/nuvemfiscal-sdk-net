# NuvemFiscal.Sdk.Api.ContaApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**ConsultarCotaConta**](ContaApi.md#consultarcotaconta) | **GET** /conta/cotas/{nome} | Consultar o limite de uso e o consumo de uma cota específica. |
| [**ListarCotasConta**](ContaApi.md#listarcotasconta) | **GET** /conta/cotas | Consultar os limites de uso e consumo de todas as cotas existentes. |

<a name="consultarcotaconta"></a>
# **ConsultarCotaConta**
> ContaCota ConsultarCotaConta (string nome)

Consultar o limite de uso e o consumo de uma cota específica.

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
    public class ConsultarCotaContaExample
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
            var apiInstance = new ContaApi(httpClient, config, httpClientHandler);
            var nome = "nome_example";  // string | Nome da cota a ser consultada.

            try
            {
                // Consultar o limite de uso e o consumo de uma cota específica.
                ContaCota result = apiInstance.ConsultarCotaConta(nome);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContaApi.ConsultarCotaConta: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCotaContaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o limite de uso e o consumo de uma cota específica.
    ApiResponse<ContaCota> response = apiInstance.ConsultarCotaContaWithHttpInfo(nome);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar ContaApi.ConsultarCotaContaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **nome** | **string** | Nome da cota a ser consultada. |  |

### Tipo de retorno

[**ContaCota**](ContaCota.md)

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

<a name="listarcotasconta"></a>
# **ListarCotasConta**
> ContaCotaListagem ListarCotasConta ()

Consultar os limites de uso e consumo de todas as cotas existentes.

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
    public class ListarCotasContaExample
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
            var apiInstance = new ContaApi(httpClient, config, httpClientHandler);

            try
            {
                // Consultar os limites de uso e consumo de todas as cotas existentes.
                ContaCotaListagem result = apiInstance.ListarCotasConta();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContaApi.ListarCotasConta: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarCotasContaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar os limites de uso e consumo de todas as cotas existentes.
    ApiResponse<ContaCotaListagem> response = apiInstance.ListarCotasContaWithHttpInfo();
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar ContaApi.ListarCotasContaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros
Este endpoint não recebe nenhum parâmetro.
### Tipo de retorno

[**ContaCotaListagem**](ContaCotaListagem.md)

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

