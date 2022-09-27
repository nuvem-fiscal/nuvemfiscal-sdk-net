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
    /// CteSefazEndereco
    /// </summary>
    [DataContract(Name = "CteSefazEndereco")]
    public partial class CteSefazEndereco : IEquatable<CteSefazEndereco>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEndereco" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazEndereco() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEndereco" /> class.
        /// </summary>
        /// <param name="xLgr">Logradouro. (required).</param>
        /// <param name="nro">Número. (required).</param>
        /// <param name="xCpl">Complemento..</param>
        /// <param name="xBairro">Bairro. (required).</param>
        /// <param name="cMun">Código do município (utilizar a tabela do IBGE).  Informar 9999999 para operações com o exterior. (required).</param>
        /// <param name="xMun">Nome do município.  Informar EXTERIOR para operações com o exterior. (required).</param>
        /// <param name="cEP">CEP.  Informar os zeros não significativos..</param>
        /// <param name="uF">Sigla da UF.  Informar EX para operações com o exterior. (required).</param>
        /// <param name="cPais">Código do país.  Utilizar a tabela do BACEN..</param>
        /// <param name="xPais">Nome do país..</param>
        public CteSefazEndereco(string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string), int cMun = default(int), string xMun = default(string), int cEP = default(int), string uF = default(string), int cPais = default(int), string xPais = default(string))
        {
            // to ensure "xLgr" is required (not null)
            if (xLgr == null)
            {
                throw new ArgumentNullException("xLgr is a required property for CteSefazEndereco and cannot be null");
            }
            this.xLgr = xLgr;
            // to ensure "nro" is required (not null)
            if (nro == null)
            {
                throw new ArgumentNullException("nro is a required property for CteSefazEndereco and cannot be null");
            }
            this.nro = nro;
            // to ensure "xBairro" is required (not null)
            if (xBairro == null)
            {
                throw new ArgumentNullException("xBairro is a required property for CteSefazEndereco and cannot be null");
            }
            this.xBairro = xBairro;
            this.cMun = cMun;
            // to ensure "xMun" is required (not null)
            if (xMun == null)
            {
                throw new ArgumentNullException("xMun is a required property for CteSefazEndereco and cannot be null");
            }
            this.xMun = xMun;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for CteSefazEndereco and cannot be null");
            }
            this.UF = uF;
            this.xCpl = xCpl;
            this.CEP = cEP;
            this.cPais = cPais;
            this.xPais = xPais;
        }

        /// <summary>
        /// Logradouro.
        /// </summary>
        /// <value>Logradouro.</value>
        [DataMember(Name = "xLgr", IsRequired = true, EmitDefaultValue = true)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "nro", IsRequired = true, EmitDefaultValue = true)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento.
        /// </summary>
        /// <value>Complemento.</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = false)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        /// <value>Bairro.</value>
        [DataMember(Name = "xBairro", IsRequired = true, EmitDefaultValue = true)]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do município (utilizar a tabela do IBGE).  Informar 9999999 para operações com o exterior.
        /// </summary>
        /// <value>Código do município (utilizar a tabela do IBGE).  Informar 9999999 para operações com o exterior.</value>
        [DataMember(Name = "cMun", IsRequired = true, EmitDefaultValue = true)]
        public int cMun { get; set; }

        /// <summary>
        /// Nome do município.  Informar EXTERIOR para operações com o exterior.
        /// </summary>
        /// <value>Nome do município.  Informar EXTERIOR para operações com o exterior.</value>
        [DataMember(Name = "xMun", IsRequired = true, EmitDefaultValue = true)]
        public string xMun { get; set; }

        /// <summary>
        /// CEP.  Informar os zeros não significativos.
        /// </summary>
        /// <value>CEP.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CEP", EmitDefaultValue = false)]
        public int CEP { get; set; }

        /// <summary>
        /// Sigla da UF.  Informar EX para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF.  Informar EX para operações com o exterior.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Código do país.  Utilizar a tabela do BACEN.
        /// </summary>
        /// <value>Código do país.  Utilizar a tabela do BACEN.</value>
        [DataMember(Name = "cPais", EmitDefaultValue = false)]
        public int cPais { get; set; }

        /// <summary>
        /// Nome do país.
        /// </summary>
        /// <value>Nome do país.</value>
        [DataMember(Name = "xPais", EmitDefaultValue = false)]
        public string xPais { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazEndereco {\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  xMun: ").Append(xMun).Append("\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  cPais: ").Append(cPais).Append("\n");
            sb.Append("  xPais: ").Append(xPais).Append("\n");
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
            return this.Equals(input as CteSefazEndereco);
        }

        /// <summary>
        /// Returns true if CteSefazEndereco instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazEndereco to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazEndereco input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                ) && 
                (
                    this.cMun == input.cMun ||
                    this.cMun.Equals(input.cMun)
                ) && 
                (
                    this.xMun == input.xMun ||
                    (this.xMun != null &&
                    this.xMun.Equals(input.xMun))
                ) && 
                (
                    this.CEP == input.CEP ||
                    this.CEP.Equals(input.CEP)
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.cPais == input.cPais ||
                    this.cPais.Equals(input.cPais)
                ) && 
                (
                    this.xPais == input.xPais ||
                    (this.xPais != null &&
                    this.xPais.Equals(input.xPais))
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
                hashCode = (hashCode * 59) + this.cMun.GetHashCode();
                if (this.xMun != null)
                {
                    hashCode = (hashCode * 59) + this.xMun.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CEP.GetHashCode();
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.cPais.GetHashCode();
                if (this.xPais != null)
                {
                    hashCode = (hashCode * 59) + this.xPais.GetHashCode();
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
