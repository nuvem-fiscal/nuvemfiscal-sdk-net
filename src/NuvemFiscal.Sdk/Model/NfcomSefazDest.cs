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
    /// Identificação do destinatário / assinante.
    /// </summary>
    [DataContract(Name = "NfcomSefazDest")]
    public partial class NfcomSefazDest : IEquatable<NfcomSefazDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazDest" /> class.
        /// </summary>
        /// <param name="xNome">Razão social ou Nome do destinatário. (required).</param>
        /// <param name="cNPJ">Número do CNPJ.  Informar os zeros não significativos..</param>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="idOutros">Identificação do destinatário outros.  Identificação do destinatário não obrigado a inscrição do CPF tais como estrangeiro, indígena e quilombola  Em caso de não contar CPF do assinante, informar o RG..</param>
        /// <param name="indIEDest">Indicador da IE do Destinatário.  * 1 - Contribuinte ICMS (informar a IE do destinatário)  * 2 - Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS  * 9 - Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS  Nota: No caso de Contribuinte Isento de Inscrição (indIEDest&#x3D;2) informar a tag IE do destinatário com o literal ISENTO. (required).</param>
        /// <param name="iE">Inscrição Estadual do destinatário..</param>
        /// <param name="iM">Inscrição Municipal..</param>
        /// <param name="enderDest">enderDest (required).</param>
        public NfcomSefazDest(string xNome = default(string), string cNPJ = default(string), string cPF = default(string), string idOutros = default(string), int? indIEDest = default(int?), string iE = default(string), string iM = default(string), NfcomSefazEndeDest enderDest = default(NfcomSefazEndeDest))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for NfcomSefazDest and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "indIEDest" is required (not null)
            if (indIEDest == null)
            {
                throw new ArgumentNullException("indIEDest is a required property for NfcomSefazDest and cannot be null");
            }
            this.indIEDest = indIEDest;
            // to ensure "enderDest" is required (not null)
            if (enderDest == null)
            {
                throw new ArgumentNullException("enderDest is a required property for NfcomSefazDest and cannot be null");
            }
            this.enderDest = enderDest;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.idOutros = idOutros;
            this.IE = iE;
            this.IM = iM;
        }

        /// <summary>
        /// Razão social ou Nome do destinatário.
        /// </summary>
        /// <value>Razão social ou Nome do destinatário.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Número do CNPJ.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Informar os zeros não significativos.</value>
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
        /// Indicador da IE do Destinatário.  * 1 - Contribuinte ICMS (informar a IE do destinatário)  * 2 - Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS  * 9 - Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS  Nota: No caso de Contribuinte Isento de Inscrição (indIEDest&#x3D;2) informar a tag IE do destinatário com o literal ISENTO.
        /// </summary>
        /// <value>Indicador da IE do Destinatário.  * 1 - Contribuinte ICMS (informar a IE do destinatário)  * 2 - Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS  * 9 - Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS  Nota: No caso de Contribuinte Isento de Inscrição (indIEDest&#x3D;2) informar a tag IE do destinatário com o literal ISENTO.</value>
        [DataMember(Name = "indIEDest", IsRequired = true, EmitDefaultValue = true)]
        public int? indIEDest { get; set; }

        /// <summary>
        /// Inscrição Estadual do destinatário.
        /// </summary>
        /// <value>Inscrição Estadual do destinatário.</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Inscrição Municipal.
        /// </summary>
        /// <value>Inscrição Municipal.</value>
        [DataMember(Name = "IM", EmitDefaultValue = true)]
        public string IM { get; set; }

        /// <summary>
        /// Gets or Sets enderDest
        /// </summary>
        [DataMember(Name = "enderDest", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazEndeDest enderDest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazDest {\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  idOutros: ").Append(idOutros).Append("\n");
            sb.Append("  indIEDest: ").Append(indIEDest).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  IM: ").Append(IM).Append("\n");
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
            return this.Equals(input as NfcomSefazDest);
        }

        /// <summary>
        /// Returns true if NfcomSefazDest instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazDest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
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
                    this.indIEDest == input.indIEDest ||
                    (this.indIEDest != null &&
                    this.indIEDest.Equals(input.indIEDest))
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.IM == input.IM ||
                    (this.IM != null &&
                    this.IM.Equals(input.IM))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
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
                if (this.indIEDest != null)
                {
                    hashCode = (hashCode * 59) + this.indIEDest.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.IM != null)
                {
                    hashCode = (hashCode * 59) + this.IM.GetHashCode();
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

            // IM (string) maxLength
            if (this.IM != null && this.IM.Length > 15)
            {
                yield return new ValidationResult("Invalid value for IM, length must be less than 15.", new [] { "IM" });
            }

            // IM (string) minLength
            if (this.IM != null && this.IM.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IM, length must be greater than 1.", new [] { "IM" });
            }

            yield break;
        }
    }

}
