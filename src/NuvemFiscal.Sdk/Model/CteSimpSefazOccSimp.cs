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
    /// Ordens de Coleta associados.
    /// </summary>
    [DataContract(Name = "CteSimpSefazOccSimp")]
    public partial class CteSimpSefazOccSimp : IEquatable<CteSimpSefazOccSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazOccSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazOccSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazOccSimp" /> class.
        /// </summary>
        /// <param name="serie">Série da OCC..</param>
        /// <param name="nOcc">Número da Ordem de coleta. (required).</param>
        /// <param name="dEmi">Data de emissão da ordem de coleta.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="emiOcc">emiOcc.</param>
        public CteSimpSefazOccSimp(string serie = default(string), int? nOcc = default(int?), DateTime? dEmi = default(DateTime?), CteSimpSefazEmiOccSimp emiOcc = default(CteSimpSefazEmiOccSimp))
        {
            // to ensure "nOcc" is required (not null)
            if (nOcc == null)
            {
                throw new ArgumentNullException("nOcc is a required property for CteSimpSefazOccSimp and cannot be null");
            }
            this.nOcc = nOcc;
            // to ensure "dEmi" is required (not null)
            if (dEmi == null)
            {
                throw new ArgumentNullException("dEmi is a required property for CteSimpSefazOccSimp and cannot be null");
            }
            this.dEmi = dEmi;
            this.serie = serie;
            this.emiOcc = emiOcc;
        }

        /// <summary>
        /// Série da OCC.
        /// </summary>
        /// <value>Série da OCC.</value>
        [DataMember(Name = "serie", EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número da Ordem de coleta.
        /// </summary>
        /// <value>Número da Ordem de coleta.</value>
        [DataMember(Name = "nOcc", IsRequired = true, EmitDefaultValue = true)]
        public int? nOcc { get; set; }

        /// <summary>
        /// Data de emissão da ordem de coleta.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de emissão da ordem de coleta.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dEmi", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dEmi { get; set; }

        /// <summary>
        /// Gets or Sets emiOcc
        /// </summary>
        [DataMember(Name = "emiOcc", EmitDefaultValue = false)]
        public CteSimpSefazEmiOccSimp emiOcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazOccSimp {\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nOcc: ").Append(nOcc).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
            sb.Append("  emiOcc: ").Append(emiOcc).Append("\n");
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
            return this.Equals(input as CteSimpSefazOccSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazOccSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazOccSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazOccSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nOcc == input.nOcc ||
                    (this.nOcc != null &&
                    this.nOcc.Equals(input.nOcc))
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
                ) && 
                (
                    this.emiOcc == input.emiOcc ||
                    (this.emiOcc != null &&
                    this.emiOcc.Equals(input.emiOcc))
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
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nOcc != null)
                {
                    hashCode = (hashCode * 59) + this.nOcc.GetHashCode();
                }
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
                }
                if (this.emiOcc != null)
                {
                    hashCode = (hashCode * 59) + this.emiOcc.GetHashCode();
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

            // nOcc (int?) maximum
            if (this.nOcc > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for nOcc, must be a value less than or equal to 999999.", new [] { "nOcc" });
            }

            // nOcc (int?) minimum
            if (this.nOcc < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nOcc, must be a value greater than or equal to 1.", new [] { "nOcc" });
            }

            yield break;
        }
    }

}
