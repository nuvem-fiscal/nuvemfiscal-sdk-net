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
    /// Dados do Resultado do Dados do Pedido de Consulta de cadastro de contribuintes.
    /// </summary>
    [DataContract(Name = "DfeContribuinteInfCons")]
    public partial class DfeContribuinteInfCons : IEquatable<DfeContribuinteInfCons>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeContribuinteInfCons" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DfeContribuinteInfCons() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeContribuinteInfCons" /> class.
        /// </summary>
        /// <param name="codigoStatus">Código do status da mensagem enviada. (required).</param>
        /// <param name="motivoStatus">Descrição literal do status do serviço solicitado. (required).</param>
        /// <param name="uf">sigla da UF consultada, utilizar SU para SUFRAMA. (required).</param>
        /// <param name="ie">Inscrição Estadual do contribuinte..</param>
        /// <param name="cnpj">CNPJ do contribuinte..</param>
        /// <param name="cpf">CPF do contribuinte..</param>
        /// <param name="dataConsulta">Data da Consulta. (required).</param>
        /// <param name="ufAtendimento">código da UF de atendimento. (required).</param>
        /// <param name="informacoesCadastrais">informacoesCadastrais.</param>
        public DfeContribuinteInfCons(int? codigoStatus = default(int?), string motivoStatus = default(string), string uf = default(string), string ie = default(string), string cnpj = default(string), string cpf = default(string), DateTime? dataConsulta = default(DateTime?), int? ufAtendimento = default(int?), List<DfeContribuinteInfCad> informacoesCadastrais = default(List<DfeContribuinteInfCad>))
        {
            // to ensure "codigoStatus" is required (not null)
            if (codigoStatus == null)
            {
                throw new ArgumentNullException("codigoStatus is a required property for DfeContribuinteInfCons and cannot be null");
            }
            this.codigo_status = codigoStatus;
            // to ensure "motivoStatus" is required (not null)
            if (motivoStatus == null)
            {
                throw new ArgumentNullException("motivoStatus is a required property for DfeContribuinteInfCons and cannot be null");
            }
            this.motivo_status = motivoStatus;
            // to ensure "uf" is required (not null)
            if (uf == null)
            {
                throw new ArgumentNullException("uf is a required property for DfeContribuinteInfCons and cannot be null");
            }
            this.uf = uf;
            // to ensure "dataConsulta" is required (not null)
            if (dataConsulta == null)
            {
                throw new ArgumentNullException("dataConsulta is a required property for DfeContribuinteInfCons and cannot be null");
            }
            this.data_consulta = dataConsulta;
            // to ensure "ufAtendimento" is required (not null)
            if (ufAtendimento == null)
            {
                throw new ArgumentNullException("ufAtendimento is a required property for DfeContribuinteInfCons and cannot be null");
            }
            this.uf_atendimento = ufAtendimento;
            this.ie = ie;
            this.cnpj = cnpj;
            this.cpf = cpf;
            this.informacoes_cadastrais = informacoesCadastrais;
        }

        /// <summary>
        /// Código do status da mensagem enviada.
        /// </summary>
        /// <value>Código do status da mensagem enviada.</value>
        [DataMember(Name = "codigo_status", IsRequired = true, EmitDefaultValue = true)]
        public int? codigo_status { get; set; }

        /// <summary>
        /// Descrição literal do status do serviço solicitado.
        /// </summary>
        /// <value>Descrição literal do status do serviço solicitado.</value>
        [DataMember(Name = "motivo_status", IsRequired = true, EmitDefaultValue = true)]
        public string motivo_status { get; set; }

        /// <summary>
        /// sigla da UF consultada, utilizar SU para SUFRAMA.
        /// </summary>
        /// <value>sigla da UF consultada, utilizar SU para SUFRAMA.</value>
        [DataMember(Name = "uf", IsRequired = true, EmitDefaultValue = true)]
        public string uf { get; set; }

        /// <summary>
        /// Inscrição Estadual do contribuinte.
        /// </summary>
        /// <value>Inscrição Estadual do contribuinte.</value>
        [DataMember(Name = "ie", EmitDefaultValue = true)]
        public string ie { get; set; }

        /// <summary>
        /// CNPJ do contribuinte.
        /// </summary>
        /// <value>CNPJ do contribuinte.</value>
        [DataMember(Name = "cnpj", EmitDefaultValue = true)]
        public string cnpj { get; set; }

        /// <summary>
        /// CPF do contribuinte.
        /// </summary>
        /// <value>CPF do contribuinte.</value>
        [DataMember(Name = "cpf", EmitDefaultValue = true)]
        public string cpf { get; set; }

        /// <summary>
        /// Data da Consulta.
        /// </summary>
        /// <value>Data da Consulta.</value>
        [DataMember(Name = "data_consulta", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? data_consulta { get; set; }

        /// <summary>
        /// código da UF de atendimento.
        /// </summary>
        /// <value>código da UF de atendimento.</value>
        [DataMember(Name = "uf_atendimento", IsRequired = true, EmitDefaultValue = true)]
        public int? uf_atendimento { get; set; }

        /// <summary>
        /// Gets or Sets informacoes_cadastrais
        /// </summary>
        [DataMember(Name = "informacoes_cadastrais", EmitDefaultValue = false)]
        public List<DfeContribuinteInfCad> informacoes_cadastrais { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeContribuinteInfCons {\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  ie: ").Append(ie).Append("\n");
            sb.Append("  cnpj: ").Append(cnpj).Append("\n");
            sb.Append("  cpf: ").Append(cpf).Append("\n");
            sb.Append("  data_consulta: ").Append(data_consulta).Append("\n");
            sb.Append("  uf_atendimento: ").Append(uf_atendimento).Append("\n");
            sb.Append("  informacoes_cadastrais: ").Append(informacoes_cadastrais).Append("\n");
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
            return this.Equals(input as DfeContribuinteInfCons);
        }

        /// <summary>
        /// Returns true if DfeContribuinteInfCons instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeContribuinteInfCons to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeContribuinteInfCons input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.ie == input.ie ||
                    (this.ie != null &&
                    this.ie.Equals(input.ie))
                ) && 
                (
                    this.cnpj == input.cnpj ||
                    (this.cnpj != null &&
                    this.cnpj.Equals(input.cnpj))
                ) && 
                (
                    this.cpf == input.cpf ||
                    (this.cpf != null &&
                    this.cpf.Equals(input.cpf))
                ) && 
                (
                    this.data_consulta == input.data_consulta ||
                    (this.data_consulta != null &&
                    this.data_consulta.Equals(input.data_consulta))
                ) && 
                (
                    this.uf_atendimento == input.uf_atendimento ||
                    (this.uf_atendimento != null &&
                    this.uf_atendimento.Equals(input.uf_atendimento))
                ) && 
                (
                    this.informacoes_cadastrais == input.informacoes_cadastrais ||
                    this.informacoes_cadastrais != null &&
                    input.informacoes_cadastrais != null &&
                    this.informacoes_cadastrais.SequenceEqual(input.informacoes_cadastrais)
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
                if (this.codigo_status != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                }
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.ie != null)
                {
                    hashCode = (hashCode * 59) + this.ie.GetHashCode();
                }
                if (this.cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cnpj.GetHashCode();
                }
                if (this.cpf != null)
                {
                    hashCode = (hashCode * 59) + this.cpf.GetHashCode();
                }
                if (this.data_consulta != null)
                {
                    hashCode = (hashCode * 59) + this.data_consulta.GetHashCode();
                }
                if (this.uf_atendimento != null)
                {
                    hashCode = (hashCode * 59) + this.uf_atendimento.GetHashCode();
                }
                if (this.informacoes_cadastrais != null)
                {
                    hashCode = (hashCode * 59) + this.informacoes_cadastrais.GetHashCode();
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
            // codigo_status (int?) maximum
            if (this.codigo_status > (int?)999)
            {
                yield return new ValidationResult("Invalid value for codigo_status, must be a value less than or equal to 999.", new [] { "codigo_status" });
            }

            // codigo_status (int?) minimum
            if (this.codigo_status < (int?)0)
            {
                yield return new ValidationResult("Invalid value for codigo_status, must be a value greater than or equal to 0.", new [] { "codigo_status" });
            }

            // motivo_status (string) maxLength
            if (this.motivo_status != null && this.motivo_status.Length > 255)
            {
                yield return new ValidationResult("Invalid value for motivo_status, length must be less than 255.", new [] { "motivo_status" });
            }

            // motivo_status (string) minLength
            if (this.motivo_status != null && this.motivo_status.Length < 1)
            {
                yield return new ValidationResult("Invalid value for motivo_status, length must be greater than 1.", new [] { "motivo_status" });
            }

            yield break;
        }
    }

}
