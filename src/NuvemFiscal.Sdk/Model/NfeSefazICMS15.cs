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
    /// Tributação monofásica própria e com responsabilidade pela retenção sobre combustíveis.
    /// </summary>
    [DataContract(Name = "NfeSefazICMS15")]
    public partial class NfeSefazICMS15 : IEquatable<NfeSefazICMS15>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS15" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS15() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS15" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 15 - Tributação monofásica própria e com responsabilidade pela retenção sobre combustíveis (required).</param>
        /// <param name="adRemICMS">Alíquota ad rem do imposto. (required).</param>
        /// <param name="vICMSMono">Valor do ICMS próprio. (required).</param>
        /// <param name="adRemICMSReten">Alíquota ad rem do imposto com retenção. (required).</param>
        /// <param name="vICMSMonoReten">Valor do ICMS com retenção. (required).</param>
        public NfeSefazICMS15(int orig = default(int), string cST = default(string), decimal adRemICMS = default(decimal), decimal vICMSMono = default(decimal), decimal adRemICMSReten = default(decimal), decimal vICMSMonoReten = default(decimal))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS15 and cannot be null");
            }
            this.CST = cST;
            this.adRemICMS = adRemICMS;
            this.vICMSMono = vICMSMono;
            this.adRemICMSReten = adRemICMSReten;
            this.vICMSMonoReten = vICMSMonoReten;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  * 15 - Tributação monofásica própria e com responsabilidade pela retenção sobre combustíveis
        /// </summary>
        /// <value>Tributção pelo ICMS  * 15 - Tributação monofásica própria e com responsabilidade pela retenção sobre combustíveis</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Alíquota ad rem do imposto.
        /// </summary>
        /// <value>Alíquota ad rem do imposto.</value>
        [DataMember(Name = "adRemICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal adRemICMS { get; set; }

        /// <summary>
        /// Valor do ICMS próprio.
        /// </summary>
        /// <value>Valor do ICMS próprio.</value>
        [DataMember(Name = "vICMSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSMono { get; set; }

        /// <summary>
        /// Alíquota ad rem do imposto com retenção.
        /// </summary>
        /// <value>Alíquota ad rem do imposto com retenção.</value>
        [DataMember(Name = "adRemICMSReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal adRemICMSReten { get; set; }

        /// <summary>
        /// Valor do ICMS com retenção.
        /// </summary>
        /// <value>Valor do ICMS com retenção.</value>
        [DataMember(Name = "vICMSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSMonoReten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS15 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  adRemICMS: ").Append(adRemICMS).Append("\n");
            sb.Append("  vICMSMono: ").Append(vICMSMono).Append("\n");
            sb.Append("  adRemICMSReten: ").Append(adRemICMSReten).Append("\n");
            sb.Append("  vICMSMonoReten: ").Append(vICMSMonoReten).Append("\n");
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
            return this.Equals(input as NfeSefazICMS15);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS15 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS15 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS15 input)
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
                    this.adRemICMS == input.adRemICMS ||
                    this.adRemICMS.Equals(input.adRemICMS)
                ) && 
                (
                    this.vICMSMono == input.vICMSMono ||
                    this.vICMSMono.Equals(input.vICMSMono)
                ) && 
                (
                    this.adRemICMSReten == input.adRemICMSReten ||
                    this.adRemICMSReten.Equals(input.adRemICMSReten)
                ) && 
                (
                    this.vICMSMonoReten == input.vICMSMonoReten ||
                    this.vICMSMonoReten.Equals(input.vICMSMonoReten)
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
                hashCode = (hashCode * 59) + this.adRemICMS.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSMono.GetHashCode();
                hashCode = (hashCode * 59) + this.adRemICMSReten.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSMonoReten.GetHashCode();
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
