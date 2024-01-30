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
    /// Dados do Produto ou Serviço.
    /// </summary>
    [DataContract(Name = "NfcomSefazProd")]
    public partial class NfcomSefazProd : IEquatable<NfcomSefazProd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazProd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazProd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazProd" /> class.
        /// </summary>
        /// <param name="cProd">Código do produto ou serviço. (required).</param>
        /// <param name="xProd">Descrição do produto ou serviço. (required).</param>
        /// <param name="cClass">Código de classificação.  Tabela de Classificação de Item da NFCom (validar por RV). (required).</param>
        /// <param name="cFOP">CFOP.  Utilizar Tabela de CFOP..</param>
        /// <param name="cNPJLD">CNPJ da operadora LD.  Informar o CNPJ da operadora LD que irá lançar o item de cofaturamento em nota do tipo faturamento 2..</param>
        /// <param name="uMed">Unidade Básica de Medida.  * 1 - Minuto  * 2 - MB  * 3 - GB  * 4 - UN (required).</param>
        /// <param name="qFaturada">Quantidade Faturada.  Informar a quantidade de comercialização do produto . (required).</param>
        /// <param name="vItem">Valor unitário do item. (required).</param>
        /// <param name="vDesc">Valor do Desconto..</param>
        /// <param name="vOutro">Outras despesas acessórias..</param>
        /// <param name="vProd">Valor total do item. (required).</param>
        /// <param name="dExpiracao">Data de expiração de crédito.  Formato AAAA-MM-DD..</param>
        /// <param name="indDevolucao">Indicador de devolução do valor do item.  * 1 - Devolução do valor do item.</param>
        public NfcomSefazProd(string cProd = default(string), string xProd = default(string), string cClass = default(string), string cFOP = default(string), string cNPJLD = default(string), int? uMed = default(int?), decimal? qFaturada = default(decimal?), decimal? vItem = default(decimal?), decimal? vDesc = default(decimal?), decimal? vOutro = default(decimal?), decimal? vProd = default(decimal?), DateTime? dExpiracao = default(DateTime?), int? indDevolucao = default(int?))
        {
            // to ensure "cProd" is required (not null)
            if (cProd == null)
            {
                throw new ArgumentNullException("cProd is a required property for NfcomSefazProd and cannot be null");
            }
            this.cProd = cProd;
            // to ensure "xProd" is required (not null)
            if (xProd == null)
            {
                throw new ArgumentNullException("xProd is a required property for NfcomSefazProd and cannot be null");
            }
            this.xProd = xProd;
            // to ensure "cClass" is required (not null)
            if (cClass == null)
            {
                throw new ArgumentNullException("cClass is a required property for NfcomSefazProd and cannot be null");
            }
            this.cClass = cClass;
            // to ensure "uMed" is required (not null)
            if (uMed == null)
            {
                throw new ArgumentNullException("uMed is a required property for NfcomSefazProd and cannot be null");
            }
            this.uMed = uMed;
            // to ensure "qFaturada" is required (not null)
            if (qFaturada == null)
            {
                throw new ArgumentNullException("qFaturada is a required property for NfcomSefazProd and cannot be null");
            }
            this.qFaturada = qFaturada;
            // to ensure "vItem" is required (not null)
            if (vItem == null)
            {
                throw new ArgumentNullException("vItem is a required property for NfcomSefazProd and cannot be null");
            }
            this.vItem = vItem;
            // to ensure "vProd" is required (not null)
            if (vProd == null)
            {
                throw new ArgumentNullException("vProd is a required property for NfcomSefazProd and cannot be null");
            }
            this.vProd = vProd;
            this.CFOP = cFOP;
            this.CNPJLD = cNPJLD;
            this.vDesc = vDesc;
            this.vOutro = vOutro;
            this.dExpiracao = dExpiracao;
            this.indDevolucao = indDevolucao;
        }

        /// <summary>
        /// Código do produto ou serviço.
        /// </summary>
        /// <value>Código do produto ou serviço.</value>
        [DataMember(Name = "cProd", IsRequired = true, EmitDefaultValue = true)]
        public string cProd { get; set; }

        /// <summary>
        /// Descrição do produto ou serviço.
        /// </summary>
        /// <value>Descrição do produto ou serviço.</value>
        [DataMember(Name = "xProd", IsRequired = true, EmitDefaultValue = true)]
        public string xProd { get; set; }

        /// <summary>
        /// Código de classificação.  Tabela de Classificação de Item da NFCom (validar por RV).
        /// </summary>
        /// <value>Código de classificação.  Tabela de Classificação de Item da NFCom (validar por RV).</value>
        [DataMember(Name = "cClass", IsRequired = true, EmitDefaultValue = true)]
        public string cClass { get; set; }

        /// <summary>
        /// CFOP.  Utilizar Tabela de CFOP.
        /// </summary>
        /// <value>CFOP.  Utilizar Tabela de CFOP.</value>
        [DataMember(Name = "CFOP", EmitDefaultValue = true)]
        public string CFOP { get; set; }

        /// <summary>
        /// CNPJ da operadora LD.  Informar o CNPJ da operadora LD que irá lançar o item de cofaturamento em nota do tipo faturamento 2.
        /// </summary>
        /// <value>CNPJ da operadora LD.  Informar o CNPJ da operadora LD que irá lançar o item de cofaturamento em nota do tipo faturamento 2.</value>
        [DataMember(Name = "CNPJLD", EmitDefaultValue = true)]
        public string CNPJLD { get; set; }

        /// <summary>
        /// Unidade Básica de Medida.  * 1 - Minuto  * 2 - MB  * 3 - GB  * 4 - UN
        /// </summary>
        /// <value>Unidade Básica de Medida.  * 1 - Minuto  * 2 - MB  * 3 - GB  * 4 - UN</value>
        [DataMember(Name = "uMed", IsRequired = true, EmitDefaultValue = true)]
        public int? uMed { get; set; }

        /// <summary>
        /// Quantidade Faturada.  Informar a quantidade de comercialização do produto .
        /// </summary>
        /// <value>Quantidade Faturada.  Informar a quantidade de comercialização do produto .</value>
        [DataMember(Name = "qFaturada", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qFaturada { get; set; }

        /// <summary>
        /// Valor unitário do item.
        /// </summary>
        /// <value>Valor unitário do item.</value>
        [DataMember(Name = "vItem", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vItem { get; set; }

        /// <summary>
        /// Valor do Desconto.
        /// </summary>
        /// <value>Valor do Desconto.</value>
        [DataMember(Name = "vDesc", EmitDefaultValue = true)]
        public decimal? vDesc { get; set; }

        /// <summary>
        /// Outras despesas acessórias.
        /// </summary>
        /// <value>Outras despesas acessórias.</value>
        [DataMember(Name = "vOutro", EmitDefaultValue = true)]
        public decimal? vOutro { get; set; }

        /// <summary>
        /// Valor total do item.
        /// </summary>
        /// <value>Valor total do item.</value>
        [DataMember(Name = "vProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vProd { get; set; }

        /// <summary>
        /// Data de expiração de crédito.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de expiração de crédito.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dExpiracao", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dExpiracao { get; set; }

        /// <summary>
        /// Indicador de devolução do valor do item.  * 1 - Devolução do valor do item
        /// </summary>
        /// <value>Indicador de devolução do valor do item.  * 1 - Devolução do valor do item</value>
        [DataMember(Name = "indDevolucao", EmitDefaultValue = true)]
        public int? indDevolucao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazProd {\n");
            sb.Append("  cProd: ").Append(cProd).Append("\n");
            sb.Append("  xProd: ").Append(xProd).Append("\n");
            sb.Append("  cClass: ").Append(cClass).Append("\n");
            sb.Append("  CFOP: ").Append(CFOP).Append("\n");
            sb.Append("  CNPJLD: ").Append(CNPJLD).Append("\n");
            sb.Append("  uMed: ").Append(uMed).Append("\n");
            sb.Append("  qFaturada: ").Append(qFaturada).Append("\n");
            sb.Append("  vItem: ").Append(vItem).Append("\n");
            sb.Append("  vDesc: ").Append(vDesc).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  vProd: ").Append(vProd).Append("\n");
            sb.Append("  dExpiracao: ").Append(dExpiracao).Append("\n");
            sb.Append("  indDevolucao: ").Append(indDevolucao).Append("\n");
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
            return this.Equals(input as NfcomSefazProd);
        }

        /// <summary>
        /// Returns true if NfcomSefazProd instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazProd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazProd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cProd == input.cProd ||
                    (this.cProd != null &&
                    this.cProd.Equals(input.cProd))
                ) && 
                (
                    this.xProd == input.xProd ||
                    (this.xProd != null &&
                    this.xProd.Equals(input.xProd))
                ) && 
                (
                    this.cClass == input.cClass ||
                    (this.cClass != null &&
                    this.cClass.Equals(input.cClass))
                ) && 
                (
                    this.CFOP == input.CFOP ||
                    (this.CFOP != null &&
                    this.CFOP.Equals(input.CFOP))
                ) && 
                (
                    this.CNPJLD == input.CNPJLD ||
                    (this.CNPJLD != null &&
                    this.CNPJLD.Equals(input.CNPJLD))
                ) && 
                (
                    this.uMed == input.uMed ||
                    (this.uMed != null &&
                    this.uMed.Equals(input.uMed))
                ) && 
                (
                    this.qFaturada == input.qFaturada ||
                    (this.qFaturada != null &&
                    this.qFaturada.Equals(input.qFaturada))
                ) && 
                (
                    this.vItem == input.vItem ||
                    (this.vItem != null &&
                    this.vItem.Equals(input.vItem))
                ) && 
                (
                    this.vDesc == input.vDesc ||
                    (this.vDesc != null &&
                    this.vDesc.Equals(input.vDesc))
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    (this.vOutro != null &&
                    this.vOutro.Equals(input.vOutro))
                ) && 
                (
                    this.vProd == input.vProd ||
                    (this.vProd != null &&
                    this.vProd.Equals(input.vProd))
                ) && 
                (
                    this.dExpiracao == input.dExpiracao ||
                    (this.dExpiracao != null &&
                    this.dExpiracao.Equals(input.dExpiracao))
                ) && 
                (
                    this.indDevolucao == input.indDevolucao ||
                    (this.indDevolucao != null &&
                    this.indDevolucao.Equals(input.indDevolucao))
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
                if (this.cProd != null)
                {
                    hashCode = (hashCode * 59) + this.cProd.GetHashCode();
                }
                if (this.xProd != null)
                {
                    hashCode = (hashCode * 59) + this.xProd.GetHashCode();
                }
                if (this.cClass != null)
                {
                    hashCode = (hashCode * 59) + this.cClass.GetHashCode();
                }
                if (this.CFOP != null)
                {
                    hashCode = (hashCode * 59) + this.CFOP.GetHashCode();
                }
                if (this.CNPJLD != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJLD.GetHashCode();
                }
                if (this.uMed != null)
                {
                    hashCode = (hashCode * 59) + this.uMed.GetHashCode();
                }
                if (this.qFaturada != null)
                {
                    hashCode = (hashCode * 59) + this.qFaturada.GetHashCode();
                }
                if (this.vItem != null)
                {
                    hashCode = (hashCode * 59) + this.vItem.GetHashCode();
                }
                if (this.vDesc != null)
                {
                    hashCode = (hashCode * 59) + this.vDesc.GetHashCode();
                }
                if (this.vOutro != null)
                {
                    hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                }
                if (this.vProd != null)
                {
                    hashCode = (hashCode * 59) + this.vProd.GetHashCode();
                }
                if (this.dExpiracao != null)
                {
                    hashCode = (hashCode * 59) + this.dExpiracao.GetHashCode();
                }
                if (this.indDevolucao != null)
                {
                    hashCode = (hashCode * 59) + this.indDevolucao.GetHashCode();
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
            // cProd (string) maxLength
            if (this.cProd != null && this.cProd.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cProd, length must be less than 60.", new [] { "cProd" });
            }

            // cProd (string) minLength
            if (this.cProd != null && this.cProd.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cProd, length must be greater than 1.", new [] { "cProd" });
            }

            // xProd (string) maxLength
            if (this.xProd != null && this.xProd.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xProd, length must be less than 120.", new [] { "xProd" });
            }

            // xProd (string) minLength
            if (this.xProd != null && this.xProd.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xProd, length must be greater than 1.", new [] { "xProd" });
            }

            // cClass (string) maxLength
            if (this.cClass != null && this.cClass.Length > 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cClass, length must be less than 7.", new [] { "cClass" });
            }

            // cClass (string) minLength
            if (this.cClass != null && this.cClass.Length < 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cClass, length must be greater than 7.", new [] { "cClass" });
            }

            yield break;
        }
    }

}
