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
    /// Grupo de informações de Outras NFS-e (Padrão anterior de NFS-e).
    /// </summary>
    [DataContract(Name = "DocOutNFSe")]
    public partial class DocOutNFSe : IEquatable<DocOutNFSe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocOutNFSe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocOutNFSe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocOutNFSe" /> class.
        /// </summary>
        /// <param name="cMunNFSeMun">Código Município emissor da nota eletrônica municipal (Tabela do IBGE). (required).</param>
        /// <param name="nNFSeMun">Número da nota eletrônica municipal. (required).</param>
        /// <param name="cVerifNFSeMun">Código de Verificação da nota eletrônica municipal. (required).</param>
        public DocOutNFSe(string cMunNFSeMun = default(string), int? nNFSeMun = default(int?), string cVerifNFSeMun = default(string))
        {
            // to ensure "cMunNFSeMun" is required (not null)
            if (cMunNFSeMun == null)
            {
                throw new ArgumentNullException("cMunNFSeMun is a required property for DocOutNFSe and cannot be null");
            }
            this.cMunNFSeMun = cMunNFSeMun;
            // to ensure "nNFSeMun" is required (not null)
            if (nNFSeMun == null)
            {
                throw new ArgumentNullException("nNFSeMun is a required property for DocOutNFSe and cannot be null");
            }
            this.nNFSeMun = nNFSeMun;
            // to ensure "cVerifNFSeMun" is required (not null)
            if (cVerifNFSeMun == null)
            {
                throw new ArgumentNullException("cVerifNFSeMun is a required property for DocOutNFSe and cannot be null");
            }
            this.cVerifNFSeMun = cVerifNFSeMun;
        }

        /// <summary>
        /// Código Município emissor da nota eletrônica municipal (Tabela do IBGE).
        /// </summary>
        /// <value>Código Município emissor da nota eletrônica municipal (Tabela do IBGE).</value>
        [DataMember(Name = "cMunNFSeMun", IsRequired = true, EmitDefaultValue = true)]
        public string cMunNFSeMun { get; set; }

        /// <summary>
        /// Número da nota eletrônica municipal.
        /// </summary>
        /// <value>Número da nota eletrônica municipal.</value>
        [DataMember(Name = "nNFSeMun", IsRequired = true, EmitDefaultValue = true)]
        public int? nNFSeMun { get; set; }

        /// <summary>
        /// Código de Verificação da nota eletrônica municipal.
        /// </summary>
        /// <value>Código de Verificação da nota eletrônica municipal.</value>
        [DataMember(Name = "cVerifNFSeMun", IsRequired = true, EmitDefaultValue = true)]
        public string cVerifNFSeMun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocOutNFSe {\n");
            sb.Append("  cMunNFSeMun: ").Append(cMunNFSeMun).Append("\n");
            sb.Append("  nNFSeMun: ").Append(nNFSeMun).Append("\n");
            sb.Append("  cVerifNFSeMun: ").Append(cVerifNFSeMun).Append("\n");
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
            return this.Equals(input as DocOutNFSe);
        }

        /// <summary>
        /// Returns true if DocOutNFSe instances are equal
        /// </summary>
        /// <param name="input">Instance of DocOutNFSe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocOutNFSe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cMunNFSeMun == input.cMunNFSeMun ||
                    (this.cMunNFSeMun != null &&
                    this.cMunNFSeMun.Equals(input.cMunNFSeMun))
                ) && 
                (
                    this.nNFSeMun == input.nNFSeMun ||
                    (this.nNFSeMun != null &&
                    this.nNFSeMun.Equals(input.nNFSeMun))
                ) && 
                (
                    this.cVerifNFSeMun == input.cVerifNFSeMun ||
                    (this.cVerifNFSeMun != null &&
                    this.cVerifNFSeMun.Equals(input.cVerifNFSeMun))
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
                if (this.cMunNFSeMun != null)
                {
                    hashCode = (hashCode * 59) + this.cMunNFSeMun.GetHashCode();
                }
                if (this.nNFSeMun != null)
                {
                    hashCode = (hashCode * 59) + this.nNFSeMun.GetHashCode();
                }
                if (this.cVerifNFSeMun != null)
                {
                    hashCode = (hashCode * 59) + this.cVerifNFSeMun.GetHashCode();
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
            // cVerifNFSeMun (string) maxLength
            if (this.cVerifNFSeMun != null && this.cVerifNFSeMun.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cVerifNFSeMun, length must be less than 9.", new [] { "cVerifNFSeMun" });
            }

            // cVerifNFSeMun (string) minLength
            if (this.cVerifNFSeMun != null && this.cVerifNFSeMun.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cVerifNFSeMun, length must be greater than 1.", new [] { "cVerifNFSeMun" });
            }

            yield break;
        }
    }

}
