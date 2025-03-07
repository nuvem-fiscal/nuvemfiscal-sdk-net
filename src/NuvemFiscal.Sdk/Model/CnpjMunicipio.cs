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
    /// Município de jurisdição onde se encontra o estabelecimento.
    /// </summary>
    [DataContract(Name = "CnpjMunicipio")]
    public partial class CnpjMunicipio : IEquatable<CnpjMunicipio>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjMunicipio" /> class.
        /// </summary>
        /// <param name="codigoTom">Código TOM do município..</param>
        /// <param name="codigoIbge">Código IBGE do município..</param>
        /// <param name="descricao">Nome do município..</param>
        public CnpjMunicipio(string codigoTom = default(string), string codigoIbge = default(string), string descricao = default(string))
        {
            this.codigo_tom = codigoTom;
            this.codigo_ibge = codigoIbge;
            this.descricao = descricao;
        }

        /// <summary>
        /// Código TOM do município.
        /// </summary>
        /// <value>Código TOM do município.</value>
        [DataMember(Name = "codigo_tom", EmitDefaultValue = false)]
        public string codigo_tom { get; set; }

        /// <summary>
        /// Código IBGE do município.
        /// </summary>
        /// <value>Código IBGE do município.</value>
        [DataMember(Name = "codigo_ibge", EmitDefaultValue = false)]
        public string codigo_ibge { get; set; }

        /// <summary>
        /// Nome do município.
        /// </summary>
        /// <value>Nome do município.</value>
        [DataMember(Name = "descricao", EmitDefaultValue = false)]
        public string descricao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjMunicipio {\n");
            sb.Append("  codigo_tom: ").Append(codigo_tom).Append("\n");
            sb.Append("  codigo_ibge: ").Append(codigo_ibge).Append("\n");
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
            return this.Equals(input as CnpjMunicipio);
        }

        /// <summary>
        /// Returns true if CnpjMunicipio instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjMunicipio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjMunicipio input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo_tom == input.codigo_tom ||
                    (this.codigo_tom != null &&
                    this.codigo_tom.Equals(input.codigo_tom))
                ) && 
                (
                    this.codigo_ibge == input.codigo_ibge ||
                    (this.codigo_ibge != null &&
                    this.codigo_ibge.Equals(input.codigo_ibge))
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
                if (this.codigo_tom != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_tom.GetHashCode();
                }
                if (this.codigo_ibge != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_ibge.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
