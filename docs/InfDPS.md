# NuvemFiscal.Sdk.Model.InfDPS
Grupo de informações da DPS relativas ao serviço prestado.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpAmb** | **int?** | Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação | [optional] 
**dhEmi** | **DateTime?** | Data e hora da emissão do DPS. Data e hora no formato UTC (Universal Coordinated Time): AAAA-MM-DDThh:mm:ssTZD. | 
**verAplic** | **string** | Versão do aplicativo que gerou o DPS. | [optional] 
**dCompet** | **DateTime?** | Data em que se iniciou a prestação do serviço: Dia, mês e ano (AAAAMMDD). | 
**subst** | [**Substituicao**](Substituicao.md) |  | [optional] 
**prest** | [**InfoPrestador**](InfoPrestador.md) |  | 
**toma** | [**InfoTomador**](InfoTomador.md) |  | [optional] 
**interm** | [**InfoIntermediario**](InfoIntermediario.md) |  | [optional] 
**serv** | [**Serv**](Serv.md) |  | 
**valores** | [**InfoValores**](InfoValores.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

