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
    /// Total da retenção de tributos federais.
    /// </summary>
    [DataContract(Name = "NfcomSefazVRetTribTot")]
    public partial class NfcomSefazVRetTribTot : IEquatable<NfcomSefazVRetTribTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazVRetTribTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazVRetTribTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazVRetTribTot" /> class.
        /// </summary>
        /// <param name="vRetPIS">Valor do PIS retido. (required).</param>
        /// <param name="vRetCofins">Valor do COFNS retido. (required).</param>
        /// <param name="vRetCSLL">Valor da CSLL retida. (required).</param>
        /// <param name="vIRRF">Valor do IRRF retido. (required).</param>
        public NfcomSefazVRetTribTot(decimal? vRetPIS = default(decimal?), decimal? vRetCofins = default(decimal?), decimal? vRetCSLL = default(decimal?), decimal? vIRRF = default(decimal?))
        {
            // to ensure "vRetPIS" is required (not null)
            if (vRetPIS == null)
            {
                throw new ArgumentNullException("vRetPIS is a required property for NfcomSefazVRetTribTot and cannot be null");
            }
            this.vRetPIS = vRetPIS;
            // to ensure "vRetCofins" is required (not null)
            if (vRetCofins == null)
            {
                throw new ArgumentNullException("vRetCofins is a required property for NfcomSefazVRetTribTot and cannot be null");
            }
            this.vRetCofins = vRetCofins;
            // to ensure "vRetCSLL" is required (not null)
            if (vRetCSLL == null)
            {
                throw new ArgumentNullException("vRetCSLL is a required property for NfcomSefazVRetTribTot and cannot be null");
            }
            this.vRetCSLL = vRetCSLL;
            // to ensure "vIRRF" is required (not null)
            if (vIRRF == null)
            {
                throw new ArgumentNullException("vIRRF is a required property for NfcomSefazVRetTribTot and cannot be null");
            }
            this.vIRRF = vIRRF;
        }

        /// <summary>
        /// Valor do PIS retido.
        /// </summary>
        /// <value>Valor do PIS retido.</value>
        [DataMember(Name = "vRetPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vRetPIS { get; set; }

        /// <summary>
        /// Valor do COFNS retido.
        /// </summary>
        /// <value>Valor do COFNS retido.</value>
        [DataMember(Name = "vRetCofins", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vRetCofins { get; set; }

        /// <summary>
        /// Valor da CSLL retida.
        /// </summary>
        /// <value>Valor da CSLL retida.</value>
        [DataMember(Name = "vRetCSLL", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vRetCSLL { get; set; }

        /// <summary>
        /// Valor do IRRF retido.
        /// </summary>
        /// <value>Valor do IRRF retido.</value>
        [DataMember(Name = "vIRRF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIRRF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazVRetTribTot {\n");
            sb.Append("  vRetPIS: ").Append(vRetPIS).Append("\n");
            sb.Append("  vRetCofins: ").Append(vRetCofins).Append("\n");
            sb.Append("  vRetCSLL: ").Append(vRetCSLL).Append("\n");
            sb.Append("  vIRRF: ").Append(vIRRF).Append("\n");
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
            return this.Equals(input as NfcomSefazVRetTribTot);
        }

        /// <summary>
        /// Returns true if NfcomSefazVRetTribTot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazVRetTribTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazVRetTribTot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vRetPIS == input.vRetPIS ||
                    (this.vRetPIS != null &&
                    this.vRetPIS.Equals(input.vRetPIS))
                ) && 
                (
                    this.vRetCofins == input.vRetCofins ||
                    (this.vRetCofins != null &&
                    this.vRetCofins.Equals(input.vRetCofins))
                ) && 
                (
                    this.vRetCSLL == input.vRetCSLL ||
                    (this.vRetCSLL != null &&
                    this.vRetCSLL.Equals(input.vRetCSLL))
                ) && 
                (
                    this.vIRRF == input.vIRRF ||
                    (this.vIRRF != null &&
                    this.vIRRF.Equals(input.vIRRF))
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
                if (this.vRetPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vRetPIS.GetHashCode();
                }
                if (this.vRetCofins != null)
                {
                    hashCode = (hashCode * 59) + this.vRetCofins.GetHashCode();
                }
                if (this.vRetCSLL != null)
                {
                    hashCode = (hashCode * 59) + this.vRetCSLL.GetHashCode();
                }
                if (this.vIRRF != null)
                {
                    hashCode = (hashCode * 59) + this.vIRRF.GetHashCode();
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
