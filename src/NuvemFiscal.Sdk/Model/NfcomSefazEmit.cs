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
    /// Identificação do Emitente do documento fiscal.
    /// </summary>
    [DataContract(Name = "NfcomSefazEmit")]
    public partial class NfcomSefazEmit : IEquatable<NfcomSefazEmit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazEmit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazEmit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazEmit" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do emitente.  Informar zeros não significativos. (required).</param>
        /// <param name="iE">Inscrição Estadual do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="iEUFDest">Inscrição Estadual Virtual do emitente na UF de Destino da partilha (IE Virtual)..</param>
        /// <param name="cRT">Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xNome">Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="xFant">Nome fantasia do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*.</param>
        /// <param name="enderEmit">enderEmit.</param>
        public NfcomSefazEmit(string cNPJ = default(string), string iE = default(string), string iEUFDest = default(string), int? cRT = default(int?), string xNome = default(string), string xFant = default(string), NfcomSefazEndeEmi enderEmit = default(NfcomSefazEndeEmi))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfcomSefazEmit and cannot be null");
            }
            this.CNPJ = cNPJ;
            this.IE = iE;
            this.IEUFDest = iEUFDest;
            this.CRT = cRT;
            this.xNome = xNome;
            this.xFant = xFant;
            this.enderEmit = enderEmit;
        }

        /// <summary>
        /// CNPJ do emitente.  Informar zeros não significativos.
        /// </summary>
        /// <value>CNPJ do emitente.  Informar zeros não significativos.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Inscrição Estadual do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Inscrição Estadual do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Inscrição Estadual Virtual do emitente na UF de Destino da partilha (IE Virtual).
        /// </summary>
        /// <value>Inscrição Estadual Virtual do emitente na UF de Destino da partilha (IE Virtual).</value>
        [DataMember(Name = "IEUFDest", EmitDefaultValue = true)]
        public string IEUFDest { get; set; }

        /// <summary>
        /// Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal.    *Caso não seja informado, será utilizado o do cadastro da empresa.*
        /// </summary>
        /// <value>Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal.    *Caso não seja informado, será utilizado o do cadastro da empresa.*</value>
        [DataMember(Name = "CRT", EmitDefaultValue = true)]
        public int? CRT { get; set; }

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
        public NfcomSefazEndeEmi enderEmit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazEmit {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  IEUFDest: ").Append(IEUFDest).Append("\n");
            sb.Append("  CRT: ").Append(CRT).Append("\n");
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
            return this.Equals(input as NfcomSefazEmit);
        }

        /// <summary>
        /// Returns true if NfcomSefazEmit instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazEmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazEmit input)
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
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.IEUFDest == input.IEUFDest ||
                    (this.IEUFDest != null &&
                    this.IEUFDest.Equals(input.IEUFDest))
                ) && 
                (
                    this.CRT == input.CRT ||
                    (this.CRT != null &&
                    this.CRT.Equals(input.CRT))
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
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.IEUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.IEUFDest.GetHashCode();
                }
                if (this.CRT != null)
                {
                    hashCode = (hashCode * 59) + this.CRT.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be less than 60.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be greater than 2.", new [] { "xNome" });
            }

            // xFant (string) maxLength
            if (this.xFant != null && this.xFant.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xFant, length must be less than 60.", new [] { "xFant" });
            }

            // xFant (string) minLength
            if (this.xFant != null && this.xFant.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xFant, length must be greater than 1.", new [] { "xFant" });
            }

            yield break;
        }
    }

}
