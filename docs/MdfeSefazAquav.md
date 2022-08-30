# NuvemFiscal.Sdk.Model.MdfeSefazAquav

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**irin** | **string** | Irin do navio sempre deverá ser informado. | 
**tpEmb** | **string** | Código do tipo de embarcação.  Preencher com código da Tabela de Tipo de Embarcação definida no Ministério dos Transportes. | 
**cEmbar** | **string** | Código da embarcação. | 
**xEmbar** | **string** | Nome da embarcação. | 
**nViag** | **string** | Número da Viagem. | 
**cPrtEmb** | **string** | Código do Porto de Embarque.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes. | 
**cPrtDest** | **string** | Código do Porto de Destino.  Preencher de acordo com Tabela de Portos definida no Ministério dos Transportes. | 
**prtTrans** | **string** | Porto de Transbordo. | [optional] 
**tpNav** | **int** | Tipo de Navegação.  Preencher com:        0 - Interior;        1 - Cabotagem. | [optional] 
**infTermCarreg** | [**List&lt;MdfeSefazInfTermCarreg&gt;**](MdfeSefazInfTermCarreg.md) | Grupo de informações dos terminais de carregamento. | [optional] 
**infTermDescarreg** | [**List&lt;MdfeSefazInfTermDescarreg&gt;**](MdfeSefazInfTermDescarreg.md) | Grupo de informações dos terminais de descarregamento. | [optional] 
**infEmbComb** | [**List&lt;MdfeSefazInfEmbComb&gt;**](MdfeSefazInfEmbComb.md) | Informações das Embarcações do Comboio. | [optional] 
**infUnidCargaVazia** | [**List&lt;MdfeSefazInfUnidCargaVazia&gt;**](MdfeSefazInfUnidCargaVazia.md) | Informações das Undades de Carga vazias. | [optional] 
**infUnidTranspVazia** | [**List&lt;MdfeSefazInfUnidTranspVazia&gt;**](MdfeSefazInfUnidTranspVazia.md) | Informações das Undades de Transporte vazias. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

