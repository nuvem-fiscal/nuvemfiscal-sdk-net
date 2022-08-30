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
    /// NfeSefazAdi
    /// </summary>
    [DataContract(Name = "NfeSefazAdi")]
    public partial class NfeSefazAdi : IEquatable<NfeSefazAdi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazAdi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazAdi() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazAdi" /> class.
        /// </summary>
        /// <param name="nAdicao">Número da Adição..</param>
        /// <param name="nSeqAdic">Número seqüencial do item dentro da Adição. (required).</param>
        /// <param name="cFabricante">Código do fabricante estrangeiro (usado nos sistemas internos de informação do emitente da NF-e). (required).</param>
        /// <param name="vDescDI">Valor do desconto do item da DI – adição..</param>
        /// <param name="nDraw">Número do ato concessório de Drawback..</param>
        public NfeSefazAdi(int nAdicao = default(int), int nSeqAdic = default(int), string cFabricante = default(string), decimal vDescDI = default(decimal), string nDraw = default(string))
        {
            this.nSeqAdic = nSeqAdic;
            // to ensure "cFabricante" is required (not null)
            if (cFabricante == null)
            {
                throw new ArgumentNullException("cFabricante is a required property for NfeSefazAdi and cannot be null");
            }
            this.cFabricante = cFabricante;
            this.nAdicao = nAdicao;
            this.vDescDI = vDescDI;
            this.nDraw = nDraw;
        }

        /// <summary>
        /// Número da Adição.
        /// </summary>
        /// <value>Número da Adição.</value>
        [DataMember(Name = "nAdicao", EmitDefaultValue = false)]
        public int nAdicao { get; set; }

        /// <summary>
        /// Número seqüencial do item dentro da Adição.
        /// </summary>
        /// <value>Número seqüencial do item dentro da Adição.</value>
        [DataMember(Name = "nSeqAdic", IsRequired = true, EmitDefaultValue = false)]
        public int nSeqAdic { get; set; }

        /// <summary>
        /// Código do fabricante estrangeiro (usado nos sistemas internos de informação do emitente da NF-e).
        /// </summary>
        /// <value>Código do fabricante estrangeiro (usado nos sistemas internos de informação do emitente da NF-e).</value>
        [DataMember(Name = "cFabricante", IsRequired = true, EmitDefaultValue = false)]
        public string cFabricante { get; set; }

        /// <summary>
        /// Valor do desconto do item da DI – adição.
        /// </summary>
        /// <value>Valor do desconto do item da DI – adição.</value>
        [DataMember(Name = "vDescDI", EmitDefaultValue = false)]
        public decimal vDescDI { get; set; }

        /// <summary>
        /// Número do ato concessório de Drawback.
        /// </summary>
        /// <value>Número do ato concessório de Drawback.</value>
        [DataMember(Name = "nDraw", EmitDefaultValue = false)]
        public string nDraw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazAdi {\n");
            sb.Append("  nAdicao: ").Append(nAdicao).Append("\n");
            sb.Append("  nSeqAdic: ").Append(nSeqAdic).Append("\n");
            sb.Append("  cFabricante: ").Append(cFabricante).Append("\n");
            sb.Append("  vDescDI: ").Append(vDescDI).Append("\n");
            sb.Append("  nDraw: ").Append(nDraw).Append("\n");
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
            return this.Equals(input as NfeSefazAdi);
        }

        /// <summary>
        /// Returns true if NfeSefazAdi instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazAdi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazAdi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nAdicao == input.nAdicao ||
                    this.nAdicao.Equals(input.nAdicao)
                ) && 
                (
                    this.nSeqAdic == input.nSeqAdic ||
                    this.nSeqAdic.Equals(input.nSeqAdic)
                ) && 
                (
                    this.cFabricante == input.cFabricante ||
                    (this.cFabricante != null &&
                    this.cFabricante.Equals(input.cFabricante))
                ) && 
                (
                    this.vDescDI == input.vDescDI ||
                    this.vDescDI.Equals(input.vDescDI)
                ) && 
                (
                    this.nDraw == input.nDraw ||
                    (this.nDraw != null &&
                    this.nDraw.Equals(input.nDraw))
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
                hashCode = (hashCode * 59) + this.nAdicao.GetHashCode();
                hashCode = (hashCode * 59) + this.nSeqAdic.GetHashCode();
                if (this.cFabricante != null)
                {
                    hashCode = (hashCode * 59) + this.cFabricante.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vDescDI.GetHashCode();
                if (this.nDraw != null)
                {
                    hashCode = (hashCode * 59) + this.nDraw.GetHashCode();
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
