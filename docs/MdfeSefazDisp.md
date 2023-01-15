# NuvemFiscal.Sdk.Model.MdfeSefazDisp
Informações dos dispositivos do Vale Pedágio.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJForn** | **string** | CNPJ da empresa fornecedora do Vale-Pedágio.  * CNPJ da Empresa Fornecedora do Vale-Pedágio, ou seja, empresa que fornece ao Responsável pelo Pagamento do Vale-Pedágio os dispositivos do Vale-Pedágio.  * Informar os zeros não significativos. | 
**CNPJPg** | **string** | CNPJ do responsável pelo pagamento do Vale-Pedágio.  * responsável pelo pagamento do Vale Pedágio. Informar somente quando o responsável não for o emitente do MDF-e.  * Informar os zeros não significativos. | [optional] 
**CPFPg** | **string** | CNPJ do responsável pelo pagamento do Vale-Pedágio.  Informar os zeros não significativos. | [optional] 
**nCompra** | **string** | Número do comprovante de compra.  Número de ordem do comprovante de compra do Vale-Pedágio fornecido para cada veículo ou combinação veicular, por viagem. | [optional] 
**vValePed** | **decimal** | Valor do Vale-Pedagio.  Valor do Vale-Pedágio obrigatório necessário à livre circulação, desde a origem da operação de transporte até o destino, do transportador contratado. | 
**tpValePed** | **string** | Tipo do Vale Pedagio.  * 01 - TAG  * 02 - Cupom  * 03 - Cartão | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

