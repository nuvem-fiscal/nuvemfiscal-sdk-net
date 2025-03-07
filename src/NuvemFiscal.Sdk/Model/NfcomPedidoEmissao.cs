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
    /// NfcomPedidoEmissao
    /// </summary>
    [DataContract(Name = "NfcomPedidoEmissao")]
    public partial class NfcomPedidoEmissao : IEquatable<NfcomPedidoEmissao>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="NfcomPedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomPedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomPedidoEmissao" /> class.
        /// </summary>
        /// <param name="infNFCom">infNFCom (required).</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        public NfcomPedidoEmissao(NfcomSefazInfNFCom infNFCom = default(NfcomSefazInfNFCom), AmbienteEnum ambiente = default(AmbienteEnum), string referencia = default(string))
        {
            // to ensure "infNFCom" is required (not null)
            if (infNFCom == null)
            {
                throw new ArgumentNullException("infNFCom is a required property for NfcomPedidoEmissao and cannot be null");
            }
            this.infNFCom = infNFCom;
            this.ambiente = ambiente;
            this.referencia = referencia;
        }

        /// <summary>
        /// Gets or Sets infNFCom
        /// </summary>
        [DataMember(Name = "infNFCom", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazInfNFCom infNFCom { get; set; }

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
            sb.Append("class NfcomPedidoEmissao {\n");
            sb.Append("  infNFCom: ").Append(infNFCom).Append("\n");
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
            return this.Equals(input as NfcomPedidoEmissao);
        }

        /// <summary>
        /// Returns true if NfcomPedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomPedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomPedidoEmissao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infNFCom == input.infNFCom ||
                    (this.infNFCom != null &&
                    this.infNFCom.Equals(input.infNFCom))
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
                if (this.infNFCom != null)
                {
                    hashCode = (hashCode * 59) + this.infNFCom.GetHashCode();
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
