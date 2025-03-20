# NuvemFiscal.Sdk.Model.DceSefazDest
Identificação do destinatário da DCe.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos. | [optional] 
**CPF** | **string** | Número do CPF.  Informar os zeros não significativos. | [optional] 
**idOutros** | **string** | Identificação do destinatário outros.  Identificação do destinatário não obrigado a inscrição do CPF tais como estrangeiro, indígena e quilombola  Em caso de não contar CPF do assinante, informar o RG. | [optional] 
**xNome** | **string** | Razão social ou Nome do destinatário. | 
**enderDest** | [**DceSefazEndeDest**](DceSefazEndeDest.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

