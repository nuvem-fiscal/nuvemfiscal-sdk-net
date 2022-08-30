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
    /// EmpresaConfigPrefeitura
    /// </summary>
    [DataContract(Name = "EmpresaConfigPrefeitura")]
    public partial class EmpresaConfigPrefeitura : IEquatable<EmpresaConfigPrefeitura>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigPrefeitura" /> class.
        /// </summary>
        /// <param name="login">login.</param>
        /// <param name="senha">senha.</param>
        /// <param name="token">token.</param>
        public EmpresaConfigPrefeitura(string login = default(string), string senha = default(string), string token = default(string))
        {
            this.login = login;
            this.senha = senha;
            this.token = token;
        }

        /// <summary>
        /// Gets or Sets login
        /// </summary>
        [DataMember(Name = "login", EmitDefaultValue = false)]
        public string login { get; set; }

        /// <summary>
        /// Gets or Sets senha
        /// </summary>
        [DataMember(Name = "senha", EmitDefaultValue = false)]
        public string senha { get; set; }

        /// <summary>
        /// Gets or Sets token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigPrefeitura {\n");
            sb.Append("  login: ").Append(login).Append("\n");
            sb.Append("  senha: ").Append(senha).Append("\n");
            sb.Append("  token: ").Append(token).Append("\n");
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
            return this.Equals(input as EmpresaConfigPrefeitura);
        }

        /// <summary>
        /// Returns true if EmpresaConfigPrefeitura instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigPrefeitura to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigPrefeitura input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.login == input.login ||
                    (this.login != null &&
                    this.login.Equals(input.login))
                ) && 
                (
                    this.senha == input.senha ||
                    (this.senha != null &&
                    this.senha.Equals(input.senha))
                ) && 
                (
                    this.token == input.token ||
                    (this.token != null &&
                    this.token.Equals(input.token))
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
                if (this.login != null)
                {
                    hashCode = (hashCode * 59) + this.login.GetHashCode();
                }
                if (this.senha != null)
                {
                    hashCode = (hashCode * 59) + this.senha.GetHashCode();
                }
                if (this.token != null)
                {
                    hashCode = (hashCode * 59) + this.token.GetHashCode();
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
