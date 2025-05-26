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
    /// Informações das NFe.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfDoc_InfNFeSimp")]
    public partial class CteSimpSefazInfDocInfNFeSimp : IEquatable<CteSimpSefazInfDocInfNFeSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfDocInfNFeSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazInfDocInfNFeSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfDocInfNFeSimp" /> class.
        /// </summary>
        /// <param name="chave">Chave de acesso da NF-e. (required).</param>
        /// <param name="unidRat">Unidade de medida rateada (Peso,Volume)..</param>
        public CteSimpSefazInfDocInfNFeSimp(string chave = default(string), decimal? unidRat = default(decimal?))
        {
            // to ensure "chave" is required (not null)
            if (chave == null)
            {
                throw new ArgumentNullException("chave is a required property for CteSimpSefazInfDocInfNFeSimp and cannot be null");
            }
            this.chave = chave;
            this.unidRat = unidRat;
        }

        /// <summary>
        /// Chave de acesso da NF-e.
        /// </summary>
        /// <value>Chave de acesso da NF-e.</value>
        [DataMember(Name = "chave", IsRequired = true, EmitDefaultValue = true)]
        public string chave { get; set; }

        /// <summary>
        /// Unidade de medida rateada (Peso,Volume).
        /// </summary>
        /// <value>Unidade de medida rateada (Peso,Volume).</value>
        [DataMember(Name = "unidRat", EmitDefaultValue = true)]
        public decimal? unidRat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfDocInfNFeSimp {\n");
            sb.Append("  chave: ").Append(chave).Append("\n");
            sb.Append("  unidRat: ").Append(unidRat).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfDocInfNFeSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfDocInfNFeSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfDocInfNFeSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfDocInfNFeSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chave == input.chave ||
                    (this.chave != null &&
                    this.chave.Equals(input.chave))
                ) && 
                (
                    this.unidRat == input.unidRat ||
                    (this.unidRat != null &&
                    this.unidRat.Equals(input.unidRat))
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
                if (this.chave != null)
                {
                    hashCode = (hashCode * 59) + this.chave.GetHashCode();
                }
                if (this.unidRat != null)
                {
                    hashCode = (hashCode * 59) + this.unidRat.GetHashCode();
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
            // chave (string) maxLength
            if (this.chave != null && this.chave.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chave, length must be less than 44.", new [] { "chave" });
            }

            // unidRat (decimal?) minimum
            if (this.unidRat < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for unidRat, must be a value greater than or equal to 0.", new [] { "unidRat" });
            }

            yield break;
        }
    }

}
