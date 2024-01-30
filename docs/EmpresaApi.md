# NuvemFiscal.Sdk.Api.EmpresaApi

Todas as URIs relativas a *https://api.nuvemfiscal.com.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**AlterarConfigCte**](EmpresaApi.md#alterarconfigcte) | **PUT** /empresas/{cpf_cnpj}/cte | Alterar configuração de CT-e |
| [**AlterarConfigMdfe**](EmpresaApi.md#alterarconfigmdfe) | **PUT** /empresas/{cpf_cnpj}/mdfe | Alterar configuração de MDF-e |
| [**AlterarConfigNfce**](EmpresaApi.md#alterarconfignfce) | **PUT** /empresas/{cpf_cnpj}/nfce | Alterar configuração de NFC-e |
| [**AlterarConfigNfcom**](EmpresaApi.md#alterarconfignfcom) | **PUT** /empresas/{cpf_cnpj}/nfcom | Alterar configuração de NFCom |
| [**AlterarConfigNfe**](EmpresaApi.md#alterarconfignfe) | **PUT** /empresas/{cpf_cnpj}/nfe | Alterar configuração de NF-e |
| [**AlterarConfigNfse**](EmpresaApi.md#alterarconfignfse) | **PUT** /empresas/{cpf_cnpj}/nfse | Alterar configuração de NFS-e |
| [**AtualizarEmpresa**](EmpresaApi.md#atualizarempresa) | **PUT** /empresas/{cpf_cnpj} | Alterar empresa |
| [**BaixarLogotipoEmpresa**](EmpresaApi.md#baixarlogotipoempresa) | **GET** /empresas/{cpf_cnpj}/logotipo | Baixar logotipo |
| [**CadastrarCertificadoEmpresa**](EmpresaApi.md#cadastrarcertificadoempresa) | **PUT** /empresas/{cpf_cnpj}/certificado | Cadastrar certificado |
| [**ConsultarCertificadoEmpresa**](EmpresaApi.md#consultarcertificadoempresa) | **GET** /empresas/{cpf_cnpj}/certificado | Consultar certificado |
| [**ConsultarConfigCte**](EmpresaApi.md#consultarconfigcte) | **GET** /empresas/{cpf_cnpj}/cte | Consultar configuração de CT-e |
| [**ConsultarConfigMdfe**](EmpresaApi.md#consultarconfigmdfe) | **GET** /empresas/{cpf_cnpj}/mdfe | Consultar configuração de MDF-e |
| [**ConsultarConfigNfce**](EmpresaApi.md#consultarconfignfce) | **GET** /empresas/{cpf_cnpj}/nfce | Consultar configuração de NFC-e |
| [**ConsultarConfigNfcom**](EmpresaApi.md#consultarconfignfcom) | **GET** /empresas/{cpf_cnpj}/nfcom | Consultar configuração de NFCom |
| [**ConsultarConfigNfe**](EmpresaApi.md#consultarconfignfe) | **GET** /empresas/{cpf_cnpj}/nfe | Consultar configuração de NF-e |
| [**ConsultarConfigNfse**](EmpresaApi.md#consultarconfignfse) | **GET** /empresas/{cpf_cnpj}/nfse | Consultar configuração de NFS-e |
| [**ConsultarEmpresa**](EmpresaApi.md#consultarempresa) | **GET** /empresas/{cpf_cnpj} | Consultar empresa |
| [**CriarEmpresa**](EmpresaApi.md#criarempresa) | **POST** /empresas | Cadastrar empresa |
| [**EnviarCertificadoEmpresa**](EmpresaApi.md#enviarcertificadoempresa) | **PUT** /empresas/{cpf_cnpj}/certificado/upload | Upload de certificado |
| [**EnviarLogotipoEmpresa**](EmpresaApi.md#enviarlogotipoempresa) | **PUT** /empresas/{cpf_cnpj}/logotipo | Enviar logotipo |
| [**ExcluirCertificadoEmpresa**](EmpresaApi.md#excluircertificadoempresa) | **DELETE** /empresas/{cpf_cnpj}/certificado | Deletar certificado |
| [**ExcluirEmpresa**](EmpresaApi.md#excluirempresa) | **DELETE** /empresas/{cpf_cnpj} | Deletar empresa |
| [**ExcluirLogotipoEmpresa**](EmpresaApi.md#excluirlogotipoempresa) | **DELETE** /empresas/{cpf_cnpj}/logotipo | Deletar logotipo |
| [**ListarEmpresas**](EmpresaApi.md#listarempresas) | **GET** /empresas | Listar empresas |

<a name="alterarconfigcte"></a>
# **AlterarConfigCte**
> EmpresaConfigCte AlterarConfigCte (string cpfCnpj, EmpresaConfigCte body)

Alterar configuração de CT-e

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
    public class AlterarConfigCteExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaConfigCte(); // EmpresaConfigCte | 

            try
            {
                // Alterar configuração de CT-e
                EmpresaConfigCte result = apiInstance.AlterarConfigCte(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AlterarConfigCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AlterarConfigCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar configuração de CT-e
    ApiResponse<EmpresaConfigCte> response = apiInstance.AlterarConfigCteWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AlterarConfigCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaConfigCte**](EmpresaConfigCte.md) |  |  |

### Tipo de retorno

[**EmpresaConfigCte**](EmpresaConfigCte.md)

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

<a name="alterarconfigmdfe"></a>
# **AlterarConfigMdfe**
> EmpresaConfigMdfe AlterarConfigMdfe (string cpfCnpj, EmpresaConfigMdfe body)

Alterar configuração de MDF-e

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
    public class AlterarConfigMdfeExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaConfigMdfe(); // EmpresaConfigMdfe | 

            try
            {
                // Alterar configuração de MDF-e
                EmpresaConfigMdfe result = apiInstance.AlterarConfigMdfe(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AlterarConfigMdfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AlterarConfigMdfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar configuração de MDF-e
    ApiResponse<EmpresaConfigMdfe> response = apiInstance.AlterarConfigMdfeWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AlterarConfigMdfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaConfigMdfe**](EmpresaConfigMdfe.md) |  |  |

### Tipo de retorno

[**EmpresaConfigMdfe**](EmpresaConfigMdfe.md)

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

<a name="alterarconfignfce"></a>
# **AlterarConfigNfce**
> EmpresaConfigNfce AlterarConfigNfce (string cpfCnpj, EmpresaConfigNfce body)

Alterar configuração de NFC-e

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
    public class AlterarConfigNfceExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaConfigNfce(); // EmpresaConfigNfce | 

            try
            {
                // Alterar configuração de NFC-e
                EmpresaConfigNfce result = apiInstance.AlterarConfigNfce(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AlterarConfigNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AlterarConfigNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar configuração de NFC-e
    ApiResponse<EmpresaConfigNfce> response = apiInstance.AlterarConfigNfceWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AlterarConfigNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaConfigNfce**](EmpresaConfigNfce.md) |  |  |

### Tipo de retorno

[**EmpresaConfigNfce**](EmpresaConfigNfce.md)

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

<a name="alterarconfignfcom"></a>
# **AlterarConfigNfcom**
> EmpresaConfigNfcom AlterarConfigNfcom (string cpfCnpj, EmpresaConfigNfcom body)

Alterar configuração de NFCom

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
    public class AlterarConfigNfcomExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaConfigNfcom(); // EmpresaConfigNfcom | 

            try
            {
                // Alterar configuração de NFCom
                EmpresaConfigNfcom result = apiInstance.AlterarConfigNfcom(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AlterarConfigNfcom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AlterarConfigNfcomWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar configuração de NFCom
    ApiResponse<EmpresaConfigNfcom> response = apiInstance.AlterarConfigNfcomWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AlterarConfigNfcomWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaConfigNfcom**](EmpresaConfigNfcom.md) |  |  |

### Tipo de retorno

[**EmpresaConfigNfcom**](EmpresaConfigNfcom.md)

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

<a name="alterarconfignfe"></a>
# **AlterarConfigNfe**
> EmpresaConfigNfe AlterarConfigNfe (string cpfCnpj, EmpresaConfigNfe body)

Alterar configuração de NF-e

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
    public class AlterarConfigNfeExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaConfigNfe(); // EmpresaConfigNfe | 

            try
            {
                // Alterar configuração de NF-e
                EmpresaConfigNfe result = apiInstance.AlterarConfigNfe(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AlterarConfigNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AlterarConfigNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar configuração de NF-e
    ApiResponse<EmpresaConfigNfe> response = apiInstance.AlterarConfigNfeWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AlterarConfigNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaConfigNfe**](EmpresaConfigNfe.md) |  |  |

### Tipo de retorno

[**EmpresaConfigNfe**](EmpresaConfigNfe.md)

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

<a name="alterarconfignfse"></a>
# **AlterarConfigNfse**
> EmpresaConfigNfse AlterarConfigNfse (string cpfCnpj, EmpresaConfigNfse body)

Alterar configuração de NFS-e

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
    public class AlterarConfigNfseExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaConfigNfse(); // EmpresaConfigNfse | 

            try
            {
                // Alterar configuração de NFS-e
                EmpresaConfigNfse result = apiInstance.AlterarConfigNfse(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AlterarConfigNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AlterarConfigNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar configuração de NFS-e
    ApiResponse<EmpresaConfigNfse> response = apiInstance.AlterarConfigNfseWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AlterarConfigNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaConfigNfse**](EmpresaConfigNfse.md) |  |  |

### Tipo de retorno

[**EmpresaConfigNfse**](EmpresaConfigNfse.md)

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

<a name="atualizarempresa"></a>
# **AtualizarEmpresa**
> Empresa AtualizarEmpresa (string cpfCnpj, Empresa body)

Alterar empresa

Altera o cadastro de uma empresa (emitente/prestador) que esteja associada a sua conta.  Nesse método, por tratar-se de um PUT, caso algum campo não seja informado, o valor dele será apagado.

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
    public class AtualizarEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new Empresa(); // Empresa | 

            try
            {
                // Alterar empresa
                Empresa result = apiInstance.AtualizarEmpresa(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.AtualizarEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante AtualizarEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Alterar empresa
    ApiResponse<Empresa> response = apiInstance.AtualizarEmpresaWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.AtualizarEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**Empresa**](Empresa.md) |  |  |

### Tipo de retorno

[**Empresa**](Empresa.md)

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

<a name="baixarlogotipoempresa"></a>
# **BaixarLogotipoEmpresa**
> FileParameter BaixarLogotipoEmpresa (string cpfCnpj)

Baixar logotipo

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
    public class BaixarLogotipoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Baixar logotipo
                FileParameter result = apiInstance.BaixarLogotipoEmpresa(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.BaixarLogotipoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante BaixarLogotipoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Baixar logotipo
    ApiResponse<FileParameter> response = apiInstance.BaixarLogotipoEmpresaWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.BaixarLogotipoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

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

<a name="cadastrarcertificadoempresa"></a>
# **CadastrarCertificadoEmpresa**
> EmpresaCertificado CadastrarCertificadoEmpresa (string cpfCnpj, EmpresaPedidoCadastroCertificado body)

Cadastrar certificado

Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * No parâmetro `certificado`, envie o binário do certificado digital (.pfx ou .p12) codificado em **base64**.

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
    public class CadastrarCertificadoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var body = new EmpresaPedidoCadastroCertificado(); // EmpresaPedidoCadastroCertificado | 

            try
            {
                // Cadastrar certificado
                EmpresaCertificado result = apiInstance.CadastrarCertificadoEmpresa(cpfCnpj, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.CadastrarCertificadoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CadastrarCertificadoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Cadastrar certificado
    ApiResponse<EmpresaCertificado> response = apiInstance.CadastrarCertificadoEmpresaWithHttpInfo(cpfCnpj, body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.CadastrarCertificadoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **body** | [**EmpresaPedidoCadastroCertificado**](EmpresaPedidoCadastroCertificado.md) |  |  |

### Tipo de retorno

[**EmpresaCertificado**](EmpresaCertificado.md)

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

<a name="consultarcertificadoempresa"></a>
# **ConsultarCertificadoEmpresa**
> EmpresaCertificado ConsultarCertificadoEmpresa (string cpfCnpj)

Consultar certificado

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
    public class ConsultarCertificadoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar certificado
                EmpresaCertificado result = apiInstance.ConsultarCertificadoEmpresa(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarCertificadoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCertificadoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar certificado
    ApiResponse<EmpresaCertificado> response = apiInstance.ConsultarCertificadoEmpresaWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarCertificadoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaCertificado**](EmpresaCertificado.md)

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

<a name="consultarconfigcte"></a>
# **ConsultarConfigCte**
> EmpresaConfigCte ConsultarConfigCte (string cpfCnpj)

Consultar configuração de CT-e

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
    public class ConsultarConfigCteExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar configuração de CT-e
                EmpresaConfigCte result = apiInstance.ConsultarConfigCte(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarConfigCte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarConfigCteWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar configuração de CT-e
    ApiResponse<EmpresaConfigCte> response = apiInstance.ConsultarConfigCteWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarConfigCteWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaConfigCte**](EmpresaConfigCte.md)

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

<a name="consultarconfigmdfe"></a>
# **ConsultarConfigMdfe**
> EmpresaConfigMdfe ConsultarConfigMdfe (string cpfCnpj)

Consultar configuração de MDF-e

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
    public class ConsultarConfigMdfeExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar configuração de MDF-e
                EmpresaConfigMdfe result = apiInstance.ConsultarConfigMdfe(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarConfigMdfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarConfigMdfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar configuração de MDF-e
    ApiResponse<EmpresaConfigMdfe> response = apiInstance.ConsultarConfigMdfeWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarConfigMdfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaConfigMdfe**](EmpresaConfigMdfe.md)

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

<a name="consultarconfignfce"></a>
# **ConsultarConfigNfce**
> EmpresaConfigNfce ConsultarConfigNfce (string cpfCnpj)

Consultar configuração de NFC-e

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
    public class ConsultarConfigNfceExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar configuração de NFC-e
                EmpresaConfigNfce result = apiInstance.ConsultarConfigNfce(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarConfigNfce: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarConfigNfceWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar configuração de NFC-e
    ApiResponse<EmpresaConfigNfce> response = apiInstance.ConsultarConfigNfceWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarConfigNfceWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaConfigNfce**](EmpresaConfigNfce.md)

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

<a name="consultarconfignfcom"></a>
# **ConsultarConfigNfcom**
> EmpresaConfigNfcom ConsultarConfigNfcom (string cpfCnpj)

Consultar configuração de NFCom

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
    public class ConsultarConfigNfcomExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar configuração de NFCom
                EmpresaConfigNfcom result = apiInstance.ConsultarConfigNfcom(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarConfigNfcom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarConfigNfcomWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar configuração de NFCom
    ApiResponse<EmpresaConfigNfcom> response = apiInstance.ConsultarConfigNfcomWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarConfigNfcomWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaConfigNfcom**](EmpresaConfigNfcom.md)

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

<a name="consultarconfignfe"></a>
# **ConsultarConfigNfe**
> EmpresaConfigNfe ConsultarConfigNfe (string cpfCnpj)

Consultar configuração de NF-e

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
    public class ConsultarConfigNfeExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar configuração de NF-e
                EmpresaConfigNfe result = apiInstance.ConsultarConfigNfe(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarConfigNfe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarConfigNfeWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar configuração de NF-e
    ApiResponse<EmpresaConfigNfe> response = apiInstance.ConsultarConfigNfeWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarConfigNfeWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaConfigNfe**](EmpresaConfigNfe.md)

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

<a name="consultarconfignfse"></a>
# **ConsultarConfigNfse**
> EmpresaConfigNfse ConsultarConfigNfse (string cpfCnpj)

Consultar configuração de NFS-e

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
    public class ConsultarConfigNfseExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar configuração de NFS-e
                EmpresaConfigNfse result = apiInstance.ConsultarConfigNfse(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarConfigNfse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarConfigNfseWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar configuração de NFS-e
    ApiResponse<EmpresaConfigNfse> response = apiInstance.ConsultarConfigNfseWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarConfigNfseWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**EmpresaConfigNfse**](EmpresaConfigNfse.md)

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

<a name="consultarempresa"></a>
# **ConsultarEmpresa**
> Empresa ConsultarEmpresa (string cpfCnpj)

Consultar empresa

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
    public class ConsultarEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Consultar empresa
                Empresa result = apiInstance.ConsultarEmpresa(cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ConsultarEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar empresa
    ApiResponse<Empresa> response = apiInstance.ConsultarEmpresaWithHttpInfo(cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ConsultarEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

[**Empresa**](Empresa.md)

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

<a name="criarempresa"></a>
# **CriarEmpresa**
> Empresa CriarEmpresa (Empresa body)

Cadastrar empresa

Cadastre uma nova empresa (emitente ou prestador) à sua conta.

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
    public class CriarEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var body = new Empresa(); // Empresa | 

            try
            {
                // Cadastrar empresa
                Empresa result = apiInstance.CriarEmpresa(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.CriarEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante CriarEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Cadastrar empresa
    ApiResponse<Empresa> response = apiInstance.CriarEmpresaWithHttpInfo(body);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.CriarEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **body** | [**Empresa**](Empresa.md) |  |  |

### Tipo de retorno

[**Empresa**](Empresa.md)

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

<a name="enviarcertificadoempresa"></a>
# **EnviarCertificadoEmpresa**
> EmpresaCertificado EnviarCertificadoEmpresa (string cpfCnpj, FileParameter input = null)

Upload de certificado

Cadastre ou atualize um certificado digital e vincule a sua empresa, para que possa iniciar a emissão de notas.  * Utilize o `content-type` igual a `multipart/form-data`.  * No parâmetro `file`, envie o binário do arquivo (.pfx ou .p12) do certificado digital.  * No parâmetro `password`, envie a senha do certificado.

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
    public class EnviarCertificadoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var input = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Upload de certificado
                EmpresaCertificado result = apiInstance.EnviarCertificadoEmpresa(cpfCnpj, input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.EnviarCertificadoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EnviarCertificadoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Upload de certificado
    ApiResponse<EmpresaCertificado> response = apiInstance.EnviarCertificadoEmpresaWithHttpInfo(cpfCnpj, input);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.EnviarCertificadoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **input** | **FileParameter****FileParameter** |  | [optional]  |

### Tipo de retorno

[**EmpresaCertificado**](EmpresaCertificado.md)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="enviarlogotipoempresa"></a>
# **EnviarLogotipoEmpresa**
> void EnviarLogotipoEmpresa (string cpfCnpj, FileParameter input = null)

Enviar logotipo

Cadastre ou atualize um logotipo e vincule a sua empresa.    **Restrições:**  * Tipos de mídia (MIME) suportados: `image/png` e `image/jpeg`  * Tamanho máximo do arquivo: 200 KB    **Cenários de uso:**  * Quero que minhas notas sejam impressas com esse logotipo.  * Quero trocar o logotipo utilizado em minhas impressões.

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
    public class EnviarLogotipoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
            var input = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Enviar logotipo
                apiInstance.EnviarLogotipoEmpresa(cpfCnpj, input);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.EnviarLogotipoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante EnviarLogotipoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Enviar logotipo
    apiInstance.EnviarLogotipoEmpresaWithHttpInfo(cpfCnpj, input);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.EnviarLogotipoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |
| **input** | **FileParameter****FileParameter** |  | [optional]  |

### Tipo de retorno

void (empty response body)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: multipart/form-data
 - **Accept**: Não especificado


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **204** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="excluircertificadoempresa"></a>
# **ExcluirCertificadoEmpresa**
> void ExcluirCertificadoEmpresa (string cpfCnpj)

Deletar certificado

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
    public class ExcluirCertificadoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Deletar certificado
                apiInstance.ExcluirCertificadoEmpresa(cpfCnpj);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ExcluirCertificadoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ExcluirCertificadoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Deletar certificado
    apiInstance.ExcluirCertificadoEmpresaWithHttpInfo(cpfCnpj);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ExcluirCertificadoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

void (empty response body)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: Não especificado


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **204** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="excluirempresa"></a>
# **ExcluirEmpresa**
> void ExcluirEmpresa (string cpfCnpj)

Deletar empresa

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
    public class ExcluirEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Deletar empresa
                apiInstance.ExcluirEmpresa(cpfCnpj);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ExcluirEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ExcluirEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Deletar empresa
    apiInstance.ExcluirEmpresaWithHttpInfo(cpfCnpj);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ExcluirEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

void (empty response body)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: Não especificado


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **204** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="excluirlogotipoempresa"></a>
# **ExcluirLogotipoEmpresa**
> void ExcluirLogotipoEmpresa (string cpfCnpj)

Deletar logotipo

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
    public class ExcluirLogotipoEmpresaExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var cpfCnpj = "cpfCnpj_example";  // string | CPF ou CNPJ da empresa.  Utilize o valor sem máscara.

            try
            {
                // Deletar logotipo
                apiInstance.ExcluirLogotipoEmpresa(cpfCnpj);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ExcluirLogotipoEmpresa: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ExcluirLogotipoEmpresaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Deletar logotipo
    apiInstance.ExcluirLogotipoEmpresaWithHttpInfo(cpfCnpj);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ExcluirLogotipoEmpresaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **cpfCnpj** | **string** | CPF ou CNPJ da empresa.  Utilize o valor sem máscara. |  |

### Tipo de retorno

void (empty response body)

### Autorização

[jwt](../README.md#jwt), [oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: Não especificado


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **204** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listarempresas"></a>
# **ListarEmpresas**
> EmpresaListagem ListarEmpresas (int? top = null, int? skip = null, bool? inlinecount = null, string cpfCnpj = null)

Listar empresas

Retorna a lista das empresas associadas à sua conta. As empresas são retornadas ordenadas pela data da criação, com as mais recentes aparecendo primeiro.

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
    public class ListarEmpresasExample
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
            var apiInstance = new EmpresaApi(httpClient, config, httpClientHandler);
            var top = 10;  // int? | Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional)  (default to 10)
            var skip = 0;  // int? | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional)  (default to 0)
            var inlinecount = false;  // bool? | Inclui no JSON de resposta, na propriedade `@count`, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional)  (default to false)
            var cpfCnpj = "cpfCnpj_example";  // string | Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (optional) 

            try
            {
                // Listar empresas
                EmpresaListagem result = apiInstance.ListarEmpresas(top, skip, inlinecount, cpfCnpj);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmpresaApi.ListarEmpresas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarEmpresasWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Listar empresas
    ApiResponse<EmpresaListagem> response = apiInstance.ListarEmpresasWithHttpInfo(top, skip, inlinecount, cpfCnpj);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar EmpresaApi.ListarEmpresasWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **top** | **int?** | Limite no número de objetos a serem retornados pela API, entre 1 e 100. | [optional] [default to 10] |
| **skip** | **int?** | Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. | [optional] [default to 0] |
| **inlinecount** | **bool?** | Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. | [optional] [default to false] |
| **cpfCnpj** | **string** | Filtrar pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. | [optional]  |

### Tipo de retorno

[**EmpresaListagem**](EmpresaListagem.md)

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

