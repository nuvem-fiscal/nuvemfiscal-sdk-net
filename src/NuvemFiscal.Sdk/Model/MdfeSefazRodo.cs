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
    /// MdfeSefazRodo
    /// </summary>
    [DataContract(Name = "MdfeSefazRodo")]
    public partial class MdfeSefazRodo : IEquatable<MdfeSefazRodo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazRodo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazRodo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazRodo" /> class.
        /// </summary>
        /// <param name="infANTT">infANTT.</param>
        /// <param name="veicTracao">veicTracao (required).</param>
        /// <param name="veicReboque">veicReboque.</param>
        /// <param name="codAgPorto">Código de Agendamento no porto..</param>
        /// <param name="lacRodo">lacRodo.</param>
        public MdfeSefazRodo(MdfeSefazInfANTT infANTT = default(MdfeSefazInfANTT), MdfeSefazVeicTracao veicTracao = default(MdfeSefazVeicTracao), List<MdfeSefazVeicReboque> veicReboque = default(List<MdfeSefazVeicReboque>), string codAgPorto = default(string), List<MdfeSefazLacRodo> lacRodo = default(List<MdfeSefazLacRodo>))
        {
            // to ensure "veicTracao" is required (not null)
            if (veicTracao == null)
            {
                throw new ArgumentNullException("veicTracao is a required property for MdfeSefazRodo and cannot be null");
            }
            this.veicTracao = veicTracao;
            this.infANTT = infANTT;
            this.veicReboque = veicReboque;
            this.codAgPorto = codAgPorto;
            this.lacRodo = lacRodo;
        }

        /// <summary>
        /// Gets or Sets infANTT
        /// </summary>
        [DataMember(Name = "infANTT", EmitDefaultValue = false)]
        public MdfeSefazInfANTT infANTT { get; set; }

        /// <summary>
        /// Gets or Sets veicTracao
        /// </summary>
        [DataMember(Name = "veicTracao", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazVeicTracao veicTracao { get; set; }

        /// <summary>
        /// Gets or Sets veicReboque
        /// </summary>
        [DataMember(Name = "veicReboque", EmitDefaultValue = false)]
        public List<MdfeSefazVeicReboque> veicReboque { get; set; }

        /// <summary>
        /// Código de Agendamento no porto.
        /// </summary>
        /// <value>Código de Agendamento no porto.</value>
        [DataMember(Name = "codAgPorto", EmitDefaultValue = true)]
        public string codAgPorto { get; set; }

        /// <summary>
        /// Gets or Sets lacRodo
        /// </summary>
        [DataMember(Name = "lacRodo", EmitDefaultValue = false)]
        public List<MdfeSefazLacRodo> lacRodo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazRodo {\n");
            sb.Append("  infANTT: ").Append(infANTT).Append("\n");
            sb.Append("  veicTracao: ").Append(veicTracao).Append("\n");
            sb.Append("  veicReboque: ").Append(veicReboque).Append("\n");
            sb.Append("  codAgPorto: ").Append(codAgPorto).Append("\n");
            sb.Append("  lacRodo: ").Append(lacRodo).Append("\n");
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
            return this.Equals(input as MdfeSefazRodo);
        }

        /// <summary>
        /// Returns true if MdfeSefazRodo instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazRodo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazRodo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.infANTT == input.infANTT ||
                    (this.infANTT != null &&
                    this.infANTT.Equals(input.infANTT))
                ) && 
                (
                    this.veicTracao == input.veicTracao ||
                    (this.veicTracao != null &&
                    this.veicTracao.Equals(input.veicTracao))
                ) && 
                (
                    this.veicReboque == input.veicReboque ||
                    this.veicReboque != null &&
                    input.veicReboque != null &&
                    this.veicReboque.SequenceEqual(input.veicReboque)
                ) && 
                (
                    this.codAgPorto == input.codAgPorto ||
                    (this.codAgPorto != null &&
                    this.codAgPorto.Equals(input.codAgPorto))
                ) && 
                (
                    this.lacRodo == input.lacRodo ||
                    this.lacRodo != null &&
                    input.lacRodo != null &&
                    this.lacRodo.SequenceEqual(input.lacRodo)
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
                if (this.infANTT != null)
                {
                    hashCode = (hashCode * 59) + this.infANTT.GetHashCode();
                }
                if (this.veicTracao != null)
                {
                    hashCode = (hashCode * 59) + this.veicTracao.GetHashCode();
                }
                if (this.veicReboque != null)
                {
                    hashCode = (hashCode * 59) + this.veicReboque.GetHashCode();
                }
                if (this.codAgPorto != null)
                {
                    hashCode = (hashCode * 59) + this.codAgPorto.GetHashCode();
                }
                if (this.lacRodo != null)
                {
                    hashCode = (hashCode * 59) + this.lacRodo.GetHashCode();
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
