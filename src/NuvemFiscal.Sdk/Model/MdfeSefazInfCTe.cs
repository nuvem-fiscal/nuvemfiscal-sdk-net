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
    /// Conhecimentos de Tranporte - usar este grupo quando for prestador de serviço de transporte.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfCTe")]
    public partial class MdfeSefazInfCTe : IEquatable<MdfeSefazInfCTe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfCTe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfCTe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfCTe" /> class.
        /// </summary>
        /// <param name="chCTe">Conhecimento Eletrônico - Chave de Acesso. (required).</param>
        /// <param name="segCodBarra">Segundo código de barras..</param>
        /// <param name="indReentrega">Indicador de Reentrega..</param>
        /// <param name="infUnidTransp">infUnidTransp.</param>
        /// <param name="peri">peri.</param>
        /// <param name="infEntregaParcial">infEntregaParcial.</param>
        public MdfeSefazInfCTe(string chCTe = default(string), string segCodBarra = default(string), int? indReentrega = default(int?), List<MdfeSefazUnidadeTransp> infUnidTransp = default(List<MdfeSefazUnidadeTransp>), List<MdfeSefazPeri> peri = default(List<MdfeSefazPeri>), MdfeSefazInfEntregaParcial infEntregaParcial = default(MdfeSefazInfEntregaParcial))
        {
            // to ensure "chCTe" is required (not null)
            if (chCTe == null)
            {
                throw new ArgumentNullException("chCTe is a required property for MdfeSefazInfCTe and cannot be null");
            }
            this.chCTe = chCTe;
            this.SegCodBarra = segCodBarra;
            this.indReentrega = indReentrega;
            this.infUnidTransp = infUnidTransp;
            this.peri = peri;
            this.infEntregaParcial = infEntregaParcial;
        }

        /// <summary>
        /// Conhecimento Eletrônico - Chave de Acesso.
        /// </summary>
        /// <value>Conhecimento Eletrônico - Chave de Acesso.</value>
        [DataMember(Name = "chCTe", IsRequired = true, EmitDefaultValue = true)]
        public string chCTe { get; set; }

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
        public List<MdfeSefazPeri> peri { get; set; }

        /// <summary>
        /// Gets or Sets infEntregaParcial
        /// </summary>
        [DataMember(Name = "infEntregaParcial", EmitDefaultValue = false)]
        public MdfeSefazInfEntregaParcial infEntregaParcial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfCTe {\n");
            sb.Append("  chCTe: ").Append(chCTe).Append("\n");
            sb.Append("  SegCodBarra: ").Append(SegCodBarra).Append("\n");
            sb.Append("  indReentrega: ").Append(indReentrega).Append("\n");
            sb.Append("  infUnidTransp: ").Append(infUnidTransp).Append("\n");
            sb.Append("  peri: ").Append(peri).Append("\n");
            sb.Append("  infEntregaParcial: ").Append(infEntregaParcial).Append("\n");
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
            return this.Equals(input as MdfeSefazInfCTe);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfCTe instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfCTe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfCTe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCTe == input.chCTe ||
                    (this.chCTe != null &&
                    this.chCTe.Equals(input.chCTe))
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
                ) && 
                (
                    this.infEntregaParcial == input.infEntregaParcial ||
                    (this.infEntregaParcial != null &&
                    this.infEntregaParcial.Equals(input.infEntregaParcial))
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
                if (this.chCTe != null)
                {
                    hashCode = (hashCode * 59) + this.chCTe.GetHashCode();
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
                if (this.infEntregaParcial != null)
                {
                    hashCode = (hashCode * 59) + this.infEntregaParcial.GetHashCode();
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
            // chCTe (string) maxLength
            if (this.chCTe != null && this.chCTe.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chCTe, length must be less than 44.", new [] { "chCTe" });
            }

            yield break;
        }
    }

}
