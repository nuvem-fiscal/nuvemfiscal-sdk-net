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
    /// Adições (NT 2011/004).
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
        /// <param name="vDescDI">Valor do desconto do item da DI - adição..</param>
        /// <param name="nDraw">Número do ato concessório de Drawback..</param>
        public NfeSefazAdi(int? nAdicao = default(int?), int? nSeqAdic = default(int?), string cFabricante = default(string), decimal? vDescDI = default(decimal?), string nDraw = default(string))
        {
            // to ensure "nSeqAdic" is required (not null)
            if (nSeqAdic == null)
            {
                throw new ArgumentNullException("nSeqAdic is a required property for NfeSefazAdi and cannot be null");
            }
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
        [DataMember(Name = "nAdicao", EmitDefaultValue = true)]
        public int? nAdicao { get; set; }

        /// <summary>
        /// Número seqüencial do item dentro da Adição.
        /// </summary>
        /// <value>Número seqüencial do item dentro da Adição.</value>
        [DataMember(Name = "nSeqAdic", IsRequired = true, EmitDefaultValue = true)]
        public int? nSeqAdic { get; set; }

        /// <summary>
        /// Código do fabricante estrangeiro (usado nos sistemas internos de informação do emitente da NF-e).
        /// </summary>
        /// <value>Código do fabricante estrangeiro (usado nos sistemas internos de informação do emitente da NF-e).</value>
        [DataMember(Name = "cFabricante", IsRequired = true, EmitDefaultValue = true)]
        public string cFabricante { get; set; }

        /// <summary>
        /// Valor do desconto do item da DI - adição.
        /// </summary>
        /// <value>Valor do desconto do item da DI - adição.</value>
        [DataMember(Name = "vDescDI", EmitDefaultValue = true)]
        public decimal? vDescDI { get; set; }

        /// <summary>
        /// Número do ato concessório de Drawback.
        /// </summary>
        /// <value>Número do ato concessório de Drawback.</value>
        [DataMember(Name = "nDraw", EmitDefaultValue = true)]
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
                    (this.nAdicao != null &&
                    this.nAdicao.Equals(input.nAdicao))
                ) && 
                (
                    this.nSeqAdic == input.nSeqAdic ||
                    (this.nSeqAdic != null &&
                    this.nSeqAdic.Equals(input.nSeqAdic))
                ) && 
                (
                    this.cFabricante == input.cFabricante ||
                    (this.cFabricante != null &&
                    this.cFabricante.Equals(input.cFabricante))
                ) && 
                (
                    this.vDescDI == input.vDescDI ||
                    (this.vDescDI != null &&
                    this.vDescDI.Equals(input.vDescDI))
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
                if (this.nAdicao != null)
                {
                    hashCode = (hashCode * 59) + this.nAdicao.GetHashCode();
                }
                if (this.nSeqAdic != null)
                {
                    hashCode = (hashCode * 59) + this.nSeqAdic.GetHashCode();
                }
                if (this.cFabricante != null)
                {
                    hashCode = (hashCode * 59) + this.cFabricante.GetHashCode();
                }
                if (this.vDescDI != null)
                {
                    hashCode = (hashCode * 59) + this.vDescDI.GetHashCode();
                }
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // nAdicao (int?) maximum
            if (this.nAdicao > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nAdicao, must be a value less than or equal to 999.", new [] { "nAdicao" });
            }

            // nAdicao (int?) minimum
            if (this.nAdicao < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nAdicao, must be a value greater than or equal to 1.", new [] { "nAdicao" });
            }

            // nSeqAdic (int?) maximum
            if (this.nSeqAdic > (int?)99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nSeqAdic, must be a value less than or equal to 99999.", new [] { "nSeqAdic" });
            }

            // nSeqAdic (int?) minimum
            if (this.nSeqAdic < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nSeqAdic, must be a value greater than or equal to 1.", new [] { "nSeqAdic" });
            }

            // cFabricante (string) maxLength
            if (this.cFabricante != null && this.cFabricante.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cFabricante, length must be less than 60.", new [] { "cFabricante" });
            }

            // cFabricante (string) minLength
            if (this.cFabricante != null && this.cFabricante.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cFabricante, length must be greater than 1.", new [] { "cFabricante" });
            }

            // nDraw (string) maxLength
            if (this.nDraw != null && this.nDraw.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDraw, length must be less than 20.", new [] { "nDraw" });
            }

            // nDraw (string) minLength
            if (this.nDraw != null && this.nDraw.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDraw, length must be greater than 1.", new [] { "nDraw" });
            }

            yield break;
        }
    }

}
