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
    /// Informações da carga lotação. Informar somente quando MDF-e for de carga lotação.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfLotacao")]
    public partial class MdfeSefazInfLotacao : IEquatable<MdfeSefazInfLotacao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfLotacao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfLotacao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfLotacao" /> class.
        /// </summary>
        /// <param name="infLocalCarrega">infLocalCarrega (required).</param>
        /// <param name="infLocalDescarrega">infLocalDescarrega (required).</param>
        public MdfeSefazInfLotacao(MdfeSefazInfLocalCarrega infLocalCarrega = default(MdfeSefazInfLocalCarrega), MdfeSefazInfLocalDescarrega infLocalDescarrega = default(MdfeSefazInfLocalDescarrega))
        {
            // to ensure "infLocalCarrega" is required (not null)
            if (infLocalCarrega == null)
            {
                throw new ArgumentNullException("infLocalCarrega is a required property for MdfeSefazInfLotacao and cannot be null");
            }
            this.infLocalCarrega = infLocalCarrega;
            // to ensure "infLocalDescarrega" is required (not null)
            if (infLocalDescarrega == null)
            {
                throw new ArgumentNullException("infLocalDescarrega is a required property for MdfeSefazInfLotacao and cannot be null");
            }
            this.infLocalDescarrega = infLocalDescarrega;
        }

        /// <summary>
        /// Gets or Sets infLocalCarrega
        /// </summary>
        [DataMember(Name = "infLocalCarrega", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazInfLocalCarrega infLocalCarrega { get; set; }

        /// <summary>
        /// Gets or Sets infLocalDescarrega
        /// </summary>
        [DataMember(Name = "infLocalDescarrega", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazInfLocalDescarrega infLocalDescarrega { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfLotacao {\n");
            sb.Append("  infLocalCarrega: ").Append(infLocalCarrega).Append("\n");
            sb.Append("  infLocalDescarrega: ").Append(infLocalDescarrega).Append("\n");
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
            return this.Equals(input as MdfeSefazInfLotacao);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfLotacao instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfLotacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfLotacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infLocalCarrega == input.infLocalCarrega ||
                    (this.infLocalCarrega != null &&
                    this.infLocalCarrega.Equals(input.infLocalCarrega))
                ) && 
                (
                    this.infLocalDescarrega == input.infLocalDescarrega ||
                    (this.infLocalDescarrega != null &&
                    this.infLocalDescarrega.Equals(input.infLocalDescarrega))
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
                if (this.infLocalCarrega != null)
                {
                    hashCode = (hashCode * 59) + this.infLocalCarrega.GetHashCode();
                }
                if (this.infLocalDescarrega != null)
                {
                    hashCode = (hashCode * 59) + this.infLocalDescarrega.GetHashCode();
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
