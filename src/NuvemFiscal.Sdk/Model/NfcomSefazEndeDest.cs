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
    /// Endereço do destinatário / assinante.
    /// </summary>
    [DataContract(Name = "NfcomSefazEndeDest")]
    public partial class NfcomSefazEndeDest : IEquatable<NfcomSefazEndeDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazEndeDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazEndeDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazEndeDest" /> class.
        /// </summary>
        /// <param name="xLgr">Logradouro. (required).</param>
        /// <param name="nro">Número. (required).</param>
        /// <param name="xCpl">Complemento..</param>
        /// <param name="xBairro">Bairro. (required).</param>
        /// <param name="cMun">Código do município (utilizar a tabela do IBGE). (required).</param>
        /// <param name="xMun">Nome do município. (required).</param>
        /// <param name="cEP">CEP.  Informar zeros não significativos. (required).</param>
        /// <param name="uF">Sigla da UF. (required).</param>
        /// <param name="cPais">Código do país.  Utilizar a tabela do BACEN..</param>
        /// <param name="xPais">Nome do país..</param>
        /// <param name="fone">Telefone..</param>
        /// <param name="email">Endereço de E-mail..</param>
        public NfcomSefazEndeDest(string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string), string cMun = default(string), string xMun = default(string), string cEP = default(string), string uF = default(string), string cPais = default(string), string xPais = default(string), string fone = default(string), string email = default(string))
        {
            // to ensure "xLgr" is required (not null)
            if (xLgr == null)
            {
                throw new ArgumentNullException("xLgr is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.xLgr = xLgr;
            // to ensure "nro" is required (not null)
            if (nro == null)
            {
                throw new ArgumentNullException("nro is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.nro = nro;
            // to ensure "xBairro" is required (not null)
            if (xBairro == null)
            {
                throw new ArgumentNullException("xBairro is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.xBairro = xBairro;
            // to ensure "cMun" is required (not null)
            if (cMun == null)
            {
                throw new ArgumentNullException("cMun is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.cMun = cMun;
            // to ensure "xMun" is required (not null)
            if (xMun == null)
            {
                throw new ArgumentNullException("xMun is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.xMun = xMun;
            // to ensure "cEP" is required (not null)
            if (cEP == null)
            {
                throw new ArgumentNullException("cEP is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.CEP = cEP;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for NfcomSefazEndeDest and cannot be null");
            }
            this.UF = uF;
            this.xCpl = xCpl;
            this.cPais = cPais;
            this.xPais = xPais;
            this.fone = fone;
            this.email = email;
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
        [DataMember(Name = "nro", IsRequired = true, EmitDefaultValue = true)]
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
        [DataMember(Name = "xBairro", IsRequired = true, EmitDefaultValue = true)]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do município (utilizar a tabela do IBGE).
        /// </summary>
        /// <value>Código do município (utilizar a tabela do IBGE).</value>
        [DataMember(Name = "cMun", IsRequired = true, EmitDefaultValue = true)]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do município.
        /// </summary>
        /// <value>Nome do município.</value>
        [DataMember(Name = "xMun", IsRequired = true, EmitDefaultValue = true)]
        public string xMun { get; set; }

        /// <summary>
        /// CEP.  Informar zeros não significativos.
        /// </summary>
        /// <value>CEP.  Informar zeros não significativos.</value>
        [DataMember(Name = "CEP", IsRequired = true, EmitDefaultValue = true)]
        public string CEP { get; set; }

        /// <summary>
        /// Sigla da UF.
        /// </summary>
        /// <value>Sigla da UF.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Código do país.  Utilizar a tabela do BACEN.
        /// </summary>
        /// <value>Código do país.  Utilizar a tabela do BACEN.</value>
        [DataMember(Name = "cPais", EmitDefaultValue = true)]
        public string cPais { get; set; }

        /// <summary>
        /// Nome do país.
        /// </summary>
        /// <value>Nome do país.</value>
        [DataMember(Name = "xPais", EmitDefaultValue = true)]
        public string xPais { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        /// <value>Telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Endereço de E-mail.
        /// </summary>
        /// <value>Endereço de E-mail.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazEndeDest {\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  xMun: ").Append(xMun).Append("\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  cPais: ").Append(cPais).Append("\n");
            sb.Append("  xPais: ").Append(xPais).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
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
            return this.Equals(input as NfcomSefazEndeDest);
        }

        /// <summary>
        /// Returns true if NfcomSefazEndeDest instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazEndeDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazEndeDest input)
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
                ) && 
                (
                    this.cPais == input.cPais ||
                    (this.cPais != null &&
                    this.cPais.Equals(input.cPais))
                ) && 
                (
                    this.xPais == input.xPais ||
                    (this.xPais != null &&
                    this.xPais.Equals(input.xPais))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
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
                if (this.cPais != null)
                {
                    hashCode = (hashCode * 59) + this.cPais.GetHashCode();
                }
                if (this.xPais != null)
                {
                    hashCode = (hashCode * 59) + this.xPais.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
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
            if (this.xLgr != null && this.xLgr.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xLgr, length must be less than 60.", new [] { "xLgr" });
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

            // xPais (string) maxLength
            if (this.xPais != null && this.xPais.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xPais, length must be less than 60.", new [] { "xPais" });
            }

            // xPais (string) minLength
            if (this.xPais != null && this.xPais.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xPais, length must be greater than 2.", new [] { "xPais" });
            }

            // email (string) maxLength
            if (this.email != null && this.email.Length > 60)
            {
                yield return new ValidationResult("Invalid value for email, length must be less than 60.", new [] { "email" });
            }

            // email (string) minLength
            if (this.email != null && this.email.Length < 1)
            {
                yield return new ValidationResult("Invalid value for email, length must be greater than 1.", new [] { "email" });
            }

            yield break;
        }
    }

}
