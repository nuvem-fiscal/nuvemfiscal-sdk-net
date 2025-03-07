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
    /// Informações do ICMS de partilha com a UF de término do serviço de transporte na operação interestadual.  Grupo a ser informado nas prestações interestaduais para consumidor final, não contribuinte do ICMS.
    /// </summary>
    [DataContract(Name = "CteSefazICMSUFFim")]
    public partial class CteSefazICMSUFFim : IEquatable<CteSefazICMSUFFim>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMSUFFim" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazICMSUFFim() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMSUFFim" /> class.
        /// </summary>
        /// <param name="vBCUFFim">Valor da BC do ICMS na UF de término da prestação do serviço de transporte. (required).</param>
        /// <param name="pFCPUFFim">Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário. (required).</param>
        /// <param name="pICMSUFFim">Alíquota interna da UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário. (required).</param>
        /// <param name="pICMSInter">Alíquota interestadual das UF envolvidas.  Alíquota interestadual das UF envolvidas. (required).</param>
        /// <param name="vFCPUFFim">Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de término da prestação. (required).</param>
        /// <param name="vICMSUFFim">Valor do ICMS de partilha para a UF de término da prestação do serviço de transporte. (required).</param>
        /// <param name="vICMSUFIni">Valor do ICMS de partilha para a UF de início da prestação do serviço de transporte. (required).</param>
        public CteSefazICMSUFFim(decimal? vBCUFFim = default(decimal?), decimal? pFCPUFFim = default(decimal?), decimal? pICMSUFFim = default(decimal?), decimal? pICMSInter = default(decimal?), decimal? vFCPUFFim = default(decimal?), decimal? vICMSUFFim = default(decimal?), decimal? vICMSUFIni = default(decimal?))
        {
            // to ensure "vBCUFFim" is required (not null)
            if (vBCUFFim == null)
            {
                throw new ArgumentNullException("vBCUFFim is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.vBCUFFim = vBCUFFim;
            // to ensure "pFCPUFFim" is required (not null)
            if (pFCPUFFim == null)
            {
                throw new ArgumentNullException("pFCPUFFim is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.pFCPUFFim = pFCPUFFim;
            // to ensure "pICMSUFFim" is required (not null)
            if (pICMSUFFim == null)
            {
                throw new ArgumentNullException("pICMSUFFim is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.pICMSUFFim = pICMSUFFim;
            // to ensure "pICMSInter" is required (not null)
            if (pICMSInter == null)
            {
                throw new ArgumentNullException("pICMSInter is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.pICMSInter = pICMSInter;
            // to ensure "vFCPUFFim" is required (not null)
            if (vFCPUFFim == null)
            {
                throw new ArgumentNullException("vFCPUFFim is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.vFCPUFFim = vFCPUFFim;
            // to ensure "vICMSUFFim" is required (not null)
            if (vICMSUFFim == null)
            {
                throw new ArgumentNullException("vICMSUFFim is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.vICMSUFFim = vICMSUFFim;
            // to ensure "vICMSUFIni" is required (not null)
            if (vICMSUFIni == null)
            {
                throw new ArgumentNullException("vICMSUFIni is a required property for CteSefazICMSUFFim and cannot be null");
            }
            this.vICMSUFIni = vICMSUFIni;
        }

        /// <summary>
        /// Valor da BC do ICMS na UF de término da prestação do serviço de transporte.
        /// </summary>
        /// <value>Valor da BC do ICMS na UF de término da prestação do serviço de transporte.</value>
        [DataMember(Name = "vBCUFFim", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCUFFim { get; set; }

        /// <summary>
        /// Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.
        /// </summary>
        /// <value>Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.</value>
        [DataMember(Name = "pFCPUFFim", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pFCPUFFim { get; set; }

        /// <summary>
        /// Alíquota interna da UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.
        /// </summary>
        /// <value>Alíquota interna da UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.</value>
        [DataMember(Name = "pICMSUFFim", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSUFFim { get; set; }

        /// <summary>
        /// Alíquota interestadual das UF envolvidas.  Alíquota interestadual das UF envolvidas.
        /// </summary>
        /// <value>Alíquota interestadual das UF envolvidas.  Alíquota interestadual das UF envolvidas.</value>
        [DataMember(Name = "pICMSInter", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSInter { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de término da prestação.
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de término da prestação.</value>
        [DataMember(Name = "vFCPUFFim", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFCPUFFim { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF de término da prestação do serviço de transporte.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF de término da prestação do serviço de transporte.</value>
        [DataMember(Name = "vICMSUFFim", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSUFFim { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF de início da prestação do serviço de transporte.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF de início da prestação do serviço de transporte.</value>
        [DataMember(Name = "vICMSUFIni", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSUFIni { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazICMSUFFim {\n");
            sb.Append("  vBCUFFim: ").Append(vBCUFFim).Append("\n");
            sb.Append("  pFCPUFFim: ").Append(pFCPUFFim).Append("\n");
            sb.Append("  pICMSUFFim: ").Append(pICMSUFFim).Append("\n");
            sb.Append("  pICMSInter: ").Append(pICMSInter).Append("\n");
            sb.Append("  vFCPUFFim: ").Append(vFCPUFFim).Append("\n");
            sb.Append("  vICMSUFFim: ").Append(vICMSUFFim).Append("\n");
            sb.Append("  vICMSUFIni: ").Append(vICMSUFIni).Append("\n");
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
            return this.Equals(input as CteSefazICMSUFFim);
        }

        /// <summary>
        /// Returns true if CteSefazICMSUFFim instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazICMSUFFim to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazICMSUFFim input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBCUFFim == input.vBCUFFim ||
                    (this.vBCUFFim != null &&
                    this.vBCUFFim.Equals(input.vBCUFFim))
                ) && 
                (
                    this.pFCPUFFim == input.pFCPUFFim ||
                    (this.pFCPUFFim != null &&
                    this.pFCPUFFim.Equals(input.pFCPUFFim))
                ) && 
                (
                    this.pICMSUFFim == input.pICMSUFFim ||
                    (this.pICMSUFFim != null &&
                    this.pICMSUFFim.Equals(input.pICMSUFFim))
                ) && 
                (
                    this.pICMSInter == input.pICMSInter ||
                    (this.pICMSInter != null &&
                    this.pICMSInter.Equals(input.pICMSInter))
                ) && 
                (
                    this.vFCPUFFim == input.vFCPUFFim ||
                    (this.vFCPUFFim != null &&
                    this.vFCPUFFim.Equals(input.vFCPUFFim))
                ) && 
                (
                    this.vICMSUFFim == input.vICMSUFFim ||
                    (this.vICMSUFFim != null &&
                    this.vICMSUFFim.Equals(input.vICMSUFFim))
                ) && 
                (
                    this.vICMSUFIni == input.vICMSUFIni ||
                    (this.vICMSUFIni != null &&
                    this.vICMSUFIni.Equals(input.vICMSUFIni))
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
                if (this.vBCUFFim != null)
                {
                    hashCode = (hashCode * 59) + this.vBCUFFim.GetHashCode();
                }
                if (this.pFCPUFFim != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPUFFim.GetHashCode();
                }
                if (this.pICMSUFFim != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSUFFim.GetHashCode();
                }
                if (this.pICMSInter != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSInter.GetHashCode();
                }
                if (this.vFCPUFFim != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPUFFim.GetHashCode();
                }
                if (this.vICMSUFFim != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSUFFim.GetHashCode();
                }
                if (this.vICMSUFIni != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSUFIni.GetHashCode();
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
            // vBCUFFim (decimal?) minimum
            if (this.vBCUFFim < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBCUFFim, must be a value greater than or equal to 0.", new [] { "vBCUFFim" });
            }

            // pFCPUFFim (decimal?) minimum
            if (this.pFCPUFFim < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pFCPUFFim, must be a value greater than or equal to 0.", new [] { "pFCPUFFim" });
            }

            // pICMSUFFim (decimal?) minimum
            if (this.pICMSUFFim < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pICMSUFFim, must be a value greater than or equal to 0.", new [] { "pICMSUFFim" });
            }

            // pICMSInter (decimal?) minimum
            if (this.pICMSInter < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pICMSInter, must be a value greater than or equal to 0.", new [] { "pICMSInter" });
            }

            // vFCPUFFim (decimal?) minimum
            if (this.vFCPUFFim < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vFCPUFFim, must be a value greater than or equal to 0.", new [] { "vFCPUFFim" });
            }

            // vICMSUFFim (decimal?) minimum
            if (this.vICMSUFFim < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vICMSUFFim, must be a value greater than or equal to 0.", new [] { "vICMSUFFim" });
            }

            // vICMSUFIni (decimal?) minimum
            if (this.vICMSUFIni < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vICMSUFIni, must be a value greater than or equal to 0.", new [] { "vICMSUFIni" });
            }

            yield break;
        }
    }

}
