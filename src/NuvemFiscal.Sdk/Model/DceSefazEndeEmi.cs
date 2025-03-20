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
    /// Endereço do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
    /// </summary>
    [DataContract(Name = "DceSefazEndeEmi")]
    public partial class DceSefazEndeEmi : IEquatable<DceSefazEndeEmi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazEndeEmi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazEndeEmi() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazEndeEmi" /> class.
        /// </summary>
        /// <param name="xLgr">Logradouro.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="nro">Número.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xCpl">Complemento.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xBairro">Bairro.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="cMun">Código do município (utilizar a tabela do IBGE).    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xMun">Nome do município.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="uF">Sigla da UF.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="cEP">CEP.  Informar zeros não significativos.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="cPais">Código do País.  * 1058&#x3D;Brasil (required).</param>
        /// <param name="xPais">Nome do País exemplo: Brasil ou BRASIL. (required).</param>
        /// <param name="fone">Telefone.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        public DceSefazEndeEmi(string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string), string cMun = default(string), string xMun = default(string), string uF = default(string), string cEP = default(string), string cPais = default(string), string xPais = default(string), string fone = default(string))
        {
            // to ensure "cPais" is required (not null)
            if (cPais == null)
            {
                throw new ArgumentNullException("cPais is a required property for DceSefazEndeEmi and cannot be null");
            }
            this.cPais = cPais;
            // to ensure "xPais" is required (not null)
            if (xPais == null)
            {
                throw new ArgumentNullException("xPais is a required property for DceSefazEndeEmi and cannot be null");
            }
            this.xPais = xPais;
            this.xLgr = xLgr;
            this.nro = nro;
            this.xCpl = xCpl;
            this.xBairro = xBairro;
            this.cMun = cMun;
            this.xMun = xMun;
            this.UF = uF;
            this.CEP = cEP;
            this.fone = fone;
        }

        /// <summary>
        /// Logradouro.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Logradouro.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xLgr", EmitDefaultValue = true)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Número.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "nro", EmitDefaultValue = true)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Complemento.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = true)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Bairro.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xBairro", EmitDefaultValue = true)]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do município (utilizar a tabela do IBGE).    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Código do município (utilizar a tabela do IBGE).    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "cMun", EmitDefaultValue = true)]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do município.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Nome do município.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xMun", EmitDefaultValue = true)]
        public string xMun { get; set; }

        /// <summary>
        /// Sigla da UF.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Sigla da UF.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "UF", EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// CEP.  Informar zeros não significativos.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>CEP.  Informar zeros não significativos.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "CEP", EmitDefaultValue = true)]
        public string CEP { get; set; }

        /// <summary>
        /// Código do País.  * 1058&#x3D;Brasil
        /// </summary>
        /// <value>Código do País.  * 1058&#x3D;Brasil</value>
        [DataMember(Name = "cPais", IsRequired = true, EmitDefaultValue = true)]
        public string cPais { get; set; }

        /// <summary>
        /// Nome do País exemplo: Brasil ou BRASIL.
        /// </summary>
        /// <value>Nome do País exemplo: Brasil ou BRASIL.</value>
        [DataMember(Name = "xPais", IsRequired = true, EmitDefaultValue = true)]
        public string xPais { get; set; }

        /// <summary>
        /// Telefone.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Telefone.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazEndeEmi {\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  xMun: ").Append(xMun).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
            sb.Append("  cPais: ").Append(cPais).Append("\n");
            sb.Append("  xPais: ").Append(xPais).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
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
            return this.Equals(input as DceSefazEndeEmi);
        }

        /// <summary>
        /// Returns true if DceSefazEndeEmi instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazEndeEmi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazEndeEmi input)
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
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.CEP == input.CEP ||
                    (this.CEP != null &&
                    this.CEP.Equals(input.CEP))
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
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.CEP != null)
                {
                    hashCode = (hashCode * 59) + this.CEP.GetHashCode();
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

            yield break;
        }
    }

}
