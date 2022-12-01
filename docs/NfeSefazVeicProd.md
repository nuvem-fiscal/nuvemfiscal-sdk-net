# NuvemFiscal.Sdk.Model.NfeSefazVeicProd

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpOp** | **int** | Tipo da Operação (1 - Venda concessionária; 2 - Faturamento direto; 3 - Venda direta; 0 - Outros). | 
**chassi** | **string** | Chassi do veículo - VIN (código-identificação-veículo). | 
**cCor** | **string** | Cor do veículo (código de cada montadora). | 
**xCor** | **string** | Descrição da cor. | 
**pot** | **string** | Potência máxima do motor do veículo em cavalo vapor (CV). (potência-veículo). | 
**cilin** | **string** | Capacidade voluntária do motor expressa em centímetros cúbicos (CC). (cilindradas). | 
**pesoL** | **string** | Peso líquido. | 
**pesoB** | **string** | Peso bruto. | 
**nSerie** | **string** | Serial (série). | 
**tpComb** | **string** | Tipo de combustível-Tabela RENAVAM: 01-Álcool; 02-Gasolina; 03-Diesel; 16-Álcool/Gas.; 17-Gas./Álcool/GNV; 18-Gasolina/Elétrico. | 
**nMotor** | **string** | Número do motor. | 
**CMT** | **string** | CMT-Capacidade Máxima de Tração - em Toneladas 4 casas decimais. | 
**dist** | **string** | Distância entre eixos. | 
**anoMod** | **int** | Ano Modelo de Fabricação. | 
**anoFab** | **int** | Ano de Fabricação. | 
**tpPint** | **string** | Tipo de pintura. | 
**tpVeic** | **int** | Tipo de veículo (utilizar tabela RENAVAM). | 
**espVeic** | **int** | Espécie de veículo (utilizar tabela RENAVAM). | 
**VIN** | **string** | Informa-se o veículo tem VIN (chassi) remarcado.  R-Remarcado  N-NormalVIN. | 
**condVeic** | **int** | Condição do veículo (1 - acabado; 2 - inacabado; 3 - semi-acabado). | 
**cMod** | **string** | Código Marca Modelo (utilizar tabela RENAVAM). | 
**cCorDENATRAN** | **string** | Código da Cor Segundo as regras de pré-cadastro do DENATRAN: 01-AMARELO;02-AZUL;03-BEGE;04-BRANCA;05-CINZA;06-DOURADA;07-GRENA   08-LARANJA;09-MARROM;10-PRATA;11-PRETA;12-ROSA;13-ROXA;14-VERDE;15-VERMELHA;16-FANTASIA. | 
**lota** | **int** | Quantidade máxima de permitida de passageiros sentados, inclusive motorista. | 
**tpRest** | **int** | Restrição  0 - Não há;  1 - Alienação Fiduciária;  2 - Arrendamento Mercantil;  3 - Reserva de Domínio;  4 - Penhor de Veículos;  9 - outras. | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

