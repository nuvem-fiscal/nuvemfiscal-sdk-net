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
    /// Tributação monofásica própria sobre combustíveis.
    /// </summary>
    [DataContract(Name = "NfeSefazICMS02")]
    public partial class NfeSefazICMS02 : IEquatable<NfeSefazICMS02>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS02" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS02() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS02" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 02 - Tributação monofásica própria sobre combustíveis (required).</param>
        /// <param name="qBCMono">Quantidade tributada..</param>
        /// <param name="adRemICMS">Alíquota ad rem do imposto. (required).</param>
        /// <param name="vICMSMono">Valor do ICMS própri. (required).</param>
        public NfeSefazICMS02(int? orig = default(int?), string cST = default(string), decimal? qBCMono = default(decimal?), decimal? adRemICMS = default(decimal?), decimal? vICMSMono = default(decimal?))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMS02 and cannot be null");
            }
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS02 and cannot be null");
            }
            this.CST = cST;
            // to ensure "adRemICMS" is required (not null)
            if (adRemICMS == null)
            {
                throw new ArgumentNullException("adRemICMS is a required property for NfeSefazICMS02 and cannot be null");
            }
            this.adRemICMS = adRemICMS;
            // to ensure "vICMSMono" is required (not null)
            if (vICMSMono == null)
            {
                throw new ArgumentNullException("vICMSMono is a required property for NfeSefazICMS02 and cannot be null");
            }
            this.vICMSMono = vICMSMono;
            this.qBCMono = qBCMono;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int? orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  * 02 - Tributação monofásica própria sobre combustíveis
        /// </summary>
        /// <value>Tributção pelo ICMS  * 02 - Tributação monofásica própria sobre combustíveis</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Quantidade tributada.
        /// </summary>
        /// <value>Quantidade tributada.</value>
        [DataMember(Name = "qBCMono", EmitDefaultValue = true)]
        public decimal? qBCMono { get; set; }

        /// <summary>
        /// Alíquota ad rem do imposto.
        /// </summary>
        /// <value>Alíquota ad rem do imposto.</value>
        [DataMember(Name = "adRemICMS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemICMS { get; set; }

        /// <summary>
        /// Valor do ICMS própri.
        /// </summary>
        /// <value>Valor do ICMS própri.</value>
        [DataMember(Name = "vICMSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vICMSMono { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS02 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  qBCMono: ").Append(qBCMono).Append("\n");
            sb.Append("  adRemICMS: ").Append(adRemICMS).Append("\n");
            sb.Append("  vICMSMono: ").Append(vICMSMono).Append("\n");
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
            return this.Equals(input as NfeSefazICMS02);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS02 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS02 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS02 input)
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
                    this.qBCMono == input.qBCMono ||
                    (this.qBCMono != null &&
                    this.qBCMono.Equals(input.qBCMono))
                ) && 
                (
                    this.adRemICMS == input.adRemICMS ||
                    (this.adRemICMS != null &&
                    this.adRemICMS.Equals(input.adRemICMS))
                ) && 
                (
                    this.vICMSMono == input.vICMSMono ||
                    (this.vICMSMono != null &&
                    this.vICMSMono.Equals(input.vICMSMono))
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
                if (this.qBCMono != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMono.GetHashCode();
                }
                if (this.adRemICMS != null)
                {
                    hashCode = (hashCode * 59) + this.adRemICMS.GetHashCode();
                }
                if (this.vICMSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSMono.GetHashCode();
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
            // qBCMono (decimal?) minimum
            if (this.qBCMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qBCMono, must be a value greater than or equal to 0.", new [] { "qBCMono" });
            }

            // adRemICMS (decimal?) minimum
            if (this.adRemICMS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for adRemICMS, must be a value greater than or equal to 0.", new [] { "adRemICMS" });
            }

            // vICMSMono (decimal?) minimum
            if (this.vICMSMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSMono, must be a value greater than or equal to 0.", new [] { "vICMSMono" });
            }

            yield break;
        }
    }

}
