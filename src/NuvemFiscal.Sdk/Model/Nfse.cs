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
    /// Nfse
    /// </summary>
    [DataContract(Name = "Nfse")]
    public partial class Nfse : IEquatable<Nfse>, IValidatableObject
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Processando for value: processando
            /// </summary>
            [EnumMember(Value = "processando")]
            Processando = 1,

            /// <summary>
            /// Enum Autorizada for value: autorizada
            /// </summary>
            [EnumMember(Value = "autorizada")]
            Autorizada = 2,

            /// <summary>
            /// Enum Negada for value: negada
            /// </summary>
            [EnumMember(Value = "negada")]
            Negada = 3,

            /// <summary>
            /// Enum Cancelada for value: cancelada
            /// </summary>
            [EnumMember(Value = "cancelada")]
            Cancelada = 4,

            /// <summary>
            /// Enum Substituida for value: substituida
            /// </summary>
            [EnumMember(Value = "substituida")]
            Substituida = 5,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 6
        }


        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Defines ambiente
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmbienteEnum
        {
            /// <summary>
            /// Enum Homologacao for value: homologacao
            /// </summary>
            [EnumMember(Value = "homologacao")]
            Homologacao = 1,

            /// <summary>
            /// Enum Producao for value: producao
            /// </summary>
            [EnumMember(Value = "producao")]
            Producao = 2
        }


        /// <summary>
        /// Gets or Sets ambiente
        /// </summary>
        [DataMember(Name = "ambiente", EmitDefaultValue = false)]
        public AmbienteEnum? ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Nfse" /> class.
        /// </summary>
        /// <param name="id">ID único da nota gerado automaticamente pela Nuvem Fiscal..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="status">status.</param>
        /// <param name="numero">numero.</param>
        /// <param name="codigoVerificacao">codigoVerificacao.</param>
        /// <param name="linkUrl">linkUrl.</param>
        /// <param name="dataEmissao">dataEmissao.</param>
        /// <param name="ambiente">ambiente.</param>
        /// <param name="referencia">referencia.</param>
        /// <param name="dPS">dPS.</param>
        /// <param name="cancelamento">cancelamento.</param>
        /// <param name="mensagens">mensagens.</param>
        /// <param name="declaracaoPrestacaoServico">declaracaoPrestacaoServico.</param>
        public Nfse(string id = default(string), DateTime createdAt = default(DateTime), StatusEnum? status = default(StatusEnum?), string numero = default(string), string codigoVerificacao = default(string), string linkUrl = default(string), DateTime? dataEmissao = default(DateTime?), AmbienteEnum? ambiente = default(AmbienteEnum?), string referencia = default(string), DPS dPS = default(DPS), NfseCancelamento cancelamento = default(NfseCancelamento), List<NfseMensagemRetorno> mensagens = default(List<NfseMensagemRetorno>), Rps declaracaoPrestacaoServico = default(Rps))
        {
            this.id = id;
            this.created_at = createdAt;
            this.status = status;
            this.numero = numero;
            this.codigo_verificacao = codigoVerificacao;
            this.link_url = linkUrl;
            this.data_emissao = dataEmissao;
            this.ambiente = ambiente;
            this.referencia = referencia;
            this.DPS = dPS;
            this.cancelamento = cancelamento;
            this.mensagens = mensagens;
            this.declaracao_prestacao_servico = declaracaoPrestacaoServico;
        }

        /// <summary>
        /// ID único da nota gerado automaticamente pela Nuvem Fiscal.
        /// </summary>
        /// <value>ID único da nota gerado automaticamente pela Nuvem Fiscal.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets created_at
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets or Sets numero
        /// </summary>
        [DataMember(Name = "numero", EmitDefaultValue = false)]
        public string numero { get; set; }

        /// <summary>
        /// Gets or Sets codigo_verificacao
        /// </summary>
        [DataMember(Name = "codigo_verificacao", EmitDefaultValue = false)]
        public string codigo_verificacao { get; set; }

        /// <summary>
        /// Gets or Sets link_url
        /// </summary>
        [DataMember(Name = "link_url", EmitDefaultValue = false)]
        public string link_url { get; set; }

        /// <summary>
        /// Gets or Sets data_emissao
        /// </summary>
        [DataMember(Name = "data_emissao", EmitDefaultValue = true)]
        public DateTime? data_emissao { get; set; }

        /// <summary>
        /// Gets or Sets referencia
        /// </summary>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets DPS
        /// </summary>
        [DataMember(Name = "DPS", EmitDefaultValue = false)]
        public DPS DPS { get; set; }

        /// <summary>
        /// Gets or Sets cancelamento
        /// </summary>
        [DataMember(Name = "cancelamento", EmitDefaultValue = false)]
        public NfseCancelamento cancelamento { get; set; }

        /// <summary>
        /// Gets or Sets mensagens
        /// </summary>
        [DataMember(Name = "mensagens", EmitDefaultValue = false)]
        public List<NfseMensagemRetorno> mensagens { get; set; }

        /// <summary>
        /// Gets or Sets declaracao_prestacao_servico
        /// </summary>
        [DataMember(Name = "declaracao_prestacao_servico", EmitDefaultValue = false)]
        public Rps declaracao_prestacao_servico { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Nfse {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  codigo_verificacao: ").Append(codigo_verificacao).Append("\n");
            sb.Append("  link_url: ").Append(link_url).Append("\n");
            sb.Append("  data_emissao: ").Append(data_emissao).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  DPS: ").Append(DPS).Append("\n");
            sb.Append("  cancelamento: ").Append(cancelamento).Append("\n");
            sb.Append("  mensagens: ").Append(mensagens).Append("\n");
            sb.Append("  declaracao_prestacao_servico: ").Append(declaracao_prestacao_servico).Append("\n");
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
            return this.Equals(input as Nfse);
        }

        /// <summary>
        /// Returns true if Nfse instances are equal
        /// </summary>
        /// <param name="input">Instance of Nfse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Nfse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.numero == input.numero ||
                    (this.numero != null &&
                    this.numero.Equals(input.numero))
                ) && 
                (
                    this.codigo_verificacao == input.codigo_verificacao ||
                    (this.codigo_verificacao != null &&
                    this.codigo_verificacao.Equals(input.codigo_verificacao))
                ) && 
                (
                    this.link_url == input.link_url ||
                    (this.link_url != null &&
                    this.link_url.Equals(input.link_url))
                ) && 
                (
                    this.data_emissao == input.data_emissao ||
                    (this.data_emissao != null &&
                    this.data_emissao.Equals(input.data_emissao))
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
                ) && 
                (
                    this.DPS == input.DPS ||
                    (this.DPS != null &&
                    this.DPS.Equals(input.DPS))
                ) && 
                (
                    this.cancelamento == input.cancelamento ||
                    (this.cancelamento != null &&
                    this.cancelamento.Equals(input.cancelamento))
                ) && 
                (
                    this.mensagens == input.mensagens ||
                    this.mensagens != null &&
                    input.mensagens != null &&
                    this.mensagens.SequenceEqual(input.mensagens)
                ) && 
                (
                    this.declaracao_prestacao_servico == input.declaracao_prestacao_servico ||
                    (this.declaracao_prestacao_servico != null &&
                    this.declaracao_prestacao_servico.Equals(input.declaracao_prestacao_servico))
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
                if (this.id != null)
                {
                    hashCode = (hashCode * 59) + this.id.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.numero != null)
                {
                    hashCode = (hashCode * 59) + this.numero.GetHashCode();
                }
                if (this.codigo_verificacao != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_verificacao.GetHashCode();
                }
                if (this.link_url != null)
                {
                    hashCode = (hashCode * 59) + this.link_url.GetHashCode();
                }
                if (this.data_emissao != null)
                {
                    hashCode = (hashCode * 59) + this.data_emissao.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
                }
                if (this.DPS != null)
                {
                    hashCode = (hashCode * 59) + this.DPS.GetHashCode();
                }
                if (this.cancelamento != null)
                {
                    hashCode = (hashCode * 59) + this.cancelamento.GetHashCode();
                }
                if (this.mensagens != null)
                {
                    hashCode = (hashCode * 59) + this.mensagens.GetHashCode();
                }
                if (this.declaracao_prestacao_servico != null)
                {
                    hashCode = (hashCode * 59) + this.declaracao_prestacao_servico.GetHashCode();
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
            yield break;
        }
    }

}
