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
    /// RpsDadosTomador
    /// </summary>
    [DataContract(Name = "RpsDadosTomador")]
    public partial class RpsDadosTomador : IEquatable<RpsDadosTomador>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosTomador" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RpsDadosTomador() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosTomador" /> class.
        /// </summary>
        /// <param name="cpfCnpj">CPF ou CNPJ do tomador/destinatário..</param>
        /// <param name="inscricaoMunicipal">Inscrição Municipal do tomador/destinatário..</param>
        /// <param name="nomeRazaoSocial">Nome ou Razão Social do tomador/destinatário. (required).</param>
        /// <param name="fone">Telefone do tomador/destinatário..</param>
        /// <param name="email">Email do tomador/destinatário..</param>
        /// <param name="endereco">endereco.</param>
        public RpsDadosTomador(string cpfCnpj = default(string), string inscricaoMunicipal = default(string), string nomeRazaoSocial = default(string), string fone = default(string), string email = default(string), RpsDadosTomadorEndereco endereco = default(RpsDadosTomadorEndereco))
        {
            // to ensure "nomeRazaoSocial" is required (not null)
            if (nomeRazaoSocial == null)
            {
                throw new ArgumentNullException("nomeRazaoSocial is a required property for RpsDadosTomador and cannot be null");
            }
            this.nome_razao_social = nomeRazaoSocial;
            this.cpf_cnpj = cpfCnpj;
            this.inscricao_municipal = inscricaoMunicipal;
            this.fone = fone;
            this.email = email;
            this.endereco = endereco;
        }

        /// <summary>
        /// CPF ou CNPJ do tomador/destinatário.
        /// </summary>
        /// <value>CPF ou CNPJ do tomador/destinatário.</value>
        [DataMember(Name = "cpf_cnpj", EmitDefaultValue = false)]
        public string cpf_cnpj { get; set; }

        /// <summary>
        /// Inscrição Municipal do tomador/destinatário.
        /// </summary>
        /// <value>Inscrição Municipal do tomador/destinatário.</value>
        [DataMember(Name = "inscricao_municipal", EmitDefaultValue = false)]
        public string inscricao_municipal { get; set; }

        /// <summary>
        /// Nome ou Razão Social do tomador/destinatário.
        /// </summary>
        /// <value>Nome ou Razão Social do tomador/destinatário.</value>
        [DataMember(Name = "nome_razao_social", IsRequired = true, EmitDefaultValue = true)]
        public string nome_razao_social { get; set; }

        /// <summary>
        /// Telefone do tomador/destinatário.
        /// </summary>
        /// <value>Telefone do tomador/destinatário.</value>
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// Email do tomador/destinatário.
        /// </summary>
        /// <value>Email do tomador/destinatário.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets endereco
        /// </summary>
        [DataMember(Name = "endereco", EmitDefaultValue = false)]
        public RpsDadosTomadorEndereco endereco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsDadosTomador {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  inscricao_municipal: ").Append(inscricao_municipal).Append("\n");
            sb.Append("  nome_razao_social: ").Append(nome_razao_social).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  endereco: ").Append(endereco).Append("\n");
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
            return this.Equals(input as RpsDadosTomador);
        }

        /// <summary>
        /// Returns true if RpsDadosTomador instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsDadosTomador to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsDadosTomador input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cpf_cnpj == input.cpf_cnpj ||
                    (this.cpf_cnpj != null &&
                    this.cpf_cnpj.Equals(input.cpf_cnpj))
                ) && 
                (
                    this.inscricao_municipal == input.inscricao_municipal ||
                    (this.inscricao_municipal != null &&
                    this.inscricao_municipal.Equals(input.inscricao_municipal))
                ) && 
                (
                    this.nome_razao_social == input.nome_razao_social ||
                    (this.nome_razao_social != null &&
                    this.nome_razao_social.Equals(input.nome_razao_social))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.endereco == input.endereco ||
                    (this.endereco != null &&
                    this.endereco.Equals(input.endereco))
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
                if (this.cpf_cnpj != null)
                {
                    hashCode = (hashCode * 59) + this.cpf_cnpj.GetHashCode();
                }
                if (this.inscricao_municipal != null)
                {
                    hashCode = (hashCode * 59) + this.inscricao_municipal.GetHashCode();
                }
                if (this.nome_razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.nome_razao_social.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
                }
                if (this.endereco != null)
                {
                    hashCode = (hashCode * 59) + this.endereco.GetHashCode();
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
