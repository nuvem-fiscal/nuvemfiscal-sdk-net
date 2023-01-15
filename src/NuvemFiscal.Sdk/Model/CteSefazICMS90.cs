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
    /// ICMS Outros.
    /// </summary>
    [DataContract(Name = "CteSefazICMS90")]
    public partial class CteSefazICMS90 : IEquatable<CteSefazICMS90>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMS90" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazICMS90() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazICMS90" /> class.
        /// </summary>
        /// <param name="cST">Classificação Tributária do Serviço.  * 90 - ICMS outros (required).</param>
        /// <param name="pRedBC">Percentual de redução da BC..</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="vCred">Valor do Crédito Outorgado/Presumido..</param>
        public CteSefazICMS90(string cST = default(string), decimal pRedBC = default(decimal), decimal vBC = default(decimal), decimal pICMS = default(decimal), decimal vICMS = default(decimal), decimal vCred = default(decimal))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSefazICMS90 and cannot be null");
            }
            this.CST = cST;
            this.vBC = vBC;
            this.pICMS = pICMS;
            this.vICMS = vICMS;
            this.pRedBC = pRedBC;
            this.vCred = vCred;
        }

        /// <summary>
        /// Classificação Tributária do Serviço.  * 90 - ICMS outros
        /// </summary>
        /// <value>Classificação Tributária do Serviço.  * 90 - ICMS outros</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", EmitDefaultValue = false)]
        public decimal pRedBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMS { get; set; }

        /// <summary>
        /// Valor do Crédito Outorgado/Presumido.
        /// </summary>
        /// <value>Valor do Crédito Outorgado/Presumido.</value>
        [DataMember(Name = "vCred", EmitDefaultValue = false)]
        public decimal vCred { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazICMS90 {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  pRedBC: ").Append(pRedBC).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vCred: ").Append(vCred).Append("\n");
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
            return this.Equals(input as CteSefazICMS90);
        }

        /// <summary>
        /// Returns true if CteSefazICMS90 instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazICMS90 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazICMS90 input)
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
                    this.pRedBC == input.pRedBC ||
                    this.pRedBC.Equals(input.pRedBC)
                ) && 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    this.pICMS.Equals(input.pICMS)
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    this.vICMS.Equals(input.vICMS)
                ) && 
                (
                    this.vCred == input.vCred ||
                    this.vCred.Equals(input.vCred)
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
                hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vCred.GetHashCode();
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
