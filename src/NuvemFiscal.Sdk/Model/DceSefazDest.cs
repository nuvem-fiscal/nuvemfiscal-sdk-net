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
    /// Identificação do destinatário da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazDest")]
    public partial class DceSefazDest : IEquatable<DceSefazDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazDest" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos..</param>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="idOutros">Identificação do destinatário outros.  Identificação do destinatário não obrigado a inscrição do CPF tais como estrangeiro, indígena e quilombola  Em caso de não contar CPF do assinante, informar o RG..</param>
        /// <param name="xNome">Razão social ou Nome do destinatário. (required).</param>
        /// <param name="enderDest">enderDest (required).</param>
        public DceSefazDest(string cNPJ = default(string), string cPF = default(string), string idOutros = default(string), string xNome = default(string), DceSefazEndeDest enderDest = default(DceSefazEndeDest))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for DceSefazDest and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "enderDest" is required (not null)
            if (enderDest == null)
            {
                throw new ArgumentNullException("enderDest is a required property for DceSefazDest and cannot be null");
            }
            this.enderDest = enderDest;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.idOutros = idOutros;
        }

        /// <summary>
        /// Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Em caso de empresa não estabelecida no Brasil, será informado o CNPJ com zeros.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Identificação do destinatário outros.  Identificação do destinatário não obrigado a inscrição do CPF tais como estrangeiro, indígena e quilombola  Em caso de não contar CPF do assinante, informar o RG.
        /// </summary>
        /// <value>Identificação do destinatário outros.  Identificação do destinatário não obrigado a inscrição do CPF tais como estrangeiro, indígena e quilombola  Em caso de não contar CPF do assinante, informar o RG.</value>
        [DataMember(Name = "idOutros", EmitDefaultValue = true)]
        public string idOutros { get; set; }

        /// <summary>
        /// Razão social ou Nome do destinatário.
        /// </summary>
        /// <value>Razão social ou Nome do destinatário.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Gets or Sets enderDest
        /// </summary>
        [DataMember(Name = "enderDest", IsRequired = true, EmitDefaultValue = true)]
        public DceSefazEndeDest enderDest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazDest {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  idOutros: ").Append(idOutros).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  enderDest: ").Append(enderDest).Append("\n");
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
            return this.Equals(input as DceSefazDest);
        }

        /// <summary>
        /// Returns true if DceSefazDest instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazDest input)
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
                    this.idOutros == input.idOutros ||
                    (this.idOutros != null &&
                    this.idOutros.Equals(input.idOutros))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.enderDest == input.enderDest ||
                    (this.enderDest != null &&
                    this.enderDest.Equals(input.enderDest))
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
                if (this.idOutros != null)
                {
                    hashCode = (hashCode * 59) + this.idOutros.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.enderDest != null)
                {
                    hashCode = (hashCode * 59) + this.enderDest.GetHashCode();
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
            // idOutros (string) maxLength
            if (this.idOutros != null && this.idOutros.Length > 20)
            {
                yield return new ValidationResult("Invalid value for idOutros, length must be less than 20.", new [] { "idOutros" });
            }

            // idOutros (string) minLength
            if (this.idOutros != null && this.idOutros.Length < 2)
            {
                yield return new ValidationResult("Invalid value for idOutros, length must be greater than 2.", new [] { "idOutros" });
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
