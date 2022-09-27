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
    /// CteInfCorrecao
    /// </summary>
    [DataContract(Name = "CteInfCorrecao")]
    public partial class CteInfCorrecao : IEquatable<CteInfCorrecao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteInfCorrecao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteInfCorrecao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteInfCorrecao" /> class.
        /// </summary>
        /// <param name="grupoAlterado">Indicar o grupo de informações que pertence o \&quot;campo_alterado\&quot;. Ex: ide. (required).</param>
        /// <param name="campoAlterado">Nome do campo modificado do CT-e Original. (required).</param>
        /// <param name="valorAlterado">Valor correspondente à alteração. (required).</param>
        /// <param name="numeroItemAlterado">Preencher com o indice do item alterado caso a alteração ocorra em uma lista.  OBS: O indice inicia sempre em 1..</param>
        public CteInfCorrecao(string grupoAlterado = default(string), string campoAlterado = default(string), string valorAlterado = default(string), int numeroItemAlterado = default(int))
        {
            // to ensure "grupoAlterado" is required (not null)
            if (grupoAlterado == null)
            {
                throw new ArgumentNullException("grupoAlterado is a required property for CteInfCorrecao and cannot be null");
            }
            this.grupo_alterado = grupoAlterado;
            // to ensure "campoAlterado" is required (not null)
            if (campoAlterado == null)
            {
                throw new ArgumentNullException("campoAlterado is a required property for CteInfCorrecao and cannot be null");
            }
            this.campo_alterado = campoAlterado;
            // to ensure "valorAlterado" is required (not null)
            if (valorAlterado == null)
            {
                throw new ArgumentNullException("valorAlterado is a required property for CteInfCorrecao and cannot be null");
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
        /// Nome do campo modificado do CT-e Original.
        /// </summary>
        /// <value>Nome do campo modificado do CT-e Original.</value>
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
        [DataMember(Name = "numero_item_alterado", EmitDefaultValue = false)]
        public int numero_item_alterado { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteInfCorrecao {\n");
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
            return this.Equals(input as CteInfCorrecao);
        }

        /// <summary>
        /// Returns true if CteInfCorrecao instances are equal
        /// </summary>
        /// <param name="input">Instance of CteInfCorrecao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteInfCorrecao input)
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
                    this.numero_item_alterado.Equals(input.numero_item_alterado)
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
                hashCode = (hashCode * 59) + this.numero_item_alterado.GetHashCode();
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
