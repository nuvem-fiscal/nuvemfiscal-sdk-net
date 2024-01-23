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
    /// Informações de Seguro do Multimodal.
    /// </summary>
    [DataContract(Name = "CteSefazSeg")]
    public partial class CteSefazSeg : IEquatable<CteSefazSeg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazSeg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazSeg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazSeg" /> class.
        /// </summary>
        /// <param name="infSeg">infSeg (required).</param>
        /// <param name="nApol">Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC). (required).</param>
        /// <param name="nAver">Número da Averbação.  Não é obrigatório, pois muitas averbações ocorrem aapós a emissão do CT, mensalmente, por exemplo. (required).</param>
        public CteSefazSeg(CteSefazInfSeg infSeg = default(CteSefazInfSeg), string nApol = default(string), string nAver = default(string))
        {
            // to ensure "infSeg" is required (not null)
            if (infSeg == null)
            {
                throw new ArgumentNullException("infSeg is a required property for CteSefazSeg and cannot be null");
            }
            this.infSeg = infSeg;
            // to ensure "nApol" is required (not null)
            if (nApol == null)
            {
                throw new ArgumentNullException("nApol is a required property for CteSefazSeg and cannot be null");
            }
            this.nApol = nApol;
            // to ensure "nAver" is required (not null)
            if (nAver == null)
            {
                throw new ArgumentNullException("nAver is a required property for CteSefazSeg and cannot be null");
            }
            this.nAver = nAver;
        }

        /// <summary>
        /// Gets or Sets infSeg
        /// </summary>
        [DataMember(Name = "infSeg", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazInfSeg infSeg { get; set; }

        /// <summary>
        /// Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC).
        /// </summary>
        /// <value>Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC).</value>
        [DataMember(Name = "nApol", IsRequired = true, EmitDefaultValue = true)]
        public string nApol { get; set; }

        /// <summary>
        /// Número da Averbação.  Não é obrigatório, pois muitas averbações ocorrem aapós a emissão do CT, mensalmente, por exemplo.
        /// </summary>
        /// <value>Número da Averbação.  Não é obrigatório, pois muitas averbações ocorrem aapós a emissão do CT, mensalmente, por exemplo.</value>
        [DataMember(Name = "nAver", IsRequired = true, EmitDefaultValue = true)]
        public string nAver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazSeg {\n");
            sb.Append("  infSeg: ").Append(infSeg).Append("\n");
            sb.Append("  nApol: ").Append(nApol).Append("\n");
            sb.Append("  nAver: ").Append(nAver).Append("\n");
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
            return this.Equals(input as CteSefazSeg);
        }

        /// <summary>
        /// Returns true if CteSefazSeg instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazSeg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazSeg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infSeg == input.infSeg ||
                    (this.infSeg != null &&
                    this.infSeg.Equals(input.infSeg))
                ) && 
                (
                    this.nApol == input.nApol ||
                    (this.nApol != null &&
                    this.nApol.Equals(input.nApol))
                ) && 
                (
                    this.nAver == input.nAver ||
                    (this.nAver != null &&
                    this.nAver.Equals(input.nAver))
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
                if (this.infSeg != null)
                {
                    hashCode = (hashCode * 59) + this.infSeg.GetHashCode();
                }
                if (this.nApol != null)
                {
                    hashCode = (hashCode * 59) + this.nApol.GetHashCode();
                }
                if (this.nAver != null)
                {
                    hashCode = (hashCode * 59) + this.nAver.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // nApol (string) maxLength
            if (this.nApol != null && this.nApol.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nApol, length must be less than 20.", new [] { "nApol" });
            }

            // nApol (string) minLength
            if (this.nApol != null && this.nApol.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nApol, length must be greater than 1.", new [] { "nApol" });
            }

            // nAver (string) maxLength
            if (this.nAver != null && this.nAver.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nAver, length must be less than 20.", new [] { "nAver" });
            }

            // nAver (string) minLength
            if (this.nAver != null && this.nAver.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nAver, length must be greater than 1.", new [] { "nAver" });
            }

            yield break;
        }
    }

}
