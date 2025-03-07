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
    /// RpsDadosConstrucaoCivil
    /// </summary>
    [DataContract(Name = "RpsDadosConstrucaoCivil")]
    public partial class RpsDadosConstrucaoCivil : IEquatable<RpsDadosConstrucaoCivil>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosConstrucaoCivil" /> class.
        /// </summary>
        /// <param name="codigoObra">codigoObra.</param>
        /// <param name="art">art.</param>
        public RpsDadosConstrucaoCivil(string codigoObra = default(string), string art = default(string))
        {
            this.codigo_obra = codigoObra;
            this.art = art;
        }

        /// <summary>
        /// Gets or Sets codigo_obra
        /// </summary>
        [DataMember(Name = "codigo_obra", EmitDefaultValue = false)]
        public string codigo_obra { get; set; }

        /// <summary>
        /// Gets or Sets art
        /// </summary>
        [DataMember(Name = "art", EmitDefaultValue = false)]
        public string art { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsDadosConstrucaoCivil {\n");
            sb.Append("  codigo_obra: ").Append(codigo_obra).Append("\n");
            sb.Append("  art: ").Append(art).Append("\n");
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
            return this.Equals(input as RpsDadosConstrucaoCivil);
        }

        /// <summary>
        /// Returns true if RpsDadosConstrucaoCivil instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsDadosConstrucaoCivil to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsDadosConstrucaoCivil input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo_obra == input.codigo_obra ||
                    (this.codigo_obra != null &&
                    this.codigo_obra.Equals(input.codigo_obra))
                ) && 
                (
                    this.art == input.art ||
                    (this.art != null &&
                    this.art.Equals(input.art))
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
                if (this.codigo_obra != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_obra.GetHashCode();
                }
                if (this.art != null)
                {
                    hashCode = (hashCode * 59) + this.art.GetHashCode();
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
