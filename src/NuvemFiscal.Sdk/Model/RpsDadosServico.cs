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
        [JsonConstructorAttribute]
        protected RpsDadosServico() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosServico" /> class.
        /// </summary>
        /// <param name="issRetido">Reter ISSQN.  Valor padrão: &#x60;false&#x60;.</param>
        /// <param name="responsavelRetencao">Responsável pela retenção:  0 - Prestador;  1 - Tomador;  2 - Intermediário.    Valor padrão: &#x60;0&#x60;.</param>
        /// <param name="itemListaServico">Código do item da lista de serviço, geralmente segue a LC116, podendo variar de acordo com a prefeitura.    Você pode encontrar esse dado no portal da prefeitura, em uma nota emitida ou junto ao contador. (required).</param>
        /// <param name="codigoCnae">Código CNAE (Classificação Nacional de Atividades Econômicas)..</param>
        /// <param name="codigoTributacaoMunicipio">Código de tributação do município..</param>
        /// <param name="discriminacao">Detalhamento do serviço prestado. (required).</param>
        /// <param name="codigoMunicipio">Código IBGE do município de prestação do serviço.  Caso não informado, será considerado o município do prestador..</param>
        /// <param name="codigoPais">Código do país de prestação do serviço..</param>
        /// <param name="tipoTributacao">Tipo de Tributação do Serviço:  1 - Isento de ISS  2 - Imune  3 - Não Incidência no Município  4 - Não Tributável  5 - Retido  6 - Tributável Dentro do Município  7 - Tributável Fora do Município  8 - Tributável Dentro do Município pelo tomador    Valor padrão: &#x60;6&#x60;.</param>
        /// <param name="exigibilidadeIss">Exigibilidade do ISS:  1 - Exigível  2 - Não Incidência  3 - Isenção  4 - Exportação  5 - Imunidade  6 - Suspenso por Decisão Judicial  7 - Suspenso por Processo Administrativo    Valor padrão: &#x60;1&#x60;.</param>
        /// <param name="codigoMunicipioIncidencia">Código IBGE do município de incidência do ISSQN..</param>
        /// <param name="numeroProcesso">Número do Processo de Suspensão da Exigibilidade..</param>
        /// <param name="unidade">Unidade do serviço prestado..</param>
        /// <param name="quantidade">Quantidade dos serviços prestados.  Valor padrão: &#x60;1&#x60;.</param>
        /// <param name="valores">valores (required).</param>
        public RpsDadosServico(bool issRetido = default(bool), int responsavelRetencao = default(int), string itemListaServico = default(string), string codigoCnae = default(string), string codigoTributacaoMunicipio = default(string), string discriminacao = default(string), string codigoMunicipio = default(string), string codigoPais = default(string), int tipoTributacao = default(int), int exigibilidadeIss = default(int), string codigoMunicipioIncidencia = default(string), string numeroProcesso = default(string), string unidade = default(string), decimal quantidade = default(decimal), RpsServicoValores valores = default(RpsServicoValores))
        {
            // to ensure "itemListaServico" is required (not null)
            if (itemListaServico == null)
            {
                throw new ArgumentNullException("itemListaServico is a required property for RpsDadosServico and cannot be null");
            }
            this.item_lista_servico = itemListaServico;
            // to ensure "discriminacao" is required (not null)
            if (discriminacao == null)
            {
                throw new ArgumentNullException("discriminacao is a required property for RpsDadosServico and cannot be null");
            }
            this.discriminacao = discriminacao;
            // to ensure "valores" is required (not null)
            if (valores == null)
            {
                throw new ArgumentNullException("valores is a required property for RpsDadosServico and cannot be null");
            }
            this.valores = valores;
            this.iss_retido = issRetido;
            this.responsavel_retencao = responsavelRetencao;
            this.codigo_cnae = codigoCnae;
            this.codigo_tributacao_municipio = codigoTributacaoMunicipio;
            this.codigo_municipio = codigoMunicipio;
            this.codigo_pais = codigoPais;
            this.tipo_tributacao = tipoTributacao;
            this.exigibilidade_iss = exigibilidadeIss;
            this.codigo_municipio_incidencia = codigoMunicipioIncidencia;
            this.numero_processo = numeroProcesso;
            this.unidade = unidade;
            this.quantidade = quantidade;
        }

        /// <summary>
        /// Reter ISSQN.  Valor padrão: &#x60;false&#x60;
        /// </summary>
        /// <value>Reter ISSQN.  Valor padrão: &#x60;false&#x60;</value>
        [DataMember(Name = "iss_retido", EmitDefaultValue = true)]
        public bool iss_retido { get; set; }

        /// <summary>
        /// Responsável pela retenção:  0 - Prestador;  1 - Tomador;  2 - Intermediário.    Valor padrão: &#x60;0&#x60;
        /// </summary>
        /// <value>Responsável pela retenção:  0 - Prestador;  1 - Tomador;  2 - Intermediário.    Valor padrão: &#x60;0&#x60;</value>
        [DataMember(Name = "responsavel_retencao", EmitDefaultValue = false)]
        public int responsavel_retencao { get; set; }

        /// <summary>
        /// Código do item da lista de serviço, geralmente segue a LC116, podendo variar de acordo com a prefeitura.    Você pode encontrar esse dado no portal da prefeitura, em uma nota emitida ou junto ao contador.
        /// </summary>
        /// <value>Código do item da lista de serviço, geralmente segue a LC116, podendo variar de acordo com a prefeitura.    Você pode encontrar esse dado no portal da prefeitura, em uma nota emitida ou junto ao contador.</value>
        [DataMember(Name = "item_lista_servico", IsRequired = true, EmitDefaultValue = true)]
        public string item_lista_servico { get; set; }

        /// <summary>
        /// Código CNAE (Classificação Nacional de Atividades Econômicas).
        /// </summary>
        /// <value>Código CNAE (Classificação Nacional de Atividades Econômicas).</value>
        [DataMember(Name = "codigo_cnae", EmitDefaultValue = false)]
        public string codigo_cnae { get; set; }

        /// <summary>
        /// Código de tributação do município.
        /// </summary>
        /// <value>Código de tributação do município.</value>
        [DataMember(Name = "codigo_tributacao_municipio", EmitDefaultValue = false)]
        public string codigo_tributacao_municipio { get; set; }

        /// <summary>
        /// Detalhamento do serviço prestado.
        /// </summary>
        /// <value>Detalhamento do serviço prestado.</value>
        [DataMember(Name = "discriminacao", IsRequired = true, EmitDefaultValue = true)]
        public string discriminacao { get; set; }

        /// <summary>
        /// Código IBGE do município de prestação do serviço.  Caso não informado, será considerado o município do prestador.
        /// </summary>
        /// <value>Código IBGE do município de prestação do serviço.  Caso não informado, será considerado o município do prestador.</value>
        [DataMember(Name = "codigo_municipio", EmitDefaultValue = false)]
        public string codigo_municipio { get; set; }

        /// <summary>
        /// Código do país de prestação do serviço.
        /// </summary>
        /// <value>Código do país de prestação do serviço.</value>
        [DataMember(Name = "codigo_pais", EmitDefaultValue = false)]
        public string codigo_pais { get; set; }

        /// <summary>
        /// Tipo de Tributação do Serviço:  1 - Isento de ISS  2 - Imune  3 - Não Incidência no Município  4 - Não Tributável  5 - Retido  6 - Tributável Dentro do Município  7 - Tributável Fora do Município  8 - Tributável Dentro do Município pelo tomador    Valor padrão: &#x60;6&#x60;
        /// </summary>
        /// <value>Tipo de Tributação do Serviço:  1 - Isento de ISS  2 - Imune  3 - Não Incidência no Município  4 - Não Tributável  5 - Retido  6 - Tributável Dentro do Município  7 - Tributável Fora do Município  8 - Tributável Dentro do Município pelo tomador    Valor padrão: &#x60;6&#x60;</value>
        [DataMember(Name = "tipo_tributacao", EmitDefaultValue = false)]
        public int tipo_tributacao { get; set; }

        /// <summary>
        /// Exigibilidade do ISS:  1 - Exigível  2 - Não Incidência  3 - Isenção  4 - Exportação  5 - Imunidade  6 - Suspenso por Decisão Judicial  7 - Suspenso por Processo Administrativo    Valor padrão: &#x60;1&#x60;
        /// </summary>
        /// <value>Exigibilidade do ISS:  1 - Exigível  2 - Não Incidência  3 - Isenção  4 - Exportação  5 - Imunidade  6 - Suspenso por Decisão Judicial  7 - Suspenso por Processo Administrativo    Valor padrão: &#x60;1&#x60;</value>
        [DataMember(Name = "exigibilidade_iss", EmitDefaultValue = false)]
        public int exigibilidade_iss { get; set; }

        /// <summary>
        /// Código IBGE do município de incidência do ISSQN.
        /// </summary>
        /// <value>Código IBGE do município de incidência do ISSQN.</value>
        [DataMember(Name = "codigo_municipio_incidencia", EmitDefaultValue = false)]
        public string codigo_municipio_incidencia { get; set; }

        /// <summary>
        /// Número do Processo de Suspensão da Exigibilidade.
        /// </summary>
        /// <value>Número do Processo de Suspensão da Exigibilidade.</value>
        [DataMember(Name = "numero_processo", EmitDefaultValue = false)]
        public string numero_processo { get; set; }

        /// <summary>
        /// Unidade do serviço prestado.
        /// </summary>
        /// <value>Unidade do serviço prestado.</value>
        [DataMember(Name = "unidade", EmitDefaultValue = false)]
        public string unidade { get; set; }

        /// <summary>
        /// Quantidade dos serviços prestados.  Valor padrão: &#x60;1&#x60;
        /// </summary>
        /// <value>Quantidade dos serviços prestados.  Valor padrão: &#x60;1&#x60;</value>
        [DataMember(Name = "quantidade", EmitDefaultValue = false)]
        public decimal quantidade { get; set; }

        /// <summary>
        /// Gets or Sets valores
        /// </summary>
        [DataMember(Name = "valores", IsRequired = true, EmitDefaultValue = true)]
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
