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
    /// Informações da Prestação do Serviço.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfServicoOS")]
    public partial class CteOsSefazInfServicoOS : IEquatable<CteOsSefazInfServicoOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfServicoOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfServicoOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfServicoOS" /> class.
        /// </summary>
        /// <param name="xDescServ">Descrição do Serviço prestado. (required).</param>
        /// <param name="infQ">infQ.</param>
        public CteOsSefazInfServicoOS(string xDescServ = default(string), CteOsSefazInfQOS infQ = default(CteOsSefazInfQOS))
        {
            // to ensure "xDescServ" is required (not null)
            if (xDescServ == null)
            {
                throw new ArgumentNullException("xDescServ is a required property for CteOsSefazInfServicoOS and cannot be null");
            }
            this.xDescServ = xDescServ;
            this.infQ = infQ;
        }

        /// <summary>
        /// Descrição do Serviço prestado.
        /// </summary>
        /// <value>Descrição do Serviço prestado.</value>
        [DataMember(Name = "xDescServ", IsRequired = true, EmitDefaultValue = true)]
        public string xDescServ { get; set; }

        /// <summary>
        /// Gets or Sets infQ
        /// </summary>
        [DataMember(Name = "infQ", EmitDefaultValue = false)]
        public CteOsSefazInfQOS infQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfServicoOS {\n");
            sb.Append("  xDescServ: ").Append(xDescServ).Append("\n");
            sb.Append("  infQ: ").Append(infQ).Append("\n");
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
            return this.Equals(input as CteOsSefazInfServicoOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfServicoOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfServicoOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfServicoOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xDescServ == input.xDescServ ||
                    (this.xDescServ != null &&
                    this.xDescServ.Equals(input.xDescServ))
                ) && 
                (
                    this.infQ == input.infQ ||
                    (this.infQ != null &&
                    this.infQ.Equals(input.infQ))
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
                if (this.xDescServ != null)
                {
                    hashCode = (hashCode * 59) + this.xDescServ.GetHashCode();
                }
                if (this.infQ != null)
                {
                    hashCode = (hashCode * 59) + this.infQ.GetHashCode();
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
            // xDescServ (string) maxLength
            if (this.xDescServ != null && this.xDescServ.Length > 30)
            {
                yield return new ValidationResult("Invalid value for xDescServ, length must be less than 30.", new [] { "xDescServ" });
            }

            // xDescServ (string) minLength
            if (this.xDescServ != null && this.xDescServ.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xDescServ, length must be greater than 1.", new [] { "xDescServ" });
            }

            yield break;
        }
    }

}
