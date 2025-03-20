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
    /// Informações da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazInfDCe")]
    public partial class DceSefazInfDCe : IEquatable<DceSefazInfDCe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazInfDCe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazInfDCe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazInfDCe" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute. (required).</param>
        /// <param name="id">Identificador da tag a ser assinada.  Informar a chave de acesso precedida do literal \&quot;DCe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="fisco">fisco.</param>
        /// <param name="marketplace">marketplace.</param>
        /// <param name="transportadora">transportadora.</param>
        /// <param name="eCT">eCT.</param>
        /// <param name="dest">dest (required).</param>
        /// <param name="autXML">autXML.</param>
        /// <param name="det">det (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="transp">transp (required).</param>
        /// <param name="infAdic">infAdic.</param>
        /// <param name="infDec">infDec.</param>
        public DceSefazInfDCe(string versao = default(string), string id = default(string), DceSefazIde ide = default(DceSefazIde), DceSefazEmit emit = default(DceSefazEmit), DceSefazFisco fisco = default(DceSefazFisco), DceSefazMarketplace marketplace = default(DceSefazMarketplace), DceSefazTransportadora transportadora = default(DceSefazTransportadora), DceSefazECT eCT = default(DceSefazECT), DceSefazDest dest = default(DceSefazDest), List<DceSefazAutXML> autXML = default(List<DceSefazAutXML>), List<DceSefazDet> det = default(List<DceSefazDet>), DceSefazTotal total = default(DceSefazTotal), DceSefazTransp transp = default(DceSefazTransp), DceSefazInfAdic infAdic = default(DceSefazInfAdic), DceSefazInfDec infDec = default(DceSefazInfDec))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for DceSefazInfDCe and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for DceSefazInfDCe and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for DceSefazInfDCe and cannot be null");
            }
            this.emit = emit;
            // to ensure "dest" is required (not null)
            if (dest == null)
            {
                throw new ArgumentNullException("dest is a required property for DceSefazInfDCe and cannot be null");
            }
            this.dest = dest;
            // to ensure "det" is required (not null)
            if (det == null)
            {
                throw new ArgumentNullException("det is a required property for DceSefazInfDCe and cannot be null");
            }
            this.det = det;
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for DceSefazInfDCe and cannot be null");
            }
            this.total = total;
            // to ensure "transp" is required (not null)
            if (transp == null)
            {
                throw new ArgumentNullException("transp is a required property for DceSefazInfDCe and cannot be null");
            }
            this.transp = transp;
            this.Id = id;
            this.Fisco = fisco;
            this.Marketplace = marketplace;
            this.Transportadora = transportadora;
            this.ECT = eCT;
            this.autXML = autXML;
            this.infAdic = infAdic;
            this.infDec = infDec;
        }

        /// <summary>
        /// Versão do leiaute.
        /// </summary>
        /// <value>Versão do leiaute.</value>
        [DataMember(Name = "versao", IsRequired = true, EmitDefaultValue = true)]
        public string versao { get; set; }

        /// <summary>
        /// Identificador da tag a ser assinada.  Informar a chave de acesso precedida do literal \&quot;DCe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Identificador da tag a ser assinada.  Informar a chave de acesso precedida do literal \&quot;DCe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazIde ide { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazEmit emit { get; set; }

        /// <summary>
        /// Gets or Sets Fisco
        /// </summary>
        [DataMember(Name = "Fisco", EmitDefaultValue = false)]
        public DceSefazFisco Fisco { get; set; }

        /// <summary>
        /// Gets or Sets Marketplace
        /// </summary>
        [DataMember(Name = "Marketplace", EmitDefaultValue = false)]
        public DceSefazMarketplace Marketplace { get; set; }

        /// <summary>
        /// Gets or Sets Transportadora
        /// </summary>
        [DataMember(Name = "Transportadora", EmitDefaultValue = false)]
        public DceSefazTransportadora Transportadora { get; set; }

        /// <summary>
        /// Gets or Sets ECT
        /// </summary>
        [DataMember(Name = "ECT", EmitDefaultValue = false)]
        public DceSefazECT ECT { get; set; }

        /// <summary>
        /// Gets or Sets dest
        /// </summary>
        [DataMember(Name = "dest", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazDest dest { get; set; }

        /// <summary>
        /// Gets or Sets autXML
        /// </summary>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<DceSefazAutXML> autXML { get; set; }

        /// <summary>
        /// Gets or Sets det
        /// </summary>
        [DataMember(Name = "det", IsRequired = true, EmitDefaultValue = true)]
        public List<DceSefazDet> det { get; set; }

        /// <summary>
        /// Gets or Sets total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazTotal total { get; set; }

        /// <summary>
        /// Gets or Sets transp
        /// </summary>
        [DataMember(Name = "transp", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazTransp transp { get; set; }

        /// <summary>
        /// Gets or Sets infAdic
        /// </summary>
        [DataMember(Name = "infAdic", EmitDefaultValue = false)]
        public DceSefazInfAdic infAdic { get; set; }

        /// <summary>
        /// Gets or Sets infDec
        /// </summary>
        [DataMember(Name = "infDec", EmitDefaultValue = false)]
        public DceSefazInfDec infDec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazInfDCe {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  Fisco: ").Append(Fisco).Append("\n");
            sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
            sb.Append("  Transportadora: ").Append(Transportadora).Append("\n");
            sb.Append("  ECT: ").Append(ECT).Append("\n");
            sb.Append("  dest: ").Append(dest).Append("\n");
            sb.Append("  autXML: ").Append(autXML).Append("\n");
            sb.Append("  det: ").Append(det).Append("\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  transp: ").Append(transp).Append("\n");
            sb.Append("  infAdic: ").Append(infAdic).Append("\n");
            sb.Append("  infDec: ").Append(infDec).Append("\n");
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
            return this.Equals(input as DceSefazInfDCe);
        }

        /// <summary>
        /// Returns true if DceSefazInfDCe instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazInfDCe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazInfDCe input)
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
                    this.Fisco == input.Fisco ||
                    (this.Fisco != null &&
                    this.Fisco.Equals(input.Fisco))
                ) && 
                (
                    this.Marketplace == input.Marketplace ||
                    (this.Marketplace != null &&
                    this.Marketplace.Equals(input.Marketplace))
                ) && 
                (
                    this.Transportadora == input.Transportadora ||
                    (this.Transportadora != null &&
                    this.Transportadora.Equals(input.Transportadora))
                ) && 
                (
                    this.ECT == input.ECT ||
                    (this.ECT != null &&
                    this.ECT.Equals(input.ECT))
                ) && 
                (
                    this.dest == input.dest ||
                    (this.dest != null &&
                    this.dest.Equals(input.dest))
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
                    this.infAdic == input.infAdic ||
                    (this.infAdic != null &&
                    this.infAdic.Equals(input.infAdic))
                ) && 
                (
                    this.infDec == input.infDec ||
                    (this.infDec != null &&
                    this.infDec.Equals(input.infDec))
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
                if (this.Fisco != null)
                {
                    hashCode = (hashCode * 59) + this.Fisco.GetHashCode();
                }
                if (this.Marketplace != null)
                {
                    hashCode = (hashCode * 59) + this.Marketplace.GetHashCode();
                }
                if (this.Transportadora != null)
                {
                    hashCode = (hashCode * 59) + this.Transportadora.GetHashCode();
                }
                if (this.ECT != null)
                {
                    hashCode = (hashCode * 59) + this.ECT.GetHashCode();
                }
                if (this.dest != null)
                {
                    hashCode = (hashCode * 59) + this.dest.GetHashCode();
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
                if (this.infAdic != null)
                {
                    hashCode = (hashCode * 59) + this.infAdic.GetHashCode();
                }
                if (this.infDec != null)
                {
                    hashCode = (hashCode * 59) + this.infDec.GetHashCode();
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
