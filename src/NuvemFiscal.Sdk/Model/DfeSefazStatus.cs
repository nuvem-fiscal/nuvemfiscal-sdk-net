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
    /// DfeSefazStatus
    /// </summary>
    [DataContract(Name = "DfeSefazStatus")]
    public partial class DfeSefazStatus : IEquatable<DfeSefazStatus>, IValidatableObject
    {
        /// <summary>
        /// SEFAZ autorizadora responsável.
        /// </summary>
        /// <value>SEFAZ autorizadora responsável.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutorizadorEnum
        {
            /// <summary>
            /// Enum AM for value: AM
            /// </summary>
            [EnumMember(Value = "AM")]
            AM = 1,

            /// <summary>
            /// Enum BA for value: BA
            /// </summary>
            [EnumMember(Value = "BA")]
            BA = 2,

            /// <summary>
            /// Enum CE for value: CE
            /// </summary>
            [EnumMember(Value = "CE")]
            CE = 3,

            /// <summary>
            /// Enum GO for value: GO
            /// </summary>
            [EnumMember(Value = "GO")]
            GO = 4,

            /// <summary>
            /// Enum MG for value: MG
            /// </summary>
            [EnumMember(Value = "MG")]
            MG = 5,

            /// <summary>
            /// Enum MS for value: MS
            /// </summary>
            [EnumMember(Value = "MS")]
            MS = 6,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 7,

            /// <summary>
            /// Enum PE for value: PE
            /// </summary>
            [EnumMember(Value = "PE")]
            PE = 8,

            /// <summary>
            /// Enum PR for value: PR
            /// </summary>
            [EnumMember(Value = "PR")]
            PR = 9,

            /// <summary>
            /// Enum RS for value: RS
            /// </summary>
            [EnumMember(Value = "RS")]
            RS = 10,

            /// <summary>
            /// Enum SP for value: SP
            /// </summary>
            [EnumMember(Value = "SP")]
            SP = 11,

            /// <summary>
            /// Enum SVAN for value: SVAN
            /// </summary>
            [EnumMember(Value = "SVAN")]
            SVAN = 12,

            /// <summary>
            /// Enum SVRS for value: SVRS
            /// </summary>
            [EnumMember(Value = "SVRS")]
            SVRS = 13,

            /// <summary>
            /// Enum SVCAN for value: SVCAN
            /// </summary>
            [EnumMember(Value = "SVCAN")]
            SVCAN = 14,

            /// <summary>
            /// Enum SVCRS for value: SVCRS
            /// </summary>
            [EnumMember(Value = "SVCRS")]
            SVCRS = 15,

            /// <summary>
            /// Enum AN for value: AN
            /// </summary>
            [EnumMember(Value = "AN")]
            AN = 16,

            /// <summary>
            /// Enum SVSP for value: SVSP
            /// </summary>
            [EnumMember(Value = "SVSP")]
            SVSP = 17,

            /// <summary>
            /// Enum SVCSP for value: SVCSP
            /// </summary>
            [EnumMember(Value = "SVCSP")]
            SVCSP = 18

        }


        /// <summary>
        /// SEFAZ autorizadora responsável.
        /// </summary>
        /// <value>SEFAZ autorizadora responsável.</value>
        [DataMember(Name = "autorizador", EmitDefaultValue = false)]
        public AutorizadorEnum? autorizador { get; set; }
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
        [DataMember(Name = "ambiente", EmitDefaultValue = false)]
        public AmbienteEnum? ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeSefazStatus" /> class.
        /// </summary>
        /// <param name="autorizador">SEFAZ autorizadora responsável..</param>
        /// <param name="ambiente">Identificação do Ambiente..</param>
        /// <param name="dataHoraConsulta">Data e hora da consulta..</param>
        /// <param name="codigoStatus">Código do status da mensagem enviada..</param>
        /// <param name="motivoStatus">Descrição literal do status do serviço solicitado..</param>
        /// <param name="tempoMedioResposta">Tempo médio de resposta do serviço (em segundos) dos últimos 5 minutos..</param>
        /// <param name="dataHoraRetorno">Data e hora prevista para o retorno dos serviços prestados..</param>
        public DfeSefazStatus(AutorizadorEnum? autorizador = default(AutorizadorEnum?), AmbienteEnum? ambiente = default(AmbienteEnum?), DateTime dataHoraConsulta = default(DateTime), int codigoStatus = default(int), string motivoStatus = default(string), int? tempoMedioResposta = default(int?), DateTime? dataHoraRetorno = default(DateTime?))
        {
            this.autorizador = autorizador;
            this.ambiente = ambiente;
            this.data_hora_consulta = dataHoraConsulta;
            this.codigo_status = codigoStatus;
            this.motivo_status = motivoStatus;
            this.tempo_medio_resposta = tempoMedioResposta;
            this.data_hora_retorno = dataHoraRetorno;
        }

        /// <summary>
        /// Data e hora da consulta.
        /// </summary>
        /// <value>Data e hora da consulta.</value>
        [DataMember(Name = "data_hora_consulta", EmitDefaultValue = false)]
        public DateTime data_hora_consulta { get; set; }

        /// <summary>
        /// Código do status da mensagem enviada.
        /// </summary>
        /// <value>Código do status da mensagem enviada.</value>
        [DataMember(Name = "codigo_status", EmitDefaultValue = false)]
        public int codigo_status { get; set; }

        /// <summary>
        /// Descrição literal do status do serviço solicitado.
        /// </summary>
        /// <value>Descrição literal do status do serviço solicitado.</value>
        [DataMember(Name = "motivo_status", EmitDefaultValue = false)]
        public string motivo_status { get; set; }

        /// <summary>
        /// Tempo médio de resposta do serviço (em segundos) dos últimos 5 minutos.
        /// </summary>
        /// <value>Tempo médio de resposta do serviço (em segundos) dos últimos 5 minutos.</value>
        [DataMember(Name = "tempo_medio_resposta", EmitDefaultValue = true)]
        public int? tempo_medio_resposta { get; set; }

        /// <summary>
        /// Data e hora prevista para o retorno dos serviços prestados.
        /// </summary>
        /// <value>Data e hora prevista para o retorno dos serviços prestados.</value>
        [DataMember(Name = "data_hora_retorno", EmitDefaultValue = true)]
        public DateTime? data_hora_retorno { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeSefazStatus {\n");
            sb.Append("  autorizador: ").Append(autorizador).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
            sb.Append("  data_hora_consulta: ").Append(data_hora_consulta).Append("\n");
            sb.Append("  codigo_status: ").Append(codigo_status).Append("\n");
            sb.Append("  motivo_status: ").Append(motivo_status).Append("\n");
            sb.Append("  tempo_medio_resposta: ").Append(tempo_medio_resposta).Append("\n");
            sb.Append("  data_hora_retorno: ").Append(data_hora_retorno).Append("\n");
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
            return this.Equals(input as DfeSefazStatus);
        }

        /// <summary>
        /// Returns true if DfeSefazStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeSefazStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeSefazStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.autorizador == input.autorizador ||
                    this.autorizador.Equals(input.autorizador)
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
                ) && 
                (
                    this.data_hora_consulta == input.data_hora_consulta ||
                    (this.data_hora_consulta != null &&
                    this.data_hora_consulta.Equals(input.data_hora_consulta))
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
                    this.tempo_medio_resposta == input.tempo_medio_resposta ||
                    (this.tempo_medio_resposta != null &&
                    this.tempo_medio_resposta.Equals(input.tempo_medio_resposta))
                ) && 
                (
                    this.data_hora_retorno == input.data_hora_retorno ||
                    (this.data_hora_retorno != null &&
                    this.data_hora_retorno.Equals(input.data_hora_retorno))
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
                hashCode = (hashCode * 59) + this.autorizador.GetHashCode();
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
                if (this.data_hora_consulta != null)
                {
                    hashCode = (hashCode * 59) + this.data_hora_consulta.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_status.GetHashCode();
                if (this.motivo_status != null)
                {
                    hashCode = (hashCode * 59) + this.motivo_status.GetHashCode();
                }
                if (this.tempo_medio_resposta != null)
                {
                    hashCode = (hashCode * 59) + this.tempo_medio_resposta.GetHashCode();
                }
                if (this.data_hora_retorno != null)
                {
                    hashCode = (hashCode * 59) + this.data_hora_retorno.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
