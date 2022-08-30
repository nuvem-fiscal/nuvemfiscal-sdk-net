# NuvemFiscal.Sdk.Model.NfeSefazISSQN

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vBC** | **decimal** | Valor da BC do ISSQN. | 
**vAliq** | **decimal** | Alíquota do ISSQN. | 
**vISSQN** | **decimal** | Valor da do ISSQN. | 
**cMunFG** | **int** | Informar o município de ocorrência do fato gerador do ISSQN. Utilizar a Tabela do IBGE (Anexo VII - Tabela de UF, Município e País). “Atenção, não vincular com os campos B12, C10 ou E10” v2.0. | 
**cListServ** | **string** | Informar o Item da lista de serviços da LC 116/03 em que se classifica o serviço. | 
**vDeducao** | **decimal** | Valor dedução para redução da base de cálculo. | [optional] 
**vOutro** | **decimal** | Valor outras retenções. | [optional] 
**vDescIncond** | **decimal** | Valor desconto incondicionado. | [optional] 
**vDescCond** | **decimal** | Valor desconto condicionado. | [optional] 
**vISSRet** | **decimal** | Valor Retenção ISS. | [optional] 
**indISS** | **int** | Exibilidade do ISS:1-Exigível;2-Não incidente;3-Isenção;4-Exportação;5-Imunidade;6-Exig.Susp. Judicial;7-Exig.Susp. ADM. | 
**cServico** | **string** | Código do serviço prestado dentro do município. | [optional] 
**cMun** | **int** | Código do Município de Incidência do Imposto. | [optional] 
**cPais** | **int** | Código de Pais. | [optional] 
**nProcesso** | **string** | Número do Processo administrativo ou judicial de suspenção do processo. | [optional] 
**indIncentivo** | **int** | Indicador de Incentivo Fiscal. 1&#x3D;Sim; 2&#x3D;Não. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

