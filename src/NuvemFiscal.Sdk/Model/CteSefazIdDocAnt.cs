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
    /// CteSefazIdDocAnt
    /// </summary>
    [DataContract(Name = "CteSefazIdDocAnt")]
    public partial class CteSefazIdDocAnt : IEquatable<CteSefazIdDocAnt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazIdDocAnt" /> class.
        /// </summary>
        /// <param name="idDocAntPap">Documentos de transporte anterior em papel..</param>
        /// <param name="idDocAntEle">Documentos de transporte anterior eletrônicos..</param>
        public CteSefazIdDocAnt(List<CteSefazIdDocAntPap> idDocAntPap = default(List<CteSefazIdDocAntPap>), List<CteSefazIdDocAntEle> idDocAntEle = default(List<CteSefazIdDocAntEle>))
        {
            this.idDocAntPap = idDocAntPap;
            this.idDocAntEle = idDocAntEle;
        }

        /// <summary>
        /// Documentos de transporte anterior em papel.
        /// </summary>
        /// <value>Documentos de transporte anterior em papel.</value>
        [DataMember(Name = "idDocAntPap", EmitDefaultValue = false)]
        public List<CteSefazIdDocAntPap> idDocAntPap { get; set; }

        /// <summary>
        /// Documentos de transporte anterior eletrônicos.
        /// </summary>
        /// <value>Documentos de transporte anterior eletrônicos.</value>
        [DataMember(Name = "idDocAntEle", EmitDefaultValue = false)]
        public List<CteSefazIdDocAntEle> idDocAntEle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazIdDocAnt {\n");
            sb.Append("  idDocAntPap: ").Append(idDocAntPap).Append("\n");
            sb.Append("  idDocAntEle: ").Append(idDocAntEle).Append("\n");
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
            return this.Equals(input as CteSefazIdDocAnt);
        }

        /// <summary>
        /// Returns true if CteSefazIdDocAnt instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazIdDocAnt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazIdDocAnt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.idDocAntPap == input.idDocAntPap ||
                    this.idDocAntPap != null &&
                    input.idDocAntPap != null &&
                    this.idDocAntPap.SequenceEqual(input.idDocAntPap)
                ) && 
                (
                    this.idDocAntEle == input.idDocAntEle ||
                    this.idDocAntEle != null &&
                    input.idDocAntEle != null &&
                    this.idDocAntEle.SequenceEqual(input.idDocAntEle)
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
                if (this.idDocAntPap != null)
                {
                    hashCode = (hashCode * 59) + this.idDocAntPap.GetHashCode();
                }
                if (this.idDocAntEle != null)
                {
                    hashCode = (hashCode * 59) + this.idDocAntEle.GetHashCode();
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
