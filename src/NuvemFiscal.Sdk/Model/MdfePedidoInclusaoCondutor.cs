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
    /// MdfePedidoInclusaoCondutor
    /// </summary>
    [DataContract(Name = "MdfePedidoInclusaoCondutor")]
    public partial class MdfePedidoInclusaoCondutor : IEquatable<MdfePedidoInclusaoCondutor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoInclusaoCondutor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfePedidoInclusaoCondutor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoInclusaoCondutor" /> class.
        /// </summary>
        /// <param name="nomeCondutor">Nome do condutor. (required).</param>
        /// <param name="cpfCondutor">CPF do condutor. (required).</param>
        public MdfePedidoInclusaoCondutor(string nomeCondutor = default(string), string cpfCondutor = default(string))
        {
            // to ensure "nomeCondutor" is required (not null)
            if (nomeCondutor == null)
            {
                throw new ArgumentNullException("nomeCondutor is a required property for MdfePedidoInclusaoCondutor and cannot be null");
            }
            this.nome_condutor = nomeCondutor;
            // to ensure "cpfCondutor" is required (not null)
            if (cpfCondutor == null)
            {
                throw new ArgumentNullException("cpfCondutor is a required property for MdfePedidoInclusaoCondutor and cannot be null");
            }
            this.cpf_condutor = cpfCondutor;
        }

        /// <summary>
        /// Nome do condutor.
        /// </summary>
        /// <value>Nome do condutor.</value>
        [DataMember(Name = "nome_condutor", IsRequired = true, EmitDefaultValue = true)]
        public string nome_condutor { get; set; }

        /// <summary>
        /// CPF do condutor.
        /// </summary>
        /// <value>CPF do condutor.</value>
        [DataMember(Name = "cpf_condutor", IsRequired = true, EmitDefaultValue = true)]
        public string cpf_condutor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfePedidoInclusaoCondutor {\n");
            sb.Append("  nome_condutor: ").Append(nome_condutor).Append("\n");
            sb.Append("  cpf_condutor: ").Append(cpf_condutor).Append("\n");
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
            return this.Equals(input as MdfePedidoInclusaoCondutor);
        }

        /// <summary>
        /// Returns true if MdfePedidoInclusaoCondutor instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfePedidoInclusaoCondutor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfePedidoInclusaoCondutor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nome_condutor == input.nome_condutor ||
                    (this.nome_condutor != null &&
                    this.nome_condutor.Equals(input.nome_condutor))
                ) && 
                (
                    this.cpf_condutor == input.cpf_condutor ||
                    (this.cpf_condutor != null &&
                    this.cpf_condutor.Equals(input.cpf_condutor))
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
                if (this.nome_condutor != null)
                {
                    hashCode = (hashCode * 59) + this.nome_condutor.GetHashCode();
                }
                if (this.cpf_condutor != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_condutor.GetHashCode();
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
            // nome_condutor (string) maxLength
            if (this.nome_condutor != null && this.nome_condutor.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_condutor, length must be less than 60.", new [] { "nome_condutor" });
            }

            // nome_condutor (string) minLength
            if (this.nome_condutor != null && this.nome_condutor.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_condutor, length must be greater than 2.", new [] { "nome_condutor" });
            }

            yield break;
        }
    }

}
