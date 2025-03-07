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
    /// Grupo Processo referenciado.  Este grupo somente deverá ser preenchido quando houver processo judicial ou administrativo que altere valores.
    /// </summary>
    [DataContract(Name = "NfcomSefazGProcRef")]
    public partial class NfcomSefazGProcRef : IEquatable<NfcomSefazGProcRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGProcRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGProcRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGProcRef" /> class.
        /// </summary>
        /// <param name="vItem">Valor unitário do item.  Informar o valor sem a influência da decisão judicial/administrativa. (required).</param>
        /// <param name="qFaturada">Quantidade Faturada.  Informar a quantidade de comercialização do produto . (required).</param>
        /// <param name="vProd">Valor total do item. (required).</param>
        /// <param name="vDesc">Valor do Desconto..</param>
        /// <param name="vOutro">Outras despesas acessórias..</param>
        /// <param name="indDevolucao">Indicador de devolução do valor do item.  * 1 - Devolução do valor do item.</param>
        /// <param name="vBC">Valor da BC do ICMS..</param>
        /// <param name="pICMS">Alíquota do ICMS..</param>
        /// <param name="vICMS">Valor do ICMS..</param>
        /// <param name="vPIS">Valor do PIS..</param>
        /// <param name="vCOFINS">Valor do COFINS..</param>
        /// <param name="vFCP">Valor do Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="gProc">gProc (required).</param>
        public NfcomSefazGProcRef(decimal? vItem = default(decimal?), decimal? qFaturada = default(decimal?), decimal? vProd = default(decimal?), decimal? vDesc = default(decimal?), decimal? vOutro = default(decimal?), int? indDevolucao = default(int?), decimal? vBC = default(decimal?), decimal? pICMS = default(decimal?), decimal? vICMS = default(decimal?), decimal? vPIS = default(decimal?), decimal? vCOFINS = default(decimal?), decimal? vFCP = default(decimal?), List<NfcomSefazGProc> gProc = default(List<NfcomSefazGProc>))
        {
            // to ensure "vItem" is required (not null)
            if (vItem == null)
            {
                throw new ArgumentNullException("vItem is a required property for NfcomSefazGProcRef and cannot be null");
            }
            this.vItem = vItem;
            // to ensure "qFaturada" is required (not null)
            if (qFaturada == null)
            {
                throw new ArgumentNullException("qFaturada is a required property for NfcomSefazGProcRef and cannot be null");
            }
            this.qFaturada = qFaturada;
            // to ensure "vProd" is required (not null)
            if (vProd == null)
            {
                throw new ArgumentNullException("vProd is a required property for NfcomSefazGProcRef and cannot be null");
            }
            this.vProd = vProd;
            // to ensure "gProc" is required (not null)
            if (gProc == null)
            {
                throw new ArgumentNullException("gProc is a required property for NfcomSefazGProcRef and cannot be null");
            }
            this.gProc = gProc;
            this.vDesc = vDesc;
            this.vOutro = vOutro;
            this.indDevolucao = indDevolucao;
            this.vBC = vBC;
            this.pICMS = pICMS;
            this.vICMS = vICMS;
            this.vPIS = vPIS;
            this.vCOFINS = vCOFINS;
            this.vFCP = vFCP;
        }

        /// <summary>
        /// Valor unitário do item.  Informar o valor sem a influência da decisão judicial/administrativa.
        /// </summary>
        /// <value>Valor unitário do item.  Informar o valor sem a influência da decisão judicial/administrativa.</value>
        [DataMember(Name = "vItem", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vItem { get; set; }

        /// <summary>
        /// Quantidade Faturada.  Informar a quantidade de comercialização do produto .
        /// </summary>
        /// <value>Quantidade Faturada.  Informar a quantidade de comercialização do produto .</value>
        [DataMember(Name = "qFaturada", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qFaturada { get; set; }

        /// <summary>
        /// Valor total do item.
        /// </summary>
        /// <value>Valor total do item.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vProd { get; set; }

        /// <summary>
        /// Valor do Desconto.
        /// </summary>
        /// <value>Valor do Desconto.</value>
        [DataMember(Name = "vDesc", EmitDefaultValue = true)]
        public decimal? vDesc { get; set; }

        /// <summary>
        /// Outras despesas acessórias.
        /// </summary>
        /// <value>Outras despesas acessórias.</value>
        [DataMember(Name = "vOutro", EmitDefaultValue = true)]
        public decimal? vOutro { get; set; }

        /// <summary>
        /// Indicador de devolução do valor do item.  * 1 - Devolução do valor do item
        /// </summary>
        /// <value>Indicador de devolução do valor do item.  * 1 - Devolução do valor do item</value>
        [DataMember(Name = "indDevolucao", EmitDefaultValue = true)]
        public int? indDevolucao { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", EmitDefaultValue = true)]
        public decimal? pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", EmitDefaultValue = true)]
        public decimal? vICMS { get; set; }

        /// <summary>
        /// Valor do PIS.
        /// </summary>
        /// <value>Valor do PIS.</value>
        [DataMember(Name = "vPIS", EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Valor do Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Valor do Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "vFCP", EmitDefaultValue = true)]
        public decimal? vFCP { get; set; }

        /// <summary>
        /// Gets or Sets gProc
        /// </summary>
        [DataMember(Name = "gProc", IsRequired = true, EmitDefaultValue = true)]
        public List<NfcomSefazGProc> gProc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGProcRef {\n");
            sb.Append("  vItem: ").Append(vItem).Append("\n");
            sb.Append("  qFaturada: ").Append(qFaturada).Append("\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
            sb.Append("  vDesc: ").Append(vDesc).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  indDevolucao: ").Append(indDevolucao).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
            sb.Append("  vFCP: ").Append(vFCP).Append("\n");
            sb.Append("  gProc: ").Append(gProc).Append("\n");
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
            return this.Equals(input as NfcomSefazGProcRef);
        }

        /// <summary>
        /// Returns true if NfcomSefazGProcRef instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGProcRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGProcRef input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vItem == input.vItem ||
                    (this.vItem != null &&
                    this.vItem.Equals(input.vItem))
                ) && 
                (
                    this.qFaturada == input.qFaturada ||
                    (this.qFaturada != null &&
                    this.qFaturada.Equals(input.qFaturada))
                ) && 
                (
                    this.vProd == input.vProd ||
                    (this.vProd != null &&
                    this.vProd.Equals(input.vProd))
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    (this.vDesc != null &&
                    this.vDesc.Equals(input.vDesc))
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    (this.vOutro != null &&
                    this.vOutro.Equals(input.vOutro))
                ) && 
                (
                    this.indDevolucao == input.indDevolucao ||
                    (this.indDevolucao != null &&
                    this.indDevolucao.Equals(input.indDevolucao))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    (this.pICMS != null &&
                    this.pICMS.Equals(input.pICMS))
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    (this.vICMS != null &&
                    this.vICMS.Equals(input.vICMS))
                ) && 
                (
                    this.vPIS == input.vPIS ||
                    (this.vPIS != null &&
                    this.vPIS.Equals(input.vPIS))
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    (this.vCOFINS != null &&
                    this.vCOFINS.Equals(input.vCOFINS))
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    (this.vFCP != null &&
                    this.vFCP.Equals(input.vFCP))
                ) && 
                (
                    this.gProc == input.gProc ||
                    this.gProc != null &&
                    input.gProc != null &&
                    this.gProc.SequenceEqual(input.gProc)
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
                if (this.vItem != null)
                {
                    hashCode = (hashCode * 59) + this.vItem.GetHashCode();
                }
                if (this.qFaturada != null)
                {
                    hashCode = (hashCode * 59) + this.qFaturada.GetHashCode();
                }
                if (this.vProd != null)
                {
                    hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                }
                if (this.vDesc != null)
                {
                    hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                }
                if (this.vOutro != null)
                {
                    hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                }
                if (this.indDevolucao != null)
                {
                    hashCode = (hashCode * 59) + this.indDevolucao.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pICMS != null)
                {
                    hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                }
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                }
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                }
                if (this.vFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
                }
                if (this.gProc != null)
                {
                    hashCode = (hashCode * 59) + this.gProc.GetHashCode();
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
            // qFaturada (decimal?) minimum
            if (this.qFaturada < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qFaturada, must be a value greater than or equal to 0.", new [] { "qFaturada" });
            }

            // vDesc (decimal?) minimum
            if (this.vDesc < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDesc, must be a value greater than or equal to 0.", new [] { "vDesc" });
            }

            // vOutro (decimal?) minimum
            if (this.vOutro < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vOutro, must be a value greater than or equal to 0.", new [] { "vOutro" });
            }

            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // pICMS (decimal?) minimum
            if (this.pICMS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pICMS, must be a value greater than or equal to 0.", new [] { "pICMS" });
            }

            // vICMS (decimal?) minimum
            if (this.vICMS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vICMS, must be a value greater than or equal to 0.", new [] { "vICMS" });
            }

            // vPIS (decimal?) minimum
            if (this.vPIS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vPIS, must be a value greater than or equal to 0.", new [] { "vPIS" });
            }

            // vCOFINS (decimal?) minimum
            if (this.vCOFINS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCOFINS, must be a value greater than or equal to 0.", new [] { "vCOFINS" });
            }

            // vFCP (decimal?) minimum
            if (this.vFCP < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vFCP, must be a value greater than or equal to 0.", new [] { "vFCP" });
            }

            yield break;
        }
    }

}
