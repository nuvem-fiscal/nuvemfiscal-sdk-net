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
    /// MdfeEncerramento
    /// </summary>
    [DataContract(Name = "MdfeEncerramento")]
    public partial class MdfeEncerramento : IEquatable<MdfeEncerramento>, IValidatableObject
    {
        /// <summary>
        /// Identificação do ambiente.
        /// </summary>
        /// <value>Identificação do ambiente.</value>
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
        /// Identificação do ambiente.
        /// </summary>
        /// <value>Identificação do ambiente.</value>
        [DataMember(Name = "ambiente", EmitDefaultValue = false)]
        public AmbienteEnum? ambiente { get; set; }
        /// <summary>
        /// Status do Evento.
        /// </summary>
        /// <value>Status do Evento.</value>
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
        /// Status do Evento.
        /// </summary>
        /// <value>Status do Evento.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeEncerramento" /> class.
        /// </summary>
        /// <param name="dataEncerramento">Data que o manifesto foi encerrado..</param>
        /// <param name="uf">UF de encerramento do manifesto..</param>
        /// <param name="codigoMunicipio">Código do Município de encerramento do manifesto..</param>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para este evento..</param>
        /// <param name="ambiente">Identificação do ambiente..</param>
        /// <param name="status">Status do Evento..</param>
        /// <param name="autor">autor.</param>
        /// <param name="chaveAcesso">Chave de Acesso do documento vinculado ao evento..</param>
        /// <param name="dataEvento">Data e hora do Evento..</param>
        /// <param name="numeroSequencial">Sequencial do evento para o mesmo tipo de evento..</param>
        /// <param name="dataRecebimento">Data e hora do recebimento do Evento pela SEFAZ..</param>
        /// <param name="codigoStatus">Código do status de registro do Evento..</param>
        /// <param name="motivoStatus">Descrição literal do status do registro do Evento..</param>
        /// <param name="numeroProtocolo">Número do Protocolo de registro do Evento..</param>
        /// <param name="codigoMensagem">Código da Mensagem..</param>
        /// <param name="mensagem">Mensagem da SEFAZ para o emissor..</param>
        /// <param name="tipoEvento">tipoEvento.</param>
        public MdfeEncerramento(DateTime dataEncerramento = default(DateTime), string uf = default(string), string codigoMunicipio = default(string), string id = default(string), AmbienteEnum? ambiente = default(AmbienteEnum?), StatusEnum? status = default(StatusEnum?), DfeAutorEvento autor = default(DfeAutorEvento), string chaveAcesso = default(string), DateTime dataEvento = default(DateTime), int numeroSequencial = default(int), DateTime? dataRecebimento = default(DateTime?), int codigoStatus = default(int), string motivoStatus = default(string), string numeroProtocolo = default(string), int codigoMensagem = default(int), string mensagem = default(string), string tipoEvento = default(string))
        {
            this.data_encerramento = dataEncerramento;
            this.uf = uf;
            this.codigo_municipio = codigoMunicipio;
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
        /// Data que o manifesto foi encerrado.
        /// </summary>
        /// <value>Data que o manifesto foi encerrado.</value>
        [DataMember(Name = "data_encerramento", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data_encerramento { get; set; }

        /// <summary>
        /// UF de encerramento do manifesto.
        /// </summary>
        /// <value>UF de encerramento do manifesto.</value>
        [DataMember(Name = "uf", EmitDefaultValue = false)]
        public string uf { get; set; }

        /// <summary>
        /// Código do Município de encerramento do manifesto.
        /// </summary>
        /// <value>Código do Município de encerramento do manifesto.</value>
        [DataMember(Name = "codigo_municipio", EmitDefaultValue = false)]
        public string codigo_municipio { get; set; }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para este evento.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para este evento.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets autor
        /// </summary>
        [DataMember(Name = "autor", EmitDefaultValue = false)]
        public DfeAutorEvento autor { get; set; }

        /// <summary>
        /// Chave de Acesso do documento vinculado ao evento.
        /// </summary>
        /// <value>Chave de Acesso do documento vinculado ao evento.</value>
        [DataMember(Name = "chave_acesso", EmitDefaultValue = false)]
        public string chave_acesso { get; set; }

        /// <summary>
        /// Data e hora do Evento.
        /// </summary>
        /// <value>Data e hora do Evento.</value>
        [DataMember(Name = "data_evento", EmitDefaultValue = false)]
        public DateTime data_evento { get; set; }

        /// <summary>
        /// Sequencial do evento para o mesmo tipo de evento.
        /// </summary>
        /// <value>Sequencial do evento para o mesmo tipo de evento.</value>
        [DataMember(Name = "numero_sequencial", EmitDefaultValue = false)]
        public int numero_sequencial { get; set; }

        /// <summary>
        /// Data e hora do recebimento do Evento pela SEFAZ.
        /// </summary>
        /// <value>Data e hora do recebimento do Evento pela SEFAZ.</value>
        [DataMember(Name = "data_recebimento", EmitDefaultValue = true)]
        public DateTime? data_recebimento { get; set; }

        /// <summary>
        /// Código do status de registro do Evento.
        /// </summary>
        /// <value>Código do status de registro do Evento.</value>
        [DataMember(Name = "codigo_status", EmitDefaultValue = false)]
        public int codigo_status { get; set; }

        /// <summary>
        /// Descrição literal do status do registro do Evento.
        /// </summary>
        /// <value>Descrição literal do status do registro do Evento.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = false)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Número do Protocolo de registro do Evento.
        /// </summary>
        /// <value>Número do Protocolo de registro do Evento.</value>
        [DataMember(Name = "numero_protocolo", EmitDefaultValue = false)]
        public string numero_protocolo { get; set; }

        /// <summary>
        /// Código da Mensagem.
        /// </summary>
        /// <value>Código da Mensagem.</value>
        [DataMember(Name = "codigo_mensagem", EmitDefaultValue = false)]
        public int codigo_mensagem { get; set; }

        /// <summary>
        /// Mensagem da SEFAZ para o emissor.
        /// </summary>
        /// <value>Mensagem da SEFAZ para o emissor.</value>
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
            sb.Append("class MdfeEncerramento {\n");
            sb.Append("  data_encerramento: ").Append(data_encerramento).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  codigo_municipio: ").Append(codigo_municipio).Append("\n");
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
            return this.Equals(input as MdfeEncerramento);
        }

        /// <summary>
        /// Returns true if MdfeEncerramento instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeEncerramento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeEncerramento input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.data_encerramento == input.data_encerramento ||
                    (this.data_encerramento != null &&
                    this.data_encerramento.Equals(input.data_encerramento))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.codigo_municipio == input.codigo_municipio ||
                    (this.codigo_municipio != null &&
                    this.codigo_municipio.Equals(input.codigo_municipio))
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
                if (this.data_encerramento != null)
                {
                    hashCode = (hashCode * 59) + this.data_encerramento.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.codigo_municipio != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_municipio.GetHashCode();
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
