# NuvemFiscal.Sdk.Model.CteSefazRem
Informações do Remetente das mercadorias transportadas pelo CT-e.  Poderá não ser informado para os CT-e de redespacho intermediário e serviço vinculado a multimodal. Nos demais casos deverá sempre ser informado.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos. | [optional] 
**CPF** | **string** | Número do CPF.  Informar os zeros não significativos. | [optional] 
**IE** | **string** | Inscrição Estadual.  Informar a IE do remetente ou ISENTO se remetente é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o remetente não seja contribuinte do ICMS não informar a tag. | [optional] 
**xNome** | **string** | Razão social ou nome do remetente. | 
**xFant** | **string** | Nome fantasia. | [optional] 
**fone** | **string** | Telefone. | [optional] 
**enderReme** | [**CteSefazEndereco**](CteSefazEndereco.md) |  | 
**email** | **string** | Endereço de email. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

