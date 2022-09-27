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
    /// NfeSefazForDia
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
        /// <param name="dia">dia.</param>
        /// <param name="qtde">Quantidade em quilogramas - peso líquido. (required).</param>
        public NfeSefazForDia(int dia = default(int), decimal qtde = default(decimal))
        {
            this.qtde = qtde;
            this.dia = dia;
        }

        /// <summary>
        /// Gets or Sets dia
        /// </summary>
        [DataMember(Name = "dia", EmitDefaultValue = false)]
        public int dia { get; set; }

        /// <summary>
        /// Quantidade em quilogramas - peso líquido.
        /// </summary>
        /// <value>Quantidade em quilogramas - peso líquido.</value>
        [DataMember(Name = "qtde", IsRequired = true, EmitDefaultValue = true)]
        public decimal qtde { get; set; }

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
                    this.dia.Equals(input.dia)
                ) && 
                (
                    this.qtde == input.qtde ||
                    this.qtde.Equals(input.qtde)
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
                hashCode = (hashCode * 59) + this.dia.GetHashCode();
                hashCode = (hashCode * 59) + this.qtde.GetHashCode();
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
