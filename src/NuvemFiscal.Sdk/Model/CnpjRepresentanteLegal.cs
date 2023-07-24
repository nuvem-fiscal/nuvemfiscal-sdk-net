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
    /// Representante legal.
    /// </summary>
    [DataContract(Name = "CnpjRepresentanteLegal")]
    public partial class CnpjRepresentanteLegal : IEquatable<CnpjRepresentanteLegal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjRepresentanteLegal" /> class.
        /// </summary>
        /// <param name="cpf">Número do cpf do representante legal..</param>
        /// <param name="nome">Nome do representante legal..</param>
        /// <param name="qualificacao">qualificacao.</param>
        public CnpjRepresentanteLegal(string cpf = default(string), string nome = default(string), CnpjQualificacaoSocio qualificacao = default(CnpjQualificacaoSocio))
        {
            this.cpf = cpf;
            this.nome = nome;
            this.qualificacao = qualificacao;
        }

        /// <summary>
        /// Número do cpf do representante legal.
        /// </summary>
        /// <value>Número do cpf do representante legal.</value>
        [DataMember(Name = "cpf", EmitDefaultValue = false)]
        public string cpf { get; set; }

        /// <summary>
        /// Nome do representante legal.
        /// </summary>
        /// <value>Nome do representante legal.</value>
        [DataMember(Name = "nome", EmitDefaultValue = false)]
        public string nome { get; set; }

        /// <summary>
        /// Gets or Sets qualificacao
        /// </summary>
        [DataMember(Name = "qualificacao", EmitDefaultValue = false)]
        public CnpjQualificacaoSocio qualificacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjRepresentanteLegal {\n");
            sb.Append("  cpf: ").Append(cpf).Append("\n");
            sb.Append("  nome: ").Append(nome).Append("\n");
            sb.Append("  qualificacao: ").Append(qualificacao).Append("\n");
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
            return this.Equals(input as CnpjRepresentanteLegal);
        }

        /// <summary>
        /// Returns true if CnpjRepresentanteLegal instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjRepresentanteLegal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjRepresentanteLegal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cpf == input.cpf ||
                    (this.cpf != null &&
                    this.cpf.Equals(input.cpf))
                ) && 
                (
                    this.nome == input.nome ||
                    (this.nome != null &&
                    this.nome.Equals(input.nome))
                ) && 
                (
                    this.qualificacao == input.qualificacao ||
                    (this.qualificacao != null &&
                    this.qualificacao.Equals(input.qualificacao))
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
                if (this.cpf != null)
                {
                    hashCode = (hashCode * 59) + this.cpf.GetHashCode();
                }
                if (this.nome != null)
                {
                    hashCode = (hashCode * 59) + this.nome.GetHashCode();
                }
                if (this.qualificacao != null)
                {
                    hashCode = (hashCode * 59) + this.qualificacao.GetHashCode();
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
