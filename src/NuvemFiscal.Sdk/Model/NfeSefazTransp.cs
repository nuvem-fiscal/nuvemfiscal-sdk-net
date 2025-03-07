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
    /// Dados dos transportes da NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazTransp")]
    public partial class NfeSefazTransp : IEquatable<NfeSefazTransp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTransp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazTransp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTransp" /> class.
        /// </summary>
        /// <param name="modFrete">Modalidade do frete  * 0 - Contratação do Frete por conta do Remetente (CIF)  * 1 - Contratação do Frete por conta do destinatário/remetente (FOB)  * 2 - Contratação do Frete por conta de terceiros  * 3 - Transporte próprio por conta do remetente  * 4 - Transporte próprio por conta do destinatário  * 9 - Sem Ocorrência de transporte (required).</param>
        /// <param name="transporta">transporta.</param>
        /// <param name="retTransp">retTransp.</param>
        /// <param name="veicTransp">veicTransp.</param>
        /// <param name="reboque">reboque.</param>
        /// <param name="vagao">Identificação do vagão (v2.0)..</param>
        /// <param name="balsa">Identificação da balsa (v2.0)..</param>
        /// <param name="vol">vol.</param>
        public NfeSefazTransp(int? modFrete = default(int?), NfeSefazTransporta transporta = default(NfeSefazTransporta), NfeSefazRetTransp retTransp = default(NfeSefazRetTransp), NfeSefazVeiculo veicTransp = default(NfeSefazVeiculo), List<NfeSefazVeiculo> reboque = default(List<NfeSefazVeiculo>), string vagao = default(string), string balsa = default(string), List<NfeSefazVol> vol = default(List<NfeSefazVol>))
        {
            // to ensure "modFrete" is required (not null)
            if (modFrete == null)
            {
                throw new ArgumentNullException("modFrete is a required property for NfeSefazTransp and cannot be null");
            }
            this.modFrete = modFrete;
            this.transporta = transporta;
            this.retTransp = retTransp;
            this.veicTransp = veicTransp;
            this.reboque = reboque;
            this.vagao = vagao;
            this.balsa = balsa;
            this.vol = vol;
        }

        /// <summary>
        /// Modalidade do frete  * 0 - Contratação do Frete por conta do Remetente (CIF)  * 1 - Contratação do Frete por conta do destinatário/remetente (FOB)  * 2 - Contratação do Frete por conta de terceiros  * 3 - Transporte próprio por conta do remetente  * 4 - Transporte próprio por conta do destinatário  * 9 - Sem Ocorrência de transporte
        /// </summary>
        /// <value>Modalidade do frete  * 0 - Contratação do Frete por conta do Remetente (CIF)  * 1 - Contratação do Frete por conta do destinatário/remetente (FOB)  * 2 - Contratação do Frete por conta de terceiros  * 3 - Transporte próprio por conta do remetente  * 4 - Transporte próprio por conta do destinatário  * 9 - Sem Ocorrência de transporte</value>
        [DataMember(Name = "modFrete", IsRequired = true, EmitDefaultValue = true)]
        public int? modFrete { get; set; }

        /// <summary>
        /// Gets or Sets transporta
        /// </summary>
        [DataMember(Name = "transporta", EmitDefaultValue = false)]
        public NfeSefazTransporta transporta { get; set; }

        /// <summary>
        /// Gets or Sets retTransp
        /// </summary>
        [DataMember(Name = "retTransp", EmitDefaultValue = false)]
        public NfeSefazRetTransp retTransp { get; set; }

        /// <summary>
        /// Gets or Sets veicTransp
        /// </summary>
        [DataMember(Name = "veicTransp", EmitDefaultValue = false)]
        public NfeSefazVeiculo veicTransp { get; set; }

        /// <summary>
        /// Gets or Sets reboque
        /// </summary>
        [DataMember(Name = "reboque", EmitDefaultValue = false)]
        public List<NfeSefazVeiculo> reboque { get; set; }

        /// <summary>
        /// Identificação do vagão (v2.0).
        /// </summary>
        /// <value>Identificação do vagão (v2.0).</value>
        [DataMember(Name = "vagao", EmitDefaultValue = true)]
        public string vagao { get; set; }

        /// <summary>
        /// Identificação da balsa (v2.0).
        /// </summary>
        /// <value>Identificação da balsa (v2.0).</value>
        [DataMember(Name = "balsa", EmitDefaultValue = true)]
        public string balsa { get; set; }

        /// <summary>
        /// Gets or Sets vol
        /// </summary>
        [DataMember(Name = "vol", EmitDefaultValue = false)]
        public List<NfeSefazVol> vol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazTransp {\n");
            sb.Append("  modFrete: ").Append(modFrete).Append("\n");
            sb.Append("  transporta: ").Append(transporta).Append("\n");
            sb.Append("  retTransp: ").Append(retTransp).Append("\n");
            sb.Append("  veicTransp: ").Append(veicTransp).Append("\n");
            sb.Append("  reboque: ").Append(reboque).Append("\n");
            sb.Append("  vagao: ").Append(vagao).Append("\n");
            sb.Append("  balsa: ").Append(balsa).Append("\n");
            sb.Append("  vol: ").Append(vol).Append("\n");
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
            return this.Equals(input as NfeSefazTransp);
        }

        /// <summary>
        /// Returns true if NfeSefazTransp instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazTransp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazTransp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.modFrete == input.modFrete ||
                    (this.modFrete != null &&
                    this.modFrete.Equals(input.modFrete))
                ) && 
                (
                    this.transporta == input.transporta ||
                    (this.transporta != null &&
                    this.transporta.Equals(input.transporta))
                ) && 
                (
                    this.retTransp == input.retTransp ||
                    (this.retTransp != null &&
                    this.retTransp.Equals(input.retTransp))
                ) && 
                (
                    this.veicTransp == input.veicTransp ||
                    (this.veicTransp != null &&
                    this.veicTransp.Equals(input.veicTransp))
                ) && 
                (
                    this.reboque == input.reboque ||
                    this.reboque != null &&
                    input.reboque != null &&
                    this.reboque.SequenceEqual(input.reboque)
                ) && 
                (
                    this.vagao == input.vagao ||
                    (this.vagao != null &&
                    this.vagao.Equals(input.vagao))
                ) && 
                (
                    this.balsa == input.balsa ||
                    (this.balsa != null &&
                    this.balsa.Equals(input.balsa))
                ) && 
                (
                    this.vol == input.vol ||
                    this.vol != null &&
                    input.vol != null &&
                    this.vol.SequenceEqual(input.vol)
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
                if (this.modFrete != null)
                {
                    hashCode = (hashCode * 59) + this.modFrete.GetHashCode();
                }
                if (this.transporta != null)
                {
                    hashCode = (hashCode * 59) + this.transporta.GetHashCode();
                }
                if (this.retTransp != null)
                {
                    hashCode = (hashCode * 59) + this.retTransp.GetHashCode();
                }
                if (this.veicTransp != null)
                {
                    hashCode = (hashCode * 59) + this.veicTransp.GetHashCode();
                }
                if (this.reboque != null)
                {
                    hashCode = (hashCode * 59) + this.reboque.GetHashCode();
                }
                if (this.vagao != null)
                {
                    hashCode = (hashCode * 59) + this.vagao.GetHashCode();
                }
                if (this.balsa != null)
                {
                    hashCode = (hashCode * 59) + this.balsa.GetHashCode();
                }
                if (this.vol != null)
                {
                    hashCode = (hashCode * 59) + this.vol.GetHashCode();
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
            // vagao (string) maxLength
            if (this.vagao != null && this.vagao.Length > 20)
            {
                yield return new ValidationResult("Invalid value for vagao, length must be less than 20.", new [] { "vagao" });
            }

            // vagao (string) minLength
            if (this.vagao != null && this.vagao.Length < 1)
            {
                yield return new ValidationResult("Invalid value for vagao, length must be greater than 1.", new [] { "vagao" });
            }

            // balsa (string) maxLength
            if (this.balsa != null && this.balsa.Length > 20)
            {
                yield return new ValidationResult("Invalid value for balsa, length must be less than 20.", new [] { "balsa" });
            }

            // balsa (string) minLength
            if (this.balsa != null && this.balsa.Length < 1)
            {
                yield return new ValidationResult("Invalid value for balsa, length must be greater than 1.", new [] { "balsa" });
            }

            yield break;
        }
    }

}
