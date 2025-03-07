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
    /// Grupo de informações relativas aos valores do serviço prestado.
    /// </summary>
    [DataContract(Name = "VServPrest")]
    public partial class VServPrest : IEquatable<VServPrest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VServPrest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VServPrest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VServPrest" /> class.
        /// </summary>
        /// <param name="vReceb">Valor monetário recebido pelo intermediário do serviço (R$)..</param>
        /// <param name="vServ">Valor dos serviços em R$. (required).</param>
        public VServPrest(decimal? vReceb = default(decimal?), decimal? vServ = default(decimal?))
        {
            // to ensure "vServ" is required (not null)
            if (vServ == null)
            {
                throw new ArgumentNullException("vServ is a required property for VServPrest and cannot be null");
            }
            this.vServ = vServ;
            this.vReceb = vReceb;
        }

        /// <summary>
        /// Valor monetário recebido pelo intermediário do serviço (R$).
        /// </summary>
        /// <value>Valor monetário recebido pelo intermediário do serviço (R$).</value>
        [DataMember(Name = "vReceb", EmitDefaultValue = true)]
        public decimal? vReceb { get; set; }

        /// <summary>
        /// Valor dos serviços em R$.
        /// </summary>
        /// <value>Valor dos serviços em R$.</value>
        [DataMember(Name = "vServ", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vServ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VServPrest {\n");
            sb.Append("  vReceb: ").Append(vReceb).Append("\n");
            sb.Append("  vServ: ").Append(vServ).Append("\n");
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
            return this.Equals(input as VServPrest);
        }

        /// <summary>
        /// Returns true if VServPrest instances are equal
        /// </summary>
        /// <param name="input">Instance of VServPrest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VServPrest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vReceb == input.vReceb ||
                    (this.vReceb != null &&
                    this.vReceb.Equals(input.vReceb))
                ) && 
                (
                    this.vServ == input.vServ ||
                    (this.vServ != null &&
                    this.vServ.Equals(input.vServ))
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
                if (this.vReceb != null)
                {
                    hashCode = (hashCode * 59) + this.vReceb.GetHashCode();
                }
                if (this.vServ != null)
                {
                    hashCode = (hashCode * 59) + this.vServ.GetHashCode();
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
            // vReceb (decimal?) minimum
            if (this.vReceb < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vReceb, must be a value greater than or equal to 0.", new [] { "vReceb" });
            }

            // vServ (decimal?) minimum
            if (this.vServ < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vServ, must be a value greater than or equal to 0.", new [] { "vServ" });
            }

            yield break;
        }
    }

}
