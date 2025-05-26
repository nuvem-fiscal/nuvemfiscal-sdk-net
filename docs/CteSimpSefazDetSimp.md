# NuvemFiscal.Sdk.Model.CteSimpSefazDetSimp
Detalhamento das entregas / prestações do CTe Simplificado.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nItem** | **int?** | Número identificador do item agrupador da prestação. | 
**cMunIni** | **string** | Código do Município de início da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior. | 
**xMunIni** | **string** | Nome do Município do início da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior. | 
**cMunFim** | **string** | Código do Município de término da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior. | 
**xMunFim** | **string** | Nome do Município do término da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior. | 
**vPrest** | **decimal?** | Valorl da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS. | 
**vRec** | **decimal?** | Valor a Receber. | 
**Comp** | [**List&lt;CteSimpSefazCompSimp&gt;**](CteSimpSefazCompSimp.md) |  | [optional] 
**infNFe** | [**List&lt;CteSimpSefazInfNFeSimp&gt;**](CteSimpSefazInfNFeSimp.md) |  | [optional] 
**infDocAnt** | [**List&lt;CteSimpSefazInfDocAntSimp&gt;**](CteSimpSefazInfDocAntSimp.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

