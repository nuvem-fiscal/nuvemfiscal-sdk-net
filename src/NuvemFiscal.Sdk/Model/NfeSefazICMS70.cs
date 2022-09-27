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
    /// NfeSefazICMS70
    /// </summary>
    [DataContract(Name = "NfeSefazICMS70")]
    public partial class NfeSefazICMS70 : IEquatable<NfeSefazICMS70>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS70" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS70() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS70" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária. (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação. (required).</param>
        /// <param name="pRedBC">Percentual de redução da BC. (required).</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="vBCFCP">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCP">Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCP">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor);  6 - Valor da Operação. (required).</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST. (required).</param>
        /// <param name="pICMSST">Alíquota do ICMS ST. (required).</param>
        /// <param name="vICMSST">Valor do ICMS ST. (required).</param>
        /// <param name="vBCFCPST">Valor da Base de cálculo do FCP retido por substituição tributária..</param>
        /// <param name="pFCPST">Percentual de FCP retido por substituição tributária..</param>
        /// <param name="vFCPST">Valor do FCP retido por substituição tributária..</param>
        /// <param name="vICMSDeson">Valor do ICMS de desoneração..</param>
        /// <param name="motDesICMS">Motivo da desoneração do ICMS:3-Uso na agropecuária;9-Outros;12-Fomento agropecuário..</param>
        /// <param name="vICMSSTDeson">Valor do ICMS-ST desonerado..</param>
        /// <param name="motDesICMSST">Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária; 9-Outros; 12-Fomento agropecuário..</param>
        public NfeSefazICMS70(int orig = default(int), string cST = default(string), int modBC = default(int), decimal pRedBC = default(decimal), decimal vBC = default(decimal), decimal pICMS = default(decimal), decimal vICMS = default(decimal), decimal vBCFCP = default(decimal), decimal pFCP = default(decimal), decimal vFCP = default(decimal), int modBCST = default(int), decimal pMVAST = default(decimal), decimal pRedBCST = default(decimal), decimal vBCST = default(decimal), decimal pICMSST = default(decimal), decimal vICMSST = default(decimal), decimal vBCFCPST = default(decimal), decimal pFCPST = default(decimal), decimal vFCPST = default(decimal), decimal vICMSDeson = default(decimal), int motDesICMS = default(int), decimal vICMSSTDeson = default(decimal), int motDesICMSST = default(int))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS70 and cannot be null");
            }
            this.CST = cST;
            this.modBC = modBC;
            this.pRedBC = pRedBC;
            this.vBC = vBC;
            this.pICMS = pICMS;
            this.vICMS = vICMS;
            this.modBCST = modBCST;
            this.vBCST = vBCST;
            this.pICMSST = pICMSST;
            this.vICMSST = vICMSST;
            this.vBCFCP = vBCFCP;
            this.pFCP = pFCP;
            this.vFCP = vFCP;
            this.pMVAST = pMVAST;
            this.pRedBCST = pRedBCST;
            this.vBCFCPST = vBCFCPST;
            this.pFCPST = pFCPST;
            this.vFCPST = vFCPST;
            this.vICMSDeson = vICMSDeson;
            this.motDesICMS = motDesICMS;
            this.vICMSSTDeson = vICMSSTDeson;
            this.motDesICMSST = motDesICMSST;
        }

        /// <summary>
        /// Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária.
        /// </summary>
        /// <value>Tributção pelo ICMS  70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação.
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS:  0 - Margem Valor Agregado (%%);  1 - Pauta (valor);  2 - Preço Tabelado Máximo (valor);  3 - Valor da Operação.</value>
        [DataMember(Name = "modBC", IsRequired = true, EmitDefaultValue = true)]
        public int modBC { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal pRedBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMS { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP.</value>
        [DataMember(Name = "vBCFCP", EmitDefaultValue = false)]
        public decimal vBCFCP { get; set; }

        /// <summary>
        /// Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "pFCP", EmitDefaultValue = false)]
        public decimal pFCP { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "vFCP", EmitDefaultValue = false)]
        public decimal vFCP { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor);  6 - Valor da Operação.
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  0 – Preço tabelado ou máximo  sugerido;  1 - Lista Negativa (valor);  2 - Lista Positiva (valor);  3 - Lista Neutra (valor);  4 - Margem Valor Agregado (%%);  5 - Pauta (valor);  6 - Valor da Operação.</value>
        [DataMember(Name = "modBCST", IsRequired = true, EmitDefaultValue = true)]
        public int modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST.
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST.</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = false)]
        public decimal pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST.
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST.</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = false)]
        public decimal pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST.
        /// </summary>
        /// <value>Valor da BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST.
        /// </summary>
        /// <value>Alíquota do ICMS ST.</value>
        [DataMember(Name = "pICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST.
        /// </summary>
        /// <value>Valor do ICMS ST.</value>
        [DataMember(Name = "vICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSST { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP retido por substituição tributária.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP retido por substituição tributária.</value>
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
        /// Valor do ICMS de desoneração.
        /// </summary>
        /// <value>Valor do ICMS de desoneração.</value>
        [DataMember(Name = "vICMSDeson", EmitDefaultValue = false)]
        public decimal vICMSDeson { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS:3-Uso na agropecuária;9-Outros;12-Fomento agropecuário.
        /// </summary>
        /// <value>Motivo da desoneração do ICMS:3-Uso na agropecuária;9-Outros;12-Fomento agropecuário.</value>
        [DataMember(Name = "motDesICMS", EmitDefaultValue = false)]
        public int motDesICMS { get; set; }

        /// <summary>
        /// Valor do ICMS-ST desonerado.
        /// </summary>
        /// <value>Valor do ICMS-ST desonerado.</value>
        [DataMember(Name = "vICMSSTDeson", EmitDefaultValue = false)]
        public decimal vICMSSTDeson { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária; 9-Outros; 12-Fomento agropecuário.
        /// </summary>
        /// <value>Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária; 9-Outros; 12-Fomento agropecuário.</value>
        [DataMember(Name = "motDesICMSST", EmitDefaultValue = false)]
        public int motDesICMSST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS70 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  modBC: ").Append(modBC).Append("\n");
            sb.Append("  pRedBC: ").Append(pRedBC).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vBCFCP: ").Append(vBCFCP).Append("\n");
            sb.Append("  pFCP: ").Append(pFCP).Append("\n");
            sb.Append("  vFCP: ").Append(vFCP).Append("\n");
            sb.Append("  modBCST: ").Append(modBCST).Append("\n");
            sb.Append("  pMVAST: ").Append(pMVAST).Append("\n");
            sb.Append("  pRedBCST: ").Append(pRedBCST).Append("\n");
            sb.Append("  vBCST: ").Append(vBCST).Append("\n");
            sb.Append("  pICMSST: ").Append(pICMSST).Append("\n");
            sb.Append("  vICMSST: ").Append(vICMSST).Append("\n");
            sb.Append("  vBCFCPST: ").Append(vBCFCPST).Append("\n");
            sb.Append("  pFCPST: ").Append(pFCPST).Append("\n");
            sb.Append("  vFCPST: ").Append(vFCPST).Append("\n");
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  motDesICMS: ").Append(motDesICMS).Append("\n");
            sb.Append("  vICMSSTDeson: ").Append(vICMSSTDeson).Append("\n");
            sb.Append("  motDesICMSST: ").Append(motDesICMSST).Append("\n");
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
            return this.Equals(input as NfeSefazICMS70);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS70 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS70 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS70 input)
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
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.modBC == input.modBC ||
                    this.modBC.Equals(input.modBC)
                ) && 
                (
                    this.pRedBC == input.pRedBC ||
                    this.pRedBC.Equals(input.pRedBC)
                ) && 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    this.pICMS.Equals(input.pICMS)
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    this.vICMS.Equals(input.vICMS)
                ) && 
                (
                    this.vBCFCP == input.vBCFCP ||
                    this.vBCFCP.Equals(input.vBCFCP)
                ) && 
                (
                    this.pFCP == input.pFCP ||
                    this.pFCP.Equals(input.pFCP)
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    this.vFCP.Equals(input.vFCP)
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
                    this.vICMSDeson == input.vICMSDeson ||
                    this.vICMSDeson.Equals(input.vICMSDeson)
                ) && 
                (
                    this.motDesICMS == input.motDesICMS ||
                    this.motDesICMS.Equals(input.motDesICMS)
                ) && 
                (
                    this.vICMSSTDeson == input.vICMSSTDeson ||
                    this.vICMSSTDeson.Equals(input.vICMSSTDeson)
                ) && 
                (
                    this.motDesICMSST == input.motDesICMSST ||
                    this.motDesICMSST.Equals(input.motDesICMSST)
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.modBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCFCP.GetHashCode();
                hashCode = (hashCode * 59) + this.pFCP.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
                hashCode = (hashCode * 59) + this.modBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.pMVAST.GetHashCode();
                hashCode = (hashCode * 59) + this.pRedBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSST.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSST.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.pFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                hashCode = (hashCode * 59) + this.motDesICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSSTDeson.GetHashCode();
                hashCode = (hashCode * 59) + this.motDesICMSST.GetHashCode();
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
