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
    /// Grupo identificador do Processo.
    /// </summary>
    [DataContract(Name = "NfcomSefazGProc")]
    public partial class NfcomSefazGProc : IEquatable<NfcomSefazGProc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGProc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGProc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGProc" /> class.
        /// </summary>
        /// <param name="tpProc">Tipo de Processo.  * 0 - SEFAZ  * 1 - Justiça Federal  * 2 - Justiça Estadual (required).</param>
        /// <param name="nProcesso">Número do Processo. (required).</param>
        public NfcomSefazGProc(int? tpProc = default(int?), string nProcesso = default(string))
        {
            // to ensure "tpProc" is required (not null)
            if (tpProc == null)
            {
                throw new ArgumentNullException("tpProc is a required property for NfcomSefazGProc and cannot be null");
            }
            this.tpProc = tpProc;
            // to ensure "nProcesso" is required (not null)
            if (nProcesso == null)
            {
                throw new ArgumentNullException("nProcesso is a required property for NfcomSefazGProc and cannot be null");
            }
            this.nProcesso = nProcesso;
        }

        /// <summary>
        /// Tipo de Processo.  * 0 - SEFAZ  * 1 - Justiça Federal  * 2 - Justiça Estadual
        /// </summary>
        /// <value>Tipo de Processo.  * 0 - SEFAZ  * 1 - Justiça Federal  * 2 - Justiça Estadual</value>
        [DataMember(Name = "tpProc", IsRequired = true, EmitDefaultValue = true)]
        public int? tpProc { get; set; }

        /// <summary>
        /// Número do Processo.
        /// </summary>
        /// <value>Número do Processo.</value>
        [DataMember(Name = "nProcesso", IsRequired = true, EmitDefaultValue = true)]
        public string nProcesso { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGProc {\n");
            sb.Append("  tpProc: ").Append(tpProc).Append("\n");
            sb.Append("  nProcesso: ").Append(nProcesso).Append("\n");
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
            return this.Equals(input as NfcomSefazGProc);
        }

        /// <summary>
        /// Returns true if NfcomSefazGProc instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGProc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGProc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpProc == input.tpProc ||
                    (this.tpProc != null &&
                    this.tpProc.Equals(input.tpProc))
                ) && 
                (
                    this.nProcesso == input.nProcesso ||
                    (this.nProcesso != null &&
                    this.nProcesso.Equals(input.nProcesso))
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
                if (this.tpProc != null)
                {
                    hashCode = (hashCode * 59) + this.tpProc.GetHashCode();
                }
                if (this.nProcesso != null)
                {
                    hashCode = (hashCode * 59) + this.nProcesso.GetHashCode();
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
            // nProcesso (string) maxLength
            if (this.nProcesso != null && this.nProcesso.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nProcesso, length must be less than 60.", new [] { "nProcesso" });
            }

            // nProcesso (string) minLength
            if (this.nProcesso != null && this.nProcesso.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nProcesso, length must be greater than 1.", new [] { "nProcesso" });
            }

            yield break;
        }
    }

}
