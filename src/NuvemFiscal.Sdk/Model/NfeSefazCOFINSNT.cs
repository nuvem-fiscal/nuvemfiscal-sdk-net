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
    /// Código de Situação Tributária do COFINS:  * 04 - Operação Tributável - Tributação Monofásica - (Alíquota Zero)  * 06 - Operação Tributável - Alíquota Zero  * 07 - Operação Isenta da contribuição  * 08 - Operação Sem Incidência da contribuição  * 09 - Operação com suspensão da contribuição
    /// </summary>
    [DataContract(Name = "NfeSefazCOFINSNT")]
    public partial class NfeSefazCOFINSNT : IEquatable<NfeSefazCOFINSNT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSNT" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCOFINSNT() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSNT" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do COFINS:  * 04 - Operação Tributável - Tributação Monofásica - (Alíquota Zero)  * 05 - Operação Tributável (ST)  * 06 - Operação Tributável - Alíquota Zero  * 07 - Operação Isenta da contribuição  * 08 - Operação Sem Incidência da contribuição  * 09 - Operação com suspensão da contribuição (required).</param>
        public NfeSefazCOFINSNT(string cST = default(string))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazCOFINSNT and cannot be null");
            }
            this.CST = cST;
        }

        /// <summary>
        /// Código de Situação Tributária do COFINS:  * 04 - Operação Tributável - Tributação Monofásica - (Alíquota Zero)  * 05 - Operação Tributável (ST)  * 06 - Operação Tributável - Alíquota Zero  * 07 - Operação Isenta da contribuição  * 08 - Operação Sem Incidência da contribuição  * 09 - Operação com suspensão da contribuição
        /// </summary>
        /// <value>Código de Situação Tributária do COFINS:  * 04 - Operação Tributável - Tributação Monofásica - (Alíquota Zero)  * 05 - Operação Tributável (ST)  * 06 - Operação Tributável - Alíquota Zero  * 07 - Operação Isenta da contribuição  * 08 - Operação Sem Incidência da contribuição  * 09 - Operação com suspensão da contribuição</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCOFINSNT {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
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
            return this.Equals(input as NfeSefazCOFINSNT);
        }

        /// <summary>
        /// Returns true if NfeSefazCOFINSNT instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCOFINSNT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCOFINSNT input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
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
