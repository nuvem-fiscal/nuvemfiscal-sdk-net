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
    /// Grupo para Declaraçao do usuário emitente.
    /// </summary>
    [DataContract(Name = "DceSefazInfDec")]
    public partial class DceSefazInfDec : IEquatable<DceSefazInfDec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazInfDec" /> class.
        /// </summary>
        /// <param name="xObs1">Observação 1 ao usuário emitente.  Deverá conter o texto fixo “É contribuinte de ICMS qualquer pessoa física ou jurídica, que realize, com habitualidade ou em volume que caracterize intuito comercial, operações de circulação de mercadoria ou prestações de serviços de transportes interestadual e intermunicipal e de comunicação, ainda que as operações e prestações de iniciem no exterior (Lei Complementar nº 87/96, Art. 4º)”.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="xObs2">Observação 2 ao usuário emitente.  Deverá conter o texto fixo “Constitui crime contra a ordem tributária suprimir ou reduzir tributo, ou contribuição social e qualquer acessório: quando negar ou deixar de fornecer, quando obrigatório, nota fiscal ou documento equivalente, relativa a venda de mercadoria ou prestação de serviço, efetivamente realizada ou fornece-la em desacordo com a legislação. Sob pena de reclusão de 2 (dois) e 5 (cinco) anos, e multa (Lei 8.137/90, Art 1ª, V)”.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        public DceSefazInfDec(string xObs1 = default(string), string xObs2 = default(string))
        {
            this.xObs1 = xObs1;
            this.xObs2 = xObs2;
        }

        /// <summary>
        /// Observação 1 ao usuário emitente.  Deverá conter o texto fixo “É contribuinte de ICMS qualquer pessoa física ou jurídica, que realize, com habitualidade ou em volume que caracterize intuito comercial, operações de circulação de mercadoria ou prestações de serviços de transportes interestadual e intermunicipal e de comunicação, ainda que as operações e prestações de iniciem no exterior (Lei Complementar nº 87/96, Art. 4º)”.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Observação 1 ao usuário emitente.  Deverá conter o texto fixo “É contribuinte de ICMS qualquer pessoa física ou jurídica, que realize, com habitualidade ou em volume que caracterize intuito comercial, operações de circulação de mercadoria ou prestações de serviços de transportes interestadual e intermunicipal e de comunicação, ainda que as operações e prestações de iniciem no exterior (Lei Complementar nº 87/96, Art. 4º)”.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "xObs1", EmitDefaultValue = true)]
        public string xObs1 { get; set; }

        /// <summary>
        /// Observação 2 ao usuário emitente.  Deverá conter o texto fixo “Constitui crime contra a ordem tributária suprimir ou reduzir tributo, ou contribuição social e qualquer acessório: quando negar ou deixar de fornecer, quando obrigatório, nota fiscal ou documento equivalente, relativa a venda de mercadoria ou prestação de serviço, efetivamente realizada ou fornece-la em desacordo com a legislação. Sob pena de reclusão de 2 (dois) e 5 (cinco) anos, e multa (Lei 8.137/90, Art 1ª, V)”.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Observação 2 ao usuário emitente.  Deverá conter o texto fixo “Constitui crime contra a ordem tributária suprimir ou reduzir tributo, ou contribuição social e qualquer acessório: quando negar ou deixar de fornecer, quando obrigatório, nota fiscal ou documento equivalente, relativa a venda de mercadoria ou prestação de serviço, efetivamente realizada ou fornece-la em desacordo com a legislação. Sob pena de reclusão de 2 (dois) e 5 (cinco) anos, e multa (Lei 8.137/90, Art 1ª, V)”.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "xObs2", EmitDefaultValue = true)]
        public string xObs2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazInfDec {\n");
            sb.Append("  xObs1: ").Append(xObs1).Append("\n");
            sb.Append("  xObs2: ").Append(xObs2).Append("\n");
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
            return this.Equals(input as DceSefazInfDec);
        }

        /// <summary>
        /// Returns true if DceSefazInfDec instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazInfDec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazInfDec input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xObs1 == input.xObs1 ||
                    (this.xObs1 != null &&
                    this.xObs1.Equals(input.xObs1))
                ) && 
                (
                    this.xObs2 == input.xObs2 ||
                    (this.xObs2 != null &&
                    this.xObs2.Equals(input.xObs2))
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
                if (this.xObs1 != null)
                {
                    hashCode = (hashCode * 59) + this.xObs1.GetHashCode();
                }
                if (this.xObs2 != null)
                {
                    hashCode = (hashCode * 59) + this.xObs2.GetHashCode();
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
            // xObs1 (string) maxLength
            if (this.xObs1 != null && this.xObs1.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for xObs1, length must be less than 2000.", new [] { "xObs1" });
            }

            // xObs1 (string) minLength
            if (this.xObs1 != null && this.xObs1.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xObs1, length must be greater than 1.", new [] { "xObs1" });
            }

            // xObs2 (string) maxLength
            if (this.xObs2 != null && this.xObs2.Length > 5000)
            {
                yield return new ValidationResult("Invalid value for xObs2, length must be less than 5000.", new [] { "xObs2" });
            }

            // xObs2 (string) minLength
            if (this.xObs2 != null && this.xObs2.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xObs2, length must be greater than 1.", new [] { "xObs2" });
            }

            yield break;
        }
    }

}
