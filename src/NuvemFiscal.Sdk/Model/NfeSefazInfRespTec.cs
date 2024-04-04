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
    /// Informações do Responsável Técnico pela emissão do DF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazInfRespTec")]
    public partial class NfeSefazInfRespTec : IEquatable<NfeSefazInfRespTec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfRespTec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazInfRespTec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfRespTec" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ. (required).</param>
        /// <param name="xContato">Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. (required).</param>
        /// <param name="email">Informar o e-mail da pessoa a ser contatada na empresa desenvolvedora do sistema. (required).</param>
        /// <param name="fone">Informar o telefone da pessoa a ser contatada na empresa desenvolvedora do sistema. Preencher com o Código DDD + número do telefone. (required).</param>
        /// <param name="idCSRT">Identificador do CSRT utilizado para montar o hash do CSRT..</param>
        /// <param name="hashCSRT">O hashCSRT é o resultado da função hash (SHA-1 - Base64) do CSRT fornecido pelo fisco mais a Chave de Acesso da NFe..</param>
        public NfeSefazInfRespTec(string cNPJ = default(string), string xContato = default(string), string email = default(string), string fone = default(string), int? idCSRT = default(int?), string hashCSRT = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfeSefazInfRespTec and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xContato" is required (not null)
            if (xContato == null)
            {
                throw new ArgumentNullException("xContato is a required property for NfeSefazInfRespTec and cannot be null");
            }
            this.xContato = xContato;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for NfeSefazInfRespTec and cannot be null");
            }
            this.email = email;
            // to ensure "fone" is required (not null)
            if (fone == null)
            {
                throw new ArgumentNullException("fone is a required property for NfeSefazInfRespTec and cannot be null");
            }
            this.fone = fone;
            this.idCSRT = idCSRT;
            this.hashCSRT = hashCSRT;
        }

        /// <summary>
        /// CNPJ.
        /// </summary>
        /// <value>CNPJ.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico.
        /// </summary>
        /// <value>Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico.</value>
        [DataMember(Name = "xContato", IsRequired = true, EmitDefaultValue = true)]
        public string xContato { get; set; }

        /// <summary>
        /// Informar o e-mail da pessoa a ser contatada na empresa desenvolvedora do sistema.
        /// </summary>
        /// <value>Informar o e-mail da pessoa a ser contatada na empresa desenvolvedora do sistema.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Informar o telefone da pessoa a ser contatada na empresa desenvolvedora do sistema. Preencher com o Código DDD + número do telefone.
        /// </summary>
        /// <value>Informar o telefone da pessoa a ser contatada na empresa desenvolvedora do sistema. Preencher com o Código DDD + número do telefone.</value>
        [DataMember(Name = "fone", IsRequired = true, EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Identificador do CSRT utilizado para montar o hash do CSRT.
        /// </summary>
        /// <value>Identificador do CSRT utilizado para montar o hash do CSRT.</value>
        [DataMember(Name = "idCSRT", EmitDefaultValue = true)]
        public int? idCSRT { get; set; }

        /// <summary>
        /// O hashCSRT é o resultado da função hash (SHA-1 - Base64) do CSRT fornecido pelo fisco mais a Chave de Acesso da NFe.
        /// </summary>
        /// <value>O hashCSRT é o resultado da função hash (SHA-1 - Base64) do CSRT fornecido pelo fisco mais a Chave de Acesso da NFe.</value>
        [DataMember(Name = "hashCSRT", EmitDefaultValue = true)]
        public string hashCSRT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfRespTec {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  xContato: ").Append(xContato).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  idCSRT: ").Append(idCSRT).Append("\n");
            sb.Append("  hashCSRT: ").Append(hashCSRT).Append("\n");
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
            return this.Equals(input as NfeSefazInfRespTec);
        }

        /// <summary>
        /// Returns true if NfeSefazInfRespTec instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfRespTec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfRespTec input)
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
                    this.xContato == input.xContato ||
                    (this.xContato != null &&
                    this.xContato.Equals(input.xContato))
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
                ) && 
                (
                    this.idCSRT == input.idCSRT ||
                    (this.idCSRT != null &&
                    this.idCSRT.Equals(input.idCSRT))
                ) && 
                (
                    this.hashCSRT == input.hashCSRT ||
                    (this.hashCSRT != null &&
                    this.hashCSRT.Equals(input.hashCSRT))
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
                if (this.xContato != null)
                {
                    hashCode = (hashCode * 59) + this.xContato.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.idCSRT != null)
                {
                    hashCode = (hashCode * 59) + this.idCSRT.GetHashCode();
                }
                if (this.hashCSRT != null)
                {
                    hashCode = (hashCode * 59) + this.hashCSRT.GetHashCode();
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

            // xContato (string) maxLength
            if (this.xContato != null && this.xContato.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xContato, length must be less than 60.", new [] { "xContato" });
            }

            // xContato (string) minLength
            if (this.xContato != null && this.xContato.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xContato, length must be greater than 2.", new [] { "xContato" });
            }

            // email (string) maxLength
            if (this.email != null && this.email.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for email, length must be less than 60.", new [] { "email" });
            }

            // email (string) minLength
            if (this.email != null && this.email.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for email, length must be greater than 6.", new [] { "email" });
            }

            // idCSRT (int?) maximum
            if (this.idCSRT > (int?)99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idCSRT, must be a value less than or equal to 99.", new [] { "idCSRT" });
            }

            // idCSRT (int?) minimum
            if (this.idCSRT < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idCSRT, must be a value greater than or equal to 0.", new [] { "idCSRT" });
            }

            // hashCSRT (string) maxLength
            if (this.hashCSRT != null && this.hashCSRT.Length > 28)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for hashCSRT, length must be less than 28.", new [] { "hashCSRT" });
            }

            yield break;
        }
    }

}
