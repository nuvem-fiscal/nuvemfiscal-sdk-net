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
    /// MdfeSefazInfTermCarreg
    /// </summary>
    [DataContract(Name = "MdfeSefazInfTermCarreg")]
    public partial class MdfeSefazInfTermCarreg : IEquatable<MdfeSefazInfTermCarreg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfTermCarreg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfTermCarreg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfTermCarreg" /> class.
        /// </summary>
        /// <param name="cTermCarreg">Código do Terminal de Carregamento.  Preencher de acordo com a Tabela de Terminais de Carregamento. O código de cada Porto está definido no Ministério de Transportes. (required).</param>
        /// <param name="xTermCarreg">Nome do Terminal de Carregamento. (required).</param>
        public MdfeSefazInfTermCarreg(string cTermCarreg = default(string), string xTermCarreg = default(string))
        {
            // to ensure "cTermCarreg" is required (not null)
            if (cTermCarreg == null)
            {
                throw new ArgumentNullException("cTermCarreg is a required property for MdfeSefazInfTermCarreg and cannot be null");
            }
            this.cTermCarreg = cTermCarreg;
            // to ensure "xTermCarreg" is required (not null)
            if (xTermCarreg == null)
            {
                throw new ArgumentNullException("xTermCarreg is a required property for MdfeSefazInfTermCarreg and cannot be null");
            }
            this.xTermCarreg = xTermCarreg;
        }

        /// <summary>
        /// Código do Terminal de Carregamento.  Preencher de acordo com a Tabela de Terminais de Carregamento. O código de cada Porto está definido no Ministério de Transportes.
        /// </summary>
        /// <value>Código do Terminal de Carregamento.  Preencher de acordo com a Tabela de Terminais de Carregamento. O código de cada Porto está definido no Ministério de Transportes.</value>
        [DataMember(Name = "cTermCarreg", IsRequired = true, EmitDefaultValue = false)]
        public string cTermCarreg { get; set; }

        /// <summary>
        /// Nome do Terminal de Carregamento.
        /// </summary>
        /// <value>Nome do Terminal de Carregamento.</value>
        [DataMember(Name = "xTermCarreg", IsRequired = true, EmitDefaultValue = false)]
        public string xTermCarreg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfTermCarreg {\n");
            sb.Append("  cTermCarreg: ").Append(cTermCarreg).Append("\n");
            sb.Append("  xTermCarreg: ").Append(xTermCarreg).Append("\n");
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
            return this.Equals(input as MdfeSefazInfTermCarreg);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfTermCarreg instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfTermCarreg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfTermCarreg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cTermCarreg == input.cTermCarreg ||
                    (this.cTermCarreg != null &&
                    this.cTermCarreg.Equals(input.cTermCarreg))
                ) && 
                (
                    this.xTermCarreg == input.xTermCarreg ||
                    (this.xTermCarreg != null &&
                    this.xTermCarreg.Equals(input.xTermCarreg))
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
                if (this.cTermCarreg != null)
                {
                    hashCode = (hashCode * 59) + this.cTermCarreg.GetHashCode();
                }
                if (this.xTermCarreg != null)
                {
                    hashCode = (hashCode * 59) + this.xTermCarreg.GetHashCode();
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
