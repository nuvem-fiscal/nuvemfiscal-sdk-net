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
    /// NfeSefazIde
    /// </summary>
    [DataContract(Name = "NfeSefazIde")]
    public partial class NfeSefazIde : IEquatable<NfeSefazIde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIde" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazIde() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIde" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE. (required).</param>
        /// <param name="cNF">Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e. (required).</param>
        /// <param name="natOp">Descrição da Natureza da Operação. (required).</param>
        /// <param name="mod">Código do modelo do Documento Fiscal. 55 &#x3D; NF-e; 65 &#x3D; NFC-e..</param>
        /// <param name="serie">Série do Documento Fiscal  série normal 0-889  Avulsa Fisco 890-899  SCAN 900-999. (required).</param>
        /// <param name="nNF">Número do Documento Fiscal. (required).</param>
        /// <param name="dhEmi">Data e Hora de emissão do Documento Fiscal (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00. (required).</param>
        /// <param name="dhSaiEnt">Data e Hora da saída ou de entrada da mercadoria / produto (AAAA-MM-DDTHH:mm:ssTZD)..</param>
        /// <param name="tpNF">Tipo do Documento Fiscal (0 - entrada; 1 - saída). (required).</param>
        /// <param name="idDest">Identificador de Local de destino da operação (1-Interna;2-Interestadual;3-Exterior). (required).</param>
        /// <param name="cMunFG">Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE). (required).</param>
        /// <param name="tpImp">Formato de impressão do DANFE (0-sem DANFE;1-DANFe Retrato; 2-DANFe Paisagem;3-DANFe Simplificado;             4-DANFe NFC-e;5-DANFe NFC-e em mensagem eletrônica). (required).</param>
        /// <param name="tpEmis">Forma de emissão da NF-e  1 - Normal;  2 - Contingência FS  3 - Regime Especial NFF (NT 2021.002)  4 - Contingência DPEC  5 - Contingência FSDA  6 - Contingência SVC - AN  7 - Contingência SVC - RS  9 - Contingência off-line NFC-e. (required).</param>
        /// <param name="cDV">Digito Verificador da Chave de Acesso da NF-e. (required).</param>
        /// <param name="tpAmb">Identificação do Ambiente:  1 - Produção  2 - Homologação..</param>
        /// <param name="finNFe">Finalidade da emissão da NF-e:  1 - NFe normal  2 - NFe complementar  3 - NFe de ajuste  4 - Devolução/Retorno. (required).</param>
        /// <param name="indFinal">Indica operação com consumidor final (0-Não;1-Consumidor Final). (required).</param>
        /// <param name="indPres">Indicador de presença do comprador no estabelecimento comercial no momento da oepração             (0-Não se aplica (ex.: Nota Fiscal complementar ou de ajuste;1-Operação presencial;2-Não presencial, internet;3-Não presencial, teleatendimento;4-NFC-e entrega em domicílio;5-Operação presencial, fora do estabelecimento;9-Não presencial, outros). (required).</param>
        /// <param name="indIntermed">Indicador de intermediador/marketplace             0&#x3D;Operação sem intermediador (em site ou plataforma própria)             1&#x3D;Operação em site ou plataforma de terceiros (intermediadores/marketplace)..</param>
        /// <param name="procEmi">Processo de emissão utilizado com a seguinte codificação:  0 - emissão de NF-e com aplicativo do contribuinte;  1 - emissão de NF-e avulsa pelo Fisco;  2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site  do Fisco;  3- emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco. (required).</param>
        /// <param name="verProc">versão do aplicativo utilizado no processo de  emissão. (required).</param>
        /// <param name="dhCont">Informar a data e hora de entrada em contingência contingência no formato  (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00..</param>
        /// <param name="xJust">Informar a Justificativa da entrada..</param>
        /// <param name="nFref">Grupo de infromações da NF referenciada..</param>
        public NfeSefazIde(int cUF = default(int), int cNF = default(int), string natOp = default(string), int mod = default(int), int serie = default(int), int nNF = default(int), DateTime dhEmi = default(DateTime), DateTime dhSaiEnt = default(DateTime), int tpNF = default(int), int idDest = default(int), int cMunFG = default(int), int tpImp = default(int), int tpEmis = default(int), int cDV = default(int), int tpAmb = default(int), int finNFe = default(int), int indFinal = default(int), int indPres = default(int), int indIntermed = default(int), int procEmi = default(int), string verProc = default(string), DateTime dhCont = default(DateTime), string xJust = default(string), List<NfeSefazNFref> nFref = default(List<NfeSefazNFref>))
        {
            this.cUF = cUF;
            this.cNF = cNF;
            // to ensure "natOp" is required (not null)
            if (natOp == null)
            {
                throw new ArgumentNullException("natOp is a required property for NfeSefazIde and cannot be null");
            }
            this.natOp = natOp;
            this.serie = serie;
            this.nNF = nNF;
            this.dhEmi = dhEmi;
            this.tpNF = tpNF;
            this.idDest = idDest;
            this.cMunFG = cMunFG;
            this.tpImp = tpImp;
            this.tpEmis = tpEmis;
            this.cDV = cDV;
            this.finNFe = finNFe;
            this.indFinal = indFinal;
            this.indPres = indPres;
            this.procEmi = procEmi;
            // to ensure "verProc" is required (not null)
            if (verProc == null)
            {
                throw new ArgumentNullException("verProc is a required property for NfeSefazIde and cannot be null");
            }
            this.verProc = verProc;
            this.mod = mod;
            this.dhSaiEnt = dhSaiEnt;
            this.tpAmb = tpAmb;
            this.indIntermed = indIntermed;
            this.dhCont = dhCont;
            this.xJust = xJust;
            this.NFref = nFref;
        }

        /// <summary>
        /// Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.
        /// </summary>
        /// <value>Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int cUF { get; set; }

        /// <summary>
        /// Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e.
        /// </summary>
        /// <value>Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e.</value>
        [DataMember(Name = "cNF", IsRequired = true, EmitDefaultValue = true)]
        public int cNF { get; set; }

        /// <summary>
        /// Descrição da Natureza da Operação.
        /// </summary>
        /// <value>Descrição da Natureza da Operação.</value>
        [DataMember(Name = "natOp", IsRequired = true, EmitDefaultValue = true)]
        public string natOp { get; set; }

        /// <summary>
        /// Código do modelo do Documento Fiscal. 55 &#x3D; NF-e; 65 &#x3D; NFC-e.
        /// </summary>
        /// <value>Código do modelo do Documento Fiscal. 55 &#x3D; NF-e; 65 &#x3D; NFC-e.</value>
        [DataMember(Name = "mod", EmitDefaultValue = false)]
        public int mod { get; set; }

        /// <summary>
        /// Série do Documento Fiscal  série normal 0-889  Avulsa Fisco 890-899  SCAN 900-999.
        /// </summary>
        /// <value>Série do Documento Fiscal  série normal 0-889  Avulsa Fisco 890-899  SCAN 900-999.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int serie { get; set; }

        /// <summary>
        /// Número do Documento Fiscal.
        /// </summary>
        /// <value>Número do Documento Fiscal.</value>
        [DataMember(Name = "nNF", IsRequired = true, EmitDefaultValue = true)]
        public int nNF { get; set; }

        /// <summary>
        /// Data e Hora de emissão do Documento Fiscal (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00.
        /// </summary>
        /// <value>Data e Hora de emissão do Documento Fiscal (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00.</value>
        [DataMember(Name = "dhEmi", IsRequired = true, EmitDefaultValue = true)]
        public DateTime dhEmi { get; set; }

        /// <summary>
        /// Data e Hora da saída ou de entrada da mercadoria / produto (AAAA-MM-DDTHH:mm:ssTZD).
        /// </summary>
        /// <value>Data e Hora da saída ou de entrada da mercadoria / produto (AAAA-MM-DDTHH:mm:ssTZD).</value>
        [DataMember(Name = "dhSaiEnt", EmitDefaultValue = false)]
        public DateTime dhSaiEnt { get; set; }

        /// <summary>
        /// Tipo do Documento Fiscal (0 - entrada; 1 - saída).
        /// </summary>
        /// <value>Tipo do Documento Fiscal (0 - entrada; 1 - saída).</value>
        [DataMember(Name = "tpNF", IsRequired = true, EmitDefaultValue = true)]
        public int tpNF { get; set; }

        /// <summary>
        /// Identificador de Local de destino da operação (1-Interna;2-Interestadual;3-Exterior).
        /// </summary>
        /// <value>Identificador de Local de destino da operação (1-Interna;2-Interestadual;3-Exterior).</value>
        [DataMember(Name = "idDest", IsRequired = true, EmitDefaultValue = true)]
        public int idDest { get; set; }

        /// <summary>
        /// Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE).
        /// </summary>
        /// <value>Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE).</value>
        [DataMember(Name = "cMunFG", IsRequired = true, EmitDefaultValue = true)]
        public int cMunFG { get; set; }

        /// <summary>
        /// Formato de impressão do DANFE (0-sem DANFE;1-DANFe Retrato; 2-DANFe Paisagem;3-DANFe Simplificado;             4-DANFe NFC-e;5-DANFe NFC-e em mensagem eletrônica).
        /// </summary>
        /// <value>Formato de impressão do DANFE (0-sem DANFE;1-DANFe Retrato; 2-DANFe Paisagem;3-DANFe Simplificado;             4-DANFe NFC-e;5-DANFe NFC-e em mensagem eletrônica).</value>
        [DataMember(Name = "tpImp", IsRequired = true, EmitDefaultValue = true)]
        public int tpImp { get; set; }

        /// <summary>
        /// Forma de emissão da NF-e  1 - Normal;  2 - Contingência FS  3 - Regime Especial NFF (NT 2021.002)  4 - Contingência DPEC  5 - Contingência FSDA  6 - Contingência SVC - AN  7 - Contingência SVC - RS  9 - Contingência off-line NFC-e.
        /// </summary>
        /// <value>Forma de emissão da NF-e  1 - Normal;  2 - Contingência FS  3 - Regime Especial NFF (NT 2021.002)  4 - Contingência DPEC  5 - Contingência FSDA  6 - Contingência SVC - AN  7 - Contingência SVC - RS  9 - Contingência off-line NFC-e.</value>
        [DataMember(Name = "tpEmis", IsRequired = true, EmitDefaultValue = true)]
        public int tpEmis { get; set; }

        /// <summary>
        /// Digito Verificador da Chave de Acesso da NF-e.
        /// </summary>
        /// <value>Digito Verificador da Chave de Acesso da NF-e.</value>
        [DataMember(Name = "cDV", IsRequired = true, EmitDefaultValue = true)]
        public int cDV { get; set; }

        /// <summary>
        /// Identificação do Ambiente:  1 - Produção  2 - Homologação.
        /// </summary>
        /// <value>Identificação do Ambiente:  1 - Produção  2 - Homologação.</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = false)]
        public int tpAmb { get; set; }

        /// <summary>
        /// Finalidade da emissão da NF-e:  1 - NFe normal  2 - NFe complementar  3 - NFe de ajuste  4 - Devolução/Retorno.
        /// </summary>
        /// <value>Finalidade da emissão da NF-e:  1 - NFe normal  2 - NFe complementar  3 - NFe de ajuste  4 - Devolução/Retorno.</value>
        [DataMember(Name = "finNFe", IsRequired = true, EmitDefaultValue = true)]
        public int finNFe { get; set; }

        /// <summary>
        /// Indica operação com consumidor final (0-Não;1-Consumidor Final).
        /// </summary>
        /// <value>Indica operação com consumidor final (0-Não;1-Consumidor Final).</value>
        [DataMember(Name = "indFinal", IsRequired = true, EmitDefaultValue = true)]
        public int indFinal { get; set; }

        /// <summary>
        /// Indicador de presença do comprador no estabelecimento comercial no momento da oepração             (0-Não se aplica (ex.: Nota Fiscal complementar ou de ajuste;1-Operação presencial;2-Não presencial, internet;3-Não presencial, teleatendimento;4-NFC-e entrega em domicílio;5-Operação presencial, fora do estabelecimento;9-Não presencial, outros).
        /// </summary>
        /// <value>Indicador de presença do comprador no estabelecimento comercial no momento da oepração             (0-Não se aplica (ex.: Nota Fiscal complementar ou de ajuste;1-Operação presencial;2-Não presencial, internet;3-Não presencial, teleatendimento;4-NFC-e entrega em domicílio;5-Operação presencial, fora do estabelecimento;9-Não presencial, outros).</value>
        [DataMember(Name = "indPres", IsRequired = true, EmitDefaultValue = true)]
        public int indPres { get; set; }

        /// <summary>
        /// Indicador de intermediador/marketplace             0&#x3D;Operação sem intermediador (em site ou plataforma própria)             1&#x3D;Operação em site ou plataforma de terceiros (intermediadores/marketplace).
        /// </summary>
        /// <value>Indicador de intermediador/marketplace             0&#x3D;Operação sem intermediador (em site ou plataforma própria)             1&#x3D;Operação em site ou plataforma de terceiros (intermediadores/marketplace).</value>
        [DataMember(Name = "indIntermed", EmitDefaultValue = false)]
        public int indIntermed { get; set; }

        /// <summary>
        /// Processo de emissão utilizado com a seguinte codificação:  0 - emissão de NF-e com aplicativo do contribuinte;  1 - emissão de NF-e avulsa pelo Fisco;  2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site  do Fisco;  3- emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.
        /// </summary>
        /// <value>Processo de emissão utilizado com a seguinte codificação:  0 - emissão de NF-e com aplicativo do contribuinte;  1 - emissão de NF-e avulsa pelo Fisco;  2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site  do Fisco;  3- emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.</value>
        [DataMember(Name = "procEmi", IsRequired = true, EmitDefaultValue = true)]
        public int procEmi { get; set; }

        /// <summary>
        /// versão do aplicativo utilizado no processo de  emissão.
        /// </summary>
        /// <value>versão do aplicativo utilizado no processo de  emissão.</value>
        [DataMember(Name = "verProc", IsRequired = true, EmitDefaultValue = true)]
        public string verProc { get; set; }

        /// <summary>
        /// Informar a data e hora de entrada em contingência contingência no formato  (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00.
        /// </summary>
        /// <value>Informar a data e hora de entrada em contingência contingência no formato  (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00.</value>
        [DataMember(Name = "dhCont", EmitDefaultValue = false)]
        public DateTime dhCont { get; set; }

        /// <summary>
        /// Informar a Justificativa da entrada.
        /// </summary>
        /// <value>Informar a Justificativa da entrada.</value>
        [DataMember(Name = "xJust", EmitDefaultValue = false)]
        public string xJust { get; set; }

        /// <summary>
        /// Grupo de infromações da NF referenciada.
        /// </summary>
        /// <value>Grupo de infromações da NF referenciada.</value>
        [DataMember(Name = "NFref", EmitDefaultValue = false)]
        public List<NfeSefazNFref> NFref { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazIde {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  cNF: ").Append(cNF).Append("\n");
            sb.Append("  natOp: ").Append(natOp).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nNF: ").Append(nNF).Append("\n");
            sb.Append("  dhEmi: ").Append(dhEmi).Append("\n");
            sb.Append("  dhSaiEnt: ").Append(dhSaiEnt).Append("\n");
            sb.Append("  tpNF: ").Append(tpNF).Append("\n");
            sb.Append("  idDest: ").Append(idDest).Append("\n");
            sb.Append("  cMunFG: ").Append(cMunFG).Append("\n");
            sb.Append("  tpImp: ").Append(tpImp).Append("\n");
            sb.Append("  tpEmis: ").Append(tpEmis).Append("\n");
            sb.Append("  cDV: ").Append(cDV).Append("\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  finNFe: ").Append(finNFe).Append("\n");
            sb.Append("  indFinal: ").Append(indFinal).Append("\n");
            sb.Append("  indPres: ").Append(indPres).Append("\n");
            sb.Append("  indIntermed: ").Append(indIntermed).Append("\n");
            sb.Append("  procEmi: ").Append(procEmi).Append("\n");
            sb.Append("  verProc: ").Append(verProc).Append("\n");
            sb.Append("  dhCont: ").Append(dhCont).Append("\n");
            sb.Append("  xJust: ").Append(xJust).Append("\n");
            sb.Append("  NFref: ").Append(NFref).Append("\n");
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
            return this.Equals(input as NfeSefazIde);
        }

        /// <summary>
        /// Returns true if NfeSefazIde instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazIde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazIde input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cUF == input.cUF ||
                    this.cUF.Equals(input.cUF)
                ) && 
                (
                    this.cNF == input.cNF ||
                    this.cNF.Equals(input.cNF)
                ) && 
                (
                    this.natOp == input.natOp ||
                    (this.natOp != null &&
                    this.natOp.Equals(input.natOp))
                ) && 
                (
                    this.mod == input.mod ||
                    this.mod.Equals(input.mod)
                ) && 
                (
                    this.serie == input.serie ||
                    this.serie.Equals(input.serie)
                ) && 
                (
                    this.nNF == input.nNF ||
                    this.nNF.Equals(input.nNF)
                ) && 
                (
                    this.dhEmi == input.dhEmi ||
                    (this.dhEmi != null &&
                    this.dhEmi.Equals(input.dhEmi))
                ) && 
                (
                    this.dhSaiEnt == input.dhSaiEnt ||
                    (this.dhSaiEnt != null &&
                    this.dhSaiEnt.Equals(input.dhSaiEnt))
                ) && 
                (
                    this.tpNF == input.tpNF ||
                    this.tpNF.Equals(input.tpNF)
                ) && 
                (
                    this.idDest == input.idDest ||
                    this.idDest.Equals(input.idDest)
                ) && 
                (
                    this.cMunFG == input.cMunFG ||
                    this.cMunFG.Equals(input.cMunFG)
                ) && 
                (
                    this.tpImp == input.tpImp ||
                    this.tpImp.Equals(input.tpImp)
                ) && 
                (
                    this.tpEmis == input.tpEmis ||
                    this.tpEmis.Equals(input.tpEmis)
                ) && 
                (
                    this.cDV == input.cDV ||
                    this.cDV.Equals(input.cDV)
                ) && 
                (
                    this.tpAmb == input.tpAmb ||
                    this.tpAmb.Equals(input.tpAmb)
                ) && 
                (
                    this.finNFe == input.finNFe ||
                    this.finNFe.Equals(input.finNFe)
                ) && 
                (
                    this.indFinal == input.indFinal ||
                    this.indFinal.Equals(input.indFinal)
                ) && 
                (
                    this.indPres == input.indPres ||
                    this.indPres.Equals(input.indPres)
                ) && 
                (
                    this.indIntermed == input.indIntermed ||
                    this.indIntermed.Equals(input.indIntermed)
                ) && 
                (
                    this.procEmi == input.procEmi ||
                    this.procEmi.Equals(input.procEmi)
                ) && 
                (
                    this.verProc == input.verProc ||
                    (this.verProc != null &&
                    this.verProc.Equals(input.verProc))
                ) && 
                (
                    this.dhCont == input.dhCont ||
                    (this.dhCont != null &&
                    this.dhCont.Equals(input.dhCont))
                ) && 
                (
                    this.xJust == input.xJust ||
                    (this.xJust != null &&
                    this.xJust.Equals(input.xJust))
                ) && 
                (
                    this.NFref == input.NFref ||
                    this.NFref != null &&
                    input.NFref != null &&
                    this.NFref.SequenceEqual(input.NFref)
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
                hashCode = (hashCode * 59) + this.cUF.GetHashCode();
                hashCode = (hashCode * 59) + this.cNF.GetHashCode();
                if (this.natOp != null)
                {
                    hashCode = (hashCode * 59) + this.natOp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.mod.GetHashCode();
                hashCode = (hashCode * 59) + this.serie.GetHashCode();
                hashCode = (hashCode * 59) + this.nNF.GetHashCode();
                if (this.dhEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dhEmi.GetHashCode();
                }
                if (this.dhSaiEnt != null)
                {
                    hashCode = (hashCode * 59) + this.dhSaiEnt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpNF.GetHashCode();
                hashCode = (hashCode * 59) + this.idDest.GetHashCode();
                hashCode = (hashCode * 59) + this.cMunFG.GetHashCode();
                hashCode = (hashCode * 59) + this.tpImp.GetHashCode();
                hashCode = (hashCode * 59) + this.tpEmis.GetHashCode();
                hashCode = (hashCode * 59) + this.cDV.GetHashCode();
                hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                hashCode = (hashCode * 59) + this.finNFe.GetHashCode();
                hashCode = (hashCode * 59) + this.indFinal.GetHashCode();
                hashCode = (hashCode * 59) + this.indPres.GetHashCode();
                hashCode = (hashCode * 59) + this.indIntermed.GetHashCode();
                hashCode = (hashCode * 59) + this.procEmi.GetHashCode();
                if (this.verProc != null)
                {
                    hashCode = (hashCode * 59) + this.verProc.GetHashCode();
                }
                if (this.dhCont != null)
                {
                    hashCode = (hashCode * 59) + this.dhCont.GetHashCode();
                }
                if (this.xJust != null)
                {
                    hashCode = (hashCode * 59) + this.xJust.GetHashCode();
                }
                if (this.NFref != null)
                {
                    hashCode = (hashCode * 59) + this.NFref.GetHashCode();
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
