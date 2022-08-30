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
    /// NfeSefazProcRef
    /// </summary>
    [DataContract(Name = "NfeSefazProcRef")]
    public partial class NfeSefazProcRef : IEquatable<NfeSefazProcRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazProcRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazProcRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazProcRef" /> class.
        /// </summary>
        /// <param name="nProc">Indentificador do processo ou ato  concessório. (required).</param>
        /// <param name="indProc">Origem do processo, informar com:  0 - SEFAZ;  1 - Justiça Federal;  2 - Justiça Estadual;  3 - Secex/RFB;  9 - Outros. (required).</param>
        public NfeSefazProcRef(string nProc = default(string), int indProc = default(int))
        {
            // to ensure "nProc" is required (not null)
            if (nProc == null)
            {
                throw new ArgumentNullException("nProc is a required property for NfeSefazProcRef and cannot be null");
            }
            this.nProc = nProc;
            this.indProc = indProc;
        }

        /// <summary>
        /// Indentificador do processo ou ato  concessório.
        /// </summary>
        /// <value>Indentificador do processo ou ato  concessório.</value>
        [DataMember(Name = "nProc", IsRequired = true, EmitDefaultValue = false)]
        public string nProc { get; set; }

        /// <summary>
        /// Origem do processo, informar com:  0 - SEFAZ;  1 - Justiça Federal;  2 - Justiça Estadual;  3 - Secex/RFB;  9 - Outros.
        /// </summary>
        /// <value>Origem do processo, informar com:  0 - SEFAZ;  1 - Justiça Federal;  2 - Justiça Estadual;  3 - Secex/RFB;  9 - Outros.</value>
        [DataMember(Name = "indProc", IsRequired = true, EmitDefaultValue = false)]
        public int indProc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazProcRef {\n");
            sb.Append("  nProc: ").Append(nProc).Append("\n");
            sb.Append("  indProc: ").Append(indProc).Append("\n");
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
            return this.Equals(input as NfeSefazProcRef);
        }

        /// <summary>
        /// Returns true if NfeSefazProcRef instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazProcRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazProcRef input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nProc == input.nProc ||
                    (this.nProc != null &&
                    this.nProc.Equals(input.nProc))
                ) && 
                (
                    this.indProc == input.indProc ||
                    this.indProc.Equals(input.indProc)
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
                if (this.nProc != null)
                {
                    hashCode = (hashCode * 59) + this.nProc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.indProc.GetHashCode();
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
