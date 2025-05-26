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
    /// Informações do CT-e Outros Serviços.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfCteOS")]
    public partial class CteOsSefazInfCteOS : IEquatable<CteOsSefazInfCteOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCteOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfCteOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCteOS" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute.  Ex: \&quot;4.00\&quot;. (required).</param>
        /// <param name="id">Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e OS e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="compl">compl.</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="toma">toma.</param>
        /// <param name="vPrest">vPrest (required).</param>
        /// <param name="imp">imp (required).</param>
        /// <param name="infCTeNorm">infCTeNorm.</param>
        /// <param name="infCteComp">infCteComp.</param>
        /// <param name="autXML">autXML.</param>
        /// <param name="infRespTec">infRespTec.</param>
        public CteOsSefazInfCteOS(string versao = default(string), string id = default(string), CteOsSefazIdeOS ide = default(CteOsSefazIdeOS), CteOsSefazComplOS compl = default(CteOsSefazComplOS), CteOsSefazEmitOS emit = default(CteOsSefazEmitOS), CteOsSefazTomaOS toma = default(CteOsSefazTomaOS), CteOsSefazVPrestOS vPrest = default(CteOsSefazVPrestOS), CteOsSefazInfCteImpOS imp = default(CteOsSefazInfCteImpOS), CteOsSefazInfCTeNormOS infCTeNorm = default(CteOsSefazInfCTeNormOS), List<CteOsSefazInfCteCompOS> infCteComp = default(List<CteOsSefazInfCteCompOS>), List<CteOsSefazAutXMLOS> autXML = default(List<CteOsSefazAutXMLOS>), CteOsSefazRespTecOS infRespTec = default(CteOsSefazRespTecOS))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for CteOsSefazInfCteOS and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for CteOsSefazInfCteOS and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for CteOsSefazInfCteOS and cannot be null");
            }
            this.emit = emit;
            // to ensure "vPrest" is required (not null)
            if (vPrest == null)
            {
                throw new ArgumentNullException("vPrest is a required property for CteOsSefazInfCteOS and cannot be null");
            }
            this.vPrest = vPrest;
            // to ensure "imp" is required (not null)
            if (imp == null)
            {
                throw new ArgumentNullException("imp is a required property for CteOsSefazInfCteOS and cannot be null");
            }
            this.imp = imp;
            this.Id = id;
            this.compl = compl;
            this.toma = toma;
            this.infCTeNorm = infCTeNorm;
            this.infCteComp = infCteComp;
            this.autXML = autXML;
            this.infRespTec = infRespTec;
        }

        /// <summary>
        /// Versão do leiaute.  Ex: \&quot;4.00\&quot;.
        /// </summary>
        /// <value>Versão do leiaute.  Ex: \&quot;4.00\&quot;.</value>
        [DataMember(Name = "versao", IsRequired = true, EmitDefaultValue = true)]
        public string versao { get; set; }

        /// <summary>
        /// Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e OS e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e OS e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "Id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public CteOsSefazIdeOS ide { get; set; }

        /// <summary>
        /// Gets or Sets compl
        /// </summary>
        [DataMember(Name = "compl", EmitDefaultValue = false)]
        public CteOsSefazComplOS compl { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public CteOsSefazEmitOS emit { get; set; }

        /// <summary>
        /// Gets or Sets toma
        /// </summary>
        [DataMember(Name = "toma", EmitDefaultValue = false)]
        public CteOsSefazTomaOS toma { get; set; }

        /// <summary>
        /// Gets or Sets vPrest
        /// </summary>
        [DataMember(Name = "vPrest", IsRequired = true, EmitDefaultValue = true)]
        public CteOsSefazVPrestOS vPrest { get; set; }

        /// <summary>
        /// Gets or Sets imp
        /// </summary>
        [DataMember(Name = "imp", IsRequired = true, EmitDefaultValue = true)]
        public CteOsSefazInfCteImpOS imp { get; set; }

        /// <summary>
        /// Gets or Sets infCTeNorm
        /// </summary>
        [DataMember(Name = "infCTeNorm", EmitDefaultValue = false)]
        public CteOsSefazInfCTeNormOS infCTeNorm { get; set; }

        /// <summary>
        /// Gets or Sets infCteComp
        /// </summary>
        [DataMember(Name = "infCteComp", EmitDefaultValue = false)]
        public List<CteOsSefazInfCteCompOS> infCteComp { get; set; }

        /// <summary>
        /// Gets or Sets autXML
        /// </summary>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<CteOsSefazAutXMLOS> autXML { get; set; }

        /// <summary>
        /// Gets or Sets infRespTec
        /// </summary>
        [DataMember(Name = "infRespTec", EmitDefaultValue = false)]
        public CteOsSefazRespTecOS infRespTec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfCteOS {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  compl: ").Append(compl).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  toma: ").Append(toma).Append("\n");
            sb.Append("  vPrest: ").Append(vPrest).Append("\n");
            sb.Append("  imp: ").Append(imp).Append("\n");
            sb.Append("  infCTeNorm: ").Append(infCTeNorm).Append("\n");
            sb.Append("  infCteComp: ").Append(infCteComp).Append("\n");
            sb.Append("  autXML: ").Append(autXML).Append("\n");
            sb.Append("  infRespTec: ").Append(infRespTec).Append("\n");
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
            return this.Equals(input as CteOsSefazInfCteOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfCteOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfCteOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfCteOS input)
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
                    this.vPrest == input.vPrest ||
                    (this.vPrest != null &&
                    this.vPrest.Equals(input.vPrest))
                ) && 
                (
                    this.imp == input.imp ||
                    (this.imp != null &&
                    this.imp.Equals(input.imp))
                ) && 
                (
                    this.infCTeNorm == input.infCTeNorm ||
                    (this.infCTeNorm != null &&
                    this.infCTeNorm.Equals(input.infCTeNorm))
                ) && 
                (
                    this.infCteComp == input.infCteComp ||
                    this.infCteComp != null &&
                    input.infCteComp != null &&
                    this.infCteComp.SequenceEqual(input.infCteComp)
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
                if (this.vPrest != null)
                {
                    hashCode = (hashCode * 59) + this.vPrest.GetHashCode();
                }
                if (this.imp != null)
                {
                    hashCode = (hashCode * 59) + this.imp.GetHashCode();
                }
                if (this.infCTeNorm != null)
                {
                    hashCode = (hashCode * 59) + this.infCTeNorm.GetHashCode();
                }
                if (this.infCteComp != null)
                {
                    hashCode = (hashCode * 59) + this.infCteComp.GetHashCode();
                }
                if (this.autXML != null)
                {
                    hashCode = (hashCode * 59) + this.autXML.GetHashCode();
                }
                if (this.infRespTec != null)
                {
                    hashCode = (hashCode * 59) + this.infRespTec.GetHashCode();
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
