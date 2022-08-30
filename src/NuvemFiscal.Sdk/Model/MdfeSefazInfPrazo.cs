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
    /// MdfeSefazInfPrazo
    /// </summary>
    [DataContract(Name = "MdfeSefazInfPrazo")]
    public partial class MdfeSefazInfPrazo : IEquatable<MdfeSefazInfPrazo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPrazo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfPrazo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPrazo" /> class.
        /// </summary>
        /// <param name="nParcela">Número da Parcela. (required).</param>
        /// <param name="dVenc">Data de vencimento da Parcela (AAAA-MM-DD). (required).</param>
        /// <param name="vParcela">Valor da Parcela. (required).</param>
        public MdfeSefazInfPrazo(int nParcela = default(int), DateTime dVenc = default(DateTime), decimal vParcela = default(decimal))
        {
            this.nParcela = nParcela;
            this.dVenc = dVenc;
            this.vParcela = vParcela;
        }

        /// <summary>
        /// Número da Parcela.
        /// </summary>
        /// <value>Número da Parcela.</value>
        [DataMember(Name = "nParcela", IsRequired = true, EmitDefaultValue = false)]
        public int nParcela { get; set; }

        /// <summary>
        /// Data de vencimento da Parcela (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de vencimento da Parcela (AAAA-MM-DD).</value>
        [DataMember(Name = "dVenc", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dVenc { get; set; }

        /// <summary>
        /// Valor da Parcela.
        /// </summary>
        /// <value>Valor da Parcela.</value>
        [DataMember(Name = "vParcela", IsRequired = true, EmitDefaultValue = false)]
        public decimal vParcela { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfPrazo {\n");
            sb.Append("  nParcela: ").Append(nParcela).Append("\n");
            sb.Append("  dVenc: ").Append(dVenc).Append("\n");
            sb.Append("  vParcela: ").Append(vParcela).Append("\n");
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
            return this.Equals(input as MdfeSefazInfPrazo);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfPrazo instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfPrazo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfPrazo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nParcela == input.nParcela ||
                    this.nParcela.Equals(input.nParcela)
                ) && 
                (
                    this.dVenc == input.dVenc ||
                    (this.dVenc != null &&
                    this.dVenc.Equals(input.dVenc))
                ) && 
                (
                    this.vParcela == input.vParcela ||
                    this.vParcela.Equals(input.vParcela)
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
                hashCode = (hashCode * 59) + this.nParcela.GetHashCode();
                if (this.dVenc != null)
                {
                    hashCode = (hashCode * 59) + this.dVenc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vParcela.GetHashCode();
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
