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
    /// Informações dos Municípios de descarregamento.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMunDescarga")]
    public partial class MdfeSefazInfMunDescarga : IEquatable<MdfeSefazInfMunDescarga>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMunDescarga" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfMunDescarga() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMunDescarga" /> class.
        /// </summary>
        /// <param name="cMunDescarga">Código do Município de Descarregamento. (required).</param>
        /// <param name="xMunDescarga">Nome do Município de Descarregamento. (required).</param>
        /// <param name="infCTe">infCTe.</param>
        /// <param name="infNFe">infNFe.</param>
        /// <param name="infMDFeTransp">infMDFeTransp.</param>
        public MdfeSefazInfMunDescarga(string cMunDescarga = default(string), string xMunDescarga = default(string), List<MdfeSefazInfCTe> infCTe = default(List<MdfeSefazInfCTe>), List<MdfeSefazInfNFe> infNFe = default(List<MdfeSefazInfNFe>), List<MdfeSefazInfMDFeTransp> infMDFeTransp = default(List<MdfeSefazInfMDFeTransp>))
        {
            // to ensure "cMunDescarga" is required (not null)
            if (cMunDescarga == null)
            {
                throw new ArgumentNullException("cMunDescarga is a required property for MdfeSefazInfMunDescarga and cannot be null");
            }
            this.cMunDescarga = cMunDescarga;
            // to ensure "xMunDescarga" is required (not null)
            if (xMunDescarga == null)
            {
                throw new ArgumentNullException("xMunDescarga is a required property for MdfeSefazInfMunDescarga and cannot be null");
            }
            this.xMunDescarga = xMunDescarga;
            this.infCTe = infCTe;
            this.infNFe = infNFe;
            this.infMDFeTransp = infMDFeTransp;
        }

        /// <summary>
        /// Código do Município de Descarregamento.
        /// </summary>
        /// <value>Código do Município de Descarregamento.</value>
        [DataMember(Name = "cMunDescarga", IsRequired = true, EmitDefaultValue = true)]
        public string cMunDescarga { get; set; }

        /// <summary>
        /// Nome do Município de Descarregamento.
        /// </summary>
        /// <value>Nome do Município de Descarregamento.</value>
        [DataMember(Name = "xMunDescarga", IsRequired = true, EmitDefaultValue = true)]
        public string xMunDescarga { get; set; }

        /// <summary>
        /// Gets or Sets infCTe
        /// </summary>
        [DataMember(Name = "infCTe", EmitDefaultValue = false)]
        public List<MdfeSefazInfCTe> infCTe { get; set; }

        /// <summary>
        /// Gets or Sets infNFe
        /// </summary>
        [DataMember(Name = "infNFe", EmitDefaultValue = false)]
        public List<MdfeSefazInfNFe> infNFe { get; set; }

        /// <summary>
        /// Gets or Sets infMDFeTransp
        /// </summary>
        [DataMember(Name = "infMDFeTransp", EmitDefaultValue = false)]
        public List<MdfeSefazInfMDFeTransp> infMDFeTransp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMunDescarga {\n");
            sb.Append("  cMunDescarga: ").Append(cMunDescarga).Append("\n");
            sb.Append("  xMunDescarga: ").Append(xMunDescarga).Append("\n");
            sb.Append("  infCTe: ").Append(infCTe).Append("\n");
            sb.Append("  infNFe: ").Append(infNFe).Append("\n");
            sb.Append("  infMDFeTransp: ").Append(infMDFeTransp).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMunDescarga);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMunDescarga instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMunDescarga to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMunDescarga input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cMunDescarga == input.cMunDescarga ||
                    (this.cMunDescarga != null &&
                    this.cMunDescarga.Equals(input.cMunDescarga))
                ) && 
                (
                    this.xMunDescarga == input.xMunDescarga ||
                    (this.xMunDescarga != null &&
                    this.xMunDescarga.Equals(input.xMunDescarga))
                ) && 
                (
                    this.infCTe == input.infCTe ||
                    this.infCTe != null &&
                    input.infCTe != null &&
                    this.infCTe.SequenceEqual(input.infCTe)
                ) && 
                (
                    this.infNFe == input.infNFe ||
                    this.infNFe != null &&
                    input.infNFe != null &&
                    this.infNFe.SequenceEqual(input.infNFe)
                ) && 
                (
                    this.infMDFeTransp == input.infMDFeTransp ||
                    this.infMDFeTransp != null &&
                    input.infMDFeTransp != null &&
                    this.infMDFeTransp.SequenceEqual(input.infMDFeTransp)
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
                if (this.cMunDescarga != null)
                {
                    hashCode = (hashCode * 59) + this.cMunDescarga.GetHashCode();
                }
                if (this.xMunDescarga != null)
                {
                    hashCode = (hashCode * 59) + this.xMunDescarga.GetHashCode();
                }
                if (this.infCTe != null)
                {
                    hashCode = (hashCode * 59) + this.infCTe.GetHashCode();
                }
                if (this.infNFe != null)
                {
                    hashCode = (hashCode * 59) + this.infNFe.GetHashCode();
                }
                if (this.infMDFeTransp != null)
                {
                    hashCode = (hashCode * 59) + this.infMDFeTransp.GetHashCode();
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
            // xMunDescarga (string) maxLength
            if (this.xMunDescarga != null && this.xMunDescarga.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xMunDescarga, length must be less than 60.", new [] { "xMunDescarga" });
            }

            // xMunDescarga (string) minLength
            if (this.xMunDescarga != null && this.xMunDescarga.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xMunDescarga, length must be greater than 2.", new [] { "xMunDescarga" });
            }

            yield break;
        }
    }

}
