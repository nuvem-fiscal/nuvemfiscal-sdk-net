# NuvemFiscal.Sdk.Model.TribOutrosPisCofins
Grupo de informações dos tributos PIS/COFINS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CST** | **string** | Código de Situação Tributária do PIS/COFINS (CST):  * 00 - Nenhum  * 01 - Operação Tributável com Alíquota Básica  * 02 - Operação Tributável com Alíquota Diferenciada  * 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto  * 04 - Operação Tributável monofásica - Revenda a Alíquota Zero  * 05 - Operação Tributável por Substituição Tributária  * 06 - Operação Tributável a Alíquota Zero  * 07 - Operação Tributável da Contribuição  * 08 - Operação sem Incidência da Contribuição  * 09 - Operação com Suspensão da Contribuição | 
**vBCPisCofins** | **decimal?** | Valor da Base de Cálculo do PIS/COFINS (R$). | [optional] 
**pAliqPis** | **decimal?** | Valor da Alíquota do PIS (%%). | [optional] 
**pAliqCofins** | **decimal?** | Valor da Alíquota da COFINS (%%). | [optional] 
**vPis** | **decimal?** | Valor monetário do PIS (R$). | [optional] 
**vCofins** | **decimal?** | Valor monetário do COFINS (R$). | [optional] 
**tpRetPisCofins** | **int?** | Tipo de retencao do Pis/Cofins:  * 1 - Retido  * 2 - Não Retido | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

