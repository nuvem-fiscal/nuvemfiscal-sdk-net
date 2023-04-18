# NuvemFiscal.Sdk.Model.NfeSefazICMSTot
Totais referentes ao ICMS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vBC** | **decimal** | BC do ICMS. | 
**vICMS** | **decimal** | Valor Total do ICMS. | 
**vICMSDeson** | **decimal** | Valor Total do ICMS desonerado. | 
**vFCPUFDest** | **decimal** | Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino. | [optional] 
**vICMSUFDest** | **decimal** | Valor total do ICMS de partilha para a UF do destinatário. | [optional] 
**vICMSUFRemet** | **decimal** | Valor total do ICMS de partilha para a UF do remetente. | [optional] 
**vFCP** | **decimal** | Valor Total do FCP (Fundo de Combate à Pobreza). | 
**vBCST** | **decimal** | BC do ICMS ST. | 
**vST** | **decimal** | Valor Total do ICMS ST. | 
**vFCPST** | **decimal** | Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária. | 
**vFCPSTRet** | **decimal** | Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária. | 
**vICMSMono** | **decimal** | Valor total do ICMS monofásico próprio. | [optional] 
**vICMSMonoReten** | **decimal** | Valor total do ICMS monofásico sujeito a retenção. | [optional] 
**vICMSMonoRet** | **decimal** | Valor do ICMS monofásico retido anteriormente. | [optional] 
**vProd** | **decimal** | Valor Total dos produtos e serviços. | 
**vFrete** | **decimal** | Valor Total do Frete. | 
**vSeg** | **decimal** | Valor Total do Seguro. | 
**vDesc** | **decimal** | Valor Total do Desconto. | 
**vII** | **decimal** | Valor Total do II. | 
**vIPI** | **decimal** | Valor Total do IPI. | 
**vIPIDevol** | **decimal** | Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe&#x3D;4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04. | 
**vPIS** | **decimal** | Valor do PIS. | 
**vCOFINS** | **decimal** | Valor do COFINS. | 
**vOutro** | **decimal** | Outras Despesas acessórias. | 
**vNF** | **decimal** | Valor Total da NF-e. | 
**vTotTrib** | **decimal** | Valor estimado total de impostos federais, estaduais e municipais. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

