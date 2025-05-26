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
    /// Dados complementares do CT-e para fins operacionais ou comerciais.
    /// </summary>
    [DataContract(Name = "CteOsSefazComplOS")]
    public partial class CteOsSefazComplOS : IEquatable<CteOsSefazComplOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazComplOS" /> class.
        /// </summary>
        /// <param name="xCaracAd">Característica adicional do transporte.  Texto livre:  REENTREGA  DEVOLUÇÃO  REFATURAMENTO  etc..</param>
        /// <param name="xCaracSer">Característica adicional do serviço.  Texto livre:  ENTREGA EXPRESSA  LOGÍSTICA REVERSA  CONVENCIONAL  EMERGENCIAL  etc..</param>
        /// <param name="xEmi">Funcionário emissor do CTe..</param>
        /// <param name="xObs">Observações Gerais..</param>
        /// <param name="obsCont">obsCont.</param>
        /// <param name="obsFisco">obsFisco.</param>
        public CteOsSefazComplOS(string xCaracAd = default(string), string xCaracSer = default(string), string xEmi = default(string), string xObs = default(string), List<CteOsSefazObsContOS> obsCont = default(List<CteOsSefazObsContOS>), List<CteOsSefazObsFiscoOS> obsFisco = default(List<CteOsSefazObsFiscoOS>))
        {
            this.xCaracAd = xCaracAd;
            this.xCaracSer = xCaracSer;
            this.xEmi = xEmi;
            this.xObs = xObs;
            this.ObsCont = obsCont;
            this.ObsFisco = obsFisco;
        }

        /// <summary>
        /// Característica adicional do transporte.  Texto livre:  REENTREGA  DEVOLUÇÃO  REFATURAMENTO  etc.
        /// </summary>
        /// <value>Característica adicional do transporte.  Texto livre:  REENTREGA  DEVOLUÇÃO  REFATURAMENTO  etc.</value>
        [DataMember(Name = "xCaracAd", EmitDefaultValue = true)]
        public string xCaracAd { get; set; }

        /// <summary>
        /// Característica adicional do serviço.  Texto livre:  ENTREGA EXPRESSA  LOGÍSTICA REVERSA  CONVENCIONAL  EMERGENCIAL  etc.
        /// </summary>
        /// <value>Característica adicional do serviço.  Texto livre:  ENTREGA EXPRESSA  LOGÍSTICA REVERSA  CONVENCIONAL  EMERGENCIAL  etc.</value>
        [DataMember(Name = "xCaracSer", EmitDefaultValue = true)]
        public string xCaracSer { get; set; }

        /// <summary>
        /// Funcionário emissor do CTe.
        /// </summary>
        /// <value>Funcionário emissor do CTe.</value>
        [DataMember(Name = "xEmi", EmitDefaultValue = true)]
        public string xEmi { get; set; }

        /// <summary>
        /// Observações Gerais.
        /// </summary>
        /// <value>Observações Gerais.</value>
        [DataMember(Name = "xObs", EmitDefaultValue = true)]
        public string xObs { get; set; }

        /// <summary>
        /// Gets or Sets ObsCont
        /// </summary>
        [DataMember(Name = "ObsCont", EmitDefaultValue = false)]
        public List<CteOsSefazObsContOS> ObsCont { get; set; }

        /// <summary>
        /// Gets or Sets ObsFisco
        /// </summary>
        [DataMember(Name = "ObsFisco", EmitDefaultValue = false)]
        public List<CteOsSefazObsFiscoOS> ObsFisco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazComplOS {\n");
            sb.Append("  xCaracAd: ").Append(xCaracAd).Append("\n");
            sb.Append("  xCaracSer: ").Append(xCaracSer).Append("\n");
            sb.Append("  xEmi: ").Append(xEmi).Append("\n");
            sb.Append("  xObs: ").Append(xObs).Append("\n");
            sb.Append("  ObsCont: ").Append(ObsCont).Append("\n");
            sb.Append("  ObsFisco: ").Append(ObsFisco).Append("\n");
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
            return this.Equals(input as CteOsSefazComplOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazComplOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazComplOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazComplOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xCaracAd == input.xCaracAd ||
                    (this.xCaracAd != null &&
                    this.xCaracAd.Equals(input.xCaracAd))
                ) && 
                (
                    this.xCaracSer == input.xCaracSer ||
                    (this.xCaracSer != null &&
                    this.xCaracSer.Equals(input.xCaracSer))
                ) && 
                (
                    this.xEmi == input.xEmi ||
                    (this.xEmi != null &&
                    this.xEmi.Equals(input.xEmi))
                ) && 
                (
                    this.xObs == input.xObs ||
                    (this.xObs != null &&
                    this.xObs.Equals(input.xObs))
                ) && 
                (
                    this.ObsCont == input.ObsCont ||
                    this.ObsCont != null &&
                    input.ObsCont != null &&
                    this.ObsCont.SequenceEqual(input.ObsCont)
                ) && 
                (
                    this.ObsFisco == input.ObsFisco ||
                    this.ObsFisco != null &&
                    input.ObsFisco != null &&
                    this.ObsFisco.SequenceEqual(input.ObsFisco)
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
                if (this.xCaracAd != null)
                {
                    hashCode = (hashCode * 59) + this.xCaracAd.GetHashCode();
                }
                if (this.xCaracSer != null)
                {
                    hashCode = (hashCode * 59) + this.xCaracSer.GetHashCode();
                }
                if (this.xEmi != null)
                {
                    hashCode = (hashCode * 59) + this.xEmi.GetHashCode();
                }
                if (this.xObs != null)
                {
                    hashCode = (hashCode * 59) + this.xObs.GetHashCode();
                }
                if (this.ObsCont != null)
                {
                    hashCode = (hashCode * 59) + this.ObsCont.GetHashCode();
                }
                if (this.ObsFisco != null)
                {
                    hashCode = (hashCode * 59) + this.ObsFisco.GetHashCode();
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
            // xCaracAd (string) maxLength
            if (this.xCaracAd != null && this.xCaracAd.Length > 15)
            {
                yield return new ValidationResult("Invalid value for xCaracAd, length must be less than 15.", new [] { "xCaracAd" });
            }

            // xCaracAd (string) minLength
            if (this.xCaracAd != null && this.xCaracAd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xCaracAd, length must be greater than 1.", new [] { "xCaracAd" });
            }

            // xCaracSer (string) maxLength
            if (this.xCaracSer != null && this.xCaracSer.Length > 30)
            {
                yield return new ValidationResult("Invalid value for xCaracSer, length must be less than 30.", new [] { "xCaracSer" });
            }

            // xCaracSer (string) minLength
            if (this.xCaracSer != null && this.xCaracSer.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xCaracSer, length must be greater than 1.", new [] { "xCaracSer" });
            }

            // xEmi (string) maxLength
            if (this.xEmi != null && this.xEmi.Length > 20)
            {
                yield return new ValidationResult("Invalid value for xEmi, length must be less than 20.", new [] { "xEmi" });
            }

            // xEmi (string) minLength
            if (this.xEmi != null && this.xEmi.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xEmi, length must be greater than 1.", new [] { "xEmi" });
            }

            // xObs (string) maxLength
            if (this.xObs != null && this.xObs.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for xObs, length must be less than 2000.", new [] { "xObs" });
            }

            // xObs (string) minLength
            if (this.xObs != null && this.xObs.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xObs, length must be greater than 1.", new [] { "xObs" });
            }

            yield break;
        }
    }

}
