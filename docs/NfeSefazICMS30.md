# NuvemFiscal.Sdk.Model.NfeSefazICMS30
Tributação pelo ICMS  * 30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**orig** | **int?** | Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. | 
**CST** | **string** | Tributção pelo ICMS  * 30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária | 
**modBCST** | **int?** | Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação | 
**pMVAST** | **decimal?** | Percentual da Margem de Valor Adicionado ICMS ST. | [optional] 
**pRedBCST** | **decimal?** | Percentual de redução da BC ICMS ST. | [optional] 
**vBCST** | **decimal?** | Valor da BC do ICMS ST. | 
**pICMSST** | **decimal?** | Alíquota do ICMS ST. | 
**vICMSST** | **decimal?** | Valor do ICMS ST. | 
**vBCFCPST** | **decimal?** | Valor da Base de cálculo do FCP. | [optional] 
**pFCPST** | **decimal?** | Percentual de FCP retido por substituição tributária. | [optional] 
**vFCPST** | **decimal?** | Valor do FCP retido por substituição tributária. | [optional] 
**vICMSDeson** | **decimal?** | Valor do ICMS de desoneração. | [optional] 
**motDesICMS** | **int?** | Motivo da desoneração do ICMS:6-Utilitários Motocicleta AÁrea Livre  * 7 - SUFRAMA  * 9 - Outros | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

