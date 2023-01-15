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
    [DataContract(Name = "CteSefazFluxo")]
    public partial class CteSefazFluxo : IEquatable<CteSefazFluxo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazFluxo" /> class.
        /// </summary>
        /// <param name="xOrig">Sigla ou código interno da Filial/Porto/Estação/ Aeroporto de Origem.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo..</param>
        /// <param name="pass">pass.</param>
        /// <param name="xDest">Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo..</param>
        /// <param name="xRota">Código da Rota de Entrega..</param>
        public CteSefazFluxo(string xOrig = default(string), List<CteSefazPass> pass = default(List<CteSefazPass>), string xDest = default(string), string xRota = default(string))
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
        [DataMember(Name = "xOrig", EmitDefaultValue = false)]
        public string xOrig { get; set; }

        /// <summary>
        /// Gets or Sets pass
        /// </summary>
        [DataMember(Name = "pass", EmitDefaultValue = false)]
        public List<CteSefazPass> pass { get; set; }

        /// <summary>
        /// Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo.
        /// </summary>
        /// <value>Sigla ou código interno da Filial/Porto/Estação/Aeroporto de Destino.  Observações para o modal aéreo:  * Preenchimento obrigatório para o modal aéreo.</value>
        [DataMember(Name = "xDest", EmitDefaultValue = false)]
        public string xDest { get; set; }

        /// <summary>
        /// Código da Rota de Entrega.
        /// </summary>
        /// <value>Código da Rota de Entrega.</value>
        [DataMember(Name = "xRota", EmitDefaultValue = false)]
        public string xRota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazFluxo {\n");
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
            return this.Equals(input as CteSefazFluxo);
        }

        /// <summary>
        /// Returns true if CteSefazFluxo instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazFluxo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazFluxo input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
