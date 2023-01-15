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
    /// Grupo de informações do contrato entre transportador e contratante.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfContrato")]
    public partial class MdfeSefazInfContrato : IEquatable<MdfeSefazInfContrato>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfContrato" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfContrato() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfContrato" /> class.
        /// </summary>
        /// <param name="nroContrato">Número do contrato do transportador com o contratante quando este existir para prestações continuadas. (required).</param>
        /// <param name="vContratoGlobal">Valor global do contrato. (required).</param>
        public MdfeSefazInfContrato(string nroContrato = default(string), decimal vContratoGlobal = default(decimal))
        {
            // to ensure "nroContrato" is required (not null)
            if (nroContrato == null)
            {
                throw new ArgumentNullException("nroContrato is a required property for MdfeSefazInfContrato and cannot be null");
            }
            this.NroContrato = nroContrato;
            this.vContratoGlobal = vContratoGlobal;
        }

        /// <summary>
        /// Número do contrato do transportador com o contratante quando este existir para prestações continuadas.
        /// </summary>
        /// <value>Número do contrato do transportador com o contratante quando este existir para prestações continuadas.</value>
        [DataMember(Name = "NroContrato", IsRequired = true, EmitDefaultValue = true)]
        public string NroContrato { get; set; }

        /// <summary>
        /// Valor global do contrato.
        /// </summary>
        /// <value>Valor global do contrato.</value>
        [DataMember(Name = "vContratoGlobal", IsRequired = true, EmitDefaultValue = true)]
        public decimal vContratoGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfContrato {\n");
            sb.Append("  NroContrato: ").Append(NroContrato).Append("\n");
            sb.Append("  vContratoGlobal: ").Append(vContratoGlobal).Append("\n");
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
            return this.Equals(input as MdfeSefazInfContrato);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfContrato instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfContrato to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfContrato input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NroContrato == input.NroContrato ||
                    (this.NroContrato != null &&
                    this.NroContrato.Equals(input.NroContrato))
                ) && 
                (
                    this.vContratoGlobal == input.vContratoGlobal ||
                    this.vContratoGlobal.Equals(input.vContratoGlobal)
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
                if (this.NroContrato != null)
                {
                    hashCode = (hashCode * 59) + this.NroContrato.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vContratoGlobal.GetHashCode();
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
