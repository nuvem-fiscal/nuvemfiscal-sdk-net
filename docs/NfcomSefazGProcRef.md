# NuvemFiscal.Sdk.Model.NfcomSefazGProcRef
Grupo Processo referenciado.  Este grupo somente deverá ser preenchido quando houver processo judicial ou administrativo que altere valores.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vItem** | **decimal?** | Valor unitário do item.  Informar o valor sem a influência da decisão judicial/administrativa. | 
**qFaturada** | **decimal?** | Quantidade Faturada.  Informar a quantidade de comercialização do produto . | 
**vProd** | **decimal?** | Valor total do item. | 
**vDesc** | **decimal?** | Valor do Desconto. | [optional] 
**vOutro** | **decimal?** | Outras despesas acessórias. | [optional] 
**indDevolucao** | **int?** | Indicador de devolução do valor do item.  * 1 - Devolução do valor do item | [optional] 
**vBC** | **decimal?** | Valor da BC do ICMS. | [optional] 
**pICMS** | **decimal?** | Alíquota do ICMS. | [optional] 
**vICMS** | **decimal?** | Valor do ICMS. | [optional] 
**vPIS** | **decimal?** | Valor do PIS. | [optional] 
**vCOFINS** | **decimal?** | Valor do COFINS. | [optional] 
**vFCP** | **decimal?** | Valor do Fundo de Combate à Pobreza (FCP). | [optional] 
**gProc** | [**List&lt;NfcomSefazGProc&gt;**](NfcomSefazGProc.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

