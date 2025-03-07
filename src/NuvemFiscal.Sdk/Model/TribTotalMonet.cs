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
    /// Valor monetário total aproximado dos tributos, em conformidade com o artigo 1o da Lei no 12.741/2012.
    /// </summary>
    [DataContract(Name = "TribTotalMonet")]
    public partial class TribTotalMonet : IEquatable<TribTotalMonet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TribTotalMonet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TribTotalMonet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TribTotalMonet" /> class.
        /// </summary>
        /// <param name="vTotTribFed">Valor monetário total aproximado dos tributos federais (R$). (required).</param>
        /// <param name="vTotTribEst">Valor monetário total aproximado dos tributos estaduais (R$). (required).</param>
        /// <param name="vTotTribMun">Valor monetário total aproximado dos tributos municipais (R$). (required).</param>
        public TribTotalMonet(decimal? vTotTribFed = default(decimal?), decimal? vTotTribEst = default(decimal?), decimal? vTotTribMun = default(decimal?))
        {
            // to ensure "vTotTribFed" is required (not null)
            if (vTotTribFed == null)
            {
                throw new ArgumentNullException("vTotTribFed is a required property for TribTotalMonet and cannot be null");
            }
            this.vTotTribFed = vTotTribFed;
            // to ensure "vTotTribEst" is required (not null)
            if (vTotTribEst == null)
            {
                throw new ArgumentNullException("vTotTribEst is a required property for TribTotalMonet and cannot be null");
            }
            this.vTotTribEst = vTotTribEst;
            // to ensure "vTotTribMun" is required (not null)
            if (vTotTribMun == null)
            {
                throw new ArgumentNullException("vTotTribMun is a required property for TribTotalMonet and cannot be null");
            }
            this.vTotTribMun = vTotTribMun;
        }

        /// <summary>
        /// Valor monetário total aproximado dos tributos federais (R$).
        /// </summary>
        /// <value>Valor monetário total aproximado dos tributos federais (R$).</value>
        [DataMember(Name = "vTotTribFed", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTotTribFed { get; set; }

        /// <summary>
        /// Valor monetário total aproximado dos tributos estaduais (R$).
        /// </summary>
        /// <value>Valor monetário total aproximado dos tributos estaduais (R$).</value>
        [DataMember(Name = "vTotTribEst", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTotTribEst { get; set; }

        /// <summary>
        /// Valor monetário total aproximado dos tributos municipais (R$).
        /// </summary>
        /// <value>Valor monetário total aproximado dos tributos municipais (R$).</value>
        [DataMember(Name = "vTotTribMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTotTribMun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TribTotalMonet {\n");
            sb.Append("  vTotTribFed: ").Append(vTotTribFed).Append("\n");
            sb.Append("  vTotTribEst: ").Append(vTotTribEst).Append("\n");
            sb.Append("  vTotTribMun: ").Append(vTotTribMun).Append("\n");
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
            return this.Equals(input as TribTotalMonet);
        }

        /// <summary>
        /// Returns true if TribTotalMonet instances are equal
        /// </summary>
        /// <param name="input">Instance of TribTotalMonet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TribTotalMonet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vTotTribFed == input.vTotTribFed ||
                    (this.vTotTribFed != null &&
                    this.vTotTribFed.Equals(input.vTotTribFed))
                ) && 
                (
                    this.vTotTribEst == input.vTotTribEst ||
                    (this.vTotTribEst != null &&
                    this.vTotTribEst.Equals(input.vTotTribEst))
                ) && 
                (
                    this.vTotTribMun == input.vTotTribMun ||
                    (this.vTotTribMun != null &&
                    this.vTotTribMun.Equals(input.vTotTribMun))
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
                if (this.vTotTribFed != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTribFed.GetHashCode();
                }
                if (this.vTotTribEst != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTribEst.GetHashCode();
                }
                if (this.vTotTribMun != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTribMun.GetHashCode();
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
            // vTotTribFed (decimal?) minimum
            if (this.vTotTribFed < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTotTribFed, must be a value greater than or equal to 0.", new [] { "vTotTribFed" });
            }

            // vTotTribEst (decimal?) minimum
            if (this.vTotTribEst < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTotTribEst, must be a value greater than or equal to 0.", new [] { "vTotTribEst" });
            }

            // vTotTribMun (decimal?) minimum
            if (this.vTotTribMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTotTribMun, must be a value greater than or equal to 0.", new [] { "vTotTribMun" });
            }

            yield break;
        }
    }

}
