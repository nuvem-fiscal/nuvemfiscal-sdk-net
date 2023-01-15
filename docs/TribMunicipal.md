# NuvemFiscal.Sdk.Model.TribMunicipal
Grupo de informações relacionados ao Imposto Sobre Serviços de Qualquer Natureza - ISSQN.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tribISSQN** | **int** | Tributação do ISSQN sobre o serviço prestado:  * 1 - Operação tributável  * 2 - Exportação de serviço  * 3 - Não Incidência  * 4 - Imunidade | 
**cPaisResult** | **string** | Código do país onde se verficou o resultado da prestação do serviço para o caso de Exportação de Serviço.(Tabela de Países ISO). | [optional] 
**BM** | [**BeneficioMunicipal**](BeneficioMunicipal.md) |  | [optional] 
**exigSusp** | [**ExigSuspensa**](ExigSuspensa.md) |  | [optional] 
**tpImunidade** | **int** | Identificação da Imunidade do ISSQN - somente para o caso de Imunidade:  * 0 - Imunidade (tipo não informado na nota de origem)  * 1 - Patrimônio, renda ou serviços, uns dos outros (CF88, Art 150, VI, a)  * 2 - Templos de qualquer culto (CF88, Art 150, VI, b)  * 3 - Patrimônio, renda ou serviços dos partidos políticos, inclusive suas fundações, das entidades sindicais dos trabalhadores, das instituições de educação e de assistência social, sem fins lucrativos, atendidos os requisitos da lei (CF88, Art 150, VI, c)  * 4 - Livros, jornais, periódicos e o papel destinado a sua impressão (CF88, Art 150, VI, d) | [optional] 
**pAliq** | **decimal** | Valor da alíquota (%%) do serviço prestado relativo ao município sujeito ativo (município de incidência) do ISSQN.  Se o município de incidência pertence ao Sistema Nacional NFS-e a alíquota estará parametrizada e, portanto, será fornecida pelo sistema.  Se o município de incidência não pertence ao Sistema Nacional NFS-e a alíquota não estará parametrizada e, por isso, deverá ser fornecida pelo emitente. | [optional] 
**tpRetISSQN** | **int** | Tipo de retencao do ISSQN:  * 1 - Não Retido  * 2 - Retido pelo Tomador  * 3 - Retido pelo Intermediario | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

