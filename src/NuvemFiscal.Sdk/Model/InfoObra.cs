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
    /// Grupo de informações do DPS relativas à serviço de obra.
    /// </summary>
    [DataContract(Name = "InfoObra")]
    public partial class InfoObra : IEquatable<InfoObra>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoObra" /> class.
        /// </summary>
        /// <param name="cObra">Número de identificação da obra.  Cadastro Nacional de Obras (CNO) ou Cadastro Específico do INSS (CEI)..</param>
        /// <param name="inscImobFisc">Inscrição imobiliária fiscal (código fornecido pela Prefeitura Municipal para a identificação da obra ou para fins de recolhimento do IPTU)..</param>
        /// <param name="end">end.</param>
        public InfoObra(string cObra = default(string), string inscImobFisc = default(string), EnderecoSimples end = default(EnderecoSimples))
        {
            this.cObra = cObra;
            this.inscImobFisc = inscImobFisc;
            this.end = end;
        }

        /// <summary>
        /// Número de identificação da obra.  Cadastro Nacional de Obras (CNO) ou Cadastro Específico do INSS (CEI).
        /// </summary>
        /// <value>Número de identificação da obra.  Cadastro Nacional de Obras (CNO) ou Cadastro Específico do INSS (CEI).</value>
        [DataMember(Name = "cObra", EmitDefaultValue = false)]
        public string cObra { get; set; }

        /// <summary>
        /// Inscrição imobiliária fiscal (código fornecido pela Prefeitura Municipal para a identificação da obra ou para fins de recolhimento do IPTU).
        /// </summary>
        /// <value>Inscrição imobiliária fiscal (código fornecido pela Prefeitura Municipal para a identificação da obra ou para fins de recolhimento do IPTU).</value>
        [DataMember(Name = "inscImobFisc", EmitDefaultValue = false)]
        public string inscImobFisc { get; set; }

        /// <summary>
        /// Gets or Sets end
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public EnderecoSimples end { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoObra {\n");
            sb.Append("  cObra: ").Append(cObra).Append("\n");
            sb.Append("  inscImobFisc: ").Append(inscImobFisc).Append("\n");
            sb.Append("  end: ").Append(end).Append("\n");
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
            return this.Equals(input as InfoObra);
        }

        /// <summary>
        /// Returns true if InfoObra instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoObra to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoObra input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cObra == input.cObra ||
                    (this.cObra != null &&
                    this.cObra.Equals(input.cObra))
                ) && 
                (
                    this.inscImobFisc == input.inscImobFisc ||
                    (this.inscImobFisc != null &&
                    this.inscImobFisc.Equals(input.inscImobFisc))
                ) && 
                (
                    this.end == input.end ||
                    (this.end != null &&
                    this.end.Equals(input.end))
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
                if (this.cObra != null)
                {
                    hashCode = (hashCode * 59) + this.cObra.GetHashCode();
                }
                if (this.inscImobFisc != null)
                {
                    hashCode = (hashCode * 59) + this.inscImobFisc.GetHashCode();
                }
                if (this.end != null)
                {
                    hashCode = (hashCode * 59) + this.end.GetHashCode();
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
