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
    /// Configuração de numeração de lote, série e RPS.
    /// </summary>
    [DataContract(Name = "EmpresaConfigRps")]
    public partial class EmpresaConfigRps : IEquatable<EmpresaConfigRps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigRps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmpresaConfigRps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigRps" /> class.
        /// </summary>
        /// <param name="lote">Número do Lote de RPS.  Informe o próximo número do lote RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de lote o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez. (required).</param>
        /// <param name="serie">Série do RPS.  A série dos RPS varia de acordo com cada prefeitura, podendo ser  número (1, 2 ou 3, por exemplo) ou letras (A, S, NFS, por exemplo).  Portanto, consulte-a com o município da empresa antes de iniciar a  emissão das notas. (required).</param>
        /// <param name="numero">Número do RPS.  Informe o próximo número de RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de RPS o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez. (required).</param>
        public EmpresaConfigRps(int lote = default(int), string serie = default(string), int numero = default(int))
        {
            this.lote = lote;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for EmpresaConfigRps and cannot be null");
            }
            this.serie = serie;
            this.numero = numero;
        }

        /// <summary>
        /// Número do Lote de RPS.  Informe o próximo número do lote RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de lote o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez.
        /// </summary>
        /// <value>Número do Lote de RPS.  Informe o próximo número do lote RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de lote o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez.</value>
        [DataMember(Name = "lote", IsRequired = true, EmitDefaultValue = true)]
        public int lote { get; set; }

        /// <summary>
        /// Série do RPS.  A série dos RPS varia de acordo com cada prefeitura, podendo ser  número (1, 2 ou 3, por exemplo) ou letras (A, S, NFS, por exemplo).  Portanto, consulte-a com o município da empresa antes de iniciar a  emissão das notas.
        /// </summary>
        /// <value>Série do RPS.  A série dos RPS varia de acordo com cada prefeitura, podendo ser  número (1, 2 ou 3, por exemplo) ou letras (A, S, NFS, por exemplo).  Portanto, consulte-a com o município da empresa antes de iniciar a  emissão das notas.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Número do RPS.  Informe o próximo número de RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de RPS o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez.
        /// </summary>
        /// <value>Número do RPS.  Informe o próximo número de RPS a ser utilizado. Após isso, a Nuvem  Fiscal gerenciará esse campo (a cada novo envio de RPS o número é  incrementado em + 1). Portanto, basta informá-lo no cadastro da empresa  uma única vez.</value>
        [DataMember(Name = "numero", IsRequired = true, EmitDefaultValue = true)]
        public int numero { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigRps {\n");
            sb.Append("  lote: ").Append(lote).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
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
            return this.Equals(input as EmpresaConfigRps);
        }

        /// <summary>
        /// Returns true if EmpresaConfigRps instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigRps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigRps input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.lote == input.lote ||
                    this.lote.Equals(input.lote)
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.numero == input.numero ||
                    this.numero.Equals(input.numero)
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
                hashCode = (hashCode * 59) + this.lote.GetHashCode();
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.numero.GetHashCode();
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
