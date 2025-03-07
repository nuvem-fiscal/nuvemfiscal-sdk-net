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
    /// Dados do COFINS da  Substituição Tributaria.
    /// </summary>
    [DataContract(Name = "NfeSefazCOFINSST")]
    public partial class NfeSefazCOFINSST : IEquatable<NfeSefazCOFINSST>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSST" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCOFINSST() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSST" /> class.
        /// </summary>
        /// <param name="vBC">Valor da BC do COFINS ST..</param>
        /// <param name="pCOFINS">Alíquota do COFINS ST(em percentual)..</param>
        /// <param name="qBCProd">Quantidade Vendida..</param>
        /// <param name="vAliqProd">Alíquota do COFINS ST(em reais)..</param>
        /// <param name="vCOFINS">Valor do COFINS ST. (required).</param>
        /// <param name="indSomaCOFINSST">Indica se o valor da COFINS ST compõe o valor total da NFe..</param>
        public NfeSefazCOFINSST(decimal? vBC = default(decimal?), decimal? pCOFINS = default(decimal?), decimal? qBCProd = default(decimal?), decimal? vAliqProd = default(decimal?), decimal? vCOFINS = default(decimal?), int? indSomaCOFINSST = default(int?))
        {
            // to ensure "vCOFINS" is required (not null)
            if (vCOFINS == null)
            {
                throw new ArgumentNullException("vCOFINS is a required property for NfeSefazCOFINSST and cannot be null");
            }
            this.vCOFINS = vCOFINS;
            this.vBC = vBC;
            this.pCOFINS = pCOFINS;
            this.qBCProd = qBCProd;
            this.vAliqProd = vAliqProd;
            this.indSomaCOFINSST = indSomaCOFINSST;
        }

        /// <summary>
        /// Valor da BC do COFINS ST.
        /// </summary>
        /// <value>Valor da BC do COFINS ST.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do COFINS ST(em percentual).
        /// </summary>
        /// <value>Alíquota do COFINS ST(em percentual).</value>
        [DataMember(Name = "pCOFINS", EmitDefaultValue = true)]
        public decimal? pCOFINS { get; set; }

        /// <summary>
        /// Quantidade Vendida.
        /// </summary>
        /// <value>Quantidade Vendida.</value>
        [DataMember(Name = "qBCProd", EmitDefaultValue = true)]
        public decimal? qBCProd { get; set; }

        /// <summary>
        /// Alíquota do COFINS ST(em reais).
        /// </summary>
        /// <value>Alíquota do COFINS ST(em reais).</value>
        [DataMember(Name = "vAliqProd", EmitDefaultValue = true)]
        public decimal? vAliqProd { get; set; }

        /// <summary>
        /// Valor do COFINS ST.
        /// </summary>
        /// <value>Valor do COFINS ST.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Indica se o valor da COFINS ST compõe o valor total da NFe.
        /// </summary>
        /// <value>Indica se o valor da COFINS ST compõe o valor total da NFe.</value>
        [DataMember(Name = "indSomaCOFINSST", EmitDefaultValue = true)]
        public int? indSomaCOFINSST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCOFINSST {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pCOFINS: ").Append(pCOFINS).Append("\n");
            sb.Append("  qBCProd: ").Append(qBCProd).Append("\n");
            sb.Append("  vAliqProd: ").Append(vAliqProd).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
            sb.Append("  indSomaCOFINSST: ").Append(indSomaCOFINSST).Append("\n");
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
            return this.Equals(input as NfeSefazCOFINSST);
        }

        /// <summary>
        /// Returns true if NfeSefazCOFINSST instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCOFINSST to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCOFINSST input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pCOFINS == input.pCOFINS ||
                    (this.pCOFINS != null &&
                    this.pCOFINS.Equals(input.pCOFINS))
                ) && 
                (
                    this.qBCProd == input.qBCProd ||
                    (this.qBCProd != null &&
                    this.qBCProd.Equals(input.qBCProd))
                ) && 
                (
                    this.vAliqProd == input.vAliqProd ||
                    (this.vAliqProd != null &&
                    this.vAliqProd.Equals(input.vAliqProd))
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    (this.vCOFINS != null &&
                    this.vCOFINS.Equals(input.vCOFINS))
                ) && 
                (
                    this.indSomaCOFINSST == input.indSomaCOFINSST ||
                    (this.indSomaCOFINSST != null &&
                    this.indSomaCOFINSST.Equals(input.indSomaCOFINSST))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.pCOFINS.GetHashCode();
                }
                if (this.qBCProd != null)
                {
                    hashCode = (hashCode * 59) + this.qBCProd.GetHashCode();
                }
                if (this.vAliqProd != null)
                {
                    hashCode = (hashCode * 59) + this.vAliqProd.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                }
                if (this.indSomaCOFINSST != null)
                {
                    hashCode = (hashCode * 59) + this.indSomaCOFINSST.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // pCOFINS (decimal?) minimum
            if (this.pCOFINS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pCOFINS, must be a value greater than or equal to 0.", new [] { "pCOFINS" });
            }

            // qBCProd (decimal?) minimum
            if (this.qBCProd < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qBCProd, must be a value greater than or equal to 0.", new [] { "qBCProd" });
            }

            // vAliqProd (decimal?) minimum
            if (this.vAliqProd < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vAliqProd, must be a value greater than or equal to 0.", new [] { "vAliqProd" });
            }

            // vCOFINS (decimal?) minimum
            if (this.vCOFINS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCOFINS, must be a value greater than or equal to 0.", new [] { "vCOFINS" });
            }

            yield break;
        }
    }

}
