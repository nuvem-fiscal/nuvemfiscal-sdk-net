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
    /// RpsServicoValores
    /// </summary>
    [DataContract(Name = "RpsServicoValores")]
    public partial class RpsServicoValores : IEquatable<RpsServicoValores>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RpsServicoValores" /> class.
        /// </summary>
        /// <param name="valorUnitario">valorUnitario.</param>
        /// <param name="valorServicos">valorServicos.</param>
        /// <param name="valorDeducoes">valorDeducoes.</param>
        /// <param name="valorPis">valorPis.</param>
        /// <param name="valorCofins">valorCofins.</param>
        /// <param name="valorInss">valorInss.</param>
        /// <param name="valorIr">valorIr.</param>
        /// <param name="valorCsll">valorCsll.</param>
        /// <param name="valorOutrasRetencoes">valorOutrasRetencoes.</param>
        /// <param name="valorIss">valorIss.</param>
        /// <param name="valorIssRetido">valorIssRetido.</param>
        /// <param name="valorLiquido">valorLiquido.</param>
        /// <param name="aliquotaIss">aliquotaIss.</param>
        /// <param name="aliquotaPis">aliquotaPis.</param>
        /// <param name="aliquotaCofins">aliquotaCofins.</param>
        /// <param name="aliquotaInss">aliquotaInss.</param>
        /// <param name="aliquotaIr">aliquotaIr.</param>
        /// <param name="aliquotaCsll">aliquotaCsll.</param>
        /// <param name="descontoIncondicionado">descontoIncondicionado.</param>
        /// <param name="descontoCondicionado">descontoCondicionado.</param>
        public RpsServicoValores(decimal valorUnitario = default(decimal), decimal valorServicos = default(decimal), decimal valorDeducoes = default(decimal), decimal valorPis = default(decimal), decimal valorCofins = default(decimal), decimal valorInss = default(decimal), decimal valorIr = default(decimal), decimal valorCsll = default(decimal), decimal valorOutrasRetencoes = default(decimal), decimal valorIss = default(decimal), decimal valorIssRetido = default(decimal), decimal valorLiquido = default(decimal), decimal aliquotaIss = default(decimal), decimal aliquotaPis = default(decimal), decimal aliquotaCofins = default(decimal), decimal aliquotaInss = default(decimal), decimal aliquotaIr = default(decimal), decimal aliquotaCsll = default(decimal), decimal descontoIncondicionado = default(decimal), decimal descontoCondicionado = default(decimal))
        {
            this.valor_unitario = valorUnitario;
            this.valor_servicos = valorServicos;
            this.valor_deducoes = valorDeducoes;
            this.valor_pis = valorPis;
            this.valor_cofins = valorCofins;
            this.valor_inss = valorInss;
            this.valor_ir = valorIr;
            this.valor_csll = valorCsll;
            this.valor_outras_retencoes = valorOutrasRetencoes;
            this.valor_iss = valorIss;
            this.valor_iss_retido = valorIssRetido;
            this.valor_liquido = valorLiquido;
            this.aliquota_iss = aliquotaIss;
            this.aliquota_pis = aliquotaPis;
            this.aliquota_cofins = aliquotaCofins;
            this.aliquota_inss = aliquotaInss;
            this.aliquota_ir = aliquotaIr;
            this.aliquota_csll = aliquotaCsll;
            this.desconto_incondicionado = descontoIncondicionado;
            this.desconto_condicionado = descontoCondicionado;
        }

        /// <summary>
        /// Gets or Sets valor_unitario
        /// </summary>
        [DataMember(Name = "valor_unitario", EmitDefaultValue = false)]
        public decimal valor_unitario { get; set; }

        /// <summary>
        /// Gets or Sets valor_servicos
        /// </summary>
        [DataMember(Name = "valor_servicos", EmitDefaultValue = false)]
        public decimal valor_servicos { get; set; }

        /// <summary>
        /// Gets or Sets valor_deducoes
        /// </summary>
        [DataMember(Name = "valor_deducoes", EmitDefaultValue = false)]
        public decimal valor_deducoes { get; set; }

        /// <summary>
        /// Gets or Sets valor_pis
        /// </summary>
        [DataMember(Name = "valor_pis", EmitDefaultValue = false)]
        public decimal valor_pis { get; set; }

        /// <summary>
        /// Gets or Sets valor_cofins
        /// </summary>
        [DataMember(Name = "valor_cofins", EmitDefaultValue = false)]
        public decimal valor_cofins { get; set; }

        /// <summary>
        /// Gets or Sets valor_inss
        /// </summary>
        [DataMember(Name = "valor_inss", EmitDefaultValue = false)]
        public decimal valor_inss { get; set; }

        /// <summary>
        /// Gets or Sets valor_ir
        /// </summary>
        [DataMember(Name = "valor_ir", EmitDefaultValue = false)]
        public decimal valor_ir { get; set; }

        /// <summary>
        /// Gets or Sets valor_csll
        /// </summary>
        [DataMember(Name = "valor_csll", EmitDefaultValue = false)]
        public decimal valor_csll { get; set; }

        /// <summary>
        /// Gets or Sets valor_outras_retencoes
        /// </summary>
        [DataMember(Name = "valor_outras_retencoes", EmitDefaultValue = false)]
        public decimal valor_outras_retencoes { get; set; }

        /// <summary>
        /// Gets or Sets valor_iss
        /// </summary>
        [DataMember(Name = "valor_iss", EmitDefaultValue = false)]
        public decimal valor_iss { get; set; }

        /// <summary>
        /// Gets or Sets valor_iss_retido
        /// </summary>
        [DataMember(Name = "valor_iss_retido", EmitDefaultValue = false)]
        public decimal valor_iss_retido { get; set; }

        /// <summary>
        /// Gets or Sets valor_liquido
        /// </summary>
        [DataMember(Name = "valor_liquido", EmitDefaultValue = false)]
        public decimal valor_liquido { get; set; }

        /// <summary>
        /// Gets or Sets aliquota_iss
        /// </summary>
        [DataMember(Name = "aliquota_iss", EmitDefaultValue = false)]
        public decimal aliquota_iss { get; set; }

        /// <summary>
        /// Gets or Sets aliquota_pis
        /// </summary>
        [DataMember(Name = "aliquota_pis", EmitDefaultValue = false)]
        public decimal aliquota_pis { get; set; }

        /// <summary>
        /// Gets or Sets aliquota_cofins
        /// </summary>
        [DataMember(Name = "aliquota_cofins", EmitDefaultValue = false)]
        public decimal aliquota_cofins { get; set; }

        /// <summary>
        /// Gets or Sets aliquota_inss
        /// </summary>
        [DataMember(Name = "aliquota_inss", EmitDefaultValue = false)]
        public decimal aliquota_inss { get; set; }

        /// <summary>
        /// Gets or Sets aliquota_ir
        /// </summary>
        [DataMember(Name = "aliquota_ir", EmitDefaultValue = false)]
        public decimal aliquota_ir { get; set; }

        /// <summary>
        /// Gets or Sets aliquota_csll
        /// </summary>
        [DataMember(Name = "aliquota_csll", EmitDefaultValue = false)]
        public decimal aliquota_csll { get; set; }

        /// <summary>
        /// Gets or Sets desconto_incondicionado
        /// </summary>
        [DataMember(Name = "desconto_incondicionado", EmitDefaultValue = false)]
        public decimal desconto_incondicionado { get; set; }

        /// <summary>
        /// Gets or Sets desconto_condicionado
        /// </summary>
        [DataMember(Name = "desconto_condicionado", EmitDefaultValue = false)]
        public decimal desconto_condicionado { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RpsServicoValores {\n");
            sb.Append("  valor_unitario: ").Append(valor_unitario).Append("\n");
            sb.Append("  valor_servicos: ").Append(valor_servicos).Append("\n");
            sb.Append("  valor_deducoes: ").Append(valor_deducoes).Append("\n");
            sb.Append("  valor_pis: ").Append(valor_pis).Append("\n");
            sb.Append("  valor_cofins: ").Append(valor_cofins).Append("\n");
            sb.Append("  valor_inss: ").Append(valor_inss).Append("\n");
            sb.Append("  valor_ir: ").Append(valor_ir).Append("\n");
            sb.Append("  valor_csll: ").Append(valor_csll).Append("\n");
            sb.Append("  valor_outras_retencoes: ").Append(valor_outras_retencoes).Append("\n");
            sb.Append("  valor_iss: ").Append(valor_iss).Append("\n");
            sb.Append("  valor_iss_retido: ").Append(valor_iss_retido).Append("\n");
            sb.Append("  valor_liquido: ").Append(valor_liquido).Append("\n");
            sb.Append("  aliquota_iss: ").Append(aliquota_iss).Append("\n");
            sb.Append("  aliquota_pis: ").Append(aliquota_pis).Append("\n");
            sb.Append("  aliquota_cofins: ").Append(aliquota_cofins).Append("\n");
            sb.Append("  aliquota_inss: ").Append(aliquota_inss).Append("\n");
            sb.Append("  aliquota_ir: ").Append(aliquota_ir).Append("\n");
            sb.Append("  aliquota_csll: ").Append(aliquota_csll).Append("\n");
            sb.Append("  desconto_incondicionado: ").Append(desconto_incondicionado).Append("\n");
            sb.Append("  desconto_condicionado: ").Append(desconto_condicionado).Append("\n");
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
            return this.Equals(input as RpsServicoValores);
        }

        /// <summary>
        /// Returns true if RpsServicoValores instances are equal
        /// </summary>
        /// <param name="input">Instance of RpsServicoValores to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RpsServicoValores input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.valor_unitario == input.valor_unitario ||
                    this.valor_unitario.Equals(input.valor_unitario)
                ) && 
                (
                    this.valor_servicos == input.valor_servicos ||
                    this.valor_servicos.Equals(input.valor_servicos)
                ) && 
                (
                    this.valor_deducoes == input.valor_deducoes ||
                    this.valor_deducoes.Equals(input.valor_deducoes)
                ) && 
                (
                    this.valor_pis == input.valor_pis ||
                    this.valor_pis.Equals(input.valor_pis)
                ) && 
                (
                    this.valor_cofins == input.valor_cofins ||
                    this.valor_cofins.Equals(input.valor_cofins)
                ) && 
                (
                    this.valor_inss == input.valor_inss ||
                    this.valor_inss.Equals(input.valor_inss)
                ) && 
                (
                    this.valor_ir == input.valor_ir ||
                    this.valor_ir.Equals(input.valor_ir)
                ) && 
                (
                    this.valor_csll == input.valor_csll ||
                    this.valor_csll.Equals(input.valor_csll)
                ) && 
                (
                    this.valor_outras_retencoes == input.valor_outras_retencoes ||
                    this.valor_outras_retencoes.Equals(input.valor_outras_retencoes)
                ) && 
                (
                    this.valor_iss == input.valor_iss ||
                    this.valor_iss.Equals(input.valor_iss)
                ) && 
                (
                    this.valor_iss_retido == input.valor_iss_retido ||
                    this.valor_iss_retido.Equals(input.valor_iss_retido)
                ) && 
                (
                    this.valor_liquido == input.valor_liquido ||
                    this.valor_liquido.Equals(input.valor_liquido)
                ) && 
                (
                    this.aliquota_iss == input.aliquota_iss ||
                    this.aliquota_iss.Equals(input.aliquota_iss)
                ) && 
                (
                    this.aliquota_pis == input.aliquota_pis ||
                    this.aliquota_pis.Equals(input.aliquota_pis)
                ) && 
                (
                    this.aliquota_cofins == input.aliquota_cofins ||
                    this.aliquota_cofins.Equals(input.aliquota_cofins)
                ) && 
                (
                    this.aliquota_inss == input.aliquota_inss ||
                    this.aliquota_inss.Equals(input.aliquota_inss)
                ) && 
                (
                    this.aliquota_ir == input.aliquota_ir ||
                    this.aliquota_ir.Equals(input.aliquota_ir)
                ) && 
                (
                    this.aliquota_csll == input.aliquota_csll ||
                    this.aliquota_csll.Equals(input.aliquota_csll)
                ) && 
                (
                    this.desconto_incondicionado == input.desconto_incondicionado ||
                    this.desconto_incondicionado.Equals(input.desconto_incondicionado)
                ) && 
                (
                    this.desconto_condicionado == input.desconto_condicionado ||
                    this.desconto_condicionado.Equals(input.desconto_condicionado)
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
                hashCode = (hashCode * 59) + this.valor_unitario.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_servicos.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_deducoes.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_pis.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_cofins.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_inss.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_ir.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_csll.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_outras_retencoes.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_iss.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_iss_retido.GetHashCode();
                hashCode = (hashCode * 59) + this.valor_liquido.GetHashCode();
                hashCode = (hashCode * 59) + this.aliquota_iss.GetHashCode();
                hashCode = (hashCode * 59) + this.aliquota_pis.GetHashCode();
                hashCode = (hashCode * 59) + this.aliquota_cofins.GetHashCode();
                hashCode = (hashCode * 59) + this.aliquota_inss.GetHashCode();
                hashCode = (hashCode * 59) + this.aliquota_ir.GetHashCode();
                hashCode = (hashCode * 59) + this.aliquota_csll.GetHashCode();
                hashCode = (hashCode * 59) + this.desconto_incondicionado.GetHashCode();
                hashCode = (hashCode * 59) + this.desconto_condicionado.GetHashCode();
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
