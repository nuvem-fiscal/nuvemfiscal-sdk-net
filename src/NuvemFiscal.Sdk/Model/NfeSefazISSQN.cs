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
    /// NfeSefazISSQN
    /// </summary>
    [DataContract(Name = "NfeSefazISSQN")]
    public partial class NfeSefazISSQN : IEquatable<NfeSefazISSQN>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazISSQN" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazISSQN() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazISSQN" /> class.
        /// </summary>
        /// <param name="vBC">Valor da BC do ISSQN. (required).</param>
        /// <param name="vAliq">Alíquota do ISSQN. (required).</param>
        /// <param name="vISSQN">Valor da do ISSQN. (required).</param>
        /// <param name="cMunFG">Informar o município de ocorrência do fato gerador do ISSQN. Utilizar a Tabela do IBGE (Anexo VII - Tabela de UF, Município e País). “Atenção, não vincular com os campos B12, C10 ou E10” v2.0. (required).</param>
        /// <param name="cListServ">Informar o Item da lista de serviços da LC 116/03 em que se classifica o serviço. (required).</param>
        /// <param name="vDeducao">Valor dedução para redução da base de cálculo..</param>
        /// <param name="vOutro">Valor outras retenções..</param>
        /// <param name="vDescIncond">Valor desconto incondicionado..</param>
        /// <param name="vDescCond">Valor desconto condicionado..</param>
        /// <param name="vISSRet">Valor Retenção ISS..</param>
        /// <param name="indISS">Exibilidade do ISS:1-Exigível;2-Não incidente;3-Isenção;4-Exportação;5-Imunidade;6-Exig.Susp. Judicial;7-Exig.Susp. ADM. (required).</param>
        /// <param name="cServico">Código do serviço prestado dentro do município..</param>
        /// <param name="cMun">Código do Município de Incidência do Imposto..</param>
        /// <param name="cPais">Código de Pais..</param>
        /// <param name="nProcesso">Número do Processo administrativo ou judicial de suspenção do processo..</param>
        /// <param name="indIncentivo">Indicador de Incentivo Fiscal. 1&#x3D;Sim; 2&#x3D;Não. (required).</param>
        public NfeSefazISSQN(decimal vBC = default(decimal), decimal vAliq = default(decimal), decimal vISSQN = default(decimal), int cMunFG = default(int), string cListServ = default(string), decimal vDeducao = default(decimal), decimal vOutro = default(decimal), decimal vDescIncond = default(decimal), decimal vDescCond = default(decimal), decimal vISSRet = default(decimal), int indISS = default(int), string cServico = default(string), int cMun = default(int), int cPais = default(int), string nProcesso = default(string), int indIncentivo = default(int))
        {
            this.vBC = vBC;
            this.vAliq = vAliq;
            this.vISSQN = vISSQN;
            this.cMunFG = cMunFG;
            // to ensure "cListServ" is required (not null)
            if (cListServ == null)
            {
                throw new ArgumentNullException("cListServ is a required property for NfeSefazISSQN and cannot be null");
            }
            this.cListServ = cListServ;
            this.indISS = indISS;
            this.indIncentivo = indIncentivo;
            this.vDeducao = vDeducao;
            this.vOutro = vOutro;
            this.vDescIncond = vDescIncond;
            this.vDescCond = vDescCond;
            this.vISSRet = vISSRet;
            this.cServico = cServico;
            this.cMun = cMun;
            this.cPais = cPais;
            this.nProcesso = nProcesso;
        }

        /// <summary>
        /// Valor da BC do ISSQN.
        /// </summary>
        /// <value>Valor da BC do ISSQN.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = false)]
        public decimal vBC { get; set; }

        /// <summary>
        /// Alíquota do ISSQN.
        /// </summary>
        /// <value>Alíquota do ISSQN.</value>
        [DataMember(Name = "vAliq", IsRequired = true, EmitDefaultValue = false)]
        public decimal vAliq { get; set; }

        /// <summary>
        /// Valor da do ISSQN.
        /// </summary>
        /// <value>Valor da do ISSQN.</value>
        [DataMember(Name = "vISSQN", IsRequired = true, EmitDefaultValue = false)]
        public decimal vISSQN { get; set; }

        /// <summary>
        /// Informar o município de ocorrência do fato gerador do ISSQN. Utilizar a Tabela do IBGE (Anexo VII - Tabela de UF, Município e País). “Atenção, não vincular com os campos B12, C10 ou E10” v2.0.
        /// </summary>
        /// <value>Informar o município de ocorrência do fato gerador do ISSQN. Utilizar a Tabela do IBGE (Anexo VII - Tabela de UF, Município e País). “Atenção, não vincular com os campos B12, C10 ou E10” v2.0.</value>
        [DataMember(Name = "cMunFG", IsRequired = true, EmitDefaultValue = false)]
        public int cMunFG { get; set; }

        /// <summary>
        /// Informar o Item da lista de serviços da LC 116/03 em que se classifica o serviço.
        /// </summary>
        /// <value>Informar o Item da lista de serviços da LC 116/03 em que se classifica o serviço.</value>
        [DataMember(Name = "cListServ", IsRequired = true, EmitDefaultValue = false)]
        public string cListServ { get; set; }

        /// <summary>
        /// Valor dedução para redução da base de cálculo.
        /// </summary>
        /// <value>Valor dedução para redução da base de cálculo.</value>
        [DataMember(Name = "vDeducao", EmitDefaultValue = false)]
        public decimal vDeducao { get; set; }

        /// <summary>
        /// Valor outras retenções.
        /// </summary>
        /// <value>Valor outras retenções.</value>
        [DataMember(Name = "vOutro", EmitDefaultValue = false)]
        public decimal vOutro { get; set; }

        /// <summary>
        /// Valor desconto incondicionado.
        /// </summary>
        /// <value>Valor desconto incondicionado.</value>
        [DataMember(Name = "vDescIncond", EmitDefaultValue = false)]
        public decimal vDescIncond { get; set; }

        /// <summary>
        /// Valor desconto condicionado.
        /// </summary>
        /// <value>Valor desconto condicionado.</value>
        [DataMember(Name = "vDescCond", EmitDefaultValue = false)]
        public decimal vDescCond { get; set; }

        /// <summary>
        /// Valor Retenção ISS.
        /// </summary>
        /// <value>Valor Retenção ISS.</value>
        [DataMember(Name = "vISSRet", EmitDefaultValue = false)]
        public decimal vISSRet { get; set; }

        /// <summary>
        /// Exibilidade do ISS:1-Exigível;2-Não incidente;3-Isenção;4-Exportação;5-Imunidade;6-Exig.Susp. Judicial;7-Exig.Susp. ADM.
        /// </summary>
        /// <value>Exibilidade do ISS:1-Exigível;2-Não incidente;3-Isenção;4-Exportação;5-Imunidade;6-Exig.Susp. Judicial;7-Exig.Susp. ADM.</value>
        [DataMember(Name = "indISS", IsRequired = true, EmitDefaultValue = false)]
        public int indISS { get; set; }

        /// <summary>
        /// Código do serviço prestado dentro do município.
        /// </summary>
        /// <value>Código do serviço prestado dentro do município.</value>
        [DataMember(Name = "cServico", EmitDefaultValue = false)]
        public string cServico { get; set; }

        /// <summary>
        /// Código do Município de Incidência do Imposto.
        /// </summary>
        /// <value>Código do Município de Incidência do Imposto.</value>
        [DataMember(Name = "cMun", EmitDefaultValue = false)]
        public int cMun { get; set; }

        /// <summary>
        /// Código de Pais.
        /// </summary>
        /// <value>Código de Pais.</value>
        [DataMember(Name = "cPais", EmitDefaultValue = false)]
        public int cPais { get; set; }

        /// <summary>
        /// Número do Processo administrativo ou judicial de suspenção do processo.
        /// </summary>
        /// <value>Número do Processo administrativo ou judicial de suspenção do processo.</value>
        [DataMember(Name = "nProcesso", EmitDefaultValue = false)]
        public string nProcesso { get; set; }

        /// <summary>
        /// Indicador de Incentivo Fiscal. 1&#x3D;Sim; 2&#x3D;Não.
        /// </summary>
        /// <value>Indicador de Incentivo Fiscal. 1&#x3D;Sim; 2&#x3D;Não.</value>
        [DataMember(Name = "indIncentivo", IsRequired = true, EmitDefaultValue = false)]
        public int indIncentivo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazISSQN {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  vAliq: ").Append(vAliq).Append("\n");
            sb.Append("  vISSQN: ").Append(vISSQN).Append("\n");
            sb.Append("  cMunFG: ").Append(cMunFG).Append("\n");
            sb.Append("  cListServ: ").Append(cListServ).Append("\n");
            sb.Append("  vDeducao: ").Append(vDeducao).Append("\n");
            sb.Append("  vOutro: ").Append(vOutro).Append("\n");
            sb.Append("  vDescIncond: ").Append(vDescIncond).Append("\n");
            sb.Append("  vDescCond: ").Append(vDescCond).Append("\n");
            sb.Append("  vISSRet: ").Append(vISSRet).Append("\n");
            sb.Append("  indISS: ").Append(indISS).Append("\n");
            sb.Append("  cServico: ").Append(cServico).Append("\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  cPais: ").Append(cPais).Append("\n");
            sb.Append("  nProcesso: ").Append(nProcesso).Append("\n");
            sb.Append("  indIncentivo: ").Append(indIncentivo).Append("\n");
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
            return this.Equals(input as NfeSefazISSQN);
        }

        /// <summary>
        /// Returns true if NfeSefazISSQN instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazISSQN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazISSQN input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    this.vBC.Equals(input.vBC)
                ) && 
                (
                    this.vAliq == input.vAliq ||
                    this.vAliq.Equals(input.vAliq)
                ) && 
                (
                    this.vISSQN == input.vISSQN ||
                    this.vISSQN.Equals(input.vISSQN)
                ) && 
                (
                    this.cMunFG == input.cMunFG ||
                    this.cMunFG.Equals(input.cMunFG)
                ) && 
                (
                    this.cListServ == input.cListServ ||
                    (this.cListServ != null &&
                    this.cListServ.Equals(input.cListServ))
                ) && 
                (
                    this.vDeducao == input.vDeducao ||
                    this.vDeducao.Equals(input.vDeducao)
                ) && 
                (
                    this.vOutro == input.vOutro ||
                    this.vOutro.Equals(input.vOutro)
                ) && 
                (
                    this.vDescIncond == input.vDescIncond ||
                    this.vDescIncond.Equals(input.vDescIncond)
                ) && 
                (
                    this.vDescCond == input.vDescCond ||
                    this.vDescCond.Equals(input.vDescCond)
                ) && 
                (
                    this.vISSRet == input.vISSRet ||
                    this.vISSRet.Equals(input.vISSRet)
                ) && 
                (
                    this.indISS == input.indISS ||
                    this.indISS.Equals(input.indISS)
                ) && 
                (
                    this.cServico == input.cServico ||
                    (this.cServico != null &&
                    this.cServico.Equals(input.cServico))
                ) && 
                (
                    this.cMun == input.cMun ||
                    this.cMun.Equals(input.cMun)
                ) && 
                (
                    this.cPais == input.cPais ||
                    this.cPais.Equals(input.cPais)
                ) && 
                (
                    this.nProcesso == input.nProcesso ||
                    (this.nProcesso != null &&
                    this.nProcesso.Equals(input.nProcesso))
                ) && 
                (
                    this.indIncentivo == input.indIncentivo ||
                    this.indIncentivo.Equals(input.indIncentivo)
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
                hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                hashCode = (hashCode * 59) + this.vAliq.GetHashCode();
                hashCode = (hashCode * 59) + this.vISSQN.GetHashCode();
                hashCode = (hashCode * 59) + this.cMunFG.GetHashCode();
                if (this.cListServ != null)
                {
                    hashCode = (hashCode * 59) + this.cListServ.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vDeducao.GetHashCode();
                hashCode = (hashCode * 59) + this.vOutro.GetHashCode();
                hashCode = (hashCode * 59) + this.vDescIncond.GetHashCode();
                hashCode = (hashCode * 59) + this.vDescCond.GetHashCode();
                hashCode = (hashCode * 59) + this.vISSRet.GetHashCode();
                hashCode = (hashCode * 59) + this.indISS.GetHashCode();
                if (this.cServico != null)
                {
                    hashCode = (hashCode * 59) + this.cServico.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.cMun.GetHashCode();
                hashCode = (hashCode * 59) + this.cPais.GetHashCode();
                if (this.nProcesso != null)
                {
                    hashCode = (hashCode * 59) + this.nProcesso.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.indIncentivo.GetHashCode();
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
