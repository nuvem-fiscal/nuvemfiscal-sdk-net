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
    /// NfeSefazICMSUFDest
    /// </summary>
    [DataContract(Name = "NfeSefazICMSUFDest")]
    public partial class NfeSefazICMSUFDest : IEquatable<NfeSefazICMSUFDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSUFDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMSUFDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSUFDest" /> class.
        /// </summary>
        /// <param name="vBCUFDest">Valor da Base de Cálculo do ICMS na UF do destinatário. (required).</param>
        /// <param name="vBCFCPUFDest">Valor da Base de Cálculo do FCP na UF do destinatário..</param>
        /// <param name="pFCPUFDest">Percentual adicional inserido na alíquota interna da UF de destino, relativo ao Fundo de Combate à Pobreza (FCP) naquela UF..</param>
        /// <param name="pICMSUFDest">Alíquota adotada nas operações internas na UF do destinatário para o produto / mercadoria. (required).</param>
        /// <param name="pICMSInter">Alíquota interestadual das UF envolvidas: - 4%% alíquota interestadual para produtos importados; - 7%% para os Estados de origem do Sul e Sudeste (exceto ES), destinado para os Estados do Norte e Nordeste  ou ES; - 12%% para os demais casos. (required).</param>
        /// <param name="pICMSInterPart">Percentual de partilha para a UF do destinatário: - 40%% em 2016; - 60%% em 2017; - 80%% em 2018; - 100%% a partir de 2019. (required).</param>
        /// <param name="vFCPUFDest">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) da UF de destino..</param>
        /// <param name="vICMSUFDest">Valor do ICMS de partilha para a UF do destinatário. (required).</param>
        /// <param name="vICMSUFRemet">Valor do ICMS de partilha para a UF do remetente. Nota: A partir de 2019, este valor será zero. (required).</param>
        public NfeSefazICMSUFDest(decimal vBCUFDest = default(decimal), decimal vBCFCPUFDest = default(decimal), decimal pFCPUFDest = default(decimal), decimal pICMSUFDest = default(decimal), decimal pICMSInter = default(decimal), decimal pICMSInterPart = default(decimal), decimal vFCPUFDest = default(decimal), decimal vICMSUFDest = default(decimal), decimal vICMSUFRemet = default(decimal))
        {
            this.vBCUFDest = vBCUFDest;
            this.pICMSUFDest = pICMSUFDest;
            this.pICMSInter = pICMSInter;
            this.pICMSInterPart = pICMSInterPart;
            this.vICMSUFDest = vICMSUFDest;
            this.vICMSUFRemet = vICMSUFRemet;
            this.vBCFCPUFDest = vBCFCPUFDest;
            this.pFCPUFDest = pFCPUFDest;
            this.vFCPUFDest = vFCPUFDest;
        }

        /// <summary>
        /// Valor da Base de Cálculo do ICMS na UF do destinatário.
        /// </summary>
        /// <value>Valor da Base de Cálculo do ICMS na UF do destinatário.</value>
        [DataMember(Name = "vBCUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBCUFDest { get; set; }

        /// <summary>
        /// Valor da Base de Cálculo do FCP na UF do destinatário.
        /// </summary>
        /// <value>Valor da Base de Cálculo do FCP na UF do destinatário.</value>
        [DataMember(Name = "vBCFCPUFDest", EmitDefaultValue = false)]
        public decimal vBCFCPUFDest { get; set; }

        /// <summary>
        /// Percentual adicional inserido na alíquota interna da UF de destino, relativo ao Fundo de Combate à Pobreza (FCP) naquela UF.
        /// </summary>
        /// <value>Percentual adicional inserido na alíquota interna da UF de destino, relativo ao Fundo de Combate à Pobreza (FCP) naquela UF.</value>
        [DataMember(Name = "pFCPUFDest", EmitDefaultValue = false)]
        public decimal pFCPUFDest { get; set; }

        /// <summary>
        /// Alíquota adotada nas operações internas na UF do destinatário para o produto / mercadoria.
        /// </summary>
        /// <value>Alíquota adotada nas operações internas na UF do destinatário para o produto / mercadoria.</value>
        [DataMember(Name = "pICMSUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSUFDest { get; set; }

        /// <summary>
        /// Alíquota interestadual das UF envolvidas: - 4%% alíquota interestadual para produtos importados; - 7%% para os Estados de origem do Sul e Sudeste (exceto ES), destinado para os Estados do Norte e Nordeste  ou ES; - 12%% para os demais casos.
        /// </summary>
        /// <value>Alíquota interestadual das UF envolvidas: - 4%% alíquota interestadual para produtos importados; - 7%% para os Estados de origem do Sul e Sudeste (exceto ES), destinado para os Estados do Norte e Nordeste  ou ES; - 12%% para os demais casos.</value>
        [DataMember(Name = "pICMSInter", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSInter { get; set; }

        /// <summary>
        /// Percentual de partilha para a UF do destinatário: - 40%% em 2016; - 60%% em 2017; - 80%% em 2018; - 100%% a partir de 2019.
        /// </summary>
        /// <value>Percentual de partilha para a UF do destinatário: - 40%% em 2016; - 60%% em 2017; - 80%% em 2018; - 100%% a partir de 2019.</value>
        [DataMember(Name = "pICMSInterPart", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSInterPart { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) da UF de destino.
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) da UF de destino.</value>
        [DataMember(Name = "vFCPUFDest", EmitDefaultValue = false)]
        public decimal vFCPUFDest { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF do destinatário.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF do destinatário.</value>
        [DataMember(Name = "vICMSUFDest", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSUFDest { get; set; }

        /// <summary>
        /// Valor do ICMS de partilha para a UF do remetente. Nota: A partir de 2019, este valor será zero.
        /// </summary>
        /// <value>Valor do ICMS de partilha para a UF do remetente. Nota: A partir de 2019, este valor será zero.</value>
        [DataMember(Name = "vICMSUFRemet", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSUFRemet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMSUFDest {\n");
            sb.Append("  vBCUFDest: ").Append(vBCUFDest).Append("\n");
            sb.Append("  vBCFCPUFDest: ").Append(vBCFCPUFDest).Append("\n");
            sb.Append("  pFCPUFDest: ").Append(pFCPUFDest).Append("\n");
            sb.Append("  pICMSUFDest: ").Append(pICMSUFDest).Append("\n");
            sb.Append("  pICMSInter: ").Append(pICMSInter).Append("\n");
            sb.Append("  pICMSInterPart: ").Append(pICMSInterPart).Append("\n");
            sb.Append("  vFCPUFDest: ").Append(vFCPUFDest).Append("\n");
            sb.Append("  vICMSUFDest: ").Append(vICMSUFDest).Append("\n");
            sb.Append("  vICMSUFRemet: ").Append(vICMSUFRemet).Append("\n");
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
            return this.Equals(input as NfeSefazICMSUFDest);
        }

        /// <summary>
        /// Returns true if NfeSefazICMSUFDest instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMSUFDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMSUFDest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBCUFDest == input.vBCUFDest ||
                    this.vBCUFDest.Equals(input.vBCUFDest)
                ) && 
                (
                    this.vBCFCPUFDest == input.vBCFCPUFDest ||
                    this.vBCFCPUFDest.Equals(input.vBCFCPUFDest)
                ) && 
                (
                    this.pFCPUFDest == input.pFCPUFDest ||
                    this.pFCPUFDest.Equals(input.pFCPUFDest)
                ) && 
                (
                    this.pICMSUFDest == input.pICMSUFDest ||
                    this.pICMSUFDest.Equals(input.pICMSUFDest)
                ) && 
                (
                    this.pICMSInter == input.pICMSInter ||
                    this.pICMSInter.Equals(input.pICMSInter)
                ) && 
                (
                    this.pICMSInterPart == input.pICMSInterPart ||
                    this.pICMSInterPart.Equals(input.pICMSInterPart)
                ) && 
                (
                    this.vFCPUFDest == input.vFCPUFDest ||
                    this.vFCPUFDest.Equals(input.vFCPUFDest)
                ) && 
                (
                    this.vICMSUFDest == input.vICMSUFDest ||
                    this.vICMSUFDest.Equals(input.vICMSUFDest)
                ) && 
                (
                    this.vICMSUFRemet == input.vICMSUFRemet ||
                    this.vICMSUFRemet.Equals(input.vICMSUFRemet)
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
                hashCode = (hashCode * 59) + this.vBCUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCFCPUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.pFCPUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSInter.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSInterPart.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSUFRemet.GetHashCode();
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
