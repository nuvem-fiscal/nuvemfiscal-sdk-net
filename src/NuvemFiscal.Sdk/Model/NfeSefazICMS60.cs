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
    /// Tributação pelo ICMS  * 60 - ICMS cobrado anteriormente por substituição tributária
    /// </summary>
    [DataContract(Name = "NfeSefazICMS60")]
    public partial class NfeSefazICMS60 : IEquatable<NfeSefazICMS60>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS60" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS60() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS60" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributação pelo ICMS  * 60 - ICMS cobrado anteriormente por substituição tributária (required).</param>
        /// <param name="vBCSTRet">Valor da BC do ICMS ST retido anteriormente..</param>
        /// <param name="pST">Aliquota suportada pelo consumidor final..</param>
        /// <param name="vICMSSubstituto">Valor do ICMS Próprio do Substituto cobrado em operação anterior..</param>
        /// <param name="vICMSSTRet">Valor do ICMS ST retido anteriormente..</param>
        /// <param name="vBCFCPSTRet">Valor da Base de cálculo do FCP retido anteriormente por ST..</param>
        /// <param name="pFCPSTRet">Percentual de FCP retido anteriormente por substituição tributária..</param>
        /// <param name="vFCPSTRet">Valor do FCP retido por substituição tributária..</param>
        /// <param name="pRedBCEfet">Percentual de redução da base de cálculo efetiva..</param>
        /// <param name="vBCEfet">Valor da base de cálculo efetiva..</param>
        /// <param name="pICMSEfet">Alíquota do ICMS efetiva..</param>
        /// <param name="vICMSEfet">Valor do ICMS efetivo..</param>
        public NfeSefazICMS60(int orig = default(int), string cST = default(string), decimal vBCSTRet = default(decimal), decimal pST = default(decimal), decimal vICMSSubstituto = default(decimal), decimal vICMSSTRet = default(decimal), decimal vBCFCPSTRet = default(decimal), decimal pFCPSTRet = default(decimal), decimal vFCPSTRet = default(decimal), decimal pRedBCEfet = default(decimal), decimal vBCEfet = default(decimal), decimal pICMSEfet = default(decimal), decimal vICMSEfet = default(decimal))
        {
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS60 and cannot be null");
            }
            this.CST = cST;
            this.vBCSTRet = vBCSTRet;
            this.pST = pST;
            this.vICMSSubstituto = vICMSSubstituto;
            this.vICMSSTRet = vICMSSTRet;
            this.vBCFCPSTRet = vBCFCPSTRet;
            this.pFCPSTRet = pFCPSTRet;
            this.vFCPSTRet = vFCPSTRet;
            this.pRedBCEfet = pRedBCEfet;
            this.vBCEfet = vBCEfet;
            this.pICMSEfet = pICMSEfet;
            this.vICMSEfet = vICMSEfet;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// Tributação pelo ICMS  * 60 - ICMS cobrado anteriormente por substituição tributária
        /// </summary>
        /// <value>Tributação pelo ICMS  * 60 - ICMS cobrado anteriormente por substituição tributária</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST retido anteriormente.
        /// </summary>
        /// <value>Valor da BC do ICMS ST retido anteriormente.</value>
        [DataMember(Name = "vBCSTRet", EmitDefaultValue = false)]
        public decimal vBCSTRet { get; set; }

        /// <summary>
        /// Aliquota suportada pelo consumidor final.
        /// </summary>
        /// <value>Aliquota suportada pelo consumidor final.</value>
        [DataMember(Name = "pST", EmitDefaultValue = false)]
        public decimal pST { get; set; }

        /// <summary>
        /// Valor do ICMS Próprio do Substituto cobrado em operação anterior.
        /// </summary>
        /// <value>Valor do ICMS Próprio do Substituto cobrado em operação anterior.</value>
        [DataMember(Name = "vICMSSubstituto", EmitDefaultValue = false)]
        public decimal vICMSSubstituto { get; set; }

        /// <summary>
        /// Valor do ICMS ST retido anteriormente.
        /// </summary>
        /// <value>Valor do ICMS ST retido anteriormente.</value>
        [DataMember(Name = "vICMSSTRet", EmitDefaultValue = false)]
        public decimal vICMSSTRet { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP retido anteriormente por ST.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP retido anteriormente por ST.</value>
        [DataMember(Name = "vBCFCPSTRet", EmitDefaultValue = false)]
        public decimal vBCFCPSTRet { get; set; }

        /// <summary>
        /// Percentual de FCP retido anteriormente por substituição tributária.
        /// </summary>
        /// <value>Percentual de FCP retido anteriormente por substituição tributária.</value>
        [DataMember(Name = "pFCPSTRet", EmitDefaultValue = false)]
        public decimal pFCPSTRet { get; set; }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        /// <value>Valor do FCP retido por substituição tributária.</value>
        [DataMember(Name = "vFCPSTRet", EmitDefaultValue = false)]
        public decimal vFCPSTRet { get; set; }

        /// <summary>
        /// Percentual de redução da base de cálculo efetiva.
        /// </summary>
        /// <value>Percentual de redução da base de cálculo efetiva.</value>
        [DataMember(Name = "pRedBCEfet", EmitDefaultValue = false)]
        public decimal pRedBCEfet { get; set; }

        /// <summary>
        /// Valor da base de cálculo efetiva.
        /// </summary>
        /// <value>Valor da base de cálculo efetiva.</value>
        [DataMember(Name = "vBCEfet", EmitDefaultValue = false)]
        public decimal vBCEfet { get; set; }

        /// <summary>
        /// Alíquota do ICMS efetiva.
        /// </summary>
        /// <value>Alíquota do ICMS efetiva.</value>
        [DataMember(Name = "pICMSEfet", EmitDefaultValue = false)]
        public decimal pICMSEfet { get; set; }

        /// <summary>
        /// Valor do ICMS efetivo.
        /// </summary>
        /// <value>Valor do ICMS efetivo.</value>
        [DataMember(Name = "vICMSEfet", EmitDefaultValue = false)]
        public decimal vICMSEfet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS60 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  vBCSTRet: ").Append(vBCSTRet).Append("\n");
            sb.Append("  pST: ").Append(pST).Append("\n");
            sb.Append("  vICMSSubstituto: ").Append(vICMSSubstituto).Append("\n");
            sb.Append("  vICMSSTRet: ").Append(vICMSSTRet).Append("\n");
            sb.Append("  vBCFCPSTRet: ").Append(vBCFCPSTRet).Append("\n");
            sb.Append("  pFCPSTRet: ").Append(pFCPSTRet).Append("\n");
            sb.Append("  vFCPSTRet: ").Append(vFCPSTRet).Append("\n");
            sb.Append("  pRedBCEfet: ").Append(pRedBCEfet).Append("\n");
            sb.Append("  vBCEfet: ").Append(vBCEfet).Append("\n");
            sb.Append("  pICMSEfet: ").Append(pICMSEfet).Append("\n");
            sb.Append("  vICMSEfet: ").Append(vICMSEfet).Append("\n");
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
            return this.Equals(input as NfeSefazICMS60);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS60 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS60 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS60 input)
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
                    this.vBCSTRet == input.vBCSTRet ||
                    this.vBCSTRet.Equals(input.vBCSTRet)
                ) && 
                (
                    this.pST == input.pST ||
                    this.pST.Equals(input.pST)
                ) && 
                (
                    this.vICMSSubstituto == input.vICMSSubstituto ||
                    this.vICMSSubstituto.Equals(input.vICMSSubstituto)
                ) && 
                (
                    this.vICMSSTRet == input.vICMSSTRet ||
                    this.vICMSSTRet.Equals(input.vICMSSTRet)
                ) && 
                (
                    this.vBCFCPSTRet == input.vBCFCPSTRet ||
                    this.vBCFCPSTRet.Equals(input.vBCFCPSTRet)
                ) && 
                (
                    this.pFCPSTRet == input.pFCPSTRet ||
                    this.pFCPSTRet.Equals(input.pFCPSTRet)
                ) && 
                (
                    this.vFCPSTRet == input.vFCPSTRet ||
                    this.vFCPSTRet.Equals(input.vFCPSTRet)
                ) && 
                (
                    this.pRedBCEfet == input.pRedBCEfet ||
                    this.pRedBCEfet.Equals(input.pRedBCEfet)
                ) && 
                (
                    this.vBCEfet == input.vBCEfet ||
                    this.vBCEfet.Equals(input.vBCEfet)
                ) && 
                (
                    this.pICMSEfet == input.pICMSEfet ||
                    this.pICMSEfet.Equals(input.pICMSEfet)
                ) && 
                (
                    this.vICMSEfet == input.vICMSEfet ||
                    this.vICMSEfet.Equals(input.vICMSEfet)
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
                hashCode = (hashCode * 59) + this.vBCSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.pST.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSSubstituto.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCFCPSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.pFCPSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.vFCPSTRet.GetHashCode();
                hashCode = (hashCode * 59) + this.pRedBCEfet.GetHashCode();
                hashCode = (hashCode * 59) + this.vBCEfet.GetHashCode();
                hashCode = (hashCode * 59) + this.pICMSEfet.GetHashCode();
                hashCode = (hashCode * 59) + this.vICMSEfet.GetHashCode();
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
