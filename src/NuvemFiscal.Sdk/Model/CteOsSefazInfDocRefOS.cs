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
    /// Informações dos documentos referenciados.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfDocRefOS")]
    public partial class CteOsSefazInfDocRefOS : IEquatable<CteOsSefazInfDocRefOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfDocRefOS" /> class.
        /// </summary>
        /// <param name="nDoc">Número..</param>
        /// <param name="serie">Série..</param>
        /// <param name="subserie">Subsérie..</param>
        /// <param name="dEmi">Data de Emissão.  Formato AAAA-MM-DD..</param>
        /// <param name="vDoc">Valor Transportado..</param>
        /// <param name="chBPe">Chave de acesso do BP-e que possui eventos excesso de bagagem..</param>
        public CteOsSefazInfDocRefOS(string nDoc = default(string), string serie = default(string), string subserie = default(string), DateTime? dEmi = default(DateTime?), decimal? vDoc = default(decimal?), string chBPe = default(string))
        {
            this.nDoc = nDoc;
            this.serie = serie;
            this.subserie = subserie;
            this.dEmi = dEmi;
            this.vDoc = vDoc;
            this.chBPe = chBPe;
        }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "nDoc", EmitDefaultValue = true)]
        public string nDoc { get; set; }

        /// <summary>
        /// Série.
        /// </summary>
        /// <value>Série.</value>
        [DataMember(Name = "serie", EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Subsérie.
        /// </summary>
        /// <value>Subsérie.</value>
        [DataMember(Name = "subserie", EmitDefaultValue = true)]
        public string subserie { get; set; }

        /// <summary>
        /// Data de Emissão.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de Emissão.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dEmi", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dEmi { get; set; }

        /// <summary>
        /// Valor Transportado.
        /// </summary>
        /// <value>Valor Transportado.</value>
        [DataMember(Name = "vDoc", EmitDefaultValue = true)]
        public decimal? vDoc { get; set; }

        /// <summary>
        /// Chave de acesso do BP-e que possui eventos excesso de bagagem.
        /// </summary>
        /// <value>Chave de acesso do BP-e que possui eventos excesso de bagagem.</value>
        [DataMember(Name = "chBPe", EmitDefaultValue = true)]
        public string chBPe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfDocRefOS {\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  subserie: ").Append(subserie).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
            sb.Append("  vDoc: ").Append(vDoc).Append("\n");
            sb.Append("  chBPe: ").Append(chBPe).Append("\n");
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
            return this.Equals(input as CteOsSefazInfDocRefOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfDocRefOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfDocRefOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfDocRefOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nDoc == input.nDoc ||
                    (this.nDoc != null &&
                    this.nDoc.Equals(input.nDoc))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.subserie == input.subserie ||
                    (this.subserie != null &&
                    this.subserie.Equals(input.subserie))
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
                ) && 
                (
                    this.vDoc == input.vDoc ||
                    (this.vDoc != null &&
                    this.vDoc.Equals(input.vDoc))
                ) && 
                (
                    this.chBPe == input.chBPe ||
                    (this.chBPe != null &&
                    this.chBPe.Equals(input.chBPe))
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
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.subserie != null)
                {
                    hashCode = (hashCode * 59) + this.subserie.GetHashCode();
                }
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
                }
                if (this.vDoc != null)
                {
                    hashCode = (hashCode * 59) + this.vDoc.GetHashCode();
                }
                if (this.chBPe != null)
                {
                    hashCode = (hashCode * 59) + this.chBPe.GetHashCode();
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
            // nDoc (string) maxLength
            if (this.nDoc != null && this.nDoc.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nDoc, length must be less than 20.", new [] { "nDoc" });
            }

            // nDoc (string) minLength
            if (this.nDoc != null && this.nDoc.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nDoc, length must be greater than 1.", new [] { "nDoc" });
            }

            // serie (string) maxLength
            if (this.serie != null && this.serie.Length > 3)
            {
                yield return new ValidationResult("Invalid value for serie, length must be less than 3.", new [] { "serie" });
            }

            // serie (string) minLength
            if (this.serie != null && this.serie.Length < 1)
            {
                yield return new ValidationResult("Invalid value for serie, length must be greater than 1.", new [] { "serie" });
            }

            // subserie (string) maxLength
            if (this.subserie != null && this.subserie.Length > 3)
            {
                yield return new ValidationResult("Invalid value for subserie, length must be less than 3.", new [] { "subserie" });
            }

            // subserie (string) minLength
            if (this.subserie != null && this.subserie.Length < 1)
            {
                yield return new ValidationResult("Invalid value for subserie, length must be greater than 1.", new [] { "subserie" });
            }

            // vDoc (decimal?) minimum
            if (this.vDoc < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDoc, must be a value greater than or equal to 0.", new [] { "vDoc" });
            }

            yield break;
        }
    }

}
