# NuvemFiscal.Sdk.Model.CteSefazRespTec

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | CNPJ da pessoa jurídica responsável técnica pelo sistema utilizado na emissão do documento fiscal eletrônico.  Informar o CNPJ da pessoa jurídica desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. | 
**xContato** | **string** | Nome da pessoa a ser contatada.  Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. No caso de pessoa física, informar o respectivo nome. | 
**email** | **string** | Email da pessoa jurídica a ser contatada. | 
**fone** | **string** | Telefone da pessoa jurídica a ser contatada.  Preencher com o Código DDD + número do telefone. | 
**idCSRT** | **int** | Identificador do código de segurança do responsável técnico.  Identificador do CSRT utilizado para geração do hash. | [optional] 
**hashCSRT** | **string** | Hash do token do código de segurança do responsável técnico.  O hashCSRT é o resultado das funções SHA-1 e base64 do token CSRT fornecido pelo fisco + chave de acesso do DF-e. (Implementação em futura NT)    Observação: 28 caracteres são representados no schema como 20 bytes do tipo base64Binary. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

