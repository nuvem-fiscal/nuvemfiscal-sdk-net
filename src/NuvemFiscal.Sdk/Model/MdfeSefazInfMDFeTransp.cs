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
    /// Manifesto Eletrônico de Documentos Fiscais. Somente para modal Aquaviário (vide regras MOC).
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMDFeTransp")]
    public partial class MdfeSefazInfMDFeTransp : IEquatable<MdfeSefazInfMDFeTransp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFeTransp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfMDFeTransp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFeTransp" /> class.
        /// </summary>
        /// <param name="chMDFe">Manifesto Eletrônico de Documentos Fiscais. (required).</param>
        /// <param name="indReentrega">Indicador de Reentrega..</param>
        /// <param name="infUnidTransp">infUnidTransp.</param>
        /// <param name="peri">peri.</param>
        public MdfeSefazInfMDFeTransp(string chMDFe = default(string), int? indReentrega = default(int?), List<MdfeSefazUnidadeTransp> infUnidTransp = default(List<MdfeSefazUnidadeTransp>), List<MdfeSefazInfMDFeTranspPeri> peri = default(List<MdfeSefazInfMDFeTranspPeri>))
        {
            // to ensure "chMDFe" is required (not null)
            if (chMDFe == null)
            {
                throw new ArgumentNullException("chMDFe is a required property for MdfeSefazInfMDFeTransp and cannot be null");
            }
            this.chMDFe = chMDFe;
            this.indReentrega = indReentrega;
            this.infUnidTransp = infUnidTransp;
            this.peri = peri;
        }

        /// <summary>
        /// Manifesto Eletrônico de Documentos Fiscais.
        /// </summary>
        /// <value>Manifesto Eletrônico de Documentos Fiscais.</value>
        [DataMember(Name = "chMDFe", IsRequired = true, EmitDefaultValue = true)]
        public string chMDFe { get; set; }

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
        public List<MdfeSefazInfMDFeTranspPeri> peri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMDFeTransp {\n");
            sb.Append("  chMDFe: ").Append(chMDFe).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMDFeTransp);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMDFeTransp instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMDFeTransp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMDFeTransp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chMDFe == input.chMDFe ||
                    (this.chMDFe != null &&
                    this.chMDFe.Equals(input.chMDFe))
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
                if (this.chMDFe != null)
                {
                    hashCode = (hashCode * 59) + this.chMDFe.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // chMDFe (string) maxLength
            if (this.chMDFe != null && this.chMDFe.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chMDFe, length must be less than 44.", new [] { "chMDFe" });
            }

            yield break;
        }
    }

}
