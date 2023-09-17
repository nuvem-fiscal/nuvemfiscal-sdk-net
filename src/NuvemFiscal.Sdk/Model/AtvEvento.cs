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
    /// Grupo de informações do DPS relativas à Evento.
    /// </summary>
    [DataContract(Name = "AtvEvento")]
    public partial class AtvEvento : IEquatable<AtvEvento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AtvEvento" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AtvEvento() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AtvEvento" /> class.
        /// </summary>
        /// <param name="desc">Descrição do evento Artístico, Cultural, Esportivo, etc. (required).</param>
        /// <param name="dtIni">Data de início da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD). (required).</param>
        /// <param name="dtFim">Data de fim da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD). (required).</param>
        /// <param name="id">Identificação da Atividade de Evento (código identificador de evento determinado pela Administração Tributária Municipal)..</param>
        /// <param name="end">end.</param>
        public AtvEvento(string desc = default(string), DateTime? dtIni = default(DateTime?), DateTime? dtFim = default(DateTime?), string id = default(string), EnderecoSimples end = default(EnderecoSimples))
        {
            // to ensure "desc" is required (not null)
            if (desc == null)
            {
                throw new ArgumentNullException("desc is a required property for AtvEvento and cannot be null");
            }
            this.desc = desc;
            // to ensure "dtIni" is required (not null)
            if (dtIni == null)
            {
                throw new ArgumentNullException("dtIni is a required property for AtvEvento and cannot be null");
            }
            this.dtIni = dtIni;
            // to ensure "dtFim" is required (not null)
            if (dtFim == null)
            {
                throw new ArgumentNullException("dtFim is a required property for AtvEvento and cannot be null");
            }
            this.dtFim = dtFim;
            this.id = id;
            this.end = end;
        }

        /// <summary>
        /// Descrição do evento Artístico, Cultural, Esportivo, etc.
        /// </summary>
        /// <value>Descrição do evento Artístico, Cultural, Esportivo, etc.</value>
        [DataMember(Name = "desc", IsRequired = true, EmitDefaultValue = true)]
        public string desc { get; set; }

        /// <summary>
        /// Data de início da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de início da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD).</value>
        [DataMember(Name = "dtIni", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dtIni { get; set; }

        /// <summary>
        /// Data de fim da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de fim da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD).</value>
        [DataMember(Name = "dtFim", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dtFim { get; set; }

        /// <summary>
        /// Identificação da Atividade de Evento (código identificador de evento determinado pela Administração Tributária Municipal).
        /// </summary>
        /// <value>Identificação da Atividade de Evento (código identificador de evento determinado pela Administração Tributária Municipal).</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets end
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public EnderecoSimples end { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AtvEvento {\n");
            sb.Append("  desc: ").Append(desc).Append("\n");
            sb.Append("  dtIni: ").Append(dtIni).Append("\n");
            sb.Append("  dtFim: ").Append(dtFim).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  end: ").Append(end).Append("\n");
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
            return this.Equals(input as AtvEvento);
        }

        /// <summary>
        /// Returns true if AtvEvento instances are equal
        /// </summary>
        /// <param name="input">Instance of AtvEvento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtvEvento input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.desc == input.desc ||
                    (this.desc != null &&
                    this.desc.Equals(input.desc))
                ) && 
                (
                    this.dtIni == input.dtIni ||
                    (this.dtIni != null &&
                    this.dtIni.Equals(input.dtIni))
                ) && 
                (
                    this.dtFim == input.dtFim ||
                    (this.dtFim != null &&
                    this.dtFim.Equals(input.dtFim))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.end == input.end ||
                    (this.end != null &&
                    this.end.Equals(input.end))
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
                if (this.desc != null)
                {
                    hashCode = (hashCode * 59) + this.desc.GetHashCode();
                }
                if (this.dtIni != null)
                {
                    hashCode = (hashCode * 59) + this.dtIni.GetHashCode();
                }
                if (this.dtFim != null)
                {
                    hashCode = (hashCode * 59) + this.dtFim.GetHashCode();
                }
                if (this.id != null)
                {
                    hashCode = (hashCode * 59) + this.id.GetHashCode();
                }
                if (this.end != null)
                {
                    hashCode = (hashCode * 59) + this.end.GetHashCode();
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
