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
    /// RpsDadosPrestador
    /// </summary>
    [DataContract(Name = "RpsDadosPrestador")]
    public partial class RpsDadosPrestador : IEquatable<RpsDadosPrestador>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosPrestador" /> class.
        /// </summary>
        /// <param name="cpfCnpj">cpfCnpj.</param>
        /// <param name="inscricaoMunicipal">inscricaoMunicipal.</param>
        /// <param name="nomeRazaoSocial">nomeRazaoSocial.</param>
        /// <param name="nomeFantasia">nomeFantasia.</param>
        /// <param name="fone">fone.</param>
        /// <param name="email">email.</param>
        /// <param name="endereco">endereco.</param>
        /// <param name="optanteSimplesNacional">optanteSimplesNacional.</param>
        /// <param name="regimeTributacao">regimeTributacao.</param>
        /// <param name="regimeEspecialTributacao">regimeEspecialTributacao.</param>
        /// <param name="incentivoFiscal">incentivoFiscal.</param>
        /// <param name="incentivadorCultural">incentivadorCultural.</param>
        public RpsDadosPrestador(string cpfCnpj = default(string), string inscricaoMunicipal = default(string), string nomeRazaoSocial = default(string), string nomeFantasia = default(string), string fone = default(string), string email = default(string), EmpresaEndereco endereco = default(EmpresaEndereco), bool optanteSimplesNacional = default(bool), int regimeTributacao = default(int), int regimeEspecialTributacao = default(int), bool incentivoFiscal = default(bool), bool incentivadorCultural = default(bool))
        {
            this.cpf_cnpj = cpfCnpj;
            this.inscricao_municipal = inscricaoMunicipal;
            this.nome_razao_social = nomeRazaoSocial;
            this.nome_fantasia = nomeFantasia;
            this.fone = fone;
            this.email = email;
            this.endereco = endereco;
            this.optante_simples_nacional = optanteSimplesNacional;
            this.regime_tributacao = regimeTributacao;
            this.regime_especial_tributacao = regimeEspecialTributacao;
            this.incentivo_fiscal = incentivoFiscal;
            this.incentivador_cultural = incentivadorCultural;
        }

        /// <summary>
        /// Gets or Sets cpf_cnpj
        /// </summary>
        [DataMember(Name = "cpf_cnpj", EmitDefaultValue = false)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Gets or Sets inscricao_municipal
        /// </summary>
        [DataMember(Name = "inscricao_municipal", EmitDefaultValue = false)]
        public string inscricao_municipal { get; set; }

        /// <summary>
        /// Gets or Sets nome_razao_social
        /// </summary>
        [DataMember(Name = "nome_razao_social", EmitDefaultValue = false)]
        public string nome_razao_social { get; set; }

        /// <summary>
        /// Gets or Sets nome_fantasia
        /// </summary>
        [DataMember(Name = "nome_fantasia", EmitDefaultValue = false)]
        public string nome_fantasia { get; set; }

        /// <summary>
        /// Gets or Sets fone
        /// </summary>
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// Gets or Sets email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets endereco
        /// </summary>
        [DataMember(Name = "endereco", EmitDefaultValue = false)]
        public EmpresaEndereco endereco { get; set; }

        /// <summary>
        /// Gets or Sets optante_simples_nacional
        /// </summary>
        [DataMember(Name = "optante_simples_nacional", EmitDefaultValue = true)]
        public bool optante_simples_nacional { get; set; }

        /// <summary>
        /// Gets or Sets regime_tributacao
        /// </summary>
        [DataMember(Name = "regime_tributacao", EmitDefaultValue = false)]
        public int regime_tributacao { get; set; }

        /// <summary>
        /// Gets or Sets regime_especial_tributacao
        /// </summary>
        [DataMember(Name = "regime_especial_tributacao", EmitDefaultValue = false)]
        public int regime_especial_tributacao { get; set; }

        /// <summary>
        /// Gets or Sets incentivo_fiscal
        /// </summary>
        [DataMember(Name = "incentivo_fiscal", EmitDefaultValue = true)]
        public bool incentivo_fiscal { get; set; }

        /// <summary>
        /// Gets or Sets incentivador_cultural
        /// </summary>
        [DataMember(Name = "incentivador_cultural", EmitDefaultValue = true)]
        public bool incentivador_cultural { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsDadosPrestador {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
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
            return this.Equals(input as RpsDadosPrestador);
        }

        /// <summary>
        /// Returns true if RpsDadosPrestador instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsDadosPrestador to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsDadosPrestador input)
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
