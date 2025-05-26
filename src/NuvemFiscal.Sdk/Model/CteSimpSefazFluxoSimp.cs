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
    /// Previsão do fluxo da carga.  Preenchimento obrigatório para o modal aéreo.
    /// </summary>
    [DataContract(Name = "CteSimpSefazFluxoSimp")]
    public partial class CteSimpSefazFluxoSimp : IEquatable<CteSimpSefazFluxoSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazFluxoSimp" /> class.
        /// </summary>
        /// <param name="xOrig">Sigla ou código interno da Filial/Porto/Estação/ Aeroporto de Origem.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo..</param>
        /// <param name="pass">pass.</param>
        /// <param name="xDest">Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo..</param>
        /// <param name="xRota">Código da Rota de Entrega..</param>
        public CteSimpSefazFluxoSimp(string xOrig = default(string), List<CteSimpSefazPassSimp> pass = default(List<CteSimpSefazPassSimp>), string xDest = default(string), string xRota = default(string))
        {
            this.xOrig = xOrig;
            this.pass = pass;
            this.xDest = xDest;
            this.xRota = xRota;
        }

        /// <summary>
        /// Sigla ou código interno da Filial/Porto/Estação/ Aeroporto de Origem.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo.
        /// </summary>
        /// <value>Sigla ou código interno da Filial/Porto/Estação/ Aeroporto de Origem.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo.</value>
        [DataMember(Name = "xOrig", EmitDefaultValue = true)]
        public string xOrig { get; set; }

        /// <summary>
        /// Gets or Sets pass
        /// </summary>
        [DataMember(Name = "pass", EmitDefaultValue = false)]
        public List<CteSimpSefazPassSimp> pass { get; set; }

        /// <summary>
        /// Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo.
        /// </summary>
        /// <value>Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo.</value>
        [DataMember(Name = "xDest", EmitDefaultValue = true)]
        public string xDest { get; set; }

        /// <summary>
        /// Código da Rota de Entrega.
        /// </summary>
        /// <value>Código da Rota de Entrega.</value>
        [DataMember(Name = "xRota", EmitDefaultValue = true)]
        public string xRota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazFluxoSimp {\n");
            sb.Append("  xOrig: ").Append(xOrig).Append("\n");
            sb.Append("  pass: ").Append(pass).Append("\n");
            sb.Append("  xDest: ").Append(xDest).Append("\n");
            sb.Append("  xRota: ").Append(xRota).Append("\n");
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
            return this.Equals(input as CteSimpSefazFluxoSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazFluxoSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazFluxoSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazFluxoSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xOrig == input.xOrig ||
                    (this.xOrig != null &&
                    this.xOrig.Equals(input.xOrig))
                ) && 
                (
                    this.pass == input.pass ||
                    this.pass != null &&
                    input.pass != null &&
                    this.pass.SequenceEqual(input.pass)
                ) && 
                (
                    this.xDest == input.xDest ||
                    (this.xDest != null &&
                    this.xDest.Equals(input.xDest))
                ) && 
                (
                    this.xRota == input.xRota ||
                    (this.xRota != null &&
                    this.xRota.Equals(input.xRota))
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
                if (this.xOrig != null)
                {
                    hashCode = (hashCode * 59) + this.xOrig.GetHashCode();
                }
                if (this.pass != null)
                {
                    hashCode = (hashCode * 59) + this.pass.GetHashCode();
                }
                if (this.xDest != null)
                {
                    hashCode = (hashCode * 59) + this.xDest.GetHashCode();
                }
                if (this.xRota != null)
                {
                    hashCode = (hashCode * 59) + this.xRota.GetHashCode();
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
            // xOrig (string) maxLength
            if (this.xOrig != null && this.xOrig.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xOrig, length must be less than 60.", new [] { "xOrig" });
            }

            // xOrig (string) minLength
            if (this.xOrig != null && this.xOrig.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xOrig, length must be greater than 1.", new [] { "xOrig" });
            }

            // xDest (string) maxLength
            if (this.xDest != null && this.xDest.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xDest, length must be less than 60.", new [] { "xDest" });
            }

            // xDest (string) minLength
            if (this.xDest != null && this.xDest.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xDest, length must be greater than 1.", new [] { "xDest" });
            }

            // xRota (string) maxLength
            if (this.xRota != null && this.xRota.Length > 10)
            {
                yield return new ValidationResult("Invalid value for xRota, length must be less than 10.", new [] { "xRota" });
            }

            // xRota (string) minLength
            if (this.xRota != null && this.xRota.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xRota, length must be greater than 1.", new [] { "xRota" });
            }

            yield break;
        }
    }

}
