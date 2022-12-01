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
    /// CnpjPorteEmpresa
    /// </summary>
    [DataContract(Name = "CnpjPorteEmpresa")]
    public partial class CnpjPorteEmpresa : IEquatable<CnpjPorteEmpresa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CnpjPorteEmpresa" /> class.
        /// </summary>
        /// <param name="codigo">Código do porte da empresa..</param>
        /// <param name="descricao">Descrição do porte da empresa..</param>
        public CnpjPorteEmpresa(string codigo = default(string), string descricao = default(string))
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        /// <summary>
        /// Código do porte da empresa.
        /// </summary>
        /// <value>Código do porte da empresa.</value>
        [DataMember(Name = "codigo", EmitDefaultValue = false)]
        public string codigo { get; set; }

        /// <summary>
        /// Descrição do porte da empresa.
        /// </summary>
        /// <value>Descrição do porte da empresa.</value>
        [DataMember(Name = "descricao", EmitDefaultValue = false)]
        public string descricao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CnpjPorteEmpresa {\n");
            sb.Append("  codigo: ").Append(codigo).Append("\n");
            sb.Append("  descricao: ").Append(descricao).Append("\n");
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
            return this.Equals(input as CnpjPorteEmpresa);
        }

        /// <summary>
        /// Returns true if CnpjPorteEmpresa instances are equal
        /// </summary>
        /// <param name="input">Instance of CnpjPorteEmpresa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CnpjPorteEmpresa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codigo == input.codigo ||
                    (this.codigo != null &&
                    this.codigo.Equals(input.codigo))
                ) && 
                (
                    this.descricao == input.descricao ||
                    (this.descricao != null &&
                    this.descricao.Equals(input.descricao))
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
                if (this.codigo != null)
                {
                    hashCode = (hashCode * 59) + this.codigo.GetHashCode();
                }
                if (this.descricao != null)
                {
                    hashCode = (hashCode * 59) + this.descricao.GetHashCode();
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
