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
    /// Indicador do \&quot;papel\&quot; do tomador do serviço no CT-e.
    /// </summary>
    [DataContract(Name = "CteSefazToma3")]
    public partial class CteSefazToma3 : IEquatable<CteSefazToma3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazToma3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazToma3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazToma3" /> class.
        /// </summary>
        /// <param name="toma">Tomador do Serviço.  Preencher com:  * 0 - Remetente  * 1 - Expedidor  * 2 - Recebedor  * 3 - Destinatário  Serão utilizadas as informações contidas no respectivo grupo, conforme indicado pelo conteúdo deste campo. (required).</param>
        public CteSefazToma3(int? toma = default(int?))
        {
            // to ensure "toma" is required (not null)
            if (toma == null)
            {
                throw new ArgumentNullException("toma is a required property for CteSefazToma3 and cannot be null");
            }
            this.toma = toma;
        }

        /// <summary>
        /// Tomador do Serviço.  Preencher com:  * 0 - Remetente  * 1 - Expedidor  * 2 - Recebedor  * 3 - Destinatário  Serão utilizadas as informações contidas no respectivo grupo, conforme indicado pelo conteúdo deste campo.
        /// </summary>
        /// <value>Tomador do Serviço.  Preencher com:  * 0 - Remetente  * 1 - Expedidor  * 2 - Recebedor  * 3 - Destinatário  Serão utilizadas as informações contidas no respectivo grupo, conforme indicado pelo conteúdo deste campo.</value>
        [DataMember(Name = "toma", IsRequired = true, EmitDefaultValue = true)]
        public int? toma { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazToma3 {\n");
            sb.Append("  toma: ").Append(toma).Append("\n");
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
            return this.Equals(input as CteSefazToma3);
        }

        /// <summary>
        /// Returns true if CteSefazToma3 instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazToma3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazToma3 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.toma == input.toma ||
                    (this.toma != null &&
                    this.toma.Equals(input.toma))
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
                if (this.toma != null)
                {
                    hashCode = (hashCode * 59) + this.toma.GetHashCode();
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
