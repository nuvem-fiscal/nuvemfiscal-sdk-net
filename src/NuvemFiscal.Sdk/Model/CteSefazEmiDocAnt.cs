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
    /// CteSefazEmiDocAnt
    /// </summary>
    [DataContract(Name = "CteSefazEmiDocAnt")]
    public partial class CteSefazEmiDocAnt : IEquatable<CteSefazEmiDocAnt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEmiDocAnt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazEmiDocAnt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEmiDocAnt" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.                     Informar os zeros não significativos..</param>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="iE">Inscrição Estadual..</param>
        /// <param name="uF">Sigla da UF.  Informar EX para operações com o exterior..</param>
        /// <param name="xNome">Razão Social ou Nome do expedidor. (required).</param>
        /// <param name="idDocAnt">Informações de identificação dos documentos de Transporte Anterior. (required).</param>
        public CteSefazEmiDocAnt(string cNPJ = default(string), string cPF = default(string), string iE = default(string), string uF = default(string), string xNome = default(string), List<CteSefazIdDocAnt> idDocAnt = default(List<CteSefazIdDocAnt>))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteSefazEmiDocAnt and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "idDocAnt" is required (not null)
            if (idDocAnt == null)
            {
                throw new ArgumentNullException("idDocAnt is a required property for CteSefazEmiDocAnt and cannot be null");
            }
            this.idDocAnt = idDocAnt;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.IE = iE;
            this.UF = uF;
        }

        /// <summary>
        /// Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.                     Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.                     Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Inscrição Estadual.
        /// </summary>
        /// <value>Inscrição Estadual.</value>
        [DataMember(Name = "IE", EmitDefaultValue = false)]
        public string IE { get; set; }

        /// <summary>
        /// Sigla da UF.  Informar EX para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF.  Informar EX para operações com o exterior.</value>
        [DataMember(Name = "UF", EmitDefaultValue = false)]
        public string UF { get; set; }

        /// <summary>
        /// Razão Social ou Nome do expedidor.
        /// </summary>
        /// <value>Razão Social ou Nome do expedidor.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Informações de identificação dos documentos de Transporte Anterior.
        /// </summary>
        /// <value>Informações de identificação dos documentos de Transporte Anterior.</value>
        [DataMember(Name = "idDocAnt", IsRequired = true, EmitDefaultValue = true)]
        public List<CteSefazIdDocAnt> idDocAnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazEmiDocAnt {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  idDocAnt: ").Append(idDocAnt).Append("\n");
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
            return this.Equals(input as CteSefazEmiDocAnt);
        }

        /// <summary>
        /// Returns true if CteSefazEmiDocAnt instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazEmiDocAnt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazEmiDocAnt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
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
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.idDocAnt == input.idDocAnt ||
                    this.idDocAnt != null &&
                    input.idDocAnt != null &&
                    this.idDocAnt.SequenceEqual(input.idDocAnt)
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.idDocAnt != null)
                {
                    hashCode = (hashCode * 59) + this.idDocAnt.GetHashCode();
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
