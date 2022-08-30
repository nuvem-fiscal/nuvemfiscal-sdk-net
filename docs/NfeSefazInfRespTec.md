# NuvemFiscal.Sdk.Model.NfeSefazInfRespTec

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | CNPJ. | 
**xContato** | **string** | Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. | 
**email** | **string** | Informar o e-mail da pessoa a ser contatada na empresa desenvolvedora do sistema. | 
**fone** | **string** | Informar o telefone da pessoa a ser contatada na empresa desenvolvedora do sistema. Preencher com o Código DDD + número do telefone. | 
**idCSRT** | **int** | Identificador do CSRT utilizado para montar o hash do CSRT. | [optional] 
**hashCSRT** | **string** | O hashCSRT é o resultado da função hash (SHA-1 – Base64) do CSRT fornecido pelo fisco mais a Chave de Acesso da NFe. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

