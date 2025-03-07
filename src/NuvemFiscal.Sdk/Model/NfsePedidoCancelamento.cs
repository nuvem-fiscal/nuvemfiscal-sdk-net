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
    /// NfsePedidoCancelamento
    /// </summary>
    [DataContract(Name = "NfsePedidoCancelamento")]
    public partial class NfsePedidoCancelamento : IEquatable<NfsePedidoCancelamento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfsePedidoCancelamento" /> class.
        /// </summary>
        /// <param name="codigo">Código de cancelamento, exigido por algumas prefeituras.  Para saber quais valores são aceitos, consulte o manual da prefeitura..</param>
        /// <param name="motivo">Motivo de cancelamento, exigido por algumas prefeituras..</param>
        public NfsePedidoCancelamento(string codigo = default(string), string motivo = default(string))
        {
            this.codigo = codigo;
            this.motivo = motivo;
        }

        /// <summary>
        /// Código de cancelamento, exigido por algumas prefeituras.  Para saber quais valores são aceitos, consulte o manual da prefeitura.
        /// </summary>
        /// <value>Código de cancelamento, exigido por algumas prefeituras.  Para saber quais valores são aceitos, consulte o manual da prefeitura.</value>
        [DataMember(Name = "codigo", EmitDefaultValue = false)]
        public string codigo { get; set; }

        /// <summary>
        /// Motivo de cancelamento, exigido por algumas prefeituras.
        /// </summary>
        /// <value>Motivo de cancelamento, exigido por algumas prefeituras.</value>
        [DataMember(Name = "motivo", EmitDefaultValue = false)]
        public string motivo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfsePedidoCancelamento {\n");
            sb.Append("  codigo: ").Append(codigo).Append("\n");
            sb.Append("  motivo: ").Append(motivo).Append("\n");
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
            return this.Equals(input as NfsePedidoCancelamento);
        }

        /// <summary>
        /// Returns true if NfsePedidoCancelamento instances are equal
        /// </summary>
        /// <param name="input">Instance of NfsePedidoCancelamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsePedidoCancelamento input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo == input.codigo ||
                    (this.codigo != null &&
                    this.codigo.Equals(input.codigo))
                ) && 
                (
                    this.motivo == input.motivo ||
                    (this.motivo != null &&
                    this.motivo.Equals(input.motivo))
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
                if (this.codigo != null)
                {
                    hashCode = (hashCode * 59) + this.codigo.GetHashCode();
                }
                if (this.motivo != null)
                {
                    hashCode = (hashCode * 59) + this.motivo.GetHashCode();
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
