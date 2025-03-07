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
    /// EnderecoEmail
    /// </summary>
    [DataContract(Name = "EnderecoEmail")]
    public partial class EnderecoEmail : IEquatable<EnderecoEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnderecoEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoEmail" /> class.
        /// </summary>
        /// <param name="email">Email do destinatário. (required).</param>
        public EnderecoEmail(string email = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for EnderecoEmail and cannot be null");
            }
            this.email = email;
        }

        /// <summary>
        /// Email do destinatário.
        /// </summary>
        /// <value>Email do destinatário.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnderecoEmail {\n");
            sb.Append("  email: ").Append(email).Append("\n");
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
            return this.Equals(input as EnderecoEmail);
        }

        /// <summary>
        /// Returns true if EnderecoEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of EnderecoEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoEmail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
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
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
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
