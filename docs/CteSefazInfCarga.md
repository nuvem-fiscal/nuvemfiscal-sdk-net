# NuvemFiscal.Sdk.Model.CteSefazInfCarga

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vCarga** | **decimal** | Valor total da carga.  Dever ser informado para todos os modais, com exceção para o Dutoviário. | [optional] 
**proPred** | **string** | Produto predominante.  Informar a descrição do produto predominante. | 
**xOutCat** | **string** | Outras características da carga.  \&quot;FRIA\&quot;, \&quot;GRANEL\&quot;, \&quot;REFRIGERADA\&quot;, \&quot;Medidas: 12X12X12\&quot;. | [optional] 
**infQ** | [**List&lt;CteSefazInfQ&gt;**](CteSefazInfQ.md) | Informações de quantidades da Carga do CT-e.  Para o Aéreo é obrigatório o preenchimento desse campo da seguinte forma.  1 - Peso Bruto, sempre em quilogramas (obrigatório);  2 - Peso Cubado; sempre em quilogramas;  3 - Quantidade de volumes, sempre em unidades (obrigatório);  4 - Cubagem, sempre em metros cúbicos (obrigatório apenas quando for impossível preencher as dimensões da(s) embalagem(ens) na tag xDime do leiaute do Aéreo). | 
**vCargaAverb** | **decimal** | Valor da Carga para efeito de averbação.  Normalmente igual ao valor declarado da mercadoria, diferente por exemplo, quando a mercadoria transportada é isenta de tributos nacionais para exportação, onde é preciso averbar um valor maior, pois no caso de indenização, o valor a ser pago será maior. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

