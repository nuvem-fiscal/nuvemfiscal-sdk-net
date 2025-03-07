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
    /// Totalizadores da carga transportada e seus documentos fiscais.
    /// </summary>
    [DataContract(Name = "MdfeSefazTot")]
    public partial class MdfeSefazTot : IEquatable<MdfeSefazTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazTot" /> class.
        /// </summary>
        /// <param name="qCTe">Quantidade total de CT-e relacionados no Manifesto..</param>
        /// <param name="qNFe">Quantidade total de NF-e relacionadas no Manifesto..</param>
        /// <param name="qMDFe">Quantidade total de MDF-e relacionados no Manifesto Aquaviário..</param>
        /// <param name="vCarga">Valor total da carga / mercadorias transportadas. (required).</param>
        /// <param name="cUnid">Código da unidade de medida do Peso Bruto da Carga / Mercadorias transportadas.  * 01 - KG  * 02 - TON (required).</param>
        /// <param name="qCarga">Peso Bruto Total da Carga / Mercadorias transportadas. (required).</param>
        public MdfeSefazTot(int? qCTe = default(int?), int? qNFe = default(int?), int? qMDFe = default(int?), decimal? vCarga = default(decimal?), string cUnid = default(string), decimal? qCarga = default(decimal?))
        {
            // to ensure "vCarga" is required (not null)
            if (vCarga == null)
            {
                throw new ArgumentNullException("vCarga is a required property for MdfeSefazTot and cannot be null");
            }
            this.vCarga = vCarga;
            // to ensure "cUnid" is required (not null)
            if (cUnid == null)
            {
                throw new ArgumentNullException("cUnid is a required property for MdfeSefazTot and cannot be null");
            }
            this.cUnid = cUnid;
            // to ensure "qCarga" is required (not null)
            if (qCarga == null)
            {
                throw new ArgumentNullException("qCarga is a required property for MdfeSefazTot and cannot be null");
            }
            this.qCarga = qCarga;
            this.qCTe = qCTe;
            this.qNFe = qNFe;
            this.qMDFe = qMDFe;
        }

        /// <summary>
        /// Quantidade total de CT-e relacionados no Manifesto.
        /// </summary>
        /// <value>Quantidade total de CT-e relacionados no Manifesto.</value>
        [DataMember(Name = "qCTe", EmitDefaultValue = true)]
        public int? qCTe { get; set; }

        /// <summary>
        /// Quantidade total de NF-e relacionadas no Manifesto.
        /// </summary>
        /// <value>Quantidade total de NF-e relacionadas no Manifesto.</value>
        [DataMember(Name = "qNFe", EmitDefaultValue = true)]
        public int? qNFe { get; set; }

        /// <summary>
        /// Quantidade total de MDF-e relacionados no Manifesto Aquaviário.
        /// </summary>
        /// <value>Quantidade total de MDF-e relacionados no Manifesto Aquaviário.</value>
        [DataMember(Name = "qMDFe", EmitDefaultValue = true)]
        public int? qMDFe { get; set; }

        /// <summary>
        /// Valor total da carga / mercadorias transportadas.
        /// </summary>
        /// <value>Valor total da carga / mercadorias transportadas.</value>
        [DataMember(Name = "vCarga", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCarga { get; set; }

        /// <summary>
        /// Código da unidade de medida do Peso Bruto da Carga / Mercadorias transportadas.  * 01 - KG  * 02 - TON
        /// </summary>
        /// <value>Código da unidade de medida do Peso Bruto da Carga / Mercadorias transportadas.  * 01 - KG  * 02 - TON</value>
        [DataMember(Name = "cUnid", IsRequired = true, EmitDefaultValue = true)]
        public string cUnid { get; set; }

        /// <summary>
        /// Peso Bruto Total da Carga / Mercadorias transportadas.
        /// </summary>
        /// <value>Peso Bruto Total da Carga / Mercadorias transportadas.</value>
        [DataMember(Name = "qCarga", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qCarga { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazTot {\n");
            sb.Append("  qCTe: ").Append(qCTe).Append("\n");
            sb.Append("  qNFe: ").Append(qNFe).Append("\n");
            sb.Append("  qMDFe: ").Append(qMDFe).Append("\n");
            sb.Append("  vCarga: ").Append(vCarga).Append("\n");
            sb.Append("  cUnid: ").Append(cUnid).Append("\n");
            sb.Append("  qCarga: ").Append(qCarga).Append("\n");
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
            return this.Equals(input as MdfeSefazTot);
        }

        /// <summary>
        /// Returns true if MdfeSefazTot instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazTot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qCTe == input.qCTe ||
                    (this.qCTe != null &&
                    this.qCTe.Equals(input.qCTe))
                ) && 
                (
                    this.qNFe == input.qNFe ||
                    (this.qNFe != null &&
                    this.qNFe.Equals(input.qNFe))
                ) && 
                (
                    this.qMDFe == input.qMDFe ||
                    (this.qMDFe != null &&
                    this.qMDFe.Equals(input.qMDFe))
                ) && 
                (
                    this.vCarga == input.vCarga ||
                    (this.vCarga != null &&
                    this.vCarga.Equals(input.vCarga))
                ) && 
                (
                    this.cUnid == input.cUnid ||
                    (this.cUnid != null &&
                    this.cUnid.Equals(input.cUnid))
                ) && 
                (
                    this.qCarga == input.qCarga ||
                    (this.qCarga != null &&
                    this.qCarga.Equals(input.qCarga))
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
                if (this.qCTe != null)
                {
                    hashCode = (hashCode * 59) + this.qCTe.GetHashCode();
                }
                if (this.qNFe != null)
                {
                    hashCode = (hashCode * 59) + this.qNFe.GetHashCode();
                }
                if (this.qMDFe != null)
                {
                    hashCode = (hashCode * 59) + this.qMDFe.GetHashCode();
                }
                if (this.vCarga != null)
                {
                    hashCode = (hashCode * 59) + this.vCarga.GetHashCode();
                }
                if (this.cUnid != null)
                {
                    hashCode = (hashCode * 59) + this.cUnid.GetHashCode();
                }
                if (this.qCarga != null)
                {
                    hashCode = (hashCode * 59) + this.qCarga.GetHashCode();
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
            // qCTe (int?) maximum
            if (this.qCTe > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for qCTe, must be a value less than or equal to 999999.", new [] { "qCTe" });
            }

            // qCTe (int?) minimum
            if (this.qCTe < (int?)0)
            {
                yield return new ValidationResult("Invalid value for qCTe, must be a value greater than or equal to 0.", new [] { "qCTe" });
            }

            // qNFe (int?) maximum
            if (this.qNFe > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for qNFe, must be a value less than or equal to 999999.", new [] { "qNFe" });
            }

            // qNFe (int?) minimum
            if (this.qNFe < (int?)0)
            {
                yield return new ValidationResult("Invalid value for qNFe, must be a value greater than or equal to 0.", new [] { "qNFe" });
            }

            // qMDFe (int?) maximum
            if (this.qMDFe > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for qMDFe, must be a value less than or equal to 999999.", new [] { "qMDFe" });
            }

            // qMDFe (int?) minimum
            if (this.qMDFe < (int?)0)
            {
                yield return new ValidationResult("Invalid value for qMDFe, must be a value greater than or equal to 0.", new [] { "qMDFe" });
            }

            // vCarga (decimal?) minimum
            if (this.vCarga < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCarga, must be a value greater than or equal to 0.", new [] { "vCarga" });
            }

            // qCarga (decimal?) minimum
            if (this.qCarga < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qCarga, must be a value greater than or equal to 0.", new [] { "qCarga" });
            }

            yield break;
        }
    }

}
