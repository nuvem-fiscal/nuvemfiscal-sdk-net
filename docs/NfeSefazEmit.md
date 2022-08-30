# NuvemFiscal.Sdk.Model.NfeSefazEmit

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número do CNPJ do emitente.  Obrigatório caso o emitente seja pessoa jurídica. | [optional] 
**CPF** | **string** | Número do CPF do emitente.  Obrigatorio caso o emitente seja pessoa física. | [optional] 
**xNome** | **string** | Razão Social ou Nome do emitente.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**xFant** | **string** | Nome fantasia.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**enderEmit** | [**NfeSefazEnderEmi**](NfeSefazEnderEmi.md) |  | [optional] 
**IE** | **string** | Inscrição Estadual do Emitente.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**IEST** | **string** | Inscricao Estadual do Substituto Tributário.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**IM** | **string** | Inscrição Municipal.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**CNAE** | **string** | CNAE Fiscal.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 
**CRT** | **int** | Código de Regime Tributário.  Este campo será obrigatoriamente preenchido com:  1 – Simples Nacional;  2 – Simples Nacional – excesso de sublimite de receita bruta;  3 – Regime Normal.  Caso não seja informado, será utilizado o do cadastro da empresa. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

