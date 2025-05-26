# NuvemFiscal.Sdk.Model.CteOsSefazPropOS
Proprietário ou possuidor do Veículo.  Só preenchido quando o veículo não pertencer à empresa emitente do CT-e OS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CPF** | **string** | Número do CPF.  Informar os zeros não significativos. | [optional] 
**CNPJ** | **string** | Número do CNPJ.  Informar os zeros não significativos. | [optional] 
**TAF** | **string** | Termo de Autorização de Fretamento - TAF.  De acordo com a Resolução ANTT nº 4.777/2015. | [optional] 
**NroRegEstadual** | **string** | Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual. | [optional] 
**xNome** | **string** | Razão Social ou Nome do proprietário. | 
**IE** | **string** | Inscrição Estadual. | [optional] 
**UF** | **string** | UF. | [optional] 
**tpProp** | **int?** | Tipo Proprietário ou possuidor.  Preencher com:  * 0 - TAC - Agregado  * 1 - TAC Independente  ou  * 2 - Outros | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

