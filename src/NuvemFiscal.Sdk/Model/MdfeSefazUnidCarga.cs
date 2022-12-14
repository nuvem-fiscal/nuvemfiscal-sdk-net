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
    /// MdfeSefazUnidCarga
    /// </summary>
    [DataContract(Name = "MdfeSefazUnidCarga")]
    public partial class MdfeSefazUnidCarga : IEquatable<MdfeSefazUnidCarga>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazUnidCarga" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazUnidCarga() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazUnidCarga" /> class.
        /// </summary>
        /// <param name="tpUnidCarga">Tipo da Unidade de Carga.  1 - Container;    2 - ULD;    3 - Pallet;    4 - Outros;. (required).</param>
        /// <param name="idUnidCarga">Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container. (required).</param>
        /// <param name="lacUnidCarga">Lacres das Unidades de Carga..</param>
        /// <param name="qtdRat">Quantidade rateada (Peso,Volume)..</param>
        public MdfeSefazUnidCarga(int tpUnidCarga = default(int), string idUnidCarga = default(string), List<MdfeSefazLacUnidCarga> lacUnidCarga = default(List<MdfeSefazLacUnidCarga>), decimal qtdRat = default(decimal))
        {
            this.tpUnidCarga = tpUnidCarga;
            // to ensure "idUnidCarga" is required (not null)
            if (idUnidCarga == null)
            {
                throw new ArgumentNullException("idUnidCarga is a required property for MdfeSefazUnidCarga and cannot be null");
            }
            this.idUnidCarga = idUnidCarga;
            this.lacUnidCarga = lacUnidCarga;
            this.qtdRat = qtdRat;
        }

        /// <summary>
        /// Tipo da Unidade de Carga.  1 - Container;    2 - ULD;    3 - Pallet;    4 - Outros;.
        /// </summary>
        /// <value>Tipo da Unidade de Carga.  1 - Container;    2 - ULD;    3 - Pallet;    4 - Outros;.</value>
        [DataMember(Name = "tpUnidCarga", IsRequired = true, EmitDefaultValue = true)]
        public int tpUnidCarga { get; set; }

        /// <summary>
        /// Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container.
        /// </summary>
        /// <value>Identificação da Unidade de Carga.  Informar a identificação da unidade de carga, por exemplo: número do container.</value>
        [DataMember(Name = "idUnidCarga", IsRequired = true, EmitDefaultValue = true)]
        public string idUnidCarga { get; set; }

        /// <summary>
        /// Lacres das Unidades de Carga.
        /// </summary>
        /// <value>Lacres das Unidades de Carga.</value>
        [DataMember(Name = "lacUnidCarga", EmitDefaultValue = false)]
        public List<MdfeSefazLacUnidCarga> lacUnidCarga { get; set; }

        /// <summary>
        /// Quantidade rateada (Peso,Volume).
        /// </summary>
        /// <value>Quantidade rateada (Peso,Volume).</value>
        [DataMember(Name = "qtdRat", EmitDefaultValue = false)]
        public decimal qtdRat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazUnidCarga {\n");
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
            return this.Equals(input as MdfeSefazUnidCarga);
        }

        /// <summary>
        /// Returns true if MdfeSefazUnidCarga instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazUnidCarga to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazUnidCarga input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpUnidCarga == input.tpUnidCarga ||
                    this.tpUnidCarga.Equals(input.tpUnidCarga)
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
                    this.qtdRat.Equals(input.qtdRat)
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
                hashCode = (hashCode * 59) + this.tpUnidCarga.GetHashCode();
                if (this.idUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.idUnidCarga.GetHashCode();
                }
                if (this.lacUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.lacUnidCarga.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.qtdRat.GetHashCode();
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
