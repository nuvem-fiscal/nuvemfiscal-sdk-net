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
    /// NfseLoteDpsPedidoEmissao
    /// </summary>
    [DataContract(Name = "NfseLoteDpsPedidoEmissao")]
    public partial class NfseLoteDpsPedidoEmissao : IEquatable<NfseLoteDpsPedidoEmissao>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="NfseLoteDpsPedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfseLoteDpsPedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfseLoteDpsPedidoEmissao" /> class.
        /// </summary>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="referencia">Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        /// <param name="documentos">Lista com as informações das DPS relativas aos serviços prestados..</param>
        public NfseLoteDpsPedidoEmissao(AmbienteEnum ambiente = default(AmbienteEnum), string referencia = default(string), List<NfseDpsPedidoEmissao> documentos = default(List<NfseDpsPedidoEmissao>))
        {
            this.ambiente = ambiente;
            this.referencia = referencia;
            this.documentos = documentos;
        }

        /// <summary>
        /// Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Seu identificador único para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Lista com as informações das DPS relativas aos serviços prestados.
        /// </summary>
        /// <value>Lista com as informações das DPS relativas aos serviços prestados.</value>
        [DataMember(Name = "documentos", EmitDefaultValue = false)]
        public List<NfseDpsPedidoEmissao> documentos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfseLoteDpsPedidoEmissao {\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
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
            return this.Equals(input as NfseLoteDpsPedidoEmissao);
        }

        /// <summary>
        /// Returns true if NfseLoteDpsPedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfseLoteDpsPedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfseLoteDpsPedidoEmissao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
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
