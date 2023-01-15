# NuvemFiscal.Sdk.Model.CteSefazEndereco
Dados do endereço.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**xLgr** | **string** | Logradouro. | 
**nro** | **string** | Número. | 
**xCpl** | **string** | Complemento. | [optional] 
**xBairro** | **string** | Bairro. | 
**cMun** | **string** | Código do município (utilizar a tabela do IBGE).  Informar 9999999 para operações com o exterior. | 
**xMun** | **string** | Nome do município.  Informar EXTERIOR para operações com o exterior. | 
**CEP** | **string** | CEP.  Informar os zeros não significativos. | [optional] 
**UF** | **string** | Sigla da UF.  Informar EX para operações com o exterior. | 
**cPais** | **string** | Código do país.  Utilizar a tabela do BACEN. | [optional] 
**xPais** | **string** | Nome do país. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

