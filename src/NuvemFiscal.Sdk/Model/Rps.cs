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
    /// *Propriedade obsoleta. Não é mais retornada pela API.*
    /// </summary>
    [DataContract(Name = "Rps")]
    public partial class Rps : IEquatable<Rps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rps" /> class.
        /// </summary>
        /// <param name="rps">rps.</param>
        /// <param name="competencia">competencia.</param>
        /// <param name="naturezaTributacao">Natureza da tributação  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial..</param>
        /// <param name="prestador">prestador.</param>
        /// <param name="tomador">tomador.</param>
        /// <param name="intermediario">intermediario.</param>
        /// <param name="construcaoCivil">construcaoCivil.</param>
        /// <param name="servicos">servicos (required).</param>
        /// <param name="outrasInformacoes">Informações adicionais ao documento..</param>
        public Rps(RpsDados rps = default(RpsDados), DateTime competencia = default(DateTime), int naturezaTributacao = default(int), RpsDadosPrestador prestador = default(RpsDadosPrestador), RpsDadosTomador tomador = default(RpsDadosTomador), RpsDadosIntermediario intermediario = default(RpsDadosIntermediario), RpsDadosConstrucaoCivil construcaoCivil = default(RpsDadosConstrucaoCivil), List<RpsDadosServico> servicos = default(List<RpsDadosServico>), string outrasInformacoes = default(string))
        {
            // to ensure "servicos" is required (not null)
            if (servicos == null)
            {
                throw new ArgumentNullException("servicos is a required property for Rps and cannot be null");
            }
            this.servicos = servicos;
            this.rps = rps;
            this.competencia = competencia;
            this.natureza_tributacao = naturezaTributacao;
            this.prestador = prestador;
            this.tomador = tomador;
            this.intermediario = intermediario;
            this.construcao_civil = construcaoCivil;
            this.outras_informacoes = outrasInformacoes;
        }

        /// <summary>
        /// Gets or Sets rps
        /// </summary>
        [DataMember(Name = "rps", EmitDefaultValue = false)]
        public RpsDados rps { get; set; }

        /// <summary>
        /// Gets or Sets competencia
        /// </summary>
        [DataMember(Name = "competencia", EmitDefaultValue = false)]
        public DateTime competencia { get; set; }

        /// <summary>
        /// Natureza da tributação  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial.
        /// </summary>
        /// <value>Natureza da tributação  1 - Simples Nacional;  2 - Fixo;  3 - Depósito em juízo;  4 - Exigibilidade suspensa por decisão judicial;  5 - Exigibilidade suspensa por procedimento administrativo;  6 - Isenção parcial.</value>
        [DataMember(Name = "natureza_tributacao", EmitDefaultValue = false)]
        public int natureza_tributacao { get; set; }

        /// <summary>
        /// Gets or Sets prestador
        /// </summary>
        [DataMember(Name = "prestador", EmitDefaultValue = false)]
        public RpsDadosPrestador prestador { get; set; }

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
        [DataMember(Name = "servicos", IsRequired = true, EmitDefaultValue = true)]
        public List<RpsDadosServico> servicos { get; set; }

        /// <summary>
        /// Informações adicionais ao documento.
        /// </summary>
        /// <value>Informações adicionais ao documento.</value>
        [DataMember(Name = "outras_informacoes", EmitDefaultValue = false)]
        public string outras_informacoes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Rps {\n");
            sb.Append("  rps: ").Append(rps).Append("\n");
            sb.Append("  competencia: ").Append(competencia).Append("\n");
            sb.Append("  natureza_tributacao: ").Append(natureza_tributacao).Append("\n");
            sb.Append("  prestador: ").Append(prestador).Append("\n");
            sb.Append("  tomador: ").Append(tomador).Append("\n");
            sb.Append("  intermediario: ").Append(intermediario).Append("\n");
            sb.Append("  construcao_civil: ").Append(construcao_civil).Append("\n");
            sb.Append("  servicos: ").Append(servicos).Append("\n");
            sb.Append("  outras_informacoes: ").Append(outras_informacoes).Append("\n");
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
            return this.Equals(input as Rps);
        }

        /// <summary>
        /// Returns true if Rps instances are equal
        /// </summary>
        /// <param name="input">Instance of Rps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rps input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.rps == input.rps ||
                    (this.rps != null &&
                    this.rps.Equals(input.rps))
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
                ) && 
                (
                    this.outras_informacoes == input.outras_informacoes ||
                    (this.outras_informacoes != null &&
                    this.outras_informacoes.Equals(input.outras_informacoes))
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
                if (this.rps != null)
                {
                    hashCode = (hashCode * 59) + this.rps.GetHashCode();
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
                if (this.outras_informacoes != null)
                {
                    hashCode = (hashCode * 59) + this.outras_informacoes.GetHashCode();
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
