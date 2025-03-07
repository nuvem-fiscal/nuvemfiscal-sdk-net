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
    /// Dados do COFINS.
    /// </summary>
    [DataContract(Name = "NfeSefazCOFINS")]
    public partial class NfeSefazCOFINS : IEquatable<NfeSefazCOFINS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINS" /> class.
        /// </summary>
        /// <param name="cOFINSAliq">cOFINSAliq.</param>
        /// <param name="cOFINSQtde">cOFINSQtde.</param>
        /// <param name="cOFINSNT">cOFINSNT.</param>
        /// <param name="cOFINSOutr">cOFINSOutr.</param>
        public NfeSefazCOFINS(NfeSefazCOFINSAliq cOFINSAliq = default(NfeSefazCOFINSAliq), NfeSefazCOFINSQtde cOFINSQtde = default(NfeSefazCOFINSQtde), NfeSefazCOFINSNT cOFINSNT = default(NfeSefazCOFINSNT), NfeSefazCOFINSOutr cOFINSOutr = default(NfeSefazCOFINSOutr))
        {
            this.COFINSAliq = cOFINSAliq;
            this.COFINSQtde = cOFINSQtde;
            this.COFINSNT = cOFINSNT;
            this.COFINSOutr = cOFINSOutr;
        }

        /// <summary>
        /// Gets or Sets COFINSAliq
        /// </summary>
        [DataMember(Name = "COFINSAliq", EmitDefaultValue = false)]
        public NfeSefazCOFINSAliq COFINSAliq { get; set; }

        /// <summary>
        /// Gets or Sets COFINSQtde
        /// </summary>
        [DataMember(Name = "COFINSQtde", EmitDefaultValue = false)]
        public NfeSefazCOFINSQtde COFINSQtde { get; set; }

        /// <summary>
        /// Gets or Sets COFINSNT
        /// </summary>
        [DataMember(Name = "COFINSNT", EmitDefaultValue = false)]
        public NfeSefazCOFINSNT COFINSNT { get; set; }

        /// <summary>
        /// Gets or Sets COFINSOutr
        /// </summary>
        [DataMember(Name = "COFINSOutr", EmitDefaultValue = false)]
        public NfeSefazCOFINSOutr COFINSOutr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCOFINS {\n");
            sb.Append("  COFINSAliq: ").Append(COFINSAliq).Append("\n");
            sb.Append("  COFINSQtde: ").Append(COFINSQtde).Append("\n");
            sb.Append("  COFINSNT: ").Append(COFINSNT).Append("\n");
            sb.Append("  COFINSOutr: ").Append(COFINSOutr).Append("\n");
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
            return this.Equals(input as NfeSefazCOFINS);
        }

        /// <summary>
        /// Returns true if NfeSefazCOFINS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCOFINS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCOFINS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.COFINSAliq == input.COFINSAliq ||
                    (this.COFINSAliq != null &&
                    this.COFINSAliq.Equals(input.COFINSAliq))
                ) && 
                (
                    this.COFINSQtde == input.COFINSQtde ||
                    (this.COFINSQtde != null &&
                    this.COFINSQtde.Equals(input.COFINSQtde))
                ) && 
                (
                    this.COFINSNT == input.COFINSNT ||
                    (this.COFINSNT != null &&
                    this.COFINSNT.Equals(input.COFINSNT))
                ) && 
                (
                    this.COFINSOutr == input.COFINSOutr ||
                    (this.COFINSOutr != null &&
                    this.COFINSOutr.Equals(input.COFINSOutr))
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
                if (this.COFINSAliq != null)
                {
                    hashCode = (hashCode * 59) + this.COFINSAliq.GetHashCode();
                }
                if (this.COFINSQtde != null)
                {
                    hashCode = (hashCode * 59) + this.COFINSQtde.GetHashCode();
                }
                if (this.COFINSNT != null)
                {
                    hashCode = (hashCode * 59) + this.COFINSNT.GetHashCode();
                }
                if (this.COFINSOutr != null)
                {
                    hashCode = (hashCode * 59) + this.COFINSOutr.GetHashCode();
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
