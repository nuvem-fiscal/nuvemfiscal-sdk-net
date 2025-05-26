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
    /// CteSimpSefazPassSimp
    /// </summary>
    [DataContract(Name = "CteSimpSefazPassSimp")]
    public partial class CteSimpSefazPassSimp : IEquatable<CteSimpSefazPassSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazPassSimp" /> class.
        /// </summary>
        /// <param name="xPass">Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Passagem.  Observação para o modal aéreo:  * O código de três letras IATA, referente ao aeroporto de transferência, deverá ser incluído, quando for o caso. Quando não for possível,  utilizar a sigla OACI. Qualquer solicitação de itinerário deverá ser incluída..</param>
        public CteSimpSefazPassSimp(string xPass = default(string))
        {
            this.xPass = xPass;
        }

        /// <summary>
        /// Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Passagem.  Observação para o modal aéreo:  * O código de três letras IATA, referente ao aeroporto de transferência, deverá ser incluído, quando for o caso. Quando não for possível,  utilizar a sigla OACI. Qualquer solicitação de itinerário deverá ser incluída.
        /// </summary>
        /// <value>Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Passagem.  Observação para o modal aéreo:  * O código de três letras IATA, referente ao aeroporto de transferência, deverá ser incluído, quando for o caso. Quando não for possível,  utilizar a sigla OACI. Qualquer solicitação de itinerário deverá ser incluída.</value>
        [DataMember(Name = "xPass", EmitDefaultValue = true)]
        public string xPass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazPassSimp {\n");
            sb.Append("  xPass: ").Append(xPass).Append("\n");
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
            return this.Equals(input as CteSimpSefazPassSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazPassSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazPassSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazPassSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xPass == input.xPass ||
                    (this.xPass != null &&
                    this.xPass.Equals(input.xPass))
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
                if (this.xPass != null)
                {
                    hashCode = (hashCode * 59) + this.xPass.GetHashCode();
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
            // xPass (string) maxLength
            if (this.xPass != null && this.xPass.Length > 15)
            {
                yield return new ValidationResult("Invalid value for xPass, length must be less than 15.", new [] { "xPass" });
            }

            // xPass (string) minLength
            if (this.xPass != null && this.xPass.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xPass, length must be greater than 1.", new [] { "xPass" });
            }

            yield break;
        }
    }

}
