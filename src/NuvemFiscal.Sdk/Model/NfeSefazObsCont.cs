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
    /// Grupo de observações de uso livre (para o item da NF-e).
    /// </summary>
    [DataContract(Name = "NfeSefazObsCont")]
    public partial class NfeSefazObsCont : IEquatable<NfeSefazObsCont>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazObsCont" /> class.
        /// </summary>
        /// <param name="xCampo">xCampo.</param>
        /// <param name="xTexto">xTexto.</param>
        public NfeSefazObsCont(string xCampo = default(string), string xTexto = default(string))
        {
            this.xCampo = xCampo;
            this.xTexto = xTexto;
        }

        /// <summary>
        /// Gets or Sets xCampo
        /// </summary>
        [DataMember(Name = "xCampo", EmitDefaultValue = true)]
        public string xCampo { get; set; }

        /// <summary>
        /// Gets or Sets xTexto
        /// </summary>
        [DataMember(Name = "xTexto", EmitDefaultValue = true)]
        public string xTexto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazObsCont {\n");
            sb.Append("  xCampo: ").Append(xCampo).Append("\n");
            sb.Append("  xTexto: ").Append(xTexto).Append("\n");
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
            return this.Equals(input as NfeSefazObsCont);
        }

        /// <summary>
        /// Returns true if NfeSefazObsCont instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazObsCont to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazObsCont input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xCampo == input.xCampo ||
                    (this.xCampo != null &&
                    this.xCampo.Equals(input.xCampo))
                ) && 
                (
                    this.xTexto == input.xTexto ||
                    (this.xTexto != null &&
                    this.xTexto.Equals(input.xTexto))
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
                if (this.xCampo != null)
                {
                    hashCode = (hashCode * 59) + this.xCampo.GetHashCode();
                }
                if (this.xTexto != null)
                {
                    hashCode = (hashCode * 59) + this.xTexto.GetHashCode();
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
            // xCampo (string) maxLength
            if (this.xCampo != null && this.xCampo.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xCampo, length must be less than 20.", new [] { "xCampo" });
            }

            // xCampo (string) minLength
            if (this.xCampo != null && this.xCampo.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xCampo, length must be greater than 1.", new [] { "xCampo" });
            }

            // xTexto (string) maxLength
            if (this.xTexto != null && this.xTexto.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xTexto, length must be less than 60.", new [] { "xTexto" });
            }

            // xTexto (string) minLength
            if (this.xTexto != null && this.xTexto.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xTexto, length must be greater than 1.", new [] { "xTexto" });
            }

            yield break;
        }
    }

}
