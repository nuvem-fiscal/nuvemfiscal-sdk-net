# NuvemFiscal.Sdk.Model.MdfeSefazInfPag
Informações do Pagamento do Frete.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**xNome** | **string** | Razão social ou Nome do respnsável pelo pagamento. | [optional] 
**CPF** | **string** | Número do CPF do responsável pelo pgto.  Informar os zeros não significativos. | [optional] 
**CNPJ** | **string** | Número do CNPJ do responsável pelo pgto.  Informar os zeros não significativos. | [optional] 
**idEstrangeiro** | **string** | Identificador do responsável pelo pgto em caso de ser estrangeiro. | [optional] 
**Comp** | [**List&lt;MdfeSefazComp&gt;**](MdfeSefazComp.md) |  | 
**vContrato** | **decimal?** | Valor Total do Contrato. | 
**indAltoDesemp** | **int?** | Indicador de operação de transporte de alto desempenho.  Operação de transporte com utilização de veículos de frotas dedicadas ou fidelizadas.  Preencher com “1” para indicar operação de transporte de alto desempenho, demais casos não informar a tag. | [optional] 
**indPag** | **int?** | Indicador da Forma de Pagamento:0-Pagamento à Vista  * 1 - Pagamento à Prazo | 
**vAdiant** | **decimal?** | Valor do Adiantamento (usar apenas em pagamento à Prazo. | [optional] 
**indAntecipaAdiant** | **int?** | Indicador para declarar concordância em antecipar o adiantamento.  Informar a tag somente se for autorizado antecipar o adiantamento. | [optional] 
**infPrazo** | [**List&lt;MdfeSefazInfPrazo&gt;**](MdfeSefazInfPrazo.md) |  | [optional] 
**tpAntecip** | **int?** | Tipo de Permissão em relação a antecipação das parcelas.  * 0 - Não permite antecipar  * 1 - Permite antecipar as parcelas  * 2 - Permite antecipar as parcelas mediante confirmação | [optional] 
**infBanc** | [**MdfeSefazInfBanc**](MdfeSefazInfBanc.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

