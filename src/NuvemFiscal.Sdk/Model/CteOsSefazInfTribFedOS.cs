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
    /// Informações dos tributos federais.  Grupo a ser informado nas prestações interestaduais para consumidor final, não contribuinte do ICMS.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfTribFedOS")]
    public partial class CteOsSefazInfTribFedOS : IEquatable<CteOsSefazInfTribFedOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfTribFedOS" /> class.
        /// </summary>
        /// <param name="vPIS">Valor do PIS..</param>
        /// <param name="vCOFINS">Valor COFINS..</param>
        /// <param name="vIR">Valor de Imposto de Renda..</param>
        /// <param name="vINSS">Valor do INSS..</param>
        /// <param name="vCSLL">Valor do CSLL..</param>
        public CteOsSefazInfTribFedOS(decimal? vPIS = default(decimal?), decimal? vCOFINS = default(decimal?), decimal? vIR = default(decimal?), decimal? vINSS = default(decimal?), decimal? vCSLL = default(decimal?))
        {
            this.vPIS = vPIS;
            this.vCOFINS = vCOFINS;
            this.vIR = vIR;
            this.vINSS = vINSS;
            this.vCSLL = vCSLL;
        }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Valor COFINS.
        /// </summary>
        /// <value>Valor COFINS.</value>
        [DataMember(Name = "vCOFINS", EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Valor de Imposto de Renda.
        /// </summary>
        /// <value>Valor de Imposto de Renda.</value>
        [DataMember(Name = "vIR", EmitDefaultValue = true)]
        public decimal? vIR { get; set; }

        /// <summary>
        /// Valor do INSS.
        /// </summary>
        /// <value>Valor do INSS.</value>
        [DataMember(Name = "vINSS", EmitDefaultValue = true)]
        public decimal? vINSS { get; set; }

        /// <summary>
        /// Valor do CSLL.
        /// </summary>
        /// <value>Valor do CSLL.</value>
        [DataMember(Name = "vCSLL", EmitDefaultValue = true)]
        public decimal? vCSLL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfTribFedOS {\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
            sb.Append("  vIR: ").Append(vIR).Append("\n");
            sb.Append("  vINSS: ").Append(vINSS).Append("\n");
            sb.Append("  vCSLL: ").Append(vCSLL).Append("\n");
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
            return this.Equals(input as CteOsSefazInfTribFedOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfTribFedOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfTribFedOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfTribFedOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vPIS == input.vPIS ||
                    (this.vPIS != null &&
                    this.vPIS.Equals(input.vPIS))
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    (this.vCOFINS != null &&
                    this.vCOFINS.Equals(input.vCOFINS))
                ) && 
                (
                    this.vIR == input.vIR ||
                    (this.vIR != null &&
                    this.vIR.Equals(input.vIR))
                ) && 
                (
                    this.vINSS == input.vINSS ||
                    (this.vINSS != null &&
                    this.vINSS.Equals(input.vINSS))
                ) && 
                (
                    this.vCSLL == input.vCSLL ||
                    (this.vCSLL != null &&
                    this.vCSLL.Equals(input.vCSLL))
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
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                }
                if (this.vIR != null)
                {
                    hashCode = (hashCode * 59) + this.vIR.GetHashCode();
                }
                if (this.vINSS != null)
                {
                    hashCode = (hashCode * 59) + this.vINSS.GetHashCode();
                }
                if (this.vCSLL != null)
                {
                    hashCode = (hashCode * 59) + this.vCSLL.GetHashCode();
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
            // vPIS (decimal?) minimum
            if (this.vPIS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vPIS, must be a value greater than or equal to 0.", new [] { "vPIS" });
            }

            // vCOFINS (decimal?) minimum
            if (this.vCOFINS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCOFINS, must be a value greater than or equal to 0.", new [] { "vCOFINS" });
            }

            // vIR (decimal?) minimum
            if (this.vIR < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIR, must be a value greater than or equal to 0.", new [] { "vIR" });
            }

            // vINSS (decimal?) minimum
            if (this.vINSS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vINSS, must be a value greater than or equal to 0.", new [] { "vINSS" });
            }

            // vCSLL (decimal?) minimum
            if (this.vCSLL < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCSLL, must be a value greater than or equal to 0.", new [] { "vCSLL" });
            }

            yield break;
        }
    }

}
