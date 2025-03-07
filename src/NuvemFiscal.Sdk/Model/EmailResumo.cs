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
    /// EmailResumo
    /// </summary>
    [DataContract(Name = "EmailResumo")]
    public partial class EmailResumo : IEquatable<EmailResumo>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="EmailResumo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailResumo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailResumo" /> class.
        /// </summary>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes. (required).</param>
        /// <param name="status">status.</param>
        /// <param name="sentAt">sentAt.</param>
        /// <param name="recipients">recipients.</param>
        /// <param name="subject">subject.</param>
        public EmailResumo(string id = default(string), StatusEnum? status = default(StatusEnum?), DateTime? sentAt = default(DateTime?), List<string> recipients = default(List<string>), string subject = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for EmailResumo and cannot be null");
            }
            this.id = id;
            this.status = status;
            this.sent_at = sentAt;
            this.recipients = recipients;
            this.subject = subject;
        }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para este email.    Utilize-o no endpoint de &lt;a href&#x3D;\&quot;#tag/Email/operation/ConsultarEmail\&quot;&gt;consulta de email&lt;/a&gt;  para obter informações detalhadas sobre o envio do email e  rastrear todos os eventos relacionados, como envio, entrega, falhas e outros  eventos relevantes.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string id { get; set; }

        /// <summary>
        /// Gets or Sets sent_at
        /// </summary>
        [DataMember(Name = "sent_at", EmitDefaultValue = true)]
        public DateTime? sent_at { get; set; }

        /// <summary>
        /// Gets or Sets recipients
        /// </summary>
        [DataMember(Name = "recipients", EmitDefaultValue = false)]
        public List<string> recipients { get; set; }

        /// <summary>
        /// Gets or Sets subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailResumo {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  sent_at: ").Append(sent_at).Append("\n");
            sb.Append("  recipients: ").Append(recipients).Append("\n");
            sb.Append("  subject: ").Append(subject).Append("\n");
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
            return this.Equals(input as EmailResumo);
        }

        /// <summary>
        /// Returns true if EmailResumo instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailResumo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailResumo input)
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
                    this.sent_at == input.sent_at ||
                    (this.sent_at != null &&
                    this.sent_at.Equals(input.sent_at))
                ) && 
                (
                    this.recipients == input.recipients ||
                    this.recipients != null &&
                    input.recipients != null &&
                    this.recipients.SequenceEqual(input.recipients)
                ) && 
                (
                    this.subject == input.subject ||
                    (this.subject != null &&
                    this.subject.Equals(input.subject))
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
                if (this.sent_at != null)
                {
                    hashCode = (hashCode * 59) + this.sent_at.GetHashCode();
                }
                if (this.recipients != null)
                {
                    hashCode = (hashCode * 59) + this.recipients.GetHashCode();
                }
                if (this.subject != null)
                {
                    hashCode = (hashCode * 59) + this.subject.GetHashCode();
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
