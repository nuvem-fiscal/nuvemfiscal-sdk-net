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
    /// Código de Situação Tributária do PIS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto
    /// </summary>
    [DataContract(Name = "NfeSefazPISQtde")]
    public partial class NfeSefazPISQtde : IEquatable<NfeSefazPISQtde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPISQtde" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazPISQtde() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPISQtde" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do PIS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto (required).</param>
        /// <param name="qBCProd">Quantidade Vendida  (NT2011/004). (required).</param>
        /// <param name="vAliqProd">Alíquota do PIS (em reais) (NT2011/004). (required).</param>
        /// <param name="vPIS">Valor do PIS. (required).</param>
        public NfeSefazPISQtde(string cST = default(string), decimal? qBCProd = default(decimal?), decimal? vAliqProd = default(decimal?), decimal? vPIS = default(decimal?))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazPISQtde and cannot be null");
            }
            this.CST = cST;
            // to ensure "qBCProd" is required (not null)
            if (qBCProd == null)
            {
                throw new ArgumentNullException("qBCProd is a required property for NfeSefazPISQtde and cannot be null");
            }
            this.qBCProd = qBCProd;
            // to ensure "vAliqProd" is required (not null)
            if (vAliqProd == null)
            {
                throw new ArgumentNullException("vAliqProd is a required property for NfeSefazPISQtde and cannot be null");
            }
            this.vAliqProd = vAliqProd;
            // to ensure "vPIS" is required (not null)
            if (vPIS == null)
            {
                throw new ArgumentNullException("vPIS is a required property for NfeSefazPISQtde and cannot be null");
            }
            this.vPIS = vPIS;
        }

        /// <summary>
        /// Código de Situação Tributária do PIS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto
        /// </summary>
        /// <value>Código de Situação Tributária do PIS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Quantidade Vendida  (NT2011/004).
        /// </summary>
        /// <value>Quantidade Vendida  (NT2011/004).</value>
        [DataMember(Name = "qBCProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCProd { get; set; }

        /// <summary>
        /// Alíquota do PIS (em reais) (NT2011/004).
        /// </summary>
        /// <value>Alíquota do PIS (em reais) (NT2011/004).</value>
        [DataMember(Name = "vAliqProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vAliqProd { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazPISQtde {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  qBCProd: ").Append(qBCProd).Append("\n");
            sb.Append("  vAliqProd: ").Append(vAliqProd).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
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
            return this.Equals(input as NfeSefazPISQtde);
        }

        /// <summary>
        /// Returns true if NfeSefazPISQtde instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazPISQtde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazPISQtde input)
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
