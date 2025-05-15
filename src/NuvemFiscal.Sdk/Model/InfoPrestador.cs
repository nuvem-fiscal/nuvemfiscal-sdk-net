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
    /// Grupo de informações do DPS relativas ao Prestador de Serviços.
    /// </summary>
    [DataContract(Name = "InfoPrestador")]
    public partial class InfoPrestador : IEquatable<InfoPrestador>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPrestador" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ.  Obrigatório caso o emitente seja pessoa jurídica..</param>
        /// <param name="cPF">Número do CPF.  Obrigatorio caso o emitente seja pessoa física..</param>
        /// <param name="regTrib">regTrib.</param>
        public InfoPrestador(string cNPJ = default(string), string cPF = default(string), RegTrib regTrib = default(RegTrib))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.regTrib = regTrib;
        }

        /// <summary>
        /// Número do CNPJ.  Obrigatório caso o emitente seja pessoa jurídica.
        /// </summary>
        /// <value>Número do CNPJ.  Obrigatório caso o emitente seja pessoa jurídica.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.  Obrigatorio caso o emitente seja pessoa física.
        /// </summary>
        /// <value>Número do CPF.  Obrigatorio caso o emitente seja pessoa física.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Gets or Sets regTrib
        /// </summary>
        [DataMember(Name = "regTrib", EmitDefaultValue = false)]
        public RegTrib regTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPrestador {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  regTrib: ").Append(regTrib).Append("\n");
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
            return this.Equals(input as InfoPrestador);
        }

        /// <summary>
        /// Returns true if InfoPrestador instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPrestador to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPrestador input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.regTrib == input.regTrib ||
                    (this.regTrib != null &&
                    this.regTrib.Equals(input.regTrib))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.regTrib != null)
                {
                    hashCode = (hashCode * 59) + this.regTrib.GetHashCode();
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
            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // CPF (string) maxLength
            if (this.CPF != null && this.CPF.Length > 11)
            {
                yield return new ValidationResult("Invalid value for CPF, length must be less than 11.", new [] { "CPF" });
            }

            yield break;
        }
    }

}
