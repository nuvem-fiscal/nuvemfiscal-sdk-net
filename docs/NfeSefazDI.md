# NuvemFiscal.Sdk.Model.NfeSefazDI
Delcaração de Importação  (NT 2011/004).

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nDI** | **string** | Numero do Documento de Importação DI/DSI/DA/DRI-E (DI/DSI/DA/DRI-E) (NT2011/004). | 
**dDI** | **DateTime** | Data de registro da DI/DSI/DA (AAAA-MM-DD). | 
**xLocDesemb** | **string** | Local do desembaraço aduaneiro. | 
**UFDesemb** | **string** | UF onde ocorreu o desembaraço aduaneiro. | 
**dDesemb** | **DateTime** | Data do desembaraço aduaneiro (AAAA-MM-DD). | 
**tpViaTransp** | **int** | Via de transporte internacional informada na DI  * 1 - Maritima  * 2 - Fluvial  * 3 - Lacustre  * 4 - Aerea  * 5 - Postal  * 6 - Ferroviaria  * 7 - Rodoviaria  * 8 - Conduto  * 9 - Meios Proprios  * 10 - Entrada/Saida Ficta  * 11 - Courier  * 12 - Em maos  * 13 - Por reboque | 
**vAFRMM** | **decimal** | Valor Adicional ao frete para renovação de marinha mercante. | [optional] 
**tpIntermedio** | **int** | Forma de Importação quanto a intermediação  * 1 - por conta propria  * 2 - por conta e ordem  * 3 - encomenda | 
**CNPJ** | **string** | CNPJ do adquirente ou do encomendante. | [optional] 
**UFTerceiro** | **string** | Sigla da UF do adquirente ou do encomendante. | [optional] 
**cExportador** | **string** | Código do exportador (usado nos sistemas internos de informação do emitente da NF-e). | 
**adi** | [**List&lt;NfeSefazAdi&gt;**](NfeSefazAdi.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

