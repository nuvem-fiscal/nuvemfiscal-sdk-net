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
    /// DfeLote
    /// </summary>
    [DataContract(Name = "DfeLote")]
    public partial class DfeLote : IEquatable<DfeLote>, IValidatableObject
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
            /// Enum Processado for value: processado
            /// </summary>
            [EnumMember(Value = "processado")]
            Processado = 2,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 3

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
        /// Initializes a new instance of the <see cref="DfeLote" /> class.
        /// </summary>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para este documento..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="status">status.</param>
        /// <param name="ambiente">ambiente.</param>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        /// <param name="idLote">idLote.</param>
        /// <param name="recibo">recibo.</param>
        /// <param name="documentos">documentos.</param>
        public DfeLote(string id = default(string), DateTime createdAt = default(DateTime), StatusEnum? status = default(StatusEnum?), AmbienteEnum? ambiente = default(AmbienteEnum?), string referencia = default(string), string idLote = default(string), DfeRecibo recibo = default(DfeRecibo), List<Dfe> documentos = default(List<Dfe>))
        {
            this.id = id;
            this.created_at = createdAt;
            this.status = status;
            this.ambiente = ambiente;
            this.referencia = referencia;
            this.id_lote = idLote;
            this.recibo = recibo;
            this.documentos = documentos;
        }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para este documento.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para este documento.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets created_at
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = true)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets id_lote
        /// </summary>
        [DataMember(Name = "id_lote", EmitDefaultValue = true)]
        public string id_lote { get; set; }

        /// <summary>
        /// Gets or Sets recibo
        /// </summary>
        [DataMember(Name = "recibo", EmitDefaultValue = false)]
        public DfeRecibo recibo { get; set; }

        /// <summary>
        /// Gets or Sets documentos
        /// </summary>
        [DataMember(Name = "documentos", EmitDefaultValue = false)]
        public List<Dfe> documentos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeLote {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  id_lote: ").Append(id_lote).Append("\n");
            sb.Append("  recibo: ").Append(recibo).Append("\n");
            sb.Append("  documentos: ").Append(documentos).Append("\n");
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
            return this.Equals(input as DfeLote);
        }

        /// <summary>
        /// Returns true if DfeLote instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeLote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeLote input)
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
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
                ) && 
                (
                    this.id_lote == input.id_lote ||
                    (this.id_lote != null &&
                    this.id_lote.Equals(input.id_lote))
                ) && 
                (
                    this.recibo == input.recibo ||
                    (this.recibo != null &&
                    this.recibo.Equals(input.recibo))
                ) && 
                (
                    this.documentos == input.documentos ||
                    this.documentos != null &&
                    input.documentos != null &&
                    this.documentos.SequenceEqual(input.documentos)
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
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
                }
                if (this.id_lote != null)
                {
                    hashCode = (hashCode * 59) + this.id_lote.GetHashCode();
                }
                if (this.recibo != null)
                {
                    hashCode = (hashCode * 59) + this.recibo.GetHashCode();
                }
                if (this.documentos != null)
                {
                    hashCode = (hashCode * 59) + this.documentos.GetHashCode();
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
