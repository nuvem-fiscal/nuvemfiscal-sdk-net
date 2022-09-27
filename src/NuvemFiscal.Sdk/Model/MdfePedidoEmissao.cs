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
    /// MdfePedidoEmissao
    /// </summary>
    [DataContract(Name = "MdfePedidoEmissao")]
    public partial class MdfePedidoEmissao : IEquatable<MdfePedidoEmissao>, IValidatableObject
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
        [DataMember(Name = "ambiente", IsRequired = true, EmitDefaultValue = false)]
        public AmbienteEnum ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfePedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoEmissao" /> class.
        /// </summary>
        /// <param name="infMDFe">infMDFe (required).</param>
        /// <param name="infMDFeSupl">infMDFeSupl.</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        public MdfePedidoEmissao(MdfeSefazInfMDFe infMDFe = default(MdfeSefazInfMDFe), MdfeSefazInfMDFeSupl infMDFeSupl = default(MdfeSefazInfMDFeSupl), AmbienteEnum ambiente = default(AmbienteEnum), string referencia = default(string))
        {
            // to ensure "infMDFe" is required (not null)
            if (infMDFe == null)
            {
                throw new ArgumentNullException("infMDFe is a required property for MdfePedidoEmissao and cannot be null");
            }
            this.infMDFe = infMDFe;
            this.ambiente = ambiente;
            this.infMDFeSupl = infMDFeSupl;
            this.referencia = referencia;
        }

        /// <summary>
        /// Gets or Sets infMDFe
        /// </summary>
        [DataMember(Name = "infMDFe", IsRequired = true, EmitDefaultValue = false)]
        public MdfeSefazInfMDFe infMDFe { get; set; }

        /// <summary>
        /// Gets or Sets infMDFeSupl
        /// </summary>
        [DataMember(Name = "infMDFeSupl", EmitDefaultValue = false)]
        public MdfeSefazInfMDFeSupl infMDFeSupl { get; set; }

        /// <summary>
        /// Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfePedidoEmissao {\n");
            sb.Append("  infMDFe: ").Append(infMDFe).Append("\n");
            sb.Append("  infMDFeSupl: ").Append(infMDFeSupl).Append("\n");
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
            return this.Equals(input as MdfePedidoEmissao);
        }

        /// <summary>
        /// Returns true if MdfePedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfePedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfePedidoEmissao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infMDFe == input.infMDFe ||
                    (this.infMDFe != null &&
                    this.infMDFe.Equals(input.infMDFe))
                ) && 
                (
                    this.infMDFeSupl == input.infMDFeSupl ||
                    (this.infMDFeSupl != null &&
                    this.infMDFeSupl.Equals(input.infMDFeSupl))
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
                if (this.infMDFe != null)
                {
                    hashCode = (hashCode * 59) + this.infMDFe.GetHashCode();
                }
                if (this.infMDFeSupl != null)
                {
                    hashCode = (hashCode * 59) + this.infMDFeSupl.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
