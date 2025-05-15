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
    /// DistribuicaoNfeDocumento
    /// </summary>
    [DataContract(Name = "DistribuicaoNfeDocumento")]
    public partial class DistribuicaoNfeDocumento : IEquatable<DistribuicaoNfeDocumento>, IValidatableObject
    {
        /// <summary>
        /// Tipo do documento de interesse da pessoa ou empresa.
        /// </summary>
        /// <value>Tipo do documento de interesse da pessoa ou empresa.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoDocumentoEnum
        {
            /// <summary>
            /// Enum Nota for value: nota
            /// </summary>
            [EnumMember(Value = "nota")]
            Nota = 1,

            /// <summary>
            /// Enum Evento for value: evento
            /// </summary>
            [EnumMember(Value = "evento")]
            Evento = 2
        }


        /// <summary>
        /// Tipo do documento de interesse da pessoa ou empresa.
        /// </summary>
        /// <value>Tipo do documento de interesse da pessoa ou empresa.</value>
        [DataMember(Name = "tipo_documento", EmitDefaultValue = true)]
        public TipoDocumentoEnum? tipo_documento { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfeDocumento" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistribuicaoNfeDocumento() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfeDocumento" /> class.
        /// </summary>
        /// <param name="id">ID único gerado pela Nuvem Fiscal para identificar o documento. (required).</param>
        /// <param name="createdAt">Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;..</param>
        /// <param name="nsu">NSU do documento fiscal..</param>
        /// <param name="schema">Identificação do Schema XML que será utilizado para validar o XML existente no conteúdo da tag docZip. Vai identificar o tipo do documento e sua versão. Exemplos: resNFe_v1.00.xsd, procNFe_v3.10.xsd, resEvento_1.00.xsd, procEventoNFe_v1.00.xsd. (required).</param>
        /// <param name="tipoDocumento">Tipo do documento de interesse da pessoa ou empresa..</param>
        /// <param name="chaveAcesso">Chave de Acesso da NF-e..</param>
        /// <param name="resumo">Indica se o documento distribuído está em sua forma resumida..</param>
        /// <param name="tipoEvento">Tipo do evento..</param>
        /// <param name="numeroSequencial">Número sequencial do evento para o mesmo tipo de evento..</param>
        /// <param name="dataEvento">Data e hora do evento..</param>
        /// <param name="dataRecebimento">Data e hora de autorização do evento..</param>
        /// <param name="numeroProtocolo">Número do protocolo de autorização..</param>
        /// <param name="tipoNfe">Tipo da NF-e (0 - entrada; 1 - saída)..</param>
        /// <param name="valorNfe">Valor total da NF-e..</param>
        /// <param name="digestValue">Digest Value da NF-e processada. Utilizado para conferir a integridade da NF-e original..</param>
        /// <param name="emitenteCpfCnpj">CPF/CNPJ do emitente..</param>
        /// <param name="emitenteNomeRazaoSocial">Nome ou Razão Social do emitente..</param>
        /// <param name="emitenteInscricaoEstadual">Inscrição Estadual do emitente..</param>
        public DistribuicaoNfeDocumento(string id = default(string), DateTime createdAt = default(DateTime), long? nsu = default(long?), string schema = default(string), TipoDocumentoEnum? tipoDocumento = default(TipoDocumentoEnum?), string chaveAcesso = default(string), bool? resumo = default(bool?), string tipoEvento = default(string), int? numeroSequencial = default(int?), DateTime? dataEvento = default(DateTime?), DateTime? dataRecebimento = default(DateTime?), string numeroProtocolo = default(string), int? tipoNfe = default(int?), decimal? valorNfe = default(decimal?), string digestValue = default(string), string emitenteCpfCnpj = default(string), string emitenteNomeRazaoSocial = default(string), string emitenteInscricaoEstadual = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DistribuicaoNfeDocumento and cannot be null");
            }
            this.id = id;
            // to ensure "schema" is required (not null)
            if (schema == null)
            {
                throw new ArgumentNullException("schema is a required property for DistribuicaoNfeDocumento and cannot be null");
            }
            this.schema = schema;
            this.created_at = createdAt;
            this.nsu = nsu;
            this.tipo_documento = tipoDocumento;
            this.chave_acesso = chaveAcesso;
            this.resumo = resumo;
            this.tipo_evento = tipoEvento;
            this.numero_sequencial = numeroSequencial;
            this.data_evento = dataEvento;
            this.data_recebimento = dataRecebimento;
            this.numero_protocolo = numeroProtocolo;
            this.tipo_nfe = tipoNfe;
            this.valor_nfe = valorNfe;
            this.digest_value = digestValue;
            this.emitente_cpf_cnpj = emitenteCpfCnpj;
            this.emitente_nome_razao_social = emitenteNomeRazaoSocial;
            this.emitente_inscricao_estadual = emitenteInscricaoEstadual;
        }

        /// <summary>
        /// ID único gerado pela Nuvem Fiscal para identificar o documento.
        /// </summary>
        /// <value>ID único gerado pela Nuvem Fiscal para identificar o documento.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string id { get; set; }

        /// <summary>
        /// Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;.
        /// </summary>
        /// <value>Data/hora em que o documento foi criado na Nuvem Fiscal. Representado no formato &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot; target&#x3D;\&quot;blank\&quot;&gt;&#x60;ISO 8601&#x60;&lt;/a&gt;.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// NSU do documento fiscal.
        /// </summary>
        /// <value>NSU do documento fiscal.</value>
        [DataMember(Name = "nsu", EmitDefaultValue = true)]
        public long? nsu { get; set; }

        /// <summary>
        /// Identificação do Schema XML que será utilizado para validar o XML existente no conteúdo da tag docZip. Vai identificar o tipo do documento e sua versão. Exemplos: resNFe_v1.00.xsd, procNFe_v3.10.xsd, resEvento_1.00.xsd, procEventoNFe_v1.00.xsd.
        /// </summary>
        /// <value>Identificação do Schema XML que será utilizado para validar o XML existente no conteúdo da tag docZip. Vai identificar o tipo do documento e sua versão. Exemplos: resNFe_v1.00.xsd, procNFe_v3.10.xsd, resEvento_1.00.xsd, procEventoNFe_v1.00.xsd.</value>
        [DataMember(Name = "schema", IsRequired = true, EmitDefaultValue = true)]
        public string schema { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e.
        /// </summary>
        /// <value>Chave de Acesso da NF-e.</value>
        [DataMember(Name = "chave_acesso", EmitDefaultValue = true)]
        public string chave_acesso { get; set; }

        /// <summary>
        /// Indica se o documento distribuído está em sua forma resumida.
        /// </summary>
        /// <value>Indica se o documento distribuído está em sua forma resumida.</value>
        [DataMember(Name = "resumo", EmitDefaultValue = true)]
        public bool? resumo { get; set; }

        /// <summary>
        /// Tipo do evento.
        /// </summary>
        /// <value>Tipo do evento.</value>
        [DataMember(Name = "tipo_evento", EmitDefaultValue = true)]
        public string tipo_evento { get; set; }

        /// <summary>
        /// Número sequencial do evento para o mesmo tipo de evento.
        /// </summary>
        /// <value>Número sequencial do evento para o mesmo tipo de evento.</value>
        [DataMember(Name = "numero_sequencial", EmitDefaultValue = true)]
        public int? numero_sequencial { get; set; }

        /// <summary>
        /// Data e hora do evento.
        /// </summary>
        /// <value>Data e hora do evento.</value>
        [DataMember(Name = "data_evento", EmitDefaultValue = true)]
        public DateTime? data_evento { get; set; }

        /// <summary>
        /// Data e hora de autorização do evento.
        /// </summary>
        /// <value>Data e hora de autorização do evento.</value>
        [DataMember(Name = "data_recebimento", EmitDefaultValue = true)]
        public DateTime? data_recebimento { get; set; }

        /// <summary>
        /// Número do protocolo de autorização.
        /// </summary>
        /// <value>Número do protocolo de autorização.</value>
        [DataMember(Name = "numero_protocolo", EmitDefaultValue = true)]
        public string numero_protocolo { get; set; }

        /// <summary>
        /// Tipo da NF-e (0 - entrada; 1 - saída).
        /// </summary>
        /// <value>Tipo da NF-e (0 - entrada; 1 - saída).</value>
        [DataMember(Name = "tipo_nfe", EmitDefaultValue = true)]
        public int? tipo_nfe { get; set; }

        /// <summary>
        /// Valor total da NF-e.
        /// </summary>
        /// <value>Valor total da NF-e.</value>
        [DataMember(Name = "valor_nfe", EmitDefaultValue = true)]
        public decimal? valor_nfe { get; set; }

        /// <summary>
        /// Digest Value da NF-e processada. Utilizado para conferir a integridade da NF-e original.
        /// </summary>
        /// <value>Digest Value da NF-e processada. Utilizado para conferir a integridade da NF-e original.</value>
        [DataMember(Name = "digest_value", EmitDefaultValue = true)]
        public string digest_value { get; set; }

        /// <summary>
        /// CPF/CNPJ do emitente.
        /// </summary>
        /// <value>CPF/CNPJ do emitente.</value>
        [DataMember(Name = "emitente_cpf_cnpj", EmitDefaultValue = true)]
        public string emitente_cpf_cnpj { get; set; }

        /// <summary>
        /// Nome ou Razão Social do emitente.
        /// </summary>
        /// <value>Nome ou Razão Social do emitente.</value>
        [DataMember(Name = "emitente_nome_razao_social", EmitDefaultValue = true)]
        public string emitente_nome_razao_social { get; set; }

        /// <summary>
        /// Inscrição Estadual do emitente.
        /// </summary>
        /// <value>Inscrição Estadual do emitente.</value>
        [DataMember(Name = "emitente_inscricao_estadual", EmitDefaultValue = true)]
        public string emitente_inscricao_estadual { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DistribuicaoNfeDocumento {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  nsu: ").Append(nsu).Append("\n");
            sb.Append("  schema: ").Append(schema).Append("\n");
            sb.Append("  tipo_documento: ").Append(tipo_documento).Append("\n");
            sb.Append("  chave_acesso: ").Append(chave_acesso).Append("\n");
            sb.Append("  resumo: ").Append(resumo).Append("\n");
            sb.Append("  tipo_evento: ").Append(tipo_evento).Append("\n");
            sb.Append("  numero_sequencial: ").Append(numero_sequencial).Append("\n");
            sb.Append("  data_evento: ").Append(data_evento).Append("\n");
            sb.Append("  data_recebimento: ").Append(data_recebimento).Append("\n");
            sb.Append("  numero_protocolo: ").Append(numero_protocolo).Append("\n");
            sb.Append("  tipo_nfe: ").Append(tipo_nfe).Append("\n");
            sb.Append("  valor_nfe: ").Append(valor_nfe).Append("\n");
            sb.Append("  digest_value: ").Append(digest_value).Append("\n");
            sb.Append("  emitente_cpf_cnpj: ").Append(emitente_cpf_cnpj).Append("\n");
            sb.Append("  emitente_nome_razao_social: ").Append(emitente_nome_razao_social).Append("\n");
            sb.Append("  emitente_inscricao_estadual: ").Append(emitente_inscricao_estadual).Append("\n");
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
            return this.Equals(input as DistribuicaoNfeDocumento);
        }

        /// <summary>
        /// Returns true if DistribuicaoNfeDocumento instances are equal
        /// </summary>
        /// <param name="input">Instance of DistribuicaoNfeDocumento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistribuicaoNfeDocumento input)
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
                    this.nsu == input.nsu ||
                    (this.nsu != null &&
                    this.nsu.Equals(input.nsu))
                ) && 
                (
                    this.schema == input.schema ||
                    (this.schema != null &&
                    this.schema.Equals(input.schema))
                ) && 
                (
                    this.tipo_documento == input.tipo_documento ||
                    this.tipo_documento.Equals(input.tipo_documento)
                ) && 
                (
                    this.chave_acesso == input.chave_acesso ||
                    (this.chave_acesso != null &&
                    this.chave_acesso.Equals(input.chave_acesso))
                ) && 
                (
                    this.resumo == input.resumo ||
                    (this.resumo != null &&
                    this.resumo.Equals(input.resumo))
                ) && 
                (
                    this.tipo_evento == input.tipo_evento ||
                    (this.tipo_evento != null &&
                    this.tipo_evento.Equals(input.tipo_evento))
                ) && 
                (
                    this.numero_sequencial == input.numero_sequencial ||
                    (this.numero_sequencial != null &&
                    this.numero_sequencial.Equals(input.numero_sequencial))
                ) && 
                (
                    this.data_evento == input.data_evento ||
                    (this.data_evento != null &&
                    this.data_evento.Equals(input.data_evento))
                ) && 
                (
                    this.data_recebimento == input.data_recebimento ||
                    (this.data_recebimento != null &&
                    this.data_recebimento.Equals(input.data_recebimento))
                ) && 
                (
                    this.numero_protocolo == input.numero_protocolo ||
                    (this.numero_protocolo != null &&
                    this.numero_protocolo.Equals(input.numero_protocolo))
                ) && 
                (
                    this.tipo_nfe == input.tipo_nfe ||
                    (this.tipo_nfe != null &&
                    this.tipo_nfe.Equals(input.tipo_nfe))
                ) && 
                (
                    this.valor_nfe == input.valor_nfe ||
                    (this.valor_nfe != null &&
                    this.valor_nfe.Equals(input.valor_nfe))
                ) && 
                (
                    this.digest_value == input.digest_value ||
                    (this.digest_value != null &&
                    this.digest_value.Equals(input.digest_value))
                ) && 
                (
                    this.emitente_cpf_cnpj == input.emitente_cpf_cnpj ||
                    (this.emitente_cpf_cnpj != null &&
                    this.emitente_cpf_cnpj.Equals(input.emitente_cpf_cnpj))
                ) && 
                (
                    this.emitente_nome_razao_social == input.emitente_nome_razao_social ||
                    (this.emitente_nome_razao_social != null &&
                    this.emitente_nome_razao_social.Equals(input.emitente_nome_razao_social))
                ) && 
                (
                    this.emitente_inscricao_estadual == input.emitente_inscricao_estadual ||
                    (this.emitente_inscricao_estadual != null &&
                    this.emitente_inscricao_estadual.Equals(input.emitente_inscricao_estadual))
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
                if (this.nsu != null)
                {
                    hashCode = (hashCode * 59) + this.nsu.GetHashCode();
                }
                if (this.schema != null)
                {
                    hashCode = (hashCode * 59) + this.schema.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tipo_documento.GetHashCode();
                if (this.chave_acesso != null)
                {
                    hashCode = (hashCode * 59) + this.chave_acesso.GetHashCode();
                }
                if (this.resumo != null)
                {
                    hashCode = (hashCode * 59) + this.resumo.GetHashCode();
                }
                if (this.tipo_evento != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_evento.GetHashCode();
                }
                if (this.numero_sequencial != null)
                {
                    hashCode = (hashCode * 59) + this.numero_sequencial.GetHashCode();
                }
                if (this.data_evento != null)
                {
                    hashCode = (hashCode * 59) + this.data_evento.GetHashCode();
                }
                if (this.data_recebimento != null)
                {
                    hashCode = (hashCode * 59) + this.data_recebimento.GetHashCode();
                }
                if (this.numero_protocolo != null)
                {
                    hashCode = (hashCode * 59) + this.numero_protocolo.GetHashCode();
                }
                if (this.tipo_nfe != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_nfe.GetHashCode();
                }
                if (this.valor_nfe != null)
                {
                    hashCode = (hashCode * 59) + this.valor_nfe.GetHashCode();
                }
                if (this.digest_value != null)
                {
                    hashCode = (hashCode * 59) + this.digest_value.GetHashCode();
                }
                if (this.emitente_cpf_cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.emitente_cpf_cnpj.GetHashCode();
                }
                if (this.emitente_nome_razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.emitente_nome_razao_social.GetHashCode();
                }
                if (this.emitente_inscricao_estadual != null)
                {
                    hashCode = (hashCode * 59) + this.emitente_inscricao_estadual.GetHashCode();
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
