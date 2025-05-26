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
    /// Detalhamento do CT-e complementado.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfCteCompOS")]
    public partial class CteOsSefazInfCteCompOS : IEquatable<CteOsSefazInfCteCompOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCteCompOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfCteCompOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCteCompOS" /> class.
        /// </summary>
        /// <param name="chCTe">Chave do CT-e complementado. (required).</param>
        public CteOsSefazInfCteCompOS(string chCTe = default(string))
        {
            // to ensure "chCTe" is required (not null)
            if (chCTe == null)
            {
                throw new ArgumentNullException("chCTe is a required property for CteOsSefazInfCteCompOS and cannot be null");
            }
            this.chCTe = chCTe;
        }

        /// <summary>
        /// Chave do CT-e complementado.
        /// </summary>
        /// <value>Chave do CT-e complementado.</value>
        [DataMember(Name = "chCTe", IsRequired = true, EmitDefaultValue = true)]
        public string chCTe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfCteCompOS {\n");
            sb.Append("  chCTe: ").Append(chCTe).Append("\n");
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
            return this.Equals(input as CteOsSefazInfCteCompOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfCteCompOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfCteCompOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfCteCompOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCTe == input.chCTe ||
                    (this.chCTe != null &&
                    this.chCTe.Equals(input.chCTe))
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
                if (this.chCTe != null)
                {
                    hashCode = (hashCode * 59) + this.chCTe.GetHashCode();
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
            // chCTe (string) maxLength
            if (this.chCTe != null && this.chCTe.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chCTe, length must be less than 44.", new [] { "chCTe" });
            }

            yield break;
        }
    }

}
