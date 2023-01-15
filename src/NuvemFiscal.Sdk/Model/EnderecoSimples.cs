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
    /// Grupo de informações do endereço da obra do serviço prestado.
    /// </summary>
    [DataContract(Name = "EnderecoSimples")]
    public partial class EnderecoSimples : IEquatable<EnderecoSimples>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoSimples" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnderecoSimples() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoSimples" /> class.
        /// </summary>
        /// <param name="cEP">Número do CEP..</param>
        /// <param name="endExt">endExt.</param>
        /// <param name="xLgr">Tipo e nome do logradouro da localização do imóvel. (required).</param>
        /// <param name="nro">Número do imóvel. (required).</param>
        /// <param name="xCpl">Complemento do endereço..</param>
        /// <param name="xBairro">Bairro. (required).</param>
        public EnderecoSimples(string cEP = default(string), EnderExtSimples endExt = default(EnderExtSimples), string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string))
        {
            // to ensure "xLgr" is required (not null)
            if (xLgr == null)
            {
                throw new ArgumentNullException("xLgr is a required property for EnderecoSimples and cannot be null");
            }
            this.xLgr = xLgr;
            // to ensure "nro" is required (not null)
            if (nro == null)
            {
                throw new ArgumentNullException("nro is a required property for EnderecoSimples and cannot be null");
            }
            this.nro = nro;
            // to ensure "xBairro" is required (not null)
            if (xBairro == null)
            {
                throw new ArgumentNullException("xBairro is a required property for EnderecoSimples and cannot be null");
            }
            this.xBairro = xBairro;
            this.CEP = cEP;
            this.endExt = endExt;
            this.xCpl = xCpl;
        }

        /// <summary>
        /// Número do CEP.
        /// </summary>
        /// <value>Número do CEP.</value>
        [DataMember(Name = "CEP", EmitDefaultValue = false)]
        public string CEP { get; set; }

        /// <summary>
        /// Gets or Sets endExt
        /// </summary>
        [DataMember(Name = "endExt", EmitDefaultValue = false)]
        public EnderExtSimples endExt { get; set; }

        /// <summary>
        /// Tipo e nome do logradouro da localização do imóvel.
        /// </summary>
        /// <value>Tipo e nome do logradouro da localização do imóvel.</value>
        [DataMember(Name = "xLgr", IsRequired = true, EmitDefaultValue = true)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número do imóvel.
        /// </summary>
        /// <value>Número do imóvel.</value>
        [DataMember(Name = "nro", IsRequired = true, EmitDefaultValue = true)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento do endereço.
        /// </summary>
        /// <value>Complemento do endereço.</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = false)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        /// <value>Bairro.</value>
        [DataMember(Name = "xBairro", IsRequired = true, EmitDefaultValue = true)]
        public string xBairro { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnderecoSimples {\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
            sb.Append("  endExt: ").Append(endExt).Append("\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
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
            return this.Equals(input as EnderecoSimples);
        }

        /// <summary>
        /// Returns true if EnderecoSimples instances are equal
        /// </summary>
        /// <param name="input">Instance of EnderecoSimples to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoSimples input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CEP == input.CEP ||
                    (this.CEP != null &&
                    this.CEP.Equals(input.CEP))
                ) && 
                (
                    this.endExt == input.endExt ||
                    (this.endExt != null &&
                    this.endExt.Equals(input.endExt))
                ) && 
                (
                    this.xLgr == input.xLgr ||
                    (this.xLgr != null &&
                    this.xLgr.Equals(input.xLgr))
                ) && 
                (
                    this.nro == input.nro ||
                    (this.nro != null &&
                    this.nro.Equals(input.nro))
                ) && 
                (
                    this.xCpl == input.xCpl ||
                    (this.xCpl != null &&
                    this.xCpl.Equals(input.xCpl))
                ) && 
                (
                    this.xBairro == input.xBairro ||
                    (this.xBairro != null &&
                    this.xBairro.Equals(input.xBairro))
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
                if (this.CEP != null)
                {
                    hashCode = (hashCode * 59) + this.CEP.GetHashCode();
                }
                if (this.endExt != null)
                {
                    hashCode = (hashCode * 59) + this.endExt.GetHashCode();
                }
                if (this.xLgr != null)
                {
                    hashCode = (hashCode * 59) + this.xLgr.GetHashCode();
                }
                if (this.nro != null)
                {
                    hashCode = (hashCode * 59) + this.nro.GetHashCode();
                }
                if (this.xCpl != null)
                {
                    hashCode = (hashCode * 59) + this.xCpl.GetHashCode();
                }
                if (this.xBairro != null)
                {
                    hashCode = (hashCode * 59) + this.xBairro.GetHashCode();
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
