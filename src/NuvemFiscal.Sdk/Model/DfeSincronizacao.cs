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
    /// DfeSincronizacao
    /// </summary>
    [DataContract(Name = "DfeSincronizacao")]
    public partial class DfeSincronizacao : IEquatable<DfeSincronizacao>, IValidatableObject
    {
        /// <summary>
        /// Situação atual da sincronização.
        /// </summary>
        /// <value>Situação atual da sincronização.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pendente for value: pendente
            /// </summary>
            [EnumMember(Value = "pendente")]
            Pendente = 1,

            /// <summary>
            /// Enum Sincronizado for value: sincronizado
            /// </summary>
            [EnumMember(Value = "sincronizado")]
            Sincronizado = 2,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 3
        }


        /// <summary>
        /// Situação atual da sincronização.
        /// </summary>
        /// <value>Situação atual da sincronização.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeSincronizacao" /> class.
        /// </summary>
        /// <param name="status">Situação atual da sincronização..</param>
        /// <param name="codigoStatus">Código da situação atual do DF-e..</param>
        /// <param name="motivoStatus">Descrição literal da situação atual do DF-e..</param>
        /// <param name="dataRecebimento">Data e hora de processamento..</param>
        /// <param name="chave">Chave de Acesso do DF-e consultado..</param>
        public DfeSincronizacao(StatusEnum? status = default(StatusEnum?), int codigoStatus = default(int), string motivoStatus = default(string), DateTime dataRecebimento = default(DateTime), string chave = default(string))
        {
            this.status = status;
            this.codigo_status = codigoStatus;
            this.motivo_status = motivoStatus;
            this.data_recebimento = dataRecebimento;
            this.chave = chave;
        }

        /// <summary>
        /// Código da situação atual do DF-e.
        /// </summary>
        /// <value>Código da situação atual do DF-e.</value>
        [DataMember(Name = "codigo_status", EmitDefaultValue = false)]
        public int codigo_status { get; set; }

        /// <summary>
        /// Descrição literal da situação atual do DF-e.
        /// </summary>
        /// <value>Descrição literal da situação atual do DF-e.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = false)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Data e hora de processamento.
        /// </summary>
        /// <value>Data e hora de processamento.</value>
        [DataMember(Name = "data_recebimento", EmitDefaultValue = false)]
        public DateTime data_recebimento { get; set; }

        /// <summary>
        /// Chave de Acesso do DF-e consultado.
        /// </summary>
        /// <value>Chave de Acesso do DF-e consultado.</value>
        [DataMember(Name = "chave", EmitDefaultValue = false)]
        public string chave { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeSincronizacao {\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  data_recebimento: ").Append(data_recebimento).Append("\n");
            sb.Append("  chave: ").Append(chave).Append("\n");
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
            return this.Equals(input as DfeSincronizacao);
        }

        /// <summary>
        /// Returns true if DfeSincronizacao instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeSincronizacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeSincronizacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
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
                    this.data_recebimento == input.data_recebimento ||
                    (this.data_recebimento != null &&
                    this.data_recebimento.Equals(input.data_recebimento))
                ) && 
                (
                    this.chave == input.chave ||
                    (this.chave != null &&
                    this.chave.Equals(input.chave))
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
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.data_recebimento != null)
                {
                    hashCode = (hashCode * 59) + this.data_recebimento.GetHashCode();
                }
                if (this.chave != null)
                {
                    hashCode = (hashCode * 59) + this.chave.GetHashCode();
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
