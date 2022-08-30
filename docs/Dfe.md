# NuvemFiscal.Sdk.Model.Dfe

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**id** | **string** | Identificador único do documento. | [optional] 
**ambiente** | **string** |  | [optional] 
**created_at** | **DateTime** | Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato [&#x60;ISO 8601&#x60;](https://en.wikipedia.org/wiki/ISO_8601). | [optional] 
**status** | **string** |  | [optional] 
**referencia** | **string** | Identificador único usado dentro de seu próprio aplicativo para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento. | [optional] 
**data_emissao** | **DateTime** |  | [optional] 
**modelo** | **int** |  | [optional] 
**serie** | **int** |  | [optional] 
**numero** | **int** |  | [optional] 
**valor_total** | **decimal** |  | [optional] 
**chave** | **string** | Chave de acesso do DF-e. | [optional] 
**autorizacao** | [**DfeAutorizacao**](DfeAutorizacao.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

