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
    /// NfsePedidoSincronizacao
    /// </summary>
    [DataContract(Name = "NfsePedidoSincronizacao")]
    public partial class NfsePedidoSincronizacao : IEquatable<NfsePedidoSincronizacao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfsePedidoSincronizacao" /> class.
        /// </summary>
        /// <param name="identificador">Identificador utilizado na consulta da situação atual da NFS-e.    O valor desse campo é opcional para as prefeituras que suportem consultas por número e série do RPS.  Para as demais, esse campo torna-se obrigatório e o seu valor pode ser a chave de acesso, número da NFS-e, chave de verificação, protocolo ou outro identificador da nota a depender da prefeitura..</param>
        public NfsePedidoSincronizacao(string identificador = default(string))
        {
            this.identificador = identificador;
        }

        /// <summary>
        /// Identificador utilizado na consulta da situação atual da NFS-e.    O valor desse campo é opcional para as prefeituras que suportem consultas por número e série do RPS.  Para as demais, esse campo torna-se obrigatório e o seu valor pode ser a chave de acesso, número da NFS-e, chave de verificação, protocolo ou outro identificador da nota a depender da prefeitura.
        /// </summary>
        /// <value>Identificador utilizado na consulta da situação atual da NFS-e.    O valor desse campo é opcional para as prefeituras que suportem consultas por número e série do RPS.  Para as demais, esse campo torna-se obrigatório e o seu valor pode ser a chave de acesso, número da NFS-e, chave de verificação, protocolo ou outro identificador da nota a depender da prefeitura.</value>
        [DataMember(Name = "identificador", EmitDefaultValue = false)]
        public string identificador { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfsePedidoSincronizacao {\n");
            sb.Append("  identificador: ").Append(identificador).Append("\n");
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
            return this.Equals(input as NfsePedidoSincronizacao);
        }

        /// <summary>
        /// Returns true if NfsePedidoSincronizacao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfsePedidoSincronizacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfsePedidoSincronizacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.identificador == input.identificador ||
                    (this.identificador != null &&
                    this.identificador.Equals(input.identificador))
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
                if (this.identificador != null)
                {
                    hashCode = (hashCode * 59) + this.identificador.GetHashCode();
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
