# NuvemFiscal.Sdk.Model.CteSefazInfNFe

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**chave** | **string** | Chave de acesso da NF-e. | 
**PIN** | **string** | PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação. | [optional] 
**dPrev** | **DateTime** | Data prevista de entrega.  Formato AAAA-MM-DD. | [optional] 
**infUnidCarga** | [**List&lt;CteSefazUnidCarga&gt;**](CteSefazUnidCarga.md) | Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu. | [optional] 
**infUnidTransp** | [**List&lt;CteSefazUnidadeTransp&gt;**](CteSefazUnidadeTransp.md) | Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

