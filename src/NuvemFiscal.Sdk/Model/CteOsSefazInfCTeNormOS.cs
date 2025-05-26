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
    /// Grupo de informações do CT-e OS Normal.
    /// </summary>
    [DataContract(Name = "CteOsSefazInfCTeNormOS")]
    public partial class CteOsSefazInfCTeNormOS : IEquatable<CteOsSefazInfCTeNormOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCTeNormOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazInfCTeNormOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazInfCTeNormOS" /> class.
        /// </summary>
        /// <param name="infServico">infServico (required).</param>
        /// <param name="infDocRef">infDocRef.</param>
        /// <param name="seg">seg.</param>
        /// <param name="infModal">infModal.</param>
        /// <param name="infCteSub">infCteSub.</param>
        /// <param name="refCTeCanc">Chave de acesso do CT-e Cancelado  Somente para Transporte de Valores..</param>
        /// <param name="cobr">cobr.</param>
        /// <param name="infGTVe">infGTVe.</param>
        public CteOsSefazInfCTeNormOS(CteOsSefazInfServicoOS infServico = default(CteOsSefazInfServicoOS), List<CteOsSefazInfDocRefOS> infDocRef = default(List<CteOsSefazInfDocRefOS>), List<CteOsSefazSegOS> seg = default(List<CteOsSefazSegOS>), CteOsSefazInfModalOS infModal = default(CteOsSefazInfModalOS), CteOsSefazInfCteSubOS infCteSub = default(CteOsSefazInfCteSubOS), string refCTeCanc = default(string), CteOsSefazCobrOS cobr = default(CteOsSefazCobrOS), List<CteOsSefazInfGTVeOS> infGTVe = default(List<CteOsSefazInfGTVeOS>))
        {
            // to ensure "infServico" is required (not null)
            if (infServico == null)
            {
                throw new ArgumentNullException("infServico is a required property for CteOsSefazInfCTeNormOS and cannot be null");
            }
            this.infServico = infServico;
            this.infDocRef = infDocRef;
            this.seg = seg;
            this.infModal = infModal;
            this.infCteSub = infCteSub;
            this.refCTeCanc = refCTeCanc;
            this.cobr = cobr;
            this.infGTVe = infGTVe;
        }

        /// <summary>
        /// Gets or Sets infServico
        /// </summary>
        [DataMember(Name = "infServico", IsRequired = true, EmitDefaultValue = true)]
        public CteOsSefazInfServicoOS infServico { get; set; }

        /// <summary>
        /// Gets or Sets infDocRef
        /// </summary>
        [DataMember(Name = "infDocRef", EmitDefaultValue = false)]
        public List<CteOsSefazInfDocRefOS> infDocRef { get; set; }

        /// <summary>
        /// Gets or Sets seg
        /// </summary>
        [DataMember(Name = "seg", EmitDefaultValue = false)]
        public List<CteOsSefazSegOS> seg { get; set; }

        /// <summary>
        /// Gets or Sets infModal
        /// </summary>
        [DataMember(Name = "infModal", EmitDefaultValue = false)]
        public CteOsSefazInfModalOS infModal { get; set; }

        /// <summary>
        /// Gets or Sets infCteSub
        /// </summary>
        [DataMember(Name = "infCteSub", EmitDefaultValue = false)]
        public CteOsSefazInfCteSubOS infCteSub { get; set; }

        /// <summary>
        /// Chave de acesso do CT-e Cancelado  Somente para Transporte de Valores.
        /// </summary>
        /// <value>Chave de acesso do CT-e Cancelado  Somente para Transporte de Valores.</value>
        [DataMember(Name = "refCTeCanc", EmitDefaultValue = true)]
        public string refCTeCanc { get; set; }

        /// <summary>
        /// Gets or Sets cobr
        /// </summary>
        [DataMember(Name = "cobr", EmitDefaultValue = false)]
        public CteOsSefazCobrOS cobr { get; set; }

        /// <summary>
        /// Gets or Sets infGTVe
        /// </summary>
        [DataMember(Name = "infGTVe", EmitDefaultValue = false)]
        public List<CteOsSefazInfGTVeOS> infGTVe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazInfCTeNormOS {\n");
            sb.Append("  infServico: ").Append(infServico).Append("\n");
            sb.Append("  infDocRef: ").Append(infDocRef).Append("\n");
            sb.Append("  seg: ").Append(seg).Append("\n");
            sb.Append("  infModal: ").Append(infModal).Append("\n");
            sb.Append("  infCteSub: ").Append(infCteSub).Append("\n");
            sb.Append("  refCTeCanc: ").Append(refCTeCanc).Append("\n");
            sb.Append("  cobr: ").Append(cobr).Append("\n");
            sb.Append("  infGTVe: ").Append(infGTVe).Append("\n");
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
            return this.Equals(input as CteOsSefazInfCTeNormOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazInfCTeNormOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazInfCTeNormOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazInfCTeNormOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infServico == input.infServico ||
                    (this.infServico != null &&
                    this.infServico.Equals(input.infServico))
                ) && 
                (
                    this.infDocRef == input.infDocRef ||
                    this.infDocRef != null &&
                    input.infDocRef != null &&
                    this.infDocRef.SequenceEqual(input.infDocRef)
                ) && 
                (
                    this.seg == input.seg ||
                    this.seg != null &&
                    input.seg != null &&
                    this.seg.SequenceEqual(input.seg)
                ) && 
                (
                    this.infModal == input.infModal ||
                    (this.infModal != null &&
                    this.infModal.Equals(input.infModal))
                ) && 
                (
                    this.infCteSub == input.infCteSub ||
                    (this.infCteSub != null &&
                    this.infCteSub.Equals(input.infCteSub))
                ) && 
                (
                    this.refCTeCanc == input.refCTeCanc ||
                    (this.refCTeCanc != null &&
                    this.refCTeCanc.Equals(input.refCTeCanc))
                ) && 
                (
                    this.cobr == input.cobr ||
                    (this.cobr != null &&
                    this.cobr.Equals(input.cobr))
                ) && 
                (
                    this.infGTVe == input.infGTVe ||
                    this.infGTVe != null &&
                    input.infGTVe != null &&
                    this.infGTVe.SequenceEqual(input.infGTVe)
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
                if (this.infServico != null)
                {
                    hashCode = (hashCode * 59) + this.infServico.GetHashCode();
                }
                if (this.infDocRef != null)
                {
                    hashCode = (hashCode * 59) + this.infDocRef.GetHashCode();
                }
                if (this.seg != null)
                {
                    hashCode = (hashCode * 59) + this.seg.GetHashCode();
                }
                if (this.infModal != null)
                {
                    hashCode = (hashCode * 59) + this.infModal.GetHashCode();
                }
                if (this.infCteSub != null)
                {
                    hashCode = (hashCode * 59) + this.infCteSub.GetHashCode();
                }
                if (this.refCTeCanc != null)
                {
                    hashCode = (hashCode * 59) + this.refCTeCanc.GetHashCode();
                }
                if (this.cobr != null)
                {
                    hashCode = (hashCode * 59) + this.cobr.GetHashCode();
                }
                if (this.infGTVe != null)
                {
                    hashCode = (hashCode * 59) + this.infGTVe.GetHashCode();
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
