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
    /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN&#x3D;202 ou 203 (v.2.0).
    /// </summary>
    [DataContract(Name = "NfeSefazICMSSN202")]
    public partial class NfeSefazICMSSN202 : IEquatable<NfeSefazICMSSN202>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSSN202" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMSSN202() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSSN202" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cSOSN">* 202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária  * 203 - Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária (v.2.0) (required).</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor). (v2.0)  * 6 - Valor da Operação (required).</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST (v2.0)..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST  (v2.0)..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST (v2.0). (required).</param>
        /// <param name="pICMSST">Alíquota do ICMS ST (v2.0). (required).</param>
        /// <param name="vICMSST">Valor do ICMS ST (v2.0). (required).</param>
        /// <param name="vBCFCPST">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCPST">Percentual de FCP retido por substituição tributária..</param>
        /// <param name="vFCPST">Valor do FCP retido por substituição tributária..</param>
        public NfeSefazICMSSN202(int? orig = default(int?), string cSOSN = default(string), int? modBCST = default(int?), decimal? pMVAST = default(decimal?), decimal? pRedBCST = default(decimal?), decimal? vBCST = default(decimal?), decimal? pICMSST = default(decimal?), decimal? vICMSST = default(decimal?), decimal? vBCFCPST = default(decimal?), decimal? pFCPST = default(decimal?), decimal? vFCPST = default(decimal?))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMSSN202 and cannot be null");
            }
            this.orig = orig;
            // to ensure "cSOSN" is required (not null)
            if (cSOSN == null)
            {
                throw new ArgumentNullException("cSOSN is a required property for NfeSefazICMSSN202 and cannot be null");
            }
            this.CSOSN = cSOSN;
            // to ensure "modBCST" is required (not null)
            if (modBCST == null)
            {
                throw new ArgumentNullException("modBCST is a required property for NfeSefazICMSSN202 and cannot be null");
            }
            this.modBCST = modBCST;
            // to ensure "vBCST" is required (not null)
            if (vBCST == null)
            {
                throw new ArgumentNullException("vBCST is a required property for NfeSefazICMSSN202 and cannot be null");
            }
            this.vBCST = vBCST;
            // to ensure "pICMSST" is required (not null)
            if (pICMSST == null)
            {
                throw new ArgumentNullException("pICMSST is a required property for NfeSefazICMSSN202 and cannot be null");
            }
            this.pICMSST = pICMSST;
            // to ensure "vICMSST" is required (not null)
            if (vICMSST == null)
            {
                throw new ArgumentNullException("vICMSST is a required property for NfeSefazICMSSN202 and cannot be null");
            }
            this.vICMSST = vICMSST;
            this.pMVAST = pMVAST;
            this.pRedBCST = pRedBCST;
            this.vBCFCPST = vBCFCPST;
            this.pFCPST = pFCPST;
            this.vFCPST = vFCPST;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int? orig { get; set; }

        /// <summary>
        /// * 202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária  * 203 - Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária (v.2.0)
        /// </summary>
        /// <value>* 202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária  * 203 - Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária (v.2.0)</value>
        [DataMember(Name = "CSOSN", IsRequired = true, EmitDefaultValue = true)]
        public string CSOSN { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor). (v2.0)  * 6 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor). (v2.0)  * 6 - Valor da Operação</value>
        [DataMember(Name = "modBCST", IsRequired = true, EmitDefaultValue = true)]
        public int? modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST (v2.0).
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST (v2.0).</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = true)]
        public decimal? pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST  (v2.0).
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST  (v2.0).</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = true)]
        public decimal? pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST (v2.0).
        /// </summary>
        /// <value>Valor da BC do ICMS ST (v2.0).</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST (v2.0).
        /// </summary>
        /// <value>Alíquota do ICMS ST (v2.0).</value>
        [DataMember(Name = "pICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST (v2.0).
        /// </summary>
        /// <value>Valor do ICMS ST (v2.0).</value>
        [DataMember(Name = "vICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSST { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP.</value>
        [DataMember(Name = "vBCFCPST", EmitDefaultValue = true)]
        public decimal? vBCFCPST { get; set; }

        /// <summary>
        /// Percentual de FCP retido por substituição tributária.
        /// </summary>
        /// <value>Percentual de FCP retido por substituição tributária.</value>
        [DataMember(Name = "pFCPST", EmitDefaultValue = true)]
        public decimal? pFCPST { get; set; }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        /// <value>Valor do FCP retido por substituição tributária.</value>
        [DataMember(Name = "vFCPST", EmitDefaultValue = true)]
        public decimal? vFCPST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMSSN202 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CSOSN: ").Append(CSOSN).Append("\n");
            sb.Append("  modBCST: ").Append(modBCST).Append("\n");
            sb.Append("  pMVAST: ").Append(pMVAST).Append("\n");
            sb.Append("  pRedBCST: ").Append(pRedBCST).Append("\n");
            sb.Append("  vBCST: ").Append(vBCST).Append("\n");
            sb.Append("  pICMSST: ").Append(pICMSST).Append("\n");
            sb.Append("  vICMSST: ").Append(vICMSST).Append("\n");
            sb.Append("  vBCFCPST: ").Append(vBCFCPST).Append("\n");
            sb.Append("  pFCPST: ").Append(pFCPST).Append("\n");
            sb.Append("  vFCPST: ").Append(vFCPST).Append("\n");
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
            return this.Equals(input as NfeSefazICMSSN202);
        }

        /// <summary>
        /// Returns true if NfeSefazICMSSN202 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMSSN202 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMSSN202 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.orig == input.orig ||
                    (this.orig != null &&
                    this.orig.Equals(input.orig))
                ) && 
                (
                    this.CSOSN == input.CSOSN ||
                    (this.CSOSN != null &&
                    this.CSOSN.Equals(input.CSOSN))
                ) && 
                (
                    this.modBCST == input.modBCST ||
                    (this.modBCST != null &&
                    this.modBCST.Equals(input.modBCST))
                ) && 
                (
                    this.pMVAST == input.pMVAST ||
                    (this.pMVAST != null &&
                    this.pMVAST.Equals(input.pMVAST))
                ) && 
                (
                    this.pRedBCST == input.pRedBCST ||
                    (this.pRedBCST != null &&
                    this.pRedBCST.Equals(input.pRedBCST))
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    (this.vBCST != null &&
                    this.vBCST.Equals(input.vBCST))
                ) && 
                (
                    this.pICMSST == input.pICMSST ||
                    (this.pICMSST != null &&
                    this.pICMSST.Equals(input.pICMSST))
                ) && 
                (
                    this.vICMSST == input.vICMSST ||
                    (this.vICMSST != null &&
                    this.vICMSST.Equals(input.vICMSST))
                ) && 
                (
                    this.vBCFCPST == input.vBCFCPST ||
                    (this.vBCFCPST != null &&
                    this.vBCFCPST.Equals(input.vBCFCPST))
                ) && 
                (
                    this.pFCPST == input.pFCPST ||
                    (this.pFCPST != null &&
                    this.pFCPST.Equals(input.pFCPST))
                ) && 
                (
                    this.vFCPST == input.vFCPST ||
                    (this.vFCPST != null &&
                    this.vFCPST.Equals(input.vFCPST))
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
                if (this.orig != null)
                {
                    hashCode = (hashCode * 59) + this.orig.GetHashCode();
                }
                if (this.CSOSN != null)
                {
                    hashCode = (hashCode * 59) + this.CSOSN.GetHashCode();
                }
                if (this.modBCST != null)
                {
                    hashCode = (hashCode * 59) + this.modBCST.GetHashCode();
                }
                if (this.pMVAST != null)
                {
                    hashCode = (hashCode * 59) + this.pMVAST.GetHashCode();
                }
                if (this.pRedBCST != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBCST.GetHashCode();
                }
                if (this.vBCST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                }
                if (this.pICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSST.GetHashCode();
                }
                if (this.vICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSST.GetHashCode();
                }
                if (this.vBCFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCFCPST.GetHashCode();
                }
                if (this.pFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPST.GetHashCode();
                }
                if (this.vFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
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
            // pMVAST (decimal?) minimum
            if (this.pMVAST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pMVAST, must be a value greater than or equal to 0.", new [] { "pMVAST" });
            }

            // pRedBCST (decimal?) minimum
            if (this.pRedBCST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedBCST, must be a value greater than or equal to 0.", new [] { "pRedBCST" });
            }

            // vBCST (decimal?) minimum
            if (this.vBCST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCST, must be a value greater than or equal to 0.", new [] { "vBCST" });
            }

            // pICMSST (decimal?) minimum
            if (this.pICMSST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pICMSST, must be a value greater than or equal to 0.", new [] { "pICMSST" });
            }

            // vICMSST (decimal?) minimum
            if (this.vICMSST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSST, must be a value greater than or equal to 0.", new [] { "vICMSST" });
            }

            // vBCFCPST (decimal?) minimum
            if (this.vBCFCPST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCFCPST, must be a value greater than or equal to 0.", new [] { "vBCFCPST" });
            }

            // pFCPST (decimal?) minimum
            if (this.pFCPST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCPST, must be a value greater than or equal to 0.", new [] { "pFCPST" });
            }

            // vFCPST (decimal?) minimum
            if (this.vFCPST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPST, must be a value greater than or equal to 0.", new [] { "vFCPST" });
            }

            yield break;
        }
    }

}
