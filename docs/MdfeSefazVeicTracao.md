# NuvemFiscal.Sdk.Model.MdfeSefazVeicTracao
Dados do Veículo com a Tração.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cInt** | **string** | Código interno do veículo. | [optional] 
**placa** | **string** | Placa do veículo. | 
**RENAVAM** | **string** | RENAVAM do veículo. | [optional] 
**tara** | **int?** | Tara em KG. | 
**capKG** | **int?** | Capacidade em KG. | [optional] 
**capM3** | **int?** | Capacidade em M3. | [optional] 
**prop** | [**MdfeSefazProp**](MdfeSefazProp.md) |  | [optional] 
**condutor** | [**List&lt;MdfeSefazCondutor&gt;**](MdfeSefazCondutor.md) |  | 
**tpRod** | **string** | Tipo de Rodado.  Preencher com:  * 01 - Truck  * 02 - Toco  * 03 - Cavalo Mecânico  * 04 - VAN  * 05 - Utilitário  * 06 - Outros | 
**tpCar** | **string** | Tipo de Carroceria.  Preencher com:  * 00 - não aplicável  * 01 - Aberta  * 02 - Fechada/Baú  * 03 - Granelera  * 04 - Porta Container  * 05 - Sider | 
**UF** | **string** | UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

