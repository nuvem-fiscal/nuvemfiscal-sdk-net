# NuvemFiscal.Sdk.Model.CteSefazInfCarga
Informações da Carga do CT-e.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vCarga** | **decimal** | Valor total da carga.  Dever ser informado para todos os modais, com exceção para o Dutoviário. | [optional] 
**proPred** | **string** | Produto predominante.  Informar a descrição do produto predominante. | 
**xOutCat** | **string** | Outras características da carga.  \&quot;FRIA\&quot;, \&quot;GRANEL\&quot;, \&quot;REFRIGERADA\&quot;, \&quot;Medidas: 12X12X12\&quot;. | [optional] 
**infQ** | [**List&lt;CteSefazInfQ&gt;**](CteSefazInfQ.md) |  | 
**vCargaAverb** | **decimal** | Valor da Carga para efeito de averbação.  Normalmente igual ao valor declarado da mercadoria, diferente por exemplo, quando a mercadoria transportada é isenta de tributos nacionais para exportação, onde é preciso averbar um valor maior, pois no caso de indenização, o valor a ser pago será maior. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

