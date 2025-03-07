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
    /// Informações do modal Rodoviário.
    /// </summary>
    [DataContract(Name = "CteSefazRodo")]
    public partial class CteSefazRodo : IEquatable<CteSefazRodo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazRodo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazRodo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazRodo" /> class.
        /// </summary>
        /// <param name="rNTRC">Registro Nacional de Transportadores Rodoviários de Carga.  Registro obrigatório do emitente do CT-e junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração. (required).</param>
        /// <param name="occ">occ.</param>
        public CteSefazRodo(string rNTRC = default(string), List<CteSefazOcc> occ = default(List<CteSefazOcc>))
        {
            // to ensure "rNTRC" is required (not null)
            if (rNTRC == null)
            {
                throw new ArgumentNullException("rNTRC is a required property for CteSefazRodo and cannot be null");
            }
            this.RNTRC = rNTRC;
            this.occ = occ;
        }

        /// <summary>
        /// Registro Nacional de Transportadores Rodoviários de Carga.  Registro obrigatório do emitente do CT-e junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração.
        /// </summary>
        /// <value>Registro Nacional de Transportadores Rodoviários de Carga.  Registro obrigatório do emitente do CT-e junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração.</value>
        [DataMember(Name = "RNTRC", IsRequired = true, EmitDefaultValue = true)]
        public string RNTRC { get; set; }

        /// <summary>
        /// Gets or Sets occ
        /// </summary>
        [DataMember(Name = "occ", EmitDefaultValue = false)]
        public List<CteSefazOcc> occ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazRodo {\n");
            sb.Append("  RNTRC: ").Append(RNTRC).Append("\n");
            sb.Append("  occ: ").Append(occ).Append("\n");
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
            return this.Equals(input as CteSefazRodo);
        }

        /// <summary>
        /// Returns true if CteSefazRodo instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazRodo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazRodo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RNTRC == input.RNTRC ||
                    (this.RNTRC != null &&
                    this.RNTRC.Equals(input.RNTRC))
                ) && 
                (
                    this.occ == input.occ ||
                    this.occ != null &&
                    input.occ != null &&
                    this.occ.SequenceEqual(input.occ)
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
                if (this.RNTRC != null)
                {
                    hashCode = (hashCode * 59) + this.RNTRC.GetHashCode();
                }
                if (this.occ != null)
                {
                    hashCode = (hashCode * 59) + this.occ.GetHashCode();
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
