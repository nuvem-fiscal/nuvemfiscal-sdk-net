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
    /// CtePedidoEmissao
    /// </summary>
    [DataContract(Name = "CtePedidoEmissao")]
    public partial class CtePedidoEmissao : IEquatable<CtePedidoEmissao>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="CtePedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CtePedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CtePedidoEmissao" /> class.
        /// </summary>
        /// <param name="infCte">infCte (required).</param>
        /// <param name="infCTeSupl">infCTeSupl.</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        public CtePedidoEmissao(CteSefazInfCte infCte = default(CteSefazInfCte), CteSefazInfCTeSupl infCTeSupl = default(CteSefazInfCTeSupl), AmbienteEnum ambiente = default(AmbienteEnum), string referencia = default(string))
        {
            // to ensure "infCte" is required (not null)
            if (infCte == null)
            {
                throw new ArgumentNullException("infCte is a required property for CtePedidoEmissao and cannot be null");
            }
            this.infCte = infCte;
            this.ambiente = ambiente;
            this.infCTeSupl = infCTeSupl;
            this.referencia = referencia;
        }

        /// <summary>
        /// Gets or Sets infCte
        /// </summary>
        [DataMember(Name = "infCte", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazInfCte infCte { get; set; }

        /// <summary>
        /// Gets or Sets infCTeSupl
        /// </summary>
        [DataMember(Name = "infCTeSupl", EmitDefaultValue = false)]
        public CteSefazInfCTeSupl infCTeSupl { get; set; }

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
            sb.Append("class CtePedidoEmissao {\n");
            sb.Append("  infCte: ").Append(infCte).Append("\n");
            sb.Append("  infCTeSupl: ").Append(infCTeSupl).Append("\n");
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
            return this.Equals(input as CtePedidoEmissao);
        }

        /// <summary>
        /// Returns true if CtePedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of CtePedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CtePedidoEmissao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infCte == input.infCte ||
                    (this.infCte != null &&
                    this.infCte.Equals(input.infCte))
                ) && 
                (
                    this.infCTeSupl == input.infCTeSupl ||
                    (this.infCTeSupl != null &&
                    this.infCTeSupl.Equals(input.infCTeSupl))
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
                if (this.infCte != null)
                {
                    hashCode = (hashCode * 59) + this.infCte.GetHashCode();
                }
                if (this.infCTeSupl != null)
                {
                    hashCode = (hashCode * 59) + this.infCTeSupl.GetHashCode();
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
