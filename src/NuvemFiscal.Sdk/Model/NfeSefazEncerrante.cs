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
    /// Informações do grupo de \&quot;encerrante\&quot;.
    /// </summary>
    [DataContract(Name = "NfeSefazEncerrante")]
    public partial class NfeSefazEncerrante : IEquatable<NfeSefazEncerrante>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazEncerrante" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazEncerrante() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazEncerrante" /> class.
        /// </summary>
        /// <param name="nBico">Numero de identificação do Bico utilizado no abastecimento. (required).</param>
        /// <param name="nBomba">Numero de identificação da bomba ao qual o bico está interligado..</param>
        /// <param name="nTanque">Numero de identificação do tanque ao qual o bico está interligado. (required).</param>
        /// <param name="vEncIni">Valor do Encerrante no ínicio do abastecimento. (required).</param>
        /// <param name="vEncFin">Valor do Encerrante no final do abastecimento. (required).</param>
        public NfeSefazEncerrante(int? nBico = default(int?), int? nBomba = default(int?), int? nTanque = default(int?), decimal? vEncIni = default(decimal?), decimal? vEncFin = default(decimal?))
        {
            // to ensure "nBico" is required (not null)
            if (nBico == null)
            {
                throw new ArgumentNullException("nBico is a required property for NfeSefazEncerrante and cannot be null");
            }
            this.nBico = nBico;
            // to ensure "nTanque" is required (not null)
            if (nTanque == null)
            {
                throw new ArgumentNullException("nTanque is a required property for NfeSefazEncerrante and cannot be null");
            }
            this.nTanque = nTanque;
            // to ensure "vEncIni" is required (not null)
            if (vEncIni == null)
            {
                throw new ArgumentNullException("vEncIni is a required property for NfeSefazEncerrante and cannot be null");
            }
            this.vEncIni = vEncIni;
            // to ensure "vEncFin" is required (not null)
            if (vEncFin == null)
            {
                throw new ArgumentNullException("vEncFin is a required property for NfeSefazEncerrante and cannot be null");
            }
            this.vEncFin = vEncFin;
            this.nBomba = nBomba;
        }

        /// <summary>
        /// Numero de identificação do Bico utilizado no abastecimento.
        /// </summary>
        /// <value>Numero de identificação do Bico utilizado no abastecimento.</value>
        [DataMember(Name = "nBico", IsRequired = true, EmitDefaultValue = true)]
        public int? nBico { get; set; }

        /// <summary>
        /// Numero de identificação da bomba ao qual o bico está interligado.
        /// </summary>
        /// <value>Numero de identificação da bomba ao qual o bico está interligado.</value>
        [DataMember(Name = "nBomba", EmitDefaultValue = true)]
        public int? nBomba { get; set; }

        /// <summary>
        /// Numero de identificação do tanque ao qual o bico está interligado.
        /// </summary>
        /// <value>Numero de identificação do tanque ao qual o bico está interligado.</value>
        [DataMember(Name = "nTanque", IsRequired = true, EmitDefaultValue = true)]
        public int? nTanque { get; set; }

        /// <summary>
        /// Valor do Encerrante no ínicio do abastecimento.
        /// </summary>
        /// <value>Valor do Encerrante no ínicio do abastecimento.</value>
        [DataMember(Name = "vEncIni", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vEncIni { get; set; }

        /// <summary>
        /// Valor do Encerrante no final do abastecimento.
        /// </summary>
        /// <value>Valor do Encerrante no final do abastecimento.</value>
        [DataMember(Name = "vEncFin", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vEncFin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazEncerrante {\n");
            sb.Append("  nBico: ").Append(nBico).Append("\n");
            sb.Append("  nBomba: ").Append(nBomba).Append("\n");
            sb.Append("  nTanque: ").Append(nTanque).Append("\n");
            sb.Append("  vEncIni: ").Append(vEncIni).Append("\n");
            sb.Append("  vEncFin: ").Append(vEncFin).Append("\n");
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
            return this.Equals(input as NfeSefazEncerrante);
        }

        /// <summary>
        /// Returns true if NfeSefazEncerrante instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazEncerrante to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazEncerrante input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nBico == input.nBico ||
                    (this.nBico != null &&
                    this.nBico.Equals(input.nBico))
                ) && 
                (
                    this.nBomba == input.nBomba ||
                    (this.nBomba != null &&
                    this.nBomba.Equals(input.nBomba))
                ) && 
                (
                    this.nTanque == input.nTanque ||
                    (this.nTanque != null &&
                    this.nTanque.Equals(input.nTanque))
                ) && 
                (
                    this.vEncIni == input.vEncIni ||
                    (this.vEncIni != null &&
                    this.vEncIni.Equals(input.vEncIni))
                ) && 
                (
                    this.vEncFin == input.vEncFin ||
                    (this.vEncFin != null &&
                    this.vEncFin.Equals(input.vEncFin))
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
                if (this.nBico != null)
                {
                    hashCode = (hashCode * 59) + this.nBico.GetHashCode();
                }
                if (this.nBomba != null)
                {
                    hashCode = (hashCode * 59) + this.nBomba.GetHashCode();
                }
                if (this.nTanque != null)
                {
                    hashCode = (hashCode * 59) + this.nTanque.GetHashCode();
                }
                if (this.vEncIni != null)
                {
                    hashCode = (hashCode * 59) + this.vEncIni.GetHashCode();
                }
                if (this.vEncFin != null)
                {
                    hashCode = (hashCode * 59) + this.vEncFin.GetHashCode();
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
            // nBico (int?) maximum
            if (this.nBico > (int?)999)
            {
                yield return new ValidationResult("Invalid value for nBico, must be a value less than or equal to 999.", new [] { "nBico" });
            }

            // nBico (int?) minimum
            if (this.nBico < (int?)0)
            {
                yield return new ValidationResult("Invalid value for nBico, must be a value greater than or equal to 0.", new [] { "nBico" });
            }

            // nBomba (int?) maximum
            if (this.nBomba > (int?)999)
            {
                yield return new ValidationResult("Invalid value for nBomba, must be a value less than or equal to 999.", new [] { "nBomba" });
            }

            // nBomba (int?) minimum
            if (this.nBomba < (int?)0)
            {
                yield return new ValidationResult("Invalid value for nBomba, must be a value greater than or equal to 0.", new [] { "nBomba" });
            }

            // nTanque (int?) maximum
            if (this.nTanque > (int?)999)
            {
                yield return new ValidationResult("Invalid value for nTanque, must be a value less than or equal to 999.", new [] { "nTanque" });
            }

            // nTanque (int?) minimum
            if (this.nTanque < (int?)0)
            {
                yield return new ValidationResult("Invalid value for nTanque, must be a value greater than or equal to 0.", new [] { "nTanque" });
            }

            // vEncIni (decimal?) minimum
            if (this.vEncIni < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vEncIni, must be a value greater than or equal to 0.", new [] { "vEncIni" });
            }

            // vEncFin (decimal?) minimum
            if (this.vEncFin < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vEncFin, must be a value greater than or equal to 0.", new [] { "vEncFin" });
            }

            yield break;
        }
    }

}
