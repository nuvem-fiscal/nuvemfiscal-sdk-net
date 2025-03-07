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
        public NfeSefazIPITrib(string cST = default(string), decimal? vBC = default(decimal?), decimal? pIPI = default(decimal?), decimal? qUnid = default(decimal?), decimal? vUnid = default(decimal?), decimal? vIPI = default(decimal?))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazIPITrib and cannot be null");
            }
            this.CST = cST;
            // to ensure "vIPI" is required (not null)
            if (vIPI == null)
            {
                throw new ArgumentNullException("vIPI is a required property for NfeSefazIPITrib and cannot be null");
            }
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
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do IPI.
        /// </summary>
        /// <value>Alíquota do IPI.</value>
        [DataMember(Name = "pIPI", EmitDefaultValue = true)]
        public decimal? pIPI { get; set; }

        /// <summary>
        /// Quantidade total na unidade padrão para tributação.
        /// </summary>
        /// <value>Quantidade total na unidade padrão para tributação.</value>
        [DataMember(Name = "qUnid", EmitDefaultValue = true)]
        public decimal? qUnid { get; set; }

        /// <summary>
        /// Valor por Unidade Tributável. Informar o valor do imposto Pauta por unidade de medida.
        /// </summary>
        /// <value>Valor por Unidade Tributável. Informar o valor do imposto Pauta por unidade de medida.</value>
        [DataMember(Name = "vUnid", EmitDefaultValue = true)]
        public decimal? vUnid { get; set; }

        /// <summary>
        /// Valor do IPI.
        /// </summary>
        /// <value>Valor do IPI.</value>
        [DataMember(Name = "vIPI", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIPI { get; set; }

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
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pIPI == input.pIPI ||
                    (this.pIPI != null &&
                    this.pIPI.Equals(input.pIPI))
                ) && 
                (
                    this.qUnid == input.qUnid ||
                    (this.qUnid != null &&
                    this.qUnid.Equals(input.qUnid))
                ) && 
                (
                    this.vUnid == input.vUnid ||
                    (this.vUnid != null &&
                    this.vUnid.Equals(input.vUnid))
                ) && 
                (
                    this.vIPI == input.vIPI ||
                    (this.vIPI != null &&
                    this.vIPI.Equals(input.vIPI))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pIPI != null)
                {
                    hashCode = (hashCode * 59) + this.pIPI.GetHashCode();
                }
                if (this.qUnid != null)
                {
                    hashCode = (hashCode * 59) + this.qUnid.GetHashCode();
                }
                if (this.vUnid != null)
                {
                    hashCode = (hashCode * 59) + this.vUnid.GetHashCode();
                }
                if (this.vIPI != null)
                {
                    hashCode = (hashCode * 59) + this.vIPI.GetHashCode();
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

            // pIPI (decimal?) minimum
            if (this.pIPI < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pIPI, must be a value greater than or equal to 0.", new [] { "pIPI" });
            }

            // qUnid (decimal?) minimum
            if (this.qUnid < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qUnid, must be a value greater than or equal to 0.", new [] { "qUnid" });
            }

            // vUnid (decimal?) minimum
            if (this.vUnid < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vUnid, must be a value greater than or equal to 0.", new [] { "vUnid" });
            }

            // vIPI (decimal?) minimum
            if (this.vIPI < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIPI, must be a value greater than or equal to 0.", new [] { "vIPI" });
            }

            yield break;
        }
    }

}
