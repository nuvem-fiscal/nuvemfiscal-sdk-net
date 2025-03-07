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
    /// Informações suplementares Nota Fiscal.
    /// </summary>
    [DataContract(Name = "NfeSefazInfNFeSupl")]
    public partial class NfeSefazInfNFeSupl : IEquatable<NfeSefazInfNFeSupl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfNFeSupl" /> class.
        /// </summary>
        /// <param name="qrCode">Texto com o QR-Code impresso no DANFE NFC-e.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="urlChave">Informar a URL da \&quot;Consulta por chave de acesso da NFC-e\&quot;. A mesma URL que deve estar informada no DANFE NFC-e para consulta por chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        public NfeSefazInfNFeSupl(string qrCode = default(string), string urlChave = default(string))
        {
            this.qrCode = qrCode;
            this.urlChave = urlChave;
        }

        /// <summary>
        /// Texto com o QR-Code impresso no DANFE NFC-e.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Texto com o QR-Code impresso no DANFE NFC-e.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "qrCode", EmitDefaultValue = true)]
        public string qrCode { get; set; }

        /// <summary>
        /// Informar a URL da \&quot;Consulta por chave de acesso da NFC-e\&quot;. A mesma URL que deve estar informada no DANFE NFC-e para consulta por chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Informar a URL da \&quot;Consulta por chave de acesso da NFC-e\&quot;. A mesma URL que deve estar informada no DANFE NFC-e para consulta por chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "urlChave", EmitDefaultValue = true)]
        public string urlChave { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfNFeSupl {\n");
            sb.Append("  qrCode: ").Append(qrCode).Append("\n");
            sb.Append("  urlChave: ").Append(urlChave).Append("\n");
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
            return this.Equals(input as NfeSefazInfNFeSupl);
        }

        /// <summary>
        /// Returns true if NfeSefazInfNFeSupl instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfNFeSupl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfNFeSupl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qrCode == input.qrCode ||
                    (this.qrCode != null &&
                    this.qrCode.Equals(input.qrCode))
                ) && 
                (
                    this.urlChave == input.urlChave ||
                    (this.urlChave != null &&
                    this.urlChave.Equals(input.urlChave))
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
                if (this.qrCode != null)
                {
                    hashCode = (hashCode * 59) + this.qrCode.GetHashCode();
                }
                if (this.urlChave != null)
                {
                    hashCode = (hashCode * 59) + this.urlChave.GetHashCode();
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
            // qrCode (string) maxLength
            if (this.qrCode != null && this.qrCode.Length > 600)
            {
                yield return new ValidationResult("Invalid value for qrCode, length must be less than 600.", new [] { "qrCode" });
            }

            // qrCode (string) minLength
            if (this.qrCode != null && this.qrCode.Length < 100)
            {
                yield return new ValidationResult("Invalid value for qrCode, length must be greater than 100.", new [] { "qrCode" });
            }

            // urlChave (string) maxLength
            if (this.urlChave != null && this.urlChave.Length > 85)
            {
                yield return new ValidationResult("Invalid value for urlChave, length must be less than 85.", new [] { "urlChave" });
            }

            // urlChave (string) minLength
            if (this.urlChave != null && this.urlChave.Length < 21)
            {
                yield return new ValidationResult("Invalid value for urlChave, length must be greater than 21.", new [] { "urlChave" });
            }

            yield break;
        }
    }

}
