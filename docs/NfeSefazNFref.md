# NuvemFiscal.Sdk.Model.NfeSefazNFref
Grupo de infromações da NF referenciada.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**refNFe** | **string** | Chave de acesso das NF-e referenciadas. Chave de acesso compostas por Código da UF (tabela do IBGE) + AAMM da emissão + CNPJ do Emitente + modelo, série e número da NF-e Referenciada + Código Numérico + DV. | [optional] 
**refNFeSig** | **string** | Referencia uma NF-e (modelo 55) emitida anteriormente pela sua Chave de Acesso com código numérico zerado, permitindo manter o sigilo da NF-e referenciada. | [optional] 
**refNF** | [**NfeSefazRefNF**](NfeSefazRefNF.md) |  | [optional] 
**refNFP** | [**NfeSefazRefNFP**](NfeSefazRefNFP.md) |  | [optional] 
**refCTe** | **string** | Utilizar esta TAG para referenciar um CT-e emitido anteriormente, vinculada a NF-e atual. | [optional] 
**refECF** | [**NfeSefazRefECF**](NfeSefazRefECF.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

