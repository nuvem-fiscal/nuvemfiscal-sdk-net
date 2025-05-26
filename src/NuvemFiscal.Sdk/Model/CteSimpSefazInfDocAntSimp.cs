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
    /// Documentos anteriores.
    /// </summary>
    [DataContract(Name = "CteSimpSefazInfDocAntSimp")]
    public partial class CteSimpSefazInfDocAntSimp : IEquatable<CteSimpSefazInfDocAntSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfDocAntSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazInfDocAntSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazInfDocAntSimp" /> class.
        /// </summary>
        /// <param name="chCTe">Chave de acesso do CT-e. (required).</param>
        /// <param name="tpPrest">indica se a prestação é total ou parcial em relação as notas do documento anterior.  Preencher com:  * 1 - Total  * 2 - Parcial (required).</param>
        /// <param name="infNFeTranspParcial">infNFeTranspParcial.</param>
        public CteSimpSefazInfDocAntSimp(string chCTe = default(string), int? tpPrest = default(int?), List<CteSimpSefazInfNFeTranspParcialSimp> infNFeTranspParcial = default(List<CteSimpSefazInfNFeTranspParcialSimp>))
        {
            // to ensure "chCTe" is required (not null)
            if (chCTe == null)
            {
                throw new ArgumentNullException("chCTe is a required property for CteSimpSefazInfDocAntSimp and cannot be null");
            }
            this.chCTe = chCTe;
            // to ensure "tpPrest" is required (not null)
            if (tpPrest == null)
            {
                throw new ArgumentNullException("tpPrest is a required property for CteSimpSefazInfDocAntSimp and cannot be null");
            }
            this.tpPrest = tpPrest;
            this.infNFeTranspParcial = infNFeTranspParcial;
        }

        /// <summary>
        /// Chave de acesso do CT-e.
        /// </summary>
        /// <value>Chave de acesso do CT-e.</value>
        [DataMember(Name = "chCTe", IsRequired = true, EmitDefaultValue = true)]
        public string chCTe { get; set; }

        /// <summary>
        /// indica se a prestação é total ou parcial em relação as notas do documento anterior.  Preencher com:  * 1 - Total  * 2 - Parcial
        /// </summary>
        /// <value>indica se a prestação é total ou parcial em relação as notas do documento anterior.  Preencher com:  * 1 - Total  * 2 - Parcial</value>
        [DataMember(Name = "tpPrest", IsRequired = true, EmitDefaultValue = true)]
        public int? tpPrest { get; set; }

        /// <summary>
        /// Gets or Sets infNFeTranspParcial
        /// </summary>
        [DataMember(Name = "infNFeTranspParcial", EmitDefaultValue = false)]
        public List<CteSimpSefazInfNFeTranspParcialSimp> infNFeTranspParcial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazInfDocAntSimp {\n");
            sb.Append("  chCTe: ").Append(chCTe).Append("\n");
            sb.Append("  tpPrest: ").Append(tpPrest).Append("\n");
            sb.Append("  infNFeTranspParcial: ").Append(infNFeTranspParcial).Append("\n");
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
            return this.Equals(input as CteSimpSefazInfDocAntSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazInfDocAntSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazInfDocAntSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazInfDocAntSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCTe == input.chCTe ||
                    (this.chCTe != null &&
                    this.chCTe.Equals(input.chCTe))
                ) && 
                (
                    this.tpPrest == input.tpPrest ||
                    (this.tpPrest != null &&
                    this.tpPrest.Equals(input.tpPrest))
                ) && 
                (
                    this.infNFeTranspParcial == input.infNFeTranspParcial ||
                    this.infNFeTranspParcial != null &&
                    input.infNFeTranspParcial != null &&
                    this.infNFeTranspParcial.SequenceEqual(input.infNFeTranspParcial)
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
                if (this.chCTe != null)
                {
                    hashCode = (hashCode * 59) + this.chCTe.GetHashCode();
                }
                if (this.tpPrest != null)
                {
                    hashCode = (hashCode * 59) + this.tpPrest.GetHashCode();
                }
                if (this.infNFeTranspParcial != null)
                {
                    hashCode = (hashCode * 59) + this.infNFeTranspParcial.GetHashCode();
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
            // chCTe (string) maxLength
            if (this.chCTe != null && this.chCTe.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chCTe, length must be less than 44.", new [] { "chCTe" });
            }

            yield break;
        }
    }

}
