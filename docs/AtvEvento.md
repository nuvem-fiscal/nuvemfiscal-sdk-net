# NuvemFiscal.Sdk.Model.AtvEvento
Grupo de informações do DPS relativas à Evento.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**xNome** | **string** | Nome do evento Artístico, Cultural, Esportivo, etc. | [optional] 
**desc** | **string** | &#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;xNome&#x60;*. | [optional] 
**dtIni** | **DateTime?** | Data de início da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD). | 
**dtFim** | **DateTime?** | Data de fim da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD). | 
**idAtvEvt** | **string** | Identificação da Atividade de Evento (código identificador de evento determinado pela Administração Tributária Municipal). | [optional] 
**id** | **string** | &#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;idAtvEvt&#x60;*. | [optional] 
**end** | [**EnderecoSimples**](EnderecoSimples.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

