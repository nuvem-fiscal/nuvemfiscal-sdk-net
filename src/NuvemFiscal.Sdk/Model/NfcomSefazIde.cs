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
    /// Identificação da NFCom.
    /// </summary>
    [DataContract(Name = "NfcomSefazIde")]
    public partial class NfcomSefazIde : IEquatable<NfcomSefazIde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazIde" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazIde() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazIde" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF de emissão e autorização da NFCom.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação. (required).</param>
        /// <param name="tpAmb">Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação.</param>
        /// <param name="mod">Modelo da NFCom.  Utilizar o código 62 para identificação da NFCom..</param>
        /// <param name="serie">Série do documento fiscal.  Informar a série do documento fiscal (informar zero para série única). (required).</param>
        /// <param name="nNF">Número do documento fiscal.  Número que identifica o documento fiscal 1 a 999999999. (required).</param>
        /// <param name="cNF">Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="cDV">Digito verificador da chave de acesso.  Informar o dígito  de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="dhEmi">Data e hora de emissão do documento fiscal.  Formato AAAA-MM-DDTHH:MM:DD TZD. (required).</param>
        /// <param name="tpEmis">Forma de emissão do Documento Fiscal.  * 1 - Normal  * 2 - Contingência (required).</param>
        /// <param name="nSiteAutoriz">Identificação do número do Site do Autorizador de recepção da NFCom.  Se o autorizador da NFCom possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a NFCOM (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar. (required).</param>
        /// <param name="cMunFG">Código do município de ocorrência do fato gerador. (required).</param>
        /// <param name="finNFCom">Finalidade de emissão da NFCom.  * 0 - NFCom Normal  * 3 - NFCom de Substituição  * 4 - NFCom de Ajuste (required).</param>
        /// <param name="tpFat">Tipo de Faturamento da NFCom.  * 0 - Faturamento Normal  * 1 - Faturamento centralizado  * 2 - Cofaturamento (required).</param>
        /// <param name="verProc">Versão do processo de emissão.  Informar a versão do aplicativo emissor de NFCom. (required).</param>
        /// <param name="indPrePago">Indicador de serviço pré-pago.  * 1 - Serviço pré-pago (informar a tag somente se a nota for referente a um serviço exclusivamente pré-pago).</param>
        /// <param name="indCessaoMeiosRede">Indicador de Sessão de Meios de Rede.  Uma vez informado (valor &#x3D; 1), essa tag dispensa geração do grupo Fatura.  Apenas para notas dos tipos Normal e Substituição com tipo de faturamento normal..</param>
        /// <param name="indNotaEntrada">Indicador de nota de entrada.  * 1 - Informar quando for nota de ajuste e possuir itens com CFOP de entrada.</param>
        /// <param name="dhCont">Data e Hora da entrada em contingência.  Informar a data e hora no formato AAAA-MM-DDTHH:MM:SS..</param>
        /// <param name="xJust">Justificativa da entrada em contingência..</param>
        public NfcomSefazIde(int? cUF = default(int?), int? tpAmb = default(int?), int? mod = default(int?), int? serie = default(int?), int? nNF = default(int?), string cNF = default(string), int? cDV = default(int?), DateTime? dhEmi = default(DateTime?), int? tpEmis = default(int?), int? nSiteAutoriz = default(int?), string cMunFG = default(string), int? finNFCom = default(int?), int? tpFat = default(int?), string verProc = default(string), int? indPrePago = default(int?), int? indCessaoMeiosRede = default(int?), int? indNotaEntrada = default(int?), DateTime? dhCont = default(DateTime?), string xJust = default(string))
        {
            // to ensure "cUF" is required (not null)
            if (cUF == null)
            {
                throw new ArgumentNullException("cUF is a required property for NfcomSefazIde and cannot be null");
            }
            this.cUF = cUF;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for NfcomSefazIde and cannot be null");
            }
            this.serie = serie;
            // to ensure "nNF" is required (not null)
            if (nNF == null)
            {
                throw new ArgumentNullException("nNF is a required property for NfcomSefazIde and cannot be null");
            }
            this.nNF = nNF;
            // to ensure "dhEmi" is required (not null)
            if (dhEmi == null)
            {
                throw new ArgumentNullException("dhEmi is a required property for NfcomSefazIde and cannot be null");
            }
            this.dhEmi = dhEmi;
            // to ensure "tpEmis" is required (not null)
            if (tpEmis == null)
            {
                throw new ArgumentNullException("tpEmis is a required property for NfcomSefazIde and cannot be null");
            }
            this.tpEmis = tpEmis;
            // to ensure "nSiteAutoriz" is required (not null)
            if (nSiteAutoriz == null)
            {
                throw new ArgumentNullException("nSiteAutoriz is a required property for NfcomSefazIde and cannot be null");
            }
            this.nSiteAutoriz = nSiteAutoriz;
            // to ensure "cMunFG" is required (not null)
            if (cMunFG == null)
            {
                throw new ArgumentNullException("cMunFG is a required property for NfcomSefazIde and cannot be null");
            }
            this.cMunFG = cMunFG;
            // to ensure "finNFCom" is required (not null)
            if (finNFCom == null)
            {
                throw new ArgumentNullException("finNFCom is a required property for NfcomSefazIde and cannot be null");
            }
            this.finNFCom = finNFCom;
            // to ensure "tpFat" is required (not null)
            if (tpFat == null)
            {
                throw new ArgumentNullException("tpFat is a required property for NfcomSefazIde and cannot be null");
            }
            this.tpFat = tpFat;
            // to ensure "verProc" is required (not null)
            if (verProc == null)
            {
                throw new ArgumentNullException("verProc is a required property for NfcomSefazIde and cannot be null");
            }
            this.verProc = verProc;
            this.tpAmb = tpAmb;
            this.mod = mod;
            this.cNF = cNF;
            this.cDV = cDV;
            this.indPrePago = indPrePago;
            this.indCessaoMeiosRede = indCessaoMeiosRede;
            this.indNotaEntrada = indNotaEntrada;
            this.dhCont = dhCont;
            this.xJust = xJust;
        }

        /// <summary>
        /// Código da UF de emissão e autorização da NFCom.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação.
        /// </summary>
        /// <value>Código da UF de emissão e autorização da NFCom.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação.</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação
        /// </summary>
        /// <value>Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = true)]
        public int? tpAmb { get; set; }

        /// <summary>
        /// Modelo da NFCom.  Utilizar o código 62 para identificação da NFCom.
        /// </summary>
        /// <value>Modelo da NFCom.  Utilizar o código 62 para identificação da NFCom.</value>
        [DataMember(Name = "mod", EmitDefaultValue = true)]
        public int? mod { get; set; }

        /// <summary>
        /// Série do documento fiscal.  Informar a série do documento fiscal (informar zero para série única).
        /// </summary>
        /// <value>Série do documento fiscal.  Informar a série do documento fiscal (informar zero para série única).</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public int? serie { get; set; }

        /// <summary>
        /// Número do documento fiscal.  Número que identifica o documento fiscal 1 a 999999999.
        /// </summary>
        /// <value>Número do documento fiscal.  Número que identifica o documento fiscal 1 a 999999999.</value>
        [DataMember(Name = "nNF", IsRequired = true, EmitDefaultValue = true)]
        public int? nNF { get; set; }

        /// <summary>
        /// Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cNF", EmitDefaultValue = true)]
        public string cNF { get; set; }

        /// <summary>
        /// Digito verificador da chave de acesso.  Informar o dígito  de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Digito verificador da chave de acesso.  Informar o dígito  de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cDV", EmitDefaultValue = true)]
        public int? cDV { get; set; }

        /// <summary>
        /// Data e hora de emissão do documento fiscal.  Formato AAAA-MM-DDTHH:MM:DD TZD.
        /// </summary>
        /// <value>Data e hora de emissão do documento fiscal.  Formato AAAA-MM-DDTHH:MM:DD TZD.</value>
        [DataMember(Name = "dhEmi", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? dhEmi { get; set; }

        /// <summary>
        /// Forma de emissão do Documento Fiscal.  * 1 - Normal  * 2 - Contingência
        /// </summary>
        /// <value>Forma de emissão do Documento Fiscal.  * 1 - Normal  * 2 - Contingência</value>
        [DataMember(Name = "tpEmis", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEmis { get; set; }

        /// <summary>
        /// Identificação do número do Site do Autorizador de recepção da NFCom.  Se o autorizador da NFCom possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a NFCOM (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar.
        /// </summary>
        /// <value>Identificação do número do Site do Autorizador de recepção da NFCom.  Se o autorizador da NFCom possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a NFCOM (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar.</value>
        [DataMember(Name = "nSiteAutoriz", IsRequired = true, EmitDefaultValue = true)]
        public int? nSiteAutoriz { get; set; }

        /// <summary>
        /// Código do município de ocorrência do fato gerador.
        /// </summary>
        /// <value>Código do município de ocorrência do fato gerador.</value>
        [DataMember(Name = "cMunFG", IsRequired = true, EmitDefaultValue = true)]
        public string cMunFG { get; set; }

        /// <summary>
        /// Finalidade de emissão da NFCom.  * 0 - NFCom Normal  * 3 - NFCom de Substituição  * 4 - NFCom de Ajuste
        /// </summary>
        /// <value>Finalidade de emissão da NFCom.  * 0 - NFCom Normal  * 3 - NFCom de Substituição  * 4 - NFCom de Ajuste</value>
        [DataMember(Name = "finNFCom", IsRequired = true, EmitDefaultValue = true)]
        public int? finNFCom { get; set; }

        /// <summary>
        /// Tipo de Faturamento da NFCom.  * 0 - Faturamento Normal  * 1 - Faturamento centralizado  * 2 - Cofaturamento
        /// </summary>
        /// <value>Tipo de Faturamento da NFCom.  * 0 - Faturamento Normal  * 1 - Faturamento centralizado  * 2 - Cofaturamento</value>
        [DataMember(Name = "tpFat", IsRequired = true, EmitDefaultValue = true)]
        public int? tpFat { get; set; }

        /// <summary>
        /// Versão do processo de emissão.  Informar a versão do aplicativo emissor de NFCom.
        /// </summary>
        /// <value>Versão do processo de emissão.  Informar a versão do aplicativo emissor de NFCom.</value>
        [DataMember(Name = "verProc", IsRequired = true, EmitDefaultValue = true)]
        public string verProc { get; set; }

        /// <summary>
        /// Indicador de serviço pré-pago.  * 1 - Serviço pré-pago (informar a tag somente se a nota for referente a um serviço exclusivamente pré-pago)
        /// </summary>
        /// <value>Indicador de serviço pré-pago.  * 1 - Serviço pré-pago (informar a tag somente se a nota for referente a um serviço exclusivamente pré-pago)</value>
        [DataMember(Name = "indPrePago", EmitDefaultValue = true)]
        public int? indPrePago { get; set; }

        /// <summary>
        /// Indicador de Sessão de Meios de Rede.  Uma vez informado (valor &#x3D; 1), essa tag dispensa geração do grupo Fatura.  Apenas para notas dos tipos Normal e Substituição com tipo de faturamento normal.
        /// </summary>
        /// <value>Indicador de Sessão de Meios de Rede.  Uma vez informado (valor &#x3D; 1), essa tag dispensa geração do grupo Fatura.  Apenas para notas dos tipos Normal e Substituição com tipo de faturamento normal.</value>
        [DataMember(Name = "indCessaoMeiosRede", EmitDefaultValue = true)]
        public int? indCessaoMeiosRede { get; set; }

        /// <summary>
        /// Indicador de nota de entrada.  * 1 - Informar quando for nota de ajuste e possuir itens com CFOP de entrada
        /// </summary>
        /// <value>Indicador de nota de entrada.  * 1 - Informar quando for nota de ajuste e possuir itens com CFOP de entrada</value>
        [DataMember(Name = "indNotaEntrada", EmitDefaultValue = true)]
        public int? indNotaEntrada { get; set; }

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
            sb.Append("class NfcomSefazIde {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nNF: ").Append(nNF).Append("\n");
            sb.Append("  cNF: ").Append(cNF).Append("\n");
            sb.Append("  cDV: ").Append(cDV).Append("\n");
            sb.Append("  dhEmi: ").Append(dhEmi).Append("\n");
            sb.Append("  tpEmis: ").Append(tpEmis).Append("\n");
            sb.Append("  nSiteAutoriz: ").Append(nSiteAutoriz).Append("\n");
            sb.Append("  cMunFG: ").Append(cMunFG).Append("\n");
            sb.Append("  finNFCom: ").Append(finNFCom).Append("\n");
            sb.Append("  tpFat: ").Append(tpFat).Append("\n");
            sb.Append("  verProc: ").Append(verProc).Append("\n");
            sb.Append("  indPrePago: ").Append(indPrePago).Append("\n");
            sb.Append("  indCessaoMeiosRede: ").Append(indCessaoMeiosRede).Append("\n");
            sb.Append("  indNotaEntrada: ").Append(indNotaEntrada).Append("\n");
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
            return this.Equals(input as NfcomSefazIde);
        }

        /// <summary>
        /// Returns true if NfcomSefazIde instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazIde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazIde input)
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
                    this.nNF == input.nNF ||
                    (this.nNF != null &&
                    this.nNF.Equals(input.nNF))
                ) && 
                (
                    this.cNF == input.cNF ||
                    (this.cNF != null &&
                    this.cNF.Equals(input.cNF))
                ) && 
                (
                    this.cDV == input.cDV ||
                    (this.cDV != null &&
                    this.cDV.Equals(input.cDV))
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
                    this.nSiteAutoriz == input.nSiteAutoriz ||
                    (this.nSiteAutoriz != null &&
                    this.nSiteAutoriz.Equals(input.nSiteAutoriz))
                ) && 
                (
                    this.cMunFG == input.cMunFG ||
                    (this.cMunFG != null &&
                    this.cMunFG.Equals(input.cMunFG))
                ) && 
                (
                    this.finNFCom == input.finNFCom ||
                    (this.finNFCom != null &&
                    this.finNFCom.Equals(input.finNFCom))
                ) && 
                (
                    this.tpFat == input.tpFat ||
                    (this.tpFat != null &&
                    this.tpFat.Equals(input.tpFat))
                ) && 
                (
                    this.verProc == input.verProc ||
                    (this.verProc != null &&
                    this.verProc.Equals(input.verProc))
                ) && 
                (
                    this.indPrePago == input.indPrePago ||
                    (this.indPrePago != null &&
                    this.indPrePago.Equals(input.indPrePago))
                ) && 
                (
                    this.indCessaoMeiosRede == input.indCessaoMeiosRede ||
                    (this.indCessaoMeiosRede != null &&
                    this.indCessaoMeiosRede.Equals(input.indCessaoMeiosRede))
                ) && 
                (
                    this.indNotaEntrada == input.indNotaEntrada ||
                    (this.indNotaEntrada != null &&
                    this.indNotaEntrada.Equals(input.indNotaEntrada))
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
                if (this.tpAmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nNF != null)
                {
                    hashCode = (hashCode * 59) + this.nNF.GetHashCode();
                }
                if (this.cNF != null)
                {
                    hashCode = (hashCode * 59) + this.cNF.GetHashCode();
                }
                if (this.cDV != null)
                {
                    hashCode = (hashCode * 59) + this.cDV.GetHashCode();
                }
                if (this.dhEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dhEmi.GetHashCode();
                }
                if (this.tpEmis != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmis.GetHashCode();
                }
                if (this.nSiteAutoriz != null)
                {
                    hashCode = (hashCode * 59) + this.nSiteAutoriz.GetHashCode();
                }
                if (this.cMunFG != null)
                {
                    hashCode = (hashCode * 59) + this.cMunFG.GetHashCode();
                }
                if (this.finNFCom != null)
                {
                    hashCode = (hashCode * 59) + this.finNFCom.GetHashCode();
                }
                if (this.tpFat != null)
                {
                    hashCode = (hashCode * 59) + this.tpFat.GetHashCode();
                }
                if (this.verProc != null)
                {
                    hashCode = (hashCode * 59) + this.verProc.GetHashCode();
                }
                if (this.indPrePago != null)
                {
                    hashCode = (hashCode * 59) + this.indPrePago.GetHashCode();
                }
                if (this.indCessaoMeiosRede != null)
                {
                    hashCode = (hashCode * 59) + this.indCessaoMeiosRede.GetHashCode();
                }
                if (this.indNotaEntrada != null)
                {
                    hashCode = (hashCode * 59) + this.indNotaEntrada.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // serie (int?) maximum
            if (this.serie > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, must be a value less than or equal to 999.", new [] { "serie" });
            }

            // serie (int?) minimum
            if (this.serie < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for serie, must be a value greater than or equal to 0.", new [] { "serie" });
            }

            // nNF (int?) maximum
            if (this.nNF > (int?)999999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nNF, must be a value less than or equal to 999999999.", new [] { "nNF" });
            }

            // nNF (int?) minimum
            if (this.nNF < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nNF, must be a value greater than or equal to 1.", new [] { "nNF" });
            }

            // cDV (int?) maximum
            if (this.cDV > (int?)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cDV, must be a value less than or equal to 9.", new [] { "cDV" });
            }

            // cDV (int?) minimum
            if (this.cDV < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cDV, must be a value greater than or equal to 0.", new [] { "cDV" });
            }

            // nSiteAutoriz (int?) maximum
            if (this.nSiteAutoriz > (int?)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nSiteAutoriz, must be a value less than or equal to 9.", new [] { "nSiteAutoriz" });
            }

            // nSiteAutoriz (int?) minimum
            if (this.nSiteAutoriz < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nSiteAutoriz, must be a value greater than or equal to 0.", new [] { "nSiteAutoriz" });
            }

            // verProc (string) maxLength
            if (this.verProc != null && this.verProc.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for verProc, length must be less than 20.", new [] { "verProc" });
            }

            // verProc (string) minLength
            if (this.verProc != null && this.verProc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for verProc, length must be greater than 1.", new [] { "verProc" });
            }

            // xJust (string) maxLength
            if (this.xJust != null && this.xJust.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xJust, length must be less than 256.", new [] { "xJust" });
            }

            // xJust (string) minLength
            if (this.xJust != null && this.xJust.Length < 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xJust, length must be greater than 15.", new [] { "xJust" });
            }

            yield break;
        }
    }

}
