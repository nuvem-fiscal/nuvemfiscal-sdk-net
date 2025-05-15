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
    /// DfeDebug
    /// </summary>
    [DataContract(Name = "DfeDebug")]
    public partial class DfeDebug : IEquatable<DfeDebug>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeDebug" /> class.
        /// </summary>
        /// <param name="id">Identificador do documento fiscal..</param>
        /// <param name="tipo">Tipo do documento: nfe, nfce, mdfe, nfse, etc..</param>
        /// <param name="createdAt">Data e hora da criação do documento, representada no formato UTC (Tempo Universal Coordenado).  O valor é retornado no padrão ISO 8601, incluindo o deslocamento de fuso horário &#39;Z&#39; no final.    Exemplo: \&quot;2025-04-15T14:16:47.775Z\&quot;.</param>
        /// <param name="requisicoes">Lista de requisições feitas ao autorizador durante o processamento..</param>
        public DfeDebug(string id = default(string), string tipo = default(string), DateTime createdAt = default(DateTime), List<DfeRequisicaoDebug> requisicoes = default(List<DfeRequisicaoDebug>))
        {
            this.id = id;
            this.tipo = tipo;
            this.created_at = createdAt;
            this.requisicoes = requisicoes;
        }

        /// <summary>
        /// Identificador do documento fiscal.
        /// </summary>
        /// <value>Identificador do documento fiscal.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Tipo do documento: nfe, nfce, mdfe, nfse, etc.
        /// </summary>
        /// <value>Tipo do documento: nfe, nfce, mdfe, nfse, etc.</value>
        [DataMember(Name = "tipo", EmitDefaultValue = false)]
        public string tipo { get; set; }

        /// <summary>
        /// Data e hora da criação do documento, representada no formato UTC (Tempo Universal Coordenado).  O valor é retornado no padrão ISO 8601, incluindo o deslocamento de fuso horário &#39;Z&#39; no final.    Exemplo: \&quot;2025-04-15T14:16:47.775Z\&quot;
        /// </summary>
        /// <value>Data e hora da criação do documento, representada no formato UTC (Tempo Universal Coordenado).  O valor é retornado no padrão ISO 8601, incluindo o deslocamento de fuso horário &#39;Z&#39; no final.    Exemplo: \&quot;2025-04-15T14:16:47.775Z\&quot;</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Lista de requisições feitas ao autorizador durante o processamento.
        /// </summary>
        /// <value>Lista de requisições feitas ao autorizador durante o processamento.</value>
        [DataMember(Name = "requisicoes", EmitDefaultValue = false)]
        public List<DfeRequisicaoDebug> requisicoes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeDebug {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  tipo: ").Append(tipo).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  requisicoes: ").Append(requisicoes).Append("\n");
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
            return this.Equals(input as DfeDebug);
        }

        /// <summary>
        /// Returns true if DfeDebug instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeDebug to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeDebug input)
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
                    this.tipo == input.tipo ||
                    (this.tipo != null &&
                    this.tipo.Equals(input.tipo))
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.requisicoes == input.requisicoes ||
                    this.requisicoes != null &&
                    input.requisicoes != null &&
                    this.requisicoes.SequenceEqual(input.requisicoes)
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
                if (this.tipo != null)
                {
                    hashCode = (hashCode * 59) + this.tipo.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.requisicoes != null)
                {
                    hashCode = (hashCode * 59) + this.requisicoes.GetHashCode();
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
