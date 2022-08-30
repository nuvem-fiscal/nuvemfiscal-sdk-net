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
    /// NfeSefazCobr
    /// </summary>
    [DataContract(Name = "NfeSefazCobr")]
    public partial class NfeSefazCobr : IEquatable<NfeSefazCobr>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCobr" /> class.
        /// </summary>
        /// <param name="fat">fat.</param>
        /// <param name="dup">Dados das duplicatas NT 2011/004..</param>
        public NfeSefazCobr(NfeSefazFat fat = default(NfeSefazFat), List<NfeSefazDup> dup = default(List<NfeSefazDup>))
        {
            this.fat = fat;
            this.dup = dup;
        }

        /// <summary>
        /// Gets or Sets fat
        /// </summary>
        [DataMember(Name = "fat", EmitDefaultValue = false)]
        public NfeSefazFat fat { get; set; }

        /// <summary>
        /// Dados das duplicatas NT 2011/004.
        /// </summary>
        /// <value>Dados das duplicatas NT 2011/004.</value>
        [DataMember(Name = "dup", EmitDefaultValue = false)]
        public List<NfeSefazDup> dup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCobr {\n");
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
            return this.Equals(input as NfeSefazCobr);
        }

        /// <summary>
        /// Returns true if NfeSefazCobr instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCobr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCobr input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
