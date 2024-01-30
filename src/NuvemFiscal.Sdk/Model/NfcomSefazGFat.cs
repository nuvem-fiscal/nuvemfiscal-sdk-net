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
    /// Grupo de informações de controle da Fatura.
    /// </summary>
    [DataContract(Name = "NfcomSefazGFat")]
    public partial class NfcomSefazGFat : IEquatable<NfcomSefazGFat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGFat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGFat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGFat" /> class.
        /// </summary>
        /// <param name="competFat">Ano e mês referência do faturamento (AAAAMM). (required).</param>
        /// <param name="dVencFat">Data de vencimento da fatura.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="dPerUsoIni">Período de uso inicial.  Formato AAAA-MM-DD..</param>
        /// <param name="dPerUsoFim">Período de uso final.  Formato AAAA-MM-DD..</param>
        /// <param name="codBarras">Linha digitável do código de barras. (required).</param>
        /// <param name="codDebAuto">Código de autorização débito em conta..</param>
        /// <param name="codBanco">Número do banco para débito em conta..</param>
        /// <param name="codAgencia">Número da agência bancária para débito em conta..</param>
        /// <param name="enderCorresp">enderCorresp.</param>
        /// <param name="gPIX">gPIX.</param>
        public NfcomSefazGFat(string competFat = default(string), DateTime? dVencFat = default(DateTime?), DateTime? dPerUsoIni = default(DateTime?), DateTime? dPerUsoFim = default(DateTime?), string codBarras = default(string), string codDebAuto = default(string), string codBanco = default(string), string codAgencia = default(string), NfcomSefazEndeEmi enderCorresp = default(NfcomSefazEndeEmi), NfcomSefazGPIX gPIX = default(NfcomSefazGPIX))
        {
            // to ensure "competFat" is required (not null)
            if (competFat == null)
            {
                throw new ArgumentNullException("competFat is a required property for NfcomSefazGFat and cannot be null");
            }
            this.CompetFat = competFat;
            // to ensure "dVencFat" is required (not null)
            if (dVencFat == null)
            {
                throw new ArgumentNullException("dVencFat is a required property for NfcomSefazGFat and cannot be null");
            }
            this.dVencFat = dVencFat;
            // to ensure "codBarras" is required (not null)
            if (codBarras == null)
            {
                throw new ArgumentNullException("codBarras is a required property for NfcomSefazGFat and cannot be null");
            }
            this.codBarras = codBarras;
            this.dPerUsoIni = dPerUsoIni;
            this.dPerUsoFim = dPerUsoFim;
            this.codDebAuto = codDebAuto;
            this.codBanco = codBanco;
            this.codAgencia = codAgencia;
            this.enderCorresp = enderCorresp;
            this.gPIX = gPIX;
        }

        /// <summary>
        /// Ano e mês referência do faturamento (AAAAMM).
        /// </summary>
        /// <value>Ano e mês referência do faturamento (AAAAMM).</value>
        [DataMember(Name = "CompetFat", IsRequired = true, EmitDefaultValue = true)]
        public string CompetFat { get; set; }

        /// <summary>
        /// Data de vencimento da fatura.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de vencimento da fatura.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dVencFat", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dVencFat { get; set; }

        /// <summary>
        /// Período de uso inicial.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Período de uso inicial.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dPerUsoIni", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dPerUsoIni { get; set; }

        /// <summary>
        /// Período de uso final.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Período de uso final.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dPerUsoFim", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dPerUsoFim { get; set; }

        /// <summary>
        /// Linha digitável do código de barras.
        /// </summary>
        /// <value>Linha digitável do código de barras.</value>
        [DataMember(Name = "codBarras", IsRequired = true, EmitDefaultValue = true)]
        public string codBarras { get; set; }

        /// <summary>
        /// Código de autorização débito em conta.
        /// </summary>
        /// <value>Código de autorização débito em conta.</value>
        [DataMember(Name = "codDebAuto", EmitDefaultValue = true)]
        public string codDebAuto { get; set; }

        /// <summary>
        /// Número do banco para débito em conta.
        /// </summary>
        /// <value>Número do banco para débito em conta.</value>
        [DataMember(Name = "codBanco", EmitDefaultValue = true)]
        public string codBanco { get; set; }

        /// <summary>
        /// Número da agência bancária para débito em conta.
        /// </summary>
        /// <value>Número da agência bancária para débito em conta.</value>
        [DataMember(Name = "codAgencia", EmitDefaultValue = true)]
        public string codAgencia { get; set; }

        /// <summary>
        /// Gets or Sets enderCorresp
        /// </summary>
        [DataMember(Name = "enderCorresp", EmitDefaultValue = false)]
        public NfcomSefazEndeEmi enderCorresp { get; set; }

        /// <summary>
        /// Gets or Sets gPIX
        /// </summary>
        [DataMember(Name = "gPIX", EmitDefaultValue = false)]
        public NfcomSefazGPIX gPIX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGFat {\n");
            sb.Append("  CompetFat: ").Append(CompetFat).Append("\n");
            sb.Append("  dVencFat: ").Append(dVencFat).Append("\n");
            sb.Append("  dPerUsoIni: ").Append(dPerUsoIni).Append("\n");
            sb.Append("  dPerUsoFim: ").Append(dPerUsoFim).Append("\n");
            sb.Append("  codBarras: ").Append(codBarras).Append("\n");
            sb.Append("  codDebAuto: ").Append(codDebAuto).Append("\n");
            sb.Append("  codBanco: ").Append(codBanco).Append("\n");
            sb.Append("  codAgencia: ").Append(codAgencia).Append("\n");
            sb.Append("  enderCorresp: ").Append(enderCorresp).Append("\n");
            sb.Append("  gPIX: ").Append(gPIX).Append("\n");
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
            return this.Equals(input as NfcomSefazGFat);
        }

        /// <summary>
        /// Returns true if NfcomSefazGFat instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGFat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGFat input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompetFat == input.CompetFat ||
                    (this.CompetFat != null &&
                    this.CompetFat.Equals(input.CompetFat))
                ) && 
                (
                    this.dVencFat == input.dVencFat ||
                    (this.dVencFat != null &&
                    this.dVencFat.Equals(input.dVencFat))
                ) && 
                (
                    this.dPerUsoIni == input.dPerUsoIni ||
                    (this.dPerUsoIni != null &&
                    this.dPerUsoIni.Equals(input.dPerUsoIni))
                ) && 
                (
                    this.dPerUsoFim == input.dPerUsoFim ||
                    (this.dPerUsoFim != null &&
                    this.dPerUsoFim.Equals(input.dPerUsoFim))
                ) && 
                (
                    this.codBarras == input.codBarras ||
                    (this.codBarras != null &&
                    this.codBarras.Equals(input.codBarras))
                ) && 
                (
                    this.codDebAuto == input.codDebAuto ||
                    (this.codDebAuto != null &&
                    this.codDebAuto.Equals(input.codDebAuto))
                ) && 
                (
                    this.codBanco == input.codBanco ||
                    (this.codBanco != null &&
                    this.codBanco.Equals(input.codBanco))
                ) && 
                (
                    this.codAgencia == input.codAgencia ||
                    (this.codAgencia != null &&
                    this.codAgencia.Equals(input.codAgencia))
                ) && 
                (
                    this.enderCorresp == input.enderCorresp ||
                    (this.enderCorresp != null &&
                    this.enderCorresp.Equals(input.enderCorresp))
                ) && 
                (
                    this.gPIX == input.gPIX ||
                    (this.gPIX != null &&
                    this.gPIX.Equals(input.gPIX))
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
                if (this.CompetFat != null)
                {
                    hashCode = (hashCode * 59) + this.CompetFat.GetHashCode();
                }
                if (this.dVencFat != null)
                {
                    hashCode = (hashCode * 59) + this.dVencFat.GetHashCode();
                }
                if (this.dPerUsoIni != null)
                {
                    hashCode = (hashCode * 59) + this.dPerUsoIni.GetHashCode();
                }
                if (this.dPerUsoFim != null)
                {
                    hashCode = (hashCode * 59) + this.dPerUsoFim.GetHashCode();
                }
                if (this.codBarras != null)
                {
                    hashCode = (hashCode * 59) + this.codBarras.GetHashCode();
                }
                if (this.codDebAuto != null)
                {
                    hashCode = (hashCode * 59) + this.codDebAuto.GetHashCode();
                }
                if (this.codBanco != null)
                {
                    hashCode = (hashCode * 59) + this.codBanco.GetHashCode();
                }
                if (this.codAgencia != null)
                {
                    hashCode = (hashCode * 59) + this.codAgencia.GetHashCode();
                }
                if (this.enderCorresp != null)
                {
                    hashCode = (hashCode * 59) + this.enderCorresp.GetHashCode();
                }
                if (this.gPIX != null)
                {
                    hashCode = (hashCode * 59) + this.gPIX.GetHashCode();
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
            // CompetFat (string) maxLength
            if (this.CompetFat != null && this.CompetFat.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompetFat, length must be less than 6.", new [] { "CompetFat" });
            }

            // CompetFat (string) minLength
            if (this.CompetFat != null && this.CompetFat.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompetFat, length must be greater than 6.", new [] { "CompetFat" });
            }

            // codBarras (string) maxLength
            if (this.codBarras != null && this.codBarras.Length > 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codBarras, length must be less than 48.", new [] { "codBarras" });
            }

            // codBarras (string) minLength
            if (this.codBarras != null && this.codBarras.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codBarras, length must be greater than 1.", new [] { "codBarras" });
            }

            // codDebAuto (string) maxLength
            if (this.codDebAuto != null && this.codDebAuto.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codDebAuto, length must be less than 20.", new [] { "codDebAuto" });
            }

            // codDebAuto (string) minLength
            if (this.codDebAuto != null && this.codDebAuto.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codDebAuto, length must be greater than 1.", new [] { "codDebAuto" });
            }

            // codBanco (string) maxLength
            if (this.codBanco != null && this.codBanco.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codBanco, length must be less than 5.", new [] { "codBanco" });
            }

            // codBanco (string) minLength
            if (this.codBanco != null && this.codBanco.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codBanco, length must be greater than 3.", new [] { "codBanco" });
            }

            // codAgencia (string) maxLength
            if (this.codAgencia != null && this.codAgencia.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codAgencia, length must be less than 10.", new [] { "codAgencia" });
            }

            // codAgencia (string) minLength
            if (this.codAgencia != null && this.codAgencia.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for codAgencia, length must be greater than 1.", new [] { "codAgencia" });
            }

            yield break;
        }
    }

}
