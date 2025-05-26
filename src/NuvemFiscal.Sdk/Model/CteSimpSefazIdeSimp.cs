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
    /// Identificação do CT-e.
    /// </summary>
    [DataContract(Name = "CteSimpSefazIdeSimp")]
    public partial class CteSimpSefazIdeSimp : IEquatable<CteSimpSefazIdeSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazIdeSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazIdeSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazIdeSimp" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF do emitente do CT-e.  Utilizar a Tabela do IBGE. (required).</param>
        /// <param name="cCT">Código numérico que compõe a Chave de Acesso.  Número aleatório gerado pelo emitente para cada CT-e, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="cFOP">Código Fiscal de Operações e Prestações. (required).</param>
        /// <param name="natOp">Natureza da Operação. (required).</param>
        /// <param name="mod">Modelo do documento fiscal.  Utilizar o código 57 para identificação do CT-e, emitido em substituição aos modelos de conhecimentos em papel..</param>
        /// <param name="serie">Série do CT-e.  Preencher com \&quot;0\&quot; no caso de série única. (required).</param>
        /// <param name="nCT">Número do CT-e. (required).</param>
        /// <param name="dhEmi">Data e hora de emissão do CT-e.  Formato AAAA-MM-DDTHH:MM:DD TZD. (required).</param>
        /// <param name="tpImp">Formato de impressão do DACTE:  * 1 - Retrato  * 2 - Paisagem (required).</param>
        /// <param name="tpEmis">Forma de emissão do CT-e.  Preencher com:  * 1 - Normal  * 3 - Regime Especial NFF  * 4 - EPEC pela SVC  * 7 - Autorização pela SVC-RS  * 8 - Autorização pela SVC-SP (required).</param>
        /// <param name="cDV">Digito Verificador da chave de acesso do CT-e.  Informar o dígito  de controle da chave de acesso do CT-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="tpAmb">Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação.</param>
        /// <param name="tpCTe">Tipo do CT-e Simplificado.  Preencher com:  * 5 - CTe Simplificado  * 6 - Substituição CTe Simplificado (required).</param>
        /// <param name="procEmi">Identificador do processo de emissão do CT-e.  Preencher com:  * 0 - emissão de CT-e com aplicativo do contribuinte  * 3 - emissão CT-e pelo contribuinte com aplicativo fornecido pelo SEBRAE (required).</param>
        /// <param name="verProc">Versão do processo de emissão.  Informar a versão do aplicativo emissor de CT-e. (required).</param>
        /// <param name="cMunEnv">Código do Município de envio do CT-e (de onde o documento foi transmitido).  Utilizar a tabela do IBGE. Informar 9999999 para as operações com o exterior. (required).</param>
        /// <param name="xMunEnv">Nome do Município de envio do CT-e (de onde o documento foi transmitido).  Informar PAIS/Municipio para as operações com o exterior. (required).</param>
        /// <param name="uFEnv">Sigla da UF de envio do CT-e (de onde o documento foi transmitido).  Informar &#39;EX&#39; para operações com o exterior. (required).</param>
        /// <param name="modal">Modal. Preencher com:  * 01 - Rodoviário  * 02 - Aéreo  * 03 - Aquaviário  * 04 - Ferroviário  * 05 - Dutoviário  * 06 - Multimodal (required).</param>
        /// <param name="tpServ">Tipo do Serviço.  Preencher com:  * 0 - Normal  * 1 - Subcontratação  * 2 - Redespacho (required).</param>
        /// <param name="uFIni">UF do início da prestação.  Informar &#39;EX&#39; para operações com o exterior. (required).</param>
        /// <param name="uFFim">UF do término da prestação.  Informar &#39;EX&#39; para operações com o exterior. (required).</param>
        /// <param name="retira">Indicador se o Recebedor retira no Aeroporto, Filial, Porto ou Estação de Destino? Preencher com:  * 0 - Sim  * 1 - Não (required).</param>
        /// <param name="xDetRetira">Detalhes do retira..</param>
        /// <param name="dhCont">Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS..</param>
        /// <param name="xJust">Justificativa da entrada em contingência..</param>
        public CteSimpSefazIdeSimp(int? cUF = default(int?), string cCT = default(string), string cFOP = default(string), string natOp = default(string), int? mod = default(int?), int? serie = default(int?), int? nCT = default(int?), DateTime? dhEmi = default(DateTime?), int? tpImp = default(int?), int? tpEmis = default(int?), int? cDV = default(int?), int? tpAmb = default(int?), int? tpCTe = default(int?), int? procEmi = default(int?), string verProc = default(string), string cMunEnv = default(string), string xMunEnv = default(string), string uFEnv = default(string), string modal = default(string), int? tpServ = default(int?), string uFIni = default(string), string uFFim = default(string), int? retira = default(int?), string xDetRetira = default(string), DateTime? dhCont = default(DateTime?), string xJust = default(string))
        {
            // to ensure "cUF" is required (not null)
            if (cUF == null)
            {
                throw new ArgumentNullException("cUF is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.cUF = cUF;
            // to ensure "cFOP" is required (not null)
            if (cFOP == null)
            {
                throw new ArgumentNullException("cFOP is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.CFOP = cFOP;
            // to ensure "natOp" is required (not null)
            if (natOp == null)
            {
                throw new ArgumentNullException("natOp is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.natOp = natOp;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.serie = serie;
            // to ensure "nCT" is required (not null)
            if (nCT == null)
            {
                throw new ArgumentNullException("nCT is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.nCT = nCT;
            // to ensure "dhEmi" is required (not null)
            if (dhEmi == null)
            {
                throw new ArgumentNullException("dhEmi is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.dhEmi = dhEmi;
            // to ensure "tpImp" is required (not null)
            if (tpImp == null)
            {
                throw new ArgumentNullException("tpImp is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.tpImp = tpImp;
            // to ensure "tpEmis" is required (not null)
            if (tpEmis == null)
            {
                throw new ArgumentNullException("tpEmis is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.tpEmis = tpEmis;
            // to ensure "tpCTe" is required (not null)
            if (tpCTe == null)
            {
                throw new ArgumentNullException("tpCTe is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.tpCTe = tpCTe;
            // to ensure "procEmi" is required (not null)
            if (procEmi == null)
            {
                throw new ArgumentNullException("procEmi is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.procEmi = procEmi;
            // to ensure "verProc" is required (not null)
            if (verProc == null)
            {
                throw new ArgumentNullException("verProc is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.verProc = verProc;
            // to ensure "cMunEnv" is required (not null)
            if (cMunEnv == null)
            {
                throw new ArgumentNullException("cMunEnv is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.cMunEnv = cMunEnv;
            // to ensure "xMunEnv" is required (not null)
            if (xMunEnv == null)
            {
                throw new ArgumentNullException("xMunEnv is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.xMunEnv = xMunEnv;
            // to ensure "uFEnv" is required (not null)
            if (uFEnv == null)
            {
                throw new ArgumentNullException("uFEnv is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.UFEnv = uFEnv;
            // to ensure "modal" is required (not null)
            if (modal == null)
            {
                throw new ArgumentNullException("modal is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.modal = modal;
            // to ensure "tpServ" is required (not null)
            if (tpServ == null)
            {
                throw new ArgumentNullException("tpServ is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.tpServ = tpServ;
            // to ensure "uFIni" is required (not null)
            if (uFIni == null)
            {
                throw new ArgumentNullException("uFIni is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.UFIni = uFIni;
            // to ensure "uFFim" is required (not null)
            if (uFFim == null)
            {
                throw new ArgumentNullException("uFFim is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.UFFim = uFFim;
            // to ensure "retira" is required (not null)
            if (retira == null)
            {
                throw new ArgumentNullException("retira is a required property for CteSimpSefazIdeSimp and cannot be null");
            }
            this.retira = retira;
            this.cCT = cCT;
            this.mod = mod;
            this.cDV = cDV;
            this.tpAmb = tpAmb;
            this.xDetRetira = xDetRetira;
            this.dhCont = dhCont;
            this.xJust = xJust;
        }

        /// <summary>
        /// Código da UF do emitente do CT-e.  Utilizar a Tabela do IBGE.
        /// </summary>
        /// <value>Código da UF do emitente do CT-e.  Utilizar a Tabela do IBGE.</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// Código numérico que compõe a Chave de Acesso.  Número aleatório gerado pelo emitente para cada CT-e, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Código numérico que compõe a Chave de Acesso.  Número aleatório gerado pelo emitente para cada CT-e, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cCT", EmitDefaultValue = true)]
        public string cCT { get; set; }

        /// <summary>
        /// Código Fiscal de Operações e Prestações.
        /// </summary>
        /// <value>Código Fiscal de Operações e Prestações.</value>
        [DataMember(Name = "CFOP", IsRequired = true, EmitDefaultValue = true)]
        public string CFOP { get; set; }

        /// <summary>
        /// Natureza da Operação.
        /// </summary>
        /// <value>Natureza da Operação.</value>
        [DataMember(Name = "natOp", IsRequired = true, EmitDefaultValue = true)]
        public string natOp { get; set; }

        /// <summary>
        /// Modelo do documento fiscal.  Utilizar o código 57 para identificação do CT-e, emitido em substituição aos modelos de conhecimentos em papel.
        /// </summary>
        /// <value>Modelo do documento fiscal.  Utilizar o código 57 para identificação do CT-e, emitido em substituição aos modelos de conhecimentos em papel.</value>
        [DataMember(Name = "mod", EmitDefaultValue = true)]
        public int? mod { get; set; }

        /// <summary>
        /// Série do CT-e.  Preencher com \&quot;0\&quot; no caso de série única.
        /// </summary>
        /// <value>Série do CT-e.  Preencher com \&quot;0\&quot; no caso de série única.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int? serie { get; set; }

        /// <summary>
        /// Número do CT-e.
        /// </summary>
        /// <value>Número do CT-e.</value>
        [DataMember(Name = "nCT", IsRequired = true, EmitDefaultValue = true)]
        public int? nCT { get; set; }

        /// <summary>
        /// Data e hora de emissão do CT-e.  Formato AAAA-MM-DDTHH:MM:DD TZD.
        /// </summary>
        /// <value>Data e hora de emissão do CT-e.  Formato AAAA-MM-DDTHH:MM:DD TZD.</value>
        [DataMember(Name = "dhEmi", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? dhEmi { get; set; }

        /// <summary>
        /// Formato de impressão do DACTE:  * 1 - Retrato  * 2 - Paisagem
        /// </summary>
        /// <value>Formato de impressão do DACTE:  * 1 - Retrato  * 2 - Paisagem</value>
        [DataMember(Name = "tpImp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpImp { get; set; }

        /// <summary>
        /// Forma de emissão do CT-e.  Preencher com:  * 1 - Normal  * 3 - Regime Especial NFF  * 4 - EPEC pela SVC  * 7 - Autorização pela SVC-RS  * 8 - Autorização pela SVC-SP
        /// </summary>
        /// <value>Forma de emissão do CT-e.  Preencher com:  * 1 - Normal  * 3 - Regime Especial NFF  * 4 - EPEC pela SVC  * 7 - Autorização pela SVC-RS  * 8 - Autorização pela SVC-SP</value>
        [DataMember(Name = "tpEmis", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEmis { get; set; }

        /// <summary>
        /// Digito Verificador da chave de acesso do CT-e.  Informar o dígito  de controle da chave de acesso do CT-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Digito Verificador da chave de acesso do CT-e.  Informar o dígito  de controle da chave de acesso do CT-e, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cDV", EmitDefaultValue = true)]
        public int? cDV { get; set; }

        /// <summary>
        /// Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação
        /// </summary>
        /// <value>Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = true)]
        public int? tpAmb { get; set; }

        /// <summary>
        /// Tipo do CT-e Simplificado.  Preencher com:  * 5 - CTe Simplificado  * 6 - Substituição CTe Simplificado
        /// </summary>
        /// <value>Tipo do CT-e Simplificado.  Preencher com:  * 5 - CTe Simplificado  * 6 - Substituição CTe Simplificado</value>
        [DataMember(Name = "tpCTe", IsRequired = true, EmitDefaultValue = true)]
        public int? tpCTe { get; set; }

        /// <summary>
        /// Identificador do processo de emissão do CT-e.  Preencher com:  * 0 - emissão de CT-e com aplicativo do contribuinte  * 3 - emissão CT-e pelo contribuinte com aplicativo fornecido pelo SEBRAE
        /// </summary>
        /// <value>Identificador do processo de emissão do CT-e.  Preencher com:  * 0 - emissão de CT-e com aplicativo do contribuinte  * 3 - emissão CT-e pelo contribuinte com aplicativo fornecido pelo SEBRAE</value>
        [DataMember(Name = "procEmi", IsRequired = true, EmitDefaultValue = true)]
        public int? procEmi { get; set; }

        /// <summary>
        /// Versão do processo de emissão.  Informar a versão do aplicativo emissor de CT-e.
        /// </summary>
        /// <value>Versão do processo de emissão.  Informar a versão do aplicativo emissor de CT-e.</value>
        [DataMember(Name = "verProc", IsRequired = true, EmitDefaultValue = true)]
        public string verProc { get; set; }

        /// <summary>
        /// Código do Município de envio do CT-e (de onde o documento foi transmitido).  Utilizar a tabela do IBGE. Informar 9999999 para as operações com o exterior.
        /// </summary>
        /// <value>Código do Município de envio do CT-e (de onde o documento foi transmitido).  Utilizar a tabela do IBGE. Informar 9999999 para as operações com o exterior.</value>
        [DataMember(Name = "cMunEnv", IsRequired = true, EmitDefaultValue = true)]
        public string cMunEnv { get; set; }

        /// <summary>
        /// Nome do Município de envio do CT-e (de onde o documento foi transmitido).  Informar PAIS/Municipio para as operações com o exterior.
        /// </summary>
        /// <value>Nome do Município de envio do CT-e (de onde o documento foi transmitido).  Informar PAIS/Municipio para as operações com o exterior.</value>
        [DataMember(Name = "xMunEnv", IsRequired = true, EmitDefaultValue = true)]
        public string xMunEnv { get; set; }

        /// <summary>
        /// Sigla da UF de envio do CT-e (de onde o documento foi transmitido).  Informar &#39;EX&#39; para operações com o exterior.
        /// </summary>
        /// <value>Sigla da UF de envio do CT-e (de onde o documento foi transmitido).  Informar &#39;EX&#39; para operações com o exterior.</value>
        [DataMember(Name = "UFEnv", IsRequired = true, EmitDefaultValue = true)]
        public string UFEnv { get; set; }

        /// <summary>
        /// Modal. Preencher com:  * 01 - Rodoviário  * 02 - Aéreo  * 03 - Aquaviário  * 04 - Ferroviário  * 05 - Dutoviário  * 06 - Multimodal
        /// </summary>
        /// <value>Modal. Preencher com:  * 01 - Rodoviário  * 02 - Aéreo  * 03 - Aquaviário  * 04 - Ferroviário  * 05 - Dutoviário  * 06 - Multimodal</value>
        [DataMember(Name = "modal", IsRequired = true, EmitDefaultValue = true)]
        public string modal { get; set; }

        /// <summary>
        /// Tipo do Serviço.  Preencher com:  * 0 - Normal  * 1 - Subcontratação  * 2 - Redespacho
        /// </summary>
        /// <value>Tipo do Serviço.  Preencher com:  * 0 - Normal  * 1 - Subcontratação  * 2 - Redespacho</value>
        [DataMember(Name = "tpServ", IsRequired = true, EmitDefaultValue = true)]
        public int? tpServ { get; set; }

        /// <summary>
        /// UF do início da prestação.  Informar &#39;EX&#39; para operações com o exterior.
        /// </summary>
        /// <value>UF do início da prestação.  Informar &#39;EX&#39; para operações com o exterior.</value>
        [DataMember(Name = "UFIni", IsRequired = true, EmitDefaultValue = true)]
        public string UFIni { get; set; }

        /// <summary>
        /// UF do término da prestação.  Informar &#39;EX&#39; para operações com o exterior.
        /// </summary>
        /// <value>UF do término da prestação.  Informar &#39;EX&#39; para operações com o exterior.</value>
        [DataMember(Name = "UFFim", IsRequired = true, EmitDefaultValue = true)]
        public string UFFim { get; set; }

        /// <summary>
        /// Indicador se o Recebedor retira no Aeroporto, Filial, Porto ou Estação de Destino? Preencher com:  * 0 - Sim  * 1 - Não
        /// </summary>
        /// <value>Indicador se o Recebedor retira no Aeroporto, Filial, Porto ou Estação de Destino? Preencher com:  * 0 - Sim  * 1 - Não</value>
        [DataMember(Name = "retira", IsRequired = true, EmitDefaultValue = true)]
        public int? retira { get; set; }

        /// <summary>
        /// Detalhes do retira.
        /// </summary>
        /// <value>Detalhes do retira.</value>
        [DataMember(Name = "xDetRetira", EmitDefaultValue = true)]
        public string xDetRetira { get; set; }

        /// <summary>
        /// Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS.
        /// </summary>
        /// <value>Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS.</value>
        [DataMember(Name = "dhCont", EmitDefaultValue = true)]
        public DateTime? dhCont { get; set; }

        /// <summary>
        /// Justificativa da entrada em contingência.
        /// </summary>
        /// <value>Justificativa da entrada em contingência.</value>
        [DataMember(Name = "xJust", EmitDefaultValue = true)]
        public string xJust { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazIdeSimp {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  cCT: ").Append(cCT).Append("\n");
            sb.Append("  CFOP: ").Append(CFOP).Append("\n");
            sb.Append("  natOp: ").Append(natOp).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nCT: ").Append(nCT).Append("\n");
            sb.Append("  dhEmi: ").Append(dhEmi).Append("\n");
            sb.Append("  tpImp: ").Append(tpImp).Append("\n");
            sb.Append("  tpEmis: ").Append(tpEmis).Append("\n");
            sb.Append("  cDV: ").Append(cDV).Append("\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  tpCTe: ").Append(tpCTe).Append("\n");
            sb.Append("  procEmi: ").Append(procEmi).Append("\n");
            sb.Append("  verProc: ").Append(verProc).Append("\n");
            sb.Append("  cMunEnv: ").Append(cMunEnv).Append("\n");
            sb.Append("  xMunEnv: ").Append(xMunEnv).Append("\n");
            sb.Append("  UFEnv: ").Append(UFEnv).Append("\n");
            sb.Append("  modal: ").Append(modal).Append("\n");
            sb.Append("  tpServ: ").Append(tpServ).Append("\n");
            sb.Append("  UFIni: ").Append(UFIni).Append("\n");
            sb.Append("  UFFim: ").Append(UFFim).Append("\n");
            sb.Append("  retira: ").Append(retira).Append("\n");
            sb.Append("  xDetRetira: ").Append(xDetRetira).Append("\n");
            sb.Append("  dhCont: ").Append(dhCont).Append("\n");
            sb.Append("  xJust: ").Append(xJust).Append("\n");
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
            return this.Equals(input as CteSimpSefazIdeSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazIdeSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazIdeSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazIdeSimp input)
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
                    this.cCT == input.cCT ||
                    (this.cCT != null &&
                    this.cCT.Equals(input.cCT))
                ) && 
                (
                    this.CFOP == input.CFOP ||
                    (this.CFOP != null &&
                    this.CFOP.Equals(input.CFOP))
                ) && 
                (
                    this.natOp == input.natOp ||
                    (this.natOp != null &&
                    this.natOp.Equals(input.natOp))
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
                    this.nCT == input.nCT ||
                    (this.nCT != null &&
                    this.nCT.Equals(input.nCT))
                ) && 
                (
                    this.dhEmi == input.dhEmi ||
                    (this.dhEmi != null &&
                    this.dhEmi.Equals(input.dhEmi))
                ) && 
                (
                    this.tpImp == input.tpImp ||
                    (this.tpImp != null &&
                    this.tpImp.Equals(input.tpImp))
                ) && 
                (
                    this.tpEmis == input.tpEmis ||
                    (this.tpEmis != null &&
                    this.tpEmis.Equals(input.tpEmis))
                ) && 
                (
                    this.cDV == input.cDV ||
                    (this.cDV != null &&
                    this.cDV.Equals(input.cDV))
                ) && 
                (
                    this.tpAmb == input.tpAmb ||
                    (this.tpAmb != null &&
                    this.tpAmb.Equals(input.tpAmb))
                ) && 
                (
                    this.tpCTe == input.tpCTe ||
                    (this.tpCTe != null &&
                    this.tpCTe.Equals(input.tpCTe))
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
                    this.cMunEnv == input.cMunEnv ||
                    (this.cMunEnv != null &&
                    this.cMunEnv.Equals(input.cMunEnv))
                ) && 
                (
                    this.xMunEnv == input.xMunEnv ||
                    (this.xMunEnv != null &&
                    this.xMunEnv.Equals(input.xMunEnv))
                ) && 
                (
                    this.UFEnv == input.UFEnv ||
                    (this.UFEnv != null &&
                    this.UFEnv.Equals(input.UFEnv))
                ) && 
                (
                    this.modal == input.modal ||
                    (this.modal != null &&
                    this.modal.Equals(input.modal))
                ) && 
                (
                    this.tpServ == input.tpServ ||
                    (this.tpServ != null &&
                    this.tpServ.Equals(input.tpServ))
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
                    this.retira == input.retira ||
                    (this.retira != null &&
                    this.retira.Equals(input.retira))
                ) && 
                (
                    this.xDetRetira == input.xDetRetira ||
                    (this.xDetRetira != null &&
                    this.xDetRetira.Equals(input.xDetRetira))
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
                if (this.cCT != null)
                {
                    hashCode = (hashCode * 59) + this.cCT.GetHashCode();
                }
                if (this.CFOP != null)
                {
                    hashCode = (hashCode * 59) + this.CFOP.GetHashCode();
                }
                if (this.natOp != null)
                {
                    hashCode = (hashCode * 59) + this.natOp.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nCT != null)
                {
                    hashCode = (hashCode * 59) + this.nCT.GetHashCode();
                }
                if (this.dhEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dhEmi.GetHashCode();
                }
                if (this.tpImp != null)
                {
                    hashCode = (hashCode * 59) + this.tpImp.GetHashCode();
                }
                if (this.tpEmis != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmis.GetHashCode();
                }
                if (this.cDV != null)
                {
                    hashCode = (hashCode * 59) + this.cDV.GetHashCode();
                }
                if (this.tpAmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                }
                if (this.tpCTe != null)
                {
                    hashCode = (hashCode * 59) + this.tpCTe.GetHashCode();
                }
                if (this.procEmi != null)
                {
                    hashCode = (hashCode * 59) + this.procEmi.GetHashCode();
                }
                if (this.verProc != null)
                {
                    hashCode = (hashCode * 59) + this.verProc.GetHashCode();
                }
                if (this.cMunEnv != null)
                {
                    hashCode = (hashCode * 59) + this.cMunEnv.GetHashCode();
                }
                if (this.xMunEnv != null)
                {
                    hashCode = (hashCode * 59) + this.xMunEnv.GetHashCode();
                }
                if (this.UFEnv != null)
                {
                    hashCode = (hashCode * 59) + this.UFEnv.GetHashCode();
                }
                if (this.modal != null)
                {
                    hashCode = (hashCode * 59) + this.modal.GetHashCode();
                }
                if (this.tpServ != null)
                {
                    hashCode = (hashCode * 59) + this.tpServ.GetHashCode();
                }
                if (this.UFIni != null)
                {
                    hashCode = (hashCode * 59) + this.UFIni.GetHashCode();
                }
                if (this.UFFim != null)
                {
                    hashCode = (hashCode * 59) + this.UFFim.GetHashCode();
                }
                if (this.retira != null)
                {
                    hashCode = (hashCode * 59) + this.retira.GetHashCode();
                }
                if (this.xDetRetira != null)
                {
                    hashCode = (hashCode * 59) + this.xDetRetira.GetHashCode();
                }
                if (this.dhCont != null)
                {
                    hashCode = (hashCode * 59) + this.dhCont.GetHashCode();
                }
                if (this.xJust != null)
                {
                    hashCode = (hashCode * 59) + this.xJust.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // natOp (string) maxLength
            if (this.natOp != null && this.natOp.Length > 60)
            {
                yield return new ValidationResult("Invalid value for natOp, length must be less than 60.", new [] { "natOp" });
            }

            // natOp (string) minLength
            if (this.natOp != null && this.natOp.Length < 1)
            {
                yield return new ValidationResult("Invalid value for natOp, length must be greater than 1.", new [] { "natOp" });
            }

            // serie (int?) maximum
            if (this.serie > (int?)999)
            {
                yield return new ValidationResult("Invalid value for serie, must be a value less than or equal to 999.", new [] { "serie" });
            }

            // serie (int?) minimum
            if (this.serie < (int?)0)
            {
                yield return new ValidationResult("Invalid value for serie, must be a value greater than or equal to 0.", new [] { "serie" });
            }

            // nCT (int?) maximum
            if (this.nCT > (int?)999999999)
            {
                yield return new ValidationResult("Invalid value for nCT, must be a value less than or equal to 999999999.", new [] { "nCT" });
            }

            // nCT (int?) minimum
            if (this.nCT < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nCT, must be a value greater than or equal to 1.", new [] { "nCT" });
            }

            // cDV (int?) maximum
            if (this.cDV > (int?)9)
            {
                yield return new ValidationResult("Invalid value for cDV, must be a value less than or equal to 9.", new [] { "cDV" });
            }

            // cDV (int?) minimum
            if (this.cDV < (int?)0)
            {
                yield return new ValidationResult("Invalid value for cDV, must be a value greater than or equal to 0.", new [] { "cDV" });
            }

            // verProc (string) maxLength
            if (this.verProc != null && this.verProc.Length > 20)
            {
                yield return new ValidationResult("Invalid value for verProc, length must be less than 20.", new [] { "verProc" });
            }

            // verProc (string) minLength
            if (this.verProc != null && this.verProc.Length < 1)
            {
                yield return new ValidationResult("Invalid value for verProc, length must be greater than 1.", new [] { "verProc" });
            }

            // xMunEnv (string) maxLength
            if (this.xMunEnv != null && this.xMunEnv.Length > 60)
            {
                yield return new ValidationResult("Invalid value for xMunEnv, length must be less than 60.", new [] { "xMunEnv" });
            }

            // xMunEnv (string) minLength
            if (this.xMunEnv != null && this.xMunEnv.Length < 2)
            {
                yield return new ValidationResult("Invalid value for xMunEnv, length must be greater than 2.", new [] { "xMunEnv" });
            }

            // xDetRetira (string) maxLength
            if (this.xDetRetira != null && this.xDetRetira.Length > 160)
            {
                yield return new ValidationResult("Invalid value for xDetRetira, length must be less than 160.", new [] { "xDetRetira" });
            }

            // xDetRetira (string) minLength
            if (this.xDetRetira != null && this.xDetRetira.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xDetRetira, length must be greater than 1.", new [] { "xDetRetira" });
            }

            // xJust (string) maxLength
            if (this.xJust != null && this.xJust.Length > 256)
            {
                yield return new ValidationResult("Invalid value for xJust, length must be less than 256.", new [] { "xJust" });
            }

            // xJust (string) minLength
            if (this.xJust != null && this.xJust.Length < 15)
            {
                yield return new ValidationResult("Invalid value for xJust, length must be greater than 15.", new [] { "xJust" });
            }

            yield break;
        }
    }

}
