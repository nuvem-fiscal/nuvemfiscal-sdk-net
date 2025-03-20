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
    /// Identificação da DCe.
    /// </summary>
    [DataContract(Name = "DceSefazIde")]
    public partial class DceSefazIde : IEquatable<DceSefazIde>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazIde" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DceSefazIde() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DceSefazIde" /> class.
        /// </summary>
        /// <param name="cUF">Código da UF de emissão e autorização da DCe.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação. (required).</param>
        /// <param name="cDC">Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="mod">Modelo da DCe.  Utilizar o código 99 para identificação da DCe..</param>
        /// <param name="serie">Série do documento fiscal.  Informar a série do documento fiscal (informar zero para série única). (required).</param>
        /// <param name="nDC">Número do documento fiscal.  Número que identifica o documento fiscal 1 a 999999999. (required).</param>
        /// <param name="dhEmi">Data e hora de emissão do documento fiscal.  Formato UTC (AAAA-MM-DDThh:mm:ssTZD, onde TZD &#x3D; +hh:mm ou -hh:mm). (required).</param>
        /// <param name="tpEmis">Forma de emissão do Documento Fiscal.  * 1 - Normal (não contingência)  * 9 - Contingência off-line da DCe (required).</param>
        /// <param name="tpEmit">Tipo do Emitente da DCe.  * 0 - App Fisco  * 1 - Marketplace  * 2 - Emissor próprio  * 3 - Transportadora  * 4 - ECT (required).</param>
        /// <param name="nSiteAutoriz">Identificação do número do Site do Autorizador de recepção da DCe.  Se o autorizador da DCe possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a DCE (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar. (required).</param>
        /// <param name="cDV">Digito verificador da chave de acesso.  Informar o dígito de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*.</param>
        /// <param name="tpAmb">Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação.</param>
        /// <param name="verProc">Versão do processo de emissão.  Informar a versão do aplicativo emissor de DCe. (required).</param>
        public DceSefazIde(int? cUF = default(int?), string cDC = default(string), int? mod = default(int?), int? serie = default(int?), int? nDC = default(int?), DateTime? dhEmi = default(DateTime?), int? tpEmis = default(int?), int? tpEmit = default(int?), int? nSiteAutoriz = default(int?), int? cDV = default(int?), int? tpAmb = default(int?), string verProc = default(string))
        {
            // to ensure "cUF" is required (not null)
            if (cUF == null)
            {
                throw new ArgumentNullException("cUF is a required property for DceSefazIde and cannot be null");
            }
            this.cUF = cUF;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for DceSefazIde and cannot be null");
            }
            this.serie = serie;
            // to ensure "nDC" is required (not null)
            if (nDC == null)
            {
                throw new ArgumentNullException("nDC is a required property for DceSefazIde and cannot be null");
            }
            this.nDC = nDC;
            // to ensure "dhEmi" is required (not null)
            if (dhEmi == null)
            {
                throw new ArgumentNullException("dhEmi is a required property for DceSefazIde and cannot be null");
            }
            this.dhEmi = dhEmi;
            // to ensure "tpEmis" is required (not null)
            if (tpEmis == null)
            {
                throw new ArgumentNullException("tpEmis is a required property for DceSefazIde and cannot be null");
            }
            this.tpEmis = tpEmis;
            // to ensure "tpEmit" is required (not null)
            if (tpEmit == null)
            {
                throw new ArgumentNullException("tpEmit is a required property for DceSefazIde and cannot be null");
            }
            this.tpEmit = tpEmit;
            // to ensure "nSiteAutoriz" is required (not null)
            if (nSiteAutoriz == null)
            {
                throw new ArgumentNullException("nSiteAutoriz is a required property for DceSefazIde and cannot be null");
            }
            this.nSiteAutoriz = nSiteAutoriz;
            // to ensure "verProc" is required (not null)
            if (verProc == null)
            {
                throw new ArgumentNullException("verProc is a required property for DceSefazIde and cannot be null");
            }
            this.verProc = verProc;
            this.cDC = cDC;
            this.mod = mod;
            this.cDV = cDV;
            this.tpAmb = tpAmb;
        }

        /// <summary>
        /// Código da UF de emissão e autorização da DCe.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação.
        /// </summary>
        /// <value>Código da UF de emissão e autorização da DCe.  Código da UF de emissão e autorização do Documento Fiscal. Utilizar a  Tabela do IBGE de código de unidades da federação.</value>
        [DataMember(Name = "cUF", IsRequired = true, EmitDefaultValue = true)]
        public int? cUF { get; set; }

        /// <summary>
        /// Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Código numérico que compõe a Chave de Acesso.  Código aleatório gerado pelo emitente, com o objetivo de evitar acessos indevidos ao documento.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cDC", EmitDefaultValue = true)]
        public string cDC { get; set; }

        /// <summary>
        /// Modelo da DCe.  Utilizar o código 99 para identificação da DCe.
        /// </summary>
        /// <value>Modelo da DCe.  Utilizar o código 99 para identificação da DCe.</value>
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
        [DataMember(Name = "nDC", IsRequired = true, EmitDefaultValue = true)]
        public int? nDC { get; set; }

        /// <summary>
        /// Data e hora de emissão do documento fiscal.  Formato UTC (AAAA-MM-DDThh:mm:ssTZD, onde TZD &#x3D; +hh:mm ou -hh:mm).
        /// </summary>
        /// <value>Data e hora de emissão do documento fiscal.  Formato UTC (AAAA-MM-DDThh:mm:ssTZD, onde TZD &#x3D; +hh:mm ou -hh:mm).</value>
        [DataMember(Name = "dhEmi", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? dhEmi { get; set; }

        /// <summary>
        /// Forma de emissão do Documento Fiscal.  * 1 - Normal (não contingência)  * 9 - Contingência off-line da DCe
        /// </summary>
        /// <value>Forma de emissão do Documento Fiscal.  * 1 - Normal (não contingência)  * 9 - Contingência off-line da DCe</value>
        [DataMember(Name = "tpEmis", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEmis { get; set; }

        /// <summary>
        /// Tipo do Emitente da DCe.  * 0 - App Fisco  * 1 - Marketplace  * 2 - Emissor próprio  * 3 - Transportadora  * 4 - ECT
        /// </summary>
        /// <value>Tipo do Emitente da DCe.  * 0 - App Fisco  * 1 - Marketplace  * 2 - Emissor próprio  * 3 - Transportadora  * 4 - ECT</value>
        [DataMember(Name = "tpEmit", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEmit { get; set; }

        /// <summary>
        /// Identificação do número do Site do Autorizador de recepção da DCe.  Se o autorizador da DCe possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a DCE (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar.
        /// </summary>
        /// <value>Identificação do número do Site do Autorizador de recepção da DCe.  Se o autorizador da DCe possuir apenas um site deverá ser informado com Zero (0), em caso de Autorizador trabalhar com múltiplos sites indicar o número do site para qual foi endereçada a DCE (1 a 9).  Observação: o ambiente autorizador que trabalhar com mais de um Site deverá divulgar para cada endereço de site qual número correspondente de nSiteAutoriz o contribuinte pode usar.</value>
        [DataMember(Name = "nSiteAutoriz", IsRequired = true, EmitDefaultValue = true)]
        public int? nSiteAutoriz { get; set; }

        /// <summary>
        /// Digito verificador da chave de acesso.  Informar o dígito de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*
        /// </summary>
        /// <value>Digito verificador da chave de acesso.  Informar o dígito de controle da chave de acesso documento fiscal, que deve ser calculado com a aplicação do algoritmo módulo 11 (base 2,9) da chave de acesso.    *Geramos automaticamente quando nenhum valor é informado.*</value>
        [DataMember(Name = "cDV", EmitDefaultValue = true)]
        public int? cDV { get; set; }

        /// <summary>
        /// Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação
        /// </summary>
        /// <value>Tipo do Ambiente:  * 1 - Produção  * 2 - Homologação</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = true)]
        public int? tpAmb { get; set; }

        /// <summary>
        /// Versão do processo de emissão.  Informar a versão do aplicativo emissor de DCe.
        /// </summary>
        /// <value>Versão do processo de emissão.  Informar a versão do aplicativo emissor de DCe.</value>
        [DataMember(Name = "verProc", IsRequired = true, EmitDefaultValue = true)]
        public string verProc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DceSefazIde {\n");
            sb.Append("  cUF: ").Append(cUF).Append("\n");
            sb.Append("  cDC: ").Append(cDC).Append("\n");
            sb.Append("  mod: ").Append(mod).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  nDC: ").Append(nDC).Append("\n");
            sb.Append("  dhEmi: ").Append(dhEmi).Append("\n");
            sb.Append("  tpEmis: ").Append(tpEmis).Append("\n");
            sb.Append("  tpEmit: ").Append(tpEmit).Append("\n");
            sb.Append("  nSiteAutoriz: ").Append(nSiteAutoriz).Append("\n");
            sb.Append("  cDV: ").Append(cDV).Append("\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  verProc: ").Append(verProc).Append("\n");
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
            return this.Equals(input as DceSefazIde);
        }

        /// <summary>
        /// Returns true if DceSefazIde instances are equal
        /// </summary>
        /// <param name="input">Instance of DceSefazIde to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DceSefazIde input)
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
                    this.cDC == input.cDC ||
                    (this.cDC != null &&
                    this.cDC.Equals(input.cDC))
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
                    this.nDC == input.nDC ||
                    (this.nDC != null &&
                    this.nDC.Equals(input.nDC))
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
                    this.tpEmit == input.tpEmit ||
                    (this.tpEmit != null &&
                    this.tpEmit.Equals(input.tpEmit))
                ) && 
                (
                    this.nSiteAutoriz == input.nSiteAutoriz ||
                    (this.nSiteAutoriz != null &&
                    this.nSiteAutoriz.Equals(input.nSiteAutoriz))
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
                    this.verProc == input.verProc ||
                    (this.verProc != null &&
                    this.verProc.Equals(input.verProc))
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
                if (this.cDC != null)
                {
                    hashCode = (hashCode * 59) + this.cDC.GetHashCode();
                }
                if (this.mod != null)
                {
                    hashCode = (hashCode * 59) + this.mod.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.nDC != null)
                {
                    hashCode = (hashCode * 59) + this.nDC.GetHashCode();
                }
                if (this.dhEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dhEmi.GetHashCode();
                }
                if (this.tpEmis != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmis.GetHashCode();
                }
                if (this.tpEmit != null)
                {
                    hashCode = (hashCode * 59) + this.tpEmit.GetHashCode();
                }
                if (this.nSiteAutoriz != null)
                {
                    hashCode = (hashCode * 59) + this.nSiteAutoriz.GetHashCode();
                }
                if (this.cDV != null)
                {
                    hashCode = (hashCode * 59) + this.cDV.GetHashCode();
                }
                if (this.tpAmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                }
                if (this.verProc != null)
                {
                    hashCode = (hashCode * 59) + this.verProc.GetHashCode();
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

            // nDC (int?) maximum
            if (this.nDC > (int?)999999999)
            {
                yield return new ValidationResult("Invalid value for nDC, must be a value less than or equal to 999999999.", new [] { "nDC" });
            }

            // nDC (int?) minimum
            if (this.nDC < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nDC, must be a value greater than or equal to 1.", new [] { "nDC" });
            }

            // tpEmit (int?) maximum
            if (this.tpEmit > (int?)4)
            {
                yield return new ValidationResult("Invalid value for tpEmit, must be a value less than or equal to 4.", new [] { "tpEmit" });
            }

            // tpEmit (int?) minimum
            if (this.tpEmit < (int?)0)
            {
                yield return new ValidationResult("Invalid value for tpEmit, must be a value greater than or equal to 0.", new [] { "tpEmit" });
            }

            // nSiteAutoriz (int?) maximum
            if (this.nSiteAutoriz > (int?)9)
            {
                yield return new ValidationResult("Invalid value for nSiteAutoriz, must be a value less than or equal to 9.", new [] { "nSiteAutoriz" });
            }

            // nSiteAutoriz (int?) minimum
            if (this.nSiteAutoriz < (int?)0)
            {
                yield return new ValidationResult("Invalid value for nSiteAutoriz, must be a value greater than or equal to 0.", new [] { "nSiteAutoriz" });
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

            yield break;
        }
    }

}
