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
    /// Grupo de informações relativas aos descontos condicionados e incondicionados.
    /// </summary>
    [DataContract(Name = "VDescCondIncond")]
    public partial class VDescCondIncond : IEquatable<VDescCondIncond>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VDescCondIncond" /> class.
        /// </summary>
        /// <param name="vDescIncond">Valor monetário do desconto incondicionado (R$)..</param>
        /// <param name="vDescCond">Valor monetário do desconto condicionado (R$)..</param>
        public VDescCondIncond(decimal? vDescIncond = default(decimal?), decimal? vDescCond = default(decimal?))
        {
            this.vDescIncond = vDescIncond;
            this.vDescCond = vDescCond;
        }

        /// <summary>
        /// Valor monetário do desconto incondicionado (R$).
        /// </summary>
        /// <value>Valor monetário do desconto incondicionado (R$).</value>
        [DataMember(Name = "vDescIncond", EmitDefaultValue = true)]
        public decimal? vDescIncond { get; set; }

        /// <summary>
        /// Valor monetário do desconto condicionado (R$).
        /// </summary>
        /// <value>Valor monetário do desconto condicionado (R$).</value>
        [DataMember(Name = "vDescCond", EmitDefaultValue = true)]
        public decimal? vDescCond { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VDescCondIncond {\n");
            sb.Append("  vDescIncond: ").Append(vDescIncond).Append("\n");
            sb.Append("  vDescCond: ").Append(vDescCond).Append("\n");
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
            return this.Equals(input as VDescCondIncond);
        }

        /// <summary>
        /// Returns true if VDescCondIncond instances are equal
        /// </summary>
        /// <param name="input">Instance of VDescCondIncond to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VDescCondIncond input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vDescIncond == input.vDescIncond ||
                    (this.vDescIncond != null &&
                    this.vDescIncond.Equals(input.vDescIncond))
                ) && 
                (
                    this.vDescCond == input.vDescCond ||
                    (this.vDescCond != null &&
                    this.vDescCond.Equals(input.vDescCond))
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
                if (this.vDescIncond != null)
                {
                    hashCode = (hashCode * 59) + this.vDescIncond.GetHashCode();
                }
                if (this.vDescCond != null)
                {
                    hashCode = (hashCode * 59) + this.vDescCond.GetHashCode();
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
            // vDescIncond (decimal?) minimum
            if (this.vDescIncond < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDescIncond, must be a value greater than or equal to 0.", new [] { "vDescIncond" });
            }

            // vDescCond (decimal?) minimum
            if (this.vDescCond < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDescCond, must be a value greater than or equal to 0.", new [] { "vDescCond" });
            }

            yield break;
        }
    }

}
