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
    /// NfeSefazICMSSN201
    /// </summary>
    [DataContract(Name = "NfeSefazICMSSN201")]
    public partial class NfeSefazICMSSN201 : IEquatable<NfeSefazICMSSN201>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSSN201" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMSSN201() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSSN201" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cSOSN">201- Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária (v.2.0). (required).</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor). (v2.0)  6 - Valor da Operação. (required).</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST (v2.0)..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST  (v2.0)..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST (v2.0). (required).</param>
        /// <param name="pICMSST">Alíquota do ICMS ST (v2.0). (required).</param>
        /// <param name="vICMSST">Valor do ICMS ST (v2.0). (required).</param>
        /// <param name="vBCFCPST">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCPST">Percentual de FCP retido por substituição tributária..</param>
        /// <param name="vFCPST">Valor do FCP retido por substituição tributária..</param>
        /// <param name="pCredSN">Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0). (required).</param>
        /// <param name="vCredICMSSN">Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0). (required).</param>
        public NfeSefazICMSSN201(int orig = default(int), string cSOSN = default(string), int modBCST = default(int), decimal pMVAST = default(decimal), decimal pRedBCST = default(decimal), decimal vBCST = default(decimal), decimal pICMSST = default(decimal), decimal vICMSST = default(decimal), decimal vBCFCPST = default(decimal), decimal pFCPST = default(decimal), decimal vFCPST = default(decimal), decimal pCredSN = default(decimal), decimal vCredICMSSN = default(decimal))
        {
            this.orig = orig;
            // to ensure "cSOSN" is required (not null)
            if (cSOSN == null)
            {
                throw new ArgumentNullException("cSOSN is a required property for NfeSefazICMSSN201 and cannot be null");
            }
            this.CSOSN = cSOSN;
            this.modBCST = modBCST;
            this.vBCST = vBCST;
            this.pICMSST = pICMSST;
            this.vICMSST = vICMSST;
            this.pCredSN = pCredSN;
            this.vCredICMSSN = vCredICMSSN;
            this.pMVAST = pMVAST;
            this.pRedBCST = pRedBCST;
            this.vBCFCPST = vBCFCPST;
            this.pFCPST = pFCPST;
            this.vFCPST = vFCPST;
        }

        /// <summary>
        /// Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// 201- Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária (v.2.0).
        /// </summary>
        /// <value>201- Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária (v.2.0).</value>
        [DataMember(Name = "CSOSN", IsRequired = true, EmitDefaultValue = true)]
        public string CSOSN { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor). (v2.0)  6 - Valor da Operação.
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor). (v2.0)  6 - Valor da Operação.</value>
        [DataMember(Name = "modBCST", IsRequired = true, EmitDefaultValue = true)]
        public int modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST (v2.0).
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST (v2.0).</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = false)]
        public decimal pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST  (v2.0).
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST  (v2.0).</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = false)]
        public decimal pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST (v2.0).
        /// </summary>
        /// <value>Valor da BC do ICMS ST (v2.0).</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST (v2.0).
        /// </summary>
        /// <value>Alíquota do ICMS ST (v2.0).</value>
        [DataMember(Name = "pICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST (v2.0).
        /// </summary>
        /// <value>Valor do ICMS ST (v2.0).</value>
        [DataMember(Name = "vICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSST { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP.</value>
        [DataMember(Name = "vBCFCPST", EmitDefaultValue = false)]
        public decimal vBCFCPST { get; set; }

        /// <summary>
        /// Percentual de FCP retido por substituição tributária.
        /// </summary>
        /// <value>Percentual de FCP retido por substituição tributária.</value>
        [DataMember(Name = "pFCPST", EmitDefaultValue = false)]
        public decimal pFCPST { get; set; }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        /// <value>Valor do FCP retido por substituição tributária.</value>
        [DataMember(Name = "vFCPST", EmitDefaultValue = false)]
        public decimal vFCPST { get; set; }

        /// <summary>
        /// Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0).
        /// </summary>
        /// <value>Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0).</value>
        [DataMember(Name = "pCredSN", IsRequired = true, EmitDefaultValue = true)]
        public decimal pCredSN { get; set; }

        /// <summary>
        /// Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0).
        /// </summary>
        /// <value>Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0).</value>
        [DataMember(Name = "vCredICMSSN", IsRequired = true, EmitDefaultValue = true)]
        public decimal vCredICMSSN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMSSN201 {\n");
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
            sb.Append("  pCredSN: ").Append(pCredSN).Append("\n");
            sb.Append("  vCredICMSSN: ").Append(vCredICMSSN).Append("\n");
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
            return this.Equals(input as NfeSefazICMSSN201);
        }

        /// <summary>
        /// Returns true if NfeSefazICMSSN201 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMSSN201 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMSSN201 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.orig == input.orig ||
                    this.orig.Equals(input.orig)
                ) && 
                (
                    this.CSOSN == input.CSOSN ||
                    (this.CSOSN != null &&
                    this.CSOSN.Equals(input.CSOSN))
                ) && 
                (
                    this.modBCST == input.modBCST ||
                    this.modBCST.Equals(input.modBCST)
                ) && 
                (
                    this.pMVAST == input.pMVAST ||
                    this.pMVAST.Equals(input.pMVAST)
                ) && 
                (
                    this.pRedBCST == input.pRedBCST ||
                    this.pRedBCST.Equals(input.pRedBCST)
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    this.vBCST.Equals(input.vBCST)
                ) && 
                (
                    this.pICMSST == input.pICMSST ||
                    this.pICMSST.Equals(input.pICMSST)
                ) && 
                (
                    this.vICMSST == input.vICMSST ||
                    this.vICMSST.Equals(input.vICMSST)
                ) && 
                (
                    this.vBCFCPST == input.vBCFCPST ||
                    this.vBCFCPST.Equals(input.vBCFCPST)
                ) && 
                (
                    this.pFCPST == input.pFCPST ||
                    this.pFCPST.Equals(input.pFCPST)
                ) && 
                (
                    this.vFCPST == input.vFCPST ||
                    this.vFCPST.Equals(input.vFCPST)
                ) && 
                (
                    this.pCredSN == input.pCredSN ||
                    this.pCredSN.Equals(input.pCredSN)
                ) && 
                (
                    this.vCredICMSSN == input.vCredICMSSN ||
                    this.vCredICMSSN.Equals(input.vCredICMSSN)
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
                hashCode = (hashCode * 59) + this.orig.GetHashCode();
                if (this.CSOSN != null)
                {
                    hashCode = (hashCode * 59) + this.CSOSN.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.modBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.pMVAST.GetHashCode();
                hashCode = (hashCode * 59) + this.pRedBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSST.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSST.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.pFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.pCredSN.GetHashCode();
                hashCode = (hashCode * 59) + this.vCredICMSSN.GetHashCode();
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
