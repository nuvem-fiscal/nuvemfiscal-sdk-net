# NuvemFiscal.Sdk.Model.CteSefazFluxo

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**xOrig** | **string** | Sigla ou código interno da Filial/Porto/Estação/ Aeroporto de Origem.  Observações para o modal aéreo:                - Preenchimento obrigatório para o modal aéreo.                - O código de três letras IATA do aeroporto de partida deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI. | [optional] 
**pass** | [**List&lt;CteSefazPass&gt;**](CteSefazPass.md) |  | [optional] 
**xDest** | **string** | Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:                - Preenchimento obrigatório para o modal aéreo.                - Deverá ser incluído o código de três letras IATA do aeroporto de destino. Quando não for possível, utilizar a sigla OACI. | [optional] 
**xRota** | **string** | Código da Rota de Entrega. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

