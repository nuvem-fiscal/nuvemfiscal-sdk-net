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
    /// Informações suplementares do MDF-e.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMDFeSupl")]
    public partial class MdfeSefazInfMDFeSupl : IEquatable<MdfeSefazInfMDFeSupl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFeSupl" /> class.
        /// </summary>
        /// <param name="qrCodMDFe">Texto com o QR-Code para consulta do MDF-e.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        public MdfeSefazInfMDFeSupl(string qrCodMDFe = default(string))
        {
            this.qrCodMDFe = qrCodMDFe;
        }

        /// <summary>
        /// Texto com o QR-Code para consulta do MDF-e.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Texto com o QR-Code para consulta do MDF-e.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "qrCodMDFe", EmitDefaultValue = true)]
        public string qrCodMDFe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMDFeSupl {\n");
            sb.Append("  qrCodMDFe: ").Append(qrCodMDFe).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMDFeSupl);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMDFeSupl instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMDFeSupl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMDFeSupl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qrCodMDFe == input.qrCodMDFe ||
                    (this.qrCodMDFe != null &&
                    this.qrCodMDFe.Equals(input.qrCodMDFe))
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
                if (this.qrCodMDFe != null)
                {
                    hashCode = (hashCode * 59) + this.qrCodMDFe.GetHashCode();
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
            // qrCodMDFe (string) maxLength
            if (this.qrCodMDFe != null && this.qrCodMDFe.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qrCodMDFe, length must be less than 1000.", new [] { "qrCodMDFe" });
            }

            // qrCodMDFe (string) minLength
            if (this.qrCodMDFe != null && this.qrCodMDFe.Length < 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qrCodMDFe, length must be greater than 50.", new [] { "qrCodMDFe" });
            }

            yield break;
        }
    }

}
