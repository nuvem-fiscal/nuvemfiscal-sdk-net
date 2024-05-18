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
    /// Dados dos totais da NFCom.
    /// </summary>
    [DataContract(Name = "NfcomSefazTotal")]
    public partial class NfcomSefazTotal : IEquatable<NfcomSefazTotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazTotal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazTotal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazTotal" /> class.
        /// </summary>
        /// <param name="vProd">Valor Total dos produtos e serviços. (required).</param>
        /// <param name="iCMSTot">iCMSTot (required).</param>
        /// <param name="vCOFINS">Valor do COFINS. (required).</param>
        /// <param name="vPIS">Valor do PIS. (required).</param>
        /// <param name="vFUNTTEL">Valor do FUNTTEL. (required).</param>
        /// <param name="vFUST">Valor do FUST. (required).</param>
        /// <param name="vRetTribTot">vRetTribTot (required).</param>
        /// <param name="vDesc">Valor Total do Desconto. (required).</param>
        /// <param name="vOutro">Outras Despesas acessórias. (required).</param>
        /// <param name="vNF">Valor Total da NFCom. (required).</param>
        public NfcomSefazTotal(decimal? vProd = default(decimal?), NfcomSefazICMSTot iCMSTot = default(NfcomSefazICMSTot), decimal? vCOFINS = default(decimal?), decimal? vPIS = default(decimal?), decimal? vFUNTTEL = default(decimal?), decimal? vFUST = default(decimal?), NfcomSefazVRetTribTot vRetTribTot = default(NfcomSefazVRetTribTot), decimal? vDesc = default(decimal?), decimal? vOutro = default(decimal?), decimal? vNF = default(decimal?))
        {
            // to ensure "vProd" is required (not null)
            if (vProd == null)
            {
                throw new ArgumentNullException("vProd is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vProd = vProd;
            // to ensure "iCMSTot" is required (not null)
            if (iCMSTot == null)
            {
                throw new ArgumentNullException("iCMSTot is a required property for NfcomSefazTotal and cannot be null");
            }
            this.ICMSTot = iCMSTot;
            // to ensure "vCOFINS" is required (not null)
            if (vCOFINS == null)
            {
                throw new ArgumentNullException("vCOFINS is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vCOFINS = vCOFINS;
            // to ensure "vPIS" is required (not null)
            if (vPIS == null)
            {
                throw new ArgumentNullException("vPIS is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vPIS = vPIS;
            // to ensure "vFUNTTEL" is required (not null)
            if (vFUNTTEL == null)
            {
                throw new ArgumentNullException("vFUNTTEL is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vFUNTTEL = vFUNTTEL;
            // to ensure "vFUST" is required (not null)
            if (vFUST == null)
            {
                throw new ArgumentNullException("vFUST is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vFUST = vFUST;
            // to ensure "vRetTribTot" is required (not null)
            if (vRetTribTot == null)
            {
                throw new ArgumentNullException("vRetTribTot is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vRetTribTot = vRetTribTot;
            // to ensure "vDesc" is required (not null)
            if (vDesc == null)
            {
                throw new ArgumentNullException("vDesc is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vDesc = vDesc;
            // to ensure "vOutro" is required (not null)
            if (vOutro == null)
            {
                throw new ArgumentNullException("vOutro is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vOutro = vOutro;
            // to ensure "vNF" is required (not null)
            if (vNF == null)
            {
                throw new ArgumentNullException("vNF is a required property for NfcomSefazTotal and cannot be null");
            }
            this.vNF = vNF;
        }

        /// <summary>
        /// Valor Total dos produtos e serviços.
        /// </summary>
        /// <value>Valor Total dos produtos e serviços.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vProd { get; set; }

        /// <summary>
        /// Gets or Sets ICMSTot
        /// </summary>
        [DataMember(Name = "ICMSTot", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazICMSTot ICMSTot { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Valor do FUNTTEL.
        /// </summary>
        /// <value>Valor do FUNTTEL.</value>
        [DataMember(Name = "vFUNTTEL", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFUNTTEL { get; set; }

        /// <summary>
        /// Valor do FUST.
        /// </summary>
        /// <value>Valor do FUST.</value>
        [DataMember(Name = "vFUST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFUST { get; set; }

        /// <summary>
        /// Gets or Sets vRetTribTot
        /// </summary>
        [DataMember(Name = "vRetTribTot", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazVRetTribTot vRetTribTot { get; set; }

        /// <summary>
        /// Valor Total do Desconto.
        /// </summary>
        /// <value>Valor Total do Desconto.</value>
        [DataMember(Name = "vDesc", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDesc { get; set; }

        /// <summary>
        /// Outras Despesas acessórias.
        /// </summary>
        /// <value>Outras Despesas acessórias.</value>
        [DataMember(Name = "vOutro", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vOutro { get; set; }

        /// <summary>
        /// Valor Total da NFCom.
        /// </summary>
        /// <value>Valor Total da NFCom.</value>
        [DataMember(Name = "vNF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vNF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazTotal {\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
            sb.Append("  ICMSTot: ").Append(ICMSTot).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
            sb.Append("  vFUNTTEL: ").Append(vFUNTTEL).Append("\n");
            sb.Append("  vFUST: ").Append(vFUST).Append("\n");
            sb.Append("  vRetTribTot: ").Append(vRetTribTot).Append("\n");
            sb.Append("  vDesc: ").Append(vDesc).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  vNF: ").Append(vNF).Append("\n");
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
            return this.Equals(input as NfcomSefazTotal);
        }

        /// <summary>
        /// Returns true if NfcomSefazTotal instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazTotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazTotal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vProd == input.vProd ||
                    (this.vProd != null &&
                    this.vProd.Equals(input.vProd))
                ) && 
                (
                    this.ICMSTot == input.ICMSTot ||
                    (this.ICMSTot != null &&
                    this.ICMSTot.Equals(input.ICMSTot))
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    (this.vCOFINS != null &&
                    this.vCOFINS.Equals(input.vCOFINS))
                ) && 
                (
                    this.vPIS == input.vPIS ||
                    (this.vPIS != null &&
                    this.vPIS.Equals(input.vPIS))
                ) && 
                (
                    this.vFUNTTEL == input.vFUNTTEL ||
                    (this.vFUNTTEL != null &&
                    this.vFUNTTEL.Equals(input.vFUNTTEL))
                ) && 
                (
                    this.vFUST == input.vFUST ||
                    (this.vFUST != null &&
                    this.vFUST.Equals(input.vFUST))
                ) && 
                (
                    this.vRetTribTot == input.vRetTribTot ||
                    (this.vRetTribTot != null &&
                    this.vRetTribTot.Equals(input.vRetTribTot))
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    (this.vDesc != null &&
                    this.vDesc.Equals(input.vDesc))
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    (this.vOutro != null &&
                    this.vOutro.Equals(input.vOutro))
                ) && 
                (
                    this.vNF == input.vNF ||
                    (this.vNF != null &&
                    this.vNF.Equals(input.vNF))
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
                if (this.vProd != null)
                {
                    hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                }
                if (this.ICMSTot != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSTot.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                }
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                }
                if (this.vFUNTTEL != null)
                {
                    hashCode = (hashCode * 59) + this.vFUNTTEL.GetHashCode();
                }
                if (this.vFUST != null)
                {
                    hashCode = (hashCode * 59) + this.vFUST.GetHashCode();
                }
                if (this.vRetTribTot != null)
                {
                    hashCode = (hashCode * 59) + this.vRetTribTot.GetHashCode();
                }
                if (this.vDesc != null)
                {
                    hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                }
                if (this.vOutro != null)
                {
                    hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                }
                if (this.vNF != null)
                {
                    hashCode = (hashCode * 59) + this.vNF.GetHashCode();
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
            // vProd (decimal?) minimum
            if (this.vProd < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vProd, must be a value greater than or equal to 0.", new [] { "vProd" });
            }

            // vCOFINS (decimal?) minimum
            if (this.vCOFINS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCOFINS, must be a value greater than or equal to 0.", new [] { "vCOFINS" });
            }

            // vPIS (decimal?) minimum
            if (this.vPIS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vPIS, must be a value greater than or equal to 0.", new [] { "vPIS" });
            }

            // vFUNTTEL (decimal?) minimum
            if (this.vFUNTTEL < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFUNTTEL, must be a value greater than or equal to 0.", new [] { "vFUNTTEL" });
            }

            // vFUST (decimal?) minimum
            if (this.vFUST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFUST, must be a value greater than or equal to 0.", new [] { "vFUST" });
            }

            // vDesc (decimal?) minimum
            if (this.vDesc < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vDesc, must be a value greater than or equal to 0.", new [] { "vDesc" });
            }

            // vOutro (decimal?) minimum
            if (this.vOutro < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vOutro, must be a value greater than or equal to 0.", new [] { "vOutro" });
            }

            // vNF (decimal?) minimum
            if (this.vNF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vNF, must be a value greater than or equal to 0.", new [] { "vNF" });
            }

            yield break;
        }
    }

}
