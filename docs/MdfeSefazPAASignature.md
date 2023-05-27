# NuvemFiscal.Sdk.Model.MdfeSefazPAASignature
Assinatura RSA do Emitente para DFe gerados por PAA.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**SignatureValue** | **string** | Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64. | 
**RSAKeyValue** | [**MdfeSefazRSAKeyValueType**](MdfeSefazRSAKeyValueType.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

