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
    /// Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.  O preenchimento desses campos não desobriga a empresa aérea de emitir os demais documentos que constam na legislação vigente.
    /// </summary>
    [DataContract(Name = "CteSefazPeri")]
    public partial class CteSefazPeri : IEquatable<CteSefazPeri>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazPeri" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazPeri() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazPeri" /> class.
        /// </summary>
        /// <param name="nONU">Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal. (required).</param>
        /// <param name="qTotEmb">Quantidade total de volumes contendo artigos perigosos.  Preencher com o número de volumes (unidades) de artigos perigosos, ou seja, cada embalagem devidamente marcada e etiquetada (por ex.: número de caixas, de tambores, de bombonas, dentre outros). Não deve ser preenchido com o número de ULD, pallets ou containers. (required).</param>
        /// <param name="infTotAP">infTotAP (required).</param>
        public CteSefazPeri(string nONU = default(string), string qTotEmb = default(string), CteSefazInfTotAP infTotAP = default(CteSefazInfTotAP))
        {
            // to ensure "nONU" is required (not null)
            if (nONU == null)
            {
                throw new ArgumentNullException("nONU is a required property for CteSefazPeri and cannot be null");
            }
            this.nONU = nONU;
            // to ensure "qTotEmb" is required (not null)
            if (qTotEmb == null)
            {
                throw new ArgumentNullException("qTotEmb is a required property for CteSefazPeri and cannot be null");
            }
            this.qTotEmb = qTotEmb;
            // to ensure "infTotAP" is required (not null)
            if (infTotAP == null)
            {
                throw new ArgumentNullException("infTotAP is a required property for CteSefazPeri and cannot be null");
            }
            this.infTotAP = infTotAP;
        }

        /// <summary>
        /// Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.
        /// </summary>
        /// <value>Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.</value>
        [DataMember(Name = "nONU", IsRequired = true, EmitDefaultValue = true)]
        public string nONU { get; set; }

        /// <summary>
        /// Quantidade total de volumes contendo artigos perigosos.  Preencher com o número de volumes (unidades) de artigos perigosos, ou seja, cada embalagem devidamente marcada e etiquetada (por ex.: número de caixas, de tambores, de bombonas, dentre outros). Não deve ser preenchido com o número de ULD, pallets ou containers.
        /// </summary>
        /// <value>Quantidade total de volumes contendo artigos perigosos.  Preencher com o número de volumes (unidades) de artigos perigosos, ou seja, cada embalagem devidamente marcada e etiquetada (por ex.: número de caixas, de tambores, de bombonas, dentre outros). Não deve ser preenchido com o número de ULD, pallets ou containers.</value>
        [DataMember(Name = "qTotEmb", IsRequired = true, EmitDefaultValue = true)]
        public string qTotEmb { get; set; }

        /// <summary>
        /// Gets or Sets infTotAP
        /// </summary>
        [DataMember(Name = "infTotAP", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazInfTotAP infTotAP { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazPeri {\n");
            sb.Append("  nONU: ").Append(nONU).Append("\n");
            sb.Append("  qTotEmb: ").Append(qTotEmb).Append("\n");
            sb.Append("  infTotAP: ").Append(infTotAP).Append("\n");
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
            return this.Equals(input as CteSefazPeri);
        }

        /// <summary>
        /// Returns true if CteSefazPeri instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazPeri to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazPeri input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nONU == input.nONU ||
                    (this.nONU != null &&
                    this.nONU.Equals(input.nONU))
                ) && 
                (
                    this.qTotEmb == input.qTotEmb ||
                    (this.qTotEmb != null &&
                    this.qTotEmb.Equals(input.qTotEmb))
                ) && 
                (
                    this.infTotAP == input.infTotAP ||
                    (this.infTotAP != null &&
                    this.infTotAP.Equals(input.infTotAP))
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
                if (this.nONU != null)
                {
                    hashCode = (hashCode * 59) + this.nONU.GetHashCode();
                }
                if (this.qTotEmb != null)
                {
                    hashCode = (hashCode * 59) + this.qTotEmb.GetHashCode();
                }
                if (this.infTotAP != null)
                {
                    hashCode = (hashCode * 59) + this.infTotAP.GetHashCode();
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
