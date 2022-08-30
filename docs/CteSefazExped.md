# NuvemFiscal.Sdk.Model.CteSefazExped

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.              Informar os zeros não significativos. | [optional] 
**CPF** | **string** | Número do CPF.  Informar os zeros não significativos. | [optional] 
**IE** | **string** | Inscrição Estadual.  Informar a IE do expedidor ou ISENTO se expedidor é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o expedidor não seja contribuinte do ICMS não informar a tag. | [optional] 
**xNome** | **string** | Razão Social ou Nome. | 
**fone** | **string** | Telefone. | [optional] 
**enderExped** | [**CteSefazEndereco**](CteSefazEndereco.md) |  | 
**email** | **string** | Endereço de email. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

