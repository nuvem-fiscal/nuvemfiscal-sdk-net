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
    /// RpsPedidoEmissao
    /// </summary>
    [DataContract(Name = "RpsPedidoEmissao")]
    public partial class RpsPedidoEmissao : IEquatable<RpsPedidoEmissao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsPedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RpsPedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsPedidoEmissao" /> class.
        /// </summary>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        /// <param name="dataEmissao">Data e Hora de Emissão do RPS, no formato AAAA-MM-DDTHH:MM:SSTZD.  Caso não informado, será considerada a data/hora da requisição à API da Nuvem Fiscal..</param>
        /// <param name="competencia">Competência do RPS, no formato AAAA-MM-DD.  Caso não informado, será considerada a data da requisição à API da Nuvem Fiscal..</param>
        /// <param name="naturezaTributacao">Natureza da tributação:  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial..</param>
        /// <param name="prestador">prestador (required).</param>
        /// <param name="tomador">tomador (required).</param>
        /// <param name="intermediario">intermediario.</param>
        /// <param name="construcaoCivil">construcaoCivil.</param>
        /// <param name="servicos">servicos (required).</param>
        public RpsPedidoEmissao(string referencia = default(string), DateTime dataEmissao = default(DateTime), DateTime competencia = default(DateTime), int naturezaTributacao = default(int), RpsIdentificacaoPrestador prestador = default(RpsIdentificacaoPrestador), RpsDadosTomador tomador = default(RpsDadosTomador), RpsDadosIntermediario intermediario = default(RpsDadosIntermediario), RpsDadosConstrucaoCivil construcaoCivil = default(RpsDadosConstrucaoCivil), List<RpsDadosServico> servicos = default(List<RpsDadosServico>))
        {
            // to ensure "prestador" is required (not null)
            if (prestador == null)
            {
                throw new ArgumentNullException("prestador is a required property for RpsPedidoEmissao and cannot be null");
            }
            this.prestador = prestador;
            // to ensure "tomador" is required (not null)
            if (tomador == null)
            {
                throw new ArgumentNullException("tomador is a required property for RpsPedidoEmissao and cannot be null");
            }
            this.tomador = tomador;
            // to ensure "servicos" is required (not null)
            if (servicos == null)
            {
                throw new ArgumentNullException("servicos is a required property for RpsPedidoEmissao and cannot be null");
            }
            this.servicos = servicos;
            this.referencia = referencia;
            this.data_emissao = dataEmissao;
            this.competencia = competencia;
            this.natureza_tributacao = naturezaTributacao;
            this.intermediario = intermediario;
            this.construcao_civil = construcaoCivil;
        }

        /// <summary>
        /// Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Data e Hora de Emissão do RPS, no formato AAAA-MM-DDTHH:MM:SSTZD.  Caso não informado, será considerada a data/hora da requisição à API da Nuvem Fiscal.
        /// </summary>
        /// <value>Data e Hora de Emissão do RPS, no formato AAAA-MM-DDTHH:MM:SSTZD.  Caso não informado, será considerada a data/hora da requisição à API da Nuvem Fiscal.</value>
        [DataMember(Name = "data_emissao", EmitDefaultValue = false)]
        public DateTime data_emissao { get; set; }

        /// <summary>
        /// Competência do RPS, no formato AAAA-MM-DD.  Caso não informado, será considerada a data da requisição à API da Nuvem Fiscal.
        /// </summary>
        /// <value>Competência do RPS, no formato AAAA-MM-DD.  Caso não informado, será considerada a data da requisição à API da Nuvem Fiscal.</value>
        [DataMember(Name = "competencia", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime competencia { get; set; }

        /// <summary>
        /// Natureza da tributação:  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial.
        /// </summary>
        /// <value>Natureza da tributação:  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial.</value>
        [DataMember(Name = "natureza_tributacao", EmitDefaultValue = false)]
        public int natureza_tributacao { get; set; }

        /// <summary>
        /// Gets or Sets prestador
        /// </summary>
        [DataMember(Name = "prestador", IsRequired = true, EmitDefaultValue = false)]
        public RpsIdentificacaoPrestador prestador { get; set; }

        /// <summary>
        /// Gets or Sets tomador
        /// </summary>
        [DataMember(Name = "tomador", IsRequired = true, EmitDefaultValue = false)]
        public RpsDadosTomador tomador { get; set; }

        /// <summary>
        /// Gets or Sets intermediario
        /// </summary>
        [DataMember(Name = "intermediario", EmitDefaultValue = false)]
        public RpsDadosIntermediario intermediario { get; set; }

        /// <summary>
        /// Gets or Sets construcao_civil
        /// </summary>
        [DataMember(Name = "construcao_civil", EmitDefaultValue = false)]
        public RpsDadosConstrucaoCivil construcao_civil { get; set; }

        /// <summary>
        /// Gets or Sets servicos
        /// </summary>
        [DataMember(Name = "servicos", IsRequired = true, EmitDefaultValue = false)]
        public List<RpsDadosServico> servicos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsPedidoEmissao {\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  data_emissao: ").Append(data_emissao).Append("\n");
            sb.Append("  competencia: ").Append(competencia).Append("\n");
            sb.Append("  natureza_tributacao: ").Append(natureza_tributacao).Append("\n");
            sb.Append("  prestador: ").Append(prestador).Append("\n");
            sb.Append("  tomador: ").Append(tomador).Append("\n");
            sb.Append("  intermediario: ").Append(intermediario).Append("\n");
            sb.Append("  construcao_civil: ").Append(construcao_civil).Append("\n");
            sb.Append("  servicos: ").Append(servicos).Append("\n");
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
            return this.Equals(input as RpsPedidoEmissao);
        }

        /// <summary>
        /// Returns true if RpsPedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsPedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsPedidoEmissao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
                ) && 
                (
                    this.data_emissao == input.data_emissao ||
                    (this.data_emissao != null &&
                    this.data_emissao.Equals(input.data_emissao))
                ) && 
                (
                    this.competencia == input.competencia ||
                    (this.competencia != null &&
                    this.competencia.Equals(input.competencia))
                ) && 
                (
                    this.natureza_tributacao == input.natureza_tributacao ||
                    this.natureza_tributacao.Equals(input.natureza_tributacao)
                ) && 
                (
                    this.prestador == input.prestador ||
                    (this.prestador != null &&
                    this.prestador.Equals(input.prestador))
                ) && 
                (
                    this.tomador == input.tomador ||
                    (this.tomador != null &&
                    this.tomador.Equals(input.tomador))
                ) && 
                (
                    this.intermediario == input.intermediario ||
                    (this.intermediario != null &&
                    this.intermediario.Equals(input.intermediario))
                ) && 
                (
                    this.construcao_civil == input.construcao_civil ||
                    (this.construcao_civil != null &&
                    this.construcao_civil.Equals(input.construcao_civil))
                ) && 
                (
                    this.servicos == input.servicos ||
                    this.servicos != null &&
                    input.servicos != null &&
                    this.servicos.SequenceEqual(input.servicos)
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
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
                }
                if (this.data_emissao != null)
                {
                    hashCode = (hashCode * 59) + this.data_emissao.GetHashCode();
                }
                if (this.competencia != null)
                {
                    hashCode = (hashCode * 59) + this.competencia.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.natureza_tributacao.GetHashCode();
                if (this.prestador != null)
                {
                    hashCode = (hashCode * 59) + this.prestador.GetHashCode();
                }
                if (this.tomador != null)
                {
                    hashCode = (hashCode * 59) + this.tomador.GetHashCode();
                }
                if (this.intermediario != null)
                {
                    hashCode = (hashCode * 59) + this.intermediario.GetHashCode();
                }
                if (this.construcao_civil != null)
                {
                    hashCode = (hashCode * 59) + this.construcao_civil.GetHashCode();
                }
                if (this.servicos != null)
                {
                    hashCode = (hashCode * 59) + this.servicos.GetHashCode();
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
