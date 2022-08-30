# NuvemFiscal.Sdk.Model.CteSefazUnidadeTransp

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpUnidTransp** | **int** | Tipo da Unidade de Transporte.  1 - Rodoviário Tração  2 - Rodoviário Reboque  3 - Navio  4 - Balsa  5 - Aeronave  6 - Vagão  7 - Outros. | 
**idUnidTransp** | **string** | Identificação da Unidade de Transporte.  Informar a identificação conforme o tipo de unidade de transporte.  Por exemplo: para rodoviário tração ou reboque deverá preencher com a placa do veículo. | 
**lacUnidTransp** | [**List&lt;CteSefazLacUnidTransp&gt;**](CteSefazLacUnidTransp.md) | Lacres das Unidades de Transporte. | [optional] 
**infUnidCarga** | [**List&lt;CteSefazUnidCarga&gt;**](CteSefazUnidCarga.md) | Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu. | [optional] 
**qtdRat** | **decimal** | Quantidade rateada (Peso,Volume). | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

