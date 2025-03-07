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
    /// Valores da Prestação de Serviço.
    /// </summary>
    [DataContract(Name = "CteSefazVPrest")]
    public partial class CteSefazVPrest : IEquatable<CteSefazVPrest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazVPrest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazVPrest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazVPrest" /> class.
        /// </summary>
        /// <param name="vTPrest">Valor Total da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS. (required).</param>
        /// <param name="vRec">Valor a Receber. (required).</param>
        /// <param name="comp">comp.</param>
        public CteSefazVPrest(decimal? vTPrest = default(decimal?), decimal? vRec = default(decimal?), List<CteSefazComp> comp = default(List<CteSefazComp>))
        {
            // to ensure "vTPrest" is required (not null)
            if (vTPrest == null)
            {
                throw new ArgumentNullException("vTPrest is a required property for CteSefazVPrest and cannot be null");
            }
            this.vTPrest = vTPrest;
            // to ensure "vRec" is required (not null)
            if (vRec == null)
            {
                throw new ArgumentNullException("vRec is a required property for CteSefazVPrest and cannot be null");
            }
            this.vRec = vRec;
            this.Comp = comp;
        }

        /// <summary>
        /// Valor Total da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS.
        /// </summary>
        /// <value>Valor Total da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS.</value>
        [DataMember(Name = "vTPrest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTPrest { get; set; }

        /// <summary>
        /// Valor a Receber.
        /// </summary>
        /// <value>Valor a Receber.</value>
        [DataMember(Name = "vRec", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vRec { get; set; }

        /// <summary>
        /// Gets or Sets Comp
        /// </summary>
        [DataMember(Name = "Comp", EmitDefaultValue = false)]
        public List<CteSefazComp> Comp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazVPrest {\n");
            sb.Append("  vTPrest: ").Append(vTPrest).Append("\n");
            sb.Append("  vRec: ").Append(vRec).Append("\n");
            sb.Append("  Comp: ").Append(Comp).Append("\n");
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
            return this.Equals(input as CteSefazVPrest);
        }

        /// <summary>
        /// Returns true if CteSefazVPrest instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazVPrest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazVPrest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vTPrest == input.vTPrest ||
                    (this.vTPrest != null &&
                    this.vTPrest.Equals(input.vTPrest))
                ) && 
                (
                    this.vRec == input.vRec ||
                    (this.vRec != null &&
                    this.vRec.Equals(input.vRec))
                ) && 
                (
                    this.Comp == input.Comp ||
                    this.Comp != null &&
                    input.Comp != null &&
                    this.Comp.SequenceEqual(input.Comp)
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
                if (this.vTPrest != null)
                {
                    hashCode = (hashCode * 59) + this.vTPrest.GetHashCode();
                }
                if (this.vRec != null)
                {
                    hashCode = (hashCode * 59) + this.vRec.GetHashCode();
                }
                if (this.Comp != null)
                {
                    hashCode = (hashCode * 59) + this.Comp.GetHashCode();
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
            // vTPrest (decimal?) minimum
            if (this.vTPrest < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTPrest, must be a value greater than or equal to 0.", new [] { "vTPrest" });
            }

            // vRec (decimal?) minimum
            if (this.vRec < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vRec, must be a value greater than or equal to 0.", new [] { "vRec" });
            }

            yield break;
        }
    }

}
