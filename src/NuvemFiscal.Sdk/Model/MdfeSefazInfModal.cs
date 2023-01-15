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
    /// Informações do modal.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfModal")]
    public partial class MdfeSefazInfModal : IEquatable<MdfeSefazInfModal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfModal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfModal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfModal" /> class.
        /// </summary>
        /// <param name="versaoModal">Versão do leiaute específico para o Modal. (required).</param>
        /// <param name="aereo">aereo.</param>
        /// <param name="rodo">rodo.</param>
        /// <param name="aquav">aquav.</param>
        /// <param name="ferrov">ferrov.</param>
        public MdfeSefazInfModal(string versaoModal = default(string), MdfeSefazAereo aereo = default(MdfeSefazAereo), MdfeSefazRodo rodo = default(MdfeSefazRodo), MdfeSefazAquav aquav = default(MdfeSefazAquav), MdfeSefazFerrov ferrov = default(MdfeSefazFerrov))
        {
            // to ensure "versaoModal" is required (not null)
            if (versaoModal == null)
            {
                throw new ArgumentNullException("versaoModal is a required property for MdfeSefazInfModal and cannot be null");
            }
            this.versaoModal = versaoModal;
            this.aereo = aereo;
            this.rodo = rodo;
            this.aquav = aquav;
            this.ferrov = ferrov;
        }

        /// <summary>
        /// Versão do leiaute específico para o Modal.
        /// </summary>
        /// <value>Versão do leiaute específico para o Modal.</value>
        [DataMember(Name = "versaoModal", IsRequired = true, EmitDefaultValue = true)]
        public string versaoModal { get; set; }

        /// <summary>
        /// Gets or Sets aereo
        /// </summary>
        [DataMember(Name = "aereo", EmitDefaultValue = false)]
        public MdfeSefazAereo aereo { get; set; }

        /// <summary>
        /// Gets or Sets rodo
        /// </summary>
        [DataMember(Name = "rodo", EmitDefaultValue = false)]
        public MdfeSefazRodo rodo { get; set; }

        /// <summary>
        /// Gets or Sets aquav
        /// </summary>
        [DataMember(Name = "aquav", EmitDefaultValue = false)]
        public MdfeSefazAquav aquav { get; set; }

        /// <summary>
        /// Gets or Sets ferrov
        /// </summary>
        [DataMember(Name = "ferrov", EmitDefaultValue = false)]
        public MdfeSefazFerrov ferrov { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfModal {\n");
            sb.Append("  versaoModal: ").Append(versaoModal).Append("\n");
            sb.Append("  aereo: ").Append(aereo).Append("\n");
            sb.Append("  rodo: ").Append(rodo).Append("\n");
            sb.Append("  aquav: ").Append(aquav).Append("\n");
            sb.Append("  ferrov: ").Append(ferrov).Append("\n");
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
            return this.Equals(input as MdfeSefazInfModal);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfModal instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfModal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfModal input)
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
                    this.aereo == input.aereo ||
                    (this.aereo != null &&
                    this.aereo.Equals(input.aereo))
                ) && 
                (
                    this.rodo == input.rodo ||
                    (this.rodo != null &&
                    this.rodo.Equals(input.rodo))
                ) && 
                (
                    this.aquav == input.aquav ||
                    (this.aquav != null &&
                    this.aquav.Equals(input.aquav))
                ) && 
                (
                    this.ferrov == input.ferrov ||
                    (this.ferrov != null &&
                    this.ferrov.Equals(input.ferrov))
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
                if (this.aereo != null)
                {
                    hashCode = (hashCode * 59) + this.aereo.GetHashCode();
                }
                if (this.rodo != null)
                {
                    hashCode = (hashCode * 59) + this.rodo.GetHashCode();
                }
                if (this.aquav != null)
                {
                    hashCode = (hashCode * 59) + this.aquav.GetHashCode();
                }
                if (this.ferrov != null)
                {
                    hashCode = (hashCode * 59) + this.ferrov.GetHashCode();
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
