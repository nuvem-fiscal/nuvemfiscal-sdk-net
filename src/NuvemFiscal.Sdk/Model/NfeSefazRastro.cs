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
    /// NfeSefazRastro
    /// </summary>
    [DataContract(Name = "NfeSefazRastro")]
    public partial class NfeSefazRastro : IEquatable<NfeSefazRastro>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRastro" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazRastro() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRastro" /> class.
        /// </summary>
        /// <param name="nLote">Número do lote do produto. (required).</param>
        /// <param name="qLote">Quantidade de produto no lote. (required).</param>
        /// <param name="dFab">Data de fabricação/produção. Formato \&quot;AAAA-MM-DD\&quot;. (required).</param>
        /// <param name="dVal">Data de validade. Informar o último dia do mês caso a validade não especifique o dia. Formato \&quot;AAAA-MM-DD\&quot;. (required).</param>
        /// <param name="cAgreg">cAgreg.</param>
        public NfeSefazRastro(string nLote = default(string), decimal qLote = default(decimal), DateTime dFab = default(DateTime), DateTime dVal = default(DateTime), string cAgreg = default(string))
        {
            // to ensure "nLote" is required (not null)
            if (nLote == null)
            {
                throw new ArgumentNullException("nLote is a required property for NfeSefazRastro and cannot be null");
            }
            this.nLote = nLote;
            this.qLote = qLote;
            this.dFab = dFab;
            this.dVal = dVal;
            this.cAgreg = cAgreg;
        }

        /// <summary>
        /// Número do lote do produto.
        /// </summary>
        /// <value>Número do lote do produto.</value>
        [DataMember(Name = "nLote", IsRequired = true, EmitDefaultValue = false)]
        public string nLote { get; set; }

        /// <summary>
        /// Quantidade de produto no lote.
        /// </summary>
        /// <value>Quantidade de produto no lote.</value>
        [DataMember(Name = "qLote", IsRequired = true, EmitDefaultValue = false)]
        public decimal qLote { get; set; }

        /// <summary>
        /// Data de fabricação/produção. Formato \&quot;AAAA-MM-DD\&quot;.
        /// </summary>
        /// <value>Data de fabricação/produção. Formato \&quot;AAAA-MM-DD\&quot;.</value>
        [DataMember(Name = "dFab", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dFab { get; set; }

        /// <summary>
        /// Data de validade. Informar o último dia do mês caso a validade não especifique o dia. Formato \&quot;AAAA-MM-DD\&quot;.
        /// </summary>
        /// <value>Data de validade. Informar o último dia do mês caso a validade não especifique o dia. Formato \&quot;AAAA-MM-DD\&quot;.</value>
        [DataMember(Name = "dVal", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dVal { get; set; }

        /// <summary>
        /// Gets or Sets cAgreg
        /// </summary>
        [DataMember(Name = "cAgreg", EmitDefaultValue = false)]
        public string cAgreg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRastro {\n");
            sb.Append("  nLote: ").Append(nLote).Append("\n");
            sb.Append("  qLote: ").Append(qLote).Append("\n");
            sb.Append("  dFab: ").Append(dFab).Append("\n");
            sb.Append("  dVal: ").Append(dVal).Append("\n");
            sb.Append("  cAgreg: ").Append(cAgreg).Append("\n");
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
            return this.Equals(input as NfeSefazRastro);
        }

        /// <summary>
        /// Returns true if NfeSefazRastro instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRastro to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRastro input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nLote == input.nLote ||
                    (this.nLote != null &&
                    this.nLote.Equals(input.nLote))
                ) && 
                (
                    this.qLote == input.qLote ||
                    this.qLote.Equals(input.qLote)
                ) && 
                (
                    this.dFab == input.dFab ||
                    (this.dFab != null &&
                    this.dFab.Equals(input.dFab))
                ) && 
                (
                    this.dVal == input.dVal ||
                    (this.dVal != null &&
                    this.dVal.Equals(input.dVal))
                ) && 
                (
                    this.cAgreg == input.cAgreg ||
                    (this.cAgreg != null &&
                    this.cAgreg.Equals(input.cAgreg))
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
                if (this.nLote != null)
                {
                    hashCode = (hashCode * 59) + this.nLote.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.qLote.GetHashCode();
                if (this.dFab != null)
                {
                    hashCode = (hashCode * 59) + this.dFab.GetHashCode();
                }
                if (this.dVal != null)
                {
                    hashCode = (hashCode * 59) + this.dVal.GetHashCode();
                }
                if (this.cAgreg != null)
                {
                    hashCode = (hashCode * 59) + this.cAgreg.GetHashCode();
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
