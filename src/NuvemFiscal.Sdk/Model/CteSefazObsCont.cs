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
    /// CteSefazObsCont
    /// </summary>
    [DataContract(Name = "CteSefazObsCont")]
    public partial class CteSefazObsCont : IEquatable<CteSefazObsCont>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazObsCont" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazObsCont() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazObsCont" /> class.
        /// </summary>
        /// <param name="xCampo">xCampo.</param>
        /// <param name="xTexto">Conteúdo do campo. (required).</param>
        public CteSefazObsCont(string xCampo = default(string), string xTexto = default(string))
        {
            // to ensure "xTexto" is required (not null)
            if (xTexto == null)
            {
                throw new ArgumentNullException("xTexto is a required property for CteSefazObsCont and cannot be null");
            }
            this.xTexto = xTexto;
            this.xCampo = xCampo;
        }

        /// <summary>
        /// Gets or Sets xCampo
        /// </summary>
        [DataMember(Name = "xCampo", EmitDefaultValue = false)]
        public string xCampo { get; set; }

        /// <summary>
        /// Conteúdo do campo.
        /// </summary>
        /// <value>Conteúdo do campo.</value>
        [DataMember(Name = "xTexto", IsRequired = true, EmitDefaultValue = true)]
        public string xTexto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazObsCont {\n");
            sb.Append("  xCampo: ").Append(xCampo).Append("\n");
            sb.Append("  xTexto: ").Append(xTexto).Append("\n");
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
            return this.Equals(input as CteSefazObsCont);
        }

        /// <summary>
        /// Returns true if CteSefazObsCont instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazObsCont to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazObsCont input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xCampo == input.xCampo ||
                    (this.xCampo != null &&
                    this.xCampo.Equals(input.xCampo))
                ) && 
                (
                    this.xTexto == input.xTexto ||
                    (this.xTexto != null &&
                    this.xTexto.Equals(input.xTexto))
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
                if (this.xCampo != null)
                {
                    hashCode = (hashCode * 59) + this.xCampo.GetHashCode();
                }
                if (this.xTexto != null)
                {
                    hashCode = (hashCode * 59) + this.xTexto.GetHashCode();
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
