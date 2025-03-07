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
    /// CepEndereco
    /// </summary>
    [DataContract(Name = "CepEndereco")]
    public partial class CepEndereco : IEquatable<CepEndereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CepEndereco" /> class.
        /// </summary>
        /// <param name="bairro">bairro.</param>
        /// <param name="cep">cep.</param>
        /// <param name="codigoIbge">codigoIbge.</param>
        /// <param name="complemento">complemento.</param>
        /// <param name="logradouro">logradouro.</param>
        /// <param name="municipio">municipio.</param>
        /// <param name="tipoLogradouro">tipoLogradouro.</param>
        /// <param name="uf">uf.</param>
        public CepEndereco(string bairro = default(string), string cep = default(string), string codigoIbge = default(string), string complemento = default(string), string logradouro = default(string), string municipio = default(string), string tipoLogradouro = default(string), string uf = default(string))
        {
            this.bairro = bairro;
            this.cep = cep;
            this.codigo_ibge = codigoIbge;
            this.complemento = complemento;
            this.logradouro = logradouro;
            this.municipio = municipio;
            this.tipo_logradouro = tipoLogradouro;
            this.uf = uf;
        }

        /// <summary>
        /// Gets or Sets bairro
        /// </summary>
        [DataMember(Name = "bairro", EmitDefaultValue = false)]
        public string bairro { get; set; }

        /// <summary>
        /// Gets or Sets cep
        /// </summary>
        [DataMember(Name = "cep", EmitDefaultValue = false)]
        public string cep { get; set; }

        /// <summary>
        /// Gets or Sets codigo_ibge
        /// </summary>
        [DataMember(Name = "codigo_ibge", EmitDefaultValue = false)]
        public string codigo_ibge { get; set; }

        /// <summary>
        /// Gets or Sets complemento
        /// </summary>
        [DataMember(Name = "complemento", EmitDefaultValue = false)]
        public string complemento { get; set; }

        /// <summary>
        /// Gets or Sets logradouro
        /// </summary>
        [DataMember(Name = "logradouro", EmitDefaultValue = false)]
        public string logradouro { get; set; }

        /// <summary>
        /// Gets or Sets municipio
        /// </summary>
        [DataMember(Name = "municipio", EmitDefaultValue = false)]
        public string municipio { get; set; }

        /// <summary>
        /// Gets or Sets tipo_logradouro
        /// </summary>
        [DataMember(Name = "tipo_logradouro", EmitDefaultValue = false)]
        public string tipo_logradouro { get; set; }

        /// <summary>
        /// Gets or Sets uf
        /// </summary>
        [DataMember(Name = "uf", EmitDefaultValue = false)]
        public string uf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CepEndereco {\n");
            sb.Append("  bairro: ").Append(bairro).Append("\n");
            sb.Append("  cep: ").Append(cep).Append("\n");
            sb.Append("  codigo_ibge: ").Append(codigo_ibge).Append("\n");
            sb.Append("  complemento: ").Append(complemento).Append("\n");
            sb.Append("  logradouro: ").Append(logradouro).Append("\n");
            sb.Append("  municipio: ").Append(municipio).Append("\n");
            sb.Append("  tipo_logradouro: ").Append(tipo_logradouro).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
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
            return this.Equals(input as CepEndereco);
        }

        /// <summary>
        /// Returns true if CepEndereco instances are equal
        /// </summary>
        /// <param name="input">Instance of CepEndereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CepEndereco input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.bairro == input.bairro ||
                    (this.bairro != null &&
                    this.bairro.Equals(input.bairro))
                ) && 
                (
                    this.cep == input.cep ||
                    (this.cep != null &&
                    this.cep.Equals(input.cep))
                ) && 
                (
                    this.codigo_ibge == input.codigo_ibge ||
                    (this.codigo_ibge != null &&
                    this.codigo_ibge.Equals(input.codigo_ibge))
                ) && 
                (
                    this.complemento == input.complemento ||
                    (this.complemento != null &&
                    this.complemento.Equals(input.complemento))
                ) && 
                (
                    this.logradouro == input.logradouro ||
                    (this.logradouro != null &&
                    this.logradouro.Equals(input.logradouro))
                ) && 
                (
                    this.municipio == input.municipio ||
                    (this.municipio != null &&
                    this.municipio.Equals(input.municipio))
                ) && 
                (
                    this.tipo_logradouro == input.tipo_logradouro ||
                    (this.tipo_logradouro != null &&
                    this.tipo_logradouro.Equals(input.tipo_logradouro))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
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
                if (this.bairro != null)
                {
                    hashCode = (hashCode * 59) + this.bairro.GetHashCode();
                }
                if (this.cep != null)
                {
                    hashCode = (hashCode * 59) + this.cep.GetHashCode();
                }
                if (this.codigo_ibge != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_ibge.GetHashCode();
                }
                if (this.complemento != null)
                {
                    hashCode = (hashCode * 59) + this.complemento.GetHashCode();
                }
                if (this.logradouro != null)
                {
                    hashCode = (hashCode * 59) + this.logradouro.GetHashCode();
                }
                if (this.municipio != null)
                {
                    hashCode = (hashCode * 59) + this.municipio.GetHashCode();
                }
                if (this.tipo_logradouro != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_logradouro.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
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
