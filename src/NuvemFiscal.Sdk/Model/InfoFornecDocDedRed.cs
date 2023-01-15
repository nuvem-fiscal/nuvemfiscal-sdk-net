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
    /// Grupo de informações do Fornecedor em Deduções de Serviços.
    /// </summary>
    [DataContract(Name = "InfoFornecDocDedRed")]
    public partial class InfoFornecDocDedRed : IEquatable<InfoFornecDocDedRed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoFornecDocDedRed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoFornecDocDedRed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoFornecDocDedRed" /> class.
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
        public InfoFornecDocDedRed(string cNPJ = default(string), string cPF = default(string), string nIF = default(string), int cNaoNIF = default(int), string cAEPF = default(string), string iM = default(string), string xNome = default(string), Endereco end = default(Endereco), string fone = default(string), string email = default(string))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for InfoFornecDocDedRed and cannot be null");
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
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.
        /// </summary>
        /// <value>Número do CPF.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior.
        /// </summary>
        /// <value>Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior.</value>
        [DataMember(Name = "NIF", EmitDefaultValue = false)]
        public string NIF { get; set; }

        /// <summary>
        /// Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF
        /// </summary>
        /// <value>Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF</value>
        [DataMember(Name = "cNaoNIF", EmitDefaultValue = false)]
        public int cNaoNIF { get; set; }

        /// <summary>
        /// Número do Cadastro de Atividade Econômica da Pessoa Física (CAEPF).
        /// </summary>
        /// <value>Número do Cadastro de Atividade Econômica da Pessoa Física (CAEPF).</value>
        [DataMember(Name = "CAEPF", EmitDefaultValue = false)]
        public string CAEPF { get; set; }

        /// <summary>
        /// Número da inscrição municipal.
        /// </summary>
        /// <value>Número da inscrição municipal.</value>
        [DataMember(Name = "IM", EmitDefaultValue = false)]
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
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// * E-mail
        /// </summary>
        /// <value>* E-mail</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoFornecDocDedRed {\n");
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
            return this.Equals(input as InfoFornecDocDedRed);
        }

        /// <summary>
        /// Returns true if InfoFornecDocDedRed instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoFornecDocDedRed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoFornecDocDedRed input)
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
                    this.cNaoNIF.Equals(input.cNaoNIF)
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
                hashCode = (hashCode * 59) + this.cNaoNIF.GetHashCode();
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
            yield break;
        }
    }

}
