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
    /// MdfeSefazInfPag
    /// </summary>
    [DataContract(Name = "MdfeSefazInfPag")]
    public partial class MdfeSefazInfPag : IEquatable<MdfeSefazInfPag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfPag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfPag" /> class.
        /// </summary>
        /// <param name="xNome">Razão social ou Nome do respnsável pelo pagamento..</param>
        /// <param name="cPF">Número do CPF do responsável pelo pgto.  Informar os zeros não significativos..</param>
        /// <param name="cNPJ">Número do CNPJ do responsável pelo pgto.  Informar os zeros não significativos..</param>
        /// <param name="idEstrangeiro">Identificador do responsável pelo pgto em caso de ser estrangeiro..</param>
        /// <param name="comp">Componentes do Pagamentoi do Frete. (required).</param>
        /// <param name="vContrato">Valor Total do Contrato. (required).</param>
        /// <param name="indAltoDesemp">Indicador de operação de transporte de alto desempenho.  Operação de transporte com utilização de veículos de frotas dedicadas ou fidelizadas.  Preencher com “1” para indicar operação de transporte de alto desempenho, demais casos não informar a tag..</param>
        /// <param name="indPag">Indicador da Forma de Pagamento:0-Pagamento à Vista;1-Pagamento à Prazo;. (required).</param>
        /// <param name="vAdiant">Valor do Adiantamento (usar apenas em pagamento à Prazo..</param>
        /// <param name="indAntecipaAdiant">Indicador para declarar concordância em antecipar o adiantamento.  Informar a tag somente se for autorizado antecipar o adiantamento..</param>
        /// <param name="infPrazo">Informações do pagamento a prazo.  Informar somente se indPag for à Prazo..</param>
        /// <param name="tpAntecip">Tipo de Permissão em relação a antecipação das parcelas.  0 - Não permite antecipar    1 - Permite antecipar as parcelas    2 - Permite antecipar as parcelas mediante confirmação..</param>
        /// <param name="infBanc">infBanc (required).</param>
        public MdfeSefazInfPag(string xNome = default(string), string cPF = default(string), string cNPJ = default(string), string idEstrangeiro = default(string), List<MdfeSefazComp> comp = default(List<MdfeSefazComp>), decimal vContrato = default(decimal), int indAltoDesemp = default(int), int indPag = default(int), decimal vAdiant = default(decimal), int indAntecipaAdiant = default(int), List<MdfeSefazInfPrazo> infPrazo = default(List<MdfeSefazInfPrazo>), int tpAntecip = default(int), MdfeSefazInfBanc infBanc = default(MdfeSefazInfBanc))
        {
            // to ensure "comp" is required (not null)
            if (comp == null)
            {
                throw new ArgumentNullException("comp is a required property for MdfeSefazInfPag and cannot be null");
            }
            this.Comp = comp;
            this.vContrato = vContrato;
            this.indPag = indPag;
            // to ensure "infBanc" is required (not null)
            if (infBanc == null)
            {
                throw new ArgumentNullException("infBanc is a required property for MdfeSefazInfPag and cannot be null");
            }
            this.infBanc = infBanc;
            this.xNome = xNome;
            this.CPF = cPF;
            this.CNPJ = cNPJ;
            this.idEstrangeiro = idEstrangeiro;
            this.indAltoDesemp = indAltoDesemp;
            this.vAdiant = vAdiant;
            this.indAntecipaAdiant = indAntecipaAdiant;
            this.infPrazo = infPrazo;
            this.tpAntecip = tpAntecip;
        }

        /// <summary>
        /// Razão social ou Nome do respnsável pelo pagamento.
        /// </summary>
        /// <value>Razão social ou Nome do respnsável pelo pagamento.</value>
        [DataMember(Name = "xNome", EmitDefaultValue = false)]
        public string xNome { get; set; }

        /// <summary>
        /// Número do CPF do responsável pelo pgto.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF do responsável pelo pgto.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Número do CNPJ do responsável pelo pgto.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ do responsável pelo pgto.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Identificador do responsável pelo pgto em caso de ser estrangeiro.
        /// </summary>
        /// <value>Identificador do responsável pelo pgto em caso de ser estrangeiro.</value>
        [DataMember(Name = "idEstrangeiro", EmitDefaultValue = false)]
        public string idEstrangeiro { get; set; }

        /// <summary>
        /// Componentes do Pagamentoi do Frete.
        /// </summary>
        /// <value>Componentes do Pagamentoi do Frete.</value>
        [DataMember(Name = "Comp", IsRequired = true, EmitDefaultValue = true)]
        public List<MdfeSefazComp> Comp { get; set; }

        /// <summary>
        /// Valor Total do Contrato.
        /// </summary>
        /// <value>Valor Total do Contrato.</value>
        [DataMember(Name = "vContrato", IsRequired = true, EmitDefaultValue = true)]
        public decimal vContrato { get; set; }

        /// <summary>
        /// Indicador de operação de transporte de alto desempenho.  Operação de transporte com utilização de veículos de frotas dedicadas ou fidelizadas.  Preencher com “1” para indicar operação de transporte de alto desempenho, demais casos não informar a tag.
        /// </summary>
        /// <value>Indicador de operação de transporte de alto desempenho.  Operação de transporte com utilização de veículos de frotas dedicadas ou fidelizadas.  Preencher com “1” para indicar operação de transporte de alto desempenho, demais casos não informar a tag.</value>
        [DataMember(Name = "indAltoDesemp", EmitDefaultValue = false)]
        public int indAltoDesemp { get; set; }

        /// <summary>
        /// Indicador da Forma de Pagamento:0-Pagamento à Vista;1-Pagamento à Prazo;.
        /// </summary>
        /// <value>Indicador da Forma de Pagamento:0-Pagamento à Vista;1-Pagamento à Prazo;.</value>
        [DataMember(Name = "indPag", IsRequired = true, EmitDefaultValue = true)]
        public int indPag { get; set; }

        /// <summary>
        /// Valor do Adiantamento (usar apenas em pagamento à Prazo.
        /// </summary>
        /// <value>Valor do Adiantamento (usar apenas em pagamento à Prazo.</value>
        [DataMember(Name = "vAdiant", EmitDefaultValue = false)]
        public decimal vAdiant { get; set; }

        /// <summary>
        /// Indicador para declarar concordância em antecipar o adiantamento.  Informar a tag somente se for autorizado antecipar o adiantamento.
        /// </summary>
        /// <value>Indicador para declarar concordância em antecipar o adiantamento.  Informar a tag somente se for autorizado antecipar o adiantamento.</value>
        [DataMember(Name = "indAntecipaAdiant", EmitDefaultValue = false)]
        public int indAntecipaAdiant { get; set; }

        /// <summary>
        /// Informações do pagamento a prazo.  Informar somente se indPag for à Prazo.
        /// </summary>
        /// <value>Informações do pagamento a prazo.  Informar somente se indPag for à Prazo.</value>
        [DataMember(Name = "infPrazo", EmitDefaultValue = false)]
        public List<MdfeSefazInfPrazo> infPrazo { get; set; }

        /// <summary>
        /// Tipo de Permissão em relação a antecipação das parcelas.  0 - Não permite antecipar    1 - Permite antecipar as parcelas    2 - Permite antecipar as parcelas mediante confirmação.
        /// </summary>
        /// <value>Tipo de Permissão em relação a antecipação das parcelas.  0 - Não permite antecipar    1 - Permite antecipar as parcelas    2 - Permite antecipar as parcelas mediante confirmação.</value>
        [DataMember(Name = "tpAntecip", EmitDefaultValue = false)]
        public int tpAntecip { get; set; }

        /// <summary>
        /// Gets or Sets infBanc
        /// </summary>
        [DataMember(Name = "infBanc", IsRequired = true, EmitDefaultValue = true)]
        public MdfeSefazInfBanc infBanc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfPag {\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  idEstrangeiro: ").Append(idEstrangeiro).Append("\n");
            sb.Append("  Comp: ").Append(Comp).Append("\n");
            sb.Append("  vContrato: ").Append(vContrato).Append("\n");
            sb.Append("  indAltoDesemp: ").Append(indAltoDesemp).Append("\n");
            sb.Append("  indPag: ").Append(indPag).Append("\n");
            sb.Append("  vAdiant: ").Append(vAdiant).Append("\n");
            sb.Append("  indAntecipaAdiant: ").Append(indAntecipaAdiant).Append("\n");
            sb.Append("  infPrazo: ").Append(infPrazo).Append("\n");
            sb.Append("  tpAntecip: ").Append(tpAntecip).Append("\n");
            sb.Append("  infBanc: ").Append(infBanc).Append("\n");
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
            return this.Equals(input as MdfeSefazInfPag);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfPag instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfPag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfPag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.idEstrangeiro == input.idEstrangeiro ||
                    (this.idEstrangeiro != null &&
                    this.idEstrangeiro.Equals(input.idEstrangeiro))
                ) && 
                (
                    this.Comp == input.Comp ||
                    this.Comp != null &&
                    input.Comp != null &&
                    this.Comp.SequenceEqual(input.Comp)
                ) && 
                (
                    this.vContrato == input.vContrato ||
                    this.vContrato.Equals(input.vContrato)
                ) && 
                (
                    this.indAltoDesemp == input.indAltoDesemp ||
                    this.indAltoDesemp.Equals(input.indAltoDesemp)
                ) && 
                (
                    this.indPag == input.indPag ||
                    this.indPag.Equals(input.indPag)
                ) && 
                (
                    this.vAdiant == input.vAdiant ||
                    this.vAdiant.Equals(input.vAdiant)
                ) && 
                (
                    this.indAntecipaAdiant == input.indAntecipaAdiant ||
                    this.indAntecipaAdiant.Equals(input.indAntecipaAdiant)
                ) && 
                (
                    this.infPrazo == input.infPrazo ||
                    this.infPrazo != null &&
                    input.infPrazo != null &&
                    this.infPrazo.SequenceEqual(input.infPrazo)
                ) && 
                (
                    this.tpAntecip == input.tpAntecip ||
                    this.tpAntecip.Equals(input.tpAntecip)
                ) && 
                (
                    this.infBanc == input.infBanc ||
                    (this.infBanc != null &&
                    this.infBanc.Equals(input.infBanc))
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
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.idEstrangeiro != null)
                {
                    hashCode = (hashCode * 59) + this.idEstrangeiro.GetHashCode();
                }
                if (this.Comp != null)
                {
                    hashCode = (hashCode * 59) + this.Comp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vContrato.GetHashCode();
                hashCode = (hashCode * 59) + this.indAltoDesemp.GetHashCode();
                hashCode = (hashCode * 59) + this.indPag.GetHashCode();
                hashCode = (hashCode * 59) + this.vAdiant.GetHashCode();
                hashCode = (hashCode * 59) + this.indAntecipaAdiant.GetHashCode();
                if (this.infPrazo != null)
                {
                    hashCode = (hashCode * 59) + this.infPrazo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpAntecip.GetHashCode();
                if (this.infBanc != null)
                {
                    hashCode = (hashCode * 59) + this.infBanc.GetHashCode();
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
