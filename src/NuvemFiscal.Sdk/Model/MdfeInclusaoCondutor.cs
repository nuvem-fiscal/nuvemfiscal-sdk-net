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
    /// MdfeInclusaoCondutor
    /// </summary>
    [DataContract(Name = "MdfeInclusaoCondutor")]
    public partial class MdfeInclusaoCondutor : IEquatable<MdfeInclusaoCondutor>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="MdfeInclusaoCondutor" /> class.
        /// </summary>
        /// <param name="nomeCondutor">Nome do condutor..</param>
        /// <param name="cpfCondutor">CPF do condutor..</param>
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
        public MdfeInclusaoCondutor(string nomeCondutor = default(string), string cpfCondutor = default(string), string id = default(string), AmbienteEnum? ambiente = default(AmbienteEnum?), StatusEnum? status = default(StatusEnum?), DfeAutorEvento autor = default(DfeAutorEvento), string chaveAcesso = default(string), DateTime dataEvento = default(DateTime), int numeroSequencial = default(int), DateTime? dataRecebimento = default(DateTime?), int codigoStatus = default(int), string motivoStatus = default(string), string numeroProtocolo = default(string), int codigoMensagem = default(int), string mensagem = default(string), string tipoEvento = default(string))
        {
            this.nome_condutor = nomeCondutor;
            this.cpf_condutor = cpfCondutor;
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
        /// Nome do condutor.
        /// </summary>
        /// <value>Nome do condutor.</value>
        [DataMember(Name = "nome_condutor", EmitDefaultValue = false)]
        public string nome_condutor { get; set; }

        /// <summary>
        /// CPF do condutor.
        /// </summary>
        /// <value>CPF do condutor.</value>
        [DataMember(Name = "cpf_condutor", EmitDefaultValue = false)]
        public string cpf_condutor { get; set; }

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
            sb.Append("class MdfeInclusaoCondutor {\n");
            sb.Append("  nome_condutor: ").Append(nome_condutor).Append("\n");
            sb.Append("  cpf_condutor: ").Append(cpf_condutor).Append("\n");
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
            return this.Equals(input as MdfeInclusaoCondutor);
        }

        /// <summary>
        /// Returns true if MdfeInclusaoCondutor instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeInclusaoCondutor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeInclusaoCondutor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nome_condutor == input.nome_condutor ||
                    (this.nome_condutor != null &&
                    this.nome_condutor.Equals(input.nome_condutor))
                ) && 
                (
                    this.cpf_condutor == input.cpf_condutor ||
                    (this.cpf_condutor != null &&
                    this.cpf_condutor.Equals(input.cpf_condutor))
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
                if (this.nome_condutor != null)
                {
                    hashCode = (hashCode * 59) + this.nome_condutor.GetHashCode();
                }
                if (this.cpf_condutor != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_condutor.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
