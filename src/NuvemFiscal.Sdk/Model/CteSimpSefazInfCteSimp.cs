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
    /// Informações do CT-e.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfCteSimp")]
    public partial class CteSimpSefazInfCteSimp : IEquatable<CteSimpSefazInfCteSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCteSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazInfCteSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfCteSimp" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute.  Ex: \&quot;4.00\&quot;. (required).</param>
        /// <param name="id">Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="compl">compl.</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="toma">toma (required).</param>
        /// <param name="infCarga">infCarga (required).</param>
        /// <param name="det">det (required).</param>
        /// <param name="infModal">infModal (required).</param>
        /// <param name="cobr">cobr.</param>
        /// <param name="infCteSub">infCteSub.</param>
        /// <param name="imp">imp (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="autXML">autXML.</param>
        /// <param name="infRespTec">infRespTec.</param>
        /// <param name="infSolicNFF">infSolicNFF.</param>
        public CteSimpSefazInfCteSimp(string versao = default(string), string id = default(string), CteSimpSefazIdeSimp ide = default(CteSimpSefazIdeSimp), CteSimpSefazComplSimp compl = default(CteSimpSefazComplSimp), CteSimpSefazEmitSimp emit = default(CteSimpSefazEmitSimp), CteSimpSefazTomaSimp toma = default(CteSimpSefazTomaSimp), CteSimpSefazInfCargaSimp infCarga = default(CteSimpSefazInfCargaSimp), List<CteSimpSefazDetSimp> det = default(List<CteSimpSefazDetSimp>), CteSimpSefazInfModalSimp infModal = default(CteSimpSefazInfModalSimp), CteSimpSefazCobrSimp cobr = default(CteSimpSefazCobrSimp), CteSimpSefazInfCteSubSimp infCteSub = default(CteSimpSefazInfCteSubSimp), CteSimpSefazInfCteImpSimp imp = default(CteSimpSefazInfCteImpSimp), CteSimpSefazTotalSimp total = default(CteSimpSefazTotalSimp), List<CteSimpSefazAutXMLSimp> autXML = default(List<CteSimpSefazAutXMLSimp>), CteSimpSefazRespTecSimp infRespTec = default(CteSimpSefazRespTecSimp), CteSimpSefazInfSolicNFFSimp infSolicNFF = default(CteSimpSefazInfSolicNFFSimp))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.emit = emit;
            // to ensure "toma" is required (not null)
            if (toma == null)
            {
                throw new ArgumentNullException("toma is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.toma = toma;
            // to ensure "infCarga" is required (not null)
            if (infCarga == null)
            {
                throw new ArgumentNullException("infCarga is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.infCarga = infCarga;
            // to ensure "det" is required (not null)
            if (det == null)
            {
                throw new ArgumentNullException("det is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.det = det;
            // to ensure "infModal" is required (not null)
            if (infModal == null)
            {
                throw new ArgumentNullException("infModal is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.infModal = infModal;
            // to ensure "imp" is required (not null)
            if (imp == null)
            {
                throw new ArgumentNullException("imp is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.imp = imp;
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for CteSimpSefazInfCteSimp and cannot be null");
            }
            this.total = total;
            this.Id = id;
            this.compl = compl;
            this.cobr = cobr;
            this.infCteSub = infCteSub;
            this.autXML = autXML;
            this.infRespTec = infRespTec;
            this.infSolicNFF = infSolicNFF;
        }

        /// <summary>
        /// Versão do leiaute.  Ex: \&quot;4.00\&quot;.
        /// </summary>
        /// <value>Versão do leiaute.  Ex: \&quot;4.00\&quot;.</value>
        [DataMember(Name = "versao", IsRequired = true, EmitDefaultValue = true)]
        public string versao { get; set; }

        /// <summary>
        /// Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazIdeSimp ide { get; set; }

        /// <summary>
        /// Gets or Sets compl
        /// </summary>
        [DataMember(Name = "compl", EmitDefaultValue = false)]
        public CteSimpSefazComplSimp compl { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazEmitSimp emit { get; set; }

        /// <summary>
        /// Gets or Sets toma
        /// </summary>
        [DataMember(Name = "toma", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazTomaSimp toma { get; set; }

        /// <summary>
        /// Gets or Sets infCarga
        /// </summary>
        [DataMember(Name = "infCarga", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazInfCargaSimp infCarga { get; set; }

        /// <summary>
        /// Gets or Sets det
        /// </summary>
        [DataMember(Name = "det", IsRequired = true, EmitDefaultValue = true)]
        public List<CteSimpSefazDetSimp> det { get; set; }

        /// <summary>
        /// Gets or Sets infModal
        /// </summary>
        [DataMember(Name = "infModal", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazInfModalSimp infModal { get; set; }

        /// <summary>
        /// Gets or Sets cobr
        /// </summary>
        [DataMember(Name = "cobr", EmitDefaultValue = false)]
        public CteSimpSefazCobrSimp cobr { get; set; }

        /// <summary>
        /// Gets or Sets infCteSub
        /// </summary>
        [DataMember(Name = "infCteSub", EmitDefaultValue = false)]
        public CteSimpSefazInfCteSubSimp infCteSub { get; set; }

        /// <summary>
        /// Gets or Sets imp
        /// </summary>
        [DataMember(Name = "imp", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazInfCteImpSimp imp { get; set; }

        /// <summary>
        /// Gets or Sets total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public CteSimpSefazTotalSimp total { get; set; }

        /// <summary>
        /// Gets or Sets autXML
        /// </summary>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<CteSimpSefazAutXMLSimp> autXML { get; set; }

        /// <summary>
        /// Gets or Sets infRespTec
        /// </summary>
        [DataMember(Name = "infRespTec", EmitDefaultValue = false)]
        public CteSimpSefazRespTecSimp infRespTec { get; set; }

        /// <summary>
        /// Gets or Sets infSolicNFF
        /// </summary>
        [DataMember(Name = "infSolicNFF", EmitDefaultValue = false)]
        public CteSimpSefazInfSolicNFFSimp infSolicNFF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfCteSimp {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  compl: ").Append(compl).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  toma: ").Append(toma).Append("\n");
            sb.Append("  infCarga: ").Append(infCarga).Append("\n");
            sb.Append("  det: ").Append(det).Append("\n");
            sb.Append("  infModal: ").Append(infModal).Append("\n");
            sb.Append("  cobr: ").Append(cobr).Append("\n");
            sb.Append("  infCteSub: ").Append(infCteSub).Append("\n");
            sb.Append("  imp: ").Append(imp).Append("\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  autXML: ").Append(autXML).Append("\n");
            sb.Append("  infRespTec: ").Append(infRespTec).Append("\n");
            sb.Append("  infSolicNFF: ").Append(infSolicNFF).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfCteSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfCteSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfCteSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfCteSimp input)
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
                    this.compl == input.compl ||
                    (this.compl != null &&
                    this.compl.Equals(input.compl))
                ) && 
                (
                    this.emit == input.emit ||
                    (this.emit != null &&
                    this.emit.Equals(input.emit))
                ) && 
                (
                    this.toma == input.toma ||
                    (this.toma != null &&
                    this.toma.Equals(input.toma))
                ) && 
                (
                    this.infCarga == input.infCarga ||
                    (this.infCarga != null &&
                    this.infCarga.Equals(input.infCarga))
                ) && 
                (
                    this.det == input.det ||
                    this.det != null &&
                    input.det != null &&
                    this.det.SequenceEqual(input.det)
                ) && 
                (
                    this.infModal == input.infModal ||
                    (this.infModal != null &&
                    this.infModal.Equals(input.infModal))
                ) && 
                (
                    this.cobr == input.cobr ||
                    (this.cobr != null &&
                    this.cobr.Equals(input.cobr))
                ) && 
                (
                    this.infCteSub == input.infCteSub ||
                    (this.infCteSub != null &&
                    this.infCteSub.Equals(input.infCteSub))
                ) && 
                (
                    this.imp == input.imp ||
                    (this.imp != null &&
                    this.imp.Equals(input.imp))
                ) && 
                (
                    this.total == input.total ||
                    (this.total != null &&
                    this.total.Equals(input.total))
                ) && 
                (
                    this.autXML == input.autXML ||
                    this.autXML != null &&
                    input.autXML != null &&
                    this.autXML.SequenceEqual(input.autXML)
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
                if (this.compl != null)
                {
                    hashCode = (hashCode * 59) + this.compl.GetHashCode();
                }
                if (this.emit != null)
                {
                    hashCode = (hashCode * 59) + this.emit.GetHashCode();
                }
                if (this.toma != null)
                {
                    hashCode = (hashCode * 59) + this.toma.GetHashCode();
                }
                if (this.infCarga != null)
                {
                    hashCode = (hashCode * 59) + this.infCarga.GetHashCode();
                }
                if (this.det != null)
                {
                    hashCode = (hashCode * 59) + this.det.GetHashCode();
                }
                if (this.infModal != null)
                {
                    hashCode = (hashCode * 59) + this.infModal.GetHashCode();
                }
                if (this.cobr != null)
                {
                    hashCode = (hashCode * 59) + this.cobr.GetHashCode();
                }
                if (this.infCteSub != null)
                {
                    hashCode = (hashCode * 59) + this.infCteSub.GetHashCode();
                }
                if (this.imp != null)
                {
                    hashCode = (hashCode * 59) + this.imp.GetHashCode();
                }
                if (this.total != null)
                {
                    hashCode = (hashCode * 59) + this.total.GetHashCode();
                }
                if (this.autXML != null)
                {
                    hashCode = (hashCode * 59) + this.autXML.GetHashCode();
                }
                if (this.infRespTec != null)
                {
                    hashCode = (hashCode * 59) + this.infRespTec.GetHashCode();
                }
                if (this.infSolicNFF != null)
                {
                    hashCode = (hashCode * 59) + this.infSolicNFF.GetHashCode();
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
