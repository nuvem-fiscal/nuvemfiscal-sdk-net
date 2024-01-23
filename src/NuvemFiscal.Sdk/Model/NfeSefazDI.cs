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
    /// Delcaração de Importação  (NT 2011/004).
    /// </summary>
    [DataContract(Name = "NfeSefazDI")]
    public partial class NfeSefazDI : IEquatable<NfeSefazDI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDI" /> class.
        /// </summary>
        /// <param name="nDI">Numero do Documento de Importação DI/DSI/DA/DRI-E (DI/DSI/DA/DRI-E) (NT2011/004). (required).</param>
        /// <param name="dDI">Data de registro da DI/DSI/DA (AAAA-MM-DD). (required).</param>
        /// <param name="xLocDesemb">Local do desembaraço aduaneiro. (required).</param>
        /// <param name="uFDesemb">UF onde ocorreu o desembaraço aduaneiro. (required).</param>
        /// <param name="dDesemb">Data do desembaraço aduaneiro (AAAA-MM-DD). (required).</param>
        /// <param name="tpViaTransp">Via de transporte internacional informada na DI  * 1 - Maritima  * 2 - Fluvial  * 3 - Lacustre  * 4 - Aerea  * 5 - Postal  * 6 - Ferroviaria  * 7 - Rodoviaria  * 8 - Conduto  * 9 - Meios Proprios  * 10 - Entrada/Saida Ficta  * 11 - Courier  * 12 - Em maos  * 13 - Por reboque (required).</param>
        /// <param name="vAFRMM">Valor Adicional ao frete para renovação de marinha mercante..</param>
        /// <param name="tpIntermedio">Forma de Importação quanto a intermediação  * 1 - por conta propria  * 2 - por conta e ordem  * 3 - encomenda (required).</param>
        /// <param name="cNPJ">CNPJ do adquirente ou do encomendante..</param>
        /// <param name="uFTerceiro">Sigla da UF do adquirente ou do encomendante..</param>
        /// <param name="cExportador">Código do exportador (usado nos sistemas internos de informação do emitente da NF-e). (required).</param>
        /// <param name="adi">adi (required).</param>
        public NfeSefazDI(string nDI = default(string), DateTime? dDI = default(DateTime?), string xLocDesemb = default(string), string uFDesemb = default(string), DateTime? dDesemb = default(DateTime?), int? tpViaTransp = default(int?), decimal? vAFRMM = default(decimal?), int? tpIntermedio = default(int?), string cNPJ = default(string), string uFTerceiro = default(string), string cExportador = default(string), List<NfeSefazAdi> adi = default(List<NfeSefazAdi>))
        {
            // to ensure "nDI" is required (not null)
            if (nDI == null)
            {
                throw new ArgumentNullException("nDI is a required property for NfeSefazDI and cannot be null");
            }
            this.nDI = nDI;
            // to ensure "dDI" is required (not null)
            if (dDI == null)
            {
                throw new ArgumentNullException("dDI is a required property for NfeSefazDI and cannot be null");
            }
            this.dDI = dDI;
            // to ensure "xLocDesemb" is required (not null)
            if (xLocDesemb == null)
            {
                throw new ArgumentNullException("xLocDesemb is a required property for NfeSefazDI and cannot be null");
            }
            this.xLocDesemb = xLocDesemb;
            // to ensure "uFDesemb" is required (not null)
            if (uFDesemb == null)
            {
                throw new ArgumentNullException("uFDesemb is a required property for NfeSefazDI and cannot be null");
            }
            this.UFDesemb = uFDesemb;
            // to ensure "dDesemb" is required (not null)
            if (dDesemb == null)
            {
                throw new ArgumentNullException("dDesemb is a required property for NfeSefazDI and cannot be null");
            }
            this.dDesemb = dDesemb;
            // to ensure "tpViaTransp" is required (not null)
            if (tpViaTransp == null)
            {
                throw new ArgumentNullException("tpViaTransp is a required property for NfeSefazDI and cannot be null");
            }
            this.tpViaTransp = tpViaTransp;
            // to ensure "tpIntermedio" is required (not null)
            if (tpIntermedio == null)
            {
                throw new ArgumentNullException("tpIntermedio is a required property for NfeSefazDI and cannot be null");
            }
            this.tpIntermedio = tpIntermedio;
            // to ensure "cExportador" is required (not null)
            if (cExportador == null)
            {
                throw new ArgumentNullException("cExportador is a required property for NfeSefazDI and cannot be null");
            }
            this.cExportador = cExportador;
            // to ensure "adi" is required (not null)
            if (adi == null)
            {
                throw new ArgumentNullException("adi is a required property for NfeSefazDI and cannot be null");
            }
            this.adi = adi;
            this.vAFRMM = vAFRMM;
            this.CNPJ = cNPJ;
            this.UFTerceiro = uFTerceiro;
        }

        /// <summary>
        /// Numero do Documento de Importação DI/DSI/DA/DRI-E (DI/DSI/DA/DRI-E) (NT2011/004).
        /// </summary>
        /// <value>Numero do Documento de Importação DI/DSI/DA/DRI-E (DI/DSI/DA/DRI-E) (NT2011/004).</value>
        [DataMember(Name = "nDI", IsRequired = true, EmitDefaultValue = true)]
        public string nDI { get; set; }

        /// <summary>
        /// Data de registro da DI/DSI/DA (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de registro da DI/DSI/DA (AAAA-MM-DD).</value>
        [DataMember(Name = "dDI", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dDI { get; set; }

        /// <summary>
        /// Local do desembaraço aduaneiro.
        /// </summary>
        /// <value>Local do desembaraço aduaneiro.</value>
        [DataMember(Name = "xLocDesemb", IsRequired = true, EmitDefaultValue = true)]
        public string xLocDesemb { get; set; }

        /// <summary>
        /// UF onde ocorreu o desembaraço aduaneiro.
        /// </summary>
        /// <value>UF onde ocorreu o desembaraço aduaneiro.</value>
        [DataMember(Name = "UFDesemb", IsRequired = true, EmitDefaultValue = true)]
        public string UFDesemb { get; set; }

        /// <summary>
        /// Data do desembaraço aduaneiro (AAAA-MM-DD).
        /// </summary>
        /// <value>Data do desembaraço aduaneiro (AAAA-MM-DD).</value>
        [DataMember(Name = "dDesemb", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dDesemb { get; set; }

        /// <summary>
        /// Via de transporte internacional informada na DI  * 1 - Maritima  * 2 - Fluvial  * 3 - Lacustre  * 4 - Aerea  * 5 - Postal  * 6 - Ferroviaria  * 7 - Rodoviaria  * 8 - Conduto  * 9 - Meios Proprios  * 10 - Entrada/Saida Ficta  * 11 - Courier  * 12 - Em maos  * 13 - Por reboque
        /// </summary>
        /// <value>Via de transporte internacional informada na DI  * 1 - Maritima  * 2 - Fluvial  * 3 - Lacustre  * 4 - Aerea  * 5 - Postal  * 6 - Ferroviaria  * 7 - Rodoviaria  * 8 - Conduto  * 9 - Meios Proprios  * 10 - Entrada/Saida Ficta  * 11 - Courier  * 12 - Em maos  * 13 - Por reboque</value>
        [DataMember(Name = "tpViaTransp", IsRequired = true, EmitDefaultValue = true)]
        public int? tpViaTransp { get; set; }

        /// <summary>
        /// Valor Adicional ao frete para renovação de marinha mercante.
        /// </summary>
        /// <value>Valor Adicional ao frete para renovação de marinha mercante.</value>
        [DataMember(Name = "vAFRMM", EmitDefaultValue = true)]
        public decimal? vAFRMM { get; set; }

        /// <summary>
        /// Forma de Importação quanto a intermediação  * 1 - por conta propria  * 2 - por conta e ordem  * 3 - encomenda
        /// </summary>
        /// <value>Forma de Importação quanto a intermediação  * 1 - por conta propria  * 2 - por conta e ordem  * 3 - encomenda</value>
        [DataMember(Name = "tpIntermedio", IsRequired = true, EmitDefaultValue = true)]
        public int? tpIntermedio { get; set; }

        /// <summary>
        /// CNPJ do adquirente ou do encomendante.
        /// </summary>
        /// <value>CNPJ do adquirente ou do encomendante.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Sigla da UF do adquirente ou do encomendante.
        /// </summary>
        /// <value>Sigla da UF do adquirente ou do encomendante.</value>
        [DataMember(Name = "UFTerceiro", EmitDefaultValue = true)]
        public string UFTerceiro { get; set; }

        /// <summary>
        /// Código do exportador (usado nos sistemas internos de informação do emitente da NF-e).
        /// </summary>
        /// <value>Código do exportador (usado nos sistemas internos de informação do emitente da NF-e).</value>
        [DataMember(Name = "cExportador", IsRequired = true, EmitDefaultValue = true)]
        public string cExportador { get; set; }

        /// <summary>
        /// Gets or Sets adi
        /// </summary>
        [DataMember(Name = "adi", IsRequired = true, EmitDefaultValue = true)]
        public List<NfeSefazAdi> adi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDI {\n");
            sb.Append("  nDI: ").Append(nDI).Append("\n");
            sb.Append("  dDI: ").Append(dDI).Append("\n");
            sb.Append("  xLocDesemb: ").Append(xLocDesemb).Append("\n");
            sb.Append("  UFDesemb: ").Append(UFDesemb).Append("\n");
            sb.Append("  dDesemb: ").Append(dDesemb).Append("\n");
            sb.Append("  tpViaTransp: ").Append(tpViaTransp).Append("\n");
            sb.Append("  vAFRMM: ").Append(vAFRMM).Append("\n");
            sb.Append("  tpIntermedio: ").Append(tpIntermedio).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  UFTerceiro: ").Append(UFTerceiro).Append("\n");
            sb.Append("  cExportador: ").Append(cExportador).Append("\n");
            sb.Append("  adi: ").Append(adi).Append("\n");
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
            return this.Equals(input as NfeSefazDI);
        }

        /// <summary>
        /// Returns true if NfeSefazDI instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nDI == input.nDI ||
                    (this.nDI != null &&
                    this.nDI.Equals(input.nDI))
                ) && 
                (
                    this.dDI == input.dDI ||
                    (this.dDI != null &&
                    this.dDI.Equals(input.dDI))
                ) && 
                (
                    this.xLocDesemb == input.xLocDesemb ||
                    (this.xLocDesemb != null &&
                    this.xLocDesemb.Equals(input.xLocDesemb))
                ) && 
                (
                    this.UFDesemb == input.UFDesemb ||
                    (this.UFDesemb != null &&
                    this.UFDesemb.Equals(input.UFDesemb))
                ) && 
                (
                    this.dDesemb == input.dDesemb ||
                    (this.dDesemb != null &&
                    this.dDesemb.Equals(input.dDesemb))
                ) && 
                (
                    this.tpViaTransp == input.tpViaTransp ||
                    (this.tpViaTransp != null &&
                    this.tpViaTransp.Equals(input.tpViaTransp))
                ) && 
                (
                    this.vAFRMM == input.vAFRMM ||
                    (this.vAFRMM != null &&
                    this.vAFRMM.Equals(input.vAFRMM))
                ) && 
                (
                    this.tpIntermedio == input.tpIntermedio ||
                    (this.tpIntermedio != null &&
                    this.tpIntermedio.Equals(input.tpIntermedio))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.UFTerceiro == input.UFTerceiro ||
                    (this.UFTerceiro != null &&
                    this.UFTerceiro.Equals(input.UFTerceiro))
                ) && 
                (
                    this.cExportador == input.cExportador ||
                    (this.cExportador != null &&
                    this.cExportador.Equals(input.cExportador))
                ) && 
                (
                    this.adi == input.adi ||
                    this.adi != null &&
                    input.adi != null &&
                    this.adi.SequenceEqual(input.adi)
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
                if (this.nDI != null)
                {
                    hashCode = (hashCode * 59) + this.nDI.GetHashCode();
                }
                if (this.dDI != null)
                {
                    hashCode = (hashCode * 59) + this.dDI.GetHashCode();
                }
                if (this.xLocDesemb != null)
                {
                    hashCode = (hashCode * 59) + this.xLocDesemb.GetHashCode();
                }
                if (this.UFDesemb != null)
                {
                    hashCode = (hashCode * 59) + this.UFDesemb.GetHashCode();
                }
                if (this.dDesemb != null)
                {
                    hashCode = (hashCode * 59) + this.dDesemb.GetHashCode();
                }
                if (this.tpViaTransp != null)
                {
                    hashCode = (hashCode * 59) + this.tpViaTransp.GetHashCode();
                }
                if (this.vAFRMM != null)
                {
                    hashCode = (hashCode * 59) + this.vAFRMM.GetHashCode();
                }
                if (this.tpIntermedio != null)
                {
                    hashCode = (hashCode * 59) + this.tpIntermedio.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.UFTerceiro != null)
                {
                    hashCode = (hashCode * 59) + this.UFTerceiro.GetHashCode();
                }
                if (this.cExportador != null)
                {
                    hashCode = (hashCode * 59) + this.cExportador.GetHashCode();
                }
                if (this.adi != null)
                {
                    hashCode = (hashCode * 59) + this.adi.GetHashCode();
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
            // nDI (string) maxLength
            if (this.nDI != null && this.nDI.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDI, length must be less than 15.", new [] { "nDI" });
            }

            // nDI (string) minLength
            if (this.nDI != null && this.nDI.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDI, length must be greater than 1.", new [] { "nDI" });
            }

            // xLocDesemb (string) maxLength
            if (this.xLocDesemb != null && this.xLocDesemb.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLocDesemb, length must be less than 60.", new [] { "xLocDesemb" });
            }

            // xLocDesemb (string) minLength
            if (this.xLocDesemb != null && this.xLocDesemb.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xLocDesemb, length must be greater than 1.", new [] { "xLocDesemb" });
            }

            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // cExportador (string) maxLength
            if (this.cExportador != null && this.cExportador.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cExportador, length must be less than 60.", new [] { "cExportador" });
            }

            // cExportador (string) minLength
            if (this.cExportador != null && this.cExportador.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cExportador, length must be greater than 1.", new [] { "cExportador" });
            }

            yield break;
        }
    }

}
