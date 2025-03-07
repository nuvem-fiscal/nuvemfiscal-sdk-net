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
    /// Grupo de informações do programa de fidelidade do assinante.
    /// </summary>
    [DataContract(Name = "NfcomSefazGFidelidade")]
    public partial class NfcomSefazGFidelidade : IEquatable<NfcomSefazGFidelidade>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGFidelidade" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGFidelidade() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGFidelidade" /> class.
        /// </summary>
        /// <param name="qtdSaldoPts">Saldo de pontos do cliente na  data de referência. (required).</param>
        /// <param name="dRefSaldoPts">Data de aferição do saldo de pontos.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="qtdPtsResg">Qtd de pontos resgatados na  data de referência. (required).</param>
        /// <param name="dRefResgPts">Data de resgate dos pontos.  Formato AAAA-MM-DD. (required).</param>
        public NfcomSefazGFidelidade(string qtdSaldoPts = default(string), DateTime? dRefSaldoPts = default(DateTime?), string qtdPtsResg = default(string), DateTime? dRefResgPts = default(DateTime?))
        {
            // to ensure "qtdSaldoPts" is required (not null)
            if (qtdSaldoPts == null)
            {
                throw new ArgumentNullException("qtdSaldoPts is a required property for NfcomSefazGFidelidade and cannot be null");
            }
            this.qtdSaldoPts = qtdSaldoPts;
            // to ensure "dRefSaldoPts" is required (not null)
            if (dRefSaldoPts == null)
            {
                throw new ArgumentNullException("dRefSaldoPts is a required property for NfcomSefazGFidelidade and cannot be null");
            }
            this.dRefSaldoPts = dRefSaldoPts;
            // to ensure "qtdPtsResg" is required (not null)
            if (qtdPtsResg == null)
            {
                throw new ArgumentNullException("qtdPtsResg is a required property for NfcomSefazGFidelidade and cannot be null");
            }
            this.qtdPtsResg = qtdPtsResg;
            // to ensure "dRefResgPts" is required (not null)
            if (dRefResgPts == null)
            {
                throw new ArgumentNullException("dRefResgPts is a required property for NfcomSefazGFidelidade and cannot be null");
            }
            this.dRefResgPts = dRefResgPts;
        }

        /// <summary>
        /// Saldo de pontos do cliente na  data de referência.
        /// </summary>
        /// <value>Saldo de pontos do cliente na  data de referência.</value>
        [DataMember(Name = "qtdSaldoPts", IsRequired = true, EmitDefaultValue = true)]
        public string qtdSaldoPts { get; set; }

        /// <summary>
        /// Data de aferição do saldo de pontos.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de aferição do saldo de pontos.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dRefSaldoPts", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dRefSaldoPts { get; set; }

        /// <summary>
        /// Qtd de pontos resgatados na  data de referência.
        /// </summary>
        /// <value>Qtd de pontos resgatados na  data de referência.</value>
        [DataMember(Name = "qtdPtsResg", IsRequired = true, EmitDefaultValue = true)]
        public string qtdPtsResg { get; set; }

        /// <summary>
        /// Data de resgate dos pontos.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de resgate dos pontos.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dRefResgPts", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dRefResgPts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGFidelidade {\n");
            sb.Append("  qtdSaldoPts: ").Append(qtdSaldoPts).Append("\n");
            sb.Append("  dRefSaldoPts: ").Append(dRefSaldoPts).Append("\n");
            sb.Append("  qtdPtsResg: ").Append(qtdPtsResg).Append("\n");
            sb.Append("  dRefResgPts: ").Append(dRefResgPts).Append("\n");
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
            return this.Equals(input as NfcomSefazGFidelidade);
        }

        /// <summary>
        /// Returns true if NfcomSefazGFidelidade instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGFidelidade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGFidelidade input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qtdSaldoPts == input.qtdSaldoPts ||
                    (this.qtdSaldoPts != null &&
                    this.qtdSaldoPts.Equals(input.qtdSaldoPts))
                ) && 
                (
                    this.dRefSaldoPts == input.dRefSaldoPts ||
                    (this.dRefSaldoPts != null &&
                    this.dRefSaldoPts.Equals(input.dRefSaldoPts))
                ) && 
                (
                    this.qtdPtsResg == input.qtdPtsResg ||
                    (this.qtdPtsResg != null &&
                    this.qtdPtsResg.Equals(input.qtdPtsResg))
                ) && 
                (
                    this.dRefResgPts == input.dRefResgPts ||
                    (this.dRefResgPts != null &&
                    this.dRefResgPts.Equals(input.dRefResgPts))
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
                if (this.qtdSaldoPts != null)
                {
                    hashCode = (hashCode * 59) + this.qtdSaldoPts.GetHashCode();
                }
                if (this.dRefSaldoPts != null)
                {
                    hashCode = (hashCode * 59) + this.dRefSaldoPts.GetHashCode();
                }
                if (this.qtdPtsResg != null)
                {
                    hashCode = (hashCode * 59) + this.qtdPtsResg.GetHashCode();
                }
                if (this.dRefResgPts != null)
                {
                    hashCode = (hashCode * 59) + this.dRefResgPts.GetHashCode();
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
            // qtdSaldoPts (string) maxLength
            if (this.qtdSaldoPts != null && this.qtdSaldoPts.Length > 20)
            {
                yield return new ValidationResult("Invalid value for qtdSaldoPts, length must be less than 20.", new [] { "qtdSaldoPts" });
            }

            // qtdSaldoPts (string) minLength
            if (this.qtdSaldoPts != null && this.qtdSaldoPts.Length < 1)
            {
                yield return new ValidationResult("Invalid value for qtdSaldoPts, length must be greater than 1.", new [] { "qtdSaldoPts" });
            }

            // qtdPtsResg (string) maxLength
            if (this.qtdPtsResg != null && this.qtdPtsResg.Length > 20)
            {
                yield return new ValidationResult("Invalid value for qtdPtsResg, length must be less than 20.", new [] { "qtdPtsResg" });
            }

            // qtdPtsResg (string) minLength
            if (this.qtdPtsResg != null && this.qtdPtsResg.Length < 1)
            {
                yield return new ValidationResult("Invalid value for qtdPtsResg, length must be greater than 1.", new [] { "qtdPtsResg" });
            }

            yield break;
        }
    }

}
