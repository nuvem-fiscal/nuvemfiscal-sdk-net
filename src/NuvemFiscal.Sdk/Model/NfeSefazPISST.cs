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
    /// Dados do PIS Substituição Tributária.
    /// </summary>
    [DataContract(Name = "NfeSefazPISST")]
    public partial class NfeSefazPISST : IEquatable<NfeSefazPISST>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPISST" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazPISST() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPISST" /> class.
        /// </summary>
        /// <param name="vBC">Valor da BC do PIS ST..</param>
        /// <param name="pPIS">Alíquota do PIS ST (em percentual)..</param>
        /// <param name="qBCProd">Quantidade Vendida..</param>
        /// <param name="vAliqProd">Alíquota do PIS ST (em reais)..</param>
        /// <param name="vPIS">Valor do PIS ST. (required).</param>
        /// <param name="indSomaPISST">Indica se o valor do PISST compõe o valor total da NF-e..</param>
        public NfeSefazPISST(decimal? vBC = default(decimal?), decimal? pPIS = default(decimal?), decimal? qBCProd = default(decimal?), decimal? vAliqProd = default(decimal?), decimal? vPIS = default(decimal?), int? indSomaPISST = default(int?))
        {
            // to ensure "vPIS" is required (not null)
            if (vPIS == null)
            {
                throw new ArgumentNullException("vPIS is a required property for NfeSefazPISST and cannot be null");
            }
            this.vPIS = vPIS;
            this.vBC = vBC;
            this.pPIS = pPIS;
            this.qBCProd = qBCProd;
            this.vAliqProd = vAliqProd;
            this.indSomaPISST = indSomaPISST;
        }

        /// <summary>
        /// Valor da BC do PIS ST.
        /// </summary>
        /// <value>Valor da BC do PIS ST.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do PIS ST (em percentual).
        /// </summary>
        /// <value>Alíquota do PIS ST (em percentual).</value>
        [DataMember(Name = "pPIS", EmitDefaultValue = true)]
        public decimal? pPIS { get; set; }

        /// <summary>
        /// Quantidade Vendida.
        /// </summary>
        /// <value>Quantidade Vendida.</value>
        [DataMember(Name = "qBCProd", EmitDefaultValue = true)]
        public decimal? qBCProd { get; set; }

        /// <summary>
        /// Alíquota do PIS ST (em reais).
        /// </summary>
        /// <value>Alíquota do PIS ST (em reais).</value>
        [DataMember(Name = "vAliqProd", EmitDefaultValue = true)]
        public decimal? vAliqProd { get; set; }

        /// <summary>
        /// Valor do PIS ST.
        /// </summary>
        /// <value>Valor do PIS ST.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Indica se o valor do PISST compõe o valor total da NF-e.
        /// </summary>
        /// <value>Indica se o valor do PISST compõe o valor total da NF-e.</value>
        [DataMember(Name = "indSomaPISST", EmitDefaultValue = true)]
        public int? indSomaPISST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazPISST {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pPIS: ").Append(pPIS).Append("\n");
            sb.Append("  qBCProd: ").Append(qBCProd).Append("\n");
            sb.Append("  vAliqProd: ").Append(vAliqProd).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
            sb.Append("  indSomaPISST: ").Append(indSomaPISST).Append("\n");
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
            return this.Equals(input as NfeSefazPISST);
        }

        /// <summary>
        /// Returns true if NfeSefazPISST instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazPISST to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazPISST input)
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
                    this.pPIS == input.pPIS ||
                    (this.pPIS != null &&
                    this.pPIS.Equals(input.pPIS))
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
                    this.vPIS == input.vPIS ||
                    (this.vPIS != null &&
                    this.vPIS.Equals(input.vPIS))
                ) && 
                (
                    this.indSomaPISST == input.indSomaPISST ||
                    (this.indSomaPISST != null &&
                    this.indSomaPISST.Equals(input.indSomaPISST))
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
                if (this.pPIS != null)
                {
                    hashCode = (hashCode * 59) + this.pPIS.GetHashCode();
                }
                if (this.qBCProd != null)
                {
                    hashCode = (hashCode * 59) + this.qBCProd.GetHashCode();
                }
                if (this.vAliqProd != null)
                {
                    hashCode = (hashCode * 59) + this.vAliqProd.GetHashCode();
                }
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                }
                if (this.indSomaPISST != null)
                {
                    hashCode = (hashCode * 59) + this.indSomaPISST.GetHashCode();
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
            yield break;
        }
    }

}
