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
    /// Tributação com Diferimento.  A exigência do preenchimento das informações do ICMS diferido fica a critério de cada UF.
    /// </summary>
    [DataContract(Name = "NfcomSefazICMS51")]
    public partial class NfcomSefazICMS51 : IEquatable<NfcomSefazICMS51>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazICMS51" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazICMS51() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazICMS51" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do serviço.  Tributação pelo ICMS 51 - Diferimento. (required).</param>
        /// <param name="vICMSDeson">Valor do ICMS de desoneração..</param>
        /// <param name="cBenef">Código de Benefício Fiscal na UF aplicado ao item.  Código de Benefício Fiscal utilizado pela UF, aplicado ao  item..</param>
        public NfcomSefazICMS51(string cST = default(string), decimal? vICMSDeson = default(decimal?), string cBenef = default(string))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfcomSefazICMS51 and cannot be null");
            }
            this.CST = cST;
            this.vICMSDeson = vICMSDeson;
            this.cBenef = cBenef;
        }

        /// <summary>
        /// Classificação Tributária do serviço.  Tributação pelo ICMS 51 - Diferimento.
        /// </summary>
        /// <value>Classificação Tributária do serviço.  Tributação pelo ICMS 51 - Diferimento.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor do ICMS de desoneração.
        /// </summary>
        /// <value>Valor do ICMS de desoneração.</value>
        [DataMember(Name = "vICMSDeson", EmitDefaultValue = true)]
        public decimal? vICMSDeson { get; set; }

        /// <summary>
        /// Código de Benefício Fiscal na UF aplicado ao item.  Código de Benefício Fiscal utilizado pela UF, aplicado ao  item.
        /// </summary>
        /// <value>Código de Benefício Fiscal na UF aplicado ao item.  Código de Benefício Fiscal utilizado pela UF, aplicado ao  item.</value>
        [DataMember(Name = "cBenef", EmitDefaultValue = true)]
        public string cBenef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazICMS51 {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  cBenef: ").Append(cBenef).Append("\n");
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
            return this.Equals(input as NfcomSefazICMS51);
        }

        /// <summary>
        /// Returns true if NfcomSefazICMS51 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazICMS51 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazICMS51 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.vICMSDeson == input.vICMSDeson ||
                    (this.vICMSDeson != null &&
                    this.vICMSDeson.Equals(input.vICMSDeson))
                ) && 
                (
                    this.cBenef == input.cBenef ||
                    (this.cBenef != null &&
                    this.cBenef.Equals(input.cBenef))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.vICMSDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                }
                if (this.cBenef != null)
                {
                    hashCode = (hashCode * 59) + this.cBenef.GetHashCode();
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
            // cBenef (string) maxLength
            if (this.cBenef != null && this.cBenef.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cBenef, length must be less than 10.", new [] { "cBenef" });
            }

            yield break;
        }
    }

}
