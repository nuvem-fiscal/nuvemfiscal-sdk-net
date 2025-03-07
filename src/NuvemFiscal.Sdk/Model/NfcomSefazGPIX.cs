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
    /// Grupo de informações do PIX.
    /// </summary>
    [DataContract(Name = "NfcomSefazGPIX")]
    public partial class NfcomSefazGPIX : IEquatable<NfcomSefazGPIX>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGPIX" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGPIX() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGPIX" /> class.
        /// </summary>
        /// <param name="urlQRCodePIX">URL do QRCode do PIX que será apresentado na fatura. (required).</param>
        public NfcomSefazGPIX(string urlQRCodePIX = default(string))
        {
            // to ensure "urlQRCodePIX" is required (not null)
            if (urlQRCodePIX == null)
            {
                throw new ArgumentNullException("urlQRCodePIX is a required property for NfcomSefazGPIX and cannot be null");
            }
            this.urlQRCodePIX = urlQRCodePIX;
        }

        /// <summary>
        /// URL do QRCode do PIX que será apresentado na fatura.
        /// </summary>
        /// <value>URL do QRCode do PIX que será apresentado na fatura.</value>
        [DataMember(Name = "urlQRCodePIX", IsRequired = true, EmitDefaultValue = true)]
        public string urlQRCodePIX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGPIX {\n");
            sb.Append("  urlQRCodePIX: ").Append(urlQRCodePIX).Append("\n");
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
            return this.Equals(input as NfcomSefazGPIX);
        }

        /// <summary>
        /// Returns true if NfcomSefazGPIX instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGPIX to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGPIX input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.urlQRCodePIX == input.urlQRCodePIX ||
                    (this.urlQRCodePIX != null &&
                    this.urlQRCodePIX.Equals(input.urlQRCodePIX))
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
                if (this.urlQRCodePIX != null)
                {
                    hashCode = (hashCode * 59) + this.urlQRCodePIX.GetHashCode();
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
            // urlQRCodePIX (string) maxLength
            if (this.urlQRCodePIX != null && this.urlQRCodePIX.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for urlQRCodePIX, length must be less than 2000.", new [] { "urlQRCodePIX" });
            }

            // urlQRCodePIX (string) minLength
            if (this.urlQRCodePIX != null && this.urlQRCodePIX.Length < 2)
            {
                yield return new ValidationResult("Invalid value for urlQRCodePIX, length must be greater than 2.", new [] { "urlQRCodePIX" });
            }

            yield break;
        }
    }

}
