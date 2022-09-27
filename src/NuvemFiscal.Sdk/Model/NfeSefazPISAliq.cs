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
    /// NfeSefazPISAliq
    /// </summary>
    [DataContract(Name = "NfeSefazPISAliq")]
    public partial class NfeSefazPISAliq : IEquatable<NfeSefazPISAliq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPISAliq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazPISAliq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPISAliq" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do PIS.   01 – Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo);  02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada);. (required).</param>
        /// <param name="vBC">Valor da BC do PIS. (required).</param>
        /// <param name="pPIS">Alíquota do PIS (em percentual). (required).</param>
        /// <param name="vPIS">Valor do PIS. (required).</param>
        public NfeSefazPISAliq(string cST = default(string), decimal vBC = default(decimal), decimal pPIS = default(decimal), decimal vPIS = default(decimal))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazPISAliq and cannot be null");
            }
            this.CST = cST;
            this.vBC = vBC;
            this.pPIS = pPIS;
            this.vPIS = vPIS;
        }

        /// <summary>
        /// Código de Situação Tributária do PIS.   01 – Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo);  02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada);.
        /// </summary>
        /// <value>Código de Situação Tributária do PIS.   01 – Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo);  02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada);.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do PIS.
        /// </summary>
        /// <value>Valor da BC do PIS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Alíquota do PIS (em percentual).
        /// </summary>
        /// <value>Alíquota do PIS (em percentual).</value>
        [DataMember(Name = "pPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal pPIS { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vPIS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazPISAliq {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pPIS: ").Append(pPIS).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
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
            return this.Equals(input as NfeSefazPISAliq);
        }

        /// <summary>
        /// Returns true if NfeSefazPISAliq instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazPISAliq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazPISAliq input)
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
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.pPIS == input.pPIS ||
                    this.pPIS.Equals(input.pPIS)
                ) && 
                (
                    this.vPIS == input.vPIS ||
                    this.vPIS.Equals(input.vPIS)
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
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pPIS.GetHashCode();
                hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
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
