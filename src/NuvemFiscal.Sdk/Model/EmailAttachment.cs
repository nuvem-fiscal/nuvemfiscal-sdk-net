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
    /// EmailAttachment
    /// </summary>
    [DataContract(Name = "EmailAttachment")]
    public partial class EmailAttachment : IEquatable<EmailAttachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAttachment" /> class.
        /// </summary>
        /// <param name="contentType">contentType.</param>
        /// <param name="filename">filename.</param>
        public EmailAttachment(string contentType = default(string), string filename = default(string))
        {
            this.content_type = contentType;
            this.filename = filename;
        }

        /// <summary>
        /// Gets or Sets content_type
        /// </summary>
        [DataMember(Name = "content_type", EmitDefaultValue = false)]
        public string content_type { get; set; }

        /// <summary>
        /// Gets or Sets filename
        /// </summary>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string filename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailAttachment {\n");
            sb.Append("  content_type: ").Append(content_type).Append("\n");
            sb.Append("  filename: ").Append(filename).Append("\n");
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
            return this.Equals(input as EmailAttachment);
        }

        /// <summary>
        /// Returns true if EmailAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailAttachment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.content_type == input.content_type ||
                    (this.content_type != null &&
                    this.content_type.Equals(input.content_type))
                ) && 
                (
                    this.filename == input.filename ||
                    (this.filename != null &&
                    this.filename.Equals(input.filename))
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
                if (this.content_type != null)
                {
                    hashCode = (hashCode * 59) + this.content_type.GetHashCode();
                }
                if (this.filename != null)
                {
                    hashCode = (hashCode * 59) + this.filename.GetHashCode();
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
            // content_type (string) maxLength
            if (this.content_type != null && this.content_type.Length > 100)
            {
                yield return new ValidationResult("Invalid value for content_type, length must be less than 100.", new [] { "content_type" });
            }

            yield break;
        }
    }

}
