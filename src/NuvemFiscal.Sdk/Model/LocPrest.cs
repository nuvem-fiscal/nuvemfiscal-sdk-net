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
    /// Grupo de informações relativas ao local da prestação do serviço.
    /// </summary>
    [DataContract(Name = "LocPrest")]
    public partial class LocPrest : IEquatable<LocPrest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocPrest" /> class.
        /// </summary>
        /// <param name="cLocPrestacao">Código do município onde o serviço foi prestado (tabela do IBGE).    Caso não seja informado, será considerado o município do Prestador do serviço..</param>
        /// <param name="cPaisPrestacao">Código do país onde o serviço foi prestado (Tabela de Países ISO)..</param>
        public LocPrest(string cLocPrestacao = default(string), string cPaisPrestacao = default(string))
        {
            this.cLocPrestacao = cLocPrestacao;
            this.cPaisPrestacao = cPaisPrestacao;
        }

        /// <summary>
        /// Código do município onde o serviço foi prestado (tabela do IBGE).    Caso não seja informado, será considerado o município do Prestador do serviço.
        /// </summary>
        /// <value>Código do município onde o serviço foi prestado (tabela do IBGE).    Caso não seja informado, será considerado o município do Prestador do serviço.</value>
        [DataMember(Name = "cLocPrestacao", EmitDefaultValue = true)]
        public string cLocPrestacao { get; set; }

        /// <summary>
        /// Código do país onde o serviço foi prestado (Tabela de Países ISO).
        /// </summary>
        /// <value>Código do país onde o serviço foi prestado (Tabela de Países ISO).</value>
        [DataMember(Name = "cPaisPrestacao", EmitDefaultValue = true)]
        public string cPaisPrestacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocPrest {\n");
            sb.Append("  cLocPrestacao: ").Append(cLocPrestacao).Append("\n");
            sb.Append("  cPaisPrestacao: ").Append(cPaisPrestacao).Append("\n");
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
            return this.Equals(input as LocPrest);
        }

        /// <summary>
        /// Returns true if LocPrest instances are equal
        /// </summary>
        /// <param name="input">Instance of LocPrest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocPrest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cLocPrestacao == input.cLocPrestacao ||
                    (this.cLocPrestacao != null &&
                    this.cLocPrestacao.Equals(input.cLocPrestacao))
                ) && 
                (
                    this.cPaisPrestacao == input.cPaisPrestacao ||
                    (this.cPaisPrestacao != null &&
                    this.cPaisPrestacao.Equals(input.cPaisPrestacao))
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
                if (this.cLocPrestacao != null)
                {
                    hashCode = (hashCode * 59) + this.cLocPrestacao.GetHashCode();
                }
                if (this.cPaisPrestacao != null)
                {
                    hashCode = (hashCode * 59) + this.cPaisPrestacao.GetHashCode();
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
