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
    /// Identificação do Fisco (uso exclusivo fisco).
    /// </summary>
    [DataContract(Name = "DceSefazFisco")]
    public partial class DceSefazFisco : IEquatable<DceSefazFisco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazFisco" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazFisco() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazFisco" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ do órgão. (required).</param>
        /// <param name="xOrgao">Nome do órgão. (required).</param>
        /// <param name="uF">Sigla da UF. (required).</param>
        public DceSefazFisco(string cNPJ = default(string), string xOrgao = default(string), string uF = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for DceSefazFisco and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xOrgao" is required (not null)
            if (xOrgao == null)
            {
                throw new ArgumentNullException("xOrgao is a required property for DceSefazFisco and cannot be null");
            }
            this.xOrgao = xOrgao;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for DceSefazFisco and cannot be null");
            }
            this.UF = uF;
        }

        /// <summary>
        /// Número do CNPJ do órgão.
        /// </summary>
        /// <value>Número do CNPJ do órgão.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Nome do órgão.
        /// </summary>
        /// <value>Nome do órgão.</value>
        [DataMember(Name = "xOrgao", IsRequired = true, EmitDefaultValue = true)]
        public string xOrgao { get; set; }

        /// <summary>
        /// Sigla da UF.
        /// </summary>
        /// <value>Sigla da UF.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazFisco {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  xOrgao: ").Append(xOrgao).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
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
            return this.Equals(input as DceSefazFisco);
        }

        /// <summary>
        /// Returns true if DceSefazFisco instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazFisco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazFisco input)
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
                    this.xOrgao == input.xOrgao ||
                    (this.xOrgao != null &&
                    this.xOrgao.Equals(input.xOrgao))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
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
                if (this.xOrgao != null)
                {
                    hashCode = (hashCode * 59) + this.xOrgao.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
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
            // xOrgao (string) maxLength
            if (this.xOrgao != null && this.xOrgao.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xOrgao, length must be less than 60.", new [] { "xOrgao" });
            }

            // xOrgao (string) minLength
            if (this.xOrgao != null && this.xOrgao.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xOrgao, length must be greater than 2.", new [] { "xOrgao" });
            }

            yield break;
        }
    }

}
