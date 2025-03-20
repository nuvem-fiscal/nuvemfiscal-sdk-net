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
    /// Grupo Campo de uso livre do MarketPlace.  Informar o nome do campo no atributo xCampo e o conteúdo do campo no xTexto.
    /// </summary>
    [DataContract(Name = "DceSefazObsMarketplace")]
    public partial class DceSefazObsMarketplace : IEquatable<DceSefazObsMarketplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazObsMarketplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazObsMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazObsMarketplace" /> class.
        /// </summary>
        /// <param name="xCampo">xCampo.</param>
        /// <param name="xTexto">Conteúdo do Campo. (required).</param>
        public DceSefazObsMarketplace(string xCampo = default(string), string xTexto = default(string))
        {
            // to ensure "xTexto" is required (not null)
            if (xTexto == null)
            {
                throw new ArgumentNullException("xTexto is a required property for DceSefazObsMarketplace and cannot be null");
            }
            this.xTexto = xTexto;
            this.xCampo = xCampo;
        }

        /// <summary>
        /// Gets or Sets xCampo
        /// </summary>
        [DataMember(Name = "xCampo", EmitDefaultValue = true)]
        public string xCampo { get; set; }

        /// <summary>
        /// Conteúdo do Campo.
        /// </summary>
        /// <value>Conteúdo do Campo.</value>
        [DataMember(Name = "xTexto", IsRequired = true, EmitDefaultValue = true)]
        public string xTexto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazObsMarketplace {\n");
            sb.Append("  xCampo: ").Append(xCampo).Append("\n");
            sb.Append("  xTexto: ").Append(xTexto).Append("\n");
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
            return this.Equals(input as DceSefazObsMarketplace);
        }

        /// <summary>
        /// Returns true if DceSefazObsMarketplace instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazObsMarketplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazObsMarketplace input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xCampo == input.xCampo ||
                    (this.xCampo != null &&
                    this.xCampo.Equals(input.xCampo))
                ) && 
                (
                    this.xTexto == input.xTexto ||
                    (this.xTexto != null &&
                    this.xTexto.Equals(input.xTexto))
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
                if (this.xCampo != null)
                {
                    hashCode = (hashCode * 59) + this.xCampo.GetHashCode();
                }
                if (this.xTexto != null)
                {
                    hashCode = (hashCode * 59) + this.xTexto.GetHashCode();
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
            // xTexto (string) maxLength
            if (this.xTexto != null && this.xTexto.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xTexto, length must be less than 60.", new [] { "xTexto" });
            }

            // xTexto (string) minLength
            if (this.xTexto != null && this.xTexto.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xTexto, length must be greater than 1.", new [] { "xTexto" });
            }

            yield break;
        }
    }

}
