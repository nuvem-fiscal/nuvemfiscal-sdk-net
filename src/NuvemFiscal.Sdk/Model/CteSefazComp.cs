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
    /// CteSefazComp
    /// </summary>
    [DataContract(Name = "CteSefazComp")]
    public partial class CteSefazComp : IEquatable<CteSefazComp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazComp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazComp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazComp" /> class.
        /// </summary>
        /// <param name="xNome">Nome do componente.  Exxemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc. (required).</param>
        /// <param name="vComp">Valor do componente. (required).</param>
        public CteSefazComp(string xNome = default(string), decimal vComp = default(decimal))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteSefazComp and cannot be null");
            }
            this.xNome = xNome;
            this.vComp = vComp;
        }

        /// <summary>
        /// Nome do componente.  Exxemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc.
        /// </summary>
        /// <value>Nome do componente.  Exxemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = false)]
        public string xNome { get; set; }

        /// <summary>
        /// Valor do componente.
        /// </summary>
        /// <value>Valor do componente.</value>
        [DataMember(Name = "vComp", IsRequired = true, EmitDefaultValue = false)]
        public decimal vComp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazComp {\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  vComp: ").Append(vComp).Append("\n");
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
            return this.Equals(input as CteSefazComp);
        }

        /// <summary>
        /// Returns true if CteSefazComp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazComp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazComp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.vComp == input.vComp ||
                    this.vComp.Equals(input.vComp)
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vComp.GetHashCode();
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
