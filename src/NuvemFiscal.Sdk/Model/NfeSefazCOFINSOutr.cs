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
    /// NfeSefazCOFINSOutr
    /// </summary>
    [DataContract(Name = "NfeSefazCOFINSOutr")]
    public partial class NfeSefazCOFINSOutr : IEquatable<NfeSefazCOFINSOutr>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSOutr" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCOFINSOutr() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCOFINSOutr" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do COFINS:  49 - Outras Operações de Saída  50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno  51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno  52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação  53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno  54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação  55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação  56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação  60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno  61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno  62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação  63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno  64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação  65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação  66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação  67 - Crédito Presumido - Outras Operações  70 - Operação de Aquisição sem Direito a Crédito  71 - Operação de Aquisição com Isenção  72 - Operação de Aquisição com Suspensão  73 - Operação de Aquisição a Alíquota Zero  74 - Operação de Aquisição sem Incidência da Contribuição  75 - Operação de Aquisição por Substituição Tributária  98 - Outras Operações de Entrada  99 - Outras Operações. (required).</param>
        /// <param name="vBC">Valor da BC do COFINS..</param>
        /// <param name="pCOFINS">Alíquota do COFINS (em percentual)..</param>
        /// <param name="qBCProd">Quantidade Vendida (NT2011/004)..</param>
        /// <param name="vAliqProd">Alíquota do COFINS (em reais) (NT2011/004)..</param>
        /// <param name="vCOFINS">Valor do COFINS. (required).</param>
        public NfeSefazCOFINSOutr(string cST = default(string), decimal vBC = default(decimal), decimal pCOFINS = default(decimal), decimal qBCProd = default(decimal), decimal vAliqProd = default(decimal), decimal vCOFINS = default(decimal))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazCOFINSOutr and cannot be null");
            }
            this.CST = cST;
            this.vCOFINS = vCOFINS;
            this.vBC = vBC;
            this.pCOFINS = pCOFINS;
            this.qBCProd = qBCProd;
            this.vAliqProd = vAliqProd;
        }

        /// <summary>
        /// Código de Situação Tributária do COFINS:  49 - Outras Operações de Saída  50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno  51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno  52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação  53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno  54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação  55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação  56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação  60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno  61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno  62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação  63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno  64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação  65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação  66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação  67 - Crédito Presumido - Outras Operações  70 - Operação de Aquisição sem Direito a Crédito  71 - Operação de Aquisição com Isenção  72 - Operação de Aquisição com Suspensão  73 - Operação de Aquisição a Alíquota Zero  74 - Operação de Aquisição sem Incidência da Contribuição  75 - Operação de Aquisição por Substituição Tributária  98 - Outras Operações de Entrada  99 - Outras Operações.
        /// </summary>
        /// <value>Código de Situação Tributária do COFINS:  49 - Outras Operações de Saída  50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno  51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno  52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação  53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno  54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação  55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação  56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação  60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno  61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno  62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação  63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno  64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação  65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação  66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação  67 - Crédito Presumido - Outras Operações  70 - Operação de Aquisição sem Direito a Crédito  71 - Operação de Aquisição com Isenção  72 - Operação de Aquisição com Suspensão  73 - Operação de Aquisição a Alíquota Zero  74 - Operação de Aquisição sem Incidência da Contribuição  75 - Operação de Aquisição por Substituição Tributária  98 - Outras Operações de Entrada  99 - Outras Operações.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do COFINS.
        /// </summary>
        /// <value>Valor da BC do COFINS.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = false)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Alíquota do COFINS (em percentual).
        /// </summary>
        /// <value>Alíquota do COFINS (em percentual).</value>
        [DataMember(Name = "pCOFINS", EmitDefaultValue = false)]
        public decimal pCOFINS { get; set; }

        /// <summary>
        /// Quantidade Vendida (NT2011/004).
        /// </summary>
        /// <value>Quantidade Vendida (NT2011/004).</value>
        [DataMember(Name = "qBCProd", EmitDefaultValue = false)]
        public decimal qBCProd { get; set; }

        /// <summary>
        /// Alíquota do COFINS (em reais) (NT2011/004).
        /// </summary>
        /// <value>Alíquota do COFINS (em reais) (NT2011/004).</value>
        [DataMember(Name = "vAliqProd", EmitDefaultValue = false)]
        public decimal vAliqProd { get; set; }

        /// <summary>
        /// Valor do COFINS.
        /// </summary>
        /// <value>Valor do COFINS.</value>
        [DataMember(Name = "vCOFINS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vCOFINS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCOFINSOutr {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pCOFINS: ").Append(pCOFINS).Append("\n");
            sb.Append("  qBCProd: ").Append(qBCProd).Append("\n");
            sb.Append("  vAliqProd: ").Append(vAliqProd).Append("\n");
            sb.Append("  vCOFINS: ").Append(vCOFINS).Append("\n");
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
            return this.Equals(input as NfeSefazCOFINSOutr);
        }

        /// <summary>
        /// Returns true if NfeSefazCOFINSOutr instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCOFINSOutr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCOFINSOutr input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.pCOFINS == input.pCOFINS ||
                    this.pCOFINS.Equals(input.pCOFINS)
                ) && 
                (
                    this.qBCProd == input.qBCProd ||
                    this.qBCProd.Equals(input.qBCProd)
                ) && 
                (
                    this.vAliqProd == input.vAliqProd ||
                    this.vAliqProd.Equals(input.vAliqProd)
                ) && 
                (
                    this.vCOFINS == input.vCOFINS ||
                    this.vCOFINS.Equals(input.vCOFINS)
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pCOFINS.GetHashCode();
                hashCode = (hashCode * 59) + this.qBCProd.GetHashCode();
                hashCode = (hashCode * 59) + this.vAliqProd.GetHashCode();
                hashCode = (hashCode * 59) + this.vCOFINS.GetHashCode();
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
