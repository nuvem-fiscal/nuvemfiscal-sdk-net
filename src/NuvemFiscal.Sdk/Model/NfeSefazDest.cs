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
    /// Identificação do Destinatário.
    /// </summary>
    [DataContract(Name = "NfeSefazDest")]
    public partial class NfeSefazDest : IEquatable<NfeSefazDest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDest" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ..</param>
        /// <param name="cPF">Número do CPF..</param>
        /// <param name="idEstrangeiro">Identificador do destinatário, em caso de comprador estrangeiro..</param>
        /// <param name="xNome">Razão Social ou nome do destinatário..</param>
        /// <param name="enderDest">enderDest.</param>
        /// <param name="indIEDest">Indicador da IE do destinatário:  * 1 - Contribuinte ICMSpagamento à vista  * 2 - Contribuinte isento de inscrição  * 9 - Não Contribuinte (required).</param>
        /// <param name="iE">Inscrição Estadual (obrigatório nas operações com contribuintes do ICMS)..</param>
        /// <param name="iSUF">Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA) PL_005d - 11/08/09 - alterado para aceitar 8 ou 9 dígitos..</param>
        /// <param name="iM">Inscrição Municipal do tomador do serviço..</param>
        /// <param name="email">Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail  de recepção da NF-e indicada pelo destinatário..</param>
        public NfeSefazDest(string cNPJ = default(string), string cPF = default(string), string idEstrangeiro = default(string), string xNome = default(string), NfeSefazEndereco enderDest = default(NfeSefazEndereco), int? indIEDest = default(int?), string iE = default(string), string iSUF = default(string), string iM = default(string), string email = default(string))
        {
            // to ensure "indIEDest" is required (not null)
            if (indIEDest == null)
            {
                throw new ArgumentNullException("indIEDest is a required property for NfeSefazDest and cannot be null");
            }
            this.indIEDest = indIEDest;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.idEstrangeiro = idEstrangeiro;
            this.xNome = xNome;
            this.enderDest = enderDest;
            this.IE = iE;
            this.ISUF = iSUF;
            this.IM = iM;
            this.email = email;
        }

        /// <summary>
        /// Número do CNPJ.
        /// </summary>
        /// <value>Número do CNPJ.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF.
        /// </summary>
        /// <value>Número do CPF.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Identificador do destinatário, em caso de comprador estrangeiro.
        /// </summary>
        /// <value>Identificador do destinatário, em caso de comprador estrangeiro.</value>
        [DataMember(Name = "idEstrangeiro", EmitDefaultValue = true)]
        public string idEstrangeiro { get; set; }

        /// <summary>
        /// Razão Social ou nome do destinatário.
        /// </summary>
        /// <value>Razão Social ou nome do destinatário.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Gets or Sets enderDest
        /// </summary>
        [DataMember(Name = "enderDest", EmitDefaultValue = false)]
        public NfeSefazEndereco enderDest { get; set; }

        /// <summary>
        /// Indicador da IE do destinatário:  * 1 - Contribuinte ICMSpagamento à vista  * 2 - Contribuinte isento de inscrição  * 9 - Não Contribuinte
        /// </summary>
        /// <value>Indicador da IE do destinatário:  * 1 - Contribuinte ICMSpagamento à vista  * 2 - Contribuinte isento de inscrição  * 9 - Não Contribuinte</value>
        [DataMember(Name = "indIEDest", IsRequired = true, EmitDefaultValue = true)]
        public int? indIEDest { get; set; }

        /// <summary>
        /// Inscrição Estadual (obrigatório nas operações com contribuintes do ICMS).
        /// </summary>
        /// <value>Inscrição Estadual (obrigatório nas operações com contribuintes do ICMS).</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA) PL_005d - 11/08/09 - alterado para aceitar 8 ou 9 dígitos.
        /// </summary>
        /// <value>Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA) PL_005d - 11/08/09 - alterado para aceitar 8 ou 9 dígitos.</value>
        [DataMember(Name = "ISUF", EmitDefaultValue = true)]
        public string ISUF { get; set; }

        /// <summary>
        /// Inscrição Municipal do tomador do serviço.
        /// </summary>
        /// <value>Inscrição Municipal do tomador do serviço.</value>
        [DataMember(Name = "IM", EmitDefaultValue = true)]
        public string IM { get; set; }

        /// <summary>
        /// Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail  de recepção da NF-e indicada pelo destinatário.
        /// </summary>
        /// <value>Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail  de recepção da NF-e indicada pelo destinatário.</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDest {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  idEstrangeiro: ").Append(idEstrangeiro).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  enderDest: ").Append(enderDest).Append("\n");
            sb.Append("  indIEDest: ").Append(indIEDest).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  ISUF: ").Append(ISUF).Append("\n");
            sb.Append("  IM: ").Append(IM).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
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
            return this.Equals(input as NfeSefazDest);
        }

        /// <summary>
        /// Returns true if NfeSefazDest instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDest input)
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
                    this.idEstrangeiro == input.idEstrangeiro ||
                    (this.idEstrangeiro != null &&
                    this.idEstrangeiro.Equals(input.idEstrangeiro))
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
                    this.ISUF == input.ISUF ||
                    (this.ISUF != null &&
                    this.ISUF.Equals(input.ISUF))
                ) && 
                (
                    this.IM == input.IM ||
                    (this.IM != null &&
                    this.IM.Equals(input.IM))
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
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
                if (this.idEstrangeiro != null)
                {
                    hashCode = (hashCode * 59) + this.idEstrangeiro.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.enderDest != null)
                {
                    hashCode = (hashCode * 59) + this.enderDest.GetHashCode();
                }
                if (this.indIEDest != null)
                {
                    hashCode = (hashCode * 59) + this.indIEDest.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.ISUF != null)
                {
                    hashCode = (hashCode * 59) + this.ISUF.GetHashCode();
                }
                if (this.IM != null)
                {
                    hashCode = (hashCode * 59) + this.IM.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
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
            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // CPF (string) maxLength
            if (this.CPF != null && this.CPF.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CPF, length must be less than 11.", new [] { "CPF" });
            }

            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be less than 60.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be greater than 2.", new [] { "xNome" });
            }

            // IE (string) maxLength
            if (this.IE != null && this.IE.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IE, length must be less than 14.", new [] { "IE" });
            }

            // IM (string) maxLength
            if (this.IM != null && this.IM.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IM, length must be less than 15.", new [] { "IM" });
            }

            // IM (string) minLength
            if (this.IM != null && this.IM.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IM, length must be greater than 1.", new [] { "IM" });
            }

            // email (string) maxLength
            if (this.email != null && this.email.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for email, length must be less than 60.", new [] { "email" });
            }

            // email (string) minLength
            if (this.email != null && this.email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for email, length must be greater than 1.", new [] { "email" });
            }

            yield break;
        }
    }

}
