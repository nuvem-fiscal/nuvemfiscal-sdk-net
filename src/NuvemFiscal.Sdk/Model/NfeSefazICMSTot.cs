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
    /// Totais referentes ao ICMS.
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
        /// <param name="qBCMono">Valor total da quantidade tributada do ICMS monofásico próprio..</param>
        /// <param name="vICMSMono">Valor total do ICMS monofásico próprio..</param>
        /// <param name="qBCMonoReten">Valor total da quantidade tributada do ICMS monofásico sujeito a retenção..</param>
        /// <param name="vICMSMonoReten">Valor total do ICMS monofásico sujeito a retenção..</param>
        /// <param name="qBCMonoRet">Valor total da quantidade tributada do ICMS monofásico retido anteriormente..</param>
        /// <param name="vICMSMonoRet">Valor do ICMS monofásico retido anteriormente..</param>
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
        public NfeSefazICMSTot(decimal? vBC = default(decimal?), decimal? vICMS = default(decimal?), decimal? vICMSDeson = default(decimal?), decimal? vFCPUFDest = default(decimal?), decimal? vICMSUFDest = default(decimal?), decimal? vICMSUFRemet = default(decimal?), decimal? vFCP = default(decimal?), decimal? vBCST = default(decimal?), decimal? vST = default(decimal?), decimal? vFCPST = default(decimal?), decimal? vFCPSTRet = default(decimal?), decimal? qBCMono = default(decimal?), decimal? vICMSMono = default(decimal?), decimal? qBCMonoReten = default(decimal?), decimal? vICMSMonoReten = default(decimal?), decimal? qBCMonoRet = default(decimal?), decimal? vICMSMonoRet = default(decimal?), decimal? vProd = default(decimal?), decimal? vFrete = default(decimal?), decimal? vSeg = default(decimal?), decimal? vDesc = default(decimal?), decimal? vII = default(decimal?), decimal? vIPI = default(decimal?), decimal? vIPIDevol = default(decimal?), decimal? vPIS = default(decimal?), decimal? vCOFINS = default(decimal?), decimal? vOutro = default(decimal?), decimal? vNF = default(decimal?), decimal? vTotTrib = default(decimal?))
        {
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "vICMS" is required (not null)
            if (vICMS == null)
            {
                throw new ArgumentNullException("vICMS is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vICMS = vICMS;
            // to ensure "vICMSDeson" is required (not null)
            if (vICMSDeson == null)
            {
                throw new ArgumentNullException("vICMSDeson is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vICMSDeson = vICMSDeson;
            // to ensure "vFCP" is required (not null)
            if (vFCP == null)
            {
                throw new ArgumentNullException("vFCP is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vFCP = vFCP;
            // to ensure "vBCST" is required (not null)
            if (vBCST == null)
            {
                throw new ArgumentNullException("vBCST is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vBCST = vBCST;
            // to ensure "vST" is required (not null)
            if (vST == null)
            {
                throw new ArgumentNullException("vST is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vST = vST;
            // to ensure "vFCPST" is required (not null)
            if (vFCPST == null)
            {
                throw new ArgumentNullException("vFCPST is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vFCPST = vFCPST;
            // to ensure "vFCPSTRet" is required (not null)
            if (vFCPSTRet == null)
            {
                throw new ArgumentNullException("vFCPSTRet is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vFCPSTRet = vFCPSTRet;
            // to ensure "vProd" is required (not null)
            if (vProd == null)
            {
                throw new ArgumentNullException("vProd is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vProd = vProd;
            // to ensure "vFrete" is required (not null)
            if (vFrete == null)
            {
                throw new ArgumentNullException("vFrete is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vFrete = vFrete;
            // to ensure "vSeg" is required (not null)
            if (vSeg == null)
            {
                throw new ArgumentNullException("vSeg is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vSeg = vSeg;
            // to ensure "vDesc" is required (not null)
            if (vDesc == null)
            {
                throw new ArgumentNullException("vDesc is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vDesc = vDesc;
            // to ensure "vII" is required (not null)
            if (vII == null)
            {
                throw new ArgumentNullException("vII is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vII = vII;
            // to ensure "vIPI" is required (not null)
            if (vIPI == null)
            {
                throw new ArgumentNullException("vIPI is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vIPI = vIPI;
            // to ensure "vIPIDevol" is required (not null)
            if (vIPIDevol == null)
            {
                throw new ArgumentNullException("vIPIDevol is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vIPIDevol = vIPIDevol;
            // to ensure "vPIS" is required (not null)
            if (vPIS == null)
            {
                throw new ArgumentNullException("vPIS is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vPIS = vPIS;
            // to ensure "vCOFINS" is required (not null)
            if (vCOFINS == null)
            {
                throw new ArgumentNullException("vCOFINS is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vCOFINS = vCOFINS;
            // to ensure "vOutro" is required (not null)
            if (vOutro == null)
            {
                throw new ArgumentNullException("vOutro is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vOutro = vOutro;
            // to ensure "vNF" is required (not null)
            if (vNF == null)
            {
                throw new ArgumentNullException("vNF is a required property for NfeSefazICMSTot and cannot be null");
            }
            this.vNF = vNF;
            this.vFCPUFDest = vFCPUFDest;
            this.vICMSUFDest = vICMSUFDest;
            this.vICMSUFRemet = vICMSUFRemet;
            this.qBCMono = qBCMono;
            this.vICMSMono = vICMSMono;
            this.qBCMonoReten = qBCMonoReten;
            this.vICMSMonoReten = vICMSMonoReten;
            this.qBCMonoRet = qBCMonoRet;
            this.vICMSMonoRet = vICMSMonoRet;
            this.vTotTrib = vTotTrib;
        }

        /// <summary>
        /// BC do ICMS.
        /// </summary>
        /// <value>BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Valor Total do ICMS.
        /// </summary>
        /// <value>Valor Total do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMS { get; set; }

        /// <summary>
        /// Valor Total do ICMS desonerado.
        /// </summary>
        /// <value>Valor Total do ICMS desonerado.</value>
        [DataMember(Name = "vICMSDeson", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSDeson { get; set; }

        /// <summary>
        /// Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino.
        /// </summary>
        /// <value>Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino.</value>
        [DataMember(Name = "vFCPUFDest", EmitDefaultValue = true)]
        public decimal? vFCPUFDest { get; set; }

        /// <summary>
        /// Valor total do ICMS de partilha para a UF do destinatário.
        /// </summary>
        /// <value>Valor total do ICMS de partilha para a UF do destinatário.</value>
        [DataMember(Name = "vICMSUFDest", EmitDefaultValue = true)]
        public decimal? vICMSUFDest { get; set; }

        /// <summary>
        /// Valor total do ICMS de partilha para a UF do remetente.
        /// </summary>
        /// <value>Valor total do ICMS de partilha para a UF do remetente.</value>
        [DataMember(Name = "vICMSUFRemet", EmitDefaultValue = true)]
        public decimal? vICMSUFRemet { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza).
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza).</value>
        [DataMember(Name = "vFCP", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFCP { get; set; }

        /// <summary>
        /// BC do ICMS ST.
        /// </summary>
        /// <value>BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCST { get; set; }

        /// <summary>
        /// Valor Total do ICMS ST.
        /// </summary>
        /// <value>Valor Total do ICMS ST.</value>
        [DataMember(Name = "vST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vST { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária.
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária.</value>
        [DataMember(Name = "vFCPST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFCPST { get; set; }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária.
        /// </summary>
        /// <value>Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária.</value>
        [DataMember(Name = "vFCPSTRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFCPSTRet { get; set; }

        /// <summary>
        /// Valor total da quantidade tributada do ICMS monofásico próprio.
        /// </summary>
        /// <value>Valor total da quantidade tributada do ICMS monofásico próprio.</value>
        [DataMember(Name = "qBCMono", EmitDefaultValue = true)]
        public decimal? qBCMono { get; set; }

        /// <summary>
        /// Valor total do ICMS monofásico próprio.
        /// </summary>
        /// <value>Valor total do ICMS monofásico próprio.</value>
        [DataMember(Name = "vICMSMono", EmitDefaultValue = true)]
        public decimal? vICMSMono { get; set; }

        /// <summary>
        /// Valor total da quantidade tributada do ICMS monofásico sujeito a retenção.
        /// </summary>
        /// <value>Valor total da quantidade tributada do ICMS monofásico sujeito a retenção.</value>
        [DataMember(Name = "qBCMonoReten", EmitDefaultValue = true)]
        public decimal? qBCMonoReten { get; set; }

        /// <summary>
        /// Valor total do ICMS monofásico sujeito a retenção.
        /// </summary>
        /// <value>Valor total do ICMS monofásico sujeito a retenção.</value>
        [DataMember(Name = "vICMSMonoReten", EmitDefaultValue = true)]
        public decimal? vICMSMonoReten { get; set; }

        /// <summary>
        /// Valor total da quantidade tributada do ICMS monofásico retido anteriormente.
        /// </summary>
        /// <value>Valor total da quantidade tributada do ICMS monofásico retido anteriormente.</value>
        [DataMember(Name = "qBCMonoRet", EmitDefaultValue = true)]
        public decimal? qBCMonoRet { get; set; }

        /// <summary>
        /// Valor do ICMS monofásico retido anteriormente.
        /// </summary>
        /// <value>Valor do ICMS monofásico retido anteriormente.</value>
        [DataMember(Name = "vICMSMonoRet", EmitDefaultValue = true)]
        public decimal? vICMSMonoRet { get; set; }

        /// <summary>
        /// Valor Total dos produtos e serviços.
        /// </summary>
        /// <value>Valor Total dos produtos e serviços.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vProd { get; set; }

        /// <summary>
        /// Valor Total do Frete.
        /// </summary>
        /// <value>Valor Total do Frete.</value>
        [DataMember(Name = "vFrete", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFrete { get; set; }

        /// <summary>
        /// Valor Total do Seguro.
        /// </summary>
        /// <value>Valor Total do Seguro.</value>
        [DataMember(Name = "vSeg", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vSeg { get; set; }

        /// <summary>
        /// Valor Total do Desconto.
        /// </summary>
        /// <value>Valor Total do Desconto.</value>
        [DataMember(Name = "vDesc", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDesc { get; set; }

        /// <summary>
        /// Valor Total do II.
        /// </summary>
        /// <value>Valor Total do II.</value>
        [DataMember(Name = "vII", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vII { get; set; }

        /// <summary>
        /// Valor Total do IPI.
        /// </summary>
        /// <value>Valor Total do IPI.</value>
        [DataMember(Name = "vIPI", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIPI { get; set; }

        /// <summary>
        /// Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe&#x3D;4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04.
        /// </summary>
        /// <value>Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe&#x3D;4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04.</value>
        [DataMember(Name = "vIPIDevol", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIPIDevol { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Outras Despesas acessórias.
        /// </summary>
        /// <value>Outras Despesas acessórias.</value>
        [DataMember(Name = "vOutro", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vOutro { get; set; }

        /// <summary>
        /// Valor Total da NF-e.
        /// </summary>
        /// <value>Valor Total da NF-e.</value>
        [DataMember(Name = "vNF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vNF { get; set; }

        /// <summary>
        /// Valor estimado total de impostos federais, estaduais e municipais.
        /// </summary>
        /// <value>Valor estimado total de impostos federais, estaduais e municipais.</value>
        [DataMember(Name = "vTotTrib", EmitDefaultValue = true)]
        public decimal? vTotTrib { get; set; }

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
            sb.Append("  qBCMono: ").Append(qBCMono).Append("\n");
            sb.Append("  vICMSMono: ").Append(vICMSMono).Append("\n");
            sb.Append("  qBCMonoReten: ").Append(qBCMonoReten).Append("\n");
            sb.Append("  vICMSMonoReten: ").Append(vICMSMonoReten).Append("\n");
            sb.Append("  qBCMonoRet: ").Append(qBCMonoRet).Append("\n");
            sb.Append("  vICMSMonoRet: ").Append(vICMSMonoRet).Append("\n");
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
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    (this.vICMS != null &&
                    this.vICMS.Equals(input.vICMS))
                ) && 
                (
                    this.vICMSDeson == input.vICMSDeson ||
                    (this.vICMSDeson != null &&
                    this.vICMSDeson.Equals(input.vICMSDeson))
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
                    this.vICMSUFRemet == input.vICMSUFRemet ||
                    (this.vICMSUFRemet != null &&
                    this.vICMSUFRemet.Equals(input.vICMSUFRemet))
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    (this.vFCP != null &&
                    this.vFCP.Equals(input.vFCP))
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    (this.vBCST != null &&
                    this.vBCST.Equals(input.vBCST))
                ) && 
                (
                    this.vST == input.vST ||
                    (this.vST != null &&
                    this.vST.Equals(input.vST))
                ) && 
                (
                    this.vFCPST == input.vFCPST ||
                    (this.vFCPST != null &&
                    this.vFCPST.Equals(input.vFCPST))
                ) && 
                (
                    this.vFCPSTRet == input.vFCPSTRet ||
                    (this.vFCPSTRet != null &&
                    this.vFCPSTRet.Equals(input.vFCPSTRet))
                ) && 
                (
                    this.qBCMono == input.qBCMono ||
                    (this.qBCMono != null &&
                    this.qBCMono.Equals(input.qBCMono))
                ) && 
                (
                    this.vICMSMono == input.vICMSMono ||
                    (this.vICMSMono != null &&
                    this.vICMSMono.Equals(input.vICMSMono))
                ) && 
                (
                    this.qBCMonoReten == input.qBCMonoReten ||
                    (this.qBCMonoReten != null &&
                    this.qBCMonoReten.Equals(input.qBCMonoReten))
                ) && 
                (
                    this.vICMSMonoReten == input.vICMSMonoReten ||
                    (this.vICMSMonoReten != null &&
                    this.vICMSMonoReten.Equals(input.vICMSMonoReten))
                ) && 
                (
                    this.qBCMonoRet == input.qBCMonoRet ||
                    (this.qBCMonoRet != null &&
                    this.qBCMonoRet.Equals(input.qBCMonoRet))
                ) && 
                (
                    this.vICMSMonoRet == input.vICMSMonoRet ||
                    (this.vICMSMonoRet != null &&
                    this.vICMSMonoRet.Equals(input.vICMSMonoRet))
                ) && 
                (
                    this.vProd == input.vProd ||
                    (this.vProd != null &&
                    this.vProd.Equals(input.vProd))
                ) && 
                (
                    this.vFrete == input.vFrete ||
                    (this.vFrete != null &&
                    this.vFrete.Equals(input.vFrete))
                ) && 
                (
                    this.vSeg == input.vSeg ||
                    (this.vSeg != null &&
                    this.vSeg.Equals(input.vSeg))
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    (this.vDesc != null &&
                    this.vDesc.Equals(input.vDesc))
                ) && 
                (
                    this.vII == input.vII ||
                    (this.vII != null &&
                    this.vII.Equals(input.vII))
                ) && 
                (
                    this.vIPI == input.vIPI ||
                    (this.vIPI != null &&
                    this.vIPI.Equals(input.vIPI))
                ) && 
                (
                    this.vIPIDevol == input.vIPIDevol ||
                    (this.vIPIDevol != null &&
                    this.vIPIDevol.Equals(input.vIPIDevol))
                ) && 
                (
                    this.vPIS == input.vPIS ||
                    (this.vPIS != null &&
                    this.vPIS.Equals(input.vPIS))
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    (this.vCOFINS != null &&
                    this.vCOFINS.Equals(input.vCOFINS))
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    (this.vOutro != null &&
                    this.vOutro.Equals(input.vOutro))
                ) && 
                (
                    this.vNF == input.vNF ||
                    (this.vNF != null &&
                    this.vNF.Equals(input.vNF))
                ) && 
                (
                    this.vTotTrib == input.vTotTrib ||
                    (this.vTotTrib != null &&
                    this.vTotTrib.Equals(input.vTotTrib))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                }
                if (this.vICMSDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                }
                if (this.vFCPUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPUFDest.GetHashCode();
                }
                if (this.vICMSUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSUFDest.GetHashCode();
                }
                if (this.vICMSUFRemet != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSUFRemet.GetHashCode();
                }
                if (this.vFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
                }
                if (this.vBCST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                }
                if (this.vST != null)
                {
                    hashCode = (hashCode * 59) + this.vST.GetHashCode();
                }
                if (this.vFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
                }
                if (this.vFCPSTRet != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPSTRet.GetHashCode();
                }
                if (this.qBCMono != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMono.GetHashCode();
                }
                if (this.vICMSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSMono.GetHashCode();
                }
                if (this.qBCMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMonoReten.GetHashCode();
                }
                if (this.vICMSMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSMonoReten.GetHashCode();
                }
                if (this.qBCMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMonoRet.GetHashCode();
                }
                if (this.vICMSMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSMonoRet.GetHashCode();
                }
                if (this.vProd != null)
                {
                    hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                }
                if (this.vFrete != null)
                {
                    hashCode = (hashCode * 59) + this.vFrete.GetHashCode();
                }
                if (this.vSeg != null)
                {
                    hashCode = (hashCode * 59) + this.vSeg.GetHashCode();
                }
                if (this.vDesc != null)
                {
                    hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                }
                if (this.vII != null)
                {
                    hashCode = (hashCode * 59) + this.vII.GetHashCode();
                }
                if (this.vIPI != null)
                {
                    hashCode = (hashCode * 59) + this.vIPI.GetHashCode();
                }
                if (this.vIPIDevol != null)
                {
                    hashCode = (hashCode * 59) + this.vIPIDevol.GetHashCode();
                }
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                }
                if (this.vOutro != null)
                {
                    hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                }
                if (this.vNF != null)
                {
                    hashCode = (hashCode * 59) + this.vNF.GetHashCode();
                }
                if (this.vTotTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTrib.GetHashCode();
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
            yield break;
        }
    }

}
