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
    /// Componentes do Valor da Prestação.
    /// </summary>
    [DataContract(Name = "CteSimpSefazCompSimp")]
    public partial class CteSimpSefazCompSimp : IEquatable<CteSimpSefazCompSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazCompSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazCompSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazCompSimp" /> class.
        /// </summary>
        /// <param name="xNome">Nome do componente.  Exxemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc. (required).</param>
        /// <param name="vComp">Valor do componente. (required).</param>
        public CteSimpSefazCompSimp(string xNome = default(string), decimal? vComp = default(decimal?))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteSimpSefazCompSimp and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "vComp" is required (not null)
            if (vComp == null)
            {
                throw new ArgumentNullException("vComp is a required property for CteSimpSefazCompSimp and cannot be null");
            }
            this.vComp = vComp;
        }

        /// <summary>
        /// Nome do componente.  Exxemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc.
        /// </summary>
        /// <value>Nome do componente.  Exxemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Valor do componente.
        /// </summary>
        /// <value>Valor do componente.</value>
        [DataMember(Name = "vComp", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vComp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazCompSimp {\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  vComp: ").Append(vComp).Append("\n");
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
            return this.Equals(input as CteSimpSefazCompSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazCompSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazCompSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazCompSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.vComp == input.vComp ||
                    (this.vComp != null &&
                    this.vComp.Equals(input.vComp))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.vComp != null)
                {
                    hashCode = (hashCode * 59) + this.vComp.GetHashCode();
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
            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 15)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be less than 15.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be greater than 1.", new [] { "xNome" });
            }

            // vComp (decimal?) minimum
            if (this.vComp < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vComp, must be a value greater than or equal to 0.", new [] { "vComp" });
            }

            yield break;
        }
    }

}
