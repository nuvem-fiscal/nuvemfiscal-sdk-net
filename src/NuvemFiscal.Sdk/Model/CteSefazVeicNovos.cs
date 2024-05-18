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
    /// informações dos veículos transportados.
    /// </summary>
    [DataContract(Name = "CteSefazVeicNovos")]
    public partial class CteSefazVeicNovos : IEquatable<CteSefazVeicNovos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazVeicNovos" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazVeicNovos() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazVeicNovos" /> class.
        /// </summary>
        /// <param name="chassi">Chassi do veículo. (required).</param>
        /// <param name="cCor">Cor do veículo.  Código de cada montadora. (required).</param>
        /// <param name="xCor">Descrição da cor. (required).</param>
        /// <param name="cMod">Código Marca Modelo.  Utilizar tabela RENAVAM. (required).</param>
        /// <param name="vUnit">Valor Unitário do Veículo. (required).</param>
        /// <param name="vFrete">Frete Unitário. (required).</param>
        public CteSefazVeicNovos(string chassi = default(string), string cCor = default(string), string xCor = default(string), string cMod = default(string), decimal? vUnit = default(decimal?), decimal? vFrete = default(decimal?))
        {
            // to ensure "chassi" is required (not null)
            if (chassi == null)
            {
                throw new ArgumentNullException("chassi is a required property for CteSefazVeicNovos and cannot be null");
            }
            this.chassi = chassi;
            // to ensure "cCor" is required (not null)
            if (cCor == null)
            {
                throw new ArgumentNullException("cCor is a required property for CteSefazVeicNovos and cannot be null");
            }
            this.cCor = cCor;
            // to ensure "xCor" is required (not null)
            if (xCor == null)
            {
                throw new ArgumentNullException("xCor is a required property for CteSefazVeicNovos and cannot be null");
            }
            this.xCor = xCor;
            // to ensure "cMod" is required (not null)
            if (cMod == null)
            {
                throw new ArgumentNullException("cMod is a required property for CteSefazVeicNovos and cannot be null");
            }
            this.cMod = cMod;
            // to ensure "vUnit" is required (not null)
            if (vUnit == null)
            {
                throw new ArgumentNullException("vUnit is a required property for CteSefazVeicNovos and cannot be null");
            }
            this.vUnit = vUnit;
            // to ensure "vFrete" is required (not null)
            if (vFrete == null)
            {
                throw new ArgumentNullException("vFrete is a required property for CteSefazVeicNovos and cannot be null");
            }
            this.vFrete = vFrete;
        }

        /// <summary>
        /// Chassi do veículo.
        /// </summary>
        /// <value>Chassi do veículo.</value>
        [DataMember(Name = "chassi", IsRequired = true, EmitDefaultValue = true)]
        public string chassi { get; set; }

        /// <summary>
        /// Cor do veículo.  Código de cada montadora.
        /// </summary>
        /// <value>Cor do veículo.  Código de cada montadora.</value>
        [DataMember(Name = "cCor", IsRequired = true, EmitDefaultValue = true)]
        public string cCor { get; set; }

        /// <summary>
        /// Descrição da cor.
        /// </summary>
        /// <value>Descrição da cor.</value>
        [DataMember(Name = "xCor", IsRequired = true, EmitDefaultValue = true)]
        public string xCor { get; set; }

        /// <summary>
        /// Código Marca Modelo.  Utilizar tabela RENAVAM.
        /// </summary>
        /// <value>Código Marca Modelo.  Utilizar tabela RENAVAM.</value>
        [DataMember(Name = "cMod", IsRequired = true, EmitDefaultValue = true)]
        public string cMod { get; set; }

        /// <summary>
        /// Valor Unitário do Veículo.
        /// </summary>
        /// <value>Valor Unitário do Veículo.</value>
        [DataMember(Name = "vUnit", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vUnit { get; set; }

        /// <summary>
        /// Frete Unitário.
        /// </summary>
        /// <value>Frete Unitário.</value>
        [DataMember(Name = "vFrete", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFrete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazVeicNovos {\n");
            sb.Append("  chassi: ").Append(chassi).Append("\n");
            sb.Append("  cCor: ").Append(cCor).Append("\n");
            sb.Append("  xCor: ").Append(xCor).Append("\n");
            sb.Append("  cMod: ").Append(cMod).Append("\n");
            sb.Append("  vUnit: ").Append(vUnit).Append("\n");
            sb.Append("  vFrete: ").Append(vFrete).Append("\n");
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
            return this.Equals(input as CteSefazVeicNovos);
        }

        /// <summary>
        /// Returns true if CteSefazVeicNovos instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazVeicNovos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazVeicNovos input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chassi == input.chassi ||
                    (this.chassi != null &&
                    this.chassi.Equals(input.chassi))
                ) && 
                (
                    this.cCor == input.cCor ||
                    (this.cCor != null &&
                    this.cCor.Equals(input.cCor))
                ) && 
                (
                    this.xCor == input.xCor ||
                    (this.xCor != null &&
                    this.xCor.Equals(input.xCor))
                ) && 
                (
                    this.cMod == input.cMod ||
                    (this.cMod != null &&
                    this.cMod.Equals(input.cMod))
                ) && 
                (
                    this.vUnit == input.vUnit ||
                    (this.vUnit != null &&
                    this.vUnit.Equals(input.vUnit))
                ) && 
                (
                    this.vFrete == input.vFrete ||
                    (this.vFrete != null &&
                    this.vFrete.Equals(input.vFrete))
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
                if (this.chassi != null)
                {
                    hashCode = (hashCode * 59) + this.chassi.GetHashCode();
                }
                if (this.cCor != null)
                {
                    hashCode = (hashCode * 59) + this.cCor.GetHashCode();
                }
                if (this.xCor != null)
                {
                    hashCode = (hashCode * 59) + this.xCor.GetHashCode();
                }
                if (this.cMod != null)
                {
                    hashCode = (hashCode * 59) + this.cMod.GetHashCode();
                }
                if (this.vUnit != null)
                {
                    hashCode = (hashCode * 59) + this.vUnit.GetHashCode();
                }
                if (this.vFrete != null)
                {
                    hashCode = (hashCode * 59) + this.vFrete.GetHashCode();
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
            // chassi (string) maxLength
            if (this.chassi != null && this.chassi.Length > 17)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chassi, length must be less than 17.", new [] { "chassi" });
            }

            // cCor (string) maxLength
            if (this.cCor != null && this.cCor.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cCor, length must be less than 4.", new [] { "cCor" });
            }

            // cCor (string) minLength
            if (this.cCor != null && this.cCor.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cCor, length must be greater than 1.", new [] { "cCor" });
            }

            // xCor (string) maxLength
            if (this.xCor != null && this.xCor.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xCor, length must be less than 40.", new [] { "xCor" });
            }

            // xCor (string) minLength
            if (this.xCor != null && this.xCor.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xCor, length must be greater than 1.", new [] { "xCor" });
            }

            // cMod (string) maxLength
            if (this.cMod != null && this.cMod.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cMod, length must be less than 6.", new [] { "cMod" });
            }

            // cMod (string) minLength
            if (this.cMod != null && this.cMod.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cMod, length must be greater than 1.", new [] { "cMod" });
            }

            // vUnit (decimal?) minimum
            if (this.vUnit < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vUnit, must be a value greater than or equal to 0.", new [] { "vUnit" });
            }

            // vFrete (decimal?) minimum
            if (this.vFrete < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFrete, must be a value greater than or equal to 0.", new [] { "vFrete" });
            }

            yield break;
        }
    }

}
