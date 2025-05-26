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
    /// Dados da cobrança do CT-e.
    /// </summary>
    [DataContract(Name = "CteOsSefazCobrOS")]
    public partial class CteOsSefazCobrOS : IEquatable<CteOsSefazCobrOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazCobrOS" /> class.
        /// </summary>
        /// <param name="fat">fat.</param>
        /// <param name="dup">dup.</param>
        public CteOsSefazCobrOS(CteOsSefazFatOS fat = default(CteOsSefazFatOS), List<CteOsSefazDupOS> dup = default(List<CteOsSefazDupOS>))
        {
            this.fat = fat;
            this.dup = dup;
        }

        /// <summary>
        /// Gets or Sets fat
        /// </summary>
        [DataMember(Name = "fat", EmitDefaultValue = false)]
        public CteOsSefazFatOS fat { get; set; }

        /// <summary>
        /// Gets or Sets dup
        /// </summary>
        [DataMember(Name = "dup", EmitDefaultValue = false)]
        public List<CteOsSefazDupOS> dup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazCobrOS {\n");
            sb.Append("  fat: ").Append(fat).Append("\n");
            sb.Append("  dup: ").Append(dup).Append("\n");
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
            return this.Equals(input as CteOsSefazCobrOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazCobrOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazCobrOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazCobrOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.fat == input.fat ||
                    (this.fat != null &&
                    this.fat.Equals(input.fat))
                ) && 
                (
                    this.dup == input.dup ||
                    this.dup != null &&
                    input.dup != null &&
                    this.dup.SequenceEqual(input.dup)
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
                if (this.fat != null)
                {
                    hashCode = (hashCode * 59) + this.fat.GetHashCode();
                }
                if (this.dup != null)
                {
                    hashCode = (hashCode * 59) + this.dup.GetHashCode();
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
