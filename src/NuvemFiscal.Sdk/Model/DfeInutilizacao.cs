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
    /// DfeInutilizacao
    /// </summary>
    [DataContract(Name = "DfeInutilizacao")]
    public partial class DfeInutilizacao : IEquatable<DfeInutilizacao>, IValidatableObject
    {
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
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pendente for value: pendente
            /// </summary>
            [EnumMember(Value = "pendente")]
            Pendente = 1,

            /// <summary>
            /// Enum Registrado for value: registrado
            /// </summary>
            [EnumMember(Value = "registrado")]
            Registrado = 2,

            /// <summary>
            /// Enum Rejeitado for value: rejeitado
            /// </summary>
            [EnumMember(Value = "rejeitado")]
            Rejeitado = 3,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 4

        }


        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeInutilizacao" /> class.
        /// </summary>
        /// <param name="cnpj">cnpj.</param>
        /// <param name="ano">ano.</param>
        /// <param name="modelo">modelo.</param>
        /// <param name="serie">serie.</param>
        /// <param name="numeroInicial">numeroInicial.</param>
        /// <param name="numeroFinal">numeroFinal.</param>
        /// <param name="justificativa">justificativa.</param>
        /// <param name="id">id.</param>
        /// <param name="ambiente">ambiente.</param>
        /// <param name="status">status.</param>
        /// <param name="autor">autor.</param>
        /// <param name="chaveAcesso">chaveAcesso.</param>
        /// <param name="dataEvento">dataEvento.</param>
        /// <param name="numeroSequencial">numeroSequencial.</param>
        /// <param name="dataRecebimento">dataRecebimento.</param>
        /// <param name="codigoStatus">codigoStatus.</param>
        /// <param name="motivoStatus">motivoStatus.</param>
        /// <param name="numeroProtocolo">numeroProtocolo.</param>
        /// <param name="codigoMensagem">codigoMensagem.</param>
        /// <param name="mensagem">mensagem.</param>
        /// <param name="tipoEvento">tipoEvento.</param>
        public DfeInutilizacao(string cnpj = default(string), int ano = default(int), int modelo = default(int), int serie = default(int), int numeroInicial = default(int), int numeroFinal = default(int), string justificativa = default(string), string id = default(string), AmbienteEnum? ambiente = default(AmbienteEnum?), StatusEnum? status = default(StatusEnum?), DfeAutorEvento autor = default(DfeAutorEvento), string chaveAcesso = default(string), DateTime dataEvento = default(DateTime), int numeroSequencial = default(int), DateTime dataRecebimento = default(DateTime), int codigoStatus = default(int), string motivoStatus = default(string), string numeroProtocolo = default(string), int codigoMensagem = default(int), string mensagem = default(string), string tipoEvento = default(string))
        {
            this.cnpj = cnpj;
            this.ano = ano;
            this.modelo = modelo;
            this.serie = serie;
            this.numero_inicial = numeroInicial;
            this.numero_final = numeroFinal;
            this.justificativa = justificativa;
            this.id = id;
            this.ambiente = ambiente;
            this.status = status;
            this.autor = autor;
            this.chave_acesso = chaveAcesso;
            this.data_evento = dataEvento;
            this.numero_sequencial = numeroSequencial;
            this.data_recebimento = dataRecebimento;
            this.codigo_status = codigoStatus;
            this.motivo_status = motivoStatus;
            this.numero_protocolo = numeroProtocolo;
            this.codigo_mensagem = codigoMensagem;
            this.mensagem = mensagem;
            this.tipo_evento = tipoEvento;
        }

        /// <summary>
        /// Gets or Sets cnpj
        /// </summary>
        [DataMember(Name = "cnpj", EmitDefaultValue = false)]
        public string cnpj { get; set; }

        /// <summary>
        /// Gets or Sets ano
        /// </summary>
        [DataMember(Name = "ano", EmitDefaultValue = false)]
        public int ano { get; set; }

        /// <summary>
        /// Gets or Sets modelo
        /// </summary>
        [DataMember(Name = "modelo", EmitDefaultValue = false)]
        public int modelo { get; set; }

        /// <summary>
        /// Gets or Sets serie
        /// </summary>
        [DataMember(Name = "serie", EmitDefaultValue = false)]
        public int serie { get; set; }

        /// <summary>
        /// Gets or Sets numero_inicial
        /// </summary>
        [DataMember(Name = "numero_inicial", EmitDefaultValue = false)]
        public int numero_inicial { get; set; }

        /// <summary>
        /// Gets or Sets numero_final
        /// </summary>
        [DataMember(Name = "numero_final", EmitDefaultValue = false)]
        public int numero_final { get; set; }

        /// <summary>
        /// Gets or Sets justificativa
        /// </summary>
        [DataMember(Name = "justificativa", EmitDefaultValue = false)]
        public string justificativa { get; set; }

        /// <summary>
        /// Gets or Sets id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets autor
        /// </summary>
        [DataMember(Name = "autor", EmitDefaultValue = false)]
        public DfeAutorEvento autor { get; set; }

        /// <summary>
        /// Gets or Sets chave_acesso
        /// </summary>
        [DataMember(Name = "chave_acesso", EmitDefaultValue = false)]
        public string chave_acesso { get; set; }

        /// <summary>
        /// Gets or Sets data_evento
        /// </summary>
        [DataMember(Name = "data_evento", EmitDefaultValue = false)]
        public DateTime data_evento { get; set; }

        /// <summary>
        /// Gets or Sets numero_sequencial
        /// </summary>
        [DataMember(Name = "numero_sequencial", EmitDefaultValue = false)]
        public int numero_sequencial { get; set; }

        /// <summary>
        /// Gets or Sets data_recebimento
        /// </summary>
        [DataMember(Name = "data_recebimento", EmitDefaultValue = false)]
        public DateTime data_recebimento { get; set; }

        /// <summary>
        /// Gets or Sets codigo_status
        /// </summary>
        [DataMember(Name = "codigo_status", EmitDefaultValue = false)]
        public int codigo_status { get; set; }

        /// <summary>
        /// Gets or Sets motivo_status
        /// </summary>
        [DataMember(Name = "motivo_status", EmitDefaultValue = false)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Gets or Sets numero_protocolo
        /// </summary>
        [DataMember(Name = "numero_protocolo", EmitDefaultValue = false)]
        public string numero_protocolo { get; set; }

        /// <summary>
        /// Gets or Sets codigo_mensagem
        /// </summary>
        [DataMember(Name = "codigo_mensagem", EmitDefaultValue = false)]
        public int codigo_mensagem { get; set; }

        /// <summary>
        /// Gets or Sets mensagem
        /// </summary>
        [DataMember(Name = "mensagem", EmitDefaultValue = false)]
        public string mensagem { get; set; }

        /// <summary>
        /// Gets or Sets tipo_evento
        /// </summary>
        [DataMember(Name = "tipo_evento", EmitDefaultValue = false)]
        public string tipo_evento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeInutilizacao {\n");
            sb.Append("  cnpj: ").Append(cnpj).Append("\n");
            sb.Append("  ano: ").Append(ano).Append("\n");
            sb.Append("  modelo: ").Append(modelo).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  numero_inicial: ").Append(numero_inicial).Append("\n");
            sb.Append("  numero_final: ").Append(numero_final).Append("\n");
            sb.Append("  justificativa: ").Append(justificativa).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  autor: ").Append(autor).Append("\n");
            sb.Append("  chave_acesso: ").Append(chave_acesso).Append("\n");
            sb.Append("  data_evento: ").Append(data_evento).Append("\n");
            sb.Append("  numero_sequencial: ").Append(numero_sequencial).Append("\n");
            sb.Append("  data_recebimento: ").Append(data_recebimento).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  numero_protocolo: ").Append(numero_protocolo).Append("\n");
            sb.Append("  codigo_mensagem: ").Append(codigo_mensagem).Append("\n");
            sb.Append("  mensagem: ").Append(mensagem).Append("\n");
            sb.Append("  tipo_evento: ").Append(tipo_evento).Append("\n");
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
            return this.Equals(input as DfeInutilizacao);
        }

        /// <summary>
        /// Returns true if DfeInutilizacao instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeInutilizacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeInutilizacao input)
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
                    this.ano == input.ano ||
                    this.ano.Equals(input.ano)
                ) && 
                (
                    this.modelo == input.modelo ||
                    this.modelo.Equals(input.modelo)
                ) && 
                (
                    this.serie == input.serie ||
                    this.serie.Equals(input.serie)
                ) && 
                (
                    this.numero_inicial == input.numero_inicial ||
                    this.numero_inicial.Equals(input.numero_inicial)
                ) && 
                (
                    this.numero_final == input.numero_final ||
                    this.numero_final.Equals(input.numero_final)
                ) && 
                (
                    this.justificativa == input.justificativa ||
                    (this.justificativa != null &&
                    this.justificativa.Equals(input.justificativa))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.autor == input.autor ||
                    (this.autor != null &&
                    this.autor.Equals(input.autor))
                ) && 
                (
                    this.chave_acesso == input.chave_acesso ||
                    (this.chave_acesso != null &&
                    this.chave_acesso.Equals(input.chave_acesso))
                ) && 
                (
                    this.data_evento == input.data_evento ||
                    (this.data_evento != null &&
                    this.data_evento.Equals(input.data_evento))
                ) && 
                (
                    this.numero_sequencial == input.numero_sequencial ||
                    this.numero_sequencial.Equals(input.numero_sequencial)
                ) && 
                (
                    this.data_recebimento == input.data_recebimento ||
                    (this.data_recebimento != null &&
                    this.data_recebimento.Equals(input.data_recebimento))
                ) && 
                (
                    this.codigo_status == input.codigo_status ||
                    this.codigo_status.Equals(input.codigo_status)
                ) && 
                (
                    this.motivo_status == input.motivo_status ||
                    (this.motivo_status != null &&
                    this.motivo_status.Equals(input.motivo_status))
                ) && 
                (
                    this.numero_protocolo == input.numero_protocolo ||
                    (this.numero_protocolo != null &&
                    this.numero_protocolo.Equals(input.numero_protocolo))
                ) && 
                (
                    this.codigo_mensagem == input.codigo_mensagem ||
                    this.codigo_mensagem.Equals(input.codigo_mensagem)
                ) && 
                (
                    this.mensagem == input.mensagem ||
                    (this.mensagem != null &&
                    this.mensagem.Equals(input.mensagem))
                ) && 
                (
                    this.tipo_evento == input.tipo_evento ||
                    (this.tipo_evento != null &&
                    this.tipo_evento.Equals(input.tipo_evento))
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
                hashCode = (hashCode * 59) + this.ano.GetHashCode();
                hashCode = (hashCode * 59) + this.modelo.GetHashCode();
                hashCode = (hashCode * 59) + this.serie.GetHashCode();
                hashCode = (hashCode * 59) + this.numero_inicial.GetHashCode();
                hashCode = (hashCode * 59) + this.numero_final.GetHashCode();
                if (this.justificativa != null)
                {
                    hashCode = (hashCode * 59) + this.justificativa.GetHashCode();
                }
                if (this.id != null)
                {
                    hashCode = (hashCode * 59) + this.id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.autor != null)
                {
                    hashCode = (hashCode * 59) + this.autor.GetHashCode();
                }
                if (this.chave_acesso != null)
                {
                    hashCode = (hashCode * 59) + this.chave_acesso.GetHashCode();
                }
                if (this.data_evento != null)
                {
                    hashCode = (hashCode * 59) + this.data_evento.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.numero_sequencial.GetHashCode();
                if (this.data_recebimento != null)
                {
                    hashCode = (hashCode * 59) + this.data_recebimento.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.numero_protocolo != null)
                {
                    hashCode = (hashCode * 59) + this.numero_protocolo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_mensagem.GetHashCode();
                if (this.mensagem != null)
                {
                    hashCode = (hashCode * 59) + this.mensagem.GetHashCode();
                }
                if (this.tipo_evento != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_evento.GetHashCode();
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
