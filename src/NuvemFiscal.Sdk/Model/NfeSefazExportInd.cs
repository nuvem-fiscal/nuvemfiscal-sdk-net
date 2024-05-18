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
    /// Exportação indireta.
    /// </summary>
    [DataContract(Name = "NfeSefazExportInd")]
    public partial class NfeSefazExportInd : IEquatable<NfeSefazExportInd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazExportInd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazExportInd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazExportInd" /> class.
        /// </summary>
        /// <param name="nRE">Registro de exportação. (required).</param>
        /// <param name="chNFe">Chave de acesso da NF-e recebida para exportação. (required).</param>
        /// <param name="qExport">Quantidade do item efetivamente exportado. (required).</param>
        public NfeSefazExportInd(string nRE = default(string), string chNFe = default(string), decimal? qExport = default(decimal?))
        {
            // to ensure "nRE" is required (not null)
            if (nRE == null)
            {
                throw new ArgumentNullException("nRE is a required property for NfeSefazExportInd and cannot be null");
            }
            this.nRE = nRE;
            // to ensure "chNFe" is required (not null)
            if (chNFe == null)
            {
                throw new ArgumentNullException("chNFe is a required property for NfeSefazExportInd and cannot be null");
            }
            this.chNFe = chNFe;
            // to ensure "qExport" is required (not null)
            if (qExport == null)
            {
                throw new ArgumentNullException("qExport is a required property for NfeSefazExportInd and cannot be null");
            }
            this.qExport = qExport;
        }

        /// <summary>
        /// Registro de exportação.
        /// </summary>
        /// <value>Registro de exportação.</value>
        [DataMember(Name = "nRE", IsRequired = true, EmitDefaultValue = true)]
        public string nRE { get; set; }

        /// <summary>
        /// Chave de acesso da NF-e recebida para exportação.
        /// </summary>
        /// <value>Chave de acesso da NF-e recebida para exportação.</value>
        [DataMember(Name = "chNFe", IsRequired = true, EmitDefaultValue = true)]
        public string chNFe { get; set; }

        /// <summary>
        /// Quantidade do item efetivamente exportado.
        /// </summary>
        /// <value>Quantidade do item efetivamente exportado.</value>
        [DataMember(Name = "qExport", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qExport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazExportInd {\n");
            sb.Append("  nRE: ").Append(nRE).Append("\n");
            sb.Append("  chNFe: ").Append(chNFe).Append("\n");
            sb.Append("  qExport: ").Append(qExport).Append("\n");
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
            return this.Equals(input as NfeSefazExportInd);
        }

        /// <summary>
        /// Returns true if NfeSefazExportInd instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazExportInd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazExportInd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nRE == input.nRE ||
                    (this.nRE != null &&
                    this.nRE.Equals(input.nRE))
                ) && 
                (
                    this.chNFe == input.chNFe ||
                    (this.chNFe != null &&
                    this.chNFe.Equals(input.chNFe))
                ) && 
                (
                    this.qExport == input.qExport ||
                    (this.qExport != null &&
                    this.qExport.Equals(input.qExport))
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
                if (this.nRE != null)
                {
                    hashCode = (hashCode * 59) + this.nRE.GetHashCode();
                }
                if (this.chNFe != null)
                {
                    hashCode = (hashCode * 59) + this.chNFe.GetHashCode();
                }
                if (this.qExport != null)
                {
                    hashCode = (hashCode * 59) + this.qExport.GetHashCode();
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
            // chNFe (string) maxLength
            if (this.chNFe != null && this.chNFe.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chNFe, length must be less than 44.", new [] { "chNFe" });
            }

            // qExport (decimal?) minimum
            if (this.qExport < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qExport, must be a value greater than or equal to 0.", new [] { "qExport" });
            }

            yield break;
        }
    }

}
