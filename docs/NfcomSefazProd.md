# NuvemFiscal.Sdk.Model.NfcomSefazProd
Dados do Produto ou Serviço.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cProd** | **string** | Código do produto ou serviço. | 
**xProd** | **string** | Descrição do produto ou serviço. | 
**cClass** | **string** | Código de classificação.  Tabela de Classificação de Item da NFCom (validar por RV). | 
**CFOP** | **string** | CFOP.  Utilizar Tabela de CFOP. | [optional] 
**CNPJLD** | **string** | CNPJ da operadora LD.  Informar o CNPJ da operadora LD que irá lançar o item de cofaturamento em nota do tipo faturamento 2. | [optional] 
**uMed** | **int?** | Unidade Básica de Medida.  * 1 - Minuto  * 2 - MB  * 3 - GB  * 4 - UN | 
**qFaturada** | **decimal?** | Quantidade Faturada.  Informar a quantidade de comercialização do produto . | 
**vItem** | **decimal?** | Valor unitário do item. | 
**vDesc** | **decimal?** | Valor do Desconto. | [optional] 
**vOutro** | **decimal?** | Outras despesas acessórias. | [optional] 
**vProd** | **decimal?** | Valor total do item. | 
**dExpiracao** | **DateTime?** | Data de expiração de crédito.  Formato AAAA-MM-DD. | [optional] 
**indDevolucao** | **int?** | Indicador de devolução do valor do item.  * 1 - Devolução do valor do item | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

