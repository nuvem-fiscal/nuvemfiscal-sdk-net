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
    /// Informações do MDF-e.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMDFe")]
    public partial class MdfeSefazInfMDFe : IEquatable<MdfeSefazInfMDFe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfMDFe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFe" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute.  Ex: \&quot;3.00\&quot;. (required).</param>
        /// <param name="id">Identificador da tag a ser assinada.  Informar a chave de acesso do MDF-e e precedida do literal \&quot;MDFe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="infModal">infModal (required).</param>
        /// <param name="infDoc">infDoc (required).</param>
        /// <param name="seg">seg.</param>
        /// <param name="prodPred">prodPred.</param>
        /// <param name="tot">tot (required).</param>
        /// <param name="lacres">lacres.</param>
        /// <param name="autXML">autXML.</param>
        /// <param name="infAdic">infAdic.</param>
        /// <param name="infRespTec">infRespTec.</param>
        /// <param name="infSolicNFF">infSolicNFF.</param>
        public MdfeSefazInfMDFe(string versao = default(string), string id = default(string), MdfeSefazIde ide = default(MdfeSefazIde), MdfeSefazEmit emit = default(MdfeSefazEmit), MdfeSefazInfModal infModal = default(MdfeSefazInfModal), MdfeSefazInfDoc infDoc = default(MdfeSefazInfDoc), List<MdfeSefazSeg> seg = default(List<MdfeSefazSeg>), MdfeSefazProdPred prodPred = default(MdfeSefazProdPred), MdfeSefazTot tot = default(MdfeSefazTot), List<MdfeSefazLacres> lacres = default(List<MdfeSefazLacres>), List<MdfeSefazAutXML> autXML = default(List<MdfeSefazAutXML>), MdfeSefazInfAdic infAdic = default(MdfeSefazInfAdic), MdfeSefazRespTec infRespTec = default(MdfeSefazRespTec), MdfeSefazInfSolicNFF infSolicNFF = default(MdfeSefazInfSolicNFF))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for MdfeSefazInfMDFe and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for MdfeSefazInfMDFe and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for MdfeSefazInfMDFe and cannot be null");
            }
            this.emit = emit;
            // to ensure "infModal" is required (not null)
            if (infModal == null)
            {
                throw new ArgumentNullException("infModal is a required property for MdfeSefazInfMDFe and cannot be null");
            }
            this.infModal = infModal;
            // to ensure "infDoc" is required (not null)
            if (infDoc == null)
            {
                throw new ArgumentNullException("infDoc is a required property for MdfeSefazInfMDFe and cannot be null");
            }
            this.infDoc = infDoc;
            // to ensure "tot" is required (not null)
            if (tot == null)
            {
                throw new ArgumentNullException("tot is a required property for MdfeSefazInfMDFe and cannot be null");
            }
            this.tot = tot;
            this.Id = id;
            this.seg = seg;
            this.prodPred = prodPred;
            this.lacres = lacres;
            this.autXML = autXML;
            this.infAdic = infAdic;
            this.infRespTec = infRespTec;
            this.infSolicNFF = infSolicNFF;
        }

        /// <summary>
        /// Versão do leiaute.  Ex: \&quot;3.00\&quot;.
        /// </summary>
        /// <value>Versão do leiaute.  Ex: \&quot;3.00\&quot;.</value>
        [DataMember(Name = "versao", IsRequired = true, EmitDefaultValue = true)]
        public string versao { get; set; }

        /// <summary>
        /// Identificador da tag a ser assinada.  Informar a chave de acesso do MDF-e e precedida do literal \&quot;MDFe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Identificador da tag a ser assinada.  Informar a chave de acesso do MDF-e e precedida do literal \&quot;MDFe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazIde ide { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazEmit emit { get; set; }

        /// <summary>
        /// Gets or Sets infModal
        /// </summary>
        [DataMember(Name = "infModal", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazInfModal infModal { get; set; }

        /// <summary>
        /// Gets or Sets infDoc
        /// </summary>
        [DataMember(Name = "infDoc", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazInfDoc infDoc { get; set; }

        /// <summary>
        /// Gets or Sets seg
        /// </summary>
        [DataMember(Name = "seg", EmitDefaultValue = false)]
        public List<MdfeSefazSeg> seg { get; set; }

        /// <summary>
        /// Gets or Sets prodPred
        /// </summary>
        [DataMember(Name = "prodPred", EmitDefaultValue = false)]
        public MdfeSefazProdPred prodPred { get; set; }

        /// <summary>
        /// Gets or Sets tot
        /// </summary>
        [DataMember(Name = "tot", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazTot tot { get; set; }

        /// <summary>
        /// Gets or Sets lacres
        /// </summary>
        [DataMember(Name = "lacres", EmitDefaultValue = false)]
        public List<MdfeSefazLacres> lacres { get; set; }

        /// <summary>
        /// Gets or Sets autXML
        /// </summary>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<MdfeSefazAutXML> autXML { get; set; }

        /// <summary>
        /// Gets or Sets infAdic
        /// </summary>
        [DataMember(Name = "infAdic", EmitDefaultValue = false)]
        public MdfeSefazInfAdic infAdic { get; set; }

        /// <summary>
        /// Gets or Sets infRespTec
        /// </summary>
        [DataMember(Name = "infRespTec", EmitDefaultValue = false)]
        public MdfeSefazRespTec infRespTec { get; set; }

        /// <summary>
        /// Gets or Sets infSolicNFF
        /// </summary>
        [DataMember(Name = "infSolicNFF", EmitDefaultValue = false)]
        public MdfeSefazInfSolicNFF infSolicNFF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMDFe {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  infModal: ").Append(infModal).Append("\n");
            sb.Append("  infDoc: ").Append(infDoc).Append("\n");
            sb.Append("  seg: ").Append(seg).Append("\n");
            sb.Append("  prodPred: ").Append(prodPred).Append("\n");
            sb.Append("  tot: ").Append(tot).Append("\n");
            sb.Append("  lacres: ").Append(lacres).Append("\n");
            sb.Append("  autXML: ").Append(autXML).Append("\n");
            sb.Append("  infAdic: ").Append(infAdic).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMDFe);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMDFe instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMDFe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMDFe input)
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
                    this.infModal == input.infModal ||
                    (this.infModal != null &&
                    this.infModal.Equals(input.infModal))
                ) && 
                (
                    this.infDoc == input.infDoc ||
                    (this.infDoc != null &&
                    this.infDoc.Equals(input.infDoc))
                ) && 
                (
                    this.seg == input.seg ||
                    this.seg != null &&
                    input.seg != null &&
                    this.seg.SequenceEqual(input.seg)
                ) && 
                (
                    this.prodPred == input.prodPred ||
                    (this.prodPred != null &&
                    this.prodPred.Equals(input.prodPred))
                ) && 
                (
                    this.tot == input.tot ||
                    (this.tot != null &&
                    this.tot.Equals(input.tot))
                ) && 
                (
                    this.lacres == input.lacres ||
                    this.lacres != null &&
                    input.lacres != null &&
                    this.lacres.SequenceEqual(input.lacres)
                ) && 
                (
                    this.autXML == input.autXML ||
                    this.autXML != null &&
                    input.autXML != null &&
                    this.autXML.SequenceEqual(input.autXML)
                ) && 
                (
                    this.infAdic == input.infAdic ||
                    (this.infAdic != null &&
                    this.infAdic.Equals(input.infAdic))
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
                if (this.emit != null)
                {
                    hashCode = (hashCode * 59) + this.emit.GetHashCode();
                }
                if (this.infModal != null)
                {
                    hashCode = (hashCode * 59) + this.infModal.GetHashCode();
                }
                if (this.infDoc != null)
                {
                    hashCode = (hashCode * 59) + this.infDoc.GetHashCode();
                }
                if (this.seg != null)
                {
                    hashCode = (hashCode * 59) + this.seg.GetHashCode();
                }
                if (this.prodPred != null)
                {
                    hashCode = (hashCode * 59) + this.prodPred.GetHashCode();
                }
                if (this.tot != null)
                {
                    hashCode = (hashCode * 59) + this.tot.GetHashCode();
                }
                if (this.lacres != null)
                {
                    hashCode = (hashCode * 59) + this.lacres.GetHashCode();
                }
                if (this.autXML != null)
                {
                    hashCode = (hashCode * 59) + this.autXML.GetHashCode();
                }
                if (this.infAdic != null)
                {
                    hashCode = (hashCode * 59) + this.infAdic.GetHashCode();
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
