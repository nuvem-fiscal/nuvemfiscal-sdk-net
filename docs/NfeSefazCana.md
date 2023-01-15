# NuvemFiscal.Sdk.Model.NfeSefazCana
Informações de registro aquisições de cana.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**safra** | **string** | Identificação da safra. | 
**_ref** | **string** | Mês e Ano de Referência, formato: MM/AAAA. | 
**forDia** | [**List&lt;NfeSefazForDia&gt;**](NfeSefazForDia.md) |  | 
**qTotMes** | **decimal** | Total do mês. | 
**qTotAnt** | **decimal** | Total Anterior. | 
**qTotGer** | **decimal** | Total Geral. | 
**deduc** | [**List&lt;NfeSefazDeduc&gt;**](NfeSefazDeduc.md) |  | [optional] 
**vFor** | **decimal** | Valor  dos fornecimentos. | 
**vTotDed** | **decimal** | Valor Total das Deduções. | 
**vLiqFor** | **decimal** | Valor Líquido dos fornecimentos. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

