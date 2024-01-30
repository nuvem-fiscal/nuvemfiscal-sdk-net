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
    /// Informações Adicionais.
    /// </summary>
    [DataContract(Name = "NfcomSefazInfAdic")]
    public partial class NfcomSefazInfAdic : IEquatable<NfcomSefazInfAdic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazInfAdic" /> class.
        /// </summary>
        /// <param name="infAdFisco">Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc..</param>
        /// <param name="infCpl">Informações complementares de interesse do Contribuinte..</param>
        public NfcomSefazInfAdic(string infAdFisco = default(string), List<string> infCpl = default(List<string>))
        {
            this.infAdFisco = infAdFisco;
            this.infCpl = infCpl;
        }

        /// <summary>
        /// Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc.
        /// </summary>
        /// <value>Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc.</value>
        [DataMember(Name = "infAdFisco", EmitDefaultValue = true)]
        public string infAdFisco { get; set; }

        /// <summary>
        /// Informações complementares de interesse do Contribuinte.
        /// </summary>
        /// <value>Informações complementares de interesse do Contribuinte.</value>
        [DataMember(Name = "infCpl", EmitDefaultValue = false)]
        public List<string> infCpl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazInfAdic {\n");
            sb.Append("  infAdFisco: ").Append(infAdFisco).Append("\n");
            sb.Append("  infCpl: ").Append(infCpl).Append("\n");
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
            return this.Equals(input as NfcomSefazInfAdic);
        }

        /// <summary>
        /// Returns true if NfcomSefazInfAdic instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazInfAdic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazInfAdic input)
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
                    this.infCpl != null &&
                    input.infCpl != null &&
                    this.infCpl.SequenceEqual(input.infCpl)
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
            // infAdFisco (string) maxLength
            if (this.infAdFisco != null && this.infAdFisco.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for infAdFisco, length must be less than 2000.", new [] { "infAdFisco" });
            }

            // infAdFisco (string) minLength
            if (this.infAdFisco != null && this.infAdFisco.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for infAdFisco, length must be greater than 1.", new [] { "infAdFisco" });
            }

            yield break;
        }
    }

}
