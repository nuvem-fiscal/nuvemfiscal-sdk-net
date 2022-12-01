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
    /// NfeSefazEmit
    /// </summary>
    [DataContract(Name = "NfeSefazEmit")]
    public partial class NfeSefazEmit : IEquatable<NfeSefazEmit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazEmit" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ do emitente.  Obrigatório caso o emitente seja pessoa jurídica..</param>
        /// <param name="cPF">Número do CPF do emitente.  Obrigatorio caso o emitente seja pessoa física..</param>
        /// <param name="xNome">Razão Social ou Nome do emitente.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="xFant">Nome fantasia.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="enderEmit">enderEmit.</param>
        /// <param name="iE">Inscrição Estadual do Emitente.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="iEST">Inscricao Estadual do Substituto Tributário.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="iM">Inscrição Municipal.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="cNAE">CNAE Fiscal.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="cRT">Código de Regime Tributário.   Este campo será obrigatoriamente preenchido com:  1 – Simples Nacional;  2 – Simples Nacional – excesso de sublimite de receita bruta;  3 – Regime Normal.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        public NfeSefazEmit(string cNPJ = default(string), string cPF = default(string), string xNome = default(string), string xFant = default(string), NfeSefazEnderEmi enderEmit = default(NfeSefazEnderEmi), string iE = default(string), string iEST = default(string), string iM = default(string), string cNAE = default(string), int cRT = default(int))
        {
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.xNome = xNome;
            this.xFant = xFant;
            this.enderEmit = enderEmit;
            this.IE = iE;
            this.IEST = iEST;
            this.IM = iM;
            this.CNAE = cNAE;
            this.CRT = cRT;
        }

        /// <summary>
        /// Número do CNPJ do emitente.  Obrigatório caso o emitente seja pessoa jurídica.
        /// </summary>
        /// <value>Número do CNPJ do emitente.  Obrigatório caso o emitente seja pessoa jurídica.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número do CPF do emitente.  Obrigatorio caso o emitente seja pessoa física.
        /// </summary>
        /// <value>Número do CPF do emitente.  Obrigatorio caso o emitente seja pessoa física.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Razão Social ou Nome do emitente.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Razão Social ou Nome do emitente.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = false)]
        public string xNome { get; set; }

        /// <summary>
        /// Nome fantasia.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Nome fantasia.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xFant", EmitDefaultValue = false)]
        public string xFant { get; set; }

        /// <summary>
        /// Gets or Sets enderEmit
        /// </summary>
        [DataMember(Name = "enderEmit", EmitDefaultValue = false)]
        public NfeSefazEnderEmi enderEmit { get; set; }

        /// <summary>
        /// Inscrição Estadual do Emitente.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Inscrição Estadual do Emitente.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "IE", EmitDefaultValue = false)]
        public string IE { get; set; }

        /// <summary>
        /// Inscricao Estadual do Substituto Tributário.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Inscricao Estadual do Substituto Tributário.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "IEST", EmitDefaultValue = false)]
        public string IEST { get; set; }

        /// <summary>
        /// Inscrição Municipal.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Inscrição Municipal.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "IM", EmitDefaultValue = false)]
        public string IM { get; set; }

        /// <summary>
        /// CNAE Fiscal.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>CNAE Fiscal.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "CNAE", EmitDefaultValue = false)]
        public string CNAE { get; set; }

        /// <summary>
        /// Código de Regime Tributário.   Este campo será obrigatoriamente preenchido com:  1 – Simples Nacional;  2 – Simples Nacional – excesso de sublimite de receita bruta;  3 – Regime Normal.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Código de Regime Tributário.   Este campo será obrigatoriamente preenchido com:  1 – Simples Nacional;  2 – Simples Nacional – excesso de sublimite de receita bruta;  3 – Regime Normal.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "CRT", EmitDefaultValue = false)]
        public int CRT { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazEmit {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  xFant: ").Append(xFant).Append("\n");
            sb.Append("  enderEmit: ").Append(enderEmit).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  IEST: ").Append(IEST).Append("\n");
            sb.Append("  IM: ").Append(IM).Append("\n");
            sb.Append("  CNAE: ").Append(CNAE).Append("\n");
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
            return this.Equals(input as NfeSefazEmit);
        }

        /// <summary>
        /// Returns true if NfeSefazEmit instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazEmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazEmit input)
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
                    this.IM == input.IM ||
                    (this.IM != null &&
                    this.IM.Equals(input.IM))
                ) && 
                (
                    this.CNAE == input.CNAE ||
                    (this.CNAE != null &&
                    this.CNAE.Equals(input.CNAE))
                ) && 
                (
                    this.CRT == input.CRT ||
                    this.CRT.Equals(input.CRT)
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
                if (this.xFant != null)
                {
                    hashCode = (hashCode * 59) + this.xFant.GetHashCode();
                }
                if (this.enderEmit != null)
                {
                    hashCode = (hashCode * 59) + this.enderEmit.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.IEST != null)
                {
                    hashCode = (hashCode * 59) + this.IEST.GetHashCode();
                }
                if (this.IM != null)
                {
                    hashCode = (hashCode * 59) + this.IM.GetHashCode();
                }
                if (this.CNAE != null)
                {
                    hashCode = (hashCode * 59) + this.CNAE.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CRT.GetHashCode();
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
