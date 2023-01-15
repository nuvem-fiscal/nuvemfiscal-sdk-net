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
    /// Lacres das Unidades de Carga.
    /// </summary>
    [DataContract(Name = "CteSefazLacUnidCarga")]
    public partial class CteSefazLacUnidCarga : IEquatable<CteSefazLacUnidCarga>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazLacUnidCarga" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazLacUnidCarga() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazLacUnidCarga" /> class.
        /// </summary>
        /// <param name="nLacre">Número do lacre. (required).</param>
        public CteSefazLacUnidCarga(string nLacre = default(string))
        {
            // to ensure "nLacre" is required (not null)
            if (nLacre == null)
            {
                throw new ArgumentNullException("nLacre is a required property for CteSefazLacUnidCarga and cannot be null");
            }
            this.nLacre = nLacre;
        }

        /// <summary>
        /// Número do lacre.
        /// </summary>
        /// <value>Número do lacre.</value>
        [DataMember(Name = "nLacre", IsRequired = true, EmitDefaultValue = true)]
        public string nLacre { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazLacUnidCarga {\n");
            sb.Append("  nLacre: ").Append(nLacre).Append("\n");
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
            return this.Equals(input as CteSefazLacUnidCarga);
        }

        /// <summary>
        /// Returns true if CteSefazLacUnidCarga instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazLacUnidCarga to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazLacUnidCarga input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nLacre == input.nLacre ||
                    (this.nLacre != null &&
                    this.nLacre.Equals(input.nLacre))
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
                if (this.nLacre != null)
                {
                    hashCode = (hashCode * 59) + this.nLacre.GetHashCode();
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
            yield break;
        }
    }

}
