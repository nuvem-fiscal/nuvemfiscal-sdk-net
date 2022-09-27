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
    /// CteSefazICMS45
    /// </summary>
    [DataContract(Name = "CteSefazICMS45")]
    public partial class CteSefazICMS45 : IEquatable<CteSefazICMS45>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMS45" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazICMS45() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMS45" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do Serviço.  Preencher com:          40 - ICMS isenção;          41 - ICMS não tributada;          51 - ICMS diferido. (required).</param>
        public CteSefazICMS45(string cST = default(string))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSefazICMS45 and cannot be null");
            }
            this.CST = cST;
        }

        /// <summary>
        /// Classificação Tributária do Serviço.  Preencher com:          40 - ICMS isenção;          41 - ICMS não tributada;          51 - ICMS diferido.
        /// </summary>
        /// <value>Classificação Tributária do Serviço.  Preencher com:          40 - ICMS isenção;          41 - ICMS não tributada;          51 - ICMS diferido.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazICMS45 {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
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
            return this.Equals(input as CteSefazICMS45);
        }

        /// <summary>
        /// Returns true if CteSefazICMS45 instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazICMS45 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazICMS45 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
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
