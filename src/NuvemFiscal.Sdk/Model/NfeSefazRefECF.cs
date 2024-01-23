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
    /// Grupo do Cupom Fiscal vinculado à NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazRefECF")]
    public partial class NfeSefazRefECF : IEquatable<NfeSefazRefECF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRefECF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazRefECF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRefECF" /> class.
        /// </summary>
        /// <param name="mod">Código do modelo do Documento Fiscal  Preencher com \&quot;2B\&quot;, quando se tratar de Cupom Fiscal emitido por máquina registradora (não ECF), com \&quot;2C\&quot;, quando se tratar de Cupom Fiscal PDV, ou \&quot;2D\&quot;, quando se tratar de Cupom Fiscal (emitido por ECF). (required).</param>
        /// <param name="nECF">Informar o número de ordem seqüencial do ECF que emitiu o Cupom Fiscal vinculado à NF-e. (required).</param>
        /// <param name="nCOO">Informar o Número do Contador de Ordem de Operação - COO vinculado à NF-e. (required).</param>
        public NfeSefazRefECF(string mod = default(string), int? nECF = default(int?), int? nCOO = default(int?))
        {
            // to ensure "mod" is required (not null)
            if (mod == null)
            {
                throw new ArgumentNullException("mod is a required property for NfeSefazRefECF and cannot be null");
            }
            this.mod = mod;
            // to ensure "nECF" is required (not null)
            if (nECF == null)
            {
                throw new ArgumentNullException("nECF is a required property for NfeSefazRefECF and cannot be null");
            }
            this.nECF = nECF;
            // to ensure "nCOO" is required (not null)
            if (nCOO == null)
            {
                throw new ArgumentNullException("nCOO is a required property for NfeSefazRefECF and cannot be null");
            }
            this.nCOO = nCOO;
        }

        /// <summary>
        /// Código do modelo do Documento Fiscal  Preencher com \&quot;2B\&quot;, quando se tratar de Cupom Fiscal emitido por máquina registradora (não ECF), com \&quot;2C\&quot;, quando se tratar de Cupom Fiscal PDV, ou \&quot;2D\&quot;, quando se tratar de Cupom Fiscal (emitido por ECF).
        /// </summary>
        /// <value>Código do modelo do Documento Fiscal  Preencher com \&quot;2B\&quot;, quando se tratar de Cupom Fiscal emitido por máquina registradora (não ECF), com \&quot;2C\&quot;, quando se tratar de Cupom Fiscal PDV, ou \&quot;2D\&quot;, quando se tratar de Cupom Fiscal (emitido por ECF).</value>
        [DataMember(Name = "mod", IsRequired = true, EmitDefaultValue = true)]
        public string mod { get; set; }

        /// <summary>
        /// Informar o número de ordem seqüencial do ECF que emitiu o Cupom Fiscal vinculado à NF-e.
        /// </summary>
        /// <value>Informar o número de ordem seqüencial do ECF que emitiu o Cupom Fiscal vinculado à NF-e.</value>
        [DataMember(Name = "nECF", IsRequired = true, EmitDefaultValue = true)]
        public int? nECF { get; set; }

        /// <summary>
        /// Informar o Número do Contador de Ordem de Operação - COO vinculado à NF-e.
        /// </summary>
        /// <value>Informar o Número do Contador de Ordem de Operação - COO vinculado à NF-e.</value>
        [DataMember(Name = "nCOO", IsRequired = true, EmitDefaultValue = true)]
        public int? nCOO { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRefECF {\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  nECF: ").Append(nECF).Append("\n");
            sb.Append("  nCOO: ").Append(nCOO).Append("\n");
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
            return this.Equals(input as NfeSefazRefECF);
        }

        /// <summary>
        /// Returns true if NfeSefazRefECF instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRefECF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRefECF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.mod == input.mod ||
                    (this.mod != null &&
                    this.mod.Equals(input.mod))
                ) && 
                (
                    this.nECF == input.nECF ||
                    (this.nECF != null &&
                    this.nECF.Equals(input.nECF))
                ) && 
                (
                    this.nCOO == input.nCOO ||
                    (this.nCOO != null &&
                    this.nCOO.Equals(input.nCOO))
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
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.nECF != null)
                {
                    hashCode = (hashCode * 59) + this.nECF.GetHashCode();
                }
                if (this.nCOO != null)
                {
                    hashCode = (hashCode * 59) + this.nCOO.GetHashCode();
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
            // nECF (int?) maximum
            if (this.nECF > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nECF, must be a value less than or equal to 999.", new [] { "nECF" });
            }

            // nECF (int?) minimum
            if (this.nECF < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nECF, must be a value greater than or equal to 0.", new [] { "nECF" });
            }

            // nCOO (int?) maximum
            if (this.nCOO > (int?)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nCOO, must be a value less than or equal to 999999.", new [] { "nCOO" });
            }

            // nCOO (int?) minimum
            if (this.nCOO < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nCOO, must be a value greater than or equal to 0.", new [] { "nCOO" });
            }

            yield break;
        }
    }

}
