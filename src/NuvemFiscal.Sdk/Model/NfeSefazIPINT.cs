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
    /// NfeSefazIPINT
    /// </summary>
    [DataContract(Name = "NfeSefazIPINT")]
    public partial class NfeSefazIPINT : IEquatable<NfeSefazIPINT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIPINT" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazIPINT() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIPINT" /> class.
        /// </summary>
        /// <param name="cST">Código da Situação Tributária do IPI:  * 01 - Entrada tributada com alíquota zero  * 02 - Entrada isenta  * 03 - Entrada não-tributada  * 04 - Entrada imune  * 05 - Entrada com suspensão  * 51 - Saída tributada com alíquota zero  * 52 - Saída isenta  * 53 - Saída não-tributada  * 54 - Saída imune  * 55 - Saída com suspensão (required).</param>
        public NfeSefazIPINT(string cST = default(string))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazIPINT and cannot be null");
            }
            this.CST = cST;
        }

        /// <summary>
        /// Código da Situação Tributária do IPI:  * 01 - Entrada tributada com alíquota zero  * 02 - Entrada isenta  * 03 - Entrada não-tributada  * 04 - Entrada imune  * 05 - Entrada com suspensão  * 51 - Saída tributada com alíquota zero  * 52 - Saída isenta  * 53 - Saída não-tributada  * 54 - Saída imune  * 55 - Saída com suspensão
        /// </summary>
        /// <value>Código da Situação Tributária do IPI:  * 01 - Entrada tributada com alíquota zero  * 02 - Entrada isenta  * 03 - Entrada não-tributada  * 04 - Entrada imune  * 05 - Entrada com suspensão  * 51 - Saída tributada com alíquota zero  * 52 - Saída isenta  * 53 - Saída não-tributada  * 54 - Saída imune  * 55 - Saída com suspensão</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazIPINT {\n");
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
            return this.Equals(input as NfeSefazIPINT);
        }

        /// <summary>
        /// Returns true if NfeSefazIPINT instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazIPINT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazIPINT input)
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
