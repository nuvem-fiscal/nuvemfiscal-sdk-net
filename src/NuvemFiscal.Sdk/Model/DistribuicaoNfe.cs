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
    /// DistribuicaoNfe
    /// </summary>
    [DataContract(Name = "DistribuicaoNfe")]
    public partial class DistribuicaoNfe : IEquatable<DistribuicaoNfe>, IValidatableObject
    {
        /// <summary>
        /// Indica o status da distribuição.
        /// </summary>
        /// <value>Indica o status da distribuição.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Processando for value: processando
            /// </summary>
            [EnumMember(Value = "processando")]
            Processando = 1,

            /// <summary>
            /// Enum Concluido for value: concluido
            /// </summary>
            [EnumMember(Value = "concluido")]
            Concluido = 2,

            /// <summary>
            /// Enum Erro for value: erro
            /// </summary>
            [EnumMember(Value = "erro")]
            Erro = 3
        }


        /// <summary>
        /// Indica o status da distribuição.
        /// </summary>
        /// <value>Indica o status da distribuição.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum status { get; set; }
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
        /// Defines tipo_consulta
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoConsultaEnum
        {
            /// <summary>
            /// Enum DistNsu for value: dist-nsu
            /// </summary>
            [EnumMember(Value = "dist-nsu")]
            DistNsu = 1,

            /// <summary>
            /// Enum ConsNsu for value: cons-nsu
            /// </summary>
            [EnumMember(Value = "cons-nsu")]
            ConsNsu = 2,

            /// <summary>
            /// Enum ConsChave for value: cons-chave
            /// </summary>
            [EnumMember(Value = "cons-chave")]
            ConsChave = 3
        }


        /// <summary>
        /// Gets or Sets tipo_consulta
        /// </summary>
        [DataMember(Name = "tipo_consulta", IsRequired = true, EmitDefaultValue = true)]
        public TipoConsultaEnum tipo_consulta { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistribuicaoNfe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfe" /> class.
        /// </summary>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para o pedido de distribuição. (required).</param>
        /// <param name="createdAt">Data/hora em que o pedido foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;..</param>
        /// <param name="status">Indica o status da distribuição. (required).</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="ufAutor">Sigla da UF do autor..</param>
        /// <param name="tipoConsulta">tipoConsulta (required).</param>
        /// <param name="distNsu">Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;distNSU&#x60;.*.</param>
        /// <param name="consNsu">Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consNSU&#x60;.*.</param>
        /// <param name="consChave">Consulta de NF-e por chave de acesso informada.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consChNFe&#x60;.*.</param>
        /// <param name="codigoStatus">Código do status de processamento da requisição. (required).</param>
        /// <param name="motivoStatus">Descrição do status de processamento da requisição..</param>
        /// <param name="dataHoraResposta">Data e Hora de processamento da requisição. (required).</param>
        /// <param name="ultimoNsu">Último NSU pesquisado no Ambiente Nacional. Se for o caso, o solicitante pode continuar a consulta a partir deste NSU para obter novos resultados. (required).</param>
        /// <param name="maxNsu">Maior NSU existente no Ambiente Nacional para o CNPJ/CPF informado. (required).</param>
        /// <param name="documentos">Conjunto de informações resumidas e documentos fiscais eletrônicos de interesse da pessoa ou empresa..</param>
        public DistribuicaoNfe(string id = default(string), DateTime createdAt = default(DateTime), StatusEnum status = default(StatusEnum), AmbienteEnum ambiente = default(AmbienteEnum), string ufAutor = default(string), TipoConsultaEnum tipoConsulta = default(TipoConsultaEnum), int? distNsu = default(int?), int? consNsu = default(int?), string consChave = default(string), int? codigoStatus = default(int?), string motivoStatus = default(string), DateTime? dataHoraResposta = default(DateTime?), int? ultimoNsu = default(int?), int? maxNsu = default(int?), List<DistribuicaoNfeDocumento> documentos = default(List<DistribuicaoNfeDocumento>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DistribuicaoNfe and cannot be null");
            }
            this.id = id;
            this.status = status;
            this.ambiente = ambiente;
            this.tipo_consulta = tipoConsulta;
            // to ensure "codigoStatus" is required (not null)
            if (codigoStatus == null)
            {
                throw new ArgumentNullException("codigoStatus is a required property for DistribuicaoNfe and cannot be null");
            }
            this.codigo_status = codigoStatus;
            // to ensure "dataHoraResposta" is required (not null)
            if (dataHoraResposta == null)
            {
                throw new ArgumentNullException("dataHoraResposta is a required property for DistribuicaoNfe and cannot be null");
            }
            this.data_hora_resposta = dataHoraResposta;
            // to ensure "ultimoNsu" is required (not null)
            if (ultimoNsu == null)
            {
                throw new ArgumentNullException("ultimoNsu is a required property for DistribuicaoNfe and cannot be null");
            }
            this.ultimo_nsu = ultimoNsu;
            // to ensure "maxNsu" is required (not null)
            if (maxNsu == null)
            {
                throw new ArgumentNullException("maxNsu is a required property for DistribuicaoNfe and cannot be null");
            }
            this.max_nsu = maxNsu;
            this.created_at = createdAt;
            this.uf_autor = ufAutor;
            this.dist_nsu = distNsu;
            this.cons_nsu = consNsu;
            this.cons_chave = consChave;
            this.motivo_status = motivoStatus;
            this.documentos = documentos;
        }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para o pedido de distribuição.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para o pedido de distribuição.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string id { get; set; }

        /// <summary>
        /// Data/hora em que o pedido foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;.
        /// </summary>
        /// <value>Data/hora em que o pedido foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Sigla da UF do autor.
        /// </summary>
        /// <value>Sigla da UF do autor.</value>
        [DataMember(Name = "uf_autor", EmitDefaultValue = true)]
        public string uf_autor { get; set; }

        /// <summary>
        /// Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;distNSU&#x60;.*
        /// </summary>
        /// <value>Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;distNSU&#x60;.*</value>
        [DataMember(Name = "dist_nsu", EmitDefaultValue = true)]
        public int? dist_nsu { get; set; }

        /// <summary>
        /// Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consNSU&#x60;.*
        /// </summary>
        /// <value>Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consNSU&#x60;.*</value>
        [DataMember(Name = "cons_nsu", EmitDefaultValue = true)]
        public int? cons_nsu { get; set; }

        /// <summary>
        /// Consulta de NF-e por chave de acesso informada.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consChNFe&#x60;.*
        /// </summary>
        /// <value>Consulta de NF-e por chave de acesso informada.    *Obrigatório quando &#x60;tipo_consulta&#x60; for &#x60;consChNFe&#x60;.*</value>
        [DataMember(Name = "cons_chave", EmitDefaultValue = true)]
        public string cons_chave { get; set; }

        /// <summary>
        /// Código do status de processamento da requisição.
        /// </summary>
        /// <value>Código do status de processamento da requisição.</value>
        [DataMember(Name = "codigo_status", IsRequired = true, EmitDefaultValue = true)]
        public int? codigo_status { get; set; }

        /// <summary>
        /// Descrição do status de processamento da requisição.
        /// </summary>
        /// <value>Descrição do status de processamento da requisição.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = true)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Data e Hora de processamento da requisição.
        /// </summary>
        /// <value>Data e Hora de processamento da requisição.</value>
        [DataMember(Name = "data_hora_resposta", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? data_hora_resposta { get; set; }

        /// <summary>
        /// Último NSU pesquisado no Ambiente Nacional. Se for o caso, o solicitante pode continuar a consulta a partir deste NSU para obter novos resultados.
        /// </summary>
        /// <value>Último NSU pesquisado no Ambiente Nacional. Se for o caso, o solicitante pode continuar a consulta a partir deste NSU para obter novos resultados.</value>
        [DataMember(Name = "ultimo_nsu", IsRequired = true, EmitDefaultValue = true)]
        public int? ultimo_nsu { get; set; }

        /// <summary>
        /// Maior NSU existente no Ambiente Nacional para o CNPJ/CPF informado.
        /// </summary>
        /// <value>Maior NSU existente no Ambiente Nacional para o CNPJ/CPF informado.</value>
        [DataMember(Name = "max_nsu", IsRequired = true, EmitDefaultValue = true)]
        public int? max_nsu { get; set; }

        /// <summary>
        /// Conjunto de informações resumidas e documentos fiscais eletrônicos de interesse da pessoa ou empresa.
        /// </summary>
        /// <value>Conjunto de informações resumidas e documentos fiscais eletrônicos de interesse da pessoa ou empresa.</value>
        [DataMember(Name = "documentos", EmitDefaultValue = false)]
        public List<DistribuicaoNfeDocumento> documentos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DistribuicaoNfe {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  uf_autor: ").Append(uf_autor).Append("\n");
            sb.Append("  tipo_consulta: ").Append(tipo_consulta).Append("\n");
            sb.Append("  dist_nsu: ").Append(dist_nsu).Append("\n");
            sb.Append("  cons_nsu: ").Append(cons_nsu).Append("\n");
            sb.Append("  cons_chave: ").Append(cons_chave).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  data_hora_resposta: ").Append(data_hora_resposta).Append("\n");
            sb.Append("  ultimo_nsu: ").Append(ultimo_nsu).Append("\n");
            sb.Append("  max_nsu: ").Append(max_nsu).Append("\n");
            sb.Append("  documentos: ").Append(documentos).Append("\n");
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
            return this.Equals(input as DistribuicaoNfe);
        }

        /// <summary>
        /// Returns true if DistribuicaoNfe instances are equal
        /// </summary>
        /// <param name="input">Instance of DistribuicaoNfe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistribuicaoNfe input)
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
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.uf_autor == input.uf_autor ||
                    (this.uf_autor != null &&
                    this.uf_autor.Equals(input.uf_autor))
                ) && 
                (
                    this.tipo_consulta == input.tipo_consulta ||
                    this.tipo_consulta.Equals(input.tipo_consulta)
                ) && 
                (
                    this.dist_nsu == input.dist_nsu ||
                    (this.dist_nsu != null &&
                    this.dist_nsu.Equals(input.dist_nsu))
                ) && 
                (
                    this.cons_nsu == input.cons_nsu ||
                    (this.cons_nsu != null &&
                    this.cons_nsu.Equals(input.cons_nsu))
                ) && 
                (
                    this.cons_chave == input.cons_chave ||
                    (this.cons_chave != null &&
                    this.cons_chave.Equals(input.cons_chave))
                ) && 
                (
                    this.codigo_status == input.codigo_status ||
                    (this.codigo_status != null &&
                    this.codigo_status.Equals(input.codigo_status))
                ) && 
                (
                    this.motivo_status == input.motivo_status ||
                    (this.motivo_status != null &&
                    this.motivo_status.Equals(input.motivo_status))
                ) && 
                (
                    this.data_hora_resposta == input.data_hora_resposta ||
                    (this.data_hora_resposta != null &&
                    this.data_hora_resposta.Equals(input.data_hora_resposta))
                ) && 
                (
                    this.ultimo_nsu == input.ultimo_nsu ||
                    (this.ultimo_nsu != null &&
                    this.ultimo_nsu.Equals(input.ultimo_nsu))
                ) && 
                (
                    this.max_nsu == input.max_nsu ||
                    (this.max_nsu != null &&
                    this.max_nsu.Equals(input.max_nsu))
                ) && 
                (
                    this.documentos == input.documentos ||
                    this.documentos != null &&
                    input.documentos != null &&
                    this.documentos.SequenceEqual(input.documentos)
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
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.uf_autor != null)
                {
                    hashCode = (hashCode * 59) + this.uf_autor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tipo_consulta.GetHashCode();
                if (this.dist_nsu != null)
                {
                    hashCode = (hashCode * 59) + this.dist_nsu.GetHashCode();
                }
                if (this.cons_nsu != null)
                {
                    hashCode = (hashCode * 59) + this.cons_nsu.GetHashCode();
                }
                if (this.cons_chave != null)
                {
                    hashCode = (hashCode * 59) + this.cons_chave.GetHashCode();
                }
                if (this.codigo_status != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                }
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.data_hora_resposta != null)
                {
                    hashCode = (hashCode * 59) + this.data_hora_resposta.GetHashCode();
                }
                if (this.ultimo_nsu != null)
                {
                    hashCode = (hashCode * 59) + this.ultimo_nsu.GetHashCode();
                }
                if (this.max_nsu != null)
                {
                    hashCode = (hashCode * 59) + this.max_nsu.GetHashCode();
                }
                if (this.documentos != null)
                {
                    hashCode = (hashCode * 59) + this.documentos.GetHashCode();
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
            yield break;
        }
    }

}
