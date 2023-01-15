# NuvemFiscal.Sdk.Model.CteSefazDest
Informações do Destinatário do CT-e.  Poderá não ser informado para os CT-e de redespacho intermediário e serviço vinculado a multimodal. Nos demais casos deverá sempre ser informado.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos. | [optional] 
**CPF** | **string** | Número do CPF.  Informar os zeros não significativos. | [optional] 
**IE** | **string** | Inscrição Estadual.  Informar a IE do destinatário ou ISENTO se destinatário é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o destinatário não seja contribuinte do ICMS não informar o conteúdo. | [optional] 
**xNome** | **string** | Razão Social ou Nome do destinatário. | 
**fone** | **string** | Telefone. | [optional] 
**ISUF** | **string** | Inscrição na SUFRAMA.  (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA). | [optional] 
**enderDest** | [**CteSefazEndereco**](CteSefazEndereco.md) |  | 
**email** | **string** | Endereço de email. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

