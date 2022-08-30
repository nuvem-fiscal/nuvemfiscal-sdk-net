# NuvemFiscal.Sdk.Api.CnpjApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**ConsultarCnpj**](CnpjApi.md#consultarcnpj) | **GET** /cnpj/{Cnpj} | Consultar dados do CNPJ |

<a name="consultarcnpj"></a>
# **ConsultarCnpj**
> CnpjEmpresa ConsultarCnpj (string cnpj)

Consultar dados do CNPJ

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
    public class ConsultarCnpjExample
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
            var apiInstance = new CnpjApi(httpClient, config, httpClientHandler);
            var cnpj = "cnpj_example";  // string | CNPJ sem máscara.

            try
            {
                // Consultar dados do CNPJ
                CnpjEmpresa result = apiInstance.ConsultarCnpj(cnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CnpjApi.ConsultarCnpj: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCnpjWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar dados do CNPJ
    ApiResponse<CnpjEmpresa> response = apiInstance.ConsultarCnpjWithHttpInfo(cnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CnpjApi.ConsultarCnpjWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cnpj** | **string** | CNPJ sem máscara. |  |

### Tipo de retorno

[**CnpjEmpresa**](CnpjEmpresa.md)

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

