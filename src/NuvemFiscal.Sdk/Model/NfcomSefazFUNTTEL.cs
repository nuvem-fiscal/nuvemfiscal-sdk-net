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
    /// Dados do FUNTTEL.
    /// </summary>
    [DataContract(Name = "NfcomSefazFUNTTEL")]
    public partial class NfcomSefazFUNTTEL : IEquatable<NfcomSefazFUNTTEL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazFUNTTEL" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazFUNTTEL() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazFUNTTEL" /> class.
        /// </summary>
        /// <param name="vBC">Valor da BC do FUNTTEL. (required).</param>
        /// <param name="pFUNTTEL">Alíquota do FUNTTEL (em percentual). (required).</param>
        /// <param name="vFUNTTEL">Valor do FUNTEL. (required).</param>
        public NfcomSefazFUNTTEL(decimal? vBC = default(decimal?), decimal? pFUNTTEL = default(decimal?), decimal? vFUNTTEL = default(decimal?))
        {
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfcomSefazFUNTTEL and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pFUNTTEL" is required (not null)
            if (pFUNTTEL == null)
            {
                throw new ArgumentNullException("pFUNTTEL is a required property for NfcomSefazFUNTTEL and cannot be null");
            }
            this.pFUNTTEL = pFUNTTEL;
            // to ensure "vFUNTTEL" is required (not null)
            if (vFUNTTEL == null)
            {
                throw new ArgumentNullException("vFUNTTEL is a required property for NfcomSefazFUNTTEL and cannot be null");
            }
            this.vFUNTTEL = vFUNTTEL;
        }

        /// <summary>
        /// Valor da BC do FUNTTEL.
        /// </summary>
        /// <value>Valor da BC do FUNTTEL.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do FUNTTEL (em percentual).
        /// </summary>
        /// <value>Alíquota do FUNTTEL (em percentual).</value>
        [DataMember(Name = "pFUNTTEL", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pFUNTTEL { get; set; }

        /// <summary>
        /// Valor do FUNTEL.
        /// </summary>
        /// <value>Valor do FUNTEL.</value>
        [DataMember(Name = "vFUNTTEL", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFUNTTEL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazFUNTTEL {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pFUNTTEL: ").Append(pFUNTTEL).Append("\n");
            sb.Append("  vFUNTTEL: ").Append(vFUNTTEL).Append("\n");
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
            return this.Equals(input as NfcomSefazFUNTTEL);
        }

        /// <summary>
        /// Returns true if NfcomSefazFUNTTEL instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazFUNTTEL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazFUNTTEL input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pFUNTTEL == input.pFUNTTEL ||
                    (this.pFUNTTEL != null &&
                    this.pFUNTTEL.Equals(input.pFUNTTEL))
                ) && 
                (
                    this.vFUNTTEL == input.vFUNTTEL ||
                    (this.vFUNTTEL != null &&
                    this.vFUNTTEL.Equals(input.vFUNTTEL))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pFUNTTEL != null)
                {
                    hashCode = (hashCode * 59) + this.pFUNTTEL.GetHashCode();
                }
                if (this.vFUNTTEL != null)
                {
                    hashCode = (hashCode * 59) + this.vFUNTTEL.GetHashCode();
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
