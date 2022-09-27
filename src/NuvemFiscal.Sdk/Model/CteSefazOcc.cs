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
    /// CteSefazOcc
    /// </summary>
    [DataContract(Name = "CteSefazOcc")]
    public partial class CteSefazOcc : IEquatable<CteSefazOcc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazOcc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazOcc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazOcc" /> class.
        /// </summary>
        /// <param name="serie">Série da OCC..</param>
        /// <param name="nOcc">Número da Ordem de coleta. (required).</param>
        /// <param name="dEmi">Data de emissão da ordem de coleta.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="emiOcc">emiOcc.</param>
        public CteSefazOcc(string serie = default(string), int nOcc = default(int), DateTime dEmi = default(DateTime), CteSefazEmiOcc emiOcc = default(CteSefazEmiOcc))
        {
            this.nOcc = nOcc;
            this.dEmi = dEmi;
            this.serie = serie;
            this.emiOcc = emiOcc;
        }

        /// <summary>
        /// Série da OCC.
        /// </summary>
        /// <value>Série da OCC.</value>
        [DataMember(Name = "serie", EmitDefaultValue = false)]
        public string serie { get; set; }

        /// <summary>
        /// Número da Ordem de coleta.
        /// </summary>
        /// <value>Número da Ordem de coleta.</value>
        [DataMember(Name = "nOcc", IsRequired = true, EmitDefaultValue = true)]
        public int nOcc { get; set; }

        /// <summary>
        /// Data de emissão da ordem de coleta.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de emissão da ordem de coleta.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dEmi", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Gets or Sets emiOcc
        /// </summary>
        [DataMember(Name = "emiOcc", EmitDefaultValue = false)]
        public CteSefazEmiOcc emiOcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazOcc {\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nOcc: ").Append(nOcc).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
            sb.Append("  emiOcc: ").Append(emiOcc).Append("\n");
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
            return this.Equals(input as CteSefazOcc);
        }

        /// <summary>
        /// Returns true if CteSefazOcc instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazOcc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazOcc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nOcc == input.nOcc ||
                    this.nOcc.Equals(input.nOcc)
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
                ) && 
                (
                    this.emiOcc == input.emiOcc ||
                    (this.emiOcc != null &&
                    this.emiOcc.Equals(input.emiOcc))
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
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.nOcc.GetHashCode();
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
                }
                if (this.emiOcc != null)
                {
                    hashCode = (hashCode * 59) + this.emiOcc.GetHashCode();
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
