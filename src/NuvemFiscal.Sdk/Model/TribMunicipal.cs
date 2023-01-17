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
    /// Grupo de informações relacionados ao Imposto Sobre Serviços de Qualquer Natureza - ISSQN.
    /// </summary>
    [DataContract(Name = "TribMunicipal")]
    public partial class TribMunicipal : IEquatable<TribMunicipal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TribMunicipal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TribMunicipal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TribMunicipal" /> class.
        /// </summary>
        /// <param name="tribISSQN">Tributação do ISSQN sobre o serviço prestado:  * 1 - Operação tributável  * 2 - Exportação de serviço  * 3 - Não Incidência  * 4 - Imunidade (required).</param>
        /// <param name="cLocIncid">Código do município de incidência do ISSQN (tabela do IBGE).    Caso o envio seja pelo Sistema Nacional NFS-e, essa propriedade é ignorada e o município de incidência do ISSQN é determinado automaticamente pela SEFIN nacional, conforme regras do aspecto espacial da lei complementar federal (LC 116/03) que são válidas para todos os municípios..</param>
        /// <param name="cPaisResult">Código do país onde se verficou o resultado da prestação do serviço para o caso de Exportação de Serviço.(Tabela de Países ISO)..</param>
        /// <param name="bM">bM.</param>
        /// <param name="exigSusp">exigSusp.</param>
        /// <param name="tpImunidade">Identificação da Imunidade do ISSQN - somente para o caso de Imunidade:  * 0 - Imunidade (tipo não informado na nota de origem)  * 1 - Patrimônio, renda ou serviços, uns dos outros (CF88, Art 150, VI, a)  * 2 - Templos de qualquer culto (CF88, Art 150, VI, b)  * 3 - Patrimônio, renda ou serviços dos partidos políticos, inclusive suas fundações, das entidades sindicais dos trabalhadores, das instituições de educação e de assistência social, sem fins lucrativos, atendidos os requisitos da lei (CF88, Art 150, VI, c)  * 4 - Livros, jornais, periódicos e o papel destinado a sua impressão (CF88, Art 150, VI, d).</param>
        /// <param name="pAliq">Valor da alíquota (%%) do serviço prestado relativo ao município sujeito ativo (município de incidência) do ISSQN.  Se o município de incidência pertence ao Sistema Nacional NFS-e a alíquota estará parametrizada e, portanto, será fornecida pelo sistema.  Se o município de incidência não pertence ao Sistema Nacional NFS-e a alíquota não estará parametrizada e, por isso, deverá ser fornecida pelo emitente..</param>
        /// <param name="tpRetISSQN">Tipo de retencao do ISSQN:  * 1 - Não Retido  * 2 - Retido pelo Tomador  * 3 - Retido pelo Intermediario.</param>
        public TribMunicipal(int tribISSQN = default(int), string cLocIncid = default(string), string cPaisResult = default(string), BeneficioMunicipal bM = default(BeneficioMunicipal), ExigSuspensa exigSusp = default(ExigSuspensa), int tpImunidade = default(int), decimal pAliq = default(decimal), int tpRetISSQN = default(int))
        {
            this.tribISSQN = tribISSQN;
            this.cLocIncid = cLocIncid;
            this.cPaisResult = cPaisResult;
            this.BM = bM;
            this.exigSusp = exigSusp;
            this.tpImunidade = tpImunidade;
            this.pAliq = pAliq;
            this.tpRetISSQN = tpRetISSQN;
        }

        /// <summary>
        /// Tributação do ISSQN sobre o serviço prestado:  * 1 - Operação tributável  * 2 - Exportação de serviço  * 3 - Não Incidência  * 4 - Imunidade
        /// </summary>
        /// <value>Tributação do ISSQN sobre o serviço prestado:  * 1 - Operação tributável  * 2 - Exportação de serviço  * 3 - Não Incidência  * 4 - Imunidade</value>
        [DataMember(Name = "tribISSQN", IsRequired = true, EmitDefaultValue = true)]
        public int tribISSQN { get; set; }

        /// <summary>
        /// Código do município de incidência do ISSQN (tabela do IBGE).    Caso o envio seja pelo Sistema Nacional NFS-e, essa propriedade é ignorada e o município de incidência do ISSQN é determinado automaticamente pela SEFIN nacional, conforme regras do aspecto espacial da lei complementar federal (LC 116/03) que são válidas para todos os municípios.
        /// </summary>
        /// <value>Código do município de incidência do ISSQN (tabela do IBGE).    Caso o envio seja pelo Sistema Nacional NFS-e, essa propriedade é ignorada e o município de incidência do ISSQN é determinado automaticamente pela SEFIN nacional, conforme regras do aspecto espacial da lei complementar federal (LC 116/03) que são válidas para todos os municípios.</value>
        [DataMember(Name = "cLocIncid", EmitDefaultValue = false)]
        public string cLocIncid { get; set; }

        /// <summary>
        /// Código do país onde se verficou o resultado da prestação do serviço para o caso de Exportação de Serviço.(Tabela de Países ISO).
        /// </summary>
        /// <value>Código do país onde se verficou o resultado da prestação do serviço para o caso de Exportação de Serviço.(Tabela de Países ISO).</value>
        [DataMember(Name = "cPaisResult", EmitDefaultValue = false)]
        public string cPaisResult { get; set; }

        /// <summary>
        /// Gets or Sets BM
        /// </summary>
        [DataMember(Name = "BM", EmitDefaultValue = false)]
        public BeneficioMunicipal BM { get; set; }

        /// <summary>
        /// Gets or Sets exigSusp
        /// </summary>
        [DataMember(Name = "exigSusp", EmitDefaultValue = false)]
        public ExigSuspensa exigSusp { get; set; }

        /// <summary>
        /// Identificação da Imunidade do ISSQN - somente para o caso de Imunidade:  * 0 - Imunidade (tipo não informado na nota de origem)  * 1 - Patrimônio, renda ou serviços, uns dos outros (CF88, Art 150, VI, a)  * 2 - Templos de qualquer culto (CF88, Art 150, VI, b)  * 3 - Patrimônio, renda ou serviços dos partidos políticos, inclusive suas fundações, das entidades sindicais dos trabalhadores, das instituições de educação e de assistência social, sem fins lucrativos, atendidos os requisitos da lei (CF88, Art 150, VI, c)  * 4 - Livros, jornais, periódicos e o papel destinado a sua impressão (CF88, Art 150, VI, d)
        /// </summary>
        /// <value>Identificação da Imunidade do ISSQN - somente para o caso de Imunidade:  * 0 - Imunidade (tipo não informado na nota de origem)  * 1 - Patrimônio, renda ou serviços, uns dos outros (CF88, Art 150, VI, a)  * 2 - Templos de qualquer culto (CF88, Art 150, VI, b)  * 3 - Patrimônio, renda ou serviços dos partidos políticos, inclusive suas fundações, das entidades sindicais dos trabalhadores, das instituições de educação e de assistência social, sem fins lucrativos, atendidos os requisitos da lei (CF88, Art 150, VI, c)  * 4 - Livros, jornais, periódicos e o papel destinado a sua impressão (CF88, Art 150, VI, d)</value>
        [DataMember(Name = "tpImunidade", EmitDefaultValue = false)]
        public int tpImunidade { get; set; }

        /// <summary>
        /// Valor da alíquota (%%) do serviço prestado relativo ao município sujeito ativo (município de incidência) do ISSQN.  Se o município de incidência pertence ao Sistema Nacional NFS-e a alíquota estará parametrizada e, portanto, será fornecida pelo sistema.  Se o município de incidência não pertence ao Sistema Nacional NFS-e a alíquota não estará parametrizada e, por isso, deverá ser fornecida pelo emitente.
        /// </summary>
        /// <value>Valor da alíquota (%%) do serviço prestado relativo ao município sujeito ativo (município de incidência) do ISSQN.  Se o município de incidência pertence ao Sistema Nacional NFS-e a alíquota estará parametrizada e, portanto, será fornecida pelo sistema.  Se o município de incidência não pertence ao Sistema Nacional NFS-e a alíquota não estará parametrizada e, por isso, deverá ser fornecida pelo emitente.</value>
        [DataMember(Name = "pAliq", EmitDefaultValue = false)]
        public decimal pAliq { get; set; }

        /// <summary>
        /// Tipo de retencao do ISSQN:  * 1 - Não Retido  * 2 - Retido pelo Tomador  * 3 - Retido pelo Intermediario
        /// </summary>
        /// <value>Tipo de retencao do ISSQN:  * 1 - Não Retido  * 2 - Retido pelo Tomador  * 3 - Retido pelo Intermediario</value>
        [DataMember(Name = "tpRetISSQN", EmitDefaultValue = false)]
        public int tpRetISSQN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TribMunicipal {\n");
            sb.Append("  tribISSQN: ").Append(tribISSQN).Append("\n");
            sb.Append("  cLocIncid: ").Append(cLocIncid).Append("\n");
            sb.Append("  cPaisResult: ").Append(cPaisResult).Append("\n");
            sb.Append("  BM: ").Append(BM).Append("\n");
            sb.Append("  exigSusp: ").Append(exigSusp).Append("\n");
            sb.Append("  tpImunidade: ").Append(tpImunidade).Append("\n");
            sb.Append("  pAliq: ").Append(pAliq).Append("\n");
            sb.Append("  tpRetISSQN: ").Append(tpRetISSQN).Append("\n");
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
            return this.Equals(input as TribMunicipal);
        }

        /// <summary>
        /// Returns true if TribMunicipal instances are equal
        /// </summary>
        /// <param name="input">Instance of TribMunicipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TribMunicipal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tribISSQN == input.tribISSQN ||
                    this.tribISSQN.Equals(input.tribISSQN)
                ) && 
                (
                    this.cLocIncid == input.cLocIncid ||
                    (this.cLocIncid != null &&
                    this.cLocIncid.Equals(input.cLocIncid))
                ) && 
                (
                    this.cPaisResult == input.cPaisResult ||
                    (this.cPaisResult != null &&
                    this.cPaisResult.Equals(input.cPaisResult))
                ) && 
                (
                    this.BM == input.BM ||
                    (this.BM != null &&
                    this.BM.Equals(input.BM))
                ) && 
                (
                    this.exigSusp == input.exigSusp ||
                    (this.exigSusp != null &&
                    this.exigSusp.Equals(input.exigSusp))
                ) && 
                (
                    this.tpImunidade == input.tpImunidade ||
                    this.tpImunidade.Equals(input.tpImunidade)
                ) && 
                (
                    this.pAliq == input.pAliq ||
                    this.pAliq.Equals(input.pAliq)
                ) && 
                (
                    this.tpRetISSQN == input.tpRetISSQN ||
                    this.tpRetISSQN.Equals(input.tpRetISSQN)
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
                hashCode = (hashCode * 59) + this.tribISSQN.GetHashCode();
                if (this.cLocIncid != null)
                {
                    hashCode = (hashCode * 59) + this.cLocIncid.GetHashCode();
                }
                if (this.cPaisResult != null)
                {
                    hashCode = (hashCode * 59) + this.cPaisResult.GetHashCode();
                }
                if (this.BM != null)
                {
                    hashCode = (hashCode * 59) + this.BM.GetHashCode();
                }
                if (this.exigSusp != null)
                {
                    hashCode = (hashCode * 59) + this.exigSusp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpImunidade.GetHashCode();
                hashCode = (hashCode * 59) + this.pAliq.GetHashCode();
                hashCode = (hashCode * 59) + this.tpRetISSQN.GetHashCode();
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
