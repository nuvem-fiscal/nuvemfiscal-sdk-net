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
    /// Nota Fiscal Eletronica.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfNFe")]
    public partial class MdfeSefazInfNFe : IEquatable<MdfeSefazInfNFe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfNFe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfNFe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfNFe" /> class.
        /// </summary>
        /// <param name="chNFe">Nota Fiscal Eletrônica. (required).</param>
        /// <param name="segCodBarra">Segundo código de barras..</param>
        /// <param name="indReentrega">Indicador de Reentrega..</param>
        /// <param name="infUnidTransp">infUnidTransp.</param>
        /// <param name="peri">peri.</param>
        public MdfeSefazInfNFe(string chNFe = default(string), string segCodBarra = default(string), int? indReentrega = default(int?), List<MdfeSefazUnidadeTransp> infUnidTransp = default(List<MdfeSefazUnidadeTransp>), List<MdfeSefazInfNFePeri> peri = default(List<MdfeSefazInfNFePeri>))
        {
            // to ensure "chNFe" is required (not null)
            if (chNFe == null)
            {
                throw new ArgumentNullException("chNFe is a required property for MdfeSefazInfNFe and cannot be null");
            }
            this.chNFe = chNFe;
            this.SegCodBarra = segCodBarra;
            this.indReentrega = indReentrega;
            this.infUnidTransp = infUnidTransp;
            this.peri = peri;
        }

        /// <summary>
        /// Nota Fiscal Eletrônica.
        /// </summary>
        /// <value>Nota Fiscal Eletrônica.</value>
        [DataMember(Name = "chNFe", IsRequired = true, EmitDefaultValue = true)]
        public string chNFe { get; set; }

        /// <summary>
        /// Segundo código de barras.
        /// </summary>
        /// <value>Segundo código de barras.</value>
        [DataMember(Name = "SegCodBarra", EmitDefaultValue = true)]
        public string SegCodBarra { get; set; }

        /// <summary>
        /// Indicador de Reentrega.
        /// </summary>
        /// <value>Indicador de Reentrega.</value>
        [DataMember(Name = "indReentrega", EmitDefaultValue = true)]
        public int? indReentrega { get; set; }

        /// <summary>
        /// Gets or Sets infUnidTransp
        /// </summary>
        [DataMember(Name = "infUnidTransp", EmitDefaultValue = false)]
        public List<MdfeSefazUnidadeTransp> infUnidTransp { get; set; }

        /// <summary>
        /// Gets or Sets peri
        /// </summary>
        [DataMember(Name = "peri", EmitDefaultValue = false)]
        public List<MdfeSefazInfNFePeri> peri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfNFe {\n");
            sb.Append("  chNFe: ").Append(chNFe).Append("\n");
            sb.Append("  SegCodBarra: ").Append(SegCodBarra).Append("\n");
            sb.Append("  indReentrega: ").Append(indReentrega).Append("\n");
            sb.Append("  infUnidTransp: ").Append(infUnidTransp).Append("\n");
            sb.Append("  peri: ").Append(peri).Append("\n");
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
            return this.Equals(input as MdfeSefazInfNFe);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfNFe instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfNFe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfNFe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chNFe == input.chNFe ||
                    (this.chNFe != null &&
                    this.chNFe.Equals(input.chNFe))
                ) && 
                (
                    this.SegCodBarra == input.SegCodBarra ||
                    (this.SegCodBarra != null &&
                    this.SegCodBarra.Equals(input.SegCodBarra))
                ) && 
                (
                    this.indReentrega == input.indReentrega ||
                    (this.indReentrega != null &&
                    this.indReentrega.Equals(input.indReentrega))
                ) && 
                (
                    this.infUnidTransp == input.infUnidTransp ||
                    this.infUnidTransp != null &&
                    input.infUnidTransp != null &&
                    this.infUnidTransp.SequenceEqual(input.infUnidTransp)
                ) && 
                (
                    this.peri == input.peri ||
                    this.peri != null &&
                    input.peri != null &&
                    this.peri.SequenceEqual(input.peri)
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
                if (this.chNFe != null)
                {
                    hashCode = (hashCode * 59) + this.chNFe.GetHashCode();
                }
                if (this.SegCodBarra != null)
                {
                    hashCode = (hashCode * 59) + this.SegCodBarra.GetHashCode();
                }
                if (this.indReentrega != null)
                {
                    hashCode = (hashCode * 59) + this.indReentrega.GetHashCode();
                }
                if (this.infUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidTransp.GetHashCode();
                }
                if (this.peri != null)
                {
                    hashCode = (hashCode * 59) + this.peri.GetHashCode();
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
            // chNFe (string) maxLength
            if (this.chNFe != null && this.chNFe.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chNFe, length must be less than 44.", new [] { "chNFe" });
            }

            yield break;
        }
    }

}
