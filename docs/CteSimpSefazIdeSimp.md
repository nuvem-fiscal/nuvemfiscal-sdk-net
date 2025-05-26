# NuvemFiscal.Sdk.Model.CteSimpSefazIdeSimp
Identificação do CT-e.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cUF** | **int?** | Código da UF do emitente do CT-e.  Utilizar a Tabela do IBGE. | 
**cCT** | **string** | Código numérico que compõe a Chave de Acesso.  Número aleatório gerado pelo emitente para cada CT-e, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**CFOP** | **string** | Código Fiscal de Operações e Prestações. | 
**natOp** | **string** | Natureza da Operação. | 
**mod** | **int?** | Modelo do documento fiscal.  Utilizar o código 57 para identificação do CT-e, emitido em substituição aos modelos de conhecimentos em papel. | [optional] 
**serie** | **int?** | Série do CT-e.  Preencher com \&quot;0\&quot; no caso de série única. | 
**nCT** | **int?** | Número do CT-e. | 
**dhEmi** | **DateTime?** | Data e hora de emissão do CT-e.  Formato AAAA-MM-DDTHH:MM:DD TZD. | 
**tpImp** | **int?** | Formato de impressão do DACTE:  * 1 - Retrato  * 2 - Paisagem | 
**tpEmis** | **int?** | Forma de emissão do CT-e.  Preencher com:  * 1 - Normal  * 3 - Regime Especial NFF  * 4 - EPEC pela SVC  * 7 - Autorização pela SVC-RS  * 8 - Autorização pela SVC-SP | 
**cDV** | **int?** | Digito Verificador da chave de acesso do CT-e.  Informar o dígito  de controle da chave de acesso do CT-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**tpAmb** | **int?** | Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação | [optional] 
**tpCTe** | **int?** | Tipo do CT-e Simplificado.  Preencher com:  * 5 - CTe Simplificado  * 6 - Substituição CTe Simplificado | 
**procEmi** | **int?** | Identificador do processo de emissão do CT-e.  Preencher com:  * 0 - emissão de CT-e com aplicativo do contribuinte  * 3 - emissão CT-e pelo contribuinte com aplicativo fornecido pelo SEBRAE | 
**verProc** | **string** | Versão do processo de emissão.  Informar a versão do aplicativo emissor de CT-e. | 
**cMunEnv** | **string** | Código do Município de envio do CT-e (de onde o documento foi transmitido).  Utilizar a tabela do IBGE. Informar 9999999 para as operações com o exterior. | 
**xMunEnv** | **string** | Nome do Município de envio do CT-e (de onde o documento foi transmitido).  Informar PAIS/Municipio para as operações com o exterior. | 
**UFEnv** | **string** | Sigla da UF de envio do CT-e (de onde o documento foi transmitido).  Informar &#39;EX&#39; para operações com o exterior. | 
**modal** | **string** | Modal. Preencher com:  * 01 - Rodoviário  * 02 - Aéreo  * 03 - Aquaviário  * 04 - Ferroviário  * 05 - Dutoviário  * 06 - Multimodal | 
**tpServ** | **int?** | Tipo do Serviço.  Preencher com:  * 0 - Normal  * 1 - Subcontratação  * 2 - Redespacho | 
**UFIni** | **string** | UF do início da prestação.  Informar &#39;EX&#39; para operações com o exterior. | 
**UFFim** | **string** | UF do término da prestação.  Informar &#39;EX&#39; para operações com o exterior. | 
**retira** | **int?** | Indicador se o Recebedor retira no Aeroporto, Filial, Porto ou Estação de Destino? Preencher com:  * 0 - Sim  * 1 - Não | 
**xDetRetira** | **string** | Detalhes do retira. | [optional] 
**dhCont** | **DateTime?** | Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS. | [optional] 
**xJust** | **string** | Justificativa da entrada em contingência. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

