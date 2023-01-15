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
    /// Dados de endereço.
    /// </summary>
    [DataContract(Name = "Endereco")]
    public partial class Endereco : IEquatable<Endereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endereco" /> class.
        /// </summary>
        /// <param name="endNac">endNac.</param>
        /// <param name="endExt">endExt.</param>
        /// <param name="xLgr">Tipo e nome do logradouro da localização do imóvel.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="nro">Número do imóvel.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="xCpl">Complemento do endereço.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="xBairro">Bairro.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        public Endereco(EnderNac endNac = default(EnderNac), EnderExt endExt = default(EnderExt), string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string))
        {
            this.endNac = endNac;
            this.endExt = endExt;
            this.xLgr = xLgr;
            this.nro = nro;
            this.xCpl = xCpl;
            this.xBairro = xBairro;
        }

        /// <summary>
        /// Gets or Sets endNac
        /// </summary>
        [DataMember(Name = "endNac", EmitDefaultValue = false)]
        public EnderNac endNac { get; set; }

        /// <summary>
        /// Gets or Sets endExt
        /// </summary>
        [DataMember(Name = "endExt", EmitDefaultValue = false)]
        public EnderExt endExt { get; set; }

        /// <summary>
        /// Tipo e nome do logradouro da localização do imóvel.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Tipo e nome do logradouro da localização do imóvel.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xLgr", EmitDefaultValue = false)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número do imóvel.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Número do imóvel.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "nro", EmitDefaultValue = false)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento do endereço.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Complemento do endereço.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = false)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Bairro.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xBairro", EmitDefaultValue = false)]
        public string xBairro { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Endereco {\n");
            sb.Append("  endNac: ").Append(endNac).Append("\n");
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
            return this.Equals(input as Endereco);
        }

        /// <summary>
        /// Returns true if Endereco instances are equal
        /// </summary>
        /// <param name="input">Instance of Endereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endereco input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.endNac == input.endNac ||
                    (this.endNac != null &&
                    this.endNac.Equals(input.endNac))
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
                if (this.endNac != null)
                {
                    hashCode = (hashCode * 59) + this.endNac.GetHashCode();
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
