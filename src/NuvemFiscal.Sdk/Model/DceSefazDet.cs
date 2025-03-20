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
    /// Detalhamento de itens da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazDet")]
    public partial class DceSefazDet : IEquatable<DceSefazDet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazDet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazDet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazDet" /> class.
        /// </summary>
        /// <param name="nItem">Número do item da DCe. (required).</param>
        /// <param name="prod">prod (required).</param>
        /// <param name="infAdProd">Informações adicionais do item..</param>
        public DceSefazDet(int? nItem = default(int?), DceSefazProd prod = default(DceSefazProd), string infAdProd = default(string))
        {
            // to ensure "nItem" is required (not null)
            if (nItem == null)
            {
                throw new ArgumentNullException("nItem is a required property for DceSefazDet and cannot be null");
            }
            this.nItem = nItem;
            // to ensure "prod" is required (not null)
            if (prod == null)
            {
                throw new ArgumentNullException("prod is a required property for DceSefazDet and cannot be null");
            }
            this.prod = prod;
            this.infAdProd = infAdProd;
        }

        /// <summary>
        /// Número do item da DCe.
        /// </summary>
        /// <value>Número do item da DCe.</value>
        [DataMember(Name = "nItem", IsRequired = true, EmitDefaultValue = true)]
        public int? nItem { get; set; }

        /// <summary>
        /// Gets or Sets prod
        /// </summary>
        [DataMember(Name = "prod", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazProd prod { get; set; }

        /// <summary>
        /// Informações adicionais do item.
        /// </summary>
        /// <value>Informações adicionais do item.</value>
        [DataMember(Name = "infAdProd", EmitDefaultValue = true)]
        public string infAdProd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazDet {\n");
            sb.Append("  nItem: ").Append(nItem).Append("\n");
            sb.Append("  prod: ").Append(prod).Append("\n");
            sb.Append("  infAdProd: ").Append(infAdProd).Append("\n");
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
            return this.Equals(input as DceSefazDet);
        }

        /// <summary>
        /// Returns true if DceSefazDet instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazDet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazDet input)
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
                    this.infAdProd == input.infAdProd ||
                    (this.infAdProd != null &&
                    this.infAdProd.Equals(input.infAdProd))
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
                if (this.infAdProd != null)
                {
                    hashCode = (hashCode * 59) + this.infAdProd.GetHashCode();
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
            // nItem (int?) maximum
            if (this.nItem > (int?)9999)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value less than or equal to 9999.", new [] { "nItem" });
            }

            // nItem (int?) minimum
            if (this.nItem < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value greater than or equal to 1.", new [] { "nItem" });
            }

            // infAdProd (string) maxLength
            if (this.infAdProd != null && this.infAdProd.Length > 500)
            {
                yield return new ValidationResult("Invalid value for infAdProd, length must be less than 500.", new [] { "infAdProd" });
            }

            // infAdProd (string) minLength
            if (this.infAdProd != null && this.infAdProd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infAdProd, length must be greater than 1.", new [] { "infAdProd" });
            }

            yield break;
        }
    }

}
