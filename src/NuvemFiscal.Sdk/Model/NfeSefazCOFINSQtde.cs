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
    /// Código de Situação Tributária do COFINS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto
    /// </summary>
    [DataContract(Name = "NfeSefazCOFINSQtde")]
    public partial class NfeSefazCOFINSQtde : IEquatable<NfeSefazCOFINSQtde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSQtde" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCOFINSQtde() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSQtde" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do COFINS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto (required).</param>
        /// <param name="qBCProd">Quantidade Vendida (NT2011/004). (required).</param>
        /// <param name="vAliqProd">Alíquota do COFINS (em reais) (NT2011/004). (required).</param>
        /// <param name="vCOFINS">Valor do COFINS. (required).</param>
        public NfeSefazCOFINSQtde(string cST = default(string), decimal qBCProd = default(decimal), decimal vAliqProd = default(decimal), decimal vCOFINS = default(decimal))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazCOFINSQtde and cannot be null");
            }
            this.CST = cST;
            this.qBCProd = qBCProd;
            this.vAliqProd = vAliqProd;
            this.vCOFINS = vCOFINS;
        }

        /// <summary>
        /// Código de Situação Tributária do COFINS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto
        /// </summary>
        /// <value>Código de Situação Tributária do COFINS.  * 03 - Operação Tributável - Base de Calculo &#x3D; Quantidade Vendida x Alíquota por Unidade de Produto</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Quantidade Vendida (NT2011/004).
        /// </summary>
        /// <value>Quantidade Vendida (NT2011/004).</value>
        [DataMember(Name = "qBCProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal qBCProd { get; set; }

        /// <summary>
        /// Alíquota do COFINS (em reais) (NT2011/004).
        /// </summary>
        /// <value>Alíquota do COFINS (em reais) (NT2011/004).</value>
        [DataMember(Name = "vAliqProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal vAliqProd { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vCOFINS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCOFINSQtde {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  qBCProd: ").Append(qBCProd).Append("\n");
            sb.Append("  vAliqProd: ").Append(vAliqProd).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
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
            return this.Equals(input as NfeSefazCOFINSQtde);
        }

        /// <summary>
        /// Returns true if NfeSefazCOFINSQtde instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCOFINSQtde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCOFINSQtde input)
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
                    this.qBCProd.Equals(input.qBCProd)
                ) && 
                (
                    this.vAliqProd == input.vAliqProd ||
                    this.vAliqProd.Equals(input.vAliqProd)
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    this.vCOFINS.Equals(input.vCOFINS)
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
                hashCode = (hashCode * 59) + this.qBCProd.GetHashCode();
                hashCode = (hashCode * 59) + this.vAliqProd.GetHashCode();
                hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
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
