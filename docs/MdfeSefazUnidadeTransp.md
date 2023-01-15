# NuvemFiscal.Sdk.Model.MdfeSefazUnidadeTransp
Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpUnidTransp** | **int** | Tipo da Unidade de Transporte.  * 1 - Rodoviário Tração  * 2 - Rodoviário Reboque  * 3 - Navio  * 4 - Balsa  * 5 - Aeronave  * 6 - Vagão  * 7 - Outros | 
**idUnidTransp** | **string** | Identificação da Unidade de Transporte.  Informar a identificação conforme o tipo de unidade de transporte.  Por exemplo: para rodoviário tração ou reboque deverá preencher com a placa do veículo. | 
**lacUnidTransp** | [**List&lt;MdfeSefazLacUnidTransp&gt;**](MdfeSefazLacUnidTransp.md) |  | [optional] 
**infUnidCarga** | [**List&lt;MdfeSefazUnidCarga&gt;**](MdfeSefazUnidCarga.md) |  | [optional] 
**qtdRat** | **decimal** | Quantidade rateada (Peso,Volume). | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

