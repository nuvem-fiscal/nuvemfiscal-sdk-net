# NuvemFiscal.Sdk.Model.NfeSefazProd

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cProd** | **string** | Código do produto ou serviço. Preencher com CFOP caso se trate de itens não relacionados com mercadorias/produto e que o contribuinte não possua codificação própria  Formato ”CFOP9999”. | 
**cEAN** | **string** | GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras. | 
**cBarra** | **string** | Codigo de barras diferente do padrão GTIN. | [optional] 
**xProd** | **string** | Descrição do produto ou serviço. | 
**NCM** | **string** | Código NCM (8 posições), será permitida a informação do gênero (posição do capítulo do NCM) quando a operação não for de comércio exterior (importação/exportação) ou o produto não seja tributado pelo IPI. Em caso de item de serviço ou item que não tenham produto (Ex. transferência de crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0). | 
**NVE** | **List&lt;string&gt;** | Nomenclatura de Valor aduaneio e Estatístico. | [optional] 
**CEST** | **string** | Codigo especificador da Substuicao Tributaria - CEST, que identifica a mercadoria sujeita aos regimes de  substituicao tributária e de antecipação do recolhimento  do imposto. | [optional] 
**indEscala** | **string** |  | [optional] 
**CNPJFab** | **string** | CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante. | [optional] 
**cBenef** | **string** |  | [optional] 
**EXTIPI** | **string** | Código EX TIPI (3 posições). | [optional] 
**CFOP** | **int** | Cfop. | 
**uCom** | **string** | Unidade comercial. | 
**qCom** | **decimal** | Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros. | 
**vUnCom** | **decimal** | Valor unitário de comercialização  - alterado para aceitar 0 a 10 casas decimais e 11 inteiros. | 
**vProd** | **decimal** | Valor bruto do produto ou serviço. | 
**cEANTrib** | **string** | GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras. | 
**cBarraTrib** | **string** | Código de barras da unidade tributável diferente do padrão GTIN. | [optional] 
**uTrib** | **string** | Unidade Tributável. | 
**qTrib** | **decimal** | Quantidade Tributável - alterado para aceitar de 0 a 4 casas decimais e 11 inteiros. | 
**vUnTrib** | **decimal** | Valor unitário de tributação - - alterado para aceitar 0 a 10 casas decimais e 11 inteiros. | 
**vFrete** | **decimal** | Valor Total do Frete. | [optional] 
**vSeg** | **decimal** | Valor Total do Seguro. | [optional] 
**vDesc** | **decimal** | Valor do Desconto. | [optional] 
**vOutro** | **decimal** | Outras despesas acessórias. | [optional] 
**indTot** | **int** | Este campo deverá ser preenchido com:   0 – o valor do item (vProd) não compõe o valor total da NF-e (vProd)   1  – o valor do item (vProd) compõe o valor total da NF-e (vProd). | 
**DI** | [**List&lt;NfeSefazDI&gt;**](NfeSefazDI.md) | Delcaração de Importação  (NT 2011/004). | [optional] 
**detExport** | [**List&lt;NfeSefazDetExport&gt;**](NfeSefazDetExport.md) | Detalhe da exportação. | [optional] 
**xPed** | **string** | pedido de compra - Informação de interesse do emissor para controle do B2B. | [optional] 
**nItemPed** | **int** | Número do Item do Pedido de Compra - Identificação do número do item do pedido de Compra. | [optional] 
**nFCI** | **string** | Número de controle da FCI - Ficha de Conteúdo de Importação. | [optional] 
**rastro** | [**List&lt;NfeSefazRastro&gt;**](NfeSefazRastro.md) |  | [optional] 
**infProdNFF** | [**NfeSefazInfProdNFF**](NfeSefazInfProdNFF.md) |  | [optional] 
**infProdEmb** | [**NfeSefazInfProdEmb**](NfeSefazInfProdEmb.md) |  | [optional] 
**veicProd** | [**NfeSefazVeicProd**](NfeSefazVeicProd.md) |  | [optional] 
**med** | [**NfeSefazMed**](NfeSefazMed.md) |  | [optional] 
**arma** | [**List&lt;NfeSefazArma&gt;**](NfeSefazArma.md) | Armamentos. | [optional] 
**comb** | [**NfeSefazComb**](NfeSefazComb.md) |  | [optional] 
**nRECOPI** | **string** | Número do RECOPI. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

