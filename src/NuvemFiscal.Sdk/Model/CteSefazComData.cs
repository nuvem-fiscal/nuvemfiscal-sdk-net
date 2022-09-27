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
    /// CteSefazComData
    /// </summary>
    [DataContract(Name = "CteSefazComData")]
    public partial class CteSefazComData : IEquatable<CteSefazComData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazComData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazComData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazComData" /> class.
        /// </summary>
        /// <param name="tpPer">Tipo de data/período programado para entrega.  Preencher com:                    1-Na data;                    2-Até a data;                    3-A partir da data. (required).</param>
        /// <param name="dProg">Data programada.  Formato AAAA-MM-DD. (required).</param>
        public CteSefazComData(int tpPer = default(int), DateTime dProg = default(DateTime))
        {
            this.tpPer = tpPer;
            this.dProg = dProg;
        }

        /// <summary>
        /// Tipo de data/período programado para entrega.  Preencher com:                    1-Na data;                    2-Até a data;                    3-A partir da data.
        /// </summary>
        /// <value>Tipo de data/período programado para entrega.  Preencher com:                    1-Na data;                    2-Até a data;                    3-A partir da data.</value>
        [DataMember(Name = "tpPer", IsRequired = true, EmitDefaultValue = true)]
        public int tpPer { get; set; }

        /// <summary>
        /// Data programada.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data programada.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dProg", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dProg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazComData {\n");
            sb.Append("  tpPer: ").Append(tpPer).Append("\n");
            sb.Append("  dProg: ").Append(dProg).Append("\n");
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
            return this.Equals(input as CteSefazComData);
        }

        /// <summary>
        /// Returns true if CteSefazComData instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazComData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazComData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpPer == input.tpPer ||
                    this.tpPer.Equals(input.tpPer)
                ) && 
                (
                    this.dProg == input.dProg ||
                    (this.dProg != null &&
                    this.dProg.Equals(input.dProg))
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
                hashCode = (hashCode * 59) + this.tpPer.GetHashCode();
                if (this.dProg != null)
                {
                    hashCode = (hashCode * 59) + this.dProg.GetHashCode();
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
