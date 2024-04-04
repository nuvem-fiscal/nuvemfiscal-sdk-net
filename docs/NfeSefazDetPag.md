# NuvemFiscal.Sdk.Model.NfeSefazDetPag
Grupo de detalhamento da forma de pagamento.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**indPag** | **int?** | Indicador da Forma de Pagamento:0-Pagamento à Vista  * 1 - Pagamento à Prazo | [optional] 
**tPag** | **string** | Forma de Pagamento:. | 
**xPag** | **string** | Descrição do Meio de Pagamento. | [optional] 
**vPag** | **decimal?** | Valor do Pagamento. Esta tag poderá ser omitida quando a tag tPag&#x3D;90 (Sem Pagamento), caso contrário deverá ser preenchida. | 
**dPag** | **DateTime?** | Data do Pagamento. | [optional] 
**CNPJPag** | **string** | CNPJ transacional do pagamento - Preencher informando o CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido quando a emissão do documento fiscal ocorrer em estabelecimento distinto. | [optional] 
**UFPag** | **string** | UF do CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido. | [optional] 
**card** | [**NfeSefazCard**](NfeSefazCard.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

