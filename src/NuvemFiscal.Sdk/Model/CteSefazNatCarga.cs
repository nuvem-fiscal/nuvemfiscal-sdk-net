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
    /// Natureza da carga.
    /// </summary>
    [DataContract(Name = "CteSefazNatCarga")]
    public partial class CteSefazNatCarga : IEquatable<CteSefazNatCarga>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazNatCarga" /> class.
        /// </summary>
        /// <param name="xDime">Dimensão.  Formato:1234X1234X1234 (cm). Esse campo deve sempre que possível ser preenchido. Entretanto, quando for impossível o preenchimento das dimensões, fica obrigatório o preenchimento da cubagem em metro cúbico do leiaute do CT-e da estrutura genérica (infQ)..</param>
        /// <param name="cInfManu">Informações de manuseio.  * 01 - certificado do expedidor para embarque de animal vivo  * 02 - artigo perigoso conforme Declaração do Expedidor anexa  * 03 - somente em aeronave cargueira  * 04 - artigo perigoso - declaração do expedidor não requerida  * 05 - artigo perigoso em quantidade isenta  * 06 - gelo seco para refrigeração (especificar no campo observações a quantidade)  * 07 - não restrito (especificar a Disposição Especial no campo observações)  * 08 - artigo perigoso em carga consolidada (especificar a quantidade no campo observações)  * 09 - autorização da autoridade governamental anexa (especificar no campo observações)  * 10 - baterias de íons de lítio em conformidade com a Seção II da PI965 - CAO  * 11 - baterias de íons de lítio em conformidade com a Seção II da PI966  * 12 - baterias de íons de lítio em conformidade com a Seção II da PI967  * 13 - baterias de metal lítio em conformidade com a Seção II da PI968 — CAO  * 14 - baterias de metal lítio em conformidade com a Seção II da PI969  * 15 - baterias de metal lítio em conformidade com a Seção II da PI970  * 99 - outro (especificar no campo observações).</param>
        public CteSefazNatCarga(string xDime = default(string), List<string> cInfManu = default(List<string>))
        {
            this.xDime = xDime;
            this.cInfManu = cInfManu;
        }

        /// <summary>
        /// Dimensão.  Formato:1234X1234X1234 (cm). Esse campo deve sempre que possível ser preenchido. Entretanto, quando for impossível o preenchimento das dimensões, fica obrigatório o preenchimento da cubagem em metro cúbico do leiaute do CT-e da estrutura genérica (infQ).
        /// </summary>
        /// <value>Dimensão.  Formato:1234X1234X1234 (cm). Esse campo deve sempre que possível ser preenchido. Entretanto, quando for impossível o preenchimento das dimensões, fica obrigatório o preenchimento da cubagem em metro cúbico do leiaute do CT-e da estrutura genérica (infQ).</value>
        [DataMember(Name = "xDime", EmitDefaultValue = true)]
        public string xDime { get; set; }

        /// <summary>
        /// Informações de manuseio.  * 01 - certificado do expedidor para embarque de animal vivo  * 02 - artigo perigoso conforme Declaração do Expedidor anexa  * 03 - somente em aeronave cargueira  * 04 - artigo perigoso - declaração do expedidor não requerida  * 05 - artigo perigoso em quantidade isenta  * 06 - gelo seco para refrigeração (especificar no campo observações a quantidade)  * 07 - não restrito (especificar a Disposição Especial no campo observações)  * 08 - artigo perigoso em carga consolidada (especificar a quantidade no campo observações)  * 09 - autorização da autoridade governamental anexa (especificar no campo observações)  * 10 - baterias de íons de lítio em conformidade com a Seção II da PI965 - CAO  * 11 - baterias de íons de lítio em conformidade com a Seção II da PI966  * 12 - baterias de íons de lítio em conformidade com a Seção II da PI967  * 13 - baterias de metal lítio em conformidade com a Seção II da PI968 — CAO  * 14 - baterias de metal lítio em conformidade com a Seção II da PI969  * 15 - baterias de metal lítio em conformidade com a Seção II da PI970  * 99 - outro (especificar no campo observações)
        /// </summary>
        /// <value>Informações de manuseio.  * 01 - certificado do expedidor para embarque de animal vivo  * 02 - artigo perigoso conforme Declaração do Expedidor anexa  * 03 - somente em aeronave cargueira  * 04 - artigo perigoso - declaração do expedidor não requerida  * 05 - artigo perigoso em quantidade isenta  * 06 - gelo seco para refrigeração (especificar no campo observações a quantidade)  * 07 - não restrito (especificar a Disposição Especial no campo observações)  * 08 - artigo perigoso em carga consolidada (especificar a quantidade no campo observações)  * 09 - autorização da autoridade governamental anexa (especificar no campo observações)  * 10 - baterias de íons de lítio em conformidade com a Seção II da PI965 - CAO  * 11 - baterias de íons de lítio em conformidade com a Seção II da PI966  * 12 - baterias de íons de lítio em conformidade com a Seção II da PI967  * 13 - baterias de metal lítio em conformidade com a Seção II da PI968 — CAO  * 14 - baterias de metal lítio em conformidade com a Seção II da PI969  * 15 - baterias de metal lítio em conformidade com a Seção II da PI970  * 99 - outro (especificar no campo observações)</value>
        [DataMember(Name = "cInfManu", EmitDefaultValue = false)]
        public List<string> cInfManu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazNatCarga {\n");
            sb.Append("  xDime: ").Append(xDime).Append("\n");
            sb.Append("  cInfManu: ").Append(cInfManu).Append("\n");
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
            return this.Equals(input as CteSefazNatCarga);
        }

        /// <summary>
        /// Returns true if CteSefazNatCarga instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazNatCarga to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazNatCarga input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xDime == input.xDime ||
                    (this.xDime != null &&
                    this.xDime.Equals(input.xDime))
                ) && 
                (
                    this.cInfManu == input.cInfManu ||
                    this.cInfManu != null &&
                    input.cInfManu != null &&
                    this.cInfManu.SequenceEqual(input.cInfManu)
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
                if (this.xDime != null)
                {
                    hashCode = (hashCode * 59) + this.xDime.GetHashCode();
                }
                if (this.cInfManu != null)
                {
                    hashCode = (hashCode * 59) + this.cInfManu.GetHashCode();
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
            // xDime (string) maxLength
            if (this.xDime != null && this.xDime.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDime, length must be less than 14.", new [] { "xDime" });
            }

            // xDime (string) minLength
            if (this.xDime != null && this.xDime.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDime, length must be greater than 5.", new [] { "xDime" });
            }

            yield break;
        }
    }

}
