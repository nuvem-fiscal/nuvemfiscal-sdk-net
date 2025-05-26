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
    /// Informações das GTV-e relacionadas ao CT-e OS.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfGTVeOS")]
    public partial class CteOsSefazInfGTVeOS : IEquatable<CteOsSefazInfGTVeOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfGTVeOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfGTVeOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfGTVeOS" /> class.
        /// </summary>
        /// <param name="chCTe">Chave de acesso da GTV-e. (required).</param>
        /// <param name="comp">comp (required).</param>
        public CteOsSefazInfGTVeOS(string chCTe = default(string), List<CteOsSefazInfGTVeCompOS> comp = default(List<CteOsSefazInfGTVeCompOS>))
        {
            // to ensure "chCTe" is required (not null)
            if (chCTe == null)
            {
                throw new ArgumentNullException("chCTe is a required property for CteOsSefazInfGTVeOS and cannot be null");
            }
            this.chCTe = chCTe;
            // to ensure "comp" is required (not null)
            if (comp == null)
            {
                throw new ArgumentNullException("comp is a required property for CteOsSefazInfGTVeOS and cannot be null");
            }
            this.Comp = comp;
        }

        /// <summary>
        /// Chave de acesso da GTV-e.
        /// </summary>
        /// <value>Chave de acesso da GTV-e.</value>
        [DataMember(Name = "chCTe", IsRequired = true, EmitDefaultValue = true)]
        public string chCTe { get; set; }

        /// <summary>
        /// Gets or Sets Comp
        /// </summary>
        [DataMember(Name = "Comp", IsRequired = true, EmitDefaultValue = true)]
        public List<CteOsSefazInfGTVeCompOS> Comp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfGTVeOS {\n");
            sb.Append("  chCTe: ").Append(chCTe).Append("\n");
            sb.Append("  Comp: ").Append(Comp).Append("\n");
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
            return this.Equals(input as CteOsSefazInfGTVeOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfGTVeOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfGTVeOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfGTVeOS input)
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
                ) && 
                (
                    this.Comp == input.Comp ||
                    this.Comp != null &&
                    input.Comp != null &&
                    this.Comp.SequenceEqual(input.Comp)
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
                if (this.Comp != null)
                {
                    hashCode = (hashCode * 59) + this.Comp.GetHashCode();
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
