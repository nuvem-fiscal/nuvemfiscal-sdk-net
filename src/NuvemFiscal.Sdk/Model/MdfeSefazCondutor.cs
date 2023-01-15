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
    /// Informações do(s) Condutor(es) do veículo.
    /// </summary>
    [DataContract(Name = "MdfeSefazCondutor")]
    public partial class MdfeSefazCondutor : IEquatable<MdfeSefazCondutor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazCondutor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazCondutor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazCondutor" /> class.
        /// </summary>
        /// <param name="xNome">Nome do Condutor. (required).</param>
        /// <param name="cPF">CPF do Condutor. (required).</param>
        public MdfeSefazCondutor(string xNome = default(string), string cPF = default(string))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for MdfeSefazCondutor and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "cPF" is required (not null)
            if (cPF == null)
            {
                throw new ArgumentNullException("cPF is a required property for MdfeSefazCondutor and cannot be null");
            }
            this.CPF = cPF;
        }

        /// <summary>
        /// Nome do Condutor.
        /// </summary>
        /// <value>Nome do Condutor.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// CPF do Condutor.
        /// </summary>
        /// <value>CPF do Condutor.</value>
        [DataMember(Name = "CPF", IsRequired = true, EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazCondutor {\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
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
            return this.Equals(input as MdfeSefazCondutor);
        }

        /// <summary>
        /// Returns true if MdfeSefazCondutor instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazCondutor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazCondutor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
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
