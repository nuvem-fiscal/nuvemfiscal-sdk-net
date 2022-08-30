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
    /// CteSefazICMSSN
    /// </summary>
    [DataContract(Name = "CteSefazICMSSN")]
    public partial class CteSefazICMSSN : IEquatable<CteSefazICMSSN>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMSSN" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazICMSSN() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMSSN" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do Serviço.  90 - ICMS Simples Nacional. (required).</param>
        /// <param name="indSN">Indica se o contribuinte é Simples Nacional   1&#x3D;Sim. (required).</param>
        public CteSefazICMSSN(string cST = default(string), int indSN = default(int))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSefazICMSSN and cannot be null");
            }
            this.CST = cST;
            this.indSN = indSN;
        }

        /// <summary>
        /// Classificação Tributária do Serviço.  90 - ICMS Simples Nacional.
        /// </summary>
        /// <value>Classificação Tributária do Serviço.  90 - ICMS Simples Nacional.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = false)]
        public string CST { get; set; }

        /// <summary>
        /// Indica se o contribuinte é Simples Nacional   1&#x3D;Sim.
        /// </summary>
        /// <value>Indica se o contribuinte é Simples Nacional   1&#x3D;Sim.</value>
        [DataMember(Name = "indSN", IsRequired = true, EmitDefaultValue = false)]
        public int indSN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazICMSSN {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  indSN: ").Append(indSN).Append("\n");
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
            return this.Equals(input as CteSefazICMSSN);
        }

        /// <summary>
        /// Returns true if CteSefazICMSSN instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazICMSSN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazICMSSN input)
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
                    this.indSN == input.indSN ||
                    this.indSN.Equals(input.indSN)
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
                hashCode = (hashCode * 59) + this.indSN.GetHashCode();
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
