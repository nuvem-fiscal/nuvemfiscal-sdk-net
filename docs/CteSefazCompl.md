# NuvemFiscal.Sdk.Model.CteSefazCompl

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**xCaracAd** | **string** | Característica adicional do transporte.  Texto livre:  REENTREGA; DEVOLUÇÃO; REFATURAMENTO; etc. | [optional] 
**xCaracSer** | **string** | Característica adicional do serviço.  Texto livre:             ENTREGA EXPRESSA; LOGÍSTICA REVERSA; CONVENCIONAL; EMERGENCIAL; etc. | [optional] 
**xEmi** | **string** | Funcionário emissor do CTe. | [optional] 
**fluxo** | [**CteSefazFluxo**](CteSefazFluxo.md) |  | [optional] 
**Entrega** | [**CteSefazEntrega**](CteSefazEntrega.md) |  | [optional] 
**origCalc** | **string** | Município de origem para efeito de cálculo do frete. | [optional] 
**destCalc** | **string** | Município de destino para efeito de cálculo do frete. | [optional] 
**xObs** | **string** | Observações Gerais. | [optional] 
**ObsCont** | [**List&lt;CteSefazObsCont&gt;**](CteSefazObsCont.md) | Campo de uso livre do contribuinte.  Informar o nome do campo no atributo xCampo e o conteúdo do campo no XTexto. | [optional] 
**ObsFisco** | [**List&lt;CteSefazObsFisco&gt;**](CteSefazObsFisco.md) | Campo de uso livre do contribuinte.  Informar o nome do campo no atributo xCampo e o conteúdo do campo no XTexto. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

