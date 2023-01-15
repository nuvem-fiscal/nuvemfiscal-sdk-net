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
    /// NfeSefazIPITrib
    /// </summary>
    [DataContract(Name = "NfeSefazIPITrib")]
    public partial class NfeSefazIPITrib : IEquatable<NfeSefazIPITrib>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIPITrib" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazIPITrib() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIPITrib" /> class.
        /// </summary>
        /// <param name="cST">Código da Situação Tributária do IPI:  * 00 - Entrada com recuperação de crédito  * 49 - Outras entradas  * 50 - Saída tributada  * 99 - Outras saídas (required).</param>
        /// <param name="vBC">Valor da BC do IPI..</param>
        /// <param name="pIPI">Alíquota do IPI..</param>
        /// <param name="qUnid">Quantidade total na unidade padrão para tributação..</param>
        /// <param name="vUnid">Valor por Unidade Tributável. Informar o valor do imposto Pauta por unidade de medida..</param>
        /// <param name="vIPI">Valor do IPI. (required).</param>
        public NfeSefazIPITrib(string cST = default(string), decimal vBC = default(decimal), decimal pIPI = default(decimal), decimal qUnid = default(decimal), decimal vUnid = default(decimal), decimal vIPI = default(decimal))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazIPITrib and cannot be null");
            }
            this.CST = cST;
            this.vIPI = vIPI;
            this.vBC = vBC;
            this.pIPI = pIPI;
            this.qUnid = qUnid;
            this.vUnid = vUnid;
        }

        /// <summary>
        /// Código da Situação Tributária do IPI:  * 00 - Entrada com recuperação de crédito  * 49 - Outras entradas  * 50 - Saída tributada  * 99 - Outras saídas
        /// </summary>
        /// <value>Código da Situação Tributária do IPI:  * 00 - Entrada com recuperação de crédito  * 49 - Outras entradas  * 50 - Saída tributada  * 99 - Outras saídas</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do IPI.
        /// </summary>
        /// <value>Valor da BC do IPI.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = false)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Alíquota do IPI.
        /// </summary>
        /// <value>Alíquota do IPI.</value>
        [DataMember(Name = "pIPI", EmitDefaultValue = false)]
        public decimal pIPI { get; set; }

        /// <summary>
        /// Quantidade total na unidade padrão para tributação.
        /// </summary>
        /// <value>Quantidade total na unidade padrão para tributação.</value>
        [DataMember(Name = "qUnid", EmitDefaultValue = false)]
        public decimal qUnid { get; set; }

        /// <summary>
        /// Valor por Unidade Tributável. Informar o valor do imposto Pauta por unidade de medida.
        /// </summary>
        /// <value>Valor por Unidade Tributável. Informar o valor do imposto Pauta por unidade de medida.</value>
        [DataMember(Name = "vUnid", EmitDefaultValue = false)]
        public decimal vUnid { get; set; }

        /// <summary>
        /// Valor do IPI.
        /// </summary>
        /// <value>Valor do IPI.</value>
        [DataMember(Name = "vIPI", IsRequired = true, EmitDefaultValue = true)]
        public decimal vIPI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazIPITrib {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pIPI: ").Append(pIPI).Append("\n");
            sb.Append("  qUnid: ").Append(qUnid).Append("\n");
            sb.Append("  vUnid: ").Append(vUnid).Append("\n");
            sb.Append("  vIPI: ").Append(vIPI).Append("\n");
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
            return this.Equals(input as NfeSefazIPITrib);
        }

        /// <summary>
        /// Returns true if NfeSefazIPITrib instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazIPITrib to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazIPITrib input)
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
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.pIPI == input.pIPI ||
                    this.pIPI.Equals(input.pIPI)
                ) && 
                (
                    this.qUnid == input.qUnid ||
                    this.qUnid.Equals(input.qUnid)
                ) && 
                (
                    this.vUnid == input.vUnid ||
                    this.vUnid.Equals(input.vUnid)
                ) && 
                (
                    this.vIPI == input.vIPI ||
                    this.vIPI.Equals(input.vIPI)
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
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pIPI.GetHashCode();
                hashCode = (hashCode * 59) + this.qUnid.GetHashCode();
                hashCode = (hashCode * 59) + this.vUnid.GetHashCode();
                hashCode = (hashCode * 59) + this.vIPI.GetHashCode();
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
