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
    /// Dados do PIS.
    /// </summary>
    [DataContract(Name = "NfcomSefazPIS")]
    public partial class NfcomSefazPIS : IEquatable<NfcomSefazPIS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazPIS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazPIS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazPIS" /> class.
        /// </summary>
        /// <param name="cST">classificação Tributária do PIS.  * 01 - Tributável com alíquota básica  * 02 - Tributável com alíquota diferenciada  * 06 - Tributável com alíquota zero  * 07 - Operação isenta de contribuição  * 08 - Operação sem incidência da contribuição  * 09 - Operação com suspensão da contribuição  * 49 - Outras operações de saída (required).</param>
        /// <param name="vBC">Valor da BC do PIS. (required).</param>
        /// <param name="pPIS">Alíquota do PIS (em percentual). (required).</param>
        /// <param name="vPIS">Valor do PIS. (required).</param>
        public NfcomSefazPIS(string cST = default(string), decimal? vBC = default(decimal?), decimal? pPIS = default(decimal?), decimal? vPIS = default(decimal?))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfcomSefazPIS and cannot be null");
            }
            this.CST = cST;
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfcomSefazPIS and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pPIS" is required (not null)
            if (pPIS == null)
            {
                throw new ArgumentNullException("pPIS is a required property for NfcomSefazPIS and cannot be null");
            }
            this.pPIS = pPIS;
            // to ensure "vPIS" is required (not null)
            if (vPIS == null)
            {
                throw new ArgumentNullException("vPIS is a required property for NfcomSefazPIS and cannot be null");
            }
            this.vPIS = vPIS;
        }

        /// <summary>
        /// classificação Tributária do PIS.  * 01 - Tributável com alíquota básica  * 02 - Tributável com alíquota diferenciada  * 06 - Tributável com alíquota zero  * 07 - Operação isenta de contribuição  * 08 - Operação sem incidência da contribuição  * 09 - Operação com suspensão da contribuição  * 49 - Outras operações de saída
        /// </summary>
        /// <value>classificação Tributária do PIS.  * 01 - Tributável com alíquota básica  * 02 - Tributável com alíquota diferenciada  * 06 - Tributável com alíquota zero  * 07 - Operação isenta de contribuição  * 08 - Operação sem incidência da contribuição  * 09 - Operação com suspensão da contribuição  * 49 - Outras operações de saída</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do PIS.
        /// </summary>
        /// <value>Valor da BC do PIS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do PIS (em percentual).
        /// </summary>
        /// <value>Alíquota do PIS (em percentual).</value>
        [DataMember(Name = "pPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pPIS { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazPIS {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pPIS: ").Append(pPIS).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
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
            return this.Equals(input as NfcomSefazPIS);
        }

        /// <summary>
        /// Returns true if NfcomSefazPIS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazPIS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazPIS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pPIS == input.pPIS ||
                    (this.pPIS != null &&
                    this.pPIS.Equals(input.pPIS))
                ) && 
                (
                    this.vPIS == input.vPIS ||
                    (this.vPIS != null &&
                    this.vPIS.Equals(input.vPIS))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pPIS != null)
                {
                    hashCode = (hashCode * 59) + this.pPIS.GetHashCode();
                }
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // pPIS (decimal?) minimum
            if (this.pPIS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pPIS, must be a value greater than or equal to 0.", new [] { "pPIS" });
            }

            // vPIS (decimal?) minimum
            if (this.vPIS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vPIS, must be a value greater than or equal to 0.", new [] { "vPIS" });
            }

            yield break;
        }
    }

}
