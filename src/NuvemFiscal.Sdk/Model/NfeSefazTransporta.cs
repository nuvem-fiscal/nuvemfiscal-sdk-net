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
    /// NfeSefazTransporta
    /// </summary>
    [DataContract(Name = "NfeSefazTransporta")]
    public partial class NfeSefazTransporta : IEquatable<NfeSefazTransporta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTransporta" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do transportador..</param>
        /// <param name="cPF">CPF do transportador..</param>
        /// <param name="xNome">Razão Social ou nome do transportador..</param>
        /// <param name="iE">Inscrição Estadual (v2.0)..</param>
        /// <param name="xEnder">Endereço completo..</param>
        /// <param name="xMun">Nome do munícipio..</param>
        /// <param name="uF">Sigla da UF..</param>
        public NfeSefazTransporta(string cNPJ = default(string), string cPF = default(string), string xNome = default(string), string iE = default(string), string xEnder = default(string), string xMun = default(string), string uF = default(string))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.xNome = xNome;
            this.IE = iE;
            this.xEnder = xEnder;
            this.xMun = xMun;
            this.UF = uF;
        }

        /// <summary>
        /// CNPJ do transportador.
        /// </summary>
        /// <value>CNPJ do transportador.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do transportador.
        /// </summary>
        /// <value>CPF do transportador.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Razão Social ou nome do transportador.
        /// </summary>
        /// <value>Razão Social ou nome do transportador.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = false)]
        public string xNome { get; set; }

        /// <summary>
        /// Inscrição Estadual (v2.0).
        /// </summary>
        /// <value>Inscrição Estadual (v2.0).</value>
        [DataMember(Name = "IE", EmitDefaultValue = false)]
        public string IE { get; set; }

        /// <summary>
        /// Endereço completo.
        /// </summary>
        /// <value>Endereço completo.</value>
        [DataMember(Name = "xEnder", EmitDefaultValue = false)]
        public string xEnder { get; set; }

        /// <summary>
        /// Nome do munícipio.
        /// </summary>
        /// <value>Nome do munícipio.</value>
        [DataMember(Name = "xMun", EmitDefaultValue = false)]
        public string xMun { get; set; }

        /// <summary>
        /// Sigla da UF.
        /// </summary>
        /// <value>Sigla da UF.</value>
        [DataMember(Name = "UF", EmitDefaultValue = false)]
        public string UF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazTransporta {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  xEnder: ").Append(xEnder).Append("\n");
            sb.Append("  xMun: ").Append(xMun).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
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
            return this.Equals(input as NfeSefazTransporta);
        }

        /// <summary>
        /// Returns true if NfeSefazTransporta instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazTransporta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazTransporta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.xEnder == input.xEnder ||
                    (this.xEnder != null &&
                    this.xEnder.Equals(input.xEnder))
                ) && 
                (
                    this.xMun == input.xMun ||
                    (this.xMun != null &&
                    this.xMun.Equals(input.xMun))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.xEnder != null)
                {
                    hashCode = (hashCode * 59) + this.xEnder.GetHashCode();
                }
                if (this.xMun != null)
                {
                    hashCode = (hashCode * 59) + this.xMun.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
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
