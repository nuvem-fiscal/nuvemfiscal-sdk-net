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
    /// Grupo de informações dos tributos PIS/COFINS.
    /// </summary>
    [DataContract(Name = "TribOutrosPisCofins")]
    public partial class TribOutrosPisCofins : IEquatable<TribOutrosPisCofins>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TribOutrosPisCofins" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TribOutrosPisCofins() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TribOutrosPisCofins" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do PIS/COFINS (CST):  * 00 - Nenhum  * 01 - Operação Tributável com Alíquota Básica  * 02 - Operação Tributável com Alíquota Diferenciada  * 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto  * 04 - Operação Tributável monofásica - Revenda a Alíquota Zero  * 05 - Operação Tributável por Substituição Tributária  * 06 - Operação Tributável a Alíquota Zero  * 07 - Operação Tributável da Contribuição  * 08 - Operação sem Incidência da Contribuição  * 09 - Operação com Suspensão da Contribuição (required).</param>
        /// <param name="vBCPisCofins">Valor da Base de Cálculo do PIS/COFINS (R$)..</param>
        /// <param name="pAliqPis">Valor da Alíquota do PIS (%%)..</param>
        /// <param name="pAliqCofins">Valor da Alíquota da COFINS (%%)..</param>
        /// <param name="vPis">Valor monetário do PIS (R$)..</param>
        /// <param name="vCofins">Valor monetário do COFINS (R$)..</param>
        /// <param name="tpRetPisCofins">Tipo de retencao do Pis/Cofins:  * 1 - Retido  * 2 - Não Retido.</param>
        public TribOutrosPisCofins(string cST = default(string), decimal? vBCPisCofins = default(decimal?), decimal? pAliqPis = default(decimal?), decimal? pAliqCofins = default(decimal?), decimal? vPis = default(decimal?), decimal? vCofins = default(decimal?), int? tpRetPisCofins = default(int?))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for TribOutrosPisCofins and cannot be null");
            }
            this.CST = cST;
            this.vBCPisCofins = vBCPisCofins;
            this.pAliqPis = pAliqPis;
            this.pAliqCofins = pAliqCofins;
            this.vPis = vPis;
            this.vCofins = vCofins;
            this.tpRetPisCofins = tpRetPisCofins;
        }

        /// <summary>
        /// Código de Situação Tributária do PIS/COFINS (CST):  * 00 - Nenhum  * 01 - Operação Tributável com Alíquota Básica  * 02 - Operação Tributável com Alíquota Diferenciada  * 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto  * 04 - Operação Tributável monofásica - Revenda a Alíquota Zero  * 05 - Operação Tributável por Substituição Tributária  * 06 - Operação Tributável a Alíquota Zero  * 07 - Operação Tributável da Contribuição  * 08 - Operação sem Incidência da Contribuição  * 09 - Operação com Suspensão da Contribuição
        /// </summary>
        /// <value>Código de Situação Tributária do PIS/COFINS (CST):  * 00 - Nenhum  * 01 - Operação Tributável com Alíquota Básica  * 02 - Operação Tributável com Alíquota Diferenciada  * 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto  * 04 - Operação Tributável monofásica - Revenda a Alíquota Zero  * 05 - Operação Tributável por Substituição Tributária  * 06 - Operação Tributável a Alíquota Zero  * 07 - Operação Tributável da Contribuição  * 08 - Operação sem Incidência da Contribuição  * 09 - Operação com Suspensão da Contribuição</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da Base de Cálculo do PIS/COFINS (R$).
        /// </summary>
        /// <value>Valor da Base de Cálculo do PIS/COFINS (R$).</value>
        [DataMember(Name = "vBCPisCofins", EmitDefaultValue = true)]
        public decimal? vBCPisCofins { get; set; }

        /// <summary>
        /// Valor da Alíquota do PIS (%%).
        /// </summary>
        /// <value>Valor da Alíquota do PIS (%%).</value>
        [DataMember(Name = "pAliqPis", EmitDefaultValue = true)]
        public decimal? pAliqPis { get; set; }

        /// <summary>
        /// Valor da Alíquota da COFINS (%%).
        /// </summary>
        /// <value>Valor da Alíquota da COFINS (%%).</value>
        [DataMember(Name = "pAliqCofins", EmitDefaultValue = true)]
        public decimal? pAliqCofins { get; set; }

        /// <summary>
        /// Valor monetário do PIS (R$).
        /// </summary>
        /// <value>Valor monetário do PIS (R$).</value>
        [DataMember(Name = "vPis", EmitDefaultValue = true)]
        public decimal? vPis { get; set; }

        /// <summary>
        /// Valor monetário do COFINS (R$).
        /// </summary>
        /// <value>Valor monetário do COFINS (R$).</value>
        [DataMember(Name = "vCofins", EmitDefaultValue = true)]
        public decimal? vCofins { get; set; }

        /// <summary>
        /// Tipo de retencao do Pis/Cofins:  * 1 - Retido  * 2 - Não Retido
        /// </summary>
        /// <value>Tipo de retencao do Pis/Cofins:  * 1 - Retido  * 2 - Não Retido</value>
        [DataMember(Name = "tpRetPisCofins", EmitDefaultValue = true)]
        public int? tpRetPisCofins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TribOutrosPisCofins {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBCPisCofins: ").Append(vBCPisCofins).Append("\n");
            sb.Append("  pAliqPis: ").Append(pAliqPis).Append("\n");
            sb.Append("  pAliqCofins: ").Append(pAliqCofins).Append("\n");
            sb.Append("  vPis: ").Append(vPis).Append("\n");
            sb.Append("  vCofins: ").Append(vCofins).Append("\n");
            sb.Append("  tpRetPisCofins: ").Append(tpRetPisCofins).Append("\n");
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
            return this.Equals(input as TribOutrosPisCofins);
        }

        /// <summary>
        /// Returns true if TribOutrosPisCofins instances are equal
        /// </summary>
        /// <param name="input">Instance of TribOutrosPisCofins to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TribOutrosPisCofins input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.vBCPisCofins == input.vBCPisCofins ||
                    (this.vBCPisCofins != null &&
                    this.vBCPisCofins.Equals(input.vBCPisCofins))
                ) && 
                (
                    this.pAliqPis == input.pAliqPis ||
                    (this.pAliqPis != null &&
                    this.pAliqPis.Equals(input.pAliqPis))
                ) && 
                (
                    this.pAliqCofins == input.pAliqCofins ||
                    (this.pAliqCofins != null &&
                    this.pAliqCofins.Equals(input.pAliqCofins))
                ) && 
                (
                    this.vPis == input.vPis ||
                    (this.vPis != null &&
                    this.vPis.Equals(input.vPis))
                ) && 
                (
                    this.vCofins == input.vCofins ||
                    (this.vCofins != null &&
                    this.vCofins.Equals(input.vCofins))
                ) && 
                (
                    this.tpRetPisCofins == input.tpRetPisCofins ||
                    (this.tpRetPisCofins != null &&
                    this.tpRetPisCofins.Equals(input.tpRetPisCofins))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.vBCPisCofins != null)
                {
                    hashCode = (hashCode * 59) + this.vBCPisCofins.GetHashCode();
                }
                if (this.pAliqPis != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqPis.GetHashCode();
                }
                if (this.pAliqCofins != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqCofins.GetHashCode();
                }
                if (this.vPis != null)
                {
                    hashCode = (hashCode * 59) + this.vPis.GetHashCode();
                }
                if (this.vCofins != null)
                {
                    hashCode = (hashCode * 59) + this.vCofins.GetHashCode();
                }
                if (this.tpRetPisCofins != null)
                {
                    hashCode = (hashCode * 59) + this.tpRetPisCofins.GetHashCode();
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
            // vBCPisCofins (decimal?) minimum
            if (this.vBCPisCofins < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBCPisCofins, must be a value greater than or equal to 0.", new [] { "vBCPisCofins" });
            }

            // pAliqPis (decimal?) minimum
            if (this.pAliqPis < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqPis, must be a value greater than or equal to 0.", new [] { "pAliqPis" });
            }

            // pAliqCofins (decimal?) minimum
            if (this.pAliqCofins < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqCofins, must be a value greater than or equal to 0.", new [] { "pAliqCofins" });
            }

            // vPis (decimal?) minimum
            if (this.vPis < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vPis, must be a value greater than or equal to 0.", new [] { "vPis" });
            }

            // vCofins (decimal?) minimum
            if (this.vCofins < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCofins, must be a value greater than or equal to 0.", new [] { "vCofins" });
            }

            yield break;
        }
    }

}
