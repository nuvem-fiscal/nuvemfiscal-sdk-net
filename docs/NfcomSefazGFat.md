# NuvemFiscal.Sdk.Model.NfcomSefazGFat
Grupo de informações de controle da Fatura.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CompetFat** | **string** | Ano e mês referência do faturamento (AAAAMM). | 
**dVencFat** | **DateTime?** | Data de vencimento da fatura.  Formato AAAA-MM-DD. | 
**dPerUsoIni** | **DateTime?** | Período de uso inicial.  Formato AAAA-MM-DD. | [optional] 
**dPerUsoFim** | **DateTime?** | Período de uso final.  Formato AAAA-MM-DD. | [optional] 
**codBarras** | **string** | Linha digitável do código de barras. | 
**codDebAuto** | **string** | Código de autorização débito em conta. | [optional] 
**codBanco** | **string** | Número do banco para débito em conta. | [optional] 
**codAgencia** | **string** | Número da agência bancária para débito em conta. | [optional] 
**enderCorresp** | [**NfcomSefazEndeEmi**](NfcomSefazEndeEmi.md) |  | [optional] 
**gPIX** | [**NfcomSefazGPIX**](NfcomSefazGPIX.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

