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
    /// Dados dos totais da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazTotal")]
    public partial class DceSefazTotal : IEquatable<DceSefazTotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazTotal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazTotal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazTotal" /> class.
        /// </summary>
        /// <param name="vDC">Valor Total da DCe. (required).</param>
        public DceSefazTotal(decimal? vDC = default(decimal?))
        {
            // to ensure "vDC" is required (not null)
            if (vDC == null)
            {
                throw new ArgumentNullException("vDC is a required property for DceSefazTotal and cannot be null");
            }
            this.vDC = vDC;
        }

        /// <summary>
        /// Valor Total da DCe.
        /// </summary>
        /// <value>Valor Total da DCe.</value>
        [DataMember(Name = "vDC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazTotal {\n");
            sb.Append("  vDC: ").Append(vDC).Append("\n");
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
            return this.Equals(input as DceSefazTotal);
        }

        /// <summary>
        /// Returns true if DceSefazTotal instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazTotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazTotal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vDC == input.vDC ||
                    (this.vDC != null &&
                    this.vDC.Equals(input.vDC))
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
                if (this.vDC != null)
                {
                    hashCode = (hashCode * 59) + this.vDC.GetHashCode();
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
            // vDC (decimal?) minimum
            if (this.vDC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDC, must be a value greater than or equal to 0.", new [] { "vDC" });
            }

            yield break;
        }
    }

}
