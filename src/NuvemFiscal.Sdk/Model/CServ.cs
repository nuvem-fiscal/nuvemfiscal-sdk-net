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
    /// Grupo de informações relativas ao código do serviço prestado.
    /// </summary>
    [DataContract(Name = "CServ")]
    public partial class CServ : IEquatable<CServ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CServ" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CServ() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CServ" /> class.
        /// </summary>
        /// <param name="cTribNac">Código de tributação nacional do ISSQN:  Regra de formação - 6 dígitos numéricos sendo: 2 para Item (LC 116/2003), 2 para Subitem (LC 116/2003) e 2 para Desdobro Nacional. (required).</param>
        /// <param name="cTribMun">Código de tributação municipal do ISSQN..</param>
        /// <param name="cNAE">Código CNAE (Classificação Nacional de Atividades Econômicas)..</param>
        /// <param name="xDescServ">Descrição completa do serviço prestado. (required).</param>
        /// <param name="cNBS">Código NBS (Nomenclatura Brasileira de Serviços, Intangíveis e outras Operações que produzam Variações no Patrimônio) correspondente ao serviço prestado..</param>
        public CServ(string cTribNac = default(string), string cTribMun = default(string), string cNAE = default(string), string xDescServ = default(string), string cNBS = default(string))
        {
            // to ensure "cTribNac" is required (not null)
            if (cTribNac == null)
            {
                throw new ArgumentNullException("cTribNac is a required property for CServ and cannot be null");
            }
            this.cTribNac = cTribNac;
            // to ensure "xDescServ" is required (not null)
            if (xDescServ == null)
            {
                throw new ArgumentNullException("xDescServ is a required property for CServ and cannot be null");
            }
            this.xDescServ = xDescServ;
            this.cTribMun = cTribMun;
            this.CNAE = cNAE;
            this.cNBS = cNBS;
        }

        /// <summary>
        /// Código de tributação nacional do ISSQN:  Regra de formação - 6 dígitos numéricos sendo: 2 para Item (LC 116/2003), 2 para Subitem (LC 116/2003) e 2 para Desdobro Nacional.
        /// </summary>
        /// <value>Código de tributação nacional do ISSQN:  Regra de formação - 6 dígitos numéricos sendo: 2 para Item (LC 116/2003), 2 para Subitem (LC 116/2003) e 2 para Desdobro Nacional.</value>
        [DataMember(Name = "cTribNac", IsRequired = true, EmitDefaultValue = true)]
        public string cTribNac { get; set; }

        /// <summary>
        /// Código de tributação municipal do ISSQN.
        /// </summary>
        /// <value>Código de tributação municipal do ISSQN.</value>
        [DataMember(Name = "cTribMun", EmitDefaultValue = false)]
        public string cTribMun { get; set; }

        /// <summary>
        /// Código CNAE (Classificação Nacional de Atividades Econômicas).
        /// </summary>
        /// <value>Código CNAE (Classificação Nacional de Atividades Econômicas).</value>
        [DataMember(Name = "CNAE", EmitDefaultValue = false)]
        public string CNAE { get; set; }

        /// <summary>
        /// Descrição completa do serviço prestado.
        /// </summary>
        /// <value>Descrição completa do serviço prestado.</value>
        [DataMember(Name = "xDescServ", IsRequired = true, EmitDefaultValue = true)]
        public string xDescServ { get; set; }

        /// <summary>
        /// Código NBS (Nomenclatura Brasileira de Serviços, Intangíveis e outras Operações que produzam Variações no Patrimônio) correspondente ao serviço prestado.
        /// </summary>
        /// <value>Código NBS (Nomenclatura Brasileira de Serviços, Intangíveis e outras Operações que produzam Variações no Patrimônio) correspondente ao serviço prestado.</value>
        [DataMember(Name = "cNBS", EmitDefaultValue = false)]
        public string cNBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CServ {\n");
            sb.Append("  cTribNac: ").Append(cTribNac).Append("\n");
            sb.Append("  cTribMun: ").Append(cTribMun).Append("\n");
            sb.Append("  CNAE: ").Append(CNAE).Append("\n");
            sb.Append("  xDescServ: ").Append(xDescServ).Append("\n");
            sb.Append("  cNBS: ").Append(cNBS).Append("\n");
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
            return this.Equals(input as CServ);
        }

        /// <summary>
        /// Returns true if CServ instances are equal
        /// </summary>
        /// <param name="input">Instance of CServ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CServ input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cTribNac == input.cTribNac ||
                    (this.cTribNac != null &&
                    this.cTribNac.Equals(input.cTribNac))
                ) && 
                (
                    this.cTribMun == input.cTribMun ||
                    (this.cTribMun != null &&
                    this.cTribMun.Equals(input.cTribMun))
                ) && 
                (
                    this.CNAE == input.CNAE ||
                    (this.CNAE != null &&
                    this.CNAE.Equals(input.CNAE))
                ) && 
                (
                    this.xDescServ == input.xDescServ ||
                    (this.xDescServ != null &&
                    this.xDescServ.Equals(input.xDescServ))
                ) && 
                (
                    this.cNBS == input.cNBS ||
                    (this.cNBS != null &&
                    this.cNBS.Equals(input.cNBS))
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
                if (this.cTribNac != null)
                {
                    hashCode = (hashCode * 59) + this.cTribNac.GetHashCode();
                }
                if (this.cTribMun != null)
                {
                    hashCode = (hashCode * 59) + this.cTribMun.GetHashCode();
                }
                if (this.CNAE != null)
                {
                    hashCode = (hashCode * 59) + this.CNAE.GetHashCode();
                }
                if (this.xDescServ != null)
                {
                    hashCode = (hashCode * 59) + this.xDescServ.GetHashCode();
                }
                if (this.cNBS != null)
                {
                    hashCode = (hashCode * 59) + this.cNBS.GetHashCode();
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
