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
    /// DistribuicaoNfeEvento
    /// </summary>
    [DataContract(Name = "DistribuicaoNfeEvento")]
    public partial class DistribuicaoNfeEvento : IEquatable<DistribuicaoNfeEvento>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="DistribuicaoNfeEvento" /> class.
        /// </summary>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para este evento..</param>
        /// <param name="createdAt">Data/hora em que o evento foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;..</param>
        /// <param name="ambiente">Identificação do ambiente..</param>
        /// <param name="status">Status do Evento..</param>
        /// <param name="cpfCnpjAutor">CPF/CNPJ do autor do evento..</param>
        /// <param name="chaveAcesso">Chave de Acesso do documento vinculado ao evento..</param>
        /// <param name="tipoEvento">Tipo do evento vinculado..</param>
        /// <param name="dataEvento">Data e hora do Evento..</param>
        /// <param name="numeroSequencial">Sequencial do evento para o mesmo tipo de evento..</param>
        /// <param name="justificativa">Justificativa para o desconhecimento ou não-realização da operação..</param>
        /// <param name="dataRegistro">Data e hora do registro do evento pela SEFAZ..</param>
        /// <param name="codigoStatus">Código do status de registro do evento..</param>
        /// <param name="motivoStatus">Descrição literal do status do registro do evento..</param>
        /// <param name="numeroProtocolo">Número do Protocolo de registro do evento..</param>
        public DistribuicaoNfeEvento(string id = default(string), DateTime createdAt = default(DateTime), AmbienteEnum? ambiente = default(AmbienteEnum?), StatusEnum? status = default(StatusEnum?), string cpfCnpjAutor = default(string), string chaveAcesso = default(string), string tipoEvento = default(string), DateTime dataEvento = default(DateTime), int? numeroSequencial = default(int?), string justificativa = default(string), DateTime? dataRegistro = default(DateTime?), int? codigoStatus = default(int?), string motivoStatus = default(string), string numeroProtocolo = default(string))
        {
            this.id = id;
            this.created_at = createdAt;
            this.ambiente = ambiente;
            this.status = status;
            this.cpf_cnpj_autor = cpfCnpjAutor;
            this.chave_acesso = chaveAcesso;
            this.tipo_evento = tipoEvento;
            this.data_evento = dataEvento;
            this.numero_sequencial = numeroSequencial;
            this.justificativa = justificativa;
            this.data_registro = dataRegistro;
            this.codigo_status = codigoStatus;
            this.motivo_status = motivoStatus;
            this.numero_protocolo = numeroProtocolo;
        }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para este evento.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para este evento.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Data/hora em que o evento foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;.
        /// </summary>
        /// <value>Data/hora em que o evento foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// CPF/CNPJ do autor do evento.
        /// </summary>
        /// <value>CPF/CNPJ do autor do evento.</value>
        [DataMember(Name = "cpf_cnpj_autor", EmitDefaultValue = false)]
        public string cpf_cnpj_autor { get; set; }

        /// <summary>
        /// Chave de Acesso do documento vinculado ao evento.
        /// </summary>
        /// <value>Chave de Acesso do documento vinculado ao evento.</value>
        [DataMember(Name = "chave_acesso", EmitDefaultValue = false)]
        public string chave_acesso { get; set; }

        /// <summary>
        /// Tipo do evento vinculado.
        /// </summary>
        /// <value>Tipo do evento vinculado.</value>
        [DataMember(Name = "tipo_evento", EmitDefaultValue = false)]
        public string tipo_evento { get; set; }

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
        [DataMember(Name = "numero_sequencial", EmitDefaultValue = true)]
        public int? numero_sequencial { get; set; }

        /// <summary>
        /// Justificativa para o desconhecimento ou não-realização da operação.
        /// </summary>
        /// <value>Justificativa para o desconhecimento ou não-realização da operação.</value>
        [DataMember(Name = "justificativa", EmitDefaultValue = true)]
        public string justificativa { get; set; }

        /// <summary>
        /// Data e hora do registro do evento pela SEFAZ.
        /// </summary>
        /// <value>Data e hora do registro do evento pela SEFAZ.</value>
        [DataMember(Name = "data_registro", EmitDefaultValue = true)]
        public DateTime? data_registro { get; set; }

        /// <summary>
        /// Código do status de registro do evento.
        /// </summary>
        /// <value>Código do status de registro do evento.</value>
        [DataMember(Name = "codigo_status", EmitDefaultValue = true)]
        public int? codigo_status { get; set; }

        /// <summary>
        /// Descrição literal do status do registro do evento.
        /// </summary>
        /// <value>Descrição literal do status do registro do evento.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = true)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Número do Protocolo de registro do evento.
        /// </summary>
        /// <value>Número do Protocolo de registro do evento.</value>
        [DataMember(Name = "numero_protocolo", EmitDefaultValue = true)]
        public string numero_protocolo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DistribuicaoNfeEvento {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  cpf_cnpj_autor: ").Append(cpf_cnpj_autor).Append("\n");
            sb.Append("  chave_acesso: ").Append(chave_acesso).Append("\n");
            sb.Append("  tipo_evento: ").Append(tipo_evento).Append("\n");
            sb.Append("  data_evento: ").Append(data_evento).Append("\n");
            sb.Append("  numero_sequencial: ").Append(numero_sequencial).Append("\n");
            sb.Append("  justificativa: ").Append(justificativa).Append("\n");
            sb.Append("  data_registro: ").Append(data_registro).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  numero_protocolo: ").Append(numero_protocolo).Append("\n");
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
            return this.Equals(input as DistribuicaoNfeEvento);
        }

        /// <summary>
        /// Returns true if DistribuicaoNfeEvento instances are equal
        /// </summary>
        /// <param name="input">Instance of DistribuicaoNfeEvento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistribuicaoNfeEvento input)
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
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.cpf_cnpj_autor == input.cpf_cnpj_autor ||
                    (this.cpf_cnpj_autor != null &&
                    this.cpf_cnpj_autor.Equals(input.cpf_cnpj_autor))
                ) && 
                (
                    this.chave_acesso == input.chave_acesso ||
                    (this.chave_acesso != null &&
                    this.chave_acesso.Equals(input.chave_acesso))
                ) && 
                (
                    this.tipo_evento == input.tipo_evento ||
                    (this.tipo_evento != null &&
                    this.tipo_evento.Equals(input.tipo_evento))
                ) && 
                (
                    this.data_evento == input.data_evento ||
                    (this.data_evento != null &&
                    this.data_evento.Equals(input.data_evento))
                ) && 
                (
                    this.numero_sequencial == input.numero_sequencial ||
                    (this.numero_sequencial != null &&
                    this.numero_sequencial.Equals(input.numero_sequencial))
                ) && 
                (
                    this.justificativa == input.justificativa ||
                    (this.justificativa != null &&
                    this.justificativa.Equals(input.justificativa))
                ) && 
                (
                    this.data_registro == input.data_registro ||
                    (this.data_registro != null &&
                    this.data_registro.Equals(input.data_registro))
                ) && 
                (
                    this.codigo_status == input.codigo_status ||
                    (this.codigo_status != null &&
                    this.codigo_status.Equals(input.codigo_status))
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
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.cpf_cnpj_autor != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_cnpj_autor.GetHashCode();
                }
                if (this.chave_acesso != null)
                {
                    hashCode = (hashCode * 59) + this.chave_acesso.GetHashCode();
                }
                if (this.tipo_evento != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_evento.GetHashCode();
                }
                if (this.data_evento != null)
                {
                    hashCode = (hashCode * 59) + this.data_evento.GetHashCode();
                }
                if (this.numero_sequencial != null)
                {
                    hashCode = (hashCode * 59) + this.numero_sequencial.GetHashCode();
                }
                if (this.justificativa != null)
                {
                    hashCode = (hashCode * 59) + this.justificativa.GetHashCode();
                }
                if (this.data_registro != null)
                {
                    hashCode = (hashCode * 59) + this.data_registro.GetHashCode();
                }
                if (this.codigo_status != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                }
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.numero_protocolo != null)
                {
                    hashCode = (hashCode * 59) + this.numero_protocolo.GetHashCode();
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
