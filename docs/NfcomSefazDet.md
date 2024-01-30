# NuvemFiscal.Sdk.Model.NfcomSefazDet
Detalhamento de Produtos e Serviços.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nItem** | **int?** | Número do item da NFCom. | 
**chNFComAnt** | **string** | Chave de Acesso da NFCom anterior.  Informar chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA. | [optional] 
**nItemAnt** | **string** | Número do item da NFCom anterior.  Informar nro do item da chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA. | [optional] 
**prod** | [**NfcomSefazProd**](NfcomSefazProd.md) |  | 
**imposto** | [**NfcomSefazImposto**](NfcomSefazImposto.md) |  | 
**gProcRef** | [**NfcomSefazGProcRef**](NfcomSefazGProcRef.md) |  | [optional] 
**gRessarc** | [**NfcomSefazGRessarc**](NfcomSefazGRessarc.md) |  | [optional] 
**infAdProd** | **string** | Informações adicionais do produto (norma referenciada, informações complementares, etc). | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

