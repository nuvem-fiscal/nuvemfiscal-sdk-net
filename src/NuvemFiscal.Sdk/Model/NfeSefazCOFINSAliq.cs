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
    /// Código de Situação Tributária do COFINS.  * 01 - Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo)  * 02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada)
    /// </summary>
    [DataContract(Name = "NfeSefazCOFINSAliq")]
    public partial class NfeSefazCOFINSAliq : IEquatable<NfeSefazCOFINSAliq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSAliq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCOFINSAliq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSAliq" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do COFINS.  * 01 - Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo)  * 02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada) (required).</param>
        /// <param name="vBC">Valor da BC do COFINS. (required).</param>
        /// <param name="pCOFINS">Alíquota do COFINS (em percentual). (required).</param>
        /// <param name="vCOFINS">Valor do COFINS. (required).</param>
        public NfeSefazCOFINSAliq(string cST = default(string), decimal? vBC = default(decimal?), decimal? pCOFINS = default(decimal?), decimal? vCOFINS = default(decimal?))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazCOFINSAliq and cannot be null");
            }
            this.CST = cST;
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfeSefazCOFINSAliq and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pCOFINS" is required (not null)
            if (pCOFINS == null)
            {
                throw new ArgumentNullException("pCOFINS is a required property for NfeSefazCOFINSAliq and cannot be null");
            }
            this.pCOFINS = pCOFINS;
            // to ensure "vCOFINS" is required (not null)
            if (vCOFINS == null)
            {
                throw new ArgumentNullException("vCOFINS is a required property for NfeSefazCOFINSAliq and cannot be null");
            }
            this.vCOFINS = vCOFINS;
        }

        /// <summary>
        /// Código de Situação Tributária do COFINS.  * 01 - Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo)  * 02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada)
        /// </summary>
        /// <value>Código de Situação Tributária do COFINS.  * 01 - Operação Tributável - Base de Cálculo &#x3D; Valor da Operação Alíquota Normal (Cumulativo/Não Cumulativo)  * 02 - Operação Tributável - Base de Calculo &#x3D; Valor da Operação (Alíquota Diferenciada)</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do COFINS.
        /// </summary>
        /// <value>Valor da BC do COFINS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do COFINS (em percentual).
        /// </summary>
        /// <value>Alíquota do COFINS (em percentual).</value>
        [DataMember(Name = "pCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pCOFINS { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCOFINSAliq {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pCOFINS: ").Append(pCOFINS).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
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
            return this.Equals(input as NfeSefazCOFINSAliq);
        }

        /// <summary>
        /// Returns true if NfeSefazCOFINSAliq instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCOFINSAliq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCOFINSAliq input)
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
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pCOFINS == input.pCOFINS ||
                    (this.pCOFINS != null &&
                    this.pCOFINS.Equals(input.pCOFINS))
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    (this.vCOFINS != null &&
                    this.vCOFINS.Equals(input.vCOFINS))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.pCOFINS.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
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
            yield break;
        }
    }

}
