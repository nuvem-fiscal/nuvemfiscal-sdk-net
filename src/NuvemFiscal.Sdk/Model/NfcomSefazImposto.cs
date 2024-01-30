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
    /// Tributos incidentes no Produto ou Serviço.
    /// </summary>
    [DataContract(Name = "NfcomSefazImposto")]
    public partial class NfcomSefazImposto : IEquatable<NfcomSefazImposto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazImposto" /> class.
        /// </summary>
        /// <param name="iCMS00">iCMS00.</param>
        /// <param name="iCMS20">iCMS20.</param>
        /// <param name="iCMS40">iCMS40.</param>
        /// <param name="iCMS51">iCMS51.</param>
        /// <param name="iCMS90">iCMS90.</param>
        /// <param name="iCMSSN">iCMSSN.</param>
        /// <param name="iCMSUFDest">iCMSUFDest.</param>
        /// <param name="indSemCST">Sem Situação Tributária para o ICMS.  Informar para itens que não tenham nenhuma relação com o ICMS.  Quando informado o item NÃO PODE ter CFOP informado  Se informado esse grupo o schema não permite informar nenhum dos grupos de ICMSXX..</param>
        /// <param name="pIS">pIS.</param>
        /// <param name="cOFINS">cOFINS.</param>
        /// <param name="fUST">fUST.</param>
        /// <param name="fUNTTEL">fUNTTEL.</param>
        /// <param name="retTrib">retTrib.</param>
        public NfcomSefazImposto(NfcomSefazICMS00 iCMS00 = default(NfcomSefazICMS00), NfcomSefazICMS20 iCMS20 = default(NfcomSefazICMS20), NfcomSefazICMS40 iCMS40 = default(NfcomSefazICMS40), NfcomSefazICMS51 iCMS51 = default(NfcomSefazICMS51), NfcomSefazICMS90 iCMS90 = default(NfcomSefazICMS90), NfcomSefazICMSSN iCMSSN = default(NfcomSefazICMSSN), List<NfcomSefazICMSUFDest> iCMSUFDest = default(List<NfcomSefazICMSUFDest>), int? indSemCST = default(int?), NfcomSefazPIS pIS = default(NfcomSefazPIS), NfcomSefazCOFINS cOFINS = default(NfcomSefazCOFINS), NfcomSefazFUST fUST = default(NfcomSefazFUST), NfcomSefazFUNTTEL fUNTTEL = default(NfcomSefazFUNTTEL), NfcomSefazRetTrib retTrib = default(NfcomSefazRetTrib))
        {
            this.ICMS00 = iCMS00;
            this.ICMS20 = iCMS20;
            this.ICMS40 = iCMS40;
            this.ICMS51 = iCMS51;
            this.ICMS90 = iCMS90;
            this.ICMSSN = iCMSSN;
            this.ICMSUFDest = iCMSUFDest;
            this.indSemCST = indSemCST;
            this.PIS = pIS;
            this.COFINS = cOFINS;
            this.FUST = fUST;
            this.FUNTTEL = fUNTTEL;
            this.retTrib = retTrib;
        }

        /// <summary>
        /// Gets or Sets ICMS00
        /// </summary>
        [DataMember(Name = "ICMS00", EmitDefaultValue = false)]
        public NfcomSefazICMS00 ICMS00 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS20
        /// </summary>
        [DataMember(Name = "ICMS20", EmitDefaultValue = false)]
        public NfcomSefazICMS20 ICMS20 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS40
        /// </summary>
        [DataMember(Name = "ICMS40", EmitDefaultValue = false)]
        public NfcomSefazICMS40 ICMS40 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS51
        /// </summary>
        [DataMember(Name = "ICMS51", EmitDefaultValue = false)]
        public NfcomSefazICMS51 ICMS51 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS90
        /// </summary>
        [DataMember(Name = "ICMS90", EmitDefaultValue = false)]
        public NfcomSefazICMS90 ICMS90 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN
        /// </summary>
        [DataMember(Name = "ICMSSN", EmitDefaultValue = false)]
        public NfcomSefazICMSSN ICMSSN { get; set; }

        /// <summary>
        /// Gets or Sets ICMSUFDest
        /// </summary>
        [DataMember(Name = "ICMSUFDest", EmitDefaultValue = false)]
        public List<NfcomSefazICMSUFDest> ICMSUFDest { get; set; }

        /// <summary>
        /// Sem Situação Tributária para o ICMS.  Informar para itens que não tenham nenhuma relação com o ICMS.  Quando informado o item NÃO PODE ter CFOP informado  Se informado esse grupo o schema não permite informar nenhum dos grupos de ICMSXX.
        /// </summary>
        /// <value>Sem Situação Tributária para o ICMS.  Informar para itens que não tenham nenhuma relação com o ICMS.  Quando informado o item NÃO PODE ter CFOP informado  Se informado esse grupo o schema não permite informar nenhum dos grupos de ICMSXX.</value>
        [DataMember(Name = "indSemCST", EmitDefaultValue = true)]
        public int? indSemCST { get; set; }

        /// <summary>
        /// Gets or Sets PIS
        /// </summary>
        [DataMember(Name = "PIS", EmitDefaultValue = false)]
        public NfcomSefazPIS PIS { get; set; }

        /// <summary>
        /// Gets or Sets COFINS
        /// </summary>
        [DataMember(Name = "COFINS", EmitDefaultValue = false)]
        public NfcomSefazCOFINS COFINS { get; set; }

        /// <summary>
        /// Gets or Sets FUST
        /// </summary>
        [DataMember(Name = "FUST", EmitDefaultValue = false)]
        public NfcomSefazFUST FUST { get; set; }

        /// <summary>
        /// Gets or Sets FUNTTEL
        /// </summary>
        [DataMember(Name = "FUNTTEL", EmitDefaultValue = false)]
        public NfcomSefazFUNTTEL FUNTTEL { get; set; }

        /// <summary>
        /// Gets or Sets retTrib
        /// </summary>
        [DataMember(Name = "retTrib", EmitDefaultValue = false)]
        public NfcomSefazRetTrib retTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazImposto {\n");
            sb.Append("  ICMS00: ").Append(ICMS00).Append("\n");
            sb.Append("  ICMS20: ").Append(ICMS20).Append("\n");
            sb.Append("  ICMS40: ").Append(ICMS40).Append("\n");
            sb.Append("  ICMS51: ").Append(ICMS51).Append("\n");
            sb.Append("  ICMS90: ").Append(ICMS90).Append("\n");
            sb.Append("  ICMSSN: ").Append(ICMSSN).Append("\n");
            sb.Append("  ICMSUFDest: ").Append(ICMSUFDest).Append("\n");
            sb.Append("  indSemCST: ").Append(indSemCST).Append("\n");
            sb.Append("  PIS: ").Append(PIS).Append("\n");
            sb.Append("  COFINS: ").Append(COFINS).Append("\n");
            sb.Append("  FUST: ").Append(FUST).Append("\n");
            sb.Append("  FUNTTEL: ").Append(FUNTTEL).Append("\n");
            sb.Append("  retTrib: ").Append(retTrib).Append("\n");
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
            return this.Equals(input as NfcomSefazImposto);
        }

        /// <summary>
        /// Returns true if NfcomSefazImposto instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazImposto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazImposto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ICMS00 == input.ICMS00 ||
                    (this.ICMS00 != null &&
                    this.ICMS00.Equals(input.ICMS00))
                ) && 
                (
                    this.ICMS20 == input.ICMS20 ||
                    (this.ICMS20 != null &&
                    this.ICMS20.Equals(input.ICMS20))
                ) && 
                (
                    this.ICMS40 == input.ICMS40 ||
                    (this.ICMS40 != null &&
                    this.ICMS40.Equals(input.ICMS40))
                ) && 
                (
                    this.ICMS51 == input.ICMS51 ||
                    (this.ICMS51 != null &&
                    this.ICMS51.Equals(input.ICMS51))
                ) && 
                (
                    this.ICMS90 == input.ICMS90 ||
                    (this.ICMS90 != null &&
                    this.ICMS90.Equals(input.ICMS90))
                ) && 
                (
                    this.ICMSSN == input.ICMSSN ||
                    (this.ICMSSN != null &&
                    this.ICMSSN.Equals(input.ICMSSN))
                ) && 
                (
                    this.ICMSUFDest == input.ICMSUFDest ||
                    this.ICMSUFDest != null &&
                    input.ICMSUFDest != null &&
                    this.ICMSUFDest.SequenceEqual(input.ICMSUFDest)
                ) && 
                (
                    this.indSemCST == input.indSemCST ||
                    (this.indSemCST != null &&
                    this.indSemCST.Equals(input.indSemCST))
                ) && 
                (
                    this.PIS == input.PIS ||
                    (this.PIS != null &&
                    this.PIS.Equals(input.PIS))
                ) && 
                (
                    this.COFINS == input.COFINS ||
                    (this.COFINS != null &&
                    this.COFINS.Equals(input.COFINS))
                ) && 
                (
                    this.FUST == input.FUST ||
                    (this.FUST != null &&
                    this.FUST.Equals(input.FUST))
                ) && 
                (
                    this.FUNTTEL == input.FUNTTEL ||
                    (this.FUNTTEL != null &&
                    this.FUNTTEL.Equals(input.FUNTTEL))
                ) && 
                (
                    this.retTrib == input.retTrib ||
                    (this.retTrib != null &&
                    this.retTrib.Equals(input.retTrib))
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
                if (this.ICMS00 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS00.GetHashCode();
                }
                if (this.ICMS20 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS20.GetHashCode();
                }
                if (this.ICMS40 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS40.GetHashCode();
                }
                if (this.ICMS51 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS51.GetHashCode();
                }
                if (this.ICMS90 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS90.GetHashCode();
                }
                if (this.ICMSSN != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN.GetHashCode();
                }
                if (this.ICMSUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSUFDest.GetHashCode();
                }
                if (this.indSemCST != null)
                {
                    hashCode = (hashCode * 59) + this.indSemCST.GetHashCode();
                }
                if (this.PIS != null)
                {
                    hashCode = (hashCode * 59) + this.PIS.GetHashCode();
                }
                if (this.COFINS != null)
                {
                    hashCode = (hashCode * 59) + this.COFINS.GetHashCode();
                }
                if (this.FUST != null)
                {
                    hashCode = (hashCode * 59) + this.FUST.GetHashCode();
                }
                if (this.FUNTTEL != null)
                {
                    hashCode = (hashCode * 59) + this.FUNTTEL.GetHashCode();
                }
                if (this.retTrib != null)
                {
                    hashCode = (hashCode * 59) + this.retTrib.GetHashCode();
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
            yield break;
        }
    }

}
