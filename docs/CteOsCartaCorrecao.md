# NuvemFiscal.Sdk.Model.CteOsCartaCorrecao

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**correcoes** | [**List&lt;CteOsInfCorrecao&gt;**](CteOsInfCorrecao.md) | Grupo de Informações de Correção. | 
**id** | **string** | ID único gerado pela Nuvem Fiscal para este evento. | [optional] 
**ambiente** | **string** | Identificação do ambiente. | [optional] 
**status** | **string** | Status do Evento. | [optional] 
**autor** | [**DfeAutorEvento**](DfeAutorEvento.md) |  | [optional] 
**chave_acesso** | **string** | Chave de Acesso do documento vinculado ao evento. | [optional] 
**data_evento** | **DateTime** | Data e hora do Evento. | [optional] 
**numero_sequencial** | **int** | Sequencial do evento para o mesmo tipo de evento. | [optional] 
**data_recebimento** | **DateTime?** | Data e hora do recebimento do Evento pela SEFAZ. | [optional] 
**codigo_status** | **int** | Código do status de registro do Evento. | [optional] 
**motivo_status** | **string** | Descrição literal do status do registro do Evento. | [optional] 
**numero_protocolo** | **string** | Número do Protocolo de registro do Evento. | [optional] 
**codigo_mensagem** | **int** | Código da Mensagem. | [optional] 
**mensagem** | **string** | Mensagem da SEFAZ para o emissor. | [optional] 
**tipo_evento** | **string** |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

