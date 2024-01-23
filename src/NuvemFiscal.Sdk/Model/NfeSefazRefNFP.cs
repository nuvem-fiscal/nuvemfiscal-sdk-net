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
    /// Grupo com as informações NF de produtor referenciada.
    /// </summary>
    [DataContract(Name = "NfeSefazRefNFP")]
    public partial class NfeSefazRefNFP : IEquatable<NfeSefazRefNFP>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRefNFP" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazRefNFP() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRefNFP" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF do emitente do Documento FiscalUtilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País). (required).</param>
        /// <param name="aAMM">AAMM da emissão da NF de produtor. (required).</param>
        /// <param name="cNPJ">CNPJ do emitente da NF de produtor..</param>
        /// <param name="cPF">CPF do emitente da NF de produtor..</param>
        /// <param name="iE">IE do emitente da NF de Produtor. (required).</param>
        /// <param name="mod">Código do modelo do Documento Fiscal - utilizar 04 para NF de produtor  ou 01 para NF Avulsa. (required).</param>
        /// <param name="serie">Série do Documento Fiscal, informar zero se inexistentesérie. (required).</param>
        /// <param name="nNF">Número do Documento Fiscal - 1 - 999999999. (required).</param>
        public NfeSefazRefNFP(int? cUF = default(int?), string aAMM = default(string), string cNPJ = default(string), string cPF = default(string), string iE = default(string), string mod = default(string), int? serie = default(int?), int? nNF = default(int?))
        {
            // to ensure "cUF" is required (not null)
            if (cUF == null)
            {
                throw new ArgumentNullException("cUF is a required property for NfeSefazRefNFP and cannot be null");
            }
            this.cUF = cUF;
            // to ensure "aAMM" is required (not null)
            if (aAMM == null)
            {
                throw new ArgumentNullException("aAMM is a required property for NfeSefazRefNFP and cannot be null");
            }
            this.AAMM = aAMM;
            // to ensure "iE" is required (not null)
            if (iE == null)
            {
                throw new ArgumentNullException("iE is a required property for NfeSefazRefNFP and cannot be null");
            }
            this.IE = iE;
            // to ensure "mod" is required (not null)
            if (mod == null)
            {
                throw new ArgumentNullException("mod is a required property for NfeSefazRefNFP and cannot be null");
            }
            this.mod = mod;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for NfeSefazRefNFP and cannot be null");
            }
            this.serie = serie;
            // to ensure "nNF" is required (not null)
            if (nNF == null)
            {
                throw new ArgumentNullException("nNF is a required property for NfeSefazRefNFP and cannot be null");
            }
            this.nNF = nNF;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
        }

        /// <summary>
        /// Código da UF do emitente do Documento FiscalUtilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País).
        /// </summary>
        /// <value>Código da UF do emitente do Documento FiscalUtilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País).</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// AAMM da emissão da NF de produtor.
        /// </summary>
        /// <value>AAMM da emissão da NF de produtor.</value>
        [DataMember(Name = "AAMM", IsRequired = true, EmitDefaultValue = true)]
        public string AAMM { get; set; }

        /// <summary>
        /// CNPJ do emitente da NF de produtor.
        /// </summary>
        /// <value>CNPJ do emitente da NF de produtor.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do emitente da NF de produtor.
        /// </summary>
        /// <value>CPF do emitente da NF de produtor.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// IE do emitente da NF de Produtor.
        /// </summary>
        /// <value>IE do emitente da NF de Produtor.</value>
        [DataMember(Name = "IE", IsRequired = true, EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Código do modelo do Documento Fiscal - utilizar 04 para NF de produtor  ou 01 para NF Avulsa.
        /// </summary>
        /// <value>Código do modelo do Documento Fiscal - utilizar 04 para NF de produtor  ou 01 para NF Avulsa.</value>
        [DataMember(Name = "mod", IsRequired = true, EmitDefaultValue = true)]
        public string mod { get; set; }

        /// <summary>
        /// Série do Documento Fiscal, informar zero se inexistentesérie.
        /// </summary>
        /// <value>Série do Documento Fiscal, informar zero se inexistentesérie.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int? serie { get; set; }

        /// <summary>
        /// Número do Documento Fiscal - 1 - 999999999.
        /// </summary>
        /// <value>Número do Documento Fiscal - 1 - 999999999.</value>
        [DataMember(Name = "nNF", IsRequired = true, EmitDefaultValue = true)]
        public int? nNF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRefNFP {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  AAMM: ").Append(AAMM).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nNF: ").Append(nNF).Append("\n");
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
            return this.Equals(input as NfeSefazRefNFP);
        }

        /// <summary>
        /// Returns true if NfeSefazRefNFP instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRefNFP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRefNFP input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cUF == input.cUF ||
                    (this.cUF != null &&
                    this.cUF.Equals(input.cUF))
                ) && 
                (
                    this.AAMM == input.AAMM ||
                    (this.AAMM != null &&
                    this.AAMM.Equals(input.AAMM))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
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
                if (this.cUF != null)
                {
                    hashCode = (hashCode * 59) + this.cUF.GetHashCode();
                }
                if (this.AAMM != null)
                {
                    hashCode = (hashCode * 59) + this.AAMM.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
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
            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // CPF (string) maxLength
            if (this.CPF != null && this.CPF.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CPF, length must be less than 11.", new [] { "CPF" });
            }

            // IE (string) maxLength
            if (this.IE != null && this.IE.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IE, length must be less than 14.", new [] { "IE" });
            }

            // serie (int?) maximum
            if (this.serie > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, must be a value less than or equal to 999.", new [] { "serie" });
            }

            // serie (int?) minimum
            if (this.serie < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, must be a value greater than or equal to 0.", new [] { "serie" });
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

            yield break;
        }
    }

}
