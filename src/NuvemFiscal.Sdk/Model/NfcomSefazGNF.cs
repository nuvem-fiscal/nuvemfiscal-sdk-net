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
    /// Informação da NF modelo 21/22 referenciada.
    /// </summary>
    [DataContract(Name = "NfcomSefazGNF")]
    public partial class NfcomSefazGNF : IEquatable<NfcomSefazGNF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGNF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGNF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGNF" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do Emitente.  Informar o CNPJ do emitente do Documento Fiscal. (required).</param>
        /// <param name="mod">Modelo do documento.  21 ou 22. (required).</param>
        /// <param name="serie">Serie do documento fiscal. (required).</param>
        /// <param name="nNF">Número do documento fiscal. (required).</param>
        /// <param name="competEmis">Ano e mês da emissão da NF (AAAAMM). (required).</param>
        /// <param name="hash115">Hash do registro no arquivo do convênio 115.  Campo poderá ser exigido a critério da UF - campo 36 do arquivo MESTRE DE DOCUMENTO FISCAL (Anexo Único, item 5 do Conv. 115/03)..</param>
        public NfcomSefazGNF(string cNPJ = default(string), int? mod = default(int?), string serie = default(string), int? nNF = default(int?), string competEmis = default(string), string hash115 = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfcomSefazGNF and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "mod" is required (not null)
            if (mod == null)
            {
                throw new ArgumentNullException("mod is a required property for NfcomSefazGNF and cannot be null");
            }
            this.mod = mod;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for NfcomSefazGNF and cannot be null");
            }
            this.serie = serie;
            // to ensure "nNF" is required (not null)
            if (nNF == null)
            {
                throw new ArgumentNullException("nNF is a required property for NfcomSefazGNF and cannot be null");
            }
            this.nNF = nNF;
            // to ensure "competEmis" is required (not null)
            if (competEmis == null)
            {
                throw new ArgumentNullException("competEmis is a required property for NfcomSefazGNF and cannot be null");
            }
            this.CompetEmis = competEmis;
            this.hash115 = hash115;
        }

        /// <summary>
        /// CNPJ do Emitente.  Informar o CNPJ do emitente do Documento Fiscal.
        /// </summary>
        /// <value>CNPJ do Emitente.  Informar o CNPJ do emitente do Documento Fiscal.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Modelo do documento.  21 ou 22.
        /// </summary>
        /// <value>Modelo do documento.  21 ou 22.</value>
        [DataMember(Name = "mod", IsRequired = true, EmitDefaultValue = true)]
        public int? mod { get; set; }

        /// <summary>
        /// Serie do documento fiscal.
        /// </summary>
        /// <value>Serie do documento fiscal.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número do documento fiscal.
        /// </summary>
        /// <value>Número do documento fiscal.</value>
        [DataMember(Name = "nNF", IsRequired = true, EmitDefaultValue = true)]
        public int? nNF { get; set; }

        /// <summary>
        /// Ano e mês da emissão da NF (AAAAMM).
        /// </summary>
        /// <value>Ano e mês da emissão da NF (AAAAMM).</value>
        [DataMember(Name = "CompetEmis", IsRequired = true, EmitDefaultValue = true)]
        public string CompetEmis { get; set; }

        /// <summary>
        /// Hash do registro no arquivo do convênio 115.  Campo poderá ser exigido a critério da UF - campo 36 do arquivo MESTRE DE DOCUMENTO FISCAL (Anexo Único, item 5 do Conv. 115/03).
        /// </summary>
        /// <value>Hash do registro no arquivo do convênio 115.  Campo poderá ser exigido a critério da UF - campo 36 do arquivo MESTRE DE DOCUMENTO FISCAL (Anexo Único, item 5 do Conv. 115/03).</value>
        [DataMember(Name = "hash115", EmitDefaultValue = true)]
        public string hash115 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGNF {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nNF: ").Append(nNF).Append("\n");
            sb.Append("  CompetEmis: ").Append(CompetEmis).Append("\n");
            sb.Append("  hash115: ").Append(hash115).Append("\n");
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
            return this.Equals(input as NfcomSefazGNF);
        }

        /// <summary>
        /// Returns true if NfcomSefazGNF instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGNF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGNF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.mod == input.mod ||
                    (this.mod != null &&
                    this.mod.Equals(input.mod))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nNF == input.nNF ||
                    (this.nNF != null &&
                    this.nNF.Equals(input.nNF))
                ) && 
                (
                    this.CompetEmis == input.CompetEmis ||
                    (this.CompetEmis != null &&
                    this.CompetEmis.Equals(input.CompetEmis))
                ) && 
                (
                    this.hash115 == input.hash115 ||
                    (this.hash115 != null &&
                    this.hash115.Equals(input.hash115))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nNF != null)
                {
                    hashCode = (hashCode * 59) + this.nNF.GetHashCode();
                }
                if (this.CompetEmis != null)
                {
                    hashCode = (hashCode * 59) + this.CompetEmis.GetHashCode();
                }
                if (this.hash115 != null)
                {
                    hashCode = (hashCode * 59) + this.hash115.GetHashCode();
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
            // serie (string) maxLength
            if (this.serie != null && this.serie.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, length must be less than 3.", new [] { "serie" });
            }

            // serie (string) minLength
            if (this.serie != null && this.serie.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, length must be greater than 3.", new [] { "serie" });
            }

            // nNF (int?) maximum
            if (this.nNF > (int?)999999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nNF, must be a value less than or equal to 999999999.", new [] { "nNF" });
            }

            // nNF (int?) minimum
            if (this.nNF < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nNF, must be a value greater than or equal to 1.", new [] { "nNF" });
            }

            // CompetEmis (string) maxLength
            if (this.CompetEmis != null && this.CompetEmis.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompetEmis, length must be less than 6.", new [] { "CompetEmis" });
            }

            // CompetEmis (string) minLength
            if (this.CompetEmis != null && this.CompetEmis.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompetEmis, length must be greater than 6.", new [] { "CompetEmis" });
            }

            // hash115 (string) maxLength
            if (this.hash115 != null && this.hash115.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for hash115, length must be less than 32.", new [] { "hash115" });
            }

            // hash115 (string) minLength
            if (this.hash115 != null && this.hash115.Length < 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for hash115, length must be greater than 32.", new [] { "hash115" });
            }

            yield break;
        }
    }

}
