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
    /// Dados do endereço da ferrovia envolvida.
    /// </summary>
    [DataContract(Name = "CteSimpSefazEnderFerSimp")]
    public partial class CteSimpSefazEnderFerSimp : IEquatable<CteSimpSefazEnderFerSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazEnderFerSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazEnderFerSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazEnderFerSimp" /> class.
        /// </summary>
        /// <param name="xLgr">Logradouro. (required).</param>
        /// <param name="nro">Número..</param>
        /// <param name="xCpl">Complemento..</param>
        /// <param name="xBairro">Bairro..</param>
        /// <param name="cMun">Código do município.  Utilizar a tabela do IBGE  Informar 9999999 para operações com o exterior. (required).</param>
        /// <param name="xMun">Nome do município.  Informar EXTERIOR para operações com o exterior. (required).</param>
        /// <param name="cEP">CEP. (required).</param>
        /// <param name="uF">Sigla da UF.  Informar EX para operações com o exterior. (required).</param>
        public CteSimpSefazEnderFerSimp(string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string), string cMun = default(string), string xMun = default(string), string cEP = default(string), string uF = default(string))
        {
            // to ensure "xLgr" is required (not null)
            if (xLgr == null)
            {
                throw new ArgumentNullException("xLgr is a required property for CteSimpSefazEnderFerSimp and cannot be null");
            }
            this.xLgr = xLgr;
            // to ensure "cMun" is required (not null)
            if (cMun == null)
            {
                throw new ArgumentNullException("cMun is a required property for CteSimpSefazEnderFerSimp and cannot be null");
            }
            this.cMun = cMun;
            // to ensure "xMun" is required (not null)
            if (xMun == null)
            {
                throw new ArgumentNullException("xMun is a required property for CteSimpSefazEnderFerSimp and cannot be null");
            }
            this.xMun = xMun;
            // to ensure "cEP" is required (not null)
            if (cEP == null)
            {
                throw new ArgumentNullException("cEP is a required property for CteSimpSefazEnderFerSimp and cannot be null");
            }
            this.CEP = cEP;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for CteSimpSefazEnderFerSimp and cannot be null");
            }
            this.UF = uF;
            this.nro = nro;
            this.xCpl = xCpl;
            this.xBairro = xBairro;
        }

        /// <summary>
        /// Logradouro.
        /// </summary>
        /// <value>Logradouro.</value>
        [DataMember(Name = "xLgr", IsRequired = true, EmitDefaultValue = true)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "nro", EmitDefaultValue = true)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento.
        /// </summary>
        /// <value>Complemento.</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = true)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        /// <value>Bairro.</value>
        [DataMember(Name = "xBairro", EmitDefaultValue = true)]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do município.  Utilizar a tabela do IBGE  Informar 9999999 para operações com o exterior.
        /// </summary>
        /// <value>Código do município.  Utilizar a tabela do IBGE  Informar 9999999 para operações com o exterior.</value>
        [DataMember(Name = "cMun", IsRequired = true, EmitDefaultValue = true)]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do município.  Informar EXTERIOR para operações com o exterior.
        /// </summary>
        /// <value>Nome do município.  Informar EXTERIOR para operações com o exterior.</value>
        [DataMember(Name = "xMun", IsRequired = true, EmitDefaultValue = true)]
        public string xMun { get; set; }

        /// <summary>
        /// CEP.
        /// </summary>
        /// <value>CEP.</value>
        [DataMember(Name = "CEP", IsRequired = true, EmitDefaultValue = true)]
        public string CEP { get; set; }

        /// <summary>
        /// Sigla da UF.  Informar EX para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF.  Informar EX para operações com o exterior.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazEnderFerSimp {\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  xMun: ").Append(xMun).Append("\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
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
            return this.Equals(input as CteSimpSefazEnderFerSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazEnderFerSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazEnderFerSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazEnderFerSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xLgr == input.xLgr ||
                    (this.xLgr != null &&
                    this.xLgr.Equals(input.xLgr))
                ) && 
                (
                    this.nro == input.nro ||
                    (this.nro != null &&
                    this.nro.Equals(input.nro))
                ) && 
                (
                    this.xCpl == input.xCpl ||
                    (this.xCpl != null &&
                    this.xCpl.Equals(input.xCpl))
                ) && 
                (
                    this.xBairro == input.xBairro ||
                    (this.xBairro != null &&
                    this.xBairro.Equals(input.xBairro))
                ) && 
                (
                    this.cMun == input.cMun ||
                    (this.cMun != null &&
                    this.cMun.Equals(input.cMun))
                ) && 
                (
                    this.xMun == input.xMun ||
                    (this.xMun != null &&
                    this.xMun.Equals(input.xMun))
                ) && 
                (
                    this.CEP == input.CEP ||
                    (this.CEP != null &&
                    this.CEP.Equals(input.CEP))
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
                if (this.xLgr != null)
                {
                    hashCode = (hashCode * 59) + this.xLgr.GetHashCode();
                }
                if (this.nro != null)
                {
                    hashCode = (hashCode * 59) + this.nro.GetHashCode();
                }
                if (this.xCpl != null)
                {
                    hashCode = (hashCode * 59) + this.xCpl.GetHashCode();
                }
                if (this.xBairro != null)
                {
                    hashCode = (hashCode * 59) + this.xBairro.GetHashCode();
                }
                if (this.cMun != null)
                {
                    hashCode = (hashCode * 59) + this.cMun.GetHashCode();
                }
                if (this.xMun != null)
                {
                    hashCode = (hashCode * 59) + this.xMun.GetHashCode();
                }
                if (this.CEP != null)
                {
                    hashCode = (hashCode * 59) + this.CEP.GetHashCode();
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
            // xLgr (string) maxLength
            if (this.xLgr != null && this.xLgr.Length > 255)
            {
                yield return new ValidationResult("Invalid value for xLgr, length must be less than 255.", new [] { "xLgr" });
            }

            // xLgr (string) minLength
            if (this.xLgr != null && this.xLgr.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xLgr, length must be greater than 2.", new [] { "xLgr" });
            }

            // nro (string) maxLength
            if (this.nro != null && this.nro.Length > 60)
            {
                yield return new ValidationResult("Invalid value for nro, length must be less than 60.", new [] { "nro" });
            }

            // nro (string) minLength
            if (this.nro != null && this.nro.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nro, length must be greater than 1.", new [] { "nro" });
            }

            // xCpl (string) maxLength
            if (this.xCpl != null && this.xCpl.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xCpl, length must be less than 60.", new [] { "xCpl" });
            }

            // xCpl (string) minLength
            if (this.xCpl != null && this.xCpl.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xCpl, length must be greater than 1.", new [] { "xCpl" });
            }

            // xBairro (string) maxLength
            if (this.xBairro != null && this.xBairro.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xBairro, length must be less than 60.", new [] { "xBairro" });
            }

            // xBairro (string) minLength
            if (this.xBairro != null && this.xBairro.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xBairro, length must be greater than 2.", new [] { "xBairro" });
            }

            // xMun (string) maxLength
            if (this.xMun != null && this.xMun.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xMun, length must be less than 60.", new [] { "xMun" });
            }

            // xMun (string) minLength
            if (this.xMun != null && this.xMun.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xMun, length must be greater than 2.", new [] { "xMun" });
            }

            yield break;
        }
    }

}
