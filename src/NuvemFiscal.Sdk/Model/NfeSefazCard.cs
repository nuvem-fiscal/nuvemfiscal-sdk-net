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
    /// Grupo de Cartões.
    /// </summary>
    [DataContract(Name = "NfeSefazCard")]
    public partial class NfeSefazCard : IEquatable<NfeSefazCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCard" /> class.
        /// </summary>
        /// <param name="tpIntegra">Tipo de Integração do processo de pagamento com o sistema de automação da empresa/  * 1 - Pagamento integrado com o sistema de automação da empresa Ex. equipamento TEF , Comercio Eletronico  * 2 - Pagamento não integrado com o sistema de automação da empresa Ex: equipamento POS (required).</param>
        /// <param name="cNPJ">CNPJ da instituição de pagamento..</param>
        /// <param name="tBand">Bandeira da operadora de cartão..</param>
        /// <param name="cAut">Número de autorização da operação cartão de crédito/débito..</param>
        public NfeSefazCard(int? tpIntegra = default(int?), string cNPJ = default(string), string tBand = default(string), string cAut = default(string))
        {
            // to ensure "tpIntegra" is required (not null)
            if (tpIntegra == null)
            {
                throw new ArgumentNullException("tpIntegra is a required property for NfeSefazCard and cannot be null");
            }
            this.tpIntegra = tpIntegra;
            this.CNPJ = cNPJ;
            this.tBand = tBand;
            this.cAut = cAut;
        }

        /// <summary>
        /// Tipo de Integração do processo de pagamento com o sistema de automação da empresa/  * 1 - Pagamento integrado com o sistema de automação da empresa Ex. equipamento TEF , Comercio Eletronico  * 2 - Pagamento não integrado com o sistema de automação da empresa Ex: equipamento POS
        /// </summary>
        /// <value>Tipo de Integração do processo de pagamento com o sistema de automação da empresa/  * 1 - Pagamento integrado com o sistema de automação da empresa Ex. equipamento TEF , Comercio Eletronico  * 2 - Pagamento não integrado com o sistema de automação da empresa Ex: equipamento POS</value>
        [DataMember(Name = "tpIntegra", IsRequired = true, EmitDefaultValue = true)]
        public int? tpIntegra { get; set; }

        /// <summary>
        /// CNPJ da instituição de pagamento.
        /// </summary>
        /// <value>CNPJ da instituição de pagamento.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Bandeira da operadora de cartão.
        /// </summary>
        /// <value>Bandeira da operadora de cartão.</value>
        [DataMember(Name = "tBand", EmitDefaultValue = true)]
        public string tBand { get; set; }

        /// <summary>
        /// Número de autorização da operação cartão de crédito/débito.
        /// </summary>
        /// <value>Número de autorização da operação cartão de crédito/débito.</value>
        [DataMember(Name = "cAut", EmitDefaultValue = true)]
        public string cAut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCard {\n");
            sb.Append("  tpIntegra: ").Append(tpIntegra).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  tBand: ").Append(tBand).Append("\n");
            sb.Append("  cAut: ").Append(cAut).Append("\n");
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
            return this.Equals(input as NfeSefazCard);
        }

        /// <summary>
        /// Returns true if NfeSefazCard instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpIntegra == input.tpIntegra ||
                    (this.tpIntegra != null &&
                    this.tpIntegra.Equals(input.tpIntegra))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.tBand == input.tBand ||
                    (this.tBand != null &&
                    this.tBand.Equals(input.tBand))
                ) && 
                (
                    this.cAut == input.cAut ||
                    (this.cAut != null &&
                    this.cAut.Equals(input.cAut))
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
                if (this.tpIntegra != null)
                {
                    hashCode = (hashCode * 59) + this.tpIntegra.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.tBand != null)
                {
                    hashCode = (hashCode * 59) + this.tBand.GetHashCode();
                }
                if (this.cAut != null)
                {
                    hashCode = (hashCode * 59) + this.cAut.GetHashCode();
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
            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // cAut (string) maxLength
            if (this.cAut != null && this.cAut.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cAut, length must be less than 20.", new [] { "cAut" });
            }

            // cAut (string) minLength
            if (this.cAut != null && this.cAut.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cAut, length must be greater than 1.", new [] { "cAut" });
            }

            yield break;
        }
    }

}
