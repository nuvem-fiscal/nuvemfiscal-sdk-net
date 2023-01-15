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
    /// Dados da NFS-e a ser substituída.
    /// </summary>
    [DataContract(Name = "Substituicao")]
    public partial class Substituicao : IEquatable<Substituicao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Substituicao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Substituicao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Substituicao" /> class.
        /// </summary>
        /// <param name="chSubstda">Chave de acesso da NFS-e a ser substituída. (required).</param>
        /// <param name="cMotivo">Código de justificativa para substituição de NFS-e:  * 01 - Desenquadramento de NFS-e do Simples Nacional  * 02 - Enquadramento de NFS-e no Simples Nacional  * 03 - Inclusão Retroativa de Imunidade/Isenção para NFS-e  * 04 - Exclusão Retroativa de Imunidade/Isenção para NFS-e  * 05 - Rejeição de NFS-e pelo tomador ou pelo intermediário se responsável pelo recolhimento do tributo  * 99 - Outros (required).</param>
        /// <param name="xMotivo">Descrição do motivo da substituição da NFS-e..</param>
        public Substituicao(string chSubstda = default(string), string cMotivo = default(string), string xMotivo = default(string))
        {
            // to ensure "chSubstda" is required (not null)
            if (chSubstda == null)
            {
                throw new ArgumentNullException("chSubstda is a required property for Substituicao and cannot be null");
            }
            this.chSubstda = chSubstda;
            // to ensure "cMotivo" is required (not null)
            if (cMotivo == null)
            {
                throw new ArgumentNullException("cMotivo is a required property for Substituicao and cannot be null");
            }
            this.cMotivo = cMotivo;
            this.xMotivo = xMotivo;
        }

        /// <summary>
        /// Chave de acesso da NFS-e a ser substituída.
        /// </summary>
        /// <value>Chave de acesso da NFS-e a ser substituída.</value>
        [DataMember(Name = "chSubstda", IsRequired = true, EmitDefaultValue = true)]
        public string chSubstda { get; set; }

        /// <summary>
        /// Código de justificativa para substituição de NFS-e:  * 01 - Desenquadramento de NFS-e do Simples Nacional  * 02 - Enquadramento de NFS-e no Simples Nacional  * 03 - Inclusão Retroativa de Imunidade/Isenção para NFS-e  * 04 - Exclusão Retroativa de Imunidade/Isenção para NFS-e  * 05 - Rejeição de NFS-e pelo tomador ou pelo intermediário se responsável pelo recolhimento do tributo  * 99 - Outros
        /// </summary>
        /// <value>Código de justificativa para substituição de NFS-e:  * 01 - Desenquadramento de NFS-e do Simples Nacional  * 02 - Enquadramento de NFS-e no Simples Nacional  * 03 - Inclusão Retroativa de Imunidade/Isenção para NFS-e  * 04 - Exclusão Retroativa de Imunidade/Isenção para NFS-e  * 05 - Rejeição de NFS-e pelo tomador ou pelo intermediário se responsável pelo recolhimento do tributo  * 99 - Outros</value>
        [DataMember(Name = "cMotivo", IsRequired = true, EmitDefaultValue = true)]
        public string cMotivo { get; set; }

        /// <summary>
        /// Descrição do motivo da substituição da NFS-e.
        /// </summary>
        /// <value>Descrição do motivo da substituição da NFS-e.</value>
        [DataMember(Name = "xMotivo", EmitDefaultValue = false)]
        public string xMotivo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Substituicao {\n");
            sb.Append("  chSubstda: ").Append(chSubstda).Append("\n");
            sb.Append("  cMotivo: ").Append(cMotivo).Append("\n");
            sb.Append("  xMotivo: ").Append(xMotivo).Append("\n");
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
            return this.Equals(input as Substituicao);
        }

        /// <summary>
        /// Returns true if Substituicao instances are equal
        /// </summary>
        /// <param name="input">Instance of Substituicao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Substituicao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chSubstda == input.chSubstda ||
                    (this.chSubstda != null &&
                    this.chSubstda.Equals(input.chSubstda))
                ) && 
                (
                    this.cMotivo == input.cMotivo ||
                    (this.cMotivo != null &&
                    this.cMotivo.Equals(input.cMotivo))
                ) && 
                (
                    this.xMotivo == input.xMotivo ||
                    (this.xMotivo != null &&
                    this.xMotivo.Equals(input.xMotivo))
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
                if (this.chSubstda != null)
                {
                    hashCode = (hashCode * 59) + this.chSubstda.GetHashCode();
                }
                if (this.cMotivo != null)
                {
                    hashCode = (hashCode * 59) + this.cMotivo.GetHashCode();
                }
                if (this.xMotivo != null)
                {
                    hashCode = (hashCode * 59) + this.xMotivo.GetHashCode();
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
