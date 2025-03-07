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
    /// Grupo de informações dos contratantes do serviço de transporte.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfContratante")]
    public partial class MdfeSefazInfContratante : IEquatable<MdfeSefazInfContratante>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfContratante" /> class.
        /// </summary>
        /// <param name="xNome">Razão social ou Nome do contratante..</param>
        /// <param name="cPF">Número do CPF do contratante do serviço.  Informar os zeros não significativos..</param>
        /// <param name="cNPJ">Número do CNPJ do contratante do serviço.  Informar os zeros não significativos..</param>
        /// <param name="idEstrangeiro">Identificador do contratante em caso de contratante estrangeiro..</param>
        /// <param name="infContrato">infContrato.</param>
        public MdfeSefazInfContratante(string xNome = default(string), string cPF = default(string), string cNPJ = default(string), string idEstrangeiro = default(string), MdfeSefazInfContrato infContrato = default(MdfeSefazInfContrato))
        {
            this.xNome = xNome;
            this.CPF = cPF;
            this.CNPJ = cNPJ;
            this.idEstrangeiro = idEstrangeiro;
            this.infContrato = infContrato;
        }

        /// <summary>
        /// Razão social ou Nome do contratante.
        /// </summary>
        /// <value>Razão social ou Nome do contratante.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Número do CPF do contratante do serviço.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF do contratante do serviço.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Número do CNPJ do contratante do serviço.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ do contratante do serviço.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Identificador do contratante em caso de contratante estrangeiro.
        /// </summary>
        /// <value>Identificador do contratante em caso de contratante estrangeiro.</value>
        [DataMember(Name = "idEstrangeiro", EmitDefaultValue = true)]
        public string idEstrangeiro { get; set; }

        /// <summary>
        /// Gets or Sets infContrato
        /// </summary>
        [DataMember(Name = "infContrato", EmitDefaultValue = false)]
        public MdfeSefazInfContrato infContrato { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfContratante {\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  idEstrangeiro: ").Append(idEstrangeiro).Append("\n");
            sb.Append("  infContrato: ").Append(infContrato).Append("\n");
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
            return this.Equals(input as MdfeSefazInfContratante);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfContratante instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfContratante to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfContratante input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.idEstrangeiro == input.idEstrangeiro ||
                    (this.idEstrangeiro != null &&
                    this.idEstrangeiro.Equals(input.idEstrangeiro))
                ) && 
                (
                    this.infContrato == input.infContrato ||
                    (this.infContrato != null &&
                    this.infContrato.Equals(input.infContrato))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.idEstrangeiro != null)
                {
                    hashCode = (hashCode * 59) + this.idEstrangeiro.GetHashCode();
                }
                if (this.infContrato != null)
                {
                    hashCode = (hashCode * 59) + this.infContrato.GetHashCode();
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

            // idEstrangeiro (string) maxLength
            if (this.idEstrangeiro != null && this.idEstrangeiro.Length > 20)
            {
                yield return new ValidationResult("Invalid value for idEstrangeiro, length must be less than 20.", new [] { "idEstrangeiro" });
            }

            // idEstrangeiro (string) minLength
            if (this.idEstrangeiro != null && this.idEstrangeiro.Length < 2)
            {
                yield return new ValidationResult("Invalid value for idEstrangeiro, length must be greater than 2.", new [] { "idEstrangeiro" });
            }

            yield break;
        }
    }

}
