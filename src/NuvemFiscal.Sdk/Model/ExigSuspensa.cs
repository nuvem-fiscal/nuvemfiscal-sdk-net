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
    /// Informações para a suspensão da Exigibilidade do ISSQN.
    /// </summary>
    [DataContract(Name = "ExigSuspensa")]
    public partial class ExigSuspensa : IEquatable<ExigSuspensa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExigSuspensa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExigSuspensa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExigSuspensa" /> class.
        /// </summary>
        /// <param name="tpSusp">Opção para Exigibilidade Suspensa:  * 1 - Exigibilidade Suspensa por Decisão Judicial  * 2 - Exigibilidade Suspensa por Processo Administrativo (required).</param>
        /// <param name="nProcesso">Número do processo judicial ou administrativo de suspensão da exigibilidade. (required).</param>
        public ExigSuspensa(int? tpSusp = default(int?), string nProcesso = default(string))
        {
            // to ensure "tpSusp" is required (not null)
            if (tpSusp == null)
            {
                throw new ArgumentNullException("tpSusp is a required property for ExigSuspensa and cannot be null");
            }
            this.tpSusp = tpSusp;
            // to ensure "nProcesso" is required (not null)
            if (nProcesso == null)
            {
                throw new ArgumentNullException("nProcesso is a required property for ExigSuspensa and cannot be null");
            }
            this.nProcesso = nProcesso;
        }

        /// <summary>
        /// Opção para Exigibilidade Suspensa:  * 1 - Exigibilidade Suspensa por Decisão Judicial  * 2 - Exigibilidade Suspensa por Processo Administrativo
        /// </summary>
        /// <value>Opção para Exigibilidade Suspensa:  * 1 - Exigibilidade Suspensa por Decisão Judicial  * 2 - Exigibilidade Suspensa por Processo Administrativo</value>
        [DataMember(Name = "tpSusp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpSusp { get; set; }

        /// <summary>
        /// Número do processo judicial ou administrativo de suspensão da exigibilidade.
        /// </summary>
        /// <value>Número do processo judicial ou administrativo de suspensão da exigibilidade.</value>
        [DataMember(Name = "nProcesso", IsRequired = true, EmitDefaultValue = true)]
        public string nProcesso { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExigSuspensa {\n");
            sb.Append("  tpSusp: ").Append(tpSusp).Append("\n");
            sb.Append("  nProcesso: ").Append(nProcesso).Append("\n");
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
            return this.Equals(input as ExigSuspensa);
        }

        /// <summary>
        /// Returns true if ExigSuspensa instances are equal
        /// </summary>
        /// <param name="input">Instance of ExigSuspensa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExigSuspensa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpSusp == input.tpSusp ||
                    (this.tpSusp != null &&
                    this.tpSusp.Equals(input.tpSusp))
                ) && 
                (
                    this.nProcesso == input.nProcesso ||
                    (this.nProcesso != null &&
                    this.nProcesso.Equals(input.nProcesso))
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
                if (this.tpSusp != null)
                {
                    hashCode = (hashCode * 59) + this.tpSusp.GetHashCode();
                }
                if (this.nProcesso != null)
                {
                    hashCode = (hashCode * 59) + this.nProcesso.GetHashCode();
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
