# NuvemFiscal.Sdk.Model.CteOsSefazTomaOS
Informações do Tomador/Usuário do Serviço.  Opcional para Excesso de Bagagem.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos. | [optional] 
**CPF** | **string** | Número do CPF.  Informar os zeros não significativos. | [optional] 
**IE** | **string** | Inscrição Estadual.  Informar a IE do tomador ou ISENTO se tomador é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o tomador não seja contribuinte do ICMS não informar o conteúdo. | [optional] 
**xNome** | **string** | Razão social ou nome do tomador. | 
**xFant** | **string** | Nome fantasia. | [optional] 
**fone** | **string** | Telefone. | [optional] 
**enderToma** | [**CteOsSefazEnderecoOS**](CteOsSefazEnderecoOS.md) |  | 
**email** | **string** | Endereço de email. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

