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
    /// MdfeSefazInfCIOT
    /// </summary>
    [DataContract(Name = "MdfeSefazInfCIOT")]
    public partial class MdfeSefazInfCIOT : IEquatable<MdfeSefazInfCIOT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfCIOT" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfCIOT() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfCIOT" /> class.
        /// </summary>
        /// <param name="cIOT">Código Identificador da Operação de Transporte.  Também Conhecido como conta frete. (required).</param>
        /// <param name="cPF">Número do CPF responsável pela geração do CIOT.  Informar os zeros não significativos..</param>
        /// <param name="cNPJ">Número do CNPJ responsável pela geração do CIOT.  Informar os zeros não significativos..</param>
        public MdfeSefazInfCIOT(string cIOT = default(string), string cPF = default(string), string cNPJ = default(string))
        {
            // to ensure "cIOT" is required (not null)
            if (cIOT == null)
            {
                throw new ArgumentNullException("cIOT is a required property for MdfeSefazInfCIOT and cannot be null");
            }
            this.CIOT = cIOT;
            this.CPF = cPF;
            this.CNPJ = cNPJ;
        }

        /// <summary>
        /// Código Identificador da Operação de Transporte.  Também Conhecido como conta frete.
        /// </summary>
        /// <value>Código Identificador da Operação de Transporte.  Também Conhecido como conta frete.</value>
        [DataMember(Name = "CIOT", IsRequired = true, EmitDefaultValue = false)]
        public string CIOT { get; set; }

        /// <summary>
        /// Número do CPF responsável pela geração do CIOT.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF responsável pela geração do CIOT.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Número do CNPJ responsável pela geração do CIOT.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ responsável pela geração do CIOT.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfCIOT {\n");
            sb.Append("  CIOT: ").Append(CIOT).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
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
            return this.Equals(input as MdfeSefazInfCIOT);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfCIOT instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfCIOT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfCIOT input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CIOT == input.CIOT ||
                    (this.CIOT != null &&
                    this.CIOT.Equals(input.CIOT))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
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
                if (this.CIOT != null)
                {
                    hashCode = (hashCode * 59) + this.CIOT.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
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
