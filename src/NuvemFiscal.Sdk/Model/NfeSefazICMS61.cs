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
    /// Tributação monofásica sobre combustíveis cobrada anteriormente.
    /// </summary>
    [DataContract(Name = "NfeSefazICMS61")]
    public partial class NfeSefazICMS61 : IEquatable<NfeSefazICMS61>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS61" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS61() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS61" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 61 - Tributação monofásica sobre combustíveis cobrada anteriormente (required).</param>
        /// <param name="qBCMonoRet">Quantidade tributada retida anteriormente..</param>
        /// <param name="adRemICMSRet">Alíquota ad rem do imposto retido anteriormente. (required).</param>
        /// <param name="vICMSMonoRet">Valor do ICMS retido anteriormente. (required).</param>
        public NfeSefazICMS61(int orig = default(int), string cST = default(string), decimal qBCMonoRet = default(decimal), decimal adRemICMSRet = default(decimal), decimal vICMSMonoRet = default(decimal))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS61 and cannot be null");
            }
            this.CST = cST;
            this.adRemICMSRet = adRemICMSRet;
            this.vICMSMonoRet = vICMSMonoRet;
            this.qBCMonoRet = qBCMonoRet;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  * 61 - Tributação monofásica sobre combustíveis cobrada anteriormente
        /// </summary>
        /// <value>Tributção pelo ICMS  * 61 - Tributação monofásica sobre combustíveis cobrada anteriormente</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Quantidade tributada retida anteriormente.
        /// </summary>
        /// <value>Quantidade tributada retida anteriormente.</value>
        [DataMember(Name = "qBCMonoRet", EmitDefaultValue = false)]
        public decimal qBCMonoRet { get; set; }

        /// <summary>
        /// Alíquota ad rem do imposto retido anteriormente.
        /// </summary>
        /// <value>Alíquota ad rem do imposto retido anteriormente.</value>
        [DataMember(Name = "adRemICMSRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal adRemICMSRet { get; set; }

        /// <summary>
        /// Valor do ICMS retido anteriormente.
        /// </summary>
        /// <value>Valor do ICMS retido anteriormente.</value>
        [DataMember(Name = "vICMSMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal vICMSMonoRet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS61 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  qBCMonoRet: ").Append(qBCMonoRet).Append("\n");
            sb.Append("  adRemICMSRet: ").Append(adRemICMSRet).Append("\n");
            sb.Append("  vICMSMonoRet: ").Append(vICMSMonoRet).Append("\n");
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
            return this.Equals(input as NfeSefazICMS61);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS61 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS61 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS61 input)
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
                    this.qBCMonoRet == input.qBCMonoRet ||
                    this.qBCMonoRet.Equals(input.qBCMonoRet)
                ) && 
                (
                    this.adRemICMSRet == input.adRemICMSRet ||
                    this.adRemICMSRet.Equals(input.adRemICMSRet)
                ) && 
                (
                    this.vICMSMonoRet == input.vICMSMonoRet ||
                    this.vICMSMonoRet.Equals(input.vICMSMonoRet)
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
                hashCode = (hashCode * 59) + this.qBCMonoRet.GetHashCode();
                hashCode = (hashCode * 59) + this.adRemICMSRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSMonoRet.GetHashCode();
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
