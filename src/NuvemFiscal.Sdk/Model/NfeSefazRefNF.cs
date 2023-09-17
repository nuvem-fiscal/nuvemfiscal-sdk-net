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
    /// Dados da NF modelo 1/1A referenciada ou NF modelo 2 referenciada.
    /// </summary>
    [DataContract(Name = "NfeSefazRefNF")]
    public partial class NfeSefazRefNF : IEquatable<NfeSefazRefNF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRefNF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazRefNF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRefNF" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE. (required).</param>
        /// <param name="aAMM">AAMM da emissão. (required).</param>
        /// <param name="cNPJ">CNPJ do emitente do documento fiscal referenciado. (required).</param>
        /// <param name="mod">Código do modelo do Documento Fiscal. Utilizar 01 para NF modelo 1/1A e 02 para NF modelo 02. (required).</param>
        /// <param name="serie">Série do Documento Fiscal, informar zero se inexistente. (required).</param>
        /// <param name="nNF">Número do Documento Fiscal. (required).</param>
        public NfeSefazRefNF(int? cUF = default(int?), string aAMM = default(string), string cNPJ = default(string), string mod = default(string), int? serie = default(int?), int? nNF = default(int?))
        {
            // to ensure "cUF" is required (not null)
            if (cUF == null)
            {
                throw new ArgumentNullException("cUF is a required property for NfeSefazRefNF and cannot be null");
            }
            this.cUF = cUF;
            // to ensure "aAMM" is required (not null)
            if (aAMM == null)
            {
                throw new ArgumentNullException("aAMM is a required property for NfeSefazRefNF and cannot be null");
            }
            this.AAMM = aAMM;
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfeSefazRefNF and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "mod" is required (not null)
            if (mod == null)
            {
                throw new ArgumentNullException("mod is a required property for NfeSefazRefNF and cannot be null");
            }
            this.mod = mod;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for NfeSefazRefNF and cannot be null");
            }
            this.serie = serie;
            // to ensure "nNF" is required (not null)
            if (nNF == null)
            {
                throw new ArgumentNullException("nNF is a required property for NfeSefazRefNF and cannot be null");
            }
            this.nNF = nNF;
        }

        /// <summary>
        /// Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.
        /// </summary>
        /// <value>Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// AAMM da emissão.
        /// </summary>
        /// <value>AAMM da emissão.</value>
        [DataMember(Name = "AAMM", IsRequired = true, EmitDefaultValue = true)]
        public string AAMM { get; set; }

        /// <summary>
        /// CNPJ do emitente do documento fiscal referenciado.
        /// </summary>
        /// <value>CNPJ do emitente do documento fiscal referenciado.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Código do modelo do Documento Fiscal. Utilizar 01 para NF modelo 1/1A e 02 para NF modelo 02.
        /// </summary>
        /// <value>Código do modelo do Documento Fiscal. Utilizar 01 para NF modelo 1/1A e 02 para NF modelo 02.</value>
        [DataMember(Name = "mod", IsRequired = true, EmitDefaultValue = true)]
        public string mod { get; set; }

        /// <summary>
        /// Série do Documento Fiscal, informar zero se inexistente.
        /// </summary>
        /// <value>Série do Documento Fiscal, informar zero se inexistente.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int? serie { get; set; }

        /// <summary>
        /// Número do Documento Fiscal.
        /// </summary>
        /// <value>Número do Documento Fiscal.</value>
        [DataMember(Name = "nNF", IsRequired = true, EmitDefaultValue = true)]
        public int? nNF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRefNF {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  AAMM: ").Append(AAMM).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
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
            return this.Equals(input as NfeSefazRefNF);
        }

        /// <summary>
        /// Returns true if NfeSefazRefNF instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRefNF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRefNF input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
