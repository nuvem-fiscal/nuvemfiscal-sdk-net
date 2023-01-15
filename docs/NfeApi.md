# NuvemFiscal.Sdk.Api.NfeApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**BaixarPdfNfe**](NfeApi.md#baixarpdfnfe) | **GET** /nfe/{id}/pdf | Baixar PDF do DANFE |
| [**BaixarXmlCancelamentoNfe**](NfeApi.md#baixarxmlcancelamentonfe) | **GET** /nfe/{id}/cancelamento/xml | Baixar XML do cancelamento |
| [**BaixarXmlCartaCorrecaoNfe**](NfeApi.md#baixarxmlcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao/xml | Baixar XML da carta de correção |
| [**BaixarXmlEventoNfe**](NfeApi.md#baixarxmleventonfe) | **GET** /nfe/eventos/{id}/xml | Baixar XML do evento |
| [**BaixarXmlInutilizacaoNfe**](NfeApi.md#baixarxmlinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id}/xml | Baixar XML da inutilização |
| [**BaixarXmlNfe**](NfeApi.md#baixarxmlnfe) | **GET** /nfe/{id}/xml | Baixar XML da NF-e processada |
| [**CancelarNfe**](NfeApi.md#cancelarnfe) | **POST** /nfe/{id}/cancelamento | Cancelar uma NF-e autorizada |
| [**ConsultarCancelamentoNfe**](NfeApi.md#consultarcancelamentonfe) | **GET** /nfe/{id}/cancelamento | Consultar o cancelamento da NF-e |
| [**ConsultarCartaCorrecaoNfe**](NfeApi.md#consultarcartacorrecaonfe) | **GET** /nfe/{id}/carta-correcao | Consultar a solicitação de correção da NF-e |
| [**ConsultarEventoNfe**](NfeApi.md#consultareventonfe) | **GET** /nfe/eventos/{id} | Consultar evento |
| [**ConsultarInutilizacaoNfe**](NfeApi.md#consultarinutilizacaonfe) | **GET** /nfe/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração |
| [**ConsultarLoteNfe**](NfeApi.md#consultarlotenfe) | **GET** /nfe/lotes/{id} | Consultar lote de NF-e |
| [**ConsultarNfe**](NfeApi.md#consultarnfe) | **GET** /nfe/{id} | Consultar NF-e |
| [**ConsultarStatusSefazNfe**](NfeApi.md#consultarstatussefaznfe) | **GET** /nfe/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora |
| [**CriarCartaCorrecaoNfe**](NfeApi.md#criarcartacorrecaonfe) | **POST** /nfe/{id}/carta-correcao | Solicitar correção da NF-e |
| [**EmitirLoteNfe**](NfeApi.md#emitirlotenfe) | **POST** /nfe/lotes | Emitir lote de NF-e |
| [**EmitirNfe**](NfeApi.md#emitirnfe) | **POST** /nfe | Emitir NF-e |
| [**InutilizarNumeracaoNfe**](NfeApi.md#inutilizarnumeracaonfe) | **POST** /nfe/inutilizacoes | Inutilizar uma sequência de numeração de NF-e |
| [**ListarLotesNfe**](NfeApi.md#listarlotesnfe) | **GET** /nfe/lotes | Listar lotes de NF-e |
| [**ListarNfe**](NfeApi.md#listarnfe) | **GET** /nfe | Listar NF-e |

<a name="baixarpdfnfe"></a>
# **BaixarPdfNfe**
> FileParameter BaixarPdfNfe (string id)

Baixar PDF do DANFE

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
    public class BaixarPdfNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar PDF do DANFE
                FileParameter result = apiInstance.BaixarPdfNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.BaixarPdfNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarPdfNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar PDF do DANFE
    ApiResponse<FileParameter> response = apiInstance.BaixarPdfNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.BaixarPdfNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmlcancelamentonfe"></a>
# **BaixarXmlCancelamentoNfe**
> FileParameter BaixarXmlCancelamentoNfe (string id)

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
    public class BaixarXmlCancelamentoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML do cancelamento
                FileParameter result = apiInstance.BaixarXmlCancelamentoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.BaixarXmlCancelamentoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlCancelamentoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do cancelamento
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlCancelamentoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.BaixarXmlCancelamentoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmlcartacorrecaonfe"></a>
# **BaixarXmlCartaCorrecaoNfe**
> FileParameter BaixarXmlCartaCorrecaoNfe (string id)

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
    public class BaixarXmlCartaCorrecaoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML da carta de correção
                FileParameter result = apiInstance.BaixarXmlCartaCorrecaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.BaixarXmlCartaCorrecaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlCartaCorrecaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da carta de correção
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlCartaCorrecaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.BaixarXmlCartaCorrecaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmleventonfe"></a>
# **BaixarXmlEventoNfe**
> FileParameter BaixarXmlEventoNfe (string id)

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
    public class BaixarXmlEventoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do evento gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML do evento
                FileParameter result = apiInstance.BaixarXmlEventoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.BaixarXmlEventoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlEventoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do evento
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlEventoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.BaixarXmlEventoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do evento gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmlinutilizacaonfe"></a>
# **BaixarXmlInutilizacaoNfe**
> FileParameter BaixarXmlInutilizacaoNfe (string id)

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
    public class BaixarXmlInutilizacaoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do evento gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML da inutilização
                FileParameter result = apiInstance.BaixarXmlInutilizacaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.BaixarXmlInutilizacaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlInutilizacaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da inutilização
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlInutilizacaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.BaixarXmlInutilizacaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do evento gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmlnfe"></a>
# **BaixarXmlNfe**
> FileParameter BaixarXmlNfe (string id)

Baixar XML da NF-e processada

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
    public class BaixarXmlNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML da NF-e processada
                FileParameter result = apiInstance.BaixarXmlNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.BaixarXmlNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da NF-e processada
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.BaixarXmlNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

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

<a name="cancelarnfe"></a>
# **CancelarNfe**
> DfeCancelamento CancelarNfe (string id, NfePedidoCancelamento body)

Cancelar uma NF-e autorizada

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
    public class CancelarNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.
            var body = new NfePedidoCancelamento(); // NfePedidoCancelamento | 

            try
            {
                // Cancelar uma NF-e autorizada
                DfeCancelamento result = apiInstance.CancelarNfe(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.CancelarNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CancelarNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Cancelar uma NF-e autorizada
    ApiResponse<DfeCancelamento> response = apiInstance.CancelarNfeWithHttpInfo(id, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.CancelarNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |
| **body** | [**NfePedidoCancelamento**](NfePedidoCancelamento.md) |  |  |

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

<a name="consultarcancelamentonfe"></a>
# **ConsultarCancelamentoNfe**
> DfeCancelamento ConsultarCancelamentoNfe (string id)

Consultar o cancelamento da NF-e

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
    public class ConsultarCancelamentoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Consultar o cancelamento da NF-e
                DfeCancelamento result = apiInstance.ConsultarCancelamentoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarCancelamentoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCancelamentoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o cancelamento da NF-e
    ApiResponse<DfeCancelamento> response = apiInstance.ConsultarCancelamentoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarCancelamentoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

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

<a name="consultarcartacorrecaonfe"></a>
# **ConsultarCartaCorrecaoNfe**
> DfeCartaCorrecao ConsultarCartaCorrecaoNfe (string id)

Consultar a solicitação de correção da NF-e

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
    public class ConsultarCartaCorrecaoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Consultar a solicitação de correção da NF-e
                DfeCartaCorrecao result = apiInstance.ConsultarCartaCorrecaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarCartaCorrecaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCartaCorrecaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar a solicitação de correção da NF-e
    ApiResponse<DfeCartaCorrecao> response = apiInstance.ConsultarCartaCorrecaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarCartaCorrecaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

### Tipo de retorno

[**DfeCartaCorrecao**](DfeCartaCorrecao.md)

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

<a name="consultareventonfe"></a>
# **ConsultarEventoNfe**
> DfeEvento ConsultarEventoNfe (string id)

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
    public class ConsultarEventoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do evento gerado pela Nuvem Fiscal.

            try
            {
                // Consultar evento
                DfeEvento result = apiInstance.ConsultarEventoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarEventoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarEventoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar evento
    ApiResponse<DfeEvento> response = apiInstance.ConsultarEventoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarEventoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do evento gerado pela Nuvem Fiscal. |  |

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

<a name="consultarinutilizacaonfe"></a>
# **ConsultarInutilizacaoNfe**
> DfeInutilizacao ConsultarInutilizacaoNfe (string id)

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
    public class ConsultarInutilizacaoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do evento gerado pela Nuvem Fiscal.

            try
            {
                // Consultar a inutilização de sequência de numeração
                DfeInutilizacao result = apiInstance.ConsultarInutilizacaoNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarInutilizacaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarInutilizacaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar a inutilização de sequência de numeração
    ApiResponse<DfeInutilizacao> response = apiInstance.ConsultarInutilizacaoNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarInutilizacaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do evento gerado pela Nuvem Fiscal. |  |

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

<a name="consultarlotenfe"></a>
# **ConsultarLoteNfe**
> DfeLote ConsultarLoteNfe (string id)

Consultar lote de NF-e

Consulta os detalhes de um lote já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de lotes e a Nuvem Fiscal irá retornar as informações do lote correspondente.

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
    public class ConsultarLoteNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do lote gerado pela Nuvem Fiscal.

            try
            {
                // Consultar lote de NF-e
                DfeLote result = apiInstance.ConsultarLoteNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarLoteNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarLoteNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar lote de NF-e
    ApiResponse<DfeLote> response = apiInstance.ConsultarLoteNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarLoteNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único do lote gerado pela Nuvem Fiscal. |  |

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

<a name="consultarnfe"></a>
# **ConsultarNfe**
> Dfe ConsultarNfe (string id)

Consultar NF-e

Consulta os detalhes de uma NF-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de notas e a Nuvem Fiscal irá retornar as informações da nota correspondente.

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
    public class ConsultarNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.

            try
            {
                // Consultar NF-e
                Dfe result = apiInstance.ConsultarNfe(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar NF-e
    ApiResponse<Dfe> response = apiInstance.ConsultarNfeWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |

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

<a name="consultarstatussefaznfe"></a>
# **ConsultarStatusSefazNfe**
> DfeSefazStatus ConsultarStatusSefazNfe (string cpfCnpj)

Consulta do Status do Serviço na SEFAZ Autorizadora

Consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual.    A Nuvem Fiscal mantém a última consulta em cache por 5 minutos, evitando sobrecarregar desnecessariamente os servidores da SEFAZ (conforme orientação do MOC - versão 7.0, item 5.5.3). Dessa forma, você poderá chamar esse endpoint quantas vezes quiser, sem preocupar-se em ter o seu CNPJ bloqueado por consumo indevido (Rejeição 656).

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
    public class ConsultarStatusSefazNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF/CNPJ do emitente.  Utilize o valor sem máscara.

            try
            {
                // Consulta do Status do Serviço na SEFAZ Autorizadora
                DfeSefazStatus result = apiInstance.ConsultarStatusSefazNfe(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ConsultarStatusSefazNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarStatusSefazNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consulta do Status do Serviço na SEFAZ Autorizadora
    ApiResponse<DfeSefazStatus> response = apiInstance.ConsultarStatusSefazNfeWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ConsultarStatusSefazNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF/CNPJ do emitente.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**DfeSefazStatus**](DfeSefazStatus.md)

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

<a name="criarcartacorrecaonfe"></a>
# **CriarCartaCorrecaoNfe**
> DfeCartaCorrecao CriarCartaCorrecaoNfe (string id, NfePedidoCartaCorrecao body)

Solicitar correção da NF-e

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
    public class CriarCartaCorrecaoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NF-e gerado pela Nuvem Fiscal.
            var body = new NfePedidoCartaCorrecao(); // NfePedidoCartaCorrecao | Contém os dados do pedido para carta de correção.

            try
            {
                // Solicitar correção da NF-e
                DfeCartaCorrecao result = apiInstance.CriarCartaCorrecaoNfe(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.CriarCartaCorrecaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CriarCartaCorrecaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Solicitar correção da NF-e
    ApiResponse<DfeCartaCorrecao> response = apiInstance.CriarCartaCorrecaoNfeWithHttpInfo(id, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.CriarCartaCorrecaoNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NF-e gerado pela Nuvem Fiscal. |  |
| **body** | [**NfePedidoCartaCorrecao**](NfePedidoCartaCorrecao.md) | Contém os dados do pedido para carta de correção. |  |

### Tipo de retorno

[**DfeCartaCorrecao**](DfeCartaCorrecao.md)

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

<a name="emitirlotenfe"></a>
# **EmitirLoteNfe**
> DfeLote EmitirLoteNfe (NfePedidoEmissaoLote body)

Emitir lote de NF-e

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
    public class EmitirLoteNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var body = new NfePedidoEmissaoLote(); // NfePedidoEmissaoLote | 

            try
            {
                // Emitir lote de NF-e
                DfeLote result = apiInstance.EmitirLoteNfe(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.EmitirLoteNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirLoteNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Emitir lote de NF-e
    ApiResponse<DfeLote> response = apiInstance.EmitirLoteNfeWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.EmitirLoteNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**NfePedidoEmissaoLote**](NfePedidoEmissaoLote.md) |  |  |

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

<a name="emitirnfe"></a>
# **EmitirNfe**
> Dfe EmitirNfe (NfePedidoEmissao body)

Emitir NF-e

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
    public class EmitirNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var body = new NfePedidoEmissao(); // NfePedidoEmissao | 

            try
            {
                // Emitir NF-e
                Dfe result = apiInstance.EmitirNfe(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.EmitirNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Emitir NF-e
    ApiResponse<Dfe> response = apiInstance.EmitirNfeWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.EmitirNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**NfePedidoEmissao**](NfePedidoEmissao.md) |  |  |

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

<a name="inutilizarnumeracaonfe"></a>
# **InutilizarNumeracaoNfe**
> DfeInutilizacao InutilizarNumeracaoNfe (DfePedidoInutilizacao body)

Inutilizar uma sequência de numeração de NF-e

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
    public class InutilizarNumeracaoNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var body = new DfePedidoInutilizacao(); // DfePedidoInutilizacao | 

            try
            {
                // Inutilizar uma sequência de numeração de NF-e
                DfeInutilizacao result = apiInstance.InutilizarNumeracaoNfe(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.InutilizarNumeracaoNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante InutilizarNumeracaoNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Inutilizar uma sequência de numeração de NF-e
    ApiResponse<DfeInutilizacao> response = apiInstance.InutilizarNumeracaoNfeWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.InutilizarNumeracaoNfeWithHttpInfo: " + e.Message);
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

<a name="listarlotesnfe"></a>
# **ListarLotesNfe**
> DfeLoteListagem ListarLotesNfe (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null, string referencia = null)

Listar lotes de NF-e

Retorna a lista dos lotes de acordo com os critérios de busca utilizados. Os lotes são retornados ordenados pela data da criação, com os mais recentes aparecendo primeiro.

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
    public class ListarLotesNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = true;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional) 
            var referencia = "referencia_example";  // string |  (optional) 

            try
            {
                // Listar lotes de NF-e
                DfeLoteListagem result = apiInstance.ListarLotesNfe(cpfCnpj, ambiente, top, skip, inlinecount, referencia);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ListarLotesNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarLotesNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar lotes de NF-e
    ApiResponse<DfeLoteListagem> response = apiInstance.ListarLotesNfeWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, referencia);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ListarLotesNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara. |  |
| **ambiente** | **string** | Identificação do Ambiente.    Valores aceitos: homologacao, producao |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional]  |
| **referencia** | **string** |  | [optional]  |

### Tipo de retorno

[**DfeLoteListagem**](DfeLoteListagem.md)

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

<a name="listarnfe"></a>
# **ListarNfe**
> DfeListagem ListarNfe (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null, string referencia = null, string chave = null)

Listar NF-e

Retorna a lista de notas de acordo com os critérios de busca utilizados. As notas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.

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
    public class ListarNfeExample
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
            var apiInstance = new NfeApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = true;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional) 
            var referencia = "referencia_example";  // string |  (optional) 
            var chave = "chave_example";  // string | Chave de acesso do DF-e. (optional) 

            try
            {
                // Listar NF-e
                DfeListagem result = apiInstance.ListarNfe(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfeApi.ListarNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar NF-e
    ApiResponse<DfeListagem> response = apiInstance.ListarNfeWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfeApi.ListarNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara. |  |
| **ambiente** | **string** | Identificação do Ambiente.    Valores aceitos: homologacao, producao |  |
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional]  |
| **referencia** | **string** |  | [optional]  |
| **chave** | **string** | Chave de acesso do DF-e. | [optional]  |

### Tipo de retorno

[**DfeListagem**](DfeListagem.md)

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

