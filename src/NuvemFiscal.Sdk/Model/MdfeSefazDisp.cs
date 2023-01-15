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
    /// Informações dos dispositivos do Vale Pedágio.
    /// </summary>
    [DataContract(Name = "MdfeSefazDisp")]
    public partial class MdfeSefazDisp : IEquatable<MdfeSefazDisp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazDisp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazDisp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazDisp" /> class.
        /// </summary>
        /// <param name="cNPJForn">CNPJ da empresa fornecedora do Vale-Pedágio.  * CNPJ da Empresa Fornecedora do Vale-Pedágio, ou seja, empresa que fornece ao Responsável pelo Pagamento do Vale-Pedágio os dispositivos do Vale-Pedágio.  * Informar os zeros não significativos. (required).</param>
        /// <param name="cNPJPg">CNPJ do responsável pelo pagamento do Vale-Pedágio.  * responsável pelo pagamento do Vale Pedágio. Informar somente quando o responsável não for o emitente do MDF-e.  * Informar os zeros não significativos..</param>
        /// <param name="cPFPg">CNPJ do responsável pelo pagamento do Vale-Pedágio.  Informar os zeros não significativos..</param>
        /// <param name="nCompra">Número do comprovante de compra.  Número de ordem do comprovante de compra do Vale-Pedágio fornecido para cada veículo ou combinação veicular, por viagem..</param>
        /// <param name="vValePed">Valor do Vale-Pedagio.  Valor do Vale-Pedágio obrigatório necessário à livre circulação, desde a origem da operação de transporte até o destino, do transportador contratado. (required).</param>
        /// <param name="tpValePed">Tipo do Vale Pedagio.  * 01 - TAG  * 02 - Cupom  * 03 - Cartão.</param>
        public MdfeSefazDisp(string cNPJForn = default(string), string cNPJPg = default(string), string cPFPg = default(string), string nCompra = default(string), decimal vValePed = default(decimal), string tpValePed = default(string))
        {
            // to ensure "cNPJForn" is required (not null)
            if (cNPJForn == null)
            {
                throw new ArgumentNullException("cNPJForn is a required property for MdfeSefazDisp and cannot be null");
            }
            this.CNPJForn = cNPJForn;
            this.vValePed = vValePed;
            this.CNPJPg = cNPJPg;
            this.CPFPg = cPFPg;
            this.nCompra = nCompra;
            this.tpValePed = tpValePed;
        }

        /// <summary>
        /// CNPJ da empresa fornecedora do Vale-Pedágio.  * CNPJ da Empresa Fornecedora do Vale-Pedágio, ou seja, empresa que fornece ao Responsável pelo Pagamento do Vale-Pedágio os dispositivos do Vale-Pedágio.  * Informar os zeros não significativos.
        /// </summary>
        /// <value>CNPJ da empresa fornecedora do Vale-Pedágio.  * CNPJ da Empresa Fornecedora do Vale-Pedágio, ou seja, empresa que fornece ao Responsável pelo Pagamento do Vale-Pedágio os dispositivos do Vale-Pedágio.  * Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJForn", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJForn { get; set; }

        /// <summary>
        /// CNPJ do responsável pelo pagamento do Vale-Pedágio.  * responsável pelo pagamento do Vale Pedágio. Informar somente quando o responsável não for o emitente do MDF-e.  * Informar os zeros não significativos.
        /// </summary>
        /// <value>CNPJ do responsável pelo pagamento do Vale-Pedágio.  * responsável pelo pagamento do Vale Pedágio. Informar somente quando o responsável não for o emitente do MDF-e.  * Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJPg", EmitDefaultValue = false)]
        public string CNPJPg { get; set; }

        /// <summary>
        /// CNPJ do responsável pelo pagamento do Vale-Pedágio.  Informar os zeros não significativos.
        /// </summary>
        /// <value>CNPJ do responsável pelo pagamento do Vale-Pedágio.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPFPg", EmitDefaultValue = false)]
        public string CPFPg { get; set; }

        /// <summary>
        /// Número do comprovante de compra.  Número de ordem do comprovante de compra do Vale-Pedágio fornecido para cada veículo ou combinação veicular, por viagem.
        /// </summary>
        /// <value>Número do comprovante de compra.  Número de ordem do comprovante de compra do Vale-Pedágio fornecido para cada veículo ou combinação veicular, por viagem.</value>
        [DataMember(Name = "nCompra", EmitDefaultValue = false)]
        public string nCompra { get; set; }

        /// <summary>
        /// Valor do Vale-Pedagio.  Valor do Vale-Pedágio obrigatório necessário à livre circulação, desde a origem da operação de transporte até o destino, do transportador contratado.
        /// </summary>
        /// <value>Valor do Vale-Pedagio.  Valor do Vale-Pedágio obrigatório necessário à livre circulação, desde a origem da operação de transporte até o destino, do transportador contratado.</value>
        [DataMember(Name = "vValePed", IsRequired = true, EmitDefaultValue = true)]
        public decimal vValePed { get; set; }

        /// <summary>
        /// Tipo do Vale Pedagio.  * 01 - TAG  * 02 - Cupom  * 03 - Cartão
        /// </summary>
        /// <value>Tipo do Vale Pedagio.  * 01 - TAG  * 02 - Cupom  * 03 - Cartão</value>
        [DataMember(Name = "tpValePed", EmitDefaultValue = false)]
        public string tpValePed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazDisp {\n");
            sb.Append("  CNPJForn: ").Append(CNPJForn).Append("\n");
            sb.Append("  CNPJPg: ").Append(CNPJPg).Append("\n");
            sb.Append("  CPFPg: ").Append(CPFPg).Append("\n");
            sb.Append("  nCompra: ").Append(nCompra).Append("\n");
            sb.Append("  vValePed: ").Append(vValePed).Append("\n");
            sb.Append("  tpValePed: ").Append(tpValePed).Append("\n");
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
            return this.Equals(input as MdfeSefazDisp);
        }

        /// <summary>
        /// Returns true if MdfeSefazDisp instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazDisp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazDisp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJForn == input.CNPJForn ||
                    (this.CNPJForn != null &&
                    this.CNPJForn.Equals(input.CNPJForn))
                ) && 
                (
                    this.CNPJPg == input.CNPJPg ||
                    (this.CNPJPg != null &&
                    this.CNPJPg.Equals(input.CNPJPg))
                ) && 
                (
                    this.CPFPg == input.CPFPg ||
                    (this.CPFPg != null &&
                    this.CPFPg.Equals(input.CPFPg))
                ) && 
                (
                    this.nCompra == input.nCompra ||
                    (this.nCompra != null &&
                    this.nCompra.Equals(input.nCompra))
                ) && 
                (
                    this.vValePed == input.vValePed ||
                    this.vValePed.Equals(input.vValePed)
                ) && 
                (
                    this.tpValePed == input.tpValePed ||
                    (this.tpValePed != null &&
                    this.tpValePed.Equals(input.tpValePed))
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
                if (this.CNPJForn != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJForn.GetHashCode();
                }
                if (this.CNPJPg != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJPg.GetHashCode();
                }
                if (this.CPFPg != null)
                {
                    hashCode = (hashCode * 59) + this.CPFPg.GetHashCode();
                }
                if (this.nCompra != null)
                {
                    hashCode = (hashCode * 59) + this.nCompra.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vValePed.GetHashCode();
                if (this.tpValePed != null)
                {
                    hashCode = (hashCode * 59) + this.tpValePed.GetHashCode();
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
