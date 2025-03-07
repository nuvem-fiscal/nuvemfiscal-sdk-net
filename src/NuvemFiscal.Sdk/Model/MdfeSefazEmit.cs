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
    /// Identificação do Emitente do Manifesto.
    /// </summary>
    [DataContract(Name = "MdfeSefazEmit")]
    public partial class MdfeSefazEmit : IEquatable<MdfeSefazEmit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazEmit" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***..</param>
        /// <param name="cPF">CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.  Poderá ser usado também para emissão do Regime Especial da Nota Fiscal Fácil.    ***Obrigatorio caso o emitente seja pessoa física***..</param>
        /// <param name="iE">Inscrição Estadual do emitemte.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xNome">Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xFant">Nome fantasia do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="enderEmit">enderEmit.</param>
        public MdfeSefazEmit(string cNPJ = default(string), string cPF = default(string), string iE = default(string), string xNome = default(string), string xFant = default(string), MdfeSefazEndeEmi enderEmit = default(MdfeSefazEndeEmi))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.IE = iE;
            this.xNome = xNome;
            this.xFant = xFant;
            this.enderEmit = enderEmit;
        }

        /// <summary>
        /// CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***.
        /// </summary>
        /// <value>CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.  Poderá ser usado também para emissão do Regime Especial da Nota Fiscal Fácil.    ***Obrigatorio caso o emitente seja pessoa física***.
        /// </summary>
        /// <value>CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.  Poderá ser usado também para emissão do Regime Especial da Nota Fiscal Fácil.    ***Obrigatorio caso o emitente seja pessoa física***.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Inscrição Estadual do emitemte.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Inscrição Estadual do emitemte.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xNome", EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Nome fantasia do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Nome fantasia do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xFant", EmitDefaultValue = true)]
        public string xFant { get; set; }

        /// <summary>
        /// Gets or Sets enderEmit
        /// </summary>
        [DataMember(Name = "enderEmit", EmitDefaultValue = false)]
        public MdfeSefazEndeEmi enderEmit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazEmit {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  xFant: ").Append(xFant).Append("\n");
            sb.Append("  enderEmit: ").Append(enderEmit).Append("\n");
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
            return this.Equals(input as MdfeSefazEmit);
        }

        /// <summary>
        /// Returns true if MdfeSefazEmit instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazEmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazEmit input)
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
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.xFant == input.xFant ||
                    (this.xFant != null &&
                    this.xFant.Equals(input.xFant))
                ) && 
                (
                    this.enderEmit == input.enderEmit ||
                    (this.enderEmit != null &&
                    this.enderEmit.Equals(input.enderEmit))
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
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.xFant != null)
                {
                    hashCode = (hashCode * 59) + this.xFant.GetHashCode();
                }
                if (this.enderEmit != null)
                {
                    hashCode = (hashCode * 59) + this.enderEmit.GetHashCode();
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
            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be less than 60.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xNome, length must be greater than 2.", new [] { "xNome" });
            }

            // xFant (string) maxLength
            if (this.xFant != null && this.xFant.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xFant, length must be less than 60.", new [] { "xFant" });
            }

            // xFant (string) minLength
            if (this.xFant != null && this.xFant.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xFant, length must be greater than 1.", new [] { "xFant" });
            }

            yield break;
        }
    }

}
