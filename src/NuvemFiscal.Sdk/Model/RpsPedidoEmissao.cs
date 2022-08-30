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
        /// <param name="referencia">referencia.</param>
        /// <param name="dataEmissao">dataEmissao.</param>
        /// <param name="competencia">competencia.</param>
        /// <param name="naturezaTributacao">naturezaTributacao.</param>
        /// <param name="prestador">prestador.</param>
        /// <param name="tomador">tomador.</param>
        /// <param name="intermediario">intermediario.</param>
        /// <param name="construcaoCivil">construcaoCivil.</param>
        /// <param name="servicos">servicos.</param>
        public RpsPedidoEmissao(string referencia = default(string), DateTime dataEmissao = default(DateTime), DateTime competencia = default(DateTime), int naturezaTributacao = default(int), RpsIdentificacaoPrestador prestador = default(RpsIdentificacaoPrestador), RpsDadosTomador tomador = default(RpsDadosTomador), RpsDadosIntermediario intermediario = default(RpsDadosIntermediario), RpsDadosConstrucaoCivil construcaoCivil = default(RpsDadosConstrucaoCivil), List<RpsDadosServico> servicos = default(List<RpsDadosServico>))
        {
            this.referencia = referencia;
            this.data_emissao = dataEmissao;
            this.competencia = competencia;
            this.natureza_tributacao = naturezaTributacao;
            this.prestador = prestador;
            this.tomador = tomador;
            this.intermediario = intermediario;
            this.construcao_civil = construcaoCivil;
            this.servicos = servicos;
        }

        /// <summary>
        /// Gets or Sets referencia
        /// </summary>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets data_emissao
        /// </summary>
        [DataMember(Name = "data_emissao", EmitDefaultValue = false)]
        public DateTime data_emissao { get; set; }

        /// <summary>
        /// Gets or Sets competencia
        /// </summary>
        [DataMember(Name = "competencia", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime competencia { get; set; }

        /// <summary>
        /// Gets or Sets natureza_tributacao
        /// </summary>
        [DataMember(Name = "natureza_tributacao", EmitDefaultValue = false)]
        public int natureza_tributacao { get; set; }

        /// <summary>
        /// Gets or Sets prestador
        /// </summary>
        [DataMember(Name = "prestador", EmitDefaultValue = false)]
        public RpsIdentificacaoPrestador prestador { get; set; }

        /// <summary>
        /// Gets or Sets tomador
        /// </summary>
        [DataMember(Name = "tomador", EmitDefaultValue = false)]
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
        [DataMember(Name = "servicos", EmitDefaultValue = false)]
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
