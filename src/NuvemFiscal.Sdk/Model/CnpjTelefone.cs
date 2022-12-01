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
    /// CnpjTelefone
    /// </summary>
    [DataContract(Name = "CnpjTelefone")]
    public partial class CnpjTelefone : IEquatable<CnpjTelefone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjTelefone" /> class.
        /// </summary>
        /// <param name="ddd">Código de DDD (Discagem Direta à Distância).</param>
        /// <param name="numero">Número do telefone..</param>
        public CnpjTelefone(string ddd = default(string), string numero = default(string))
        {
            this.ddd = ddd;
            this.numero = numero;
        }

        /// <summary>
        /// Código de DDD (Discagem Direta à Distância)
        /// </summary>
        /// <value>Código de DDD (Discagem Direta à Distância)</value>
        [DataMember(Name = "ddd", EmitDefaultValue = false)]
        public string ddd { get; set; }

        /// <summary>
        /// Número do telefone.
        /// </summary>
        /// <value>Número do telefone.</value>
        [DataMember(Name = "numero", EmitDefaultValue = false)]
        public string numero { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjTelefone {\n");
            sb.Append("  ddd: ").Append(ddd).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
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
            return this.Equals(input as CnpjTelefone);
        }

        /// <summary>
        /// Returns true if CnpjTelefone instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjTelefone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjTelefone input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ddd == input.ddd ||
                    (this.ddd != null &&
                    this.ddd.Equals(input.ddd))
                ) && 
                (
                    this.numero == input.numero ||
                    (this.numero != null &&
                    this.numero.Equals(input.numero))
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
                if (this.ddd != null)
                {
                    hashCode = (hashCode * 59) + this.ddd.GetHashCode();
                }
                if (this.numero != null)
                {
                    hashCode = (hashCode * 59) + this.numero.GetHashCode();
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
