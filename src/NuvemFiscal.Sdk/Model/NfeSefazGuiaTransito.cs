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
    /// Guias De Trânsito de produtos agropecurários animais, vegetais e de origem florestal.
    /// </summary>
    [DataContract(Name = "NfeSefazGuiaTransito")]
    public partial class NfeSefazGuiaTransito : IEquatable<NfeSefazGuiaTransito>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGuiaTransito" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGuiaTransito() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGuiaTransito" /> class.
        /// </summary>
        /// <param name="tpGuia">Tipo da Guia: 1 - GTA; 2 - TTA; 3 - DTA; 4 - ATV; 5 - PTV; 6 - GTV; 7 - Guia Florestal (DOF, SisFlora - PA e MT, SIAM - MG). (required).</param>
        /// <param name="uFGuia">uFGuia.</param>
        /// <param name="serieGuia">Série da Guia..</param>
        /// <param name="nGuia">Número da Guia. (required).</param>
        public NfeSefazGuiaTransito(int? tpGuia = default(int?), string uFGuia = default(string), string serieGuia = default(string), string nGuia = default(string))
        {
            // to ensure "tpGuia" is required (not null)
            if (tpGuia == null)
            {
                throw new ArgumentNullException("tpGuia is a required property for NfeSefazGuiaTransito and cannot be null");
            }
            this.tpGuia = tpGuia;
            // to ensure "nGuia" is required (not null)
            if (nGuia == null)
            {
                throw new ArgumentNullException("nGuia is a required property for NfeSefazGuiaTransito and cannot be null");
            }
            this.nGuia = nGuia;
            this.UFGuia = uFGuia;
            this.serieGuia = serieGuia;
        }

        /// <summary>
        /// Tipo da Guia: 1 - GTA; 2 - TTA; 3 - DTA; 4 - ATV; 5 - PTV; 6 - GTV; 7 - Guia Florestal (DOF, SisFlora - PA e MT, SIAM - MG).
        /// </summary>
        /// <value>Tipo da Guia: 1 - GTA; 2 - TTA; 3 - DTA; 4 - ATV; 5 - PTV; 6 - GTV; 7 - Guia Florestal (DOF, SisFlora - PA e MT, SIAM - MG).</value>
        [DataMember(Name = "tpGuia", IsRequired = true, EmitDefaultValue = true)]
        public int? tpGuia { get; set; }

        /// <summary>
        /// Gets or Sets UFGuia
        /// </summary>
        [DataMember(Name = "UFGuia", EmitDefaultValue = true)]
        public string UFGuia { get; set; }

        /// <summary>
        /// Série da Guia.
        /// </summary>
        /// <value>Série da Guia.</value>
        [DataMember(Name = "serieGuia", EmitDefaultValue = true)]
        public string serieGuia { get; set; }

        /// <summary>
        /// Número da Guia.
        /// </summary>
        /// <value>Número da Guia.</value>
        [DataMember(Name = "nGuia", IsRequired = true, EmitDefaultValue = true)]
        public string nGuia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGuiaTransito {\n");
            sb.Append("  tpGuia: ").Append(tpGuia).Append("\n");
            sb.Append("  UFGuia: ").Append(UFGuia).Append("\n");
            sb.Append("  serieGuia: ").Append(serieGuia).Append("\n");
            sb.Append("  nGuia: ").Append(nGuia).Append("\n");
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
            return this.Equals(input as NfeSefazGuiaTransito);
        }

        /// <summary>
        /// Returns true if NfeSefazGuiaTransito instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGuiaTransito to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGuiaTransito input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpGuia == input.tpGuia ||
                    (this.tpGuia != null &&
                    this.tpGuia.Equals(input.tpGuia))
                ) && 
                (
                    this.UFGuia == input.UFGuia ||
                    (this.UFGuia != null &&
                    this.UFGuia.Equals(input.UFGuia))
                ) && 
                (
                    this.serieGuia == input.serieGuia ||
                    (this.serieGuia != null &&
                    this.serieGuia.Equals(input.serieGuia))
                ) && 
                (
                    this.nGuia == input.nGuia ||
                    (this.nGuia != null &&
                    this.nGuia.Equals(input.nGuia))
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
                if (this.tpGuia != null)
                {
                    hashCode = (hashCode * 59) + this.tpGuia.GetHashCode();
                }
                if (this.UFGuia != null)
                {
                    hashCode = (hashCode * 59) + this.UFGuia.GetHashCode();
                }
                if (this.serieGuia != null)
                {
                    hashCode = (hashCode * 59) + this.serieGuia.GetHashCode();
                }
                if (this.nGuia != null)
                {
                    hashCode = (hashCode * 59) + this.nGuia.GetHashCode();
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
            // serieGuia (string) maxLength
            if (this.serieGuia != null && this.serieGuia.Length > 9)
            {
                yield return new ValidationResult("Invalid value for serieGuia, length must be less than 9.", new [] { "serieGuia" });
            }

            // serieGuia (string) minLength
            if (this.serieGuia != null && this.serieGuia.Length < 1)
            {
                yield return new ValidationResult("Invalid value for serieGuia, length must be greater than 1.", new [] { "serieGuia" });
            }

            yield break;
        }
    }

}
