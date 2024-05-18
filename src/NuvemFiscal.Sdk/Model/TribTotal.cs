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
    /// Grupo de informações para totais aproximados dos tributos relacionados ao serviço prestado.
    /// </summary>
    [DataContract(Name = "TribTotal")]
    public partial class TribTotal : IEquatable<TribTotal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TribTotal" /> class.
        /// </summary>
        /// <param name="vTotTrib">vTotTrib.</param>
        /// <param name="pTotTrib">pTotTrib.</param>
        /// <param name="indTotTrib">Indicador de informação de valor total de tributos. Possui valor fixo igual a zero (indTotTrib&#x3D;0).  Não informar nenhum valor estimado para os Tributos (Decreto 8.264/2014).  * 0 - Não.</param>
        /// <param name="pTotTribSN">Valor percentual aproximado do total dos tributos da alíquota do Simples Nacional (%%)..</param>
        public TribTotal(TribTotalMonet vTotTrib = default(TribTotalMonet), TribTotalPercent pTotTrib = default(TribTotalPercent), int? indTotTrib = default(int?), decimal? pTotTribSN = default(decimal?))
        {
            this.vTotTrib = vTotTrib;
            this.pTotTrib = pTotTrib;
            this.indTotTrib = indTotTrib;
            this.pTotTribSN = pTotTribSN;
        }

        /// <summary>
        /// Gets or Sets vTotTrib
        /// </summary>
        [DataMember(Name = "vTotTrib", EmitDefaultValue = false)]
        public TribTotalMonet vTotTrib { get; set; }

        /// <summary>
        /// Gets or Sets pTotTrib
        /// </summary>
        [DataMember(Name = "pTotTrib", EmitDefaultValue = false)]
        public TribTotalPercent pTotTrib { get; set; }

        /// <summary>
        /// Indicador de informação de valor total de tributos. Possui valor fixo igual a zero (indTotTrib&#x3D;0).  Não informar nenhum valor estimado para os Tributos (Decreto 8.264/2014).  * 0 - Não
        /// </summary>
        /// <value>Indicador de informação de valor total de tributos. Possui valor fixo igual a zero (indTotTrib&#x3D;0).  Não informar nenhum valor estimado para os Tributos (Decreto 8.264/2014).  * 0 - Não</value>
        [DataMember(Name = "indTotTrib", EmitDefaultValue = true)]
        public int? indTotTrib { get; set; }

        /// <summary>
        /// Valor percentual aproximado do total dos tributos da alíquota do Simples Nacional (%%).
        /// </summary>
        /// <value>Valor percentual aproximado do total dos tributos da alíquota do Simples Nacional (%%).</value>
        [DataMember(Name = "pTotTribSN", EmitDefaultValue = true)]
        public decimal? pTotTribSN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TribTotal {\n");
            sb.Append("  vTotTrib: ").Append(vTotTrib).Append("\n");
            sb.Append("  pTotTrib: ").Append(pTotTrib).Append("\n");
            sb.Append("  indTotTrib: ").Append(indTotTrib).Append("\n");
            sb.Append("  pTotTribSN: ").Append(pTotTribSN).Append("\n");
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
            return this.Equals(input as TribTotal);
        }

        /// <summary>
        /// Returns true if TribTotal instances are equal
        /// </summary>
        /// <param name="input">Instance of TribTotal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TribTotal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vTotTrib == input.vTotTrib ||
                    (this.vTotTrib != null &&
                    this.vTotTrib.Equals(input.vTotTrib))
                ) && 
                (
                    this.pTotTrib == input.pTotTrib ||
                    (this.pTotTrib != null &&
                    this.pTotTrib.Equals(input.pTotTrib))
                ) && 
                (
                    this.indTotTrib == input.indTotTrib ||
                    (this.indTotTrib != null &&
                    this.indTotTrib.Equals(input.indTotTrib))
                ) && 
                (
                    this.pTotTribSN == input.pTotTribSN ||
                    (this.pTotTribSN != null &&
                    this.pTotTribSN.Equals(input.pTotTribSN))
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
                if (this.vTotTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTrib.GetHashCode();
                }
                if (this.pTotTrib != null)
                {
                    hashCode = (hashCode * 59) + this.pTotTrib.GetHashCode();
                }
                if (this.indTotTrib != null)
                {
                    hashCode = (hashCode * 59) + this.indTotTrib.GetHashCode();
                }
                if (this.pTotTribSN != null)
                {
                    hashCode = (hashCode * 59) + this.pTotTribSN.GetHashCode();
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
            // pTotTribSN (decimal?) minimum
            if (this.pTotTribSN < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pTotTribSN, must be a value greater than or equal to 0.", new [] { "pTotTribSN" });
            }

            yield break;
        }
    }

}
