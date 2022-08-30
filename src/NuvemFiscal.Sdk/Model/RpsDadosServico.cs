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
    /// RpsDadosServico
    /// </summary>
    [DataContract(Name = "RpsDadosServico")]
    public partial class RpsDadosServico : IEquatable<RpsDadosServico>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosServico" /> class.
        /// </summary>
        /// <param name="issRetido">issRetido.</param>
        /// <param name="responsavelRetencao">responsavelRetencao.</param>
        /// <param name="itemListaServico">itemListaServico.</param>
        /// <param name="codigoCnae">codigoCnae.</param>
        /// <param name="codigoTributacaoMunicipio">codigoTributacaoMunicipio.</param>
        /// <param name="discriminacao">discriminacao.</param>
        /// <param name="codigoMunicipio">codigoMunicipio.</param>
        /// <param name="codigoPais">codigoPais.</param>
        /// <param name="tipoTributacao">tipoTributacao.</param>
        /// <param name="exigibilidadeIss">exigibilidadeIss.</param>
        /// <param name="codigoMunicipioIncidencia">codigoMunicipioIncidencia.</param>
        /// <param name="numeroProcesso">numeroProcesso.</param>
        /// <param name="unidade">unidade.</param>
        /// <param name="quantidade">quantidade.</param>
        /// <param name="valores">valores.</param>
        public RpsDadosServico(bool issRetido = default(bool), int responsavelRetencao = default(int), string itemListaServico = default(string), string codigoCnae = default(string), string codigoTributacaoMunicipio = default(string), string discriminacao = default(string), string codigoMunicipio = default(string), string codigoPais = default(string), int tipoTributacao = default(int), int exigibilidadeIss = default(int), string codigoMunicipioIncidencia = default(string), string numeroProcesso = default(string), string unidade = default(string), decimal quantidade = default(decimal), RpsServicoValores valores = default(RpsServicoValores))
        {
            this.iss_retido = issRetido;
            this.responsavel_retencao = responsavelRetencao;
            this.item_lista_servico = itemListaServico;
            this.codigo_cnae = codigoCnae;
            this.codigo_tributacao_municipio = codigoTributacaoMunicipio;
            this.discriminacao = discriminacao;
            this.codigo_municipio = codigoMunicipio;
            this.codigo_pais = codigoPais;
            this.tipo_tributacao = tipoTributacao;
            this.exigibilidade_iss = exigibilidadeIss;
            this.codigo_municipio_incidencia = codigoMunicipioIncidencia;
            this.numero_processo = numeroProcesso;
            this.unidade = unidade;
            this.quantidade = quantidade;
            this.valores = valores;
        }

        /// <summary>
        /// Gets or Sets iss_retido
        /// </summary>
        [DataMember(Name = "iss_retido", EmitDefaultValue = true)]
        public bool iss_retido { get; set; }

        /// <summary>
        /// Gets or Sets responsavel_retencao
        /// </summary>
        [DataMember(Name = "responsavel_retencao", EmitDefaultValue = false)]
        public int responsavel_retencao { get; set; }

        /// <summary>
        /// Gets or Sets item_lista_servico
        /// </summary>
        [DataMember(Name = "item_lista_servico", EmitDefaultValue = false)]
        public string item_lista_servico { get; set; }

        /// <summary>
        /// Gets or Sets codigo_cnae
        /// </summary>
        [DataMember(Name = "codigo_cnae", EmitDefaultValue = false)]
        public string codigo_cnae { get; set; }

        /// <summary>
        /// Gets or Sets codigo_tributacao_municipio
        /// </summary>
        [DataMember(Name = "codigo_tributacao_municipio", EmitDefaultValue = false)]
        public string codigo_tributacao_municipio { get; set; }

        /// <summary>
        /// Gets or Sets discriminacao
        /// </summary>
        [DataMember(Name = "discriminacao", EmitDefaultValue = false)]
        public string discriminacao { get; set; }

        /// <summary>
        /// Gets or Sets codigo_municipio
        /// </summary>
        [DataMember(Name = "codigo_municipio", EmitDefaultValue = false)]
        public string codigo_municipio { get; set; }

        /// <summary>
        /// Gets or Sets codigo_pais
        /// </summary>
        [DataMember(Name = "codigo_pais", EmitDefaultValue = false)]
        public string codigo_pais { get; set; }

        /// <summary>
        /// Gets or Sets tipo_tributacao
        /// </summary>
        [DataMember(Name = "tipo_tributacao", EmitDefaultValue = false)]
        public int tipo_tributacao { get; set; }

        /// <summary>
        /// Gets or Sets exigibilidade_iss
        /// </summary>
        [DataMember(Name = "exigibilidade_iss", EmitDefaultValue = false)]
        public int exigibilidade_iss { get; set; }

        /// <summary>
        /// Gets or Sets codigo_municipio_incidencia
        /// </summary>
        [DataMember(Name = "codigo_municipio_incidencia", EmitDefaultValue = false)]
        public string codigo_municipio_incidencia { get; set; }

        /// <summary>
        /// Gets or Sets numero_processo
        /// </summary>
        [DataMember(Name = "numero_processo", EmitDefaultValue = false)]
        public string numero_processo { get; set; }

        /// <summary>
        /// Gets or Sets unidade
        /// </summary>
        [DataMember(Name = "unidade", EmitDefaultValue = false)]
        public string unidade { get; set; }

        /// <summary>
        /// Gets or Sets quantidade
        /// </summary>
        [DataMember(Name = "quantidade", EmitDefaultValue = false)]
        public decimal quantidade { get; set; }

        /// <summary>
        /// Gets or Sets valores
        /// </summary>
        [DataMember(Name = "valores", EmitDefaultValue = false)]
        public RpsServicoValores valores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsDadosServico {\n");
            sb.Append("  iss_retido: ").Append(iss_retido).Append("\n");
            sb.Append("  responsavel_retencao: ").Append(responsavel_retencao).Append("\n");
            sb.Append("  item_lista_servico: ").Append(item_lista_servico).Append("\n");
            sb.Append("  codigo_cnae: ").Append(codigo_cnae).Append("\n");
            sb.Append("  codigo_tributacao_municipio: ").Append(codigo_tributacao_municipio).Append("\n");
            sb.Append("  discriminacao: ").Append(discriminacao).Append("\n");
            sb.Append("  codigo_municipio: ").Append(codigo_municipio).Append("\n");
            sb.Append("  codigo_pais: ").Append(codigo_pais).Append("\n");
            sb.Append("  tipo_tributacao: ").Append(tipo_tributacao).Append("\n");
            sb.Append("  exigibilidade_iss: ").Append(exigibilidade_iss).Append("\n");
            sb.Append("  codigo_municipio_incidencia: ").Append(codigo_municipio_incidencia).Append("\n");
            sb.Append("  numero_processo: ").Append(numero_processo).Append("\n");
            sb.Append("  unidade: ").Append(unidade).Append("\n");
            sb.Append("  quantidade: ").Append(quantidade).Append("\n");
            sb.Append("  valores: ").Append(valores).Append("\n");
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
            return this.Equals(input as RpsDadosServico);
        }

        /// <summary>
        /// Returns true if RpsDadosServico instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsDadosServico to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsDadosServico input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.iss_retido == input.iss_retido ||
                    this.iss_retido.Equals(input.iss_retido)
                ) && 
                (
                    this.responsavel_retencao == input.responsavel_retencao ||
                    this.responsavel_retencao.Equals(input.responsavel_retencao)
                ) && 
                (
                    this.item_lista_servico == input.item_lista_servico ||
                    (this.item_lista_servico != null &&
                    this.item_lista_servico.Equals(input.item_lista_servico))
                ) && 
                (
                    this.codigo_cnae == input.codigo_cnae ||
                    (this.codigo_cnae != null &&
                    this.codigo_cnae.Equals(input.codigo_cnae))
                ) && 
                (
                    this.codigo_tributacao_municipio == input.codigo_tributacao_municipio ||
                    (this.codigo_tributacao_municipio != null &&
                    this.codigo_tributacao_municipio.Equals(input.codigo_tributacao_municipio))
                ) && 
                (
                    this.discriminacao == input.discriminacao ||
                    (this.discriminacao != null &&
                    this.discriminacao.Equals(input.discriminacao))
                ) && 
                (
                    this.codigo_municipio == input.codigo_municipio ||
                    (this.codigo_municipio != null &&
                    this.codigo_municipio.Equals(input.codigo_municipio))
                ) && 
                (
                    this.codigo_pais == input.codigo_pais ||
                    (this.codigo_pais != null &&
                    this.codigo_pais.Equals(input.codigo_pais))
                ) && 
                (
                    this.tipo_tributacao == input.tipo_tributacao ||
                    this.tipo_tributacao.Equals(input.tipo_tributacao)
                ) && 
                (
                    this.exigibilidade_iss == input.exigibilidade_iss ||
                    this.exigibilidade_iss.Equals(input.exigibilidade_iss)
                ) && 
                (
                    this.codigo_municipio_incidencia == input.codigo_municipio_incidencia ||
                    (this.codigo_municipio_incidencia != null &&
                    this.codigo_municipio_incidencia.Equals(input.codigo_municipio_incidencia))
                ) && 
                (
                    this.numero_processo == input.numero_processo ||
                    (this.numero_processo != null &&
                    this.numero_processo.Equals(input.numero_processo))
                ) && 
                (
                    this.unidade == input.unidade ||
                    (this.unidade != null &&
                    this.unidade.Equals(input.unidade))
                ) && 
                (
                    this.quantidade == input.quantidade ||
                    this.quantidade.Equals(input.quantidade)
                ) && 
                (
                    this.valores == input.valores ||
                    (this.valores != null &&
                    this.valores.Equals(input.valores))
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
                hashCode = (hashCode * 59) + this.iss_retido.GetHashCode();
                hashCode = (hashCode * 59) + this.responsavel_retencao.GetHashCode();
                if (this.item_lista_servico != null)
                {
                    hashCode = (hashCode * 59) + this.item_lista_servico.GetHashCode();
                }
                if (this.codigo_cnae != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_cnae.GetHashCode();
                }
                if (this.codigo_tributacao_municipio != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_tributacao_municipio.GetHashCode();
                }
                if (this.discriminacao != null)
                {
                    hashCode = (hashCode * 59) + this.discriminacao.GetHashCode();
                }
                if (this.codigo_municipio != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_municipio.GetHashCode();
                }
                if (this.codigo_pais != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_pais.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tipo_tributacao.GetHashCode();
                hashCode = (hashCode * 59) + this.exigibilidade_iss.GetHashCode();
                if (this.codigo_municipio_incidencia != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_municipio_incidencia.GetHashCode();
                }
                if (this.numero_processo != null)
                {
                    hashCode = (hashCode * 59) + this.numero_processo.GetHashCode();
                }
                if (this.unidade != null)
                {
                    hashCode = (hashCode * 59) + this.unidade.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.quantidade.GetHashCode();
                if (this.valores != null)
                {
                    hashCode = (hashCode * 59) + this.valores.GetHashCode();
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
