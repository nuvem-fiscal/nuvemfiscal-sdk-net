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
    /// NfsePedidoEmissao
    /// </summary>
    [DataContract(Name = "NfsePedidoEmissao")]
    public partial class NfsePedidoEmissao : IEquatable<NfsePedidoEmissao>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="NfsePedidoEmissao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfsePedidoEmissao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfsePedidoEmissao" /> class.
        /// </summary>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="rps">rps (required).</param>
        public NfsePedidoEmissao(AmbienteEnum ambiente = default(AmbienteEnum), RpsPedidoEmissao rps = default(RpsPedidoEmissao))
        {
            this.ambiente = ambiente;
            // to ensure "rps" is required (not null)
            if (rps == null)
            {
                throw new ArgumentNullException("rps is a required property for NfsePedidoEmissao and cannot be null");
            }
            this.rps = rps;
        }

        /// <summary>
        /// Gets or Sets rps
        /// </summary>
        [DataMember(Name = "rps", IsRequired = true, EmitDefaultValue = false)]
        public RpsPedidoEmissao rps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfsePedidoEmissao {\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  rps: ").Append(rps).Append("\n");
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
            return this.Equals(input as NfsePedidoEmissao);
        }

        /// <summary>
        /// Returns true if NfsePedidoEmissao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfsePedidoEmissao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsePedidoEmissao input)
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
                    this.rps == input.rps ||
                    (this.rps != null &&
                    this.rps.Equals(input.rps))
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
                if (this.rps != null)
                {
                    hashCode = (hashCode * 59) + this.rps.GetHashCode();
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
