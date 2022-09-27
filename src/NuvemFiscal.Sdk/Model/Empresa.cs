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
    /// Empresa
    /// </summary>
    [DataContract(Name = "Empresa")]
    public partial class Empresa : IEquatable<Empresa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Empresa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Empresa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Empresa" /> class.
        /// </summary>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.  Utilize o valor sem máscara. (required).</param>
        /// <param name="createdAt">Data e hora que o objeto foi criado.  A Nuvem Fiscal gerencia esse campo automaticamente..</param>
        /// <param name="updatedAt">Data e hora que o objeto foi alterado pela última vez.  A Nuvem Fiscal gerencia esse campo automaticamente..</param>
        /// <param name="inscricaoEstadual">Inscrição estadual da empresa..</param>
        /// <param name="inscricaoMunicipal">Inscrição municipal da empresa..</param>
        /// <param name="nomeRazaoSocial">Razão social da empresa. (required).</param>
        /// <param name="nomeFantasia">Nome fantasia da empresa..</param>
        /// <param name="fone">Telefone da empresa..</param>
        /// <param name="email">Email da empresa. (required).</param>
        /// <param name="endereco">endereco (required).</param>
        /// <param name="optanteSimplesNacional">Optante pelo simples nacional..</param>
        /// <param name="regimeTributacao">Regime Tributário da Empresa:  0 - Nenhum  1 - Simples Nacional  2 - Simples Nacional - Excesso  3 - Normal - Lucro Presumido  4 - Normal - Lucro Real (required).</param>
        /// <param name="regimeEspecialTributacao">Regime especial de tributação da Empresa:  0 - Sem Regime Tributário Especial  1 - Micro Empresa Municipal  2 - Estimativa  3 - Sociedade de Profissionais  4 - Cooperativa  5 - Microempresário Individual - MEI  6 - Microempresa ou Pequeno Porte - ME EPP (required).</param>
        /// <param name="incentivoFiscal">Indicador se a empresa possui algum tipo de incentivo fiscal..</param>
        /// <param name="incentivadorCultural">Indicador se a empresa é um incentivador cultural..</param>
        public Empresa(string cpfCnpj = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string inscricaoEstadual = default(string), string inscricaoMunicipal = default(string), string nomeRazaoSocial = default(string), string nomeFantasia = default(string), string fone = default(string), string email = default(string), EmpresaEndereco endereco = default(EmpresaEndereco), bool optanteSimplesNacional = default(bool), int regimeTributacao = default(int), int regimeEspecialTributacao = default(int), bool incentivoFiscal = default(bool), bool incentivadorCultural = default(bool))
        {
            // to ensure "cpfCnpj" is required (not null)
            if (cpfCnpj == null)
            {
                throw new ArgumentNullException("cpfCnpj is a required property for Empresa and cannot be null");
            }
            this.cpf_cnpj = cpfCnpj;
            // to ensure "nomeRazaoSocial" is required (not null)
            if (nomeRazaoSocial == null)
            {
                throw new ArgumentNullException("nomeRazaoSocial is a required property for Empresa and cannot be null");
            }
            this.nome_razao_social = nomeRazaoSocial;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for Empresa and cannot be null");
            }
            this.email = email;
            // to ensure "endereco" is required (not null)
            if (endereco == null)
            {
                throw new ArgumentNullException("endereco is a required property for Empresa and cannot be null");
            }
            this.endereco = endereco;
            this.regime_tributacao = regimeTributacao;
            this.regime_especial_tributacao = regimeEspecialTributacao;
            this.created_at = createdAt;
            this.updated_at = updatedAt;
            this.inscricao_estadual = inscricaoEstadual;
            this.inscricao_municipal = inscricaoMunicipal;
            this.nome_fantasia = nomeFantasia;
            this.fone = fone;
            this.optante_simples_nacional = optanteSimplesNacional;
            this.incentivo_fiscal = incentivoFiscal;
            this.incentivador_cultural = incentivadorCultural;
        }

        /// <summary>
        /// CPF ou CNPJ da empresa.  Utilize o valor sem máscara.
        /// </summary>
        /// <value>CPF ou CNPJ da empresa.  Utilize o valor sem máscara.</value>
        [DataMember(Name = "cpf_cnpj", IsRequired = true, EmitDefaultValue = true)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Data e hora que o objeto foi criado.  A Nuvem Fiscal gerencia esse campo automaticamente.
        /// </summary>
        /// <value>Data e hora que o objeto foi criado.  A Nuvem Fiscal gerencia esse campo automaticamente.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Data e hora que o objeto foi alterado pela última vez.  A Nuvem Fiscal gerencia esse campo automaticamente.
        /// </summary>
        /// <value>Data e hora que o objeto foi alterado pela última vez.  A Nuvem Fiscal gerencia esse campo automaticamente.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime updated_at { get; set; }

        /// <summary>
        /// Inscrição estadual da empresa.
        /// </summary>
        /// <value>Inscrição estadual da empresa.</value>
        [DataMember(Name = "inscricao_estadual", EmitDefaultValue = false)]
        public string inscricao_estadual { get; set; }

        /// <summary>
        /// Inscrição municipal da empresa.
        /// </summary>
        /// <value>Inscrição municipal da empresa.</value>
        [DataMember(Name = "inscricao_municipal", EmitDefaultValue = false)]
        public string inscricao_municipal { get; set; }

        /// <summary>
        /// Razão social da empresa.
        /// </summary>
        /// <value>Razão social da empresa.</value>
        [DataMember(Name = "nome_razao_social", IsRequired = true, EmitDefaultValue = true)]
        public string nome_razao_social { get; set; }

        /// <summary>
        /// Nome fantasia da empresa.
        /// </summary>
        /// <value>Nome fantasia da empresa.</value>
        [DataMember(Name = "nome_fantasia", EmitDefaultValue = false)]
        public string nome_fantasia { get; set; }

        /// <summary>
        /// Telefone da empresa.
        /// </summary>
        /// <value>Telefone da empresa.</value>
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// Email da empresa.
        /// </summary>
        /// <value>Email da empresa.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets endereco
        /// </summary>
        [DataMember(Name = "endereco", IsRequired = true, EmitDefaultValue = true)]
        public EmpresaEndereco endereco { get; set; }

        /// <summary>
        /// Optante pelo simples nacional.
        /// </summary>
        /// <value>Optante pelo simples nacional.</value>
        [DataMember(Name = "optante_simples_nacional", EmitDefaultValue = true)]
        public bool optante_simples_nacional { get; set; }

        /// <summary>
        /// Regime Tributário da Empresa:  0 - Nenhum  1 - Simples Nacional  2 - Simples Nacional - Excesso  3 - Normal - Lucro Presumido  4 - Normal - Lucro Real
        /// </summary>
        /// <value>Regime Tributário da Empresa:  0 - Nenhum  1 - Simples Nacional  2 - Simples Nacional - Excesso  3 - Normal - Lucro Presumido  4 - Normal - Lucro Real</value>
        [DataMember(Name = "regime_tributacao", IsRequired = true, EmitDefaultValue = true)]
        public int regime_tributacao { get; set; }

        /// <summary>
        /// Regime especial de tributação da Empresa:  0 - Sem Regime Tributário Especial  1 - Micro Empresa Municipal  2 - Estimativa  3 - Sociedade de Profissionais  4 - Cooperativa  5 - Microempresário Individual - MEI  6 - Microempresa ou Pequeno Porte - ME EPP
        /// </summary>
        /// <value>Regime especial de tributação da Empresa:  0 - Sem Regime Tributário Especial  1 - Micro Empresa Municipal  2 - Estimativa  3 - Sociedade de Profissionais  4 - Cooperativa  5 - Microempresário Individual - MEI  6 - Microempresa ou Pequeno Porte - ME EPP</value>
        [DataMember(Name = "regime_especial_tributacao", IsRequired = true, EmitDefaultValue = true)]
        public int regime_especial_tributacao { get; set; }

        /// <summary>
        /// Indicador se a empresa possui algum tipo de incentivo fiscal.
        /// </summary>
        /// <value>Indicador se a empresa possui algum tipo de incentivo fiscal.</value>
        [DataMember(Name = "incentivo_fiscal", EmitDefaultValue = true)]
        public bool incentivo_fiscal { get; set; }

        /// <summary>
        /// Indicador se a empresa é um incentivador cultural.
        /// </summary>
        /// <value>Indicador se a empresa é um incentivador cultural.</value>
        [DataMember(Name = "incentivador_cultural", EmitDefaultValue = true)]
        public bool incentivador_cultural { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Empresa {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  updated_at: ").Append(updated_at).Append("\n");
            sb.Append("  inscricao_estadual: ").Append(inscricao_estadual).Append("\n");
            sb.Append("  inscricao_municipal: ").Append(inscricao_municipal).Append("\n");
            sb.Append("  nome_razao_social: ").Append(nome_razao_social).Append("\n");
            sb.Append("  nome_fantasia: ").Append(nome_fantasia).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  endereco: ").Append(endereco).Append("\n");
            sb.Append("  optante_simples_nacional: ").Append(optante_simples_nacional).Append("\n");
            sb.Append("  regime_tributacao: ").Append(regime_tributacao).Append("\n");
            sb.Append("  regime_especial_tributacao: ").Append(regime_especial_tributacao).Append("\n");
            sb.Append("  incentivo_fiscal: ").Append(incentivo_fiscal).Append("\n");
            sb.Append("  incentivador_cultural: ").Append(incentivador_cultural).Append("\n");
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
            return this.Equals(input as Empresa);
        }

        /// <summary>
        /// Returns true if Empresa instances are equal
        /// </summary>
        /// <param name="input">Instance of Empresa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Empresa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cpf_cnpj == input.cpf_cnpj ||
                    (this.cpf_cnpj != null &&
                    this.cpf_cnpj.Equals(input.cpf_cnpj))
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.updated_at == input.updated_at ||
                    (this.updated_at != null &&
                    this.updated_at.Equals(input.updated_at))
                ) && 
                (
                    this.inscricao_estadual == input.inscricao_estadual ||
                    (this.inscricao_estadual != null &&
                    this.inscricao_estadual.Equals(input.inscricao_estadual))
                ) && 
                (
                    this.inscricao_municipal == input.inscricao_municipal ||
                    (this.inscricao_municipal != null &&
                    this.inscricao_municipal.Equals(input.inscricao_municipal))
                ) && 
                (
                    this.nome_razao_social == input.nome_razao_social ||
                    (this.nome_razao_social != null &&
                    this.nome_razao_social.Equals(input.nome_razao_social))
                ) && 
                (
                    this.nome_fantasia == input.nome_fantasia ||
                    (this.nome_fantasia != null &&
                    this.nome_fantasia.Equals(input.nome_fantasia))
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
                    this.endereco == input.endereco ||
                    (this.endereco != null &&
                    this.endereco.Equals(input.endereco))
                ) && 
                (
                    this.optante_simples_nacional == input.optante_simples_nacional ||
                    this.optante_simples_nacional.Equals(input.optante_simples_nacional)
                ) && 
                (
                    this.regime_tributacao == input.regime_tributacao ||
                    this.regime_tributacao.Equals(input.regime_tributacao)
                ) && 
                (
                    this.regime_especial_tributacao == input.regime_especial_tributacao ||
                    this.regime_especial_tributacao.Equals(input.regime_especial_tributacao)
                ) && 
                (
                    this.incentivo_fiscal == input.incentivo_fiscal ||
                    this.incentivo_fiscal.Equals(input.incentivo_fiscal)
                ) && 
                (
                    this.incentivador_cultural == input.incentivador_cultural ||
                    this.incentivador_cultural.Equals(input.incentivador_cultural)
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
                if (this.cpf_cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_cnpj.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.updated_at != null)
                {
                    hashCode = (hashCode * 59) + this.updated_at.GetHashCode();
                }
                if (this.inscricao_estadual != null)
                {
                    hashCode = (hashCode * 59) + this.inscricao_estadual.GetHashCode();
                }
                if (this.inscricao_municipal != null)
                {
                    hashCode = (hashCode * 59) + this.inscricao_municipal.GetHashCode();
                }
                if (this.nome_razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.nome_razao_social.GetHashCode();
                }
                if (this.nome_fantasia != null)
                {
                    hashCode = (hashCode * 59) + this.nome_fantasia.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
                }
                if (this.endereco != null)
                {
                    hashCode = (hashCode * 59) + this.endereco.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.optante_simples_nacional.GetHashCode();
                hashCode = (hashCode * 59) + this.regime_tributacao.GetHashCode();
                hashCode = (hashCode * 59) + this.regime_especial_tributacao.GetHashCode();
                hashCode = (hashCode * 59) + this.incentivo_fiscal.GetHashCode();
                hashCode = (hashCode * 59) + this.incentivador_cultural.GetHashCode();
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
