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
    /// Informações de Seguro da Carga.
    /// </summary>
    [DataContract(Name = "CteOsSefazSegOS")]
    public partial class CteOsSefazSegOS : IEquatable<CteOsSefazSegOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazSegOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazSegOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazSegOS" /> class.
        /// </summary>
        /// <param name="respSeg">Responsável pelo seguro.  Preencher com:  * 4 - Emitente do CT-e  * 5 - Tomador de Serviço (required).</param>
        /// <param name="xSeg">Nome da Seguradora..</param>
        /// <param name="nApol">Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC)..</param>
        public CteOsSefazSegOS(int? respSeg = default(int?), string xSeg = default(string), string nApol = default(string))
        {
            // to ensure "respSeg" is required (not null)
            if (respSeg == null)
            {
                throw new ArgumentNullException("respSeg is a required property for CteOsSefazSegOS and cannot be null");
            }
            this.respSeg = respSeg;
            this.xSeg = xSeg;
            this.nApol = nApol;
        }

        /// <summary>
        /// Responsável pelo seguro.  Preencher com:  * 4 - Emitente do CT-e  * 5 - Tomador de Serviço
        /// </summary>
        /// <value>Responsável pelo seguro.  Preencher com:  * 4 - Emitente do CT-e  * 5 - Tomador de Serviço</value>
        [DataMember(Name = "respSeg", IsRequired = true, EmitDefaultValue = true)]
        public int? respSeg { get; set; }

        /// <summary>
        /// Nome da Seguradora.
        /// </summary>
        /// <value>Nome da Seguradora.</value>
        [DataMember(Name = "xSeg", EmitDefaultValue = true)]
        public string xSeg { get; set; }

        /// <summary>
        /// Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC).
        /// </summary>
        /// <value>Número da Apólice.  Obrigatório pela lei 11.442/07 (RCTRC).</value>
        [DataMember(Name = "nApol", EmitDefaultValue = true)]
        public string nApol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazSegOS {\n");
            sb.Append("  respSeg: ").Append(respSeg).Append("\n");
            sb.Append("  xSeg: ").Append(xSeg).Append("\n");
            sb.Append("  nApol: ").Append(nApol).Append("\n");
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
            return this.Equals(input as CteOsSefazSegOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazSegOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazSegOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazSegOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.respSeg == input.respSeg ||
                    (this.respSeg != null &&
                    this.respSeg.Equals(input.respSeg))
                ) && 
                (
                    this.xSeg == input.xSeg ||
                    (this.xSeg != null &&
                    this.xSeg.Equals(input.xSeg))
                ) && 
                (
                    this.nApol == input.nApol ||
                    (this.nApol != null &&
                    this.nApol.Equals(input.nApol))
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
                if (this.respSeg != null)
                {
                    hashCode = (hashCode * 59) + this.respSeg.GetHashCode();
                }
                if (this.xSeg != null)
                {
                    hashCode = (hashCode * 59) + this.xSeg.GetHashCode();
                }
                if (this.nApol != null)
                {
                    hashCode = (hashCode * 59) + this.nApol.GetHashCode();
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
            // xSeg (string) maxLength
            if (this.xSeg != null && this.xSeg.Length > 30)
            {
                yield return new ValidationResult("Invalid value for xSeg, length must be less than 30.", new [] { "xSeg" });
            }

            // xSeg (string) minLength
            if (this.xSeg != null && this.xSeg.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xSeg, length must be greater than 1.", new [] { "xSeg" });
            }

            // nApol (string) maxLength
            if (this.nApol != null && this.nApol.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nApol, length must be less than 20.", new [] { "nApol" });
            }

            // nApol (string) minLength
            if (this.nApol != null && this.nApol.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nApol, length must be greater than 1.", new [] { "nApol" });
            }

            yield break;
        }
    }

}
