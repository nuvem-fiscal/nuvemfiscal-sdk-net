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
    /// Grupo de informações do CT-e Normal e Substituto.
    /// </summary>
    [DataContract(Name = "CteSefazInfCTeNorm")]
    public partial class CteSefazInfCTeNorm : IEquatable<CteSefazInfCTeNorm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCTeNorm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfCTeNorm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfCTeNorm" /> class.
        /// </summary>
        /// <param name="infCarga">infCarga (required).</param>
        /// <param name="infDoc">infDoc.</param>
        /// <param name="docAnt">docAnt.</param>
        /// <param name="infModal">infModal (required).</param>
        /// <param name="veicNovos">veicNovos.</param>
        /// <param name="cobr">cobr.</param>
        /// <param name="infCteSub">infCteSub.</param>
        /// <param name="infGlobalizado">infGlobalizado.</param>
        /// <param name="infServVinc">infServVinc.</param>
        public CteSefazInfCTeNorm(CteSefazInfCarga infCarga = default(CteSefazInfCarga), CteSefazInfDoc infDoc = default(CteSefazInfDoc), CteSefazDocAnt docAnt = default(CteSefazDocAnt), CteSefazInfModal infModal = default(CteSefazInfModal), List<CteSefazVeicNovos> veicNovos = default(List<CteSefazVeicNovos>), CteSefazCobr cobr = default(CteSefazCobr), CteSefazInfCteSub infCteSub = default(CteSefazInfCteSub), CteSefazInfGlobalizado infGlobalizado = default(CteSefazInfGlobalizado), CteSefazInfServVinc infServVinc = default(CteSefazInfServVinc))
        {
            // to ensure "infCarga" is required (not null)
            if (infCarga == null)
            {
                throw new ArgumentNullException("infCarga is a required property for CteSefazInfCTeNorm and cannot be null");
            }
            this.infCarga = infCarga;
            // to ensure "infModal" is required (not null)
            if (infModal == null)
            {
                throw new ArgumentNullException("infModal is a required property for CteSefazInfCTeNorm and cannot be null");
            }
            this.infModal = infModal;
            this.infDoc = infDoc;
            this.docAnt = docAnt;
            this.veicNovos = veicNovos;
            this.cobr = cobr;
            this.infCteSub = infCteSub;
            this.infGlobalizado = infGlobalizado;
            this.infServVinc = infServVinc;
        }

        /// <summary>
        /// Gets or Sets infCarga
        /// </summary>
        [DataMember(Name = "infCarga", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazInfCarga infCarga { get; set; }

        /// <summary>
        /// Gets or Sets infDoc
        /// </summary>
        [DataMember(Name = "infDoc", EmitDefaultValue = false)]
        public CteSefazInfDoc infDoc { get; set; }

        /// <summary>
        /// Gets or Sets docAnt
        /// </summary>
        [DataMember(Name = "docAnt", EmitDefaultValue = false)]
        public CteSefazDocAnt docAnt { get; set; }

        /// <summary>
        /// Gets or Sets infModal
        /// </summary>
        [DataMember(Name = "infModal", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazInfModal infModal { get; set; }

        /// <summary>
        /// Gets or Sets veicNovos
        /// </summary>
        [DataMember(Name = "veicNovos", EmitDefaultValue = false)]
        public List<CteSefazVeicNovos> veicNovos { get; set; }

        /// <summary>
        /// Gets or Sets cobr
        /// </summary>
        [DataMember(Name = "cobr", EmitDefaultValue = false)]
        public CteSefazCobr cobr { get; set; }

        /// <summary>
        /// Gets or Sets infCteSub
        /// </summary>
        [DataMember(Name = "infCteSub", EmitDefaultValue = false)]
        public CteSefazInfCteSub infCteSub { get; set; }

        /// <summary>
        /// Gets or Sets infGlobalizado
        /// </summary>
        [DataMember(Name = "infGlobalizado", EmitDefaultValue = false)]
        public CteSefazInfGlobalizado infGlobalizado { get; set; }

        /// <summary>
        /// Gets or Sets infServVinc
        /// </summary>
        [DataMember(Name = "infServVinc", EmitDefaultValue = false)]
        public CteSefazInfServVinc infServVinc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfCTeNorm {\n");
            sb.Append("  infCarga: ").Append(infCarga).Append("\n");
            sb.Append("  infDoc: ").Append(infDoc).Append("\n");
            sb.Append("  docAnt: ").Append(docAnt).Append("\n");
            sb.Append("  infModal: ").Append(infModal).Append("\n");
            sb.Append("  veicNovos: ").Append(veicNovos).Append("\n");
            sb.Append("  cobr: ").Append(cobr).Append("\n");
            sb.Append("  infCteSub: ").Append(infCteSub).Append("\n");
            sb.Append("  infGlobalizado: ").Append(infGlobalizado).Append("\n");
            sb.Append("  infServVinc: ").Append(infServVinc).Append("\n");
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
            return this.Equals(input as CteSefazInfCTeNorm);
        }

        /// <summary>
        /// Returns true if CteSefazInfCTeNorm instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfCTeNorm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfCTeNorm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infCarga == input.infCarga ||
                    (this.infCarga != null &&
                    this.infCarga.Equals(input.infCarga))
                ) && 
                (
                    this.infDoc == input.infDoc ||
                    (this.infDoc != null &&
                    this.infDoc.Equals(input.infDoc))
                ) && 
                (
                    this.docAnt == input.docAnt ||
                    (this.docAnt != null &&
                    this.docAnt.Equals(input.docAnt))
                ) && 
                (
                    this.infModal == input.infModal ||
                    (this.infModal != null &&
                    this.infModal.Equals(input.infModal))
                ) && 
                (
                    this.veicNovos == input.veicNovos ||
                    this.veicNovos != null &&
                    input.veicNovos != null &&
                    this.veicNovos.SequenceEqual(input.veicNovos)
                ) && 
                (
                    this.cobr == input.cobr ||
                    (this.cobr != null &&
                    this.cobr.Equals(input.cobr))
                ) && 
                (
                    this.infCteSub == input.infCteSub ||
                    (this.infCteSub != null &&
                    this.infCteSub.Equals(input.infCteSub))
                ) && 
                (
                    this.infGlobalizado == input.infGlobalizado ||
                    (this.infGlobalizado != null &&
                    this.infGlobalizado.Equals(input.infGlobalizado))
                ) && 
                (
                    this.infServVinc == input.infServVinc ||
                    (this.infServVinc != null &&
                    this.infServVinc.Equals(input.infServVinc))
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
                if (this.infCarga != null)
                {
                    hashCode = (hashCode * 59) + this.infCarga.GetHashCode();
                }
                if (this.infDoc != null)
                {
                    hashCode = (hashCode * 59) + this.infDoc.GetHashCode();
                }
                if (this.docAnt != null)
                {
                    hashCode = (hashCode * 59) + this.docAnt.GetHashCode();
                }
                if (this.infModal != null)
                {
                    hashCode = (hashCode * 59) + this.infModal.GetHashCode();
                }
                if (this.veicNovos != null)
                {
                    hashCode = (hashCode * 59) + this.veicNovos.GetHashCode();
                }
                if (this.cobr != null)
                {
                    hashCode = (hashCode * 59) + this.cobr.GetHashCode();
                }
                if (this.infCteSub != null)
                {
                    hashCode = (hashCode * 59) + this.infCteSub.GetHashCode();
                }
                if (this.infGlobalizado != null)
                {
                    hashCode = (hashCode * 59) + this.infGlobalizado.GetHashCode();
                }
                if (this.infServVinc != null)
                {
                    hashCode = (hashCode * 59) + this.infServVinc.GetHashCode();
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
