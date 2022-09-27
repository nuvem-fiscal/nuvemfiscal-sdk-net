# NuvemFiscal.Sdk.Model.DfeLote

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**id** | **string** | ID único gerado pela Nuvem Fiscal para este documento. | [optional] 
**created_at** | **DateTime** |  | [optional] 
**status** | **string** |  | [optional] 
**ambiente** | **string** |  | [optional] 
**referencia** | **string** | Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento. | [optional] 
**id_lote** | **string** |  | [optional] 
**recibo** | [**DfeRecibo**](DfeRecibo.md) |  | [optional] 
**documentos** | [**List&lt;Dfe&gt;**](Dfe.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

