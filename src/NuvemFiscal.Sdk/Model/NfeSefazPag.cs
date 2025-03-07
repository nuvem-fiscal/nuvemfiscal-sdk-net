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
    /// Dados de Pagamento. Obrigatório apenas para (NFC-e) NT 2012/004.
    /// </summary>
    [DataContract(Name = "NfeSefazPag")]
    public partial class NfeSefazPag : IEquatable<NfeSefazPag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazPag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPag" /> class.
        /// </summary>
        /// <param name="detPag">detPag (required).</param>
        /// <param name="vTroco">Valor do Troco..</param>
        public NfeSefazPag(List<NfeSefazDetPag> detPag = default(List<NfeSefazDetPag>), decimal? vTroco = default(decimal?))
        {
            // to ensure "detPag" is required (not null)
            if (detPag == null)
            {
                throw new ArgumentNullException("detPag is a required property for NfeSefazPag and cannot be null");
            }
            this.detPag = detPag;
            this.vTroco = vTroco;
        }

        /// <summary>
        /// Gets or Sets detPag
        /// </summary>
        [DataMember(Name = "detPag", IsRequired = true, EmitDefaultValue = true)]
        public List<NfeSefazDetPag> detPag { get; set; }

        /// <summary>
        /// Valor do Troco.
        /// </summary>
        /// <value>Valor do Troco.</value>
        [DataMember(Name = "vTroco", EmitDefaultValue = true)]
        public decimal? vTroco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazPag {\n");
            sb.Append("  detPag: ").Append(detPag).Append("\n");
            sb.Append("  vTroco: ").Append(vTroco).Append("\n");
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
            return this.Equals(input as NfeSefazPag);
        }

        /// <summary>
        /// Returns true if NfeSefazPag instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazPag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazPag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.detPag == input.detPag ||
                    this.detPag != null &&
                    input.detPag != null &&
                    this.detPag.SequenceEqual(input.detPag)
                ) && 
                (
                    this.vTroco == input.vTroco ||
                    (this.vTroco != null &&
                    this.vTroco.Equals(input.vTroco))
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
                if (this.detPag != null)
                {
                    hashCode = (hashCode * 59) + this.detPag.GetHashCode();
                }
                if (this.vTroco != null)
                {
                    hashCode = (hashCode * 59) + this.vTroco.GetHashCode();
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
            // vTroco (decimal?) minimum
            if (this.vTroco < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTroco, must be a value greater than or equal to 0.", new [] { "vTroco" });
            }

            yield break;
        }
    }

}
