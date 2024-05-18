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
    /// Tributção pelo ICMS 51 - Diferimento. A exigência do preenchimento das informações do ICMS diferido fica à critério de cada UF.
    /// </summary>
    [DataContract(Name = "NfeSefazICMS51")]
    public partial class NfeSefazICMS51 : IEquatable<NfeSefazICMS51>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS51" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS51() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS51" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 20 - Com redução de base de cálculo (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação.</param>
        /// <param name="pRedBC">Percentual de redução da BC..</param>
        /// <param name="cBenefRBC">Código de Benefício Fiscal na UF aplicado ao item quando houver RBC..</param>
        /// <param name="vBC">Valor da BC do ICMS..</param>
        /// <param name="pICMS">Alíquota do imposto..</param>
        /// <param name="vICMSOp">Valor do ICMS da Operação..</param>
        /// <param name="pDif">Percentual do diferemento..</param>
        /// <param name="vICMSDif">Valor do ICMS da diferido..</param>
        /// <param name="vICMS">Valor do ICMS..</param>
        /// <param name="vBCFCP">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCP">Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCP">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="pFCPDif">Percentual do diferimento do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCPDif">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) diferido..</param>
        /// <param name="vFCPEfet">Valor efetivo do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        public NfeSefazICMS51(int? orig = default(int?), string cST = default(string), int? modBC = default(int?), decimal? pRedBC = default(decimal?), string cBenefRBC = default(string), decimal? vBC = default(decimal?), decimal? pICMS = default(decimal?), decimal? vICMSOp = default(decimal?), decimal? pDif = default(decimal?), decimal? vICMSDif = default(decimal?), decimal? vICMS = default(decimal?), decimal? vBCFCP = default(decimal?), decimal? pFCP = default(decimal?), decimal? vFCP = default(decimal?), decimal? pFCPDif = default(decimal?), decimal? vFCPDif = default(decimal?), decimal? vFCPEfet = default(decimal?))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMS51 and cannot be null");
            }
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS51 and cannot be null");
            }
            this.CST = cST;
            this.modBC = modBC;
            this.pRedBC = pRedBC;
            this.cBenefRBC = cBenefRBC;
            this.vBC = vBC;
            this.pICMS = pICMS;
            this.vICMSOp = vICMSOp;
            this.pDif = pDif;
            this.vICMSDif = vICMSDif;
            this.vICMS = vICMS;
            this.vBCFCP = vBCFCP;
            this.pFCP = pFCP;
            this.vFCP = vFCP;
            this.pFCPDif = pFCPDif;
            this.vFCPDif = vFCPDif;
            this.vFCPEfet = vFCPEfet;
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
        [DataMember(Name = "modBC", EmitDefaultValue = true)]
        public int? modBC { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", EmitDefaultValue = true)]
        public decimal? pRedBC { get; set; }

        /// <summary>
        /// Código de Benefício Fiscal na UF aplicado ao item quando houver RBC.
        /// </summary>
        /// <value>Código de Benefício Fiscal na UF aplicado ao item quando houver RBC.</value>
        [DataMember(Name = "cBenefRBC", EmitDefaultValue = true)]
        public string cBenefRBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Alíquota do imposto.
        /// </summary>
        /// <value>Alíquota do imposto.</value>
        [DataMember(Name = "pICMS", EmitDefaultValue = true)]
        public decimal? pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS da Operação.
        /// </summary>
        /// <value>Valor do ICMS da Operação.</value>
        [DataMember(Name = "vICMSOp", EmitDefaultValue = true)]
        public decimal? vICMSOp { get; set; }

        /// <summary>
        /// Percentual do diferemento.
        /// </summary>
        /// <value>Percentual do diferemento.</value>
        [DataMember(Name = "pDif", EmitDefaultValue = true)]
        public decimal? pDif { get; set; }

        /// <summary>
        /// Valor do ICMS da diferido.
        /// </summary>
        /// <value>Valor do ICMS da diferido.</value>
        [DataMember(Name = "vICMSDif", EmitDefaultValue = true)]
        public decimal? vICMSDif { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", EmitDefaultValue = true)]
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
        /// Percentual do diferimento do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Percentual do diferimento do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "pFCPDif", EmitDefaultValue = true)]
        public decimal? pFCPDif { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) diferido.
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) diferido.</value>
        [DataMember(Name = "vFCPDif", EmitDefaultValue = true)]
        public decimal? vFCPDif { get; set; }

        /// <summary>
        /// Valor efetivo do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Valor efetivo do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "vFCPEfet", EmitDefaultValue = true)]
        public decimal? vFCPEfet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS51 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  modBC: ").Append(modBC).Append("\n");
            sb.Append("  pRedBC: ").Append(pRedBC).Append("\n");
            sb.Append("  cBenefRBC: ").Append(cBenefRBC).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMSOp: ").Append(vICMSOp).Append("\n");
            sb.Append("  pDif: ").Append(pDif).Append("\n");
            sb.Append("  vICMSDif: ").Append(vICMSDif).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vBCFCP: ").Append(vBCFCP).Append("\n");
            sb.Append("  pFCP: ").Append(pFCP).Append("\n");
            sb.Append("  vFCP: ").Append(vFCP).Append("\n");
            sb.Append("  pFCPDif: ").Append(pFCPDif).Append("\n");
            sb.Append("  vFCPDif: ").Append(vFCPDif).Append("\n");
            sb.Append("  vFCPEfet: ").Append(vFCPEfet).Append("\n");
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
            return this.Equals(input as NfeSefazICMS51);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS51 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS51 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS51 input)
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
                    this.cBenefRBC == input.cBenefRBC ||
                    (this.cBenefRBC != null &&
                    this.cBenefRBC.Equals(input.cBenefRBC))
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
                    this.vICMSOp == input.vICMSOp ||
                    (this.vICMSOp != null &&
                    this.vICMSOp.Equals(input.vICMSOp))
                ) && 
                (
                    this.pDif == input.pDif ||
                    (this.pDif != null &&
                    this.pDif.Equals(input.pDif))
                ) && 
                (
                    this.vICMSDif == input.vICMSDif ||
                    (this.vICMSDif != null &&
                    this.vICMSDif.Equals(input.vICMSDif))
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
                    this.pFCPDif == input.pFCPDif ||
                    (this.pFCPDif != null &&
                    this.pFCPDif.Equals(input.pFCPDif))
                ) && 
                (
                    this.vFCPDif == input.vFCPDif ||
                    (this.vFCPDif != null &&
                    this.vFCPDif.Equals(input.vFCPDif))
                ) && 
                (
                    this.vFCPEfet == input.vFCPEfet ||
                    (this.vFCPEfet != null &&
                    this.vFCPEfet.Equals(input.vFCPEfet))
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
                if (this.cBenefRBC != null)
                {
                    hashCode = (hashCode * 59) + this.cBenefRBC.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pICMS != null)
                {
                    hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                }
                if (this.vICMSOp != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSOp.GetHashCode();
                }
                if (this.pDif != null)
                {
                    hashCode = (hashCode * 59) + this.pDif.GetHashCode();
                }
                if (this.vICMSDif != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDif.GetHashCode();
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
                if (this.pFCPDif != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPDif.GetHashCode();
                }
                if (this.vFCPDif != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPDif.GetHashCode();
                }
                if (this.vFCPEfet != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPEfet.GetHashCode();
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
            // pRedBC (decimal?) minimum
            if (this.pRedBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedBC, must be a value greater than or equal to 0.", new [] { "pRedBC" });
            }

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

            // vICMSOp (decimal?) minimum
            if (this.vICMSOp < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSOp, must be a value greater than or equal to 0.", new [] { "vICMSOp" });
            }

            // pDif (decimal?) maximum
            if (this.pDif > (decimal?)1E+2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDif, must be a value less than or equal to 1E+2.", new [] { "pDif" });
            }

            // pDif (decimal?) minimum
            if (this.pDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDif, must be a value greater than or equal to 0.", new [] { "pDif" });
            }

            // vICMSDif (decimal?) minimum
            if (this.vICMSDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSDif, must be a value greater than or equal to 0.", new [] { "vICMSDif" });
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

            // pFCPDif (decimal?) minimum
            if (this.pFCPDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCPDif, must be a value greater than or equal to 0.", new [] { "pFCPDif" });
            }

            // vFCPDif (decimal?) minimum
            if (this.vFCPDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPDif, must be a value greater than or equal to 0.", new [] { "vFCPDif" });
            }

            // vFCPEfet (decimal?) minimum
            if (this.vFCPEfet < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPEfet, must be a value greater than or equal to 0.", new [] { "vFCPEfet" });
            }

            yield break;
        }
    }

}
