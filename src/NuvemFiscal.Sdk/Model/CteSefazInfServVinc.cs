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
    /// CteSefazInfServVinc
    /// </summary>
    [DataContract(Name = "CteSefazInfServVinc")]
    public partial class CteSefazInfServVinc : IEquatable<CteSefazInfServVinc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfServVinc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfServVinc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfServVinc" /> class.
        /// </summary>
        /// <param name="infCTeMultimodal">informações do CT-e multimodal vinculado. (required).</param>
        public CteSefazInfServVinc(List<CteSefazInfCTeMultimodal> infCTeMultimodal = default(List<CteSefazInfCTeMultimodal>))
        {
            // to ensure "infCTeMultimodal" is required (not null)
            if (infCTeMultimodal == null)
            {
                throw new ArgumentNullException("infCTeMultimodal is a required property for CteSefazInfServVinc and cannot be null");
            }
            this.infCTeMultimodal = infCTeMultimodal;
        }

        /// <summary>
        /// informações do CT-e multimodal vinculado.
        /// </summary>
        /// <value>informações do CT-e multimodal vinculado.</value>
        [DataMember(Name = "infCTeMultimodal", IsRequired = true, EmitDefaultValue = true)]
        public List<CteSefazInfCTeMultimodal> infCTeMultimodal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfServVinc {\n");
            sb.Append("  infCTeMultimodal: ").Append(infCTeMultimodal).Append("\n");
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
            return this.Equals(input as CteSefazInfServVinc);
        }

        /// <summary>
        /// Returns true if CteSefazInfServVinc instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfServVinc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfServVinc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infCTeMultimodal == input.infCTeMultimodal ||
                    this.infCTeMultimodal != null &&
                    input.infCTeMultimodal != null &&
                    this.infCTeMultimodal.SequenceEqual(input.infCTeMultimodal)
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
                if (this.infCTeMultimodal != null)
                {
                    hashCode = (hashCode * 59) + this.infCTeMultimodal.GetHashCode();
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
