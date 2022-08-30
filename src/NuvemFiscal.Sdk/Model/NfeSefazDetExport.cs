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
    /// NfeSefazDetExport
    /// </summary>
    [DataContract(Name = "NfeSefazDetExport")]
    public partial class NfeSefazDetExport : IEquatable<NfeSefazDetExport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDetExport" /> class.
        /// </summary>
        /// <param name="nDraw">Número do ato concessório de Drawback..</param>
        /// <param name="exportInd">exportInd.</param>
        public NfeSefazDetExport(string nDraw = default(string), NfeSefazExportInd exportInd = default(NfeSefazExportInd))
        {
            this.nDraw = nDraw;
            this.exportInd = exportInd;
        }

        /// <summary>
        /// Número do ato concessório de Drawback.
        /// </summary>
        /// <value>Número do ato concessório de Drawback.</value>
        [DataMember(Name = "nDraw", EmitDefaultValue = false)]
        public string nDraw { get; set; }

        /// <summary>
        /// Gets or Sets exportInd
        /// </summary>
        [DataMember(Name = "exportInd", EmitDefaultValue = false)]
        public NfeSefazExportInd exportInd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDetExport {\n");
            sb.Append("  nDraw: ").Append(nDraw).Append("\n");
            sb.Append("  exportInd: ").Append(exportInd).Append("\n");
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
            return this.Equals(input as NfeSefazDetExport);
        }

        /// <summary>
        /// Returns true if NfeSefazDetExport instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDetExport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDetExport input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nDraw == input.nDraw ||
                    (this.nDraw != null &&
                    this.nDraw.Equals(input.nDraw))
                ) && 
                (
                    this.exportInd == input.exportInd ||
                    (this.exportInd != null &&
                    this.exportInd.Equals(input.exportInd))
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
                if (this.nDraw != null)
                {
                    hashCode = (hashCode * 59) + this.nDraw.GetHashCode();
                }
                if (this.exportInd != null)
                {
                    hashCode = (hashCode * 59) + this.exportInd.GetHashCode();
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
