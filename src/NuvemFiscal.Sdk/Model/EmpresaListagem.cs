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
    /// EmpresaListagem
    /// </summary>
    [DataContract(Name = "EmpresaListagem")]
    public partial class EmpresaListagem : IEquatable<EmpresaListagem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaListagem" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="data">data.</param>
        public EmpresaListagem(int count = default(int), List<Empresa> data = default(List<Empresa>))
        {
            this.count = count;
            this.data = data;
        }

        /// <summary>
        /// Gets or Sets count
        /// </summary>
        [DataMember(Name = "@count", EmitDefaultValue = false)]
        public int count { get; set; }

        /// <summary>
        /// Gets or Sets data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<Empresa> data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaListagem {\n");
            sb.Append("  count: ").Append(count).Append("\n");
            sb.Append("  data: ").Append(data).Append("\n");
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
            return this.Equals(input as EmpresaListagem);
        }

        /// <summary>
        /// Returns true if EmpresaListagem instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaListagem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaListagem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.count == input.count ||
                    this.count.Equals(input.count)
                ) && 
                (
                    this.data == input.data ||
                    this.data != null &&
                    input.data != null &&
                    this.data.SequenceEqual(input.data)
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
                hashCode = (hashCode * 59) + this.count.GetHashCode();
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
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
