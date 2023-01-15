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
        public NfeSefazInfRespTec(string cNPJ = default(string), string xContato = default(string), string email = default(string), string fone = default(string), int idCSRT = default(int), string hashCSRT = default(string))
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
        [DataMember(Name = "idCSRT", EmitDefaultValue = false)]
        public int idCSRT { get; set; }

        /// <summary>
        /// O hashCSRT é o resultado da função hash (SHA-1 - Base64) do CSRT fornecido pelo fisco mais a Chave de Acesso da NFe.
        /// </summary>
        /// <value>O hashCSRT é o resultado da função hash (SHA-1 - Base64) do CSRT fornecido pelo fisco mais a Chave de Acesso da NFe.</value>
        [DataMember(Name = "hashCSRT", EmitDefaultValue = false)]
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
                    this.idCSRT.Equals(input.idCSRT)
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
                hashCode = (hashCode * 59) + this.idCSRT.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
