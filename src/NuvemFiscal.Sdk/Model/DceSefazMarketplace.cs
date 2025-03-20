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
    /// Identificação do Marketplace (uso exclusivo Marketplace).
    /// </summary>
    [DataContract(Name = "DceSefazMarketplace")]
    public partial class DceSefazMarketplace : IEquatable<DceSefazMarketplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazMarketplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazMarketplace" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ do Marketplace. (required).</param>
        /// <param name="xNome">Razão Social ou Nome do Marketplace. (required).</param>
        /// <param name="site">Endereço ou site do Marketplace. (required).</param>
        public DceSefazMarketplace(string cNPJ = default(string), string xNome = default(string), string site = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for DceSefazMarketplace and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for DceSefazMarketplace and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "site" is required (not null)
            if (site == null)
            {
                throw new ArgumentNullException("site is a required property for DceSefazMarketplace and cannot be null");
            }
            this.Site = site;
        }

        /// <summary>
        /// Número do CNPJ do Marketplace.
        /// </summary>
        /// <value>Número do CNPJ do Marketplace.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Razão Social ou Nome do Marketplace.
        /// </summary>
        /// <value>Razão Social ou Nome do Marketplace.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Endereço ou site do Marketplace.
        /// </summary>
        /// <value>Endereço ou site do Marketplace.</value>
        [DataMember(Name = "Site", IsRequired = true, EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazMarketplace {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
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
            return this.Equals(input as DceSefazMarketplace);
        }

        /// <summary>
        /// Returns true if DceSefazMarketplace instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazMarketplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazMarketplace input)
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
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
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
                if (this.Site != null)
                {
                    hashCode = (hashCode * 59) + this.Site.GetHashCode();
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

            // Site (string) maxLength
            if (this.Site != null && this.Site.Length > 120)
            {
                yield return new ValidationResult("Invalid value for Site, length must be less than 120.", new [] { "Site" });
            }

            // Site (string) minLength
            if (this.Site != null && this.Site.Length < 2)
            {
                yield return new ValidationResult("Invalid value for Site, length must be greater than 2.", new [] { "Site" });
            }

            yield break;
        }
    }

}
