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
    /// Fornecimentos diários.
    /// </summary>
    [DataContract(Name = "NfeSefazForDia")]
    public partial class NfeSefazForDia : IEquatable<NfeSefazForDia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazForDia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazForDia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazForDia" /> class.
        /// </summary>
        /// <param name="dia">Número do dia. (required).</param>
        /// <param name="qtde">Quantidade em quilogramas - peso líquido. (required).</param>
        public NfeSefazForDia(int? dia = default(int?), decimal? qtde = default(decimal?))
        {
            // to ensure "dia" is required (not null)
            if (dia == null)
            {
                throw new ArgumentNullException("dia is a required property for NfeSefazForDia and cannot be null");
            }
            this.dia = dia;
            // to ensure "qtde" is required (not null)
            if (qtde == null)
            {
                throw new ArgumentNullException("qtde is a required property for NfeSefazForDia and cannot be null");
            }
            this.qtde = qtde;
        }

        /// <summary>
        /// Número do dia.
        /// </summary>
        /// <value>Número do dia.</value>
        [DataMember(Name = "dia", IsRequired = true, EmitDefaultValue = true)]
        public int? dia { get; set; }

        /// <summary>
        /// Quantidade em quilogramas - peso líquido.
        /// </summary>
        /// <value>Quantidade em quilogramas - peso líquido.</value>
        [DataMember(Name = "qtde", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qtde { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazForDia {\n");
            sb.Append("  dia: ").Append(dia).Append("\n");
            sb.Append("  qtde: ").Append(qtde).Append("\n");
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
            return this.Equals(input as NfeSefazForDia);
        }

        /// <summary>
        /// Returns true if NfeSefazForDia instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazForDia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazForDia input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.dia == input.dia ||
                    (this.dia != null &&
                    this.dia.Equals(input.dia))
                ) && 
                (
                    this.qtde == input.qtde ||
                    (this.qtde != null &&
                    this.qtde.Equals(input.qtde))
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
                if (this.dia != null)
                {
                    hashCode = (hashCode * 59) + this.dia.GetHashCode();
                }
                if (this.qtde != null)
                {
                    hashCode = (hashCode * 59) + this.qtde.GetHashCode();
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
            // dia (int?) maximum
            if (this.dia > (int?)31)
            {
                yield return new ValidationResult("Invalid value for dia, must be a value less than or equal to 31.", new [] { "dia" });
            }

            // dia (int?) minimum
            if (this.dia < (int?)1)
            {
                yield return new ValidationResult("Invalid value for dia, must be a value greater than or equal to 1.", new [] { "dia" });
            }

            // qtde (decimal?) minimum
            if (this.qtde < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qtde, must be a value greater than or equal to 0.", new [] { "qtde" });
            }

            yield break;
        }
    }

}
