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
    /// MdfePedidoEncerramento
    /// </summary>
    [DataContract(Name = "MdfePedidoEncerramento")]
    public partial class MdfePedidoEncerramento : IEquatable<MdfePedidoEncerramento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfePedidoEncerramento" /> class.
        /// </summary>
        /// <param name="dataEncerramento">Data que o manifesto foi encerrado.  Opcional. Caso não seja informada, será utilizada a data em que a solicitação foi feita à API..</param>
        /// <param name="uf">UF de encerramento do manifesto..</param>
        /// <param name="codigoMunicipio">Código IBGE do Município de encerramento do manifesto..</param>
        public MdfePedidoEncerramento(DateTime dataEncerramento = default(DateTime), string uf = default(string), int codigoMunicipio = default(int))
        {
            this.data_encerramento = dataEncerramento;
            this.uf = uf;
            this.codigo_municipio = codigoMunicipio;
        }

        /// <summary>
        /// Data que o manifesto foi encerrado.  Opcional. Caso não seja informada, será utilizada a data em que a solicitação foi feita à API.
        /// </summary>
        /// <value>Data que o manifesto foi encerrado.  Opcional. Caso não seja informada, será utilizada a data em que a solicitação foi feita à API.</value>
        [DataMember(Name = "data_encerramento", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime data_encerramento { get; set; }

        /// <summary>
        /// UF de encerramento do manifesto.
        /// </summary>
        /// <value>UF de encerramento do manifesto.</value>
        [DataMember(Name = "uf", EmitDefaultValue = false)]
        public string uf { get; set; }

        /// <summary>
        /// Código IBGE do Município de encerramento do manifesto.
        /// </summary>
        /// <value>Código IBGE do Município de encerramento do manifesto.</value>
        [DataMember(Name = "codigo_municipio", EmitDefaultValue = false)]
        public int codigo_municipio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfePedidoEncerramento {\n");
            sb.Append("  data_encerramento: ").Append(data_encerramento).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  codigo_municipio: ").Append(codigo_municipio).Append("\n");
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
            return this.Equals(input as MdfePedidoEncerramento);
        }

        /// <summary>
        /// Returns true if MdfePedidoEncerramento instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfePedidoEncerramento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfePedidoEncerramento input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.data_encerramento == input.data_encerramento ||
                    (this.data_encerramento != null &&
                    this.data_encerramento.Equals(input.data_encerramento))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.codigo_municipio == input.codigo_municipio ||
                    this.codigo_municipio.Equals(input.codigo_municipio)
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
                if (this.data_encerramento != null)
                {
                    hashCode = (hashCode * 59) + this.data_encerramento.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.codigo_municipio.GetHashCode();
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
