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
    /// DistribuicaoNfePedido
    /// </summary>
    [DataContract(Name = "DistribuicaoNfePedido")]
    public partial class DistribuicaoNfePedido : IEquatable<DistribuicaoNfePedido>, IValidatableObject
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
        /// Tipo de consulta.   Valores possíveis: * &#x60;dist-nsu&#x60; - Consulta pelo último NSU recebido. * &#x60;cons-nsu&#x60; - Consulta por um NSU específico. * &#x60;cons-chave&#x60; - Consulta pela chave de acesso da NF-e.
        /// </summary>
        /// <value>Tipo de consulta.   Valores possíveis: * &#x60;dist-nsu&#x60; - Consulta pelo último NSU recebido. * &#x60;cons-nsu&#x60; - Consulta por um NSU específico. * &#x60;cons-chave&#x60; - Consulta pela chave de acesso da NF-e.</value>
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
        /// Tipo de consulta.   Valores possíveis: * &#x60;dist-nsu&#x60; - Consulta pelo último NSU recebido. * &#x60;cons-nsu&#x60; - Consulta por um NSU específico. * &#x60;cons-chave&#x60; - Consulta pela chave de acesso da NF-e.
        /// </summary>
        /// <value>Tipo de consulta.   Valores possíveis: * &#x60;dist-nsu&#x60; - Consulta pelo último NSU recebido. * &#x60;cons-nsu&#x60; - Consulta por um NSU específico. * &#x60;cons-chave&#x60; - Consulta pela chave de acesso da NF-e.</value>
        [DataMember(Name = "tipo_consulta", IsRequired = true, EmitDefaultValue = true)]
        public TipoConsultaEnum tipo_consulta { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfePedido" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistribuicaoNfePedido() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicaoNfePedido" /> class.
        /// </summary>
        /// <param name="cpfCnpj">CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*. (required).</param>
        /// <param name="ambiente">Identificação do Ambiente. (required).</param>
        /// <param name="ufAutor">Sigla da UF do autor..</param>
        /// <param name="tipoConsulta">Tipo de consulta.   Valores possíveis: * &#x60;dist-nsu&#x60; - Consulta pelo último NSU recebido. * &#x60;cons-nsu&#x60; - Consulta por um NSU específico. * &#x60;cons-chave&#x60; - Consulta pela chave de acesso da NF-e. (required).</param>
        /// <param name="distNsu">Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;dist-nsu\&quot;.*.</param>
        /// <param name="consNsu">Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;cons-nsu\&quot;.*.</param>
        /// <param name="consChave">Consulta de NF-e por chave de acesso informada.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;cons-chave\&quot;.*.</param>
        /// <param name="ignorarTempoEspera">Deve ser utilizado em situações em que o cliente  deseja ignorar o intervalo mínimo de 1 hora entre pedidos de distribuição  de NF-e. Quando habilitado, o cliente reconhece os riscos associados,  incluindo o bloqueio do CNPJ no Ambiente Nacional da SEFAZ, caso seja  caracterizado consumo indevido.    Valores:  * &#x60;false&#x60;: Respeita a regra de intervalo mínimo de 1 hora entre consultas    quando não há mais documentos disponíveis.    * &#x60;true&#x60;: Ignora o tempo de espera e força a requisição. (default to false).</param>
        public DistribuicaoNfePedido(string cpfCnpj = default(string), AmbienteEnum ambiente = default(AmbienteEnum), string ufAutor = default(string), TipoConsultaEnum tipoConsulta = default(TipoConsultaEnum), int? distNsu = default(int?), int? consNsu = default(int?), string consChave = default(string), bool ignorarTempoEspera = false)
        {
            // to ensure "cpfCnpj" is required (not null)
            if (cpfCnpj == null)
            {
                throw new ArgumentNullException("cpfCnpj is a required property for DistribuicaoNfePedido and cannot be null");
            }
            this.cpf_cnpj = cpfCnpj;
            this.ambiente = ambiente;
            this.tipo_consulta = tipoConsulta;
            this.uf_autor = ufAutor;
            this.dist_nsu = distNsu;
            this.cons_nsu = consNsu;
            this.cons_chave = consChave;
            this.ignorar_tempo_espera = ignorarTempoEspera;
        }

        /// <summary>
        /// CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.
        /// </summary>
        /// <value>CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</value>
        [DataMember(Name = "cpf_cnpj", IsRequired = true, EmitDefaultValue = true)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Sigla da UF do autor.
        /// </summary>
        /// <value>Sigla da UF do autor.</value>
        [DataMember(Name = "uf_autor", EmitDefaultValue = true)]
        public string uf_autor { get; set; }

        /// <summary>
        /// Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;dist-nsu\&quot;.*
        /// </summary>
        /// <value>Distribuição de conjunto de DF-e a partir do NSU informado.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;dist-nsu\&quot;.*</value>
        [DataMember(Name = "dist_nsu", EmitDefaultValue = true)]
        public int? dist_nsu { get; set; }

        /// <summary>
        /// Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;cons-nsu\&quot;.*
        /// </summary>
        /// <value>Consulta DF-e vinculado ao NSU informado.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;cons-nsu\&quot;.*</value>
        [DataMember(Name = "cons_nsu", EmitDefaultValue = true)]
        public int? cons_nsu { get; set; }

        /// <summary>
        /// Consulta de NF-e por chave de acesso informada.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;cons-chave\&quot;.*
        /// </summary>
        /// <value>Consulta de NF-e por chave de acesso informada.    *Obrigatório quando \&quot;tipo_consulta\&quot; for \&quot;cons-chave\&quot;.*</value>
        [DataMember(Name = "cons_chave", EmitDefaultValue = true)]
        public string cons_chave { get; set; }

        /// <summary>
        /// Deve ser utilizado em situações em que o cliente  deseja ignorar o intervalo mínimo de 1 hora entre pedidos de distribuição  de NF-e. Quando habilitado, o cliente reconhece os riscos associados,  incluindo o bloqueio do CNPJ no Ambiente Nacional da SEFAZ, caso seja  caracterizado consumo indevido.    Valores:  * &#x60;false&#x60;: Respeita a regra de intervalo mínimo de 1 hora entre consultas    quando não há mais documentos disponíveis.    * &#x60;true&#x60;: Ignora o tempo de espera e força a requisição.
        /// </summary>
        /// <value>Deve ser utilizado em situações em que o cliente  deseja ignorar o intervalo mínimo de 1 hora entre pedidos de distribuição  de NF-e. Quando habilitado, o cliente reconhece os riscos associados,  incluindo o bloqueio do CNPJ no Ambiente Nacional da SEFAZ, caso seja  caracterizado consumo indevido.    Valores:  * &#x60;false&#x60;: Respeita a regra de intervalo mínimo de 1 hora entre consultas    quando não há mais documentos disponíveis.    * &#x60;true&#x60;: Ignora o tempo de espera e força a requisição.</value>
        [DataMember(Name = "ignorar_tempo_espera", EmitDefaultValue = true)]
        public bool ignorar_tempo_espera { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DistribuicaoNfePedido {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  uf_autor: ").Append(uf_autor).Append("\n");
            sb.Append("  tipo_consulta: ").Append(tipo_consulta).Append("\n");
            sb.Append("  dist_nsu: ").Append(dist_nsu).Append("\n");
            sb.Append("  cons_nsu: ").Append(cons_nsu).Append("\n");
            sb.Append("  cons_chave: ").Append(cons_chave).Append("\n");
            sb.Append("  ignorar_tempo_espera: ").Append(ignorar_tempo_espera).Append("\n");
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
            return this.Equals(input as DistribuicaoNfePedido);
        }

        /// <summary>
        /// Returns true if DistribuicaoNfePedido instances are equal
        /// </summary>
        /// <param name="input">Instance of DistribuicaoNfePedido to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistribuicaoNfePedido input)
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
                    this.ignorar_tempo_espera == input.ignorar_tempo_espera ||
                    this.ignorar_tempo_espera.Equals(input.ignorar_tempo_espera)
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
                hashCode = (hashCode * 59) + this.ignorar_tempo_espera.GetHashCode();
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
