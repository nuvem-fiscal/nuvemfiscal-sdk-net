# NuvemFiscal.Sdk.Model.NfeSefazICMSUFDest

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vBCUFDest** | **decimal** | Valor da Base de Cálculo do ICMS na UF do destinatário. | 
**vBCFCPUFDest** | **decimal** | Valor da Base de Cálculo do FCP na UF do destinatário. | [optional] 
**pFCPUFDest** | **decimal** | Percentual adicional inserido na alíquota interna da UF de destino, relativo ao Fundo de Combate à Pobreza (FCP) naquela UF. | [optional] 
**pICMSUFDest** | **decimal** | Alíquota adotada nas operações internas na UF do destinatário para o produto / mercadoria. | 
**pICMSInter** | **decimal** | Alíquota interestadual das UF envolvidas: - 4%% alíquota interestadual para produtos importados; - 7%% para os Estados de origem do Sul e Sudeste (exceto ES), destinado para os Estados do Norte e Nordeste  ou ES; - 12%% para os demais casos. | 
**pICMSInterPart** | **decimal** | Percentual de partilha para a UF do destinatário: - 40%% em 2016; - 60%% em 2017; - 80%% em 2018; - 100%% a partir de 2019. | 
**vFCPUFDest** | **decimal** | Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) da UF de destino. | [optional] 
**vICMSUFDest** | **decimal** | Valor do ICMS de partilha para a UF do destinatário. | 
**vICMSUFRemet** | **decimal** | Valor do ICMS de partilha para a UF do remetente. Nota: A partir de 2019, este valor será zero. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

