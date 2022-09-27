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
    /// MdfeSefazInfMunCarrega
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMunCarrega")]
    public partial class MdfeSefazInfMunCarrega : IEquatable<MdfeSefazInfMunCarrega>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMunCarrega" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfMunCarrega() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMunCarrega" /> class.
        /// </summary>
        /// <param name="cMunCarrega">Código do Município de Carregamento. (required).</param>
        /// <param name="xMunCarrega">Nome do Município de Carregamento. (required).</param>
        public MdfeSefazInfMunCarrega(int cMunCarrega = default(int), string xMunCarrega = default(string))
        {
            this.cMunCarrega = cMunCarrega;
            // to ensure "xMunCarrega" is required (not null)
            if (xMunCarrega == null)
            {
                throw new ArgumentNullException("xMunCarrega is a required property for MdfeSefazInfMunCarrega and cannot be null");
            }
            this.xMunCarrega = xMunCarrega;
        }

        /// <summary>
        /// Código do Município de Carregamento.
        /// </summary>
        /// <value>Código do Município de Carregamento.</value>
        [DataMember(Name = "cMunCarrega", IsRequired = true, EmitDefaultValue = true)]
        public int cMunCarrega { get; set; }

        /// <summary>
        /// Nome do Município de Carregamento.
        /// </summary>
        /// <value>Nome do Município de Carregamento.</value>
        [DataMember(Name = "xMunCarrega", IsRequired = true, EmitDefaultValue = true)]
        public string xMunCarrega { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMunCarrega {\n");
            sb.Append("  cMunCarrega: ").Append(cMunCarrega).Append("\n");
            sb.Append("  xMunCarrega: ").Append(xMunCarrega).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMunCarrega);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMunCarrega instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMunCarrega to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMunCarrega input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cMunCarrega == input.cMunCarrega ||
                    this.cMunCarrega.Equals(input.cMunCarrega)
                ) && 
                (
                    this.xMunCarrega == input.xMunCarrega ||
                    (this.xMunCarrega != null &&
                    this.xMunCarrega.Equals(input.xMunCarrega))
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
                hashCode = (hashCode * 59) + this.cMunCarrega.GetHashCode();
                if (this.xMunCarrega != null)
                {
                    hashCode = (hashCode * 59) + this.xMunCarrega.GetHashCode();
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
