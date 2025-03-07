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
    /// Dados do Veículo com a Tração.
    /// </summary>
    [DataContract(Name = "MdfeSefazVeicTracao")]
    public partial class MdfeSefazVeicTracao : IEquatable<MdfeSefazVeicTracao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazVeicTracao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazVeicTracao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazVeicTracao" /> class.
        /// </summary>
        /// <param name="cInt">Código interno do veículo..</param>
        /// <param name="placa">Placa do veículo. (required).</param>
        /// <param name="rENAVAM">RENAVAM do veículo..</param>
        /// <param name="tara">Tara em KG. (required).</param>
        /// <param name="capKG">Capacidade em KG..</param>
        /// <param name="capM3">Capacidade em M3..</param>
        /// <param name="prop">prop.</param>
        /// <param name="condutor">condutor (required).</param>
        /// <param name="tpRod">Tipo de Rodado.  Preencher com:  * 01 - Truck  * 02 - Toco  * 03 - Cavalo Mecânico  * 04 - VAN  * 05 - Utilitário  * 06 - Outros (required).</param>
        /// <param name="tpCar">Tipo de Carroceria.  Preencher com:  * 00 - não aplicável  * 01 - Aberta  * 02 - Fechada/Baú  * 03 - Granelera  * 04 - Porta Container  * 05 - Sider (required).</param>
        /// <param name="uF">UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo..</param>
        public MdfeSefazVeicTracao(string cInt = default(string), string placa = default(string), string rENAVAM = default(string), int? tara = default(int?), int? capKG = default(int?), int? capM3 = default(int?), MdfeSefazProp prop = default(MdfeSefazProp), List<MdfeSefazCondutor> condutor = default(List<MdfeSefazCondutor>), string tpRod = default(string), string tpCar = default(string), string uF = default(string))
        {
            // to ensure "placa" is required (not null)
            if (placa == null)
            {
                throw new ArgumentNullException("placa is a required property for MdfeSefazVeicTracao and cannot be null");
            }
            this.placa = placa;
            // to ensure "tara" is required (not null)
            if (tara == null)
            {
                throw new ArgumentNullException("tara is a required property for MdfeSefazVeicTracao and cannot be null");
            }
            this.tara = tara;
            // to ensure "condutor" is required (not null)
            if (condutor == null)
            {
                throw new ArgumentNullException("condutor is a required property for MdfeSefazVeicTracao and cannot be null");
            }
            this.condutor = condutor;
            // to ensure "tpRod" is required (not null)
            if (tpRod == null)
            {
                throw new ArgumentNullException("tpRod is a required property for MdfeSefazVeicTracao and cannot be null");
            }
            this.tpRod = tpRod;
            // to ensure "tpCar" is required (not null)
            if (tpCar == null)
            {
                throw new ArgumentNullException("tpCar is a required property for MdfeSefazVeicTracao and cannot be null");
            }
            this.tpCar = tpCar;
            this.cInt = cInt;
            this.RENAVAM = rENAVAM;
            this.capKG = capKG;
            this.capM3 = capM3;
            this.prop = prop;
            this.UF = uF;
        }

        /// <summary>
        /// Código interno do veículo.
        /// </summary>
        /// <value>Código interno do veículo.</value>
        [DataMember(Name = "cInt", EmitDefaultValue = true)]
        public string cInt { get; set; }

        /// <summary>
        /// Placa do veículo.
        /// </summary>
        /// <value>Placa do veículo.</value>
        [DataMember(Name = "placa", IsRequired = true, EmitDefaultValue = true)]
        public string placa { get; set; }

        /// <summary>
        /// RENAVAM do veículo.
        /// </summary>
        /// <value>RENAVAM do veículo.</value>
        [DataMember(Name = "RENAVAM", EmitDefaultValue = true)]
        public string RENAVAM { get; set; }

        /// <summary>
        /// Tara em KG.
        /// </summary>
        /// <value>Tara em KG.</value>
        [DataMember(Name = "tara", IsRequired = true, EmitDefaultValue = true)]
        public int? tara { get; set; }

        /// <summary>
        /// Capacidade em KG.
        /// </summary>
        /// <value>Capacidade em KG.</value>
        [DataMember(Name = "capKG", EmitDefaultValue = true)]
        public int? capKG { get; set; }

        /// <summary>
        /// Capacidade em M3.
        /// </summary>
        /// <value>Capacidade em M3.</value>
        [DataMember(Name = "capM3", EmitDefaultValue = true)]
        public int? capM3 { get; set; }

        /// <summary>
        /// Gets or Sets prop
        /// </summary>
        [DataMember(Name = "prop", EmitDefaultValue = false)]
        public MdfeSefazProp prop { get; set; }

        /// <summary>
        /// Gets or Sets condutor
        /// </summary>
        [DataMember(Name = "condutor", IsRequired = true, EmitDefaultValue = true)]
        public List<MdfeSefazCondutor> condutor { get; set; }

        /// <summary>
        /// Tipo de Rodado.  Preencher com:  * 01 - Truck  * 02 - Toco  * 03 - Cavalo Mecânico  * 04 - VAN  * 05 - Utilitário  * 06 - Outros
        /// </summary>
        /// <value>Tipo de Rodado.  Preencher com:  * 01 - Truck  * 02 - Toco  * 03 - Cavalo Mecânico  * 04 - VAN  * 05 - Utilitário  * 06 - Outros</value>
        [DataMember(Name = "tpRod", IsRequired = true, EmitDefaultValue = true)]
        public string tpRod { get; set; }

        /// <summary>
        /// Tipo de Carroceria.  Preencher com:  * 00 - não aplicável  * 01 - Aberta  * 02 - Fechada/Baú  * 03 - Granelera  * 04 - Porta Container  * 05 - Sider
        /// </summary>
        /// <value>Tipo de Carroceria.  Preencher com:  * 00 - não aplicável  * 01 - Aberta  * 02 - Fechada/Baú  * 03 - Granelera  * 04 - Porta Container  * 05 - Sider</value>
        [DataMember(Name = "tpCar", IsRequired = true, EmitDefaultValue = true)]
        public string tpCar { get; set; }

        /// <summary>
        /// UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo.
        /// </summary>
        /// <value>UF em que veículo está licenciado.  Sigla da UF de licenciamento do veículo.</value>
        [DataMember(Name = "UF", EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazVeicTracao {\n");
            sb.Append("  cInt: ").Append(cInt).Append("\n");
            sb.Append("  placa: ").Append(placa).Append("\n");
            sb.Append("  RENAVAM: ").Append(RENAVAM).Append("\n");
            sb.Append("  tara: ").Append(tara).Append("\n");
            sb.Append("  capKG: ").Append(capKG).Append("\n");
            sb.Append("  capM3: ").Append(capM3).Append("\n");
            sb.Append("  prop: ").Append(prop).Append("\n");
            sb.Append("  condutor: ").Append(condutor).Append("\n");
            sb.Append("  tpRod: ").Append(tpRod).Append("\n");
            sb.Append("  tpCar: ").Append(tpCar).Append("\n");
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
            return this.Equals(input as MdfeSefazVeicTracao);
        }

        /// <summary>
        /// Returns true if MdfeSefazVeicTracao instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazVeicTracao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazVeicTracao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cInt == input.cInt ||
                    (this.cInt != null &&
                    this.cInt.Equals(input.cInt))
                ) && 
                (
                    this.placa == input.placa ||
                    (this.placa != null &&
                    this.placa.Equals(input.placa))
                ) && 
                (
                    this.RENAVAM == input.RENAVAM ||
                    (this.RENAVAM != null &&
                    this.RENAVAM.Equals(input.RENAVAM))
                ) && 
                (
                    this.tara == input.tara ||
                    (this.tara != null &&
                    this.tara.Equals(input.tara))
                ) && 
                (
                    this.capKG == input.capKG ||
                    (this.capKG != null &&
                    this.capKG.Equals(input.capKG))
                ) && 
                (
                    this.capM3 == input.capM3 ||
                    (this.capM3 != null &&
                    this.capM3.Equals(input.capM3))
                ) && 
                (
                    this.prop == input.prop ||
                    (this.prop != null &&
                    this.prop.Equals(input.prop))
                ) && 
                (
                    this.condutor == input.condutor ||
                    this.condutor != null &&
                    input.condutor != null &&
                    this.condutor.SequenceEqual(input.condutor)
                ) && 
                (
                    this.tpRod == input.tpRod ||
                    (this.tpRod != null &&
                    this.tpRod.Equals(input.tpRod))
                ) && 
                (
                    this.tpCar == input.tpCar ||
                    (this.tpCar != null &&
                    this.tpCar.Equals(input.tpCar))
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
                if (this.cInt != null)
                {
                    hashCode = (hashCode * 59) + this.cInt.GetHashCode();
                }
                if (this.placa != null)
                {
                    hashCode = (hashCode * 59) + this.placa.GetHashCode();
                }
                if (this.RENAVAM != null)
                {
                    hashCode = (hashCode * 59) + this.RENAVAM.GetHashCode();
                }
                if (this.tara != null)
                {
                    hashCode = (hashCode * 59) + this.tara.GetHashCode();
                }
                if (this.capKG != null)
                {
                    hashCode = (hashCode * 59) + this.capKG.GetHashCode();
                }
                if (this.capM3 != null)
                {
                    hashCode = (hashCode * 59) + this.capM3.GetHashCode();
                }
                if (this.prop != null)
                {
                    hashCode = (hashCode * 59) + this.prop.GetHashCode();
                }
                if (this.condutor != null)
                {
                    hashCode = (hashCode * 59) + this.condutor.GetHashCode();
                }
                if (this.tpRod != null)
                {
                    hashCode = (hashCode * 59) + this.tpRod.GetHashCode();
                }
                if (this.tpCar != null)
                {
                    hashCode = (hashCode * 59) + this.tpCar.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // cInt (string) maxLength
            if (this.cInt != null && this.cInt.Length > 10)
            {
                yield return new ValidationResult("Invalid value for cInt, length must be less than 10.", new [] { "cInt" });
            }

            // cInt (string) minLength
            if (this.cInt != null && this.cInt.Length < 1)
            {
                yield return new ValidationResult("Invalid value for cInt, length must be greater than 1.", new [] { "cInt" });
            }

            // RENAVAM (string) maxLength
            if (this.RENAVAM != null && this.RENAVAM.Length > 11)
            {
                yield return new ValidationResult("Invalid value for RENAVAM, length must be less than 11.", new [] { "RENAVAM" });
            }

            // RENAVAM (string) minLength
            if (this.RENAVAM != null && this.RENAVAM.Length < 9)
            {
                yield return new ValidationResult("Invalid value for RENAVAM, length must be greater than 9.", new [] { "RENAVAM" });
            }

            // tara (int?) maximum
            if (this.tara > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for tara, must be a value less than or equal to 999999.", new [] { "tara" });
            }

            // tara (int?) minimum
            if (this.tara < (int?)0)
            {
                yield return new ValidationResult("Invalid value for tara, must be a value greater than or equal to 0.", new [] { "tara" });
            }

            // capKG (int?) maximum
            if (this.capKG > (int?)999999)
            {
                yield return new ValidationResult("Invalid value for capKG, must be a value less than or equal to 999999.", new [] { "capKG" });
            }

            // capKG (int?) minimum
            if (this.capKG < (int?)0)
            {
                yield return new ValidationResult("Invalid value for capKG, must be a value greater than or equal to 0.", new [] { "capKG" });
            }

            // capM3 (int?) maximum
            if (this.capM3 > (int?)999)
            {
                yield return new ValidationResult("Invalid value for capM3, must be a value less than or equal to 999.", new [] { "capM3" });
            }

            // capM3 (int?) minimum
            if (this.capM3 < (int?)0)
            {
                yield return new ValidationResult("Invalid value for capM3, must be a value greater than or equal to 0.", new [] { "capM3" });
            }

            yield break;
        }
    }

}
