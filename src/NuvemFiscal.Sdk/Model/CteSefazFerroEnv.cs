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
    /// Informações das Ferrovias Envolvidas.
    /// </summary>
    [DataContract(Name = "CteSefazFerroEnv")]
    public partial class CteSefazFerroEnv : IEquatable<CteSefazFerroEnv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazFerroEnv" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazFerroEnv() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazFerroEnv" /> class.
        /// </summary>
        /// <param name="cNPJ">Número do CNPJ.  Informar o CNPJ da Ferrovia Envolvida. Caso a Ferrovia envolvida não seja inscrita no CNPJ o campo deverá preenchido com zeros.  Informar os zeros não significativos. (required).</param>
        /// <param name="cInt">Código interno da Ferrovia envolvida.  Uso da transportadora..</param>
        /// <param name="iE">Inscrição Estadual..</param>
        /// <param name="xNome">Razão Social ou Nome. (required).</param>
        /// <param name="enderFerro">enderFerro (required).</param>
        public CteSefazFerroEnv(string cNPJ = default(string), string cInt = default(string), string iE = default(string), string xNome = default(string), CteSefazEnderFer enderFerro = default(CteSefazEnderFer))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for CteSefazFerroEnv and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for CteSefazFerroEnv and cannot be null");
            }
            this.xNome = xNome;
            // to ensure "enderFerro" is required (not null)
            if (enderFerro == null)
            {
                throw new ArgumentNullException("enderFerro is a required property for CteSefazFerroEnv and cannot be null");
            }
            this.enderFerro = enderFerro;
            this.cInt = cInt;
            this.IE = iE;
        }

        /// <summary>
        /// Número do CNPJ.  Informar o CNPJ da Ferrovia Envolvida. Caso a Ferrovia envolvida não seja inscrita no CNPJ o campo deverá preenchido com zeros.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Informar o CNPJ da Ferrovia Envolvida. Caso a Ferrovia envolvida não seja inscrita no CNPJ o campo deverá preenchido com zeros.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Código interno da Ferrovia envolvida.  Uso da transportadora.
        /// </summary>
        /// <value>Código interno da Ferrovia envolvida.  Uso da transportadora.</value>
        [DataMember(Name = "cInt", EmitDefaultValue = true)]
        public string cInt { get; set; }

        /// <summary>
        /// Inscrição Estadual.
        /// </summary>
        /// <value>Inscrição Estadual.</value>
        [DataMember(Name = "IE", EmitDefaultValue = true)]
        public string IE { get; set; }

        /// <summary>
        /// Razão Social ou Nome.
        /// </summary>
        /// <value>Razão Social ou Nome.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Gets or Sets enderFerro
        /// </summary>
        [DataMember(Name = "enderFerro", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazEnderFer enderFerro { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazFerroEnv {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  cInt: ").Append(cInt).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  enderFerro: ").Append(enderFerro).Append("\n");
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
            return this.Equals(input as CteSefazFerroEnv);
        }

        /// <summary>
        /// Returns true if CteSefazFerroEnv instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazFerroEnv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazFerroEnv input)
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
                    this.cInt == input.cInt ||
                    (this.cInt != null &&
                    this.cInt.Equals(input.cInt))
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
                    this.enderFerro == input.enderFerro ||
                    (this.enderFerro != null &&
                    this.enderFerro.Equals(input.enderFerro))
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
                if (this.cInt != null)
                {
                    hashCode = (hashCode * 59) + this.cInt.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.enderFerro != null)
                {
                    hashCode = (hashCode * 59) + this.enderFerro.GetHashCode();
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
