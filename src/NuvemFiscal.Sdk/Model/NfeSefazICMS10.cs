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
    /// Tributação pelo ICMS  * 10 - Tributada e com cobrança do ICMS por substituição tributária
    /// </summary>
    [DataContract(Name = "NfeSefazICMS10")]
    public partial class NfeSefazICMS10 : IEquatable<NfeSefazICMS10>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS10" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS10() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS10" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">* 10 - Tributada e com cobrança do ICMS por substituição tributária (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação (required).</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="vBCFCP">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCP">Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCP">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação (required).</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST. (required).</param>
        /// <param name="pICMSST">Alíquota do ICMS ST. (required).</param>
        /// <param name="vICMSST">Valor do ICMS ST. (required).</param>
        /// <param name="vBCFCPST">Valor da Base de cálculo do FCP retido por substituicao tributaria..</param>
        /// <param name="pFCPST">Percentual de FCP retido por substituição tributária..</param>
        /// <param name="vFCPST">Valor do FCP retido por substituição tributária..</param>
        /// <param name="vICMSSTDeson">Valor do ICMS-ST desonerado..</param>
        /// <param name="motDesICMSST">Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário.</param>
        public NfeSefazICMS10(int? orig = default(int?), string cST = default(string), int? modBC = default(int?), decimal? vBC = default(decimal?), decimal? pICMS = default(decimal?), decimal? vICMS = default(decimal?), decimal? vBCFCP = default(decimal?), decimal? pFCP = default(decimal?), decimal? vFCP = default(decimal?), int? modBCST = default(int?), decimal? pMVAST = default(decimal?), decimal? pRedBCST = default(decimal?), decimal? vBCST = default(decimal?), decimal? pICMSST = default(decimal?), decimal? vICMSST = default(decimal?), decimal? vBCFCPST = default(decimal?), decimal? pFCPST = default(decimal?), decimal? vFCPST = default(decimal?), decimal? vICMSSTDeson = default(decimal?), int? motDesICMSST = default(int?))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.CST = cST;
            // to ensure "modBC" is required (not null)
            if (modBC == null)
            {
                throw new ArgumentNullException("modBC is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.modBC = modBC;
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pICMS" is required (not null)
            if (pICMS == null)
            {
                throw new ArgumentNullException("pICMS is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.pICMS = pICMS;
            // to ensure "vICMS" is required (not null)
            if (vICMS == null)
            {
                throw new ArgumentNullException("vICMS is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.vICMS = vICMS;
            // to ensure "modBCST" is required (not null)
            if (modBCST == null)
            {
                throw new ArgumentNullException("modBCST is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.modBCST = modBCST;
            // to ensure "vBCST" is required (not null)
            if (vBCST == null)
            {
                throw new ArgumentNullException("vBCST is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.vBCST = vBCST;
            // to ensure "pICMSST" is required (not null)
            if (pICMSST == null)
            {
                throw new ArgumentNullException("pICMSST is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.pICMSST = pICMSST;
            // to ensure "vICMSST" is required (not null)
            if (vICMSST == null)
            {
                throw new ArgumentNullException("vICMSST is a required property for NfeSefazICMS10 and cannot be null");
            }
            this.vICMSST = vICMSST;
            this.vBCFCP = vBCFCP;
            this.pFCP = pFCP;
            this.vFCP = vFCP;
            this.pMVAST = pMVAST;
            this.pRedBCST = pRedBCST;
            this.vBCFCPST = vBCFCPST;
            this.pFCPST = pFCPST;
            this.vFCPST = vFCPST;
            this.vICMSSTDeson = vICMSSTDeson;
            this.motDesICMSST = motDesICMSST;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int? orig { get; set; }

        /// <summary>
        /// * 10 - Tributada e com cobrança do ICMS por substituição tributária
        /// </summary>
        /// <value>* 10 - Tributada e com cobrança do ICMS por substituição tributária</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação</value>
        [DataMember(Name = "modBC", IsRequired = true, EmitDefaultValue = true)]
        public int? modBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMS { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP.</value>
        [DataMember(Name = "vBCFCP", EmitDefaultValue = true)]
        public decimal? vBCFCP { get; set; }

        /// <summary>
        /// Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "pFCP", EmitDefaultValue = true)]
        public decimal? pFCP { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "vFCP", EmitDefaultValue = true)]
        public decimal? vFCP { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação</value>
        [DataMember(Name = "modBCST", IsRequired = true, EmitDefaultValue = true)]
        public int? modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST.
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST.</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = true)]
        public decimal? pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST.
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST.</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = true)]
        public decimal? pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST.
        /// </summary>
        /// <value>Valor da BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST.
        /// </summary>
        /// <value>Alíquota do ICMS ST.</value>
        [DataMember(Name = "pICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST.
        /// </summary>
        /// <value>Valor do ICMS ST.</value>
        [DataMember(Name = "vICMSST", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSST { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP retido por substituicao tributaria.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP retido por substituicao tributaria.</value>
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
        /// Valor do ICMS-ST desonerado.
        /// </summary>
        /// <value>Valor do ICMS-ST desonerado.</value>
        [DataMember(Name = "vICMSSTDeson", EmitDefaultValue = true)]
        public decimal? vICMSSTDeson { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário
        /// </summary>
        /// <value>Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário</value>
        [DataMember(Name = "motDesICMSST", EmitDefaultValue = true)]
        public int? motDesICMSST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS10 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  modBC: ").Append(modBC).Append("\n");
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
            return this.Equals(input as NfeSefazICMS10);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS10 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS10 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS10 input)
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
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.modBC == input.modBC ||
                    (this.modBC != null &&
                    this.modBC.Equals(input.modBC))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    (this.pICMS != null &&
                    this.pICMS.Equals(input.pICMS))
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    (this.vICMS != null &&
                    this.vICMS.Equals(input.vICMS))
                ) && 
                (
                    this.vBCFCP == input.vBCFCP ||
                    (this.vBCFCP != null &&
                    this.vBCFCP.Equals(input.vBCFCP))
                ) && 
                (
                    this.pFCP == input.pFCP ||
                    (this.pFCP != null &&
                    this.pFCP.Equals(input.pFCP))
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    (this.vFCP != null &&
                    this.vFCP.Equals(input.vFCP))
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
                ) && 
                (
                    this.vICMSSTDeson == input.vICMSSTDeson ||
                    (this.vICMSSTDeson != null &&
                    this.vICMSSTDeson.Equals(input.vICMSSTDeson))
                ) && 
                (
                    this.motDesICMSST == input.motDesICMSST ||
                    (this.motDesICMSST != null &&
                    this.motDesICMSST.Equals(input.motDesICMSST))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.modBC != null)
                {
                    hashCode = (hashCode * 59) + this.modBC.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pICMS != null)
                {
                    hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                }
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                }
                if (this.vBCFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vBCFCP.GetHashCode();
                }
                if (this.pFCP != null)
                {
                    hashCode = (hashCode * 59) + this.pFCP.GetHashCode();
                }
                if (this.vFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
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
                if (this.vICMSSTDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSSTDeson.GetHashCode();
                }
                if (this.motDesICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.motDesICMSST.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // pICMS (decimal?) minimum
            if (this.pICMS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pICMS, must be a value greater than or equal to 0.", new [] { "pICMS" });
            }

            // vICMS (decimal?) minimum
            if (this.vICMS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMS, must be a value greater than or equal to 0.", new [] { "vICMS" });
            }

            // vBCFCP (decimal?) minimum
            if (this.vBCFCP < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCFCP, must be a value greater than or equal to 0.", new [] { "vBCFCP" });
            }

            // pFCP (decimal?) minimum
            if (this.pFCP < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCP, must be a value greater than or equal to 0.", new [] { "pFCP" });
            }

            // vFCP (decimal?) minimum
            if (this.vFCP < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCP, must be a value greater than or equal to 0.", new [] { "vFCP" });
            }

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

            // vICMSSTDeson (decimal?) minimum
            if (this.vICMSSTDeson < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSSTDeson, must be a value greater than or equal to 0.", new [] { "vICMSSTDeson" });
            }

            yield break;
        }
    }

}
