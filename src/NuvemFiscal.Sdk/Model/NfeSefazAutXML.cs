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
    /// NfeSefazAutXML
    /// </summary>
    [DataContract(Name = "NfeSefazAutXML")]
    public partial class NfeSefazAutXML : IEquatable<NfeSefazAutXML>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazAutXML" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ Autorizado..</param>
        /// <param name="cPF">CPF Autorizado..</param>
        public NfeSefazAutXML(string cNPJ = default(string), string cPF = default(string))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
        }

        /// <summary>
        /// CNPJ Autorizado.
        /// </summary>
        /// <value>CNPJ Autorizado.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF Autorizado.
        /// </summary>
        /// <value>CPF Autorizado.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazAutXML {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
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
            return this.Equals(input as NfeSefazAutXML);
        }

        /// <summary>
        /// Returns true if NfeSefazAutXML instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazAutXML to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazAutXML input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
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
