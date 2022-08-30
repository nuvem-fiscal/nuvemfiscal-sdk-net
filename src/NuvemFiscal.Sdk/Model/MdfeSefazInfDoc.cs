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
    /// MdfeSefazInfDoc
    /// </summary>
    [DataContract(Name = "MdfeSefazInfDoc")]
    public partial class MdfeSefazInfDoc : IEquatable<MdfeSefazInfDoc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfDoc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfDoc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfDoc" /> class.
        /// </summary>
        /// <param name="infMunDescarga">Informações dos Municípios de descarregamento. (required).</param>
        public MdfeSefazInfDoc(List<MdfeSefazInfMunDescarga> infMunDescarga = default(List<MdfeSefazInfMunDescarga>))
        {
            // to ensure "infMunDescarga" is required (not null)
            if (infMunDescarga == null)
            {
                throw new ArgumentNullException("infMunDescarga is a required property for MdfeSefazInfDoc and cannot be null");
            }
            this.infMunDescarga = infMunDescarga;
        }

        /// <summary>
        /// Informações dos Municípios de descarregamento.
        /// </summary>
        /// <value>Informações dos Municípios de descarregamento.</value>
        [DataMember(Name = "infMunDescarga", IsRequired = true, EmitDefaultValue = false)]
        public List<MdfeSefazInfMunDescarga> infMunDescarga { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfDoc {\n");
            sb.Append("  infMunDescarga: ").Append(infMunDescarga).Append("\n");
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
            return this.Equals(input as MdfeSefazInfDoc);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfDoc instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfDoc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfDoc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infMunDescarga == input.infMunDescarga ||
                    this.infMunDescarga != null &&
                    input.infMunDescarga != null &&
                    this.infMunDescarga.SequenceEqual(input.infMunDescarga)
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
                if (this.infMunDescarga != null)
                {
                    hashCode = (hashCode * 59) + this.infMunDescarga.GetHashCode();
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
