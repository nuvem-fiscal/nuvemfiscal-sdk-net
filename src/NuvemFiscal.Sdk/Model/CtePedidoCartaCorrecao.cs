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
    /// CtePedidoCartaCorrecao
    /// </summary>
    [DataContract(Name = "CtePedidoCartaCorrecao")]
    public partial class CtePedidoCartaCorrecao : IEquatable<CtePedidoCartaCorrecao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CtePedidoCartaCorrecao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CtePedidoCartaCorrecao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CtePedidoCartaCorrecao" /> class.
        /// </summary>
        /// <param name="correcoes">Grupo de Informações de Correção. (required).</param>
        public CtePedidoCartaCorrecao(List<CteInfCorrecao> correcoes = default(List<CteInfCorrecao>))
        {
            // to ensure "correcoes" is required (not null)
            if (correcoes == null)
            {
                throw new ArgumentNullException("correcoes is a required property for CtePedidoCartaCorrecao and cannot be null");
            }
            this.correcoes = correcoes;
        }

        /// <summary>
        /// Grupo de Informações de Correção.
        /// </summary>
        /// <value>Grupo de Informações de Correção.</value>
        [DataMember(Name = "correcoes", IsRequired = true, EmitDefaultValue = true)]
        public List<CteInfCorrecao> correcoes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CtePedidoCartaCorrecao {\n");
            sb.Append("  correcoes: ").Append(correcoes).Append("\n");
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
            return this.Equals(input as CtePedidoCartaCorrecao);
        }

        /// <summary>
        /// Returns true if CtePedidoCartaCorrecao instances are equal
        /// </summary>
        /// <param name="input">Instance of CtePedidoCartaCorrecao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CtePedidoCartaCorrecao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.correcoes == input.correcoes ||
                    this.correcoes != null &&
                    input.correcoes != null &&
                    this.correcoes.SequenceEqual(input.correcoes)
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
                if (this.correcoes != null)
                {
                    hashCode = (hashCode * 59) + this.correcoes.GetHashCode();
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
