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
    /// Informações do ICMS de partilha com a UF destinatária.
    /// </summary>
    [DataContract(Name = "NfcomSefazICMSUFDest")]
    public partial class NfcomSefazICMSUFDest : IEquatable<NfcomSefazICMSUFDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazICMSUFDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazICMSUFDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazICMSUFDest" /> class.
        /// </summary>
        /// <param name="cUFDest">cUFDest.</param>
        /// <param name="vBCUFDest">Valor da BC do ICMS na UF de destino. (required).</param>
        /// <param name="pFCPUFDest">Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de destino.  Alíquota adotada nas operações internas na UF do destinatário. (required).</param>
        /// <param name="pICMSUFDest">Alíquota interna da UF de destino.  Alíquota adotada nas operações internas na UF do destinatário. (required).</param>
        /// <param name="vFCPUFDest">Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de destino. (required).</param>
        /// <param name="vICMSUFDest">Valor do ICMS de partilha para a UF de destino. (required).</param>
        /// <param name="vICMSUFEmi">Valor do ICMS de partilha para a UF de emissão. (required).</param>
        /// <param name="cBenefUFDest">Código de Benefício Fiscal na UF destino aplicado ao item.  Código de Benefício Fiscal utilizado pela UF, aplicado ao  item..</param>
        public NfcomSefazICMSUFDest(int? cUFDest = default(int?), decimal? vBCUFDest = default(decimal?), decimal? pFCPUFDest = default(decimal?), decimal? pICMSUFDest = default(decimal?), decimal? vFCPUFDest = default(decimal?), decimal? vICMSUFDest = default(decimal?), decimal? vICMSUFEmi = default(decimal?), string cBenefUFDest = default(string))
        {
            // to ensure "vBCUFDest" is required (not null)
            if (vBCUFDest == null)
            {
                throw new ArgumentNullException("vBCUFDest is a required property for NfcomSefazICMSUFDest and cannot be null");
            }
            this.vBCUFDest = vBCUFDest;
            // to ensure "pFCPUFDest" is required (not null)
            if (pFCPUFDest == null)
            {
                throw new ArgumentNullException("pFCPUFDest is a required property for NfcomSefazICMSUFDest and cannot be null");
            }
            this.pFCPUFDest = pFCPUFDest;
            // to ensure "pICMSUFDest" is required (not null)
            if (pICMSUFDest == null)
            {
                throw new ArgumentNullException("pICMSUFDest is a required property for NfcomSefazICMSUFDest and cannot be null");
            }
            this.pICMSUFDest = pICMSUFDest;
            // to ensure "vFCPUFDest" is required (not null)
            if (vFCPUFDest == null)
            {
                throw new ArgumentNullException("vFCPUFDest is a required property for NfcomSefazICMSUFDest and cannot be null");
            }
            this.vFCPUFDest = vFCPUFDest;
            // to ensure "vICMSUFDest" is required (not null)
            if (vICMSUFDest == null)
            {
                throw new ArgumentNullException("vICMSUFDest is a required property for NfcomSefazICMSUFDest and cannot be null");
            }
            this.vICMSUFDest = vICMSUFDest;
            // to ensure "vICMSUFEmi" is required (not null)
            if (vICMSUFEmi == null)
            {
                throw new ArgumentNullException("vICMSUFEmi is a required property for NfcomSefazICMSUFDest and cannot be null");
            }
            this.vICMSUFEmi = vICMSUFEmi;
            this.cUFDest = cUFDest;
            this.cBenefUFDest = cBenefUFDest;
        }

        /// <summary>
        /// Gets or Sets cUFDest
        /// </summary>
        [DataMember(Name = "cUFDest", EmitDefaultValue = true)]
        public int? cUFDest { get; set; }

        /// <summary>
        /// Valor da BC do ICMS na UF de destino.
        /// </summary>
        /// <value>Valor da BC do ICMS na UF de destino.</value>
        [DataMember(Name = "vBCUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCUFDest { get; set; }

        /// <summary>
        /// Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de destino.  Alíquota adotada nas operações internas na UF do destinatário.
        /// </summary>
        /// <value>Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de destino.  Alíquota adotada nas operações internas na UF do destinatário.</value>
        [DataMember(Name = "pFCPUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pFCPUFDest { get; set; }

        /// <summary>
        /// Alíquota interna da UF de destino.  Alíquota adotada nas operações internas na UF do destinatário.
        /// </summary>
        /// <value>Alíquota interna da UF de destino.  Alíquota adotada nas operações internas na UF do destinatário.</value>
        [DataMember(Name = "pICMSUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSUFDest { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de destino.
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de destino.</value>
        [DataMember(Name = "vFCPUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFCPUFDest { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF de destino.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF de destino.</value>
        [DataMember(Name = "vICMSUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSUFDest { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF de emissão.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF de emissão.</value>
        [DataMember(Name = "vICMSUFEmi", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSUFEmi { get; set; }

        /// <summary>
        /// Código de Benefício Fiscal na UF destino aplicado ao item.  Código de Benefício Fiscal utilizado pela UF, aplicado ao  item.
        /// </summary>
        /// <value>Código de Benefício Fiscal na UF destino aplicado ao item.  Código de Benefício Fiscal utilizado pela UF, aplicado ao  item.</value>
        [DataMember(Name = "cBenefUFDest", EmitDefaultValue = true)]
        public string cBenefUFDest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazICMSUFDest {\n");
            sb.Append("  cUFDest: ").Append(cUFDest).Append("\n");
            sb.Append("  vBCUFDest: ").Append(vBCUFDest).Append("\n");
            sb.Append("  pFCPUFDest: ").Append(pFCPUFDest).Append("\n");
            sb.Append("  pICMSUFDest: ").Append(pICMSUFDest).Append("\n");
            sb.Append("  vFCPUFDest: ").Append(vFCPUFDest).Append("\n");
            sb.Append("  vICMSUFDest: ").Append(vICMSUFDest).Append("\n");
            sb.Append("  vICMSUFEmi: ").Append(vICMSUFEmi).Append("\n");
            sb.Append("  cBenefUFDest: ").Append(cBenefUFDest).Append("\n");
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
            return this.Equals(input as NfcomSefazICMSUFDest);
        }

        /// <summary>
        /// Returns true if NfcomSefazICMSUFDest instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazICMSUFDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazICMSUFDest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cUFDest == input.cUFDest ||
                    (this.cUFDest != null &&
                    this.cUFDest.Equals(input.cUFDest))
                ) && 
                (
                    this.vBCUFDest == input.vBCUFDest ||
                    (this.vBCUFDest != null &&
                    this.vBCUFDest.Equals(input.vBCUFDest))
                ) && 
                (
                    this.pFCPUFDest == input.pFCPUFDest ||
                    (this.pFCPUFDest != null &&
                    this.pFCPUFDest.Equals(input.pFCPUFDest))
                ) && 
                (
                    this.pICMSUFDest == input.pICMSUFDest ||
                    (this.pICMSUFDest != null &&
                    this.pICMSUFDest.Equals(input.pICMSUFDest))
                ) && 
                (
                    this.vFCPUFDest == input.vFCPUFDest ||
                    (this.vFCPUFDest != null &&
                    this.vFCPUFDest.Equals(input.vFCPUFDest))
                ) && 
                (
                    this.vICMSUFDest == input.vICMSUFDest ||
                    (this.vICMSUFDest != null &&
                    this.vICMSUFDest.Equals(input.vICMSUFDest))
                ) && 
                (
                    this.vICMSUFEmi == input.vICMSUFEmi ||
                    (this.vICMSUFEmi != null &&
                    this.vICMSUFEmi.Equals(input.vICMSUFEmi))
                ) && 
                (
                    this.cBenefUFDest == input.cBenefUFDest ||
                    (this.cBenefUFDest != null &&
                    this.cBenefUFDest.Equals(input.cBenefUFDest))
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
                if (this.cUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.cUFDest.GetHashCode();
                }
                if (this.vBCUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.vBCUFDest.GetHashCode();
                }
                if (this.pFCPUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPUFDest.GetHashCode();
                }
                if (this.pICMSUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSUFDest.GetHashCode();
                }
                if (this.vFCPUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPUFDest.GetHashCode();
                }
                if (this.vICMSUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSUFDest.GetHashCode();
                }
                if (this.vICMSUFEmi != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSUFEmi.GetHashCode();
                }
                if (this.cBenefUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.cBenefUFDest.GetHashCode();
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
            // vBCUFDest (decimal?) minimum
            if (this.vBCUFDest < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCUFDest, must be a value greater than or equal to 0.", new [] { "vBCUFDest" });
            }

            // pFCPUFDest (decimal?) minimum
            if (this.pFCPUFDest < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCPUFDest, must be a value greater than or equal to 0.", new [] { "pFCPUFDest" });
            }

            // pICMSUFDest (decimal?) minimum
            if (this.pICMSUFDest < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pICMSUFDest, must be a value greater than or equal to 0.", new [] { "pICMSUFDest" });
            }

            // vFCPUFDest (decimal?) minimum
            if (this.vFCPUFDest < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPUFDest, must be a value greater than or equal to 0.", new [] { "vFCPUFDest" });
            }

            // vICMSUFDest (decimal?) minimum
            if (this.vICMSUFDest < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSUFDest, must be a value greater than or equal to 0.", new [] { "vICMSUFDest" });
            }

            // vICMSUFEmi (decimal?) minimum
            if (this.vICMSUFEmi < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSUFEmi, must be a value greater than or equal to 0.", new [] { "vICMSUFEmi" });
            }

            // cBenefUFDest (string) maxLength
            if (this.cBenefUFDest != null && this.cBenefUFDest.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cBenefUFDest, length must be less than 10.", new [] { "cBenefUFDest" });
            }

            yield break;
        }
    }

}
