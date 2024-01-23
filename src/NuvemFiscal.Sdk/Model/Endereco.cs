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
    /// Dados de endereço.
    /// </summary>
    [DataContract(Name = "Endereco")]
    public partial class Endereco : IEquatable<Endereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endereco" /> class.
        /// </summary>
        /// <param name="endNac">endNac.</param>
        /// <param name="endExt">endExt.</param>
        /// <param name="xLgr">Tipo e nome do logradouro da localização do imóvel..</param>
        /// <param name="nro">Número do imóvel..</param>
        /// <param name="xCpl">Complemento do endereço..</param>
        /// <param name="xBairro">Bairro..</param>
        public Endereco(EnderNac endNac = default(EnderNac), EnderExt endExt = default(EnderExt), string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string))
        {
            this.endNac = endNac;
            this.endExt = endExt;
            this.xLgr = xLgr;
            this.nro = nro;
            this.xCpl = xCpl;
            this.xBairro = xBairro;
        }

        /// <summary>
        /// Gets or Sets endNac
        /// </summary>
        [DataMember(Name = "endNac", EmitDefaultValue = false)]
        public EnderNac endNac { get; set; }

        /// <summary>
        /// Gets or Sets endExt
        /// </summary>
        [DataMember(Name = "endExt", EmitDefaultValue = false)]
        public EnderExt endExt { get; set; }

        /// <summary>
        /// Tipo e nome do logradouro da localização do imóvel.
        /// </summary>
        /// <value>Tipo e nome do logradouro da localização do imóvel.</value>
        [DataMember(Name = "xLgr", EmitDefaultValue = true)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número do imóvel.
        /// </summary>
        /// <value>Número do imóvel.</value>
        [DataMember(Name = "nro", EmitDefaultValue = true)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento do endereço.
        /// </summary>
        /// <value>Complemento do endereço.</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = true)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        /// <value>Bairro.</value>
        [DataMember(Name = "xBairro", EmitDefaultValue = true)]
        public string xBairro { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Endereco {\n");
            sb.Append("  endNac: ").Append(endNac).Append("\n");
            sb.Append("  endExt: ").Append(endExt).Append("\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
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
            return this.Equals(input as Endereco);
        }

        /// <summary>
        /// Returns true if Endereco instances are equal
        /// </summary>
        /// <param name="input">Instance of Endereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endereco input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.endNac == input.endNac ||
                    (this.endNac != null &&
                    this.endNac.Equals(input.endNac))
                ) && 
                (
                    this.endExt == input.endExt ||
                    (this.endExt != null &&
                    this.endExt.Equals(input.endExt))
                ) && 
                (
                    this.xLgr == input.xLgr ||
                    (this.xLgr != null &&
                    this.xLgr.Equals(input.xLgr))
                ) && 
                (
                    this.nro == input.nro ||
                    (this.nro != null &&
                    this.nro.Equals(input.nro))
                ) && 
                (
                    this.xCpl == input.xCpl ||
                    (this.xCpl != null &&
                    this.xCpl.Equals(input.xCpl))
                ) && 
                (
                    this.xBairro == input.xBairro ||
                    (this.xBairro != null &&
                    this.xBairro.Equals(input.xBairro))
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
                if (this.endNac != null)
                {
                    hashCode = (hashCode * 59) + this.endNac.GetHashCode();
                }
                if (this.endExt != null)
                {
                    hashCode = (hashCode * 59) + this.endExt.GetHashCode();
                }
                if (this.xLgr != null)
                {
                    hashCode = (hashCode * 59) + this.xLgr.GetHashCode();
                }
                if (this.nro != null)
                {
                    hashCode = (hashCode * 59) + this.nro.GetHashCode();
                }
                if (this.xCpl != null)
                {
                    hashCode = (hashCode * 59) + this.xCpl.GetHashCode();
                }
                if (this.xBairro != null)
                {
                    hashCode = (hashCode * 59) + this.xBairro.GetHashCode();
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
            // xLgr (string) maxLength
            if (this.xLgr != null && this.xLgr.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLgr, length must be less than 255.", new [] { "xLgr" });
            }

            // xLgr (string) minLength
            if (this.xLgr != null && this.xLgr.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLgr, length must be greater than 1.", new [] { "xLgr" });
            }

            // nro (string) maxLength
            if (this.nro != null && this.nro.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nro, length must be less than 60.", new [] { "nro" });
            }

            // nro (string) minLength
            if (this.nro != null && this.nro.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nro, length must be greater than 1.", new [] { "nro" });
            }

            // xCpl (string) maxLength
            if (this.xCpl != null && this.xCpl.Length > 156)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xCpl, length must be less than 156.", new [] { "xCpl" });
            }

            // xCpl (string) minLength
            if (this.xCpl != null && this.xCpl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xCpl, length must be greater than 1.", new [] { "xCpl" });
            }

            // xBairro (string) maxLength
            if (this.xBairro != null && this.xBairro.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xBairro, length must be less than 60.", new [] { "xBairro" });
            }

            // xBairro (string) minLength
            if (this.xBairro != null && this.xBairro.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xBairro, length must be greater than 1.", new [] { "xBairro" });
            }

            yield break;
        }
    }

}
