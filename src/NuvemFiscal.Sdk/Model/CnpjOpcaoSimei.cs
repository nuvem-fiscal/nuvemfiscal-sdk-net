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
    /// Informações da opção pelo MEI.
    /// </summary>
    [DataContract(Name = "CnpjOpcaoSimei")]
    public partial class CnpjOpcaoSimei : IEquatable<CnpjOpcaoSimei>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjOpcaoSimei" /> class.
        /// </summary>
        /// <param name="optante">Indicador da existência da opção pelo MEI:  * &#x60;true&#x60; - É optante.  * &#x60;false&#x60; - Não é optante..</param>
        /// <param name="dataOpcao">Data da opção pelo MEI..</param>
        /// <param name="dataExclusao">Data da exclusão do MEI..</param>
        public CnpjOpcaoSimei(bool optante = default(bool), DateTime? dataOpcao = default(DateTime?), DateTime? dataExclusao = default(DateTime?))
        {
            this.optante = optante;
            this.data_opcao = dataOpcao;
            this.data_exclusao = dataExclusao;
        }

        /// <summary>
        /// Indicador da existência da opção pelo MEI:  * &#x60;true&#x60; - É optante.  * &#x60;false&#x60; - Não é optante.
        /// </summary>
        /// <value>Indicador da existência da opção pelo MEI:  * &#x60;true&#x60; - É optante.  * &#x60;false&#x60; - Não é optante.</value>
        [DataMember(Name = "optante", EmitDefaultValue = true)]
        public bool optante { get; set; }

        /// <summary>
        /// Data da opção pelo MEI.
        /// </summary>
        /// <value>Data da opção pelo MEI.</value>
        [DataMember(Name = "data_opcao", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? data_opcao { get; set; }

        /// <summary>
        /// Data da exclusão do MEI.
        /// </summary>
        /// <value>Data da exclusão do MEI.</value>
        [DataMember(Name = "data_exclusao", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? data_exclusao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjOpcaoSimei {\n");
            sb.Append("  optante: ").Append(optante).Append("\n");
            sb.Append("  data_opcao: ").Append(data_opcao).Append("\n");
            sb.Append("  data_exclusao: ").Append(data_exclusao).Append("\n");
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
            return this.Equals(input as CnpjOpcaoSimei);
        }

        /// <summary>
        /// Returns true if CnpjOpcaoSimei instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjOpcaoSimei to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjOpcaoSimei input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.optante == input.optante ||
                    this.optante.Equals(input.optante)
                ) && 
                (
                    this.data_opcao == input.data_opcao ||
                    (this.data_opcao != null &&
                    this.data_opcao.Equals(input.data_opcao))
                ) && 
                (
                    this.data_exclusao == input.data_exclusao ||
                    (this.data_exclusao != null &&
                    this.data_exclusao.Equals(input.data_exclusao))
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
                hashCode = (hashCode * 59) + this.optante.GetHashCode();
                if (this.data_opcao != null)
                {
                    hashCode = (hashCode * 59) + this.data_opcao.GetHashCode();
                }
                if (this.data_exclusao != null)
                {
                    hashCode = (hashCode * 59) + this.data_exclusao.GetHashCode();
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
