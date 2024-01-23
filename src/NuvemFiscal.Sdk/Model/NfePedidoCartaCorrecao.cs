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
    /// NfePedidoCartaCorrecao
    /// </summary>
    [DataContract(Name = "NfePedidoCartaCorrecao")]
    public partial class NfePedidoCartaCorrecao : IEquatable<NfePedidoCartaCorrecao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfePedidoCartaCorrecao" /> class.
        /// </summary>
        /// <param name="correcao">Correção a ser considerada..</param>
        public NfePedidoCartaCorrecao(string correcao = default(string))
        {
            this.correcao = correcao;
        }

        /// <summary>
        /// Correção a ser considerada.
        /// </summary>
        /// <value>Correção a ser considerada.</value>
        [DataMember(Name = "correcao", EmitDefaultValue = false)]
        public string correcao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfePedidoCartaCorrecao {\n");
            sb.Append("  correcao: ").Append(correcao).Append("\n");
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
            return this.Equals(input as NfePedidoCartaCorrecao);
        }

        /// <summary>
        /// Returns true if NfePedidoCartaCorrecao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfePedidoCartaCorrecao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfePedidoCartaCorrecao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.correcao == input.correcao ||
                    (this.correcao != null &&
                    this.correcao.Equals(input.correcao))
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
                if (this.correcao != null)
                {
                    hashCode = (hashCode * 59) + this.correcao.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
