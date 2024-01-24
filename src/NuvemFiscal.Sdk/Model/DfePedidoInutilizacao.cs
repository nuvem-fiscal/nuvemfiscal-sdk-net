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
    /// DfePedidoInutilizacao
    /// </summary>
    [DataContract(Name = "DfePedidoInutilizacao")]
    public partial class DfePedidoInutilizacao : IEquatable<DfePedidoInutilizacao>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="DfePedidoInutilizacao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DfePedidoInutilizacao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfePedidoInutilizacao" /> class.
        /// </summary>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="cnpj">CNPJ do emitente. (required).</param>
        /// <param name="ano">Ano de inutilização da numeração. (required).</param>
        /// <param name="serie">Série da NF-e. (required).</param>
        /// <param name="numeroInicial">Número da NF-e inicial. (required).</param>
        /// <param name="numeroFinal">Número da NF-e final. (required).</param>
        /// <param name="justificativa">Justificativa do pedido de inutilização. (required).</param>
        public DfePedidoInutilizacao(AmbienteEnum ambiente = default(AmbienteEnum), string cnpj = default(string), int ano = default(int), int serie = default(int), int numeroInicial = default(int), int numeroFinal = default(int), string justificativa = default(string))
        {
            this.ambiente = ambiente;
            // to ensure "cnpj" is required (not null)
            if (cnpj == null)
            {
                throw new ArgumentNullException("cnpj is a required property for DfePedidoInutilizacao and cannot be null");
            }
            this.cnpj = cnpj;
            this.ano = ano;
            this.serie = serie;
            this.numero_inicial = numeroInicial;
            this.numero_final = numeroFinal;
            // to ensure "justificativa" is required (not null)
            if (justificativa == null)
            {
                throw new ArgumentNullException("justificativa is a required property for DfePedidoInutilizacao and cannot be null");
            }
            this.justificativa = justificativa;
        }

        /// <summary>
        /// CNPJ do emitente.
        /// </summary>
        /// <value>CNPJ do emitente.</value>
        [DataMember(Name = "cnpj", IsRequired = true, EmitDefaultValue = true)]
        public string cnpj { get; set; }

        /// <summary>
        /// Ano de inutilização da numeração.
        /// </summary>
        /// <value>Ano de inutilização da numeração.</value>
        [DataMember(Name = "ano", IsRequired = true, EmitDefaultValue = true)]
        public int ano { get; set; }

        /// <summary>
        /// Série da NF-e.
        /// </summary>
        /// <value>Série da NF-e.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int serie { get; set; }

        /// <summary>
        /// Número da NF-e inicial.
        /// </summary>
        /// <value>Número da NF-e inicial.</value>
        [DataMember(Name = "numero_inicial", IsRequired = true, EmitDefaultValue = true)]
        public int numero_inicial { get; set; }

        /// <summary>
        /// Número da NF-e final.
        /// </summary>
        /// <value>Número da NF-e final.</value>
        [DataMember(Name = "numero_final", IsRequired = true, EmitDefaultValue = true)]
        public int numero_final { get; set; }

        /// <summary>
        /// Justificativa do pedido de inutilização.
        /// </summary>
        /// <value>Justificativa do pedido de inutilização.</value>
        [DataMember(Name = "justificativa", IsRequired = true, EmitDefaultValue = true)]
        public string justificativa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfePedidoInutilizacao {\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  cnpj: ").Append(cnpj).Append("\n");
            sb.Append("  ano: ").Append(ano).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  numero_inicial: ").Append(numero_inicial).Append("\n");
            sb.Append("  numero_final: ").Append(numero_final).Append("\n");
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
            return this.Equals(input as DfePedidoInutilizacao);
        }

        /// <summary>
        /// Returns true if DfePedidoInutilizacao instances are equal
        /// </summary>
        /// <param name="input">Instance of DfePedidoInutilizacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfePedidoInutilizacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.cnpj == input.cnpj ||
                    (this.cnpj != null &&
                    this.cnpj.Equals(input.cnpj))
                ) && 
                (
                    this.ano == input.ano ||
                    this.ano.Equals(input.ano)
                ) && 
                (
                    this.serie == input.serie ||
                    this.serie.Equals(input.serie)
                ) && 
                (
                    this.numero_inicial == input.numero_inicial ||
                    this.numero_inicial.Equals(input.numero_inicial)
                ) && 
                (
                    this.numero_final == input.numero_final ||
                    this.numero_final.Equals(input.numero_final)
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
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cnpj.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ano.GetHashCode();
                hashCode = (hashCode * 59) + this.serie.GetHashCode();
                hashCode = (hashCode * 59) + this.numero_inicial.GetHashCode();
                hashCode = (hashCode * 59) + this.numero_final.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // serie (int) maximum
            if (this.serie > (int)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, must be a value less than or equal to 999.", new [] { "serie" });
            }

            // serie (int) minimum
            if (this.serie < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, must be a value greater than or equal to 0.", new [] { "serie" });
            }

            // numero_inicial (int) maximum
            if (this.numero_inicial > (int)999999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for numero_inicial, must be a value less than or equal to 999999999.", new [] { "numero_inicial" });
            }

            // numero_inicial (int) minimum
            if (this.numero_inicial < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for numero_inicial, must be a value greater than or equal to 1.", new [] { "numero_inicial" });
            }

            // numero_final (int) maximum
            if (this.numero_final > (int)999999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for numero_final, must be a value less than or equal to 999999999.", new [] { "numero_final" });
            }

            // numero_final (int) minimum
            if (this.numero_final < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for numero_final, must be a value greater than or equal to 1.", new [] { "numero_final" });
            }

            // justificativa (string) maxLength
            if (this.justificativa != null && this.justificativa.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for justificativa, length must be less than 255.", new [] { "justificativa" });
            }

            // justificativa (string) minLength
            if (this.justificativa != null && this.justificativa.Length < 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for justificativa, length must be greater than 15.", new [] { "justificativa" });
            }

            yield break;
        }
    }

}
