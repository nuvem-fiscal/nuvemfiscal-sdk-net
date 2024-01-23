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
    /// NfePedidoCancelamento
    /// </summary>
    [DataContract(Name = "NfePedidoCancelamento")]
    public partial class NfePedidoCancelamento : IEquatable<NfePedidoCancelamento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfePedidoCancelamento" /> class.
        /// </summary>
        /// <param name="justificativa">Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco..</param>
        public NfePedidoCancelamento(string justificativa = default(string))
        {
            this.justificativa = justificativa;
        }

        /// <summary>
        /// Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco.
        /// </summary>
        /// <value>Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco.</value>
        [DataMember(Name = "justificativa", EmitDefaultValue = false)]
        public string justificativa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfePedidoCancelamento {\n");
            sb.Append("  justificativa: ").Append(justificativa).Append("\n");
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
            return this.Equals(input as NfePedidoCancelamento);
        }

        /// <summary>
        /// Returns true if NfePedidoCancelamento instances are equal
        /// </summary>
        /// <param name="input">Instance of NfePedidoCancelamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfePedidoCancelamento input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.justificativa == input.justificativa ||
                    (this.justificativa != null &&
                    this.justificativa.Equals(input.justificativa))
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
                if (this.justificativa != null)
                {
                    hashCode = (hashCode * 59) + this.justificativa.GetHashCode();
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
