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
    /// Grupo de informações sobre o CréditoPresumido.
    /// </summary>
    [DataContract(Name = "NfeSefazGCred")]
    public partial class NfeSefazGCred : IEquatable<NfeSefazGCred>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCred" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCred() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCred" /> class.
        /// </summary>
        /// <param name="cCredPresumido">Código de Benefício Fiscal de Crédito Presumido na UF aplicado ao item. (required).</param>
        /// <param name="pCredPresumido">Percentual do Crédito Presumido. (required).</param>
        /// <param name="vCredPresumido">Valor do Crédito Presumido. (required).</param>
        public NfeSefazGCred(string cCredPresumido = default(string), decimal? pCredPresumido = default(decimal?), decimal? vCredPresumido = default(decimal?))
        {
            // to ensure "cCredPresumido" is required (not null)
            if (cCredPresumido == null)
            {
                throw new ArgumentNullException("cCredPresumido is a required property for NfeSefazGCred and cannot be null");
            }
            this.cCredPresumido = cCredPresumido;
            // to ensure "pCredPresumido" is required (not null)
            if (pCredPresumido == null)
            {
                throw new ArgumentNullException("pCredPresumido is a required property for NfeSefazGCred and cannot be null");
            }
            this.pCredPresumido = pCredPresumido;
            // to ensure "vCredPresumido" is required (not null)
            if (vCredPresumido == null)
            {
                throw new ArgumentNullException("vCredPresumido is a required property for NfeSefazGCred and cannot be null");
            }
            this.vCredPresumido = vCredPresumido;
        }

        /// <summary>
        /// Código de Benefício Fiscal de Crédito Presumido na UF aplicado ao item.
        /// </summary>
        /// <value>Código de Benefício Fiscal de Crédito Presumido na UF aplicado ao item.</value>
        [DataMember(Name = "cCredPresumido", IsRequired = true, EmitDefaultValue = true)]
        public string cCredPresumido { get; set; }

        /// <summary>
        /// Percentual do Crédito Presumido.
        /// </summary>
        /// <value>Percentual do Crédito Presumido.</value>
        [DataMember(Name = "pCredPresumido", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pCredPresumido { get; set; }

        /// <summary>
        /// Valor do Crédito Presumido.
        /// </summary>
        /// <value>Valor do Crédito Presumido.</value>
        [DataMember(Name = "vCredPresumido", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCredPresumido { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGCred {\n");
            sb.Append("  cCredPresumido: ").Append(cCredPresumido).Append("\n");
            sb.Append("  pCredPresumido: ").Append(pCredPresumido).Append("\n");
            sb.Append("  vCredPresumido: ").Append(vCredPresumido).Append("\n");
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
            return this.Equals(input as NfeSefazGCred);
        }

        /// <summary>
        /// Returns true if NfeSefazGCred instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCred to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCred input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cCredPresumido == input.cCredPresumido ||
                    (this.cCredPresumido != null &&
                    this.cCredPresumido.Equals(input.cCredPresumido))
                ) && 
                (
                    this.pCredPresumido == input.pCredPresumido ||
                    (this.pCredPresumido != null &&
                    this.pCredPresumido.Equals(input.pCredPresumido))
                ) && 
                (
                    this.vCredPresumido == input.vCredPresumido ||
                    (this.vCredPresumido != null &&
                    this.vCredPresumido.Equals(input.vCredPresumido))
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
                if (this.cCredPresumido != null)
                {
                    hashCode = (hashCode * 59) + this.cCredPresumido.GetHashCode();
                }
                if (this.pCredPresumido != null)
                {
                    hashCode = (hashCode * 59) + this.pCredPresumido.GetHashCode();
                }
                if (this.vCredPresumido != null)
                {
                    hashCode = (hashCode * 59) + this.vCredPresumido.GetHashCode();
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
            // pCredPresumido (decimal?) minimum
            if (this.pCredPresumido < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pCredPresumido, must be a value greater than or equal to 0.", new [] { "pCredPresumido" });
            }

            // vCredPresumido (decimal?) minimum
            if (this.vCredPresumido < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCredPresumido, must be a value greater than or equal to 0.", new [] { "vCredPresumido" });
            }

            yield break;
        }
    }

}
