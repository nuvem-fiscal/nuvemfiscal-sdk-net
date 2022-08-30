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
    /// NfeSefazVol
    /// </summary>
    [DataContract(Name = "NfeSefazVol")]
    public partial class NfeSefazVol : IEquatable<NfeSefazVol>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazVol" /> class.
        /// </summary>
        /// <param name="qVol">Quantidade de volumes transportados..</param>
        /// <param name="esp">Espécie dos volumes transportados..</param>
        /// <param name="marca">Marca dos volumes transportados..</param>
        /// <param name="nVol">Numeração dos volumes transportados..</param>
        /// <param name="pesoL">Peso líquido (em kg)..</param>
        /// <param name="pesoB">Peso bruto (em kg)..</param>
        /// <param name="lacres">lacres.</param>
        public NfeSefazVol(int qVol = default(int), string esp = default(string), string marca = default(string), string nVol = default(string), decimal pesoL = default(decimal), decimal pesoB = default(decimal), List<NfeSefazLacres> lacres = default(List<NfeSefazLacres>))
        {
            this.qVol = qVol;
            this.esp = esp;
            this.marca = marca;
            this.nVol = nVol;
            this.pesoL = pesoL;
            this.pesoB = pesoB;
            this.lacres = lacres;
        }

        /// <summary>
        /// Quantidade de volumes transportados.
        /// </summary>
        /// <value>Quantidade de volumes transportados.</value>
        [DataMember(Name = "qVol", EmitDefaultValue = false)]
        public int qVol { get; set; }

        /// <summary>
        /// Espécie dos volumes transportados.
        /// </summary>
        /// <value>Espécie dos volumes transportados.</value>
        [DataMember(Name = "esp", EmitDefaultValue = false)]
        public string esp { get; set; }

        /// <summary>
        /// Marca dos volumes transportados.
        /// </summary>
        /// <value>Marca dos volumes transportados.</value>
        [DataMember(Name = "marca", EmitDefaultValue = false)]
        public string marca { get; set; }

        /// <summary>
        /// Numeração dos volumes transportados.
        /// </summary>
        /// <value>Numeração dos volumes transportados.</value>
        [DataMember(Name = "nVol", EmitDefaultValue = false)]
        public string nVol { get; set; }

        /// <summary>
        /// Peso líquido (em kg).
        /// </summary>
        /// <value>Peso líquido (em kg).</value>
        [DataMember(Name = "pesoL", EmitDefaultValue = false)]
        public decimal pesoL { get; set; }

        /// <summary>
        /// Peso bruto (em kg).
        /// </summary>
        /// <value>Peso bruto (em kg).</value>
        [DataMember(Name = "pesoB", EmitDefaultValue = false)]
        public decimal pesoB { get; set; }

        /// <summary>
        /// Gets or Sets lacres
        /// </summary>
        [DataMember(Name = "lacres", EmitDefaultValue = false)]
        public List<NfeSefazLacres> lacres { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazVol {\n");
            sb.Append("  qVol: ").Append(qVol).Append("\n");
            sb.Append("  esp: ").Append(esp).Append("\n");
            sb.Append("  marca: ").Append(marca).Append("\n");
            sb.Append("  nVol: ").Append(nVol).Append("\n");
            sb.Append("  pesoL: ").Append(pesoL).Append("\n");
            sb.Append("  pesoB: ").Append(pesoB).Append("\n");
            sb.Append("  lacres: ").Append(lacres).Append("\n");
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
            return this.Equals(input as NfeSefazVol);
        }

        /// <summary>
        /// Returns true if NfeSefazVol instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazVol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazVol input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qVol == input.qVol ||
                    this.qVol.Equals(input.qVol)
                ) && 
                (
                    this.esp == input.esp ||
                    (this.esp != null &&
                    this.esp.Equals(input.esp))
                ) && 
                (
                    this.marca == input.marca ||
                    (this.marca != null &&
                    this.marca.Equals(input.marca))
                ) && 
                (
                    this.nVol == input.nVol ||
                    (this.nVol != null &&
                    this.nVol.Equals(input.nVol))
                ) && 
                (
                    this.pesoL == input.pesoL ||
                    this.pesoL.Equals(input.pesoL)
                ) && 
                (
                    this.pesoB == input.pesoB ||
                    this.pesoB.Equals(input.pesoB)
                ) && 
                (
                    this.lacres == input.lacres ||
                    this.lacres != null &&
                    input.lacres != null &&
                    this.lacres.SequenceEqual(input.lacres)
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
                hashCode = (hashCode * 59) + this.qVol.GetHashCode();
                if (this.esp != null)
                {
                    hashCode = (hashCode * 59) + this.esp.GetHashCode();
                }
                if (this.marca != null)
                {
                    hashCode = (hashCode * 59) + this.marca.GetHashCode();
                }
                if (this.nVol != null)
                {
                    hashCode = (hashCode * 59) + this.nVol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.pesoL.GetHashCode();
                hashCode = (hashCode * 59) + this.pesoB.GetHashCode();
                if (this.lacres != null)
                {
                    hashCode = (hashCode * 59) + this.lacres.GetHashCode();
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
