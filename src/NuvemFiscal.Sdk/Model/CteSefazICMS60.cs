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
    /// CteSefazICMS60
    /// </summary>
    [DataContract(Name = "CteSefazICMS60")]
    public partial class CteSefazICMS60 : IEquatable<CteSefazICMS60>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMS60" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazICMS60() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMS60" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do Serviço.  60 - ICMS cobrado por substituição tributária. (required).</param>
        /// <param name="vBCSTRet">Valor da BC do ICMS ST retido.  Valor do frete sobre o qual será calculado o ICMS a ser substituído na Prestação. (required).</param>
        /// <param name="vICMSSTRet">Valor do ICMS ST retido.  Resultado da multiplicação do “vBCSTRet” x “pICMSSTRet” – que será valor do ICMS a ser retido pelo Substituto. Podendo o valor do ICMS a ser retido efetivamente, sofrer ajustes conforme a opção tributaria do transportador substituído. (required).</param>
        /// <param name="pICMSSTRet">Alíquota do ICMS.  Percentual de Alíquota incidente na prestação de serviço de transporte. (required).</param>
        /// <param name="vCred">Valor do Crédito outorgado/Presumido.  Preencher somente quando o transportador substituído, for optante pelo crédito outorgado previsto no Convênio 106/96 e corresponde ao percentual de 20%% do valor do ICMS ST retido..</param>
        public CteSefazICMS60(string cST = default(string), decimal vBCSTRet = default(decimal), decimal vICMSSTRet = default(decimal), decimal pICMSSTRet = default(decimal), decimal vCred = default(decimal))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSefazICMS60 and cannot be null");
            }
            this.CST = cST;
            this.vBCSTRet = vBCSTRet;
            this.vICMSSTRet = vICMSSTRet;
            this.pICMSSTRet = pICMSSTRet;
            this.vCred = vCred;
        }

        /// <summary>
        /// Classificação Tributária do Serviço.  60 - ICMS cobrado por substituição tributária.
        /// </summary>
        /// <value>Classificação Tributária do Serviço.  60 - ICMS cobrado por substituição tributária.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = false)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST retido.  Valor do frete sobre o qual será calculado o ICMS a ser substituído na Prestação.
        /// </summary>
        /// <value>Valor da BC do ICMS ST retido.  Valor do frete sobre o qual será calculado o ICMS a ser substituído na Prestação.</value>
        [DataMember(Name = "vBCSTRet", IsRequired = true, EmitDefaultValue = false)]
        public decimal vBCSTRet { get; set; }

        /// <summary>
        /// Valor do ICMS ST retido.  Resultado da multiplicação do “vBCSTRet” x “pICMSSTRet” – que será valor do ICMS a ser retido pelo Substituto. Podendo o valor do ICMS a ser retido efetivamente, sofrer ajustes conforme a opção tributaria do transportador substituído.
        /// </summary>
        /// <value>Valor do ICMS ST retido.  Resultado da multiplicação do “vBCSTRet” x “pICMSSTRet” – que será valor do ICMS a ser retido pelo Substituto. Podendo o valor do ICMS a ser retido efetivamente, sofrer ajustes conforme a opção tributaria do transportador substituído.</value>
        [DataMember(Name = "vICMSSTRet", IsRequired = true, EmitDefaultValue = false)]
        public decimal vICMSSTRet { get; set; }

        /// <summary>
        /// Alíquota do ICMS.  Percentual de Alíquota incidente na prestação de serviço de transporte.
        /// </summary>
        /// <value>Alíquota do ICMS.  Percentual de Alíquota incidente na prestação de serviço de transporte.</value>
        [DataMember(Name = "pICMSSTRet", IsRequired = true, EmitDefaultValue = false)]
        public decimal pICMSSTRet { get; set; }

        /// <summary>
        /// Valor do Crédito outorgado/Presumido.  Preencher somente quando o transportador substituído, for optante pelo crédito outorgado previsto no Convênio 106/96 e corresponde ao percentual de 20%% do valor do ICMS ST retido.
        /// </summary>
        /// <value>Valor do Crédito outorgado/Presumido.  Preencher somente quando o transportador substituído, for optante pelo crédito outorgado previsto no Convênio 106/96 e corresponde ao percentual de 20%% do valor do ICMS ST retido.</value>
        [DataMember(Name = "vCred", EmitDefaultValue = false)]
        public decimal vCred { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazICMS60 {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBCSTRet: ").Append(vBCSTRet).Append("\n");
            sb.Append("  vICMSSTRet: ").Append(vICMSSTRet).Append("\n");
            sb.Append("  pICMSSTRet: ").Append(pICMSSTRet).Append("\n");
            sb.Append("  vCred: ").Append(vCred).Append("\n");
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
            return this.Equals(input as CteSefazICMS60);
        }

        /// <summary>
        /// Returns true if CteSefazICMS60 instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazICMS60 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazICMS60 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.vBCSTRet == input.vBCSTRet ||
                    this.vBCSTRet.Equals(input.vBCSTRet)
                ) && 
                (
                    this.vICMSSTRet == input.vICMSSTRet ||
                    this.vICMSSTRet.Equals(input.vICMSSTRet)
                ) && 
                (
                    this.pICMSSTRet == input.pICMSSTRet ||
                    this.pICMSSTRet.Equals(input.pICMSSTRet)
                ) && 
                (
                    this.vCred == input.vCred ||
                    this.vCred.Equals(input.vCred)
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vBCSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vCred.GetHashCode();
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
