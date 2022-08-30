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
    /// RpsDados
    /// </summary>
    [DataContract(Name = "RpsDados")]
    public partial class RpsDados : IEquatable<RpsDados>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDados" /> class.
        /// </summary>
        /// <param name="identificacaoRps">identificacaoRps.</param>
        /// <param name="dataEmissao">dataEmissao.</param>
        public RpsDados(RpsIdentificacao identificacaoRps = default(RpsIdentificacao), DateTime dataEmissao = default(DateTime))
        {
            this.identificacao_rps = identificacaoRps;
            this.data_emissao = dataEmissao;
        }

        /// <summary>
        /// Gets or Sets identificacao_rps
        /// </summary>
        [DataMember(Name = "identificacao_rps", EmitDefaultValue = false)]
        public RpsIdentificacao identificacao_rps { get; set; }

        /// <summary>
        /// Gets or Sets data_emissao
        /// </summary>
        [DataMember(Name = "data_emissao", EmitDefaultValue = false)]
        public DateTime data_emissao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsDados {\n");
            sb.Append("  identificacao_rps: ").Append(identificacao_rps).Append("\n");
            sb.Append("  data_emissao: ").Append(data_emissao).Append("\n");
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
            return this.Equals(input as RpsDados);
        }

        /// <summary>
        /// Returns true if RpsDados instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsDados to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsDados input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.identificacao_rps == input.identificacao_rps ||
                    (this.identificacao_rps != null &&
                    this.identificacao_rps.Equals(input.identificacao_rps))
                ) && 
                (
                    this.data_emissao == input.data_emissao ||
                    (this.data_emissao != null &&
                    this.data_emissao.Equals(input.data_emissao))
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
                if (this.identificacao_rps != null)
                {
                    hashCode = (hashCode * 59) + this.identificacao_rps.GetHashCode();
                }
                if (this.data_emissao != null)
                {
                    hashCode = (hashCode * 59) + this.data_emissao.GetHashCode();
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
