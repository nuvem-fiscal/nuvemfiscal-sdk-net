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
    /// Entrega sem hora definida.
    /// </summary>
    [DataContract(Name = "CteSefazSemHora")]
    public partial class CteSefazSemHora : IEquatable<CteSefazSemHora>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazSemHora" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazSemHora() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazSemHora" /> class.
        /// </summary>
        /// <param name="tpHor">Tipo de hora.  * 0 - Sem hora definida (required).</param>
        public CteSefazSemHora(int tpHor = default(int))
        {
            this.tpHor = tpHor;
        }

        /// <summary>
        /// Tipo de hora.  * 0 - Sem hora definida
        /// </summary>
        /// <value>Tipo de hora.  * 0 - Sem hora definida</value>
        [DataMember(Name = "tpHor", IsRequired = true, EmitDefaultValue = true)]
        public int tpHor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazSemHora {\n");
            sb.Append("  tpHor: ").Append(tpHor).Append("\n");
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
            return this.Equals(input as CteSefazSemHora);
        }

        /// <summary>
        /// Returns true if CteSefazSemHora instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazSemHora to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazSemHora input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpHor == input.tpHor ||
                    this.tpHor.Equals(input.tpHor)
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
                hashCode = (hashCode * 59) + this.tpHor.GetHashCode();
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
