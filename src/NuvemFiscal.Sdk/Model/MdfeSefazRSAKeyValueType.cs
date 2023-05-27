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
    /// Chave Publica no padrão XML RSA Key.
    /// </summary>
    [DataContract(Name = "MdfeSefazRSAKeyValueType")]
    public partial class MdfeSefazRSAKeyValueType : IEquatable<MdfeSefazRSAKeyValueType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazRSAKeyValueType" /> class.
        /// </summary>
        /// <param name="modulus">modulus.</param>
        /// <param name="exponent">exponent.</param>
        public MdfeSefazRSAKeyValueType(string modulus = default(string), string exponent = default(string))
        {
            this.Modulus = modulus;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Gets or Sets Modulus
        /// </summary>
        [DataMember(Name = "Modulus", EmitDefaultValue = false)]
        public string Modulus { get; set; }

        /// <summary>
        /// Gets or Sets Exponent
        /// </summary>
        [DataMember(Name = "Exponent", EmitDefaultValue = false)]
        public string Exponent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazRSAKeyValueType {\n");
            sb.Append("  Modulus: ").Append(Modulus).Append("\n");
            sb.Append("  Exponent: ").Append(Exponent).Append("\n");
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
            return this.Equals(input as MdfeSefazRSAKeyValueType);
        }

        /// <summary>
        /// Returns true if MdfeSefazRSAKeyValueType instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazRSAKeyValueType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazRSAKeyValueType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Modulus == input.Modulus ||
                    (this.Modulus != null &&
                    this.Modulus.Equals(input.Modulus))
                ) && 
                (
                    this.Exponent == input.Exponent ||
                    (this.Exponent != null &&
                    this.Exponent.Equals(input.Exponent))
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
                if (this.Modulus != null)
                {
                    hashCode = (hashCode * 59) + this.Modulus.GetHashCode();
                }
                if (this.Exponent != null)
                {
                    hashCode = (hashCode * 59) + this.Exponent.GetHashCode();
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
