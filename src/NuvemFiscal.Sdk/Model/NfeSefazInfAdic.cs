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
    /// NfeSefazInfAdic
    /// </summary>
    [DataContract(Name = "NfeSefazInfAdic")]
    public partial class NfeSefazInfAdic : IEquatable<NfeSefazInfAdic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazInfAdic" /> class.
        /// </summary>
        /// <param name="infAdFisco">Informações adicionais de interesse do Fisco (v2.0)..</param>
        /// <param name="infCpl">Informações complementares de interesse do Contribuinte..</param>
        /// <param name="obsCont">Campo de uso livre do contribuinte  informar o nome do campo no atributo xCampo  e o conteúdo do campo no xTexto..</param>
        /// <param name="obsFisco">Campo de uso exclusivo do Fisco  informar o nome do campo no atributo xCampo  e o conteúdo do campo no xTexto..</param>
        /// <param name="procRef">Grupo de informações do  processo referenciado..</param>
        public NfeSefazInfAdic(string infAdFisco = default(string), string infCpl = default(string), List<NfeSefazObsCont> obsCont = default(List<NfeSefazObsCont>), List<NfeSefazObsFisco> obsFisco = default(List<NfeSefazObsFisco>), List<NfeSefazProcRef> procRef = default(List<NfeSefazProcRef>))
        {
            this.infAdFisco = infAdFisco;
            this.infCpl = infCpl;
            this.obsCont = obsCont;
            this.obsFisco = obsFisco;
            this.procRef = procRef;
        }

        /// <summary>
        /// Informações adicionais de interesse do Fisco (v2.0).
        /// </summary>
        /// <value>Informações adicionais de interesse do Fisco (v2.0).</value>
        [DataMember(Name = "infAdFisco", EmitDefaultValue = false)]
        public string infAdFisco { get; set; }

        /// <summary>
        /// Informações complementares de interesse do Contribuinte.
        /// </summary>
        /// <value>Informações complementares de interesse do Contribuinte.</value>
        [DataMember(Name = "infCpl", EmitDefaultValue = false)]
        public string infCpl { get; set; }

        /// <summary>
        /// Campo de uso livre do contribuinte  informar o nome do campo no atributo xCampo  e o conteúdo do campo no xTexto.
        /// </summary>
        /// <value>Campo de uso livre do contribuinte  informar o nome do campo no atributo xCampo  e o conteúdo do campo no xTexto.</value>
        [DataMember(Name = "obsCont", EmitDefaultValue = false)]
        public List<NfeSefazObsCont> obsCont { get; set; }

        /// <summary>
        /// Campo de uso exclusivo do Fisco  informar o nome do campo no atributo xCampo  e o conteúdo do campo no xTexto.
        /// </summary>
        /// <value>Campo de uso exclusivo do Fisco  informar o nome do campo no atributo xCampo  e o conteúdo do campo no xTexto.</value>
        [DataMember(Name = "obsFisco", EmitDefaultValue = false)]
        public List<NfeSefazObsFisco> obsFisco { get; set; }

        /// <summary>
        /// Grupo de informações do  processo referenciado.
        /// </summary>
        /// <value>Grupo de informações do  processo referenciado.</value>
        [DataMember(Name = "procRef", EmitDefaultValue = false)]
        public List<NfeSefazProcRef> procRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazInfAdic {\n");
            sb.Append("  infAdFisco: ").Append(infAdFisco).Append("\n");
            sb.Append("  infCpl: ").Append(infCpl).Append("\n");
            sb.Append("  obsCont: ").Append(obsCont).Append("\n");
            sb.Append("  obsFisco: ").Append(obsFisco).Append("\n");
            sb.Append("  procRef: ").Append(procRef).Append("\n");
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
            return this.Equals(input as NfeSefazInfAdic);
        }

        /// <summary>
        /// Returns true if NfeSefazInfAdic instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazInfAdic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazInfAdic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infAdFisco == input.infAdFisco ||
                    (this.infAdFisco != null &&
                    this.infAdFisco.Equals(input.infAdFisco))
                ) && 
                (
                    this.infCpl == input.infCpl ||
                    (this.infCpl != null &&
                    this.infCpl.Equals(input.infCpl))
                ) && 
                (
                    this.obsCont == input.obsCont ||
                    this.obsCont != null &&
                    input.obsCont != null &&
                    this.obsCont.SequenceEqual(input.obsCont)
                ) && 
                (
                    this.obsFisco == input.obsFisco ||
                    this.obsFisco != null &&
                    input.obsFisco != null &&
                    this.obsFisco.SequenceEqual(input.obsFisco)
                ) && 
                (
                    this.procRef == input.procRef ||
                    this.procRef != null &&
                    input.procRef != null &&
                    this.procRef.SequenceEqual(input.procRef)
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
                if (this.infAdFisco != null)
                {
                    hashCode = (hashCode * 59) + this.infAdFisco.GetHashCode();
                }
                if (this.infCpl != null)
                {
                    hashCode = (hashCode * 59) + this.infCpl.GetHashCode();
                }
                if (this.obsCont != null)
                {
                    hashCode = (hashCode * 59) + this.obsCont.GetHashCode();
                }
                if (this.obsFisco != null)
                {
                    hashCode = (hashCode * 59) + this.obsFisco.GetHashCode();
                }
                if (this.procRef != null)
                {
                    hashCode = (hashCode * 59) + this.procRef.GetHashCode();
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
