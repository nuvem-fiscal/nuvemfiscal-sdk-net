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
    /// MdfeNaoEncerrados
    /// </summary>
    [DataContract(Name = "MdfeNaoEncerrados")]
    public partial class MdfeNaoEncerrados : IEquatable<MdfeNaoEncerrados>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeNaoEncerrados" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeNaoEncerrados() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeNaoEncerrados" /> class.
        /// </summary>
        /// <param name="tpAmb">Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação.</param>
        /// <param name="verAplic">Versão do Aplicativo que processou o MDF-e..</param>
        /// <param name="cStat">Código do status da mensagem enviada. (required).</param>
        /// <param name="xMotivo">Descrição literal do status do serviço solicitado..</param>
        /// <param name="cUF">código da UF de atendimento..</param>
        /// <param name="infMDFe">infMDFe.</param>
        public MdfeNaoEncerrados(int? tpAmb = default(int?), string verAplic = default(string), int? cStat = default(int?), string xMotivo = default(string), int? cUF = default(int?), List<MdfeNaoEncerrado> infMDFe = default(List<MdfeNaoEncerrado>))
        {
            // to ensure "cStat" is required (not null)
            if (cStat == null)
            {
                throw new ArgumentNullException("cStat is a required property for MdfeNaoEncerrados and cannot be null");
            }
            this.cStat = cStat;
            this.tpAmb = tpAmb;
            this.verAplic = verAplic;
            this.xMotivo = xMotivo;
            this.cUF = cUF;
            this.infMDFe = infMDFe;
        }

        /// <summary>
        /// Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação
        /// </summary>
        /// <value>Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = true)]
        public int? tpAmb { get; set; }

        /// <summary>
        /// Versão do Aplicativo que processou o MDF-e.
        /// </summary>
        /// <value>Versão do Aplicativo que processou o MDF-e.</value>
        [DataMember(Name = "verAplic", EmitDefaultValue = true)]
        public string verAplic { get; set; }

        /// <summary>
        /// Código do status da mensagem enviada.
        /// </summary>
        /// <value>Código do status da mensagem enviada.</value>
        [DataMember(Name = "cStat", IsRequired = true, EmitDefaultValue = true)]
        public int? cStat { get; set; }

        /// <summary>
        /// Descrição literal do status do serviço solicitado.
        /// </summary>
        /// <value>Descrição literal do status do serviço solicitado.</value>
        [DataMember(Name = "xMotivo", EmitDefaultValue = true)]
        public string xMotivo { get; set; }

        /// <summary>
        /// código da UF de atendimento.
        /// </summary>
        /// <value>código da UF de atendimento.</value>
        [DataMember(Name = "cUF", EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// Gets or Sets infMDFe
        /// </summary>
        [DataMember(Name = "infMDFe", EmitDefaultValue = false)]
        public List<MdfeNaoEncerrado> infMDFe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeNaoEncerrados {\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  verAplic: ").Append(verAplic).Append("\n");
            sb.Append("  cStat: ").Append(cStat).Append("\n");
            sb.Append("  xMotivo: ").Append(xMotivo).Append("\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  infMDFe: ").Append(infMDFe).Append("\n");
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
            return this.Equals(input as MdfeNaoEncerrados);
        }

        /// <summary>
        /// Returns true if MdfeNaoEncerrados instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeNaoEncerrados to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeNaoEncerrados input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpAmb == input.tpAmb ||
                    (this.tpAmb != null &&
                    this.tpAmb.Equals(input.tpAmb))
                ) && 
                (
                    this.verAplic == input.verAplic ||
                    (this.verAplic != null &&
                    this.verAplic.Equals(input.verAplic))
                ) && 
                (
                    this.cStat == input.cStat ||
                    (this.cStat != null &&
                    this.cStat.Equals(input.cStat))
                ) && 
                (
                    this.xMotivo == input.xMotivo ||
                    (this.xMotivo != null &&
                    this.xMotivo.Equals(input.xMotivo))
                ) && 
                (
                    this.cUF == input.cUF ||
                    (this.cUF != null &&
                    this.cUF.Equals(input.cUF))
                ) && 
                (
                    this.infMDFe == input.infMDFe ||
                    this.infMDFe != null &&
                    input.infMDFe != null &&
                    this.infMDFe.SequenceEqual(input.infMDFe)
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
                if (this.tpAmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                }
                if (this.verAplic != null)
                {
                    hashCode = (hashCode * 59) + this.verAplic.GetHashCode();
                }
                if (this.cStat != null)
                {
                    hashCode = (hashCode * 59) + this.cStat.GetHashCode();
                }
                if (this.xMotivo != null)
                {
                    hashCode = (hashCode * 59) + this.xMotivo.GetHashCode();
                }
                if (this.cUF != null)
                {
                    hashCode = (hashCode * 59) + this.cUF.GetHashCode();
                }
                if (this.infMDFe != null)
                {
                    hashCode = (hashCode * 59) + this.infMDFe.GetHashCode();
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
            yield break;
        }
    }

}
