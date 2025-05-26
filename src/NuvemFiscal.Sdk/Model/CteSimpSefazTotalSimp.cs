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
    /// Valores Totais do CTe.
    /// </summary>
    [DataContract(Name = "CteSimpSefazTotalSimp")]
    public partial class CteSimpSefazTotalSimp : IEquatable<CteSimpSefazTotalSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazTotalSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazTotalSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazTotalSimp" /> class.
        /// </summary>
        /// <param name="vTPrest">Valor Total da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS. (required).</param>
        /// <param name="vTRec">Valor total a Receber. (required).</param>
        public CteSimpSefazTotalSimp(decimal? vTPrest = default(decimal?), decimal? vTRec = default(decimal?))
        {
            // to ensure "vTPrest" is required (not null)
            if (vTPrest == null)
            {
                throw new ArgumentNullException("vTPrest is a required property for CteSimpSefazTotalSimp and cannot be null");
            }
            this.vTPrest = vTPrest;
            // to ensure "vTRec" is required (not null)
            if (vTRec == null)
            {
                throw new ArgumentNullException("vTRec is a required property for CteSimpSefazTotalSimp and cannot be null");
            }
            this.vTRec = vTRec;
        }

        /// <summary>
        /// Valor Total da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS.
        /// </summary>
        /// <value>Valor Total da Prestação do Serviço.  Pode conter zeros quando o CT-e for de complemento de ICMS.</value>
        [DataMember(Name = "vTPrest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTPrest { get; set; }

        /// <summary>
        /// Valor total a Receber.
        /// </summary>
        /// <value>Valor total a Receber.</value>
        [DataMember(Name = "vTRec", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTRec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazTotalSimp {\n");
            sb.Append("  vTPrest: ").Append(vTPrest).Append("\n");
            sb.Append("  vTRec: ").Append(vTRec).Append("\n");
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
            return this.Equals(input as CteSimpSefazTotalSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazTotalSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazTotalSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazTotalSimp input)
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
                    this.vTRec == input.vTRec ||
                    (this.vTRec != null &&
                    this.vTRec.Equals(input.vTRec))
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
                if (this.vTRec != null)
                {
                    hashCode = (hashCode * 59) + this.vTRec.GetHashCode();
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

            // vTRec (decimal?) minimum
            if (this.vTRec < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTRec, must be a value greater than or equal to 0.", new [] { "vTRec" });
            }

            yield break;
        }
    }

}
