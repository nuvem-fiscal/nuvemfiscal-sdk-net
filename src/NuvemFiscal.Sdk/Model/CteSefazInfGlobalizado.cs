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
    /// Informações do CT-e Globalizado.
    /// </summary>
    [DataContract(Name = "CteSefazInfGlobalizado")]
    public partial class CteSefazInfGlobalizado : IEquatable<CteSefazInfGlobalizado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfGlobalizado" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfGlobalizado() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfGlobalizado" /> class.
        /// </summary>
        /// <param name="xObs">Preencher com informações adicionais, legislação do regime especial, etc. (required).</param>
        public CteSefazInfGlobalizado(string xObs = default(string))
        {
            // to ensure "xObs" is required (not null)
            if (xObs == null)
            {
                throw new ArgumentNullException("xObs is a required property for CteSefazInfGlobalizado and cannot be null");
            }
            this.xObs = xObs;
        }

        /// <summary>
        /// Preencher com informações adicionais, legislação do regime especial, etc.
        /// </summary>
        /// <value>Preencher com informações adicionais, legislação do regime especial, etc.</value>
        [DataMember(Name = "xObs", IsRequired = true, EmitDefaultValue = true)]
        public string xObs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfGlobalizado {\n");
            sb.Append("  xObs: ").Append(xObs).Append("\n");
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
            return this.Equals(input as CteSefazInfGlobalizado);
        }

        /// <summary>
        /// Returns true if CteSefazInfGlobalizado instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfGlobalizado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfGlobalizado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xObs == input.xObs ||
                    (this.xObs != null &&
                    this.xObs.Equals(input.xObs))
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
                if (this.xObs != null)
                {
                    hashCode = (hashCode * 59) + this.xObs.GetHashCode();
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
            // xObs (string) maxLength
            if (this.xObs != null && this.xObs.Length > 256)
            {
                yield return new ValidationResult("Invalid value for xObs, length must be less than 256.", new [] { "xObs" });
            }

            // xObs (string) minLength
            if (this.xObs != null && this.xObs.Length < 15)
            {
                yield return new ValidationResult("Invalid value for xObs, length must be greater than 15.", new [] { "xObs" });
            }

            yield break;
        }
    }

}
