# NuvemFiscal.Sdk.Model.MdfeSefazInfMDFe

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**versao** | **string** | Versão do leiaute.  Ex: \&quot;3.00\&quot;. | 
**Id** | **string** | Identificador da tag a ser assinada.  Informar a chave de acesso do MDF-e e precedida do literal \&quot;MDFe\&quot;. | [optional] 
**ide** | [**MdfeSefazIde**](MdfeSefazIde.md) |  | 
**emit** | [**MdfeSefazEmit**](MdfeSefazEmit.md) |  | 
**infModal** | [**MdfeSefazInfModal**](MdfeSefazInfModal.md) |  | 
**infDoc** | [**MdfeSefazInfDoc**](MdfeSefazInfDoc.md) |  | 
**seg** | [**List&lt;MdfeSefazSeg&gt;**](MdfeSefazSeg.md) | Informações de Seguro da Carga. | [optional] 
**prodPred** | [**MdfeSefazProdPred**](MdfeSefazProdPred.md) |  | [optional] 
**tot** | [**MdfeSefazTot**](MdfeSefazTot.md) |  | 
**lacres** | [**List&lt;MdfeSefazLacres&gt;**](MdfeSefazLacres.md) | Lacres do MDF-e.  Preechimento opcional para os modais Rodoviário e Ferroviário. | [optional] 
**autXML** | [**List&lt;MdfeSefazAutXML&gt;**](MdfeSefazAutXML.md) | Autorizados para download do XML do DF-e.  Informar CNPJ ou CPF. Preencher os zeros não significativos. | [optional] 
**infAdic** | [**MdfeSefazInfAdic**](MdfeSefazInfAdic.md) |  | [optional] 
**infRespTec** | [**MdfeSefazRespTec**](MdfeSefazRespTec.md) |  | [optional] 
**infSolicNFF** | [**MdfeSefazInfSolicNFF**](MdfeSefazInfSolicNFF.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

