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
    /// Detalhes técnicos da requisição HTTP realizada ao autorizador.
    /// </summary>
    [DataContract(Name = "HttpRequestDebug")]
    public partial class HttpRequestDebug : IEquatable<HttpRequestDebug>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestDebug" /> class.
        /// </summary>
        /// <param name="id">Identificador interno da requisição HTTP.    Esse identificador pode ser utilizado no endpoint  &lt;a href&#x3D;\&quot;#tag/Debug/operation/DebugHttpRequestContent\&quot;&gt;Corpo da Requisição HTTP&lt;/a&gt; ou &lt;a href&#x3D;\&quot;#tag/Debug/operation/DebugHttpResponseContent\&quot;&gt;Corpo da Resposta HTTP&lt;/a&gt;  para obter o conteúdo enviado ou recebido na comunicação com o autorizador..</param>
        /// <param name="method">Método HTTP utilizado (ex: &#39;POST&#39;)..</param>
        /// <param name="uri">URI do serviço externo (SEFAZ, prefeitura, etc.)..</param>
        /// <param name="headers">Cabeçalhos HTTP enviados na requisição, no formato bruto..</param>
        /// <param name="responseStatusCode">Código de status HTTP retornado (ex: 200, 403)..</param>
        /// <param name="responseStatusReason">Motivo ou descrição do status HTTP retornado..</param>
        /// <param name="responseHeaders">Cabeçalhos retornados na resposta, no formato bruto..</param>
        /// <param name="responseTime">Tempo de resposta do serviço externo, em milissegundos..</param>
        public HttpRequestDebug(string id = default(string), string method = default(string), string uri = default(string), string headers = default(string), int responseStatusCode = default(int), string responseStatusReason = default(string), string responseHeaders = default(string), int responseTime = default(int))
        {
            this.id = id;
            this.method = method;
            this.uri = uri;
            this.headers = headers;
            this.response_status_code = responseStatusCode;
            this.response_status_reason = responseStatusReason;
            this.response_headers = responseHeaders;
            this.response_time = responseTime;
        }

        /// <summary>
        /// Identificador interno da requisição HTTP.    Esse identificador pode ser utilizado no endpoint  &lt;a href&#x3D;\&quot;#tag/Debug/operation/DebugHttpRequestContent\&quot;&gt;Corpo da Requisição HTTP&lt;/a&gt; ou &lt;a href&#x3D;\&quot;#tag/Debug/operation/DebugHttpResponseContent\&quot;&gt;Corpo da Resposta HTTP&lt;/a&gt;  para obter o conteúdo enviado ou recebido na comunicação com o autorizador.
        /// </summary>
        /// <value>Identificador interno da requisição HTTP.    Esse identificador pode ser utilizado no endpoint  &lt;a href&#x3D;\&quot;#tag/Debug/operation/DebugHttpRequestContent\&quot;&gt;Corpo da Requisição HTTP&lt;/a&gt; ou &lt;a href&#x3D;\&quot;#tag/Debug/operation/DebugHttpResponseContent\&quot;&gt;Corpo da Resposta HTTP&lt;/a&gt;  para obter o conteúdo enviado ou recebido na comunicação com o autorizador.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// Método HTTP utilizado (ex: &#39;POST&#39;).
        /// </summary>
        /// <value>Método HTTP utilizado (ex: &#39;POST&#39;).</value>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string method { get; set; }

        /// <summary>
        /// URI do serviço externo (SEFAZ, prefeitura, etc.).
        /// </summary>
        /// <value>URI do serviço externo (SEFAZ, prefeitura, etc.).</value>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string uri { get; set; }

        /// <summary>
        /// Cabeçalhos HTTP enviados na requisição, no formato bruto.
        /// </summary>
        /// <value>Cabeçalhos HTTP enviados na requisição, no formato bruto.</value>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public string headers { get; set; }

        /// <summary>
        /// Código de status HTTP retornado (ex: 200, 403).
        /// </summary>
        /// <value>Código de status HTTP retornado (ex: 200, 403).</value>
        [DataMember(Name = "response_status_code", EmitDefaultValue = false)]
        public int response_status_code { get; set; }

        /// <summary>
        /// Motivo ou descrição do status HTTP retornado.
        /// </summary>
        /// <value>Motivo ou descrição do status HTTP retornado.</value>
        [DataMember(Name = "response_status_reason", EmitDefaultValue = false)]
        public string response_status_reason { get; set; }

        /// <summary>
        /// Cabeçalhos retornados na resposta, no formato bruto.
        /// </summary>
        /// <value>Cabeçalhos retornados na resposta, no formato bruto.</value>
        [DataMember(Name = "response_headers", EmitDefaultValue = false)]
        public string response_headers { get; set; }

        /// <summary>
        /// Tempo de resposta do serviço externo, em milissegundos.
        /// </summary>
        /// <value>Tempo de resposta do serviço externo, em milissegundos.</value>
        [DataMember(Name = "response_time", EmitDefaultValue = false)]
        public int response_time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HttpRequestDebug {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  method: ").Append(method).Append("\n");
            sb.Append("  uri: ").Append(uri).Append("\n");
            sb.Append("  headers: ").Append(headers).Append("\n");
            sb.Append("  response_status_code: ").Append(response_status_code).Append("\n");
            sb.Append("  response_status_reason: ").Append(response_status_reason).Append("\n");
            sb.Append("  response_headers: ").Append(response_headers).Append("\n");
            sb.Append("  response_time: ").Append(response_time).Append("\n");
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
            return this.Equals(input as HttpRequestDebug);
        }

        /// <summary>
        /// Returns true if HttpRequestDebug instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpRequestDebug to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpRequestDebug input)
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
                    this.method == input.method ||
                    (this.method != null &&
                    this.method.Equals(input.method))
                ) && 
                (
                    this.uri == input.uri ||
                    (this.uri != null &&
                    this.uri.Equals(input.uri))
                ) && 
                (
                    this.headers == input.headers ||
                    (this.headers != null &&
                    this.headers.Equals(input.headers))
                ) && 
                (
                    this.response_status_code == input.response_status_code ||
                    this.response_status_code.Equals(input.response_status_code)
                ) && 
                (
                    this.response_status_reason == input.response_status_reason ||
                    (this.response_status_reason != null &&
                    this.response_status_reason.Equals(input.response_status_reason))
                ) && 
                (
                    this.response_headers == input.response_headers ||
                    (this.response_headers != null &&
                    this.response_headers.Equals(input.response_headers))
                ) && 
                (
                    this.response_time == input.response_time ||
                    this.response_time.Equals(input.response_time)
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
                if (this.method != null)
                {
                    hashCode = (hashCode * 59) + this.method.GetHashCode();
                }
                if (this.uri != null)
                {
                    hashCode = (hashCode * 59) + this.uri.GetHashCode();
                }
                if (this.headers != null)
                {
                    hashCode = (hashCode * 59) + this.headers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.response_status_code.GetHashCode();
                if (this.response_status_reason != null)
                {
                    hashCode = (hashCode * 59) + this.response_status_reason.GetHashCode();
                }
                if (this.response_headers != null)
                {
                    hashCode = (hashCode * 59) + this.response_headers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.response_time.GetHashCode();
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
