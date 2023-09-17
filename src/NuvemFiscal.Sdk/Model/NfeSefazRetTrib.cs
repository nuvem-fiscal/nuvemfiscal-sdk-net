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
    /// Retenção de Tributos Federais.
    /// </summary>
    [DataContract(Name = "NfeSefazRetTrib")]
    public partial class NfeSefazRetTrib : IEquatable<NfeSefazRetTrib>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRetTrib" /> class.
        /// </summary>
        /// <param name="vRetPIS">Valor Retido de PIS..</param>
        /// <param name="vRetCOFINS">Valor Retido de COFINS..</param>
        /// <param name="vRetCSLL">Valor Retido de CSLL..</param>
        /// <param name="vBCIRRF">Base de Cálculo do IRRF..</param>
        /// <param name="vIRRF">Valor Retido de IRRF..</param>
        /// <param name="vBCRetPrev">Base de Cálculo da Retenção da Previdêncica Social..</param>
        /// <param name="vRetPrev">Valor da Retenção da Previdêncica Social..</param>
        public NfeSefazRetTrib(decimal? vRetPIS = default(decimal?), decimal? vRetCOFINS = default(decimal?), decimal? vRetCSLL = default(decimal?), decimal? vBCIRRF = default(decimal?), decimal? vIRRF = default(decimal?), decimal? vBCRetPrev = default(decimal?), decimal? vRetPrev = default(decimal?))
        {
            this.vRetPIS = vRetPIS;
            this.vRetCOFINS = vRetCOFINS;
            this.vRetCSLL = vRetCSLL;
            this.vBCIRRF = vBCIRRF;
            this.vIRRF = vIRRF;
            this.vBCRetPrev = vBCRetPrev;
            this.vRetPrev = vRetPrev;
        }

        /// <summary>
        /// Valor Retido de PIS.
        /// </summary>
        /// <value>Valor Retido de PIS.</value>
        [DataMember(Name = "vRetPIS", EmitDefaultValue = true)]
        public decimal? vRetPIS { get; set; }

        /// <summary>
        /// Valor Retido de COFINS.
        /// </summary>
        /// <value>Valor Retido de COFINS.</value>
        [DataMember(Name = "vRetCOFINS", EmitDefaultValue = true)]
        public decimal? vRetCOFINS { get; set; }

        /// <summary>
        /// Valor Retido de CSLL.
        /// </summary>
        /// <value>Valor Retido de CSLL.</value>
        [DataMember(Name = "vRetCSLL", EmitDefaultValue = true)]
        public decimal? vRetCSLL { get; set; }

        /// <summary>
        /// Base de Cálculo do IRRF.
        /// </summary>
        /// <value>Base de Cálculo do IRRF.</value>
        [DataMember(Name = "vBCIRRF", EmitDefaultValue = true)]
        public decimal? vBCIRRF { get; set; }

        /// <summary>
        /// Valor Retido de IRRF.
        /// </summary>
        /// <value>Valor Retido de IRRF.</value>
        [DataMember(Name = "vIRRF", EmitDefaultValue = true)]
        public decimal? vIRRF { get; set; }

        /// <summary>
        /// Base de Cálculo da Retenção da Previdêncica Social.
        /// </summary>
        /// <value>Base de Cálculo da Retenção da Previdêncica Social.</value>
        [DataMember(Name = "vBCRetPrev", EmitDefaultValue = true)]
        public decimal? vBCRetPrev { get; set; }

        /// <summary>
        /// Valor da Retenção da Previdêncica Social.
        /// </summary>
        /// <value>Valor da Retenção da Previdêncica Social.</value>
        [DataMember(Name = "vRetPrev", EmitDefaultValue = true)]
        public decimal? vRetPrev { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRetTrib {\n");
            sb.Append("  vRetPIS: ").Append(vRetPIS).Append("\n");
            sb.Append("  vRetCOFINS: ").Append(vRetCOFINS).Append("\n");
            sb.Append("  vRetCSLL: ").Append(vRetCSLL).Append("\n");
            sb.Append("  vBCIRRF: ").Append(vBCIRRF).Append("\n");
            sb.Append("  vIRRF: ").Append(vIRRF).Append("\n");
            sb.Append("  vBCRetPrev: ").Append(vBCRetPrev).Append("\n");
            sb.Append("  vRetPrev: ").Append(vRetPrev).Append("\n");
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
            return this.Equals(input as NfeSefazRetTrib);
        }

        /// <summary>
        /// Returns true if NfeSefazRetTrib instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRetTrib to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRetTrib input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vRetPIS == input.vRetPIS ||
                    (this.vRetPIS != null &&
                    this.vRetPIS.Equals(input.vRetPIS))
                ) && 
                (
                    this.vRetCOFINS == input.vRetCOFINS ||
                    (this.vRetCOFINS != null &&
                    this.vRetCOFINS.Equals(input.vRetCOFINS))
                ) && 
                (
                    this.vRetCSLL == input.vRetCSLL ||
                    (this.vRetCSLL != null &&
                    this.vRetCSLL.Equals(input.vRetCSLL))
                ) && 
                (
                    this.vBCIRRF == input.vBCIRRF ||
                    (this.vBCIRRF != null &&
                    this.vBCIRRF.Equals(input.vBCIRRF))
                ) && 
                (
                    this.vIRRF == input.vIRRF ||
                    (this.vIRRF != null &&
                    this.vIRRF.Equals(input.vIRRF))
                ) && 
                (
                    this.vBCRetPrev == input.vBCRetPrev ||
                    (this.vBCRetPrev != null &&
                    this.vBCRetPrev.Equals(input.vBCRetPrev))
                ) && 
                (
                    this.vRetPrev == input.vRetPrev ||
                    (this.vRetPrev != null &&
                    this.vRetPrev.Equals(input.vRetPrev))
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
                if (this.vRetPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vRetPIS.GetHashCode();
                }
                if (this.vRetCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vRetCOFINS.GetHashCode();
                }
                if (this.vRetCSLL != null)
                {
                    hashCode = (hashCode * 59) + this.vRetCSLL.GetHashCode();
                }
                if (this.vBCIRRF != null)
                {
                    hashCode = (hashCode * 59) + this.vBCIRRF.GetHashCode();
                }
                if (this.vIRRF != null)
                {
                    hashCode = (hashCode * 59) + this.vIRRF.GetHashCode();
                }
                if (this.vBCRetPrev != null)
                {
                    hashCode = (hashCode * 59) + this.vBCRetPrev.GetHashCode();
                }
                if (this.vRetPrev != null)
                {
                    hashCode = (hashCode * 59) + this.vRetPrev.GetHashCode();
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
