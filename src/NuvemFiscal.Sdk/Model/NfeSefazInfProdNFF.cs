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
    /// Informações mais detalhadas do produto (usada na NFF).
    /// </summary>
    [DataContract(Name = "NfeSefazInfProdNFF")]
    public partial class NfeSefazInfProdNFF : IEquatable<NfeSefazInfProdNFF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfProdNFF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazInfProdNFF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfProdNFF" /> class.
        /// </summary>
        /// <param name="cProdFisco">Código Fiscal do Produto. (required).</param>
        /// <param name="cOperNFF">Código da operação selecionada na NFF e relacionada ao item. (required).</param>
        public NfeSefazInfProdNFF(string cProdFisco = default(string), string cOperNFF = default(string))
        {
            // to ensure "cProdFisco" is required (not null)
            if (cProdFisco == null)
            {
                throw new ArgumentNullException("cProdFisco is a required property for NfeSefazInfProdNFF and cannot be null");
            }
            this.cProdFisco = cProdFisco;
            // to ensure "cOperNFF" is required (not null)
            if (cOperNFF == null)
            {
                throw new ArgumentNullException("cOperNFF is a required property for NfeSefazInfProdNFF and cannot be null");
            }
            this.cOperNFF = cOperNFF;
        }

        /// <summary>
        /// Código Fiscal do Produto.
        /// </summary>
        /// <value>Código Fiscal do Produto.</value>
        [DataMember(Name = "cProdFisco", IsRequired = true, EmitDefaultValue = true)]
        public string cProdFisco { get; set; }

        /// <summary>
        /// Código da operação selecionada na NFF e relacionada ao item.
        /// </summary>
        /// <value>Código da operação selecionada na NFF e relacionada ao item.</value>
        [DataMember(Name = "cOperNFF", IsRequired = true, EmitDefaultValue = true)]
        public string cOperNFF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfProdNFF {\n");
            sb.Append("  cProdFisco: ").Append(cProdFisco).Append("\n");
            sb.Append("  cOperNFF: ").Append(cOperNFF).Append("\n");
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
            return this.Equals(input as NfeSefazInfProdNFF);
        }

        /// <summary>
        /// Returns true if NfeSefazInfProdNFF instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfProdNFF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfProdNFF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cProdFisco == input.cProdFisco ||
                    (this.cProdFisco != null &&
                    this.cProdFisco.Equals(input.cProdFisco))
                ) && 
                (
                    this.cOperNFF == input.cOperNFF ||
                    (this.cOperNFF != null &&
                    this.cOperNFF.Equals(input.cOperNFF))
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
                if (this.cProdFisco != null)
                {
                    hashCode = (hashCode * 59) + this.cProdFisco.GetHashCode();
                }
                if (this.cOperNFF != null)
                {
                    hashCode = (hashCode * 59) + this.cOperNFF.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // cProdFisco (string) maxLength
            if (this.cProdFisco != null && this.cProdFisco.Length > 14)
            {
                yield return new ValidationResult("Invalid value for cProdFisco, length must be less than 14.", new [] { "cProdFisco" });
            }

            yield break;
        }
    }

}
