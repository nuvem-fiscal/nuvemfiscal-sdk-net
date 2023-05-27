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
    /// Assinatura RSA do Emitente para DFe gerados por PAA.
    /// </summary>
    [DataContract(Name = "MdfeSefazPAASignature")]
    public partial class MdfeSefazPAASignature : IEquatable<MdfeSefazPAASignature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazPAASignature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazPAASignature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazPAASignature" /> class.
        /// </summary>
        /// <param name="signatureValue">Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64. (required).</param>
        /// <param name="rSAKeyValue">rSAKeyValue (required).</param>
        public MdfeSefazPAASignature(string signatureValue = default(string), MdfeSefazRSAKeyValueType rSAKeyValue = default(MdfeSefazRSAKeyValueType))
        {
            // to ensure "signatureValue" is required (not null)
            if (signatureValue == null)
            {
                throw new ArgumentNullException("signatureValue is a required property for MdfeSefazPAASignature and cannot be null");
            }
            this.SignatureValue = signatureValue;
            // to ensure "rSAKeyValue" is required (not null)
            if (rSAKeyValue == null)
            {
                throw new ArgumentNullException("rSAKeyValue is a required property for MdfeSefazPAASignature and cannot be null");
            }
            this.RSAKeyValue = rSAKeyValue;
        }

        /// <summary>
        /// Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64.
        /// </summary>
        /// <value>Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64.</value>
        [DataMember(Name = "SignatureValue", IsRequired = true, EmitDefaultValue = true)]
        public string SignatureValue { get; set; }

        /// <summary>
        /// Gets or Sets RSAKeyValue
        /// </summary>
        [DataMember(Name = "RSAKeyValue", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazRSAKeyValueType RSAKeyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazPAASignature {\n");
            sb.Append("  SignatureValue: ").Append(SignatureValue).Append("\n");
            sb.Append("  RSAKeyValue: ").Append(RSAKeyValue).Append("\n");
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
            return this.Equals(input as MdfeSefazPAASignature);
        }

        /// <summary>
        /// Returns true if MdfeSefazPAASignature instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazPAASignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazPAASignature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignatureValue == input.SignatureValue ||
                    (this.SignatureValue != null &&
                    this.SignatureValue.Equals(input.SignatureValue))
                ) && 
                (
                    this.RSAKeyValue == input.RSAKeyValue ||
                    (this.RSAKeyValue != null &&
                    this.RSAKeyValue.Equals(input.RSAKeyValue))
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
                if (this.SignatureValue != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureValue.GetHashCode();
                }
                if (this.RSAKeyValue != null)
                {
                    hashCode = (hashCode * 59) + this.RSAKeyValue.GetHashCode();
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
