# NuvemFiscal.Sdk.Model.MdfeSefazAereo

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nac** | **string** | Marca da Nacionalidade da aeronave. | 
**matr** | **string** | Marca de Matrícula da aeronave. | 
**nVoo** | **string** | Número do Voo.  Formato &#x3D; AB1234, sendo AB a designação da empresa e 1234 o número do voo. Quando não for possível incluir as marcas de nacionalidade e matrícula sem hífen. | 
**cAerEmb** | **string** | Aeródromo de Embarque.  O código de três letras IATA do aeroporto de partida deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI. | 
**cAerDes** | **string** | Aeródromo de Destino.  O código de três letras IATA do aeroporto de destino deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI. | 
**dVoo** | **DateTime?** | Data do Voo.  Formato AAAA-MM-DD. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

