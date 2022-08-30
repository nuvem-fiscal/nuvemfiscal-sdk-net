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
    /// DfeRecibo
    /// </summary>
    [DataContract(Name = "DfeRecibo")]
    public partial class DfeRecibo : IEquatable<DfeRecibo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeRecibo" /> class.
        /// </summary>
        /// <param name="numero">Número do Recibo.</param>
        /// <param name="codigoStatus">Código do status da mensagem enviada..</param>
        /// <param name="motivoStatus">Descrição literal do status do serviço solicitado..</param>
        /// <param name="dataRecebimento">Data e hora de processamento..</param>
        /// <param name="codigoMensagem">Código da Mensagem..</param>
        /// <param name="mensagem">Mensagem da SEFAZ para o emissor..</param>
        public DfeRecibo(string numero = default(string), int codigoStatus = default(int), string motivoStatus = default(string), DateTime dataRecebimento = default(DateTime), int codigoMensagem = default(int), string mensagem = default(string))
        {
            this.numero = numero;
            this.codigo_status = codigoStatus;
            this.motivo_status = motivoStatus;
            this.data_recebimento = dataRecebimento;
            this.codigo_mensagem = codigoMensagem;
            this.mensagem = mensagem;
        }

        /// <summary>
        /// Número do Recibo
        /// </summary>
        /// <value>Número do Recibo</value>
        [DataMember(Name = "numero", EmitDefaultValue = false)]
        public string numero { get; set; }

        /// <summary>
        /// Código do status da mensagem enviada.
        /// </summary>
        /// <value>Código do status da mensagem enviada.</value>
        [DataMember(Name = "codigo_status", EmitDefaultValue = false)]
        public int codigo_status { get; set; }

        /// <summary>
        /// Descrição literal do status do serviço solicitado.
        /// </summary>
        /// <value>Descrição literal do status do serviço solicitado.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = false)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Data e hora de processamento.
        /// </summary>
        /// <value>Data e hora de processamento.</value>
        [DataMember(Name = "data_recebimento", EmitDefaultValue = false)]
        public DateTime data_recebimento { get; set; }

        /// <summary>
        /// Código da Mensagem.
        /// </summary>
        /// <value>Código da Mensagem.</value>
        [DataMember(Name = "codigo_mensagem", EmitDefaultValue = false)]
        public int codigo_mensagem { get; set; }

        /// <summary>
        /// Mensagem da SEFAZ para o emissor.
        /// </summary>
        /// <value>Mensagem da SEFAZ para o emissor.</value>
        [DataMember(Name = "mensagem", EmitDefaultValue = false)]
        public string mensagem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeRecibo {\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  data_recebimento: ").Append(data_recebimento).Append("\n");
            sb.Append("  codigo_mensagem: ").Append(codigo_mensagem).Append("\n");
            sb.Append("  mensagem: ").Append(mensagem).Append("\n");
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
            return this.Equals(input as DfeRecibo);
        }

        /// <summary>
        /// Returns true if DfeRecibo instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeRecibo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeRecibo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.numero == input.numero ||
                    (this.numero != null &&
                    this.numero.Equals(input.numero))
                ) && 
                (
                    this.codigo_status == input.codigo_status ||
                    this.codigo_status.Equals(input.codigo_status)
                ) && 
                (
                    this.motivo_status == input.motivo_status ||
                    (this.motivo_status != null &&
                    this.motivo_status.Equals(input.motivo_status))
                ) && 
                (
                    this.data_recebimento == input.data_recebimento ||
                    (this.data_recebimento != null &&
                    this.data_recebimento.Equals(input.data_recebimento))
                ) && 
                (
                    this.codigo_mensagem == input.codigo_mensagem ||
                    this.codigo_mensagem.Equals(input.codigo_mensagem)
                ) && 
                (
                    this.mensagem == input.mensagem ||
                    (this.mensagem != null &&
                    this.mensagem.Equals(input.mensagem))
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
                if (this.numero != null)
                {
                    hashCode = (hashCode * 59) + this.numero.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.data_recebimento != null)
                {
                    hashCode = (hashCode * 59) + this.data_recebimento.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_mensagem.GetHashCode();
                if (this.mensagem != null)
                {
                    hashCode = (hashCode * 59) + this.mensagem.GetHashCode();
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
