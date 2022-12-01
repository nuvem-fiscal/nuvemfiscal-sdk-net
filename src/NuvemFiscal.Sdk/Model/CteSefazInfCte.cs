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
    /// CteSefazInfCte
    /// </summary>
    [DataContract(Name = "CteSefazInfCte")]
    public partial class CteSefazInfCte : IEquatable<CteSefazInfCte>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCte" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfCte() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCte" /> class.
        /// </summary>
        /// <param name="versao">Versão do leiaute.  Ex: \&quot;3.00\&quot;. (required).</param>
        /// <param name="id">Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e e precedida do literal \&quot;CTe\&quot;..</param>
        /// <param name="ide">ide (required).</param>
        /// <param name="compl">compl.</param>
        /// <param name="emit">emit (required).</param>
        /// <param name="rem">rem.</param>
        /// <param name="exped">exped.</param>
        /// <param name="receb">receb.</param>
        /// <param name="dest">dest.</param>
        /// <param name="vPrest">vPrest (required).</param>
        /// <param name="imp">imp (required).</param>
        /// <param name="infCTeNorm">infCTeNorm.</param>
        /// <param name="infCteComp">infCteComp.</param>
        /// <param name="infCteAnu">infCteAnu.</param>
        /// <param name="autXML">Autorizados para download do XML do DF-e.  Informar CNPJ ou CPF. Preencher os zeros não significativos..</param>
        /// <param name="infRespTec">infRespTec.</param>
        /// <param name="infSolicNFF">infSolicNFF.</param>
        public CteSefazInfCte(string versao = default(string), string id = default(string), CteSefazIde ide = default(CteSefazIde), CteSefazCompl compl = default(CteSefazCompl), CteSefazEmit emit = default(CteSefazEmit), CteSefazRem rem = default(CteSefazRem), CteSefazExped exped = default(CteSefazExped), CteSefazReceb receb = default(CteSefazReceb), CteSefazDest dest = default(CteSefazDest), CteSefazVPrest vPrest = default(CteSefazVPrest), CteSefazInfCteImp imp = default(CteSefazInfCteImp), CteSefazInfCTeNorm infCTeNorm = default(CteSefazInfCTeNorm), CteSefazInfCteComp infCteComp = default(CteSefazInfCteComp), CteSefazInfCteAnu infCteAnu = default(CteSefazInfCteAnu), List<CteSefazAutXML> autXML = default(List<CteSefazAutXML>), CteSefazRespTec infRespTec = default(CteSefazRespTec), CteSefazInfSolicNFF infSolicNFF = default(CteSefazInfSolicNFF))
        {
            // to ensure "versao" is required (not null)
            if (versao == null)
            {
                throw new ArgumentNullException("versao is a required property for CteSefazInfCte and cannot be null");
            }
            this.versao = versao;
            // to ensure "ide" is required (not null)
            if (ide == null)
            {
                throw new ArgumentNullException("ide is a required property for CteSefazInfCte and cannot be null");
            }
            this.ide = ide;
            // to ensure "emit" is required (not null)
            if (emit == null)
            {
                throw new ArgumentNullException("emit is a required property for CteSefazInfCte and cannot be null");
            }
            this.emit = emit;
            // to ensure "vPrest" is required (not null)
            if (vPrest == null)
            {
                throw new ArgumentNullException("vPrest is a required property for CteSefazInfCte and cannot be null");
            }
            this.vPrest = vPrest;
            // to ensure "imp" is required (not null)
            if (imp == null)
            {
                throw new ArgumentNullException("imp is a required property for CteSefazInfCte and cannot be null");
            }
            this.imp = imp;
            this.Id = id;
            this.compl = compl;
            this.rem = rem;
            this.exped = exped;
            this.receb = receb;
            this.dest = dest;
            this.infCTeNorm = infCTeNorm;
            this.infCteComp = infCteComp;
            this.infCteAnu = infCteAnu;
            this.autXML = autXML;
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
        /// Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e e precedida do literal \&quot;CTe\&quot;.
        /// </summary>
        /// <value>Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e e precedida do literal \&quot;CTe\&quot;.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ide
        /// </summary>
        [DataMember(Name = "ide", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazIde ide { get; set; }

        /// <summary>
        /// Gets or Sets compl
        /// </summary>
        [DataMember(Name = "compl", EmitDefaultValue = false)]
        public CteSefazCompl compl { get; set; }

        /// <summary>
        /// Gets or Sets emit
        /// </summary>
        [DataMember(Name = "emit", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazEmit emit { get; set; }

        /// <summary>
        /// Gets or Sets rem
        /// </summary>
        [DataMember(Name = "rem", EmitDefaultValue = false)]
        public CteSefazRem rem { get; set; }

        /// <summary>
        /// Gets or Sets exped
        /// </summary>
        [DataMember(Name = "exped", EmitDefaultValue = false)]
        public CteSefazExped exped { get; set; }

        /// <summary>
        /// Gets or Sets receb
        /// </summary>
        [DataMember(Name = "receb", EmitDefaultValue = false)]
        public CteSefazReceb receb { get; set; }

        /// <summary>
        /// Gets or Sets dest
        /// </summary>
        [DataMember(Name = "dest", EmitDefaultValue = false)]
        public CteSefazDest dest { get; set; }

        /// <summary>
        /// Gets or Sets vPrest
        /// </summary>
        [DataMember(Name = "vPrest", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazVPrest vPrest { get; set; }

        /// <summary>
        /// Gets or Sets imp
        /// </summary>
        [DataMember(Name = "imp", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazInfCteImp imp { get; set; }

        /// <summary>
        /// Gets or Sets infCTeNorm
        /// </summary>
        [DataMember(Name = "infCTeNorm", EmitDefaultValue = false)]
        public CteSefazInfCTeNorm infCTeNorm { get; set; }

        /// <summary>
        /// Gets or Sets infCteComp
        /// </summary>
        [DataMember(Name = "infCteComp", EmitDefaultValue = false)]
        public CteSefazInfCteComp infCteComp { get; set; }

        /// <summary>
        /// Gets or Sets infCteAnu
        /// </summary>
        [DataMember(Name = "infCteAnu", EmitDefaultValue = false)]
        public CteSefazInfCteAnu infCteAnu { get; set; }

        /// <summary>
        /// Autorizados para download do XML do DF-e.  Informar CNPJ ou CPF. Preencher os zeros não significativos.
        /// </summary>
        /// <value>Autorizados para download do XML do DF-e.  Informar CNPJ ou CPF. Preencher os zeros não significativos.</value>
        [DataMember(Name = "autXML", EmitDefaultValue = false)]
        public List<CteSefazAutXML> autXML { get; set; }

        /// <summary>
        /// Gets or Sets infRespTec
        /// </summary>
        [DataMember(Name = "infRespTec", EmitDefaultValue = false)]
        public CteSefazRespTec infRespTec { get; set; }

        /// <summary>
        /// Gets or Sets infSolicNFF
        /// </summary>
        [DataMember(Name = "infSolicNFF", EmitDefaultValue = false)]
        public CteSefazInfSolicNFF infSolicNFF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfCte {\n");
            sb.Append("  versao: ").Append(versao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ide: ").Append(ide).Append("\n");
            sb.Append("  compl: ").Append(compl).Append("\n");
            sb.Append("  emit: ").Append(emit).Append("\n");
            sb.Append("  rem: ").Append(rem).Append("\n");
            sb.Append("  exped: ").Append(exped).Append("\n");
            sb.Append("  receb: ").Append(receb).Append("\n");
            sb.Append("  dest: ").Append(dest).Append("\n");
            sb.Append("  vPrest: ").Append(vPrest).Append("\n");
            sb.Append("  imp: ").Append(imp).Append("\n");
            sb.Append("  infCTeNorm: ").Append(infCTeNorm).Append("\n");
            sb.Append("  infCteComp: ").Append(infCteComp).Append("\n");
            sb.Append("  infCteAnu: ").Append(infCteAnu).Append("\n");
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
            return this.Equals(input as CteSefazInfCte);
        }

        /// <summary>
        /// Returns true if CteSefazInfCte instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfCte to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfCte input)
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
                    this.rem == input.rem ||
                    (this.rem != null &&
                    this.rem.Equals(input.rem))
                ) && 
                (
                    this.exped == input.exped ||
                    (this.exped != null &&
                    this.exped.Equals(input.exped))
                ) && 
                (
                    this.receb == input.receb ||
                    (this.receb != null &&
                    this.receb.Equals(input.receb))
                ) && 
                (
                    this.dest == input.dest ||
                    (this.dest != null &&
                    this.dest.Equals(input.dest))
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
                    (this.infCteComp != null &&
                    this.infCteComp.Equals(input.infCteComp))
                ) && 
                (
                    this.infCteAnu == input.infCteAnu ||
                    (this.infCteAnu != null &&
                    this.infCteAnu.Equals(input.infCteAnu))
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
                if (this.rem != null)
                {
                    hashCode = (hashCode * 59) + this.rem.GetHashCode();
                }
                if (this.exped != null)
                {
                    hashCode = (hashCode * 59) + this.exped.GetHashCode();
                }
                if (this.receb != null)
                {
                    hashCode = (hashCode * 59) + this.receb.GetHashCode();
                }
                if (this.dest != null)
                {
                    hashCode = (hashCode * 59) + this.dest.GetHashCode();
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
                if (this.infCteAnu != null)
                {
                    hashCode = (hashCode * 59) + this.infCteAnu.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
