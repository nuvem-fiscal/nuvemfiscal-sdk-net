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
    /// NfseSincronizacao
    /// </summary>
    [DataContract(Name = "NfseSincronizacao")]
    public partial class NfseSincronizacao : IEquatable<NfseSincronizacao>, IValidatableObject
    {
        /// <summary>
        /// Situação atual da sincronização.
        /// </summary>
        /// <value>Situação atual da sincronização.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pendente for value: pendente
            /// </summary>
            [EnumMember(Value = "pendente")]
            Pendente = 1,

            /// <summary>
            /// Enum Sincronizado for value: sincronizado
            /// </summary>
            [EnumMember(Value = "sincronizado")]
            Sincronizado = 2

        }


        /// <summary>
        /// Situação atual da sincronização.
        /// </summary>
        /// <value>Situação atual da sincronização.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfseSincronizacao" /> class.
        /// </summary>
        /// <param name="status">Situação atual da sincronização..</param>
        public NfseSincronizacao(StatusEnum? status = default(StatusEnum?))
        {
            this.status = status;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfseSincronizacao {\n");
            sb.Append("  status: ").Append(status).Append("\n");
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
            return this.Equals(input as NfseSincronizacao);
        }

        /// <summary>
        /// Returns true if NfseSincronizacao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfseSincronizacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfseSincronizacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
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
                hashCode = (hashCode * 59) + this.status.GetHashCode();
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
