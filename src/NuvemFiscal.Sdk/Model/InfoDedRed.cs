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
    /// Grupo de informações relativas ao valores para dedução/redução do valor da base de cálculo (valor do serviço).
    /// </summary>
    [DataContract(Name = "InfoDedRed")]
    public partial class InfoDedRed : IEquatable<InfoDedRed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoDedRed" /> class.
        /// </summary>
        /// <param name="pDR">Valor percentual padrão para dedução/redução do valor do serviço..</param>
        /// <param name="vDR">Valor monetário padrão para dedução/redução do valor do serviço..</param>
        /// <param name="documentos">documentos.</param>
        public InfoDedRed(decimal? pDR = default(decimal?), decimal? vDR = default(decimal?), ListaDocDedRed documentos = default(ListaDocDedRed))
        {
            this.pDR = pDR;
            this.vDR = vDR;
            this.documentos = documentos;
        }

        /// <summary>
        /// Valor percentual padrão para dedução/redução do valor do serviço.
        /// </summary>
        /// <value>Valor percentual padrão para dedução/redução do valor do serviço.</value>
        [DataMember(Name = "pDR", EmitDefaultValue = true)]
        public decimal? pDR { get; set; }

        /// <summary>
        /// Valor monetário padrão para dedução/redução do valor do serviço.
        /// </summary>
        /// <value>Valor monetário padrão para dedução/redução do valor do serviço.</value>
        [DataMember(Name = "vDR", EmitDefaultValue = true)]
        public decimal? vDR { get; set; }

        /// <summary>
        /// Gets or Sets documentos
        /// </summary>
        [DataMember(Name = "documentos", EmitDefaultValue = false)]
        public ListaDocDedRed documentos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoDedRed {\n");
            sb.Append("  pDR: ").Append(pDR).Append("\n");
            sb.Append("  vDR: ").Append(vDR).Append("\n");
            sb.Append("  documentos: ").Append(documentos).Append("\n");
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
            return this.Equals(input as InfoDedRed);
        }

        /// <summary>
        /// Returns true if InfoDedRed instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoDedRed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoDedRed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pDR == input.pDR ||
                    (this.pDR != null &&
                    this.pDR.Equals(input.pDR))
                ) && 
                (
                    this.vDR == input.vDR ||
                    (this.vDR != null &&
                    this.vDR.Equals(input.vDR))
                ) && 
                (
                    this.documentos == input.documentos ||
                    (this.documentos != null &&
                    this.documentos.Equals(input.documentos))
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
                if (this.pDR != null)
                {
                    hashCode = (hashCode * 59) + this.pDR.GetHashCode();
                }
                if (this.vDR != null)
                {
                    hashCode = (hashCode * 59) + this.vDR.GetHashCode();
                }
                if (this.documentos != null)
                {
                    hashCode = (hashCode * 59) + this.documentos.GetHashCode();
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
            // pDR (decimal?) minimum
            if (this.pDR < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pDR, must be a value greater than or equal to 0.", new [] { "pDR" });
            }

            // vDR (decimal?) minimum
            if (this.vDR < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDR, must be a value greater than or equal to 0.", new [] { "vDR" });
            }

            yield break;
        }
    }

}
