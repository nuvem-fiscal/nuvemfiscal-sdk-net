# NuvemFiscal.Sdk.Model.CteSefazEmit

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | CNPJ do emitente.  Informar zeros não significativos.  Obrigatório caso o emitente seja pessoa jurídica. | [optional] 
**CPF** | **string** | CPF do emitente.  Informar zeros não significativos.    Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.  Obrigatorio caso o emitente seja pessoa física. | [optional] 
**IE** | **string** | Inscrição Estadual do Emitente.  A IE do emitente somente ficará sem informação para o caso do Regime Especial da NFF (tpEmis&#x3D;3).  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**IEST** | **string** | Inscrição Estadual do Substituto Tributário. | [optional] 
**xNome** | **string** | Razão social ou Nome do emitente.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**xFant** | **string** | Nome fantasia.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**enderEmit** | [**CteSefazEndeEmi**](CteSefazEndeEmi.md) |  | [optional] 
**CRT** | **int** | Código do Regime Tributário.  Informar: 1&#x3D;Simples Nacional;   2&#x3D;Simples Nacional, excesso sublimite de receita bruta;  3&#x3D;Regime Normal. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

