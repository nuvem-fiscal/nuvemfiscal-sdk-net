# NuvemFiscal.Sdk.Model.NfcomSefazIde
Identificação da NFCom.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**cUF** | **int?** | Código da UF de emissão e autorização da NFCom.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação. | 
**tpAmb** | **int?** | Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação | [optional] 
**mod** | **int?** | Modelo da NFCom.  Utilizar o código 62 para identificação da NFCom. | [optional] 
**serie** | **int?** | Série do documento fiscal.  Informar a série do documento fiscal (informar zero para série única). | 
**nNF** | **int?** | Número do documento fiscal.  Número que identifica o documento fiscal 1 a 999999999. | 
**cNF** | **string** | Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**cDV** | **int?** | Digito verificador da chave de acesso.  Informar o dígito  de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**dhEmi** | **DateTime?** | Data e hora de emissão do documento fiscal.  Formato AAAA-MM-DDTHH:MM:DD TZD. | 
**tpEmis** | **int?** | Forma de emissão do Documento Fiscal.  * 1 - Normal  * 2 - Contingência | 
**nSiteAutoriz** | **int?** | Identificação do número do Site do Autorizador de recepção da NFCom.  Se o autorizador da NFCom possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a NFCOM (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar. | 
**cMunFG** | **string** | Código do município de ocorrência do fato gerador. | 
**finNFCom** | **int?** | Finalidade de emissão da NFCom.  * 0 - NFCom Normal  * 3 - NFCom de Substituição  * 4 - NFCom de Ajuste | 
**tpFat** | **int?** | Tipo de Faturamento da NFCom.  * 0 - Faturamento Normal  * 1 - Faturamento centralizado  * 2 - Cofaturamento | 
**verProc** | **string** | Versão do processo de emissão.  Informar a versão do aplicativo emissor de NFCom. | 
**indPrePago** | **int?** | Indicador de serviço pré-pago.  * 1 - Serviço pré-pago (informar a tag somente se a nota for referente a um serviço exclusivamente pré-pago) | [optional] 
**indCessaoMeiosRede** | **int?** | Indicador de Sessão de Meios de Rede.  Uma vez informado (valor &#x3D; 1), essa tag dispensa geração do grupo Fatura.  Apenas para notas dos tipos Normal e Substituição com tipo de faturamento normal. | [optional] 
**indNotaEntrada** | **int?** | Indicador de nota de entrada.  * 1 - Informar quando for nota de ajuste e possuir itens com CFOP de entrada | [optional] 
**dhCont** | **DateTime?** | Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS. | [optional] 
**xJust** | **string** | Justificativa da entrada em contingência. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

