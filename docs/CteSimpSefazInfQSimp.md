# NuvemFiscal.Sdk.Model.CteSimpSefazInfQSimp
Informações de quantidades da Carga do CT-e.  Para o Aéreo é obrigatório o preenchimento desse campo da seguinte forma.  * 1 - Peso Bruto, sempre em quilogramas (obrigatório)  * 2 - Peso Cubado  sempre em quilogramas  * 3 - Quantidade de volumes, sempre em unidades (obrigatório)  * 4 - Cubagem, sempre em metros cúbicos (obrigatório apenas quando for impossível preencher as dimensões da(s) embalagem(ens) na tag xDime do leiaute do Aéreo)

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cUnid** | **string** | Código da Unidade de Medida.  Preencher com:  * 00 - M3  * 01 - KG  * 02 - TON  * 03 - UNIDADE  * 04 - LITROS  * 05 - MMBTU | 
**tpMed** | **string** | Tipo da Medida.  Informar com:  * 00 - Cubagem da NF-e  * 01 - Cubagem Aferida pelo Transportador  * 02 - Peso Bruto da NF-e  * 03 - Peso Bruto Aferido pelo Transportador  * 04 - Peso Cubado  * 05 - Peso Base do Cálculo do Frete  * 06 - Peso para uso Operacional  * 07 - Caixas  * 08 - Paletes  * 09 - Sacas  * 10 - Containers  * 11 - Rolos  * 12 - Bombonas  * 13 - Latas  * 14 - Litragem  * 15 - Milhão de BTU (British Thermal Units)  * 99 - Outros | 
**qCarga** | **decimal?** | Quantidade. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

