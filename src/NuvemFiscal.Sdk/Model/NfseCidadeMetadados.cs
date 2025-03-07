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
    /// NfseCidadeMetadados
    /// </summary>
    [DataContract(Name = "NfseCidadeMetadados")]
    public partial class NfseCidadeMetadados : IEquatable<NfseCidadeMetadados>, IValidatableObject
    {
        /// <summary>
        /// Defines ambientes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmbientesEnum
        {
            /// <summary>
            /// Enum Homologacao for value: homologacao
            /// </summary>
            [EnumMember(Value = "homologacao")]
            Homologacao = 1,

            /// <summary>
            /// Enum Producao for value: producao
            /// </summary>
            [EnumMember(Value = "producao")]
            Producao = 2
        }

        /// <summary>
        /// Defines credenciais
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CredenciaisEnum
        {
            /// <summary>
            /// Enum Certificado for value: certificado
            /// </summary>
            [EnumMember(Value = "certificado")]
            Certificado = 1,

            /// <summary>
            /// Enum LoginSenha for value: login_senha
            /// </summary>
            [EnumMember(Value = "login_senha")]
            LoginSenha = 2,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 3
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NfseCidadeMetadados" /> class.
        /// </summary>
        /// <param name="codigoIbge">Código IBGE do município..</param>
        /// <param name="uf">UF do município..</param>
        /// <param name="municipio">Nome do município..</param>
        /// <param name="provedor">Provedor do município..</param>
        /// <param name="ambientes">Ambientes disponíveis no provedor..</param>
        /// <param name="credenciais">Credenciais requeridas para autenticação no provedor..</param>
        public NfseCidadeMetadados(string codigoIbge = default(string), string uf = default(string), string municipio = default(string), string provedor = default(string), List<AmbientesEnum> ambientes = default(List<AmbientesEnum>), List<CredenciaisEnum> credenciais = default(List<CredenciaisEnum>))
        {
            this.codigo_ibge = codigoIbge;
            this.uf = uf;
            this.municipio = municipio;
            this.provedor = provedor;
            this.ambientes = ambientes;
            this.credenciais = credenciais;
        }

        /// <summary>
        /// Código IBGE do município.
        /// </summary>
        /// <value>Código IBGE do município.</value>
        [DataMember(Name = "codigo_ibge", EmitDefaultValue = false)]
        public string codigo_ibge { get; set; }

        /// <summary>
        /// UF do município.
        /// </summary>
        /// <value>UF do município.</value>
        [DataMember(Name = "uf", EmitDefaultValue = false)]
        public string uf { get; set; }

        /// <summary>
        /// Nome do município.
        /// </summary>
        /// <value>Nome do município.</value>
        [DataMember(Name = "municipio", EmitDefaultValue = false)]
        public string municipio { get; set; }

        /// <summary>
        /// Provedor do município.
        /// </summary>
        /// <value>Provedor do município.</value>
        [DataMember(Name = "provedor", EmitDefaultValue = false)]
        public string provedor { get; set; }

        /// <summary>
        /// Ambientes disponíveis no provedor.
        /// </summary>
        /// <value>Ambientes disponíveis no provedor.</value>
        [DataMember(Name = "ambientes", EmitDefaultValue = false)]
        public List<NfseCidadeMetadados.AmbientesEnum> ambientes { get; set; }

        /// <summary>
        /// Credenciais requeridas para autenticação no provedor.
        /// </summary>
        /// <value>Credenciais requeridas para autenticação no provedor.</value>
        [DataMember(Name = "credenciais", EmitDefaultValue = false)]
        public List<NfseCidadeMetadados.CredenciaisEnum> credenciais { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfseCidadeMetadados {\n");
            sb.Append("  codigo_ibge: ").Append(codigo_ibge).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  municipio: ").Append(municipio).Append("\n");
            sb.Append("  provedor: ").Append(provedor).Append("\n");
            sb.Append("  ambientes: ").Append(ambientes).Append("\n");
            sb.Append("  credenciais: ").Append(credenciais).Append("\n");
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
            return this.Equals(input as NfseCidadeMetadados);
        }

        /// <summary>
        /// Returns true if NfseCidadeMetadados instances are equal
        /// </summary>
        /// <param name="input">Instance of NfseCidadeMetadados to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfseCidadeMetadados input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo_ibge == input.codigo_ibge ||
                    (this.codigo_ibge != null &&
                    this.codigo_ibge.Equals(input.codigo_ibge))
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
                ) && 
                (
                    this.provedor == input.provedor ||
                    (this.provedor != null &&
                    this.provedor.Equals(input.provedor))
                ) && 
                (
                    this.ambientes == input.ambientes ||
                    this.ambientes != null &&
                    input.ambientes != null &&
                    this.ambientes.SequenceEqual(input.ambientes)
                ) && 
                (
                    this.credenciais == input.credenciais ||
                    this.credenciais != null &&
                    input.credenciais != null &&
                    this.credenciais.SequenceEqual(input.credenciais)
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
                if (this.codigo_ibge != null)
                {
                    hashCode = (hashCode * 59) + this.codigo_ibge.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.municipio != null)
                {
                    hashCode = (hashCode * 59) + this.municipio.GetHashCode();
                }
                if (this.provedor != null)
                {
                    hashCode = (hashCode * 59) + this.provedor.GetHashCode();
                }
                if (this.ambientes != null)
                {
                    hashCode = (hashCode * 59) + this.ambientes.GetHashCode();
                }
                if (this.credenciais != null)
                {
                    hashCode = (hashCode * 59) + this.credenciais.GetHashCode();
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
