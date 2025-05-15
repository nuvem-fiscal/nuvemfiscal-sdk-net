# NuvemFiscal.Sdk.Model.DistribuicaoNfe

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**id** | **string** | ID único gerado pela Nuvem Fiscal para o pedido de distribuição. | 
**created_at** | **DateTime** | Data/hora em que o pedido foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;. | [optional] 
**status** | **string** | Indica o status da distribuição. | 
**ambiente** | **string** | Identificação do Ambiente. | 
**uf_autor** | **string** | Sigla da UF do autor. | [optional] 
**tipo_consulta** | **string** |  | 
**dist_nsu** | **long?** | Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;distNSU&#x60;.* | [optional] 
**cons_nsu** | **long?** | Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consNSU&#x60;.* | [optional] 
**cons_chave** | **string** | Consulta de NF-e por chave de acesso informada.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consChNFe&#x60;.* | [optional] 
**codigo_status** | **int?** | Código do status de processamento da requisição. | 
**motivo_status** | **string** | Descrição do status de processamento da requisição. | [optional] 
**data_hora_resposta** | **DateTime?** | Data e Hora de processamento da requisição. | 
**ultimo_nsu** | **long?** | Último NSU pesquisado no Ambiente Nacional. Se for o caso, o solicitante pode continuar a consulta a partir deste NSU para obter novos resultados. | 
**max_nsu** | **long?** | Maior NSU existente no Ambiente Nacional para o CNPJ/CPF informado. | 
**documentos** | [**List&lt;DistribuicaoNfeDocumento&gt;**](DistribuicaoNfeDocumento.md) | Conjunto de informações resumidas e documentos fiscais eletrônicos de interesse da pessoa ou empresa. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

