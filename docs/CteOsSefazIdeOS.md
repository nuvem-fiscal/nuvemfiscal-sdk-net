# NuvemFiscal.Sdk.Model.CteOsSefazIdeOS
Identificação do CT-e Outros Serviços.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cUF** | **int?** | Código da UF do emitente do CT-e.  Utilizar a Tabela do IBGE. | 
**cCT** | **string** | Código numérico que compõe a Chave de Acesso.  Número aleatório gerado pelo emitente para cada CT-e, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**CFOP** | **string** | Código Fiscal de Operações e Prestações. | 
**natOp** | **string** | Natureza da Operação. | 
**mod** | **int?** | Modelo do documento fiscal.  Utilizar o código 67 para identificação do CT-e Outros Serviços, emitido em substituição a Nota Fiscal Modelo 7 para transporte de pessoas, valores e excesso de bagagem. | [optional] 
**serie** | **int?** | Série do CT-e OS.  Preencher com \&quot;0\&quot; no caso de série única. | 
**nCT** | **int?** | Número do CT-e OS. | 
**dhEmi** | **DateTime?** | Data e hora de emissão do CT-e OS.  Formato AAAA-MM-DDTHH:MM:DD TZD. | 
**tpImp** | **int?** | Formato de impressão do DACTE:  * 1 - Retrato  * 2 - Paisagem | 
**tpEmis** | **int?** | Forma de emissão do CT-e.  Preencher com:  * 1 - Normal  * 5 - Contingência FSDA  * 7 - Autorização pela SVC-RS  * 8 - Autorização pela SVC-SP | 
**cDV** | **int?** | Digito Verificador da chave de acesso do CT-e.  Informar o dígito  de controle da chave de acesso do CT-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**tpAmb** | **int?** | Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação | [optional] 
**tpCTe** | **int?** | Tipo do CT-e OS.  Preencher com:  * 0 - CT-e Normal  * 1 - CT-e Complementar  * 3 - CT-e de Substituição | 
**procEmi** | **int?** | Identificador do processo de emissão do CT-e OS.  Preencher com:  * 0 - emissão de CT-e com aplicativo do contribuinte  * 3 - emissão CT-e pelo contribuinte com aplicativo fornecido pelo Fisco | 
**verProc** | **string** | Versão do processo de emissão.  Iinformar a versão do aplicativo emissor de CT-e. | 
**cMunEnv** | **string** | Código do Município de envio do CT-e (de onde o documento foi transmitido).  Utilizar a tabela do IBGE. Informar 9999999 para as operações com o exterior. | 
**xMunEnv** | **string** | Nome do Município de envio do CT-e (de onde o documento foi transmitido).  Informar PAIS/Municipio para as operações com o exterior. | 
**UFEnv** | **string** | Sigla da UF de envio do CT-e (de onde o documento foi transmitido).  Informar &#39;EX&#39; para operações com o exterior. | 
**modal** | **string** | Modal. Preencher com:  * 01 - Rodoviário  * 02 - Aéreo  * 03 - Aquaviário  * 04 - Ferroviário | 
**tpServ** | **int?** | Tipo do Serviço.  Preencher com:  * 6 - Transporte de Pessoas  * 7 - Transporte de Valores  * 8 - Excesso de Bagagem | 
**indIEToma** | **int?** | Indicador da IE do tomador:  * 1 - Contribuinte ICMS  * 2 - Contribuinte isento de inscrição  * 9 - Não Contribuinte  Aplica-se ao tomador que for indicado no toma3 ou toma4. | 
**cMunIni** | **string** | Código do Município de início da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior. | [optional] 
**xMunIni** | **string** | Nome do Município do início da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior. | [optional] 
**UFIni** | **string** | UF do início da prestação.  Informar &#39;EX&#39; para operações com o exterior. | [optional] 
**cMunFim** | **string** | Código do Município de término da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior. | [optional] 
**xMunFim** | **string** | Nome do Município do término da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior. | [optional] 
**UFFim** | **string** | UF do término da prestação.  Informar &#39;EX&#39; para operações com o exterior. | [optional] 
**infPercurso** | [**List&lt;CteOsSefazInfPercursoOS&gt;**](CteOsSefazInfPercursoOS.md) |  | [optional] 
**dhCont** | **DateTime?** | Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS. | [optional] 
**xJust** | **string** | Justificativa da entrada em contingência. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

