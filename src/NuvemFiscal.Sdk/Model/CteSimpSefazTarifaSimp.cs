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
    /// Informações de tarifa.
    /// </summary>
    [DataContract(Name = "CteSimpSefazTarifaSimp")]
    public partial class CteSimpSefazTarifaSimp : IEquatable<CteSimpSefazTarifaSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazTarifaSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazTarifaSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazTarifaSimp" /> class.
        /// </summary>
        /// <param name="cL">Classe.  Preencher com:  * M - Tarifa Mínima  * G - Tarifa Geral  * E - Tarifa Específica (required).</param>
        /// <param name="cTar">Código da Tarifa.  Deverão ser incluídos os códigos de três dígitos, correspondentes à tarifa..</param>
        /// <param name="vTar">Valor da Tarifa.  Valor da tarifa por kg quando for o caso. (required).</param>
        public CteSimpSefazTarifaSimp(string cL = default(string), string cTar = default(string), decimal? vTar = default(decimal?))
        {
            // to ensure "cL" is required (not null)
            if (cL == null)
            {
                throw new ArgumentNullException("cL is a required property for CteSimpSefazTarifaSimp and cannot be null");
            }
            this.CL = cL;
            // to ensure "vTar" is required (not null)
            if (vTar == null)
            {
                throw new ArgumentNullException("vTar is a required property for CteSimpSefazTarifaSimp and cannot be null");
            }
            this.vTar = vTar;
            this.cTar = cTar;
        }

        /// <summary>
        /// Classe.  Preencher com:  * M - Tarifa Mínima  * G - Tarifa Geral  * E - Tarifa Específica
        /// </summary>
        /// <value>Classe.  Preencher com:  * M - Tarifa Mínima  * G - Tarifa Geral  * E - Tarifa Específica</value>
        [DataMember(Name = "CL", IsRequired = true, EmitDefaultValue = true)]
        public string CL { get; set; }

        /// <summary>
        /// Código da Tarifa.  Deverão ser incluídos os códigos de três dígitos, correspondentes à tarifa.
        /// </summary>
        /// <value>Código da Tarifa.  Deverão ser incluídos os códigos de três dígitos, correspondentes à tarifa.</value>
        [DataMember(Name = "cTar", EmitDefaultValue = true)]
        public string cTar { get; set; }

        /// <summary>
        /// Valor da Tarifa.  Valor da tarifa por kg quando for o caso.
        /// </summary>
        /// <value>Valor da Tarifa.  Valor da tarifa por kg quando for o caso.</value>
        [DataMember(Name = "vTar", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazTarifaSimp {\n");
            sb.Append("  CL: ").Append(CL).Append("\n");
            sb.Append("  cTar: ").Append(cTar).Append("\n");
            sb.Append("  vTar: ").Append(vTar).Append("\n");
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
            return this.Equals(input as CteSimpSefazTarifaSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazTarifaSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazTarifaSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazTarifaSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CL == input.CL ||
                    (this.CL != null &&
                    this.CL.Equals(input.CL))
                ) && 
                (
                    this.cTar == input.cTar ||
                    (this.cTar != null &&
                    this.cTar.Equals(input.cTar))
                ) && 
                (
                    this.vTar == input.vTar ||
                    (this.vTar != null &&
                    this.vTar.Equals(input.vTar))
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
                if (this.CL != null)
                {
                    hashCode = (hashCode * 59) + this.CL.GetHashCode();
                }
                if (this.cTar != null)
                {
                    hashCode = (hashCode * 59) + this.cTar.GetHashCode();
                }
                if (this.vTar != null)
                {
                    hashCode = (hashCode * 59) + this.vTar.GetHashCode();
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
            // CL (string) maxLength
            if (this.CL != null && this.CL.Length > 1)
            {
                yield return new ValidationResult("Invalid value for CL, length must be less than 1.", new [] { "CL" });
            }

            // cTar (string) maxLength
            if (this.cTar != null && this.cTar.Length > 4)
            {
                yield return new ValidationResult("Invalid value for cTar, length must be less than 4.", new [] { "cTar" });
            }

            // cTar (string) minLength
            if (this.cTar != null && this.cTar.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cTar, length must be greater than 1.", new [] { "cTar" });
            }

            // vTar (decimal?) minimum
            if (this.vTar < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTar, must be a value greater than or equal to 0.", new [] { "vTar" });
            }

            yield break;
        }
    }

}
