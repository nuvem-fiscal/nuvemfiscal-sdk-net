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
    /// NfeSefazIpi
    /// </summary>
    [DataContract(Name = "NfeSefazIpi")]
    public partial class NfeSefazIpi : IEquatable<NfeSefazIpi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIpi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazIpi() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIpi" /> class.
        /// </summary>
        /// <param name="cNPJProd">CNPJ do produtor da mercadoria, quando diferente do emitente. Somente para os casos de exportação direta ou indireta..</param>
        /// <param name="cSelo">Código do selo de controle do IPI..</param>
        /// <param name="qSelo">Quantidade de selo de controle do IPI..</param>
        /// <param name="cEnq">Código de Enquadramento Legal do IPI (tabela a ser criada pela RFB). (required).</param>
        /// <param name="iPITrib">iPITrib.</param>
        /// <param name="iPINT">iPINT.</param>
        public NfeSefazIpi(string cNPJProd = default(string), string cSelo = default(string), int qSelo = default(int), string cEnq = default(string), NfeSefazIPITrib iPITrib = default(NfeSefazIPITrib), NfeSefazIPINT iPINT = default(NfeSefazIPINT))
        {
            // to ensure "cEnq" is required (not null)
            if (cEnq == null)
            {
                throw new ArgumentNullException("cEnq is a required property for NfeSefazIpi and cannot be null");
            }
            this.cEnq = cEnq;
            this.CNPJProd = cNPJProd;
            this.cSelo = cSelo;
            this.qSelo = qSelo;
            this.IPITrib = iPITrib;
            this.IPINT = iPINT;
        }

        /// <summary>
        /// CNPJ do produtor da mercadoria, quando diferente do emitente. Somente para os casos de exportação direta ou indireta.
        /// </summary>
        /// <value>CNPJ do produtor da mercadoria, quando diferente do emitente. Somente para os casos de exportação direta ou indireta.</value>
        [DataMember(Name = "CNPJProd", EmitDefaultValue = false)]
        public string CNPJProd { get; set; }

        /// <summary>
        /// Código do selo de controle do IPI.
        /// </summary>
        /// <value>Código do selo de controle do IPI.</value>
        [DataMember(Name = "cSelo", EmitDefaultValue = false)]
        public string cSelo { get; set; }

        /// <summary>
        /// Quantidade de selo de controle do IPI.
        /// </summary>
        /// <value>Quantidade de selo de controle do IPI.</value>
        [DataMember(Name = "qSelo", EmitDefaultValue = false)]
        public int qSelo { get; set; }

        /// <summary>
        /// Código de Enquadramento Legal do IPI (tabela a ser criada pela RFB).
        /// </summary>
        /// <value>Código de Enquadramento Legal do IPI (tabela a ser criada pela RFB).</value>
        [DataMember(Name = "cEnq", IsRequired = true, EmitDefaultValue = true)]
        public string cEnq { get; set; }

        /// <summary>
        /// Gets or Sets IPITrib
        /// </summary>
        [DataMember(Name = "IPITrib", EmitDefaultValue = false)]
        public NfeSefazIPITrib IPITrib { get; set; }

        /// <summary>
        /// Gets or Sets IPINT
        /// </summary>
        [DataMember(Name = "IPINT", EmitDefaultValue = false)]
        public NfeSefazIPINT IPINT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazIpi {\n");
            sb.Append("  CNPJProd: ").Append(CNPJProd).Append("\n");
            sb.Append("  cSelo: ").Append(cSelo).Append("\n");
            sb.Append("  qSelo: ").Append(qSelo).Append("\n");
            sb.Append("  cEnq: ").Append(cEnq).Append("\n");
            sb.Append("  IPITrib: ").Append(IPITrib).Append("\n");
            sb.Append("  IPINT: ").Append(IPINT).Append("\n");
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
            return this.Equals(input as NfeSefazIpi);
        }

        /// <summary>
        /// Returns true if NfeSefazIpi instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazIpi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazIpi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJProd == input.CNPJProd ||
                    (this.CNPJProd != null &&
                    this.CNPJProd.Equals(input.CNPJProd))
                ) && 
                (
                    this.cSelo == input.cSelo ||
                    (this.cSelo != null &&
                    this.cSelo.Equals(input.cSelo))
                ) && 
                (
                    this.qSelo == input.qSelo ||
                    this.qSelo.Equals(input.qSelo)
                ) && 
                (
                    this.cEnq == input.cEnq ||
                    (this.cEnq != null &&
                    this.cEnq.Equals(input.cEnq))
                ) && 
                (
                    this.IPITrib == input.IPITrib ||
                    (this.IPITrib != null &&
                    this.IPITrib.Equals(input.IPITrib))
                ) && 
                (
                    this.IPINT == input.IPINT ||
                    (this.IPINT != null &&
                    this.IPINT.Equals(input.IPINT))
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
                if (this.CNPJProd != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJProd.GetHashCode();
                }
                if (this.cSelo != null)
                {
                    hashCode = (hashCode * 59) + this.cSelo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.qSelo.GetHashCode();
                if (this.cEnq != null)
                {
                    hashCode = (hashCode * 59) + this.cEnq.GetHashCode();
                }
                if (this.IPITrib != null)
                {
                    hashCode = (hashCode * 59) + this.IPITrib.GetHashCode();
                }
                if (this.IPINT != null)
                {
                    hashCode = (hashCode * 59) + this.IPINT.GetHashCode();
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
