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
    /// NfeSefazCana
    /// </summary>
    [DataContract(Name = "NfeSefazCana")]
    public partial class NfeSefazCana : IEquatable<NfeSefazCana>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCana" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCana() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCana" /> class.
        /// </summary>
        /// <param name="safra">Identificação da safra. (required).</param>
        /// <param name="_ref">Mês e Ano de Referência, formato: MM/AAAA. (required).</param>
        /// <param name="forDia">Fornecimentos diários. (required).</param>
        /// <param name="qTotMes">Total do mês. (required).</param>
        /// <param name="qTotAnt">Total Anterior. (required).</param>
        /// <param name="qTotGer">Total Geral. (required).</param>
        /// <param name="deduc">Deduções - Taxas e Contribuições..</param>
        /// <param name="vFor">Valor  dos fornecimentos. (required).</param>
        /// <param name="vTotDed">Valor Total das Deduções. (required).</param>
        /// <param name="vLiqFor">Valor Líquido dos fornecimentos. (required).</param>
        public NfeSefazCana(string safra = default(string), string _ref = default(string), List<NfeSefazForDia> forDia = default(List<NfeSefazForDia>), decimal qTotMes = default(decimal), decimal qTotAnt = default(decimal), decimal qTotGer = default(decimal), List<NfeSefazDeduc> deduc = default(List<NfeSefazDeduc>), decimal vFor = default(decimal), decimal vTotDed = default(decimal), decimal vLiqFor = default(decimal))
        {
            // to ensure "safra" is required (not null)
            if (safra == null)
            {
                throw new ArgumentNullException("safra is a required property for NfeSefazCana and cannot be null");
            }
            this.safra = safra;
            // to ensure "_ref" is required (not null)
            if (_ref == null)
            {
                throw new ArgumentNullException("_ref is a required property for NfeSefazCana and cannot be null");
            }
            this._ref = _ref;
            // to ensure "forDia" is required (not null)
            if (forDia == null)
            {
                throw new ArgumentNullException("forDia is a required property for NfeSefazCana and cannot be null");
            }
            this.forDia = forDia;
            this.qTotMes = qTotMes;
            this.qTotAnt = qTotAnt;
            this.qTotGer = qTotGer;
            this.vFor = vFor;
            this.vTotDed = vTotDed;
            this.vLiqFor = vLiqFor;
            this.deduc = deduc;
        }

        /// <summary>
        /// Identificação da safra.
        /// </summary>
        /// <value>Identificação da safra.</value>
        [DataMember(Name = "safra", IsRequired = true, EmitDefaultValue = true)]
        public string safra { get; set; }

        /// <summary>
        /// Mês e Ano de Referência, formato: MM/AAAA.
        /// </summary>
        /// <value>Mês e Ano de Referência, formato: MM/AAAA.</value>
        [DataMember(Name = "ref", IsRequired = true, EmitDefaultValue = true)]
        public string _ref { get; set; }

        /// <summary>
        /// Fornecimentos diários.
        /// </summary>
        /// <value>Fornecimentos diários.</value>
        [DataMember(Name = "forDia", IsRequired = true, EmitDefaultValue = true)]
        public List<NfeSefazForDia> forDia { get; set; }

        /// <summary>
        /// Total do mês.
        /// </summary>
        /// <value>Total do mês.</value>
        [DataMember(Name = "qTotMes", IsRequired = true, EmitDefaultValue = true)]
        public decimal qTotMes { get; set; }

        /// <summary>
        /// Total Anterior.
        /// </summary>
        /// <value>Total Anterior.</value>
        [DataMember(Name = "qTotAnt", IsRequired = true, EmitDefaultValue = true)]
        public decimal qTotAnt { get; set; }

        /// <summary>
        /// Total Geral.
        /// </summary>
        /// <value>Total Geral.</value>
        [DataMember(Name = "qTotGer", IsRequired = true, EmitDefaultValue = true)]
        public decimal qTotGer { get; set; }

        /// <summary>
        /// Deduções - Taxas e Contribuições.
        /// </summary>
        /// <value>Deduções - Taxas e Contribuições.</value>
        [DataMember(Name = "deduc", EmitDefaultValue = false)]
        public List<NfeSefazDeduc> deduc { get; set; }

        /// <summary>
        /// Valor  dos fornecimentos.
        /// </summary>
        /// <value>Valor  dos fornecimentos.</value>
        [DataMember(Name = "vFor", IsRequired = true, EmitDefaultValue = true)]
        public decimal vFor { get; set; }

        /// <summary>
        /// Valor Total das Deduções.
        /// </summary>
        /// <value>Valor Total das Deduções.</value>
        [DataMember(Name = "vTotDed", IsRequired = true, EmitDefaultValue = true)]
        public decimal vTotDed { get; set; }

        /// <summary>
        /// Valor Líquido dos fornecimentos.
        /// </summary>
        /// <value>Valor Líquido dos fornecimentos.</value>
        [DataMember(Name = "vLiqFor", IsRequired = true, EmitDefaultValue = true)]
        public decimal vLiqFor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCana {\n");
            sb.Append("  safra: ").Append(safra).Append("\n");
            sb.Append("  _ref: ").Append(_ref).Append("\n");
            sb.Append("  forDia: ").Append(forDia).Append("\n");
            sb.Append("  qTotMes: ").Append(qTotMes).Append("\n");
            sb.Append("  qTotAnt: ").Append(qTotAnt).Append("\n");
            sb.Append("  qTotGer: ").Append(qTotGer).Append("\n");
            sb.Append("  deduc: ").Append(deduc).Append("\n");
            sb.Append("  vFor: ").Append(vFor).Append("\n");
            sb.Append("  vTotDed: ").Append(vTotDed).Append("\n");
            sb.Append("  vLiqFor: ").Append(vLiqFor).Append("\n");
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
            return this.Equals(input as NfeSefazCana);
        }

        /// <summary>
        /// Returns true if NfeSefazCana instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCana to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCana input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.safra == input.safra ||
                    (this.safra != null &&
                    this.safra.Equals(input.safra))
                ) && 
                (
                    this._ref == input._ref ||
                    (this._ref != null &&
                    this._ref.Equals(input._ref))
                ) && 
                (
                    this.forDia == input.forDia ||
                    this.forDia != null &&
                    input.forDia != null &&
                    this.forDia.SequenceEqual(input.forDia)
                ) && 
                (
                    this.qTotMes == input.qTotMes ||
                    this.qTotMes.Equals(input.qTotMes)
                ) && 
                (
                    this.qTotAnt == input.qTotAnt ||
                    this.qTotAnt.Equals(input.qTotAnt)
                ) && 
                (
                    this.qTotGer == input.qTotGer ||
                    this.qTotGer.Equals(input.qTotGer)
                ) && 
                (
                    this.deduc == input.deduc ||
                    this.deduc != null &&
                    input.deduc != null &&
                    this.deduc.SequenceEqual(input.deduc)
                ) && 
                (
                    this.vFor == input.vFor ||
                    this.vFor.Equals(input.vFor)
                ) && 
                (
                    this.vTotDed == input.vTotDed ||
                    this.vTotDed.Equals(input.vTotDed)
                ) && 
                (
                    this.vLiqFor == input.vLiqFor ||
                    this.vLiqFor.Equals(input.vLiqFor)
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
                if (this.safra != null)
                {
                    hashCode = (hashCode * 59) + this.safra.GetHashCode();
                }
                if (this._ref != null)
                {
                    hashCode = (hashCode * 59) + this._ref.GetHashCode();
                }
                if (this.forDia != null)
                {
                    hashCode = (hashCode * 59) + this.forDia.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.qTotMes.GetHashCode();
                hashCode = (hashCode * 59) + this.qTotAnt.GetHashCode();
                hashCode = (hashCode * 59) + this.qTotGer.GetHashCode();
                if (this.deduc != null)
                {
                    hashCode = (hashCode * 59) + this.deduc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vFor.GetHashCode();
                hashCode = (hashCode * 59) + this.vTotDed.GetHashCode();
                hashCode = (hashCode * 59) + this.vLiqFor.GetHashCode();
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
