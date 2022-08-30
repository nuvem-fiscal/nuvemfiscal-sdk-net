# NuvemFiscal.Sdk.Model.NfeSefazICMSST

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**orig** | **int** | Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. | 
**CST** | **string** | Tributção pelo ICMS  41-Não Tributado.  60-Cobrado anteriormente por substituição tributária. | 
**vBCSTRet** | **decimal** | Informar o valor da BC do ICMS ST retido na UF remetente. | 
**pST** | **decimal** | Aliquota suportada pelo consumidor final. | [optional] 
**vICMSSubstituto** | **decimal** | Valor do ICMS Próprio do Substituto cobrado em operação anterior. | [optional] 
**vICMSSTRet** | **decimal** | Informar o valor do ICMS ST retido na UF remetente (iv2.0)). | 
**vBCFCPSTRet** | **decimal** | Informar o valor da Base de Cálculo do FCP retido anteriormente por ST. | [optional] 
**pFCPSTRet** | **decimal** | Percentual relativo ao Fundo de Combate à Pobreza (FCP) retido por substituição tributária. | [optional] 
**vFCPSTRet** | **decimal** | Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) retido por substituição tributária. | [optional] 
**vBCSTDest** | **decimal** | Informar o valor da BC do ICMS ST da UF destino. | 
**vICMSSTDest** | **decimal** | Informar o valor da BC do ICMS ST da UF destino (v2.0). | 
**pRedBCEfet** | **decimal** | Percentual de redução da base de cálculo efetiva. | [optional] 
**vBCEfet** | **decimal** | Valor da base de cálculo efetiva. | [optional] 
**pICMSEfet** | **decimal** | Alíquota do ICMS efetivo. | [optional] 
**vICMSEfet** | **decimal** | Valor do ICMS efetivo. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

