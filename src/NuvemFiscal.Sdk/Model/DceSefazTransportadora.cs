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
    /// Identificação da Transportadora (uso exclusivo Transportadora).
    /// </summary>
    [DataContract(Name = "DceSefazTransportadora")]
    public partial class DceSefazTransportadora : IEquatable<DceSefazTransportadora>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazTransportadora" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazTransportadora() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazTransportadora" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ da Transportadora. (required).</param>
        /// <param name="xNome">Razão Social ou Nome da Transportadora. (required).</param>
        public DceSefazTransportadora(string cNPJ = default(string), string xNome = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for DceSefazTransportadora and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for DceSefazTransportadora and cannot be null");
            }
            this.xNome = xNome;
        }

        /// <summary>
        /// Número do CNPJ da Transportadora.
        /// </summary>
        /// <value>Número do CNPJ da Transportadora.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Razão Social ou Nome da Transportadora.
        /// </summary>
        /// <value>Razão Social ou Nome da Transportadora.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazTransportadora {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
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
            return this.Equals(input as DceSefazTransportadora);
        }

        /// <summary>
        /// Returns true if DceSefazTransportadora instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazTransportadora to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazTransportadora input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
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
            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be less than 60.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be greater than 2.", new [] { "xNome" });
            }

            yield break;
        }
    }

}
