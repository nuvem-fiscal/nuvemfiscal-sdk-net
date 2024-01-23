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
    /// Grupo de informações do DPS relativas ao Serviço Prestado.
    /// </summary>
    [DataContract(Name = "Serv")]
    public partial class Serv : IEquatable<Serv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Serv" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Serv() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Serv" /> class.
        /// </summary>
        /// <param name="locPrest">locPrest.</param>
        /// <param name="cServ">cServ (required).</param>
        /// <param name="comExt">comExt.</param>
        /// <param name="lsadppu">lsadppu.</param>
        /// <param name="obra">obra.</param>
        /// <param name="atvEvento">atvEvento.</param>
        /// <param name="explRod">explRod.</param>
        /// <param name="infoCompl">infoCompl.</param>
        public Serv(LocPrest locPrest = default(LocPrest), CServ cServ = default(CServ), ComExterior comExt = default(ComExterior), LocacaoSublocacao lsadppu = default(LocacaoSublocacao), InfoObra obra = default(InfoObra), AtvEvento atvEvento = default(AtvEvento), ExploracaoRodoviaria explRod = default(ExploracaoRodoviaria), InfoCompl infoCompl = default(InfoCompl))
        {
            // to ensure "cServ" is required (not null)
            if (cServ == null)
            {
                throw new ArgumentNullException("cServ is a required property for Serv and cannot be null");
            }
            this.cServ = cServ;
            this.locPrest = locPrest;
            this.comExt = comExt;
            this.lsadppu = lsadppu;
            this.obra = obra;
            this.atvEvento = atvEvento;
            this.explRod = explRod;
            this.infoCompl = infoCompl;
        }

        /// <summary>
        /// Gets or Sets locPrest
        /// </summary>
        [DataMember(Name = "locPrest", EmitDefaultValue = false)]
        public LocPrest locPrest { get; set; }

        /// <summary>
        /// Gets or Sets cServ
        /// </summary>
        [DataMember(Name = "cServ", IsRequired = true, EmitDefaultValue = true)]
        public CServ cServ { get; set; }

        /// <summary>
        /// Gets or Sets comExt
        /// </summary>
        [DataMember(Name = "comExt", EmitDefaultValue = false)]
        public ComExterior comExt { get; set; }

        /// <summary>
        /// Gets or Sets lsadppu
        /// </summary>
        [DataMember(Name = "lsadppu", EmitDefaultValue = false)]
        public LocacaoSublocacao lsadppu { get; set; }

        /// <summary>
        /// Gets or Sets obra
        /// </summary>
        [DataMember(Name = "obra", EmitDefaultValue = false)]
        public InfoObra obra { get; set; }

        /// <summary>
        /// Gets or Sets atvEvento
        /// </summary>
        [DataMember(Name = "atvEvento", EmitDefaultValue = false)]
        public AtvEvento atvEvento { get; set; }

        /// <summary>
        /// Gets or Sets explRod
        /// </summary>
        [DataMember(Name = "explRod", EmitDefaultValue = false)]
        public ExploracaoRodoviaria explRod { get; set; }

        /// <summary>
        /// Gets or Sets infoCompl
        /// </summary>
        [DataMember(Name = "infoCompl", EmitDefaultValue = false)]
        public InfoCompl infoCompl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Serv {\n");
            sb.Append("  locPrest: ").Append(locPrest).Append("\n");
            sb.Append("  cServ: ").Append(cServ).Append("\n");
            sb.Append("  comExt: ").Append(comExt).Append("\n");
            sb.Append("  lsadppu: ").Append(lsadppu).Append("\n");
            sb.Append("  obra: ").Append(obra).Append("\n");
            sb.Append("  atvEvento: ").Append(atvEvento).Append("\n");
            sb.Append("  explRod: ").Append(explRod).Append("\n");
            sb.Append("  infoCompl: ").Append(infoCompl).Append("\n");
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
            return this.Equals(input as Serv);
        }

        /// <summary>
        /// Returns true if Serv instances are equal
        /// </summary>
        /// <param name="input">Instance of Serv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Serv input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.locPrest == input.locPrest ||
                    (this.locPrest != null &&
                    this.locPrest.Equals(input.locPrest))
                ) && 
                (
                    this.cServ == input.cServ ||
                    (this.cServ != null &&
                    this.cServ.Equals(input.cServ))
                ) && 
                (
                    this.comExt == input.comExt ||
                    (this.comExt != null &&
                    this.comExt.Equals(input.comExt))
                ) && 
                (
                    this.lsadppu == input.lsadppu ||
                    (this.lsadppu != null &&
                    this.lsadppu.Equals(input.lsadppu))
                ) && 
                (
                    this.obra == input.obra ||
                    (this.obra != null &&
                    this.obra.Equals(input.obra))
                ) && 
                (
                    this.atvEvento == input.atvEvento ||
                    (this.atvEvento != null &&
                    this.atvEvento.Equals(input.atvEvento))
                ) && 
                (
                    this.explRod == input.explRod ||
                    (this.explRod != null &&
                    this.explRod.Equals(input.explRod))
                ) && 
                (
                    this.infoCompl == input.infoCompl ||
                    (this.infoCompl != null &&
                    this.infoCompl.Equals(input.infoCompl))
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
                if (this.locPrest != null)
                {
                    hashCode = (hashCode * 59) + this.locPrest.GetHashCode();
                }
                if (this.cServ != null)
                {
                    hashCode = (hashCode * 59) + this.cServ.GetHashCode();
                }
                if (this.comExt != null)
                {
                    hashCode = (hashCode * 59) + this.comExt.GetHashCode();
                }
                if (this.lsadppu != null)
                {
                    hashCode = (hashCode * 59) + this.lsadppu.GetHashCode();
                }
                if (this.obra != null)
                {
                    hashCode = (hashCode * 59) + this.obra.GetHashCode();
                }
                if (this.atvEvento != null)
                {
                    hashCode = (hashCode * 59) + this.atvEvento.GetHashCode();
                }
                if (this.explRod != null)
                {
                    hashCode = (hashCode * 59) + this.explRod.GetHashCode();
                }
                if (this.infoCompl != null)
                {
                    hashCode = (hashCode * 59) + this.infoCompl.GetHashCode();
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
