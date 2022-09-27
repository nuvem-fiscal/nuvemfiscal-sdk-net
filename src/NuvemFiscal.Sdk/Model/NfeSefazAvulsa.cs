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
    /// NfeSefazAvulsa
    /// </summary>
    [DataContract(Name = "NfeSefazAvulsa")]
    public partial class NfeSefazAvulsa : IEquatable<NfeSefazAvulsa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazAvulsa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazAvulsa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazAvulsa" /> class.
        /// </summary>
        /// <param name="cNPJ">CNPJ do Órgão emissor. (required).</param>
        /// <param name="xOrgao">Órgão emitente. (required).</param>
        /// <param name="matr">Matrícula do agente. (required).</param>
        /// <param name="xAgente">Nome do agente. (required).</param>
        /// <param name="fone">Telefone..</param>
        /// <param name="uF">Sigla da Unidade da Federação. (required).</param>
        /// <param name="nDAR">Número do Documento de Arrecadação de Receita..</param>
        /// <param name="dEmi">Data de emissão do DAR (AAAA-MM-DD)..</param>
        /// <param name="vDAR">Valor Total constante no DAR..</param>
        /// <param name="repEmi">Repartição Fiscal emitente. (required).</param>
        /// <param name="dPag">Data de pagamento do DAR (AAAA-MM-DD)..</param>
        public NfeSefazAvulsa(string cNPJ = default(string), string xOrgao = default(string), string matr = default(string), string xAgente = default(string), string fone = default(string), string uF = default(string), string nDAR = default(string), DateTime dEmi = default(DateTime), decimal vDAR = default(decimal), string repEmi = default(string), DateTime dPag = default(DateTime))
        {
            // to ensure "cNPJ" is required (not null)
            if (cNPJ == null)
            {
                throw new ArgumentNullException("cNPJ is a required property for NfeSefazAvulsa and cannot be null");
            }
            this.CNPJ = cNPJ;
            // to ensure "xOrgao" is required (not null)
            if (xOrgao == null)
            {
                throw new ArgumentNullException("xOrgao is a required property for NfeSefazAvulsa and cannot be null");
            }
            this.xOrgao = xOrgao;
            // to ensure "matr" is required (not null)
            if (matr == null)
            {
                throw new ArgumentNullException("matr is a required property for NfeSefazAvulsa and cannot be null");
            }
            this.matr = matr;
            // to ensure "xAgente" is required (not null)
            if (xAgente == null)
            {
                throw new ArgumentNullException("xAgente is a required property for NfeSefazAvulsa and cannot be null");
            }
            this.xAgente = xAgente;
            // to ensure "uF" is required (not null)
            if (uF == null)
            {
                throw new ArgumentNullException("uF is a required property for NfeSefazAvulsa and cannot be null");
            }
            this.UF = uF;
            // to ensure "repEmi" is required (not null)
            if (repEmi == null)
            {
                throw new ArgumentNullException("repEmi is a required property for NfeSefazAvulsa and cannot be null");
            }
            this.repEmi = repEmi;
            this.fone = fone;
            this.nDAR = nDAR;
            this.dEmi = dEmi;
            this.vDAR = vDAR;
            this.dPag = dPag;
        }

        /// <summary>
        /// CNPJ do Órgão emissor.
        /// </summary>
        /// <value>CNPJ do Órgão emissor.</value>
        [DataMember(Name = "CNPJ", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Órgão emitente.
        /// </summary>
        /// <value>Órgão emitente.</value>
        [DataMember(Name = "xOrgao", IsRequired = true, EmitDefaultValue = true)]
        public string xOrgao { get; set; }

        /// <summary>
        /// Matrícula do agente.
        /// </summary>
        /// <value>Matrícula do agente.</value>
        [DataMember(Name = "matr", IsRequired = true, EmitDefaultValue = true)]
        public string matr { get; set; }

        /// <summary>
        /// Nome do agente.
        /// </summary>
        /// <value>Nome do agente.</value>
        [DataMember(Name = "xAgente", IsRequired = true, EmitDefaultValue = true)]
        public string xAgente { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        /// <value>Telefone.</value>
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// Sigla da Unidade da Federação.
        /// </summary>
        /// <value>Sigla da Unidade da Federação.</value>
        [DataMember(Name = "UF", IsRequired = true, EmitDefaultValue = true)]
        public string UF { get; set; }

        /// <summary>
        /// Número do Documento de Arrecadação de Receita.
        /// </summary>
        /// <value>Número do Documento de Arrecadação de Receita.</value>
        [DataMember(Name = "nDAR", EmitDefaultValue = false)]
        public string nDAR { get; set; }

        /// <summary>
        /// Data de emissão do DAR (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de emissão do DAR (AAAA-MM-DD).</value>
        [DataMember(Name = "dEmi", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Valor Total constante no DAR.
        /// </summary>
        /// <value>Valor Total constante no DAR.</value>
        [DataMember(Name = "vDAR", EmitDefaultValue = false)]
        public decimal vDAR { get; set; }

        /// <summary>
        /// Repartição Fiscal emitente.
        /// </summary>
        /// <value>Repartição Fiscal emitente.</value>
        [DataMember(Name = "repEmi", IsRequired = true, EmitDefaultValue = true)]
        public string repEmi { get; set; }

        /// <summary>
        /// Data de pagamento do DAR (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de pagamento do DAR (AAAA-MM-DD).</value>
        [DataMember(Name = "dPag", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dPag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazAvulsa {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  xOrgao: ").Append(xOrgao).Append("\n");
            sb.Append("  matr: ").Append(matr).Append("\n");
            sb.Append("  xAgente: ").Append(xAgente).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  nDAR: ").Append(nDAR).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
            sb.Append("  vDAR: ").Append(vDAR).Append("\n");
            sb.Append("  repEmi: ").Append(repEmi).Append("\n");
            sb.Append("  dPag: ").Append(dPag).Append("\n");
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
            return this.Equals(input as NfeSefazAvulsa);
        }

        /// <summary>
        /// Returns true if NfeSefazAvulsa instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazAvulsa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazAvulsa input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.xOrgao == input.xOrgao ||
                    (this.xOrgao != null &&
                    this.xOrgao.Equals(input.xOrgao))
                ) && 
                (
                    this.matr == input.matr ||
                    (this.matr != null &&
                    this.matr.Equals(input.matr))
                ) && 
                (
                    this.xAgente == input.xAgente ||
                    (this.xAgente != null &&
                    this.xAgente.Equals(input.xAgente))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.nDAR == input.nDAR ||
                    (this.nDAR != null &&
                    this.nDAR.Equals(input.nDAR))
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
                ) && 
                (
                    this.vDAR == input.vDAR ||
                    this.vDAR.Equals(input.vDAR)
                ) && 
                (
                    this.repEmi == input.repEmi ||
                    (this.repEmi != null &&
                    this.repEmi.Equals(input.repEmi))
                ) && 
                (
                    this.dPag == input.dPag ||
                    (this.dPag != null &&
                    this.dPag.Equals(input.dPag))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.xOrgao != null)
                {
                    hashCode = (hashCode * 59) + this.xOrgao.GetHashCode();
                }
                if (this.matr != null)
                {
                    hashCode = (hashCode * 59) + this.matr.GetHashCode();
                }
                if (this.xAgente != null)
                {
                    hashCode = (hashCode * 59) + this.xAgente.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.nDAR != null)
                {
                    hashCode = (hashCode * 59) + this.nDAR.GetHashCode();
                }
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vDAR.GetHashCode();
                if (this.repEmi != null)
                {
                    hashCode = (hashCode * 59) + this.repEmi.GetHashCode();
                }
                if (this.dPag != null)
                {
                    hashCode = (hashCode * 59) + this.dPag.GetHashCode();
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
