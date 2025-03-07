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
    /// Partilha do ICMS entre a UF de origem e UF de destino ou a UF definida na legislação  Operação interestadual para consumidor final com partilha do ICMS  devido na operação entre a UF de origem e a UF do destinatário ou ou a UF definida na legislação. (Ex. UF da concessionária de entrega do  veículos).
    /// </summary>
    [DataContract(Name = "NfeSefazICMSPart")]
    public partial class NfeSefazICMSPart : IEquatable<NfeSefazICMSPart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSPart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMSPart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSPart" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributação pelo ICMS  * 10 - Tributada e com cobrança do ICMS por substituição tributária  * 90 - Outros (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação (required).</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pRedBC">Percentual de redução da BC..</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação (required).</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST. (required).</param>
        /// <param name="pICMSST">Alíquota do ICMS ST. (required).</param>
        /// <param name="vICMSST">Valor do ICMS ST. (required).</param>
        /// <param name="vBCFCPST">Valor da Base de cálculo do FCP retido por substituicao tributaria..</param>
        /// <param name="pFCPST">Percentual de FCP retido por substituição tributária..</param>
        /// <param name="vFCPST">Valor do FCP retido por substituição tributária..</param>
        /// <param name="pBCOp">Percentual para determinação do valor  da Base de Cálculo da operação própria. (required).</param>
        /// <param name="uFST">Sigla da UF para qual é devido o ICMS ST da operação. (required).</param>
        public NfeSefazICMSPart(int? orig = default(int?), string cST = default(string), int? modBC = default(int?), decimal? vBC = default(decimal?), decimal? pRedBC = default(decimal?), decimal? pICMS = default(decimal?), decimal? vICMS = default(decimal?), int? modBCST = default(int?), decimal? pMVAST = default(decimal?), decimal? pRedBCST = default(decimal?), decimal? vBCST = default(decimal?), decimal? pICMSST = default(decimal?), decimal? vICMSST = default(decimal?), decimal? vBCFCPST = default(decimal?), decimal? pFCPST = default(decimal?), decimal? vFCPST = default(decimal?), decimal? pBCOp = default(decimal?), string uFST = default(string))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.CST = cST;
            // to ensure "modBC" is required (not null)
            if (modBC == null)
            {
                throw new ArgumentNullException("modBC is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.modBC = modBC;
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pICMS" is required (not null)
            if (pICMS == null)
            {
                throw new ArgumentNullException("pICMS is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.pICMS = pICMS;
            // to ensure "vICMS" is required (not null)
            if (vICMS == null)
            {
                throw new ArgumentNullException("vICMS is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.vICMS = vICMS;
            // to ensure "modBCST" is required (not null)
            if (modBCST == null)
            {
                throw new ArgumentNullException("modBCST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.modBCST = modBCST;
            // to ensure "vBCST" is required (not null)
            if (vBCST == null)
            {
                throw new ArgumentNullException("vBCST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.vBCST = vBCST;
            // to ensure "pICMSST" is required (not null)
            if (pICMSST == null)
            {
                throw new ArgumentNullException("pICMSST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.pICMSST = pICMSST;
            // to ensure "vICMSST" is required (not null)
            if (vICMSST == null)
            {
                throw new ArgumentNullException("vICMSST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.vICMSST = vICMSST;
            // to ensure "pBCOp" is required (not null)
            if (pBCOp == null)
            {
                throw new ArgumentNullException("pBCOp is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.pBCOp = pBCOp;
            // to ensure "uFST" is required (not null)
            if (uFST == null)
            {
                throw new ArgumentNullException("uFST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.UFST = uFST;
            this.pRedBC = pRedBC;
            this.pMVAST = pMVAST;
            this.pRedBCST = pRedBCST;
            this.vBCFCPST = vBCFCPST;
            this.pFCPST = pFCPST;
            this.vFCPST = vFCPST;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int? orig { get; set; }

        /// <summary>
        /// Tributação pelo ICMS  * 10 - Tributada e com cobrança do ICMS por substituição tributária  * 90 - Outros
        /// </summary>
        /// <value>Tributação pelo ICMS  * 10 - Tributada e com cobrança do ICMS por substituição tributária  * 90 - Outros</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação</value>
        [DataMember(Name = "modBC", IsRequired = true, EmitDefaultValue = true)]
        public int? modBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", EmitDefaultValue = true)]
        public decimal? pRedBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMS { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação</value>
        [DataMember(Name = "modBCST", IsRequired = true, EmitDefaultValue = true)]
        public int? modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST.
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST.</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = true)]
        public decimal? pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST.
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST.</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = true)]
        public decimal? pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST.
        /// </summary>
        /// <value>Valor da BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST.
        /// </summary>
        /// <value>Alíquota do ICMS ST.</value>
        [DataMember(Name = "pICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST.
        /// </summary>
        /// <value>Valor do ICMS ST.</value>
        [DataMember(Name = "vICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSST { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP retido por substituicao tributaria.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP retido por substituicao tributaria.</value>
        [DataMember(Name = "vBCFCPST", EmitDefaultValue = true)]
        public decimal? vBCFCPST { get; set; }

        /// <summary>
        /// Percentual de FCP retido por substituição tributária.
        /// </summary>
        /// <value>Percentual de FCP retido por substituição tributária.</value>
        [DataMember(Name = "pFCPST", EmitDefaultValue = true)]
        public decimal? pFCPST { get; set; }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        /// <value>Valor do FCP retido por substituição tributária.</value>
        [DataMember(Name = "vFCPST", EmitDefaultValue = true)]
        public decimal? vFCPST { get; set; }

        /// <summary>
        /// Percentual para determinação do valor  da Base de Cálculo da operação própria.
        /// </summary>
        /// <value>Percentual para determinação do valor  da Base de Cálculo da operação própria.</value>
        [DataMember(Name = "pBCOp", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pBCOp { get; set; }

        /// <summary>
        /// Sigla da UF para qual é devido o ICMS ST da operação.
        /// </summary>
        /// <value>Sigla da UF para qual é devido o ICMS ST da operação.</value>
        [DataMember(Name = "UFST", IsRequired = true, EmitDefaultValue = true)]
        public string UFST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMSPart {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  modBC: ").Append(modBC).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pRedBC: ").Append(pRedBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  modBCST: ").Append(modBCST).Append("\n");
            sb.Append("  pMVAST: ").Append(pMVAST).Append("\n");
            sb.Append("  pRedBCST: ").Append(pRedBCST).Append("\n");
            sb.Append("  vBCST: ").Append(vBCST).Append("\n");
            sb.Append("  pICMSST: ").Append(pICMSST).Append("\n");
            sb.Append("  vICMSST: ").Append(vICMSST).Append("\n");
            sb.Append("  vBCFCPST: ").Append(vBCFCPST).Append("\n");
            sb.Append("  pFCPST: ").Append(pFCPST).Append("\n");
            sb.Append("  vFCPST: ").Append(vFCPST).Append("\n");
            sb.Append("  pBCOp: ").Append(pBCOp).Append("\n");
            sb.Append("  UFST: ").Append(UFST).Append("\n");
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
            return this.Equals(input as NfeSefazICMSPart);
        }

        /// <summary>
        /// Returns true if NfeSefazICMSPart instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMSPart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMSPart input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.orig == input.orig ||
                    (this.orig != null &&
                    this.orig.Equals(input.orig))
                ) && 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.modBC == input.modBC ||
                    (this.modBC != null &&
                    this.modBC.Equals(input.modBC))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pRedBC == input.pRedBC ||
                    (this.pRedBC != null &&
                    this.pRedBC.Equals(input.pRedBC))
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    (this.pICMS != null &&
                    this.pICMS.Equals(input.pICMS))
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    (this.vICMS != null &&
                    this.vICMS.Equals(input.vICMS))
                ) && 
                (
                    this.modBCST == input.modBCST ||
                    (this.modBCST != null &&
                    this.modBCST.Equals(input.modBCST))
                ) && 
                (
                    this.pMVAST == input.pMVAST ||
                    (this.pMVAST != null &&
                    this.pMVAST.Equals(input.pMVAST))
                ) && 
                (
                    this.pRedBCST == input.pRedBCST ||
                    (this.pRedBCST != null &&
                    this.pRedBCST.Equals(input.pRedBCST))
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    (this.vBCST != null &&
                    this.vBCST.Equals(input.vBCST))
                ) && 
                (
                    this.pICMSST == input.pICMSST ||
                    (this.pICMSST != null &&
                    this.pICMSST.Equals(input.pICMSST))
                ) && 
                (
                    this.vICMSST == input.vICMSST ||
                    (this.vICMSST != null &&
                    this.vICMSST.Equals(input.vICMSST))
                ) && 
                (
                    this.vBCFCPST == input.vBCFCPST ||
                    (this.vBCFCPST != null &&
                    this.vBCFCPST.Equals(input.vBCFCPST))
                ) && 
                (
                    this.pFCPST == input.pFCPST ||
                    (this.pFCPST != null &&
                    this.pFCPST.Equals(input.pFCPST))
                ) && 
                (
                    this.vFCPST == input.vFCPST ||
                    (this.vFCPST != null &&
                    this.vFCPST.Equals(input.vFCPST))
                ) && 
                (
                    this.pBCOp == input.pBCOp ||
                    (this.pBCOp != null &&
                    this.pBCOp.Equals(input.pBCOp))
                ) && 
                (
                    this.UFST == input.UFST ||
                    (this.UFST != null &&
                    this.UFST.Equals(input.UFST))
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
                if (this.orig != null)
                {
                    hashCode = (hashCode * 59) + this.orig.GetHashCode();
                }
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.modBC != null)
                {
                    hashCode = (hashCode * 59) + this.modBC.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pRedBC != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
                }
                if (this.pICMS != null)
                {
                    hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                }
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                }
                if (this.modBCST != null)
                {
                    hashCode = (hashCode * 59) + this.modBCST.GetHashCode();
                }
                if (this.pMVAST != null)
                {
                    hashCode = (hashCode * 59) + this.pMVAST.GetHashCode();
                }
                if (this.pRedBCST != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBCST.GetHashCode();
                }
                if (this.vBCST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                }
                if (this.pICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSST.GetHashCode();
                }
                if (this.vICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSST.GetHashCode();
                }
                if (this.vBCFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCFCPST.GetHashCode();
                }
                if (this.pFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPST.GetHashCode();
                }
                if (this.vFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
                }
                if (this.pBCOp != null)
                {
                    hashCode = (hashCode * 59) + this.pBCOp.GetHashCode();
                }
                if (this.UFST != null)
                {
                    hashCode = (hashCode * 59) + this.UFST.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // pRedBC (decimal?) minimum
            if (this.pRedBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pRedBC, must be a value greater than or equal to 0.", new [] { "pRedBC" });
            }

            // pICMS (decimal?) minimum
            if (this.pICMS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pICMS, must be a value greater than or equal to 0.", new [] { "pICMS" });
            }

            // vICMS (decimal?) minimum
            if (this.vICMS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vICMS, must be a value greater than or equal to 0.", new [] { "vICMS" });
            }

            // pMVAST (decimal?) minimum
            if (this.pMVAST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pMVAST, must be a value greater than or equal to 0.", new [] { "pMVAST" });
            }

            // pRedBCST (decimal?) minimum
            if (this.pRedBCST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pRedBCST, must be a value greater than or equal to 0.", new [] { "pRedBCST" });
            }

            // vBCST (decimal?) minimum
            if (this.vBCST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBCST, must be a value greater than or equal to 0.", new [] { "vBCST" });
            }

            // pICMSST (decimal?) minimum
            if (this.pICMSST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pICMSST, must be a value greater than or equal to 0.", new [] { "pICMSST" });
            }

            // vICMSST (decimal?) minimum
            if (this.vICMSST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vICMSST, must be a value greater than or equal to 0.", new [] { "vICMSST" });
            }

            // vBCFCPST (decimal?) minimum
            if (this.vBCFCPST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBCFCPST, must be a value greater than or equal to 0.", new [] { "vBCFCPST" });
            }

            // pFCPST (decimal?) minimum
            if (this.pFCPST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pFCPST, must be a value greater than or equal to 0.", new [] { "pFCPST" });
            }

            // vFCPST (decimal?) minimum
            if (this.vFCPST < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vFCPST, must be a value greater than or equal to 0.", new [] { "vFCPST" });
            }

            // pBCOp (decimal?) minimum
            if (this.pBCOp < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pBCOp, must be a value greater than or equal to 0.", new [] { "pBCOp" });
            }

            yield break;
        }
    }

}
