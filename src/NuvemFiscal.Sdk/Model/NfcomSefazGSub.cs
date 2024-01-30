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
    /// Grupo de informações da substituição.
    /// </summary>
    [DataContract(Name = "NfcomSefazGSub")]
    public partial class NfcomSefazGSub : IEquatable<NfcomSefazGSub>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGSub" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGSub() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGSub" /> class.
        /// </summary>
        /// <param name="chNFCom">Chave de acesso da NFCom original..</param>
        /// <param name="gNF">gNF.</param>
        /// <param name="motSub">Motivo da substituição.  * 01 - Erro de Preço  * 02 - Erro Cadastral  * 03 - Decisão Judicial  * 04 - Erro de Tributação  * 05 - Descontinuidade do Serviço (required).</param>
        public NfcomSefazGSub(string chNFCom = default(string), NfcomSefazGNF gNF = default(NfcomSefazGNF), string motSub = default(string))
        {
            // to ensure "motSub" is required (not null)
            if (motSub == null)
            {
                throw new ArgumentNullException("motSub is a required property for NfcomSefazGSub and cannot be null");
            }
            this.motSub = motSub;
            this.chNFCom = chNFCom;
            this.gNF = gNF;
        }

        /// <summary>
        /// Chave de acesso da NFCom original.
        /// </summary>
        /// <value>Chave de acesso da NFCom original.</value>
        [DataMember(Name = "chNFCom", EmitDefaultValue = true)]
        public string chNFCom { get; set; }

        /// <summary>
        /// Gets or Sets gNF
        /// </summary>
        [DataMember(Name = "gNF", EmitDefaultValue = false)]
        public NfcomSefazGNF gNF { get; set; }

        /// <summary>
        /// Motivo da substituição.  * 01 - Erro de Preço  * 02 - Erro Cadastral  * 03 - Decisão Judicial  * 04 - Erro de Tributação  * 05 - Descontinuidade do Serviço
        /// </summary>
        /// <value>Motivo da substituição.  * 01 - Erro de Preço  * 02 - Erro Cadastral  * 03 - Decisão Judicial  * 04 - Erro de Tributação  * 05 - Descontinuidade do Serviço</value>
        [DataMember(Name = "motSub", IsRequired = true, EmitDefaultValue = true)]
        public string motSub { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGSub {\n");
            sb.Append("  chNFCom: ").Append(chNFCom).Append("\n");
            sb.Append("  gNF: ").Append(gNF).Append("\n");
            sb.Append("  motSub: ").Append(motSub).Append("\n");
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
            return this.Equals(input as NfcomSefazGSub);
        }

        /// <summary>
        /// Returns true if NfcomSefazGSub instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGSub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGSub input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chNFCom == input.chNFCom ||
                    (this.chNFCom != null &&
                    this.chNFCom.Equals(input.chNFCom))
                ) && 
                (
                    this.gNF == input.gNF ||
                    (this.gNF != null &&
                    this.gNF.Equals(input.gNF))
                ) && 
                (
                    this.motSub == input.motSub ||
                    (this.motSub != null &&
                    this.motSub.Equals(input.motSub))
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
                if (this.chNFCom != null)
                {
                    hashCode = (hashCode * 59) + this.chNFCom.GetHashCode();
                }
                if (this.gNF != null)
                {
                    hashCode = (hashCode * 59) + this.gNF.GetHashCode();
                }
                if (this.motSub != null)
                {
                    hashCode = (hashCode * 59) + this.motSub.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // chNFCom (string) maxLength
            if (this.chNFCom != null && this.chNFCom.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chNFCom, length must be less than 44.", new [] { "chNFCom" });
            }

            // motSub (string) maxLength
            if (this.motSub != null && this.motSub.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for motSub, length must be less than 2.", new [] { "motSub" });
            }

            // motSub (string) minLength
            if (this.motSub != null && this.motSub.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for motSub, length must be greater than 2.", new [] { "motSub" });
            }

            yield break;
        }
    }

}
