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
    /// MdfePedidoEmissaoLote
    /// </summary>
    [DataContract(Name = "MdfePedidoEmissaoLote")]
    public partial class MdfePedidoEmissaoLote : IEquatable<MdfePedidoEmissaoLote>, IValidatableObject
    {
        /// <summary>
        /// Identificação do Ambiente.
        /// </summary>
        /// <value>Identificação do Ambiente.</value>
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
        /// Identificação do Ambiente.
        /// </summary>
        /// <value>Identificação do Ambiente.</value>
        [DataMember(Name = "ambiente", IsRequired = true, EmitDefaultValue = true)]
        public AmbienteEnum ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoEmissaoLote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfePedidoEmissaoLote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoEmissaoLote" /> class.
        /// </summary>
        /// <param name="documentos">documentos.</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="referencia">Seu identificador para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        /// <param name="idLote">idLote (required).</param>
        public MdfePedidoEmissaoLote(List<MdfePedidoEmissao> documentos = default(List<MdfePedidoEmissao>), AmbienteEnum ambiente = default(AmbienteEnum), string referencia = default(string), string idLote = default(string))
        {
            this.ambiente = ambiente;
            // to ensure "idLote" is required (not null)
            if (idLote == null)
            {
                throw new ArgumentNullException("idLote is a required property for MdfePedidoEmissaoLote and cannot be null");
            }
            this.id_lote = idLote;
            this.documentos = documentos;
            this.referencia = referencia;
        }

        /// <summary>
        /// Gets or Sets documentos
        /// </summary>
        [DataMember(Name = "documentos", EmitDefaultValue = false)]
        public List<MdfePedidoEmissao> documentos { get; set; }

        /// <summary>
        /// Seu identificador para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Seu identificador para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets id_lote
        /// </summary>
        [DataMember(Name = "id_lote", IsRequired = true, EmitDefaultValue = true)]
        public string id_lote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfePedidoEmissaoLote {\n");
            sb.Append("  documentos: ").Append(documentos).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  id_lote: ").Append(id_lote).Append("\n");
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
            return this.Equals(input as MdfePedidoEmissaoLote);
        }

        /// <summary>
        /// Returns true if MdfePedidoEmissaoLote instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfePedidoEmissaoLote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfePedidoEmissaoLote input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.documentos == input.documentos ||
                    this.documentos != null &&
                    input.documentos != null &&
                    this.documentos.SequenceEqual(input.documentos)
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
                if (this.documentos != null)
                {
                    hashCode = (hashCode * 59) + this.documentos.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
                }
                if (this.id_lote != null)
                {
                    hashCode = (hashCode * 59) + this.id_lote.GetHashCode();
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
            // referencia (string) maxLength
            if (this.referencia != null && this.referencia.Length > 50)
            {
                yield return new ValidationResult("Invalid value for referencia, length must be less than 50.", new [] { "referencia" });
            }

            yield break;
        }
    }

}
