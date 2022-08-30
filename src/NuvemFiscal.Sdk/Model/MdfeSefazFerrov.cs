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
    /// MdfeSefazFerrov
    /// </summary>
    [DataContract(Name = "MdfeSefazFerrov")]
    public partial class MdfeSefazFerrov : IEquatable<MdfeSefazFerrov>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazFerrov" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazFerrov() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazFerrov" /> class.
        /// </summary>
        /// <param name="trem">trem (required).</param>
        /// <param name="vag">informações dos Vagões. (required).</param>
        public MdfeSefazFerrov(MdfeSefazTrem trem = default(MdfeSefazTrem), List<MdfeSefazVag> vag = default(List<MdfeSefazVag>))
        {
            // to ensure "trem" is required (not null)
            if (trem == null)
            {
                throw new ArgumentNullException("trem is a required property for MdfeSefazFerrov and cannot be null");
            }
            this.trem = trem;
            // to ensure "vag" is required (not null)
            if (vag == null)
            {
                throw new ArgumentNullException("vag is a required property for MdfeSefazFerrov and cannot be null");
            }
            this.vag = vag;
        }

        /// <summary>
        /// Gets or Sets trem
        /// </summary>
        [DataMember(Name = "trem", IsRequired = true, EmitDefaultValue = false)]
        public MdfeSefazTrem trem { get; set; }

        /// <summary>
        /// informações dos Vagões.
        /// </summary>
        /// <value>informações dos Vagões.</value>
        [DataMember(Name = "vag", IsRequired = true, EmitDefaultValue = false)]
        public List<MdfeSefazVag> vag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazFerrov {\n");
            sb.Append("  trem: ").Append(trem).Append("\n");
            sb.Append("  vag: ").Append(vag).Append("\n");
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
            return this.Equals(input as MdfeSefazFerrov);
        }

        /// <summary>
        /// Returns true if MdfeSefazFerrov instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazFerrov to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazFerrov input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.trem == input.trem ||
                    (this.trem != null &&
                    this.trem.Equals(input.trem))
                ) && 
                (
                    this.vag == input.vag ||
                    this.vag != null &&
                    input.vag != null &&
                    this.vag.SequenceEqual(input.vag)
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
                if (this.trem != null)
                {
                    hashCode = (hashCode * 59) + this.trem.GetHashCode();
                }
                if (this.vag != null)
                {
                    hashCode = (hashCode * 59) + this.vag.GetHashCode();
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
