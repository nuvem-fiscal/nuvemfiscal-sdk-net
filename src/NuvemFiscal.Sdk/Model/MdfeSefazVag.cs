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
    /// informações dos Vagões.
    /// </summary>
    [DataContract(Name = "MdfeSefazVag")]
    public partial class MdfeSefazVag : IEquatable<MdfeSefazVag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazVag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazVag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazVag" /> class.
        /// </summary>
        /// <param name="pesoBC">Peso Base de Cálculo de Frete em Toneladas. (required).</param>
        /// <param name="pesoR">Peso Real em Toneladas. (required).</param>
        /// <param name="tpVag">Tipo de Vagão..</param>
        /// <param name="serie">Serie de Identificação do vagão. (required).</param>
        /// <param name="nVag">Número de Identificação do vagão. (required).</param>
        /// <param name="nSeq">Sequencia do vagão na composição..</param>
        /// <param name="tU">Tonelada Útil.  Unidade de peso referente à carga útil (apenas o peso da carga transportada), expressa em toneladas. (required).</param>
        public MdfeSefazVag(decimal pesoBC = default(decimal), decimal pesoR = default(decimal), string tpVag = default(string), string serie = default(string), int nVag = default(int), int nSeq = default(int), decimal tU = default(decimal))
        {
            this.pesoBC = pesoBC;
            this.pesoR = pesoR;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for MdfeSefazVag and cannot be null");
            }
            this.serie = serie;
            this.nVag = nVag;
            this.TU = tU;
            this.tpVag = tpVag;
            this.nSeq = nSeq;
        }

        /// <summary>
        /// Peso Base de Cálculo de Frete em Toneladas.
        /// </summary>
        /// <value>Peso Base de Cálculo de Frete em Toneladas.</value>
        [DataMember(Name = "pesoBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal pesoBC { get; set; }

        /// <summary>
        /// Peso Real em Toneladas.
        /// </summary>
        /// <value>Peso Real em Toneladas.</value>
        [DataMember(Name = "pesoR", IsRequired = true, EmitDefaultValue = true)]
        public decimal pesoR { get; set; }

        /// <summary>
        /// Tipo de Vagão.
        /// </summary>
        /// <value>Tipo de Vagão.</value>
        [DataMember(Name = "tpVag", EmitDefaultValue = false)]
        public string tpVag { get; set; }

        /// <summary>
        /// Serie de Identificação do vagão.
        /// </summary>
        /// <value>Serie de Identificação do vagão.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número de Identificação do vagão.
        /// </summary>
        /// <value>Número de Identificação do vagão.</value>
        [DataMember(Name = "nVag", IsRequired = true, EmitDefaultValue = true)]
        public int nVag { get; set; }

        /// <summary>
        /// Sequencia do vagão na composição.
        /// </summary>
        /// <value>Sequencia do vagão na composição.</value>
        [DataMember(Name = "nSeq", EmitDefaultValue = false)]
        public int nSeq { get; set; }

        /// <summary>
        /// Tonelada Útil.  Unidade de peso referente à carga útil (apenas o peso da carga transportada), expressa em toneladas.
        /// </summary>
        /// <value>Tonelada Útil.  Unidade de peso referente à carga útil (apenas o peso da carga transportada), expressa em toneladas.</value>
        [DataMember(Name = "TU", IsRequired = true, EmitDefaultValue = true)]
        public decimal TU { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazVag {\n");
            sb.Append("  pesoBC: ").Append(pesoBC).Append("\n");
            sb.Append("  pesoR: ").Append(pesoR).Append("\n");
            sb.Append("  tpVag: ").Append(tpVag).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nVag: ").Append(nVag).Append("\n");
            sb.Append("  nSeq: ").Append(nSeq).Append("\n");
            sb.Append("  TU: ").Append(TU).Append("\n");
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
            return this.Equals(input as MdfeSefazVag);
        }

        /// <summary>
        /// Returns true if MdfeSefazVag instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazVag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazVag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pesoBC == input.pesoBC ||
                    this.pesoBC.Equals(input.pesoBC)
                ) && 
                (
                    this.pesoR == input.pesoR ||
                    this.pesoR.Equals(input.pesoR)
                ) && 
                (
                    this.tpVag == input.tpVag ||
                    (this.tpVag != null &&
                    this.tpVag.Equals(input.tpVag))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nVag == input.nVag ||
                    this.nVag.Equals(input.nVag)
                ) && 
                (
                    this.nSeq == input.nSeq ||
                    this.nSeq.Equals(input.nSeq)
                ) && 
                (
                    this.TU == input.TU ||
                    this.TU.Equals(input.TU)
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
                hashCode = (hashCode * 59) + this.pesoBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pesoR.GetHashCode();
                if (this.tpVag != null)
                {
                    hashCode = (hashCode * 59) + this.tpVag.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.nVag.GetHashCode();
                hashCode = (hashCode * 59) + this.nSeq.GetHashCode();
                hashCode = (hashCode * 59) + this.TU.GetHashCode();
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
