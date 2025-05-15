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
    /// NfseCancelamento
    /// </summary>
    [DataContract(Name = "NfseCancelamento")]
    public partial class NfseCancelamento : IEquatable<NfseCancelamento>, IValidatableObject
    {
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
            /// Enum Concluido for value: concluido
            /// </summary>
            [EnumMember(Value = "concluido")]
            Concluido = 2,

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
        /// Initializes a new instance of the <see cref="NfseCancelamento" /> class.
        /// </summary>
        /// <param name="id">ID único do cancelamento gerado automaticamente pela Nuvem Fiscal..</param>
        /// <param name="status">status.</param>
        /// <param name="codigo">codigo.</param>
        /// <param name="motivo">motivo.</param>
        /// <param name="dataHora">dataHora.</param>
        /// <param name="mensagens">mensagens.</param>
        public NfseCancelamento(string id = default(string), StatusEnum? status = default(StatusEnum?), string codigo = default(string), string motivo = default(string), DateTime? dataHora = default(DateTime?), List<NfseMensagemRetorno> mensagens = default(List<NfseMensagemRetorno>))
        {
            this.id = id;
            this.status = status;
            this.codigo = codigo;
            this.motivo = motivo;
            this.data_hora = dataHora;
            this.mensagens = mensagens;
        }

        /// <summary>
        /// ID único do cancelamento gerado automaticamente pela Nuvem Fiscal.
        /// </summary>
        /// <value>ID único do cancelamento gerado automaticamente pela Nuvem Fiscal.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets codigo
        /// </summary>
        [DataMember(Name = "codigo", EmitDefaultValue = false)]
        public string codigo { get; set; }

        /// <summary>
        /// Gets or Sets motivo
        /// </summary>
        [DataMember(Name = "motivo", EmitDefaultValue = false)]
        public string motivo { get; set; }

        /// <summary>
        /// Gets or Sets data_hora
        /// </summary>
        [DataMember(Name = "data_hora", EmitDefaultValue = true)]
        public DateTime? data_hora { get; set; }

        /// <summary>
        /// Gets or Sets mensagens
        /// </summary>
        [DataMember(Name = "mensagens", EmitDefaultValue = false)]
        public List<NfseMensagemRetorno> mensagens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfseCancelamento {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  codigo: ").Append(codigo).Append("\n");
            sb.Append("  motivo: ").Append(motivo).Append("\n");
            sb.Append("  data_hora: ").Append(data_hora).Append("\n");
            sb.Append("  mensagens: ").Append(mensagens).Append("\n");
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
            return this.Equals(input as NfseCancelamento);
        }

        /// <summary>
        /// Returns true if NfseCancelamento instances are equal
        /// </summary>
        /// <param name="input">Instance of NfseCancelamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfseCancelamento input)
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
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.codigo == input.codigo ||
                    (this.codigo != null &&
                    this.codigo.Equals(input.codigo))
                ) && 
                (
                    this.motivo == input.motivo ||
                    (this.motivo != null &&
                    this.motivo.Equals(input.motivo))
                ) && 
                (
                    this.data_hora == input.data_hora ||
                    (this.data_hora != null &&
                    this.data_hora.Equals(input.data_hora))
                ) && 
                (
                    this.mensagens == input.mensagens ||
                    this.mensagens != null &&
                    input.mensagens != null &&
                    this.mensagens.SequenceEqual(input.mensagens)
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
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.codigo != null)
                {
                    hashCode = (hashCode * 59) + this.codigo.GetHashCode();
                }
                if (this.motivo != null)
                {
                    hashCode = (hashCode * 59) + this.motivo.GetHashCode();
                }
                if (this.data_hora != null)
                {
                    hashCode = (hashCode * 59) + this.data_hora.GetHashCode();
                }
                if (this.mensagens != null)
                {
                    hashCode = (hashCode * 59) + this.mensagens.GetHashCode();
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
