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
    /// Dados do Veículo.
    /// </summary>
    [DataContract(Name = "CteOsSefazVeicOS")]
    public partial class CteOsSefazVeicOS : IEquatable<CteOsSefazVeicOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazVeicOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazVeicOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazVeicOS" /> class.
        /// </summary>
        /// <param name="placa">Placa do veículo. (required).</param>
        /// <param name="rENAVAM">RENAVAM do veículo..</param>
        /// <param name="prop">prop.</param>
        /// <param name="uF">UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo..</param>
        public CteOsSefazVeicOS(string placa = default(string), string rENAVAM = default(string), CteOsSefazPropOS prop = default(CteOsSefazPropOS), string uF = default(string))
        {
            // to ensure "placa" is required (not null)
            if (placa == null)
            {
                throw new ArgumentNullException("placa is a required property for CteOsSefazVeicOS and cannot be null");
            }
            this.placa = placa;
            this.RENAVAM = rENAVAM;
            this.prop = prop;
            this.UF = uF;
        }

        /// <summary>
        /// Placa do veículo.
        /// </summary>
        /// <value>Placa do veículo.</value>
        [DataMember(Name = "placa", IsRequired = true, EmitDefaultValue = true)]
        public string placa { get; set; }

        /// <summary>
        /// RENAVAM do veículo.
        /// </summary>
        /// <value>RENAVAM do veículo.</value>
        [DataMember(Name = "RENAVAM", EmitDefaultValue = true)]
        public string RENAVAM { get; set; }

        /// <summary>
        /// Gets or Sets prop
        /// </summary>
        [DataMember(Name = "prop", EmitDefaultValue = false)]
        public CteOsSefazPropOS prop { get; set; }

        /// <summary>
        /// UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo.
        /// </summary>
        /// <value>UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo.</value>
        [DataMember(Name = "UF", EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazVeicOS {\n");
            sb.Append("  placa: ").Append(placa).Append("\n");
            sb.Append("  RENAVAM: ").Append(RENAVAM).Append("\n");
            sb.Append("  prop: ").Append(prop).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
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
            return this.Equals(input as CteOsSefazVeicOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazVeicOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazVeicOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazVeicOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.placa == input.placa ||
                    (this.placa != null &&
                    this.placa.Equals(input.placa))
                ) && 
                (
                    this.RENAVAM == input.RENAVAM ||
                    (this.RENAVAM != null &&
                    this.RENAVAM.Equals(input.RENAVAM))
                ) && 
                (
                    this.prop == input.prop ||
                    (this.prop != null &&
                    this.prop.Equals(input.prop))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
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
                if (this.placa != null)
                {
                    hashCode = (hashCode * 59) + this.placa.GetHashCode();
                }
                if (this.RENAVAM != null)
                {
                    hashCode = (hashCode * 59) + this.RENAVAM.GetHashCode();
                }
                if (this.prop != null)
                {
                    hashCode = (hashCode * 59) + this.prop.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
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
            // RENAVAM (string) maxLength
            if (this.RENAVAM != null && this.RENAVAM.Length > 11)
            {
                yield return new ValidationResult("Invalid value for RENAVAM, length must be less than 11.", new [] { "RENAVAM" });
            }

            // RENAVAM (string) minLength
            if (this.RENAVAM != null && this.RENAVAM.Length < 9)
            {
                yield return new ValidationResult("Invalid value for RENAVAM, length must be greater than 9.", new [] { "RENAVAM" });
            }

            yield break;
        }
    }

}
