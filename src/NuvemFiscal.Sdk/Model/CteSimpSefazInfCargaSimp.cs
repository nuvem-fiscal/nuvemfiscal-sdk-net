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
    /// Informações da Carga do CT-e.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfCargaSimp")]
    public partial class CteSimpSefazInfCargaSimp : IEquatable<CteSimpSefazInfCargaSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCargaSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazInfCargaSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCargaSimp" /> class.
        /// </summary>
        /// <param name="vCarga">Valor total da carga. (required).</param>
        /// <param name="proPred">Produto predominante.  Informar a descrição do produto predominante. (required).</param>
        /// <param name="xOutCat">Outras características da carga.  \&quot;FRIA\&quot;, \&quot;GRANEL\&quot;, \&quot;REFRIGERADA\&quot;, \&quot;Medidas: 12X12X12\&quot;..</param>
        /// <param name="infQ">infQ (required).</param>
        /// <param name="vCargaAverb">Valor da Carga para efeito de averbação.  Normalmente igual ao valor declarado da mercadoria, diferente por exemplo, quando a mercadoria transportada é isenta de tributos nacionais para exportação, onde é preciso averbar um valor maior, pois no caso de indenização, o valor a ser pago será maior..</param>
        public CteSimpSefazInfCargaSimp(decimal? vCarga = default(decimal?), string proPred = default(string), string xOutCat = default(string), List<CteSimpSefazInfQSimp> infQ = default(List<CteSimpSefazInfQSimp>), decimal? vCargaAverb = default(decimal?))
        {
            // to ensure "vCarga" is required (not null)
            if (vCarga == null)
            {
                throw new ArgumentNullException("vCarga is a required property for CteSimpSefazInfCargaSimp and cannot be null");
            }
            this.vCarga = vCarga;
            // to ensure "proPred" is required (not null)
            if (proPred == null)
            {
                throw new ArgumentNullException("proPred is a required property for CteSimpSefazInfCargaSimp and cannot be null");
            }
            this.proPred = proPred;
            // to ensure "infQ" is required (not null)
            if (infQ == null)
            {
                throw new ArgumentNullException("infQ is a required property for CteSimpSefazInfCargaSimp and cannot be null");
            }
            this.infQ = infQ;
            this.xOutCat = xOutCat;
            this.vCargaAverb = vCargaAverb;
        }

        /// <summary>
        /// Valor total da carga.
        /// </summary>
        /// <value>Valor total da carga.</value>
        [DataMember(Name = "vCarga", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCarga { get; set; }

        /// <summary>
        /// Produto predominante.  Informar a descrição do produto predominante.
        /// </summary>
        /// <value>Produto predominante.  Informar a descrição do produto predominante.</value>
        [DataMember(Name = "proPred", IsRequired = true, EmitDefaultValue = true)]
        public string proPred { get; set; }

        /// <summary>
        /// Outras características da carga.  \&quot;FRIA\&quot;, \&quot;GRANEL\&quot;, \&quot;REFRIGERADA\&quot;, \&quot;Medidas: 12X12X12\&quot;.
        /// </summary>
        /// <value>Outras características da carga.  \&quot;FRIA\&quot;, \&quot;GRANEL\&quot;, \&quot;REFRIGERADA\&quot;, \&quot;Medidas: 12X12X12\&quot;.</value>
        [DataMember(Name = "xOutCat", EmitDefaultValue = true)]
        public string xOutCat { get; set; }

        /// <summary>
        /// Gets or Sets infQ
        /// </summary>
        [DataMember(Name = "infQ", IsRequired = true, EmitDefaultValue = true)]
        public List<CteSimpSefazInfQSimp> infQ { get; set; }

        /// <summary>
        /// Valor da Carga para efeito de averbação.  Normalmente igual ao valor declarado da mercadoria, diferente por exemplo, quando a mercadoria transportada é isenta de tributos nacionais para exportação, onde é preciso averbar um valor maior, pois no caso de indenização, o valor a ser pago será maior.
        /// </summary>
        /// <value>Valor da Carga para efeito de averbação.  Normalmente igual ao valor declarado da mercadoria, diferente por exemplo, quando a mercadoria transportada é isenta de tributos nacionais para exportação, onde é preciso averbar um valor maior, pois no caso de indenização, o valor a ser pago será maior.</value>
        [DataMember(Name = "vCargaAverb", EmitDefaultValue = true)]
        public decimal? vCargaAverb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfCargaSimp {\n");
            sb.Append("  vCarga: ").Append(vCarga).Append("\n");
            sb.Append("  proPred: ").Append(proPred).Append("\n");
            sb.Append("  xOutCat: ").Append(xOutCat).Append("\n");
            sb.Append("  infQ: ").Append(infQ).Append("\n");
            sb.Append("  vCargaAverb: ").Append(vCargaAverb).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfCargaSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfCargaSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfCargaSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfCargaSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vCarga == input.vCarga ||
                    (this.vCarga != null &&
                    this.vCarga.Equals(input.vCarga))
                ) && 
                (
                    this.proPred == input.proPred ||
                    (this.proPred != null &&
                    this.proPred.Equals(input.proPred))
                ) && 
                (
                    this.xOutCat == input.xOutCat ||
                    (this.xOutCat != null &&
                    this.xOutCat.Equals(input.xOutCat))
                ) && 
                (
                    this.infQ == input.infQ ||
                    this.infQ != null &&
                    input.infQ != null &&
                    this.infQ.SequenceEqual(input.infQ)
                ) && 
                (
                    this.vCargaAverb == input.vCargaAverb ||
                    (this.vCargaAverb != null &&
                    this.vCargaAverb.Equals(input.vCargaAverb))
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
                if (this.vCarga != null)
                {
                    hashCode = (hashCode * 59) + this.vCarga.GetHashCode();
                }
                if (this.proPred != null)
                {
                    hashCode = (hashCode * 59) + this.proPred.GetHashCode();
                }
                if (this.xOutCat != null)
                {
                    hashCode = (hashCode * 59) + this.xOutCat.GetHashCode();
                }
                if (this.infQ != null)
                {
                    hashCode = (hashCode * 59) + this.infQ.GetHashCode();
                }
                if (this.vCargaAverb != null)
                {
                    hashCode = (hashCode * 59) + this.vCargaAverb.GetHashCode();
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
            // vCarga (decimal?) minimum
            if (this.vCarga < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCarga, must be a value greater than or equal to 0.", new [] { "vCarga" });
            }

            // proPred (string) maxLength
            if (this.proPred != null && this.proPred.Length > 60)
            {
                yield return new ValidationResult("Invalid value for proPred, length must be less than 60.", new [] { "proPred" });
            }

            // proPred (string) minLength
            if (this.proPred != null && this.proPred.Length < 1)
            {
                yield return new ValidationResult("Invalid value for proPred, length must be greater than 1.", new [] { "proPred" });
            }

            // xOutCat (string) maxLength
            if (this.xOutCat != null && this.xOutCat.Length > 30)
            {
                yield return new ValidationResult("Invalid value for xOutCat, length must be less than 30.", new [] { "xOutCat" });
            }

            // xOutCat (string) minLength
            if (this.xOutCat != null && this.xOutCat.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xOutCat, length must be greater than 1.", new [] { "xOutCat" });
            }

            // vCargaAverb (decimal?) minimum
            if (this.vCargaAverb < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCargaAverb, must be a value greater than or equal to 0.", new [] { "vCargaAverb" });
            }

            yield break;
        }
    }

}
