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
    /// Prestação sujeito à tributação com redução de BC do ICMS.
    /// </summary>
    [DataContract(Name = "CteSimpSefazICMS20Simp")]
    public partial class CteSimpSefazICMS20Simp : IEquatable<CteSimpSefazICMS20Simp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazICMS20Simp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazICMS20Simp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazICMS20Simp" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do serviço.  * 20 - tributação com BC reduzida do ICMS (required).</param>
        /// <param name="pRedBC">Percentual de redução da BC. (required).</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="vICMSDeson">Valor do ICMS de desoneração..</param>
        /// <param name="cBenef">Código de Benefício Fiscal na UF.  Código de Benefício Fiscal utilizado pela UF..</param>
        public CteSimpSefazICMS20Simp(string cST = default(string), decimal? pRedBC = default(decimal?), decimal? vBC = default(decimal?), decimal? pICMS = default(decimal?), decimal? vICMS = default(decimal?), decimal? vICMSDeson = default(decimal?), string cBenef = default(string))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSimpSefazICMS20Simp and cannot be null");
            }
            this.CST = cST;
            // to ensure "pRedBC" is required (not null)
            if (pRedBC == null)
            {
                throw new ArgumentNullException("pRedBC is a required property for CteSimpSefazICMS20Simp and cannot be null");
            }
            this.pRedBC = pRedBC;
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for CteSimpSefazICMS20Simp and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pICMS" is required (not null)
            if (pICMS == null)
            {
                throw new ArgumentNullException("pICMS is a required property for CteSimpSefazICMS20Simp and cannot be null");
            }
            this.pICMS = pICMS;
            // to ensure "vICMS" is required (not null)
            if (vICMS == null)
            {
                throw new ArgumentNullException("vICMS is a required property for CteSimpSefazICMS20Simp and cannot be null");
            }
            this.vICMS = vICMS;
            this.vICMSDeson = vICMSDeson;
            this.cBenef = cBenef;
        }

        /// <summary>
        /// Classificação Tributária do serviço.  * 20 - tributação com BC reduzida do ICMS
        /// </summary>
        /// <value>Classificação Tributária do serviço.  * 20 - tributação com BC reduzida do ICMS</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pRedBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

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
            sb.Append("class CteSimpSefazICMS20Simp {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  pRedBC: ").Append(pRedBC).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
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
            return this.Equals(input as CteSimpSefazICMS20Simp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazICMS20Simp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazICMS20Simp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazICMS20Simp input)
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
                    this.pRedBC == input.pRedBC ||
                    (this.pRedBC != null &&
                    this.pRedBC.Equals(input.pRedBC))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
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
                if (this.pRedBC != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pICMS != null)
                {
                    hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                }
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // pRedBC (decimal?) minimum
            if (this.pRedBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pRedBC, must be a value greater than or equal to 0.", new [] { "pRedBC" });
            }

            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
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

            // vICMSDeson (decimal?) minimum
            if (this.vICMSDeson < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vICMSDeson, must be a value greater than or equal to 0.", new [] { "vICMSDeson" });
            }

            // cBenef (string) maxLength
            if (this.cBenef != null && this.cBenef.Length > 10)
            {
                yield return new ValidationResult("Invalid value for cBenef, length must be less than 10.", new [] { "cBenef" });
            }

            yield break;
        }
    }

}
