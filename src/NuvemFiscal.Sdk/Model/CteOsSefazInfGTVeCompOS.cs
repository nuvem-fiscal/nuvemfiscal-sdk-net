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
    /// Componentes do Valor da GTVe.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfGTVe_CompOS")]
    public partial class CteOsSefazInfGTVeCompOS : IEquatable<CteOsSefazInfGTVeCompOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfGTVeCompOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfGTVeCompOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfGTVeCompOS" /> class.
        /// </summary>
        /// <param name="tpComp">Tipo do Componente.  * 1 - Custodia  * 2 - Embarque  * 3 - Tempo de espera  * 4 - Malote  * 5 - Ad Valorem  * 6 - Outros (required).</param>
        /// <param name="vComp">Valor do componente. (required).</param>
        /// <param name="xComp">Nome do componente (informar apenas para outros).  Exemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc..</param>
        public CteOsSefazInfGTVeCompOS(int? tpComp = default(int?), decimal? vComp = default(decimal?), string xComp = default(string))
        {
            // to ensure "tpComp" is required (not null)
            if (tpComp == null)
            {
                throw new ArgumentNullException("tpComp is a required property for CteOsSefazInfGTVeCompOS and cannot be null");
            }
            this.tpComp = tpComp;
            // to ensure "vComp" is required (not null)
            if (vComp == null)
            {
                throw new ArgumentNullException("vComp is a required property for CteOsSefazInfGTVeCompOS and cannot be null");
            }
            this.vComp = vComp;
            this.xComp = xComp;
        }

        /// <summary>
        /// Tipo do Componente.  * 1 - Custodia  * 2 - Embarque  * 3 - Tempo de espera  * 4 - Malote  * 5 - Ad Valorem  * 6 - Outros
        /// </summary>
        /// <value>Tipo do Componente.  * 1 - Custodia  * 2 - Embarque  * 3 - Tempo de espera  * 4 - Malote  * 5 - Ad Valorem  * 6 - Outros</value>
        [DataMember(Name = "tpComp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpComp { get; set; }

        /// <summary>
        /// Valor do componente.
        /// </summary>
        /// <value>Valor do componente.</value>
        [DataMember(Name = "vComp", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vComp { get; set; }

        /// <summary>
        /// Nome do componente (informar apenas para outros).  Exemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc.
        /// </summary>
        /// <value>Nome do componente (informar apenas para outros).  Exemplos: FRETE PESO, FRETE VALOR, SEC/CAT, ADEME, AGENDAMENTO, etc.</value>
        [DataMember(Name = "xComp", EmitDefaultValue = true)]
        public string xComp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfGTVeCompOS {\n");
            sb.Append("  tpComp: ").Append(tpComp).Append("\n");
            sb.Append("  vComp: ").Append(vComp).Append("\n");
            sb.Append("  xComp: ").Append(xComp).Append("\n");
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
            return this.Equals(input as CteOsSefazInfGTVeCompOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfGTVeCompOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfGTVeCompOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfGTVeCompOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpComp == input.tpComp ||
                    (this.tpComp != null &&
                    this.tpComp.Equals(input.tpComp))
                ) && 
                (
                    this.vComp == input.vComp ||
                    (this.vComp != null &&
                    this.vComp.Equals(input.vComp))
                ) && 
                (
                    this.xComp == input.xComp ||
                    (this.xComp != null &&
                    this.xComp.Equals(input.xComp))
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
                if (this.tpComp != null)
                {
                    hashCode = (hashCode * 59) + this.tpComp.GetHashCode();
                }
                if (this.vComp != null)
                {
                    hashCode = (hashCode * 59) + this.vComp.GetHashCode();
                }
                if (this.xComp != null)
                {
                    hashCode = (hashCode * 59) + this.xComp.GetHashCode();
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
            // vComp (decimal?) minimum
            if (this.vComp < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vComp, must be a value greater than or equal to 0.", new [] { "vComp" });
            }

            // xComp (string) maxLength
            if (this.xComp != null && this.xComp.Length > 15)
            {
                yield return new ValidationResult("Invalid value for xComp, length must be less than 15.", new [] { "xComp" });
            }

            // xComp (string) minLength
            if (this.xComp != null && this.xComp.Length < 0)
            {
                yield return new ValidationResult("Invalid value for xComp, length must be greater than 0.", new [] { "xComp" });
            }

            yield break;
        }
    }

}
