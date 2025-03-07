# NuvemFiscal.Sdk.Api.CnpjApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**ConsultarCnpj**](CnpjApi.md#consultarcnpj) | **GET** /cnpj/{Cnpj} | Consultar dados do CNPJ |
| [**ListarCnpj**](CnpjApi.md#listarcnpj) | **GET** /cnpj | Listar estabelecimentos ativos a partir da base de CNPJ |

<a name="consultarcnpj"></a>
# **ConsultarCnpj**
> CnpjEmpresa ConsultarCnpj (string cnpj)

Consultar dados do CNPJ

**Informações adicionais**:  - Cota: <a href=\"/docs/limites#cnpj-consultas\">cnpj-consultas</a>  - Consumo: 1 unidade por requisição.

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

<a name="listarcnpj"></a>
# **ListarCnpj**
> CnpjListagem ListarCnpj (string cnaePrincipal, string municipio, string naturezaJuridica, int? top = null, int? skip = null, bool? inlinecount = null)

Listar estabelecimentos ativos a partir da base de CNPJ

Retorna uma lista de estabelecimentos de acordo com os critérios de busca utilizados.  Somente serão retornados estabelecimentos com situação cadastral \"Ativa\".    **Informações adicionais**:  - Cota: <a href=\"/docs/limites#cnpj-listagem\">cnpj-listagem</a>  - Consumo: 1 unidade por estabelecimento listado ou requisição.

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
    public class ListarCnpjExample
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
            var cnaePrincipal = "cnaePrincipal_example";  // string | Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara.
            var municipio = "municipio_example";  // string | Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara.
            var naturezaJuridica = "naturezaJuridica_example";  // string | Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara.
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = false;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional)  (default to false)

            try
            {
                // Listar estabelecimentos ativos a partir da base de CNPJ
                CnpjListagem result = apiInstance.ListarCnpj(cnaePrincipal, municipio, naturezaJuridica, top, skip, inlinecount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CnpjApi.ListarCnpj: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarCnpjWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar estabelecimentos ativos a partir da base de CNPJ
    ApiResponse<CnpjListagem> response = apiInstance.ListarCnpjWithHttpInfo(cnaePrincipal, municipio, naturezaJuridica, top, skip, inlinecount);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar CnpjApi.ListarCnpjWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cnaePrincipal** | **string** | Filtro pelo código CNAE da atividade principal do estabelecimento.  Utilize o valor sem máscara. |  |
| **municipio** | **string** | Filtro pelo código IBGE ou TOM (Tabela de Órgãos e Municípios) do município do estabelecimento.  Utilize o valor sem máscara. |  |
| **naturezaJuridica** | **string** | Filtro pela natureza jurídica do estabelecimento   Utilize o valor de quatro dígitos sem máscara. |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional] [default to false] |

### Tipo de retorno

[**CnpjListagem**](CnpjListagem.md)

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

