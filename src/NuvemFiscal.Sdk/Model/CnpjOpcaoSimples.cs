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
    /// CnpjOpcaoSimples
    /// </summary>
    [DataContract(Name = "CnpjOpcaoSimples")]
    public partial class CnpjOpcaoSimples : IEquatable<CnpjOpcaoSimples>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjOpcaoSimples" /> class.
        /// </summary>
        /// <param name="optante">optante.</param>
        /// <param name="dataOpcao">dataOpcao.</param>
        /// <param name="dataExclusao">dataExclusao.</param>
        public CnpjOpcaoSimples(bool optante = default(bool), DateTime dataOpcao = default(DateTime), DateTime dataExclusao = default(DateTime))
        {
            this.optante = optante;
            this.data_opcao = dataOpcao;
            this.data_exclusao = dataExclusao;
        }

        /// <summary>
        /// Gets or Sets optante
        /// </summary>
        [DataMember(Name = "optante", EmitDefaultValue = true)]
        public bool optante { get; set; }

        /// <summary>
        /// Gets or Sets data_opcao
        /// </summary>
        [DataMember(Name = "data_opcao", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data_opcao { get; set; }

        /// <summary>
        /// Gets or Sets data_exclusao
        /// </summary>
        [DataMember(Name = "data_exclusao", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data_exclusao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjOpcaoSimples {\n");
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
            return this.Equals(input as CnpjOpcaoSimples);
        }

        /// <summary>
        /// Returns true if CnpjOpcaoSimples instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjOpcaoSimples to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjOpcaoSimples input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
