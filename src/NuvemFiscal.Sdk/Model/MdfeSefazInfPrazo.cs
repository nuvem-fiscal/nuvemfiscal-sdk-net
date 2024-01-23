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
    /// Informações do pagamento a prazo.  Informar somente se indPag for à Prazo.
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
        public MdfeSefazInfPrazo(int? nParcela = default(int?), DateTime? dVenc = default(DateTime?), decimal? vParcela = default(decimal?))
        {
            // to ensure "nParcela" is required (not null)
            if (nParcela == null)
            {
                throw new ArgumentNullException("nParcela is a required property for MdfeSefazInfPrazo and cannot be null");
            }
            this.nParcela = nParcela;
            // to ensure "dVenc" is required (not null)
            if (dVenc == null)
            {
                throw new ArgumentNullException("dVenc is a required property for MdfeSefazInfPrazo and cannot be null");
            }
            this.dVenc = dVenc;
            // to ensure "vParcela" is required (not null)
            if (vParcela == null)
            {
                throw new ArgumentNullException("vParcela is a required property for MdfeSefazInfPrazo and cannot be null");
            }
            this.vParcela = vParcela;
        }

        /// <summary>
        /// Número da Parcela.
        /// </summary>
        /// <value>Número da Parcela.</value>
        [DataMember(Name = "nParcela", IsRequired = true, EmitDefaultValue = true)]
        public int? nParcela { get; set; }

        /// <summary>
        /// Data de vencimento da Parcela (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de vencimento da Parcela (AAAA-MM-DD).</value>
        [DataMember(Name = "dVenc", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dVenc { get; set; }

        /// <summary>
        /// Valor da Parcela.
        /// </summary>
        /// <value>Valor da Parcela.</value>
        [DataMember(Name = "vParcela", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vParcela { get; set; }

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
                    (this.nParcela != null &&
                    this.nParcela.Equals(input.nParcela))
                ) && 
                (
                    this.dVenc == input.dVenc ||
                    (this.dVenc != null &&
                    this.dVenc.Equals(input.dVenc))
                ) && 
                (
                    this.vParcela == input.vParcela ||
                    (this.vParcela != null &&
                    this.vParcela.Equals(input.vParcela))
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
                if (this.nParcela != null)
                {
                    hashCode = (hashCode * 59) + this.nParcela.GetHashCode();
                }
                if (this.dVenc != null)
                {
                    hashCode = (hashCode * 59) + this.dVenc.GetHashCode();
                }
                if (this.vParcela != null)
                {
                    hashCode = (hashCode * 59) + this.vParcela.GetHashCode();
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
            // nParcela (int?) maximum
            if (this.nParcela > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nParcela, must be a value less than or equal to 999.", new [] { "nParcela" });
            }

            // nParcela (int?) minimum
            if (this.nParcela < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nParcela, must be a value greater than or equal to 0.", new [] { "nParcela" });
            }

            yield break;
        }
    }

}
