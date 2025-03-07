# NuvemFiscal.Sdk.Model.Email

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**id** | **string** | ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes. | 
**status** | **string** |  | [optional] 
**sent_at** | **DateTime?** |  | [optional] 
**to** | **List&lt;string&gt;** |  | [optional] 
**cc** | **List&lt;string&gt;** |  | [optional] 
**reply_to** | **string** |  | [optional] 
**subject** | **string** |  | [optional] 
**attachments** | [**List&lt;EmailAttachment&gt;**](EmailAttachment.md) |  | [optional] 
**events** | [**List&lt;EmailEvent&gt;**](EmailEvent.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

