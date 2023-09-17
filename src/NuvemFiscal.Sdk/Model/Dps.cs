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
    /// Grupo de informações da DPS relativas ao serviço prestado.
    /// </summary>
    [DataContract(Name = "DPS")]
    public partial class DPS : IEquatable<DPS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DPS" /> class.
        /// </summary>
        /// <param name="serie">Série do DPS..</param>
        /// <param name="nDPS">Número do DPS..</param>
        public DPS(string serie = default(string), string nDPS = default(string))
        {
            this.serie = serie;
            this.nDPS = nDPS;
        }

        /// <summary>
        /// Série do DPS.
        /// </summary>
        /// <value>Série do DPS.</value>
        [DataMember(Name = "serie", EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número do DPS.
        /// </summary>
        /// <value>Número do DPS.</value>
        [DataMember(Name = "nDPS", EmitDefaultValue = true)]
        public string nDPS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DPS {\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nDPS: ").Append(nDPS).Append("\n");
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
            return this.Equals(input as DPS);
        }

        /// <summary>
        /// Returns true if DPS instances are equal
        /// </summary>
        /// <param name="input">Instance of DPS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DPS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nDPS == input.nDPS ||
                    (this.nDPS != null &&
                    this.nDPS.Equals(input.nDPS))
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
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nDPS != null)
                {
                    hashCode = (hashCode * 59) + this.nDPS.GetHashCode();
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
