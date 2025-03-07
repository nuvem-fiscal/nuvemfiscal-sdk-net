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
    /// DfePedidoEnvioEmail
    /// </summary>
    [DataContract(Name = "DfePedidoEnvioEmail")]
    public partial class DfePedidoEnvioEmail : IEquatable<DfePedidoEnvioEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfePedidoEnvioEmail" /> class.
        /// </summary>
        /// <param name="destinatarios">Lista de endereços de email para envio dos arquivos.    *Caso nenhum email seja informado, será utilizado o email do destinatário do documento fiscal.*.</param>
        public DfePedidoEnvioEmail(List<EnderecoEmail> destinatarios = default(List<EnderecoEmail>))
        {
            this.destinatarios = destinatarios;
        }

        /// <summary>
        /// Lista de endereços de email para envio dos arquivos.    *Caso nenhum email seja informado, será utilizado o email do destinatário do documento fiscal.*
        /// </summary>
        /// <value>Lista de endereços de email para envio dos arquivos.    *Caso nenhum email seja informado, será utilizado o email do destinatário do documento fiscal.*</value>
        [DataMember(Name = "destinatarios", EmitDefaultValue = false)]
        public List<EnderecoEmail> destinatarios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfePedidoEnvioEmail {\n");
            sb.Append("  destinatarios: ").Append(destinatarios).Append("\n");
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
            return this.Equals(input as DfePedidoEnvioEmail);
        }

        /// <summary>
        /// Returns true if DfePedidoEnvioEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of DfePedidoEnvioEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfePedidoEnvioEmail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.destinatarios == input.destinatarios ||
                    this.destinatarios != null &&
                    input.destinatarios != null &&
                    this.destinatarios.SequenceEqual(input.destinatarios)
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
                if (this.destinatarios != null)
                {
                    hashCode = (hashCode * 59) + this.destinatarios.GetHashCode();
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
