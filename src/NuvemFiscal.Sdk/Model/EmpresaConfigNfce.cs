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
    /// EmpresaConfigNfce
    /// </summary>
    [DataContract(Name = "EmpresaConfigNfce")]
    public partial class EmpresaConfigNfce : IEquatable<EmpresaConfigNfce>, IValidatableObject
    {
        /// <summary>
        /// Indica se a empresa irá emitir em produção ou homologação.
        /// </summary>
        /// <value>Indica se a empresa irá emitir em produção ou homologação.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AmbienteEnum
        {
            /// <summary>
            /// Enum Homologacao for value: homologacao
            /// </summary>
            [EnumMember(Value = "homologacao")]
            Homologacao = 1,

            /// <summary>
            /// Enum Producao for value: producao
            /// </summary>
            [EnumMember(Value = "producao")]
            Producao = 2

        }


        /// <summary>
        /// Indica se a empresa irá emitir em produção ou homologação.
        /// </summary>
        /// <value>Indica se a empresa irá emitir em produção ou homologação.</value>
        [DataMember(Name = "ambiente", IsRequired = true, EmitDefaultValue = true)]
        public AmbienteEnum ambiente { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigNfce" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmpresaConfigNfce() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigNfce" /> class.
        /// </summary>
        /// <param name="cRT">Código de Regime Tributário.  Este campo será preenchido com:  * 1 – Simples Nacional;  * 2 – Simples Nacional – excesso de sublimite de receita bruta;  * 3 – Regime Normal..</param>
        /// <param name="sefaz">sefaz (required).</param>
        /// <param name="ambiente">Indica se a empresa irá emitir em produção ou homologação. (required).</param>
        public EmpresaConfigNfce(int cRT = default(int), EmpresaConfigNfceSefaz sefaz = default(EmpresaConfigNfceSefaz), AmbienteEnum ambiente = default(AmbienteEnum))
        {
            // to ensure "sefaz" is required (not null)
            if (sefaz == null)
            {
                throw new ArgumentNullException("sefaz is a required property for EmpresaConfigNfce and cannot be null");
            }
            this.sefaz = sefaz;
            this.ambiente = ambiente;
            this.CRT = cRT;
        }

        /// <summary>
        /// Código de Regime Tributário.  Este campo será preenchido com:  * 1 – Simples Nacional;  * 2 – Simples Nacional – excesso de sublimite de receita bruta;  * 3 – Regime Normal.
        /// </summary>
        /// <value>Código de Regime Tributário.  Este campo será preenchido com:  * 1 – Simples Nacional;  * 2 – Simples Nacional – excesso de sublimite de receita bruta;  * 3 – Regime Normal.</value>
        [DataMember(Name = "CRT", EmitDefaultValue = false)]
        public int CRT { get; set; }

        /// <summary>
        /// Gets or Sets sefaz
        /// </summary>
        [DataMember(Name = "sefaz", IsRequired = true, EmitDefaultValue = true)]
        public EmpresaConfigNfceSefaz sefaz { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigNfce {\n");
            sb.Append("  CRT: ").Append(CRT).Append("\n");
            sb.Append("  sefaz: ").Append(sefaz).Append("\n");
            sb.Append("  ambiente: ").Append(ambiente).Append("\n");
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
            return this.Equals(input as EmpresaConfigNfce);
        }

        /// <summary>
        /// Returns true if EmpresaConfigNfce instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigNfce to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigNfce input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CRT == input.CRT ||
                    this.CRT.Equals(input.CRT)
                ) && 
                (
                    this.sefaz == input.sefaz ||
                    (this.sefaz != null &&
                    this.sefaz.Equals(input.sefaz))
                ) && 
                (
                    this.ambiente == input.ambiente ||
                    this.ambiente.Equals(input.ambiente)
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
                hashCode = (hashCode * 59) + this.CRT.GetHashCode();
                if (this.sefaz != null)
                {
                    hashCode = (hashCode * 59) + this.sefaz.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ambiente.GetHashCode();
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
