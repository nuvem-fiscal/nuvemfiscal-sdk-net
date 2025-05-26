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
    /// Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.
    /// </summary>
    [DataContract(Name = "CteSimpSefazUnidadeTranspSimp")]
    public partial class CteSimpSefazUnidadeTranspSimp : IEquatable<CteSimpSefazUnidadeTranspSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazUnidadeTranspSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazUnidadeTranspSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazUnidadeTranspSimp" /> class.
        /// </summary>
        /// <param name="tpUnidTransp">Tipo da Unidade de Transporte.  * 1 - Rodoviário Tração  * 2 - Rodoviário Reboque  * 3 - Navio  * 4 - Balsa  * 5 - Aeronave  * 6 - Vagão  * 7 - Outros (required).</param>
        /// <param name="idUnidTransp">Identificação da Unidade de Transporte.  Informar a identificação conforme o tipo de unidade de transporte.  Por exemplo: para rodoviário tração ou reboque deverá preencher com a placa do veículo. (required).</param>
        /// <param name="lacUnidTransp">lacUnidTransp.</param>
        /// <param name="infUnidCarga">infUnidCarga.</param>
        /// <param name="qtdRat">Quantidade rateada (Peso,Volume)..</param>
        public CteSimpSefazUnidadeTranspSimp(int? tpUnidTransp = default(int?), string idUnidTransp = default(string), List<CteSimpSefazLacUnidTranspSimp> lacUnidTransp = default(List<CteSimpSefazLacUnidTranspSimp>), List<CteSimpSefazUnidCargaSimp> infUnidCarga = default(List<CteSimpSefazUnidCargaSimp>), decimal? qtdRat = default(decimal?))
        {
            // to ensure "tpUnidTransp" is required (not null)
            if (tpUnidTransp == null)
            {
                throw new ArgumentNullException("tpUnidTransp is a required property for CteSimpSefazUnidadeTranspSimp and cannot be null");
            }
            this.tpUnidTransp = tpUnidTransp;
            // to ensure "idUnidTransp" is required (not null)
            if (idUnidTransp == null)
            {
                throw new ArgumentNullException("idUnidTransp is a required property for CteSimpSefazUnidadeTranspSimp and cannot be null");
            }
            this.idUnidTransp = idUnidTransp;
            this.lacUnidTransp = lacUnidTransp;
            this.infUnidCarga = infUnidCarga;
            this.qtdRat = qtdRat;
        }

        /// <summary>
        /// Tipo da Unidade de Transporte.  * 1 - Rodoviário Tração  * 2 - Rodoviário Reboque  * 3 - Navio  * 4 - Balsa  * 5 - Aeronave  * 6 - Vagão  * 7 - Outros
        /// </summary>
        /// <value>Tipo da Unidade de Transporte.  * 1 - Rodoviário Tração  * 2 - Rodoviário Reboque  * 3 - Navio  * 4 - Balsa  * 5 - Aeronave  * 6 - Vagão  * 7 - Outros</value>
        [DataMember(Name = "tpUnidTransp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpUnidTransp { get; set; }

        /// <summary>
        /// Identificação da Unidade de Transporte.  Informar a identificação conforme o tipo de unidade de transporte.  Por exemplo: para rodoviário tração ou reboque deverá preencher com a placa do veículo.
        /// </summary>
        /// <value>Identificação da Unidade de Transporte.  Informar a identificação conforme o tipo de unidade de transporte.  Por exemplo: para rodoviário tração ou reboque deverá preencher com a placa do veículo.</value>
        [DataMember(Name = "idUnidTransp", IsRequired = true, EmitDefaultValue = true)]
        public string idUnidTransp { get; set; }

        /// <summary>
        /// Gets or Sets lacUnidTransp
        /// </summary>
        [DataMember(Name = "lacUnidTransp", EmitDefaultValue = false)]
        public List<CteSimpSefazLacUnidTranspSimp> lacUnidTransp { get; set; }

        /// <summary>
        /// Gets or Sets infUnidCarga
        /// </summary>
        [DataMember(Name = "infUnidCarga", EmitDefaultValue = false)]
        public List<CteSimpSefazUnidCargaSimp> infUnidCarga { get; set; }

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
            sb.Append("class CteSimpSefazUnidadeTranspSimp {\n");
            sb.Append("  tpUnidTransp: ").Append(tpUnidTransp).Append("\n");
            sb.Append("  idUnidTransp: ").Append(idUnidTransp).Append("\n");
            sb.Append("  lacUnidTransp: ").Append(lacUnidTransp).Append("\n");
            sb.Append("  infUnidCarga: ").Append(infUnidCarga).Append("\n");
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
            return this.Equals(input as CteSimpSefazUnidadeTranspSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazUnidadeTranspSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazUnidadeTranspSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazUnidadeTranspSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpUnidTransp == input.tpUnidTransp ||
                    (this.tpUnidTransp != null &&
                    this.tpUnidTransp.Equals(input.tpUnidTransp))
                ) && 
                (
                    this.idUnidTransp == input.idUnidTransp ||
                    (this.idUnidTransp != null &&
                    this.idUnidTransp.Equals(input.idUnidTransp))
                ) && 
                (
                    this.lacUnidTransp == input.lacUnidTransp ||
                    this.lacUnidTransp != null &&
                    input.lacUnidTransp != null &&
                    this.lacUnidTransp.SequenceEqual(input.lacUnidTransp)
                ) && 
                (
                    this.infUnidCarga == input.infUnidCarga ||
                    this.infUnidCarga != null &&
                    input.infUnidCarga != null &&
                    this.infUnidCarga.SequenceEqual(input.infUnidCarga)
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
                if (this.tpUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.tpUnidTransp.GetHashCode();
                }
                if (this.idUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.idUnidTransp.GetHashCode();
                }
                if (this.lacUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.lacUnidTransp.GetHashCode();
                }
                if (this.infUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidCarga.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // idUnidTransp (string) maxLength
            if (this.idUnidTransp != null && this.idUnidTransp.Length > 20)
            {
                yield return new ValidationResult("Invalid value for idUnidTransp, length must be less than 20.", new [] { "idUnidTransp" });
            }

            // idUnidTransp (string) minLength
            if (this.idUnidTransp != null && this.idUnidTransp.Length < 1)
            {
                yield return new ValidationResult("Invalid value for idUnidTransp, length must be greater than 1.", new [] { "idUnidTransp" });
            }

            // qtdRat (decimal?) minimum
            if (this.qtdRat < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qtdRat, must be a value greater than or equal to 0.", new [] { "qtdRat" });
            }

            yield break;
        }
    }

}
