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
    /// Informações Adicionais.
    /// </summary>
    [DataContract(Name = "DceSefazInfAdic")]
    public partial class DceSefazInfAdic : IEquatable<DceSefazInfAdic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazInfAdic" /> class.
        /// </summary>
        /// <param name="infAdFisco">Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc..</param>
        /// <param name="infCpl">Informações complementares de interesse do Emitente..</param>
        /// <param name="infAdMarketplace">Informações Adicionais do MarketPlace..</param>
        /// <param name="infAdECT">Informações Adicionais do Correio..</param>
        /// <param name="obsEmit">obsEmit.</param>
        /// <param name="obsFisco">obsFisco.</param>
        /// <param name="obsMarketplace">obsMarketplace.</param>
        /// <param name="obsECT">obsECT.</param>
        public DceSefazInfAdic(string infAdFisco = default(string), string infCpl = default(string), string infAdMarketplace = default(string), string infAdECT = default(string), List<DceSefazObsEmit> obsEmit = default(List<DceSefazObsEmit>), List<DceSefazObsFisco> obsFisco = default(List<DceSefazObsFisco>), List<DceSefazObsMarketplace> obsMarketplace = default(List<DceSefazObsMarketplace>), List<DceSefazObsECT> obsECT = default(List<DceSefazObsECT>))
        {
            this.infAdFisco = infAdFisco;
            this.infCpl = infCpl;
            this.infAdMarketplace = infAdMarketplace;
            this.infAdECT = infAdECT;
            this.obsEmit = obsEmit;
            this.obsFisco = obsFisco;
            this.obsMarketplace = obsMarketplace;
            this.obsECT = obsECT;
        }

        /// <summary>
        /// Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc.
        /// </summary>
        /// <value>Informações adicionais de interesse do Fisco.  Norma referenciada, informações complementares, etc.</value>
        [DataMember(Name = "infAdFisco", EmitDefaultValue = true)]
        public string infAdFisco { get; set; }

        /// <summary>
        /// Informações complementares de interesse do Emitente.
        /// </summary>
        /// <value>Informações complementares de interesse do Emitente.</value>
        [DataMember(Name = "infCpl", EmitDefaultValue = true)]
        public string infCpl { get; set; }

        /// <summary>
        /// Informações Adicionais do MarketPlace.
        /// </summary>
        /// <value>Informações Adicionais do MarketPlace.</value>
        [DataMember(Name = "infAdMarketplace", EmitDefaultValue = true)]
        public string infAdMarketplace { get; set; }

        /// <summary>
        /// Informações Adicionais do Correio.
        /// </summary>
        /// <value>Informações Adicionais do Correio.</value>
        [DataMember(Name = "infAdECT", EmitDefaultValue = true)]
        public string infAdECT { get; set; }

        /// <summary>
        /// Gets or Sets obsEmit
        /// </summary>
        [DataMember(Name = "obsEmit", EmitDefaultValue = false)]
        public List<DceSefazObsEmit> obsEmit { get; set; }

        /// <summary>
        /// Gets or Sets obsFisco
        /// </summary>
        [DataMember(Name = "obsFisco", EmitDefaultValue = false)]
        public List<DceSefazObsFisco> obsFisco { get; set; }

        /// <summary>
        /// Gets or Sets obsMarketplace
        /// </summary>
        [DataMember(Name = "obsMarketplace", EmitDefaultValue = false)]
        public List<DceSefazObsMarketplace> obsMarketplace { get; set; }

        /// <summary>
        /// Gets or Sets obsECT
        /// </summary>
        [DataMember(Name = "obsECT", EmitDefaultValue = false)]
        public List<DceSefazObsECT> obsECT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazInfAdic {\n");
            sb.Append("  infAdFisco: ").Append(infAdFisco).Append("\n");
            sb.Append("  infCpl: ").Append(infCpl).Append("\n");
            sb.Append("  infAdMarketplace: ").Append(infAdMarketplace).Append("\n");
            sb.Append("  infAdECT: ").Append(infAdECT).Append("\n");
            sb.Append("  obsEmit: ").Append(obsEmit).Append("\n");
            sb.Append("  obsFisco: ").Append(obsFisco).Append("\n");
            sb.Append("  obsMarketplace: ").Append(obsMarketplace).Append("\n");
            sb.Append("  obsECT: ").Append(obsECT).Append("\n");
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
            return this.Equals(input as DceSefazInfAdic);
        }

        /// <summary>
        /// Returns true if DceSefazInfAdic instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazInfAdic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazInfAdic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infAdFisco == input.infAdFisco ||
                    (this.infAdFisco != null &&
                    this.infAdFisco.Equals(input.infAdFisco))
                ) && 
                (
                    this.infCpl == input.infCpl ||
                    (this.infCpl != null &&
                    this.infCpl.Equals(input.infCpl))
                ) && 
                (
                    this.infAdMarketplace == input.infAdMarketplace ||
                    (this.infAdMarketplace != null &&
                    this.infAdMarketplace.Equals(input.infAdMarketplace))
                ) && 
                (
                    this.infAdECT == input.infAdECT ||
                    (this.infAdECT != null &&
                    this.infAdECT.Equals(input.infAdECT))
                ) && 
                (
                    this.obsEmit == input.obsEmit ||
                    this.obsEmit != null &&
                    input.obsEmit != null &&
                    this.obsEmit.SequenceEqual(input.obsEmit)
                ) && 
                (
                    this.obsFisco == input.obsFisco ||
                    this.obsFisco != null &&
                    input.obsFisco != null &&
                    this.obsFisco.SequenceEqual(input.obsFisco)
                ) && 
                (
                    this.obsMarketplace == input.obsMarketplace ||
                    this.obsMarketplace != null &&
                    input.obsMarketplace != null &&
                    this.obsMarketplace.SequenceEqual(input.obsMarketplace)
                ) && 
                (
                    this.obsECT == input.obsECT ||
                    this.obsECT != null &&
                    input.obsECT != null &&
                    this.obsECT.SequenceEqual(input.obsECT)
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
                if (this.infAdFisco != null)
                {
                    hashCode = (hashCode * 59) + this.infAdFisco.GetHashCode();
                }
                if (this.infCpl != null)
                {
                    hashCode = (hashCode * 59) + this.infCpl.GetHashCode();
                }
                if (this.infAdMarketplace != null)
                {
                    hashCode = (hashCode * 59) + this.infAdMarketplace.GetHashCode();
                }
                if (this.infAdECT != null)
                {
                    hashCode = (hashCode * 59) + this.infAdECT.GetHashCode();
                }
                if (this.obsEmit != null)
                {
                    hashCode = (hashCode * 59) + this.obsEmit.GetHashCode();
                }
                if (this.obsFisco != null)
                {
                    hashCode = (hashCode * 59) + this.obsFisco.GetHashCode();
                }
                if (this.obsMarketplace != null)
                {
                    hashCode = (hashCode * 59) + this.obsMarketplace.GetHashCode();
                }
                if (this.obsECT != null)
                {
                    hashCode = (hashCode * 59) + this.obsECT.GetHashCode();
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

            // infCpl (string) maxLength
            if (this.infCpl != null && this.infCpl.Length > 5000)
            {
                yield return new ValidationResult("Invalid value for infCpl, length must be less than 5000.", new [] { "infCpl" });
            }

            // infCpl (string) minLength
            if (this.infCpl != null && this.infCpl.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infCpl, length must be greater than 1.", new [] { "infCpl" });
            }

            // infAdMarketplace (string) maxLength
            if (this.infAdMarketplace != null && this.infAdMarketplace.Length > 5000)
            {
                yield return new ValidationResult("Invalid value for infAdMarketplace, length must be less than 5000.", new [] { "infAdMarketplace" });
            }

            // infAdMarketplace (string) minLength
            if (this.infAdMarketplace != null && this.infAdMarketplace.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infAdMarketplace, length must be greater than 1.", new [] { "infAdMarketplace" });
            }

            // infAdECT (string) maxLength
            if (this.infAdECT != null && this.infAdECT.Length > 5000)
            {
                yield return new ValidationResult("Invalid value for infAdECT, length must be less than 5000.", new [] { "infAdECT" });
            }

            // infAdECT (string) minLength
            if (this.infAdECT != null && this.infAdECT.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infAdECT, length must be greater than 1.", new [] { "infAdECT" });
            }

            yield break;
        }
    }

}
