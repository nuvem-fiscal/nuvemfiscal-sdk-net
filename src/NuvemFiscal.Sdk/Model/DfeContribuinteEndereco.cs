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
    /// Dados do endereço.
    /// </summary>
    [DataContract(Name = "DfeContribuinteEndereco")]
    public partial class DfeContribuinteEndereco : IEquatable<DfeContribuinteEndereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeContribuinteEndereco" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DfeContribuinteEndereco() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeContribuinteEndereco" /> class.
        /// </summary>
        /// <param name="logradouro">Logradouro. (required).</param>
        /// <param name="numero">Número. (required).</param>
        /// <param name="complemento">Complemento..</param>
        /// <param name="bairro">Bairro. (required).</param>
        /// <param name="codigoMunicipio">Código do município (utilizar a tabela do IBGE), informar 9999999 para operações com o exterior. (required).</param>
        /// <param name="nomeMunicipio">Nome do município, informar EXTERIOR para operações com o exterior. (required).</param>
        /// <param name="uf">Sigla da UF, informar EX para operações com o exterior. (required).</param>
        /// <param name="cep">CEP..</param>
        /// <param name="codigoPais">Código de Pais..</param>
        /// <param name="pais">Nome do país..</param>
        /// <param name="fone">Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone..</param>
        public DfeContribuinteEndereco(string logradouro = default(string), string numero = default(string), string complemento = default(string), string bairro = default(string), string codigoMunicipio = default(string), string nomeMunicipio = default(string), string uf = default(string), string cep = default(string), string codigoPais = default(string), string pais = default(string), string fone = default(string))
        {
            // to ensure "logradouro" is required (not null)
            if (logradouro == null)
            {
                throw new ArgumentNullException("logradouro is a required property for DfeContribuinteEndereco and cannot be null");
            }
            this.logradouro = logradouro;
            // to ensure "numero" is required (not null)
            if (numero == null)
            {
                throw new ArgumentNullException("numero is a required property for DfeContribuinteEndereco and cannot be null");
            }
            this.numero = numero;
            // to ensure "bairro" is required (not null)
            if (bairro == null)
            {
                throw new ArgumentNullException("bairro is a required property for DfeContribuinteEndereco and cannot be null");
            }
            this.bairro = bairro;
            // to ensure "codigoMunicipio" is required (not null)
            if (codigoMunicipio == null)
            {
                throw new ArgumentNullException("codigoMunicipio is a required property for DfeContribuinteEndereco and cannot be null");
            }
            this.codigo_municipio = codigoMunicipio;
            // to ensure "nomeMunicipio" is required (not null)
            if (nomeMunicipio == null)
            {
                throw new ArgumentNullException("nomeMunicipio is a required property for DfeContribuinteEndereco and cannot be null");
            }
            this.nome_municipio = nomeMunicipio;
            // to ensure "uf" is required (not null)
            if (uf == null)
            {
                throw new ArgumentNullException("uf is a required property for DfeContribuinteEndereco and cannot be null");
            }
            this.uf = uf;
            this.complemento = complemento;
            this.cep = cep;
            this.codigo_pais = codigoPais;
            this.pais = pais;
            this.fone = fone;
        }

        /// <summary>
        /// Logradouro.
        /// </summary>
        /// <value>Logradouro.</value>
        [DataMember(Name = "logradouro", IsRequired = true, EmitDefaultValue = true)]
        public string logradouro { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "numero", IsRequired = true, EmitDefaultValue = true)]
        public string numero { get; set; }

        /// <summary>
        /// Complemento.
        /// </summary>
        /// <value>Complemento.</value>
        [DataMember(Name = "complemento", EmitDefaultValue = true)]
        public string complemento { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        /// <value>Bairro.</value>
        [DataMember(Name = "bairro", IsRequired = true, EmitDefaultValue = true)]
        public string bairro { get; set; }

        /// <summary>
        /// Código do município (utilizar a tabela do IBGE), informar 9999999 para operações com o exterior.
        /// </summary>
        /// <value>Código do município (utilizar a tabela do IBGE), informar 9999999 para operações com o exterior.</value>
        [DataMember(Name = "codigo_municipio", IsRequired = true, EmitDefaultValue = true)]
        public string codigo_municipio { get; set; }

        /// <summary>
        /// Nome do município, informar EXTERIOR para operações com o exterior.
        /// </summary>
        /// <value>Nome do município, informar EXTERIOR para operações com o exterior.</value>
        [DataMember(Name = "nome_municipio", IsRequired = true, EmitDefaultValue = true)]
        public string nome_municipio { get; set; }

        /// <summary>
        /// Sigla da UF, informar EX para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF, informar EX para operações com o exterior.</value>
        [DataMember(Name = "uf", IsRequired = true, EmitDefaultValue = true)]
        public string uf { get; set; }

        /// <summary>
        /// CEP.
        /// </summary>
        /// <value>CEP.</value>
        [DataMember(Name = "cep", EmitDefaultValue = true)]
        public string cep { get; set; }

        /// <summary>
        /// Código de Pais.
        /// </summary>
        /// <value>Código de Pais.</value>
        [DataMember(Name = "codigo_pais", EmitDefaultValue = true)]
        public string codigo_pais { get; set; }

        /// <summary>
        /// Nome do país.
        /// </summary>
        /// <value>Nome do país.</value>
        [DataMember(Name = "pais", EmitDefaultValue = true)]
        public string pais { get; set; }

        /// <summary>
        /// Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone.
        /// </summary>
        /// <value>Telefone, preencher com Código DDD + número do telefone , nas operações com exterior é permtido informar o código do país + código da localidade + número do telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeContribuinteEndereco {\n");
            sb.Append("  logradouro: ").Append(logradouro).Append("\n");
            sb.Append("  numero: ").Append(numero).Append("\n");
            sb.Append("  complemento: ").Append(complemento).Append("\n");
            sb.Append("  bairro: ").Append(bairro).Append("\n");
            sb.Append("  codigo_municipio: ").Append(codigo_municipio).Append("\n");
            sb.Append("  nome_municipio: ").Append(nome_municipio).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  cep: ").Append(cep).Append("\n");
            sb.Append("  codigo_pais: ").Append(codigo_pais).Append("\n");
            sb.Append("  pais: ").Append(pais).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
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
            return this.Equals(input as DfeContribuinteEndereco);
        }

        /// <summary>
        /// Returns true if DfeContribuinteEndereco instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeContribuinteEndereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeContribuinteEndereco input)
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
                    this.nome_municipio == input.nome_municipio ||
                    (this.nome_municipio != null &&
                    this.nome_municipio.Equals(input.nome_municipio))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.cep == input.cep ||
                    (this.cep != null &&
                    this.cep.Equals(input.cep))
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
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
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
                if (this.nome_municipio != null)
                {
                    hashCode = (hashCode * 59) + this.nome_municipio.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.cep != null)
                {
                    hashCode = (hashCode * 59) + this.cep.GetHashCode();
                }
                if (this.codigo_pais != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_pais.GetHashCode();
                }
                if (this.pais != null)
                {
                    hashCode = (hashCode * 59) + this.pais.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // logradouro (string) maxLength
            if (this.logradouro != null && this.logradouro.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for logradouro, length must be less than 60.", new [] { "logradouro" });
            }

            // logradouro (string) minLength
            if (this.logradouro != null && this.logradouro.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for logradouro, length must be greater than 2.", new [] { "logradouro" });
            }

            // numero (string) maxLength
            if (this.numero != null && this.numero.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for numero, length must be less than 60.", new [] { "numero" });
            }

            // numero (string) minLength
            if (this.numero != null && this.numero.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for numero, length must be greater than 1.", new [] { "numero" });
            }

            // complemento (string) maxLength
            if (this.complemento != null && this.complemento.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for complemento, length must be less than 60.", new [] { "complemento" });
            }

            // complemento (string) minLength
            if (this.complemento != null && this.complemento.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for complemento, length must be greater than 1.", new [] { "complemento" });
            }

            // bairro (string) maxLength
            if (this.bairro != null && this.bairro.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for bairro, length must be less than 60.", new [] { "bairro" });
            }

            // bairro (string) minLength
            if (this.bairro != null && this.bairro.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for bairro, length must be greater than 2.", new [] { "bairro" });
            }

            // nome_municipio (string) maxLength
            if (this.nome_municipio != null && this.nome_municipio.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_municipio, length must be less than 60.", new [] { "nome_municipio" });
            }

            // nome_municipio (string) minLength
            if (this.nome_municipio != null && this.nome_municipio.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nome_municipio, length must be greater than 2.", new [] { "nome_municipio" });
            }

            // pais (string) maxLength
            if (this.pais != null && this.pais.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pais, length must be less than 60.", new [] { "pais" });
            }

            // pais (string) minLength
            if (this.pais != null && this.pais.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pais, length must be greater than 2.", new [] { "pais" });
            }

            yield break;
        }
    }

}
