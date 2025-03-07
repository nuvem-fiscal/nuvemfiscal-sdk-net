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
    /// Grupo de informações específicas de endereço no exterior.
    /// </summary>
    [DataContract(Name = "EnderExt")]
    public partial class EnderExt : IEquatable<EnderExt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderExt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnderExt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderExt" /> class.
        /// </summary>
        /// <param name="cPais">Código do país (Tabela de Países ISO). (required).</param>
        /// <param name="cEndPost">Código alfanumérico do Endereçamento Postal no exterior do prestador do serviço. (required).</param>
        /// <param name="xCidade">Nome da cidade no exterior do prestador do serviço. (required).</param>
        /// <param name="xEstProvReg">Estado, província ou região da cidade no exterior do prestador do serviço. (required).</param>
        public EnderExt(string cPais = default(string), string cEndPost = default(string), string xCidade = default(string), string xEstProvReg = default(string))
        {
            // to ensure "cPais" is required (not null)
            if (cPais == null)
            {
                throw new ArgumentNullException("cPais is a required property for EnderExt and cannot be null");
            }
            this.cPais = cPais;
            // to ensure "cEndPost" is required (not null)
            if (cEndPost == null)
            {
                throw new ArgumentNullException("cEndPost is a required property for EnderExt and cannot be null");
            }
            this.cEndPost = cEndPost;
            // to ensure "xCidade" is required (not null)
            if (xCidade == null)
            {
                throw new ArgumentNullException("xCidade is a required property for EnderExt and cannot be null");
            }
            this.xCidade = xCidade;
            // to ensure "xEstProvReg" is required (not null)
            if (xEstProvReg == null)
            {
                throw new ArgumentNullException("xEstProvReg is a required property for EnderExt and cannot be null");
            }
            this.xEstProvReg = xEstProvReg;
        }

        /// <summary>
        /// Código do país (Tabela de Países ISO).
        /// </summary>
        /// <value>Código do país (Tabela de Países ISO).</value>
        [DataMember(Name = "cPais", IsRequired = true, EmitDefaultValue = true)]
        public string cPais { get; set; }

        /// <summary>
        /// Código alfanumérico do Endereçamento Postal no exterior do prestador do serviço.
        /// </summary>
        /// <value>Código alfanumérico do Endereçamento Postal no exterior do prestador do serviço.</value>
        [DataMember(Name = "cEndPost", IsRequired = true, EmitDefaultValue = true)]
        public string cEndPost { get; set; }

        /// <summary>
        /// Nome da cidade no exterior do prestador do serviço.
        /// </summary>
        /// <value>Nome da cidade no exterior do prestador do serviço.</value>
        [DataMember(Name = "xCidade", IsRequired = true, EmitDefaultValue = true)]
        public string xCidade { get; set; }

        /// <summary>
        /// Estado, província ou região da cidade no exterior do prestador do serviço.
        /// </summary>
        /// <value>Estado, província ou região da cidade no exterior do prestador do serviço.</value>
        [DataMember(Name = "xEstProvReg", IsRequired = true, EmitDefaultValue = true)]
        public string xEstProvReg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnderExt {\n");
            sb.Append("  cPais: ").Append(cPais).Append("\n");
            sb.Append("  cEndPost: ").Append(cEndPost).Append("\n");
            sb.Append("  xCidade: ").Append(xCidade).Append("\n");
            sb.Append("  xEstProvReg: ").Append(xEstProvReg).Append("\n");
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
            return this.Equals(input as EnderExt);
        }

        /// <summary>
        /// Returns true if EnderExt instances are equal
        /// </summary>
        /// <param name="input">Instance of EnderExt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderExt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cPais == input.cPais ||
                    (this.cPais != null &&
                    this.cPais.Equals(input.cPais))
                ) && 
                (
                    this.cEndPost == input.cEndPost ||
                    (this.cEndPost != null &&
                    this.cEndPost.Equals(input.cEndPost))
                ) && 
                (
                    this.xCidade == input.xCidade ||
                    (this.xCidade != null &&
                    this.xCidade.Equals(input.xCidade))
                ) && 
                (
                    this.xEstProvReg == input.xEstProvReg ||
                    (this.xEstProvReg != null &&
                    this.xEstProvReg.Equals(input.xEstProvReg))
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
                if (this.cPais != null)
                {
                    hashCode = (hashCode * 59) + this.cPais.GetHashCode();
                }
                if (this.cEndPost != null)
                {
                    hashCode = (hashCode * 59) + this.cEndPost.GetHashCode();
                }
                if (this.xCidade != null)
                {
                    hashCode = (hashCode * 59) + this.xCidade.GetHashCode();
                }
                if (this.xEstProvReg != null)
                {
                    hashCode = (hashCode * 59) + this.xEstProvReg.GetHashCode();
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
            // cEndPost (string) maxLength
            if (this.cEndPost != null && this.cEndPost.Length > 11)
            {
                yield return new ValidationResult("Invalid value for cEndPost, length must be less than 11.", new [] { "cEndPost" });
            }

            // cEndPost (string) minLength
            if (this.cEndPost != null && this.cEndPost.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cEndPost, length must be greater than 1.", new [] { "cEndPost" });
            }

            // xCidade (string) maxLength
            if (this.xCidade != null && this.xCidade.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xCidade, length must be less than 60.", new [] { "xCidade" });
            }

            // xCidade (string) minLength
            if (this.xCidade != null && this.xCidade.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xCidade, length must be greater than 1.", new [] { "xCidade" });
            }

            // xEstProvReg (string) maxLength
            if (this.xEstProvReg != null && this.xEstProvReg.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xEstProvReg, length must be less than 60.", new [] { "xEstProvReg" });
            }

            // xEstProvReg (string) minLength
            if (this.xEstProvReg != null && this.xEstProvReg.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xEstProvReg, length must be greater than 1.", new [] { "xEstProvReg" });
            }

            yield break;
        }
    }

}
