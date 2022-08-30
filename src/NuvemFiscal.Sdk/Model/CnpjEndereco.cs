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
    /// CnpjEndereco
    /// </summary>
    [DataContract(Name = "CnpjEndereco")]
    public partial class CnpjEndereco : IEquatable<CnpjEndereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjEndereco" /> class.
        /// </summary>
        /// <param name="tipoLogradouro">tipoLogradouro.</param>
        /// <param name="logradouro">logradouro.</param>
        /// <param name="numero">numero.</param>
        /// <param name="complemento">complemento.</param>
        /// <param name="bairro">bairro.</param>
        /// <param name="cep">cep.</param>
        /// <param name="uf">uf.</param>
        /// <param name="municipio">municipio.</param>
        public CnpjEndereco(string tipoLogradouro = default(string), string logradouro = default(string), string numero = default(string), string complemento = default(string), string bairro = default(string), string cep = default(string), string uf = default(string), CnpjMunicipio municipio = default(CnpjMunicipio))
        {
            this.tipo_logradouro = tipoLogradouro;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cep = cep;
            this.uf = uf;
            this.municipio = municipio;
        }

        /// <summary>
        /// Gets or Sets tipo_logradouro
        /// </summary>
        [DataMember(Name = "tipo_logradouro", EmitDefaultValue = false)]
        public string tipo_logradouro { get; set; }

        /// <summary>
        /// Gets or Sets logradouro
        /// </summary>
        [DataMember(Name = "logradouro", EmitDefaultValue = false)]
        public string logradouro { get; set; }

        /// <summary>
        /// Gets or Sets numero
        /// </summary>
        [DataMember(Name = "numero", EmitDefaultValue = false)]
        public string numero { get; set; }

        /// <summary>
        /// Gets or Sets complemento
        /// </summary>
        [DataMember(Name = "complemento", EmitDefaultValue = false)]
        public string complemento { get; set; }

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
        /// Gets or Sets uf
        /// </summary>
        [DataMember(Name = "uf", EmitDefaultValue = false)]
        public string uf { get; set; }

        /// <summary>
        /// Gets or Sets municipio
        /// </summary>
        [DataMember(Name = "municipio", EmitDefaultValue = false)]
        public CnpjMunicipio municipio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjEndereco {\n");
            sb.Append("  tipo_logradouro: ").Append(tipo_logradouro).Append("\n");
            sb.Append("  logradouro: ").Append(logradouro).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  complemento: ").Append(complemento).Append("\n");
            sb.Append("  bairro: ").Append(bairro).Append("\n");
            sb.Append("  cep: ").Append(cep).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  municipio: ").Append(municipio).Append("\n");
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
            return this.Equals(input as CnpjEndereco);
        }

        /// <summary>
        /// Returns true if CnpjEndereco instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjEndereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjEndereco input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tipo_logradouro == input.tipo_logradouro ||
                    (this.tipo_logradouro != null &&
                    this.tipo_logradouro.Equals(input.tipo_logradouro))
                ) && 
                (
                    this.logradouro == input.logradouro ||
                    (this.logradouro != null &&
                    this.logradouro.Equals(input.logradouro))
                ) && 
                (
                    this.numero == input.numero ||
                    (this.numero != null &&
                    this.numero.Equals(input.numero))
                ) && 
                (
                    this.complemento == input.complemento ||
                    (this.complemento != null &&
                    this.complemento.Equals(input.complemento))
                ) && 
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
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.municipio == input.municipio ||
                    (this.municipio != null &&
                    this.municipio.Equals(input.municipio))
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
                if (this.tipo_logradouro != null)
                {
                    hashCode = (hashCode * 59) + this.tipo_logradouro.GetHashCode();
                }
                if (this.logradouro != null)
                {
                    hashCode = (hashCode * 59) + this.logradouro.GetHashCode();
                }
                if (this.numero != null)
                {
                    hashCode = (hashCode * 59) + this.numero.GetHashCode();
                }
                if (this.complemento != null)
                {
                    hashCode = (hashCode * 59) + this.complemento.GetHashCode();
                }
                if (this.bairro != null)
                {
                    hashCode = (hashCode * 59) + this.bairro.GetHashCode();
                }
                if (this.cep != null)
                {
                    hashCode = (hashCode * 59) + this.cep.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.municipio != null)
                {
                    hashCode = (hashCode * 59) + this.municipio.GetHashCode();
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
