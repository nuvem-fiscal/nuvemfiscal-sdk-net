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
    /// Totais referentes ao ICMS.
    /// </summary>
    [DataContract(Name = "NfcomSefazICMSTot")]
    public partial class NfcomSefazICMSTot : IEquatable<NfcomSefazICMSTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazICMSTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazICMSTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazICMSTot" /> class.
        /// </summary>
        /// <param name="vBC">BC do ICMS. (required).</param>
        /// <param name="vICMS">Valor Total do ICMS. (required).</param>
        /// <param name="vICMSDeson">Valor Total do ICMS desonerado. (required).</param>
        /// <param name="vFCP">Valor Total do FCP (Fundo de Combate à Pobreza). (required).</param>
        public NfcomSefazICMSTot(decimal? vBC = default(decimal?), decimal? vICMS = default(decimal?), decimal? vICMSDeson = default(decimal?), decimal? vFCP = default(decimal?))
        {
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfcomSefazICMSTot and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "vICMS" is required (not null)
            if (vICMS == null)
            {
                throw new ArgumentNullException("vICMS is a required property for NfcomSefazICMSTot and cannot be null");
            }
            this.vICMS = vICMS;
            // to ensure "vICMSDeson" is required (not null)
            if (vICMSDeson == null)
            {
                throw new ArgumentNullException("vICMSDeson is a required property for NfcomSefazICMSTot and cannot be null");
            }
            this.vICMSDeson = vICMSDeson;
            // to ensure "vFCP" is required (not null)
            if (vFCP == null)
            {
                throw new ArgumentNullException("vFCP is a required property for NfcomSefazICMSTot and cannot be null");
            }
            this.vFCP = vFCP;
        }

        /// <summary>
        /// BC do ICMS.
        /// </summary>
        /// <value>BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Valor Total do ICMS.
        /// </summary>
        /// <value>Valor Total do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMS { get; set; }

        /// <summary>
        /// Valor Total do ICMS desonerado.
        /// </summary>
        /// <value>Valor Total do ICMS desonerado.</value>
        [DataMember(Name = "vICMSDeson", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSDeson { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza).
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza).</value>
        [DataMember(Name = "vFCP", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFCP { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazICMSTot {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  vFCP: ").Append(vFCP).Append("\n");
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
            return this.Equals(input as NfcomSefazICMSTot);
        }

        /// <summary>
        /// Returns true if NfcomSefazICMSTot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazICMSTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazICMSTot input)
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
                    this.vICMS == input.vICMS ||
                    (this.vICMS != null &&
                    this.vICMS.Equals(input.vICMS))
                ) && 
                (
                    this.vICMSDeson == input.vICMSDeson ||
                    (this.vICMSDeson != null &&
                    this.vICMSDeson.Equals(input.vICMSDeson))
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    (this.vFCP != null &&
                    this.vFCP.Equals(input.vFCP))
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
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                }
                if (this.vICMSDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                }
                if (this.vFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
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
