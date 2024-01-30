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
    /// Informações da NFCom.
    /// </summary>
    [DataContract(Name = "NfcomSefazInfNFCom")]
    public partial class NfcomSefazInfNFCom : IEquatable<NfcomSefazInfNFCom>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazInfNFCom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazInfNFCom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazInfNFCom" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute. (required).</param>
        /// <param name="id">Identificador da tag a ser assinada.  Informar a chave de acesso da NFCom e precedida do literal \&quot;NFCom\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="dest">dest (required).</param>
        /// <param name="assinante">assinante (required).</param>
        /// <param name="gSub">gSub.</param>
        /// <param name="gCofat">gCofat.</param>
        /// <param name="det">det (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="gFidelidade">gFidelidade.</param>
        /// <param name="gFat">gFat.</param>
        /// <param name="gFatCentral">gFatCentral.</param>
        /// <param name="autXML">autXML.</param>
        /// <param name="infAdic">infAdic.</param>
        /// <param name="gRespTec">gRespTec.</param>
        public NfcomSefazInfNFCom(string versao = default(string), string id = default(string), NfcomSefazIde ide = default(NfcomSefazIde), NfcomSefazEmit emit = default(NfcomSefazEmit), NfcomSefazDest dest = default(NfcomSefazDest), NfcomSefazAssinante assinante = default(NfcomSefazAssinante), NfcomSefazGSub gSub = default(NfcomSefazGSub), NfcomSefazGCofat gCofat = default(NfcomSefazGCofat), List<NfcomSefazDet> det = default(List<NfcomSefazDet>), NfcomSefazTotal total = default(NfcomSefazTotal), NfcomSefazGFidelidade gFidelidade = default(NfcomSefazGFidelidade), NfcomSefazGFat gFat = default(NfcomSefazGFat), NfcomSefazGFatCentral gFatCentral = default(NfcomSefazGFatCentral), List<NfcomSefazAutXML> autXML = default(List<NfcomSefazAutXML>), NfcomSefazInfAdic infAdic = default(NfcomSefazInfAdic), NfcomSefazRespTec gRespTec = default(NfcomSefazRespTec))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.emit = emit;
            // to ensure "dest" is required (not null)
            if (dest == null)
            {
                throw new ArgumentNullException("dest is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.dest = dest;
            // to ensure "assinante" is required (not null)
            if (assinante == null)
            {
                throw new ArgumentNullException("assinante is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.assinante = assinante;
            // to ensure "det" is required (not null)
            if (det == null)
            {
                throw new ArgumentNullException("det is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.det = det;
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new ArgumentNullException("total is a required property for NfcomSefazInfNFCom and cannot be null");
            }
            this.total = total;
            this.Id = id;
            this.gSub = gSub;
            this.gCofat = gCofat;
            this.gFidelidade = gFidelidade;
            this.gFat = gFat;
            this.gFatCentral = gFatCentral;
            this.autXML = autXML;
            this.infAdic = infAdic;
            this.gRespTec = gRespTec;
        }

        /// <summary>
        /// Versão do leiaute.
        /// </summary>
        /// <value>Versão do leiaute.</value>
        [DataMember(Name = "versao", IsRequired = true, EmitDefaultValue = true)]
        public string versao { get; set; }

        /// <summary>
        /// Identificador da tag a ser assinada.  Informar a chave de acesso da NFCom e precedida do literal \&quot;NFCom\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Identificador da tag a ser assinada.  Informar a chave de acesso da NFCom e precedida do literal \&quot;NFCom\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazIde ide { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazEmit emit { get; set; }

        /// <summary>
        /// Gets or Sets dest
        /// </summary>
        [DataMember(Name = "dest", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazDest dest { get; set; }

        /// <summary>
        /// Gets or Sets assinante
        /// </summary>
        [DataMember(Name = "assinante", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazAssinante assinante { get; set; }

        /// <summary>
        /// Gets or Sets gSub
        /// </summary>
        [DataMember(Name = "gSub", EmitDefaultValue = false)]
        public NfcomSefazGSub gSub { get; set; }

        /// <summary>
        /// Gets or Sets gCofat
        /// </summary>
        [DataMember(Name = "gCofat", EmitDefaultValue = false)]
        public NfcomSefazGCofat gCofat { get; set; }

        /// <summary>
        /// Gets or Sets det
        /// </summary>
        [DataMember(Name = "det", IsRequired = true, EmitDefaultValue = true)]
        public List<NfcomSefazDet> det { get; set; }

        /// <summary>
        /// Gets or Sets total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazTotal total { get; set; }

        /// <summary>
        /// Gets or Sets gFidelidade
        /// </summary>
        [DataMember(Name = "gFidelidade", EmitDefaultValue = false)]
        public NfcomSefazGFidelidade gFidelidade { get; set; }

        /// <summary>
        /// Gets or Sets gFat
        /// </summary>
        [DataMember(Name = "gFat", EmitDefaultValue = false)]
        public NfcomSefazGFat gFat { get; set; }

        /// <summary>
        /// Gets or Sets gFatCentral
        /// </summary>
        [DataMember(Name = "gFatCentral", EmitDefaultValue = false)]
        public NfcomSefazGFatCentral gFatCentral { get; set; }

        /// <summary>
        /// Gets or Sets autXML
        /// </summary>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<NfcomSefazAutXML> autXML { get; set; }

        /// <summary>
        /// Gets or Sets infAdic
        /// </summary>
        [DataMember(Name = "infAdic", EmitDefaultValue = false)]
        public NfcomSefazInfAdic infAdic { get; set; }

        /// <summary>
        /// Gets or Sets gRespTec
        /// </summary>
        [DataMember(Name = "gRespTec", EmitDefaultValue = false)]
        public NfcomSefazRespTec gRespTec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazInfNFCom {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  dest: ").Append(dest).Append("\n");
            sb.Append("  assinante: ").Append(assinante).Append("\n");
            sb.Append("  gSub: ").Append(gSub).Append("\n");
            sb.Append("  gCofat: ").Append(gCofat).Append("\n");
            sb.Append("  det: ").Append(det).Append("\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  gFidelidade: ").Append(gFidelidade).Append("\n");
            sb.Append("  gFat: ").Append(gFat).Append("\n");
            sb.Append("  gFatCentral: ").Append(gFatCentral).Append("\n");
            sb.Append("  autXML: ").Append(autXML).Append("\n");
            sb.Append("  infAdic: ").Append(infAdic).Append("\n");
            sb.Append("  gRespTec: ").Append(gRespTec).Append("\n");
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
            return this.Equals(input as NfcomSefazInfNFCom);
        }

        /// <summary>
        /// Returns true if NfcomSefazInfNFCom instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazInfNFCom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazInfNFCom input)
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
                    this.dest == input.dest ||
                    (this.dest != null &&
                    this.dest.Equals(input.dest))
                ) && 
                (
                    this.assinante == input.assinante ||
                    (this.assinante != null &&
                    this.assinante.Equals(input.assinante))
                ) && 
                (
                    this.gSub == input.gSub ||
                    (this.gSub != null &&
                    this.gSub.Equals(input.gSub))
                ) && 
                (
                    this.gCofat == input.gCofat ||
                    (this.gCofat != null &&
                    this.gCofat.Equals(input.gCofat))
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
                    this.gFidelidade == input.gFidelidade ||
                    (this.gFidelidade != null &&
                    this.gFidelidade.Equals(input.gFidelidade))
                ) && 
                (
                    this.gFat == input.gFat ||
                    (this.gFat != null &&
                    this.gFat.Equals(input.gFat))
                ) && 
                (
                    this.gFatCentral == input.gFatCentral ||
                    (this.gFatCentral != null &&
                    this.gFatCentral.Equals(input.gFatCentral))
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
                    this.gRespTec == input.gRespTec ||
                    (this.gRespTec != null &&
                    this.gRespTec.Equals(input.gRespTec))
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
                if (this.dest != null)
                {
                    hashCode = (hashCode * 59) + this.dest.GetHashCode();
                }
                if (this.assinante != null)
                {
                    hashCode = (hashCode * 59) + this.assinante.GetHashCode();
                }
                if (this.gSub != null)
                {
                    hashCode = (hashCode * 59) + this.gSub.GetHashCode();
                }
                if (this.gCofat != null)
                {
                    hashCode = (hashCode * 59) + this.gCofat.GetHashCode();
                }
                if (this.det != null)
                {
                    hashCode = (hashCode * 59) + this.det.GetHashCode();
                }
                if (this.total != null)
                {
                    hashCode = (hashCode * 59) + this.total.GetHashCode();
                }
                if (this.gFidelidade != null)
                {
                    hashCode = (hashCode * 59) + this.gFidelidade.GetHashCode();
                }
                if (this.gFat != null)
                {
                    hashCode = (hashCode * 59) + this.gFat.GetHashCode();
                }
                if (this.gFatCentral != null)
                {
                    hashCode = (hashCode * 59) + this.gFatCentral.GetHashCode();
                }
                if (this.autXML != null)
                {
                    hashCode = (hashCode * 59) + this.autXML.GetHashCode();
                }
                if (this.infAdic != null)
                {
                    hashCode = (hashCode * 59) + this.infAdic.GetHashCode();
                }
                if (this.gRespTec != null)
                {
                    hashCode = (hashCode * 59) + this.gRespTec.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
