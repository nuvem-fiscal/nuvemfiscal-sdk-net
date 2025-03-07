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
    /// NfeSefazImpostoDevol
    /// </summary>
    [DataContract(Name = "NfeSefazImpostoDevol")]
    public partial class NfeSefazImpostoDevol : IEquatable<NfeSefazImpostoDevol>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazImpostoDevol" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazImpostoDevol() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazImpostoDevol" /> class.
        /// </summary>
        /// <param name="pDevol">Percentual de mercadoria devolvida. (required).</param>
        /// <param name="iPI">iPI (required).</param>
        public NfeSefazImpostoDevol(decimal? pDevol = default(decimal?), NfeSefazImpostoDevolIPI iPI = default(NfeSefazImpostoDevolIPI))
        {
            // to ensure "pDevol" is required (not null)
            if (pDevol == null)
            {
                throw new ArgumentNullException("pDevol is a required property for NfeSefazImpostoDevol and cannot be null");
            }
            this.pDevol = pDevol;
            // to ensure "iPI" is required (not null)
            if (iPI == null)
            {
                throw new ArgumentNullException("iPI is a required property for NfeSefazImpostoDevol and cannot be null");
            }
            this.IPI = iPI;
        }

        /// <summary>
        /// Percentual de mercadoria devolvida.
        /// </summary>
        /// <value>Percentual de mercadoria devolvida.</value>
        [DataMember(Name = "pDevol", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDevol { get; set; }

        /// <summary>
        /// Gets or Sets IPI
        /// </summary>
        [DataMember(Name = "IPI", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazImpostoDevolIPI IPI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazImpostoDevol {\n");
            sb.Append("  pDevol: ").Append(pDevol).Append("\n");
            sb.Append("  IPI: ").Append(IPI).Append("\n");
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
            return this.Equals(input as NfeSefazImpostoDevol);
        }

        /// <summary>
        /// Returns true if NfeSefazImpostoDevol instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazImpostoDevol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazImpostoDevol input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pDevol == input.pDevol ||
                    (this.pDevol != null &&
                    this.pDevol.Equals(input.pDevol))
                ) && 
                (
                    this.IPI == input.IPI ||
                    (this.IPI != null &&
                    this.IPI.Equals(input.IPI))
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
                if (this.pDevol != null)
                {
                    hashCode = (hashCode * 59) + this.pDevol.GetHashCode();
                }
                if (this.IPI != null)
                {
                    hashCode = (hashCode * 59) + this.IPI.GetHashCode();
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
            // pDevol (decimal?) maximum
            if (this.pDevol > (decimal?)1E+2)
            {
                yield return new ValidationResult("Invalid value for pDevol, must be a value less than or equal to 1E+2.", new [] { "pDevol" });
            }

            // pDevol (decimal?) minimum
            if (this.pDevol < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pDevol, must be a value greater than or equal to 0.", new [] { "pDevol" });
            }

            yield break;
        }
    }

}
