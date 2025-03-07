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
    /// Informação de IPI devolvido.
    /// </summary>
    [DataContract(Name = "NfeSefazImpostoDevol_IPI")]
    public partial class NfeSefazImpostoDevolIPI : IEquatable<NfeSefazImpostoDevolIPI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazImpostoDevolIPI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazImpostoDevolIPI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazImpostoDevolIPI" /> class.
        /// </summary>
        /// <param name="vIPIDevol">Valor do IPI devolvido. (required).</param>
        public NfeSefazImpostoDevolIPI(decimal? vIPIDevol = default(decimal?))
        {
            // to ensure "vIPIDevol" is required (not null)
            if (vIPIDevol == null)
            {
                throw new ArgumentNullException("vIPIDevol is a required property for NfeSefazImpostoDevolIPI and cannot be null");
            }
            this.vIPIDevol = vIPIDevol;
        }

        /// <summary>
        /// Valor do IPI devolvido.
        /// </summary>
        /// <value>Valor do IPI devolvido.</value>
        [DataMember(Name = "vIPIDevol", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIPIDevol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazImpostoDevolIPI {\n");
            sb.Append("  vIPIDevol: ").Append(vIPIDevol).Append("\n");
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
            return this.Equals(input as NfeSefazImpostoDevolIPI);
        }

        /// <summary>
        /// Returns true if NfeSefazImpostoDevolIPI instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazImpostoDevolIPI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazImpostoDevolIPI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vIPIDevol == input.vIPIDevol ||
                    (this.vIPIDevol != null &&
                    this.vIPIDevol.Equals(input.vIPIDevol))
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
                if (this.vIPIDevol != null)
                {
                    hashCode = (hashCode * 59) + this.vIPIDevol.GetHashCode();
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
            // vIPIDevol (decimal?) minimum
            if (this.vIPIDevol < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIPIDevol, must be a value greater than or equal to 0.", new [] { "vIPIDevol" });
            }

            yield break;
        }
    }

}
