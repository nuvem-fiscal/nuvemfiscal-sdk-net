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
    /// Dados do PIS.
    /// </summary>
    [DataContract(Name = "NfeSefazPIS")]
    public partial class NfeSefazPIS : IEquatable<NfeSefazPIS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPIS" /> class.
        /// </summary>
        /// <param name="pISAliq">pISAliq.</param>
        /// <param name="pISQtde">pISQtde.</param>
        /// <param name="pISNT">pISNT.</param>
        /// <param name="pISOutr">pISOutr.</param>
        public NfeSefazPIS(NfeSefazPISAliq pISAliq = default(NfeSefazPISAliq), NfeSefazPISQtde pISQtde = default(NfeSefazPISQtde), NfeSefazPISNT pISNT = default(NfeSefazPISNT), NfeSefazPISOutr pISOutr = default(NfeSefazPISOutr))
        {
            this.PISAliq = pISAliq;
            this.PISQtde = pISQtde;
            this.PISNT = pISNT;
            this.PISOutr = pISOutr;
        }

        /// <summary>
        /// Gets or Sets PISAliq
        /// </summary>
        [DataMember(Name = "PISAliq", EmitDefaultValue = false)]
        public NfeSefazPISAliq PISAliq { get; set; }

        /// <summary>
        /// Gets or Sets PISQtde
        /// </summary>
        [DataMember(Name = "PISQtde", EmitDefaultValue = false)]
        public NfeSefazPISQtde PISQtde { get; set; }

        /// <summary>
        /// Gets or Sets PISNT
        /// </summary>
        [DataMember(Name = "PISNT", EmitDefaultValue = false)]
        public NfeSefazPISNT PISNT { get; set; }

        /// <summary>
        /// Gets or Sets PISOutr
        /// </summary>
        [DataMember(Name = "PISOutr", EmitDefaultValue = false)]
        public NfeSefazPISOutr PISOutr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazPIS {\n");
            sb.Append("  PISAliq: ").Append(PISAliq).Append("\n");
            sb.Append("  PISQtde: ").Append(PISQtde).Append("\n");
            sb.Append("  PISNT: ").Append(PISNT).Append("\n");
            sb.Append("  PISOutr: ").Append(PISOutr).Append("\n");
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
            return this.Equals(input as NfeSefazPIS);
        }

        /// <summary>
        /// Returns true if NfeSefazPIS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazPIS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazPIS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PISAliq == input.PISAliq ||
                    (this.PISAliq != null &&
                    this.PISAliq.Equals(input.PISAliq))
                ) && 
                (
                    this.PISQtde == input.PISQtde ||
                    (this.PISQtde != null &&
                    this.PISQtde.Equals(input.PISQtde))
                ) && 
                (
                    this.PISNT == input.PISNT ||
                    (this.PISNT != null &&
                    this.PISNT.Equals(input.PISNT))
                ) && 
                (
                    this.PISOutr == input.PISOutr ||
                    (this.PISOutr != null &&
                    this.PISOutr.Equals(input.PISOutr))
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
                if (this.PISAliq != null)
                {
                    hashCode = (hashCode * 59) + this.PISAliq.GetHashCode();
                }
                if (this.PISQtde != null)
                {
                    hashCode = (hashCode * 59) + this.PISQtde.GetHashCode();
                }
                if (this.PISNT != null)
                {
                    hashCode = (hashCode * 59) + this.PISNT.GetHashCode();
                }
                if (this.PISOutr != null)
                {
                    hashCode = (hashCode * 59) + this.PISOutr.GetHashCode();
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
            yield break;
        }
    }

}
