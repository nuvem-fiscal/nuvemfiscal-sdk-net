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
    /// Informações da composição do trem.
    /// </summary>
    [DataContract(Name = "MdfeSefazTrem")]
    public partial class MdfeSefazTrem : IEquatable<MdfeSefazTrem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazTrem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazTrem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazTrem" /> class.
        /// </summary>
        /// <param name="xPref">Prefixo do Trem. (required).</param>
        /// <param name="dhTrem">Data e hora de liberação do trem na origem..</param>
        /// <param name="xOri">Origem do Trem.  Sigla da estação de origem. (required).</param>
        /// <param name="xDest">Destino do Trem.  Sigla da estação de destino. (required).</param>
        /// <param name="qVag">Quantidade de vagões carregados. (required).</param>
        public MdfeSefazTrem(string xPref = default(string), DateTime? dhTrem = default(DateTime?), string xOri = default(string), string xDest = default(string), int? qVag = default(int?))
        {
            // to ensure "xPref" is required (not null)
            if (xPref == null)
            {
                throw new ArgumentNullException("xPref is a required property for MdfeSefazTrem and cannot be null");
            }
            this.xPref = xPref;
            // to ensure "xOri" is required (not null)
            if (xOri == null)
            {
                throw new ArgumentNullException("xOri is a required property for MdfeSefazTrem and cannot be null");
            }
            this.xOri = xOri;
            // to ensure "xDest" is required (not null)
            if (xDest == null)
            {
                throw new ArgumentNullException("xDest is a required property for MdfeSefazTrem and cannot be null");
            }
            this.xDest = xDest;
            // to ensure "qVag" is required (not null)
            if (qVag == null)
            {
                throw new ArgumentNullException("qVag is a required property for MdfeSefazTrem and cannot be null");
            }
            this.qVag = qVag;
            this.dhTrem = dhTrem;
        }

        /// <summary>
        /// Prefixo do Trem.
        /// </summary>
        /// <value>Prefixo do Trem.</value>
        [DataMember(Name = "xPref", IsRequired = true, EmitDefaultValue = true)]
        public string xPref { get; set; }

        /// <summary>
        /// Data e hora de liberação do trem na origem.
        /// </summary>
        /// <value>Data e hora de liberação do trem na origem.</value>
        [DataMember(Name = "dhTrem", EmitDefaultValue = true)]
        public DateTime? dhTrem { get; set; }

        /// <summary>
        /// Origem do Trem.  Sigla da estação de origem.
        /// </summary>
        /// <value>Origem do Trem.  Sigla da estação de origem.</value>
        [DataMember(Name = "xOri", IsRequired = true, EmitDefaultValue = true)]
        public string xOri { get; set; }

        /// <summary>
        /// Destino do Trem.  Sigla da estação de destino.
        /// </summary>
        /// <value>Destino do Trem.  Sigla da estação de destino.</value>
        [DataMember(Name = "xDest", IsRequired = true, EmitDefaultValue = true)]
        public string xDest { get; set; }

        /// <summary>
        /// Quantidade de vagões carregados.
        /// </summary>
        /// <value>Quantidade de vagões carregados.</value>
        [DataMember(Name = "qVag", IsRequired = true, EmitDefaultValue = true)]
        public int? qVag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazTrem {\n");
            sb.Append("  xPref: ").Append(xPref).Append("\n");
            sb.Append("  dhTrem: ").Append(dhTrem).Append("\n");
            sb.Append("  xOri: ").Append(xOri).Append("\n");
            sb.Append("  xDest: ").Append(xDest).Append("\n");
            sb.Append("  qVag: ").Append(qVag).Append("\n");
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
            return this.Equals(input as MdfeSefazTrem);
        }

        /// <summary>
        /// Returns true if MdfeSefazTrem instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazTrem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazTrem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xPref == input.xPref ||
                    (this.xPref != null &&
                    this.xPref.Equals(input.xPref))
                ) && 
                (
                    this.dhTrem == input.dhTrem ||
                    (this.dhTrem != null &&
                    this.dhTrem.Equals(input.dhTrem))
                ) && 
                (
                    this.xOri == input.xOri ||
                    (this.xOri != null &&
                    this.xOri.Equals(input.xOri))
                ) && 
                (
                    this.xDest == input.xDest ||
                    (this.xDest != null &&
                    this.xDest.Equals(input.xDest))
                ) && 
                (
                    this.qVag == input.qVag ||
                    (this.qVag != null &&
                    this.qVag.Equals(input.qVag))
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
                if (this.xPref != null)
                {
                    hashCode = (hashCode * 59) + this.xPref.GetHashCode();
                }
                if (this.dhTrem != null)
                {
                    hashCode = (hashCode * 59) + this.dhTrem.GetHashCode();
                }
                if (this.xOri != null)
                {
                    hashCode = (hashCode * 59) + this.xOri.GetHashCode();
                }
                if (this.xDest != null)
                {
                    hashCode = (hashCode * 59) + this.xDest.GetHashCode();
                }
                if (this.qVag != null)
                {
                    hashCode = (hashCode * 59) + this.qVag.GetHashCode();
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
            // xPref (string) maxLength
            if (this.xPref != null && this.xPref.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xPref, length must be less than 10.", new [] { "xPref" });
            }

            // xPref (string) minLength
            if (this.xPref != null && this.xPref.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xPref, length must be greater than 1.", new [] { "xPref" });
            }

            // xOri (string) maxLength
            if (this.xOri != null && this.xOri.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xOri, length must be less than 3.", new [] { "xOri" });
            }

            // xOri (string) minLength
            if (this.xOri != null && this.xOri.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xOri, length must be greater than 1.", new [] { "xOri" });
            }

            // xDest (string) maxLength
            if (this.xDest != null && this.xDest.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDest, length must be less than 3.", new [] { "xDest" });
            }

            // xDest (string) minLength
            if (this.xDest != null && this.xDest.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDest, length must be greater than 1.", new [] { "xDest" });
            }

            // qVag (int?) maximum
            if (this.qVag > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qVag, must be a value less than or equal to 999.", new [] { "qVag" });
            }

            // qVag (int?) minimum
            if (this.qVag < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qVag, must be a value greater than or equal to 1.", new [] { "qVag" });
            }

            yield break;
        }
    }

}
