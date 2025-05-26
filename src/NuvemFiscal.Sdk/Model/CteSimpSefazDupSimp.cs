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
    /// Dados das duplicatas.
    /// </summary>
    [DataContract(Name = "CteSimpSefazDupSimp")]
    public partial class CteSimpSefazDupSimp : IEquatable<CteSimpSefazDupSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazDupSimp" /> class.
        /// </summary>
        /// <param name="nDup">Número da duplicata..</param>
        /// <param name="dVenc">Data de vencimento da duplicata (AAAA-MM-DD)..</param>
        /// <param name="vDup">Valor da duplicata..</param>
        public CteSimpSefazDupSimp(string nDup = default(string), DateTime? dVenc = default(DateTime?), decimal? vDup = default(decimal?))
        {
            this.nDup = nDup;
            this.dVenc = dVenc;
            this.vDup = vDup;
        }

        /// <summary>
        /// Número da duplicata.
        /// </summary>
        /// <value>Número da duplicata.</value>
        [DataMember(Name = "nDup", EmitDefaultValue = true)]
        public string nDup { get; set; }

        /// <summary>
        /// Data de vencimento da duplicata (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de vencimento da duplicata (AAAA-MM-DD).</value>
        [DataMember(Name = "dVenc", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dVenc { get; set; }

        /// <summary>
        /// Valor da duplicata.
        /// </summary>
        /// <value>Valor da duplicata.</value>
        [DataMember(Name = "vDup", EmitDefaultValue = true)]
        public decimal? vDup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazDupSimp {\n");
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
            return this.Equals(input as CteSimpSefazDupSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazDupSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazDupSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazDupSimp input)
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
                    (this.vDup != null &&
                    this.vDup.Equals(input.vDup))
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
                if (this.vDup != null)
                {
                    hashCode = (hashCode * 59) + this.vDup.GetHashCode();
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
            // nDup (string) maxLength
            if (this.nDup != null && this.nDup.Length > 60)
            {
                yield return new ValidationResult("Invalid value for nDup, length must be less than 60.", new [] { "nDup" });
            }

            // nDup (string) minLength
            if (this.nDup != null && this.nDup.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nDup, length must be greater than 1.", new [] { "nDup" });
            }

            // vDup (decimal?) minimum
            if (this.vDup < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDup, must be a value greater than or equal to 0.", new [] { "vDup" });
            }

            yield break;
        }
    }

}
