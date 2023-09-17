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
    /// Tributos incidentes nos produtos ou serviços da NF-e.
    /// </summary>
    [DataContract(Name = "NfeSefazImposto")]
    public partial class NfeSefazImposto : IEquatable<NfeSefazImposto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazImposto" /> class.
        /// </summary>
        /// <param name="vTotTrib">Valor estimado total de impostos federais, estaduais e municipais..</param>
        /// <param name="iCMS">iCMS.</param>
        /// <param name="iPI">iPI.</param>
        /// <param name="iI">iI.</param>
        /// <param name="iSSQN">iSSQN.</param>
        /// <param name="pIS">pIS.</param>
        /// <param name="pISST">pISST.</param>
        /// <param name="cOFINS">cOFINS.</param>
        /// <param name="cOFINSST">cOFINSST.</param>
        /// <param name="iCMSUFDest">iCMSUFDest.</param>
        public NfeSefazImposto(decimal? vTotTrib = default(decimal?), NfeSefazICMS iCMS = default(NfeSefazICMS), NfeSefazIpi iPI = default(NfeSefazIpi), NfeSefazII iI = default(NfeSefazII), NfeSefazISSQN iSSQN = default(NfeSefazISSQN), NfeSefazPIS pIS = default(NfeSefazPIS), NfeSefazPISST pISST = default(NfeSefazPISST), NfeSefazCOFINS cOFINS = default(NfeSefazCOFINS), NfeSefazCOFINSST cOFINSST = default(NfeSefazCOFINSST), NfeSefazICMSUFDest iCMSUFDest = default(NfeSefazICMSUFDest))
        {
            this.vTotTrib = vTotTrib;
            this.ICMS = iCMS;
            this.IPI = iPI;
            this.II = iI;
            this.ISSQN = iSSQN;
            this.PIS = pIS;
            this.PISST = pISST;
            this.COFINS = cOFINS;
            this.COFINSST = cOFINSST;
            this.ICMSUFDest = iCMSUFDest;
        }

        /// <summary>
        /// Valor estimado total de impostos federais, estaduais e municipais.
        /// </summary>
        /// <value>Valor estimado total de impostos federais, estaduais e municipais.</value>
        [DataMember(Name = "vTotTrib", EmitDefaultValue = true)]
        public decimal? vTotTrib { get; set; }

        /// <summary>
        /// Gets or Sets ICMS
        /// </summary>
        [DataMember(Name = "ICMS", EmitDefaultValue = false)]
        public NfeSefazICMS ICMS { get; set; }

        /// <summary>
        /// Gets or Sets IPI
        /// </summary>
        [DataMember(Name = "IPI", EmitDefaultValue = false)]
        public NfeSefazIpi IPI { get; set; }

        /// <summary>
        /// Gets or Sets II
        /// </summary>
        [DataMember(Name = "II", EmitDefaultValue = false)]
        public NfeSefazII II { get; set; }

        /// <summary>
        /// Gets or Sets ISSQN
        /// </summary>
        [DataMember(Name = "ISSQN", EmitDefaultValue = false)]
        public NfeSefazISSQN ISSQN { get; set; }

        /// <summary>
        /// Gets or Sets PIS
        /// </summary>
        [DataMember(Name = "PIS", EmitDefaultValue = false)]
        public NfeSefazPIS PIS { get; set; }

        /// <summary>
        /// Gets or Sets PISST
        /// </summary>
        [DataMember(Name = "PISST", EmitDefaultValue = false)]
        public NfeSefazPISST PISST { get; set; }

        /// <summary>
        /// Gets or Sets COFINS
        /// </summary>
        [DataMember(Name = "COFINS", EmitDefaultValue = false)]
        public NfeSefazCOFINS COFINS { get; set; }

        /// <summary>
        /// Gets or Sets COFINSST
        /// </summary>
        [DataMember(Name = "COFINSST", EmitDefaultValue = false)]
        public NfeSefazCOFINSST COFINSST { get; set; }

        /// <summary>
        /// Gets or Sets ICMSUFDest
        /// </summary>
        [DataMember(Name = "ICMSUFDest", EmitDefaultValue = false)]
        public NfeSefazICMSUFDest ICMSUFDest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazImposto {\n");
            sb.Append("  vTotTrib: ").Append(vTotTrib).Append("\n");
            sb.Append("  ICMS: ").Append(ICMS).Append("\n");
            sb.Append("  IPI: ").Append(IPI).Append("\n");
            sb.Append("  II: ").Append(II).Append("\n");
            sb.Append("  ISSQN: ").Append(ISSQN).Append("\n");
            sb.Append("  PIS: ").Append(PIS).Append("\n");
            sb.Append("  PISST: ").Append(PISST).Append("\n");
            sb.Append("  COFINS: ").Append(COFINS).Append("\n");
            sb.Append("  COFINSST: ").Append(COFINSST).Append("\n");
            sb.Append("  ICMSUFDest: ").Append(ICMSUFDest).Append("\n");
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
            return this.Equals(input as NfeSefazImposto);
        }

        /// <summary>
        /// Returns true if NfeSefazImposto instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazImposto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazImposto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vTotTrib == input.vTotTrib ||
                    (this.vTotTrib != null &&
                    this.vTotTrib.Equals(input.vTotTrib))
                ) && 
                (
                    this.ICMS == input.ICMS ||
                    (this.ICMS != null &&
                    this.ICMS.Equals(input.ICMS))
                ) && 
                (
                    this.IPI == input.IPI ||
                    (this.IPI != null &&
                    this.IPI.Equals(input.IPI))
                ) && 
                (
                    this.II == input.II ||
                    (this.II != null &&
                    this.II.Equals(input.II))
                ) && 
                (
                    this.ISSQN == input.ISSQN ||
                    (this.ISSQN != null &&
                    this.ISSQN.Equals(input.ISSQN))
                ) && 
                (
                    this.PIS == input.PIS ||
                    (this.PIS != null &&
                    this.PIS.Equals(input.PIS))
                ) && 
                (
                    this.PISST == input.PISST ||
                    (this.PISST != null &&
                    this.PISST.Equals(input.PISST))
                ) && 
                (
                    this.COFINS == input.COFINS ||
                    (this.COFINS != null &&
                    this.COFINS.Equals(input.COFINS))
                ) && 
                (
                    this.COFINSST == input.COFINSST ||
                    (this.COFINSST != null &&
                    this.COFINSST.Equals(input.COFINSST))
                ) && 
                (
                    this.ICMSUFDest == input.ICMSUFDest ||
                    (this.ICMSUFDest != null &&
                    this.ICMSUFDest.Equals(input.ICMSUFDest))
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
                if (this.vTotTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vTotTrib.GetHashCode();
                }
                if (this.ICMS != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS.GetHashCode();
                }
                if (this.IPI != null)
                {
                    hashCode = (hashCode * 59) + this.IPI.GetHashCode();
                }
                if (this.II != null)
                {
                    hashCode = (hashCode * 59) + this.II.GetHashCode();
                }
                if (this.ISSQN != null)
                {
                    hashCode = (hashCode * 59) + this.ISSQN.GetHashCode();
                }
                if (this.PIS != null)
                {
                    hashCode = (hashCode * 59) + this.PIS.GetHashCode();
                }
                if (this.PISST != null)
                {
                    hashCode = (hashCode * 59) + this.PISST.GetHashCode();
                }
                if (this.COFINS != null)
                {
                    hashCode = (hashCode * 59) + this.COFINS.GetHashCode();
                }
                if (this.COFINSST != null)
                {
                    hashCode = (hashCode * 59) + this.COFINSST.GetHashCode();
                }
                if (this.ICMSUFDest != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSUFDest.GetHashCode();
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
