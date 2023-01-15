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
    [DataContract(Name = "EnderExtSimples")]
    public partial class EnderExtSimples : IEquatable<EnderExtSimples>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderExtSimples" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnderExtSimples() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderExtSimples" /> class.
        /// </summary>
        /// <param name="cEndPost">Código alfanumérico do Endereçamento Postal no exterior do prestador do serviço. (required).</param>
        /// <param name="xCidade">Nome da cidade no exterior do prestador do serviço. (required).</param>
        /// <param name="xEstProvReg">Estado, província ou região da cidade no exterior do prestador do serviço. (required).</param>
        public EnderExtSimples(string cEndPost = default(string), string xCidade = default(string), string xEstProvReg = default(string))
        {
            // to ensure "cEndPost" is required (not null)
            if (cEndPost == null)
            {
                throw new ArgumentNullException("cEndPost is a required property for EnderExtSimples and cannot be null");
            }
            this.cEndPost = cEndPost;
            // to ensure "xCidade" is required (not null)
            if (xCidade == null)
            {
                throw new ArgumentNullException("xCidade is a required property for EnderExtSimples and cannot be null");
            }
            this.xCidade = xCidade;
            // to ensure "xEstProvReg" is required (not null)
            if (xEstProvReg == null)
            {
                throw new ArgumentNullException("xEstProvReg is a required property for EnderExtSimples and cannot be null");
            }
            this.xEstProvReg = xEstProvReg;
        }

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
            sb.Append("class EnderExtSimples {\n");
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
            return this.Equals(input as EnderExtSimples);
        }

        /// <summary>
        /// Returns true if EnderExtSimples instances are equal
        /// </summary>
        /// <param name="input">Instance of EnderExtSimples to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderExtSimples input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
