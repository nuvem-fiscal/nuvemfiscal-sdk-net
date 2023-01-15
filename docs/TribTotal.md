# NuvemFiscal.Sdk.Model.TribTotal
Grupo de informações para totais aproximados dos tributos relacionados ao serviço prestado.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vTotTrib** | [**TribTotalMonet**](TribTotalMonet.md) |  | [optional] 
**pTotTrib** | [**TribTotalPercent**](TribTotalPercent.md) |  | [optional] 
**indTotTrib** | **int** | Indicador de informação de valor total de tributos. Possui valor fixo igual a zero (indTotTrib&#x3D;0).  Não informar nenhum valor estimado para os Tributos (Decreto 8.264/2014).  * 0 - Não | [optional] 
**pTotTribSN** | **decimal** | Valor percentual aproximado do total dos tributos da alíquota do Simples Nacional (%%). | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

