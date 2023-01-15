# NuvemFiscal.Sdk.Model.CnpjEmpresa

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cnpj** | **string** | Número de inscrição do CNPJ. | [optional] 
**razao_social** | **string** | Nome empresarial da pessoa jurídica. | [optional] 
**nome_fantasia** | **string** | Corresponde ao nome fantasia. | [optional] 
**data_inicio_atividade** | **DateTime** | Data de início da atividade. | [optional] 
**matriz** | **bool** | Indicador de matriz/filial:  * &#x60;true&#x60; - É matriz  * &#x60;false&#x60; - É filial | [optional] 
**natureza_juridica** | [**CnpjNaturezaJuridica**](CnpjNaturezaJuridica.md) |  | [optional] 
**capital_social** | **decimal** | Capital social da empresa. | [optional] 
**porte** | [**CnpjPorteEmpresa**](CnpjPorteEmpresa.md) |  | [optional] 
**ente_federativo_responsavel** | **string** | O ente federativo responsável é preenchido para os casos de órgãos e  entidades do grupo de natureza jurídica 1XXX. Para as demais naturezas,  este atributo fica em branco. | [optional] 
**situacao_cadastral** | [**CnpjSituacaoCadastral**](CnpjSituacaoCadastral.md) |  | [optional] 
**motivo_situacao_cadastral** | [**CnpjMotivoSituacaoCadastral**](CnpjMotivoSituacaoCadastral.md) |  | [optional] 
**nome_da_cidade_no_exterior** | **string** | Nome da cidade no exterior. | [optional] 
**pais** | [**CnpjPais**](CnpjPais.md) |  | [optional] 
**atividade_principal** | [**CnpjCnae**](CnpjCnae.md) |  | [optional] 
**atividades_secundarias** | [**List&lt;CnpjCnaeSecundario&gt;**](CnpjCnaeSecundario.md) |  | [optional] 
**endereco** | [**CnpjEndereco**](CnpjEndereco.md) |  | [optional] 
**telefones** | [**List&lt;CnpjTelefone&gt;**](CnpjTelefone.md) |  | [optional] 
**email** | **string** | E-mail do contribuinte. | [optional] 
**situacao_especial** | [**CnpjSituacaoEspecial**](CnpjSituacaoEspecial.md) |  | [optional] 
**simples** | [**CnpjOpcaoSimples**](CnpjOpcaoSimples.md) |  | [optional] 
**simei** | [**CnpjOpcaoSimei**](CnpjOpcaoSimei.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

