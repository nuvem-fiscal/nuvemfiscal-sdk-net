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
    /// DistribuicaoNfeNota
    /// </summary>
    [DataContract(Name = "DistribuicaoNfeNota")]
    public partial class DistribuicaoNfeNota : IEquatable<DistribuicaoNfeNota>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfeNota" /> class.
        /// </summary>
        /// <param name="chaveAcesso">Chave de Acesso da NF-e..</param>
        /// <param name="numeroProtocolo">Número do protocolo de autorização..</param>
        /// <param name="tipoNfe">Tipo da NF-e (0 - entrada; 1 - saída)..</param>
        /// <param name="dataEmissao">Data e hora da emissão do documento fiscal..</param>
        /// <param name="valorNfe">Valor total da NF-e..</param>
        /// <param name="digestValue">Digest Value da NF-e processada. Utilizado para conferir a integridade da NF-e original..</param>
        /// <param name="emitenteCpfCnpj">CPF/CNPJ do emitente..</param>
        /// <param name="emitenteNomeRazaoSocial">Nome ou Razão Social do emitente..</param>
        /// <param name="emitenteInscricaoEstadual">Inscrição Estadual do emitente..</param>
        public DistribuicaoNfeNota(string chaveAcesso = default(string), string numeroProtocolo = default(string), int? tipoNfe = default(int?), DateTime? dataEmissao = default(DateTime?), decimal? valorNfe = default(decimal?), string digestValue = default(string), string emitenteCpfCnpj = default(string), string emitenteNomeRazaoSocial = default(string), string emitenteInscricaoEstadual = default(string))
        {
            this.chave_acesso = chaveAcesso;
            this.numero_protocolo = numeroProtocolo;
            this.tipo_nfe = tipoNfe;
            this.data_emissao = dataEmissao;
            this.valor_nfe = valorNfe;
            this.digest_value = digestValue;
            this.emitente_cpf_cnpj = emitenteCpfCnpj;
            this.emitente_nome_razao_social = emitenteNomeRazaoSocial;
            this.emitente_inscricao_estadual = emitenteInscricaoEstadual;
        }

        /// <summary>
        /// Chave de Acesso da NF-e.
        /// </summary>
        /// <value>Chave de Acesso da NF-e.</value>
        [DataMember(Name = "chave_acesso", EmitDefaultValue = true)]
        public string chave_acesso { get; set; }

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
        /// Data e hora da emissão do documento fiscal.
        /// </summary>
        /// <value>Data e hora da emissão do documento fiscal.</value>
        [DataMember(Name = "data_emissao", EmitDefaultValue = true)]
        public DateTime? data_emissao { get; set; }

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
            sb.Append("class DistribuicaoNfeNota {\n");
            sb.Append("  chave_acesso: ").Append(chave_acesso).Append("\n");
            sb.Append("  numero_protocolo: ").Append(numero_protocolo).Append("\n");
            sb.Append("  tipo_nfe: ").Append(tipo_nfe).Append("\n");
            sb.Append("  data_emissao: ").Append(data_emissao).Append("\n");
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
            return this.Equals(input as DistribuicaoNfeNota);
        }

        /// <summary>
        /// Returns true if DistribuicaoNfeNota instances are equal
        /// </summary>
        /// <param name="input">Instance of DistribuicaoNfeNota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistribuicaoNfeNota input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chave_acesso == input.chave_acesso ||
                    (this.chave_acesso != null &&
                    this.chave_acesso.Equals(input.chave_acesso))
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
                    this.data_emissao == input.data_emissao ||
                    (this.data_emissao != null &&
                    this.data_emissao.Equals(input.data_emissao))
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
                if (this.chave_acesso != null)
                {
                    hashCode = (hashCode * 59) + this.chave_acesso.GetHashCode();
                }
                if (this.numero_protocolo != null)
                {
                    hashCode = (hashCode * 59) + this.numero_protocolo.GetHashCode();
                }
                if (this.tipo_nfe != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_nfe.GetHashCode();
                }
                if (this.data_emissao != null)
                {
                    hashCode = (hashCode * 59) + this.data_emissao.GetHashCode();
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
