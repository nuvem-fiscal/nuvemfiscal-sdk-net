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
    /// NfeSefazICMSPart
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
        /// <param name="orig">Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributação pelo ICMS  10 - Tributada e com cobrança do ICMS por substituição tributária;  90 – Outros. (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação. (required).</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pRedBC">Percentual de redução da BC..</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor).  6 - Valor da Operação. (required).</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST. (required).</param>
        /// <param name="pICMSST">Alíquota do ICMS ST. (required).</param>
        /// <param name="vICMSST">Valor do ICMS ST. (required).</param>
        /// <param name="pBCOp">Percentual para determinação do valor  da Base de Cálculo da operação própria. (required).</param>
        /// <param name="uFST">Sigla da UF para qual é devido o ICMS ST da operação. (required).</param>
        public NfeSefazICMSPart(int orig = default(int), string cST = default(string), int modBC = default(int), decimal vBC = default(decimal), decimal pRedBC = default(decimal), decimal pICMS = default(decimal), decimal vICMS = default(decimal), int modBCST = default(int), decimal pMVAST = default(decimal), decimal pRedBCST = default(decimal), decimal vBCST = default(decimal), decimal pICMSST = default(decimal), decimal vICMSST = default(decimal), decimal pBCOp = default(decimal), string uFST = default(string))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMSPart and cannot be null");
            }
            this.CST = cST;
            this.modBC = modBC;
            this.vBC = vBC;
            this.pICMS = pICMS;
            this.vICMS = vICMS;
            this.modBCST = modBCST;
            this.vBCST = vBCST;
            this.pICMSST = pICMSST;
            this.vICMSST = vICMSST;
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
        }

        /// <summary>
        /// Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributação pelo ICMS  10 - Tributada e com cobrança do ICMS por substituição tributária;  90 – Outros.
        /// </summary>
        /// <value>Tributação pelo ICMS  10 - Tributada e com cobrança do ICMS por substituição tributária;  90 – Outros.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação.
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação.</value>
        [DataMember(Name = "modBC", IsRequired = true, EmitDefaultValue = true)]
        public int modBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", EmitDefaultValue = false)]
        public decimal pRedBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMS { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor).  6 - Valor da Operação.
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor).  6 - Valor da Operação.</value>
        [DataMember(Name = "modBCST", IsRequired = true, EmitDefaultValue = true)]
        public int modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST.
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST.</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = false)]
        public decimal pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST.
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST.</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = false)]
        public decimal pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST.
        /// </summary>
        /// <value>Valor da BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST.
        /// </summary>
        /// <value>Alíquota do ICMS ST.</value>
        [DataMember(Name = "pICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST.
        /// </summary>
        /// <value>Valor do ICMS ST.</value>
        [DataMember(Name = "vICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSST { get; set; }

        /// <summary>
        /// Percentual para determinação do valor  da Base de Cálculo da operação própria.
        /// </summary>
        /// <value>Percentual para determinação do valor  da Base de Cálculo da operação própria.</value>
        [DataMember(Name = "pBCOp", IsRequired = true, EmitDefaultValue = true)]
        public decimal pBCOp { get; set; }

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
                    this.orig.Equals(input.orig)
                ) && 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.modBC == input.modBC ||
                    this.modBC.Equals(input.modBC)
                ) && 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.pRedBC == input.pRedBC ||
                    this.pRedBC.Equals(input.pRedBC)
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    this.pICMS.Equals(input.pICMS)
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    this.vICMS.Equals(input.vICMS)
                ) && 
                (
                    this.modBCST == input.modBCST ||
                    this.modBCST.Equals(input.modBCST)
                ) && 
                (
                    this.pMVAST == input.pMVAST ||
                    this.pMVAST.Equals(input.pMVAST)
                ) && 
                (
                    this.pRedBCST == input.pRedBCST ||
                    this.pRedBCST.Equals(input.pRedBCST)
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    this.vBCST.Equals(input.vBCST)
                ) && 
                (
                    this.pICMSST == input.pICMSST ||
                    this.pICMSST.Equals(input.pICMSST)
                ) && 
                (
                    this.vICMSST == input.vICMSST ||
                    this.vICMSST.Equals(input.vICMSST)
                ) && 
                (
                    this.pBCOp == input.pBCOp ||
                    this.pBCOp.Equals(input.pBCOp)
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
                hashCode = (hashCode * 59) + this.orig.GetHashCode();
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.modBC.GetHashCode();
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.modBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.pMVAST.GetHashCode();
                hashCode = (hashCode * 59) + this.pRedBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSST.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSST.GetHashCode();
                hashCode = (hashCode * 59) + this.pBCOp.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
