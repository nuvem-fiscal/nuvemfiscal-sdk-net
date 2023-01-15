# NuvemFiscal.Sdk.Model.DocDedRed
Grupo de informações de documento utilizado para Dedução/Redução do valor do serviço.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**chNFSe** | **string** | Chave de Acesso da NFS-e (Padrão Nacional). | [optional] 
**chNFe** | **string** | Chave de Acesso da NF-e. | [optional] 
**NFSeMun** | [**DocOutNFSe**](DocOutNFSe.md) |  | [optional] 
**NFNFS** | [**DocNFNFS**](DocNFNFS.md) |  | [optional] 
**nDocFisc** | **string** | Número de documento fiscal. | [optional] 
**nDoc** | **string** | Número de documento não fiscal. | [optional] 
**tpDedRed** | **int** | Identificação da Dedução/Redução:  * 1 - Alimentação e bebidas/frigobar  * 2 - Materiais  * 3 - Produção externa  * 4 - Reembolso de despesas  * 5 - Repasse consorciado  * 6 - Repasse plano de saúde  * 7 - Serviços  * 8 - Subempreitada de mão de obra  * 99 - Outras deduções | 
**xDescOutDed** | **string** | Descrição da Dedução/Redução quando a opção é \&quot;99 - Outras Deduções\&quot;. | [optional] 
**dtEmiDoc** | **DateTime** | Data da emissão do documento dedutível. Ano, mês e dia (AAAA-MM-DD). | 
**vDedutivelRedutivel** | **decimal** | Valor monetário total dedutível/redutível no documento informado (R$).  Este é o valor total no documento informado que é passível de dedução/redução. | 
**vDeducaoReducao** | **decimal** | Valor monetário utilizado para dedução/redução do valor do serviço da NFS-e que está sendo emitida (R$).  Deve ser menor ou igual ao valor deduzível/redutível (vDedutivelRedutivel). | 
**fornec** | [**InfoFornecDocDedRed**](InfoFornecDocDedRed.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

