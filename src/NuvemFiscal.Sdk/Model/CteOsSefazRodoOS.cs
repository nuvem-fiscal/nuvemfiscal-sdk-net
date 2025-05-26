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
    /// Informações do modal Rodoviário.
    /// </summary>
    [DataContract(Name = "CteOsSefazRodoOS")]
    public partial class CteOsSefazRodoOS : IEquatable<CteOsSefazRodoOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazRodoOS" /> class.
        /// </summary>
        /// <param name="tAF">Termo de Autorização de Fretamento - TAF.  Registro obrigatório do emitente do CT-e OS junto à ANTT, de acordo com a Resolução ANTT nº 4.777/2015..</param>
        /// <param name="nroRegEstadual">Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual..</param>
        /// <param name="veic">veic.</param>
        /// <param name="infFretamento">infFretamento.</param>
        public CteOsSefazRodoOS(string tAF = default(string), string nroRegEstadual = default(string), CteOsSefazVeicOS veic = default(CteOsSefazVeicOS), CteOsSefazInfFretamentoOS infFretamento = default(CteOsSefazInfFretamentoOS))
        {
            this.TAF = tAF;
            this.NroRegEstadual = nroRegEstadual;
            this.veic = veic;
            this.infFretamento = infFretamento;
        }

        /// <summary>
        /// Termo de Autorização de Fretamento - TAF.  Registro obrigatório do emitente do CT-e OS junto à ANTT, de acordo com a Resolução ANTT nº 4.777/2015.
        /// </summary>
        /// <value>Termo de Autorização de Fretamento - TAF.  Registro obrigatório do emitente do CT-e OS junto à ANTT, de acordo com a Resolução ANTT nº 4.777/2015.</value>
        [DataMember(Name = "TAF", EmitDefaultValue = true)]
        public string TAF { get; set; }

        /// <summary>
        /// Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual.
        /// </summary>
        /// <value>Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual.</value>
        [DataMember(Name = "NroRegEstadual", EmitDefaultValue = true)]
        public string NroRegEstadual { get; set; }

        /// <summary>
        /// Gets or Sets veic
        /// </summary>
        [DataMember(Name = "veic", EmitDefaultValue = false)]
        public CteOsSefazVeicOS veic { get; set; }

        /// <summary>
        /// Gets or Sets infFretamento
        /// </summary>
        [DataMember(Name = "infFretamento", EmitDefaultValue = false)]
        public CteOsSefazInfFretamentoOS infFretamento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazRodoOS {\n");
            sb.Append("  TAF: ").Append(TAF).Append("\n");
            sb.Append("  NroRegEstadual: ").Append(NroRegEstadual).Append("\n");
            sb.Append("  veic: ").Append(veic).Append("\n");
            sb.Append("  infFretamento: ").Append(infFretamento).Append("\n");
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
            return this.Equals(input as CteOsSefazRodoOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazRodoOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazRodoOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazRodoOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TAF == input.TAF ||
                    (this.TAF != null &&
                    this.TAF.Equals(input.TAF))
                ) && 
                (
                    this.NroRegEstadual == input.NroRegEstadual ||
                    (this.NroRegEstadual != null &&
                    this.NroRegEstadual.Equals(input.NroRegEstadual))
                ) && 
                (
                    this.veic == input.veic ||
                    (this.veic != null &&
                    this.veic.Equals(input.veic))
                ) && 
                (
                    this.infFretamento == input.infFretamento ||
                    (this.infFretamento != null &&
                    this.infFretamento.Equals(input.infFretamento))
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
                if (this.TAF != null)
                {
                    hashCode = (hashCode * 59) + this.TAF.GetHashCode();
                }
                if (this.NroRegEstadual != null)
                {
                    hashCode = (hashCode * 59) + this.NroRegEstadual.GetHashCode();
                }
                if (this.veic != null)
                {
                    hashCode = (hashCode * 59) + this.veic.GetHashCode();
                }
                if (this.infFretamento != null)
                {
                    hashCode = (hashCode * 59) + this.infFretamento.GetHashCode();
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
            // TAF (string) maxLength
            if (this.TAF != null && this.TAF.Length > 12)
            {
                yield return new ValidationResult("Invalid value for TAF, length must be less than 12.", new [] { "TAF" });
            }

            // NroRegEstadual (string) maxLength
            if (this.NroRegEstadual != null && this.NroRegEstadual.Length > 25)
            {
                yield return new ValidationResult("Invalid value for NroRegEstadual, length must be less than 25.", new [] { "NroRegEstadual" });
            }

            yield break;
        }
    }

}
