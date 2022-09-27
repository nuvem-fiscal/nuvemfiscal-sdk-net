# NuvemFiscal.Sdk.Model.RpsPedidoEmissao

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**referencia** | **string** | Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento. | [optional] 
**data_emissao** | **DateTime** | Data e Hora de Emissão do RPS, no formato AAAA-MM-DDTHH:MM:SSTZD.  Caso não informado, será considerada a data/hora da requisição à API da Nuvem Fiscal. | [optional] 
**competencia** | **DateTime** | Competência do RPS, no formato AAAA-MM-DD.  Caso não informado, será considerada a data da requisição à API da Nuvem Fiscal. | [optional] 
**natureza_tributacao** | **int** | Natureza da tributação:  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial. | [optional] 
**prestador** | [**RpsIdentificacaoPrestador**](RpsIdentificacaoPrestador.md) |  | 
**tomador** | [**RpsDadosTomador**](RpsDadosTomador.md) |  | 
**intermediario** | [**RpsDadosIntermediario**](RpsDadosIntermediario.md) |  | [optional] 
**construcao_civil** | [**RpsDadosConstrucaoCivil**](RpsDadosConstrucaoCivil.md) |  | [optional] 
**servicos** | [**List&lt;RpsDadosServico&gt;**](RpsDadosServico.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

