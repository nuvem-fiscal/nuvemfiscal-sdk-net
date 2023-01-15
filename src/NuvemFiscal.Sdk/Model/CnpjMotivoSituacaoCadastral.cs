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
    /// Motivo da situação cadastral.
    /// </summary>
    [DataContract(Name = "CnpjMotivoSituacaoCadastral")]
    public partial class CnpjMotivoSituacaoCadastral : IEquatable<CnpjMotivoSituacaoCadastral>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjMotivoSituacaoCadastral" /> class.
        /// </summary>
        /// <param name="data">Data do evento..</param>
        /// <param name="codigo">Código do motivo da situação cadastral..</param>
        /// <param name="descricao">Descrição do motivo da situação cadastral..</param>
        public CnpjMotivoSituacaoCadastral(DateTime data = default(DateTime), string codigo = default(string), string descricao = default(string))
        {
            this.data = data;
            this.codigo = codigo;
            this.descricao = descricao;
        }

        /// <summary>
        /// Data do evento.
        /// </summary>
        /// <value>Data do evento.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data { get; set; }

        /// <summary>
        /// Código do motivo da situação cadastral.
        /// </summary>
        /// <value>Código do motivo da situação cadastral.</value>
        [DataMember(Name = "codigo", EmitDefaultValue = false)]
        public string codigo { get; set; }

        /// <summary>
        /// Descrição do motivo da situação cadastral.
        /// </summary>
        /// <value>Descrição do motivo da situação cadastral.</value>
        [DataMember(Name = "descricao", EmitDefaultValue = false)]
        public string descricao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjMotivoSituacaoCadastral {\n");
            sb.Append("  data: ").Append(data).Append("\n");
            sb.Append("  codigo: ").Append(codigo).Append("\n");
            sb.Append("  descricao: ").Append(descricao).Append("\n");
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
            return this.Equals(input as CnpjMotivoSituacaoCadastral);
        }

        /// <summary>
        /// Returns true if CnpjMotivoSituacaoCadastral instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjMotivoSituacaoCadastral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjMotivoSituacaoCadastral input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.data == input.data ||
                    (this.data != null &&
                    this.data.Equals(input.data))
                ) && 
                (
                    this.codigo == input.codigo ||
                    (this.codigo != null &&
                    this.codigo.Equals(input.codigo))
                ) && 
                (
                    this.descricao == input.descricao ||
                    (this.descricao != null &&
                    this.descricao.Equals(input.descricao))
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
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
                }
                if (this.codigo != null)
                {
                    hashCode = (hashCode * 59) + this.codigo.GetHashCode();
                }
                if (this.descricao != null)
                {
                    hashCode = (hashCode * 59) + this.descricao.GetHashCode();
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
