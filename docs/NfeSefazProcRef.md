# NuvemFiscal.Sdk.Model.NfeSefazProcRef
Grupo de informações do  processo referenciado.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nProc** | **string** | Indentificador do processo ou ato  concessório. | 
**indProc** | **int?** | Origem do processo, informar com:  * 0 - SEFAZ  * 1 - Justiça Federal  * 2 - Justiça Estadual  * 3 - Secex/RFB  * 4 - CONFAZ  * 9 - Outros | 
**tpAto** | **string** | Tipo do ato concessório  Para origem do Processo na SEFAZ (indProc&#x3D;0), informar o  tipo de ato concessório:  * 08 - Termo de Acordo  * 10 - Regime Especial  * 12 - Autorização específica  * 14 - Ajuste SINIEF  * 15 - Convênio ICMS | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

