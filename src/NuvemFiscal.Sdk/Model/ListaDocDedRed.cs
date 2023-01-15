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
    /// Grupo de informações de documento utilizado para Dedução/Redução do valor do serviço.
    /// </summary>
    [DataContract(Name = "ListaDocDedRed")]
    public partial class ListaDocDedRed : IEquatable<ListaDocDedRed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaDocDedRed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListaDocDedRed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaDocDedRed" /> class.
        /// </summary>
        /// <param name="docDedRed">docDedRed (required).</param>
        public ListaDocDedRed(List<DocDedRed> docDedRed = default(List<DocDedRed>))
        {
            // to ensure "docDedRed" is required (not null)
            if (docDedRed == null)
            {
                throw new ArgumentNullException("docDedRed is a required property for ListaDocDedRed and cannot be null");
            }
            this.docDedRed = docDedRed;
        }

        /// <summary>
        /// Gets or Sets docDedRed
        /// </summary>
        [DataMember(Name = "docDedRed", IsRequired = true, EmitDefaultValue = true)]
        public List<DocDedRed> docDedRed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListaDocDedRed {\n");
            sb.Append("  docDedRed: ").Append(docDedRed).Append("\n");
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
            return this.Equals(input as ListaDocDedRed);
        }

        /// <summary>
        /// Returns true if ListaDocDedRed instances are equal
        /// </summary>
        /// <param name="input">Instance of ListaDocDedRed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaDocDedRed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.docDedRed == input.docDedRed ||
                    this.docDedRed != null &&
                    input.docDedRed != null &&
                    this.docDedRed.SequenceEqual(input.docDedRed)
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
                if (this.docDedRed != null)
                {
                    hashCode = (hashCode * 59) + this.docDedRed.GetHashCode();
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
