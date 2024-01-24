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
        /// <param name="xNome">Nome do evento Artístico, Cultural, Esportivo, etc..</param>
        /// <param name="desc">&#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;xNome&#x60;*..</param>
        /// <param name="dtIni">Data de início da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD). (required).</param>
        /// <param name="dtFim">Data de fim da atividade de evento. Ano, Mês e Dia (AAAA-MM-DD). (required).</param>
        /// <param name="idAtvEvt">Identificação da Atividade de Evento (código identificador de evento determinado pela Administração Tributária Municipal)..</param>
        /// <param name="id">&#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;idAtvEvt&#x60;*..</param>
        /// <param name="end">end.</param>
        public AtvEvento(string xNome = default(string), string desc = default(string), DateTime? dtIni = default(DateTime?), DateTime? dtFim = default(DateTime?), string idAtvEvt = default(string), string id = default(string), EnderecoSimples end = default(EnderecoSimples))
        {
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
            this.xNome = xNome;
            this.desc = desc;
            this.idAtvEvt = idAtvEvt;
            this.id = id;
            this.end = end;
        }

        /// <summary>
        /// Nome do evento Artístico, Cultural, Esportivo, etc.
        /// </summary>
        /// <value>Nome do evento Artístico, Cultural, Esportivo, etc.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// &#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;xNome&#x60;*.
        /// </summary>
        /// <value>&#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;xNome&#x60;*.</value>
        [DataMember(Name = "desc", EmitDefaultValue = true)]
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
        [DataMember(Name = "idAtvEvt", EmitDefaultValue = true)]
        public string idAtvEvt { get; set; }

        /// <summary>
        /// &#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;idAtvEvt&#x60;*.
        /// </summary>
        /// <value>&#x60;Deprecated&#x60;    **Propriedade depreciada**.    *Utilize &#x60;idAtvEvt&#x60;*.</value>
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
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  desc: ").Append(desc).Append("\n");
            sb.Append("  dtIni: ").Append(dtIni).Append("\n");
            sb.Append("  dtFim: ").Append(dtFim).Append("\n");
            sb.Append("  idAtvEvt: ").Append(idAtvEvt).Append("\n");
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
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
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
                    this.idAtvEvt == input.idAtvEvt ||
                    (this.idAtvEvt != null &&
                    this.idAtvEvt.Equals(input.idAtvEvt))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
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
                if (this.idAtvEvt != null)
                {
                    hashCode = (hashCode * 59) + this.idAtvEvt.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be less than 255.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be greater than 1.", new [] { "xNome" });
            }

            // desc (string) maxLength
            if (this.desc != null && this.desc.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for desc, length must be less than 255.", new [] { "desc" });
            }

            // desc (string) minLength
            if (this.desc != null && this.desc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for desc, length must be greater than 1.", new [] { "desc" });
            }

            // idAtvEvt (string) maxLength
            if (this.idAtvEvt != null && this.idAtvEvt.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idAtvEvt, length must be less than 30.", new [] { "idAtvEvt" });
            }

            // idAtvEvt (string) minLength
            if (this.idAtvEvt != null && this.idAtvEvt.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idAtvEvt, length must be greater than 1.", new [] { "idAtvEvt" });
            }

            // id (string) maxLength
            if (this.id != null && this.id.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for id, length must be less than 30.", new [] { "id" });
            }

            // id (string) minLength
            if (this.id != null && this.id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for id, length must be greater than 1.", new [] { "id" });
            }

            yield break;
        }
    }

}
