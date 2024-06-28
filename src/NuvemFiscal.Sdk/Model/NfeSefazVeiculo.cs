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
    /// Dados do veículo.
    /// </summary>
    [DataContract(Name = "NfeSefazVeiculo")]
    public partial class NfeSefazVeiculo : IEquatable<NfeSefazVeiculo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazVeiculo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazVeiculo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazVeiculo" /> class.
        /// </summary>
        /// <param name="placa">Placa do veículo (NT2011/004). (required).</param>
        /// <param name="uF">Sigla da UF..</param>
        /// <param name="rNTC">Registro Nacional de Transportador de Carga (ANTT)..</param>
        public NfeSefazVeiculo(string placa = default(string), string uF = default(string), string rNTC = default(string))
        {
            // to ensure "placa" is required (not null)
            if (placa == null)
            {
                throw new ArgumentNullException("placa is a required property for NfeSefazVeiculo and cannot be null");
            }
            this.placa = placa;
            this.UF = uF;
            this.RNTC = rNTC;
        }

        /// <summary>
        /// Placa do veículo (NT2011/004).
        /// </summary>
        /// <value>Placa do veículo (NT2011/004).</value>
        [DataMember(Name = "placa", IsRequired = true, EmitDefaultValue = true)]
        public string placa { get; set; }

        /// <summary>
        /// Sigla da UF.
        /// </summary>
        /// <value>Sigla da UF.</value>
        [DataMember(Name = "UF", EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Registro Nacional de Transportador de Carga (ANTT).
        /// </summary>
        /// <value>Registro Nacional de Transportador de Carga (ANTT).</value>
        [DataMember(Name = "RNTC", EmitDefaultValue = true)]
        public string RNTC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazVeiculo {\n");
            sb.Append("  placa: ").Append(placa).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  RNTC: ").Append(RNTC).Append("\n");
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
            return this.Equals(input as NfeSefazVeiculo);
        }

        /// <summary>
        /// Returns true if NfeSefazVeiculo instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazVeiculo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazVeiculo input)
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
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.RNTC == input.RNTC ||
                    (this.RNTC != null &&
                    this.RNTC.Equals(input.RNTC))
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
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.RNTC != null)
                {
                    hashCode = (hashCode * 59) + this.RNTC.GetHashCode();
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
            // RNTC (string) maxLength
            if (this.RNTC != null && this.RNTC.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RNTC, length must be less than 20.", new [] { "RNTC" });
            }

            // RNTC (string) minLength
            if (this.RNTC != null && this.RNTC.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RNTC, length must be greater than 1.", new [] { "RNTC" });
            }

            yield break;
        }
    }

}
