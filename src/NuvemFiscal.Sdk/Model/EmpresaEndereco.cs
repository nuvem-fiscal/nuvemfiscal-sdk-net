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
    /// EmpresaEndereco
    /// </summary>
    [DataContract(Name = "EmpresaEndereco")]
    public partial class EmpresaEndereco : IEquatable<EmpresaEndereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaEndereco" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmpresaEndereco() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaEndereco" /> class.
        /// </summary>
        /// <param name="logradouro">Logradouro. (required).</param>
        /// <param name="numero">Número. (required).</param>
        /// <param name="complemento">Complemento..</param>
        /// <param name="bairro">Bairro. (required).</param>
        /// <param name="codigoMunicipio">Código IBGE do município. (required).</param>
        /// <param name="cidade">Cidade..</param>
        /// <param name="uf">Sigla do estado. (required).</param>
        /// <param name="codigoPais">Código do país.  Valor padrão: &#x60;1058&#x60;.</param>
        /// <param name="pais">Nome do país.  Valor padrão: &#x60;Brasil&#x60;.</param>
        /// <param name="cep">CEP.  Utilize o valor sem máscara. (required).</param>
        public EmpresaEndereco(string logradouro = default(string), string numero = default(string), string complemento = default(string), string bairro = default(string), string codigoMunicipio = default(string), string cidade = default(string), string uf = default(string), string codigoPais = default(string), string pais = default(string), string cep = default(string))
        {
            // to ensure "logradouro" is required (not null)
            if (logradouro == null)
            {
                throw new ArgumentNullException("logradouro is a required property for EmpresaEndereco and cannot be null");
            }
            this.logradouro = logradouro;
            // to ensure "numero" is required (not null)
            if (numero == null)
            {
                throw new ArgumentNullException("numero is a required property for EmpresaEndereco and cannot be null");
            }
            this.numero = numero;
            // to ensure "bairro" is required (not null)
            if (bairro == null)
            {
                throw new ArgumentNullException("bairro is a required property for EmpresaEndereco and cannot be null");
            }
            this.bairro = bairro;
            // to ensure "codigoMunicipio" is required (not null)
            if (codigoMunicipio == null)
            {
                throw new ArgumentNullException("codigoMunicipio is a required property for EmpresaEndereco and cannot be null");
            }
            this.codigo_municipio = codigoMunicipio;
            // to ensure "uf" is required (not null)
            if (uf == null)
            {
                throw new ArgumentNullException("uf is a required property for EmpresaEndereco and cannot be null");
            }
            this.uf = uf;
            // to ensure "cep" is required (not null)
            if (cep == null)
            {
                throw new ArgumentNullException("cep is a required property for EmpresaEndereco and cannot be null");
            }
            this.cep = cep;
            this.complemento = complemento;
            this.cidade = cidade;
            this.codigo_pais = codigoPais;
            this.pais = pais;
        }

        /// <summary>
        /// Logradouro.
        /// </summary>
        /// <value>Logradouro.</value>
        [DataMember(Name = "logradouro", IsRequired = true, EmitDefaultValue = false)]
        public string logradouro { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "numero", IsRequired = true, EmitDefaultValue = false)]
        public string numero { get; set; }

        /// <summary>
        /// Complemento.
        /// </summary>
        /// <value>Complemento.</value>
        [DataMember(Name = "complemento", EmitDefaultValue = false)]
        public string complemento { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        /// <value>Bairro.</value>
        [DataMember(Name = "bairro", IsRequired = true, EmitDefaultValue = false)]
        public string bairro { get; set; }

        /// <summary>
        /// Código IBGE do município.
        /// </summary>
        /// <value>Código IBGE do município.</value>
        [DataMember(Name = "codigo_municipio", IsRequired = true, EmitDefaultValue = false)]
        public string codigo_municipio { get; set; }

        /// <summary>
        /// Cidade.
        /// </summary>
        /// <value>Cidade.</value>
        [DataMember(Name = "cidade", EmitDefaultValue = false)]
        public string cidade { get; set; }

        /// <summary>
        /// Sigla do estado.
        /// </summary>
        /// <value>Sigla do estado.</value>
        [DataMember(Name = "uf", IsRequired = true, EmitDefaultValue = false)]
        public string uf { get; set; }

        /// <summary>
        /// Código do país.  Valor padrão: &#x60;1058&#x60;
        /// </summary>
        /// <value>Código do país.  Valor padrão: &#x60;1058&#x60;</value>
        [DataMember(Name = "codigo_pais", EmitDefaultValue = false)]
        public string codigo_pais { get; set; }

        /// <summary>
        /// Nome do país.  Valor padrão: &#x60;Brasil&#x60;
        /// </summary>
        /// <value>Nome do país.  Valor padrão: &#x60;Brasil&#x60;</value>
        [DataMember(Name = "pais", EmitDefaultValue = false)]
        public string pais { get; set; }

        /// <summary>
        /// CEP.  Utilize o valor sem máscara.
        /// </summary>
        /// <value>CEP.  Utilize o valor sem máscara.</value>
        [DataMember(Name = "cep", IsRequired = true, EmitDefaultValue = false)]
        public string cep { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaEndereco {\n");
            sb.Append("  logradouro: ").Append(logradouro).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  complemento: ").Append(complemento).Append("\n");
            sb.Append("  bairro: ").Append(bairro).Append("\n");
            sb.Append("  codigo_municipio: ").Append(codigo_municipio).Append("\n");
            sb.Append("  cidade: ").Append(cidade).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  codigo_pais: ").Append(codigo_pais).Append("\n");
            sb.Append("  pais: ").Append(pais).Append("\n");
            sb.Append("  cep: ").Append(cep).Append("\n");
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
            return this.Equals(input as EmpresaEndereco);
        }

        /// <summary>
        /// Returns true if EmpresaEndereco instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaEndereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaEndereco input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.codigo_municipio == input.codigo_municipio ||
                    (this.codigo_municipio != null &&
                    this.codigo_municipio.Equals(input.codigo_municipio))
                ) && 
                (
                    this.cidade == input.cidade ||
                    (this.cidade != null &&
                    this.cidade.Equals(input.cidade))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.codigo_pais == input.codigo_pais ||
                    (this.codigo_pais != null &&
                    this.codigo_pais.Equals(input.codigo_pais))
                ) && 
                (
                    this.pais == input.pais ||
                    (this.pais != null &&
                    this.pais.Equals(input.pais))
                ) && 
                (
                    this.cep == input.cep ||
                    (this.cep != null &&
                    this.cep.Equals(input.cep))
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
                if (this.codigo_municipio != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_municipio.GetHashCode();
                }
                if (this.cidade != null)
                {
                    hashCode = (hashCode * 59) + this.cidade.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.codigo_pais != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_pais.GetHashCode();
                }
                if (this.pais != null)
                {
                    hashCode = (hashCode * 59) + this.pais.GetHashCode();
                }
                if (this.cep != null)
                {
                    hashCode = (hashCode * 59) + this.cep.GetHashCode();
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
