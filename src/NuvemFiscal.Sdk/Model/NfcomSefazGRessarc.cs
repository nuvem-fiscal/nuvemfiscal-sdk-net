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
    /// Grupo de Informações detalhadas de item de cClass de Ressarcimento.
    /// </summary>
    [DataContract(Name = "NfcomSefazGRessarc")]
    public partial class NfcomSefazGRessarc : IEquatable<NfcomSefazGRessarc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGRessarc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGRessarc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGRessarc" /> class.
        /// </summary>
        /// <param name="tpRessarc">Tipo de Ressarcimento.  * 1 - Cobrança Indevida  * 2 - Interrupção  * 99 - Outros (required).</param>
        /// <param name="dRef">Data de referencia.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="nProcesso">Número do Processo..</param>
        /// <param name="nProtReclama">Número do protocolo de reclamação..</param>
        /// <param name="xObs">Observações sobre o processo de ressarcimento..</param>
        public NfcomSefazGRessarc(int? tpRessarc = default(int?), DateTime? dRef = default(DateTime?), string nProcesso = default(string), string nProtReclama = default(string), string xObs = default(string))
        {
            // to ensure "tpRessarc" is required (not null)
            if (tpRessarc == null)
            {
                throw new ArgumentNullException("tpRessarc is a required property for NfcomSefazGRessarc and cannot be null");
            }
            this.tpRessarc = tpRessarc;
            // to ensure "dRef" is required (not null)
            if (dRef == null)
            {
                throw new ArgumentNullException("dRef is a required property for NfcomSefazGRessarc and cannot be null");
            }
            this.dRef = dRef;
            this.nProcesso = nProcesso;
            this.nProtReclama = nProtReclama;
            this.xObs = xObs;
        }

        /// <summary>
        /// Tipo de Ressarcimento.  * 1 - Cobrança Indevida  * 2 - Interrupção  * 99 - Outros
        /// </summary>
        /// <value>Tipo de Ressarcimento.  * 1 - Cobrança Indevida  * 2 - Interrupção  * 99 - Outros</value>
        [DataMember(Name = "tpRessarc", IsRequired = true, EmitDefaultValue = true)]
        public int? tpRessarc { get; set; }

        /// <summary>
        /// Data de referencia.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de referencia.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dRef", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dRef { get; set; }

        /// <summary>
        /// Número do Processo.
        /// </summary>
        /// <value>Número do Processo.</value>
        [DataMember(Name = "nProcesso", EmitDefaultValue = true)]
        public string nProcesso { get; set; }

        /// <summary>
        /// Número do protocolo de reclamação.
        /// </summary>
        /// <value>Número do protocolo de reclamação.</value>
        [DataMember(Name = "nProtReclama", EmitDefaultValue = true)]
        public string nProtReclama { get; set; }

        /// <summary>
        /// Observações sobre o processo de ressarcimento.
        /// </summary>
        /// <value>Observações sobre o processo de ressarcimento.</value>
        [DataMember(Name = "xObs", EmitDefaultValue = true)]
        public string xObs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGRessarc {\n");
            sb.Append("  tpRessarc: ").Append(tpRessarc).Append("\n");
            sb.Append("  dRef: ").Append(dRef).Append("\n");
            sb.Append("  nProcesso: ").Append(nProcesso).Append("\n");
            sb.Append("  nProtReclama: ").Append(nProtReclama).Append("\n");
            sb.Append("  xObs: ").Append(xObs).Append("\n");
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
            return this.Equals(input as NfcomSefazGRessarc);
        }

        /// <summary>
        /// Returns true if NfcomSefazGRessarc instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGRessarc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGRessarc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpRessarc == input.tpRessarc ||
                    (this.tpRessarc != null &&
                    this.tpRessarc.Equals(input.tpRessarc))
                ) && 
                (
                    this.dRef == input.dRef ||
                    (this.dRef != null &&
                    this.dRef.Equals(input.dRef))
                ) && 
                (
                    this.nProcesso == input.nProcesso ||
                    (this.nProcesso != null &&
                    this.nProcesso.Equals(input.nProcesso))
                ) && 
                (
                    this.nProtReclama == input.nProtReclama ||
                    (this.nProtReclama != null &&
                    this.nProtReclama.Equals(input.nProtReclama))
                ) && 
                (
                    this.xObs == input.xObs ||
                    (this.xObs != null &&
                    this.xObs.Equals(input.xObs))
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
                if (this.tpRessarc != null)
                {
                    hashCode = (hashCode * 59) + this.tpRessarc.GetHashCode();
                }
                if (this.dRef != null)
                {
                    hashCode = (hashCode * 59) + this.dRef.GetHashCode();
                }
                if (this.nProcesso != null)
                {
                    hashCode = (hashCode * 59) + this.nProcesso.GetHashCode();
                }
                if (this.nProtReclama != null)
                {
                    hashCode = (hashCode * 59) + this.nProtReclama.GetHashCode();
                }
                if (this.xObs != null)
                {
                    hashCode = (hashCode * 59) + this.xObs.GetHashCode();
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
            // nProcesso (string) maxLength
            if (this.nProcesso != null && this.nProcesso.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nProcesso, length must be less than 60.", new [] { "nProcesso" });
            }

            // nProcesso (string) minLength
            if (this.nProcesso != null && this.nProcesso.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nProcesso, length must be greater than 1.", new [] { "nProcesso" });
            }

            // nProtReclama (string) maxLength
            if (this.nProtReclama != null && this.nProtReclama.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nProtReclama, length must be less than 60.", new [] { "nProtReclama" });
            }

            // nProtReclama (string) minLength
            if (this.nProtReclama != null && this.nProtReclama.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nProtReclama, length must be greater than 1.", new [] { "nProtReclama" });
            }

            // xObs (string) maxLength
            if (this.xObs != null && this.xObs.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xObs, length must be less than 100.", new [] { "xObs" });
            }

            // xObs (string) minLength
            if (this.xObs != null && this.xObs.Length < 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xObs, length must be greater than 15.", new [] { "xObs" });
            }

            yield break;
        }
    }

}
