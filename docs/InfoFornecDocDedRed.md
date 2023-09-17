# NuvemFiscal.Sdk.Model.InfoFornecDocDedRed
Grupo de informações do Fornecedor em Deduções de Serviços.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ. | [optional] 
**CPF** | **string** | Número do CPF. | [optional] 
**NIF** | **string** | Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior. | [optional] 
**cNaoNIF** | **int?** | Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF | [optional] 
**CAEPF** | **string** | Número do Cadastro de Atividade Econômica da Pessoa Física (CAEPF). | [optional] 
**IM** | **string** | Número da inscrição municipal. | [optional] 
**xNome** | **string** | Nome/Nome Empresarial. | 
**end** | [**Endereco**](Endereco.md) |  | [optional] 
**fone** | **string** | Número do telefone do prestador:  Preencher com o Código DDD + número do telefone.  Nas operações com exterior é permitido informar o código do país + código da localidade + número do telefone). | [optional] 
**email** | **string** | * E-mail | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

