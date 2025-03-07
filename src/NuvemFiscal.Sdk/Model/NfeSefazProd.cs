/*
 * Nuvem Fiscal - SDK para .NET
 * https://www.nuvemfiscal.com.br
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = NuvemFiscal.Sdk.Client.FileParameter;
using OpenAPIDateConverter = NuvemFiscal.Sdk.Client.OpenAPIDateConverter;

namespace NuvemFiscal.Sdk.Model
{
    /// <summary>
    /// Dados dos produtos e serviços da NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazProd")]
    public partial class NfeSefazProd : IEquatable<NfeSefazProd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazProd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazProd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazProd" /> class.
        /// </summary>
        /// <param name="cProd">Código do produto ou serviço. Preencher com CFOP caso se trate de itens não relacionados com mercadorias/produto e que o contribuinte não possua codificação própria  Formato ”CFOP9999”. (required).</param>
        /// <param name="cEAN">GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras. (required).</param>
        /// <param name="cBarra">Codigo de barras diferente do padrão GTIN..</param>
        /// <param name="xProd">Descrição do produto ou serviço. (required).</param>
        /// <param name="nCM">Código NCM (8 posições), será permitida a informação do gênero (posição do capítulo do NCM) quando a operação não for de comércio exterior (importação/exportação) ou o produto não seja tributado pelo IPI. Em caso de item de serviço ou item que não tenham produto (Ex. transferência de crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0). (required).</param>
        /// <param name="nVE">Nomenclatura de Valor aduaneio e Estatístico..</param>
        /// <param name="cEST">Codigo especificador da Substuicao Tributaria - CEST, que identifica a mercadoria sujeita aos regimes de  substituicao tributária e de antecipação do recolhimento  do imposto..</param>
        /// <param name="indEscala">indEscala.</param>
        /// <param name="cNPJFab">CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante..</param>
        /// <param name="cBenef">cBenef.</param>
        /// <param name="gCred">gCred.</param>
        /// <param name="eXTIPI">Código EX TIPI (3 posições)..</param>
        /// <param name="cFOP">Cfop. (required).</param>
        /// <param name="uCom">Unidade comercial. (required).</param>
        /// <param name="qCom">Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros. (required).</param>
        /// <param name="vUnCom">Valor unitário de comercialização  - alterado para aceitar 0 a 10 casas decimais e 11 inteiros. (required).</param>
        /// <param name="vProd">Valor bruto do produto ou serviço. (required).</param>
        /// <param name="cEANTrib">GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras. (required).</param>
        /// <param name="cBarraTrib">Código de barras da unidade tributável diferente do padrão GTIN..</param>
        /// <param name="uTrib">Unidade Tributável. (required).</param>
        /// <param name="qTrib">Quantidade Tributável - alterado para aceitar de 0 a 4 casas decimais e 11 inteiros. (required).</param>
        /// <param name="vUnTrib">Valor unitário de tributação - - alterado para aceitar 0 a 10 casas decimais e 11 inteiros. (required).</param>
        /// <param name="vFrete">Valor Total do Frete..</param>
        /// <param name="vSeg">Valor Total do Seguro..</param>
        /// <param name="vDesc">Valor do Desconto..</param>
        /// <param name="vOutro">Outras despesas acessórias..</param>
        /// <param name="indTot">Este campo deverá ser preenchido com:  * 0 - o valor do item (vProd) não compõe o valor total da NF-e (vProd)  * 1 - o valor do item (vProd) compõe o valor total da NF-e (vProd) (required).</param>
        /// <param name="dI">dI.</param>
        /// <param name="detExport">detExport.</param>
        /// <param name="xPed">pedido de compra - Informação de interesse do emissor para controle do B2B..</param>
        /// <param name="nItemPed">Número do Item do Pedido de Compra - Identificação do número do item do pedido de Compra..</param>
        /// <param name="nFCI">Número de controle da FCI - Ficha de Conteúdo de Importação..</param>
        /// <param name="rastro">rastro.</param>
        /// <param name="infProdNFF">infProdNFF.</param>
        /// <param name="infProdEmb">infProdEmb.</param>
        /// <param name="veicProd">veicProd.</param>
        /// <param name="med">med.</param>
        /// <param name="arma">arma.</param>
        /// <param name="comb">comb.</param>
        /// <param name="nRECOPI">Número do RECOPI..</param>
        public NfeSefazProd(string cProd = default(string), string cEAN = default(string), string cBarra = default(string), string xProd = default(string), string nCM = default(string), List<string> nVE = default(List<string>), string cEST = default(string), string indEscala = default(string), string cNPJFab = default(string), string cBenef = default(string), List<NfeSefazGCred> gCred = default(List<NfeSefazGCred>), string eXTIPI = default(string), string cFOP = default(string), string uCom = default(string), decimal? qCom = default(decimal?), decimal? vUnCom = default(decimal?), decimal? vProd = default(decimal?), string cEANTrib = default(string), string cBarraTrib = default(string), string uTrib = default(string), decimal? qTrib = default(decimal?), decimal? vUnTrib = default(decimal?), decimal? vFrete = default(decimal?), decimal? vSeg = default(decimal?), decimal? vDesc = default(decimal?), decimal? vOutro = default(decimal?), int? indTot = default(int?), List<NfeSefazDI> dI = default(List<NfeSefazDI>), List<NfeSefazDetExport> detExport = default(List<NfeSefazDetExport>), string xPed = default(string), int? nItemPed = default(int?), string nFCI = default(string), List<NfeSefazRastro> rastro = default(List<NfeSefazRastro>), NfeSefazInfProdNFF infProdNFF = default(NfeSefazInfProdNFF), NfeSefazInfProdEmb infProdEmb = default(NfeSefazInfProdEmb), NfeSefazVeicProd veicProd = default(NfeSefazVeicProd), NfeSefazMed med = default(NfeSefazMed), List<NfeSefazArma> arma = default(List<NfeSefazArma>), NfeSefazComb comb = default(NfeSefazComb), string nRECOPI = default(string))
        {
            // to ensure "cProd" is required (not null)
            if (cProd == null)
            {
                throw new ArgumentNullException("cProd is a required property for NfeSefazProd and cannot be null");
            }
            this.cProd = cProd;
            // to ensure "cEAN" is required (not null)
            if (cEAN == null)
            {
                throw new ArgumentNullException("cEAN is a required property for NfeSefazProd and cannot be null");
            }
            this.cEAN = cEAN;
            // to ensure "xProd" is required (not null)
            if (xProd == null)
            {
                throw new ArgumentNullException("xProd is a required property for NfeSefazProd and cannot be null");
            }
            this.xProd = xProd;
            // to ensure "nCM" is required (not null)
            if (nCM == null)
            {
                throw new ArgumentNullException("nCM is a required property for NfeSefazProd and cannot be null");
            }
            this.NCM = nCM;
            // to ensure "cFOP" is required (not null)
            if (cFOP == null)
            {
                throw new ArgumentNullException("cFOP is a required property for NfeSefazProd and cannot be null");
            }
            this.CFOP = cFOP;
            // to ensure "uCom" is required (not null)
            if (uCom == null)
            {
                throw new ArgumentNullException("uCom is a required property for NfeSefazProd and cannot be null");
            }
            this.uCom = uCom;
            // to ensure "qCom" is required (not null)
            if (qCom == null)
            {
                throw new ArgumentNullException("qCom is a required property for NfeSefazProd and cannot be null");
            }
            this.qCom = qCom;
            // to ensure "vUnCom" is required (not null)
            if (vUnCom == null)
            {
                throw new ArgumentNullException("vUnCom is a required property for NfeSefazProd and cannot be null");
            }
            this.vUnCom = vUnCom;
            // to ensure "vProd" is required (not null)
            if (vProd == null)
            {
                throw new ArgumentNullException("vProd is a required property for NfeSefazProd and cannot be null");
            }
            this.vProd = vProd;
            // to ensure "cEANTrib" is required (not null)
            if (cEANTrib == null)
            {
                throw new ArgumentNullException("cEANTrib is a required property for NfeSefazProd and cannot be null");
            }
            this.cEANTrib = cEANTrib;
            // to ensure "uTrib" is required (not null)
            if (uTrib == null)
            {
                throw new ArgumentNullException("uTrib is a required property for NfeSefazProd and cannot be null");
            }
            this.uTrib = uTrib;
            // to ensure "qTrib" is required (not null)
            if (qTrib == null)
            {
                throw new ArgumentNullException("qTrib is a required property for NfeSefazProd and cannot be null");
            }
            this.qTrib = qTrib;
            // to ensure "vUnTrib" is required (not null)
            if (vUnTrib == null)
            {
                throw new ArgumentNullException("vUnTrib is a required property for NfeSefazProd and cannot be null");
            }
            this.vUnTrib = vUnTrib;
            // to ensure "indTot" is required (not null)
            if (indTot == null)
            {
                throw new ArgumentNullException("indTot is a required property for NfeSefazProd and cannot be null");
            }
            this.indTot = indTot;
            this.cBarra = cBarra;
            this.NVE = nVE;
            this.CEST = cEST;
            this.indEscala = indEscala;
            this.CNPJFab = cNPJFab;
            this.cBenef = cBenef;
            this.gCred = gCred;
            this.EXTIPI = eXTIPI;
            this.cBarraTrib = cBarraTrib;
            this.vFrete = vFrete;
            this.vSeg = vSeg;
            this.vDesc = vDesc;
            this.vOutro = vOutro;
            this.DI = dI;
            this.detExport = detExport;
            this.xPed = xPed;
            this.nItemPed = nItemPed;
            this.nFCI = nFCI;
            this.rastro = rastro;
            this.infProdNFF = infProdNFF;
            this.infProdEmb = infProdEmb;
            this.veicProd = veicProd;
            this.med = med;
            this.arma = arma;
            this.comb = comb;
            this.nRECOPI = nRECOPI;
        }

        /// <summary>
        /// Código do produto ou serviço. Preencher com CFOP caso se trate de itens não relacionados com mercadorias/produto e que o contribuinte não possua codificação própria  Formato ”CFOP9999”.
        /// </summary>
        /// <value>Código do produto ou serviço. Preencher com CFOP caso se trate de itens não relacionados com mercadorias/produto e que o contribuinte não possua codificação própria  Formato ”CFOP9999”.</value>
        [DataMember(Name = "cProd", IsRequired = true, EmitDefaultValue = true)]
        public string cProd { get; set; }

        /// <summary>
        /// GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras.
        /// </summary>
        /// <value>GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras.</value>
        [DataMember(Name = "cEAN", IsRequired = true, EmitDefaultValue = true)]
        public string cEAN { get; set; }

        /// <summary>
        /// Codigo de barras diferente do padrão GTIN.
        /// </summary>
        /// <value>Codigo de barras diferente do padrão GTIN.</value>
        [DataMember(Name = "cBarra", EmitDefaultValue = true)]
        public string cBarra { get; set; }

        /// <summary>
        /// Descrição do produto ou serviço.
        /// </summary>
        /// <value>Descrição do produto ou serviço.</value>
        [DataMember(Name = "xProd", IsRequired = true, EmitDefaultValue = true)]
        public string xProd { get; set; }

        /// <summary>
        /// Código NCM (8 posições), será permitida a informação do gênero (posição do capítulo do NCM) quando a operação não for de comércio exterior (importação/exportação) ou o produto não seja tributado pelo IPI. Em caso de item de serviço ou item que não tenham produto (Ex. transferência de crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0).
        /// </summary>
        /// <value>Código NCM (8 posições), será permitida a informação do gênero (posição do capítulo do NCM) quando a operação não for de comércio exterior (importação/exportação) ou o produto não seja tributado pelo IPI. Em caso de item de serviço ou item que não tenham produto (Ex. transferência de crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0).</value>
        [DataMember(Name = "NCM", IsRequired = true, EmitDefaultValue = true)]
        public string NCM { get; set; }

        /// <summary>
        /// Nomenclatura de Valor aduaneio e Estatístico.
        /// </summary>
        /// <value>Nomenclatura de Valor aduaneio e Estatístico.</value>
        [DataMember(Name = "NVE", EmitDefaultValue = false)]
        public List<string> NVE { get; set; }

        /// <summary>
        /// Codigo especificador da Substuicao Tributaria - CEST, que identifica a mercadoria sujeita aos regimes de  substituicao tributária e de antecipação do recolhimento  do imposto.
        /// </summary>
        /// <value>Codigo especificador da Substuicao Tributaria - CEST, que identifica a mercadoria sujeita aos regimes de  substituicao tributária e de antecipação do recolhimento  do imposto.</value>
        [DataMember(Name = "CEST", EmitDefaultValue = true)]
        public string CEST { get; set; }

        /// <summary>
        /// Gets or Sets indEscala
        /// </summary>
        [DataMember(Name = "indEscala", EmitDefaultValue = true)]
        public string indEscala { get; set; }

        /// <summary>
        /// CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante.
        /// </summary>
        /// <value>CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante.</value>
        [DataMember(Name = "CNPJFab", EmitDefaultValue = true)]
        public string CNPJFab { get; set; }

        /// <summary>
        /// Gets or Sets cBenef
        /// </summary>
        [DataMember(Name = "cBenef", EmitDefaultValue = true)]
        public string cBenef { get; set; }

        /// <summary>
        /// Gets or Sets gCred
        /// </summary>
        [DataMember(Name = "gCred", EmitDefaultValue = false)]
        public List<NfeSefazGCred> gCred { get; set; }

        /// <summary>
        /// Código EX TIPI (3 posições).
        /// </summary>
        /// <value>Código EX TIPI (3 posições).</value>
        [DataMember(Name = "EXTIPI", EmitDefaultValue = true)]
        public string EXTIPI { get; set; }

        /// <summary>
        /// Cfop.
        /// </summary>
        /// <value>Cfop.</value>
        [DataMember(Name = "CFOP", IsRequired = true, EmitDefaultValue = true)]
        public string CFOP { get; set; }

        /// <summary>
        /// Unidade comercial.
        /// </summary>
        /// <value>Unidade comercial.</value>
        [DataMember(Name = "uCom", IsRequired = true, EmitDefaultValue = true)]
        public string uCom { get; set; }

        /// <summary>
        /// Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
        /// </summary>
        /// <value>Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.</value>
        [DataMember(Name = "qCom", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qCom { get; set; }

        /// <summary>
        /// Valor unitário de comercialização  - alterado para aceitar 0 a 10 casas decimais e 11 inteiros.
        /// </summary>
        /// <value>Valor unitário de comercialização  - alterado para aceitar 0 a 10 casas decimais e 11 inteiros.</value>
        [DataMember(Name = "vUnCom", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vUnCom { get; set; }

        /// <summary>
        /// Valor bruto do produto ou serviço.
        /// </summary>
        /// <value>Valor bruto do produto ou serviço.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vProd { get; set; }

        /// <summary>
        /// GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras.
        /// </summary>
        /// <value>GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras.</value>
        [DataMember(Name = "cEANTrib", IsRequired = true, EmitDefaultValue = true)]
        public string cEANTrib { get; set; }

        /// <summary>
        /// Código de barras da unidade tributável diferente do padrão GTIN.
        /// </summary>
        /// <value>Código de barras da unidade tributável diferente do padrão GTIN.</value>
        [DataMember(Name = "cBarraTrib", EmitDefaultValue = true)]
        public string cBarraTrib { get; set; }

        /// <summary>
        /// Unidade Tributável.
        /// </summary>
        /// <value>Unidade Tributável.</value>
        [DataMember(Name = "uTrib", IsRequired = true, EmitDefaultValue = true)]
        public string uTrib { get; set; }

        /// <summary>
        /// Quantidade Tributável - alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
        /// </summary>
        /// <value>Quantidade Tributável - alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.</value>
        [DataMember(Name = "qTrib", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qTrib { get; set; }

        /// <summary>
        /// Valor unitário de tributação - - alterado para aceitar 0 a 10 casas decimais e 11 inteiros.
        /// </summary>
        /// <value>Valor unitário de tributação - - alterado para aceitar 0 a 10 casas decimais e 11 inteiros.</value>
        [DataMember(Name = "vUnTrib", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vUnTrib { get; set; }

        /// <summary>
        /// Valor Total do Frete.
        /// </summary>
        /// <value>Valor Total do Frete.</value>
        [DataMember(Name = "vFrete", EmitDefaultValue = true)]
        public decimal? vFrete { get; set; }

        /// <summary>
        /// Valor Total do Seguro.
        /// </summary>
        /// <value>Valor Total do Seguro.</value>
        [DataMember(Name = "vSeg", EmitDefaultValue = true)]
        public decimal? vSeg { get; set; }

        /// <summary>
        /// Valor do Desconto.
        /// </summary>
        /// <value>Valor do Desconto.</value>
        [DataMember(Name = "vDesc", EmitDefaultValue = true)]
        public decimal? vDesc { get; set; }

        /// <summary>
        /// Outras despesas acessórias.
        /// </summary>
        /// <value>Outras despesas acessórias.</value>
        [DataMember(Name = "vOutro", EmitDefaultValue = true)]
        public decimal? vOutro { get; set; }

        /// <summary>
        /// Este campo deverá ser preenchido com:  * 0 - o valor do item (vProd) não compõe o valor total da NF-e (vProd)  * 1 - o valor do item (vProd) compõe o valor total da NF-e (vProd)
        /// </summary>
        /// <value>Este campo deverá ser preenchido com:  * 0 - o valor do item (vProd) não compõe o valor total da NF-e (vProd)  * 1 - o valor do item (vProd) compõe o valor total da NF-e (vProd)</value>
        [DataMember(Name = "indTot", IsRequired = true, EmitDefaultValue = true)]
        public int? indTot { get; set; }

        /// <summary>
        /// Gets or Sets DI
        /// </summary>
        [DataMember(Name = "DI", EmitDefaultValue = false)]
        public List<NfeSefazDI> DI { get; set; }

        /// <summary>
        /// Gets or Sets detExport
        /// </summary>
        [DataMember(Name = "detExport", EmitDefaultValue = false)]
        public List<NfeSefazDetExport> detExport { get; set; }

        /// <summary>
        /// pedido de compra - Informação de interesse do emissor para controle do B2B.
        /// </summary>
        /// <value>pedido de compra - Informação de interesse do emissor para controle do B2B.</value>
        [DataMember(Name = "xPed", EmitDefaultValue = true)]
        public string xPed { get; set; }

        /// <summary>
        /// Número do Item do Pedido de Compra - Identificação do número do item do pedido de Compra.
        /// </summary>
        /// <value>Número do Item do Pedido de Compra - Identificação do número do item do pedido de Compra.</value>
        [DataMember(Name = "nItemPed", EmitDefaultValue = true)]
        public int? nItemPed { get; set; }

        /// <summary>
        /// Número de controle da FCI - Ficha de Conteúdo de Importação.
        /// </summary>
        /// <value>Número de controle da FCI - Ficha de Conteúdo de Importação.</value>
        [DataMember(Name = "nFCI", EmitDefaultValue = true)]
        public string nFCI { get; set; }

        /// <summary>
        /// Gets or Sets rastro
        /// </summary>
        [DataMember(Name = "rastro", EmitDefaultValue = false)]
        public List<NfeSefazRastro> rastro { get; set; }

        /// <summary>
        /// Gets or Sets infProdNFF
        /// </summary>
        [DataMember(Name = "infProdNFF", EmitDefaultValue = false)]
        public NfeSefazInfProdNFF infProdNFF { get; set; }

        /// <summary>
        /// Gets or Sets infProdEmb
        /// </summary>
        [DataMember(Name = "infProdEmb", EmitDefaultValue = false)]
        public NfeSefazInfProdEmb infProdEmb { get; set; }

        /// <summary>
        /// Gets or Sets veicProd
        /// </summary>
        [DataMember(Name = "veicProd", EmitDefaultValue = false)]
        public NfeSefazVeicProd veicProd { get; set; }

        /// <summary>
        /// Gets or Sets med
        /// </summary>
        [DataMember(Name = "med", EmitDefaultValue = false)]
        public NfeSefazMed med { get; set; }

        /// <summary>
        /// Gets or Sets arma
        /// </summary>
        [DataMember(Name = "arma", EmitDefaultValue = false)]
        public List<NfeSefazArma> arma { get; set; }

        /// <summary>
        /// Gets or Sets comb
        /// </summary>
        [DataMember(Name = "comb", EmitDefaultValue = false)]
        public NfeSefazComb comb { get; set; }

        /// <summary>
        /// Número do RECOPI.
        /// </summary>
        /// <value>Número do RECOPI.</value>
        [DataMember(Name = "nRECOPI", EmitDefaultValue = true)]
        public string nRECOPI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazProd {\n");
            sb.Append("  cProd: ").Append(cProd).Append("\n");
            sb.Append("  cEAN: ").Append(cEAN).Append("\n");
            sb.Append("  cBarra: ").Append(cBarra).Append("\n");
            sb.Append("  xProd: ").Append(xProd).Append("\n");
            sb.Append("  NCM: ").Append(NCM).Append("\n");
            sb.Append("  NVE: ").Append(NVE).Append("\n");
            sb.Append("  CEST: ").Append(CEST).Append("\n");
            sb.Append("  indEscala: ").Append(indEscala).Append("\n");
            sb.Append("  CNPJFab: ").Append(CNPJFab).Append("\n");
            sb.Append("  cBenef: ").Append(cBenef).Append("\n");
            sb.Append("  gCred: ").Append(gCred).Append("\n");
            sb.Append("  EXTIPI: ").Append(EXTIPI).Append("\n");
            sb.Append("  CFOP: ").Append(CFOP).Append("\n");
            sb.Append("  uCom: ").Append(uCom).Append("\n");
            sb.Append("  qCom: ").Append(qCom).Append("\n");
            sb.Append("  vUnCom: ").Append(vUnCom).Append("\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
            sb.Append("  cEANTrib: ").Append(cEANTrib).Append("\n");
            sb.Append("  cBarraTrib: ").Append(cBarraTrib).Append("\n");
            sb.Append("  uTrib: ").Append(uTrib).Append("\n");
            sb.Append("  qTrib: ").Append(qTrib).Append("\n");
            sb.Append("  vUnTrib: ").Append(vUnTrib).Append("\n");
            sb.Append("  vFrete: ").Append(vFrete).Append("\n");
            sb.Append("  vSeg: ").Append(vSeg).Append("\n");
            sb.Append("  vDesc: ").Append(vDesc).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  indTot: ").Append(indTot).Append("\n");
            sb.Append("  DI: ").Append(DI).Append("\n");
            sb.Append("  detExport: ").Append(detExport).Append("\n");
            sb.Append("  xPed: ").Append(xPed).Append("\n");
            sb.Append("  nItemPed: ").Append(nItemPed).Append("\n");
            sb.Append("  nFCI: ").Append(nFCI).Append("\n");
            sb.Append("  rastro: ").Append(rastro).Append("\n");
            sb.Append("  infProdNFF: ").Append(infProdNFF).Append("\n");
            sb.Append("  infProdEmb: ").Append(infProdEmb).Append("\n");
            sb.Append("  veicProd: ").Append(veicProd).Append("\n");
            sb.Append("  med: ").Append(med).Append("\n");
            sb.Append("  arma: ").Append(arma).Append("\n");
            sb.Append("  comb: ").Append(comb).Append("\n");
            sb.Append("  nRECOPI: ").Append(nRECOPI).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NfeSefazProd);
        }

        /// <summary>
        /// Returns true if NfeSefazProd instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazProd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazProd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cProd == input.cProd ||
                    (this.cProd != null &&
                    this.cProd.Equals(input.cProd))
                ) && 
                (
                    this.cEAN == input.cEAN ||
                    (this.cEAN != null &&
                    this.cEAN.Equals(input.cEAN))
                ) && 
                (
                    this.cBarra == input.cBarra ||
                    (this.cBarra != null &&
                    this.cBarra.Equals(input.cBarra))
                ) && 
                (
                    this.xProd == input.xProd ||
                    (this.xProd != null &&
                    this.xProd.Equals(input.xProd))
                ) && 
                (
                    this.NCM == input.NCM ||
                    (this.NCM != null &&
                    this.NCM.Equals(input.NCM))
                ) && 
                (
                    this.NVE == input.NVE ||
                    this.NVE != null &&
                    input.NVE != null &&
                    this.NVE.SequenceEqual(input.NVE)
                ) && 
                (
                    this.CEST == input.CEST ||
                    (this.CEST != null &&
                    this.CEST.Equals(input.CEST))
                ) && 
                (
                    this.indEscala == input.indEscala ||
                    (this.indEscala != null &&
                    this.indEscala.Equals(input.indEscala))
                ) && 
                (
                    this.CNPJFab == input.CNPJFab ||
                    (this.CNPJFab != null &&
                    this.CNPJFab.Equals(input.CNPJFab))
                ) && 
                (
                    this.cBenef == input.cBenef ||
                    (this.cBenef != null &&
                    this.cBenef.Equals(input.cBenef))
                ) && 
                (
                    this.gCred == input.gCred ||
                    this.gCred != null &&
                    input.gCred != null &&
                    this.gCred.SequenceEqual(input.gCred)
                ) && 
                (
                    this.EXTIPI == input.EXTIPI ||
                    (this.EXTIPI != null &&
                    this.EXTIPI.Equals(input.EXTIPI))
                ) && 
                (
                    this.CFOP == input.CFOP ||
                    (this.CFOP != null &&
                    this.CFOP.Equals(input.CFOP))
                ) && 
                (
                    this.uCom == input.uCom ||
                    (this.uCom != null &&
                    this.uCom.Equals(input.uCom))
                ) && 
                (
                    this.qCom == input.qCom ||
                    (this.qCom != null &&
                    this.qCom.Equals(input.qCom))
                ) && 
                (
                    this.vUnCom == input.vUnCom ||
                    (this.vUnCom != null &&
                    this.vUnCom.Equals(input.vUnCom))
                ) && 
                (
                    this.vProd == input.vProd ||
                    (this.vProd != null &&
                    this.vProd.Equals(input.vProd))
                ) && 
                (
                    this.cEANTrib == input.cEANTrib ||
                    (this.cEANTrib != null &&
                    this.cEANTrib.Equals(input.cEANTrib))
                ) && 
                (
                    this.cBarraTrib == input.cBarraTrib ||
                    (this.cBarraTrib != null &&
                    this.cBarraTrib.Equals(input.cBarraTrib))
                ) && 
                (
                    this.uTrib == input.uTrib ||
                    (this.uTrib != null &&
                    this.uTrib.Equals(input.uTrib))
                ) && 
                (
                    this.qTrib == input.qTrib ||
                    (this.qTrib != null &&
                    this.qTrib.Equals(input.qTrib))
                ) && 
                (
                    this.vUnTrib == input.vUnTrib ||
                    (this.vUnTrib != null &&
                    this.vUnTrib.Equals(input.vUnTrib))
                ) && 
                (
                    this.vFrete == input.vFrete ||
                    (this.vFrete != null &&
                    this.vFrete.Equals(input.vFrete))
                ) && 
                (
                    this.vSeg == input.vSeg ||
                    (this.vSeg != null &&
                    this.vSeg.Equals(input.vSeg))
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    (this.vDesc != null &&
                    this.vDesc.Equals(input.vDesc))
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    (this.vOutro != null &&
                    this.vOutro.Equals(input.vOutro))
                ) && 
                (
                    this.indTot == input.indTot ||
                    (this.indTot != null &&
                    this.indTot.Equals(input.indTot))
                ) && 
                (
                    this.DI == input.DI ||
                    this.DI != null &&
                    input.DI != null &&
                    this.DI.SequenceEqual(input.DI)
                ) && 
                (
                    this.detExport == input.detExport ||
                    this.detExport != null &&
                    input.detExport != null &&
                    this.detExport.SequenceEqual(input.detExport)
                ) && 
                (
                    this.xPed == input.xPed ||
                    (this.xPed != null &&
                    this.xPed.Equals(input.xPed))
                ) && 
                (
                    this.nItemPed == input.nItemPed ||
                    (this.nItemPed != null &&
                    this.nItemPed.Equals(input.nItemPed))
                ) && 
                (
                    this.nFCI == input.nFCI ||
                    (this.nFCI != null &&
                    this.nFCI.Equals(input.nFCI))
                ) && 
                (
                    this.rastro == input.rastro ||
                    this.rastro != null &&
                    input.rastro != null &&
                    this.rastro.SequenceEqual(input.rastro)
                ) && 
                (
                    this.infProdNFF == input.infProdNFF ||
                    (this.infProdNFF != null &&
                    this.infProdNFF.Equals(input.infProdNFF))
                ) && 
                (
                    this.infProdEmb == input.infProdEmb ||
                    (this.infProdEmb != null &&
                    this.infProdEmb.Equals(input.infProdEmb))
                ) && 
                (
                    this.veicProd == input.veicProd ||
                    (this.veicProd != null &&
                    this.veicProd.Equals(input.veicProd))
                ) && 
                (
                    this.med == input.med ||
                    (this.med != null &&
                    this.med.Equals(input.med))
                ) && 
                (
                    this.arma == input.arma ||
                    this.arma != null &&
                    input.arma != null &&
                    this.arma.SequenceEqual(input.arma)
                ) && 
                (
                    this.comb == input.comb ||
                    (this.comb != null &&
                    this.comb.Equals(input.comb))
                ) && 
                (
                    this.nRECOPI == input.nRECOPI ||
                    (this.nRECOPI != null &&
                    this.nRECOPI.Equals(input.nRECOPI))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.cProd != null)
                {
                    hashCode = (hashCode * 59) + this.cProd.GetHashCode();
                }
                if (this.cEAN != null)
                {
                    hashCode = (hashCode * 59) + this.cEAN.GetHashCode();
                }
                if (this.cBarra != null)
                {
                    hashCode = (hashCode * 59) + this.cBarra.GetHashCode();
                }
                if (this.xProd != null)
                {
                    hashCode = (hashCode * 59) + this.xProd.GetHashCode();
                }
                if (this.NCM != null)
                {
                    hashCode = (hashCode * 59) + this.NCM.GetHashCode();
                }
                if (this.NVE != null)
                {
                    hashCode = (hashCode * 59) + this.NVE.GetHashCode();
                }
                if (this.CEST != null)
                {
                    hashCode = (hashCode * 59) + this.CEST.GetHashCode();
                }
                if (this.indEscala != null)
                {
                    hashCode = (hashCode * 59) + this.indEscala.GetHashCode();
                }
                if (this.CNPJFab != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJFab.GetHashCode();
                }
                if (this.cBenef != null)
                {
                    hashCode = (hashCode * 59) + this.cBenef.GetHashCode();
                }
                if (this.gCred != null)
                {
                    hashCode = (hashCode * 59) + this.gCred.GetHashCode();
                }
                if (this.EXTIPI != null)
                {
                    hashCode = (hashCode * 59) + this.EXTIPI.GetHashCode();
                }
                if (this.CFOP != null)
                {
                    hashCode = (hashCode * 59) + this.CFOP.GetHashCode();
                }
                if (this.uCom != null)
                {
                    hashCode = (hashCode * 59) + this.uCom.GetHashCode();
                }
                if (this.qCom != null)
                {
                    hashCode = (hashCode * 59) + this.qCom.GetHashCode();
                }
                if (this.vUnCom != null)
                {
                    hashCode = (hashCode * 59) + this.vUnCom.GetHashCode();
                }
                if (this.vProd != null)
                {
                    hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                }
                if (this.cEANTrib != null)
                {
                    hashCode = (hashCode * 59) + this.cEANTrib.GetHashCode();
                }
                if (this.cBarraTrib != null)
                {
                    hashCode = (hashCode * 59) + this.cBarraTrib.GetHashCode();
                }
                if (this.uTrib != null)
                {
                    hashCode = (hashCode * 59) + this.uTrib.GetHashCode();
                }
                if (this.qTrib != null)
                {
                    hashCode = (hashCode * 59) + this.qTrib.GetHashCode();
                }
                if (this.vUnTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vUnTrib.GetHashCode();
                }
                if (this.vFrete != null)
                {
                    hashCode = (hashCode * 59) + this.vFrete.GetHashCode();
                }
                if (this.vSeg != null)
                {
                    hashCode = (hashCode * 59) + this.vSeg.GetHashCode();
                }
                if (this.vDesc != null)
                {
                    hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                }
                if (this.vOutro != null)
                {
                    hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                }
                if (this.indTot != null)
                {
                    hashCode = (hashCode * 59) + this.indTot.GetHashCode();
                }
                if (this.DI != null)
                {
                    hashCode = (hashCode * 59) + this.DI.GetHashCode();
                }
                if (this.detExport != null)
                {
                    hashCode = (hashCode * 59) + this.detExport.GetHashCode();
                }
                if (this.xPed != null)
                {
                    hashCode = (hashCode * 59) + this.xPed.GetHashCode();
                }
                if (this.nItemPed != null)
                {
                    hashCode = (hashCode * 59) + this.nItemPed.GetHashCode();
                }
                if (this.nFCI != null)
                {
                    hashCode = (hashCode * 59) + this.nFCI.GetHashCode();
                }
                if (this.rastro != null)
                {
                    hashCode = (hashCode * 59) + this.rastro.GetHashCode();
                }
                if (this.infProdNFF != null)
                {
                    hashCode = (hashCode * 59) + this.infProdNFF.GetHashCode();
                }
                if (this.infProdEmb != null)
                {
                    hashCode = (hashCode * 59) + this.infProdEmb.GetHashCode();
                }
                if (this.veicProd != null)
                {
                    hashCode = (hashCode * 59) + this.veicProd.GetHashCode();
                }
                if (this.med != null)
                {
                    hashCode = (hashCode * 59) + this.med.GetHashCode();
                }
                if (this.arma != null)
                {
                    hashCode = (hashCode * 59) + this.arma.GetHashCode();
                }
                if (this.comb != null)
                {
                    hashCode = (hashCode * 59) + this.comb.GetHashCode();
                }
                if (this.nRECOPI != null)
                {
                    hashCode = (hashCode * 59) + this.nRECOPI.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // cProd (string) maxLength
            if (this.cProd != null && this.cProd.Length > 60)
            {
                yield return new ValidationResult("Invalid value for cProd, length must be less than 60.", new [] { "cProd" });
            }

            // cProd (string) minLength
            if (this.cProd != null && this.cProd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cProd, length must be greater than 1.", new [] { "cProd" });
            }

            // cBarra (string) maxLength
            if (this.cBarra != null && this.cBarra.Length > 30)
            {
                yield return new ValidationResult("Invalid value for cBarra, length must be less than 30.", new [] { "cBarra" });
            }

            // cBarra (string) minLength
            if (this.cBarra != null && this.cBarra.Length < 3)
            {
                yield return new ValidationResult("Invalid value for cBarra, length must be greater than 3.", new [] { "cBarra" });
            }

            // xProd (string) maxLength
            if (this.xProd != null && this.xProd.Length > 120)
            {
                yield return new ValidationResult("Invalid value for xProd, length must be less than 120.", new [] { "xProd" });
            }

            // xProd (string) minLength
            if (this.xProd != null && this.xProd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xProd, length must be greater than 1.", new [] { "xProd" });
            }

            // CNPJFab (string) maxLength
            if (this.CNPJFab != null && this.CNPJFab.Length > 14)
            {
                yield return new ValidationResult("Invalid value for CNPJFab, length must be less than 14.", new [] { "CNPJFab" });
            }

            // uCom (string) maxLength
            if (this.uCom != null && this.uCom.Length > 6)
            {
                yield return new ValidationResult("Invalid value for uCom, length must be less than 6.", new [] { "uCom" });
            }

            // uCom (string) minLength
            if (this.uCom != null && this.uCom.Length < 1)
            {
                yield return new ValidationResult("Invalid value for uCom, length must be greater than 1.", new [] { "uCom" });
            }

            // qCom (decimal?) minimum
            if (this.qCom < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qCom, must be a value greater than or equal to 0.", new [] { "qCom" });
            }

            // vUnCom (decimal?) minimum
            if (this.vUnCom < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vUnCom, must be a value greater than or equal to 0.", new [] { "vUnCom" });
            }

            // vProd (decimal?) minimum
            if (this.vProd < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vProd, must be a value greater than or equal to 0.", new [] { "vProd" });
            }

            // cBarraTrib (string) maxLength
            if (this.cBarraTrib != null && this.cBarraTrib.Length > 30)
            {
                yield return new ValidationResult("Invalid value for cBarraTrib, length must be less than 30.", new [] { "cBarraTrib" });
            }

            // cBarraTrib (string) minLength
            if (this.cBarraTrib != null && this.cBarraTrib.Length < 3)
            {
                yield return new ValidationResult("Invalid value for cBarraTrib, length must be greater than 3.", new [] { "cBarraTrib" });
            }

            // uTrib (string) maxLength
            if (this.uTrib != null && this.uTrib.Length > 6)
            {
                yield return new ValidationResult("Invalid value for uTrib, length must be less than 6.", new [] { "uTrib" });
            }

            // uTrib (string) minLength
            if (this.uTrib != null && this.uTrib.Length < 1)
            {
                yield return new ValidationResult("Invalid value for uTrib, length must be greater than 1.", new [] { "uTrib" });
            }

            // qTrib (decimal?) minimum
            if (this.qTrib < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qTrib, must be a value greater than or equal to 0.", new [] { "qTrib" });
            }

            // vUnTrib (decimal?) minimum
            if (this.vUnTrib < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vUnTrib, must be a value greater than or equal to 0.", new [] { "vUnTrib" });
            }

            // vFrete (decimal?) minimum
            if (this.vFrete < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vFrete, must be a value greater than or equal to 0.", new [] { "vFrete" });
            }

            // vSeg (decimal?) minimum
            if (this.vSeg < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vSeg, must be a value greater than or equal to 0.", new [] { "vSeg" });
            }

            // vDesc (decimal?) minimum
            if (this.vDesc < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDesc, must be a value greater than or equal to 0.", new [] { "vDesc" });
            }

            // vOutro (decimal?) minimum
            if (this.vOutro < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vOutro, must be a value greater than or equal to 0.", new [] { "vOutro" });
            }

            // xPed (string) maxLength
            if (this.xPed != null && this.xPed.Length > 15)
            {
                yield return new ValidationResult("Invalid value for xPed, length must be less than 15.", new [] { "xPed" });
            }

            // xPed (string) minLength
            if (this.xPed != null && this.xPed.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xPed, length must be greater than 1.", new [] { "xPed" });
            }

            // nItemPed (int?) maximum
            if (this.nItemPed > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for nItemPed, must be a value less than or equal to 999999.", new [] { "nItemPed" });
            }

            // nItemPed (int?) minimum
            if (this.nItemPed < (int?)0)
            {
                yield return new ValidationResult("Invalid value for nItemPed, must be a value greater than or equal to 0.", new [] { "nItemPed" });
            }

            // nRECOPI (string) maxLength
            if (this.nRECOPI != null && this.nRECOPI.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nRECOPI, length must be less than 20.", new [] { "nRECOPI" });
            }

            yield break;
        }
    }

}
