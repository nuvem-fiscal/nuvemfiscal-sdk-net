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
    /// NfeSefazDet
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
        /// <param name="nItem">nItem.</param>
        /// <param name="prod">prod (required).</param>
        /// <param name="imposto">imposto (required).</param>
        /// <param name="impostoDevol">impostoDevol.</param>
        /// <param name="infAdProd">Informações adicionais do produto (norma referenciada, informações complementares, etc)..</param>
        public NfeSefazDet(int nItem = default(int), NfeSefazProd prod = default(NfeSefazProd), NfeSefazImposto imposto = default(NfeSefazImposto), NfeSefazImpostoDevol impostoDevol = default(NfeSefazImpostoDevol), string infAdProd = default(string))
        {
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
            this.nItem = nItem;
            this.impostoDevol = impostoDevol;
            this.infAdProd = infAdProd;
        }

        /// <summary>
        /// Gets or Sets nItem
        /// </summary>
        [DataMember(Name = "nItem", EmitDefaultValue = false)]
        public int nItem { get; set; }

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
        [DataMember(Name = "infAdProd", EmitDefaultValue = false)]
        public string infAdProd { get; set; }

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
                    this.nItem.Equals(input.nItem)
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
                hashCode = (hashCode * 59) + this.nItem.GetHashCode();
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
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
