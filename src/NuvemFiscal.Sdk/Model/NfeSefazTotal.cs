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
    /// Dados dos totais da NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazTotal")]
    public partial class NfeSefazTotal : IEquatable<NfeSefazTotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTotal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazTotal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTotal" /> class.
        /// </summary>
        /// <param name="iCMSTot">iCMSTot (required).</param>
        /// <param name="iSSQNtot">iSSQNtot.</param>
        /// <param name="retTrib">retTrib.</param>
        public NfeSefazTotal(NfeSefazICMSTot iCMSTot = default(NfeSefazICMSTot), NfeSefazISSQNtot iSSQNtot = default(NfeSefazISSQNtot), NfeSefazRetTrib retTrib = default(NfeSefazRetTrib))
        {
            // to ensure "iCMSTot" is required (not null)
            if (iCMSTot == null)
            {
                throw new ArgumentNullException("iCMSTot is a required property for NfeSefazTotal and cannot be null");
            }
            this.ICMSTot = iCMSTot;
            this.ISSQNtot = iSSQNtot;
            this.retTrib = retTrib;
        }

        /// <summary>
        /// Gets or Sets ICMSTot
        /// </summary>
        [DataMember(Name = "ICMSTot", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazICMSTot ICMSTot { get; set; }

        /// <summary>
        /// Gets or Sets ISSQNtot
        /// </summary>
        [DataMember(Name = "ISSQNtot", EmitDefaultValue = false)]
        public NfeSefazISSQNtot ISSQNtot { get; set; }

        /// <summary>
        /// Gets or Sets retTrib
        /// </summary>
        [DataMember(Name = "retTrib", EmitDefaultValue = false)]
        public NfeSefazRetTrib retTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazTotal {\n");
            sb.Append("  ICMSTot: ").Append(ICMSTot).Append("\n");
            sb.Append("  ISSQNtot: ").Append(ISSQNtot).Append("\n");
            sb.Append("  retTrib: ").Append(retTrib).Append("\n");
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
            return this.Equals(input as NfeSefazTotal);
        }

        /// <summary>
        /// Returns true if NfeSefazTotal instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazTotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazTotal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ICMSTot == input.ICMSTot ||
                    (this.ICMSTot != null &&
                    this.ICMSTot.Equals(input.ICMSTot))
                ) && 
                (
                    this.ISSQNtot == input.ISSQNtot ||
                    (this.ISSQNtot != null &&
                    this.ISSQNtot.Equals(input.ISSQNtot))
                ) && 
                (
                    this.retTrib == input.retTrib ||
                    (this.retTrib != null &&
                    this.retTrib.Equals(input.retTrib))
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
                if (this.ICMSTot != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSTot.GetHashCode();
                }
                if (this.ISSQNtot != null)
                {
                    hashCode = (hashCode * 59) + this.ISSQNtot.GetHashCode();
                }
                if (this.retTrib != null)
                {
                    hashCode = (hashCode * 59) + this.retTrib.GetHashCode();
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
            yield break;
        }
    }

}
