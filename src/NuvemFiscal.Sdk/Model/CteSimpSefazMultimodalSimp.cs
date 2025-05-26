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
    /// Informações do Multimodal.
    /// </summary>
    [DataContract(Name = "CteSimpSefazMultimodalSimp")]
    public partial class CteSimpSefazMultimodalSimp : IEquatable<CteSimpSefazMultimodalSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazMultimodalSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazMultimodalSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazMultimodalSimp" /> class.
        /// </summary>
        /// <param name="cOTM">Número do Certificado do Operador de Transporte Multimodal. (required).</param>
        /// <param name="indNegociavel">Indicador Negociável  Preencher com: 0 - Não Negociável  * 1 - Negociável (required).</param>
        /// <param name="seg">seg.</param>
        public CteSimpSefazMultimodalSimp(string cOTM = default(string), int? indNegociavel = default(int?), CteSimpSefazSegSimp seg = default(CteSimpSefazSegSimp))
        {
            // to ensure "cOTM" is required (not null)
            if (cOTM == null)
            {
                throw new ArgumentNullException("cOTM is a required property for CteSimpSefazMultimodalSimp and cannot be null");
            }
            this.COTM = cOTM;
            // to ensure "indNegociavel" is required (not null)
            if (indNegociavel == null)
            {
                throw new ArgumentNullException("indNegociavel is a required property for CteSimpSefazMultimodalSimp and cannot be null");
            }
            this.indNegociavel = indNegociavel;
            this.seg = seg;
        }

        /// <summary>
        /// Número do Certificado do Operador de Transporte Multimodal.
        /// </summary>
        /// <value>Número do Certificado do Operador de Transporte Multimodal.</value>
        [DataMember(Name = "COTM", IsRequired = true, EmitDefaultValue = true)]
        public string COTM { get; set; }

        /// <summary>
        /// Indicador Negociável  Preencher com: 0 - Não Negociável  * 1 - Negociável
        /// </summary>
        /// <value>Indicador Negociável  Preencher com: 0 - Não Negociável  * 1 - Negociável</value>
        [DataMember(Name = "indNegociavel", IsRequired = true, EmitDefaultValue = true)]
        public int? indNegociavel { get; set; }

        /// <summary>
        /// Gets or Sets seg
        /// </summary>
        [DataMember(Name = "seg", EmitDefaultValue = false)]
        public CteSimpSefazSegSimp seg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazMultimodalSimp {\n");
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
            return this.Equals(input as CteSimpSefazMultimodalSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazMultimodalSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazMultimodalSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazMultimodalSimp input)
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
                    (this.indNegociavel != null &&
                    this.indNegociavel.Equals(input.indNegociavel))
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
                if (this.indNegociavel != null)
                {
                    hashCode = (hashCode * 59) + this.indNegociavel.GetHashCode();
                }
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // COTM (string) maxLength
            if (this.COTM != null && this.COTM.Length > 20)
            {
                yield return new ValidationResult("Invalid value for COTM, length must be less than 20.", new [] { "COTM" });
            }

            // COTM (string) minLength
            if (this.COTM != null && this.COTM.Length < 1)
            {
                yield return new ValidationResult("Invalid value for COTM, length must be greater than 1.", new [] { "COTM" });
            }

            yield break;
        }
    }

}
