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
        /// <param name="dPag">Data do Pagamento..</param>
        /// <param name="cNPJPag">CNPJ transacional do pagamento - Preencher informando o CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido quando a emissão do documento fiscal ocorrer em estabelecimento distinto..</param>
        /// <param name="uFPag">UF do CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido..</param>
        /// <param name="card">card.</param>
        public NfeSefazDetPag(int? indPag = default(int?), string tPag = default(string), string xPag = default(string), decimal? vPag = default(decimal?), DateTime? dPag = default(DateTime?), string cNPJPag = default(string), string uFPag = default(string), NfeSefazCard card = default(NfeSefazCard))
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
            this.dPag = dPag;
            this.CNPJPag = cNPJPag;
            this.UFPag = uFPag;
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
        /// Data do Pagamento.
        /// </summary>
        /// <value>Data do Pagamento.</value>
        [DataMember(Name = "dPag", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dPag { get; set; }

        /// <summary>
        /// CNPJ transacional do pagamento - Preencher informando o CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido quando a emissão do documento fiscal ocorrer em estabelecimento distinto.
        /// </summary>
        /// <value>CNPJ transacional do pagamento - Preencher informando o CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido quando a emissão do documento fiscal ocorrer em estabelecimento distinto.</value>
        [DataMember(Name = "CNPJPag", EmitDefaultValue = true)]
        public string CNPJPag { get; set; }

        /// <summary>
        /// UF do CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido.
        /// </summary>
        /// <value>UF do CNPJ do estabelecimento onde o pagamento foi processado/transacionado/recebido.</value>
        [DataMember(Name = "UFPag", EmitDefaultValue = true)]
        public string UFPag { get; set; }

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
            sb.Append("  dPag: ").Append(dPag).Append("\n");
            sb.Append("  CNPJPag: ").Append(CNPJPag).Append("\n");
            sb.Append("  UFPag: ").Append(UFPag).Append("\n");
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
                    this.dPag == input.dPag ||
                    (this.dPag != null &&
                    this.dPag.Equals(input.dPag))
                ) && 
                (
                    this.CNPJPag == input.CNPJPag ||
                    (this.CNPJPag != null &&
                    this.CNPJPag.Equals(input.CNPJPag))
                ) && 
                (
                    this.UFPag == input.UFPag ||
                    (this.UFPag != null &&
                    this.UFPag.Equals(input.UFPag))
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
                if (this.dPag != null)
                {
                    hashCode = (hashCode * 59) + this.dPag.GetHashCode();
                }
                if (this.CNPJPag != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJPag.GetHashCode();
                }
                if (this.UFPag != null)
                {
                    hashCode = (hashCode * 59) + this.UFPag.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // xPag (string) maxLength
            if (this.xPag != null && this.xPag.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xPag, length must be less than 60.", new [] { "xPag" });
            }

            // xPag (string) minLength
            if (this.xPag != null && this.xPag.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xPag, length must be greater than 2.", new [] { "xPag" });
            }

            // vPag (decimal?) minimum
            if (this.vPag < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vPag, must be a value greater than or equal to 0.", new [] { "vPag" });
            }

            // CNPJPag (string) maxLength
            if (this.CNPJPag != null && this.CNPJPag.Length > 14)
            {
                yield return new ValidationResult("Invalid value for CNPJPag, length must be less than 14.", new [] { "CNPJPag" });
            }

            yield break;
        }
    }

}
