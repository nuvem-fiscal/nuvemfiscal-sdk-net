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
    /// Informações de quantidades da Carga do CT-e.  Para Transporte de Pessoas indicar número de passageiros, para excesso de bagagem e transporte de valores indicar número de Volumes/Malotes.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfQOS")]
    public partial class CteOsSefazInfQOS : IEquatable<CteOsSefazInfQOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfQOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfQOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfQOS" /> class.
        /// </summary>
        /// <param name="qCarga">Quantidade. (required).</param>
        public CteOsSefazInfQOS(decimal? qCarga = default(decimal?))
        {
            // to ensure "qCarga" is required (not null)
            if (qCarga == null)
            {
                throw new ArgumentNullException("qCarga is a required property for CteOsSefazInfQOS and cannot be null");
            }
            this.qCarga = qCarga;
        }

        /// <summary>
        /// Quantidade.
        /// </summary>
        /// <value>Quantidade.</value>
        [DataMember(Name = "qCarga", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qCarga { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfQOS {\n");
            sb.Append("  qCarga: ").Append(qCarga).Append("\n");
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
            return this.Equals(input as CteOsSefazInfQOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfQOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfQOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfQOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qCarga == input.qCarga ||
                    (this.qCarga != null &&
                    this.qCarga.Equals(input.qCarga))
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
                if (this.qCarga != null)
                {
                    hashCode = (hashCode * 59) + this.qCarga.GetHashCode();
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
            // qCarga (decimal?) minimum
            if (this.qCarga < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qCarga, must be a value greater than or equal to 0.", new [] { "qCarga" });
            }

            yield break;
        }
    }

}
