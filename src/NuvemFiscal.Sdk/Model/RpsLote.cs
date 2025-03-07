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
    /// RpsLote
    /// </summary>
    [DataContract(Name = "RpsLote")]
    public partial class RpsLote : IEquatable<RpsLote>, IValidatableObject
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Novo for value: novo
            /// </summary>
            [EnumMember(Value = "novo")]
            Novo = 1,

            /// <summary>
            /// Enum FilaEnvio for value: fila_envio
            /// </summary>
            [EnumMember(Value = "fila_envio")]
            FilaEnvio = 2,

            /// <summary>
            /// Enum FilaConsulta for value: fila_consulta
            /// </summary>
            [EnumMember(Value = "fila_consulta")]
            FilaConsulta = 3,

            /// <summary>
            /// Enum Processado for value: processado
            /// </summary>
            [EnumMember(Value = "processado")]
            Processado = 4,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 5
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
        /// Initializes a new instance of the <see cref="RpsLote" /> class.
        /// </summary>
        /// <param name="id">ID único do lote gerado automaticamente pela Nuvem Fiscal..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="status">status.</param>
        /// <param name="numero">numero.</param>
        /// <param name="ambiente">ambiente.</param>
        /// <param name="referencia">referencia.</param>
        /// <param name="notas">notas.</param>
        public RpsLote(string id = default(string), DateTime createdAt = default(DateTime), StatusEnum? status = default(StatusEnum?), string numero = default(string), AmbienteEnum? ambiente = default(AmbienteEnum?), string referencia = default(string), List<Nfse> notas = default(List<Nfse>))
        {
            this.id = id;
            this.created_at = createdAt;
            this.status = status;
            this.numero = numero;
            this.ambiente = ambiente;
            this.referencia = referencia;
            this.notas = notas;
        }

        /// <summary>
        /// ID único do lote gerado automaticamente pela Nuvem Fiscal.
        /// </summary>
        /// <value>ID único do lote gerado automaticamente pela Nuvem Fiscal.</value>
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
        /// Gets or Sets referencia
        /// </summary>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets notas
        /// </summary>
        [DataMember(Name = "notas", EmitDefaultValue = false)]
        public List<Nfse> notas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsLote {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  notas: ").Append(notas).Append("\n");
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
            return this.Equals(input as RpsLote);
        }

        /// <summary>
        /// Returns true if RpsLote instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsLote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsLote input)
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
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
                ) && 
                (
                    this.notas == input.notas ||
                    this.notas != null &&
                    input.notas != null &&
                    this.notas.SequenceEqual(input.notas)
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
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
                }
                if (this.notas != null)
                {
                    hashCode = (hashCode * 59) + this.notas.GetHashCode();
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
