# NuvemFiscal.Sdk.Model.CteSefazUnidCarga
Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpUnidCarga** | **int?** | Tipo da Unidade de Carga.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros | 
**idUnidCarga** | **string** | Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container. | 
**lacUnidCarga** | [**List&lt;CteSefazLacUnidCarga&gt;**](CteSefazLacUnidCarga.md) |  | [optional] 
**qtdRat** | **decimal?** | Quantidade rateada (Peso,Volume). | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

