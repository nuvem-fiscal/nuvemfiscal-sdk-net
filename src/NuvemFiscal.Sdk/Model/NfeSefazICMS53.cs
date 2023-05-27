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
    /// Tributação monofásica sobre combustíveis com recolhimento diferido.
    /// </summary>
    [DataContract(Name = "NfeSefazICMS53")]
    public partial class NfeSefazICMS53 : IEquatable<NfeSefazICMS53>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS53" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS53() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS53" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 53 - Tributação monofásica sobre combustíveis com recolhimento diferido (required).</param>
        /// <param name="qBCMono">Quantidade tributada..</param>
        /// <param name="adRemICMS">Alíquota ad rem do imposto..</param>
        /// <param name="vICMSMonoOp">Valor do ICMS da operação..</param>
        /// <param name="pDif">Percentual do diferemento..</param>
        /// <param name="vICMSMonoDif">Valor do ICMS diferido..</param>
        /// <param name="vICMSMono">Valor do ICMS próprio devido..</param>
        /// <param name="qBCMonoDif">Quantidade tributada diferida.  OBS: Campo revogado pela NT2023.001v1.20.</param>
        /// <param name="adRemICMSDif">Alíquota ad rem do imposto diferido.  OBS: Campo revogado pela NT2023.001v1.20.</param>
        public NfeSefazICMS53(int orig = default(int), string cST = default(string), decimal qBCMono = default(decimal), decimal adRemICMS = default(decimal), decimal vICMSMonoOp = default(decimal), decimal pDif = default(decimal), decimal vICMSMonoDif = default(decimal), decimal vICMSMono = default(decimal), decimal qBCMonoDif = default(decimal), decimal adRemICMSDif = default(decimal))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS53 and cannot be null");
            }
            this.CST = cST;
            this.qBCMono = qBCMono;
            this.adRemICMS = adRemICMS;
            this.vICMSMonoOp = vICMSMonoOp;
            this.pDif = pDif;
            this.vICMSMonoDif = vICMSMonoDif;
            this.vICMSMono = vICMSMono;
            this.qBCMonoDif = qBCMonoDif;
            this.adRemICMSDif = adRemICMSDif;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  * 53 - Tributação monofásica sobre combustíveis com recolhimento diferido
        /// </summary>
        /// <value>Tributção pelo ICMS  * 53 - Tributação monofásica sobre combustíveis com recolhimento diferido</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Quantidade tributada.
        /// </summary>
        /// <value>Quantidade tributada.</value>
        [DataMember(Name = "qBCMono", EmitDefaultValue = false)]
        public decimal qBCMono { get; set; }

        /// <summary>
        /// Alíquota ad rem do imposto.
        /// </summary>
        /// <value>Alíquota ad rem do imposto.</value>
        [DataMember(Name = "adRemICMS", EmitDefaultValue = false)]
        public decimal adRemICMS { get; set; }

        /// <summary>
        /// Valor do ICMS da operação.
        /// </summary>
        /// <value>Valor do ICMS da operação.</value>
        [DataMember(Name = "vICMSMonoOp", EmitDefaultValue = false)]
        public decimal vICMSMonoOp { get; set; }

        /// <summary>
        /// Percentual do diferemento.
        /// </summary>
        /// <value>Percentual do diferemento.</value>
        [DataMember(Name = "pDif", EmitDefaultValue = false)]
        public decimal pDif { get; set; }

        /// <summary>
        /// Valor do ICMS diferido.
        /// </summary>
        /// <value>Valor do ICMS diferido.</value>
        [DataMember(Name = "vICMSMonoDif", EmitDefaultValue = false)]
        public decimal vICMSMonoDif { get; set; }

        /// <summary>
        /// Valor do ICMS próprio devido.
        /// </summary>
        /// <value>Valor do ICMS próprio devido.</value>
        [DataMember(Name = "vICMSMono", EmitDefaultValue = false)]
        public decimal vICMSMono { get; set; }

        /// <summary>
        /// Quantidade tributada diferida.  OBS: Campo revogado pela NT2023.001v1.20
        /// </summary>
        /// <value>Quantidade tributada diferida.  OBS: Campo revogado pela NT2023.001v1.20</value>
        [DataMember(Name = "qBCMonoDif", EmitDefaultValue = false)]
        public decimal qBCMonoDif { get; set; }

        /// <summary>
        /// Alíquota ad rem do imposto diferido.  OBS: Campo revogado pela NT2023.001v1.20
        /// </summary>
        /// <value>Alíquota ad rem do imposto diferido.  OBS: Campo revogado pela NT2023.001v1.20</value>
        [DataMember(Name = "adRemICMSDif", EmitDefaultValue = false)]
        public decimal adRemICMSDif { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS53 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  qBCMono: ").Append(qBCMono).Append("\n");
            sb.Append("  adRemICMS: ").Append(adRemICMS).Append("\n");
            sb.Append("  vICMSMonoOp: ").Append(vICMSMonoOp).Append("\n");
            sb.Append("  pDif: ").Append(pDif).Append("\n");
            sb.Append("  vICMSMonoDif: ").Append(vICMSMonoDif).Append("\n");
            sb.Append("  vICMSMono: ").Append(vICMSMono).Append("\n");
            sb.Append("  qBCMonoDif: ").Append(qBCMonoDif).Append("\n");
            sb.Append("  adRemICMSDif: ").Append(adRemICMSDif).Append("\n");
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
            return this.Equals(input as NfeSefazICMS53);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS53 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS53 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS53 input)
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
                    this.qBCMono == input.qBCMono ||
                    this.qBCMono.Equals(input.qBCMono)
                ) && 
                (
                    this.adRemICMS == input.adRemICMS ||
                    this.adRemICMS.Equals(input.adRemICMS)
                ) && 
                (
                    this.vICMSMonoOp == input.vICMSMonoOp ||
                    this.vICMSMonoOp.Equals(input.vICMSMonoOp)
                ) && 
                (
                    this.pDif == input.pDif ||
                    this.pDif.Equals(input.pDif)
                ) && 
                (
                    this.vICMSMonoDif == input.vICMSMonoDif ||
                    this.vICMSMonoDif.Equals(input.vICMSMonoDif)
                ) && 
                (
                    this.vICMSMono == input.vICMSMono ||
                    this.vICMSMono.Equals(input.vICMSMono)
                ) && 
                (
                    this.qBCMonoDif == input.qBCMonoDif ||
                    this.qBCMonoDif.Equals(input.qBCMonoDif)
                ) && 
                (
                    this.adRemICMSDif == input.adRemICMSDif ||
                    this.adRemICMSDif.Equals(input.adRemICMSDif)
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
                hashCode = (hashCode * 59) + this.qBCMono.GetHashCode();
                hashCode = (hashCode * 59) + this.adRemICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSMonoOp.GetHashCode();
                hashCode = (hashCode * 59) + this.pDif.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSMonoDif.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSMono.GetHashCode();
                hashCode = (hashCode * 59) + this.qBCMonoDif.GetHashCode();
                hashCode = (hashCode * 59) + this.adRemICMSDif.GetHashCode();
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
