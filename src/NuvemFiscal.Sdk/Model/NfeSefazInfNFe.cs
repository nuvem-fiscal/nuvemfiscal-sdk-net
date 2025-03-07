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
    /// Informações da Nota Fiscal eletrônica.
    /// </summary>
    [DataContract(Name = "NfeSefazInfNFe")]
    public partial class NfeSefazInfNFe : IEquatable<NfeSefazInfNFe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfNFe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazInfNFe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfNFe" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute (v4.00). (required).</param>
        /// <param name="id">PL_005d - 11/08/09 - validação do Id.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="avulsa">avulsa.</param>
        /// <param name="dest">dest.</param>
        /// <param name="retirada">retirada.</param>
        /// <param name="entrega">entrega.</param>
        /// <param name="autXML">autXML.</param>
        /// <param name="det">det (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="transp">transp (required).</param>
        /// <param name="cobr">cobr.</param>
        /// <param name="pag">pag (required).</param>
        /// <param name="infIntermed">infIntermed.</param>
        /// <param name="infAdic">infAdic.</param>
        /// <param name="exporta">exporta.</param>
        /// <param name="compra">compra.</param>
        /// <param name="cana">cana.</param>
        /// <param name="infRespTec">infRespTec.</param>
        /// <param name="infSolicNFF">infSolicNFF.</param>
        /// <param name="agropecuario">agropecuario.</param>
        public NfeSefazInfNFe(string versao = default(string), string id = default(string), NfeSefazIde ide = default(NfeSefazIde), NfeSefazEmit emit = default(NfeSefazEmit), NfeSefazAvulsa avulsa = default(NfeSefazAvulsa), NfeSefazDest dest = default(NfeSefazDest), NfeSefazLocal retirada = default(NfeSefazLocal), NfeSefazLocal entrega = default(NfeSefazLocal), List<NfeSefazAutXML> autXML = default(List<NfeSefazAutXML>), List<NfeSefazDet> det = default(List<NfeSefazDet>), NfeSefazTotal total = default(NfeSefazTotal), NfeSefazTransp transp = default(NfeSefazTransp), NfeSefazCobr cobr = default(NfeSefazCobr), NfeSefazPag pag = default(NfeSefazPag), NfeSefazInfIntermed infIntermed = default(NfeSefazInfIntermed), NfeSefazInfAdic infAdic = default(NfeSefazInfAdic), NfeSefazExporta exporta = default(NfeSefazExporta), NfeSefazCompra compra = default(NfeSefazCompra), NfeSefazCana cana = default(NfeSefazCana), NfeSefazInfRespTec infRespTec = default(NfeSefazInfRespTec), NfeSefazInfSolicNFF infSolicNFF = default(NfeSefazInfSolicNFF), NfeSefazAgropecuario agropecuario = default(NfeSefazAgropecuario))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.emit = emit;
            // to ensure "det" is required (not null)
            if (det == null)
            {
                throw new ArgumentNullException("det is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.det = det;
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.total = total;
            // to ensure "transp" is required (not null)
            if (transp == null)
            {
                throw new ArgumentNullException("transp is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.transp = transp;
            // to ensure "pag" is required (not null)
            if (pag == null)
            {
                throw new ArgumentNullException("pag is a required property for NfeSefazInfNFe and cannot be null");
            }
            this.pag = pag;
            this.Id = id;
            this.avulsa = avulsa;
            this.dest = dest;
            this.retirada = retirada;
            this.entrega = entrega;
            this.autXML = autXML;
            this.cobr = cobr;
            this.infIntermed = infIntermed;
            this.infAdic = infAdic;
            this.exporta = exporta;
            this.compra = compra;
            this.cana = cana;
            this.infRespTec = infRespTec;
            this.infSolicNFF = infSolicNFF;
            this.agropecuario = agropecuario;
        }

        /// <summary>
        /// Versão do leiaute (v4.00).
        /// </summary>
        /// <value>Versão do leiaute (v4.00).</value>
        [DataMember(Name = "versao", IsRequired = true, EmitDefaultValue = true)]
        public string versao { get; set; }

        /// <summary>
        /// PL_005d - 11/08/09 - validação do Id.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>PL_005d - 11/08/09 - validação do Id.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazIde ide { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazEmit emit { get; set; }

        /// <summary>
        /// Gets or Sets avulsa
        /// </summary>
        [DataMember(Name = "avulsa", EmitDefaultValue = false)]
        public NfeSefazAvulsa avulsa { get; set; }

        /// <summary>
        /// Gets or Sets dest
        /// </summary>
        [DataMember(Name = "dest", EmitDefaultValue = false)]
        public NfeSefazDest dest { get; set; }

        /// <summary>
        /// Gets or Sets retirada
        /// </summary>
        [DataMember(Name = "retirada", EmitDefaultValue = false)]
        public NfeSefazLocal retirada { get; set; }

        /// <summary>
        /// Gets or Sets entrega
        /// </summary>
        [DataMember(Name = "entrega", EmitDefaultValue = false)]
        public NfeSefazLocal entrega { get; set; }

        /// <summary>
        /// Gets or Sets autXML
        /// </summary>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<NfeSefazAutXML> autXML { get; set; }

        /// <summary>
        /// Gets or Sets det
        /// </summary>
        [DataMember(Name = "det", IsRequired = true, EmitDefaultValue = true)]
        public List<NfeSefazDet> det { get; set; }

        /// <summary>
        /// Gets or Sets total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazTotal total { get; set; }

        /// <summary>
        /// Gets or Sets transp
        /// </summary>
        [DataMember(Name = "transp", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazTransp transp { get; set; }

        /// <summary>
        /// Gets or Sets cobr
        /// </summary>
        [DataMember(Name = "cobr", EmitDefaultValue = false)]
        public NfeSefazCobr cobr { get; set; }

        /// <summary>
        /// Gets or Sets pag
        /// </summary>
        [DataMember(Name = "pag", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazPag pag { get; set; }

        /// <summary>
        /// Gets or Sets infIntermed
        /// </summary>
        [DataMember(Name = "infIntermed", EmitDefaultValue = false)]
        public NfeSefazInfIntermed infIntermed { get; set; }

        /// <summary>
        /// Gets or Sets infAdic
        /// </summary>
        [DataMember(Name = "infAdic", EmitDefaultValue = false)]
        public NfeSefazInfAdic infAdic { get; set; }

        /// <summary>
        /// Gets or Sets exporta
        /// </summary>
        [DataMember(Name = "exporta", EmitDefaultValue = false)]
        public NfeSefazExporta exporta { get; set; }

        /// <summary>
        /// Gets or Sets compra
        /// </summary>
        [DataMember(Name = "compra", EmitDefaultValue = false)]
        public NfeSefazCompra compra { get; set; }

        /// <summary>
        /// Gets or Sets cana
        /// </summary>
        [DataMember(Name = "cana", EmitDefaultValue = false)]
        public NfeSefazCana cana { get; set; }

        /// <summary>
        /// Gets or Sets infRespTec
        /// </summary>
        [DataMember(Name = "infRespTec", EmitDefaultValue = false)]
        public NfeSefazInfRespTec infRespTec { get; set; }

        /// <summary>
        /// Gets or Sets infSolicNFF
        /// </summary>
        [DataMember(Name = "infSolicNFF", EmitDefaultValue = false)]
        public NfeSefazInfSolicNFF infSolicNFF { get; set; }

        /// <summary>
        /// Gets or Sets agropecuario
        /// </summary>
        [DataMember(Name = "agropecuario", EmitDefaultValue = false)]
        public NfeSefazAgropecuario agropecuario { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfNFe {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  avulsa: ").Append(avulsa).Append("\n");
            sb.Append("  dest: ").Append(dest).Append("\n");
            sb.Append("  retirada: ").Append(retirada).Append("\n");
            sb.Append("  entrega: ").Append(entrega).Append("\n");
            sb.Append("  autXML: ").Append(autXML).Append("\n");
            sb.Append("  det: ").Append(det).Append("\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  transp: ").Append(transp).Append("\n");
            sb.Append("  cobr: ").Append(cobr).Append("\n");
            sb.Append("  pag: ").Append(pag).Append("\n");
            sb.Append("  infIntermed: ").Append(infIntermed).Append("\n");
            sb.Append("  infAdic: ").Append(infAdic).Append("\n");
            sb.Append("  exporta: ").Append(exporta).Append("\n");
            sb.Append("  compra: ").Append(compra).Append("\n");
            sb.Append("  cana: ").Append(cana).Append("\n");
            sb.Append("  infRespTec: ").Append(infRespTec).Append("\n");
            sb.Append("  infSolicNFF: ").Append(infSolicNFF).Append("\n");
            sb.Append("  agropecuario: ").Append(agropecuario).Append("\n");
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
            return this.Equals(input as NfeSefazInfNFe);
        }

        /// <summary>
        /// Returns true if NfeSefazInfNFe instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfNFe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfNFe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.versao == input.versao ||
                    (this.versao != null &&
                    this.versao.Equals(input.versao))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ide == input.ide ||
                    (this.ide != null &&
                    this.ide.Equals(input.ide))
                ) && 
                (
                    this.emit == input.emit ||
                    (this.emit != null &&
                    this.emit.Equals(input.emit))
                ) && 
                (
                    this.avulsa == input.avulsa ||
                    (this.avulsa != null &&
                    this.avulsa.Equals(input.avulsa))
                ) && 
                (
                    this.dest == input.dest ||
                    (this.dest != null &&
                    this.dest.Equals(input.dest))
                ) && 
                (
                    this.retirada == input.retirada ||
                    (this.retirada != null &&
                    this.retirada.Equals(input.retirada))
                ) && 
                (
                    this.entrega == input.entrega ||
                    (this.entrega != null &&
                    this.entrega.Equals(input.entrega))
                ) && 
                (
                    this.autXML == input.autXML ||
                    this.autXML != null &&
                    input.autXML != null &&
                    this.autXML.SequenceEqual(input.autXML)
                ) && 
                (
                    this.det == input.det ||
                    this.det != null &&
                    input.det != null &&
                    this.det.SequenceEqual(input.det)
                ) && 
                (
                    this.total == input.total ||
                    (this.total != null &&
                    this.total.Equals(input.total))
                ) && 
                (
                    this.transp == input.transp ||
                    (this.transp != null &&
                    this.transp.Equals(input.transp))
                ) && 
                (
                    this.cobr == input.cobr ||
                    (this.cobr != null &&
                    this.cobr.Equals(input.cobr))
                ) && 
                (
                    this.pag == input.pag ||
                    (this.pag != null &&
                    this.pag.Equals(input.pag))
                ) && 
                (
                    this.infIntermed == input.infIntermed ||
                    (this.infIntermed != null &&
                    this.infIntermed.Equals(input.infIntermed))
                ) && 
                (
                    this.infAdic == input.infAdic ||
                    (this.infAdic != null &&
                    this.infAdic.Equals(input.infAdic))
                ) && 
                (
                    this.exporta == input.exporta ||
                    (this.exporta != null &&
                    this.exporta.Equals(input.exporta))
                ) && 
                (
                    this.compra == input.compra ||
                    (this.compra != null &&
                    this.compra.Equals(input.compra))
                ) && 
                (
                    this.cana == input.cana ||
                    (this.cana != null &&
                    this.cana.Equals(input.cana))
                ) && 
                (
                    this.infRespTec == input.infRespTec ||
                    (this.infRespTec != null &&
                    this.infRespTec.Equals(input.infRespTec))
                ) && 
                (
                    this.infSolicNFF == input.infSolicNFF ||
                    (this.infSolicNFF != null &&
                    this.infSolicNFF.Equals(input.infSolicNFF))
                ) && 
                (
                    this.agropecuario == input.agropecuario ||
                    (this.agropecuario != null &&
                    this.agropecuario.Equals(input.agropecuario))
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
                if (this.versao != null)
                {
                    hashCode = (hashCode * 59) + this.versao.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ide != null)
                {
                    hashCode = (hashCode * 59) + this.ide.GetHashCode();
                }
                if (this.emit != null)
                {
                    hashCode = (hashCode * 59) + this.emit.GetHashCode();
                }
                if (this.avulsa != null)
                {
                    hashCode = (hashCode * 59) + this.avulsa.GetHashCode();
                }
                if (this.dest != null)
                {
                    hashCode = (hashCode * 59) + this.dest.GetHashCode();
                }
                if (this.retirada != null)
                {
                    hashCode = (hashCode * 59) + this.retirada.GetHashCode();
                }
                if (this.entrega != null)
                {
                    hashCode = (hashCode * 59) + this.entrega.GetHashCode();
                }
                if (this.autXML != null)
                {
                    hashCode = (hashCode * 59) + this.autXML.GetHashCode();
                }
                if (this.det != null)
                {
                    hashCode = (hashCode * 59) + this.det.GetHashCode();
                }
                if (this.total != null)
                {
                    hashCode = (hashCode * 59) + this.total.GetHashCode();
                }
                if (this.transp != null)
                {
                    hashCode = (hashCode * 59) + this.transp.GetHashCode();
                }
                if (this.cobr != null)
                {
                    hashCode = (hashCode * 59) + this.cobr.GetHashCode();
                }
                if (this.pag != null)
                {
                    hashCode = (hashCode * 59) + this.pag.GetHashCode();
                }
                if (this.infIntermed != null)
                {
                    hashCode = (hashCode * 59) + this.infIntermed.GetHashCode();
                }
                if (this.infAdic != null)
                {
                    hashCode = (hashCode * 59) + this.infAdic.GetHashCode();
                }
                if (this.exporta != null)
                {
                    hashCode = (hashCode * 59) + this.exporta.GetHashCode();
                }
                if (this.compra != null)
                {
                    hashCode = (hashCode * 59) + this.compra.GetHashCode();
                }
                if (this.cana != null)
                {
                    hashCode = (hashCode * 59) + this.cana.GetHashCode();
                }
                if (this.infRespTec != null)
                {
                    hashCode = (hashCode * 59) + this.infRespTec.GetHashCode();
                }
                if (this.infSolicNFF != null)
                {
                    hashCode = (hashCode * 59) + this.infSolicNFF.GetHashCode();
                }
                if (this.agropecuario != null)
                {
                    hashCode = (hashCode * 59) + this.agropecuario.GetHashCode();
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
            yield break;
        }
    }

}
