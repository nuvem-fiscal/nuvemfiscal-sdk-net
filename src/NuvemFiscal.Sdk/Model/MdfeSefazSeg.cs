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
    /// Informações de Seguro da Carga.
    /// </summary>
    [DataContract(Name = "MdfeSefazSeg")]
    public partial class MdfeSefazSeg : IEquatable<MdfeSefazSeg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazSeg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazSeg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazSeg" /> class.
        /// </summary>
        /// <param name="infResp">infResp (required).</param>
        /// <param name="infSeg">infSeg.</param>
        /// <param name="nApol">Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC)..</param>
        /// <param name="nAver">Número da Averbação.  Informar as averbações do seguro..</param>
        public MdfeSefazSeg(MdfeSefazInfResp infResp = default(MdfeSefazInfResp), MdfeSefazInfSeg infSeg = default(MdfeSefazInfSeg), string nApol = default(string), List<string> nAver = default(List<string>))
        {
            // to ensure "infResp" is required (not null)
            if (infResp == null)
            {
                throw new ArgumentNullException("infResp is a required property for MdfeSefazSeg and cannot be null");
            }
            this.infResp = infResp;
            this.infSeg = infSeg;
            this.nApol = nApol;
            this.nAver = nAver;
        }

        /// <summary>
        /// Gets or Sets infResp
        /// </summary>
        [DataMember(Name = "infResp", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazInfResp infResp { get; set; }

        /// <summary>
        /// Gets or Sets infSeg
        /// </summary>
        [DataMember(Name = "infSeg", EmitDefaultValue = false)]
        public MdfeSefazInfSeg infSeg { get; set; }

        /// <summary>
        /// Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC).
        /// </summary>
        /// <value>Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC).</value>
        [DataMember(Name = "nApol", EmitDefaultValue = true)]
        public string nApol { get; set; }

        /// <summary>
        /// Número da Averbação.  Informar as averbações do seguro.
        /// </summary>
        /// <value>Número da Averbação.  Informar as averbações do seguro.</value>
        [DataMember(Name = "nAver", EmitDefaultValue = false)]
        public List<string> nAver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazSeg {\n");
            sb.Append("  infResp: ").Append(infResp).Append("\n");
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
            return this.Equals(input as MdfeSefazSeg);
        }

        /// <summary>
        /// Returns true if MdfeSefazSeg instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazSeg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazSeg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infResp == input.infResp ||
                    (this.infResp != null &&
                    this.infResp.Equals(input.infResp))
                ) && 
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
                    this.nAver != null &&
                    input.nAver != null &&
                    this.nAver.SequenceEqual(input.nAver)
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
                if (this.infResp != null)
                {
                    hashCode = (hashCode * 59) + this.infResp.GetHashCode();
                }
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // nApol (string) maxLength
            if (this.nApol != null && this.nApol.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nApol, length must be less than 20.", new [] { "nApol" });
            }

            // nApol (string) minLength
            if (this.nApol != null && this.nApol.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nApol, length must be greater than 1.", new [] { "nApol" });
            }

            yield break;
        }
    }

}
