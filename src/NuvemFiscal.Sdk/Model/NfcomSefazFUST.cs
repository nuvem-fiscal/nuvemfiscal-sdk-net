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
    /// Dados do FUST.
    /// </summary>
    [DataContract(Name = "NfcomSefazFUST")]
    public partial class NfcomSefazFUST : IEquatable<NfcomSefazFUST>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazFUST" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazFUST() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazFUST" /> class.
        /// </summary>
        /// <param name="vBC">Valor da BC do FUST. (required).</param>
        /// <param name="pFUST">Alíquota do FUST (em percentual). (required).</param>
        /// <param name="vFUST">Valor do FUST. (required).</param>
        public NfcomSefazFUST(decimal? vBC = default(decimal?), decimal? pFUST = default(decimal?), decimal? vFUST = default(decimal?))
        {
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfcomSefazFUST and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pFUST" is required (not null)
            if (pFUST == null)
            {
                throw new ArgumentNullException("pFUST is a required property for NfcomSefazFUST and cannot be null");
            }
            this.pFUST = pFUST;
            // to ensure "vFUST" is required (not null)
            if (vFUST == null)
            {
                throw new ArgumentNullException("vFUST is a required property for NfcomSefazFUST and cannot be null");
            }
            this.vFUST = vFUST;
        }

        /// <summary>
        /// Valor da BC do FUST.
        /// </summary>
        /// <value>Valor da BC do FUST.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do FUST (em percentual).
        /// </summary>
        /// <value>Alíquota do FUST (em percentual).</value>
        [DataMember(Name = "pFUST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pFUST { get; set; }

        /// <summary>
        /// Valor do FUST.
        /// </summary>
        /// <value>Valor do FUST.</value>
        [DataMember(Name = "vFUST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFUST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazFUST {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pFUST: ").Append(pFUST).Append("\n");
            sb.Append("  vFUST: ").Append(vFUST).Append("\n");
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
            return this.Equals(input as NfcomSefazFUST);
        }

        /// <summary>
        /// Returns true if NfcomSefazFUST instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazFUST to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazFUST input)
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
                    this.pFUST == input.pFUST ||
                    (this.pFUST != null &&
                    this.pFUST.Equals(input.pFUST))
                ) && 
                (
                    this.vFUST == input.vFUST ||
                    (this.vFUST != null &&
                    this.vFUST.Equals(input.vFUST))
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
                if (this.pFUST != null)
                {
                    hashCode = (hashCode * 59) + this.pFUST.GetHashCode();
                }
                if (this.vFUST != null)
                {
                    hashCode = (hashCode * 59) + this.vFUST.GetHashCode();
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
