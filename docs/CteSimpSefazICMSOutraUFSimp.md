# NuvemFiscal.Sdk.Model.CteSimpSefazICMSOutraUFSimp
ICMS devido à UF de origem da prestação, quando  diferente da UF do emitente.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CST** | **string** | Classificação Tributária do Serviço.  * 90 - ICMS Outra UF | 
**pRedBCOutraUF** | **decimal?** | Percentual de redução da BC. | [optional] 
**vBCOutraUF** | **decimal?** | Valor da BC do ICMS. | 
**pICMSOutraUF** | **decimal?** | Alíquota do ICMS. | 
**vICMSOutraUF** | **decimal?** | Valor do ICMS devido outra UF. | 
**vICMSDeson** | **decimal?** | Valor do ICMS de desoneração. | [optional] 
**cBenef** | **string** | Código de Benefício Fiscal na UF.  Código de Benefício Fiscal utilizado pela UF. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

