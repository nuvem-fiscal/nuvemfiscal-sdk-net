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
    /// Informações dos documentos dos conteiners.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfDocSimp")]
    public partial class CteSimpSefazInfDocSimp : IEquatable<CteSimpSefazInfDocSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfDocSimp" /> class.
        /// </summary>
        /// <param name="infNF">infNF.</param>
        /// <param name="infNFe">infNFe.</param>
        public CteSimpSefazInfDocSimp(List<CteSimpSefazInfNFSimp> infNF = default(List<CteSimpSefazInfNFSimp>), List<CteSimpSefazInfDocInfNFeSimp> infNFe = default(List<CteSimpSefazInfDocInfNFeSimp>))
        {
            this.infNF = infNF;
            this.infNFe = infNFe;
        }

        /// <summary>
        /// Gets or Sets infNF
        /// </summary>
        [DataMember(Name = "infNF", EmitDefaultValue = false)]
        public List<CteSimpSefazInfNFSimp> infNF { get; set; }

        /// <summary>
        /// Gets or Sets infNFe
        /// </summary>
        [DataMember(Name = "infNFe", EmitDefaultValue = false)]
        public List<CteSimpSefazInfDocInfNFeSimp> infNFe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfDocSimp {\n");
            sb.Append("  infNF: ").Append(infNF).Append("\n");
            sb.Append("  infNFe: ").Append(infNFe).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfDocSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfDocSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfDocSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfDocSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infNF == input.infNF ||
                    this.infNF != null &&
                    input.infNF != null &&
                    this.infNF.SequenceEqual(input.infNF)
                ) && 
                (
                    this.infNFe == input.infNFe ||
                    this.infNFe != null &&
                    input.infNFe != null &&
                    this.infNFe.SequenceEqual(input.infNFe)
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
                if (this.infNF != null)
                {
                    hashCode = (hashCode * 59) + this.infNF.GetHashCode();
                }
                if (this.infNFe != null)
                {
                    hashCode = (hashCode * 59) + this.infNFe.GetHashCode();
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
