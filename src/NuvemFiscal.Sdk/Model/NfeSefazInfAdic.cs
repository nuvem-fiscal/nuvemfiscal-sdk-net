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
    /// Informações adicionais da NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazInfAdic")]
    public partial class NfeSefazInfAdic : IEquatable<NfeSefazInfAdic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfAdic" /> class.
        /// </summary>
        /// <param name="infAdFisco">Informações adicionais de interesse do Fisco (v2.0)..</param>
        /// <param name="infCpl">Informações complementares de interesse do Contribuinte..</param>
        /// <param name="obsCont">obsCont.</param>
        /// <param name="obsFisco">obsFisco.</param>
        /// <param name="procRef">procRef.</param>
        public NfeSefazInfAdic(string infAdFisco = default(string), string infCpl = default(string), List<NfeSefazInfAdicObsCont> obsCont = default(List<NfeSefazInfAdicObsCont>), List<NfeSefazInfAdicObsFisco> obsFisco = default(List<NfeSefazInfAdicObsFisco>), List<NfeSefazProcRef> procRef = default(List<NfeSefazProcRef>))
        {
            this.infAdFisco = infAdFisco;
            this.infCpl = infCpl;
            this.obsCont = obsCont;
            this.obsFisco = obsFisco;
            this.procRef = procRef;
        }

        /// <summary>
        /// Informações adicionais de interesse do Fisco (v2.0).
        /// </summary>
        /// <value>Informações adicionais de interesse do Fisco (v2.0).</value>
        [DataMember(Name = "infAdFisco", EmitDefaultValue = true)]
        public string infAdFisco { get; set; }

        /// <summary>
        /// Informações complementares de interesse do Contribuinte.
        /// </summary>
        /// <value>Informações complementares de interesse do Contribuinte.</value>
        [DataMember(Name = "infCpl", EmitDefaultValue = true)]
        public string infCpl { get; set; }

        /// <summary>
        /// Gets or Sets obsCont
        /// </summary>
        [DataMember(Name = "obsCont", EmitDefaultValue = false)]
        public List<NfeSefazInfAdicObsCont> obsCont { get; set; }

        /// <summary>
        /// Gets or Sets obsFisco
        /// </summary>
        [DataMember(Name = "obsFisco", EmitDefaultValue = false)]
        public List<NfeSefazInfAdicObsFisco> obsFisco { get; set; }

        /// <summary>
        /// Gets or Sets procRef
        /// </summary>
        [DataMember(Name = "procRef", EmitDefaultValue = false)]
        public List<NfeSefazProcRef> procRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfAdic {\n");
            sb.Append("  infAdFisco: ").Append(infAdFisco).Append("\n");
            sb.Append("  infCpl: ").Append(infCpl).Append("\n");
            sb.Append("  obsCont: ").Append(obsCont).Append("\n");
            sb.Append("  obsFisco: ").Append(obsFisco).Append("\n");
            sb.Append("  procRef: ").Append(procRef).Append("\n");
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
            return this.Equals(input as NfeSefazInfAdic);
        }

        /// <summary>
        /// Returns true if NfeSefazInfAdic instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfAdic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfAdic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infAdFisco == input.infAdFisco ||
                    (this.infAdFisco != null &&
                    this.infAdFisco.Equals(input.infAdFisco))
                ) && 
                (
                    this.infCpl == input.infCpl ||
                    (this.infCpl != null &&
                    this.infCpl.Equals(input.infCpl))
                ) && 
                (
                    this.obsCont == input.obsCont ||
                    this.obsCont != null &&
                    input.obsCont != null &&
                    this.obsCont.SequenceEqual(input.obsCont)
                ) && 
                (
                    this.obsFisco == input.obsFisco ||
                    this.obsFisco != null &&
                    input.obsFisco != null &&
                    this.obsFisco.SequenceEqual(input.obsFisco)
                ) && 
                (
                    this.procRef == input.procRef ||
                    this.procRef != null &&
                    input.procRef != null &&
                    this.procRef.SequenceEqual(input.procRef)
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
                if (this.infAdFisco != null)
                {
                    hashCode = (hashCode * 59) + this.infAdFisco.GetHashCode();
                }
                if (this.infCpl != null)
                {
                    hashCode = (hashCode * 59) + this.infCpl.GetHashCode();
                }
                if (this.obsCont != null)
                {
                    hashCode = (hashCode * 59) + this.obsCont.GetHashCode();
                }
                if (this.obsFisco != null)
                {
                    hashCode = (hashCode * 59) + this.obsFisco.GetHashCode();
                }
                if (this.procRef != null)
                {
                    hashCode = (hashCode * 59) + this.procRef.GetHashCode();
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
            // infAdFisco (string) maxLength
            if (this.infAdFisco != null && this.infAdFisco.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for infAdFisco, length must be less than 2000.", new [] { "infAdFisco" });
            }

            // infAdFisco (string) minLength
            if (this.infAdFisco != null && this.infAdFisco.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infAdFisco, length must be greater than 1.", new [] { "infAdFisco" });
            }

            // infCpl (string) maxLength
            if (this.infCpl != null && this.infCpl.Length > 5000)
            {
                yield return new ValidationResult("Invalid value for infCpl, length must be less than 5000.", new [] { "infCpl" });
            }

            // infCpl (string) minLength
            if (this.infCpl != null && this.infCpl.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infCpl, length must be greater than 1.", new [] { "infCpl" });
            }

            yield break;
        }
    }

}
