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
    /// EmpresaConfigDistribuicaoNfe
    /// </summary>
    [DataContract(Name = "EmpresaConfigDistribuicaoNfe")]
    public partial class EmpresaConfigDistribuicaoNfe : IEquatable<EmpresaConfigDistribuicaoNfe>, IValidatableObject
    {
        /// <summary>
        /// Indica se a empresa irá emitir em produção ou homologação.
        /// </summary>
        /// <value>Indica se a empresa irá emitir em produção ou homologação.</value>
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
        /// Indica se a empresa irá emitir em produção ou homologação.
        /// </summary>
        /// <value>Indica se a empresa irá emitir em produção ou homologação.</value>
        [DataMember(Name = "ambiente", IsRequired = true, EmitDefaultValue = true)]
        public AmbienteEnum ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigDistribuicaoNfe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmpresaConfigDistribuicaoNfe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigDistribuicaoNfe" /> class.
        /// </summary>
        /// <param name="distribuicaoAutomatica">Indica se a distribuição automática está habilitada.    Quando ativada, a API da Nuvem Fiscal realizará automaticamente pedidos de  distribuição de notas fiscais eletrônicas (NF-e) utilizando o último NSU.    A frequência dessas distribuições é controlada pelo campo &#x60;distribuicao_intervalo_horas&#x60;,  cujo valor padrão é 24 horas (uma vez ao dia). (default to false).</param>
        /// <param name="distribuicaoIntervaloHoras">Define o intervalo mínimo, em horas, entre distribuições automáticas de documentos.    Esse valor determina com que frequência a API da Nuvem Fiscal executará novas  requisições automáticas de distribuição de notas fiscais eletrônicas (NF-e).    Deve ser um valor entre 1 e 24. Por exemplo, se configurado como 4, uma nova  tentativa de distribuição só será feita se pelo menos 4 horas tiverem se passado  desde a última requisição.    Esse campo só é relevante quando &#x60;distribuicao_automatica&#x60; estiver habilitado..</param>
        /// <param name="cienciaAutomatica">Indica se a manifestação de Ciência da Operação (210210) deve ser feita  automaticamente pela API.    Caso habilitada, a manifestação de ciência será realizada para notas  recebidas por qualquer forma de consulta ou modo de distribuição (manual ou automático). (default to false).</param>
        /// <param name="ambiente">Indica se a empresa irá emitir em produção ou homologação. (required).</param>
        public EmpresaConfigDistribuicaoNfe(bool? distribuicaoAutomatica = false, int? distribuicaoIntervaloHoras = default(int?), bool? cienciaAutomatica = false, AmbienteEnum ambiente = default(AmbienteEnum))
        {
            this.ambiente = ambiente;
            // use default value if no "distribuicaoAutomatica" provided
            this.distribuicao_automatica = distribuicaoAutomatica ?? false;
            this.distribuicao_intervalo_horas = distribuicaoIntervaloHoras;
            // use default value if no "cienciaAutomatica" provided
            this.ciencia_automatica = cienciaAutomatica ?? false;
        }

        /// <summary>
        /// Indica se a distribuição automática está habilitada.    Quando ativada, a API da Nuvem Fiscal realizará automaticamente pedidos de  distribuição de notas fiscais eletrônicas (NF-e) utilizando o último NSU.    A frequência dessas distribuições é controlada pelo campo &#x60;distribuicao_intervalo_horas&#x60;,  cujo valor padrão é 24 horas (uma vez ao dia).
        /// </summary>
        /// <value>Indica se a distribuição automática está habilitada.    Quando ativada, a API da Nuvem Fiscal realizará automaticamente pedidos de  distribuição de notas fiscais eletrônicas (NF-e) utilizando o último NSU.    A frequência dessas distribuições é controlada pelo campo &#x60;distribuicao_intervalo_horas&#x60;,  cujo valor padrão é 24 horas (uma vez ao dia).</value>
        [DataMember(Name = "distribuicao_automatica", EmitDefaultValue = true)]
        public bool? distribuicao_automatica { get; set; }

        /// <summary>
        /// Define o intervalo mínimo, em horas, entre distribuições automáticas de documentos.    Esse valor determina com que frequência a API da Nuvem Fiscal executará novas  requisições automáticas de distribuição de notas fiscais eletrônicas (NF-e).    Deve ser um valor entre 1 e 24. Por exemplo, se configurado como 4, uma nova  tentativa de distribuição só será feita se pelo menos 4 horas tiverem se passado  desde a última requisição.    Esse campo só é relevante quando &#x60;distribuicao_automatica&#x60; estiver habilitado.
        /// </summary>
        /// <value>Define o intervalo mínimo, em horas, entre distribuições automáticas de documentos.    Esse valor determina com que frequência a API da Nuvem Fiscal executará novas  requisições automáticas de distribuição de notas fiscais eletrônicas (NF-e).    Deve ser um valor entre 1 e 24. Por exemplo, se configurado como 4, uma nova  tentativa de distribuição só será feita se pelo menos 4 horas tiverem se passado  desde a última requisição.    Esse campo só é relevante quando &#x60;distribuicao_automatica&#x60; estiver habilitado.</value>
        [DataMember(Name = "distribuicao_intervalo_horas", EmitDefaultValue = true)]
        public int? distribuicao_intervalo_horas { get; set; }

        /// <summary>
        /// Indica se a manifestação de Ciência da Operação (210210) deve ser feita  automaticamente pela API.    Caso habilitada, a manifestação de ciência será realizada para notas  recebidas por qualquer forma de consulta ou modo de distribuição (manual ou automático).
        /// </summary>
        /// <value>Indica se a manifestação de Ciência da Operação (210210) deve ser feita  automaticamente pela API.    Caso habilitada, a manifestação de ciência será realizada para notas  recebidas por qualquer forma de consulta ou modo de distribuição (manual ou automático).</value>
        [DataMember(Name = "ciencia_automatica", EmitDefaultValue = true)]
        public bool? ciencia_automatica { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigDistribuicaoNfe {\n");
            sb.Append("  distribuicao_automatica: ").Append(distribuicao_automatica).Append("\n");
            sb.Append("  distribuicao_intervalo_horas: ").Append(distribuicao_intervalo_horas).Append("\n");
            sb.Append("  ciencia_automatica: ").Append(ciencia_automatica).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
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
            return this.Equals(input as EmpresaConfigDistribuicaoNfe);
        }

        /// <summary>
        /// Returns true if EmpresaConfigDistribuicaoNfe instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigDistribuicaoNfe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigDistribuicaoNfe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.distribuicao_automatica == input.distribuicao_automatica ||
                    (this.distribuicao_automatica != null &&
                    this.distribuicao_automatica.Equals(input.distribuicao_automatica))
                ) && 
                (
                    this.distribuicao_intervalo_horas == input.distribuicao_intervalo_horas ||
                    (this.distribuicao_intervalo_horas != null &&
                    this.distribuicao_intervalo_horas.Equals(input.distribuicao_intervalo_horas))
                ) && 
                (
                    this.ciencia_automatica == input.ciencia_automatica ||
                    (this.ciencia_automatica != null &&
                    this.ciencia_automatica.Equals(input.ciencia_automatica))
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
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
                if (this.distribuicao_automatica != null)
                {
                    hashCode = (hashCode * 59) + this.distribuicao_automatica.GetHashCode();
                }
                if (this.distribuicao_intervalo_horas != null)
                {
                    hashCode = (hashCode * 59) + this.distribuicao_intervalo_horas.GetHashCode();
                }
                if (this.ciencia_automatica != null)
                {
                    hashCode = (hashCode * 59) + this.ciencia_automatica.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
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
            // distribuicao_intervalo_horas (int?) maximum
            if (this.distribuicao_intervalo_horas > (int?)24)
            {
                yield return new ValidationResult("Invalid value for distribuicao_intervalo_horas, must be a value less than or equal to 24.", new [] { "distribuicao_intervalo_horas" });
            }

            // distribuicao_intervalo_horas (int?) minimum
            if (this.distribuicao_intervalo_horas < (int?)1)
            {
                yield return new ValidationResult("Invalid value for distribuicao_intervalo_horas, must be a value greater than or equal to 1.", new [] { "distribuicao_intervalo_horas" });
            }

            yield break;
        }
    }

}
