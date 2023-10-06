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
    /// Grupo para informações da solicitação da NFF.
    /// </summary>
    [DataContract(Name = "NfeSefazInfSolicNFF")]
    public partial class NfeSefazInfSolicNFF : IEquatable<NfeSefazInfSolicNFF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfSolicNFF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazInfSolicNFF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfSolicNFF" /> class.
        /// </summary>
        /// <param name="xSolic">Solicitação do pedido de emissão da NFF. (required).</param>
        public NfeSefazInfSolicNFF(string xSolic = default(string))
        {
            // to ensure "xSolic" is required (not null)
            if (xSolic == null)
            {
                throw new ArgumentNullException("xSolic is a required property for NfeSefazInfSolicNFF and cannot be null");
            }
            this.xSolic = xSolic;
        }

        /// <summary>
        /// Solicitação do pedido de emissão da NFF.
        /// </summary>
        /// <value>Solicitação do pedido de emissão da NFF.</value>
        [DataMember(Name = "xSolic", IsRequired = true, EmitDefaultValue = true)]
        public string xSolic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfSolicNFF {\n");
            sb.Append("  xSolic: ").Append(xSolic).Append("\n");
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
            return this.Equals(input as NfeSefazInfSolicNFF);
        }

        /// <summary>
        /// Returns true if NfeSefazInfSolicNFF instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfSolicNFF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfSolicNFF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xSolic == input.xSolic ||
                    (this.xSolic != null &&
                    this.xSolic.Equals(input.xSolic))
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
                if (this.xSolic != null)
                {
                    hashCode = (hashCode * 59) + this.xSolic.GetHashCode();
                }
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
            // xSolic (string) maxLength
            if (this.xSolic != null && this.xSolic.Length > 5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xSolic, length must be less than 5000.", new [] { "xSolic" });
            }

            // xSolic (string) minLength
            if (this.xSolic != null && this.xSolic.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xSolic, length must be greater than 2.", new [] { "xSolic" });
            }

            yield break;
        }
    }

}
