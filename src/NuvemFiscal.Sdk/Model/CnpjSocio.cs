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
    /// Quadro Societário.
    /// </summary>
    [DataContract(Name = "CnpjSocio")]
    public partial class CnpjSocio : IEquatable<CnpjSocio>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjSocio" /> class.
        /// </summary>
        /// <param name="identificadorSocio">identificadorSocio.</param>
        /// <param name="nome">Nome do sócio pessoa física ou a razão social e/ou nome empresarial da  pessoa jurídica e/ou nome do sócio/razão social do sócio estrangeiro..</param>
        /// <param name="cpfCnpj">CPF ou CNPJ do sócio (sócio estrangeiro não tem esta informação)..</param>
        /// <param name="qualificacao">qualificacao.</param>
        /// <param name="dataEntradaSociedade">Data de entrada na sociedade..</param>
        /// <param name="pais">pais.</param>
        /// <param name="representanteLegal">representanteLegal.</param>
        /// <param name="faixaEtaria">faixaEtaria.</param>
        public CnpjSocio(CnpjIdentificadorSocio identificadorSocio = default(CnpjIdentificadorSocio), string nome = default(string), string cpfCnpj = default(string), CnpjQualificacaoSocio qualificacao = default(CnpjQualificacaoSocio), DateTime dataEntradaSociedade = default(DateTime), CnpjPais pais = default(CnpjPais), CnpjRepresentanteLegal representanteLegal = default(CnpjRepresentanteLegal), CnpjFaixaEtaria faixaEtaria = default(CnpjFaixaEtaria))
        {
            this.identificador_socio = identificadorSocio;
            this.nome = nome;
            this.cpf_cnpj = cpfCnpj;
            this.qualificacao = qualificacao;
            this.data_entrada_sociedade = dataEntradaSociedade;
            this.pais = pais;
            this.representante_legal = representanteLegal;
            this.faixa_etaria = faixaEtaria;
        }

        /// <summary>
        /// Gets or Sets identificador_socio
        /// </summary>
        [DataMember(Name = "identificador_socio", EmitDefaultValue = false)]
        public CnpjIdentificadorSocio identificador_socio { get; set; }

        /// <summary>
        /// Nome do sócio pessoa física ou a razão social e/ou nome empresarial da  pessoa jurídica e/ou nome do sócio/razão social do sócio estrangeiro.
        /// </summary>
        /// <value>Nome do sócio pessoa física ou a razão social e/ou nome empresarial da  pessoa jurídica e/ou nome do sócio/razão social do sócio estrangeiro.</value>
        [DataMember(Name = "nome", EmitDefaultValue = false)]
        public string nome { get; set; }

        /// <summary>
        /// CPF ou CNPJ do sócio (sócio estrangeiro não tem esta informação).
        /// </summary>
        /// <value>CPF ou CNPJ do sócio (sócio estrangeiro não tem esta informação).</value>
        [DataMember(Name = "cpf_cnpj", EmitDefaultValue = false)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Gets or Sets qualificacao
        /// </summary>
        [DataMember(Name = "qualificacao", EmitDefaultValue = false)]
        public CnpjQualificacaoSocio qualificacao { get; set; }

        /// <summary>
        /// Data de entrada na sociedade.
        /// </summary>
        /// <value>Data de entrada na sociedade.</value>
        [DataMember(Name = "data_entrada_sociedade", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data_entrada_sociedade { get; set; }

        /// <summary>
        /// Gets or Sets pais
        /// </summary>
        [DataMember(Name = "pais", EmitDefaultValue = false)]
        public CnpjPais pais { get; set; }

        /// <summary>
        /// Gets or Sets representante_legal
        /// </summary>
        [DataMember(Name = "representante_legal", EmitDefaultValue = false)]
        public CnpjRepresentanteLegal representante_legal { get; set; }

        /// <summary>
        /// Gets or Sets faixa_etaria
        /// </summary>
        [DataMember(Name = "faixa_etaria", EmitDefaultValue = false)]
        public CnpjFaixaEtaria faixa_etaria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjSocio {\n");
            sb.Append("  identificador_socio: ").Append(identificador_socio).Append("\n");
            sb.Append("  nome: ").Append(nome).Append("\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  qualificacao: ").Append(qualificacao).Append("\n");
            sb.Append("  data_entrada_sociedade: ").Append(data_entrada_sociedade).Append("\n");
            sb.Append("  pais: ").Append(pais).Append("\n");
            sb.Append("  representante_legal: ").Append(representante_legal).Append("\n");
            sb.Append("  faixa_etaria: ").Append(faixa_etaria).Append("\n");
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
            return this.Equals(input as CnpjSocio);
        }

        /// <summary>
        /// Returns true if CnpjSocio instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjSocio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjSocio input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.identificador_socio == input.identificador_socio ||
                    (this.identificador_socio != null &&
                    this.identificador_socio.Equals(input.identificador_socio))
                ) && 
                (
                    this.nome == input.nome ||
                    (this.nome != null &&
                    this.nome.Equals(input.nome))
                ) && 
                (
                    this.cpf_cnpj == input.cpf_cnpj ||
                    (this.cpf_cnpj != null &&
                    this.cpf_cnpj.Equals(input.cpf_cnpj))
                ) && 
                (
                    this.qualificacao == input.qualificacao ||
                    (this.qualificacao != null &&
                    this.qualificacao.Equals(input.qualificacao))
                ) && 
                (
                    this.data_entrada_sociedade == input.data_entrada_sociedade ||
                    (this.data_entrada_sociedade != null &&
                    this.data_entrada_sociedade.Equals(input.data_entrada_sociedade))
                ) && 
                (
                    this.pais == input.pais ||
                    (this.pais != null &&
                    this.pais.Equals(input.pais))
                ) && 
                (
                    this.representante_legal == input.representante_legal ||
                    (this.representante_legal != null &&
                    this.representante_legal.Equals(input.representante_legal))
                ) && 
                (
                    this.faixa_etaria == input.faixa_etaria ||
                    (this.faixa_etaria != null &&
                    this.faixa_etaria.Equals(input.faixa_etaria))
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
                if (this.identificador_socio != null)
                {
                    hashCode = (hashCode * 59) + this.identificador_socio.GetHashCode();
                }
                if (this.nome != null)
                {
                    hashCode = (hashCode * 59) + this.nome.GetHashCode();
                }
                if (this.cpf_cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_cnpj.GetHashCode();
                }
                if (this.qualificacao != null)
                {
                    hashCode = (hashCode * 59) + this.qualificacao.GetHashCode();
                }
                if (this.data_entrada_sociedade != null)
                {
                    hashCode = (hashCode * 59) + this.data_entrada_sociedade.GetHashCode();
                }
                if (this.pais != null)
                {
                    hashCode = (hashCode * 59) + this.pais.GetHashCode();
                }
                if (this.representante_legal != null)
                {
                    hashCode = (hashCode * 59) + this.representante_legal.GetHashCode();
                }
                if (this.faixa_etaria != null)
                {
                    hashCode = (hashCode * 59) + this.faixa_etaria.GetHashCode();
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
            yield break;
        }
    }

}
