# NuvemFiscal.Sdk.Model.NfeSefazICMS60
Tributação pelo ICMS  * 60 - ICMS cobrado anteriormente por substituição tributária

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**orig** | **int?** | Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. | 
**CST** | **string** | Tributação pelo ICMS  * 60 - ICMS cobrado anteriormente por substituição tributária | 
**vBCSTRet** | **decimal?** | Valor da BC do ICMS ST retido anteriormente. | [optional] 
**pST** | **decimal?** | Aliquota suportada pelo consumidor final. | [optional] 
**vICMSSubstituto** | **decimal?** | Valor do ICMS Próprio do Substituto cobrado em operação anterior. | [optional] 
**vICMSSTRet** | **decimal?** | Valor do ICMS ST retido anteriormente. | [optional] 
**vBCFCPSTRet** | **decimal?** | Valor da Base de cálculo do FCP retido anteriormente por ST. | [optional] 
**pFCPSTRet** | **decimal?** | Percentual de FCP retido anteriormente por substituição tributária. | [optional] 
**vFCPSTRet** | **decimal?** | Valor do FCP retido por substituição tributária. | [optional] 
**pRedBCEfet** | **decimal?** | Percentual de redução da base de cálculo efetiva. | [optional] 
**vBCEfet** | **decimal?** | Valor da base de cálculo efetiva. | [optional] 
**pICMSEfet** | **decimal?** | Alíquota do ICMS efetiva. | [optional] 
**vICMSEfet** | **decimal?** | Valor do ICMS efetivo. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

