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
    /// Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu.
    /// </summary>
    [DataContract(Name = "CteSefazUnidCarga")]
    public partial class CteSefazUnidCarga : IEquatable<CteSefazUnidCarga>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazUnidCarga" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazUnidCarga() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazUnidCarga" /> class.
        /// </summary>
        /// <param name="tpUnidCarga">Tipo da Unidade de Carga.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros (required).</param>
        /// <param name="idUnidCarga">Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container. (required).</param>
        /// <param name="lacUnidCarga">lacUnidCarga.</param>
        /// <param name="qtdRat">Quantidade rateada (Peso,Volume)..</param>
        public CteSefazUnidCarga(int? tpUnidCarga = default(int?), string idUnidCarga = default(string), List<CteSefazLacUnidCarga> lacUnidCarga = default(List<CteSefazLacUnidCarga>), decimal? qtdRat = default(decimal?))
        {
            // to ensure "tpUnidCarga" is required (not null)
            if (tpUnidCarga == null)
            {
                throw new ArgumentNullException("tpUnidCarga is a required property for CteSefazUnidCarga and cannot be null");
            }
            this.tpUnidCarga = tpUnidCarga;
            // to ensure "idUnidCarga" is required (not null)
            if (idUnidCarga == null)
            {
                throw new ArgumentNullException("idUnidCarga is a required property for CteSefazUnidCarga and cannot be null");
            }
            this.idUnidCarga = idUnidCarga;
            this.lacUnidCarga = lacUnidCarga;
            this.qtdRat = qtdRat;
        }

        /// <summary>
        /// Tipo da Unidade de Carga.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros
        /// </summary>
        /// <value>Tipo da Unidade de Carga.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros</value>
        [DataMember(Name = "tpUnidCarga", IsRequired = true, EmitDefaultValue = true)]
        public int? tpUnidCarga { get; set; }

        /// <summary>
        /// Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container.
        /// </summary>
        /// <value>Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container.</value>
        [DataMember(Name = "idUnidCarga", IsRequired = true, EmitDefaultValue = true)]
        public string idUnidCarga { get; set; }

        /// <summary>
        /// Gets or Sets lacUnidCarga
        /// </summary>
        [DataMember(Name = "lacUnidCarga", EmitDefaultValue = false)]
        public List<CteSefazLacUnidCarga> lacUnidCarga { get; set; }

        /// <summary>
        /// Quantidade rateada (Peso,Volume).
        /// </summary>
        /// <value>Quantidade rateada (Peso,Volume).</value>
        [DataMember(Name = "qtdRat", EmitDefaultValue = true)]
        public decimal? qtdRat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazUnidCarga {\n");
            sb.Append("  tpUnidCarga: ").Append(tpUnidCarga).Append("\n");
            sb.Append("  idUnidCarga: ").Append(idUnidCarga).Append("\n");
            sb.Append("  lacUnidCarga: ").Append(lacUnidCarga).Append("\n");
            sb.Append("  qtdRat: ").Append(qtdRat).Append("\n");
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
            return this.Equals(input as CteSefazUnidCarga);
        }

        /// <summary>
        /// Returns true if CteSefazUnidCarga instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazUnidCarga to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazUnidCarga input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpUnidCarga == input.tpUnidCarga ||
                    (this.tpUnidCarga != null &&
                    this.tpUnidCarga.Equals(input.tpUnidCarga))
                ) && 
                (
                    this.idUnidCarga == input.idUnidCarga ||
                    (this.idUnidCarga != null &&
                    this.idUnidCarga.Equals(input.idUnidCarga))
                ) && 
                (
                    this.lacUnidCarga == input.lacUnidCarga ||
                    this.lacUnidCarga != null &&
                    input.lacUnidCarga != null &&
                    this.lacUnidCarga.SequenceEqual(input.lacUnidCarga)
                ) && 
                (
                    this.qtdRat == input.qtdRat ||
                    (this.qtdRat != null &&
                    this.qtdRat.Equals(input.qtdRat))
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
                if (this.tpUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.tpUnidCarga.GetHashCode();
                }
                if (this.idUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.idUnidCarga.GetHashCode();
                }
                if (this.lacUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.lacUnidCarga.GetHashCode();
                }
                if (this.qtdRat != null)
                {
                    hashCode = (hashCode * 59) + this.qtdRat.GetHashCode();
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
            // idUnidCarga (string) maxLength
            if (this.idUnidCarga != null && this.idUnidCarga.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idUnidCarga, length must be less than 20.", new [] { "idUnidCarga" });
            }

            // idUnidCarga (string) minLength
            if (this.idUnidCarga != null && this.idUnidCarga.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idUnidCarga, length must be greater than 1.", new [] { "idUnidCarga" });
            }

            yield break;
        }
    }

}
