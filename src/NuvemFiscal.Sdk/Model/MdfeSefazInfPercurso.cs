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
    /// Informações do Percurso do MDF-e.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfPercurso")]
    public partial class MdfeSefazInfPercurso : IEquatable<MdfeSefazInfPercurso>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPercurso" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfPercurso() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPercurso" /> class.
        /// </summary>
        /// <param name="uFPer">Sigla das Unidades da Federação do percurso do veículo.  Não é necessário repetir as UF de Início e Fim. (required).</param>
        public MdfeSefazInfPercurso(string uFPer = default(string))
        {
            // to ensure "uFPer" is required (not null)
            if (uFPer == null)
            {
                throw new ArgumentNullException("uFPer is a required property for MdfeSefazInfPercurso and cannot be null");
            }
            this.UFPer = uFPer;
        }

        /// <summary>
        /// Sigla das Unidades da Federação do percurso do veículo.  Não é necessário repetir as UF de Início e Fim.
        /// </summary>
        /// <value>Sigla das Unidades da Federação do percurso do veículo.  Não é necessário repetir as UF de Início e Fim.</value>
        [DataMember(Name = "UFPer", IsRequired = true, EmitDefaultValue = true)]
        public string UFPer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfPercurso {\n");
            sb.Append("  UFPer: ").Append(UFPer).Append("\n");
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
            return this.Equals(input as MdfeSefazInfPercurso);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfPercurso instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfPercurso to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfPercurso input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UFPer == input.UFPer ||
                    (this.UFPer != null &&
                    this.UFPer.Equals(input.UFPer))
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
                if (this.UFPer != null)
                {
                    hashCode = (hashCode * 59) + this.UFPer.GetHashCode();
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
