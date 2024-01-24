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
    /// ICMS devido à UF de origem da prestação, quando  diferente da UF do emitente.
    /// </summary>
    [DataContract(Name = "CteSefazICMSOutraUF")]
    public partial class CteSefazICMSOutraUF : IEquatable<CteSefazICMSOutraUF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMSOutraUF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazICMSOutraUF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMSOutraUF" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do Serviço.  * 90 - ICMS Outra UF (required).</param>
        /// <param name="pRedBCOutraUF">Percentual de redução da BC..</param>
        /// <param name="vBCOutraUF">Valor da BC do ICMS. (required).</param>
        /// <param name="pICMSOutraUF">Alíquota do ICMS. (required).</param>
        /// <param name="vICMSOutraUF">Valor do ICMS devido outra UF. (required).</param>
        /// <param name="vICMSDeson">Valor do ICMS de desoneração..</param>
        /// <param name="cBenef">Código de Benefício Fiscal na UF.  Código de Benefício Fiscal utilizado pela UF..</param>
        public CteSefazICMSOutraUF(string cST = default(string), decimal? pRedBCOutraUF = default(decimal?), decimal? vBCOutraUF = default(decimal?), decimal? pICMSOutraUF = default(decimal?), decimal? vICMSOutraUF = default(decimal?), decimal? vICMSDeson = default(decimal?), string cBenef = default(string))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSefazICMSOutraUF and cannot be null");
            }
            this.CST = cST;
            // to ensure "vBCOutraUF" is required (not null)
            if (vBCOutraUF == null)
            {
                throw new ArgumentNullException("vBCOutraUF is a required property for CteSefazICMSOutraUF and cannot be null");
            }
            this.vBCOutraUF = vBCOutraUF;
            // to ensure "pICMSOutraUF" is required (not null)
            if (pICMSOutraUF == null)
            {
                throw new ArgumentNullException("pICMSOutraUF is a required property for CteSefazICMSOutraUF and cannot be null");
            }
            this.pICMSOutraUF = pICMSOutraUF;
            // to ensure "vICMSOutraUF" is required (not null)
            if (vICMSOutraUF == null)
            {
                throw new ArgumentNullException("vICMSOutraUF is a required property for CteSefazICMSOutraUF and cannot be null");
            }
            this.vICMSOutraUF = vICMSOutraUF;
            this.pRedBCOutraUF = pRedBCOutraUF;
            this.vICMSDeson = vICMSDeson;
            this.cBenef = cBenef;
        }

        /// <summary>
        /// Classificação Tributária do Serviço.  * 90 - ICMS Outra UF
        /// </summary>
        /// <value>Classificação Tributária do Serviço.  * 90 - ICMS Outra UF</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBCOutraUF", EmitDefaultValue = true)]
        public decimal? pRedBCOutraUF { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBCOutraUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCOutraUF { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMSOutraUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSOutraUF { get; set; }

        /// <summary>
        /// Valor do ICMS devido outra UF.
        /// </summary>
        /// <value>Valor do ICMS devido outra UF.</value>
        [DataMember(Name = "vICMSOutraUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSOutraUF { get; set; }

        /// <summary>
        /// Valor do ICMS de desoneração.
        /// </summary>
        /// <value>Valor do ICMS de desoneração.</value>
        [DataMember(Name = "vICMSDeson", EmitDefaultValue = true)]
        public decimal? vICMSDeson { get; set; }

        /// <summary>
        /// Código de Benefício Fiscal na UF.  Código de Benefício Fiscal utilizado pela UF.
        /// </summary>
        /// <value>Código de Benefício Fiscal na UF.  Código de Benefício Fiscal utilizado pela UF.</value>
        [DataMember(Name = "cBenef", EmitDefaultValue = true)]
        public string cBenef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazICMSOutraUF {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  pRedBCOutraUF: ").Append(pRedBCOutraUF).Append("\n");
            sb.Append("  vBCOutraUF: ").Append(vBCOutraUF).Append("\n");
            sb.Append("  pICMSOutraUF: ").Append(pICMSOutraUF).Append("\n");
            sb.Append("  vICMSOutraUF: ").Append(vICMSOutraUF).Append("\n");
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  cBenef: ").Append(cBenef).Append("\n");
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
            return this.Equals(input as CteSefazICMSOutraUF);
        }

        /// <summary>
        /// Returns true if CteSefazICMSOutraUF instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazICMSOutraUF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazICMSOutraUF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.pRedBCOutraUF == input.pRedBCOutraUF ||
                    (this.pRedBCOutraUF != null &&
                    this.pRedBCOutraUF.Equals(input.pRedBCOutraUF))
                ) && 
                (
                    this.vBCOutraUF == input.vBCOutraUF ||
                    (this.vBCOutraUF != null &&
                    this.vBCOutraUF.Equals(input.vBCOutraUF))
                ) && 
                (
                    this.pICMSOutraUF == input.pICMSOutraUF ||
                    (this.pICMSOutraUF != null &&
                    this.pICMSOutraUF.Equals(input.pICMSOutraUF))
                ) && 
                (
                    this.vICMSOutraUF == input.vICMSOutraUF ||
                    (this.vICMSOutraUF != null &&
                    this.vICMSOutraUF.Equals(input.vICMSOutraUF))
                ) && 
                (
                    this.vICMSDeson == input.vICMSDeson ||
                    (this.vICMSDeson != null &&
                    this.vICMSDeson.Equals(input.vICMSDeson))
                ) && 
                (
                    this.cBenef == input.cBenef ||
                    (this.cBenef != null &&
                    this.cBenef.Equals(input.cBenef))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.pRedBCOutraUF != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBCOutraUF.GetHashCode();
                }
                if (this.vBCOutraUF != null)
                {
                    hashCode = (hashCode * 59) + this.vBCOutraUF.GetHashCode();
                }
                if (this.pICMSOutraUF != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSOutraUF.GetHashCode();
                }
                if (this.vICMSOutraUF != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSOutraUF.GetHashCode();
                }
                if (this.vICMSDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                }
                if (this.cBenef != null)
                {
                    hashCode = (hashCode * 59) + this.cBenef.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // cBenef (string) maxLength
            if (this.cBenef != null && this.cBenef.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cBenef, length must be less than 10.", new [] { "cBenef" });
            }

            yield break;
        }
    }

}
