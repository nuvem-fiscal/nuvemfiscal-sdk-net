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
    /// Grupo de Informações do Cofaturamento.
    /// </summary>
    [DataContract(Name = "NfcomSefazGCofat")]
    public partial class NfcomSefazGCofat : IEquatable<NfcomSefazGCofat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGCofat" /> class.
        /// </summary>
        /// <param name="chNFComLocal">Chave de acesso da NFCom emitida pela Operadora Local..</param>
        /// <param name="gNF">gNF.</param>
        public NfcomSefazGCofat(string chNFComLocal = default(string), NfcomSefazGCofatGNF gNF = default(NfcomSefazGCofatGNF))
        {
            this.chNFComLocal = chNFComLocal;
            this.gNF = gNF;
        }

        /// <summary>
        /// Chave de acesso da NFCom emitida pela Operadora Local.
        /// </summary>
        /// <value>Chave de acesso da NFCom emitida pela Operadora Local.</value>
        [DataMember(Name = "chNFComLocal", EmitDefaultValue = true)]
        public string chNFComLocal { get; set; }

        /// <summary>
        /// Gets or Sets gNF
        /// </summary>
        [DataMember(Name = "gNF", EmitDefaultValue = false)]
        public NfcomSefazGCofatGNF gNF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGCofat {\n");
            sb.Append("  chNFComLocal: ").Append(chNFComLocal).Append("\n");
            sb.Append("  gNF: ").Append(gNF).Append("\n");
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
            return this.Equals(input as NfcomSefazGCofat);
        }

        /// <summary>
        /// Returns true if NfcomSefazGCofat instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGCofat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGCofat input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chNFComLocal == input.chNFComLocal ||
                    (this.chNFComLocal != null &&
                    this.chNFComLocal.Equals(input.chNFComLocal))
                ) && 
                (
                    this.gNF == input.gNF ||
                    (this.gNF != null &&
                    this.gNF.Equals(input.gNF))
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
                if (this.chNFComLocal != null)
                {
                    hashCode = (hashCode * 59) + this.chNFComLocal.GetHashCode();
                }
                if (this.gNF != null)
                {
                    hashCode = (hashCode * 59) + this.gNF.GetHashCode();
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
            // chNFComLocal (string) maxLength
            if (this.chNFComLocal != null && this.chNFComLocal.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chNFComLocal, length must be less than 44.", new [] { "chNFComLocal" });
            }

            yield break;
        }
    }

}
