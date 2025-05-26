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
    /// Dados do fretamento (apenas para Transporte de Pessoas).
    /// </summary>
    [DataContract(Name = "CteOsSefazInfFretamentoOS")]
    public partial class CteOsSefazInfFretamentoOS : IEquatable<CteOsSefazInfFretamentoOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfFretamentoOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfFretamentoOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfFretamentoOS" /> class.
        /// </summary>
        /// <param name="tpFretamento">Tipo Fretamento.  Preencher com:  * 1 - Eventual 2 - Continuo (required).</param>
        /// <param name="dhViagem">Data e hora da viagem (Apenas para fretamento eventual).  Formato AAAA-MM-DDTHH:MM:DD TZD..</param>
        public CteOsSefazInfFretamentoOS(int? tpFretamento = default(int?), DateTime? dhViagem = default(DateTime?))
        {
            // to ensure "tpFretamento" is required (not null)
            if (tpFretamento == null)
            {
                throw new ArgumentNullException("tpFretamento is a required property for CteOsSefazInfFretamentoOS and cannot be null");
            }
            this.tpFretamento = tpFretamento;
            this.dhViagem = dhViagem;
        }

        /// <summary>
        /// Tipo Fretamento.  Preencher com:  * 1 - Eventual 2 - Continuo
        /// </summary>
        /// <value>Tipo Fretamento.  Preencher com:  * 1 - Eventual 2 - Continuo</value>
        [DataMember(Name = "tpFretamento", IsRequired = true, EmitDefaultValue = true)]
        public int? tpFretamento { get; set; }

        /// <summary>
        /// Data e hora da viagem (Apenas para fretamento eventual).  Formato AAAA-MM-DDTHH:MM:DD TZD.
        /// </summary>
        /// <value>Data e hora da viagem (Apenas para fretamento eventual).  Formato AAAA-MM-DDTHH:MM:DD TZD.</value>
        [DataMember(Name = "dhViagem", EmitDefaultValue = true)]
        public DateTime? dhViagem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfFretamentoOS {\n");
            sb.Append("  tpFretamento: ").Append(tpFretamento).Append("\n");
            sb.Append("  dhViagem: ").Append(dhViagem).Append("\n");
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
            return this.Equals(input as CteOsSefazInfFretamentoOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfFretamentoOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfFretamentoOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfFretamentoOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpFretamento == input.tpFretamento ||
                    (this.tpFretamento != null &&
                    this.tpFretamento.Equals(input.tpFretamento))
                ) && 
                (
                    this.dhViagem == input.dhViagem ||
                    (this.dhViagem != null &&
                    this.dhViagem.Equals(input.dhViagem))
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
                if (this.tpFretamento != null)
                {
                    hashCode = (hashCode * 59) + this.tpFretamento.GetHashCode();
                }
                if (this.dhViagem != null)
                {
                    hashCode = (hashCode * 59) + this.dhViagem.GetHashCode();
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
            yield break;
        }
    }

}
