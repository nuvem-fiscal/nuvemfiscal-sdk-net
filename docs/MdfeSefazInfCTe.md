# NuvemFiscal.Sdk.Model.MdfeSefazInfCTe

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**chCTe** | **string** | Conhecimento Eletrônico - Chave de Acesso. | 
**SegCodBarra** | **string** | Segundo código de barras. | [optional] 
**indReentrega** | **int** | Indicador de Reentrega. | [optional] 
**infUnidTransp** | [**List&lt;MdfeSefazUnidadeTransp&gt;**](MdfeSefazUnidadeTransp.md) | Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas. | [optional] 
**peri** | [**List&lt;MdfeSefazPeri&gt;**](MdfeSefazPeri.md) | Preenchido quando for  transporte de produtos classificados pela ONU como perigosos. | [optional] 
**infEntregaParcial** | [**MdfeSefazInfEntregaParcial**](MdfeSefazInfEntregaParcial.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

