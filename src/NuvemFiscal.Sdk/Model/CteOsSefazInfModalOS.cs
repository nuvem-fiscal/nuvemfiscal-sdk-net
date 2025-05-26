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
    /// Informações do modal  Obrigatório para Pessoas e Bagagem.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfModalOS")]
    public partial class CteOsSefazInfModalOS : IEquatable<CteOsSefazInfModalOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfModalOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfModalOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfModalOS" /> class.
        /// </summary>
        /// <param name="versaoModal">Versão do leiaute específico para o Modal. (required).</param>
        /// <param name="rodoOS">rodoOS.</param>
        public CteOsSefazInfModalOS(string versaoModal = default(string), CteOsSefazRodoOS rodoOS = default(CteOsSefazRodoOS))
        {
            // to ensure "versaoModal" is required (not null)
            if (versaoModal == null)
            {
                throw new ArgumentNullException("versaoModal is a required property for CteOsSefazInfModalOS and cannot be null");
            }
            this.versaoModal = versaoModal;
            this.rodoOS = rodoOS;
        }

        /// <summary>
        /// Versão do leiaute específico para o Modal.
        /// </summary>
        /// <value>Versão do leiaute específico para o Modal.</value>
        [DataMember(Name = "versaoModal", IsRequired = true, EmitDefaultValue = true)]
        public string versaoModal { get; set; }

        /// <summary>
        /// Gets or Sets rodoOS
        /// </summary>
        [DataMember(Name = "rodoOS", EmitDefaultValue = false)]
        public CteOsSefazRodoOS rodoOS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfModalOS {\n");
            sb.Append("  versaoModal: ").Append(versaoModal).Append("\n");
            sb.Append("  rodoOS: ").Append(rodoOS).Append("\n");
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
            return this.Equals(input as CteOsSefazInfModalOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfModalOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfModalOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfModalOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.versaoModal == input.versaoModal ||
                    (this.versaoModal != null &&
                    this.versaoModal.Equals(input.versaoModal))
                ) && 
                (
                    this.rodoOS == input.rodoOS ||
                    (this.rodoOS != null &&
                    this.rodoOS.Equals(input.rodoOS))
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
                if (this.versaoModal != null)
                {
                    hashCode = (hashCode * 59) + this.versaoModal.GetHashCode();
                }
                if (this.rodoOS != null)
                {
                    hashCode = (hashCode * 59) + this.rodoOS.GetHashCode();
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
