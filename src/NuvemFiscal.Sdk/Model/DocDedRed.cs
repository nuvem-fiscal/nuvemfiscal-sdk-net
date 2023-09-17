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
    /// Grupo de informações de documento utilizado para Dedução/Redução do valor do serviço.
    /// </summary>
    [DataContract(Name = "DocDedRed")]
    public partial class DocDedRed : IEquatable<DocDedRed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocDedRed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocDedRed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocDedRed" /> class.
        /// </summary>
        /// <param name="chNFSe">Chave de Acesso da NFS-e (Padrão Nacional)..</param>
        /// <param name="chNFe">Chave de Acesso da NF-e..</param>
        /// <param name="nFSeMun">nFSeMun.</param>
        /// <param name="nFNFS">nFNFS.</param>
        /// <param name="nDocFisc">Número de documento fiscal..</param>
        /// <param name="nDoc">Número de documento não fiscal..</param>
        /// <param name="tpDedRed">Identificação da Dedução/Redução:  * 1 - Alimentação e bebidas/frigobar  * 2 - Materiais  * 3 - Produção externa  * 4 - Reembolso de despesas  * 5 - Repasse consorciado  * 6 - Repasse plano de saúde  * 7 - Serviços  * 8 - Subempreitada de mão de obra  * 99 - Outras deduções (required).</param>
        /// <param name="xDescOutDed">Descrição da Dedução/Redução quando a opção é \&quot;99 - Outras Deduções\&quot;..</param>
        /// <param name="dtEmiDoc">Data da emissão do documento dedutível. Ano, mês e dia (AAAA-MM-DD). (required).</param>
        /// <param name="vDedutivelRedutivel">Valor monetário total dedutível/redutível no documento informado (R$).  Este é o valor total no documento informado que é passível de dedução/redução. (required).</param>
        /// <param name="vDeducaoReducao">Valor monetário utilizado para dedução/redução do valor do serviço da NFS-e que está sendo emitida (R$).  Deve ser menor ou igual ao valor deduzível/redutível (vDedutivelRedutivel). (required).</param>
        /// <param name="fornec">fornec.</param>
        public DocDedRed(string chNFSe = default(string), string chNFe = default(string), DocOutNFSe nFSeMun = default(DocOutNFSe), DocNFNFS nFNFS = default(DocNFNFS), string nDocFisc = default(string), string nDoc = default(string), int? tpDedRed = default(int?), string xDescOutDed = default(string), DateTime? dtEmiDoc = default(DateTime?), decimal? vDedutivelRedutivel = default(decimal?), decimal? vDeducaoReducao = default(decimal?), InfoFornecDocDedRed fornec = default(InfoFornecDocDedRed))
        {
            // to ensure "tpDedRed" is required (not null)
            if (tpDedRed == null)
            {
                throw new ArgumentNullException("tpDedRed is a required property for DocDedRed and cannot be null");
            }
            this.tpDedRed = tpDedRed;
            // to ensure "dtEmiDoc" is required (not null)
            if (dtEmiDoc == null)
            {
                throw new ArgumentNullException("dtEmiDoc is a required property for DocDedRed and cannot be null");
            }
            this.dtEmiDoc = dtEmiDoc;
            // to ensure "vDedutivelRedutivel" is required (not null)
            if (vDedutivelRedutivel == null)
            {
                throw new ArgumentNullException("vDedutivelRedutivel is a required property for DocDedRed and cannot be null");
            }
            this.vDedutivelRedutivel = vDedutivelRedutivel;
            // to ensure "vDeducaoReducao" is required (not null)
            if (vDeducaoReducao == null)
            {
                throw new ArgumentNullException("vDeducaoReducao is a required property for DocDedRed and cannot be null");
            }
            this.vDeducaoReducao = vDeducaoReducao;
            this.chNFSe = chNFSe;
            this.chNFe = chNFe;
            this.NFSeMun = nFSeMun;
            this.NFNFS = nFNFS;
            this.nDocFisc = nDocFisc;
            this.nDoc = nDoc;
            this.xDescOutDed = xDescOutDed;
            this.fornec = fornec;
        }

        /// <summary>
        /// Chave de Acesso da NFS-e (Padrão Nacional).
        /// </summary>
        /// <value>Chave de Acesso da NFS-e (Padrão Nacional).</value>
        [DataMember(Name = "chNFSe", EmitDefaultValue = true)]
        public string chNFSe { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e.
        /// </summary>
        /// <value>Chave de Acesso da NF-e.</value>
        [DataMember(Name = "chNFe", EmitDefaultValue = true)]
        public string chNFe { get; set; }

        /// <summary>
        /// Gets or Sets NFSeMun
        /// </summary>
        [DataMember(Name = "NFSeMun", EmitDefaultValue = false)]
        public DocOutNFSe NFSeMun { get; set; }

        /// <summary>
        /// Gets or Sets NFNFS
        /// </summary>
        [DataMember(Name = "NFNFS", EmitDefaultValue = false)]
        public DocNFNFS NFNFS { get; set; }

        /// <summary>
        /// Número de documento fiscal.
        /// </summary>
        /// <value>Número de documento fiscal.</value>
        [DataMember(Name = "nDocFisc", EmitDefaultValue = true)]
        public string nDocFisc { get; set; }

        /// <summary>
        /// Número de documento não fiscal.
        /// </summary>
        /// <value>Número de documento não fiscal.</value>
        [DataMember(Name = "nDoc", EmitDefaultValue = true)]
        public string nDoc { get; set; }

        /// <summary>
        /// Identificação da Dedução/Redução:  * 1 - Alimentação e bebidas/frigobar  * 2 - Materiais  * 3 - Produção externa  * 4 - Reembolso de despesas  * 5 - Repasse consorciado  * 6 - Repasse plano de saúde  * 7 - Serviços  * 8 - Subempreitada de mão de obra  * 99 - Outras deduções
        /// </summary>
        /// <value>Identificação da Dedução/Redução:  * 1 - Alimentação e bebidas/frigobar  * 2 - Materiais  * 3 - Produção externa  * 4 - Reembolso de despesas  * 5 - Repasse consorciado  * 6 - Repasse plano de saúde  * 7 - Serviços  * 8 - Subempreitada de mão de obra  * 99 - Outras deduções</value>
        [DataMember(Name = "tpDedRed", IsRequired = true, EmitDefaultValue = true)]
        public int? tpDedRed { get; set; }

        /// <summary>
        /// Descrição da Dedução/Redução quando a opção é \&quot;99 - Outras Deduções\&quot;.
        /// </summary>
        /// <value>Descrição da Dedução/Redução quando a opção é \&quot;99 - Outras Deduções\&quot;.</value>
        [DataMember(Name = "xDescOutDed", EmitDefaultValue = true)]
        public string xDescOutDed { get; set; }

        /// <summary>
        /// Data da emissão do documento dedutível. Ano, mês e dia (AAAA-MM-DD).
        /// </summary>
        /// <value>Data da emissão do documento dedutível. Ano, mês e dia (AAAA-MM-DD).</value>
        [DataMember(Name = "dtEmiDoc", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dtEmiDoc { get; set; }

        /// <summary>
        /// Valor monetário total dedutível/redutível no documento informado (R$).  Este é o valor total no documento informado que é passível de dedução/redução.
        /// </summary>
        /// <value>Valor monetário total dedutível/redutível no documento informado (R$).  Este é o valor total no documento informado que é passível de dedução/redução.</value>
        [DataMember(Name = "vDedutivelRedutivel", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDedutivelRedutivel { get; set; }

        /// <summary>
        /// Valor monetário utilizado para dedução/redução do valor do serviço da NFS-e que está sendo emitida (R$).  Deve ser menor ou igual ao valor deduzível/redutível (vDedutivelRedutivel).
        /// </summary>
        /// <value>Valor monetário utilizado para dedução/redução do valor do serviço da NFS-e que está sendo emitida (R$).  Deve ser menor ou igual ao valor deduzível/redutível (vDedutivelRedutivel).</value>
        [DataMember(Name = "vDeducaoReducao", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDeducaoReducao { get; set; }

        /// <summary>
        /// Gets or Sets fornec
        /// </summary>
        [DataMember(Name = "fornec", EmitDefaultValue = false)]
        public InfoFornecDocDedRed fornec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocDedRed {\n");
            sb.Append("  chNFSe: ").Append(chNFSe).Append("\n");
            sb.Append("  chNFe: ").Append(chNFe).Append("\n");
            sb.Append("  NFSeMun: ").Append(NFSeMun).Append("\n");
            sb.Append("  NFNFS: ").Append(NFNFS).Append("\n");
            sb.Append("  nDocFisc: ").Append(nDocFisc).Append("\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
            sb.Append("  tpDedRed: ").Append(tpDedRed).Append("\n");
            sb.Append("  xDescOutDed: ").Append(xDescOutDed).Append("\n");
            sb.Append("  dtEmiDoc: ").Append(dtEmiDoc).Append("\n");
            sb.Append("  vDedutivelRedutivel: ").Append(vDedutivelRedutivel).Append("\n");
            sb.Append("  vDeducaoReducao: ").Append(vDeducaoReducao).Append("\n");
            sb.Append("  fornec: ").Append(fornec).Append("\n");
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
            return this.Equals(input as DocDedRed);
        }

        /// <summary>
        /// Returns true if DocDedRed instances are equal
        /// </summary>
        /// <param name="input">Instance of DocDedRed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocDedRed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chNFSe == input.chNFSe ||
                    (this.chNFSe != null &&
                    this.chNFSe.Equals(input.chNFSe))
                ) && 
                (
                    this.chNFe == input.chNFe ||
                    (this.chNFe != null &&
                    this.chNFe.Equals(input.chNFe))
                ) && 
                (
                    this.NFSeMun == input.NFSeMun ||
                    (this.NFSeMun != null &&
                    this.NFSeMun.Equals(input.NFSeMun))
                ) && 
                (
                    this.NFNFS == input.NFNFS ||
                    (this.NFNFS != null &&
                    this.NFNFS.Equals(input.NFNFS))
                ) && 
                (
                    this.nDocFisc == input.nDocFisc ||
                    (this.nDocFisc != null &&
                    this.nDocFisc.Equals(input.nDocFisc))
                ) && 
                (
                    this.nDoc == input.nDoc ||
                    (this.nDoc != null &&
                    this.nDoc.Equals(input.nDoc))
                ) && 
                (
                    this.tpDedRed == input.tpDedRed ||
                    (this.tpDedRed != null &&
                    this.tpDedRed.Equals(input.tpDedRed))
                ) && 
                (
                    this.xDescOutDed == input.xDescOutDed ||
                    (this.xDescOutDed != null &&
                    this.xDescOutDed.Equals(input.xDescOutDed))
                ) && 
                (
                    this.dtEmiDoc == input.dtEmiDoc ||
                    (this.dtEmiDoc != null &&
                    this.dtEmiDoc.Equals(input.dtEmiDoc))
                ) && 
                (
                    this.vDedutivelRedutivel == input.vDedutivelRedutivel ||
                    (this.vDedutivelRedutivel != null &&
                    this.vDedutivelRedutivel.Equals(input.vDedutivelRedutivel))
                ) && 
                (
                    this.vDeducaoReducao == input.vDeducaoReducao ||
                    (this.vDeducaoReducao != null &&
                    this.vDeducaoReducao.Equals(input.vDeducaoReducao))
                ) && 
                (
                    this.fornec == input.fornec ||
                    (this.fornec != null &&
                    this.fornec.Equals(input.fornec))
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
                if (this.chNFSe != null)
                {
                    hashCode = (hashCode * 59) + this.chNFSe.GetHashCode();
                }
                if (this.chNFe != null)
                {
                    hashCode = (hashCode * 59) + this.chNFe.GetHashCode();
                }
                if (this.NFSeMun != null)
                {
                    hashCode = (hashCode * 59) + this.NFSeMun.GetHashCode();
                }
                if (this.NFNFS != null)
                {
                    hashCode = (hashCode * 59) + this.NFNFS.GetHashCode();
                }
                if (this.nDocFisc != null)
                {
                    hashCode = (hashCode * 59) + this.nDocFisc.GetHashCode();
                }
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
                }
                if (this.tpDedRed != null)
                {
                    hashCode = (hashCode * 59) + this.tpDedRed.GetHashCode();
                }
                if (this.xDescOutDed != null)
                {
                    hashCode = (hashCode * 59) + this.xDescOutDed.GetHashCode();
                }
                if (this.dtEmiDoc != null)
                {
                    hashCode = (hashCode * 59) + this.dtEmiDoc.GetHashCode();
                }
                if (this.vDedutivelRedutivel != null)
                {
                    hashCode = (hashCode * 59) + this.vDedutivelRedutivel.GetHashCode();
                }
                if (this.vDeducaoReducao != null)
                {
                    hashCode = (hashCode * 59) + this.vDeducaoReducao.GetHashCode();
                }
                if (this.fornec != null)
                {
                    hashCode = (hashCode * 59) + this.fornec.GetHashCode();
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
