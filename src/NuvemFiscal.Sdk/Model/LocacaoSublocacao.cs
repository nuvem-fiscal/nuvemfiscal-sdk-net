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
    /// Grupo de informações relativas a atividades de Locação, sublocação, arrendamento, direito de passagem ou permissão de uso, compartilhado ou não, de ferrovia, rodovia, postes, cabos, dutos e condutos de qualquer natureza.
    /// </summary>
    [DataContract(Name = "LocacaoSublocacao")]
    public partial class LocacaoSublocacao : IEquatable<LocacaoSublocacao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocacaoSublocacao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocacaoSublocacao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocacaoSublocacao" /> class.
        /// </summary>
        /// <param name="categ">Categoria do serviço. (required).</param>
        /// <param name="objeto">Tipo de objetos da locação, sublocação, arrendamento, direito de passagem ou permissão de uso. (required).</param>
        /// <param name="extensao">Extensão total da ferrovia, rodovia, cabos, dutos ou condutos. (required).</param>
        /// <param name="nPostes">Número total de postes. (required).</param>
        public LocacaoSublocacao(int? categ = default(int?), int? objeto = default(int?), string extensao = default(string), string nPostes = default(string))
        {
            // to ensure "categ" is required (not null)
            if (categ == null)
            {
                throw new ArgumentNullException("categ is a required property for LocacaoSublocacao and cannot be null");
            }
            this.categ = categ;
            // to ensure "objeto" is required (not null)
            if (objeto == null)
            {
                throw new ArgumentNullException("objeto is a required property for LocacaoSublocacao and cannot be null");
            }
            this.objeto = objeto;
            // to ensure "extensao" is required (not null)
            if (extensao == null)
            {
                throw new ArgumentNullException("extensao is a required property for LocacaoSublocacao and cannot be null");
            }
            this.extensao = extensao;
            // to ensure "nPostes" is required (not null)
            if (nPostes == null)
            {
                throw new ArgumentNullException("nPostes is a required property for LocacaoSublocacao and cannot be null");
            }
            this.nPostes = nPostes;
        }

        /// <summary>
        /// Categoria do serviço.
        /// </summary>
        /// <value>Categoria do serviço.</value>
        [DataMember(Name = "categ", IsRequired = true, EmitDefaultValue = true)]
        public int? categ { get; set; }

        /// <summary>
        /// Tipo de objetos da locação, sublocação, arrendamento, direito de passagem ou permissão de uso.
        /// </summary>
        /// <value>Tipo de objetos da locação, sublocação, arrendamento, direito de passagem ou permissão de uso.</value>
        [DataMember(Name = "objeto", IsRequired = true, EmitDefaultValue = true)]
        public int? objeto { get; set; }

        /// <summary>
        /// Extensão total da ferrovia, rodovia, cabos, dutos ou condutos.
        /// </summary>
        /// <value>Extensão total da ferrovia, rodovia, cabos, dutos ou condutos.</value>
        [DataMember(Name = "extensao", IsRequired = true, EmitDefaultValue = true)]
        public string extensao { get; set; }

        /// <summary>
        /// Número total de postes.
        /// </summary>
        /// <value>Número total de postes.</value>
        [DataMember(Name = "nPostes", IsRequired = true, EmitDefaultValue = true)]
        public string nPostes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocacaoSublocacao {\n");
            sb.Append("  categ: ").Append(categ).Append("\n");
            sb.Append("  objeto: ").Append(objeto).Append("\n");
            sb.Append("  extensao: ").Append(extensao).Append("\n");
            sb.Append("  nPostes: ").Append(nPostes).Append("\n");
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
            return this.Equals(input as LocacaoSublocacao);
        }

        /// <summary>
        /// Returns true if LocacaoSublocacao instances are equal
        /// </summary>
        /// <param name="input">Instance of LocacaoSublocacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocacaoSublocacao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.categ == input.categ ||
                    (this.categ != null &&
                    this.categ.Equals(input.categ))
                ) && 
                (
                    this.objeto == input.objeto ||
                    (this.objeto != null &&
                    this.objeto.Equals(input.objeto))
                ) && 
                (
                    this.extensao == input.extensao ||
                    (this.extensao != null &&
                    this.extensao.Equals(input.extensao))
                ) && 
                (
                    this.nPostes == input.nPostes ||
                    (this.nPostes != null &&
                    this.nPostes.Equals(input.nPostes))
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
                if (this.categ != null)
                {
                    hashCode = (hashCode * 59) + this.categ.GetHashCode();
                }
                if (this.objeto != null)
                {
                    hashCode = (hashCode * 59) + this.objeto.GetHashCode();
                }
                if (this.extensao != null)
                {
                    hashCode = (hashCode * 59) + this.extensao.GetHashCode();
                }
                if (this.nPostes != null)
                {
                    hashCode = (hashCode * 59) + this.nPostes.GetHashCode();
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
            // extensao (string) maxLength
            if (this.extensao != null && this.extensao.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for extensao, length must be less than 5.", new [] { "extensao" });
            }

            // extensao (string) minLength
            if (this.extensao != null && this.extensao.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for extensao, length must be greater than 1.", new [] { "extensao" });
            }

            // nPostes (string) maxLength
            if (this.nPostes != null && this.nPostes.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nPostes, length must be less than 6.", new [] { "nPostes" });
            }

            // nPostes (string) minLength
            if (this.nPostes != null && this.nPostes.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nPostes, length must be greater than 1.", new [] { "nPostes" });
            }

            yield break;
        }
    }

}
