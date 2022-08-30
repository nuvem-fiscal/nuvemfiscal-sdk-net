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
    /// CteSefazDetCont
    /// </summary>
    [DataContract(Name = "CteSefazDetCont")]
    public partial class CteSefazDetCont : IEquatable<CteSefazDetCont>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDetCont" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazDetCont() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDetCont" /> class.
        /// </summary>
        /// <param name="nCont">Identificação do Container. (required).</param>
        /// <param name="lacre">Grupo de informações dos lacres dos cointainers da qtde da carga..</param>
        /// <param name="infDoc">infDoc.</param>
        public CteSefazDetCont(string nCont = default(string), List<CteSefazLacre> lacre = default(List<CteSefazLacre>), CteSefazDetContInfDoc infDoc = default(CteSefazDetContInfDoc))
        {
            // to ensure "nCont" is required (not null)
            if (nCont == null)
            {
                throw new ArgumentNullException("nCont is a required property for CteSefazDetCont and cannot be null");
            }
            this.nCont = nCont;
            this.lacre = lacre;
            this.infDoc = infDoc;
        }

        /// <summary>
        /// Identificação do Container.
        /// </summary>
        /// <value>Identificação do Container.</value>
        [DataMember(Name = "nCont", IsRequired = true, EmitDefaultValue = false)]
        public string nCont { get; set; }

        /// <summary>
        /// Grupo de informações dos lacres dos cointainers da qtde da carga.
        /// </summary>
        /// <value>Grupo de informações dos lacres dos cointainers da qtde da carga.</value>
        [DataMember(Name = "lacre", EmitDefaultValue = false)]
        public List<CteSefazLacre> lacre { get; set; }

        /// <summary>
        /// Gets or Sets infDoc
        /// </summary>
        [DataMember(Name = "infDoc", EmitDefaultValue = false)]
        public CteSefazDetContInfDoc infDoc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazDetCont {\n");
            sb.Append("  nCont: ").Append(nCont).Append("\n");
            sb.Append("  lacre: ").Append(lacre).Append("\n");
            sb.Append("  infDoc: ").Append(infDoc).Append("\n");
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
            return this.Equals(input as CteSefazDetCont);
        }

        /// <summary>
        /// Returns true if CteSefazDetCont instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazDetCont to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazDetCont input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nCont == input.nCont ||
                    (this.nCont != null &&
                    this.nCont.Equals(input.nCont))
                ) && 
                (
                    this.lacre == input.lacre ||
                    this.lacre != null &&
                    input.lacre != null &&
                    this.lacre.SequenceEqual(input.lacre)
                ) && 
                (
                    this.infDoc == input.infDoc ||
                    (this.infDoc != null &&
                    this.infDoc.Equals(input.infDoc))
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
                if (this.nCont != null)
                {
                    hashCode = (hashCode * 59) + this.nCont.GetHashCode();
                }
                if (this.lacre != null)
                {
                    hashCode = (hashCode * 59) + this.lacre.GetHashCode();
                }
                if (this.infDoc != null)
                {
                    hashCode = (hashCode * 59) + this.infDoc.GetHashCode();
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
