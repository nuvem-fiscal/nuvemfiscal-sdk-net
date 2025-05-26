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
    /// Informações suplementares do CT-e.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfCTeSuplSimp")]
    public partial class CteSimpSefazInfCTeSuplSimp : IEquatable<CteSimpSefazInfCTeSuplSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCTeSuplSimp" /> class.
        /// </summary>
        /// <param name="qrCodCTe">Texto com o QR-Code impresso no DACTE.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        public CteSimpSefazInfCTeSuplSimp(string qrCodCTe = default(string))
        {
            this.qrCodCTe = qrCodCTe;
        }

        /// <summary>
        /// Texto com o QR-Code impresso no DACTE.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Texto com o QR-Code impresso no DACTE.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "qrCodCTe", EmitDefaultValue = true)]
        public string qrCodCTe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfCTeSuplSimp {\n");
            sb.Append("  qrCodCTe: ").Append(qrCodCTe).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfCTeSuplSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfCTeSuplSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfCTeSuplSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfCTeSuplSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qrCodCTe == input.qrCodCTe ||
                    (this.qrCodCTe != null &&
                    this.qrCodCTe.Equals(input.qrCodCTe))
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
                if (this.qrCodCTe != null)
                {
                    hashCode = (hashCode * 59) + this.qrCodCTe.GetHashCode();
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
            // qrCodCTe (string) maxLength
            if (this.qrCodCTe != null && this.qrCodCTe.Length > 1000)
            {
                yield return new ValidationResult("Invalid value for qrCodCTe, length must be less than 1000.", new [] { "qrCodCTe" });
            }

            // qrCodCTe (string) minLength
            if (this.qrCodCTe != null && this.qrCodCTe.Length < 50)
            {
                yield return new ValidationResult("Invalid value for qrCodCTe, length must be greater than 50.", new [] { "qrCodCTe" });
            }

            yield break;
        }
    }

}
