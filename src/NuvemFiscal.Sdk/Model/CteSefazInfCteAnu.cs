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
    /// Detalhamento do CT-e do tipo Anulação.
    /// </summary>
    [DataContract(Name = "CteSefazInfCteAnu")]
    public partial class CteSefazInfCteAnu : IEquatable<CteSefazInfCteAnu>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCteAnu" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfCteAnu() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCteAnu" /> class.
        /// </summary>
        /// <param name="chCte">Chave de acesso do CT-e original a ser anulado e substituído. (required).</param>
        /// <param name="dEmi">Data de emissão da declaração do tomador não contribuinte do ICMS. (required).</param>
        public CteSefazInfCteAnu(string chCte = default(string), DateTime dEmi = default(DateTime))
        {
            // to ensure "chCte" is required (not null)
            if (chCte == null)
            {
                throw new ArgumentNullException("chCte is a required property for CteSefazInfCteAnu and cannot be null");
            }
            this.chCte = chCte;
            this.dEmi = dEmi;
        }

        /// <summary>
        /// Chave de acesso do CT-e original a ser anulado e substituído.
        /// </summary>
        /// <value>Chave de acesso do CT-e original a ser anulado e substituído.</value>
        [DataMember(Name = "chCte", IsRequired = true, EmitDefaultValue = true)]
        public string chCte { get; set; }

        /// <summary>
        /// Data de emissão da declaração do tomador não contribuinte do ICMS.
        /// </summary>
        /// <value>Data de emissão da declaração do tomador não contribuinte do ICMS.</value>
        [DataMember(Name = "dEmi", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfCteAnu {\n");
            sb.Append("  chCte: ").Append(chCte).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
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
            return this.Equals(input as CteSefazInfCteAnu);
        }

        /// <summary>
        /// Returns true if CteSefazInfCteAnu instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfCteAnu to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfCteAnu input)
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
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
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
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
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
