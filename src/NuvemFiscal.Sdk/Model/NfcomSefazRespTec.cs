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
    [DataContract(Name = "NfcomSefazRespTec")]
    public partial class NfcomSefazRespTec : IEquatable<NfcomSefazRespTec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazRespTec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazRespTec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazRespTec" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ da pessoa jurídica responsável técnica pelo sistema utilizado na emissão do documento fiscal eletrônico.  Informar o CNPJ da pessoa jurídica desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. (required).</param>
        /// <param name="xContato">Nome da pessoa a ser contatada.  Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. No caso de pessoa física, informar o respectivo nome. (required).</param>
        /// <param name="email">Email da pessoa jurídica a ser contatada. (required).</param>
        /// <param name="fone">Telefone da pessoa jurídica a ser contatada.  Preencher com o Código DDD + número do telefone. (required).</param>
        /// <param name="idCSRT">Identificador do código de segurança do responsável técnico.  Identificador do CSRT utilizado para geração do hash..</param>
        /// <param name="hashCSRT">Hash do token do código de segurança do responsável técnico.  O hashCSRT é o resultado das funções SHA-1 e base64 do token CSRT fornecido pelo fisco + chave de acesso do DF-e. (Implementação em futura NT)  Observação: 28 caracteres são representados no schema como 20 bytes do tipo base64Binary..</param>
        public NfcomSefazRespTec(string cNPJ = default(string), string xContato = default(string), string email = default(string), string fone = default(string), int? idCSRT = default(int?), string hashCSRT = default(string))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfcomSefazRespTec and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xContato" is required (not null)
            if (xContato == null)
            {
                throw new ArgumentNullException("xContato is a required property for NfcomSefazRespTec and cannot be null");
            }
            this.xContato = xContato;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for NfcomSefazRespTec and cannot be null");
            }
            this.email = email;
            // to ensure "fone" is required (not null)
            if (fone == null)
            {
                throw new ArgumentNullException("fone is a required property for NfcomSefazRespTec and cannot be null");
            }
            this.fone = fone;
            this.idCSRT = idCSRT;
            this.hashCSRT = hashCSRT;
        }

        /// <summary>
        /// CNPJ da pessoa jurídica responsável técnica pelo sistema utilizado na emissão do documento fiscal eletrônico.  Informar o CNPJ da pessoa jurídica desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico.
        /// </summary>
        /// <value>CNPJ da pessoa jurídica responsável técnica pelo sistema utilizado na emissão do documento fiscal eletrônico.  Informar o CNPJ da pessoa jurídica desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Nome da pessoa a ser contatada.  Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. No caso de pessoa física, informar o respectivo nome.
        /// </summary>
        /// <value>Nome da pessoa a ser contatada.  Informar o nome da pessoa a ser contatada na empresa desenvolvedora do sistema utilizado na emissão do documento fiscal eletrônico. No caso de pessoa física, informar o respectivo nome.</value>
        [DataMember(Name = "xContato", IsRequired = true, EmitDefaultValue = true)]
        public string xContato { get; set; }

        /// <summary>
        /// Email da pessoa jurídica a ser contatada.
        /// </summary>
        /// <value>Email da pessoa jurídica a ser contatada.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Telefone da pessoa jurídica a ser contatada.  Preencher com o Código DDD + número do telefone.
        /// </summary>
        /// <value>Telefone da pessoa jurídica a ser contatada.  Preencher com o Código DDD + número do telefone.</value>
        [DataMember(Name = "fone", IsRequired = true, EmitDefaultValue = true)]
        public string fone { get; set; }

        /// <summary>
        /// Identificador do código de segurança do responsável técnico.  Identificador do CSRT utilizado para geração do hash.
        /// </summary>
        /// <value>Identificador do código de segurança do responsável técnico.  Identificador do CSRT utilizado para geração do hash.</value>
        [DataMember(Name = "idCSRT", EmitDefaultValue = true)]
        public int? idCSRT { get; set; }

        /// <summary>
        /// Hash do token do código de segurança do responsável técnico.  O hashCSRT é o resultado das funções SHA-1 e base64 do token CSRT fornecido pelo fisco + chave de acesso do DF-e. (Implementação em futura NT)  Observação: 28 caracteres são representados no schema como 20 bytes do tipo base64Binary.
        /// </summary>
        /// <value>Hash do token do código de segurança do responsável técnico.  O hashCSRT é o resultado das funções SHA-1 e base64 do token CSRT fornecido pelo fisco + chave de acesso do DF-e. (Implementação em futura NT)  Observação: 28 caracteres são representados no schema como 20 bytes do tipo base64Binary.</value>
        [DataMember(Name = "hashCSRT", EmitDefaultValue = true)]
        public string hashCSRT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazRespTec {\n");
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
            return this.Equals(input as NfcomSefazRespTec);
        }

        /// <summary>
        /// Returns true if NfcomSefazRespTec instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazRespTec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazRespTec input)
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // xContato (string) maxLength
            if (this.xContato != null && this.xContato.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xContato, length must be less than 60.", new [] { "xContato" });
            }

            // xContato (string) minLength
            if (this.xContato != null && this.xContato.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xContato, length must be greater than 2.", new [] { "xContato" });
            }

            // email (string) maxLength
            if (this.email != null && this.email.Length > 60)
            {
                yield return new ValidationResult("Invalid value for email, length must be less than 60.", new [] { "email" });
            }

            // email (string) minLength
            if (this.email != null && this.email.Length < 1)
            {
                yield return new ValidationResult("Invalid value for email, length must be greater than 1.", new [] { "email" });
            }

            // idCSRT (int?) maximum
            if (this.idCSRT > (int?)999)
            {
                yield return new ValidationResult("Invalid value for idCSRT, must be a value less than or equal to 999.", new [] { "idCSRT" });
            }

            // idCSRT (int?) minimum
            if (this.idCSRT < (int?)0)
            {
                yield return new ValidationResult("Invalid value for idCSRT, must be a value greater than or equal to 0.", new [] { "idCSRT" });
            }

            // hashCSRT (string) maxLength
            if (this.hashCSRT != null && this.hashCSRT.Length > 28)
            {
                yield return new ValidationResult("Invalid value for hashCSRT, length must be less than 28.", new [] { "hashCSRT" });
            }

            yield break;
        }
    }

}
