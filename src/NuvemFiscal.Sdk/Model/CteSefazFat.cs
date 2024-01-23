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
    /// Dados da fatura.
    /// </summary>
    [DataContract(Name = "CteSefazFat")]
    public partial class CteSefazFat : IEquatable<CteSefazFat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazFat" /> class.
        /// </summary>
        /// <param name="nFat">Número da fatura..</param>
        /// <param name="vOrig">Valor original da fatura..</param>
        /// <param name="vDesc">Valor do desconto da fatura..</param>
        /// <param name="vLiq">Valor líquido da fatura..</param>
        public CteSefazFat(string nFat = default(string), decimal? vOrig = default(decimal?), decimal? vDesc = default(decimal?), decimal? vLiq = default(decimal?))
        {
            this.nFat = nFat;
            this.vOrig = vOrig;
            this.vDesc = vDesc;
            this.vLiq = vLiq;
        }

        /// <summary>
        /// Número da fatura.
        /// </summary>
        /// <value>Número da fatura.</value>
        [DataMember(Name = "nFat", EmitDefaultValue = true)]
        public string nFat { get; set; }

        /// <summary>
        /// Valor original da fatura.
        /// </summary>
        /// <value>Valor original da fatura.</value>
        [DataMember(Name = "vOrig", EmitDefaultValue = true)]
        public decimal? vOrig { get; set; }

        /// <summary>
        /// Valor do desconto da fatura.
        /// </summary>
        /// <value>Valor do desconto da fatura.</value>
        [DataMember(Name = "vDesc", EmitDefaultValue = true)]
        public decimal? vDesc { get; set; }

        /// <summary>
        /// Valor líquido da fatura.
        /// </summary>
        /// <value>Valor líquido da fatura.</value>
        [DataMember(Name = "vLiq", EmitDefaultValue = true)]
        public decimal? vLiq { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazFat {\n");
            sb.Append("  nFat: ").Append(nFat).Append("\n");
            sb.Append("  vOrig: ").Append(vOrig).Append("\n");
            sb.Append("  vDesc: ").Append(vDesc).Append("\n");
            sb.Append("  vLiq: ").Append(vLiq).Append("\n");
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
            return this.Equals(input as CteSefazFat);
        }

        /// <summary>
        /// Returns true if CteSefazFat instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazFat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazFat input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nFat == input.nFat ||
                    (this.nFat != null &&
                    this.nFat.Equals(input.nFat))
                ) && 
                (
                    this.vOrig == input.vOrig ||
                    (this.vOrig != null &&
                    this.vOrig.Equals(input.vOrig))
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    (this.vDesc != null &&
                    this.vDesc.Equals(input.vDesc))
                ) && 
                (
                    this.vLiq == input.vLiq ||
                    (this.vLiq != null &&
                    this.vLiq.Equals(input.vLiq))
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
                if (this.nFat != null)
                {
                    hashCode = (hashCode * 59) + this.nFat.GetHashCode();
                }
                if (this.vOrig != null)
                {
                    hashCode = (hashCode * 59) + this.vOrig.GetHashCode();
                }
                if (this.vDesc != null)
                {
                    hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                }
                if (this.vLiq != null)
                {
                    hashCode = (hashCode * 59) + this.vLiq.GetHashCode();
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
            // nFat (string) maxLength
            if (this.nFat != null && this.nFat.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nFat, length must be less than 60.", new [] { "nFat" });
            }

            // nFat (string) minLength
            if (this.nFat != null && this.nFat.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nFat, length must be greater than 1.", new [] { "nFat" });
            }

            yield break;
        }
    }

}
