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
    /// DfeRequisicaoDebug
    /// </summary>
    [DataContract(Name = "DfeRequisicaoDebug")]
    public partial class DfeRequisicaoDebug : IEquatable<DfeRequisicaoDebug>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeRequisicaoDebug" /> class.
        /// </summary>
        /// <param name="createdAt">Data e hora da criação da requisição, representada no formato UTC (Tempo Universal Coordenado).  O valor é retornado no padrão ISO 8601, incluindo o deslocamento de fuso horário &#39;Z&#39; no final.    Exemplo: \&quot;2025-04-15T14:16:47.775Z\&quot;.</param>
        /// <param name="tipo">Tipo da operação realizada na requisição para o autorizador.  Pode assumir um dos seguintes valores:  - &#39;envio_lote&#39;      : envio do lote de documentos fiscais para autorização;  - &#39;consulta_lote&#39;   : consulta do processamento do lote;  - &#39;cons_sit_dfe&#39;    : consulta de situação individual de um DFe.    Esse campo indica a natureza da interação com a SEFAZ ou prefeitura,  e é útil para fins de rastreamento e diagnóstico do fluxo..</param>
        /// <param name="loteId">Identificador do lote vinculado à requisição..</param>
        /// <param name="codigoStatus">Código de status retornado pela SEFAZ/prefeitura..</param>
        /// <param name="motivoStatus">Motivo associado ao status retornado..</param>
        /// <param name="httpRequest">httpRequest.</param>
        public DfeRequisicaoDebug(DateTime createdAt = default(DateTime), string tipo = default(string), string loteId = default(string), int codigoStatus = default(int), string motivoStatus = default(string), HttpRequestDebug httpRequest = default(HttpRequestDebug))
        {
            this.created_at = createdAt;
            this.tipo = tipo;
            this.lote_id = loteId;
            this.codigo_status = codigoStatus;
            this.motivo_status = motivoStatus;
            this.http_request = httpRequest;
        }

        /// <summary>
        /// Data e hora da criação da requisição, representada no formato UTC (Tempo Universal Coordenado).  O valor é retornado no padrão ISO 8601, incluindo o deslocamento de fuso horário &#39;Z&#39; no final.    Exemplo: \&quot;2025-04-15T14:16:47.775Z\&quot;
        /// </summary>
        /// <value>Data e hora da criação da requisição, representada no formato UTC (Tempo Universal Coordenado).  O valor é retornado no padrão ISO 8601, incluindo o deslocamento de fuso horário &#39;Z&#39; no final.    Exemplo: \&quot;2025-04-15T14:16:47.775Z\&quot;</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Tipo da operação realizada na requisição para o autorizador.  Pode assumir um dos seguintes valores:  - &#39;envio_lote&#39;      : envio do lote de documentos fiscais para autorização;  - &#39;consulta_lote&#39;   : consulta do processamento do lote;  - &#39;cons_sit_dfe&#39;    : consulta de situação individual de um DFe.    Esse campo indica a natureza da interação com a SEFAZ ou prefeitura,  e é útil para fins de rastreamento e diagnóstico do fluxo.
        /// </summary>
        /// <value>Tipo da operação realizada na requisição para o autorizador.  Pode assumir um dos seguintes valores:  - &#39;envio_lote&#39;      : envio do lote de documentos fiscais para autorização;  - &#39;consulta_lote&#39;   : consulta do processamento do lote;  - &#39;cons_sit_dfe&#39;    : consulta de situação individual de um DFe.    Esse campo indica a natureza da interação com a SEFAZ ou prefeitura,  e é útil para fins de rastreamento e diagnóstico do fluxo.</value>
        [DataMember(Name = "tipo", EmitDefaultValue = false)]
        public string tipo { get; set; }

        /// <summary>
        /// Identificador do lote vinculado à requisição.
        /// </summary>
        /// <value>Identificador do lote vinculado à requisição.</value>
        [DataMember(Name = "lote_id", EmitDefaultValue = false)]
        public string lote_id { get; set; }

        /// <summary>
        /// Código de status retornado pela SEFAZ/prefeitura.
        /// </summary>
        /// <value>Código de status retornado pela SEFAZ/prefeitura.</value>
        [DataMember(Name = "codigo_status", EmitDefaultValue = false)]
        public int codigo_status { get; set; }

        /// <summary>
        /// Motivo associado ao status retornado.
        /// </summary>
        /// <value>Motivo associado ao status retornado.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = false)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Gets or Sets http_request
        /// </summary>
        [DataMember(Name = "http_request", EmitDefaultValue = false)]
        public HttpRequestDebug http_request { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeRequisicaoDebug {\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  tipo: ").Append(tipo).Append("\n");
            sb.Append("  lote_id: ").Append(lote_id).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  http_request: ").Append(http_request).Append("\n");
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
            return this.Equals(input as DfeRequisicaoDebug);
        }

        /// <summary>
        /// Returns true if DfeRequisicaoDebug instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeRequisicaoDebug to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeRequisicaoDebug input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.tipo == input.tipo ||
                    (this.tipo != null &&
                    this.tipo.Equals(input.tipo))
                ) && 
                (
                    this.lote_id == input.lote_id ||
                    (this.lote_id != null &&
                    this.lote_id.Equals(input.lote_id))
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
                    this.http_request == input.http_request ||
                    (this.http_request != null &&
                    this.http_request.Equals(input.http_request))
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
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.tipo != null)
                {
                    hashCode = (hashCode * 59) + this.tipo.GetHashCode();
                }
                if (this.lote_id != null)
                {
                    hashCode = (hashCode * 59) + this.lote_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.http_request != null)
                {
                    hashCode = (hashCode * 59) + this.http_request.GetHashCode();
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
