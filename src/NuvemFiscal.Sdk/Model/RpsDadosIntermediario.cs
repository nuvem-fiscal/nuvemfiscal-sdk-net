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
    /// RpsDadosIntermediario
    /// </summary>
    [DataContract(Name = "RpsDadosIntermediario")]
    public partial class RpsDadosIntermediario : IEquatable<RpsDadosIntermediario>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsDadosIntermediario" /> class.
        /// </summary>
        /// <param name="cpfCnpj">cpfCnpj.</param>
        /// <param name="nomeRazaoSocial">nomeRazaoSocial.</param>
        /// <param name="inscricaoMunicipal">inscricaoMunicipal.</param>
        public RpsDadosIntermediario(string cpfCnpj = default(string), string nomeRazaoSocial = default(string), string inscricaoMunicipal = default(string))
        {
            this.cpf_cnpj = cpfCnpj;
            this.nome_razao_social = nomeRazaoSocial;
            this.inscricao_municipal = inscricaoMunicipal;
        }

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
        /// Gets or Sets inscricao_municipal
        /// </summary>
        [DataMember(Name = "inscricao_municipal", EmitDefaultValue = false)]
        public string inscricao_municipal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsDadosIntermediario {\n");
            sb.Append("  cpf_cnpj: ").Append(cpf_cnpj).Append("\n");
            sb.Append("  nome_razao_social: ").Append(nome_razao_social).Append("\n");
            sb.Append("  inscricao_municipal: ").Append(inscricao_municipal).Append("\n");
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
            return this.Equals(input as RpsDadosIntermediario);
        }

        /// <summary>
        /// Returns true if RpsDadosIntermediario instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsDadosIntermediario to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsDadosIntermediario input)
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
                    this.nome_razao_social == input.nome_razao_social ||
                    (this.nome_razao_social != null &&
                    this.nome_razao_social.Equals(input.nome_razao_social))
                ) && 
                (
                    this.inscricao_municipal == input.inscricao_municipal ||
                    (this.inscricao_municipal != null &&
                    this.inscricao_municipal.Equals(input.inscricao_municipal))
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
                if (this.nome_razao_social != null)
                {
                    hashCode = (hashCode * 59) + this.nome_razao_social.GetHashCode();
                }
                if (this.inscricao_municipal != null)
                {
                    hashCode = (hashCode * 59) + this.inscricao_municipal.GetHashCode();
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
            yield break;
        }
    }

}
