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
    /// Documentos de Transporte Anterior.
    /// </summary>
    [DataContract(Name = "CteSefazDocAnt")]
    public partial class CteSefazDocAnt : IEquatable<CteSefazDocAnt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDocAnt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazDocAnt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDocAnt" /> class.
        /// </summary>
        /// <param name="emiDocAnt">emiDocAnt (required).</param>
        public CteSefazDocAnt(List<CteSefazEmiDocAnt> emiDocAnt = default(List<CteSefazEmiDocAnt>))
        {
            // to ensure "emiDocAnt" is required (not null)
            if (emiDocAnt == null)
            {
                throw new ArgumentNullException("emiDocAnt is a required property for CteSefazDocAnt and cannot be null");
            }
            this.emiDocAnt = emiDocAnt;
        }

        /// <summary>
        /// Gets or Sets emiDocAnt
        /// </summary>
        [DataMember(Name = "emiDocAnt", IsRequired = true, EmitDefaultValue = true)]
        public List<CteSefazEmiDocAnt> emiDocAnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazDocAnt {\n");
            sb.Append("  emiDocAnt: ").Append(emiDocAnt).Append("\n");
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
            return this.Equals(input as CteSefazDocAnt);
        }

        /// <summary>
        /// Returns true if CteSefazDocAnt instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazDocAnt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazDocAnt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.emiDocAnt == input.emiDocAnt ||
                    this.emiDocAnt != null &&
                    input.emiDocAnt != null &&
                    this.emiDocAnt.SequenceEqual(input.emiDocAnt)
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
                if (this.emiDocAnt != null)
                {
                    hashCode = (hashCode * 59) + this.emiDocAnt.GetHashCode();
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
