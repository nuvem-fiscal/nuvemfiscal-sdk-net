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
    /// Dados do Produto ou Serviço.
    /// </summary>
    [DataContract(Name = "DceSefazProd")]
    public partial class DceSefazProd : IEquatable<DceSefazProd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazProd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazProd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazProd" /> class.
        /// </summary>
        /// <param name="xProd">Descrição do produto, bem ou mercadoria. (required).</param>
        /// <param name="nCM">Código NCM.  Capítulo do Código NCM com 2 dígitos ou NCM completo. (required).</param>
        /// <param name="qCom">Quantidade. (required).</param>
        /// <param name="vUnCom">Valor unitário do item. (required).</param>
        /// <param name="vProd">Valor total brutp do item. (required).</param>
        public DceSefazProd(string xProd = default(string), string nCM = default(string), decimal? qCom = default(decimal?), decimal? vUnCom = default(decimal?), decimal? vProd = default(decimal?))
        {
            // to ensure "xProd" is required (not null)
            if (xProd == null)
            {
                throw new ArgumentNullException("xProd is a required property for DceSefazProd and cannot be null");
            }
            this.xProd = xProd;
            // to ensure "nCM" is required (not null)
            if (nCM == null)
            {
                throw new ArgumentNullException("nCM is a required property for DceSefazProd and cannot be null");
            }
            this.NCM = nCM;
            // to ensure "qCom" is required (not null)
            if (qCom == null)
            {
                throw new ArgumentNullException("qCom is a required property for DceSefazProd and cannot be null");
            }
            this.qCom = qCom;
            // to ensure "vUnCom" is required (not null)
            if (vUnCom == null)
            {
                throw new ArgumentNullException("vUnCom is a required property for DceSefazProd and cannot be null");
            }
            this.vUnCom = vUnCom;
            // to ensure "vProd" is required (not null)
            if (vProd == null)
            {
                throw new ArgumentNullException("vProd is a required property for DceSefazProd and cannot be null");
            }
            this.vProd = vProd;
        }

        /// <summary>
        /// Descrição do produto, bem ou mercadoria.
        /// </summary>
        /// <value>Descrição do produto, bem ou mercadoria.</value>
        [DataMember(Name = "xProd", IsRequired = true, EmitDefaultValue = true)]
        public string xProd { get; set; }

        /// <summary>
        /// Código NCM.  Capítulo do Código NCM com 2 dígitos ou NCM completo.
        /// </summary>
        /// <value>Código NCM.  Capítulo do Código NCM com 2 dígitos ou NCM completo.</value>
        [DataMember(Name = "NCM", IsRequired = true, EmitDefaultValue = true)]
        public string NCM { get; set; }

        /// <summary>
        /// Quantidade.
        /// </summary>
        /// <value>Quantidade.</value>
        [DataMember(Name = "qCom", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qCom { get; set; }

        /// <summary>
        /// Valor unitário do item.
        /// </summary>
        /// <value>Valor unitário do item.</value>
        [DataMember(Name = "vUnCom", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vUnCom { get; set; }

        /// <summary>
        /// Valor total brutp do item.
        /// </summary>
        /// <value>Valor total brutp do item.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vProd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazProd {\n");
            sb.Append("  xProd: ").Append(xProd).Append("\n");
            sb.Append("  NCM: ").Append(NCM).Append("\n");
            sb.Append("  qCom: ").Append(qCom).Append("\n");
            sb.Append("  vUnCom: ").Append(vUnCom).Append("\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
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
            return this.Equals(input as DceSefazProd);
        }

        /// <summary>
        /// Returns true if DceSefazProd instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazProd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazProd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xProd == input.xProd ||
                    (this.xProd != null &&
                    this.xProd.Equals(input.xProd))
                ) && 
                (
                    this.NCM == input.NCM ||
                    (this.NCM != null &&
                    this.NCM.Equals(input.NCM))
                ) && 
                (
                    this.qCom == input.qCom ||
                    (this.qCom != null &&
                    this.qCom.Equals(input.qCom))
                ) && 
                (
                    this.vUnCom == input.vUnCom ||
                    (this.vUnCom != null &&
                    this.vUnCom.Equals(input.vUnCom))
                ) && 
                (
                    this.vProd == input.vProd ||
                    (this.vProd != null &&
                    this.vProd.Equals(input.vProd))
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
                if (this.xProd != null)
                {
                    hashCode = (hashCode * 59) + this.xProd.GetHashCode();
                }
                if (this.NCM != null)
                {
                    hashCode = (hashCode * 59) + this.NCM.GetHashCode();
                }
                if (this.qCom != null)
                {
                    hashCode = (hashCode * 59) + this.qCom.GetHashCode();
                }
                if (this.vUnCom != null)
                {
                    hashCode = (hashCode * 59) + this.vUnCom.GetHashCode();
                }
                if (this.vProd != null)
                {
                    hashCode = (hashCode * 59) + this.vProd.GetHashCode();
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
            // xProd (string) maxLength
            if (this.xProd != null && this.xProd.Length > 120)
            {
                yield return new ValidationResult("Invalid value for xProd, length must be less than 120.", new [] { "xProd" });
            }

            // xProd (string) minLength
            if (this.xProd != null && this.xProd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xProd, length must be greater than 1.", new [] { "xProd" });
            }

            // qCom (decimal?) minimum
            if (this.qCom < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qCom, must be a value greater than or equal to 0.", new [] { "qCom" });
            }

            yield break;
        }
    }

}
