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
    /// Armamentos.
    /// </summary>
    [DataContract(Name = "NfeSefazArma")]
    public partial class NfeSefazArma : IEquatable<NfeSefazArma>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazArma" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazArma() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazArma" /> class.
        /// </summary>
        /// <param name="tpArma">Indicador do tipo de arma de fogo (0 - Uso permitido; 1 - Uso restrito). (required).</param>
        /// <param name="nSerie">Número de série da arma. (required).</param>
        /// <param name="nCano">Número de série do cano. (required).</param>
        /// <param name="descr">Descrição completa da arma, compreendendo: calibre, marca, capacidade, tipo de funcionamento, comprimento e demais elementos que permitam a sua perfeita identificação. (required).</param>
        public NfeSefazArma(int? tpArma = default(int?), string nSerie = default(string), string nCano = default(string), string descr = default(string))
        {
            // to ensure "tpArma" is required (not null)
            if (tpArma == null)
            {
                throw new ArgumentNullException("tpArma is a required property for NfeSefazArma and cannot be null");
            }
            this.tpArma = tpArma;
            // to ensure "nSerie" is required (not null)
            if (nSerie == null)
            {
                throw new ArgumentNullException("nSerie is a required property for NfeSefazArma and cannot be null");
            }
            this.nSerie = nSerie;
            // to ensure "nCano" is required (not null)
            if (nCano == null)
            {
                throw new ArgumentNullException("nCano is a required property for NfeSefazArma and cannot be null");
            }
            this.nCano = nCano;
            // to ensure "descr" is required (not null)
            if (descr == null)
            {
                throw new ArgumentNullException("descr is a required property for NfeSefazArma and cannot be null");
            }
            this.descr = descr;
        }

        /// <summary>
        /// Indicador do tipo de arma de fogo (0 - Uso permitido; 1 - Uso restrito).
        /// </summary>
        /// <value>Indicador do tipo de arma de fogo (0 - Uso permitido; 1 - Uso restrito).</value>
        [DataMember(Name = "tpArma", IsRequired = true, EmitDefaultValue = true)]
        public int? tpArma { get; set; }

        /// <summary>
        /// Número de série da arma.
        /// </summary>
        /// <value>Número de série da arma.</value>
        [DataMember(Name = "nSerie", IsRequired = true, EmitDefaultValue = true)]
        public string nSerie { get; set; }

        /// <summary>
        /// Número de série do cano.
        /// </summary>
        /// <value>Número de série do cano.</value>
        [DataMember(Name = "nCano", IsRequired = true, EmitDefaultValue = true)]
        public string nCano { get; set; }

        /// <summary>
        /// Descrição completa da arma, compreendendo: calibre, marca, capacidade, tipo de funcionamento, comprimento e demais elementos que permitam a sua perfeita identificação.
        /// </summary>
        /// <value>Descrição completa da arma, compreendendo: calibre, marca, capacidade, tipo de funcionamento, comprimento e demais elementos que permitam a sua perfeita identificação.</value>
        [DataMember(Name = "descr", IsRequired = true, EmitDefaultValue = true)]
        public string descr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazArma {\n");
            sb.Append("  tpArma: ").Append(tpArma).Append("\n");
            sb.Append("  nSerie: ").Append(nSerie).Append("\n");
            sb.Append("  nCano: ").Append(nCano).Append("\n");
            sb.Append("  descr: ").Append(descr).Append("\n");
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
            return this.Equals(input as NfeSefazArma);
        }

        /// <summary>
        /// Returns true if NfeSefazArma instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazArma to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazArma input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpArma == input.tpArma ||
                    (this.tpArma != null &&
                    this.tpArma.Equals(input.tpArma))
                ) && 
                (
                    this.nSerie == input.nSerie ||
                    (this.nSerie != null &&
                    this.nSerie.Equals(input.nSerie))
                ) && 
                (
                    this.nCano == input.nCano ||
                    (this.nCano != null &&
                    this.nCano.Equals(input.nCano))
                ) && 
                (
                    this.descr == input.descr ||
                    (this.descr != null &&
                    this.descr.Equals(input.descr))
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
                if (this.tpArma != null)
                {
                    hashCode = (hashCode * 59) + this.tpArma.GetHashCode();
                }
                if (this.nSerie != null)
                {
                    hashCode = (hashCode * 59) + this.nSerie.GetHashCode();
                }
                if (this.nCano != null)
                {
                    hashCode = (hashCode * 59) + this.nCano.GetHashCode();
                }
                if (this.descr != null)
                {
                    hashCode = (hashCode * 59) + this.descr.GetHashCode();
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
            // nSerie (string) maxLength
            if (this.nSerie != null && this.nSerie.Length > 15)
            {
                yield return new ValidationResult("Invalid value for nSerie, length must be less than 15.", new [] { "nSerie" });
            }

            // nSerie (string) minLength
            if (this.nSerie != null && this.nSerie.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nSerie, length must be greater than 1.", new [] { "nSerie" });
            }

            // nCano (string) maxLength
            if (this.nCano != null && this.nCano.Length > 15)
            {
                yield return new ValidationResult("Invalid value for nCano, length must be less than 15.", new [] { "nCano" });
            }

            // nCano (string) minLength
            if (this.nCano != null && this.nCano.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nCano, length must be greater than 1.", new [] { "nCano" });
            }

            // descr (string) maxLength
            if (this.descr != null && this.descr.Length > 256)
            {
                yield return new ValidationResult("Invalid value for descr, length must be less than 256.", new [] { "descr" });
            }

            // descr (string) minLength
            if (this.descr != null && this.descr.Length < 1)
            {
                yield return new ValidationResult("Invalid value for descr, length must be greater than 1.", new [] { "descr" });
            }

            yield break;
        }
    }

}
