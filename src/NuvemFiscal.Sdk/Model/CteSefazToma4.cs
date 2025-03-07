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
    /// Indicador do \&quot;papel\&quot; do tomador do serviço no CT-e.
    /// </summary>
    [DataContract(Name = "CteSefazToma4")]
    public partial class CteSefazToma4 : IEquatable<CteSefazToma4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazToma4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazToma4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazToma4" /> class.
        /// </summary>
        /// <param name="toma">Tomador do Serviço.  Preencher com:  * 4 - Outros  Obs: Informar os dados cadastrais do tomador do serviço. (required).</param>
        /// <param name="cNPJ">Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos..</param>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="iE">Inscrição Estadual.  Informar a IE do tomador ou ISENTO se tomador é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o tomador não seja contribuinte do ICMS não informar o conteúdo..</param>
        /// <param name="xNome">Razão Social ou Nome. (required).</param>
        /// <param name="xFant">Nome Fantasia..</param>
        /// <param name="fone">Telefone..</param>
        /// <param name="enderToma">enderToma (required).</param>
        /// <param name="email">Endereço de email..</param>
        public CteSefazToma4(int? toma = default(int?), string cNPJ = default(string), string cPF = default(string), string iE = default(string), string xNome = default(string), string xFant = default(string), string fone = default(string), CteSefazEndereco enderToma = default(CteSefazEndereco), string email = default(string))
        {
            // to ensure "toma" is required (not null)
            if (toma == null)
            {
                throw new ArgumentNullException("toma is a required property for CteSefazToma4 and cannot be null");
            }
            this.toma = toma;
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteSefazToma4 and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "enderToma" is required (not null)
            if (enderToma == null)
            {
                throw new ArgumentNullException("enderToma is a required property for CteSefazToma4 and cannot be null");
            }
            this.enderToma = enderToma;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.IE = iE;
            this.xFant = xFant;
            this.fone = fone;
            this.email = email;
        }

        /// <summary>
        /// Tomador do Serviço.  Preencher com:  * 4 - Outros  Obs: Informar os dados cadastrais do tomador do serviço.
        /// </summary>
        /// <value>Tomador do Serviço.  Preencher com:  * 4 - Outros  Obs: Informar os dados cadastrais do tomador do serviço.</value>
        [DataMember(Name = "toma", IsRequired = true, EmitDefaultValue = true)]
        public int? toma { get; set; }

        /// <summary>
        /// Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Inscrição Estadual.  Informar a IE do tomador ou ISENTO se tomador é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o tomador não seja contribuinte do ICMS não informar o conteúdo.
        /// </summary>
        /// <value>Inscrição Estadual.  Informar a IE do tomador ou ISENTO se tomador é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o tomador não seja contribuinte do ICMS não informar o conteúdo.</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Razão Social ou Nome.
        /// </summary>
        /// <value>Razão Social ou Nome.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Nome Fantasia.
        /// </summary>
        /// <value>Nome Fantasia.</value>
        [DataMember(Name = "xFant", EmitDefaultValue = true)]
        public string xFant { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        /// <value>Telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Gets or Sets enderToma
        /// </summary>
        [DataMember(Name = "enderToma", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazEndereco enderToma { get; set; }

        /// <summary>
        /// Endereço de email.
        /// </summary>
        /// <value>Endereço de email.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazToma4 {\n");
            sb.Append("  toma: ").Append(toma).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  xFant: ").Append(xFant).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  enderToma: ").Append(enderToma).Append("\n");
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
            return this.Equals(input as CteSefazToma4);
        }

        /// <summary>
        /// Returns true if CteSefazToma4 instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazToma4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazToma4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.toma == input.toma ||
                    (this.toma != null &&
                    this.toma.Equals(input.toma))
                ) && 
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
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.xFant == input.xFant ||
                    (this.xFant != null &&
                    this.xFant.Equals(input.xFant))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
                ) && 
                (
                    this.enderToma == input.enderToma ||
                    (this.enderToma != null &&
                    this.enderToma.Equals(input.enderToma))
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
                if (this.toma != null)
                {
                    hashCode = (hashCode * 59) + this.toma.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.xFant != null)
                {
                    hashCode = (hashCode * 59) + this.xFant.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.enderToma != null)
                {
                    hashCode = (hashCode * 59) + this.enderToma.GetHashCode();
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

            // xFant (string) maxLength
            if (this.xFant != null && this.xFant.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xFant, length must be less than 60.", new [] { "xFant" });
            }

            // xFant (string) minLength
            if (this.xFant != null && this.xFant.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xFant, length must be greater than 2.", new [] { "xFant" });
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
