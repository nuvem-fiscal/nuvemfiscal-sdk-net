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
    /// Detalhamento de informações para o tráfego mútuo.
    /// </summary>
    [DataContract(Name = "CteSefazTrafMut")]
    public partial class CteSefazTrafMut : IEquatable<CteSefazTrafMut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTrafMut" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazTrafMut() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTrafMut" /> class.
        /// </summary>
        /// <param name="respFat">Responsável pelo Faturamento.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino (required).</param>
        /// <param name="ferrEmi">Ferrovia Emitente do CTe.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino (required).</param>
        /// <param name="vFrete">Valor do Frete do Tráfego Mútuo. (required).</param>
        /// <param name="chCTeFerroOrigem">Chave de acesso do CT-e emitido pelo ferrovia de origem..</param>
        /// <param name="ferroEnv">ferroEnv.</param>
        public CteSefazTrafMut(int? respFat = default(int?), int? ferrEmi = default(int?), decimal? vFrete = default(decimal?), string chCTeFerroOrigem = default(string), List<CteSefazFerroEnv> ferroEnv = default(List<CteSefazFerroEnv>))
        {
            // to ensure "respFat" is required (not null)
            if (respFat == null)
            {
                throw new ArgumentNullException("respFat is a required property for CteSefazTrafMut and cannot be null");
            }
            this.respFat = respFat;
            // to ensure "ferrEmi" is required (not null)
            if (ferrEmi == null)
            {
                throw new ArgumentNullException("ferrEmi is a required property for CteSefazTrafMut and cannot be null");
            }
            this.ferrEmi = ferrEmi;
            // to ensure "vFrete" is required (not null)
            if (vFrete == null)
            {
                throw new ArgumentNullException("vFrete is a required property for CteSefazTrafMut and cannot be null");
            }
            this.vFrete = vFrete;
            this.chCTeFerroOrigem = chCTeFerroOrigem;
            this.ferroEnv = ferroEnv;
        }

        /// <summary>
        /// Responsável pelo Faturamento.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino
        /// </summary>
        /// <value>Responsável pelo Faturamento.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino</value>
        [DataMember(Name = "respFat", IsRequired = true, EmitDefaultValue = true)]
        public int? respFat { get; set; }

        /// <summary>
        /// Ferrovia Emitente do CTe.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino
        /// </summary>
        /// <value>Ferrovia Emitente do CTe.  Preencher com:  * 1 - Ferrovia de origem  * 2 - Ferrovia de destino</value>
        [DataMember(Name = "ferrEmi", IsRequired = true, EmitDefaultValue = true)]
        public int? ferrEmi { get; set; }

        /// <summary>
        /// Valor do Frete do Tráfego Mútuo.
        /// </summary>
        /// <value>Valor do Frete do Tráfego Mútuo.</value>
        [DataMember(Name = "vFrete", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vFrete { get; set; }

        /// <summary>
        /// Chave de acesso do CT-e emitido pelo ferrovia de origem.
        /// </summary>
        /// <value>Chave de acesso do CT-e emitido pelo ferrovia de origem.</value>
        [DataMember(Name = "chCTeFerroOrigem", EmitDefaultValue = true)]
        public string chCTeFerroOrigem { get; set; }

        /// <summary>
        /// Gets or Sets ferroEnv
        /// </summary>
        [DataMember(Name = "ferroEnv", EmitDefaultValue = false)]
        public List<CteSefazFerroEnv> ferroEnv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazTrafMut {\n");
            sb.Append("  respFat: ").Append(respFat).Append("\n");
            sb.Append("  ferrEmi: ").Append(ferrEmi).Append("\n");
            sb.Append("  vFrete: ").Append(vFrete).Append("\n");
            sb.Append("  chCTeFerroOrigem: ").Append(chCTeFerroOrigem).Append("\n");
            sb.Append("  ferroEnv: ").Append(ferroEnv).Append("\n");
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
            return this.Equals(input as CteSefazTrafMut);
        }

        /// <summary>
        /// Returns true if CteSefazTrafMut instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazTrafMut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazTrafMut input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.respFat == input.respFat ||
                    (this.respFat != null &&
                    this.respFat.Equals(input.respFat))
                ) && 
                (
                    this.ferrEmi == input.ferrEmi ||
                    (this.ferrEmi != null &&
                    this.ferrEmi.Equals(input.ferrEmi))
                ) && 
                (
                    this.vFrete == input.vFrete ||
                    (this.vFrete != null &&
                    this.vFrete.Equals(input.vFrete))
                ) && 
                (
                    this.chCTeFerroOrigem == input.chCTeFerroOrigem ||
                    (this.chCTeFerroOrigem != null &&
                    this.chCTeFerroOrigem.Equals(input.chCTeFerroOrigem))
                ) && 
                (
                    this.ferroEnv == input.ferroEnv ||
                    this.ferroEnv != null &&
                    input.ferroEnv != null &&
                    this.ferroEnv.SequenceEqual(input.ferroEnv)
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
                if (this.respFat != null)
                {
                    hashCode = (hashCode * 59) + this.respFat.GetHashCode();
                }
                if (this.ferrEmi != null)
                {
                    hashCode = (hashCode * 59) + this.ferrEmi.GetHashCode();
                }
                if (this.vFrete != null)
                {
                    hashCode = (hashCode * 59) + this.vFrete.GetHashCode();
                }
                if (this.chCTeFerroOrigem != null)
                {
                    hashCode = (hashCode * 59) + this.chCTeFerroOrigem.GetHashCode();
                }
                if (this.ferroEnv != null)
                {
                    hashCode = (hashCode * 59) + this.ferroEnv.GetHashCode();
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
