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
    /// Entrega sem data definida.  Esta opção é proibida para o modal aéreo.
    /// </summary>
    [DataContract(Name = "CteSefazSemData")]
    public partial class CteSefazSemData : IEquatable<CteSefazSemData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazSemData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazSemData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazSemData" /> class.
        /// </summary>
        /// <param name="tpPer">Tipo de data/período programado para entrega.  * 0 - Sem data definida (required).</param>
        public CteSefazSemData(int? tpPer = default(int?))
        {
            // to ensure "tpPer" is required (not null)
            if (tpPer == null)
            {
                throw new ArgumentNullException("tpPer is a required property for CteSefazSemData and cannot be null");
            }
            this.tpPer = tpPer;
        }

        /// <summary>
        /// Tipo de data/período programado para entrega.  * 0 - Sem data definida
        /// </summary>
        /// <value>Tipo de data/período programado para entrega.  * 0 - Sem data definida</value>
        [DataMember(Name = "tpPer", IsRequired = true, EmitDefaultValue = true)]
        public int? tpPer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazSemData {\n");
            sb.Append("  tpPer: ").Append(tpPer).Append("\n");
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
            return this.Equals(input as CteSefazSemData);
        }

        /// <summary>
        /// Returns true if CteSefazSemData instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazSemData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazSemData input)
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
