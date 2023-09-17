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
    /// Valor percentual total aproximado dos tributos, em conformidade com o artigo 1o da Lei no 12.741/2012.
    /// </summary>
    [DataContract(Name = "TribTotalPercent")]
    public partial class TribTotalPercent : IEquatable<TribTotalPercent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TribTotalPercent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TribTotalPercent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TribTotalPercent" /> class.
        /// </summary>
        /// <param name="pTotTribFed">Valor percentual total aproximado dos tributos federais (%%). (required).</param>
        /// <param name="pTotTribEst">Valor percentual total aproximado dos tributos estaduais (%%). (required).</param>
        /// <param name="pTotTribMun">Valor percentual total aproximado dos tributos municipais (%%). (required).</param>
        public TribTotalPercent(decimal? pTotTribFed = default(decimal?), decimal? pTotTribEst = default(decimal?), decimal? pTotTribMun = default(decimal?))
        {
            // to ensure "pTotTribFed" is required (not null)
            if (pTotTribFed == null)
            {
                throw new ArgumentNullException("pTotTribFed is a required property for TribTotalPercent and cannot be null");
            }
            this.pTotTribFed = pTotTribFed;
            // to ensure "pTotTribEst" is required (not null)
            if (pTotTribEst == null)
            {
                throw new ArgumentNullException("pTotTribEst is a required property for TribTotalPercent and cannot be null");
            }
            this.pTotTribEst = pTotTribEst;
            // to ensure "pTotTribMun" is required (not null)
            if (pTotTribMun == null)
            {
                throw new ArgumentNullException("pTotTribMun is a required property for TribTotalPercent and cannot be null");
            }
            this.pTotTribMun = pTotTribMun;
        }

        /// <summary>
        /// Valor percentual total aproximado dos tributos federais (%%).
        /// </summary>
        /// <value>Valor percentual total aproximado dos tributos federais (%%).</value>
        [DataMember(Name = "pTotTribFed", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pTotTribFed { get; set; }

        /// <summary>
        /// Valor percentual total aproximado dos tributos estaduais (%%).
        /// </summary>
        /// <value>Valor percentual total aproximado dos tributos estaduais (%%).</value>
        [DataMember(Name = "pTotTribEst", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pTotTribEst { get; set; }

        /// <summary>
        /// Valor percentual total aproximado dos tributos municipais (%%).
        /// </summary>
        /// <value>Valor percentual total aproximado dos tributos municipais (%%).</value>
        [DataMember(Name = "pTotTribMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pTotTribMun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TribTotalPercent {\n");
            sb.Append("  pTotTribFed: ").Append(pTotTribFed).Append("\n");
            sb.Append("  pTotTribEst: ").Append(pTotTribEst).Append("\n");
            sb.Append("  pTotTribMun: ").Append(pTotTribMun).Append("\n");
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
            return this.Equals(input as TribTotalPercent);
        }

        /// <summary>
        /// Returns true if TribTotalPercent instances are equal
        /// </summary>
        /// <param name="input">Instance of TribTotalPercent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TribTotalPercent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pTotTribFed == input.pTotTribFed ||
                    (this.pTotTribFed != null &&
                    this.pTotTribFed.Equals(input.pTotTribFed))
                ) && 
                (
                    this.pTotTribEst == input.pTotTribEst ||
                    (this.pTotTribEst != null &&
                    this.pTotTribEst.Equals(input.pTotTribEst))
                ) && 
                (
                    this.pTotTribMun == input.pTotTribMun ||
                    (this.pTotTribMun != null &&
                    this.pTotTribMun.Equals(input.pTotTribMun))
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
                if (this.pTotTribFed != null)
                {
                    hashCode = (hashCode * 59) + this.pTotTribFed.GetHashCode();
                }
                if (this.pTotTribEst != null)
                {
                    hashCode = (hashCode * 59) + this.pTotTribEst.GetHashCode();
                }
                if (this.pTotTribMun != null)
                {
                    hashCode = (hashCode * 59) + this.pTotTribMun.GetHashCode();
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
