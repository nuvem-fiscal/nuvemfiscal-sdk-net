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
    /// Informações relativas ao ICMS.
    /// </summary>
    [DataContract(Name = "CteSefazImp")]
    public partial class CteSefazImp : IEquatable<CteSefazImp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazImp" /> class.
        /// </summary>
        /// <param name="iCMS00">iCMS00.</param>
        /// <param name="iCMS20">iCMS20.</param>
        /// <param name="iCMS45">iCMS45.</param>
        /// <param name="iCMS60">iCMS60.</param>
        /// <param name="iCMS90">iCMS90.</param>
        /// <param name="iCMSOutraUF">iCMSOutraUF.</param>
        /// <param name="iCMSSN">iCMSSN.</param>
        public CteSefazImp(CteSefazICMS00 iCMS00 = default(CteSefazICMS00), CteSefazICMS20 iCMS20 = default(CteSefazICMS20), CteSefazICMS45 iCMS45 = default(CteSefazICMS45), CteSefazICMS60 iCMS60 = default(CteSefazICMS60), CteSefazICMS90 iCMS90 = default(CteSefazICMS90), CteSefazICMSOutraUF iCMSOutraUF = default(CteSefazICMSOutraUF), CteSefazICMSSN iCMSSN = default(CteSefazICMSSN))
        {
            this.ICMS00 = iCMS00;
            this.ICMS20 = iCMS20;
            this.ICMS45 = iCMS45;
            this.ICMS60 = iCMS60;
            this.ICMS90 = iCMS90;
            this.ICMSOutraUF = iCMSOutraUF;
            this.ICMSSN = iCMSSN;
        }

        /// <summary>
        /// Gets or Sets ICMS00
        /// </summary>
        [DataMember(Name = "ICMS00", EmitDefaultValue = false)]
        public CteSefazICMS00 ICMS00 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS20
        /// </summary>
        [DataMember(Name = "ICMS20", EmitDefaultValue = false)]
        public CteSefazICMS20 ICMS20 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS45
        /// </summary>
        [DataMember(Name = "ICMS45", EmitDefaultValue = false)]
        public CteSefazICMS45 ICMS45 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS60
        /// </summary>
        [DataMember(Name = "ICMS60", EmitDefaultValue = false)]
        public CteSefazICMS60 ICMS60 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS90
        /// </summary>
        [DataMember(Name = "ICMS90", EmitDefaultValue = false)]
        public CteSefazICMS90 ICMS90 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSOutraUF
        /// </summary>
        [DataMember(Name = "ICMSOutraUF", EmitDefaultValue = false)]
        public CteSefazICMSOutraUF ICMSOutraUF { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN
        /// </summary>
        [DataMember(Name = "ICMSSN", EmitDefaultValue = false)]
        public CteSefazICMSSN ICMSSN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazImp {\n");
            sb.Append("  ICMS00: ").Append(ICMS00).Append("\n");
            sb.Append("  ICMS20: ").Append(ICMS20).Append("\n");
            sb.Append("  ICMS45: ").Append(ICMS45).Append("\n");
            sb.Append("  ICMS60: ").Append(ICMS60).Append("\n");
            sb.Append("  ICMS90: ").Append(ICMS90).Append("\n");
            sb.Append("  ICMSOutraUF: ").Append(ICMSOutraUF).Append("\n");
            sb.Append("  ICMSSN: ").Append(ICMSSN).Append("\n");
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
            return this.Equals(input as CteSefazImp);
        }

        /// <summary>
        /// Returns true if CteSefazImp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazImp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazImp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ICMS00 == input.ICMS00 ||
                    (this.ICMS00 != null &&
                    this.ICMS00.Equals(input.ICMS00))
                ) && 
                (
                    this.ICMS20 == input.ICMS20 ||
                    (this.ICMS20 != null &&
                    this.ICMS20.Equals(input.ICMS20))
                ) && 
                (
                    this.ICMS45 == input.ICMS45 ||
                    (this.ICMS45 != null &&
                    this.ICMS45.Equals(input.ICMS45))
                ) && 
                (
                    this.ICMS60 == input.ICMS60 ||
                    (this.ICMS60 != null &&
                    this.ICMS60.Equals(input.ICMS60))
                ) && 
                (
                    this.ICMS90 == input.ICMS90 ||
                    (this.ICMS90 != null &&
                    this.ICMS90.Equals(input.ICMS90))
                ) && 
                (
                    this.ICMSOutraUF == input.ICMSOutraUF ||
                    (this.ICMSOutraUF != null &&
                    this.ICMSOutraUF.Equals(input.ICMSOutraUF))
                ) && 
                (
                    this.ICMSSN == input.ICMSSN ||
                    (this.ICMSSN != null &&
                    this.ICMSSN.Equals(input.ICMSSN))
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
                if (this.ICMS00 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS00.GetHashCode();
                }
                if (this.ICMS20 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS20.GetHashCode();
                }
                if (this.ICMS45 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS45.GetHashCode();
                }
                if (this.ICMS60 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS60.GetHashCode();
                }
                if (this.ICMS90 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS90.GetHashCode();
                }
                if (this.ICMSOutraUF != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSOutraUF.GetHashCode();
                }
                if (this.ICMSSN != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN.GetHashCode();
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
