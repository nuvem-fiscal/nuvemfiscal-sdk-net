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
    /// Benefício Municipal
    /// </summary>
    [DataContract(Name = "BeneficioMunicipal")]
    public partial class BeneficioMunicipal : IEquatable<BeneficioMunicipal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficioMunicipal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeneficioMunicipal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficioMunicipal" /> class.
        /// </summary>
        /// <param name="tpBM">Tipo do Benefício Municipal:  * 1 - Alíquota Diferenciada  * 2 - Redução da BC  * 3 - Isenção (required).</param>
        /// <param name="nBM">Identificador do benefício municipal parametrizado pelo município. (required).</param>
        /// <param name="vRedBCBM">Valor monetário informado pelo emitente para redução da base de cálculo (BC) do ISSQN devido a um Benefício Municipal (BM)..</param>
        /// <param name="pRedBCBM">Valor percentual informado pelo emitente para redução da base de cálculo (BC) do ISSQN devido a um Benefício Municipal (BM)..</param>
        public BeneficioMunicipal(int? tpBM = default(int?), string nBM = default(string), decimal? vRedBCBM = default(decimal?), decimal? pRedBCBM = default(decimal?))
        {
            // to ensure "tpBM" is required (not null)
            if (tpBM == null)
            {
                throw new ArgumentNullException("tpBM is a required property for BeneficioMunicipal and cannot be null");
            }
            this.tpBM = tpBM;
            // to ensure "nBM" is required (not null)
            if (nBM == null)
            {
                throw new ArgumentNullException("nBM is a required property for BeneficioMunicipal and cannot be null");
            }
            this.nBM = nBM;
            this.vRedBCBM = vRedBCBM;
            this.pRedBCBM = pRedBCBM;
        }

        /// <summary>
        /// Tipo do Benefício Municipal:  * 1 - Alíquota Diferenciada  * 2 - Redução da BC  * 3 - Isenção
        /// </summary>
        /// <value>Tipo do Benefício Municipal:  * 1 - Alíquota Diferenciada  * 2 - Redução da BC  * 3 - Isenção</value>
        [DataMember(Name = "tpBM", IsRequired = true, EmitDefaultValue = true)]
        public int? tpBM { get; set; }

        /// <summary>
        /// Identificador do benefício municipal parametrizado pelo município.
        /// </summary>
        /// <value>Identificador do benefício municipal parametrizado pelo município.</value>
        [DataMember(Name = "nBM", IsRequired = true, EmitDefaultValue = true)]
        public string nBM { get; set; }

        /// <summary>
        /// Valor monetário informado pelo emitente para redução da base de cálculo (BC) do ISSQN devido a um Benefício Municipal (BM).
        /// </summary>
        /// <value>Valor monetário informado pelo emitente para redução da base de cálculo (BC) do ISSQN devido a um Benefício Municipal (BM).</value>
        [DataMember(Name = "vRedBCBM", EmitDefaultValue = true)]
        public decimal? vRedBCBM { get; set; }

        /// <summary>
        /// Valor percentual informado pelo emitente para redução da base de cálculo (BC) do ISSQN devido a um Benefício Municipal (BM).
        /// </summary>
        /// <value>Valor percentual informado pelo emitente para redução da base de cálculo (BC) do ISSQN devido a um Benefício Municipal (BM).</value>
        [DataMember(Name = "pRedBCBM", EmitDefaultValue = true)]
        public decimal? pRedBCBM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BeneficioMunicipal {\n");
            sb.Append("  tpBM: ").Append(tpBM).Append("\n");
            sb.Append("  nBM: ").Append(nBM).Append("\n");
            sb.Append("  vRedBCBM: ").Append(vRedBCBM).Append("\n");
            sb.Append("  pRedBCBM: ").Append(pRedBCBM).Append("\n");
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
            return this.Equals(input as BeneficioMunicipal);
        }

        /// <summary>
        /// Returns true if BeneficioMunicipal instances are equal
        /// </summary>
        /// <param name="input">Instance of BeneficioMunicipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficioMunicipal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpBM == input.tpBM ||
                    (this.tpBM != null &&
                    this.tpBM.Equals(input.tpBM))
                ) && 
                (
                    this.nBM == input.nBM ||
                    (this.nBM != null &&
                    this.nBM.Equals(input.nBM))
                ) && 
                (
                    this.vRedBCBM == input.vRedBCBM ||
                    (this.vRedBCBM != null &&
                    this.vRedBCBM.Equals(input.vRedBCBM))
                ) && 
                (
                    this.pRedBCBM == input.pRedBCBM ||
                    (this.pRedBCBM != null &&
                    this.pRedBCBM.Equals(input.pRedBCBM))
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
                if (this.tpBM != null)
                {
                    hashCode = (hashCode * 59) + this.tpBM.GetHashCode();
                }
                if (this.nBM != null)
                {
                    hashCode = (hashCode * 59) + this.nBM.GetHashCode();
                }
                if (this.vRedBCBM != null)
                {
                    hashCode = (hashCode * 59) + this.vRedBCBM.GetHashCode();
                }
                if (this.pRedBCBM != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBCBM.GetHashCode();
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
