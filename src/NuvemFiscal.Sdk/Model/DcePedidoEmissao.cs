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
    /// DcePedidoEmissao
    /// </summary>
    [DataContract(Name = "DcePedidoEmissao")]
    public partial class DcePedidoEmissao : IEquatable<DcePedidoEmissao>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="DcePedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DcePedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DcePedidoEmissao" /> class.
        /// </summary>
        /// <param name="infDCe">infDCe (required).</param>
        /// <param name="infSolicDCe">infSolicDCe (required).</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        public DcePedidoEmissao(DceSefazInfDCe infDCe = default(DceSefazInfDCe), DceSefazInfSolicDCe infSolicDCe = default(DceSefazInfSolicDCe), AmbienteEnum ambiente = default(AmbienteEnum), string referencia = default(string))
        {
            // to ensure "infDCe" is required (not null)
            if (infDCe == null)
            {
                throw new ArgumentNullException("infDCe is a required property for DcePedidoEmissao and cannot be null");
            }
            this.infDCe = infDCe;
            // to ensure "infSolicDCe" is required (not null)
            if (infSolicDCe == null)
            {
                throw new ArgumentNullException("infSolicDCe is a required property for DcePedidoEmissao and cannot be null");
            }
            this.infSolicDCe = infSolicDCe;
            this.ambiente = ambiente;
            this.referencia = referencia;
        }

        /// <summary>
        /// Gets or Sets infDCe
        /// </summary>
        [DataMember(Name = "infDCe", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazInfDCe infDCe { get; set; }

        /// <summary>
        /// Gets or Sets infSolicDCe
        /// </summary>
        [DataMember(Name = "infSolicDCe", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazInfSolicDCe infSolicDCe { get; set; }

        /// <summary>
        /// Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = true)]
        public string referencia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DcePedidoEmissao {\n");
            sb.Append("  infDCe: ").Append(infDCe).Append("\n");
            sb.Append("  infSolicDCe: ").Append(infSolicDCe).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
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
            return this.Equals(input as DcePedidoEmissao);
        }

        /// <summary>
        /// Returns true if DcePedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of DcePedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DcePedidoEmissao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infDCe == input.infDCe ||
                    (this.infDCe != null &&
                    this.infDCe.Equals(input.infDCe))
                ) && 
                (
                    this.infSolicDCe == input.infSolicDCe ||
                    (this.infSolicDCe != null &&
                    this.infSolicDCe.Equals(input.infSolicDCe))
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
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
                if (this.infDCe != null)
                {
                    hashCode = (hashCode * 59) + this.infDCe.GetHashCode();
                }
                if (this.infSolicDCe != null)
                {
                    hashCode = (hashCode * 59) + this.infSolicDCe.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
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
