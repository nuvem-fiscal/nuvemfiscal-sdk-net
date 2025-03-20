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
    /// Dados dos transportes da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazTransp")]
    public partial class DceSefazTransp : IEquatable<DceSefazTransp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazTransp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazTransp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazTransp" /> class.
        /// </summary>
        /// <param name="modTrans">Modalidade do transporte.  * 0 - Transporte pelos correios  * 1 - Transporte por contra própria  * 2 - Transporte por empresa transportadora (required).</param>
        /// <param name="cNPJTransp">Número do CNPJ da Transportadora. (required).</param>
        public DceSefazTransp(int? modTrans = default(int?), string cNPJTransp = default(string))
        {
            // to ensure "modTrans" is required (not null)
            if (modTrans == null)
            {
                throw new ArgumentNullException("modTrans is a required property for DceSefazTransp and cannot be null");
            }
            this.modTrans = modTrans;
            // to ensure "cNPJTransp" is required (not null)
            if (cNPJTransp == null)
            {
                throw new ArgumentNullException("cNPJTransp is a required property for DceSefazTransp and cannot be null");
            }
            this.CNPJTransp = cNPJTransp;
        }

        /// <summary>
        /// Modalidade do transporte.  * 0 - Transporte pelos correios  * 1 - Transporte por contra própria  * 2 - Transporte por empresa transportadora
        /// </summary>
        /// <value>Modalidade do transporte.  * 0 - Transporte pelos correios  * 1 - Transporte por contra própria  * 2 - Transporte por empresa transportadora</value>
        [DataMember(Name = "modTrans", IsRequired = true, EmitDefaultValue = true)]
        public int? modTrans { get; set; }

        /// <summary>
        /// Número do CNPJ da Transportadora.
        /// </summary>
        /// <value>Número do CNPJ da Transportadora.</value>
        [DataMember(Name = "CNPJTransp", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJTransp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazTransp {\n");
            sb.Append("  modTrans: ").Append(modTrans).Append("\n");
            sb.Append("  CNPJTransp: ").Append(CNPJTransp).Append("\n");
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
            return this.Equals(input as DceSefazTransp);
        }

        /// <summary>
        /// Returns true if DceSefazTransp instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazTransp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazTransp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.modTrans == input.modTrans ||
                    (this.modTrans != null &&
                    this.modTrans.Equals(input.modTrans))
                ) && 
                (
                    this.CNPJTransp == input.CNPJTransp ||
                    (this.CNPJTransp != null &&
                    this.CNPJTransp.Equals(input.CNPJTransp))
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
                if (this.modTrans != null)
                {
                    hashCode = (hashCode * 59) + this.modTrans.GetHashCode();
                }
                if (this.CNPJTransp != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJTransp.GetHashCode();
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
            yield break;
        }
    }

}
