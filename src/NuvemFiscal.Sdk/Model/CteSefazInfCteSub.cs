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
    /// CteSefazInfCteSub
    /// </summary>
    [DataContract(Name = "CteSefazInfCteSub")]
    public partial class CteSefazInfCteSub : IEquatable<CteSefazInfCteSub>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCteSub" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfCteSub() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCteSub" /> class.
        /// </summary>
        /// <param name="chCte">Chave de acesso do CT-e a ser substituído (original). (required).</param>
        /// <param name="refCteAnu">Chave de acesso do CT-e de Anulação..</param>
        /// <param name="tomaICMS">tomaICMS.</param>
        /// <param name="indAlteraToma">Indicador de CT-e Alteração de Tomador..</param>
        public CteSefazInfCteSub(string chCte = default(string), string refCteAnu = default(string), CteSefazTomaICMS tomaICMS = default(CteSefazTomaICMS), int indAlteraToma = default(int))
        {
            // to ensure "chCte" is required (not null)
            if (chCte == null)
            {
                throw new ArgumentNullException("chCte is a required property for CteSefazInfCteSub and cannot be null");
            }
            this.chCte = chCte;
            this.refCteAnu = refCteAnu;
            this.tomaICMS = tomaICMS;
            this.indAlteraToma = indAlteraToma;
        }

        /// <summary>
        /// Chave de acesso do CT-e a ser substituído (original).
        /// </summary>
        /// <value>Chave de acesso do CT-e a ser substituído (original).</value>
        [DataMember(Name = "chCte", IsRequired = true, EmitDefaultValue = true)]
        public string chCte { get; set; }

        /// <summary>
        /// Chave de acesso do CT-e de Anulação.
        /// </summary>
        /// <value>Chave de acesso do CT-e de Anulação.</value>
        [DataMember(Name = "refCteAnu", EmitDefaultValue = false)]
        public string refCteAnu { get; set; }

        /// <summary>
        /// Gets or Sets tomaICMS
        /// </summary>
        [DataMember(Name = "tomaICMS", EmitDefaultValue = false)]
        public CteSefazTomaICMS tomaICMS { get; set; }

        /// <summary>
        /// Indicador de CT-e Alteração de Tomador.
        /// </summary>
        /// <value>Indicador de CT-e Alteração de Tomador.</value>
        [DataMember(Name = "indAlteraToma", EmitDefaultValue = false)]
        public int indAlteraToma { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfCteSub {\n");
            sb.Append("  chCte: ").Append(chCte).Append("\n");
            sb.Append("  refCteAnu: ").Append(refCteAnu).Append("\n");
            sb.Append("  tomaICMS: ").Append(tomaICMS).Append("\n");
            sb.Append("  indAlteraToma: ").Append(indAlteraToma).Append("\n");
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
            return this.Equals(input as CteSefazInfCteSub);
        }

        /// <summary>
        /// Returns true if CteSefazInfCteSub instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfCteSub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfCteSub input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCte == input.chCte ||
                    (this.chCte != null &&
                    this.chCte.Equals(input.chCte))
                ) && 
                (
                    this.refCteAnu == input.refCteAnu ||
                    (this.refCteAnu != null &&
                    this.refCteAnu.Equals(input.refCteAnu))
                ) && 
                (
                    this.tomaICMS == input.tomaICMS ||
                    (this.tomaICMS != null &&
                    this.tomaICMS.Equals(input.tomaICMS))
                ) && 
                (
                    this.indAlteraToma == input.indAlteraToma ||
                    this.indAlteraToma.Equals(input.indAlteraToma)
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
                if (this.chCte != null)
                {
                    hashCode = (hashCode * 59) + this.chCte.GetHashCode();
                }
                if (this.refCteAnu != null)
                {
                    hashCode = (hashCode * 59) + this.refCteAnu.GetHashCode();
                }
                if (this.tomaICMS != null)
                {
                    hashCode = (hashCode * 59) + this.tomaICMS.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.indAlteraToma.GetHashCode();
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
