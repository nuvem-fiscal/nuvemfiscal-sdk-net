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
    /// Informações bancárias.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfBanc")]
    public partial class MdfeSefazInfBanc : IEquatable<MdfeSefazInfBanc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfBanc" /> class.
        /// </summary>
        /// <param name="codBanco">Número do banco..</param>
        /// <param name="codAgencia">Número da agência bancária..</param>
        /// <param name="cNPJIPEF">Número do CNPJ da Instituição de Pagamento Eletrônico do Frete.  Informar os zeros não significativos..</param>
        /// <param name="pIX">Chave PIX.  Informar a chave PIX para recebimento do frete.  Pode ser email, CPF/ CNPJ (somente numeros), Telefone com a seguinte formatação (+5599999999999) ou a chave aleatória gerada pela instituição..</param>
        public MdfeSefazInfBanc(string codBanco = default(string), string codAgencia = default(string), string cNPJIPEF = default(string), string pIX = default(string))
        {
            this.codBanco = codBanco;
            this.codAgencia = codAgencia;
            this.CNPJIPEF = cNPJIPEF;
            this.PIX = pIX;
        }

        /// <summary>
        /// Número do banco.
        /// </summary>
        /// <value>Número do banco.</value>
        [DataMember(Name = "codBanco", EmitDefaultValue = true)]
        public string codBanco { get; set; }

        /// <summary>
        /// Número da agência bancária.
        /// </summary>
        /// <value>Número da agência bancária.</value>
        [DataMember(Name = "codAgencia", EmitDefaultValue = true)]
        public string codAgencia { get; set; }

        /// <summary>
        /// Número do CNPJ da Instituição de Pagamento Eletrônico do Frete.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ da Instituição de Pagamento Eletrônico do Frete.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJIPEF", EmitDefaultValue = true)]
        public string CNPJIPEF { get; set; }

        /// <summary>
        /// Chave PIX.  Informar a chave PIX para recebimento do frete.  Pode ser email, CPF/ CNPJ (somente numeros), Telefone com a seguinte formatação (+5599999999999) ou a chave aleatória gerada pela instituição.
        /// </summary>
        /// <value>Chave PIX.  Informar a chave PIX para recebimento do frete.  Pode ser email, CPF/ CNPJ (somente numeros), Telefone com a seguinte formatação (+5599999999999) ou a chave aleatória gerada pela instituição.</value>
        [DataMember(Name = "PIX", EmitDefaultValue = true)]
        public string PIX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfBanc {\n");
            sb.Append("  codBanco: ").Append(codBanco).Append("\n");
            sb.Append("  codAgencia: ").Append(codAgencia).Append("\n");
            sb.Append("  CNPJIPEF: ").Append(CNPJIPEF).Append("\n");
            sb.Append("  PIX: ").Append(PIX).Append("\n");
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
            return this.Equals(input as MdfeSefazInfBanc);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfBanc instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfBanc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfBanc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.codBanco == input.codBanco ||
                    (this.codBanco != null &&
                    this.codBanco.Equals(input.codBanco))
                ) && 
                (
                    this.codAgencia == input.codAgencia ||
                    (this.codAgencia != null &&
                    this.codAgencia.Equals(input.codAgencia))
                ) && 
                (
                    this.CNPJIPEF == input.CNPJIPEF ||
                    (this.CNPJIPEF != null &&
                    this.CNPJIPEF.Equals(input.CNPJIPEF))
                ) && 
                (
                    this.PIX == input.PIX ||
                    (this.PIX != null &&
                    this.PIX.Equals(input.PIX))
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
                if (this.codBanco != null)
                {
                    hashCode = (hashCode * 59) + this.codBanco.GetHashCode();
                }
                if (this.codAgencia != null)
                {
                    hashCode = (hashCode * 59) + this.codAgencia.GetHashCode();
                }
                if (this.CNPJIPEF != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJIPEF.GetHashCode();
                }
                if (this.PIX != null)
                {
                    hashCode = (hashCode * 59) + this.PIX.GetHashCode();
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
