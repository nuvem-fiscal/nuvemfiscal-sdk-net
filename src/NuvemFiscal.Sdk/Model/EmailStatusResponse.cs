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
    /// EmailStatusResponse
    /// </summary>
    [DataContract(Name = "EmailStatusResponse")]
    public partial class EmailStatusResponse : IEquatable<EmailStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Sending for value: sending
            /// </summary>
            [EnumMember(Value = "sending")]
            Sending = 2,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 3,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 4,

            /// <summary>
            /// Enum DeliveryDelayed for value: delivery_delayed
            /// </summary>
            [EnumMember(Value = "delivery_delayed")]
            DeliveryDelayed = 5,

            /// <summary>
            /// Enum Bounced for value: bounced
            /// </summary>
            [EnumMember(Value = "bounced")]
            Bounced = 6,

            /// <summary>
            /// Enum Complained for value: complained
            /// </summary>
            [EnumMember(Value = "complained")]
            Complained = 7,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 8,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 9,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 10
        }


        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailStatusResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailStatusResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailStatusResponse" /> class.
        /// </summary>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes. (required).</param>
        /// <param name="status">status.</param>
        /// <param name="statusMessage">statusMessage.</param>
        public EmailStatusResponse(string id = default(string), StatusEnum? status = default(StatusEnum?), string statusMessage = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for EmailStatusResponse and cannot be null");
            }
            this.id = id;
            this.status = status;
            this.status_message = statusMessage;
        }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets status_message
        /// </summary>
        [DataMember(Name = "status_message", EmitDefaultValue = true)]
        public string status_message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailStatusResponse {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  status_message: ").Append(status_message).Append("\n");
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
            return this.Equals(input as EmailStatusResponse);
        }

        /// <summary>
        /// Returns true if EmailStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailStatusResponse input)
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
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.status_message == input.status_message ||
                    (this.status_message != null &&
                    this.status_message.Equals(input.status_message))
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
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.status_message != null)
                {
                    hashCode = (hashCode * 59) + this.status_message.GetHashCode();
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
