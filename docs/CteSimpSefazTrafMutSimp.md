# NuvemFiscal.Sdk.Model.CteSimpSefazTrafMutSimp
Detalhamento de informações para o tráfego mútuo.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**respFat** | **int?** | Responsável pelo Faturamento.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino | 
**ferrEmi** | **int?** | Ferrovia Emitente do CTe.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino | 
**vFrete** | **decimal?** | Valor do Frete do Tráfego Mútuo. | 
**chCTeFerroOrigem** | **string** | Chave de acesso do CT-e emitido pelo ferrovia de origem. | [optional] 
**ferroEnv** | [**List&lt;CteSimpSefazFerroEnvSimp&gt;**](CteSimpSefazFerroEnvSimp.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

