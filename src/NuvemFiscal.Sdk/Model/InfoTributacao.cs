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
    /// Grupo de informações relacionados aos tributos relacionados ao serviço prestado.
    /// </summary>
    [DataContract(Name = "InfoTributacao")]
    public partial class InfoTributacao : IEquatable<InfoTributacao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoTributacao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoTributacao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoTributacao" /> class.
        /// </summary>
        /// <param name="tribMun">tribMun (required).</param>
        /// <param name="tribFed">tribFed.</param>
        /// <param name="totTrib">totTrib.</param>
        public InfoTributacao(TribMunicipal tribMun = default(TribMunicipal), TribFederal tribFed = default(TribFederal), TribTotal totTrib = default(TribTotal))
        {
            // to ensure "tribMun" is required (not null)
            if (tribMun == null)
            {
                throw new ArgumentNullException("tribMun is a required property for InfoTributacao and cannot be null");
            }
            this.tribMun = tribMun;
            this.tribFed = tribFed;
            this.totTrib = totTrib;
        }

        /// <summary>
        /// Gets or Sets tribMun
        /// </summary>
        [DataMember(Name = "tribMun", IsRequired = true, EmitDefaultValue = true)]
        public TribMunicipal tribMun { get; set; }

        /// <summary>
        /// Gets or Sets tribFed
        /// </summary>
        [DataMember(Name = "tribFed", EmitDefaultValue = false)]
        public TribFederal tribFed { get; set; }

        /// <summary>
        /// Gets or Sets totTrib
        /// </summary>
        [DataMember(Name = "totTrib", EmitDefaultValue = false)]
        public TribTotal totTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoTributacao {\n");
            sb.Append("  tribMun: ").Append(tribMun).Append("\n");
            sb.Append("  tribFed: ").Append(tribFed).Append("\n");
            sb.Append("  totTrib: ").Append(totTrib).Append("\n");
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
            return this.Equals(input as InfoTributacao);
        }

        /// <summary>
        /// Returns true if InfoTributacao instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoTributacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoTributacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tribMun == input.tribMun ||
                    (this.tribMun != null &&
                    this.tribMun.Equals(input.tribMun))
                ) && 
                (
                    this.tribFed == input.tribFed ||
                    (this.tribFed != null &&
                    this.tribFed.Equals(input.tribFed))
                ) && 
                (
                    this.totTrib == input.totTrib ||
                    (this.totTrib != null &&
                    this.totTrib.Equals(input.totTrib))
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
                if (this.tribMun != null)
                {
                    hashCode = (hashCode * 59) + this.tribMun.GetHashCode();
                }
                if (this.tribFed != null)
                {
                    hashCode = (hashCode * 59) + this.tribFed.GetHashCode();
                }
                if (this.totTrib != null)
                {
                    hashCode = (hashCode * 59) + this.totTrib.GetHashCode();
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
