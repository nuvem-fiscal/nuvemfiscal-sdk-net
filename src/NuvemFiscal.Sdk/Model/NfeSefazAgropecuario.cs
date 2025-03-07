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
    /// Produtos Agropecurários Animais, Vegetais e Florestais.
    /// </summary>
    [DataContract(Name = "NfeSefazAgropecuario")]
    public partial class NfeSefazAgropecuario : IEquatable<NfeSefazAgropecuario>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazAgropecuario" /> class.
        /// </summary>
        /// <param name="defensivo">defensivo.</param>
        /// <param name="guiaTransito">guiaTransito.</param>
        public NfeSefazAgropecuario(NfeSefazDefensivo defensivo = default(NfeSefazDefensivo), NfeSefazGuiaTransito guiaTransito = default(NfeSefazGuiaTransito))
        {
            this.defensivo = defensivo;
            this.guiaTransito = guiaTransito;
        }

        /// <summary>
        /// Gets or Sets defensivo
        /// </summary>
        [DataMember(Name = "defensivo", EmitDefaultValue = false)]
        public NfeSefazDefensivo defensivo { get; set; }

        /// <summary>
        /// Gets or Sets guiaTransito
        /// </summary>
        [DataMember(Name = "guiaTransito", EmitDefaultValue = false)]
        public NfeSefazGuiaTransito guiaTransito { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazAgropecuario {\n");
            sb.Append("  defensivo: ").Append(defensivo).Append("\n");
            sb.Append("  guiaTransito: ").Append(guiaTransito).Append("\n");
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
            return this.Equals(input as NfeSefazAgropecuario);
        }

        /// <summary>
        /// Returns true if NfeSefazAgropecuario instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazAgropecuario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazAgropecuario input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.defensivo == input.defensivo ||
                    (this.defensivo != null &&
                    this.defensivo.Equals(input.defensivo))
                ) && 
                (
                    this.guiaTransito == input.guiaTransito ||
                    (this.guiaTransito != null &&
                    this.guiaTransito.Equals(input.guiaTransito))
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
                if (this.defensivo != null)
                {
                    hashCode = (hashCode * 59) + this.defensivo.GetHashCode();
                }
                if (this.guiaTransito != null)
                {
                    hashCode = (hashCode * 59) + this.guiaTransito.GetHashCode();
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
