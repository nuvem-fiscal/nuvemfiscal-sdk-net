# NuvemFiscal.Sdk.Model.NfeSefazCard
Grupo de Cartões, PIX, Boletos e outros Pagamentos Eletrônicos.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpIntegra** | **int?** | Tipo de Integração do processo de pagamento com o sistema de automação da empresa:  * 1 - Pagamento integrado com o sistema de automação da empresa (Ex.: equipamento TEF, Comércio Eletrônico, POS Integrado)  * 2 - Pagamento não integrado com o sistema de automação da empresa (Ex.: equipamento POS Simples) | 
**CNPJ** | **string** | CNPJ da instituição de pagamento. | [optional] 
**tBand** | **string** | Bandeira da operadora de cartão. | [optional] 
**cAut** | **string** | Número de autorização da operação com cartões, PIX, boletos e outros pagamentos eletrônicos. | [optional] 
**CNPJReceb** | **string** | CNPJ do beneficiário do pagamento. | [optional] 
**idTermPag** | **string** | Identificador do terminal de pagamento. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

