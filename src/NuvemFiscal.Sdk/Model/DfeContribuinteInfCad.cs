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
    /// Informações cadastrais do contribuinte consultado.
    /// </summary>
    [DataContract(Name = "DfeContribuinteInfCad")]
    public partial class DfeContribuinteInfCad : IEquatable<DfeContribuinteInfCad>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeContribuinteInfCad" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DfeContribuinteInfCad() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeContribuinteInfCad" /> class.
        /// </summary>
        /// <param name="ie">Número da Inscrição Estadual do contribuinte. (required).</param>
        /// <param name="cnpj">Número do CNPJ  do contribuinte..</param>
        /// <param name="cpf">Número do CPF do contribuinte..</param>
        /// <param name="uf">Sigla da UF de localização do contribuinte. Em algumas situações, a UF de localização pode ser diferente da UF consultada. Ex. IE de Substituto Tributário. (required).</param>
        /// <param name="situacaoCadastral">Situação cadastral do contribuinte:  * 0 - não habilitado  * 1 - habilitado (required).</param>
        /// <param name="indicadorNfe">Indicador de contribuinte credenciado a emitir NF-e.  * 0 - Não credenciado para emissão da NF-e  * 1 - Credenciado  * 2 - Credenciado com obrigatoriedade para todas operações  * 3 - Credenciado com obrigatoriedade parcial  * 4 - a SEFAZ não fornece a informação  Este indicador significa apenas que o contribuinte é credenciado para emitir NF-e na SEFAZ consultada. (required).</param>
        /// <param name="indicadorCte">Indicador de contribuinte credenciado a emitir CT-e.  * 0 - Não credenciado para emissão da CT-e  * 1 - Credenciado  * 2 - Credenciado com obrigatoriedade para todas operações  * 3 - Credenciado com obrigatoriedade parcial  * 4 - a SEFAZ não fornece a informação  Este indicador significa apenas que o contribuinte é credenciado para emitir CT-e na SEFAZ consultada. (required).</param>
        /// <param name="nomeRazaoSocial">Razão Social ou nome do contribuinte. (required).</param>
        /// <param name="nomeFantasia">Razão Social ou nome do contribuinte..</param>
        /// <param name="regimeApuracaoIcms">Regime de Apuração do ICMS..</param>
        /// <param name="cnae">CNAE Fiscal do contribuinte..</param>
        /// <param name="dataInicioAtividade">Data de início de atividades do contribuinte..</param>
        /// <param name="dataSituacaoCadastral">Data da última modificação da situação cadastral do contribuinte..</param>
        /// <param name="dataFimAtividade">Data de ocorrência da baixa do contribuinte..</param>
        /// <param name="ieUnica">Inscrição Estadual Única..</param>
        /// <param name="ieAtual">Inscrição Estadual atual..</param>
        /// <param name="endereco">endereco.</param>
        public DfeContribuinteInfCad(string ie = default(string), string cnpj = default(string), string cpf = default(string), string uf = default(string), int? situacaoCadastral = default(int?), int? indicadorNfe = default(int?), int? indicadorCte = default(int?), string nomeRazaoSocial = default(string), string nomeFantasia = default(string), string regimeApuracaoIcms = default(string), string cnae = default(string), DateTime? dataInicioAtividade = default(DateTime?), DateTime? dataSituacaoCadastral = default(DateTime?), DateTime? dataFimAtividade = default(DateTime?), string ieUnica = default(string), string ieAtual = default(string), DfeContribuinteEndereco endereco = default(DfeContribuinteEndereco))
        {
            // to ensure "ie" is required (not null)
            if (ie == null)
            {
                throw new ArgumentNullException("ie is a required property for DfeContribuinteInfCad and cannot be null");
            }
            this.ie = ie;
            // to ensure "uf" is required (not null)
            if (uf == null)
            {
                throw new ArgumentNullException("uf is a required property for DfeContribuinteInfCad and cannot be null");
            }
            this.uf = uf;
            // to ensure "situacaoCadastral" is required (not null)
            if (situacaoCadastral == null)
            {
                throw new ArgumentNullException("situacaoCadastral is a required property for DfeContribuinteInfCad and cannot be null");
            }
            this.situacao_cadastral = situacaoCadastral;
            // to ensure "indicadorNfe" is required (not null)
            if (indicadorNfe == null)
            {
                throw new ArgumentNullException("indicadorNfe is a required property for DfeContribuinteInfCad and cannot be null");
            }
            this.indicador_nfe = indicadorNfe;
            // to ensure "indicadorCte" is required (not null)
            if (indicadorCte == null)
            {
                throw new ArgumentNullException("indicadorCte is a required property for DfeContribuinteInfCad and cannot be null");
            }
            this.indicador_cte = indicadorCte;
            // to ensure "nomeRazaoSocial" is required (not null)
            if (nomeRazaoSocial == null)
            {
                throw new ArgumentNullException("nomeRazaoSocial is a required property for DfeContribuinteInfCad and cannot be null");
            }
            this.nome_razao_social = nomeRazaoSocial;
            this.cnpj = cnpj;
            this.cpf = cpf;
            this.nome_fantasia = nomeFantasia;
            this.regime_apuracao_icms = regimeApuracaoIcms;
            this.cnae = cnae;
            this.data_inicio_atividade = dataInicioAtividade;
            this.data_situacao_cadastral = dataSituacaoCadastral;
            this.data_fim_atividade = dataFimAtividade;
            this.ie_unica = ieUnica;
            this.ie_atual = ieAtual;
            this.endereco = endereco;
        }

        /// <summary>
        /// Número da Inscrição Estadual do contribuinte.
        /// </summary>
        /// <value>Número da Inscrição Estadual do contribuinte.</value>
        [DataMember(Name = "ie", IsRequired = true, EmitDefaultValue = true)]
        public string ie { get; set; }

        /// <summary>
        /// Número do CNPJ  do contribuinte.
        /// </summary>
        /// <value>Número do CNPJ  do contribuinte.</value>
        [DataMember(Name = "cnpj", EmitDefaultValue = true)]
        public string cnpj { get; set; }

        /// <summary>
        /// Número do CPF do contribuinte.
        /// </summary>
        /// <value>Número do CPF do contribuinte.</value>
        [DataMember(Name = "cpf", EmitDefaultValue = true)]
        public string cpf { get; set; }

        /// <summary>
        /// Sigla da UF de localização do contribuinte. Em algumas situações, a UF de localização pode ser diferente da UF consultada. Ex. IE de Substituto Tributário.
        /// </summary>
        /// <value>Sigla da UF de localização do contribuinte. Em algumas situações, a UF de localização pode ser diferente da UF consultada. Ex. IE de Substituto Tributário.</value>
        [DataMember(Name = "uf", IsRequired = true, EmitDefaultValue = true)]
        public string uf { get; set; }

        /// <summary>
        /// Situação cadastral do contribuinte:  * 0 - não habilitado  * 1 - habilitado
        /// </summary>
        /// <value>Situação cadastral do contribuinte:  * 0 - não habilitado  * 1 - habilitado</value>
        [DataMember(Name = "situacao_cadastral", IsRequired = true, EmitDefaultValue = true)]
        public int? situacao_cadastral { get; set; }

        /// <summary>
        /// Indicador de contribuinte credenciado a emitir NF-e.  * 0 - Não credenciado para emissão da NF-e  * 1 - Credenciado  * 2 - Credenciado com obrigatoriedade para todas operações  * 3 - Credenciado com obrigatoriedade parcial  * 4 - a SEFAZ não fornece a informação  Este indicador significa apenas que o contribuinte é credenciado para emitir NF-e na SEFAZ consultada.
        /// </summary>
        /// <value>Indicador de contribuinte credenciado a emitir NF-e.  * 0 - Não credenciado para emissão da NF-e  * 1 - Credenciado  * 2 - Credenciado com obrigatoriedade para todas operações  * 3 - Credenciado com obrigatoriedade parcial  * 4 - a SEFAZ não fornece a informação  Este indicador significa apenas que o contribuinte é credenciado para emitir NF-e na SEFAZ consultada.</value>
        [DataMember(Name = "indicador_nfe", IsRequired = true, EmitDefaultValue = true)]
        public int? indicador_nfe { get; set; }

        /// <summary>
        /// Indicador de contribuinte credenciado a emitir CT-e.  * 0 - Não credenciado para emissão da CT-e  * 1 - Credenciado  * 2 - Credenciado com obrigatoriedade para todas operações  * 3 - Credenciado com obrigatoriedade parcial  * 4 - a SEFAZ não fornece a informação  Este indicador significa apenas que o contribuinte é credenciado para emitir CT-e na SEFAZ consultada.
        /// </summary>
        /// <value>Indicador de contribuinte credenciado a emitir CT-e.  * 0 - Não credenciado para emissão da CT-e  * 1 - Credenciado  * 2 - Credenciado com obrigatoriedade para todas operações  * 3 - Credenciado com obrigatoriedade parcial  * 4 - a SEFAZ não fornece a informação  Este indicador significa apenas que o contribuinte é credenciado para emitir CT-e na SEFAZ consultada.</value>
        [DataMember(Name = "indicador_cte", IsRequired = true, EmitDefaultValue = true)]
        public int? indicador_cte { get; set; }

        /// <summary>
        /// Razão Social ou nome do contribuinte.
        /// </summary>
        /// <value>Razão Social ou nome do contribuinte.</value>
        [DataMember(Name = "nome_razao_social", IsRequired = true, EmitDefaultValue = true)]
        public string nome_razao_social { get; set; }

        /// <summary>
        /// Razão Social ou nome do contribuinte.
        /// </summary>
        /// <value>Razão Social ou nome do contribuinte.</value>
        [DataMember(Name = "nome_fantasia", EmitDefaultValue = true)]
        public string nome_fantasia { get; set; }

        /// <summary>
        /// Regime de Apuração do ICMS.
        /// </summary>
        /// <value>Regime de Apuração do ICMS.</value>
        [DataMember(Name = "regime_apuracao_icms", EmitDefaultValue = true)]
        public string regime_apuracao_icms { get; set; }

        /// <summary>
        /// CNAE Fiscal do contribuinte.
        /// </summary>
        /// <value>CNAE Fiscal do contribuinte.</value>
        [DataMember(Name = "cnae", EmitDefaultValue = true)]
        public string cnae { get; set; }

        /// <summary>
        /// Data de início de atividades do contribuinte.
        /// </summary>
        /// <value>Data de início de atividades do contribuinte.</value>
        [DataMember(Name = "data_inicio_atividade", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? data_inicio_atividade { get; set; }

        /// <summary>
        /// Data da última modificação da situação cadastral do contribuinte.
        /// </summary>
        /// <value>Data da última modificação da situação cadastral do contribuinte.</value>
        [DataMember(Name = "data_situacao_cadastral", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? data_situacao_cadastral { get; set; }

        /// <summary>
        /// Data de ocorrência da baixa do contribuinte.
        /// </summary>
        /// <value>Data de ocorrência da baixa do contribuinte.</value>
        [DataMember(Name = "data_fim_atividade", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? data_fim_atividade { get; set; }

        /// <summary>
        /// Inscrição Estadual Única.
        /// </summary>
        /// <value>Inscrição Estadual Única.</value>
        [DataMember(Name = "ie_unica", EmitDefaultValue = true)]
        public string ie_unica { get; set; }

        /// <summary>
        /// Inscrição Estadual atual.
        /// </summary>
        /// <value>Inscrição Estadual atual.</value>
        [DataMember(Name = "ie_atual", EmitDefaultValue = true)]
        public string ie_atual { get; set; }

        /// <summary>
        /// Gets or Sets endereco
        /// </summary>
        [DataMember(Name = "endereco", EmitDefaultValue = false)]
        public DfeContribuinteEndereco endereco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeContribuinteInfCad {\n");
            sb.Append("  ie: ").Append(ie).Append("\n");
            sb.Append("  cnpj: ").Append(cnpj).Append("\n");
            sb.Append("  cpf: ").Append(cpf).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  situacao_cadastral: ").Append(situacao_cadastral).Append("\n");
            sb.Append("  indicador_nfe: ").Append(indicador_nfe).Append("\n");
            sb.Append("  indicador_cte: ").Append(indicador_cte).Append("\n");
            sb.Append("  nome_razao_social: ").Append(nome_razao_social).Append("\n");
            sb.Append("  nome_fantasia: ").Append(nome_fantasia).Append("\n");
            sb.Append("  regime_apuracao_icms: ").Append(regime_apuracao_icms).Append("\n");
            sb.Append("  cnae: ").Append(cnae).Append("\n");
            sb.Append("  data_inicio_atividade: ").Append(data_inicio_atividade).Append("\n");
            sb.Append("  data_situacao_cadastral: ").Append(data_situacao_cadastral).Append("\n");
            sb.Append("  data_fim_atividade: ").Append(data_fim_atividade).Append("\n");
            sb.Append("  ie_unica: ").Append(ie_unica).Append("\n");
            sb.Append("  ie_atual: ").Append(ie_atual).Append("\n");
            sb.Append("  endereco: ").Append(endereco).Append("\n");
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
            return this.Equals(input as DfeContribuinteInfCad);
        }

        /// <summary>
        /// Returns true if DfeContribuinteInfCad instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeContribuinteInfCad to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeContribuinteInfCad input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ie == input.ie ||
                    (this.ie != null &&
                    this.ie.Equals(input.ie))
                ) && 
                (
                    this.cnpj == input.cnpj ||
                    (this.cnpj != null &&
                    this.cnpj.Equals(input.cnpj))
                ) && 
                (
                    this.cpf == input.cpf ||
                    (this.cpf != null &&
                    this.cpf.Equals(input.cpf))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.situacao_cadastral == input.situacao_cadastral ||
                    (this.situacao_cadastral != null &&
                    this.situacao_cadastral.Equals(input.situacao_cadastral))
                ) && 
                (
                    this.indicador_nfe == input.indicador_nfe ||
                    (this.indicador_nfe != null &&
                    this.indicador_nfe.Equals(input.indicador_nfe))
                ) && 
                (
                    this.indicador_cte == input.indicador_cte ||
                    (this.indicador_cte != null &&
                    this.indicador_cte.Equals(input.indicador_cte))
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
                    this.regime_apuracao_icms == input.regime_apuracao_icms ||
                    (this.regime_apuracao_icms != null &&
                    this.regime_apuracao_icms.Equals(input.regime_apuracao_icms))
                ) && 
                (
                    this.cnae == input.cnae ||
                    (this.cnae != null &&
                    this.cnae.Equals(input.cnae))
                ) && 
                (
                    this.data_inicio_atividade == input.data_inicio_atividade ||
                    (this.data_inicio_atividade != null &&
                    this.data_inicio_atividade.Equals(input.data_inicio_atividade))
                ) && 
                (
                    this.data_situacao_cadastral == input.data_situacao_cadastral ||
                    (this.data_situacao_cadastral != null &&
                    this.data_situacao_cadastral.Equals(input.data_situacao_cadastral))
                ) && 
                (
                    this.data_fim_atividade == input.data_fim_atividade ||
                    (this.data_fim_atividade != null &&
                    this.data_fim_atividade.Equals(input.data_fim_atividade))
                ) && 
                (
                    this.ie_unica == input.ie_unica ||
                    (this.ie_unica != null &&
                    this.ie_unica.Equals(input.ie_unica))
                ) && 
                (
                    this.ie_atual == input.ie_atual ||
                    (this.ie_atual != null &&
                    this.ie_atual.Equals(input.ie_atual))
                ) && 
                (
                    this.endereco == input.endereco ||
                    (this.endereco != null &&
                    this.endereco.Equals(input.endereco))
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
                if (this.ie != null)
                {
                    hashCode = (hashCode * 59) + this.ie.GetHashCode();
                }
                if (this.cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cnpj.GetHashCode();
                }
                if (this.cpf != null)
                {
                    hashCode = (hashCode * 59) + this.cpf.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.situacao_cadastral != null)
                {
                    hashCode = (hashCode * 59) + this.situacao_cadastral.GetHashCode();
                }
                if (this.indicador_nfe != null)
                {
                    hashCode = (hashCode * 59) + this.indicador_nfe.GetHashCode();
                }
                if (this.indicador_cte != null)
                {
                    hashCode = (hashCode * 59) + this.indicador_cte.GetHashCode();
                }
                if (this.nome_razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.nome_razao_social.GetHashCode();
                }
                if (this.nome_fantasia != null)
                {
                    hashCode = (hashCode * 59) + this.nome_fantasia.GetHashCode();
                }
                if (this.regime_apuracao_icms != null)
                {
                    hashCode = (hashCode * 59) + this.regime_apuracao_icms.GetHashCode();
                }
                if (this.cnae != null)
                {
                    hashCode = (hashCode * 59) + this.cnae.GetHashCode();
                }
                if (this.data_inicio_atividade != null)
                {
                    hashCode = (hashCode * 59) + this.data_inicio_atividade.GetHashCode();
                }
                if (this.data_situacao_cadastral != null)
                {
                    hashCode = (hashCode * 59) + this.data_situacao_cadastral.GetHashCode();
                }
                if (this.data_fim_atividade != null)
                {
                    hashCode = (hashCode * 59) + this.data_fim_atividade.GetHashCode();
                }
                if (this.ie_unica != null)
                {
                    hashCode = (hashCode * 59) + this.ie_unica.GetHashCode();
                }
                if (this.ie_atual != null)
                {
                    hashCode = (hashCode * 59) + this.ie_atual.GetHashCode();
                }
                if (this.endereco != null)
                {
                    hashCode = (hashCode * 59) + this.endereco.GetHashCode();
                }
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
            // nome_razao_social (string) maxLength
            if (this.nome_razao_social != null && this.nome_razao_social.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_razao_social, length must be less than 60.", new [] { "nome_razao_social" });
            }

            // nome_razao_social (string) minLength
            if (this.nome_razao_social != null && this.nome_razao_social.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_razao_social, length must be greater than 1.", new [] { "nome_razao_social" });
            }

            // nome_fantasia (string) maxLength
            if (this.nome_fantasia != null && this.nome_fantasia.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_fantasia, length must be less than 60.", new [] { "nome_fantasia" });
            }

            // nome_fantasia (string) minLength
            if (this.nome_fantasia != null && this.nome_fantasia.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_fantasia, length must be greater than 1.", new [] { "nome_fantasia" });
            }

            // regime_apuracao_icms (string) maxLength
            if (this.regime_apuracao_icms != null && this.regime_apuracao_icms.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for regime_apuracao_icms, length must be less than 60.", new [] { "regime_apuracao_icms" });
            }

            // regime_apuracao_icms (string) minLength
            if (this.regime_apuracao_icms != null && this.regime_apuracao_icms.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for regime_apuracao_icms, length must be greater than 1.", new [] { "regime_apuracao_icms" });
            }

            yield break;
        }
    }

}
