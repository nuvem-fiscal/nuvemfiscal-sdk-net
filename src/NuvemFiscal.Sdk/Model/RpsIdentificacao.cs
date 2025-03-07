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
    /// RpsIdentificacao
    /// </summary>
    [DataContract(Name = "RpsIdentificacao")]
    public partial class RpsIdentificacao : IEquatable<RpsIdentificacao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsIdentificacao" /> class.
        /// </summary>
        /// <param name="numero">numero.</param>
        /// <param name="serie">serie.</param>
        /// <param name="tipo">tipo.</param>
        public RpsIdentificacao(string numero = default(string), string serie = default(string), string tipo = default(string))
        {
            this.numero = numero;
            this.serie = serie;
            this.tipo = tipo;
        }

        /// <summary>
        /// Gets or Sets numero
        /// </summary>
        [DataMember(Name = "numero", EmitDefaultValue = false)]
        public string numero { get; set; }

        /// <summary>
        /// Gets or Sets serie
        /// </summary>
        [DataMember(Name = "serie", EmitDefaultValue = false)]
        public string serie { get; set; }

        /// <summary>
        /// Gets or Sets tipo
        /// </summary>
        [DataMember(Name = "tipo", EmitDefaultValue = false)]
        public string tipo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsIdentificacao {\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  tipo: ").Append(tipo).Append("\n");
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
            return this.Equals(input as RpsIdentificacao);
        }

        /// <summary>
        /// Returns true if RpsIdentificacao instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsIdentificacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsIdentificacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.numero == input.numero ||
                    (this.numero != null &&
                    this.numero.Equals(input.numero))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.tipo == input.tipo ||
                    (this.tipo != null &&
                    this.tipo.Equals(input.tipo))
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
                if (this.numero != null)
                {
                    hashCode = (hashCode * 59) + this.numero.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.tipo != null)
                {
                    hashCode = (hashCode * 59) + this.tipo.GetHashCode();
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
