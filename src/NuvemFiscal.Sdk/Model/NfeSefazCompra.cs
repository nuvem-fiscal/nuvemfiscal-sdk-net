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
    /// Informações de compras  (Nota de Empenho, Pedido e Contrato).
    /// </summary>
    [DataContract(Name = "NfeSefazCompra")]
    public partial class NfeSefazCompra : IEquatable<NfeSefazCompra>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCompra" /> class.
        /// </summary>
        /// <param name="xNEmp">Informação da Nota de Empenho de compras públicas (NT2011/004)..</param>
        /// <param name="xPed">Informação do pedido..</param>
        /// <param name="xCont">Informação do contrato..</param>
        public NfeSefazCompra(string xNEmp = default(string), string xPed = default(string), string xCont = default(string))
        {
            this.xNEmp = xNEmp;
            this.xPed = xPed;
            this.xCont = xCont;
        }

        /// <summary>
        /// Informação da Nota de Empenho de compras públicas (NT2011/004).
        /// </summary>
        /// <value>Informação da Nota de Empenho de compras públicas (NT2011/004).</value>
        [DataMember(Name = "xNEmp", EmitDefaultValue = true)]
        public string xNEmp { get; set; }

        /// <summary>
        /// Informação do pedido.
        /// </summary>
        /// <value>Informação do pedido.</value>
        [DataMember(Name = "xPed", EmitDefaultValue = true)]
        public string xPed { get; set; }

        /// <summary>
        /// Informação do contrato.
        /// </summary>
        /// <value>Informação do contrato.</value>
        [DataMember(Name = "xCont", EmitDefaultValue = true)]
        public string xCont { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCompra {\n");
            sb.Append("  xNEmp: ").Append(xNEmp).Append("\n");
            sb.Append("  xPed: ").Append(xPed).Append("\n");
            sb.Append("  xCont: ").Append(xCont).Append("\n");
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
            return this.Equals(input as NfeSefazCompra);
        }

        /// <summary>
        /// Returns true if NfeSefazCompra instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCompra to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCompra input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNEmp == input.xNEmp ||
                    (this.xNEmp != null &&
                    this.xNEmp.Equals(input.xNEmp))
                ) && 
                (
                    this.xPed == input.xPed ||
                    (this.xPed != null &&
                    this.xPed.Equals(input.xPed))
                ) && 
                (
                    this.xCont == input.xCont ||
                    (this.xCont != null &&
                    this.xCont.Equals(input.xCont))
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
                if (this.xNEmp != null)
                {
                    hashCode = (hashCode * 59) + this.xNEmp.GetHashCode();
                }
                if (this.xPed != null)
                {
                    hashCode = (hashCode * 59) + this.xPed.GetHashCode();
                }
                if (this.xCont != null)
                {
                    hashCode = (hashCode * 59) + this.xCont.GetHashCode();
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
            // xNEmp (string) maxLength
            if (this.xNEmp != null && this.xNEmp.Length > 22)
            {
                yield return new ValidationResult("Invalid value for xNEmp, length must be less than 22.", new [] { "xNEmp" });
            }

            // xNEmp (string) minLength
            if (this.xNEmp != null && this.xNEmp.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xNEmp, length must be greater than 1.", new [] { "xNEmp" });
            }

            // xPed (string) maxLength
            if (this.xPed != null && this.xPed.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xPed, length must be less than 60.", new [] { "xPed" });
            }

            // xPed (string) minLength
            if (this.xPed != null && this.xPed.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xPed, length must be greater than 1.", new [] { "xPed" });
            }

            // xCont (string) maxLength
            if (this.xCont != null && this.xCont.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xCont, length must be less than 60.", new [] { "xCont" });
            }

            // xCont (string) minLength
            if (this.xCont != null && this.xCont.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xCont, length must be greater than 1.", new [] { "xCont" });
            }

            yield break;
        }
    }

}
