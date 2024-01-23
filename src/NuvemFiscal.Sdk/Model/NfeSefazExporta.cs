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
    /// Informações de exportação.
    /// </summary>
    [DataContract(Name = "NfeSefazExporta")]
    public partial class NfeSefazExporta : IEquatable<NfeSefazExporta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazExporta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazExporta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazExporta" /> class.
        /// </summary>
        /// <param name="uFSaidaPais">Sigla da UF de Embarque ou de transposição de fronteira. (required).</param>
        /// <param name="xLocExporta">Local de Embarque ou de transposição de fronteira. (required).</param>
        /// <param name="xLocDespacho">Descrição do local de despacho..</param>
        public NfeSefazExporta(string uFSaidaPais = default(string), string xLocExporta = default(string), string xLocDespacho = default(string))
        {
            // to ensure "uFSaidaPais" is required (not null)
            if (uFSaidaPais == null)
            {
                throw new ArgumentNullException("uFSaidaPais is a required property for NfeSefazExporta and cannot be null");
            }
            this.UFSaidaPais = uFSaidaPais;
            // to ensure "xLocExporta" is required (not null)
            if (xLocExporta == null)
            {
                throw new ArgumentNullException("xLocExporta is a required property for NfeSefazExporta and cannot be null");
            }
            this.xLocExporta = xLocExporta;
            this.xLocDespacho = xLocDespacho;
        }

        /// <summary>
        /// Sigla da UF de Embarque ou de transposição de fronteira.
        /// </summary>
        /// <value>Sigla da UF de Embarque ou de transposição de fronteira.</value>
        [DataMember(Name = "UFSaidaPais", IsRequired = true, EmitDefaultValue = true)]
        public string UFSaidaPais { get; set; }

        /// <summary>
        /// Local de Embarque ou de transposição de fronteira.
        /// </summary>
        /// <value>Local de Embarque ou de transposição de fronteira.</value>
        [DataMember(Name = "xLocExporta", IsRequired = true, EmitDefaultValue = true)]
        public string xLocExporta { get; set; }

        /// <summary>
        /// Descrição do local de despacho.
        /// </summary>
        /// <value>Descrição do local de despacho.</value>
        [DataMember(Name = "xLocDespacho", EmitDefaultValue = true)]
        public string xLocDespacho { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazExporta {\n");
            sb.Append("  UFSaidaPais: ").Append(UFSaidaPais).Append("\n");
            sb.Append("  xLocExporta: ").Append(xLocExporta).Append("\n");
            sb.Append("  xLocDespacho: ").Append(xLocDespacho).Append("\n");
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
            return this.Equals(input as NfeSefazExporta);
        }

        /// <summary>
        /// Returns true if NfeSefazExporta instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazExporta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazExporta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UFSaidaPais == input.UFSaidaPais ||
                    (this.UFSaidaPais != null &&
                    this.UFSaidaPais.Equals(input.UFSaidaPais))
                ) && 
                (
                    this.xLocExporta == input.xLocExporta ||
                    (this.xLocExporta != null &&
                    this.xLocExporta.Equals(input.xLocExporta))
                ) && 
                (
                    this.xLocDespacho == input.xLocDespacho ||
                    (this.xLocDespacho != null &&
                    this.xLocDespacho.Equals(input.xLocDespacho))
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
                if (this.UFSaidaPais != null)
                {
                    hashCode = (hashCode * 59) + this.UFSaidaPais.GetHashCode();
                }
                if (this.xLocExporta != null)
                {
                    hashCode = (hashCode * 59) + this.xLocExporta.GetHashCode();
                }
                if (this.xLocDespacho != null)
                {
                    hashCode = (hashCode * 59) + this.xLocDespacho.GetHashCode();
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
            // xLocExporta (string) maxLength
            if (this.xLocExporta != null && this.xLocExporta.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLocExporta, length must be less than 60.", new [] { "xLocExporta" });
            }

            // xLocExporta (string) minLength
            if (this.xLocExporta != null && this.xLocExporta.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLocExporta, length must be greater than 1.", new [] { "xLocExporta" });
            }

            // xLocDespacho (string) maxLength
            if (this.xLocDespacho != null && this.xLocDespacho.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLocDespacho, length must be less than 60.", new [] { "xLocDespacho" });
            }

            // xLocDespacho (string) minLength
            if (this.xLocDespacho != null && this.xLocDespacho.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLocDespacho, length must be greater than 1.", new [] { "xLocDespacho" });
            }

            yield break;
        }
    }

}
