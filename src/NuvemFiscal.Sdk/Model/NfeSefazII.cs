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
    /// Dados do Imposto de Importação.
    /// </summary>
    [DataContract(Name = "NfeSefazII")]
    public partial class NfeSefazII : IEquatable<NfeSefazII>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazII" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazII() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazII" /> class.
        /// </summary>
        /// <param name="vBC">Base da BC do Imposto de Importação. (required).</param>
        /// <param name="vDespAdu">Valor das despesas aduaneiras. (required).</param>
        /// <param name="vII">Valor do Imposto de Importação. (required).</param>
        /// <param name="vIOF">Valor do Imposto sobre Operações Financeiras. (required).</param>
        public NfeSefazII(decimal? vBC = default(decimal?), decimal? vDespAdu = default(decimal?), decimal? vII = default(decimal?), decimal? vIOF = default(decimal?))
        {
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfeSefazII and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "vDespAdu" is required (not null)
            if (vDespAdu == null)
            {
                throw new ArgumentNullException("vDespAdu is a required property for NfeSefazII and cannot be null");
            }
            this.vDespAdu = vDespAdu;
            // to ensure "vII" is required (not null)
            if (vII == null)
            {
                throw new ArgumentNullException("vII is a required property for NfeSefazII and cannot be null");
            }
            this.vII = vII;
            // to ensure "vIOF" is required (not null)
            if (vIOF == null)
            {
                throw new ArgumentNullException("vIOF is a required property for NfeSefazII and cannot be null");
            }
            this.vIOF = vIOF;
        }

        /// <summary>
        /// Base da BC do Imposto de Importação.
        /// </summary>
        /// <value>Base da BC do Imposto de Importação.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Valor das despesas aduaneiras.
        /// </summary>
        /// <value>Valor das despesas aduaneiras.</value>
        [DataMember(Name = "vDespAdu", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDespAdu { get; set; }

        /// <summary>
        /// Valor do Imposto de Importação.
        /// </summary>
        /// <value>Valor do Imposto de Importação.</value>
        [DataMember(Name = "vII", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vII { get; set; }

        /// <summary>
        /// Valor do Imposto sobre Operações Financeiras.
        /// </summary>
        /// <value>Valor do Imposto sobre Operações Financeiras.</value>
        [DataMember(Name = "vIOF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIOF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazII {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  vDespAdu: ").Append(vDespAdu).Append("\n");
            sb.Append("  vII: ").Append(vII).Append("\n");
            sb.Append("  vIOF: ").Append(vIOF).Append("\n");
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
            return this.Equals(input as NfeSefazII);
        }

        /// <summary>
        /// Returns true if NfeSefazII instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazII to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazII input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.vDespAdu == input.vDespAdu ||
                    (this.vDespAdu != null &&
                    this.vDespAdu.Equals(input.vDespAdu))
                ) && 
                (
                    this.vII == input.vII ||
                    (this.vII != null &&
                    this.vII.Equals(input.vII))
                ) && 
                (
                    this.vIOF == input.vIOF ||
                    (this.vIOF != null &&
                    this.vIOF.Equals(input.vIOF))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.vDespAdu != null)
                {
                    hashCode = (hashCode * 59) + this.vDespAdu.GetHashCode();
                }
                if (this.vII != null)
                {
                    hashCode = (hashCode * 59) + this.vII.GetHashCode();
                }
                if (this.vIOF != null)
                {
                    hashCode = (hashCode * 59) + this.vIOF.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // vDespAdu (decimal?) minimum
            if (this.vDespAdu < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vDespAdu, must be a value greater than or equal to 0.", new [] { "vDespAdu" });
            }

            // vII (decimal?) minimum
            if (this.vII < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vII, must be a value greater than or equal to 0.", new [] { "vII" });
            }

            // vIOF (decimal?) minimum
            if (this.vIOF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIOF, must be a value greater than or equal to 0.", new [] { "vIOF" });
            }

            yield break;
        }
    }

}
