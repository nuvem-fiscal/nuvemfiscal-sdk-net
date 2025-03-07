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
    /// Dados do assinante.
    /// </summary>
    [DataContract(Name = "NfcomSefazAssinante")]
    public partial class NfcomSefazAssinante : IEquatable<NfcomSefazAssinante>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazAssinante" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazAssinante() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazAssinante" /> class.
        /// </summary>
        /// <param name="iCodAssinante">Código único de Identificação do assinante. (required).</param>
        /// <param name="tpAssinante">Tipo de assinante.  * 1 - Comercial  * 2 - Industrial  * 3 - Residencial/Pessoa Física  * 4 - Produtor Rural  * 5 - Órgão da administração pública estadual direta e suas fundações e autarquias, quando mantidas pelo poder público estadual e regidas por normas de direito público, nos termos do Convênio ICMS 107/95  * 6 - Prestador de serviço de telecomunicação responsável pelo recolhimento do imposto incidente sobre a cessão dos meios de rede do prestador do serviço ao usuário final, nos termos do Convênio ICMS 17/13  * 7 - Missões Diplomáticas, Repartições Consulares e Organismos Internacionais, nos termos do Convênio ICMS 158/94  * 8 - Igrejas e Templos de qualquer natureza  * 99 - Outros não especificados anteriormente (required).</param>
        /// <param name="tpServUtil">Tipo de serviço utilizado.  * 1 - Telefonia  * 2 - Comunicação de dados  * 3 - TV por Assinatura  * 4 - Provimento de acesso à Internet  * 5 - Multimídia  * 6 - Outros  * 7 - Varios (required).</param>
        /// <param name="nContrato">Número do Contrato do assinante..</param>
        /// <param name="dContratoIni">Data de início do contrato.  Formato AAAA-MM-DD..</param>
        /// <param name="dContratoFim">Data de término do contrato.  Formato AAAA-MM-DD..</param>
        /// <param name="nroTermPrinc">Número do Terminal Principal do serviço contratado.  Em se tratando de plano de prestação de serviço telefônico corporativo, familiar ou similares, informar o número do terminal telefônico principal do plano..</param>
        /// <param name="cUFPrinc">Código da UF de habilitação do terminal.  Utilizar a  Tabela do IBGE de código de unidades da federação..</param>
        /// <param name="nroTermAdic">Número dos Terminais adicionais do serviço contratado..</param>
        /// <param name="cUFAdic">Código da UF de habilitação do terminal..</param>
        public NfcomSefazAssinante(string iCodAssinante = default(string), int? tpAssinante = default(int?), int? tpServUtil = default(int?), string nContrato = default(string), DateTime? dContratoIni = default(DateTime?), DateTime? dContratoFim = default(DateTime?), string nroTermPrinc = default(string), int? cUFPrinc = default(int?), string nroTermAdic = default(string), int? cUFAdic = default(int?))
        {
            // to ensure "iCodAssinante" is required (not null)
            if (iCodAssinante == null)
            {
                throw new ArgumentNullException("iCodAssinante is a required property for NfcomSefazAssinante and cannot be null");
            }
            this.iCodAssinante = iCodAssinante;
            // to ensure "tpAssinante" is required (not null)
            if (tpAssinante == null)
            {
                throw new ArgumentNullException("tpAssinante is a required property for NfcomSefazAssinante and cannot be null");
            }
            this.tpAssinante = tpAssinante;
            // to ensure "tpServUtil" is required (not null)
            if (tpServUtil == null)
            {
                throw new ArgumentNullException("tpServUtil is a required property for NfcomSefazAssinante and cannot be null");
            }
            this.tpServUtil = tpServUtil;
            this.nContrato = nContrato;
            this.dContratoIni = dContratoIni;
            this.dContratoFim = dContratoFim;
            this.NroTermPrinc = nroTermPrinc;
            this.cUFPrinc = cUFPrinc;
            this.NroTermAdic = nroTermAdic;
            this.cUFAdic = cUFAdic;
        }

        /// <summary>
        /// Código único de Identificação do assinante.
        /// </summary>
        /// <value>Código único de Identificação do assinante.</value>
        [DataMember(Name = "iCodAssinante", IsRequired = true, EmitDefaultValue = true)]
        public string iCodAssinante { get; set; }

        /// <summary>
        /// Tipo de assinante.  * 1 - Comercial  * 2 - Industrial  * 3 - Residencial/Pessoa Física  * 4 - Produtor Rural  * 5 - Órgão da administração pública estadual direta e suas fundações e autarquias, quando mantidas pelo poder público estadual e regidas por normas de direito público, nos termos do Convênio ICMS 107/95  * 6 - Prestador de serviço de telecomunicação responsável pelo recolhimento do imposto incidente sobre a cessão dos meios de rede do prestador do serviço ao usuário final, nos termos do Convênio ICMS 17/13  * 7 - Missões Diplomáticas, Repartições Consulares e Organismos Internacionais, nos termos do Convênio ICMS 158/94  * 8 - Igrejas e Templos de qualquer natureza  * 99 - Outros não especificados anteriormente
        /// </summary>
        /// <value>Tipo de assinante.  * 1 - Comercial  * 2 - Industrial  * 3 - Residencial/Pessoa Física  * 4 - Produtor Rural  * 5 - Órgão da administração pública estadual direta e suas fundações e autarquias, quando mantidas pelo poder público estadual e regidas por normas de direito público, nos termos do Convênio ICMS 107/95  * 6 - Prestador de serviço de telecomunicação responsável pelo recolhimento do imposto incidente sobre a cessão dos meios de rede do prestador do serviço ao usuário final, nos termos do Convênio ICMS 17/13  * 7 - Missões Diplomáticas, Repartições Consulares e Organismos Internacionais, nos termos do Convênio ICMS 158/94  * 8 - Igrejas e Templos de qualquer natureza  * 99 - Outros não especificados anteriormente</value>
        [DataMember(Name = "tpAssinante", IsRequired = true, EmitDefaultValue = true)]
        public int? tpAssinante { get; set; }

        /// <summary>
        /// Tipo de serviço utilizado.  * 1 - Telefonia  * 2 - Comunicação de dados  * 3 - TV por Assinatura  * 4 - Provimento de acesso à Internet  * 5 - Multimídia  * 6 - Outros  * 7 - Varios
        /// </summary>
        /// <value>Tipo de serviço utilizado.  * 1 - Telefonia  * 2 - Comunicação de dados  * 3 - TV por Assinatura  * 4 - Provimento de acesso à Internet  * 5 - Multimídia  * 6 - Outros  * 7 - Varios</value>
        [DataMember(Name = "tpServUtil", IsRequired = true, EmitDefaultValue = true)]
        public int? tpServUtil { get; set; }

        /// <summary>
        /// Número do Contrato do assinante.
        /// </summary>
        /// <value>Número do Contrato do assinante.</value>
        [DataMember(Name = "nContrato", EmitDefaultValue = true)]
        public string nContrato { get; set; }

        /// <summary>
        /// Data de início do contrato.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de início do contrato.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dContratoIni", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dContratoIni { get; set; }

        /// <summary>
        /// Data de término do contrato.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de término do contrato.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dContratoFim", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dContratoFim { get; set; }

        /// <summary>
        /// Número do Terminal Principal do serviço contratado.  Em se tratando de plano de prestação de serviço telefônico corporativo, familiar ou similares, informar o número do terminal telefônico principal do plano.
        /// </summary>
        /// <value>Número do Terminal Principal do serviço contratado.  Em se tratando de plano de prestação de serviço telefônico corporativo, familiar ou similares, informar o número do terminal telefônico principal do plano.</value>
        [DataMember(Name = "NroTermPrinc", EmitDefaultValue = true)]
        public string NroTermPrinc { get; set; }

        /// <summary>
        /// Código da UF de habilitação do terminal.  Utilizar a  Tabela do IBGE de código de unidades da federação.
        /// </summary>
        /// <value>Código da UF de habilitação do terminal.  Utilizar a  Tabela do IBGE de código de unidades da federação.</value>
        [DataMember(Name = "cUFPrinc", EmitDefaultValue = true)]
        public int? cUFPrinc { get; set; }

        /// <summary>
        /// Número dos Terminais adicionais do serviço contratado.
        /// </summary>
        /// <value>Número dos Terminais adicionais do serviço contratado.</value>
        [DataMember(Name = "NroTermAdic", EmitDefaultValue = true)]
        public string NroTermAdic { get; set; }

        /// <summary>
        /// Código da UF de habilitação do terminal.
        /// </summary>
        /// <value>Código da UF de habilitação do terminal.</value>
        [DataMember(Name = "cUFAdic", EmitDefaultValue = true)]
        public int? cUFAdic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazAssinante {\n");
            sb.Append("  iCodAssinante: ").Append(iCodAssinante).Append("\n");
            sb.Append("  tpAssinante: ").Append(tpAssinante).Append("\n");
            sb.Append("  tpServUtil: ").Append(tpServUtil).Append("\n");
            sb.Append("  nContrato: ").Append(nContrato).Append("\n");
            sb.Append("  dContratoIni: ").Append(dContratoIni).Append("\n");
            sb.Append("  dContratoFim: ").Append(dContratoFim).Append("\n");
            sb.Append("  NroTermPrinc: ").Append(NroTermPrinc).Append("\n");
            sb.Append("  cUFPrinc: ").Append(cUFPrinc).Append("\n");
            sb.Append("  NroTermAdic: ").Append(NroTermAdic).Append("\n");
            sb.Append("  cUFAdic: ").Append(cUFAdic).Append("\n");
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
            return this.Equals(input as NfcomSefazAssinante);
        }

        /// <summary>
        /// Returns true if NfcomSefazAssinante instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazAssinante to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazAssinante input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.iCodAssinante == input.iCodAssinante ||
                    (this.iCodAssinante != null &&
                    this.iCodAssinante.Equals(input.iCodAssinante))
                ) && 
                (
                    this.tpAssinante == input.tpAssinante ||
                    (this.tpAssinante != null &&
                    this.tpAssinante.Equals(input.tpAssinante))
                ) && 
                (
                    this.tpServUtil == input.tpServUtil ||
                    (this.tpServUtil != null &&
                    this.tpServUtil.Equals(input.tpServUtil))
                ) && 
                (
                    this.nContrato == input.nContrato ||
                    (this.nContrato != null &&
                    this.nContrato.Equals(input.nContrato))
                ) && 
                (
                    this.dContratoIni == input.dContratoIni ||
                    (this.dContratoIni != null &&
                    this.dContratoIni.Equals(input.dContratoIni))
                ) && 
                (
                    this.dContratoFim == input.dContratoFim ||
                    (this.dContratoFim != null &&
                    this.dContratoFim.Equals(input.dContratoFim))
                ) && 
                (
                    this.NroTermPrinc == input.NroTermPrinc ||
                    (this.NroTermPrinc != null &&
                    this.NroTermPrinc.Equals(input.NroTermPrinc))
                ) && 
                (
                    this.cUFPrinc == input.cUFPrinc ||
                    (this.cUFPrinc != null &&
                    this.cUFPrinc.Equals(input.cUFPrinc))
                ) && 
                (
                    this.NroTermAdic == input.NroTermAdic ||
                    (this.NroTermAdic != null &&
                    this.NroTermAdic.Equals(input.NroTermAdic))
                ) && 
                (
                    this.cUFAdic == input.cUFAdic ||
                    (this.cUFAdic != null &&
                    this.cUFAdic.Equals(input.cUFAdic))
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
                if (this.iCodAssinante != null)
                {
                    hashCode = (hashCode * 59) + this.iCodAssinante.GetHashCode();
                }
                if (this.tpAssinante != null)
                {
                    hashCode = (hashCode * 59) + this.tpAssinante.GetHashCode();
                }
                if (this.tpServUtil != null)
                {
                    hashCode = (hashCode * 59) + this.tpServUtil.GetHashCode();
                }
                if (this.nContrato != null)
                {
                    hashCode = (hashCode * 59) + this.nContrato.GetHashCode();
                }
                if (this.dContratoIni != null)
                {
                    hashCode = (hashCode * 59) + this.dContratoIni.GetHashCode();
                }
                if (this.dContratoFim != null)
                {
                    hashCode = (hashCode * 59) + this.dContratoFim.GetHashCode();
                }
                if (this.NroTermPrinc != null)
                {
                    hashCode = (hashCode * 59) + this.NroTermPrinc.GetHashCode();
                }
                if (this.cUFPrinc != null)
                {
                    hashCode = (hashCode * 59) + this.cUFPrinc.GetHashCode();
                }
                if (this.NroTermAdic != null)
                {
                    hashCode = (hashCode * 59) + this.NroTermAdic.GetHashCode();
                }
                if (this.cUFAdic != null)
                {
                    hashCode = (hashCode * 59) + this.cUFAdic.GetHashCode();
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
            // iCodAssinante (string) maxLength
            if (this.iCodAssinante != null && this.iCodAssinante.Length > 30)
            {
                yield return new ValidationResult("Invalid value for iCodAssinante, length must be less than 30.", new [] { "iCodAssinante" });
            }

            // iCodAssinante (string) minLength
            if (this.iCodAssinante != null && this.iCodAssinante.Length < 1)
            {
                yield return new ValidationResult("Invalid value for iCodAssinante, length must be greater than 1.", new [] { "iCodAssinante" });
            }

            // nContrato (string) maxLength
            if (this.nContrato != null && this.nContrato.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nContrato, length must be less than 20.", new [] { "nContrato" });
            }

            // nContrato (string) minLength
            if (this.nContrato != null && this.nContrato.Length < 1)
            {
                yield return new ValidationResult("Invalid value for nContrato, length must be greater than 1.", new [] { "nContrato" });
            }

            yield break;
        }
    }

}
