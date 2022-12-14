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
    /// CteSefazDup
    /// </summary>
    [DataContract(Name = "CteSefazDup")]
    public partial class CteSefazDup : IEquatable<CteSefazDup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDup" /> class.
        /// </summary>
        /// <param name="nDup">Número da duplicata..</param>
        /// <param name="dVenc">Data de vencimento da duplicata (AAAA-MM-DD)..</param>
        /// <param name="vDup">Valor da duplicata..</param>
        public CteSefazDup(string nDup = default(string), DateTime dVenc = default(DateTime), decimal vDup = default(decimal))
        {
            this.nDup = nDup;
            this.dVenc = dVenc;
            this.vDup = vDup;
        }

        /// <summary>
        /// Número da duplicata.
        /// </summary>
        /// <value>Número da duplicata.</value>
        [DataMember(Name = "nDup", EmitDefaultValue = false)]
        public string nDup { get; set; }

        /// <summary>
        /// Data de vencimento da duplicata (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de vencimento da duplicata (AAAA-MM-DD).</value>
        [DataMember(Name = "dVenc", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dVenc { get; set; }

        /// <summary>
        /// Valor da duplicata.
        /// </summary>
        /// <value>Valor da duplicata.</value>
        [DataMember(Name = "vDup", EmitDefaultValue = false)]
        public decimal vDup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazDup {\n");
            sb.Append("  nDup: ").Append(nDup).Append("\n");
            sb.Append("  dVenc: ").Append(dVenc).Append("\n");
            sb.Append("  vDup: ").Append(vDup).Append("\n");
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
            return this.Equals(input as CteSefazDup);
        }

        /// <summary>
        /// Returns true if CteSefazDup instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazDup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazDup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nDup == input.nDup ||
                    (this.nDup != null &&
                    this.nDup.Equals(input.nDup))
                ) && 
                (
                    this.dVenc == input.dVenc ||
                    (this.dVenc != null &&
                    this.dVenc.Equals(input.dVenc))
                ) && 
                (
                    this.vDup == input.vDup ||
                    this.vDup.Equals(input.vDup)
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
                if (this.nDup != null)
                {
                    hashCode = (hashCode * 59) + this.nDup.GetHashCode();
                }
                if (this.dVenc != null)
                {
                    hashCode = (hashCode * 59) + this.dVenc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vDup.GetHashCode();
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
