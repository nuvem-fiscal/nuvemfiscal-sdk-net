# NuvemFiscal.Sdk.Model.CteSefazInfQ
Informações de quantidades da Carga do CT-e.  Para o Aéreo é obrigatório o preenchimento desse campo da seguinte forma.  * 1 - Peso Bruto, sempre em quilogramas (obrigatório)  * 2 - Peso Cubado  sempre em quilogramas  * 3 - Quantidade de volumes, sempre em unidades (obrigatório)  * 4 - Cubagem, sempre em metros cúbicos (obrigatório apenas quando for impossível preencher as dimensões da(s) embalagem(ens) na tag xDime do leiaute do Aéreo)

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cUnid** | **string** | Código da Unidade de Medida.  Preencher com:  * 00 - M3  * 01 - KG  * 02 - TON  * 03 - UNIDADE  * 04 - LITROS  * 05 - MMBTU | 
**tpMed** | **string** | Tipo da Medida.  Exemplos:  PESO BRUTO, PESO DECLARADO, PESO CUBADO, PESO AFORADO, PESO AFERIDO, PESO BASE DE CÁLCULO, LITRAGEM, CAIXAS e etc. | 
**qCarga** | **decimal?** | Quantidade. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

