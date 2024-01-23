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
    /// EmpresaConfigNfse
    /// </summary>
    [DataContract(Name = "EmpresaConfigNfse")]
    public partial class EmpresaConfigNfse : IEquatable<EmpresaConfigNfse>, IValidatableObject
    {
        /// <summary>
        /// Indica se a empresa irá emitir em produção ou homologação.
        /// </summary>
        /// <value>Indica se a empresa irá emitir em produção ou homologação.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmbienteEnum
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
        /// Indica se a empresa irá emitir em produção ou homologação.
        /// </summary>
        /// <value>Indica se a empresa irá emitir em produção ou homologação.</value>
        [DataMember(Name = "ambiente", IsRequired = true, EmitDefaultValue = true)]
        public AmbienteEnum ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigNfse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmpresaConfigNfse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigNfse" /> class.
        /// </summary>
        /// <param name="regTrib">regTrib.</param>
        /// <param name="rps">rps (required).</param>
        /// <param name="prefeitura">prefeitura.</param>
        /// <param name="incentivoFiscal">Indicador se a empresa possui algum tipo de incentivo fiscal. (default to false).</param>
        /// <param name="ambiente">Indica se a empresa irá emitir em produção ou homologação. (required).</param>
        public EmpresaConfigNfse(EmpresaConfigNfseRegTrib regTrib = default(EmpresaConfigNfseRegTrib), EmpresaConfigRps rps = default(EmpresaConfigRps), EmpresaConfigPrefeitura prefeitura = default(EmpresaConfigPrefeitura), bool incentivoFiscal = false, AmbienteEnum ambiente = default(AmbienteEnum))
        {
            // to ensure "rps" is required (not null)
            if (rps == null)
            {
                throw new ArgumentNullException("rps is a required property for EmpresaConfigNfse and cannot be null");
            }
            this.rps = rps;
            this.ambiente = ambiente;
            this.regTrib = regTrib;
            this.prefeitura = prefeitura;
            this.incentivo_fiscal = incentivoFiscal;
        }

        /// <summary>
        /// Gets or Sets regTrib
        /// </summary>
        [DataMember(Name = "regTrib", EmitDefaultValue = false)]
        public EmpresaConfigNfseRegTrib regTrib { get; set; }

        /// <summary>
        /// Gets or Sets rps
        /// </summary>
        [DataMember(Name = "rps", IsRequired = true, EmitDefaultValue = true)]
        public EmpresaConfigRps rps { get; set; }

        /// <summary>
        /// Gets or Sets prefeitura
        /// </summary>
        [DataMember(Name = "prefeitura", EmitDefaultValue = false)]
        public EmpresaConfigPrefeitura prefeitura { get; set; }

        /// <summary>
        /// Indicador se a empresa possui algum tipo de incentivo fiscal.
        /// </summary>
        /// <value>Indicador se a empresa possui algum tipo de incentivo fiscal.</value>
        [DataMember(Name = "incentivo_fiscal", EmitDefaultValue = true)]
        public bool incentivo_fiscal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigNfse {\n");
            sb.Append("  regTrib: ").Append(regTrib).Append("\n");
            sb.Append("  rps: ").Append(rps).Append("\n");
            sb.Append("  prefeitura: ").Append(prefeitura).Append("\n");
            sb.Append("  incentivo_fiscal: ").Append(incentivo_fiscal).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
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
            return this.Equals(input as EmpresaConfigNfse);
        }

        /// <summary>
        /// Returns true if EmpresaConfigNfse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigNfse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigNfse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.regTrib == input.regTrib ||
                    (this.regTrib != null &&
                    this.regTrib.Equals(input.regTrib))
                ) && 
                (
                    this.rps == input.rps ||
                    (this.rps != null &&
                    this.rps.Equals(input.rps))
                ) && 
                (
                    this.prefeitura == input.prefeitura ||
                    (this.prefeitura != null &&
                    this.prefeitura.Equals(input.prefeitura))
                ) && 
                (
                    this.incentivo_fiscal == input.incentivo_fiscal ||
                    this.incentivo_fiscal.Equals(input.incentivo_fiscal)
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
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
                if (this.regTrib != null)
                {
                    hashCode = (hashCode * 59) + this.regTrib.GetHashCode();
                }
                if (this.rps != null)
                {
                    hashCode = (hashCode * 59) + this.rps.GetHashCode();
                }
                if (this.prefeitura != null)
                {
                    hashCode = (hashCode * 59) + this.prefeitura.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.incentivo_fiscal.GetHashCode();
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
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
            yield break;
        }
    }

}
