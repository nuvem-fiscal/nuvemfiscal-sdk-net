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
    /// MdfeNaoEncerrado
    /// </summary>
    [DataContract(Name = "MdfeNaoEncerrado")]
    public partial class MdfeNaoEncerrado : IEquatable<MdfeNaoEncerrado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeNaoEncerrado" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeNaoEncerrado() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeNaoEncerrado" /> class.
        /// </summary>
        /// <param name="chMDFe">Chaves de acesso do MDF-e não encerrado. (required).</param>
        /// <param name="nProt">Número do Protocolo de autorização do MDF-e não encerrado. (required).</param>
        public MdfeNaoEncerrado(string chMDFe = default(string), string nProt = default(string))
        {
            // to ensure "chMDFe" is required (not null)
            if (chMDFe == null)
            {
                throw new ArgumentNullException("chMDFe is a required property for MdfeNaoEncerrado and cannot be null");
            }
            this.chMDFe = chMDFe;
            // to ensure "nProt" is required (not null)
            if (nProt == null)
            {
                throw new ArgumentNullException("nProt is a required property for MdfeNaoEncerrado and cannot be null");
            }
            this.nProt = nProt;
        }

        /// <summary>
        /// Chaves de acesso do MDF-e não encerrado.
        /// </summary>
        /// <value>Chaves de acesso do MDF-e não encerrado.</value>
        [DataMember(Name = "chMDFe", IsRequired = true, EmitDefaultValue = true)]
        public string chMDFe { get; set; }

        /// <summary>
        /// Número do Protocolo de autorização do MDF-e não encerrado.
        /// </summary>
        /// <value>Número do Protocolo de autorização do MDF-e não encerrado.</value>
        [DataMember(Name = "nProt", IsRequired = true, EmitDefaultValue = true)]
        public string nProt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeNaoEncerrado {\n");
            sb.Append("  chMDFe: ").Append(chMDFe).Append("\n");
            sb.Append("  nProt: ").Append(nProt).Append("\n");
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
            return this.Equals(input as MdfeNaoEncerrado);
        }

        /// <summary>
        /// Returns true if MdfeNaoEncerrado instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeNaoEncerrado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeNaoEncerrado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chMDFe == input.chMDFe ||
                    (this.chMDFe != null &&
                    this.chMDFe.Equals(input.chMDFe))
                ) && 
                (
                    this.nProt == input.nProt ||
                    (this.nProt != null &&
                    this.nProt.Equals(input.nProt))
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
                if (this.chMDFe != null)
                {
                    hashCode = (hashCode * 59) + this.chMDFe.GetHashCode();
                }
                if (this.nProt != null)
                {
                    hashCode = (hashCode * 59) + this.nProt.GetHashCode();
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
            yield break;
        }
    }

}
