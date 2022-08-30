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
    /// Dfe
    /// </summary>
    [DataContract(Name = "Dfe")]
    public partial class Dfe : IEquatable<Dfe>, IValidatableObject
    {
        /// <summary>
        /// Defines ambiente
        /// </summary>
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
        /// Gets or Sets ambiente
        /// </summary>
        [DataMember(Name = "ambiente", EmitDefaultValue = false)]
        public AmbienteEnum? ambiente { get; set; }
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pendente for value: pendente
            /// </summary>
            [EnumMember(Value = "pendente")]
            Pendente = 1,

            /// <summary>
            /// Enum Autorizado for value: autorizado
            /// </summary>
            [EnumMember(Value = "autorizado")]
            Autorizado = 2,

            /// <summary>
            /// Enum Rejeitado for value: rejeitado
            /// </summary>
            [EnumMember(Value = "rejeitado")]
            Rejeitado = 3,

            /// <summary>
            /// Enum Denegado for value: denegado
            /// </summary>
            [EnumMember(Value = "denegado")]
            Denegado = 4,

            /// <summary>
            /// Enum Encerrado for value: encerrado
            /// </summary>
            [EnumMember(Value = "encerrado")]
            Encerrado = 5,

            /// <summary>
            /// Enum Cancelado for value: cancelado
            /// </summary>
            [EnumMember(Value = "cancelado")]
            Cancelado = 6,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 7

        }


        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dfe" /> class.
        /// </summary>
        /// <param name="id">Identificador único do documento..</param>
        /// <param name="ambiente">ambiente.</param>
        /// <param name="createdAt">Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato [&#x60;ISO 8601&#x60;](https://en.wikipedia.org/wiki/ISO_8601)..</param>
        /// <param name="status">status.</param>
        /// <param name="referencia">Identificador único usado dentro de seu próprio aplicativo para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento..</param>
        /// <param name="dataEmissao">dataEmissao.</param>
        /// <param name="modelo">modelo.</param>
        /// <param name="serie">serie.</param>
        /// <param name="numero">numero.</param>
        /// <param name="valorTotal">valorTotal.</param>
        /// <param name="chave">Chave de acesso do DF-e..</param>
        /// <param name="autorizacao">autorizacao.</param>
        public Dfe(string id = default(string), AmbienteEnum? ambiente = default(AmbienteEnum?), DateTime createdAt = default(DateTime), StatusEnum? status = default(StatusEnum?), string referencia = default(string), DateTime dataEmissao = default(DateTime), int modelo = default(int), int serie = default(int), int numero = default(int), decimal valorTotal = default(decimal), string chave = default(string), DfeAutorizacao autorizacao = default(DfeAutorizacao))
        {
            this.id = id;
            this.ambiente = ambiente;
            this.created_at = createdAt;
            this.status = status;
            this.referencia = referencia;
            this.data_emissao = dataEmissao;
            this.modelo = modelo;
            this.serie = serie;
            this.numero = numero;
            this.valor_total = valorTotal;
            this.chave = chave;
            this.autorizacao = autorizacao;
        }

        /// <summary>
        /// Identificador único do documento.
        /// </summary>
        /// <value>Identificador único do documento.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato [&#x60;ISO 8601&#x60;](https://en.wikipedia.org/wiki/ISO_8601).
        /// </summary>
        /// <value>Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato [&#x60;ISO 8601&#x60;](https://en.wikipedia.org/wiki/ISO_8601).</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Identificador único usado dentro de seu próprio aplicativo para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.
        /// </summary>
        /// <value>Identificador único usado dentro de seu próprio aplicativo para este documento. Opcional, ajuda a evitar o envio duplicado de um mesmo documento.</value>
        [DataMember(Name = "referencia", EmitDefaultValue = false)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets data_emissao
        /// </summary>
        [DataMember(Name = "data_emissao", EmitDefaultValue = false)]
        public DateTime data_emissao { get; set; }

        /// <summary>
        /// Gets or Sets modelo
        /// </summary>
        [DataMember(Name = "modelo", EmitDefaultValue = false)]
        public int modelo { get; set; }

        /// <summary>
        /// Gets or Sets serie
        /// </summary>
        [DataMember(Name = "serie", EmitDefaultValue = false)]
        public int serie { get; set; }

        /// <summary>
        /// Gets or Sets numero
        /// </summary>
        [DataMember(Name = "numero", EmitDefaultValue = false)]
        public int numero { get; set; }

        /// <summary>
        /// Gets or Sets valor_total
        /// </summary>
        [DataMember(Name = "valor_total", EmitDefaultValue = false)]
        public decimal valor_total { get; set; }

        /// <summary>
        /// Chave de acesso do DF-e.
        /// </summary>
        /// <value>Chave de acesso do DF-e.</value>
        [DataMember(Name = "chave", EmitDefaultValue = false)]
        public string chave { get; set; }

        /// <summary>
        /// Gets or Sets autorizacao
        /// </summary>
        [DataMember(Name = "autorizacao", EmitDefaultValue = false)]
        public DfeAutorizacao autorizacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Dfe {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  data_emissao: ").Append(data_emissao).Append("\n");
            sb.Append("  modelo: ").Append(modelo).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  valor_total: ").Append(valor_total).Append("\n");
            sb.Append("  chave: ").Append(chave).Append("\n");
            sb.Append("  autorizacao: ").Append(autorizacao).Append("\n");
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
            return this.Equals(input as Dfe);
        }

        /// <summary>
        /// Returns true if Dfe instances are equal
        /// </summary>
        /// <param name="input">Instance of Dfe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dfe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
                ) && 
                (
                    this.data_emissao == input.data_emissao ||
                    (this.data_emissao != null &&
                    this.data_emissao.Equals(input.data_emissao))
                ) && 
                (
                    this.modelo == input.modelo ||
                    this.modelo.Equals(input.modelo)
                ) && 
                (
                    this.serie == input.serie ||
                    this.serie.Equals(input.serie)
                ) && 
                (
                    this.numero == input.numero ||
                    this.numero.Equals(input.numero)
                ) && 
                (
                    this.valor_total == input.valor_total ||
                    this.valor_total.Equals(input.valor_total)
                ) && 
                (
                    this.chave == input.chave ||
                    (this.chave != null &&
                    this.chave.Equals(input.chave))
                ) && 
                (
                    this.autorizacao == input.autorizacao ||
                    (this.autorizacao != null &&
                    this.autorizacao.Equals(input.autorizacao))
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
                if (this.id != null)
                {
                    hashCode = (hashCode * 59) + this.id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.referencia != null)
                {
                    hashCode = (hashCode * 59) + this.referencia.GetHashCode();
                }
                if (this.data_emissao != null)
                {
                    hashCode = (hashCode * 59) + this.data_emissao.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.modelo.GetHashCode();
                hashCode = (hashCode * 59) + this.serie.GetHashCode();
                hashCode = (hashCode * 59) + this.numero.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_total.GetHashCode();
                if (this.chave != null)
                {
                    hashCode = (hashCode * 59) + this.chave.GetHashCode();
                }
                if (this.autorizacao != null)
                {
                    hashCode = (hashCode * 59) + this.autorizacao.GetHashCode();
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
