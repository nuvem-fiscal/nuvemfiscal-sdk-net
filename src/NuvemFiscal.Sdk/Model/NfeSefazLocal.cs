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
    /// NfeSefazLocal
    /// </summary>
    [DataContract(Name = "NfeSefazLocal")]
    public partial class NfeSefazLocal : IEquatable<NfeSefazLocal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazLocal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazLocal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazLocal" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ..</param>
        /// <param name="cPF">CPF (v2.0)..</param>
        /// <param name="xNome">Razão Social ou Nome do Expedidor/Recebedor..</param>
        /// <param name="xLgr">Logradouro. (required).</param>
        /// <param name="nro">Número. (required).</param>
        /// <param name="xCpl">Complemento..</param>
        /// <param name="xBairro">Bairro. (required).</param>
        /// <param name="cMun">Código do município (utilizar a tabela do IBGE). (required).</param>
        /// <param name="xMun">Nome do município. (required).</param>
        /// <param name="uF">Sigla da UF. (required).</param>
        /// <param name="cEP">CEP..</param>
        /// <param name="cPais">Código de Pais..</param>
        /// <param name="xPais">Nome do país..</param>
        /// <param name="fone">Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone..</param>
        /// <param name="email">Informar o e-mail do expedidor/Recebedor. O campo pode ser utilizado para informar o e-mail de recepção da NF-e indicada pelo expedidor..</param>
        /// <param name="iE">Inscrição Estadual (v2.0)..</param>
        public NfeSefazLocal(string cNPJ = default(string), string cPF = default(string), string xNome = default(string), string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string), int cMun = default(int), string xMun = default(string), string uF = default(string), int cEP = default(int), int cPais = default(int), string xPais = default(string), string fone = default(string), string email = default(string), string iE = default(string))
        {
            // to ensure "xLgr" is required (not null)
            if (xLgr == null)
            {
                throw new ArgumentNullException("xLgr is a required property for NfeSefazLocal and cannot be null");
            }
            this.xLgr = xLgr;
            // to ensure "nro" is required (not null)
            if (nro == null)
            {
                throw new ArgumentNullException("nro is a required property for NfeSefazLocal and cannot be null");
            }
            this.nro = nro;
            // to ensure "xBairro" is required (not null)
            if (xBairro == null)
            {
                throw new ArgumentNullException("xBairro is a required property for NfeSefazLocal and cannot be null");
            }
            this.xBairro = xBairro;
            this.cMun = cMun;
            // to ensure "xMun" is required (not null)
            if (xMun == null)
            {
                throw new ArgumentNullException("xMun is a required property for NfeSefazLocal and cannot be null");
            }
            this.xMun = xMun;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for NfeSefazLocal and cannot be null");
            }
            this.UF = uF;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.xNome = xNome;
            this.xCpl = xCpl;
            this.CEP = cEP;
            this.cPais = cPais;
            this.xPais = xPais;
            this.fone = fone;
            this.email = email;
            this.IE = iE;
        }

        /// <summary>
        /// CNPJ.
        /// </summary>
        /// <value>CNPJ.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF (v2.0).
        /// </summary>
        /// <value>CPF (v2.0).</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Razão Social ou Nome do Expedidor/Recebedor.
        /// </summary>
        /// <value>Razão Social ou Nome do Expedidor/Recebedor.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = false)]
        public string xNome { get; set; }

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
        [DataMember(Name = "xCpl", EmitDefaultValue = false)]
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
        public int cMun { get; set; }

        /// <summary>
        /// Nome do município.
        /// </summary>
        /// <value>Nome do município.</value>
        [DataMember(Name = "xMun", IsRequired = true, EmitDefaultValue = true)]
        public string xMun { get; set; }

        /// <summary>
        /// Sigla da UF.
        /// </summary>
        /// <value>Sigla da UF.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// CEP.
        /// </summary>
        /// <value>CEP.</value>
        [DataMember(Name = "CEP", EmitDefaultValue = false)]
        public int CEP { get; set; }

        /// <summary>
        /// Código de Pais.
        /// </summary>
        /// <value>Código de Pais.</value>
        [DataMember(Name = "cPais", EmitDefaultValue = false)]
        public int cPais { get; set; }

        /// <summary>
        /// Nome do país.
        /// </summary>
        /// <value>Nome do país.</value>
        [DataMember(Name = "xPais", EmitDefaultValue = false)]
        public string xPais { get; set; }

        /// <summary>
        /// Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone.
        /// </summary>
        /// <value>Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// Informar o e-mail do expedidor/Recebedor. O campo pode ser utilizado para informar o e-mail de recepção da NF-e indicada pelo expedidor.
        /// </summary>
        /// <value>Informar o e-mail do expedidor/Recebedor. O campo pode ser utilizado para informar o e-mail de recepção da NF-e indicada pelo expedidor.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>
        /// Inscrição Estadual (v2.0).
        /// </summary>
        /// <value>Inscrição Estadual (v2.0).</value>
        [DataMember(Name = "IE", EmitDefaultValue = false)]
        public string IE { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazLocal {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
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
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
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
            return this.Equals(input as NfeSefazLocal);
        }

        /// <summary>
        /// Returns true if NfeSefazLocal instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazLocal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazLocal input)
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
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
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
                    this.cMun.Equals(input.cMun)
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
                    this.CEP.Equals(input.CEP)
                ) && 
                (
                    this.cPais == input.cPais ||
                    this.cPais.Equals(input.cPais)
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
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
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
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
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
                hashCode = (hashCode * 59) + this.cMun.GetHashCode();
                if (this.xMun != null)
                {
                    hashCode = (hashCode * 59) + this.xMun.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CEP.GetHashCode();
                hashCode = (hashCode * 59) + this.cPais.GetHashCode();
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
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
