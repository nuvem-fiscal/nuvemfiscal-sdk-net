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
    /// Grupo de informações de outros tributos relacionados ao serviço prestado.
    /// </summary>
    [DataContract(Name = "TribFederal")]
    public partial class TribFederal : IEquatable<TribFederal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TribFederal" /> class.
        /// </summary>
        /// <param name="piscofins">piscofins.</param>
        /// <param name="vRetCP">Valor monetário do CP(R$)..</param>
        /// <param name="vRetIRRF">Valor monetário do IRRF (R$)..</param>
        /// <param name="vRetCSLL">Valor monetário do CSLL (R$)..</param>
        public TribFederal(TribOutrosPisCofins piscofins = default(TribOutrosPisCofins), decimal? vRetCP = default(decimal?), decimal? vRetIRRF = default(decimal?), decimal? vRetCSLL = default(decimal?))
        {
            this.piscofins = piscofins;
            this.vRetCP = vRetCP;
            this.vRetIRRF = vRetIRRF;
            this.vRetCSLL = vRetCSLL;
        }

        /// <summary>
        /// Gets or Sets piscofins
        /// </summary>
        [DataMember(Name = "piscofins", EmitDefaultValue = false)]
        public TribOutrosPisCofins piscofins { get; set; }

        /// <summary>
        /// Valor monetário do CP(R$).
        /// </summary>
        /// <value>Valor monetário do CP(R$).</value>
        [DataMember(Name = "vRetCP", EmitDefaultValue = true)]
        public decimal? vRetCP { get; set; }

        /// <summary>
        /// Valor monetário do IRRF (R$).
        /// </summary>
        /// <value>Valor monetário do IRRF (R$).</value>
        [DataMember(Name = "vRetIRRF", EmitDefaultValue = true)]
        public decimal? vRetIRRF { get; set; }

        /// <summary>
        /// Valor monetário do CSLL (R$).
        /// </summary>
        /// <value>Valor monetário do CSLL (R$).</value>
        [DataMember(Name = "vRetCSLL", EmitDefaultValue = true)]
        public decimal? vRetCSLL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TribFederal {\n");
            sb.Append("  piscofins: ").Append(piscofins).Append("\n");
            sb.Append("  vRetCP: ").Append(vRetCP).Append("\n");
            sb.Append("  vRetIRRF: ").Append(vRetIRRF).Append("\n");
            sb.Append("  vRetCSLL: ").Append(vRetCSLL).Append("\n");
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
            return this.Equals(input as TribFederal);
        }

        /// <summary>
        /// Returns true if TribFederal instances are equal
        /// </summary>
        /// <param name="input">Instance of TribFederal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TribFederal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.piscofins == input.piscofins ||
                    (this.piscofins != null &&
                    this.piscofins.Equals(input.piscofins))
                ) && 
                (
                    this.vRetCP == input.vRetCP ||
                    (this.vRetCP != null &&
                    this.vRetCP.Equals(input.vRetCP))
                ) && 
                (
                    this.vRetIRRF == input.vRetIRRF ||
                    (this.vRetIRRF != null &&
                    this.vRetIRRF.Equals(input.vRetIRRF))
                ) && 
                (
                    this.vRetCSLL == input.vRetCSLL ||
                    (this.vRetCSLL != null &&
                    this.vRetCSLL.Equals(input.vRetCSLL))
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
                if (this.piscofins != null)
                {
                    hashCode = (hashCode * 59) + this.piscofins.GetHashCode();
                }
                if (this.vRetCP != null)
                {
                    hashCode = (hashCode * 59) + this.vRetCP.GetHashCode();
                }
                if (this.vRetIRRF != null)
                {
                    hashCode = (hashCode * 59) + this.vRetIRRF.GetHashCode();
                }
                if (this.vRetCSLL != null)
                {
                    hashCode = (hashCode * 59) + this.vRetCSLL.GetHashCode();
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
