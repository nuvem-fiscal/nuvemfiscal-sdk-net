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
    /// Identificação da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazEmit")]
    public partial class DceSefazEmit : IEquatable<DceSefazEmit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazEmit" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ do emitente..</param>
        /// <param name="cPF">Número do CPF do emitente.  Informar os zeros não significativos..</param>
        /// <param name="xNome">Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="enderEmit">enderEmit.</param>
        public DceSefazEmit(string cNPJ = default(string), string cPF = default(string), string xNome = default(string), DceSefazEndeEmi enderEmit = default(DceSefazEndeEmi))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.xNome = xNome;
            this.enderEmit = enderEmit;
        }

        /// <summary>
        /// Número do CNPJ do emitente.
        /// </summary>
        /// <value>Número do CNPJ do emitente.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF do emitente.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF do emitente.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xNome", EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Gets or Sets enderEmit
        /// </summary>
        [DataMember(Name = "enderEmit", EmitDefaultValue = false)]
        public DceSefazEndeEmi enderEmit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazEmit {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  enderEmit: ").Append(enderEmit).Append("\n");
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
            return this.Equals(input as DceSefazEmit);
        }

        /// <summary>
        /// Returns true if DceSefazEmit instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazEmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazEmit input)
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
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.enderEmit == input.enderEmit ||
                    (this.enderEmit != null &&
                    this.enderEmit.Equals(input.enderEmit))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.enderEmit != null)
                {
                    hashCode = (hashCode * 59) + this.enderEmit.GetHashCode();
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
            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be less than 60.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be greater than 2.", new [] { "xNome" });
            }

            yield break;
        }
    }

}
