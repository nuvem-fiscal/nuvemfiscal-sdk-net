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
    /// Identificação do Emitente do CT-e.
    /// </summary>
    [DataContract(Name = "CteSimpSefazEmitSimp")]
    public partial class CteSimpSefazEmitSimp : IEquatable<CteSimpSefazEmitSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazEmitSimp" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***..</param>
        /// <param name="cPF">CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.    ***Obrigatorio caso o emitente seja pessoa física***..</param>
        /// <param name="iE">Inscrição Estadual do Emitente.  A IE do emitente somente ficará sem informação para o caso do Regime Especial da NFF (tpEmis&#x3D;3).    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="iEST">Inscrição Estadual do Substituto Tributário..</param>
        /// <param name="xNome">Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xFant">Nome fantasia.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="enderEmit">enderEmit.</param>
        /// <param name="cRT">Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal;  * 4 - Simples Nacional - Microempreendedor Individual (MEI).    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        public CteSimpSefazEmitSimp(string cNPJ = default(string), string cPF = default(string), string iE = default(string), string iEST = default(string), string xNome = default(string), string xFant = default(string), CteSimpSefazEndeEmiSimp enderEmit = default(CteSimpSefazEndeEmiSimp), int? cRT = default(int?))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.IE = iE;
            this.IEST = iEST;
            this.xNome = xNome;
            this.xFant = xFant;
            this.enderEmit = enderEmit;
            this.CRT = cRT;
        }

        /// <summary>
        /// CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***.
        /// </summary>
        /// <value>CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.    ***Obrigatorio caso o emitente seja pessoa física***.
        /// </summary>
        /// <value>CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.    ***Obrigatorio caso o emitente seja pessoa física***.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Inscrição Estadual do Emitente.  A IE do emitente somente ficará sem informação para o caso do Regime Especial da NFF (tpEmis&#x3D;3).    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Inscrição Estadual do Emitente.  A IE do emitente somente ficará sem informação para o caso do Regime Especial da NFF (tpEmis&#x3D;3).    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Inscrição Estadual do Substituto Tributário.
        /// </summary>
        /// <value>Inscrição Estadual do Substituto Tributário.</value>
        [DataMember(Name = "IEST", EmitDefaultValue = true)]
        public string IEST { get; set; }

        /// <summary>
        /// Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xNome", EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Nome fantasia.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Nome fantasia.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "xFant", EmitDefaultValue = true)]
        public string xFant { get; set; }

        /// <summary>
        /// Gets or Sets enderEmit
        /// </summary>
        [DataMember(Name = "enderEmit", EmitDefaultValue = false)]
        public CteSimpSefazEndeEmiSimp enderEmit { get; set; }

        /// <summary>
        /// Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal;  * 4 - Simples Nacional - Microempreendedor Individual (MEI).    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal;  * 4 - Simples Nacional - Microempreendedor Individual (MEI).    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "CRT", EmitDefaultValue = true)]
        public int? CRT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazEmitSimp {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  IEST: ").Append(IEST).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  xFant: ").Append(xFant).Append("\n");
            sb.Append("  enderEmit: ").Append(enderEmit).Append("\n");
            sb.Append("  CRT: ").Append(CRT).Append("\n");
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
            return this.Equals(input as CteSimpSefazEmitSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazEmitSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazEmitSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazEmitSimp input)
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
                    this.IEST == input.IEST ||
                    (this.IEST != null &&
                    this.IEST.Equals(input.IEST))
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
                ) && 
                (
                    this.CRT == input.CRT ||
                    (this.CRT != null &&
                    this.CRT.Equals(input.CRT))
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
                if (this.IEST != null)
                {
                    hashCode = (hashCode * 59) + this.IEST.GetHashCode();
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
                if (this.CRT != null)
                {
                    hashCode = (hashCode * 59) + this.CRT.GetHashCode();
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
            if (this.xFant != null && this.xFant.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xFant, length must be greater than 2.", new [] { "xFant" });
            }

            yield break;
        }
    }

}
