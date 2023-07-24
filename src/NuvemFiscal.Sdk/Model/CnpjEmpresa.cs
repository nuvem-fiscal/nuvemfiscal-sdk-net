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
    /// CnpjEmpresa
    /// </summary>
    [DataContract(Name = "CnpjEmpresa")]
    public partial class CnpjEmpresa : IEquatable<CnpjEmpresa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjEmpresa" /> class.
        /// </summary>
        /// <param name="cnpj">Número de inscrição do CNPJ..</param>
        /// <param name="razaoSocial">Nome empresarial da pessoa jurídica..</param>
        /// <param name="nomeFantasia">Corresponde ao nome fantasia..</param>
        /// <param name="dataInicioAtividade">Data de início da atividade..</param>
        /// <param name="matriz">Indicador de matriz/filial:  * &#x60;true&#x60; - É matriz  * &#x60;false&#x60; - É filial.</param>
        /// <param name="naturezaJuridica">naturezaJuridica.</param>
        /// <param name="capitalSocial">Capital social da empresa..</param>
        /// <param name="porte">porte.</param>
        /// <param name="enteFederativoResponsavel">O ente federativo responsável é preenchido para os casos de órgãos e  entidades do grupo de natureza jurídica 1XXX. Para as demais naturezas,  este atributo fica em branco..</param>
        /// <param name="situacaoCadastral">situacaoCadastral.</param>
        /// <param name="motivoSituacaoCadastral">motivoSituacaoCadastral.</param>
        /// <param name="nomeDaCidadeNoExterior">Nome da cidade no exterior..</param>
        /// <param name="pais">pais.</param>
        /// <param name="atividadePrincipal">atividadePrincipal.</param>
        /// <param name="atividadesSecundarias">atividadesSecundarias.</param>
        /// <param name="endereco">endereco.</param>
        /// <param name="telefones">telefones.</param>
        /// <param name="email">E-mail do contribuinte..</param>
        /// <param name="situacaoEspecial">situacaoEspecial.</param>
        /// <param name="simples">simples.</param>
        /// <param name="simei">simei.</param>
        /// <param name="socios">socios.</param>
        public CnpjEmpresa(string cnpj = default(string), string razaoSocial = default(string), string nomeFantasia = default(string), DateTime dataInicioAtividade = default(DateTime), bool matriz = default(bool), CnpjNaturezaJuridica naturezaJuridica = default(CnpjNaturezaJuridica), decimal capitalSocial = default(decimal), CnpjPorteEmpresa porte = default(CnpjPorteEmpresa), string enteFederativoResponsavel = default(string), CnpjSituacaoCadastral situacaoCadastral = default(CnpjSituacaoCadastral), CnpjMotivoSituacaoCadastral motivoSituacaoCadastral = default(CnpjMotivoSituacaoCadastral), string nomeDaCidadeNoExterior = default(string), CnpjPais pais = default(CnpjPais), CnpjCnae atividadePrincipal = default(CnpjCnae), List<CnpjCnaeSecundario> atividadesSecundarias = default(List<CnpjCnaeSecundario>), CnpjEndereco endereco = default(CnpjEndereco), List<CnpjTelefone> telefones = default(List<CnpjTelefone>), string email = default(string), CnpjSituacaoEspecial situacaoEspecial = default(CnpjSituacaoEspecial), CnpjOpcaoSimples simples = default(CnpjOpcaoSimples), CnpjOpcaoSimei simei = default(CnpjOpcaoSimei), List<CnpjSocio> socios = default(List<CnpjSocio>))
        {
            this.cnpj = cnpj;
            this.razao_social = razaoSocial;
            this.nome_fantasia = nomeFantasia;
            this.data_inicio_atividade = dataInicioAtividade;
            this.matriz = matriz;
            this.natureza_juridica = naturezaJuridica;
            this.capital_social = capitalSocial;
            this.porte = porte;
            this.ente_federativo_responsavel = enteFederativoResponsavel;
            this.situacao_cadastral = situacaoCadastral;
            this.motivo_situacao_cadastral = motivoSituacaoCadastral;
            this.nome_da_cidade_no_exterior = nomeDaCidadeNoExterior;
            this.pais = pais;
            this.atividade_principal = atividadePrincipal;
            this.atividades_secundarias = atividadesSecundarias;
            this.endereco = endereco;
            this.telefones = telefones;
            this.email = email;
            this.situacao_especial = situacaoEspecial;
            this.simples = simples;
            this.simei = simei;
            this.socios = socios;
        }

        /// <summary>
        /// Número de inscrição do CNPJ.
        /// </summary>
        /// <value>Número de inscrição do CNPJ.</value>
        [DataMember(Name = "cnpj", EmitDefaultValue = false)]
        public string cnpj { get; set; }

        /// <summary>
        /// Nome empresarial da pessoa jurídica.
        /// </summary>
        /// <value>Nome empresarial da pessoa jurídica.</value>
        [DataMember(Name = "razao_social", EmitDefaultValue = false)]
        public string razao_social { get; set; }

        /// <summary>
        /// Corresponde ao nome fantasia.
        /// </summary>
        /// <value>Corresponde ao nome fantasia.</value>
        [DataMember(Name = "nome_fantasia", EmitDefaultValue = false)]
        public string nome_fantasia { get; set; }

        /// <summary>
        /// Data de início da atividade.
        /// </summary>
        /// <value>Data de início da atividade.</value>
        [DataMember(Name = "data_inicio_atividade", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data_inicio_atividade { get; set; }

        /// <summary>
        /// Indicador de matriz/filial:  * &#x60;true&#x60; - É matriz  * &#x60;false&#x60; - É filial
        /// </summary>
        /// <value>Indicador de matriz/filial:  * &#x60;true&#x60; - É matriz  * &#x60;false&#x60; - É filial</value>
        [DataMember(Name = "matriz", EmitDefaultValue = true)]
        public bool matriz { get; set; }

        /// <summary>
        /// Gets or Sets natureza_juridica
        /// </summary>
        [DataMember(Name = "natureza_juridica", EmitDefaultValue = false)]
        public CnpjNaturezaJuridica natureza_juridica { get; set; }

        /// <summary>
        /// Capital social da empresa.
        /// </summary>
        /// <value>Capital social da empresa.</value>
        [DataMember(Name = "capital_social", EmitDefaultValue = false)]
        public decimal capital_social { get; set; }

        /// <summary>
        /// Gets or Sets porte
        /// </summary>
        [DataMember(Name = "porte", EmitDefaultValue = false)]
        public CnpjPorteEmpresa porte { get; set; }

        /// <summary>
        /// O ente federativo responsável é preenchido para os casos de órgãos e  entidades do grupo de natureza jurídica 1XXX. Para as demais naturezas,  este atributo fica em branco.
        /// </summary>
        /// <value>O ente federativo responsável é preenchido para os casos de órgãos e  entidades do grupo de natureza jurídica 1XXX. Para as demais naturezas,  este atributo fica em branco.</value>
        [DataMember(Name = "ente_federativo_responsavel", EmitDefaultValue = false)]
        public string ente_federativo_responsavel { get; set; }

        /// <summary>
        /// Gets or Sets situacao_cadastral
        /// </summary>
        [DataMember(Name = "situacao_cadastral", EmitDefaultValue = false)]
        public CnpjSituacaoCadastral situacao_cadastral { get; set; }

        /// <summary>
        /// Gets or Sets motivo_situacao_cadastral
        /// </summary>
        [DataMember(Name = "motivo_situacao_cadastral", EmitDefaultValue = false)]
        public CnpjMotivoSituacaoCadastral motivo_situacao_cadastral { get; set; }

        /// <summary>
        /// Nome da cidade no exterior.
        /// </summary>
        /// <value>Nome da cidade no exterior.</value>
        [DataMember(Name = "nome_da_cidade_no_exterior", EmitDefaultValue = false)]
        public string nome_da_cidade_no_exterior { get; set; }

        /// <summary>
        /// Gets or Sets pais
        /// </summary>
        [DataMember(Name = "pais", EmitDefaultValue = false)]
        public CnpjPais pais { get; set; }

        /// <summary>
        /// Gets or Sets atividade_principal
        /// </summary>
        [DataMember(Name = "atividade_principal", EmitDefaultValue = false)]
        public CnpjCnae atividade_principal { get; set; }

        /// <summary>
        /// Gets or Sets atividades_secundarias
        /// </summary>
        [DataMember(Name = "atividades_secundarias", EmitDefaultValue = false)]
        public List<CnpjCnaeSecundario> atividades_secundarias { get; set; }

        /// <summary>
        /// Gets or Sets endereco
        /// </summary>
        [DataMember(Name = "endereco", EmitDefaultValue = false)]
        public CnpjEndereco endereco { get; set; }

        /// <summary>
        /// Gets or Sets telefones
        /// </summary>
        [DataMember(Name = "telefones", EmitDefaultValue = false)]
        public List<CnpjTelefone> telefones { get; set; }

        /// <summary>
        /// E-mail do contribuinte.
        /// </summary>
        /// <value>E-mail do contribuinte.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets situacao_especial
        /// </summary>
        [DataMember(Name = "situacao_especial", EmitDefaultValue = false)]
        public CnpjSituacaoEspecial situacao_especial { get; set; }

        /// <summary>
        /// Gets or Sets simples
        /// </summary>
        [DataMember(Name = "simples", EmitDefaultValue = false)]
        public CnpjOpcaoSimples simples { get; set; }

        /// <summary>
        /// Gets or Sets simei
        /// </summary>
        [DataMember(Name = "simei", EmitDefaultValue = false)]
        public CnpjOpcaoSimei simei { get; set; }

        /// <summary>
        /// Gets or Sets socios
        /// </summary>
        [DataMember(Name = "socios", EmitDefaultValue = false)]
        public List<CnpjSocio> socios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjEmpresa {\n");
            sb.Append("  cnpj: ").Append(cnpj).Append("\n");
            sb.Append("  razao_social: ").Append(razao_social).Append("\n");
            sb.Append("  nome_fantasia: ").Append(nome_fantasia).Append("\n");
            sb.Append("  data_inicio_atividade: ").Append(data_inicio_atividade).Append("\n");
            sb.Append("  matriz: ").Append(matriz).Append("\n");
            sb.Append("  natureza_juridica: ").Append(natureza_juridica).Append("\n");
            sb.Append("  capital_social: ").Append(capital_social).Append("\n");
            sb.Append("  porte: ").Append(porte).Append("\n");
            sb.Append("  ente_federativo_responsavel: ").Append(ente_federativo_responsavel).Append("\n");
            sb.Append("  situacao_cadastral: ").Append(situacao_cadastral).Append("\n");
            sb.Append("  motivo_situacao_cadastral: ").Append(motivo_situacao_cadastral).Append("\n");
            sb.Append("  nome_da_cidade_no_exterior: ").Append(nome_da_cidade_no_exterior).Append("\n");
            sb.Append("  pais: ").Append(pais).Append("\n");
            sb.Append("  atividade_principal: ").Append(atividade_principal).Append("\n");
            sb.Append("  atividades_secundarias: ").Append(atividades_secundarias).Append("\n");
            sb.Append("  endereco: ").Append(endereco).Append("\n");
            sb.Append("  telefones: ").Append(telefones).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  situacao_especial: ").Append(situacao_especial).Append("\n");
            sb.Append("  simples: ").Append(simples).Append("\n");
            sb.Append("  simei: ").Append(simei).Append("\n");
            sb.Append("  socios: ").Append(socios).Append("\n");
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
            return this.Equals(input as CnpjEmpresa);
        }

        /// <summary>
        /// Returns true if CnpjEmpresa instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjEmpresa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjEmpresa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cnpj == input.cnpj ||
                    (this.cnpj != null &&
                    this.cnpj.Equals(input.cnpj))
                ) && 
                (
                    this.razao_social == input.razao_social ||
                    (this.razao_social != null &&
                    this.razao_social.Equals(input.razao_social))
                ) && 
                (
                    this.nome_fantasia == input.nome_fantasia ||
                    (this.nome_fantasia != null &&
                    this.nome_fantasia.Equals(input.nome_fantasia))
                ) && 
                (
                    this.data_inicio_atividade == input.data_inicio_atividade ||
                    (this.data_inicio_atividade != null &&
                    this.data_inicio_atividade.Equals(input.data_inicio_atividade))
                ) && 
                (
                    this.matriz == input.matriz ||
                    this.matriz.Equals(input.matriz)
                ) && 
                (
                    this.natureza_juridica == input.natureza_juridica ||
                    (this.natureza_juridica != null &&
                    this.natureza_juridica.Equals(input.natureza_juridica))
                ) && 
                (
                    this.capital_social == input.capital_social ||
                    this.capital_social.Equals(input.capital_social)
                ) && 
                (
                    this.porte == input.porte ||
                    (this.porte != null &&
                    this.porte.Equals(input.porte))
                ) && 
                (
                    this.ente_federativo_responsavel == input.ente_federativo_responsavel ||
                    (this.ente_federativo_responsavel != null &&
                    this.ente_federativo_responsavel.Equals(input.ente_federativo_responsavel))
                ) && 
                (
                    this.situacao_cadastral == input.situacao_cadastral ||
                    (this.situacao_cadastral != null &&
                    this.situacao_cadastral.Equals(input.situacao_cadastral))
                ) && 
                (
                    this.motivo_situacao_cadastral == input.motivo_situacao_cadastral ||
                    (this.motivo_situacao_cadastral != null &&
                    this.motivo_situacao_cadastral.Equals(input.motivo_situacao_cadastral))
                ) && 
                (
                    this.nome_da_cidade_no_exterior == input.nome_da_cidade_no_exterior ||
                    (this.nome_da_cidade_no_exterior != null &&
                    this.nome_da_cidade_no_exterior.Equals(input.nome_da_cidade_no_exterior))
                ) && 
                (
                    this.pais == input.pais ||
                    (this.pais != null &&
                    this.pais.Equals(input.pais))
                ) && 
                (
                    this.atividade_principal == input.atividade_principal ||
                    (this.atividade_principal != null &&
                    this.atividade_principal.Equals(input.atividade_principal))
                ) && 
                (
                    this.atividades_secundarias == input.atividades_secundarias ||
                    this.atividades_secundarias != null &&
                    input.atividades_secundarias != null &&
                    this.atividades_secundarias.SequenceEqual(input.atividades_secundarias)
                ) && 
                (
                    this.endereco == input.endereco ||
                    (this.endereco != null &&
                    this.endereco.Equals(input.endereco))
                ) && 
                (
                    this.telefones == input.telefones ||
                    this.telefones != null &&
                    input.telefones != null &&
                    this.telefones.SequenceEqual(input.telefones)
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.situacao_especial == input.situacao_especial ||
                    (this.situacao_especial != null &&
                    this.situacao_especial.Equals(input.situacao_especial))
                ) && 
                (
                    this.simples == input.simples ||
                    (this.simples != null &&
                    this.simples.Equals(input.simples))
                ) && 
                (
                    this.simei == input.simei ||
                    (this.simei != null &&
                    this.simei.Equals(input.simei))
                ) && 
                (
                    this.socios == input.socios ||
                    this.socios != null &&
                    input.socios != null &&
                    this.socios.SequenceEqual(input.socios)
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
                if (this.cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cnpj.GetHashCode();
                }
                if (this.razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.razao_social.GetHashCode();
                }
                if (this.nome_fantasia != null)
                {
                    hashCode = (hashCode * 59) + this.nome_fantasia.GetHashCode();
                }
                if (this.data_inicio_atividade != null)
                {
                    hashCode = (hashCode * 59) + this.data_inicio_atividade.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.matriz.GetHashCode();
                if (this.natureza_juridica != null)
                {
                    hashCode = (hashCode * 59) + this.natureza_juridica.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.capital_social.GetHashCode();
                if (this.porte != null)
                {
                    hashCode = (hashCode * 59) + this.porte.GetHashCode();
                }
                if (this.ente_federativo_responsavel != null)
                {
                    hashCode = (hashCode * 59) + this.ente_federativo_responsavel.GetHashCode();
                }
                if (this.situacao_cadastral != null)
                {
                    hashCode = (hashCode * 59) + this.situacao_cadastral.GetHashCode();
                }
                if (this.motivo_situacao_cadastral != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_situacao_cadastral.GetHashCode();
                }
                if (this.nome_da_cidade_no_exterior != null)
                {
                    hashCode = (hashCode * 59) + this.nome_da_cidade_no_exterior.GetHashCode();
                }
                if (this.pais != null)
                {
                    hashCode = (hashCode * 59) + this.pais.GetHashCode();
                }
                if (this.atividade_principal != null)
                {
                    hashCode = (hashCode * 59) + this.atividade_principal.GetHashCode();
                }
                if (this.atividades_secundarias != null)
                {
                    hashCode = (hashCode * 59) + this.atividades_secundarias.GetHashCode();
                }
                if (this.endereco != null)
                {
                    hashCode = (hashCode * 59) + this.endereco.GetHashCode();
                }
                if (this.telefones != null)
                {
                    hashCode = (hashCode * 59) + this.telefones.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
                }
                if (this.situacao_especial != null)
                {
                    hashCode = (hashCode * 59) + this.situacao_especial.GetHashCode();
                }
                if (this.simples != null)
                {
                    hashCode = (hashCode * 59) + this.simples.GetHashCode();
                }
                if (this.simei != null)
                {
                    hashCode = (hashCode * 59) + this.simei.GetHashCode();
                }
                if (this.socios != null)
                {
                    hashCode = (hashCode * 59) + this.socios.GetHashCode();
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
