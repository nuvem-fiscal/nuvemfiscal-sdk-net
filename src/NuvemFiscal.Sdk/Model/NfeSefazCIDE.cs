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
    /// CIDE Combustíveis.
    /// </summary>
    [DataContract(Name = "NfeSefazCIDE")]
    public partial class NfeSefazCIDE : IEquatable<NfeSefazCIDE>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCIDE" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCIDE() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCIDE" /> class.
        /// </summary>
        /// <param name="qBCProd">BC do CIDE ( Quantidade comercializada). (required).</param>
        /// <param name="vAliqProd">Alíquota do CIDE  (em reais). (required).</param>
        /// <param name="vCIDE">Valor do CIDE. (required).</param>
        public NfeSefazCIDE(decimal? qBCProd = default(decimal?), decimal? vAliqProd = default(decimal?), decimal? vCIDE = default(decimal?))
        {
            // to ensure "qBCProd" is required (not null)
            if (qBCProd == null)
            {
                throw new ArgumentNullException("qBCProd is a required property for NfeSefazCIDE and cannot be null");
            }
            this.qBCProd = qBCProd;
            // to ensure "vAliqProd" is required (not null)
            if (vAliqProd == null)
            {
                throw new ArgumentNullException("vAliqProd is a required property for NfeSefazCIDE and cannot be null");
            }
            this.vAliqProd = vAliqProd;
            // to ensure "vCIDE" is required (not null)
            if (vCIDE == null)
            {
                throw new ArgumentNullException("vCIDE is a required property for NfeSefazCIDE and cannot be null");
            }
            this.vCIDE = vCIDE;
        }

        /// <summary>
        /// BC do CIDE ( Quantidade comercializada).
        /// </summary>
        /// <value>BC do CIDE ( Quantidade comercializada).</value>
        [DataMember(Name = "qBCProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCProd { get; set; }

        /// <summary>
        /// Alíquota do CIDE  (em reais).
        /// </summary>
        /// <value>Alíquota do CIDE  (em reais).</value>
        [DataMember(Name = "vAliqProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vAliqProd { get; set; }

        /// <summary>
        /// Valor do CIDE.
        /// </summary>
        /// <value>Valor do CIDE.</value>
        [DataMember(Name = "vCIDE", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCIDE { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCIDE {\n");
            sb.Append("  qBCProd: ").Append(qBCProd).Append("\n");
            sb.Append("  vAliqProd: ").Append(vAliqProd).Append("\n");
            sb.Append("  vCIDE: ").Append(vCIDE).Append("\n");
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
            return this.Equals(input as NfeSefazCIDE);
        }

        /// <summary>
        /// Returns true if NfeSefazCIDE instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCIDE to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCIDE input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qBCProd == input.qBCProd ||
                    (this.qBCProd != null &&
                    this.qBCProd.Equals(input.qBCProd))
                ) && 
                (
                    this.vAliqProd == input.vAliqProd ||
                    (this.vAliqProd != null &&
                    this.vAliqProd.Equals(input.vAliqProd))
                ) && 
                (
                    this.vCIDE == input.vCIDE ||
                    (this.vCIDE != null &&
                    this.vCIDE.Equals(input.vCIDE))
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
                if (this.qBCProd != null)
                {
                    hashCode = (hashCode * 59) + this.qBCProd.GetHashCode();
                }
                if (this.vAliqProd != null)
                {
                    hashCode = (hashCode * 59) + this.vAliqProd.GetHashCode();
                }
                if (this.vCIDE != null)
                {
                    hashCode = (hashCode * 59) + this.vCIDE.GetHashCode();
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
            // qBCProd (decimal?) minimum
            if (this.qBCProd < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qBCProd, must be a value greater than or equal to 0.", new [] { "qBCProd" });
            }

            // vAliqProd (decimal?) minimum
            if (this.vAliqProd < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vAliqProd, must be a value greater than or equal to 0.", new [] { "vAliqProd" });
            }

            // vCIDE (decimal?) minimum
            if (this.vCIDE < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCIDE, must be a value greater than or equal to 0.", new [] { "vCIDE" });
            }

            yield break;
        }
    }

}
