# NuvemFiscal.Sdk.Model.EmpresaConfigRps
Configuração de numeração de lote, série e RPS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**lote** | **long** | Número do Lote de RPS.  Informe o próximo número do lote RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de lote o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez. | 
**serie** | **string** | Série do RPS.  A série dos RPS varia de acordo com cada prefeitura, podendo ser  número (1, 2 ou 3, por exemplo) ou letras (A, S, NFS, por exemplo).  Portanto, consulte-a com o município da empresa antes de iniciar a  emissão das notas. | 
**numero** | **long** | Número do RPS.  Informe o próximo número de RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de RPS o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

