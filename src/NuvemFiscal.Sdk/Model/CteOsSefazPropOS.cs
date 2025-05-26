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
    /// Proprietário ou possuidor do Veículo.  Só preenchido quando o veículo não pertencer à empresa emitente do CT-e OS.
    /// </summary>
    [DataContract(Name = "CteOsSefazPropOS")]
    public partial class CteOsSefazPropOS : IEquatable<CteOsSefazPropOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazPropOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazPropOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazPropOS" /> class.
        /// </summary>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="cNPJ">Número do CNPJ.  Informar os zeros não significativos..</param>
        /// <param name="tAF">Termo de Autorização de Fretamento - TAF.  De acordo com a Resolução ANTT nº 4.777/2015..</param>
        /// <param name="nroRegEstadual">Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual..</param>
        /// <param name="xNome">Razão Social ou Nome do proprietário. (required).</param>
        /// <param name="iE">Inscrição Estadual..</param>
        /// <param name="uF">UF..</param>
        /// <param name="tpProp">Tipo Proprietário ou possuidor.  Preencher com:  * 0 - TAC - Agregado  * 1 - TAC Independente  ou  * 2 - Outros (required).</param>
        public CteOsSefazPropOS(string cPF = default(string), string cNPJ = default(string), string tAF = default(string), string nroRegEstadual = default(string), string xNome = default(string), string iE = default(string), string uF = default(string), int? tpProp = default(int?))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteOsSefazPropOS and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "tpProp" is required (not null)
            if (tpProp == null)
            {
                throw new ArgumentNullException("tpProp is a required property for CteOsSefazPropOS and cannot be null");
            }
            this.tpProp = tpProp;
            this.CPF = cPF;
            this.CNPJ = cNPJ;
            this.TAF = tAF;
            this.NroRegEstadual = nroRegEstadual;
            this.IE = iE;
            this.UF = uF;
        }

        /// <summary>
        /// Número do CPF.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Número do CNPJ.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Termo de Autorização de Fretamento - TAF.  De acordo com a Resolução ANTT nº 4.777/2015.
        /// </summary>
        /// <value>Termo de Autorização de Fretamento - TAF.  De acordo com a Resolução ANTT nº 4.777/2015.</value>
        [DataMember(Name = "TAF", EmitDefaultValue = true)]
        public string TAF { get; set; }

        /// <summary>
        /// Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual.
        /// </summary>
        /// <value>Número do Registro Estadual.  Registro obrigatório do emitente do CT-e OS junto à Agência Reguladora  Estadual.</value>
        [DataMember(Name = "NroRegEstadual", EmitDefaultValue = true)]
        public string NroRegEstadual { get; set; }

        /// <summary>
        /// Razão Social ou Nome do proprietário.
        /// </summary>
        /// <value>Razão Social ou Nome do proprietário.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Inscrição Estadual.
        /// </summary>
        /// <value>Inscrição Estadual.</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// UF.
        /// </summary>
        /// <value>UF.</value>
        [DataMember(Name = "UF", EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Tipo Proprietário ou possuidor.  Preencher com:  * 0 - TAC - Agregado  * 1 - TAC Independente  ou  * 2 - Outros
        /// </summary>
        /// <value>Tipo Proprietário ou possuidor.  Preencher com:  * 0 - TAC - Agregado  * 1 - TAC Independente  ou  * 2 - Outros</value>
        [DataMember(Name = "tpProp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpProp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazPropOS {\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  TAF: ").Append(TAF).Append("\n");
            sb.Append("  NroRegEstadual: ").Append(NroRegEstadual).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  tpProp: ").Append(tpProp).Append("\n");
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
            return this.Equals(input as CteOsSefazPropOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazPropOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazPropOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazPropOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.TAF == input.TAF ||
                    (this.TAF != null &&
                    this.TAF.Equals(input.TAF))
                ) && 
                (
                    this.NroRegEstadual == input.NroRegEstadual ||
                    (this.NroRegEstadual != null &&
                    this.NroRegEstadual.Equals(input.NroRegEstadual))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.tpProp == input.tpProp ||
                    (this.tpProp != null &&
                    this.tpProp.Equals(input.tpProp))
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
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.TAF != null)
                {
                    hashCode = (hashCode * 59) + this.TAF.GetHashCode();
                }
                if (this.NroRegEstadual != null)
                {
                    hashCode = (hashCode * 59) + this.NroRegEstadual.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.tpProp != null)
                {
                    hashCode = (hashCode * 59) + this.tpProp.GetHashCode();
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
            // TAF (string) maxLength
            if (this.TAF != null && this.TAF.Length > 12)
            {
                yield return new ValidationResult("Invalid value for TAF, length must be less than 12.", new [] { "TAF" });
            }

            // NroRegEstadual (string) maxLength
            if (this.NroRegEstadual != null && this.NroRegEstadual.Length > 25)
            {
                yield return new ValidationResult("Invalid value for NroRegEstadual, length must be less than 25.", new [] { "NroRegEstadual" });
            }

            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be less than 60.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be greater than 2.", new [] { "xNome" });
            }

            yield break;
        }
    }

}
