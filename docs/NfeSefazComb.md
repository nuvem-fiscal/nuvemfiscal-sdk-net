# NuvemFiscal.Sdk.Model.NfeSefazComb
Informar apenas para operações com combustíveis líquidos.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cProdANP** | **int?** | Código de produto da ANP. codificação de produtos do SIMP (http://www.anp.gov.br). | 
**descANP** | **string** | Descrição do Produto conforme ANP. Utilizar a descrição de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/). | 
**pGLP** | **decimal?** | Percentual do GLP derivado do petróleo no produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do GLP derivado de petróleo no produto GLP. Valores 0 a 100. | [optional] 
**pGNn** | **decimal?** | Percentual de gás natural nacional - GLGNn para o produto GLP (cProdANP&#x3D;210203001). Informar em número decimal o percentual do Gás Natural Nacional - GLGNn para o produto GLP. Valores de 0 a 100. | [optional] 
**pGNi** | **decimal?** | Percentual de gás natural importado GLGNi para o produto GLP (cProdANP&#x3D;210203001). Informar em número deciaml o percentual do Gás Natural Importado - GLGNi para o produto GLP. Valores de 0 a 100. | [optional] 
**vPart** | **decimal?** | Valor de partida (cProdANP&#x3D;210203001). Deve ser informado neste campo o valor por quilograma sem ICMS. | [optional] 
**CODIF** | **string** | Código de autorização / registro do CODIF. Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do    Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível). | [optional] 
**qTemp** | **decimal?** | Quantidade de combustível  faturada à temperatura ambiente.  Informar quando a quantidade  faturada informada no campo  qCom (I10) tiver sido ajustada para  uma temperatura diferente da  ambiente. | [optional] 
**UFCons** | **string** | Sigla da UF de Consumo. | 
**CIDE** | [**NfeSefazCIDE**](NfeSefazCIDE.md) |  | [optional] 
**encerrante** | [**NfeSefazEncerrante**](NfeSefazEncerrante.md) |  | [optional] 
**pBio** | **decimal?** | Percentual do índice de mistura do Biodiesel (B100) no Óleo Diesel B instituído pelo órgão regulamentador. | [optional] 
**origComb** | [**List&lt;NfeSefazOrigComb&gt;**](NfeSefazOrigComb.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

