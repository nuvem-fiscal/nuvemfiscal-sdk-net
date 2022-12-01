# NuvemFiscal.Sdk.Model.MdfeSefazInfResp

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**respSeg** | **int** | Responsável pelo seguro.  Preencher com:                 1- Emitente do MDF-e;    22 - Responsável pela contratação do serviço de transporte (contratante)       Dados obrigatórios apenas no modal Rodoviário, depois da lei 11.442/07. Para os demais modais esta informação é opcional. | 
**CNPJ** | **string** | Número do CNPJ do responsável pelo seguro.  Obrigatório apenas se responsável pelo seguro for (2) responsável pela contratação do transporte - pessoa jurídica. | [optional] 
**CPF** | **string** | Número do CPF do responsável pelo seguro.  Obrigatório apenas se responsável pelo seguro for (2) responsável pela contratação do transporte - pessoa física. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

