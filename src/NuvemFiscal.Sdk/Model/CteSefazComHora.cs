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
    /// Entrega com hora definida.
    /// </summary>
    [DataContract(Name = "CteSefazComHora")]
    public partial class CteSefazComHora : IEquatable<CteSefazComHora>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazComHora" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazComHora() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazComHora" /> class.
        /// </summary>
        /// <param name="tpHor">Tipo de hora.  Preencher com:  * 1 - No horário  * 2 - Até o horário  * 3 - A partir do horário (required).</param>
        /// <param name="hProg">Hora programada.  Formato HH:MM:SS. (required).</param>
        public CteSefazComHora(int? tpHor = default(int?), string hProg = default(string))
        {
            // to ensure "tpHor" is required (not null)
            if (tpHor == null)
            {
                throw new ArgumentNullException("tpHor is a required property for CteSefazComHora and cannot be null");
            }
            this.tpHor = tpHor;
            // to ensure "hProg" is required (not null)
            if (hProg == null)
            {
                throw new ArgumentNullException("hProg is a required property for CteSefazComHora and cannot be null");
            }
            this.hProg = hProg;
        }

        /// <summary>
        /// Tipo de hora.  Preencher com:  * 1 - No horário  * 2 - Até o horário  * 3 - A partir do horário
        /// </summary>
        /// <value>Tipo de hora.  Preencher com:  * 1 - No horário  * 2 - Até o horário  * 3 - A partir do horário</value>
        [DataMember(Name = "tpHor", IsRequired = true, EmitDefaultValue = true)]
        public int? tpHor { get; set; }

        /// <summary>
        /// Hora programada.  Formato HH:MM:SS.
        /// </summary>
        /// <value>Hora programada.  Formato HH:MM:SS.</value>
        [DataMember(Name = "hProg", IsRequired = true, EmitDefaultValue = true)]
        public string hProg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazComHora {\n");
            sb.Append("  tpHor: ").Append(tpHor).Append("\n");
            sb.Append("  hProg: ").Append(hProg).Append("\n");
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
            return this.Equals(input as CteSefazComHora);
        }

        /// <summary>
        /// Returns true if CteSefazComHora instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazComHora to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazComHora input)
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
                    this.hProg == input.hProg ||
                    (this.hProg != null &&
                    this.hProg.Equals(input.hProg))
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
                if (this.hProg != null)
                {
                    hashCode = (hashCode * 59) + this.hProg.GetHashCode();
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
