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
        /// <param name="distribuicaoAutomatica">Indica se a distribuição automática está habilitada.    Nesse modo, a API da Nuvem Fiscal irá realizar pedidos de distribuição  pelo último NSU de forma automática a cada 1 hora. (default to false).</param>
        /// <param name="cienciaAutomatica">Indica se a manifestação de Ciência da Operação (210210) deve ser feita  automaticamente pela API.    Caso habilitada, a manifestação de ciência será realizada para notas  recebidas por qualquer forma de consulta ou modo de distribuição (manual ou automático). (default to false).</param>
        /// <param name="ambiente">Indica se a empresa irá emitir em produção ou homologação. (required).</param>
        public EmpresaConfigDistribuicaoNfe(bool? distribuicaoAutomatica = false, bool? cienciaAutomatica = false, AmbienteEnum ambiente = default(AmbienteEnum))
        {
            this.ambiente = ambiente;
            // use default value if no "distribuicaoAutomatica" provided
            this.distribuicao_automatica = distribuicaoAutomatica ?? false;
            // use default value if no "cienciaAutomatica" provided
            this.ciencia_automatica = cienciaAutomatica ?? false;
        }

        /// <summary>
        /// Indica se a distribuição automática está habilitada.    Nesse modo, a API da Nuvem Fiscal irá realizar pedidos de distribuição  pelo último NSU de forma automática a cada 1 hora.
        /// </summary>
        /// <value>Indica se a distribuição automática está habilitada.    Nesse modo, a API da Nuvem Fiscal irá realizar pedidos de distribuição  pelo último NSU de forma automática a cada 1 hora.</value>
        [DataMember(Name = "distribuicao_automatica", EmitDefaultValue = true)]
        public bool? distribuicao_automatica { get; set; }

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
            yield break;
        }
    }

}
