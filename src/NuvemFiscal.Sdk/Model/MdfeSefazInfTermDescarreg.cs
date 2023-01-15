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
    /// Grupo de informações dos terminais de descarregamento.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfTermDescarreg")]
    public partial class MdfeSefazInfTermDescarreg : IEquatable<MdfeSefazInfTermDescarreg>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfTermDescarreg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfTermDescarreg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfTermDescarreg" /> class.
        /// </summary>
        /// <param name="cTermDescarreg">Código do Terminal de Descarregamento.  Preencher de acordo com a Tabela de Terminais de Descarregamento. O código de cada Porto está definido no Ministério de Transportes. (required).</param>
        /// <param name="xTermDescarreg">Nome do Terminal de Descarregamento. (required).</param>
        public MdfeSefazInfTermDescarreg(string cTermDescarreg = default(string), string xTermDescarreg = default(string))
        {
            // to ensure "cTermDescarreg" is required (not null)
            if (cTermDescarreg == null)
            {
                throw new ArgumentNullException("cTermDescarreg is a required property for MdfeSefazInfTermDescarreg and cannot be null");
            }
            this.cTermDescarreg = cTermDescarreg;
            // to ensure "xTermDescarreg" is required (not null)
            if (xTermDescarreg == null)
            {
                throw new ArgumentNullException("xTermDescarreg is a required property for MdfeSefazInfTermDescarreg and cannot be null");
            }
            this.xTermDescarreg = xTermDescarreg;
        }

        /// <summary>
        /// Código do Terminal de Descarregamento.  Preencher de acordo com a Tabela de Terminais de Descarregamento. O código de cada Porto está definido no Ministério de Transportes.
        /// </summary>
        /// <value>Código do Terminal de Descarregamento.  Preencher de acordo com a Tabela de Terminais de Descarregamento. O código de cada Porto está definido no Ministério de Transportes.</value>
        [DataMember(Name = "cTermDescarreg", IsRequired = true, EmitDefaultValue = true)]
        public string cTermDescarreg { get; set; }

        /// <summary>
        /// Nome do Terminal de Descarregamento.
        /// </summary>
        /// <value>Nome do Terminal de Descarregamento.</value>
        [DataMember(Name = "xTermDescarreg", IsRequired = true, EmitDefaultValue = true)]
        public string xTermDescarreg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfTermDescarreg {\n");
            sb.Append("  cTermDescarreg: ").Append(cTermDescarreg).Append("\n");
            sb.Append("  xTermDescarreg: ").Append(xTermDescarreg).Append("\n");
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
            return this.Equals(input as MdfeSefazInfTermDescarreg);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfTermDescarreg instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfTermDescarreg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfTermDescarreg input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cTermDescarreg == input.cTermDescarreg ||
                    (this.cTermDescarreg != null &&
                    this.cTermDescarreg.Equals(input.cTermDescarreg))
                ) && 
                (
                    this.xTermDescarreg == input.xTermDescarreg ||
                    (this.xTermDescarreg != null &&
                    this.xTermDescarreg.Equals(input.xTermDescarreg))
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
                if (this.cTermDescarreg != null)
                {
                    hashCode = (hashCode * 59) + this.cTermDescarreg.GetHashCode();
                }
                if (this.xTermDescarreg != null)
                {
                    hashCode = (hashCode * 59) + this.xTermDescarreg.GetHashCode();
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
