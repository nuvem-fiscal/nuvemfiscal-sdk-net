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
    /// Grupo de informações da Entrega Parcial (Corte de Voo).
    /// </summary>
    [DataContract(Name = "MdfeSefazInfEntregaParcial")]
    public partial class MdfeSefazInfEntregaParcial : IEquatable<MdfeSefazInfEntregaParcial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfEntregaParcial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfEntregaParcial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfEntregaParcial" /> class.
        /// </summary>
        /// <param name="qtdTotal">Quantidade total de volumes. (required).</param>
        /// <param name="qtdParcial">Quantidade de volumes enviados no MDF-e. (required).</param>
        public MdfeSefazInfEntregaParcial(decimal? qtdTotal = default(decimal?), decimal? qtdParcial = default(decimal?))
        {
            // to ensure "qtdTotal" is required (not null)
            if (qtdTotal == null)
            {
                throw new ArgumentNullException("qtdTotal is a required property for MdfeSefazInfEntregaParcial and cannot be null");
            }
            this.qtdTotal = qtdTotal;
            // to ensure "qtdParcial" is required (not null)
            if (qtdParcial == null)
            {
                throw new ArgumentNullException("qtdParcial is a required property for MdfeSefazInfEntregaParcial and cannot be null");
            }
            this.qtdParcial = qtdParcial;
        }

        /// <summary>
        /// Quantidade total de volumes.
        /// </summary>
        /// <value>Quantidade total de volumes.</value>
        [DataMember(Name = "qtdTotal", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qtdTotal { get; set; }

        /// <summary>
        /// Quantidade de volumes enviados no MDF-e.
        /// </summary>
        /// <value>Quantidade de volumes enviados no MDF-e.</value>
        [DataMember(Name = "qtdParcial", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qtdParcial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfEntregaParcial {\n");
            sb.Append("  qtdTotal: ").Append(qtdTotal).Append("\n");
            sb.Append("  qtdParcial: ").Append(qtdParcial).Append("\n");
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
            return this.Equals(input as MdfeSefazInfEntregaParcial);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfEntregaParcial instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfEntregaParcial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfEntregaParcial input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qtdTotal == input.qtdTotal ||
                    (this.qtdTotal != null &&
                    this.qtdTotal.Equals(input.qtdTotal))
                ) && 
                (
                    this.qtdParcial == input.qtdParcial ||
                    (this.qtdParcial != null &&
                    this.qtdParcial.Equals(input.qtdParcial))
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
                if (this.qtdTotal != null)
                {
                    hashCode = (hashCode * 59) + this.qtdTotal.GetHashCode();
                }
                if (this.qtdParcial != null)
                {
                    hashCode = (hashCode * 59) + this.qtdParcial.GetHashCode();
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
            // qtdTotal (decimal?) minimum
            if (this.qtdTotal < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qtdTotal, must be a value greater than or equal to 0.", new [] { "qtdTotal" });
            }

            // qtdParcial (decimal?) minimum
            if (this.qtdParcial < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qtdParcial, must be a value greater than or equal to 0.", new [] { "qtdParcial" });
            }

            yield break;
        }
    }

}
