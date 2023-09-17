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
    /// Identificação do MDF-e.
    /// </summary>
    [DataContract(Name = "MdfeSefazIde")]
    public partial class MdfeSefazIde : IEquatable<MdfeSefazIde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazIde" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazIde() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazIde" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF do emitente do MDF-e.  Código da UF do emitente do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação. (required).</param>
        /// <param name="tpAmb">Tipo do Ambiente.  * 1 - Produção  * 2 - Homologação.</param>
        /// <param name="tpEmit">Tipo do Emitente.  * 1 - Prestador de serviço de transporte  * 2 - Transportador de Carga Própria 3 - Prestador de serviço de transporte que emitirá CT-e Globalizado  OBS: Deve ser preenchido com 2 para emitentes de NF-e e pelas transportadoras quando estiverem fazendo transporte de carga própria. Deve ser preenchido com 3 para transportador de carga que emitirá à posteriori CT-e Globalizado relacionando as NF-e. (required).</param>
        /// <param name="tpTransp">Tipo do Transportador.  * 1 - ETC  * 2 - TAC  * 3 - CTC.</param>
        /// <param name="mod">Modelo do Manifesto Eletrônico.  Utilizar o código 58 para identificação do MDF-e..</param>
        /// <param name="serie">Série do Manifesto.  Informar a série do documento fiscal (informar zero se inexistente).  Série na faixa [920-969]: Reservada para emissão por contribuinte pessoa física com inscrição estadual. (required).</param>
        /// <param name="nMDF">Número do Manifesto.  Número que identifica o Manifesto. 1 a 999999999. (required).</param>
        /// <param name="cMDF">Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="cDV">Digito verificador da chave de acesso do Manifesto.  Informar o dígito  de controle da chave de acesso do MDF-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="modal">Modalidade de transporte.  * 1 - Rodoviário  * 2 - Aéreo  * 3 - Aquaviário  * 4 - Ferroviário (required).</param>
        /// <param name="dhEmi">Data e hora de emissão do Manifesto.  Formato AAAA-MM-DDTHH:MM:DD TZD. (required).</param>
        /// <param name="tpEmis">Forma de emissão do Manifesto.  * 1 - Normal  * 2 - Contingência  * 3 - Regime Especial NFF (required).</param>
        /// <param name="procEmi">Identificação do processo de emissão do Manifesto.  * 0 - emissão de MDF-e com aplicativo do contribuinte (required).</param>
        /// <param name="verProc">Versão do processo de emissão.  Informar a versão do aplicativo emissor de MDF-e. (required).</param>
        /// <param name="uFIni">Sigla da UF do Carregamento.  Utilizar a Tabela do IBGE de código de unidades da federação.  Informar &#39;EX&#39; para operações com o exterior. (required).</param>
        /// <param name="uFFim">Sigla da UF do Descarregamento.  Utilizar a Tabela do IBGE de código de unidades da federação.  Informar &#39;EX&#39; para operações com o exterior. (required).</param>
        /// <param name="infMunCarrega">infMunCarrega (required).</param>
        /// <param name="infPercurso">infPercurso.</param>
        /// <param name="dhIniViagem">Data e hora previstos de inicio da viagem.  Formato AAAA-MM-DDTHH:MM:DD TZD..</param>
        /// <param name="indCanalVerde">Indicador de participação do Canal Verde..</param>
        /// <param name="indCarregaPosterior">Indicador de MDF-e com inclusão da Carga posterior a emissão por evento de inclusão de DF-e..</param>
        public MdfeSefazIde(int? cUF = default(int?), int? tpAmb = default(int?), int? tpEmit = default(int?), int? tpTransp = default(int?), int? mod = default(int?), int? serie = default(int?), int? nMDF = default(int?), string cMDF = default(string), int? cDV = default(int?), int? modal = default(int?), DateTime? dhEmi = default(DateTime?), int? tpEmis = default(int?), string procEmi = default(string), string verProc = default(string), string uFIni = default(string), string uFFim = default(string), List<MdfeSefazInfMunCarrega> infMunCarrega = default(List<MdfeSefazInfMunCarrega>), List<MdfeSefazInfPercurso> infPercurso = default(List<MdfeSefazInfPercurso>), DateTime? dhIniViagem = default(DateTime?), int? indCanalVerde = default(int?), int? indCarregaPosterior = default(int?))
        {
            // to ensure "cUF" is required (not null)
            if (cUF == null)
            {
                throw new ArgumentNullException("cUF is a required property for MdfeSefazIde and cannot be null");
            }
            this.cUF = cUF;
            // to ensure "tpEmit" is required (not null)
            if (tpEmit == null)
            {
                throw new ArgumentNullException("tpEmit is a required property for MdfeSefazIde and cannot be null");
            }
            this.tpEmit = tpEmit;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for MdfeSefazIde and cannot be null");
            }
            this.serie = serie;
            // to ensure "nMDF" is required (not null)
            if (nMDF == null)
            {
                throw new ArgumentNullException("nMDF is a required property for MdfeSefazIde and cannot be null");
            }
            this.nMDF = nMDF;
            // to ensure "modal" is required (not null)
            if (modal == null)
            {
                throw new ArgumentNullException("modal is a required property for MdfeSefazIde and cannot be null");
            }
            this.modal = modal;
            // to ensure "dhEmi" is required (not null)
            if (dhEmi == null)
            {
                throw new ArgumentNullException("dhEmi is a required property for MdfeSefazIde and cannot be null");
            }
            this.dhEmi = dhEmi;
            // to ensure "tpEmis" is required (not null)
            if (tpEmis == null)
            {
                throw new ArgumentNullException("tpEmis is a required property for MdfeSefazIde and cannot be null");
            }
            this.tpEmis = tpEmis;
            // to ensure "procEmi" is required (not null)
            if (procEmi == null)
            {
                throw new ArgumentNullException("procEmi is a required property for MdfeSefazIde and cannot be null");
            }
            this.procEmi = procEmi;
            // to ensure "verProc" is required (not null)
            if (verProc == null)
            {
                throw new ArgumentNullException("verProc is a required property for MdfeSefazIde and cannot be null");
            }
            this.verProc = verProc;
            // to ensure "uFIni" is required (not null)
            if (uFIni == null)
            {
                throw new ArgumentNullException("uFIni is a required property for MdfeSefazIde and cannot be null");
            }
            this.UFIni = uFIni;
            // to ensure "uFFim" is required (not null)
            if (uFFim == null)
            {
                throw new ArgumentNullException("uFFim is a required property for MdfeSefazIde and cannot be null");
            }
            this.UFFim = uFFim;
            // to ensure "infMunCarrega" is required (not null)
            if (infMunCarrega == null)
            {
                throw new ArgumentNullException("infMunCarrega is a required property for MdfeSefazIde and cannot be null");
            }
            this.infMunCarrega = infMunCarrega;
            this.tpAmb = tpAmb;
            this.tpTransp = tpTransp;
            this.mod = mod;
            this.cMDF = cMDF;
            this.cDV = cDV;
            this.infPercurso = infPercurso;
            this.dhIniViagem = dhIniViagem;
            this.indCanalVerde = indCanalVerde;
            this.indCarregaPosterior = indCarregaPosterior;
        }

        /// <summary>
        /// Código da UF do emitente do MDF-e.  Código da UF do emitente do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação.
        /// </summary>
        /// <value>Código da UF do emitente do MDF-e.  Código da UF do emitente do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação.</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// Tipo do Ambiente.  * 1 - Produção  * 2 - Homologação
        /// </summary>
        /// <value>Tipo do Ambiente.  * 1 - Produção  * 2 - Homologação</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = true)]
        public int? tpAmb { get; set; }

        /// <summary>
        /// Tipo do Emitente.  * 1 - Prestador de serviço de transporte  * 2 - Transportador de Carga Própria 3 - Prestador de serviço de transporte que emitirá CT-e Globalizado  OBS: Deve ser preenchido com 2 para emitentes de NF-e e pelas transportadoras quando estiverem fazendo transporte de carga própria. Deve ser preenchido com 3 para transportador de carga que emitirá à posteriori CT-e Globalizado relacionando as NF-e.
        /// </summary>
        /// <value>Tipo do Emitente.  * 1 - Prestador de serviço de transporte  * 2 - Transportador de Carga Própria 3 - Prestador de serviço de transporte que emitirá CT-e Globalizado  OBS: Deve ser preenchido com 2 para emitentes de NF-e e pelas transportadoras quando estiverem fazendo transporte de carga própria. Deve ser preenchido com 3 para transportador de carga que emitirá à posteriori CT-e Globalizado relacionando as NF-e.</value>
        [DataMember(Name = "tpEmit", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEmit { get; set; }

        /// <summary>
        /// Tipo do Transportador.  * 1 - ETC  * 2 - TAC  * 3 - CTC
        /// </summary>
        /// <value>Tipo do Transportador.  * 1 - ETC  * 2 - TAC  * 3 - CTC</value>
        [DataMember(Name = "tpTransp", EmitDefaultValue = true)]
        public int? tpTransp { get; set; }

        /// <summary>
        /// Modelo do Manifesto Eletrônico.  Utilizar o código 58 para identificação do MDF-e.
        /// </summary>
        /// <value>Modelo do Manifesto Eletrônico.  Utilizar o código 58 para identificação do MDF-e.</value>
        [DataMember(Name = "mod", EmitDefaultValue = true)]
        public int? mod { get; set; }

        /// <summary>
        /// Série do Manifesto.  Informar a série do documento fiscal (informar zero se inexistente).  Série na faixa [920-969]: Reservada para emissão por contribuinte pessoa física com inscrição estadual.
        /// </summary>
        /// <value>Série do Manifesto.  Informar a série do documento fiscal (informar zero se inexistente).  Série na faixa [920-969]: Reservada para emissão por contribuinte pessoa física com inscrição estadual.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int? serie { get; set; }

        /// <summary>
        /// Número do Manifesto.  Número que identifica o Manifesto. 1 a 999999999.
        /// </summary>
        /// <value>Número do Manifesto.  Número que identifica o Manifesto. 1 a 999999999.</value>
        [DataMember(Name = "nMDF", IsRequired = true, EmitDefaultValue = true)]
        public int? nMDF { get; set; }

        /// <summary>
        /// Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cMDF", EmitDefaultValue = true)]
        public string cMDF { get; set; }

        /// <summary>
        /// Digito verificador da chave de acesso do Manifesto.  Informar o dígito  de controle da chave de acesso do MDF-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Digito verificador da chave de acesso do Manifesto.  Informar o dígito  de controle da chave de acesso do MDF-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cDV", EmitDefaultValue = true)]
        public int? cDV { get; set; }

        /// <summary>
        /// Modalidade de transporte.  * 1 - Rodoviário  * 2 - Aéreo  * 3 - Aquaviário  * 4 - Ferroviário
        /// </summary>
        /// <value>Modalidade de transporte.  * 1 - Rodoviário  * 2 - Aéreo  * 3 - Aquaviário  * 4 - Ferroviário</value>
        [DataMember(Name = "modal", IsRequired = true, EmitDefaultValue = true)]
        public int? modal { get; set; }

        /// <summary>
        /// Data e hora de emissão do Manifesto.  Formato AAAA-MM-DDTHH:MM:DD TZD.
        /// </summary>
        /// <value>Data e hora de emissão do Manifesto.  Formato AAAA-MM-DDTHH:MM:DD TZD.</value>
        [DataMember(Name = "dhEmi", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? dhEmi { get; set; }

        /// <summary>
        /// Forma de emissão do Manifesto.  * 1 - Normal  * 2 - Contingência  * 3 - Regime Especial NFF
        /// </summary>
        /// <value>Forma de emissão do Manifesto.  * 1 - Normal  * 2 - Contingência  * 3 - Regime Especial NFF</value>
        [DataMember(Name = "tpEmis", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEmis { get; set; }

        /// <summary>
        /// Identificação do processo de emissão do Manifesto.  * 0 - emissão de MDF-e com aplicativo do contribuinte
        /// </summary>
        /// <value>Identificação do processo de emissão do Manifesto.  * 0 - emissão de MDF-e com aplicativo do contribuinte</value>
        [DataMember(Name = "procEmi", IsRequired = true, EmitDefaultValue = true)]
        public string procEmi { get; set; }

        /// <summary>
        /// Versão do processo de emissão.  Informar a versão do aplicativo emissor de MDF-e.
        /// </summary>
        /// <value>Versão do processo de emissão.  Informar a versão do aplicativo emissor de MDF-e.</value>
        [DataMember(Name = "verProc", IsRequired = true, EmitDefaultValue = true)]
        public string verProc { get; set; }

        /// <summary>
        /// Sigla da UF do Carregamento.  Utilizar a Tabela do IBGE de código de unidades da federação.  Informar &#39;EX&#39; para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF do Carregamento.  Utilizar a Tabela do IBGE de código de unidades da federação.  Informar &#39;EX&#39; para operações com o exterior.</value>
        [DataMember(Name = "UFIni", IsRequired = true, EmitDefaultValue = true)]
        public string UFIni { get; set; }

        /// <summary>
        /// Sigla da UF do Descarregamento.  Utilizar a Tabela do IBGE de código de unidades da federação.  Informar &#39;EX&#39; para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF do Descarregamento.  Utilizar a Tabela do IBGE de código de unidades da federação.  Informar &#39;EX&#39; para operações com o exterior.</value>
        [DataMember(Name = "UFFim", IsRequired = true, EmitDefaultValue = true)]
        public string UFFim { get; set; }

        /// <summary>
        /// Gets or Sets infMunCarrega
        /// </summary>
        [DataMember(Name = "infMunCarrega", IsRequired = true, EmitDefaultValue = true)]
        public List<MdfeSefazInfMunCarrega> infMunCarrega { get; set; }

        /// <summary>
        /// Gets or Sets infPercurso
        /// </summary>
        [DataMember(Name = "infPercurso", EmitDefaultValue = false)]
        public List<MdfeSefazInfPercurso> infPercurso { get; set; }

        /// <summary>
        /// Data e hora previstos de inicio da viagem.  Formato AAAA-MM-DDTHH:MM:DD TZD.
        /// </summary>
        /// <value>Data e hora previstos de inicio da viagem.  Formato AAAA-MM-DDTHH:MM:DD TZD.</value>
        [DataMember(Name = "dhIniViagem", EmitDefaultValue = true)]
        public DateTime? dhIniViagem { get; set; }

        /// <summary>
        /// Indicador de participação do Canal Verde.
        /// </summary>
        /// <value>Indicador de participação do Canal Verde.</value>
        [DataMember(Name = "indCanalVerde", EmitDefaultValue = true)]
        public int? indCanalVerde { get; set; }

        /// <summary>
        /// Indicador de MDF-e com inclusão da Carga posterior a emissão por evento de inclusão de DF-e.
        /// </summary>
        /// <value>Indicador de MDF-e com inclusão da Carga posterior a emissão por evento de inclusão de DF-e.</value>
        [DataMember(Name = "indCarregaPosterior", EmitDefaultValue = true)]
        public int? indCarregaPosterior { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazIde {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  tpEmit: ").Append(tpEmit).Append("\n");
            sb.Append("  tpTransp: ").Append(tpTransp).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nMDF: ").Append(nMDF).Append("\n");
            sb.Append("  cMDF: ").Append(cMDF).Append("\n");
            sb.Append("  cDV: ").Append(cDV).Append("\n");
            sb.Append("  modal: ").Append(modal).Append("\n");
            sb.Append("  dhEmi: ").Append(dhEmi).Append("\n");
            sb.Append("  tpEmis: ").Append(tpEmis).Append("\n");
            sb.Append("  procEmi: ").Append(procEmi).Append("\n");
            sb.Append("  verProc: ").Append(verProc).Append("\n");
            sb.Append("  UFIni: ").Append(UFIni).Append("\n");
            sb.Append("  UFFim: ").Append(UFFim).Append("\n");
            sb.Append("  infMunCarrega: ").Append(infMunCarrega).Append("\n");
            sb.Append("  infPercurso: ").Append(infPercurso).Append("\n");
            sb.Append("  dhIniViagem: ").Append(dhIniViagem).Append("\n");
            sb.Append("  indCanalVerde: ").Append(indCanalVerde).Append("\n");
            sb.Append("  indCarregaPosterior: ").Append(indCarregaPosterior).Append("\n");
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
            return this.Equals(input as MdfeSefazIde);
        }

        /// <summary>
        /// Returns true if MdfeSefazIde instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazIde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazIde input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cUF == input.cUF ||
                    (this.cUF != null &&
                    this.cUF.Equals(input.cUF))
                ) && 
                (
                    this.tpAmb == input.tpAmb ||
                    (this.tpAmb != null &&
                    this.tpAmb.Equals(input.tpAmb))
                ) && 
                (
                    this.tpEmit == input.tpEmit ||
                    (this.tpEmit != null &&
                    this.tpEmit.Equals(input.tpEmit))
                ) && 
                (
                    this.tpTransp == input.tpTransp ||
                    (this.tpTransp != null &&
                    this.tpTransp.Equals(input.tpTransp))
                ) && 
                (
                    this.mod == input.mod ||
                    (this.mod != null &&
                    this.mod.Equals(input.mod))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.nMDF == input.nMDF ||
                    (this.nMDF != null &&
                    this.nMDF.Equals(input.nMDF))
                ) && 
                (
                    this.cMDF == input.cMDF ||
                    (this.cMDF != null &&
                    this.cMDF.Equals(input.cMDF))
                ) && 
                (
                    this.cDV == input.cDV ||
                    (this.cDV != null &&
                    this.cDV.Equals(input.cDV))
                ) && 
                (
                    this.modal == input.modal ||
                    (this.modal != null &&
                    this.modal.Equals(input.modal))
                ) && 
                (
                    this.dhEmi == input.dhEmi ||
                    (this.dhEmi != null &&
                    this.dhEmi.Equals(input.dhEmi))
                ) && 
                (
                    this.tpEmis == input.tpEmis ||
                    (this.tpEmis != null &&
                    this.tpEmis.Equals(input.tpEmis))
                ) && 
                (
                    this.procEmi == input.procEmi ||
                    (this.procEmi != null &&
                    this.procEmi.Equals(input.procEmi))
                ) && 
                (
                    this.verProc == input.verProc ||
                    (this.verProc != null &&
                    this.verProc.Equals(input.verProc))
                ) && 
                (
                    this.UFIni == input.UFIni ||
                    (this.UFIni != null &&
                    this.UFIni.Equals(input.UFIni))
                ) && 
                (
                    this.UFFim == input.UFFim ||
                    (this.UFFim != null &&
                    this.UFFim.Equals(input.UFFim))
                ) && 
                (
                    this.infMunCarrega == input.infMunCarrega ||
                    this.infMunCarrega != null &&
                    input.infMunCarrega != null &&
                    this.infMunCarrega.SequenceEqual(input.infMunCarrega)
                ) && 
                (
                    this.infPercurso == input.infPercurso ||
                    this.infPercurso != null &&
                    input.infPercurso != null &&
                    this.infPercurso.SequenceEqual(input.infPercurso)
                ) && 
                (
                    this.dhIniViagem == input.dhIniViagem ||
                    (this.dhIniViagem != null &&
                    this.dhIniViagem.Equals(input.dhIniViagem))
                ) && 
                (
                    this.indCanalVerde == input.indCanalVerde ||
                    (this.indCanalVerde != null &&
                    this.indCanalVerde.Equals(input.indCanalVerde))
                ) && 
                (
                    this.indCarregaPosterior == input.indCarregaPosterior ||
                    (this.indCarregaPosterior != null &&
                    this.indCarregaPosterior.Equals(input.indCarregaPosterior))
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
                if (this.cUF != null)
                {
                    hashCode = (hashCode * 59) + this.cUF.GetHashCode();
                }
                if (this.tpAmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                }
                if (this.tpEmit != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmit.GetHashCode();
                }
                if (this.tpTransp != null)
                {
                    hashCode = (hashCode * 59) + this.tpTransp.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nMDF != null)
                {
                    hashCode = (hashCode * 59) + this.nMDF.GetHashCode();
                }
                if (this.cMDF != null)
                {
                    hashCode = (hashCode * 59) + this.cMDF.GetHashCode();
                }
                if (this.cDV != null)
                {
                    hashCode = (hashCode * 59) + this.cDV.GetHashCode();
                }
                if (this.modal != null)
                {
                    hashCode = (hashCode * 59) + this.modal.GetHashCode();
                }
                if (this.dhEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dhEmi.GetHashCode();
                }
                if (this.tpEmis != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmis.GetHashCode();
                }
                if (this.procEmi != null)
                {
                    hashCode = (hashCode * 59) + this.procEmi.GetHashCode();
                }
                if (this.verProc != null)
                {
                    hashCode = (hashCode * 59) + this.verProc.GetHashCode();
                }
                if (this.UFIni != null)
                {
                    hashCode = (hashCode * 59) + this.UFIni.GetHashCode();
                }
                if (this.UFFim != null)
                {
                    hashCode = (hashCode * 59) + this.UFFim.GetHashCode();
                }
                if (this.infMunCarrega != null)
                {
                    hashCode = (hashCode * 59) + this.infMunCarrega.GetHashCode();
                }
                if (this.infPercurso != null)
                {
                    hashCode = (hashCode * 59) + this.infPercurso.GetHashCode();
                }
                if (this.dhIniViagem != null)
                {
                    hashCode = (hashCode * 59) + this.dhIniViagem.GetHashCode();
                }
                if (this.indCanalVerde != null)
                {
                    hashCode = (hashCode * 59) + this.indCanalVerde.GetHashCode();
                }
                if (this.indCarregaPosterior != null)
                {
                    hashCode = (hashCode * 59) + this.indCarregaPosterior.GetHashCode();
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
