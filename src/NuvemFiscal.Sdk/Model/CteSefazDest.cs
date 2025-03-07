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
    /// Informações do Destinatário do CT-e.  Poderá não ser informado para os CT-e de redespacho intermediário e serviço vinculado a multimodal. Nos demais casos deverá sempre ser informado.
    /// </summary>
    [DataContract(Name = "CteSefazDest")]
    public partial class CteSefazDest : IEquatable<CteSefazDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDest" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos..</param>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="iE">Inscrição Estadual.  Informar a IE do destinatário ou ISENTO se destinatário é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o destinatário não seja contribuinte do ICMS não informar o conteúdo..</param>
        /// <param name="xNome">Razão Social ou Nome do destinatário. (required).</param>
        /// <param name="fone">Telefone..</param>
        /// <param name="iSUF">Inscrição na SUFRAMA.  (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA)..</param>
        /// <param name="enderDest">enderDest (required).</param>
        /// <param name="email">Endereço de email..</param>
        public CteSefazDest(string cNPJ = default(string), string cPF = default(string), string iE = default(string), string xNome = default(string), string fone = default(string), string iSUF = default(string), CteSefazEndereco enderDest = default(CteSefazEndereco), string email = default(string))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteSefazDest and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "enderDest" is required (not null)
            if (enderDest == null)
            {
                throw new ArgumentNullException("enderDest is a required property for CteSefazDest and cannot be null");
            }
            this.enderDest = enderDest;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.IE = iE;
            this.fone = fone;
            this.ISUF = iSUF;
            this.email = email;
        }

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
        /// Inscrição Estadual.  Informar a IE do destinatário ou ISENTO se destinatário é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o destinatário não seja contribuinte do ICMS não informar o conteúdo.
        /// </summary>
        /// <value>Inscrição Estadual.  Informar a IE do destinatário ou ISENTO se destinatário é contribuinte do ICMS isento de inscrição no cadastro de contribuintes do ICMS. Caso o destinatário não seja contribuinte do ICMS não informar o conteúdo.</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Razão Social ou Nome do destinatário.
        /// </summary>
        /// <value>Razão Social ou Nome do destinatário.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        /// <value>Telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Inscrição na SUFRAMA.  (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA).
        /// </summary>
        /// <value>Inscrição na SUFRAMA.  (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA).</value>
        [DataMember(Name = "ISUF", EmitDefaultValue = true)]
        public string ISUF { get; set; }

        /// <summary>
        /// Gets or Sets enderDest
        /// </summary>
        [DataMember(Name = "enderDest", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazEndereco enderDest { get; set; }

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
            sb.Append("class CteSefazDest {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  ISUF: ").Append(ISUF).Append("\n");
            sb.Append("  enderDest: ").Append(enderDest).Append("\n");
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
            return this.Equals(input as CteSefazDest);
        }

        /// <summary>
        /// Returns true if CteSefazDest instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazDest input)
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
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
                ) && 
                (
                    this.ISUF == input.ISUF ||
                    (this.ISUF != null &&
                    this.ISUF.Equals(input.ISUF))
                ) && 
                (
                    this.enderDest == input.enderDest ||
                    (this.enderDest != null &&
                    this.enderDest.Equals(input.enderDest))
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
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.ISUF != null)
                {
                    hashCode = (hashCode * 59) + this.ISUF.GetHashCode();
                }
                if (this.enderDest != null)
                {
                    hashCode = (hashCode * 59) + this.enderDest.GetHashCode();
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
