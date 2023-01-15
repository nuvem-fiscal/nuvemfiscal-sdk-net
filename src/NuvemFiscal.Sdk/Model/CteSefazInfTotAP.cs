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
    /// Grupo de informações das quantidades totais de artigos perigosos.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal.
    /// </summary>
    [DataContract(Name = "CteSefazInfTotAP")]
    public partial class CteSefazInfTotAP : IEquatable<CteSefazInfTotAP>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfTotAP" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfTotAP() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfTotAP" /> class.
        /// </summary>
        /// <param name="qTotProd">Quantidade total de artigos perigosos.  15 posições, sendo 11 inteiras e 4 decimais.  Deve indicar a quantidade total do artigo perigoso, tendo como base a unidade referenciada na Tabela 3-1 do Doc 9284, por exemplo: litros  quilogramas  quilograma bruto etc. O preenchimento não deve, entretanto, incluir a unidade de medida. No caso de transporte de material radioativo, deve-se indicar o somatório dos Índices de Transporte (TI). Não indicar a quantidade do artigo perigoso por embalagem. (required).</param>
        /// <param name="uniAP">Unidade de medida.  * 1 - KG  * 2 - KG G (quilograma bruto)  * 3 - LITROS  * 4 - TI (índice de transporte para radioativos)  * 5 - Unidades (apenas para artigos perigosos medidos em unidades que não se enquadram nos itens acima. Exemplo: baterias, celulares, equipamentos, veículos, dentre outros) (required).</param>
        public CteSefazInfTotAP(decimal qTotProd = default(decimal), int uniAP = default(int))
        {
            this.qTotProd = qTotProd;
            this.uniAP = uniAP;
        }

        /// <summary>
        /// Quantidade total de artigos perigosos.  15 posições, sendo 11 inteiras e 4 decimais.  Deve indicar a quantidade total do artigo perigoso, tendo como base a unidade referenciada na Tabela 3-1 do Doc 9284, por exemplo: litros  quilogramas  quilograma bruto etc. O preenchimento não deve, entretanto, incluir a unidade de medida. No caso de transporte de material radioativo, deve-se indicar o somatório dos Índices de Transporte (TI). Não indicar a quantidade do artigo perigoso por embalagem.
        /// </summary>
        /// <value>Quantidade total de artigos perigosos.  15 posições, sendo 11 inteiras e 4 decimais.  Deve indicar a quantidade total do artigo perigoso, tendo como base a unidade referenciada na Tabela 3-1 do Doc 9284, por exemplo: litros  quilogramas  quilograma bruto etc. O preenchimento não deve, entretanto, incluir a unidade de medida. No caso de transporte de material radioativo, deve-se indicar o somatório dos Índices de Transporte (TI). Não indicar a quantidade do artigo perigoso por embalagem.</value>
        [DataMember(Name = "qTotProd", IsRequired = true, EmitDefaultValue = true)]
        public decimal qTotProd { get; set; }

        /// <summary>
        /// Unidade de medida.  * 1 - KG  * 2 - KG G (quilograma bruto)  * 3 - LITROS  * 4 - TI (índice de transporte para radioativos)  * 5 - Unidades (apenas para artigos perigosos medidos em unidades que não se enquadram nos itens acima. Exemplo: baterias, celulares, equipamentos, veículos, dentre outros)
        /// </summary>
        /// <value>Unidade de medida.  * 1 - KG  * 2 - KG G (quilograma bruto)  * 3 - LITROS  * 4 - TI (índice de transporte para radioativos)  * 5 - Unidades (apenas para artigos perigosos medidos em unidades que não se enquadram nos itens acima. Exemplo: baterias, celulares, equipamentos, veículos, dentre outros)</value>
        [DataMember(Name = "uniAP", IsRequired = true, EmitDefaultValue = true)]
        public int uniAP { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfTotAP {\n");
            sb.Append("  qTotProd: ").Append(qTotProd).Append("\n");
            sb.Append("  uniAP: ").Append(uniAP).Append("\n");
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
            return this.Equals(input as CteSefazInfTotAP);
        }

        /// <summary>
        /// Returns true if CteSefazInfTotAP instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfTotAP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfTotAP input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qTotProd == input.qTotProd ||
                    this.qTotProd.Equals(input.qTotProd)
                ) && 
                (
                    this.uniAP == input.uniAP ||
                    this.uniAP.Equals(input.uniAP)
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
                hashCode = (hashCode * 59) + this.qTotProd.GetHashCode();
                hashCode = (hashCode * 59) + this.uniAP.GetHashCode();
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
