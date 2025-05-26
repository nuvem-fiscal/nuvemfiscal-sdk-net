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
    /// Informações relativas aos Impostos.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfCte_ImpSimp")]
    public partial class CteSimpSefazInfCteImpSimp : IEquatable<CteSimpSefazInfCteImpSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCteImpSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazInfCteImpSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCteImpSimp" /> class.
        /// </summary>
        /// <param name="iCMS">iCMS (required).</param>
        /// <param name="vTotTrib">Valor Total dos Tributos..</param>
        /// <param name="infAdFisco">Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc..</param>
        /// <param name="iCMSUFFim">iCMSUFFim.</param>
        public CteSimpSefazInfCteImpSimp(CteSimpSefazImpSimp iCMS = default(CteSimpSefazImpSimp), decimal? vTotTrib = default(decimal?), string infAdFisco = default(string), CteSimpSefazICMSUFFimSimp iCMSUFFim = default(CteSimpSefazICMSUFFimSimp))
        {
            // to ensure "iCMS" is required (not null)
            if (iCMS == null)
            {
                throw new ArgumentNullException("iCMS is a required property for CteSimpSefazInfCteImpSimp and cannot be null");
            }
            this.ICMS = iCMS;
            this.vTotTrib = vTotTrib;
            this.infAdFisco = infAdFisco;
            this.ICMSUFFim = iCMSUFFim;
        }

        /// <summary>
        /// Gets or Sets ICMS
        /// </summary>
        [DataMember(Name = "ICMS", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazImpSimp ICMS { get; set; }

        /// <summary>
        /// Valor Total dos Tributos.
        /// </summary>
        /// <value>Valor Total dos Tributos.</value>
        [DataMember(Name = "vTotTrib", EmitDefaultValue = true)]
        public decimal? vTotTrib { get; set; }

        /// <summary>
        /// Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc.
        /// </summary>
        /// <value>Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc.</value>
        [DataMember(Name = "infAdFisco", EmitDefaultValue = true)]
        public string infAdFisco { get; set; }

        /// <summary>
        /// Gets or Sets ICMSUFFim
        /// </summary>
        [DataMember(Name = "ICMSUFFim", EmitDefaultValue = false)]
        public CteSimpSefazICMSUFFimSimp ICMSUFFim { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfCteImpSimp {\n");
            sb.Append("  ICMS: ").Append(ICMS).Append("\n");
            sb.Append("  vTotTrib: ").Append(vTotTrib).Append("\n");
            sb.Append("  infAdFisco: ").Append(infAdFisco).Append("\n");
            sb.Append("  ICMSUFFim: ").Append(ICMSUFFim).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfCteImpSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfCteImpSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfCteImpSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfCteImpSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ICMS == input.ICMS ||
                    (this.ICMS != null &&
                    this.ICMS.Equals(input.ICMS))
                ) && 
                (
                    this.vTotTrib == input.vTotTrib ||
                    (this.vTotTrib != null &&
                    this.vTotTrib.Equals(input.vTotTrib))
                ) && 
                (
                    this.infAdFisco == input.infAdFisco ||
                    (this.infAdFisco != null &&
                    this.infAdFisco.Equals(input.infAdFisco))
                ) && 
                (
                    this.ICMSUFFim == input.ICMSUFFim ||
                    (this.ICMSUFFim != null &&
                    this.ICMSUFFim.Equals(input.ICMSUFFim))
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
                if (this.ICMS != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS.GetHashCode();
                }
                if (this.vTotTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTrib.GetHashCode();
                }
                if (this.infAdFisco != null)
                {
                    hashCode = (hashCode * 59) + this.infAdFisco.GetHashCode();
                }
                if (this.ICMSUFFim != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSUFFim.GetHashCode();
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
            // vTotTrib (decimal?) minimum
            if (this.vTotTrib < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTotTrib, must be a value greater than or equal to 0.", new [] { "vTotTrib" });
            }

            // infAdFisco (string) maxLength
            if (this.infAdFisco != null && this.infAdFisco.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for infAdFisco, length must be less than 2000.", new [] { "infAdFisco" });
            }

            // infAdFisco (string) minLength
            if (this.infAdFisco != null && this.infAdFisco.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infAdFisco, length must be greater than 1.", new [] { "infAdFisco" });
            }

            yield break;
        }
    }

}
