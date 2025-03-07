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
    /// EmailEvent
    /// </summary>
    [DataContract(Name = "EmailEvent")]
    public partial class EmailEvent : IEquatable<EmailEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="message">message.</param>
        public EmailEvent(string id = default(string), string eventType = default(string), DateTime timestamp = default(DateTime), string message = default(string))
        {
            this.id = id;
            this.event_type = eventType;
            this.timestamp = timestamp;
            this.message = message;
        }

        /// <summary>
        /// Gets or Sets id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets event_type
        /// </summary>
        [DataMember(Name = "event_type", EmitDefaultValue = false)]
        public string event_type { get; set; }

        /// <summary>
        /// Gets or Sets timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime timestamp { get; set; }

        /// <summary>
        /// Gets or Sets message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailEvent {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  event_type: ").Append(event_type).Append("\n");
            sb.Append("  timestamp: ").Append(timestamp).Append("\n");
            sb.Append("  message: ").Append(message).Append("\n");
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
            return this.Equals(input as EmailEvent);
        }

        /// <summary>
        /// Returns true if EmailEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.event_type == input.event_type ||
                    (this.event_type != null &&
                    this.event_type.Equals(input.event_type))
                ) && 
                (
                    this.timestamp == input.timestamp ||
                    (this.timestamp != null &&
                    this.timestamp.Equals(input.timestamp))
                ) && 
                (
                    this.message == input.message ||
                    (this.message != null &&
                    this.message.Equals(input.message))
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
                if (this.id != null)
                {
                    hashCode = (hashCode * 59) + this.id.GetHashCode();
                }
                if (this.event_type != null)
                {
                    hashCode = (hashCode * 59) + this.event_type.GetHashCode();
                }
                if (this.timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.timestamp.GetHashCode();
                }
                if (this.message != null)
                {
                    hashCode = (hashCode * 59) + this.message.GetHashCode();
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
