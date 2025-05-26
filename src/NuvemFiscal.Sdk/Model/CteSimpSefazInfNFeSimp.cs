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
    /// Informações das NF-e.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfNFeSimp")]
    public partial class CteSimpSefazInfNFeSimp : IEquatable<CteSimpSefazInfNFeSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfNFeSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazInfNFeSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfNFeSimp" /> class.
        /// </summary>
        /// <param name="chNFe">Chave de acesso da NF-e. (required).</param>
        /// <param name="pIN">PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação..</param>
        /// <param name="dPrev">Data prevista de entrega.  Formato AAAA-MM-DD..</param>
        /// <param name="infUnidCarga">infUnidCarga.</param>
        /// <param name="infUnidTransp">infUnidTransp.</param>
        public CteSimpSefazInfNFeSimp(string chNFe = default(string), string pIN = default(string), DateTime? dPrev = default(DateTime?), List<CteSimpSefazUnidCargaSimp> infUnidCarga = default(List<CteSimpSefazUnidCargaSimp>), List<CteSimpSefazUnidadeTranspSimp> infUnidTransp = default(List<CteSimpSefazUnidadeTranspSimp>))
        {
            // to ensure "chNFe" is required (not null)
            if (chNFe == null)
            {
                throw new ArgumentNullException("chNFe is a required property for CteSimpSefazInfNFeSimp and cannot be null");
            }
            this.chNFe = chNFe;
            this.PIN = pIN;
            this.dPrev = dPrev;
            this.infUnidCarga = infUnidCarga;
            this.infUnidTransp = infUnidTransp;
        }

        /// <summary>
        /// Chave de acesso da NF-e.
        /// </summary>
        /// <value>Chave de acesso da NF-e.</value>
        [DataMember(Name = "chNFe", IsRequired = true, EmitDefaultValue = true)]
        public string chNFe { get; set; }

        /// <summary>
        /// PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação.
        /// </summary>
        /// <value>PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação.</value>
        [DataMember(Name = "PIN", EmitDefaultValue = true)]
        public string PIN { get; set; }

        /// <summary>
        /// Data prevista de entrega.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data prevista de entrega.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dPrev", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dPrev { get; set; }

        /// <summary>
        /// Gets or Sets infUnidCarga
        /// </summary>
        [DataMember(Name = "infUnidCarga", EmitDefaultValue = false)]
        public List<CteSimpSefazUnidCargaSimp> infUnidCarga { get; set; }

        /// <summary>
        /// Gets or Sets infUnidTransp
        /// </summary>
        [DataMember(Name = "infUnidTransp", EmitDefaultValue = false)]
        public List<CteSimpSefazUnidadeTranspSimp> infUnidTransp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfNFeSimp {\n");
            sb.Append("  chNFe: ").Append(chNFe).Append("\n");
            sb.Append("  PIN: ").Append(PIN).Append("\n");
            sb.Append("  dPrev: ").Append(dPrev).Append("\n");
            sb.Append("  infUnidCarga: ").Append(infUnidCarga).Append("\n");
            sb.Append("  infUnidTransp: ").Append(infUnidTransp).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfNFeSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfNFeSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfNFeSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfNFeSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chNFe == input.chNFe ||
                    (this.chNFe != null &&
                    this.chNFe.Equals(input.chNFe))
                ) && 
                (
                    this.PIN == input.PIN ||
                    (this.PIN != null &&
                    this.PIN.Equals(input.PIN))
                ) && 
                (
                    this.dPrev == input.dPrev ||
                    (this.dPrev != null &&
                    this.dPrev.Equals(input.dPrev))
                ) && 
                (
                    this.infUnidCarga == input.infUnidCarga ||
                    this.infUnidCarga != null &&
                    input.infUnidCarga != null &&
                    this.infUnidCarga.SequenceEqual(input.infUnidCarga)
                ) && 
                (
                    this.infUnidTransp == input.infUnidTransp ||
                    this.infUnidTransp != null &&
                    input.infUnidTransp != null &&
                    this.infUnidTransp.SequenceEqual(input.infUnidTransp)
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
                if (this.chNFe != null)
                {
                    hashCode = (hashCode * 59) + this.chNFe.GetHashCode();
                }
                if (this.PIN != null)
                {
                    hashCode = (hashCode * 59) + this.PIN.GetHashCode();
                }
                if (this.dPrev != null)
                {
                    hashCode = (hashCode * 59) + this.dPrev.GetHashCode();
                }
                if (this.infUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidCarga.GetHashCode();
                }
                if (this.infUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidTransp.GetHashCode();
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
            // chNFe (string) maxLength
            if (this.chNFe != null && this.chNFe.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chNFe, length must be less than 44.", new [] { "chNFe" });
            }

            // PIN (string) maxLength
            if (this.PIN != null && this.PIN.Length > 9)
            {
                yield return new ValidationResult("Invalid value for PIN, length must be less than 9.", new [] { "PIN" });
            }

            // PIN (string) minLength
            if (this.PIN != null && this.PIN.Length < 2)
            {
                yield return new ValidationResult("Invalid value for PIN, length must be greater than 2.", new [] { "PIN" });
            }

            yield break;
        }
    }

}
