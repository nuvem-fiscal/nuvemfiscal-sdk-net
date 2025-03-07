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
    /// informações do CT-e multimodal vinculado.
    /// </summary>
    [DataContract(Name = "CteSefazInfCTeMultimodal")]
    public partial class CteSefazInfCTeMultimodal : IEquatable<CteSefazInfCTeMultimodal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCTeMultimodal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfCTeMultimodal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCTeMultimodal" /> class.
        /// </summary>
        /// <param name="chCTeMultimodal">Chave de acesso do CT-e Multimodal. (required).</param>
        public CteSefazInfCTeMultimodal(string chCTeMultimodal = default(string))
        {
            // to ensure "chCTeMultimodal" is required (not null)
            if (chCTeMultimodal == null)
            {
                throw new ArgumentNullException("chCTeMultimodal is a required property for CteSefazInfCTeMultimodal and cannot be null");
            }
            this.chCTeMultimodal = chCTeMultimodal;
        }

        /// <summary>
        /// Chave de acesso do CT-e Multimodal.
        /// </summary>
        /// <value>Chave de acesso do CT-e Multimodal.</value>
        [DataMember(Name = "chCTeMultimodal", IsRequired = true, EmitDefaultValue = true)]
        public string chCTeMultimodal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfCTeMultimodal {\n");
            sb.Append("  chCTeMultimodal: ").Append(chCTeMultimodal).Append("\n");
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
            return this.Equals(input as CteSefazInfCTeMultimodal);
        }

        /// <summary>
        /// Returns true if CteSefazInfCTeMultimodal instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfCTeMultimodal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfCTeMultimodal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCTeMultimodal == input.chCTeMultimodal ||
                    (this.chCTeMultimodal != null &&
                    this.chCTeMultimodal.Equals(input.chCTeMultimodal))
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
                if (this.chCTeMultimodal != null)
                {
                    hashCode = (hashCode * 59) + this.chCTeMultimodal.GetHashCode();
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
            // chCTeMultimodal (string) maxLength
            if (this.chCTeMultimodal != null && this.chCTeMultimodal.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chCTeMultimodal, length must be less than 44.", new [] { "chCTeMultimodal" });
            }

            yield break;
        }
    }

}
