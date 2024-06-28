# NuvemFiscal.Sdk.Model.DfeContribuinteInfCons
Dados do Resultado do Dados do Pedido de Consulta de cadastro de contribuintes.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**codigo_status** | **int?** | Código do status da mensagem enviada. | 
**motivo_status** | **string** | Descrição literal do status do serviço solicitado. | 
**uf** | **string** | sigla da UF consultada, utilizar SU para SUFRAMA. | 
**ie** | **string** | Inscrição Estadual do contribuinte. | [optional] 
**cnpj** | **string** | CNPJ do contribuinte. | [optional] 
**cpf** | **string** | CPF do contribuinte. | [optional] 
**data_consulta** | **DateTime?** | Data da Consulta. | 
**uf_atendimento** | **int?** | código da UF de atendimento. | 
**informacoes_cadastrais** | [**List&lt;DfeContribuinteInfCad&gt;**](DfeContribuinteInfCad.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

