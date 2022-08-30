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
    /// EmpresaCertificado
    /// </summary>
    [DataContract(Name = "EmpresaCertificado")]
    public partial class EmpresaCertificado : IEquatable<EmpresaCertificado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaCertificado" /> class.
        /// </summary>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="issuerName">issuerName.</param>
        /// <param name="notValidBefore">notValidBefore.</param>
        /// <param name="notValidAfter">notValidAfter.</param>
        /// <param name="thumbprint">thumbprint.</param>
        /// <param name="subjectName">subjectName.</param>
        /// <param name="cpfCnpj">cpfCnpj.</param>
        /// <param name="nomeRazaoSocial">nomeRazaoSocial.</param>
        public EmpresaCertificado(string serialNumber = default(string), string issuerName = default(string), DateTime notValidBefore = default(DateTime), DateTime notValidAfter = default(DateTime), string thumbprint = default(string), string subjectName = default(string), string cpfCnpj = default(string), string nomeRazaoSocial = default(string))
        {
            this.serial_number = serialNumber;
            this.issuer_name = issuerName;
            this.not_valid_before = notValidBefore;
            this.not_valid_after = notValidAfter;
            this.thumbprint = thumbprint;
            this.subject_name = subjectName;
            this.cpf_cnpj = cpfCnpj;
            this.nome_razao_social = nomeRazaoSocial;
        }

        /// <summary>
        /// Gets or Sets serial_number
        /// </summary>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]
        public string serial_number { get; set; }

        /// <summary>
        /// Gets or Sets issuer_name
        /// </summary>
        [DataMember(Name = "issuer_name", EmitDefaultValue = false)]
        public string issuer_name { get; set; }

        /// <summary>
        /// Gets or Sets not_valid_before
        /// </summary>
        [DataMember(Name = "not_valid_before", EmitDefaultValue = false)]
        public DateTime not_valid_before { get; set; }

        /// <summary>
        /// Gets or Sets not_valid_after
        /// </summary>
        [DataMember(Name = "not_valid_after", EmitDefaultValue = false)]
        public DateTime not_valid_after { get; set; }

        /// <summary>
        /// Gets or Sets thumbprint
        /// </summary>
        [DataMember(Name = "thumbprint", EmitDefaultValue = false)]
        public string thumbprint { get; set; }

        /// <summary>
        /// Gets or Sets subject_name
        /// </summary>
        [DataMember(Name = "subject_name", EmitDefaultValue = false)]
        public string subject_name { get; set; }

        /// <summary>
        /// Gets or Sets cpf_cnpj
        /// </summary>
        [DataMember(Name = "cpf_cnpj", EmitDefaultValue = false)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Gets or Sets nome_razao_social
        /// </summary>
        [DataMember(Name = "nome_razao_social", EmitDefaultValue = false)]
        public string nome_razao_social { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaCertificado {\n");
            sb.Append("  serial_number: ").Append(serial_number).Append("\n");
            sb.Append("  issuer_name: ").Append(issuer_name).Append("\n");
            sb.Append("  not_valid_before: ").Append(not_valid_before).Append("\n");
            sb.Append("  not_valid_after: ").Append(not_valid_after).Append("\n");
            sb.Append("  thumbprint: ").Append(thumbprint).Append("\n");
            sb.Append("  subject_name: ").Append(subject_name).Append("\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  nome_razao_social: ").Append(nome_razao_social).Append("\n");
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
            return this.Equals(input as EmpresaCertificado);
        }

        /// <summary>
        /// Returns true if EmpresaCertificado instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaCertificado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaCertificado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.serial_number == input.serial_number ||
                    (this.serial_number != null &&
                    this.serial_number.Equals(input.serial_number))
                ) && 
                (
                    this.issuer_name == input.issuer_name ||
                    (this.issuer_name != null &&
                    this.issuer_name.Equals(input.issuer_name))
                ) && 
                (
                    this.not_valid_before == input.not_valid_before ||
                    (this.not_valid_before != null &&
                    this.not_valid_before.Equals(input.not_valid_before))
                ) && 
                (
                    this.not_valid_after == input.not_valid_after ||
                    (this.not_valid_after != null &&
                    this.not_valid_after.Equals(input.not_valid_after))
                ) && 
                (
                    this.thumbprint == input.thumbprint ||
                    (this.thumbprint != null &&
                    this.thumbprint.Equals(input.thumbprint))
                ) && 
                (
                    this.subject_name == input.subject_name ||
                    (this.subject_name != null &&
                    this.subject_name.Equals(input.subject_name))
                ) && 
                (
                    this.cpf_cnpj == input.cpf_cnpj ||
                    (this.cpf_cnpj != null &&
                    this.cpf_cnpj.Equals(input.cpf_cnpj))
                ) && 
                (
                    this.nome_razao_social == input.nome_razao_social ||
                    (this.nome_razao_social != null &&
                    this.nome_razao_social.Equals(input.nome_razao_social))
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
                if (this.serial_number != null)
                {
                    hashCode = (hashCode * 59) + this.serial_number.GetHashCode();
                }
                if (this.issuer_name != null)
                {
                    hashCode = (hashCode * 59) + this.issuer_name.GetHashCode();
                }
                if (this.not_valid_before != null)
                {
                    hashCode = (hashCode * 59) + this.not_valid_before.GetHashCode();
                }
                if (this.not_valid_after != null)
                {
                    hashCode = (hashCode * 59) + this.not_valid_after.GetHashCode();
                }
                if (this.thumbprint != null)
                {
                    hashCode = (hashCode * 59) + this.thumbprint.GetHashCode();
                }
                if (this.subject_name != null)
                {
                    hashCode = (hashCode * 59) + this.subject_name.GetHashCode();
                }
                if (this.cpf_cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_cnpj.GetHashCode();
                }
                if (this.nome_razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.nome_razao_social.GetHashCode();
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
