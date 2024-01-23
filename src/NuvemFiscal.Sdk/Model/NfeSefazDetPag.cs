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
    /// Grupo de detalhamento da forma de pagamento.
    /// </summary>
    [DataContract(Name = "NfeSefazDetPag")]
    public partial class NfeSefazDetPag : IEquatable<NfeSefazDetPag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDetPag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDetPag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDetPag" /> class.
        /// </summary>
        /// <param name="indPag">Indicador da Forma de Pagamento:0-Pagamento à Vista  * 1 - Pagamento à Prazo.</param>
        /// <param name="tPag">Forma de Pagamento:. (required).</param>
        /// <param name="xPag">Descrição do Meio de Pagamento..</param>
        /// <param name="vPag">Valor do Pagamento. Esta tag poderá ser omitida quando a tag tPag&#x3D;90 (Sem Pagamento), caso contrário deverá ser preenchida. (required).</param>
        /// <param name="card">card.</param>
        public NfeSefazDetPag(int? indPag = default(int?), string tPag = default(string), string xPag = default(string), decimal? vPag = default(decimal?), NfeSefazCard card = default(NfeSefazCard))
        {
            // to ensure "tPag" is required (not null)
            if (tPag == null)
            {
                throw new ArgumentNullException("tPag is a required property for NfeSefazDetPag and cannot be null");
            }
            this.tPag = tPag;
            // to ensure "vPag" is required (not null)
            if (vPag == null)
            {
                throw new ArgumentNullException("vPag is a required property for NfeSefazDetPag and cannot be null");
            }
            this.vPag = vPag;
            this.indPag = indPag;
            this.xPag = xPag;
            this.card = card;
        }

        /// <summary>
        /// Indicador da Forma de Pagamento:0-Pagamento à Vista  * 1 - Pagamento à Prazo
        /// </summary>
        /// <value>Indicador da Forma de Pagamento:0-Pagamento à Vista  * 1 - Pagamento à Prazo</value>
        [DataMember(Name = "indPag", EmitDefaultValue = true)]
        public int? indPag { get; set; }

        /// <summary>
        /// Forma de Pagamento:.
        /// </summary>
        /// <value>Forma de Pagamento:.</value>
        [DataMember(Name = "tPag", IsRequired = true, EmitDefaultValue = true)]
        public string tPag { get; set; }

        /// <summary>
        /// Descrição do Meio de Pagamento.
        /// </summary>
        /// <value>Descrição do Meio de Pagamento.</value>
        [DataMember(Name = "xPag", EmitDefaultValue = true)]
        public string xPag { get; set; }

        /// <summary>
        /// Valor do Pagamento. Esta tag poderá ser omitida quando a tag tPag&#x3D;90 (Sem Pagamento), caso contrário deverá ser preenchida.
        /// </summary>
        /// <value>Valor do Pagamento. Esta tag poderá ser omitida quando a tag tPag&#x3D;90 (Sem Pagamento), caso contrário deverá ser preenchida.</value>
        [DataMember(Name = "vPag", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPag { get; set; }

        /// <summary>
        /// Gets or Sets card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public NfeSefazCard card { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDetPag {\n");
            sb.Append("  indPag: ").Append(indPag).Append("\n");
            sb.Append("  tPag: ").Append(tPag).Append("\n");
            sb.Append("  xPag: ").Append(xPag).Append("\n");
            sb.Append("  vPag: ").Append(vPag).Append("\n");
            sb.Append("  card: ").Append(card).Append("\n");
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
            return this.Equals(input as NfeSefazDetPag);
        }

        /// <summary>
        /// Returns true if NfeSefazDetPag instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDetPag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDetPag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.indPag == input.indPag ||
                    (this.indPag != null &&
                    this.indPag.Equals(input.indPag))
                ) && 
                (
                    this.tPag == input.tPag ||
                    (this.tPag != null &&
                    this.tPag.Equals(input.tPag))
                ) && 
                (
                    this.xPag == input.xPag ||
                    (this.xPag != null &&
                    this.xPag.Equals(input.xPag))
                ) && 
                (
                    this.vPag == input.vPag ||
                    (this.vPag != null &&
                    this.vPag.Equals(input.vPag))
                ) && 
                (
                    this.card == input.card ||
                    (this.card != null &&
                    this.card.Equals(input.card))
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
                if (this.indPag != null)
                {
                    hashCode = (hashCode * 59) + this.indPag.GetHashCode();
                }
                if (this.tPag != null)
                {
                    hashCode = (hashCode * 59) + this.tPag.GetHashCode();
                }
                if (this.xPag != null)
                {
                    hashCode = (hashCode * 59) + this.xPag.GetHashCode();
                }
                if (this.vPag != null)
                {
                    hashCode = (hashCode * 59) + this.vPag.GetHashCode();
                }
                if (this.card != null)
                {
                    hashCode = (hashCode * 59) + this.card.GetHashCode();
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
            // xPag (string) maxLength
            if (this.xPag != null && this.xPag.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xPag, length must be less than 60.", new [] { "xPag" });
            }

            // xPag (string) minLength
            if (this.xPag != null && this.xPag.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xPag, length must be greater than 2.", new [] { "xPag" });
            }

            yield break;
        }
    }

}
