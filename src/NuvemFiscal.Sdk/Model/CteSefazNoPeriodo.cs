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
    /// Entrega no período definido.
    /// </summary>
    [DataContract(Name = "CteSefazNoPeriodo")]
    public partial class CteSefazNoPeriodo : IEquatable<CteSefazNoPeriodo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazNoPeriodo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazNoPeriodo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazNoPeriodo" /> class.
        /// </summary>
        /// <param name="tpPer">Tipo período.  * 4 - no período (required).</param>
        /// <param name="dIni">Data inicial.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="dFim">Data final.  Formato AAAA-MM-DD. (required).</param>
        public CteSefazNoPeriodo(int? tpPer = default(int?), DateTime? dIni = default(DateTime?), DateTime? dFim = default(DateTime?))
        {
            // to ensure "tpPer" is required (not null)
            if (tpPer == null)
            {
                throw new ArgumentNullException("tpPer is a required property for CteSefazNoPeriodo and cannot be null");
            }
            this.tpPer = tpPer;
            // to ensure "dIni" is required (not null)
            if (dIni == null)
            {
                throw new ArgumentNullException("dIni is a required property for CteSefazNoPeriodo and cannot be null");
            }
            this.dIni = dIni;
            // to ensure "dFim" is required (not null)
            if (dFim == null)
            {
                throw new ArgumentNullException("dFim is a required property for CteSefazNoPeriodo and cannot be null");
            }
            this.dFim = dFim;
        }

        /// <summary>
        /// Tipo período.  * 4 - no período
        /// </summary>
        /// <value>Tipo período.  * 4 - no período</value>
        [DataMember(Name = "tpPer", IsRequired = true, EmitDefaultValue = true)]
        public int? tpPer { get; set; }

        /// <summary>
        /// Data inicial.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data inicial.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dIni", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dIni { get; set; }

        /// <summary>
        /// Data final.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data final.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dFim", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dFim { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazNoPeriodo {\n");
            sb.Append("  tpPer: ").Append(tpPer).Append("\n");
            sb.Append("  dIni: ").Append(dIni).Append("\n");
            sb.Append("  dFim: ").Append(dFim).Append("\n");
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
            return this.Equals(input as CteSefazNoPeriodo);
        }

        /// <summary>
        /// Returns true if CteSefazNoPeriodo instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazNoPeriodo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazNoPeriodo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpPer == input.tpPer ||
                    (this.tpPer != null &&
                    this.tpPer.Equals(input.tpPer))
                ) && 
                (
                    this.dIni == input.dIni ||
                    (this.dIni != null &&
                    this.dIni.Equals(input.dIni))
                ) && 
                (
                    this.dFim == input.dFim ||
                    (this.dFim != null &&
                    this.dFim.Equals(input.dFim))
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
                if (this.tpPer != null)
                {
                    hashCode = (hashCode * 59) + this.tpPer.GetHashCode();
                }
                if (this.dIni != null)
                {
                    hashCode = (hashCode * 59) + this.dIni.GetHashCode();
                }
                if (this.dFim != null)
                {
                    hashCode = (hashCode * 59) + this.dFim.GetHashCode();
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
            yield break;
        }
    }

}
