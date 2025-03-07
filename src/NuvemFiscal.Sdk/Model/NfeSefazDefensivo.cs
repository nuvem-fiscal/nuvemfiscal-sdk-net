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
    /// Defensivo Agrícola / Agrotóxico.
    /// </summary>
    [DataContract(Name = "NfeSefazDefensivo")]
    public partial class NfeSefazDefensivo : IEquatable<NfeSefazDefensivo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDefensivo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDefensivo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDefensivo" /> class.
        /// </summary>
        /// <param name="nReceituario">Número do Receituário ou Receita do Defensivo / Agrotóxico. (required).</param>
        /// <param name="cPFRespTec">CPF do Responsável Técnico pelo receituário. (required).</param>
        public NfeSefazDefensivo(string nReceituario = default(string), string cPFRespTec = default(string))
        {
            // to ensure "nReceituario" is required (not null)
            if (nReceituario == null)
            {
                throw new ArgumentNullException("nReceituario is a required property for NfeSefazDefensivo and cannot be null");
            }
            this.nReceituario = nReceituario;
            // to ensure "cPFRespTec" is required (not null)
            if (cPFRespTec == null)
            {
                throw new ArgumentNullException("cPFRespTec is a required property for NfeSefazDefensivo and cannot be null");
            }
            this.CPFRespTec = cPFRespTec;
        }

        /// <summary>
        /// Número do Receituário ou Receita do Defensivo / Agrotóxico.
        /// </summary>
        /// <value>Número do Receituário ou Receita do Defensivo / Agrotóxico.</value>
        [DataMember(Name = "nReceituario", IsRequired = true, EmitDefaultValue = true)]
        public string nReceituario { get; set; }

        /// <summary>
        /// CPF do Responsável Técnico pelo receituário.
        /// </summary>
        /// <value>CPF do Responsável Técnico pelo receituário.</value>
        [DataMember(Name = "CPFRespTec", IsRequired = true, EmitDefaultValue = true)]
        public string CPFRespTec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDefensivo {\n");
            sb.Append("  nReceituario: ").Append(nReceituario).Append("\n");
            sb.Append("  CPFRespTec: ").Append(CPFRespTec).Append("\n");
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
            return this.Equals(input as NfeSefazDefensivo);
        }

        /// <summary>
        /// Returns true if NfeSefazDefensivo instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDefensivo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDefensivo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nReceituario == input.nReceituario ||
                    (this.nReceituario != null &&
                    this.nReceituario.Equals(input.nReceituario))
                ) && 
                (
                    this.CPFRespTec == input.CPFRespTec ||
                    (this.CPFRespTec != null &&
                    this.CPFRespTec.Equals(input.CPFRespTec))
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
                if (this.nReceituario != null)
                {
                    hashCode = (hashCode * 59) + this.nReceituario.GetHashCode();
                }
                if (this.CPFRespTec != null)
                {
                    hashCode = (hashCode * 59) + this.CPFRespTec.GetHashCode();
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
            // nReceituario (string) maxLength
            if (this.nReceituario != null && this.nReceituario.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nReceituario, length must be less than 20.", new [] { "nReceituario" });
            }

            // nReceituario (string) minLength
            if (this.nReceituario != null && this.nReceituario.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nReceituario, length must be greater than 1.", new [] { "nReceituario" });
            }

            // CPFRespTec (string) maxLength
            if (this.CPFRespTec != null && this.CPFRespTec.Length > 11)
            {
                yield return new ValidationResult("Invalid value for CPFRespTec, length must be less than 11.", new [] { "CPFRespTec" });
            }

            yield break;
        }
    }

}
