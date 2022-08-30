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
    /// EmpresaPedidoCadastroCertificado
    /// </summary>
    [DataContract(Name = "EmpresaPedidoCadastroCertificado")]
    public partial class EmpresaPedidoCadastroCertificado : IEquatable<EmpresaPedidoCadastroCertificado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaPedidoCadastroCertificado" /> class.
        /// </summary>
        /// <param name="certificado">certificado.</param>
        /// <param name="password">password.</param>
        public EmpresaPedidoCadastroCertificado(byte[] certificado = default(byte[]), string password = default(string))
        {
            this.certificado = certificado;
            this.password = password;
        }

        /// <summary>
        /// Gets or Sets certificado
        /// </summary>
        [DataMember(Name = "certificado", EmitDefaultValue = false)]
        public byte[] certificado { get; set; }

        /// <summary>
        /// Gets or Sets password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaPedidoCadastroCertificado {\n");
            sb.Append("  certificado: ").Append(certificado).Append("\n");
            sb.Append("  password: ").Append(password).Append("\n");
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
            return this.Equals(input as EmpresaPedidoCadastroCertificado);
        }

        /// <summary>
        /// Returns true if EmpresaPedidoCadastroCertificado instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaPedidoCadastroCertificado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaPedidoCadastroCertificado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.certificado == input.certificado ||
                    (this.certificado != null &&
                    this.certificado.Equals(input.certificado))
                ) && 
                (
                    this.password == input.password ||
                    (this.password != null &&
                    this.password.Equals(input.password))
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
                if (this.certificado != null)
                {
                    hashCode = (hashCode * 59) + this.certificado.GetHashCode();
                }
                if (this.password != null)
                {
                    hashCode = (hashCode * 59) + this.password.GetHashCode();
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
