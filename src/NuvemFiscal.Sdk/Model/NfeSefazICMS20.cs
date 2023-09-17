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
    /// Tributção pelo ICMS  * 20 - Com redução de base de cálculo
    /// </summary>
    [DataContract(Name = "NfeSefazICMS20")]
    public partial class NfeSefazICMS20 : IEquatable<NfeSefazICMS20>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS20" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS20() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS20" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 20 - Com redução de base de cálculo (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação (required).</param>
        /// <param name="pRedBC">Percentual de redução da BC. (required).</param>
        /// <param name="vBC">Valor da BC do ICMS. (required).</param>
        /// <param name="pICMS">Alíquota do ICMS. (required).</param>
        /// <param name="vICMS">Valor do ICMS. (required).</param>
        /// <param name="vBCFCP">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCP">Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCP">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vICMSDeson">Valor do ICMS de desoneração..</param>
        /// <param name="motDesICMS">Motivo da desoneração do ICMS:3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário.</param>
        public NfeSefazICMS20(int? orig = default(int?), string cST = default(string), int? modBC = default(int?), decimal? pRedBC = default(decimal?), decimal? vBC = default(decimal?), decimal? pICMS = default(decimal?), decimal? vICMS = default(decimal?), decimal? vBCFCP = default(decimal?), decimal? pFCP = default(decimal?), decimal? vFCP = default(decimal?), decimal? vICMSDeson = default(decimal?), int? motDesICMS = default(int?))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.CST = cST;
            // to ensure "modBC" is required (not null)
            if (modBC == null)
            {
                throw new ArgumentNullException("modBC is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.modBC = modBC;
            // to ensure "pRedBC" is required (not null)
            if (pRedBC == null)
            {
                throw new ArgumentNullException("pRedBC is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.pRedBC = pRedBC;
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "pICMS" is required (not null)
            if (pICMS == null)
            {
                throw new ArgumentNullException("pICMS is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.pICMS = pICMS;
            // to ensure "vICMS" is required (not null)
            if (vICMS == null)
            {
                throw new ArgumentNullException("vICMS is a required property for NfeSefazICMS20 and cannot be null");
            }
            this.vICMS = vICMS;
            this.vBCFCP = vBCFCP;
            this.pFCP = pFCP;
            this.vFCP = vFCP;
            this.vICMSDeson = vICMSDeson;
            this.motDesICMS = motDesICMS;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int? orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  * 20 - Com redução de base de cálculo
        /// </summary>
        /// <value>Tributção pelo ICMS  * 20 - Com redução de base de cálculo</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação</value>
        [DataMember(Name = "modBC", IsRequired = true, EmitDefaultValue = true)]
        public int? modBC { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pRedBC { get; set; }

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
        /// Valor do ICMS de desoneração.
        /// </summary>
        /// <value>Valor do ICMS de desoneração.</value>
        [DataMember(Name = "vICMSDeson", EmitDefaultValue = true)]
        public decimal? vICMSDeson { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS:3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário
        /// </summary>
        /// <value>Motivo da desoneração do ICMS:3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário</value>
        [DataMember(Name = "motDesICMS", EmitDefaultValue = true)]
        public int? motDesICMS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS20 {\n");
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
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  motDesICMS: ").Append(motDesICMS).Append("\n");
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
            return this.Equals(input as NfeSefazICMS20);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS20 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS20 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS20 input)
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
                    this.pRedBC == input.pRedBC ||
                    (this.pRedBC != null &&
                    this.pRedBC.Equals(input.pRedBC))
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
                    this.vICMSDeson == input.vICMSDeson ||
                    (this.vICMSDeson != null &&
                    this.vICMSDeson.Equals(input.vICMSDeson))
                ) && 
                (
                    this.motDesICMS == input.motDesICMS ||
                    (this.motDesICMS != null &&
                    this.motDesICMS.Equals(input.motDesICMS))
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
                if (this.pRedBC != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
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
                if (this.vICMSDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                }
                if (this.motDesICMS != null)
                {
                    hashCode = (hashCode * 59) + this.motDesICMS.GetHashCode();
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
