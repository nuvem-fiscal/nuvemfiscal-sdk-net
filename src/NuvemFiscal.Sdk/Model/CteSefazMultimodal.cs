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
    /// CteSefazMultimodal
    /// </summary>
    [DataContract(Name = "CteSefazMultimodal")]
    public partial class CteSefazMultimodal : IEquatable<CteSefazMultimodal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazMultimodal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazMultimodal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazMultimodal" /> class.
        /// </summary>
        /// <param name="cOTM">Número do Certificado do Operador de Transporte Multimodal. (required).</param>
        /// <param name="indNegociavel">Indicador Negociável  Preencher com: 0 - Não Negociável; 1 - Negociável. (required).</param>
        /// <param name="seg">seg.</param>
        public CteSefazMultimodal(string cOTM = default(string), int indNegociavel = default(int), CteSefazSeg seg = default(CteSefazSeg))
        {
            // to ensure "cOTM" is required (not null)
            if (cOTM == null)
            {
                throw new ArgumentNullException("cOTM is a required property for CteSefazMultimodal and cannot be null");
            }
            this.COTM = cOTM;
            this.indNegociavel = indNegociavel;
            this.seg = seg;
        }

        /// <summary>
        /// Número do Certificado do Operador de Transporte Multimodal.
        /// </summary>
        /// <value>Número do Certificado do Operador de Transporte Multimodal.</value>
        [DataMember(Name = "COTM", IsRequired = true, EmitDefaultValue = false)]
        public string COTM { get; set; }

        /// <summary>
        /// Indicador Negociável  Preencher com: 0 - Não Negociável; 1 - Negociável.
        /// </summary>
        /// <value>Indicador Negociável  Preencher com: 0 - Não Negociável; 1 - Negociável.</value>
        [DataMember(Name = "indNegociavel", IsRequired = true, EmitDefaultValue = false)]
        public int indNegociavel { get; set; }

        /// <summary>
        /// Gets or Sets seg
        /// </summary>
        [DataMember(Name = "seg", EmitDefaultValue = false)]
        public CteSefazSeg seg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazMultimodal {\n");
            sb.Append("  COTM: ").Append(COTM).Append("\n");
            sb.Append("  indNegociavel: ").Append(indNegociavel).Append("\n");
            sb.Append("  seg: ").Append(seg).Append("\n");
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
            return this.Equals(input as CteSefazMultimodal);
        }

        /// <summary>
        /// Returns true if CteSefazMultimodal instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazMultimodal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazMultimodal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.COTM == input.COTM ||
                    (this.COTM != null &&
                    this.COTM.Equals(input.COTM))
                ) && 
                (
                    this.indNegociavel == input.indNegociavel ||
                    this.indNegociavel.Equals(input.indNegociavel)
                ) && 
                (
                    this.seg == input.seg ||
                    (this.seg != null &&
                    this.seg.Equals(input.seg))
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
                if (this.COTM != null)
                {
                    hashCode = (hashCode * 59) + this.COTM.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.indNegociavel.GetHashCode();
                if (this.seg != null)
                {
                    hashCode = (hashCode * 59) + this.seg.GetHashCode();
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
