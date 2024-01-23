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
    /// Dados dos detalhes da NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazDet")]
    public partial class NfeSefazDet : IEquatable<NfeSefazDet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDet" /> class.
        /// </summary>
        /// <param name="nItem">Número do item do NF. (required).</param>
        /// <param name="prod">prod (required).</param>
        /// <param name="imposto">imposto (required).</param>
        /// <param name="impostoDevol">impostoDevol.</param>
        /// <param name="infAdProd">Informações adicionais do produto (norma referenciada, informações complementares, etc)..</param>
        /// <param name="obsItem">obsItem.</param>
        public NfeSefazDet(int? nItem = default(int?), NfeSefazProd prod = default(NfeSefazProd), NfeSefazImposto imposto = default(NfeSefazImposto), NfeSefazImpostoDevol impostoDevol = default(NfeSefazImpostoDevol), string infAdProd = default(string), NfeSefazObsItem obsItem = default(NfeSefazObsItem))
        {
            // to ensure "nItem" is required (not null)
            if (nItem == null)
            {
                throw new ArgumentNullException("nItem is a required property for NfeSefazDet and cannot be null");
            }
            this.nItem = nItem;
            // to ensure "prod" is required (not null)
            if (prod == null)
            {
                throw new ArgumentNullException("prod is a required property for NfeSefazDet and cannot be null");
            }
            this.prod = prod;
            // to ensure "imposto" is required (not null)
            if (imposto == null)
            {
                throw new ArgumentNullException("imposto is a required property for NfeSefazDet and cannot be null");
            }
            this.imposto = imposto;
            this.impostoDevol = impostoDevol;
            this.infAdProd = infAdProd;
            this.obsItem = obsItem;
        }

        /// <summary>
        /// Número do item do NF.
        /// </summary>
        /// <value>Número do item do NF.</value>
        [DataMember(Name = "nItem", IsRequired = true, EmitDefaultValue = true)]
        public int? nItem { get; set; }

        /// <summary>
        /// Gets or Sets prod
        /// </summary>
        [DataMember(Name = "prod", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazProd prod { get; set; }

        /// <summary>
        /// Gets or Sets imposto
        /// </summary>
        [DataMember(Name = "imposto", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazImposto imposto { get; set; }

        /// <summary>
        /// Gets or Sets impostoDevol
        /// </summary>
        [DataMember(Name = "impostoDevol", EmitDefaultValue = false)]
        public NfeSefazImpostoDevol impostoDevol { get; set; }

        /// <summary>
        /// Informações adicionais do produto (norma referenciada, informações complementares, etc).
        /// </summary>
        /// <value>Informações adicionais do produto (norma referenciada, informações complementares, etc).</value>
        [DataMember(Name = "infAdProd", EmitDefaultValue = true)]
        public string infAdProd { get; set; }

        /// <summary>
        /// Gets or Sets obsItem
        /// </summary>
        [DataMember(Name = "obsItem", EmitDefaultValue = false)]
        public NfeSefazObsItem obsItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDet {\n");
            sb.Append("  nItem: ").Append(nItem).Append("\n");
            sb.Append("  prod: ").Append(prod).Append("\n");
            sb.Append("  imposto: ").Append(imposto).Append("\n");
            sb.Append("  impostoDevol: ").Append(impostoDevol).Append("\n");
            sb.Append("  infAdProd: ").Append(infAdProd).Append("\n");
            sb.Append("  obsItem: ").Append(obsItem).Append("\n");
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
            return this.Equals(input as NfeSefazDet);
        }

        /// <summary>
        /// Returns true if NfeSefazDet instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nItem == input.nItem ||
                    (this.nItem != null &&
                    this.nItem.Equals(input.nItem))
                ) && 
                (
                    this.prod == input.prod ||
                    (this.prod != null &&
                    this.prod.Equals(input.prod))
                ) && 
                (
                    this.imposto == input.imposto ||
                    (this.imposto != null &&
                    this.imposto.Equals(input.imposto))
                ) && 
                (
                    this.impostoDevol == input.impostoDevol ||
                    (this.impostoDevol != null &&
                    this.impostoDevol.Equals(input.impostoDevol))
                ) && 
                (
                    this.infAdProd == input.infAdProd ||
                    (this.infAdProd != null &&
                    this.infAdProd.Equals(input.infAdProd))
                ) && 
                (
                    this.obsItem == input.obsItem ||
                    (this.obsItem != null &&
                    this.obsItem.Equals(input.obsItem))
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
                if (this.nItem != null)
                {
                    hashCode = (hashCode * 59) + this.nItem.GetHashCode();
                }
                if (this.prod != null)
                {
                    hashCode = (hashCode * 59) + this.prod.GetHashCode();
                }
                if (this.imposto != null)
                {
                    hashCode = (hashCode * 59) + this.imposto.GetHashCode();
                }
                if (this.impostoDevol != null)
                {
                    hashCode = (hashCode * 59) + this.impostoDevol.GetHashCode();
                }
                if (this.infAdProd != null)
                {
                    hashCode = (hashCode * 59) + this.infAdProd.GetHashCode();
                }
                if (this.obsItem != null)
                {
                    hashCode = (hashCode * 59) + this.obsItem.GetHashCode();
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
            // nItem (int?) maximum
            if (this.nItem > (int?)990)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nItem, must be a value less than or equal to 990.", new [] { "nItem" });
            }

            // nItem (int?) minimum
            if (this.nItem < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nItem, must be a value greater than or equal to 1.", new [] { "nItem" });
            }

            // infAdProd (string) maxLength
            if (this.infAdProd != null && this.infAdProd.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for infAdProd, length must be less than 500.", new [] { "infAdProd" });
            }

            // infAdProd (string) minLength
            if (this.infAdProd != null && this.infAdProd.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for infAdProd, length must be greater than 1.", new [] { "infAdProd" });
            }

            yield break;
        }
    }

}
