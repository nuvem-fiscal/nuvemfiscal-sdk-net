# NuvemFiscal.Sdk.Model.CteSefazInfOutros

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpDoc** | **string** | Tipo de documento originário.  Preencher com:                 00 - Declaração;                 10 - Dutoviário;      59 - CF-e SAT;    65 - NFC-e;          99 - Outros. | 
**descOutros** | **string** | Descrição do documento. | [optional] 
**nDoc** | **string** | Número. | [optional] 
**dEmi** | **DateTime** | Data de Emissão.  Formato AAAA-MM-DD. | [optional] 
**vDocFisc** | **decimal** | Valor do documento. | [optional] 
**dPrev** | **DateTime** | Data prevista de entrega.  Formato AAAA-MM-DD. | [optional] 
**infUnidCarga** | [**List&lt;CteSefazUnidCarga&gt;**](CteSefazUnidCarga.md) | Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu. | [optional] 
**infUnidTransp** | [**List&lt;CteSefazUnidadeTransp&gt;**](CteSefazUnidadeTransp.md) | Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

