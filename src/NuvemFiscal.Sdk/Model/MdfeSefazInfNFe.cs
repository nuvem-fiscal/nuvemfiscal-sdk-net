/*
 * API Nuvem Fiscal
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
    /// MdfeSefazInfNFe
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
        /// <param name="infUnidTransp">Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas..</param>
        /// <param name="peri">Preenchido quando for  transporte de produtos classificados pela ONU como perigosos..</param>
        public MdfeSefazInfNFe(string chNFe = default(string), string segCodBarra = default(string), int indReentrega = default(int), List<MdfeSefazUnidadeTransp> infUnidTransp = default(List<MdfeSefazUnidadeTransp>), List<MdfeSefazInfNFePeri> peri = default(List<MdfeSefazInfNFePeri>))
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
        [DataMember(Name = "chNFe", IsRequired = true, EmitDefaultValue = false)]
        public string chNFe { get; set; }

        /// <summary>
        /// Segundo código de barras.
        /// </summary>
        /// <value>Segundo código de barras.</value>
        [DataMember(Name = "SegCodBarra", EmitDefaultValue = false)]
        public string SegCodBarra { get; set; }

        /// <summary>
        /// Indicador de Reentrega.
        /// </summary>
        /// <value>Indicador de Reentrega.</value>
        [DataMember(Name = "indReentrega", EmitDefaultValue = false)]
        public int indReentrega { get; set; }

        /// <summary>
        /// Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.
        /// </summary>
        /// <value>Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.</value>
        [DataMember(Name = "infUnidTransp", EmitDefaultValue = false)]
        public List<MdfeSefazUnidadeTransp> infUnidTransp { get; set; }

        /// <summary>
        /// Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.
        /// </summary>
        /// <value>Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.</value>
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
                    this.indReentrega.Equals(input.indReentrega)
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
                hashCode = (hashCode * 59) + this.indReentrega.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}