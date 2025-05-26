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
    /// Detalhamento das entregas / prestações do CTe Simplificado.
    /// </summary>
    [DataContract(Name = "CteSimpSefazDetSimp")]
    public partial class CteSimpSefazDetSimp : IEquatable<CteSimpSefazDetSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazDetSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazDetSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazDetSimp" /> class.
        /// </summary>
        /// <param name="nItem">Número identificador do item agrupador da prestação. (required).</param>
        /// <param name="cMunIni">Código do Município de início da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior. (required).</param>
        /// <param name="xMunIni">Nome do Município do início da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior. (required).</param>
        /// <param name="cMunFim">Código do Município de término da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior. (required).</param>
        /// <param name="xMunFim">Nome do Município do término da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior. (required).</param>
        /// <param name="vPrest">Valorl da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS. (required).</param>
        /// <param name="vRec">Valor a Receber. (required).</param>
        /// <param name="comp">comp.</param>
        /// <param name="infNFe">infNFe.</param>
        /// <param name="infDocAnt">infDocAnt.</param>
        public CteSimpSefazDetSimp(int? nItem = default(int?), string cMunIni = default(string), string xMunIni = default(string), string cMunFim = default(string), string xMunFim = default(string), decimal? vPrest = default(decimal?), decimal? vRec = default(decimal?), List<CteSimpSefazCompSimp> comp = default(List<CteSimpSefazCompSimp>), List<CteSimpSefazInfNFeSimp> infNFe = default(List<CteSimpSefazInfNFeSimp>), List<CteSimpSefazInfDocAntSimp> infDocAnt = default(List<CteSimpSefazInfDocAntSimp>))
        {
            // to ensure "nItem" is required (not null)
            if (nItem == null)
            {
                throw new ArgumentNullException("nItem is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.nItem = nItem;
            // to ensure "cMunIni" is required (not null)
            if (cMunIni == null)
            {
                throw new ArgumentNullException("cMunIni is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.cMunIni = cMunIni;
            // to ensure "xMunIni" is required (not null)
            if (xMunIni == null)
            {
                throw new ArgumentNullException("xMunIni is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.xMunIni = xMunIni;
            // to ensure "cMunFim" is required (not null)
            if (cMunFim == null)
            {
                throw new ArgumentNullException("cMunFim is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.cMunFim = cMunFim;
            // to ensure "xMunFim" is required (not null)
            if (xMunFim == null)
            {
                throw new ArgumentNullException("xMunFim is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.xMunFim = xMunFim;
            // to ensure "vPrest" is required (not null)
            if (vPrest == null)
            {
                throw new ArgumentNullException("vPrest is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.vPrest = vPrest;
            // to ensure "vRec" is required (not null)
            if (vRec == null)
            {
                throw new ArgumentNullException("vRec is a required property for CteSimpSefazDetSimp and cannot be null");
            }
            this.vRec = vRec;
            this.Comp = comp;
            this.infNFe = infNFe;
            this.infDocAnt = infDocAnt;
        }

        /// <summary>
        /// Número identificador do item agrupador da prestação.
        /// </summary>
        /// <value>Número identificador do item agrupador da prestação.</value>
        [DataMember(Name = "nItem", IsRequired = true, EmitDefaultValue = true)]
        public int? nItem { get; set; }

        /// <summary>
        /// Código do Município de início da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior.
        /// </summary>
        /// <value>Código do Município de início da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior.</value>
        [DataMember(Name = "cMunIni", IsRequired = true, EmitDefaultValue = true)]
        public string cMunIni { get; set; }

        /// <summary>
        /// Nome do Município do início da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior.
        /// </summary>
        /// <value>Nome do Município do início da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior.</value>
        [DataMember(Name = "xMunIni", IsRequired = true, EmitDefaultValue = true)]
        public string xMunIni { get; set; }

        /// <summary>
        /// Código do Município de término da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior.
        /// </summary>
        /// <value>Código do Município de término da prestação.  Utilizar a tabela do IBGE. Informar 9999999 para operações com o exterior.</value>
        [DataMember(Name = "cMunFim", IsRequired = true, EmitDefaultValue = true)]
        public string cMunFim { get; set; }

        /// <summary>
        /// Nome do Município do término da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior.
        /// </summary>
        /// <value>Nome do Município do término da prestação.  Informar &#39;EXTERIOR&#39; para operações com o exterior.</value>
        [DataMember(Name = "xMunFim", IsRequired = true, EmitDefaultValue = true)]
        public string xMunFim { get; set; }

        /// <summary>
        /// Valorl da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS.
        /// </summary>
        /// <value>Valorl da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS.</value>
        [DataMember(Name = "vPrest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPrest { get; set; }

        /// <summary>
        /// Valor a Receber.
        /// </summary>
        /// <value>Valor a Receber.</value>
        [DataMember(Name = "vRec", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vRec { get; set; }

        /// <summary>
        /// Gets or Sets Comp
        /// </summary>
        [DataMember(Name = "Comp", EmitDefaultValue = false)]
        public List<CteSimpSefazCompSimp> Comp { get; set; }

        /// <summary>
        /// Gets or Sets infNFe
        /// </summary>
        [DataMember(Name = "infNFe", EmitDefaultValue = false)]
        public List<CteSimpSefazInfNFeSimp> infNFe { get; set; }

        /// <summary>
        /// Gets or Sets infDocAnt
        /// </summary>
        [DataMember(Name = "infDocAnt", EmitDefaultValue = false)]
        public List<CteSimpSefazInfDocAntSimp> infDocAnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazDetSimp {\n");
            sb.Append("  nItem: ").Append(nItem).Append("\n");
            sb.Append("  cMunIni: ").Append(cMunIni).Append("\n");
            sb.Append("  xMunIni: ").Append(xMunIni).Append("\n");
            sb.Append("  cMunFim: ").Append(cMunFim).Append("\n");
            sb.Append("  xMunFim: ").Append(xMunFim).Append("\n");
            sb.Append("  vPrest: ").Append(vPrest).Append("\n");
            sb.Append("  vRec: ").Append(vRec).Append("\n");
            sb.Append("  Comp: ").Append(Comp).Append("\n");
            sb.Append("  infNFe: ").Append(infNFe).Append("\n");
            sb.Append("  infDocAnt: ").Append(infDocAnt).Append("\n");
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
            return this.Equals(input as CteSimpSefazDetSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazDetSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazDetSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazDetSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nItem == input.nItem ||
                    (this.nItem != null &&
                    this.nItem.Equals(input.nItem))
                ) && 
                (
                    this.cMunIni == input.cMunIni ||
                    (this.cMunIni != null &&
                    this.cMunIni.Equals(input.cMunIni))
                ) && 
                (
                    this.xMunIni == input.xMunIni ||
                    (this.xMunIni != null &&
                    this.xMunIni.Equals(input.xMunIni))
                ) && 
                (
                    this.cMunFim == input.cMunFim ||
                    (this.cMunFim != null &&
                    this.cMunFim.Equals(input.cMunFim))
                ) && 
                (
                    this.xMunFim == input.xMunFim ||
                    (this.xMunFim != null &&
                    this.xMunFim.Equals(input.xMunFim))
                ) && 
                (
                    this.vPrest == input.vPrest ||
                    (this.vPrest != null &&
                    this.vPrest.Equals(input.vPrest))
                ) && 
                (
                    this.vRec == input.vRec ||
                    (this.vRec != null &&
                    this.vRec.Equals(input.vRec))
                ) && 
                (
                    this.Comp == input.Comp ||
                    this.Comp != null &&
                    input.Comp != null &&
                    this.Comp.SequenceEqual(input.Comp)
                ) && 
                (
                    this.infNFe == input.infNFe ||
                    this.infNFe != null &&
                    input.infNFe != null &&
                    this.infNFe.SequenceEqual(input.infNFe)
                ) && 
                (
                    this.infDocAnt == input.infDocAnt ||
                    this.infDocAnt != null &&
                    input.infDocAnt != null &&
                    this.infDocAnt.SequenceEqual(input.infDocAnt)
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
                if (this.nItem != null)
                {
                    hashCode = (hashCode * 59) + this.nItem.GetHashCode();
                }
                if (this.cMunIni != null)
                {
                    hashCode = (hashCode * 59) + this.cMunIni.GetHashCode();
                }
                if (this.xMunIni != null)
                {
                    hashCode = (hashCode * 59) + this.xMunIni.GetHashCode();
                }
                if (this.cMunFim != null)
                {
                    hashCode = (hashCode * 59) + this.cMunFim.GetHashCode();
                }
                if (this.xMunFim != null)
                {
                    hashCode = (hashCode * 59) + this.xMunFim.GetHashCode();
                }
                if (this.vPrest != null)
                {
                    hashCode = (hashCode * 59) + this.vPrest.GetHashCode();
                }
                if (this.vRec != null)
                {
                    hashCode = (hashCode * 59) + this.vRec.GetHashCode();
                }
                if (this.Comp != null)
                {
                    hashCode = (hashCode * 59) + this.Comp.GetHashCode();
                }
                if (this.infNFe != null)
                {
                    hashCode = (hashCode * 59) + this.infNFe.GetHashCode();
                }
                if (this.infDocAnt != null)
                {
                    hashCode = (hashCode * 59) + this.infDocAnt.GetHashCode();
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
            // nItem (int?) maximum
            if (this.nItem > (int?)990)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value less than or equal to 990.", new [] { "nItem" });
            }

            // nItem (int?) minimum
            if (this.nItem < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value greater than or equal to 1.", new [] { "nItem" });
            }

            // xMunIni (string) maxLength
            if (this.xMunIni != null && this.xMunIni.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xMunIni, length must be less than 60.", new [] { "xMunIni" });
            }

            // xMunIni (string) minLength
            if (this.xMunIni != null && this.xMunIni.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xMunIni, length must be greater than 2.", new [] { "xMunIni" });
            }

            // xMunFim (string) maxLength
            if (this.xMunFim != null && this.xMunFim.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xMunFim, length must be less than 60.", new [] { "xMunFim" });
            }

            // xMunFim (string) minLength
            if (this.xMunFim != null && this.xMunFim.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xMunFim, length must be greater than 2.", new [] { "xMunFim" });
            }

            // vPrest (decimal?) minimum
            if (this.vPrest < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vPrest, must be a value greater than or equal to 0.", new [] { "vPrest" });
            }

            // vRec (decimal?) minimum
            if (this.vRec < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vRec, must be a value greater than or equal to 0.", new [] { "vRec" });
            }

            yield break;
        }
    }

}
