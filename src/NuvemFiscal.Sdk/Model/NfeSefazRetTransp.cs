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
    /// NfeSefazRetTransp
    /// </summary>
    [DataContract(Name = "NfeSefazRetTransp")]
    public partial class NfeSefazRetTransp : IEquatable<NfeSefazRetTransp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRetTransp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazRetTransp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRetTransp" /> class.
        /// </summary>
        /// <param name="vServ">Valor do Serviço. (required).</param>
        /// <param name="vBCRet">BC da Retenção do ICMS. (required).</param>
        /// <param name="pICMSRet">Alíquota da Retenção. (required).</param>
        /// <param name="vICMSRet">Valor do ICMS Retido. (required).</param>
        /// <param name="cFOP">Código Fiscal de Operações e Prestações. (required).</param>
        /// <param name="cMunFG">Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE). (required).</param>
        public NfeSefazRetTransp(decimal vServ = default(decimal), decimal vBCRet = default(decimal), decimal pICMSRet = default(decimal), decimal vICMSRet = default(decimal), int cFOP = default(int), int cMunFG = default(int))
        {
            this.vServ = vServ;
            this.vBCRet = vBCRet;
            this.pICMSRet = pICMSRet;
            this.vICMSRet = vICMSRet;
            this.CFOP = cFOP;
            this.cMunFG = cMunFG;
        }

        /// <summary>
        /// Valor do Serviço.
        /// </summary>
        /// <value>Valor do Serviço.</value>
        [DataMember(Name = "vServ", IsRequired = true, EmitDefaultValue = true)]
        public decimal vServ { get; set; }

        /// <summary>
        /// BC da Retenção do ICMS.
        /// </summary>
        /// <value>BC da Retenção do ICMS.</value>
        [DataMember(Name = "vBCRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBCRet { get; set; }

        /// <summary>
        /// Alíquota da Retenção.
        /// </summary>
        /// <value>Alíquota da Retenção.</value>
        [DataMember(Name = "pICMSRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSRet { get; set; }

        /// <summary>
        /// Valor do ICMS Retido.
        /// </summary>
        /// <value>Valor do ICMS Retido.</value>
        [DataMember(Name = "vICMSRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSRet { get; set; }

        /// <summary>
        /// Código Fiscal de Operações e Prestações.
        /// </summary>
        /// <value>Código Fiscal de Operações e Prestações.</value>
        [DataMember(Name = "CFOP", IsRequired = true, EmitDefaultValue = true)]
        public int CFOP { get; set; }

        /// <summary>
        /// Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE).
        /// </summary>
        /// <value>Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE).</value>
        [DataMember(Name = "cMunFG", IsRequired = true, EmitDefaultValue = true)]
        public int cMunFG { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRetTransp {\n");
            sb.Append("  vServ: ").Append(vServ).Append("\n");
            sb.Append("  vBCRet: ").Append(vBCRet).Append("\n");
            sb.Append("  pICMSRet: ").Append(pICMSRet).Append("\n");
            sb.Append("  vICMSRet: ").Append(vICMSRet).Append("\n");
            sb.Append("  CFOP: ").Append(CFOP).Append("\n");
            sb.Append("  cMunFG: ").Append(cMunFG).Append("\n");
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
            return this.Equals(input as NfeSefazRetTransp);
        }

        /// <summary>
        /// Returns true if NfeSefazRetTransp instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRetTransp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRetTransp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vServ == input.vServ ||
                    this.vServ.Equals(input.vServ)
                ) && 
                (
                    this.vBCRet == input.vBCRet ||
                    this.vBCRet.Equals(input.vBCRet)
                ) && 
                (
                    this.pICMSRet == input.pICMSRet ||
                    this.pICMSRet.Equals(input.pICMSRet)
                ) && 
                (
                    this.vICMSRet == input.vICMSRet ||
                    this.vICMSRet.Equals(input.vICMSRet)
                ) && 
                (
                    this.CFOP == input.CFOP ||
                    this.CFOP.Equals(input.CFOP)
                ) && 
                (
                    this.cMunFG == input.cMunFG ||
                    this.cMunFG.Equals(input.cMunFG)
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
                hashCode = (hashCode * 59) + this.vServ.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCRet.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSRet.GetHashCode();
                hashCode = (hashCode * 59) + this.CFOP.GetHashCode();
                hashCode = (hashCode * 59) + this.cMunFG.GetHashCode();
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
