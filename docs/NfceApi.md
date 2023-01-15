# NuvemFiscal.Sdk.Api.NfceApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**BaixarPdfNfce**](NfceApi.md#baixarpdfnfce) | **GET** /nfce/{id}/pdf | Baixar PDF do DANFCE |
| [**BaixarXmlCancelamentoNfce**](NfceApi.md#baixarxmlcancelamentonfce) | **GET** /nfce/{id}/cancelamento/xml | Baixar XML do cancelamento |
| [**BaixarXmlInutilizacaoNfce**](NfceApi.md#baixarxmlinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id}/xml | Baixar XML da inutilização |
| [**BaixarXmlNfce**](NfceApi.md#baixarxmlnfce) | **GET** /nfce/{id}/xml | Baixar XML da NFC-e processada |
| [**CancelarNfce**](NfceApi.md#cancelarnfce) | **POST** /nfce/{id}/cancelamento | Cancelar uma NFC-e autorizada |
| [**ConsultarCancelamentoNfce**](NfceApi.md#consultarcancelamentonfce) | **GET** /nfce/{id}/cancelamento | Consultar o cancelamento da NFC-e |
| [**ConsultarInutilizacaoNfce**](NfceApi.md#consultarinutilizacaonfce) | **GET** /nfce/inutilizacoes/{id} | Consultar a inutilização de sequência de numeração |
| [**ConsultarLoteNfce**](NfceApi.md#consultarlotenfce) | **GET** /nfce/lotes/{id} | Consultar lote de NFC-e |
| [**ConsultarNfce**](NfceApi.md#consultarnfce) | **GET** /nfce/{id} | Consultar NFC-e |
| [**ConsultarStatusSefazNfce**](NfceApi.md#consultarstatussefaznfce) | **GET** /nfce/sefaz/status | Consulta do Status do Serviço na SEFAZ Autorizadora |
| [**EmitirLoteNfce**](NfceApi.md#emitirlotenfce) | **POST** /nfce/lotes | Emitir lote de NFC-e |
| [**EmitirNfce**](NfceApi.md#emitirnfce) | **POST** /nfce | Emitir NFC-e |
| [**InutilizarNumeracaoNfce**](NfceApi.md#inutilizarnumeracaonfce) | **POST** /nfce/inutilizacoes | Inutilizar uma sequência de numeração de NFC-e |
| [**ListarLotesNfce**](NfceApi.md#listarlotesnfce) | **GET** /nfce/lotes | Listar lotes de NFC-e |
| [**ListarNfce**](NfceApi.md#listarnfce) | **GET** /nfce | Listar NFC-e |

<a name="baixarpdfnfce"></a>
# **BaixarPdfNfce**
> FileParameter BaixarPdfNfce (string id)

Baixar PDF do DANFCE

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
    public class BaixarPdfNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NFC-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar PDF do DANFCE
                FileParameter result = apiInstance.BaixarPdfNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.BaixarPdfNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarPdfNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar PDF do DANFCE
    ApiResponse<FileParameter> response = apiInstance.BaixarPdfNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.BaixarPdfNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NFC-e gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmlcancelamentonfce"></a>
# **BaixarXmlCancelamentoNfce**
> FileParameter BaixarXmlCancelamentoNfce (string id)

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
    public class BaixarXmlCancelamentoNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NFC-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML do cancelamento
                FileParameter result = apiInstance.BaixarXmlCancelamentoNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.BaixarXmlCancelamentoNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlCancelamentoNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML do cancelamento
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlCancelamentoNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.BaixarXmlCancelamentoNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NFC-e gerado pela Nuvem Fiscal. |  |

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

<a name="baixarxmlinutilizacaonfce"></a>
# **BaixarXmlInutilizacaoNfce**
> FileParameter BaixarXmlInutilizacaoNfce (string id)

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
    public class BaixarXmlInutilizacaoNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do evento gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML da inutilização
                FileParameter result = apiInstance.BaixarXmlInutilizacaoNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.BaixarXmlInutilizacaoNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlInutilizacaoNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da inutilização
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlInutilizacaoNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.BaixarXmlInutilizacaoNfceWithHttpInfo: " + e.Message);
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

<a name="baixarxmlnfce"></a>
# **BaixarXmlNfce**
> FileParameter BaixarXmlNfce (string id)

Baixar XML da NFC-e processada

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
    public class BaixarXmlNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NFC-e gerado pela Nuvem Fiscal.

            try
            {
                // Baixar XML da NFC-e processada
                FileParameter result = apiInstance.BaixarXmlNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.BaixarXmlNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarXmlNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar XML da NFC-e processada
    ApiResponse<FileParameter> response = apiInstance.BaixarXmlNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.BaixarXmlNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NFC-e gerado pela Nuvem Fiscal. |  |

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

<a name="cancelarnfce"></a>
# **CancelarNfce**
> DfeCancelamento CancelarNfce (string id, NfePedidoCancelamento body)

Cancelar uma NFC-e autorizada

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
    public class CancelarNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NFC-e gerado pela Nuvem Fiscal.
            var body = new NfePedidoCancelamento(); // NfePedidoCancelamento | 

            try
            {
                // Cancelar uma NFC-e autorizada
                DfeCancelamento result = apiInstance.CancelarNfce(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.CancelarNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CancelarNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Cancelar uma NFC-e autorizada
    ApiResponse<DfeCancelamento> response = apiInstance.CancelarNfceWithHttpInfo(id, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.CancelarNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NFC-e gerado pela Nuvem Fiscal. |  |
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

<a name="consultarcancelamentonfce"></a>
# **ConsultarCancelamentoNfce**
> DfeCancelamento ConsultarCancelamentoNfce (string id)

Consultar o cancelamento da NFC-e

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
    public class ConsultarCancelamentoNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NFC-e gerado pela Nuvem Fiscal.

            try
            {
                // Consultar o cancelamento da NFC-e
                DfeCancelamento result = apiInstance.ConsultarCancelamentoNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ConsultarCancelamentoNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCancelamentoNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o cancelamento da NFC-e
    ApiResponse<DfeCancelamento> response = apiInstance.ConsultarCancelamentoNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ConsultarCancelamentoNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NFC-e gerado pela Nuvem Fiscal. |  |

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

<a name="consultarinutilizacaonfce"></a>
# **ConsultarInutilizacaoNfce**
> DfeInutilizacao ConsultarInutilizacaoNfce (string id)

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
    public class ConsultarInutilizacaoNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do evento gerado pela Nuvem Fiscal.

            try
            {
                // Consultar a inutilização de sequência de numeração
                DfeInutilizacao result = apiInstance.ConsultarInutilizacaoNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ConsultarInutilizacaoNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarInutilizacaoNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar a inutilização de sequência de numeração
    ApiResponse<DfeInutilizacao> response = apiInstance.ConsultarInutilizacaoNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ConsultarInutilizacaoNfceWithHttpInfo: " + e.Message);
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

<a name="consultarlotenfce"></a>
# **ConsultarLoteNfce**
> DfeLote ConsultarLoteNfce (string id)

Consultar lote de NFC-e

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
    public class ConsultarLoteNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único do lote gerado pela Nuvem Fiscal.

            try
            {
                // Consultar lote de NFC-e
                DfeLote result = apiInstance.ConsultarLoteNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ConsultarLoteNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarLoteNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar lote de NFC-e
    ApiResponse<DfeLote> response = apiInstance.ConsultarLoteNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ConsultarLoteNfceWithHttpInfo: " + e.Message);
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

<a name="consultarnfce"></a>
# **ConsultarNfce**
> Dfe ConsultarNfce (string id)

Consultar NFC-e

Consulta os detalhes de uma NFC-e já existente. Forneça o ID único obtido de uma requisição de emissão ou de listagem de notas e a Nuvem Fiscal irá retornar as informações da nota correspondente.

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
    public class ConsultarNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | ID único da NFC-e gerado pela Nuvem Fiscal.

            try
            {
                // Consultar NFC-e
                Dfe result = apiInstance.ConsultarNfce(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ConsultarNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar NFC-e
    ApiResponse<Dfe> response = apiInstance.ConsultarNfceWithHttpInfo(id);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ConsultarNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **id** | **string** | ID único da NFC-e gerado pela Nuvem Fiscal. |  |

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

<a name="consultarstatussefaznfce"></a>
# **ConsultarStatusSefazNfce**
> DfeSefazStatus ConsultarStatusSefazNfce (string cpfCnpj)

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
    public class ConsultarStatusSefazNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF/CNPJ do emitente.  Utilize o valor sem máscara.

            try
            {
                // Consulta do Status do Serviço na SEFAZ Autorizadora
                DfeSefazStatus result = apiInstance.ConsultarStatusSefazNfce(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ConsultarStatusSefazNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarStatusSefazNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consulta do Status do Serviço na SEFAZ Autorizadora
    ApiResponse<DfeSefazStatus> response = apiInstance.ConsultarStatusSefazNfceWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ConsultarStatusSefazNfceWithHttpInfo: " + e.Message);
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

<a name="emitirlotenfce"></a>
# **EmitirLoteNfce**
> DfeLote EmitirLoteNfce (NfePedidoEmissaoLote body)

Emitir lote de NFC-e

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
    public class EmitirLoteNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var body = new NfePedidoEmissaoLote(); // NfePedidoEmissaoLote | 

            try
            {
                // Emitir lote de NFC-e
                DfeLote result = apiInstance.EmitirLoteNfce(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.EmitirLoteNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirLoteNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Emitir lote de NFC-e
    ApiResponse<DfeLote> response = apiInstance.EmitirLoteNfceWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.EmitirLoteNfceWithHttpInfo: " + e.Message);
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

<a name="emitirnfce"></a>
# **EmitirNfce**
> Dfe EmitirNfce (NfePedidoEmissao body)

Emitir NFC-e

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
    public class EmitirNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var body = new NfePedidoEmissao(); // NfePedidoEmissao | 

            try
            {
                // Emitir NFC-e
                Dfe result = apiInstance.EmitirNfce(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.EmitirNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EmitirNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Emitir NFC-e
    ApiResponse<Dfe> response = apiInstance.EmitirNfceWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.EmitirNfceWithHttpInfo: " + e.Message);
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

<a name="inutilizarnumeracaonfce"></a>
# **InutilizarNumeracaoNfce**
> DfeInutilizacao InutilizarNumeracaoNfce (DfePedidoInutilizacao body)

Inutilizar uma sequência de numeração de NFC-e

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
    public class InutilizarNumeracaoNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var body = new DfePedidoInutilizacao(); // DfePedidoInutilizacao | 

            try
            {
                // Inutilizar uma sequência de numeração de NFC-e
                DfeInutilizacao result = apiInstance.InutilizarNumeracaoNfce(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.InutilizarNumeracaoNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante InutilizarNumeracaoNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Inutilizar uma sequência de numeração de NFC-e
    ApiResponse<DfeInutilizacao> response = apiInstance.InutilizarNumeracaoNfceWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.InutilizarNumeracaoNfceWithHttpInfo: " + e.Message);
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

<a name="listarlotesnfce"></a>
# **ListarLotesNfce**
> DfeLoteListagem ListarLotesNfce (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null, string referencia = null)

Listar lotes de NFC-e

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
    public class ListarLotesNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do emitente.  Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = true;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional) 
            var referencia = "referencia_example";  // string |  (optional) 

            try
            {
                // Listar lotes de NFC-e
                DfeLoteListagem result = apiInstance.ListarLotesNfce(cpfCnpj, ambiente, top, skip, inlinecount, referencia);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ListarLotesNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarLotesNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar lotes de NFC-e
    ApiResponse<DfeLoteListagem> response = apiInstance.ListarLotesNfceWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, referencia);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ListarLotesNfceWithHttpInfo: " + e.Message);
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

<a name="listarnfce"></a>
# **ListarNfce**
> DfeListagem ListarNfce (string cpfCnpj, string ambiente, int? top = null, int? skip = null, bool? inlinecount = null, string referencia = null, string chave = null)

Listar NFC-e

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
    public class ListarNfceExample
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
            var apiInstance = new NfceApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ do emitente.    Utilize o valor sem máscara.
            var ambiente = "ambiente_example";  // string | Identificação do Ambiente.    Valores aceitos: homologacao, producao
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = true;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional) 
            var referencia = "referencia_example";  // string |  (optional) 
            var chave = "chave_example";  // string | Chave de acesso do DF-e. (optional) 

            try
            {
                // Listar NFC-e
                DfeListagem result = apiInstance.ListarNfce(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NfceApi.ListarNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar NFC-e
    ApiResponse<DfeListagem> response = apiInstance.ListarNfceWithHttpInfo(cpfCnpj, ambiente, top, skip, inlinecount, referencia, chave);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar NfceApi.ListarNfceWithHttpInfo: " + e.Message);
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

