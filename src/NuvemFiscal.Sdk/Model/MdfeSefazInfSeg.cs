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
    /// Informações da seguradora.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfSeg")]
    public partial class MdfeSefazInfSeg : IEquatable<MdfeSefazInfSeg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfSeg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfSeg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfSeg" /> class.
        /// </summary>
        /// <param name="xSeg">Nome da Seguradora. (required).</param>
        /// <param name="cNPJ">Número do CNPJ da seguradora.  Obrigatório apenas se responsável pelo seguro for (2) responsável pela contratação do transporte - pessoa jurídica. (required).</param>
        public MdfeSefazInfSeg(string xSeg = default(string), string cNPJ = default(string))
        {
            // to ensure "xSeg" is required (not null)
            if (xSeg == null)
            {
                throw new ArgumentNullException("xSeg is a required property for MdfeSefazInfSeg and cannot be null");
            }
            this.xSeg = xSeg;
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for MdfeSefazInfSeg and cannot be null");
            }
            this.CNPJ = cNPJ;
        }

        /// <summary>
        /// Nome da Seguradora.
        /// </summary>
        /// <value>Nome da Seguradora.</value>
        [DataMember(Name = "xSeg", IsRequired = true, EmitDefaultValue = true)]
        public string xSeg { get; set; }

        /// <summary>
        /// Número do CNPJ da seguradora.  Obrigatório apenas se responsável pelo seguro for (2) responsável pela contratação do transporte - pessoa jurídica.
        /// </summary>
        /// <value>Número do CNPJ da seguradora.  Obrigatório apenas se responsável pelo seguro for (2) responsável pela contratação do transporte - pessoa jurídica.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfSeg {\n");
            sb.Append("  xSeg: ").Append(xSeg).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
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
            return this.Equals(input as MdfeSefazInfSeg);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfSeg instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfSeg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfSeg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xSeg == input.xSeg ||
                    (this.xSeg != null &&
                    this.xSeg.Equals(input.xSeg))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
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
                if (this.xSeg != null)
                {
                    hashCode = (hashCode * 59) + this.xSeg.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
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
            // xSeg (string) maxLength
            if (this.xSeg != null && this.xSeg.Length > 30)
            {
                yield return new ValidationResult("Invalid value for xSeg, length must be less than 30.", new [] { "xSeg" });
            }

            // xSeg (string) minLength
            if (this.xSeg != null && this.xSeg.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xSeg, length must be greater than 1.", new [] { "xSeg" });
            }

            yield break;
        }
    }

}
