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
    /// EmpresaConfigRps
    /// </summary>
    [DataContract(Name = "EmpresaConfigRps")]
    public partial class EmpresaConfigRps : IEquatable<EmpresaConfigRps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigRps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmpresaConfigRps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigRps" /> class.
        /// </summary>
        /// <param name="lote">lote (required).</param>
        /// <param name="serie">serie (required).</param>
        /// <param name="numero">numero (required).</param>
        public EmpresaConfigRps(int lote = default(int), string serie = default(string), int numero = default(int))
        {
            this.lote = lote;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for EmpresaConfigRps and cannot be null");
            }
            this.serie = serie;
            this.numero = numero;
        }

        /// <summary>
        /// Gets or Sets lote
        /// </summary>
        [DataMember(Name = "lote", IsRequired = true, EmitDefaultValue = false)]
        public int lote { get; set; }

        /// <summary>
        /// Gets or Sets serie
        /// </summary>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = false)]
        public string serie { get; set; }

        /// <summary>
        /// Gets or Sets numero
        /// </summary>
        [DataMember(Name = "numero", IsRequired = true, EmitDefaultValue = false)]
        public int numero { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigRps {\n");
            sb.Append("  lote: ").Append(lote).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
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
            return this.Equals(input as EmpresaConfigRps);
        }

        /// <summary>
        /// Returns true if EmpresaConfigRps instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigRps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigRps input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.lote == input.lote ||
                    this.lote.Equals(input.lote)
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.numero == input.numero ||
                    this.numero.Equals(input.numero)
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
                hashCode = (hashCode * 59) + this.lote.GetHashCode();
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.numero.GetHashCode();
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
