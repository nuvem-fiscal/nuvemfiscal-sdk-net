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
    /// DistribuicaoNfePedidoManifestacao
    /// </summary>
    [DataContract(Name = "DistribuicaoNfePedidoManifestacao")]
    public partial class DistribuicaoNfePedidoManifestacao : IEquatable<DistribuicaoNfePedidoManifestacao>, IValidatableObject
    {
        /// <summary>
        /// Identificação do Ambiente.
        /// </summary>
        /// <value>Identificação do Ambiente.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmbienteEnum
        {
            /// <summary>
            /// Enum Homologacao for value: homologacao
            /// </summary>
            [EnumMember(Value = "homologacao")]
            Homologacao = 1,

            /// <summary>
            /// Enum Producao for value: producao
            /// </summary>
            [EnumMember(Value = "producao")]
            Producao = 2
        }


        /// <summary>
        /// Identificação do Ambiente.
        /// </summary>
        /// <value>Identificação do Ambiente.</value>
        [DataMember(Name = "ambiente", IsRequired = true, EmitDefaultValue = true)]
        public AmbienteEnum ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfePedidoManifestacao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistribuicaoNfePedidoManifestacao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfePedidoManifestacao" /> class.
        /// </summary>
        /// <param name="cpfCnpj">CPF ou CNPJ do autor do evento.    *Utilize o valor sem máscara*. (required).</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="chaveAcesso">Chave de Acesso da NF-e. (required).</param>
        /// <param name="tipoEvento">Tipo do evento de manifestação do destinatário.    Valores disponíveis:  * &#x60;210200&#x60; - Confirmação da operação;  * &#x60;210210&#x60; - Ciência da operação;  * &#x60;210220&#x60; - Desconhecimento da operação;  * &#x60;210240&#x60; - Operação não realizada. (required).</param>
        /// <param name="justificativa">Justificativa para o desconhecimento ou não-realização da operação.    **Nota**: Campo obrigatório para o evento &#x60;210240&#x60; (operação não realizada)..</param>
        public DistribuicaoNfePedidoManifestacao(string cpfCnpj = default(string), AmbienteEnum ambiente = default(AmbienteEnum), string chaveAcesso = default(string), string tipoEvento = default(string), string justificativa = default(string))
        {
            // to ensure "cpfCnpj" is required (not null)
            if (cpfCnpj == null)
            {
                throw new ArgumentNullException("cpfCnpj is a required property for DistribuicaoNfePedidoManifestacao and cannot be null");
            }
            this.cpf_cnpj = cpfCnpj;
            this.ambiente = ambiente;
            // to ensure "chaveAcesso" is required (not null)
            if (chaveAcesso == null)
            {
                throw new ArgumentNullException("chaveAcesso is a required property for DistribuicaoNfePedidoManifestacao and cannot be null");
            }
            this.chave_acesso = chaveAcesso;
            // to ensure "tipoEvento" is required (not null)
            if (tipoEvento == null)
            {
                throw new ArgumentNullException("tipoEvento is a required property for DistribuicaoNfePedidoManifestacao and cannot be null");
            }
            this.tipo_evento = tipoEvento;
            this.justificativa = justificativa;
        }

        /// <summary>
        /// CPF ou CNPJ do autor do evento.    *Utilize o valor sem máscara*.
        /// </summary>
        /// <value>CPF ou CNPJ do autor do evento.    *Utilize o valor sem máscara*.</value>
        [DataMember(Name = "cpf_cnpj", IsRequired = true, EmitDefaultValue = true)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e.
        /// </summary>
        /// <value>Chave de Acesso da NF-e.</value>
        [DataMember(Name = "chave_acesso", IsRequired = true, EmitDefaultValue = true)]
        public string chave_acesso { get; set; }

        /// <summary>
        /// Tipo do evento de manifestação do destinatário.    Valores disponíveis:  * &#x60;210200&#x60; - Confirmação da operação;  * &#x60;210210&#x60; - Ciência da operação;  * &#x60;210220&#x60; - Desconhecimento da operação;  * &#x60;210240&#x60; - Operação não realizada.
        /// </summary>
        /// <value>Tipo do evento de manifestação do destinatário.    Valores disponíveis:  * &#x60;210200&#x60; - Confirmação da operação;  * &#x60;210210&#x60; - Ciência da operação;  * &#x60;210220&#x60; - Desconhecimento da operação;  * &#x60;210240&#x60; - Operação não realizada.</value>
        [DataMember(Name = "tipo_evento", IsRequired = true, EmitDefaultValue = true)]
        public string tipo_evento { get; set; }

        /// <summary>
        /// Justificativa para o desconhecimento ou não-realização da operação.    **Nota**: Campo obrigatório para o evento &#x60;210240&#x60; (operação não realizada).
        /// </summary>
        /// <value>Justificativa para o desconhecimento ou não-realização da operação.    **Nota**: Campo obrigatório para o evento &#x60;210240&#x60; (operação não realizada).</value>
        [DataMember(Name = "justificativa", EmitDefaultValue = true)]
        public string justificativa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DistribuicaoNfePedidoManifestacao {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  chave_acesso: ").Append(chave_acesso).Append("\n");
            sb.Append("  tipo_evento: ").Append(tipo_evento).Append("\n");
            sb.Append("  justificativa: ").Append(justificativa).Append("\n");
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
            return this.Equals(input as DistribuicaoNfePedidoManifestacao);
        }

        /// <summary>
        /// Returns true if DistribuicaoNfePedidoManifestacao instances are equal
        /// </summary>
        /// <param name="input">Instance of DistribuicaoNfePedidoManifestacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistribuicaoNfePedidoManifestacao input)
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
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.chave_acesso == input.chave_acesso ||
                    (this.chave_acesso != null &&
                    this.chave_acesso.Equals(input.chave_acesso))
                ) && 
                (
                    this.tipo_evento == input.tipo_evento ||
                    (this.tipo_evento != null &&
                    this.tipo_evento.Equals(input.tipo_evento))
                ) && 
                (
                    this.justificativa == input.justificativa ||
                    (this.justificativa != null &&
                    this.justificativa.Equals(input.justificativa))
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
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.chave_acesso != null)
                {
                    hashCode = (hashCode * 59) + this.chave_acesso.GetHashCode();
                }
                if (this.tipo_evento != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_evento.GetHashCode();
                }
                if (this.justificativa != null)
                {
                    hashCode = (hashCode * 59) + this.justificativa.GetHashCode();
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
            // justificativa (string) maxLength
            if (this.justificativa != null && this.justificativa.Length > 255)
            {
                yield return new ValidationResult("Invalid value for justificativa, length must be less than 255.", new [] { "justificativa" });
            }

            // justificativa (string) minLength
            if (this.justificativa != null && this.justificativa.Length < 15)
            {
                yield return new ValidationResult("Invalid value for justificativa, length must be greater than 15.", new [] { "justificativa" });
            }

            yield break;
        }
    }

}
