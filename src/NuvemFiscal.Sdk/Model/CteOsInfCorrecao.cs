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
    /// CteOsInfCorrecao
    /// </summary>
    [DataContract(Name = "CteOsInfCorrecao")]
    public partial class CteOsInfCorrecao : IEquatable<CteOsInfCorrecao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsInfCorrecao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsInfCorrecao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsInfCorrecao" /> class.
        /// </summary>
        /// <param name="grupoAlterado">Indicar o grupo de informações que pertence o \&quot;campo_alterado\&quot;. Ex: ide. (required).</param>
        /// <param name="campoAlterado">Nome do campo modificado do CT-e OS Original. (required).</param>
        /// <param name="valorAlterado">Valor correspondente à alteração. (required).</param>
        /// <param name="numeroItemAlterado">Preencher com o indice do item alterado caso a alteração ocorra em uma lista.  OBS: O indice inicia sempre em 1..</param>
        public CteOsInfCorrecao(string grupoAlterado = default(string), string campoAlterado = default(string), string valorAlterado = default(string), int? numeroItemAlterado = default(int?))
        {
            // to ensure "grupoAlterado" is required (not null)
            if (grupoAlterado == null)
            {
                throw new ArgumentNullException("grupoAlterado is a required property for CteOsInfCorrecao and cannot be null");
            }
            this.grupo_alterado = grupoAlterado;
            // to ensure "campoAlterado" is required (not null)
            if (campoAlterado == null)
            {
                throw new ArgumentNullException("campoAlterado is a required property for CteOsInfCorrecao and cannot be null");
            }
            this.campo_alterado = campoAlterado;
            // to ensure "valorAlterado" is required (not null)
            if (valorAlterado == null)
            {
                throw new ArgumentNullException("valorAlterado is a required property for CteOsInfCorrecao and cannot be null");
            }
            this.valor_alterado = valorAlterado;
            this.numero_item_alterado = numeroItemAlterado;
        }

        /// <summary>
        /// Indicar o grupo de informações que pertence o \&quot;campo_alterado\&quot;. Ex: ide.
        /// </summary>
        /// <value>Indicar o grupo de informações que pertence o \&quot;campo_alterado\&quot;. Ex: ide.</value>
        [DataMember(Name = "grupo_alterado", IsRequired = true, EmitDefaultValue = true)]
        public string grupo_alterado { get; set; }

        /// <summary>
        /// Nome do campo modificado do CT-e OS Original.
        /// </summary>
        /// <value>Nome do campo modificado do CT-e OS Original.</value>
        [DataMember(Name = "campo_alterado", IsRequired = true, EmitDefaultValue = true)]
        public string campo_alterado { get; set; }

        /// <summary>
        /// Valor correspondente à alteração.
        /// </summary>
        /// <value>Valor correspondente à alteração.</value>
        [DataMember(Name = "valor_alterado", IsRequired = true, EmitDefaultValue = true)]
        public string valor_alterado { get; set; }

        /// <summary>
        /// Preencher com o indice do item alterado caso a alteração ocorra em uma lista.  OBS: O indice inicia sempre em 1.
        /// </summary>
        /// <value>Preencher com o indice do item alterado caso a alteração ocorra em uma lista.  OBS: O indice inicia sempre em 1.</value>
        [DataMember(Name = "numero_item_alterado", EmitDefaultValue = true)]
        public int? numero_item_alterado { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsInfCorrecao {\n");
            sb.Append("  grupo_alterado: ").Append(grupo_alterado).Append("\n");
            sb.Append("  campo_alterado: ").Append(campo_alterado).Append("\n");
            sb.Append("  valor_alterado: ").Append(valor_alterado).Append("\n");
            sb.Append("  numero_item_alterado: ").Append(numero_item_alterado).Append("\n");
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
            return this.Equals(input as CteOsInfCorrecao);
        }

        /// <summary>
        /// Returns true if CteOsInfCorrecao instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsInfCorrecao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsInfCorrecao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.grupo_alterado == input.grupo_alterado ||
                    (this.grupo_alterado != null &&
                    this.grupo_alterado.Equals(input.grupo_alterado))
                ) && 
                (
                    this.campo_alterado == input.campo_alterado ||
                    (this.campo_alterado != null &&
                    this.campo_alterado.Equals(input.campo_alterado))
                ) && 
                (
                    this.valor_alterado == input.valor_alterado ||
                    (this.valor_alterado != null &&
                    this.valor_alterado.Equals(input.valor_alterado))
                ) && 
                (
                    this.numero_item_alterado == input.numero_item_alterado ||
                    (this.numero_item_alterado != null &&
                    this.numero_item_alterado.Equals(input.numero_item_alterado))
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
                if (this.grupo_alterado != null)
                {
                    hashCode = (hashCode * 59) + this.grupo_alterado.GetHashCode();
                }
                if (this.campo_alterado != null)
                {
                    hashCode = (hashCode * 59) + this.campo_alterado.GetHashCode();
                }
                if (this.valor_alterado != null)
                {
                    hashCode = (hashCode * 59) + this.valor_alterado.GetHashCode();
                }
                if (this.numero_item_alterado != null)
                {
                    hashCode = (hashCode * 59) + this.numero_item_alterado.GetHashCode();
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
            // grupo_alterado (string) maxLength
            if (this.grupo_alterado != null && this.grupo_alterado.Length > 20)
            {
                yield return new ValidationResult("Invalid value for grupo_alterado, length must be less than 20.", new [] { "grupo_alterado" });
            }

            // grupo_alterado (string) minLength
            if (this.grupo_alterado != null && this.grupo_alterado.Length < 1)
            {
                yield return new ValidationResult("Invalid value for grupo_alterado, length must be greater than 1.", new [] { "grupo_alterado" });
            }

            // campo_alterado (string) maxLength
            if (this.campo_alterado != null && this.campo_alterado.Length > 20)
            {
                yield return new ValidationResult("Invalid value for campo_alterado, length must be less than 20.", new [] { "campo_alterado" });
            }

            // campo_alterado (string) minLength
            if (this.campo_alterado != null && this.campo_alterado.Length < 1)
            {
                yield return new ValidationResult("Invalid value for campo_alterado, length must be greater than 1.", new [] { "campo_alterado" });
            }

            // valor_alterado (string) maxLength
            if (this.valor_alterado != null && this.valor_alterado.Length > 500)
            {
                yield return new ValidationResult("Invalid value for valor_alterado, length must be less than 500.", new [] { "valor_alterado" });
            }

            // valor_alterado (string) minLength
            if (this.valor_alterado != null && this.valor_alterado.Length < 1)
            {
                yield return new ValidationResult("Invalid value for valor_alterado, length must be greater than 1.", new [] { "valor_alterado" });
            }

            yield break;
        }
    }

}
