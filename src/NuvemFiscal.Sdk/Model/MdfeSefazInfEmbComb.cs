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
    /// Informações das Embarcações do Comboio.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfEmbComb")]
    public partial class MdfeSefazInfEmbComb : IEquatable<MdfeSefazInfEmbComb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfEmbComb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfEmbComb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfEmbComb" /> class.
        /// </summary>
        /// <param name="cEmbComb">Código da embarcação do comboio. (required).</param>
        /// <param name="xBalsa">Identificador da Balsa. (required).</param>
        public MdfeSefazInfEmbComb(string cEmbComb = default(string), string xBalsa = default(string))
        {
            // to ensure "cEmbComb" is required (not null)
            if (cEmbComb == null)
            {
                throw new ArgumentNullException("cEmbComb is a required property for MdfeSefazInfEmbComb and cannot be null");
            }
            this.cEmbComb = cEmbComb;
            // to ensure "xBalsa" is required (not null)
            if (xBalsa == null)
            {
                throw new ArgumentNullException("xBalsa is a required property for MdfeSefazInfEmbComb and cannot be null");
            }
            this.xBalsa = xBalsa;
        }

        /// <summary>
        /// Código da embarcação do comboio.
        /// </summary>
        /// <value>Código da embarcação do comboio.</value>
        [DataMember(Name = "cEmbComb", IsRequired = true, EmitDefaultValue = true)]
        public string cEmbComb { get; set; }

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
            sb.Append("class MdfeSefazInfEmbComb {\n");
            sb.Append("  cEmbComb: ").Append(cEmbComb).Append("\n");
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
            return this.Equals(input as MdfeSefazInfEmbComb);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfEmbComb instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfEmbComb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfEmbComb input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cEmbComb == input.cEmbComb ||
                    (this.cEmbComb != null &&
                    this.cEmbComb.Equals(input.cEmbComb))
                ) && 
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
                if (this.cEmbComb != null)
                {
                    hashCode = (hashCode * 59) + this.cEmbComb.GetHashCode();
                }
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // cEmbComb (string) maxLength
            if (this.cEmbComb != null && this.cEmbComb.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cEmbComb, length must be less than 10.", new [] { "cEmbComb" });
            }

            // cEmbComb (string) minLength
            if (this.cEmbComb != null && this.cEmbComb.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cEmbComb, length must be greater than 1.", new [] { "cEmbComb" });
            }

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
