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
    /// Informações das NF.
    /// </summary>
    [DataContract(Name = "CteSefazDetCont_InfDoc_InfNF")]
    public partial class CteSefazDetContInfDocInfNF : IEquatable<CteSefazDetContInfDocInfNF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDetContInfDocInfNF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazDetContInfDocInfNF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDetContInfDocInfNF" /> class.
        /// </summary>
        /// <param name="serie">Série. (required).</param>
        /// <param name="nDoc">Número. (required).</param>
        /// <param name="unidRat">Unidade de medida rateada (Peso,Volume)..</param>
        public CteSefazDetContInfDocInfNF(string serie = default(string), string nDoc = default(string), decimal? unidRat = default(decimal?))
        {
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for CteSefazDetContInfDocInfNF and cannot be null");
            }
            this.serie = serie;
            // to ensure "nDoc" is required (not null)
            if (nDoc == null)
            {
                throw new ArgumentNullException("nDoc is a required property for CteSefazDetContInfDocInfNF and cannot be null");
            }
            this.nDoc = nDoc;
            this.unidRat = unidRat;
        }

        /// <summary>
        /// Série.
        /// </summary>
        /// <value>Série.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "nDoc", IsRequired = true, EmitDefaultValue = true)]
        public string nDoc { get; set; }

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
            sb.Append("class CteSefazDetContInfDocInfNF {\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
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
            return this.Equals(input as CteSefazDetContInfDocInfNF);
        }

        /// <summary>
        /// Returns true if CteSefazDetContInfDocInfNF instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazDetContInfDocInfNF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazDetContInfDocInfNF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nDoc == input.nDoc ||
                    (this.nDoc != null &&
                    this.nDoc.Equals(input.nDoc))
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
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // serie (string) maxLength
            if (this.serie != null && this.serie.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, length must be less than 3.", new [] { "serie" });
            }

            // serie (string) minLength
            if (this.serie != null && this.serie.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, length must be greater than 1.", new [] { "serie" });
            }

            // nDoc (string) maxLength
            if (this.nDoc != null && this.nDoc.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDoc, length must be less than 20.", new [] { "nDoc" });
            }

            // nDoc (string) minLength
            if (this.nDoc != null && this.nDoc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDoc, length must be greater than 1.", new [] { "nDoc" });
            }

            yield break;
        }
    }

}
