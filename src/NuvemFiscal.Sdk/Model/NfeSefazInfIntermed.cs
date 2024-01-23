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
    /// Grupo de Informações do Intermediador da Transação.
    /// </summary>
    [DataContract(Name = "NfeSefazInfIntermed")]
    public partial class NfeSefazInfIntermed : IEquatable<NfeSefazInfIntermed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfIntermed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazInfIntermed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfIntermed" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do Intermediador da Transação (agenciador, plataforma de delivery, marketplace e similar) de serviços e de negócios. (required).</param>
        /// <param name="idCadIntTran">Identificador cadastrado no intermediador. (required).</param>
        public NfeSefazInfIntermed(string cNPJ = default(string), string idCadIntTran = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfeSefazInfIntermed and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "idCadIntTran" is required (not null)
            if (idCadIntTran == null)
            {
                throw new ArgumentNullException("idCadIntTran is a required property for NfeSefazInfIntermed and cannot be null");
            }
            this.idCadIntTran = idCadIntTran;
        }

        /// <summary>
        /// CNPJ do Intermediador da Transação (agenciador, plataforma de delivery, marketplace e similar) de serviços e de negócios.
        /// </summary>
        /// <value>CNPJ do Intermediador da Transação (agenciador, plataforma de delivery, marketplace e similar) de serviços e de negócios.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Identificador cadastrado no intermediador.
        /// </summary>
        /// <value>Identificador cadastrado no intermediador.</value>
        [DataMember(Name = "idCadIntTran", IsRequired = true, EmitDefaultValue = true)]
        public string idCadIntTran { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfIntermed {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  idCadIntTran: ").Append(idCadIntTran).Append("\n");
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
            return this.Equals(input as NfeSefazInfIntermed);
        }

        /// <summary>
        /// Returns true if NfeSefazInfIntermed instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfIntermed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfIntermed input)
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
                    this.idCadIntTran == input.idCadIntTran ||
                    (this.idCadIntTran != null &&
                    this.idCadIntTran.Equals(input.idCadIntTran))
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
                if (this.idCadIntTran != null)
                {
                    hashCode = (hashCode * 59) + this.idCadIntTran.GetHashCode();
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

            // idCadIntTran (string) maxLength
            if (this.idCadIntTran != null && this.idCadIntTran.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idCadIntTran, length must be less than 60.", new [] { "idCadIntTran" });
            }

            // idCadIntTran (string) minLength
            if (this.idCadIntTran != null && this.idCadIntTran.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idCadIntTran, length must be greater than 2.", new [] { "idCadIntTran" });
            }

            yield break;
        }
    }

}
