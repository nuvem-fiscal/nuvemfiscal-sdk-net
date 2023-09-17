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
    /// Grupo de informações específicas de endereço nacional.
    /// </summary>
    [DataContract(Name = "EnderNac")]
    public partial class EnderNac : IEquatable<EnderNac>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderNac" /> class.
        /// </summary>
        /// <param name="cMun">Código do município, conforme Tabela do IBGE..</param>
        /// <param name="cEP">Número do CEP..</param>
        public EnderNac(string cMun = default(string), string cEP = default(string))
        {
            this.cMun = cMun;
            this.CEP = cEP;
        }

        /// <summary>
        /// Código do município, conforme Tabela do IBGE.
        /// </summary>
        /// <value>Código do município, conforme Tabela do IBGE.</value>
        [DataMember(Name = "cMun", EmitDefaultValue = true)]
        public string cMun { get; set; }

        /// <summary>
        /// Número do CEP.
        /// </summary>
        /// <value>Número do CEP.</value>
        [DataMember(Name = "CEP", EmitDefaultValue = true)]
        public string CEP { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnderNac {\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
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
            return this.Equals(input as EnderNac);
        }

        /// <summary>
        /// Returns true if EnderNac instances are equal
        /// </summary>
        /// <param name="input">Instance of EnderNac to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderNac input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cMun == input.cMun ||
                    (this.cMun != null &&
                    this.cMun.Equals(input.cMun))
                ) && 
                (
                    this.CEP == input.CEP ||
                    (this.CEP != null &&
                    this.CEP.Equals(input.CEP))
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
                if (this.cMun != null)
                {
                    hashCode = (hashCode * 59) + this.cMun.GetHashCode();
                }
                if (this.CEP != null)
                {
                    hashCode = (hashCode * 59) + this.CEP.GetHashCode();
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
