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
    /// Tributação pelo ICMS  * 40 - Isenta  * 41 - Não tributada  * 50 - Suspensão
    /// </summary>
    [DataContract(Name = "NfeSefazICMS40")]
    public partial class NfeSefazICMS40 : IEquatable<NfeSefazICMS40>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS40" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS40() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS40" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributação pelo ICMS  * 40 - Isenta  * 41 - Não tributada  * 50 - Suspensão  * 51 - Diferimento (required).</param>
        /// <param name="vICMSDeson">O valor do ICMS será informado apenas nas operações com veículos beneficiados com a desoneração condicional do ICMS..</param>
        /// <param name="motDesICMS">Este campo será preenchido quando o campo anterior estiver preenchido.  Informar o motivo da desoneração:  * 1 - Táxi  * 3 - Produtor Agropecuário  * 4 - Frotista/Locadora  * 5 - Diplomático/Consular  * 6 - Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 - CONTRAN e suas alterações)  * 7 - SUFRAMA  * 8 - Venda a órgão Público  * 9 - Outros  * 10 - Deficiente Condutor  * 11 - Deficiente não condutor  * 16 - Olimpíadas Rio 2016  * 90 - Solicitado pelo Fisco.</param>
        public NfeSefazICMS40(int orig = default(int), string cST = default(string), decimal vICMSDeson = default(decimal), int motDesICMS = default(int))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS40 and cannot be null");
            }
            this.CST = cST;
            this.vICMSDeson = vICMSDeson;
            this.motDesICMS = motDesICMS;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributação pelo ICMS  * 40 - Isenta  * 41 - Não tributada  * 50 - Suspensão  * 51 - Diferimento
        /// </summary>
        /// <value>Tributação pelo ICMS  * 40 - Isenta  * 41 - Não tributada  * 50 - Suspensão  * 51 - Diferimento</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// O valor do ICMS será informado apenas nas operações com veículos beneficiados com a desoneração condicional do ICMS.
        /// </summary>
        /// <value>O valor do ICMS será informado apenas nas operações com veículos beneficiados com a desoneração condicional do ICMS.</value>
        [DataMember(Name = "vICMSDeson", EmitDefaultValue = false)]
        public decimal vICMSDeson { get; set; }

        /// <summary>
        /// Este campo será preenchido quando o campo anterior estiver preenchido.  Informar o motivo da desoneração:  * 1 - Táxi  * 3 - Produtor Agropecuário  * 4 - Frotista/Locadora  * 5 - Diplomático/Consular  * 6 - Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 - CONTRAN e suas alterações)  * 7 - SUFRAMA  * 8 - Venda a órgão Público  * 9 - Outros  * 10 - Deficiente Condutor  * 11 - Deficiente não condutor  * 16 - Olimpíadas Rio 2016  * 90 - Solicitado pelo Fisco
        /// </summary>
        /// <value>Este campo será preenchido quando o campo anterior estiver preenchido.  Informar o motivo da desoneração:  * 1 - Táxi  * 3 - Produtor Agropecuário  * 4 - Frotista/Locadora  * 5 - Diplomático/Consular  * 6 - Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 - CONTRAN e suas alterações)  * 7 - SUFRAMA  * 8 - Venda a órgão Público  * 9 - Outros  * 10 - Deficiente Condutor  * 11 - Deficiente não condutor  * 16 - Olimpíadas Rio 2016  * 90 - Solicitado pelo Fisco</value>
        [DataMember(Name = "motDesICMS", EmitDefaultValue = false)]
        public int motDesICMS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS40 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
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
            return this.Equals(input as NfeSefazICMS40);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS40 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS40 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS40 input)
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
                    this.vICMSDeson == input.vICMSDeson ||
                    this.vICMSDeson.Equals(input.vICMSDeson)
                ) && 
                (
                    this.motDesICMS == input.motDesICMS ||
                    this.motDesICMS.Equals(input.motDesICMS)
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
                hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                hashCode = (hashCode * 59) + this.motDesICMS.GetHashCode();
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
