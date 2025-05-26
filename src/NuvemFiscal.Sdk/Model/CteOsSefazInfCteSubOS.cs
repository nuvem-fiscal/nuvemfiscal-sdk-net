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
    /// Informações do CT-e de substituição.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfCteSubOS")]
    public partial class CteOsSefazInfCteSubOS : IEquatable<CteOsSefazInfCteSubOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCteSubOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfCteSubOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCteSubOS" /> class.
        /// </summary>
        /// <param name="chCte">Chave de acesso do CT-e a ser substituído (original). (required).</param>
        public CteOsSefazInfCteSubOS(string chCte = default(string))
        {
            // to ensure "chCte" is required (not null)
            if (chCte == null)
            {
                throw new ArgumentNullException("chCte is a required property for CteOsSefazInfCteSubOS and cannot be null");
            }
            this.chCte = chCte;
        }

        /// <summary>
        /// Chave de acesso do CT-e a ser substituído (original).
        /// </summary>
        /// <value>Chave de acesso do CT-e a ser substituído (original).</value>
        [DataMember(Name = "chCte", IsRequired = true, EmitDefaultValue = true)]
        public string chCte { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfCteSubOS {\n");
            sb.Append("  chCte: ").Append(chCte).Append("\n");
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
            return this.Equals(input as CteOsSefazInfCteSubOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfCteSubOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfCteSubOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfCteSubOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCte == input.chCte ||
                    (this.chCte != null &&
                    this.chCte.Equals(input.chCte))
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
                if (this.chCte != null)
                {
                    hashCode = (hashCode * 59) + this.chCte.GetHashCode();
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
