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
    /// Entrega no intervalo de horário definido.
    /// </summary>
    [DataContract(Name = "CteSefazNoInter")]
    public partial class CteSefazNoInter : IEquatable<CteSefazNoInter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazNoInter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazNoInter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazNoInter" /> class.
        /// </summary>
        /// <param name="tpHor">Tipo de hora.  * 4 - No intervalo de tempo (required).</param>
        /// <param name="hIni">Hora inicial.  Formato HH:MM:SS. (required).</param>
        /// <param name="hFim">Hora final.  Formato HH:MM:SS. (required).</param>
        public CteSefazNoInter(int? tpHor = default(int?), string hIni = default(string), string hFim = default(string))
        {
            // to ensure "tpHor" is required (not null)
            if (tpHor == null)
            {
                throw new ArgumentNullException("tpHor is a required property for CteSefazNoInter and cannot be null");
            }
            this.tpHor = tpHor;
            // to ensure "hIni" is required (not null)
            if (hIni == null)
            {
                throw new ArgumentNullException("hIni is a required property for CteSefazNoInter and cannot be null");
            }
            this.hIni = hIni;
            // to ensure "hFim" is required (not null)
            if (hFim == null)
            {
                throw new ArgumentNullException("hFim is a required property for CteSefazNoInter and cannot be null");
            }
            this.hFim = hFim;
        }

        /// <summary>
        /// Tipo de hora.  * 4 - No intervalo de tempo
        /// </summary>
        /// <value>Tipo de hora.  * 4 - No intervalo de tempo</value>
        [DataMember(Name = "tpHor", IsRequired = true, EmitDefaultValue = true)]
        public int? tpHor { get; set; }

        /// <summary>
        /// Hora inicial.  Formato HH:MM:SS.
        /// </summary>
        /// <value>Hora inicial.  Formato HH:MM:SS.</value>
        [DataMember(Name = "hIni", IsRequired = true, EmitDefaultValue = true)]
        public string hIni { get; set; }

        /// <summary>
        /// Hora final.  Formato HH:MM:SS.
        /// </summary>
        /// <value>Hora final.  Formato HH:MM:SS.</value>
        [DataMember(Name = "hFim", IsRequired = true, EmitDefaultValue = true)]
        public string hFim { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazNoInter {\n");
            sb.Append("  tpHor: ").Append(tpHor).Append("\n");
            sb.Append("  hIni: ").Append(hIni).Append("\n");
            sb.Append("  hFim: ").Append(hFim).Append("\n");
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
            return this.Equals(input as CteSefazNoInter);
        }

        /// <summary>
        /// Returns true if CteSefazNoInter instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazNoInter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazNoInter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpHor == input.tpHor ||
                    (this.tpHor != null &&
                    this.tpHor.Equals(input.tpHor))
                ) && 
                (
                    this.hIni == input.hIni ||
                    (this.hIni != null &&
                    this.hIni.Equals(input.hIni))
                ) && 
                (
                    this.hFim == input.hFim ||
                    (this.hFim != null &&
                    this.hFim.Equals(input.hFim))
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
                if (this.tpHor != null)
                {
                    hashCode = (hashCode * 59) + this.tpHor.GetHashCode();
                }
                if (this.hIni != null)
                {
                    hashCode = (hashCode * 59) + this.hIni.GetHashCode();
                }
                if (this.hFim != null)
                {
                    hashCode = (hashCode * 59) + this.hFim.GetHashCode();
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
