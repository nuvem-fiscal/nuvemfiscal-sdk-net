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
    /// Grupo de observações de uso livre (para o item da NF-e).
    /// </summary>
    [DataContract(Name = "NfeSefazObsItem")]
    public partial class NfeSefazObsItem : IEquatable<NfeSefazObsItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazObsItem" /> class.
        /// </summary>
        /// <param name="obsCont">obsCont.</param>
        /// <param name="obsFisco">obsFisco.</param>
        public NfeSefazObsItem(NfeSefazObsCont obsCont = default(NfeSefazObsCont), NfeSefazObsFisco obsFisco = default(NfeSefazObsFisco))
        {
            this.obsCont = obsCont;
            this.obsFisco = obsFisco;
        }

        /// <summary>
        /// Gets or Sets obsCont
        /// </summary>
        [DataMember(Name = "obsCont", EmitDefaultValue = false)]
        public NfeSefazObsCont obsCont { get; set; }

        /// <summary>
        /// Gets or Sets obsFisco
        /// </summary>
        [DataMember(Name = "obsFisco", EmitDefaultValue = false)]
        public NfeSefazObsFisco obsFisco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazObsItem {\n");
            sb.Append("  obsCont: ").Append(obsCont).Append("\n");
            sb.Append("  obsFisco: ").Append(obsFisco).Append("\n");
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
            return this.Equals(input as NfeSefazObsItem);
        }

        /// <summary>
        /// Returns true if NfeSefazObsItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazObsItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazObsItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.obsCont == input.obsCont ||
                    (this.obsCont != null &&
                    this.obsCont.Equals(input.obsCont))
                ) && 
                (
                    this.obsFisco == input.obsFisco ||
                    (this.obsFisco != null &&
                    this.obsFisco.Equals(input.obsFisco))
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
                if (this.obsCont != null)
                {
                    hashCode = (hashCode * 59) + this.obsCont.GetHashCode();
                }
                if (this.obsFisco != null)
                {
                    hashCode = (hashCode * 59) + this.obsFisco.GetHashCode();
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
