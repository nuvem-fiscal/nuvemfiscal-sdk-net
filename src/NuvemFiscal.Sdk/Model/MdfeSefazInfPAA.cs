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
    /// Grupo de Informação do Provedor de Assinatura e Autorização.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfPAA")]
    public partial class MdfeSefazInfPAA : IEquatable<MdfeSefazInfPAA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPAA" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfPAA() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPAA" /> class.
        /// </summary>
        /// <param name="cNPJPAA">CNPJ do Provedor de Assinatura e Autorização. (required).</param>
        /// <param name="pAASignature">pAASignature (required).</param>
        public MdfeSefazInfPAA(string cNPJPAA = default(string), MdfeSefazPAASignature pAASignature = default(MdfeSefazPAASignature))
        {
            // to ensure "cNPJPAA" is required (not null)
            if (cNPJPAA == null)
            {
                throw new ArgumentNullException("cNPJPAA is a required property for MdfeSefazInfPAA and cannot be null");
            }
            this.CNPJPAA = cNPJPAA;
            // to ensure "pAASignature" is required (not null)
            if (pAASignature == null)
            {
                throw new ArgumentNullException("pAASignature is a required property for MdfeSefazInfPAA and cannot be null");
            }
            this.PAASignature = pAASignature;
        }

        /// <summary>
        /// CNPJ do Provedor de Assinatura e Autorização.
        /// </summary>
        /// <value>CNPJ do Provedor de Assinatura e Autorização.</value>
        [DataMember(Name = "CNPJPAA", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJPAA { get; set; }

        /// <summary>
        /// Gets or Sets PAASignature
        /// </summary>
        [DataMember(Name = "PAASignature", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazPAASignature PAASignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfPAA {\n");
            sb.Append("  CNPJPAA: ").Append(CNPJPAA).Append("\n");
            sb.Append("  PAASignature: ").Append(PAASignature).Append("\n");
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
            return this.Equals(input as MdfeSefazInfPAA);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfPAA instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfPAA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfPAA input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJPAA == input.CNPJPAA ||
                    (this.CNPJPAA != null &&
                    this.CNPJPAA.Equals(input.CNPJPAA))
                ) && 
                (
                    this.PAASignature == input.PAASignature ||
                    (this.PAASignature != null &&
                    this.PAASignature.Equals(input.PAASignature))
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
                if (this.CNPJPAA != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJPAA.GetHashCode();
                }
                if (this.PAASignature != null)
                {
                    hashCode = (hashCode * 59) + this.PAASignature.GetHashCode();
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
