# NuvemFiscal.Sdk.Model.CteSefazICMS60
Tributação pelo ICMS60 - ICMS cobrado por substituição tributária.Responsabilidade do recolhimento do ICMS atribuído ao tomador ou 3º por ST.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CST** | **string** | Classificação Tributária do Serviço.  * 60 - ICMS cobrado por substituição tributária | 
**vBCSTRet** | **decimal?** | Valor da BC do ICMS ST retido.  Valor do frete sobre o qual será calculado o ICMS a ser substituído na Prestação. | 
**vICMSSTRet** | **decimal?** | Valor do ICMS ST retido.  Resultado da multiplicação do “vBCSTRet” x “pICMSSTRet” - que será valor do ICMS a ser retido pelo Substituto. Podendo o valor do ICMS a ser retido efetivamente, sofrer ajustes conforme a opção tributaria do transportador substituído. | 
**pICMSSTRet** | **decimal?** | Alíquota do ICMS.  Percentual de Alíquota incidente na prestação de serviço de transporte. | 
**vCred** | **decimal?** | Valor do Crédito outorgado/Presumido.  Preencher somente quando o transportador substituído, for optante pelo crédito outorgado previsto no Convênio 106/96 e corresponde ao percentual de 20%% do valor do ICMS ST retido. | [optional] 
**vICMSDeson** | **decimal?** | Valor do ICMS de desoneração. | [optional] 
**cBenef** | **string** | Código de Benefício Fiscal na UF.  Código de Benefício Fiscal utilizado pela UF. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

