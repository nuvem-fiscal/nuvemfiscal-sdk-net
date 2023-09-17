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
    /// Informações mais detalhadas do produto (usada na NFF).
    /// </summary>
    [DataContract(Name = "NfeSefazInfProdEmb")]
    public partial class NfeSefazInfProdEmb : IEquatable<NfeSefazInfProdEmb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfProdEmb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazInfProdEmb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfProdEmb" /> class.
        /// </summary>
        /// <param name="xEmb">Embalagem do produto. (required).</param>
        /// <param name="qVolEmb">Volume do produto na embalagem. (required).</param>
        /// <param name="uEmb">Unidade de Medida da Embalagem. (required).</param>
        public NfeSefazInfProdEmb(string xEmb = default(string), decimal? qVolEmb = default(decimal?), string uEmb = default(string))
        {
            // to ensure "xEmb" is required (not null)
            if (xEmb == null)
            {
                throw new ArgumentNullException("xEmb is a required property for NfeSefazInfProdEmb and cannot be null");
            }
            this.xEmb = xEmb;
            // to ensure "qVolEmb" is required (not null)
            if (qVolEmb == null)
            {
                throw new ArgumentNullException("qVolEmb is a required property for NfeSefazInfProdEmb and cannot be null");
            }
            this.qVolEmb = qVolEmb;
            // to ensure "uEmb" is required (not null)
            if (uEmb == null)
            {
                throw new ArgumentNullException("uEmb is a required property for NfeSefazInfProdEmb and cannot be null");
            }
            this.uEmb = uEmb;
        }

        /// <summary>
        /// Embalagem do produto.
        /// </summary>
        /// <value>Embalagem do produto.</value>
        [DataMember(Name = "xEmb", IsRequired = true, EmitDefaultValue = true)]
        public string xEmb { get; set; }

        /// <summary>
        /// Volume do produto na embalagem.
        /// </summary>
        /// <value>Volume do produto na embalagem.</value>
        [DataMember(Name = "qVolEmb", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qVolEmb { get; set; }

        /// <summary>
        /// Unidade de Medida da Embalagem.
        /// </summary>
        /// <value>Unidade de Medida da Embalagem.</value>
        [DataMember(Name = "uEmb", IsRequired = true, EmitDefaultValue = true)]
        public string uEmb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfProdEmb {\n");
            sb.Append("  xEmb: ").Append(xEmb).Append("\n");
            sb.Append("  qVolEmb: ").Append(qVolEmb).Append("\n");
            sb.Append("  uEmb: ").Append(uEmb).Append("\n");
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
            return this.Equals(input as NfeSefazInfProdEmb);
        }

        /// <summary>
        /// Returns true if NfeSefazInfProdEmb instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfProdEmb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfProdEmb input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xEmb == input.xEmb ||
                    (this.xEmb != null &&
                    this.xEmb.Equals(input.xEmb))
                ) && 
                (
                    this.qVolEmb == input.qVolEmb ||
                    (this.qVolEmb != null &&
                    this.qVolEmb.Equals(input.qVolEmb))
                ) && 
                (
                    this.uEmb == input.uEmb ||
                    (this.uEmb != null &&
                    this.uEmb.Equals(input.uEmb))
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
                if (this.xEmb != null)
                {
                    hashCode = (hashCode * 59) + this.xEmb.GetHashCode();
                }
                if (this.qVolEmb != null)
                {
                    hashCode = (hashCode * 59) + this.qVolEmb.GetHashCode();
                }
                if (this.uEmb != null)
                {
                    hashCode = (hashCode * 59) + this.uEmb.GetHashCode();
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
