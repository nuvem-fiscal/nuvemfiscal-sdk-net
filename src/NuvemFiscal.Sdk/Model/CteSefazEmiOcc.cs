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
    /// CteSefazEmiOcc
    /// </summary>
    [DataContract(Name = "CteSefazEmiOcc")]
    public partial class CteSefazEmiOcc : IEquatable<CteSefazEmiOcc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEmiOcc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazEmiOcc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEmiOcc" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ.  Informar os zeros não significativos. (required).</param>
        /// <param name="cInt">Código interno de uso da transportadora.  Uso intermo das transportadoras..</param>
        /// <param name="iE">Inscrição Estadual. (required).</param>
        /// <param name="uF">Sigla da UF.  Informar EX para operações com o exterior. (required).</param>
        /// <param name="fone">Telefone..</param>
        public CteSefazEmiOcc(string cNPJ = default(string), string cInt = default(string), string iE = default(string), string uF = default(string), string fone = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for CteSefazEmiOcc and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "iE" is required (not null)
            if (iE == null)
            {
                throw new ArgumentNullException("iE is a required property for CteSefazEmiOcc and cannot be null");
            }
            this.IE = iE;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for CteSefazEmiOcc and cannot be null");
            }
            this.UF = uF;
            this.cInt = cInt;
            this.fone = fone;
        }

        /// <summary>
        /// Número do CNPJ.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Código interno de uso da transportadora.  Uso intermo das transportadoras.
        /// </summary>
        /// <value>Código interno de uso da transportadora.  Uso intermo das transportadoras.</value>
        [DataMember(Name = "cInt", EmitDefaultValue = true)]
        public string cInt { get; set; }

        /// <summary>
        /// Inscrição Estadual.
        /// </summary>
        /// <value>Inscrição Estadual.</value>
        [DataMember(Name = "IE", IsRequired = true, EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Sigla da UF.  Informar EX para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF.  Informar EX para operações com o exterior.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        /// <value>Telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazEmiOcc {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  cInt: ").Append(cInt).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
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
            return this.Equals(input as CteSefazEmiOcc);
        }

        /// <summary>
        /// Returns true if CteSefazEmiOcc instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazEmiOcc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazEmiOcc input)
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
                    this.cInt == input.cInt ||
                    (this.cInt != null &&
                    this.cInt.Equals(input.cInt))
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
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
                if (this.cInt != null)
                {
                    hashCode = (hashCode * 59) + this.cInt.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
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
            // cInt (string) maxLength
            if (this.cInt != null && this.cInt.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cInt, length must be less than 10.", new [] { "cInt" });
            }

            // cInt (string) minLength
            if (this.cInt != null && this.cInt.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cInt, length must be greater than 1.", new [] { "cInt" });
            }

            // IE (string) maxLength
            if (this.IE != null && this.IE.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IE, length must be less than 14.", new [] { "IE" });
            }

            yield break;
        }
    }

}
