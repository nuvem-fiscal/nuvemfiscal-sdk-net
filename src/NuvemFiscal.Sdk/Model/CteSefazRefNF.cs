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
    /// CteSefazRefNF
    /// </summary>
    [DataContract(Name = "CteSefazRefNF")]
    public partial class CteSefazRefNF : IEquatable<CteSefazRefNF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazRefNF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazRefNF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazRefNF" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do Emitente.  Informar o CNPJ do emitente do Documento Fiscal..</param>
        /// <param name="cPF">Número do CPF.  Informar o CPF do emitente do documento fiscal..</param>
        /// <param name="mod">Modelo do Documento Fiscal. (required).</param>
        /// <param name="serie">Serie do documento fiscal. (required).</param>
        /// <param name="subserie">Subserie do documento fiscal..</param>
        /// <param name="nro">Número do documento fiscal. (required).</param>
        /// <param name="valor">Valor do documento fiscal. (required).</param>
        /// <param name="dEmi">Data de emissão do documento fiscal. (required).</param>
        public CteSefazRefNF(string cNPJ = default(string), string cPF = default(string), string mod = default(string), int serie = default(int), int subserie = default(int), int nro = default(int), decimal valor = default(decimal), DateTime dEmi = default(DateTime))
        {
            // to ensure "mod" is required (not null)
            if (mod == null)
            {
                throw new ArgumentNullException("mod is a required property for CteSefazRefNF and cannot be null");
            }
            this.mod = mod;
            this.serie = serie;
            this.nro = nro;
            this.valor = valor;
            this.dEmi = dEmi;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.subserie = subserie;
        }

        /// <summary>
        /// CNPJ do Emitente.  Informar o CNPJ do emitente do Documento Fiscal.
        /// </summary>
        /// <value>CNPJ do Emitente.  Informar o CNPJ do emitente do Documento Fiscal.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.  Informar o CPF do emitente do documento fiscal.
        /// </summary>
        /// <value>Número do CPF.  Informar o CPF do emitente do documento fiscal.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Modelo do Documento Fiscal.
        /// </summary>
        /// <value>Modelo do Documento Fiscal.</value>
        [DataMember(Name = "mod", IsRequired = true, EmitDefaultValue = false)]
        public string mod { get; set; }

        /// <summary>
        /// Serie do documento fiscal.
        /// </summary>
        /// <value>Serie do documento fiscal.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = false)]
        public int serie { get; set; }

        /// <summary>
        /// Subserie do documento fiscal.
        /// </summary>
        /// <value>Subserie do documento fiscal.</value>
        [DataMember(Name = "subserie", EmitDefaultValue = false)]
        public int subserie { get; set; }

        /// <summary>
        /// Número do documento fiscal.
        /// </summary>
        /// <value>Número do documento fiscal.</value>
        [DataMember(Name = "nro", IsRequired = true, EmitDefaultValue = false)]
        public int nro { get; set; }

        /// <summary>
        /// Valor do documento fiscal.
        /// </summary>
        /// <value>Valor do documento fiscal.</value>
        [DataMember(Name = "valor", IsRequired = true, EmitDefaultValue = false)]
        public decimal valor { get; set; }

        /// <summary>
        /// Data de emissão do documento fiscal.
        /// </summary>
        /// <value>Data de emissão do documento fiscal.</value>
        [DataMember(Name = "dEmi", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazRefNF {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  subserie: ").Append(subserie).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  valor: ").Append(valor).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
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
            return this.Equals(input as CteSefazRefNF);
        }

        /// <summary>
        /// Returns true if CteSefazRefNF instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazRefNF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazRefNF input)
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
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.mod == input.mod ||
                    (this.mod != null &&
                    this.mod.Equals(input.mod))
                ) && 
                (
                    this.serie == input.serie ||
                    this.serie.Equals(input.serie)
                ) && 
                (
                    this.subserie == input.subserie ||
                    this.subserie.Equals(input.subserie)
                ) && 
                (
                    this.nro == input.nro ||
                    this.nro.Equals(input.nro)
                ) && 
                (
                    this.valor == input.valor ||
                    this.valor.Equals(input.valor)
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
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
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.serie.GetHashCode();
                hashCode = (hashCode * 59) + this.subserie.GetHashCode();
                hashCode = (hashCode * 59) + this.nro.GetHashCode();
                hashCode = (hashCode * 59) + this.valor.GetHashCode();
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
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
