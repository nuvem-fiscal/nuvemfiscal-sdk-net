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
    /// Informações do modal Aéreo.
    /// </summary>
    [DataContract(Name = "MdfeSefazAereo")]
    public partial class MdfeSefazAereo : IEquatable<MdfeSefazAereo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazAereo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazAereo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazAereo" /> class.
        /// </summary>
        /// <param name="nac">Marca da Nacionalidade da aeronave. (required).</param>
        /// <param name="matr">Marca de Matrícula da aeronave. (required).</param>
        /// <param name="nVoo">Número do Voo.  Formato &#x3D; AB1234, sendo AB a designação da empresa e 1234 o número do voo. Quando não for possível incluir as marcas de nacionalidade e matrícula sem hífen. (required).</param>
        /// <param name="cAerEmb">Aeródromo de Embarque.  O código de três letras IATA do aeroporto de partida deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI. (required).</param>
        /// <param name="cAerDes">Aeródromo de Destino.  O código de três letras IATA do aeroporto de destino deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI. (required).</param>
        /// <param name="dVoo">Data do Voo.  Formato AAAA-MM-DD. (required).</param>
        public MdfeSefazAereo(string nac = default(string), string matr = default(string), string nVoo = default(string), string cAerEmb = default(string), string cAerDes = default(string), DateTime? dVoo = default(DateTime?))
        {
            // to ensure "nac" is required (not null)
            if (nac == null)
            {
                throw new ArgumentNullException("nac is a required property for MdfeSefazAereo and cannot be null");
            }
            this.nac = nac;
            // to ensure "matr" is required (not null)
            if (matr == null)
            {
                throw new ArgumentNullException("matr is a required property for MdfeSefazAereo and cannot be null");
            }
            this.matr = matr;
            // to ensure "nVoo" is required (not null)
            if (nVoo == null)
            {
                throw new ArgumentNullException("nVoo is a required property for MdfeSefazAereo and cannot be null");
            }
            this.nVoo = nVoo;
            // to ensure "cAerEmb" is required (not null)
            if (cAerEmb == null)
            {
                throw new ArgumentNullException("cAerEmb is a required property for MdfeSefazAereo and cannot be null");
            }
            this.cAerEmb = cAerEmb;
            // to ensure "cAerDes" is required (not null)
            if (cAerDes == null)
            {
                throw new ArgumentNullException("cAerDes is a required property for MdfeSefazAereo and cannot be null");
            }
            this.cAerDes = cAerDes;
            // to ensure "dVoo" is required (not null)
            if (dVoo == null)
            {
                throw new ArgumentNullException("dVoo is a required property for MdfeSefazAereo and cannot be null");
            }
            this.dVoo = dVoo;
        }

        /// <summary>
        /// Marca da Nacionalidade da aeronave.
        /// </summary>
        /// <value>Marca da Nacionalidade da aeronave.</value>
        [DataMember(Name = "nac", IsRequired = true, EmitDefaultValue = true)]
        public string nac { get; set; }

        /// <summary>
        /// Marca de Matrícula da aeronave.
        /// </summary>
        /// <value>Marca de Matrícula da aeronave.</value>
        [DataMember(Name = "matr", IsRequired = true, EmitDefaultValue = true)]
        public string matr { get; set; }

        /// <summary>
        /// Número do Voo.  Formato &#x3D; AB1234, sendo AB a designação da empresa e 1234 o número do voo. Quando não for possível incluir as marcas de nacionalidade e matrícula sem hífen.
        /// </summary>
        /// <value>Número do Voo.  Formato &#x3D; AB1234, sendo AB a designação da empresa e 1234 o número do voo. Quando não for possível incluir as marcas de nacionalidade e matrícula sem hífen.</value>
        [DataMember(Name = "nVoo", IsRequired = true, EmitDefaultValue = true)]
        public string nVoo { get; set; }

        /// <summary>
        /// Aeródromo de Embarque.  O código de três letras IATA do aeroporto de partida deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI.
        /// </summary>
        /// <value>Aeródromo de Embarque.  O código de três letras IATA do aeroporto de partida deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI.</value>
        [DataMember(Name = "cAerEmb", IsRequired = true, EmitDefaultValue = true)]
        public string cAerEmb { get; set; }

        /// <summary>
        /// Aeródromo de Destino.  O código de três letras IATA do aeroporto de destino deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI.
        /// </summary>
        /// <value>Aeródromo de Destino.  O código de três letras IATA do aeroporto de destino deverá ser incluído como primeira anotação. Quando não for possível, utilizar a sigla OACI.</value>
        [DataMember(Name = "cAerDes", IsRequired = true, EmitDefaultValue = true)]
        public string cAerDes { get; set; }

        /// <summary>
        /// Data do Voo.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data do Voo.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dVoo", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dVoo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazAereo {\n");
            sb.Append("  nac: ").Append(nac).Append("\n");
            sb.Append("  matr: ").Append(matr).Append("\n");
            sb.Append("  nVoo: ").Append(nVoo).Append("\n");
            sb.Append("  cAerEmb: ").Append(cAerEmb).Append("\n");
            sb.Append("  cAerDes: ").Append(cAerDes).Append("\n");
            sb.Append("  dVoo: ").Append(dVoo).Append("\n");
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
            return this.Equals(input as MdfeSefazAereo);
        }

        /// <summary>
        /// Returns true if MdfeSefazAereo instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazAereo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazAereo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nac == input.nac ||
                    (this.nac != null &&
                    this.nac.Equals(input.nac))
                ) && 
                (
                    this.matr == input.matr ||
                    (this.matr != null &&
                    this.matr.Equals(input.matr))
                ) && 
                (
                    this.nVoo == input.nVoo ||
                    (this.nVoo != null &&
                    this.nVoo.Equals(input.nVoo))
                ) && 
                (
                    this.cAerEmb == input.cAerEmb ||
                    (this.cAerEmb != null &&
                    this.cAerEmb.Equals(input.cAerEmb))
                ) && 
                (
                    this.cAerDes == input.cAerDes ||
                    (this.cAerDes != null &&
                    this.cAerDes.Equals(input.cAerDes))
                ) && 
                (
                    this.dVoo == input.dVoo ||
                    (this.dVoo != null &&
                    this.dVoo.Equals(input.dVoo))
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
                if (this.nac != null)
                {
                    hashCode = (hashCode * 59) + this.nac.GetHashCode();
                }
                if (this.matr != null)
                {
                    hashCode = (hashCode * 59) + this.matr.GetHashCode();
                }
                if (this.nVoo != null)
                {
                    hashCode = (hashCode * 59) + this.nVoo.GetHashCode();
                }
                if (this.cAerEmb != null)
                {
                    hashCode = (hashCode * 59) + this.cAerEmb.GetHashCode();
                }
                if (this.cAerDes != null)
                {
                    hashCode = (hashCode * 59) + this.cAerDes.GetHashCode();
                }
                if (this.dVoo != null)
                {
                    hashCode = (hashCode * 59) + this.dVoo.GetHashCode();
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
            // nac (string) maxLength
            if (this.nac != null && this.nac.Length > 4)
            {
                yield return new ValidationResult("Invalid value for nac, length must be less than 4.", new [] { "nac" });
            }

            // nac (string) minLength
            if (this.nac != null && this.nac.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nac, length must be greater than 1.", new [] { "nac" });
            }

            // matr (string) maxLength
            if (this.matr != null && this.matr.Length > 6)
            {
                yield return new ValidationResult("Invalid value for matr, length must be less than 6.", new [] { "matr" });
            }

            // matr (string) minLength
            if (this.matr != null && this.matr.Length < 1)
            {
                yield return new ValidationResult("Invalid value for matr, length must be greater than 1.", new [] { "matr" });
            }

            // nVoo (string) maxLength
            if (this.nVoo != null && this.nVoo.Length > 9)
            {
                yield return new ValidationResult("Invalid value for nVoo, length must be less than 9.", new [] { "nVoo" });
            }

            // nVoo (string) minLength
            if (this.nVoo != null && this.nVoo.Length < 5)
            {
                yield return new ValidationResult("Invalid value for nVoo, length must be greater than 5.", new [] { "nVoo" });
            }

            // cAerEmb (string) maxLength
            if (this.cAerEmb != null && this.cAerEmb.Length > 4)
            {
                yield return new ValidationResult("Invalid value for cAerEmb, length must be less than 4.", new [] { "cAerEmb" });
            }

            // cAerEmb (string) minLength
            if (this.cAerEmb != null && this.cAerEmb.Length < 3)
            {
                yield return new ValidationResult("Invalid value for cAerEmb, length must be greater than 3.", new [] { "cAerEmb" });
            }

            // cAerDes (string) maxLength
            if (this.cAerDes != null && this.cAerDes.Length > 4)
            {
                yield return new ValidationResult("Invalid value for cAerDes, length must be less than 4.", new [] { "cAerDes" });
            }

            // cAerDes (string) minLength
            if (this.cAerDes != null && this.cAerDes.Length < 3)
            {
                yield return new ValidationResult("Invalid value for cAerDes, length must be greater than 3.", new [] { "cAerDes" });
            }

            yield break;
        }
    }

}
