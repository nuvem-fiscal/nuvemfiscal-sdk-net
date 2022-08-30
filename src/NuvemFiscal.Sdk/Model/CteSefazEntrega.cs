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
    /// CteSefazEntrega
    /// </summary>
    [DataContract(Name = "CteSefazEntrega")]
    public partial class CteSefazEntrega : IEquatable<CteSefazEntrega>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEntrega" /> class.
        /// </summary>
        /// <param name="semData">semData.</param>
        /// <param name="comData">comData.</param>
        /// <param name="noPeriodo">noPeriodo.</param>
        /// <param name="semHora">semHora.</param>
        /// <param name="comHora">comHora.</param>
        /// <param name="noInter">noInter.</param>
        public CteSefazEntrega(CteSefazSemData semData = default(CteSefazSemData), CteSefazComData comData = default(CteSefazComData), CteSefazNoPeriodo noPeriodo = default(CteSefazNoPeriodo), CteSefazSemHora semHora = default(CteSefazSemHora), CteSefazComHora comHora = default(CteSefazComHora), CteSefazNoInter noInter = default(CteSefazNoInter))
        {
            this.semData = semData;
            this.comData = comData;
            this.noPeriodo = noPeriodo;
            this.semHora = semHora;
            this.comHora = comHora;
            this.noInter = noInter;
        }

        /// <summary>
        /// Gets or Sets semData
        /// </summary>
        [DataMember(Name = "semData", EmitDefaultValue = false)]
        public CteSefazSemData semData { get; set; }

        /// <summary>
        /// Gets or Sets comData
        /// </summary>
        [DataMember(Name = "comData", EmitDefaultValue = false)]
        public CteSefazComData comData { get; set; }

        /// <summary>
        /// Gets or Sets noPeriodo
        /// </summary>
        [DataMember(Name = "noPeriodo", EmitDefaultValue = false)]
        public CteSefazNoPeriodo noPeriodo { get; set; }

        /// <summary>
        /// Gets or Sets semHora
        /// </summary>
        [DataMember(Name = "semHora", EmitDefaultValue = false)]
        public CteSefazSemHora semHora { get; set; }

        /// <summary>
        /// Gets or Sets comHora
        /// </summary>
        [DataMember(Name = "comHora", EmitDefaultValue = false)]
        public CteSefazComHora comHora { get; set; }

        /// <summary>
        /// Gets or Sets noInter
        /// </summary>
        [DataMember(Name = "noInter", EmitDefaultValue = false)]
        public CteSefazNoInter noInter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazEntrega {\n");
            sb.Append("  semData: ").Append(semData).Append("\n");
            sb.Append("  comData: ").Append(comData).Append("\n");
            sb.Append("  noPeriodo: ").Append(noPeriodo).Append("\n");
            sb.Append("  semHora: ").Append(semHora).Append("\n");
            sb.Append("  comHora: ").Append(comHora).Append("\n");
            sb.Append("  noInter: ").Append(noInter).Append("\n");
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
            return this.Equals(input as CteSefazEntrega);
        }

        /// <summary>
        /// Returns true if CteSefazEntrega instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazEntrega to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazEntrega input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.semData == input.semData ||
                    (this.semData != null &&
                    this.semData.Equals(input.semData))
                ) && 
                (
                    this.comData == input.comData ||
                    (this.comData != null &&
                    this.comData.Equals(input.comData))
                ) && 
                (
                    this.noPeriodo == input.noPeriodo ||
                    (this.noPeriodo != null &&
                    this.noPeriodo.Equals(input.noPeriodo))
                ) && 
                (
                    this.semHora == input.semHora ||
                    (this.semHora != null &&
                    this.semHora.Equals(input.semHora))
                ) && 
                (
                    this.comHora == input.comHora ||
                    (this.comHora != null &&
                    this.comHora.Equals(input.comHora))
                ) && 
                (
                    this.noInter == input.noInter ||
                    (this.noInter != null &&
                    this.noInter.Equals(input.noInter))
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
                if (this.semData != null)
                {
                    hashCode = (hashCode * 59) + this.semData.GetHashCode();
                }
                if (this.comData != null)
                {
                    hashCode = (hashCode * 59) + this.comData.GetHashCode();
                }
                if (this.noPeriodo != null)
                {
                    hashCode = (hashCode * 59) + this.noPeriodo.GetHashCode();
                }
                if (this.semHora != null)
                {
                    hashCode = (hashCode * 59) + this.semHora.GetHashCode();
                }
                if (this.comHora != null)
                {
                    hashCode = (hashCode * 59) + this.comHora.GetHashCode();
                }
                if (this.noInter != null)
                {
                    hashCode = (hashCode * 59) + this.noInter.GetHashCode();
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
