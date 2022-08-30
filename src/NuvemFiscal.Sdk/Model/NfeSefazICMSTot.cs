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
    /// NfeSefazICMSTot
    /// </summary>
    [DataContract(Name = "NfeSefazICMSTot")]
    public partial class NfeSefazICMSTot : IEquatable<NfeSefazICMSTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMSTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSTot" /> class.
        /// </summary>
        /// <param name="vBC">BC do ICMS. (required).</param>
        /// <param name="vICMS">Valor Total do ICMS. (required).</param>
        /// <param name="vICMSDeson">Valor Total do ICMS desonerado. (required).</param>
        /// <param name="vFCPUFDest">Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino..</param>
        /// <param name="vICMSUFDest">Valor total do ICMS de partilha para a UF do destinatário..</param>
        /// <param name="vICMSUFRemet">Valor total do ICMS de partilha para a UF do remetente..</param>
        /// <param name="vFCP">Valor Total do FCP (Fundo de Combate à Pobreza). (required).</param>
        /// <param name="vBCST">BC do ICMS ST. (required).</param>
        /// <param name="vST">Valor Total do ICMS ST. (required).</param>
        /// <param name="vFCPST">Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária. (required).</param>
        /// <param name="vFCPSTRet">Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária. (required).</param>
        /// <param name="vProd">Valor Total dos produtos e serviços. (required).</param>
        /// <param name="vFrete">Valor Total do Frete. (required).</param>
        /// <param name="vSeg">Valor Total do Seguro. (required).</param>
        /// <param name="vDesc">Valor Total do Desconto. (required).</param>
        /// <param name="vII">Valor Total do II. (required).</param>
        /// <param name="vIPI">Valor Total do IPI. (required).</param>
        /// <param name="vIPIDevol">Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe&#x3D;4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04. (required).</param>
        /// <param name="vPIS">Valor do PIS. (required).</param>
        /// <param name="vCOFINS">Valor do COFINS. (required).</param>
        /// <param name="vOutro">Outras Despesas acessórias. (required).</param>
        /// <param name="vNF">Valor Total da NF-e. (required).</param>
        /// <param name="vTotTrib">Valor estimado total de impostos federais, estaduais e municipais..</param>
        public NfeSefazICMSTot(decimal vBC = default(decimal), decimal vICMS = default(decimal), decimal vICMSDeson = default(decimal), decimal vFCPUFDest = default(decimal), decimal vICMSUFDest = default(decimal), decimal vICMSUFRemet = default(decimal), decimal vFCP = default(decimal), decimal vBCST = default(decimal), decimal vST = default(decimal), decimal vFCPST = default(decimal), decimal vFCPSTRet = default(decimal), decimal vProd = default(decimal), decimal vFrete = default(decimal), decimal vSeg = default(decimal), decimal vDesc = default(decimal), decimal vII = default(decimal), decimal vIPI = default(decimal), decimal vIPIDevol = default(decimal), decimal vPIS = default(decimal), decimal vCOFINS = default(decimal), decimal vOutro = default(decimal), decimal vNF = default(decimal), decimal vTotTrib = default(decimal))
        {
            this.vBC = vBC;
            this.vICMS = vICMS;
            this.vICMSDeson = vICMSDeson;
            this.vFCP = vFCP;
            this.vBCST = vBCST;
            this.vST = vST;
            this.vFCPST = vFCPST;
            this.vFCPSTRet = vFCPSTRet;
            this.vProd = vProd;
            this.vFrete = vFrete;
            this.vSeg = vSeg;
            this.vDesc = vDesc;
            this.vII = vII;
            this.vIPI = vIPI;
            this.vIPIDevol = vIPIDevol;
            this.vPIS = vPIS;
            this.vCOFINS = vCOFINS;
            this.vOutro = vOutro;
            this.vNF = vNF;
            this.vFCPUFDest = vFCPUFDest;
            this.vICMSUFDest = vICMSUFDest;
            this.vICMSUFRemet = vICMSUFRemet;
            this.vTotTrib = vTotTrib;
        }

        /// <summary>
        /// BC do ICMS.
        /// </summary>
        /// <value>BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = false)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Valor Total do ICMS.
        /// </summary>
        /// <value>Valor Total do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = false)]
        public decimal vICMS { get; set; }

        /// <summary>
        /// Valor Total do ICMS desonerado.
        /// </summary>
        /// <value>Valor Total do ICMS desonerado.</value>
        [DataMember(Name = "vICMSDeson", IsRequired = true, EmitDefaultValue = false)]
        public decimal vICMSDeson { get; set; }

        /// <summary>
        /// Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino.
        /// </summary>
        /// <value>Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino.</value>
        [DataMember(Name = "vFCPUFDest", EmitDefaultValue = false)]
        public decimal vFCPUFDest { get; set; }

        /// <summary>
        /// Valor total do ICMS de partilha para a UF do destinatário.
        /// </summary>
        /// <value>Valor total do ICMS de partilha para a UF do destinatário.</value>
        [DataMember(Name = "vICMSUFDest", EmitDefaultValue = false)]
        public decimal vICMSUFDest { get; set; }

        /// <summary>
        /// Valor total do ICMS de partilha para a UF do remetente.
        /// </summary>
        /// <value>Valor total do ICMS de partilha para a UF do remetente.</value>
        [DataMember(Name = "vICMSUFRemet", EmitDefaultValue = false)]
        public decimal vICMSUFRemet { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza).
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza).</value>
        [DataMember(Name = "vFCP", IsRequired = true, EmitDefaultValue = false)]
        public decimal vFCP { get; set; }

        /// <summary>
        /// BC do ICMS ST.
        /// </summary>
        /// <value>BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = false)]
        public decimal vBCST { get; set; }

        /// <summary>
        /// Valor Total do ICMS ST.
        /// </summary>
        /// <value>Valor Total do ICMS ST.</value>
        [DataMember(Name = "vST", IsRequired = true, EmitDefaultValue = false)]
        public decimal vST { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária.
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária.</value>
        [DataMember(Name = "vFCPST", IsRequired = true, EmitDefaultValue = false)]
        public decimal vFCPST { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária.
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária.</value>
        [DataMember(Name = "vFCPSTRet", IsRequired = true, EmitDefaultValue = false)]
        public decimal vFCPSTRet { get; set; }

        /// <summary>
        /// Valor Total dos produtos e serviços.
        /// </summary>
        /// <value>Valor Total dos produtos e serviços.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = false)]
        public decimal vProd { get; set; }

        /// <summary>
        /// Valor Total do Frete.
        /// </summary>
        /// <value>Valor Total do Frete.</value>
        [DataMember(Name = "vFrete", IsRequired = true, EmitDefaultValue = false)]
        public decimal vFrete { get; set; }

        /// <summary>
        /// Valor Total do Seguro.
        /// </summary>
        /// <value>Valor Total do Seguro.</value>
        [DataMember(Name = "vSeg", IsRequired = true, EmitDefaultValue = false)]
        public decimal vSeg { get; set; }

        /// <summary>
        /// Valor Total do Desconto.
        /// </summary>
        /// <value>Valor Total do Desconto.</value>
        [DataMember(Name = "vDesc", IsRequired = true, EmitDefaultValue = false)]
        public decimal vDesc { get; set; }

        /// <summary>
        /// Valor Total do II.
        /// </summary>
        /// <value>Valor Total do II.</value>
        [DataMember(Name = "vII", IsRequired = true, EmitDefaultValue = false)]
        public decimal vII { get; set; }

        /// <summary>
        /// Valor Total do IPI.
        /// </summary>
        /// <value>Valor Total do IPI.</value>
        [DataMember(Name = "vIPI", IsRequired = true, EmitDefaultValue = false)]
        public decimal vIPI { get; set; }

        /// <summary>
        /// Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe&#x3D;4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04.
        /// </summary>
        /// <value>Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe&#x3D;4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04.</value>
        [DataMember(Name = "vIPIDevol", IsRequired = true, EmitDefaultValue = false)]
        public decimal vIPIDevol { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = false)]
        public decimal vPIS { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = false)]
        public decimal vCOFINS { get; set; }

        /// <summary>
        /// Outras Despesas acessórias.
        /// </summary>
        /// <value>Outras Despesas acessórias.</value>
        [DataMember(Name = "vOutro", IsRequired = true, EmitDefaultValue = false)]
        public decimal vOutro { get; set; }

        /// <summary>
        /// Valor Total da NF-e.
        /// </summary>
        /// <value>Valor Total da NF-e.</value>
        [DataMember(Name = "vNF", IsRequired = true, EmitDefaultValue = false)]
        public decimal vNF { get; set; }

        /// <summary>
        /// Valor estimado total de impostos federais, estaduais e municipais.
        /// </summary>
        /// <value>Valor estimado total de impostos federais, estaduais e municipais.</value>
        [DataMember(Name = "vTotTrib", EmitDefaultValue = false)]
        public decimal vTotTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMSTot {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  vFCPUFDest: ").Append(vFCPUFDest).Append("\n");
            sb.Append("  vICMSUFDest: ").Append(vICMSUFDest).Append("\n");
            sb.Append("  vICMSUFRemet: ").Append(vICMSUFRemet).Append("\n");
            sb.Append("  vFCP: ").Append(vFCP).Append("\n");
            sb.Append("  vBCST: ").Append(vBCST).Append("\n");
            sb.Append("  vST: ").Append(vST).Append("\n");
            sb.Append("  vFCPST: ").Append(vFCPST).Append("\n");
            sb.Append("  vFCPSTRet: ").Append(vFCPSTRet).Append("\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
            sb.Append("  vFrete: ").Append(vFrete).Append("\n");
            sb.Append("  vSeg: ").Append(vSeg).Append("\n");
            sb.Append("  vDesc: ").Append(vDesc).Append("\n");
            sb.Append("  vII: ").Append(vII).Append("\n");
            sb.Append("  vIPI: ").Append(vIPI).Append("\n");
            sb.Append("  vIPIDevol: ").Append(vIPIDevol).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  vNF: ").Append(vNF).Append("\n");
            sb.Append("  vTotTrib: ").Append(vTotTrib).Append("\n");
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
            return this.Equals(input as NfeSefazICMSTot);
        }

        /// <summary>
        /// Returns true if NfeSefazICMSTot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMSTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMSTot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    this.vICMS.Equals(input.vICMS)
                ) && 
                (
                    this.vICMSDeson == input.vICMSDeson ||
                    this.vICMSDeson.Equals(input.vICMSDeson)
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
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    this.vFCP.Equals(input.vFCP)
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    this.vBCST.Equals(input.vBCST)
                ) && 
                (
                    this.vST == input.vST ||
                    this.vST.Equals(input.vST)
                ) && 
                (
                    this.vFCPST == input.vFCPST ||
                    this.vFCPST.Equals(input.vFCPST)
                ) && 
                (
                    this.vFCPSTRet == input.vFCPSTRet ||
                    this.vFCPSTRet.Equals(input.vFCPSTRet)
                ) && 
                (
                    this.vProd == input.vProd ||
                    this.vProd.Equals(input.vProd)
                ) && 
                (
                    this.vFrete == input.vFrete ||
                    this.vFrete.Equals(input.vFrete)
                ) && 
                (
                    this.vSeg == input.vSeg ||
                    this.vSeg.Equals(input.vSeg)
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    this.vDesc.Equals(input.vDesc)
                ) && 
                (
                    this.vII == input.vII ||
                    this.vII.Equals(input.vII)
                ) && 
                (
                    this.vIPI == input.vIPI ||
                    this.vIPI.Equals(input.vIPI)
                ) && 
                (
                    this.vIPIDevol == input.vIPIDevol ||
                    this.vIPIDevol.Equals(input.vIPIDevol)
                ) && 
                (
                    this.vPIS == input.vPIS ||
                    this.vPIS.Equals(input.vPIS)
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    this.vCOFINS.Equals(input.vCOFINS)
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    this.vOutro.Equals(input.vOutro)
                ) && 
                (
                    this.vNF == input.vNF ||
                    this.vNF.Equals(input.vNF)
                ) && 
                (
                    this.vTotTrib == input.vTotTrib ||
                    this.vTotTrib.Equals(input.vTotTrib)
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
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSUFDest.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSUFRemet.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.vST.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                hashCode = (hashCode * 59) + this.vFrete.GetHashCode();
                hashCode = (hashCode * 59) + this.vSeg.GetHashCode();
                hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                hashCode = (hashCode * 59) + this.vII.GetHashCode();
                hashCode = (hashCode * 59) + this.vIPI.GetHashCode();
                hashCode = (hashCode * 59) + this.vIPIDevol.GetHashCode();
                hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                hashCode = (hashCode * 59) + this.vNF.GetHashCode();
                hashCode = (hashCode * 59) + this.vTotTrib.GetHashCode();
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
