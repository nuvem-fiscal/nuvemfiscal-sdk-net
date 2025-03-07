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
    /// Totais referentes ao ISSQN.
    /// </summary>
    [DataContract(Name = "NfeSefazISSQNtot")]
    public partial class NfeSefazISSQNtot : IEquatable<NfeSefazISSQNtot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazISSQNtot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazISSQNtot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazISSQNtot" /> class.
        /// </summary>
        /// <param name="vServ">Valor Total dos Serviços sob não-incidência ou não tributados pelo ICMS..</param>
        /// <param name="vBC">Base de Cálculo do ISS..</param>
        /// <param name="vISS">Valor Total do ISS..</param>
        /// <param name="vPIS">Valor do PIS sobre serviços..</param>
        /// <param name="vCOFINS">Valor do COFINS sobre serviços..</param>
        /// <param name="dCompet">Data da prestação do serviço  (AAAA-MM-DD). (required).</param>
        /// <param name="vDeducao">Valor dedução para redução da base de cálculo..</param>
        /// <param name="vOutro">Valor outras retenções..</param>
        /// <param name="vDescIncond">Valor desconto incondicionado..</param>
        /// <param name="vDescCond">Valor desconto condicionado..</param>
        /// <param name="vISSRet">Valor Total Retenção ISS..</param>
        /// <param name="cRegTrib">Código do regime especial de tributação..</param>
        public NfeSefazISSQNtot(decimal? vServ = default(decimal?), decimal? vBC = default(decimal?), decimal? vISS = default(decimal?), decimal? vPIS = default(decimal?), decimal? vCOFINS = default(decimal?), DateTime? dCompet = default(DateTime?), decimal? vDeducao = default(decimal?), decimal? vOutro = default(decimal?), decimal? vDescIncond = default(decimal?), decimal? vDescCond = default(decimal?), decimal? vISSRet = default(decimal?), int? cRegTrib = default(int?))
        {
            // to ensure "dCompet" is required (not null)
            if (dCompet == null)
            {
                throw new ArgumentNullException("dCompet is a required property for NfeSefazISSQNtot and cannot be null");
            }
            this.dCompet = dCompet;
            this.vServ = vServ;
            this.vBC = vBC;
            this.vISS = vISS;
            this.vPIS = vPIS;
            this.vCOFINS = vCOFINS;
            this.vDeducao = vDeducao;
            this.vOutro = vOutro;
            this.vDescIncond = vDescIncond;
            this.vDescCond = vDescCond;
            this.vISSRet = vISSRet;
            this.cRegTrib = cRegTrib;
        }

        /// <summary>
        /// Valor Total dos Serviços sob não-incidência ou não tributados pelo ICMS.
        /// </summary>
        /// <value>Valor Total dos Serviços sob não-incidência ou não tributados pelo ICMS.</value>
        [DataMember(Name = "vServ", EmitDefaultValue = true)]
        public decimal? vServ { get; set; }

        /// <summary>
        /// Base de Cálculo do ISS.
        /// </summary>
        /// <value>Base de Cálculo do ISS.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Valor Total do ISS.
        /// </summary>
        /// <value>Valor Total do ISS.</value>
        [DataMember(Name = "vISS", EmitDefaultValue = true)]
        public decimal? vISS { get; set; }

        /// <summary>
        /// Valor do PIS sobre serviços.
        /// </summary>
        /// <value>Valor do PIS sobre serviços.</value>
        [DataMember(Name = "vPIS", EmitDefaultValue = true)]
        public decimal? vPIS { get; set; }

        /// <summary>
        /// Valor do COFINS sobre serviços.
        /// </summary>
        /// <value>Valor do COFINS sobre serviços.</value>
        [DataMember(Name = "vCOFINS", EmitDefaultValue = true)]
        public decimal? vCOFINS { get; set; }

        /// <summary>
        /// Data da prestação do serviço  (AAAA-MM-DD).
        /// </summary>
        /// <value>Data da prestação do serviço  (AAAA-MM-DD).</value>
        [DataMember(Name = "dCompet", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dCompet { get; set; }

        /// <summary>
        /// Valor dedução para redução da base de cálculo.
        /// </summary>
        /// <value>Valor dedução para redução da base de cálculo.</value>
        [DataMember(Name = "vDeducao", EmitDefaultValue = true)]
        public decimal? vDeducao { get; set; }

        /// <summary>
        /// Valor outras retenções.
        /// </summary>
        /// <value>Valor outras retenções.</value>
        [DataMember(Name = "vOutro", EmitDefaultValue = true)]
        public decimal? vOutro { get; set; }

        /// <summary>
        /// Valor desconto incondicionado.
        /// </summary>
        /// <value>Valor desconto incondicionado.</value>
        [DataMember(Name = "vDescIncond", EmitDefaultValue = true)]
        public decimal? vDescIncond { get; set; }

        /// <summary>
        /// Valor desconto condicionado.
        /// </summary>
        /// <value>Valor desconto condicionado.</value>
        [DataMember(Name = "vDescCond", EmitDefaultValue = true)]
        public decimal? vDescCond { get; set; }

        /// <summary>
        /// Valor Total Retenção ISS.
        /// </summary>
        /// <value>Valor Total Retenção ISS.</value>
        [DataMember(Name = "vISSRet", EmitDefaultValue = true)]
        public decimal? vISSRet { get; set; }

        /// <summary>
        /// Código do regime especial de tributação.
        /// </summary>
        /// <value>Código do regime especial de tributação.</value>
        [DataMember(Name = "cRegTrib", EmitDefaultValue = true)]
        public int? cRegTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazISSQNtot {\n");
            sb.Append("  vServ: ").Append(vServ).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  vISS: ").Append(vISS).Append("\n");
            sb.Append("  vPIS: ").Append(vPIS).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
            sb.Append("  dCompet: ").Append(dCompet).Append("\n");
            sb.Append("  vDeducao: ").Append(vDeducao).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  vDescIncond: ").Append(vDescIncond).Append("\n");
            sb.Append("  vDescCond: ").Append(vDescCond).Append("\n");
            sb.Append("  vISSRet: ").Append(vISSRet).Append("\n");
            sb.Append("  cRegTrib: ").Append(cRegTrib).Append("\n");
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
            return this.Equals(input as NfeSefazISSQNtot);
        }

        /// <summary>
        /// Returns true if NfeSefazISSQNtot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazISSQNtot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazISSQNtot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vServ == input.vServ ||
                    (this.vServ != null &&
                    this.vServ.Equals(input.vServ))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.vISS == input.vISS ||
                    (this.vISS != null &&
                    this.vISS.Equals(input.vISS))
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
                    this.dCompet == input.dCompet ||
                    (this.dCompet != null &&
                    this.dCompet.Equals(input.dCompet))
                ) && 
                (
                    this.vDeducao == input.vDeducao ||
                    (this.vDeducao != null &&
                    this.vDeducao.Equals(input.vDeducao))
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    (this.vOutro != null &&
                    this.vOutro.Equals(input.vOutro))
                ) && 
                (
                    this.vDescIncond == input.vDescIncond ||
                    (this.vDescIncond != null &&
                    this.vDescIncond.Equals(input.vDescIncond))
                ) && 
                (
                    this.vDescCond == input.vDescCond ||
                    (this.vDescCond != null &&
                    this.vDescCond.Equals(input.vDescCond))
                ) && 
                (
                    this.vISSRet == input.vISSRet ||
                    (this.vISSRet != null &&
                    this.vISSRet.Equals(input.vISSRet))
                ) && 
                (
                    this.cRegTrib == input.cRegTrib ||
                    (this.cRegTrib != null &&
                    this.cRegTrib.Equals(input.cRegTrib))
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
                if (this.vServ != null)
                {
                    hashCode = (hashCode * 59) + this.vServ.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.vISS != null)
                {
                    hashCode = (hashCode * 59) + this.vISS.GetHashCode();
                }
                if (this.vPIS != null)
                {
                    hashCode = (hashCode * 59) + this.vPIS.GetHashCode();
                }
                if (this.vCOFINS != null)
                {
                    hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
                }
                if (this.dCompet != null)
                {
                    hashCode = (hashCode * 59) + this.dCompet.GetHashCode();
                }
                if (this.vDeducao != null)
                {
                    hashCode = (hashCode * 59) + this.vDeducao.GetHashCode();
                }
                if (this.vOutro != null)
                {
                    hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                }
                if (this.vDescIncond != null)
                {
                    hashCode = (hashCode * 59) + this.vDescIncond.GetHashCode();
                }
                if (this.vDescCond != null)
                {
                    hashCode = (hashCode * 59) + this.vDescCond.GetHashCode();
                }
                if (this.vISSRet != null)
                {
                    hashCode = (hashCode * 59) + this.vISSRet.GetHashCode();
                }
                if (this.cRegTrib != null)
                {
                    hashCode = (hashCode * 59) + this.cRegTrib.GetHashCode();
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
            // vServ (decimal?) minimum
            if (this.vServ < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vServ, must be a value greater than or equal to 0.", new [] { "vServ" });
            }

            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // vISS (decimal?) minimum
            if (this.vISS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vISS, must be a value greater than or equal to 0.", new [] { "vISS" });
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

            // vDeducao (decimal?) minimum
            if (this.vDeducao < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDeducao, must be a value greater than or equal to 0.", new [] { "vDeducao" });
            }

            // vOutro (decimal?) minimum
            if (this.vOutro < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vOutro, must be a value greater than or equal to 0.", new [] { "vOutro" });
            }

            // vDescIncond (decimal?) minimum
            if (this.vDescIncond < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDescIncond, must be a value greater than or equal to 0.", new [] { "vDescIncond" });
            }

            // vDescCond (decimal?) minimum
            if (this.vDescCond < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDescCond, must be a value greater than or equal to 0.", new [] { "vDescCond" });
            }

            // vISSRet (decimal?) minimum
            if (this.vISSRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vISSRet, must be a value greater than or equal to 0.", new [] { "vISSRet" });
            }

            yield break;
        }
    }

}
