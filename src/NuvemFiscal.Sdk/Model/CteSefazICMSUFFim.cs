/*
 * API Nuvem Fiscal
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
    /// CteSefazICMSUFFim
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
        public CteSefazICMSUFFim(decimal vBCUFFim = default(decimal), decimal pFCPUFFim = default(decimal), decimal pICMSUFFim = default(decimal), decimal pICMSInter = default(decimal), decimal vFCPUFFim = default(decimal), decimal vICMSUFFim = default(decimal), decimal vICMSUFIni = default(decimal))
        {
            this.vBCUFFim = vBCUFFim;
            this.pFCPUFFim = pFCPUFFim;
            this.pICMSUFFim = pICMSUFFim;
            this.pICMSInter = pICMSInter;
            this.vFCPUFFim = vFCPUFFim;
            this.vICMSUFFim = vICMSUFFim;
            this.vICMSUFIni = vICMSUFIni;
        }

        /// <summary>
        /// Valor da BC do ICMS na UF de término da prestação do serviço de transporte.
        /// </summary>
        /// <value>Valor da BC do ICMS na UF de término da prestação do serviço de transporte.</value>
        [DataMember(Name = "vBCUFFim", IsRequired = true, EmitDefaultValue = false)]
        public decimal vBCUFFim { get; set; }

        /// <summary>
        /// Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.
        /// </summary>
        /// <value>Percentual do ICMS relativo ao Fundo de Combate à pobreza (FCP) na UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.</value>
        [DataMember(Name = "pFCPUFFim", IsRequired = true, EmitDefaultValue = false)]
        public decimal pFCPUFFim { get; set; }

        /// <summary>
        /// Alíquota interna da UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.
        /// </summary>
        /// <value>Alíquota interna da UF de término da prestação do serviço de transporte.  Alíquota adotada nas operações internas na UF do destinatário.</value>
        [DataMember(Name = "pICMSUFFim", IsRequired = true, EmitDefaultValue = false)]
        public decimal pICMSUFFim { get; set; }

        /// <summary>
        /// Alíquota interestadual das UF envolvidas.  Alíquota interestadual das UF envolvidas.
        /// </summary>
        /// <value>Alíquota interestadual das UF envolvidas.  Alíquota interestadual das UF envolvidas.</value>
        [DataMember(Name = "pICMSInter", IsRequired = true, EmitDefaultValue = false)]
        public decimal pICMSInter { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de término da prestação.
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate á Pobreza (FCP) da UF de término da prestação.</value>
        [DataMember(Name = "vFCPUFFim", IsRequired = true, EmitDefaultValue = false)]
        public decimal vFCPUFFim { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF de término da prestação do serviço de transporte.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF de término da prestação do serviço de transporte.</value>
        [DataMember(Name = "vICMSUFFim", IsRequired = true, EmitDefaultValue = false)]
        public decimal vICMSUFFim { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF de início da prestação do serviço de transporte.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF de início da prestação do serviço de transporte.</value>
        [DataMember(Name = "vICMSUFIni", IsRequired = true, EmitDefaultValue = false)]
        public decimal vICMSUFIni { get; set; }

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
                    this.vBCUFFim.Equals(input.vBCUFFim)
                ) && 
                (
                    this.pFCPUFFim == input.pFCPUFFim ||
                    this.pFCPUFFim.Equals(input.pFCPUFFim)
                ) && 
                (
                    this.pICMSUFFim == input.pICMSUFFim ||
                    this.pICMSUFFim.Equals(input.pICMSUFFim)
                ) && 
                (
                    this.pICMSInter == input.pICMSInter ||
                    this.pICMSInter.Equals(input.pICMSInter)
                ) && 
                (
                    this.vFCPUFFim == input.vFCPUFFim ||
                    this.vFCPUFFim.Equals(input.vFCPUFFim)
                ) && 
                (
                    this.vICMSUFFim == input.vICMSUFFim ||
                    this.vICMSUFFim.Equals(input.vICMSUFFim)
                ) && 
                (
                    this.vICMSUFIni == input.vICMSUFIni ||
                    this.vICMSUFIni.Equals(input.vICMSUFIni)
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
                hashCode = (hashCode * 59) + this.vBCUFFim.GetHashCode();
                hashCode = (hashCode * 59) + this.pFCPUFFim.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSUFFim.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSInter.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPUFFim.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSUFFim.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSUFIni.GetHashCode();
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
