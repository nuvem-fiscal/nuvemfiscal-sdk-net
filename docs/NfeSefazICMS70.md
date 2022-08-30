# NuvemFiscal.Sdk.Model.NfeSefazICMS70

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**orig** | **int** | Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. | 
**CST** | **string** | Tributção pelo ICMS  70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária. | 
**modBC** | **int** | Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação. | 
**pRedBC** | **decimal** | Percentual de redução da BC. | 
**vBC** | **decimal** | Valor da BC do ICMS. | 
**pICMS** | **decimal** | Alíquota do ICMS. | 
**vICMS** | **decimal** | Valor do ICMS. | 
**vBCFCP** | **decimal** | Valor da Base de cálculo do FCP. | [optional] 
**pFCP** | **decimal** | Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP). | [optional] 
**vFCP** | **decimal** | Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP). | [optional] 
**modBCST** | **int** | Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor);  6 - Valor da Operação. | 
**pMVAST** | **decimal** | Percentual da Margem de Valor Adicionado ICMS ST. | [optional] 
**pRedBCST** | **decimal** | Percentual de redução da BC ICMS ST. | [optional] 
**vBCST** | **decimal** | Valor da BC do ICMS ST. | 
**pICMSST** | **decimal** | Alíquota do ICMS ST. | 
**vICMSST** | **decimal** | Valor do ICMS ST. | 
**vBCFCPST** | **decimal** | Valor da Base de cálculo do FCP retido por substituição tributária. | [optional] 
**pFCPST** | **decimal** | Percentual de FCP retido por substituição tributária. | [optional] 
**vFCPST** | **decimal** | Valor do FCP retido por substituição tributária. | [optional] 
**vICMSDeson** | **decimal** | Valor do ICMS de desoneração. | [optional] 
**motDesICMS** | **int** | Motivo da desoneração do ICMS:3-Uso na agropecuária;9-Outros;12-Fomento agropecuário. | [optional] 
**vICMSSTDeson** | **decimal** | Valor do ICMS-ST desonerado. | [optional] 
**motDesICMSST** | **int** | Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária; 9-Outros; 12-Fomento agropecuário. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

