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
    /// Grupo de informações das balsas.
    /// </summary>
    [DataContract(Name = "CteSefazBalsa")]
    public partial class CteSefazBalsa : IEquatable<CteSefazBalsa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazBalsa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazBalsa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazBalsa" /> class.
        /// </summary>
        /// <param name="xBalsa">Identificador da Balsa. (required).</param>
        public CteSefazBalsa(string xBalsa = default(string))
        {
            // to ensure "xBalsa" is required (not null)
            if (xBalsa == null)
            {
                throw new ArgumentNullException("xBalsa is a required property for CteSefazBalsa and cannot be null");
            }
            this.xBalsa = xBalsa;
        }

        /// <summary>
        /// Identificador da Balsa.
        /// </summary>
        /// <value>Identificador da Balsa.</value>
        [DataMember(Name = "xBalsa", IsRequired = true, EmitDefaultValue = true)]
        public string xBalsa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazBalsa {\n");
            sb.Append("  xBalsa: ").Append(xBalsa).Append("\n");
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
            return this.Equals(input as CteSefazBalsa);
        }

        /// <summary>
        /// Returns true if CteSefazBalsa instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazBalsa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazBalsa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xBalsa == input.xBalsa ||
                    (this.xBalsa != null &&
                    this.xBalsa.Equals(input.xBalsa))
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
                if (this.xBalsa != null)
                {
                    hashCode = (hashCode * 59) + this.xBalsa.GetHashCode();
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
            // xBalsa (string) maxLength
            if (this.xBalsa != null && this.xBalsa.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xBalsa, length must be less than 60.", new [] { "xBalsa" });
            }

            // xBalsa (string) minLength
            if (this.xBalsa != null && this.xBalsa.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xBalsa, length must be greater than 1.", new [] { "xBalsa" });
            }

            yield break;
        }
    }

}
