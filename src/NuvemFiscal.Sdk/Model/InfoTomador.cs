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
    /// Grupo de informações do DPS relativas ao Tomador de Serviços.
    /// </summary>
    [DataContract(Name = "InfoTomador")]
    public partial class InfoTomador : IEquatable<InfoTomador>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoTomador" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoTomador() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoTomador" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ..</param>
        /// <param name="cPF">Número do CPF..</param>
        /// <param name="nIF">Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior..</param>
        /// <param name="cNaoNIF">Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF.</param>
        /// <param name="cAEPF">Número do Cadastro de Atividade Econômica da Pessoa Física (CAEPF)..</param>
        /// <param name="iM">Número da inscrição municipal..</param>
        /// <param name="xNome">Nome/Nome Empresarial. (required).</param>
        /// <param name="end">end.</param>
        /// <param name="fone">Número do telefone do prestador:  Preencher com o Código DDD + número do telefone.  Nas operações com exterior é permitido informar o código do país + código da localidade + número do telefone)..</param>
        /// <param name="email">* E-mail.</param>
        public InfoTomador(string cNPJ = default(string), string cPF = default(string), string nIF = default(string), int? cNaoNIF = default(int?), string cAEPF = default(string), string iM = default(string), string xNome = default(string), Endereco end = default(Endereco), string fone = default(string), string email = default(string))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for InfoTomador and cannot be null");
            }
            this.xNome = xNome;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.NIF = nIF;
            this.cNaoNIF = cNaoNIF;
            this.CAEPF = cAEPF;
            this.IM = iM;
            this.end = end;
            this.fone = fone;
            this.email = email;
        }

        /// <summary>
        /// Número do CNPJ.
        /// </summary>
        /// <value>Número do CNPJ.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.
        /// </summary>
        /// <value>Número do CPF.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior.
        /// </summary>
        /// <value>Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior.</value>
        [DataMember(Name = "NIF", EmitDefaultValue = true)]
        public string NIF { get; set; }

        /// <summary>
        /// Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF
        /// </summary>
        /// <value>Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF</value>
        [DataMember(Name = "cNaoNIF", EmitDefaultValue = true)]
        public int? cNaoNIF { get; set; }

        /// <summary>
        /// Número do Cadastro de Atividade Econômica da Pessoa Física (CAEPF).
        /// </summary>
        /// <value>Número do Cadastro de Atividade Econômica da Pessoa Física (CAEPF).</value>
        [DataMember(Name = "CAEPF", EmitDefaultValue = true)]
        public string CAEPF { get; set; }

        /// <summary>
        /// Número da inscrição municipal.
        /// </summary>
        /// <value>Número da inscrição municipal.</value>
        [DataMember(Name = "IM", EmitDefaultValue = true)]
        public string IM { get; set; }

        /// <summary>
        /// Nome/Nome Empresarial.
        /// </summary>
        /// <value>Nome/Nome Empresarial.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Gets or Sets end
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public Endereco end { get; set; }

        /// <summary>
        /// Número do telefone do prestador:  Preencher com o Código DDD + número do telefone.  Nas operações com exterior é permitido informar o código do país + código da localidade + número do telefone).
        /// </summary>
        /// <value>Número do telefone do prestador:  Preencher com o Código DDD + número do telefone.  Nas operações com exterior é permitido informar o código do país + código da localidade + número do telefone).</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// * E-mail
        /// </summary>
        /// <value>* E-mail</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoTomador {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  NIF: ").Append(NIF).Append("\n");
            sb.Append("  cNaoNIF: ").Append(cNaoNIF).Append("\n");
            sb.Append("  CAEPF: ").Append(CAEPF).Append("\n");
            sb.Append("  IM: ").Append(IM).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  end: ").Append(end).Append("\n");
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
            return this.Equals(input as InfoTomador);
        }

        /// <summary>
        /// Returns true if InfoTomador instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoTomador to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoTomador input)
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
                    this.NIF == input.NIF ||
                    (this.NIF != null &&
                    this.NIF.Equals(input.NIF))
                ) && 
                (
                    this.cNaoNIF == input.cNaoNIF ||
                    (this.cNaoNIF != null &&
                    this.cNaoNIF.Equals(input.cNaoNIF))
                ) && 
                (
                    this.CAEPF == input.CAEPF ||
                    (this.CAEPF != null &&
                    this.CAEPF.Equals(input.CAEPF))
                ) && 
                (
                    this.IM == input.IM ||
                    (this.IM != null &&
                    this.IM.Equals(input.IM))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.end == input.end ||
                    (this.end != null &&
                    this.end.Equals(input.end))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.NIF != null)
                {
                    hashCode = (hashCode * 59) + this.NIF.GetHashCode();
                }
                if (this.cNaoNIF != null)
                {
                    hashCode = (hashCode * 59) + this.cNaoNIF.GetHashCode();
                }
                if (this.CAEPF != null)
                {
                    hashCode = (hashCode * 59) + this.CAEPF.GetHashCode();
                }
                if (this.IM != null)
                {
                    hashCode = (hashCode * 59) + this.IM.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.end != null)
                {
                    hashCode = (hashCode * 59) + this.end.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // CPF (string) maxLength
            if (this.CPF != null && this.CPF.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CPF, length must be less than 11.", new [] { "CPF" });
            }

            // NIF (string) maxLength
            if (this.NIF != null && this.NIF.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NIF, length must be less than 40.", new [] { "NIF" });
            }

            // NIF (string) minLength
            if (this.NIF != null && this.NIF.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NIF, length must be greater than 1.", new [] { "NIF" });
            }

            // CAEPF (string) maxLength
            if (this.CAEPF != null && this.CAEPF.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CAEPF, length must be less than 14.", new [] { "CAEPF" });
            }

            // IM (string) maxLength
            if (this.IM != null && this.IM.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IM, length must be less than 15.", new [] { "IM" });
            }

            // IM (string) minLength
            if (this.IM != null && this.IM.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IM, length must be greater than 1.", new [] { "IM" });
            }

            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be less than 300.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be greater than 1.", new [] { "xNome" });
            }

            // email (string) maxLength
            if (this.email != null && this.email.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for email, length must be less than 80.", new [] { "email" });
            }

            // email (string) minLength
            if (this.email != null && this.email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for email, length must be greater than 1.", new [] { "email" });
            }

            yield break;
        }
    }

}
