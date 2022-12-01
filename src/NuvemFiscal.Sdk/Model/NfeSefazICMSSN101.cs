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
    /// NfeSefazICMSSN101
    /// </summary>
    [DataContract(Name = "NfeSefazICMSSN101")]
    public partial class NfeSefazICMSSN101 : IEquatable<NfeSefazICMSSN101>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSSN101" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMSSN101() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMSSN101" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cSOSN">101- Tributada pelo Simples Nacional com permissão de crédito. (v.2.0). (required).</param>
        /// <param name="pCredSN">Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0). (required).</param>
        /// <param name="vCredICMSSN">Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0). (required).</param>
        public NfeSefazICMSSN101(int orig = default(int), string cSOSN = default(string), decimal pCredSN = default(decimal), decimal vCredICMSSN = default(decimal))
        {
            this.orig = orig;
            // to ensure "cSOSN" is required (not null)
            if (cSOSN == null)
            {
                throw new ArgumentNullException("cSOSN is a required property for NfeSefazICMSSN101 and cannot be null");
            }
            this.CSOSN = cSOSN;
            this.pCredSN = pCredSN;
            this.vCredICMSSN = vCredICMSSN;
        }

        /// <summary>
        /// Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  1 - Estrangeira - Importação direta, exceto a indicada no código 6;  2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int orig { get; set; }

        /// <summary>
        /// 101- Tributada pelo Simples Nacional com permissão de crédito. (v.2.0).
        /// </summary>
        /// <value>101- Tributada pelo Simples Nacional com permissão de crédito. (v.2.0).</value>
        [DataMember(Name = "CSOSN", IsRequired = true, EmitDefaultValue = true)]
        public string CSOSN { get; set; }

        /// <summary>
        /// Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0).
        /// </summary>
        /// <value>Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0).</value>
        [DataMember(Name = "pCredSN", IsRequired = true, EmitDefaultValue = true)]
        public decimal pCredSN { get; set; }

        /// <summary>
        /// Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0).
        /// </summary>
        /// <value>Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0).</value>
        [DataMember(Name = "vCredICMSSN", IsRequired = true, EmitDefaultValue = true)]
        public decimal vCredICMSSN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMSSN101 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CSOSN: ").Append(CSOSN).Append("\n");
            sb.Append("  pCredSN: ").Append(pCredSN).Append("\n");
            sb.Append("  vCredICMSSN: ").Append(vCredICMSSN).Append("\n");
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
            return this.Equals(input as NfeSefazICMSSN101);
        }

        /// <summary>
        /// Returns true if NfeSefazICMSSN101 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMSSN101 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMSSN101 input)
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
                    this.CSOSN == input.CSOSN ||
                    (this.CSOSN != null &&
                    this.CSOSN.Equals(input.CSOSN))
                ) && 
                (
                    this.pCredSN == input.pCredSN ||
                    this.pCredSN.Equals(input.pCredSN)
                ) && 
                (
                    this.vCredICMSSN == input.vCredICMSSN ||
                    this.vCredICMSSN.Equals(input.vCredICMSSN)
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
                if (this.CSOSN != null)
                {
                    hashCode = (hashCode * 59) + this.CSOSN.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.pCredSN.GetHashCode();
                hashCode = (hashCode * 59) + this.vCredICMSSN.GetHashCode();
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
