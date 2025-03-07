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
    /// Grupo indicador da origem do combustível.
    /// </summary>
    [DataContract(Name = "NfeSefazOrigComb")]
    public partial class NfeSefazOrigComb : IEquatable<NfeSefazOrigComb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazOrigComb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazOrigComb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazOrigComb" /> class.
        /// </summary>
        /// <param name="indImport">Indicador de importação 0&#x3D;Nacional  * 1 - Importado (required).</param>
        /// <param name="cUFOrig">UF de origem do produtor ou do importado. (required).</param>
        /// <param name="pOrig">Percentual originário para a UF. (required).</param>
        public NfeSefazOrigComb(int? indImport = default(int?), int? cUFOrig = default(int?), decimal? pOrig = default(decimal?))
        {
            // to ensure "indImport" is required (not null)
            if (indImport == null)
            {
                throw new ArgumentNullException("indImport is a required property for NfeSefazOrigComb and cannot be null");
            }
            this.indImport = indImport;
            // to ensure "cUFOrig" is required (not null)
            if (cUFOrig == null)
            {
                throw new ArgumentNullException("cUFOrig is a required property for NfeSefazOrigComb and cannot be null");
            }
            this.cUFOrig = cUFOrig;
            // to ensure "pOrig" is required (not null)
            if (pOrig == null)
            {
                throw new ArgumentNullException("pOrig is a required property for NfeSefazOrigComb and cannot be null");
            }
            this.pOrig = pOrig;
        }

        /// <summary>
        /// Indicador de importação 0&#x3D;Nacional  * 1 - Importado
        /// </summary>
        /// <value>Indicador de importação 0&#x3D;Nacional  * 1 - Importado</value>
        [DataMember(Name = "indImport", IsRequired = true, EmitDefaultValue = true)]
        public int? indImport { get; set; }

        /// <summary>
        /// UF de origem do produtor ou do importado.
        /// </summary>
        /// <value>UF de origem do produtor ou do importado.</value>
        [DataMember(Name = "cUFOrig", IsRequired = true, EmitDefaultValue = true)]
        public int? cUFOrig { get; set; }

        /// <summary>
        /// Percentual originário para a UF.
        /// </summary>
        /// <value>Percentual originário para a UF.</value>
        [DataMember(Name = "pOrig", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pOrig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazOrigComb {\n");
            sb.Append("  indImport: ").Append(indImport).Append("\n");
            sb.Append("  cUFOrig: ").Append(cUFOrig).Append("\n");
            sb.Append("  pOrig: ").Append(pOrig).Append("\n");
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
            return this.Equals(input as NfeSefazOrigComb);
        }

        /// <summary>
        /// Returns true if NfeSefazOrigComb instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazOrigComb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazOrigComb input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.indImport == input.indImport ||
                    (this.indImport != null &&
                    this.indImport.Equals(input.indImport))
                ) && 
                (
                    this.cUFOrig == input.cUFOrig ||
                    (this.cUFOrig != null &&
                    this.cUFOrig.Equals(input.cUFOrig))
                ) && 
                (
                    this.pOrig == input.pOrig ||
                    (this.pOrig != null &&
                    this.pOrig.Equals(input.pOrig))
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
                if (this.indImport != null)
                {
                    hashCode = (hashCode * 59) + this.indImport.GetHashCode();
                }
                if (this.cUFOrig != null)
                {
                    hashCode = (hashCode * 59) + this.cUFOrig.GetHashCode();
                }
                if (this.pOrig != null)
                {
                    hashCode = (hashCode * 59) + this.pOrig.GetHashCode();
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
            // pOrig (decimal?) maximum
            if (this.pOrig > (decimal?)1E+2)
            {
                yield return new ValidationResult("Invalid value for pOrig, must be a value less than or equal to 1E+2.", new [] { "pOrig" });
            }

            // pOrig (decimal?) minimum
            if (this.pOrig < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pOrig, must be a value greater than or equal to 0.", new [] { "pOrig" });
            }

            yield break;
        }
    }

}
