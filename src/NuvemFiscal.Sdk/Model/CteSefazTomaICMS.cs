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
    /// CteSefazTomaICMS
    /// </summary>
    [DataContract(Name = "CteSefazTomaICMS")]
    public partial class CteSefazTomaICMS : IEquatable<CteSefazTomaICMS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTomaICMS" /> class.
        /// </summary>
        /// <param name="refNFe">Chave de acesso da NF-e emitida pelo Tomador..</param>
        /// <param name="refNF">refNF.</param>
        /// <param name="refCte">Chave de acesso do CT-e emitido pelo Tomador..</param>
        public CteSefazTomaICMS(string refNFe = default(string), CteSefazRefNF refNF = default(CteSefazRefNF), string refCte = default(string))
        {
            this.refNFe = refNFe;
            this.refNF = refNF;
            this.refCte = refCte;
        }

        /// <summary>
        /// Chave de acesso da NF-e emitida pelo Tomador.
        /// </summary>
        /// <value>Chave de acesso da NF-e emitida pelo Tomador.</value>
        [DataMember(Name = "refNFe", EmitDefaultValue = false)]
        public string refNFe { get; set; }

        /// <summary>
        /// Gets or Sets refNF
        /// </summary>
        [DataMember(Name = "refNF", EmitDefaultValue = false)]
        public CteSefazRefNF refNF { get; set; }

        /// <summary>
        /// Chave de acesso do CT-e emitido pelo Tomador.
        /// </summary>
        /// <value>Chave de acesso do CT-e emitido pelo Tomador.</value>
        [DataMember(Name = "refCte", EmitDefaultValue = false)]
        public string refCte { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazTomaICMS {\n");
            sb.Append("  refNFe: ").Append(refNFe).Append("\n");
            sb.Append("  refNF: ").Append(refNF).Append("\n");
            sb.Append("  refCte: ").Append(refCte).Append("\n");
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
            return this.Equals(input as CteSefazTomaICMS);
        }

        /// <summary>
        /// Returns true if CteSefazTomaICMS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazTomaICMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazTomaICMS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.refNFe == input.refNFe ||
                    (this.refNFe != null &&
                    this.refNFe.Equals(input.refNFe))
                ) && 
                (
                    this.refNF == input.refNF ||
                    (this.refNF != null &&
                    this.refNF.Equals(input.refNF))
                ) && 
                (
                    this.refCte == input.refCte ||
                    (this.refCte != null &&
                    this.refCte.Equals(input.refCte))
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
                if (this.refNFe != null)
                {
                    hashCode = (hashCode * 59) + this.refNFe.GetHashCode();
                }
                if (this.refNF != null)
                {
                    hashCode = (hashCode * 59) + this.refNF.GetHashCode();
                }
                if (this.refCte != null)
                {
                    hashCode = (hashCode * 59) + this.refCte.GetHashCode();
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
