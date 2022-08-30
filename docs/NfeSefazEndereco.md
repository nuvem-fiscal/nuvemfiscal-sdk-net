# NuvemFiscal.Sdk.Model.NfeSefazEndereco

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**xLgr** | **string** | Logradouro. | 
**nro** | **string** | Número. | 
**xCpl** | **string** | Complemento. | [optional] 
**xBairro** | **string** | Bairro. | 
**cMun** | **int** | Código do município (utilizar a tabela do IBGE), informar 9999999 para operações com o exterior. | 
**xMun** | **string** | Nome do município, informar EXTERIOR para operações com o exterior. | 
**UF** | **string** | Sigla da UF, informar EX para operações com o exterior. | 
**CEP** | **int** | CEP. | [optional] 
**cPais** | **int** | Código de Pais. | [optional] 
**xPais** | **string** | Nome do país. | [optional] 
**fone** | **string** | Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

