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
    /// RpsIdentificacaoPrestador
    /// </summary>
    [DataContract(Name = "RpsIdentificacaoPrestador")]
    public partial class RpsIdentificacaoPrestador : IEquatable<RpsIdentificacaoPrestador>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsIdentificacaoPrestador" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RpsIdentificacaoPrestador() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsIdentificacaoPrestador" /> class.
        /// </summary>
        /// <param name="cpfCnpj">CPF ou CNPJ do prestador.  Utilize o valor sem máscara. (required).</param>
        public RpsIdentificacaoPrestador(string cpfCnpj = default(string))
        {
            // to ensure "cpfCnpj" is required (not null)
            if (cpfCnpj == null)
            {
                throw new ArgumentNullException("cpfCnpj is a required property for RpsIdentificacaoPrestador and cannot be null");
            }
            this.cpf_cnpj = cpfCnpj;
        }

        /// <summary>
        /// CPF ou CNPJ do prestador.  Utilize o valor sem máscara.
        /// </summary>
        /// <value>CPF ou CNPJ do prestador.  Utilize o valor sem máscara.</value>
        [DataMember(Name = "cpf_cnpj", IsRequired = true, EmitDefaultValue = true)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsIdentificacaoPrestador {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
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
            return this.Equals(input as RpsIdentificacaoPrestador);
        }

        /// <summary>
        /// Returns true if RpsIdentificacaoPrestador instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsIdentificacaoPrestador to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsIdentificacaoPrestador input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cpf_cnpj == input.cpf_cnpj ||
                    (this.cpf_cnpj != null &&
                    this.cpf_cnpj.Equals(input.cpf_cnpj))
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
                if (this.cpf_cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_cnpj.GetHashCode();
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
