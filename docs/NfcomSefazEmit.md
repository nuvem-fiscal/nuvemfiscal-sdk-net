# NuvemFiscal.Sdk.Model.NfcomSefazEmit
Identificação do Emitente do documento fiscal.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | CNPJ do emitente.  Informar zeros não significativos. | 
**IE** | **string** | Inscrição Estadual do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**IEUFDest** | **string** | Inscrição Estadual Virtual do emitente na UF de Destino da partilha (IE Virtual). | [optional] 
**CRT** | **int?** | Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal.    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**xNome** | **string** | Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**xFant** | **string** | Nome fantasia do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**enderEmit** | [**NfcomSefazEndeEmi**](NfcomSefazEndeEmi.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

