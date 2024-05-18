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
    /// Deduções - Taxas e Contribuições.
    /// </summary>
    [DataContract(Name = "NfeSefazDeduc")]
    public partial class NfeSefazDeduc : IEquatable<NfeSefazDeduc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDeduc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDeduc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDeduc" /> class.
        /// </summary>
        /// <param name="xDed">Descrição da Dedução. (required).</param>
        /// <param name="vDed">valor da dedução. (required).</param>
        public NfeSefazDeduc(string xDed = default(string), decimal? vDed = default(decimal?))
        {
            // to ensure "xDed" is required (not null)
            if (xDed == null)
            {
                throw new ArgumentNullException("xDed is a required property for NfeSefazDeduc and cannot be null");
            }
            this.xDed = xDed;
            // to ensure "vDed" is required (not null)
            if (vDed == null)
            {
                throw new ArgumentNullException("vDed is a required property for NfeSefazDeduc and cannot be null");
            }
            this.vDed = vDed;
        }

        /// <summary>
        /// Descrição da Dedução.
        /// </summary>
        /// <value>Descrição da Dedução.</value>
        [DataMember(Name = "xDed", IsRequired = true, EmitDefaultValue = true)]
        public string xDed { get; set; }

        /// <summary>
        /// valor da dedução.
        /// </summary>
        /// <value>valor da dedução.</value>
        [DataMember(Name = "vDed", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDeduc {\n");
            sb.Append("  xDed: ").Append(xDed).Append("\n");
            sb.Append("  vDed: ").Append(vDed).Append("\n");
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
            return this.Equals(input as NfeSefazDeduc);
        }

        /// <summary>
        /// Returns true if NfeSefazDeduc instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDeduc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDeduc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xDed == input.xDed ||
                    (this.xDed != null &&
                    this.xDed.Equals(input.xDed))
                ) && 
                (
                    this.vDed == input.vDed ||
                    (this.vDed != null &&
                    this.vDed.Equals(input.vDed))
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
                if (this.xDed != null)
                {
                    hashCode = (hashCode * 59) + this.xDed.GetHashCode();
                }
                if (this.vDed != null)
                {
                    hashCode = (hashCode * 59) + this.vDed.GetHashCode();
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
            // xDed (string) maxLength
            if (this.xDed != null && this.xDed.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDed, length must be less than 60.", new [] { "xDed" });
            }

            // xDed (string) minLength
            if (this.xDed != null && this.xDed.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDed, length must be greater than 1.", new [] { "xDed" });
            }

            // vDed (decimal?) minimum
            if (this.vDed < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vDed, must be a value greater than or equal to 0.", new [] { "vDed" });
            }

            yield break;
        }
    }

}
