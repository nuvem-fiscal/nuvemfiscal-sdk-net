# NuvemFiscal.Sdk.Model.CteSefazInfNF
Informações das NF.  Este grupo deve ser informado quando o documento originário for NF.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nRoma** | **string** | Número do Romaneio da NF. | [optional] 
**nPed** | **string** | Número do Pedido da NF. | [optional] 
**mod** | **string** | Modelo da Nota Fiscal.  Preencher com:  * 01 - NF Modelo 01/1A e Avulsa  * 04 - NF de Produtor | 
**serie** | **string** | Série. | 
**nDoc** | **string** | Número. | 
**dEmi** | **DateTime?** | Data de Emissão.  Formato AAAA-MM-DD. | 
**vBC** | **decimal?** | Valor da Base de Cálculo do ICMS. | 
**vICMS** | **decimal?** | Valor Total do ICMS. | 
**vBCST** | **decimal?** | Valor da Base de Cálculo do ICMS ST. | 
**vST** | **decimal?** | Valor Total do ICMS ST. | 
**vProd** | **decimal?** | Valor Total dos Produtos. | 
**vNF** | **decimal?** | Valor Total da NF. | 
**nCFOP** | **string** | CFOP Predominante.  CFOP da NF ou, na existência de mais de um, predominância pelo critério de valor econômico. | 
**nPeso** | **decimal?** | Peso total em Kg. | [optional] 
**PIN** | **string** | PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação. | [optional] 
**dPrev** | **DateTime?** | Data prevista de entrega.  Formato AAAA-MM-DD. | [optional] 
**infUnidCarga** | [**List&lt;CteSefazUnidCarga&gt;**](CteSefazUnidCarga.md) |  | [optional] 
**infUnidTransp** | [**List&lt;CteSefazUnidadeTransp&gt;**](CteSefazUnidadeTransp.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

