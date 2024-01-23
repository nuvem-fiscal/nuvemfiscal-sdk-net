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
    /// Grupo de informações relativas à valores do serviço prestado.
    /// </summary>
    [DataContract(Name = "InfoValores")]
    public partial class InfoValores : IEquatable<InfoValores>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoValores" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoValores() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoValores" /> class.
        /// </summary>
        /// <param name="vServPrest">vServPrest (required).</param>
        /// <param name="vDescCondIncond">vDescCondIncond.</param>
        /// <param name="vDedRed">vDedRed.</param>
        /// <param name="trib">trib (required).</param>
        public InfoValores(VServPrest vServPrest = default(VServPrest), VDescCondIncond vDescCondIncond = default(VDescCondIncond), InfoDedRed vDedRed = default(InfoDedRed), InfoTributacao trib = default(InfoTributacao))
        {
            // to ensure "vServPrest" is required (not null)
            if (vServPrest == null)
            {
                throw new ArgumentNullException("vServPrest is a required property for InfoValores and cannot be null");
            }
            this.vServPrest = vServPrest;
            // to ensure "trib" is required (not null)
            if (trib == null)
            {
                throw new ArgumentNullException("trib is a required property for InfoValores and cannot be null");
            }
            this.trib = trib;
            this.vDescCondIncond = vDescCondIncond;
            this.vDedRed = vDedRed;
        }

        /// <summary>
        /// Gets or Sets vServPrest
        /// </summary>
        [DataMember(Name = "vServPrest", IsRequired = true, EmitDefaultValue = true)]
        public VServPrest vServPrest { get; set; }

        /// <summary>
        /// Gets or Sets vDescCondIncond
        /// </summary>
        [DataMember(Name = "vDescCondIncond", EmitDefaultValue = false)]
        public VDescCondIncond vDescCondIncond { get; set; }

        /// <summary>
        /// Gets or Sets vDedRed
        /// </summary>
        [DataMember(Name = "vDedRed", EmitDefaultValue = false)]
        public InfoDedRed vDedRed { get; set; }

        /// <summary>
        /// Gets or Sets trib
        /// </summary>
        [DataMember(Name = "trib", IsRequired = true, EmitDefaultValue = true)]
        public InfoTributacao trib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoValores {\n");
            sb.Append("  vServPrest: ").Append(vServPrest).Append("\n");
            sb.Append("  vDescCondIncond: ").Append(vDescCondIncond).Append("\n");
            sb.Append("  vDedRed: ").Append(vDedRed).Append("\n");
            sb.Append("  trib: ").Append(trib).Append("\n");
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
            return this.Equals(input as InfoValores);
        }

        /// <summary>
        /// Returns true if InfoValores instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoValores to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoValores input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vServPrest == input.vServPrest ||
                    (this.vServPrest != null &&
                    this.vServPrest.Equals(input.vServPrest))
                ) && 
                (
                    this.vDescCondIncond == input.vDescCondIncond ||
                    (this.vDescCondIncond != null &&
                    this.vDescCondIncond.Equals(input.vDescCondIncond))
                ) && 
                (
                    this.vDedRed == input.vDedRed ||
                    (this.vDedRed != null &&
                    this.vDedRed.Equals(input.vDedRed))
                ) && 
                (
                    this.trib == input.trib ||
                    (this.trib != null &&
                    this.trib.Equals(input.trib))
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
                if (this.vServPrest != null)
                {
                    hashCode = (hashCode * 59) + this.vServPrest.GetHashCode();
                }
                if (this.vDescCondIncond != null)
                {
                    hashCode = (hashCode * 59) + this.vDescCondIncond.GetHashCode();
                }
                if (this.vDedRed != null)
                {
                    hashCode = (hashCode * 59) + this.vDedRed.GetHashCode();
                }
                if (this.trib != null)
                {
                    hashCode = (hashCode * 59) + this.trib.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
