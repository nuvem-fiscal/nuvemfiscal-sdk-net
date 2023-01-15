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
    /// Dados do ICMS Normal e ST.
    /// </summary>
    [DataContract(Name = "NfeSefazICMS")]
    public partial class NfeSefazICMS : IEquatable<NfeSefazICMS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS" /> class.
        /// </summary>
        /// <param name="iCMS00">iCMS00.</param>
        /// <param name="iCMS10">iCMS10.</param>
        /// <param name="iCMS20">iCMS20.</param>
        /// <param name="iCMS30">iCMS30.</param>
        /// <param name="iCMS40">iCMS40.</param>
        /// <param name="iCMS51">iCMS51.</param>
        /// <param name="iCMS60">iCMS60.</param>
        /// <param name="iCMS70">iCMS70.</param>
        /// <param name="iCMS90">iCMS90.</param>
        /// <param name="iCMSPart">iCMSPart.</param>
        /// <param name="iCMSST">iCMSST.</param>
        /// <param name="iCMSSN101">iCMSSN101.</param>
        /// <param name="iCMSSN102">iCMSSN102.</param>
        /// <param name="iCMSSN201">iCMSSN201.</param>
        /// <param name="iCMSSN202">iCMSSN202.</param>
        /// <param name="iCMSSN500">iCMSSN500.</param>
        /// <param name="iCMSSN900">iCMSSN900.</param>
        public NfeSefazICMS(NfeSefazICMS00 iCMS00 = default(NfeSefazICMS00), NfeSefazICMS10 iCMS10 = default(NfeSefazICMS10), NfeSefazICMS20 iCMS20 = default(NfeSefazICMS20), NfeSefazICMS30 iCMS30 = default(NfeSefazICMS30), NfeSefazICMS40 iCMS40 = default(NfeSefazICMS40), NfeSefazICMS51 iCMS51 = default(NfeSefazICMS51), NfeSefazICMS60 iCMS60 = default(NfeSefazICMS60), NfeSefazICMS70 iCMS70 = default(NfeSefazICMS70), NfeSefazICMS90 iCMS90 = default(NfeSefazICMS90), NfeSefazICMSPart iCMSPart = default(NfeSefazICMSPart), NfeSefazICMSST iCMSST = default(NfeSefazICMSST), NfeSefazICMSSN101 iCMSSN101 = default(NfeSefazICMSSN101), NfeSefazICMSSN102 iCMSSN102 = default(NfeSefazICMSSN102), NfeSefazICMSSN201 iCMSSN201 = default(NfeSefazICMSSN201), NfeSefazICMSSN202 iCMSSN202 = default(NfeSefazICMSSN202), NfeSefazICMSSN500 iCMSSN500 = default(NfeSefazICMSSN500), NfeSefazICMSSN900 iCMSSN900 = default(NfeSefazICMSSN900))
        {
            this.ICMS00 = iCMS00;
            this.ICMS10 = iCMS10;
            this.ICMS20 = iCMS20;
            this.ICMS30 = iCMS30;
            this.ICMS40 = iCMS40;
            this.ICMS51 = iCMS51;
            this.ICMS60 = iCMS60;
            this.ICMS70 = iCMS70;
            this.ICMS90 = iCMS90;
            this.ICMSPart = iCMSPart;
            this.ICMSST = iCMSST;
            this.ICMSSN101 = iCMSSN101;
            this.ICMSSN102 = iCMSSN102;
            this.ICMSSN201 = iCMSSN201;
            this.ICMSSN202 = iCMSSN202;
            this.ICMSSN500 = iCMSSN500;
            this.ICMSSN900 = iCMSSN900;
        }

        /// <summary>
        /// Gets or Sets ICMS00
        /// </summary>
        [DataMember(Name = "ICMS00", EmitDefaultValue = false)]
        public NfeSefazICMS00 ICMS00 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS10
        /// </summary>
        [DataMember(Name = "ICMS10", EmitDefaultValue = false)]
        public NfeSefazICMS10 ICMS10 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS20
        /// </summary>
        [DataMember(Name = "ICMS20", EmitDefaultValue = false)]
        public NfeSefazICMS20 ICMS20 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS30
        /// </summary>
        [DataMember(Name = "ICMS30", EmitDefaultValue = false)]
        public NfeSefazICMS30 ICMS30 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS40
        /// </summary>
        [DataMember(Name = "ICMS40", EmitDefaultValue = false)]
        public NfeSefazICMS40 ICMS40 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS51
        /// </summary>
        [DataMember(Name = "ICMS51", EmitDefaultValue = false)]
        public NfeSefazICMS51 ICMS51 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS60
        /// </summary>
        [DataMember(Name = "ICMS60", EmitDefaultValue = false)]
        public NfeSefazICMS60 ICMS60 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS70
        /// </summary>
        [DataMember(Name = "ICMS70", EmitDefaultValue = false)]
        public NfeSefazICMS70 ICMS70 { get; set; }

        /// <summary>
        /// Gets or Sets ICMS90
        /// </summary>
        [DataMember(Name = "ICMS90", EmitDefaultValue = false)]
        public NfeSefazICMS90 ICMS90 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSPart
        /// </summary>
        [DataMember(Name = "ICMSPart", EmitDefaultValue = false)]
        public NfeSefazICMSPart ICMSPart { get; set; }

        /// <summary>
        /// Gets or Sets ICMSST
        /// </summary>
        [DataMember(Name = "ICMSST", EmitDefaultValue = false)]
        public NfeSefazICMSST ICMSST { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN101
        /// </summary>
        [DataMember(Name = "ICMSSN101", EmitDefaultValue = false)]
        public NfeSefazICMSSN101 ICMSSN101 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN102
        /// </summary>
        [DataMember(Name = "ICMSSN102", EmitDefaultValue = false)]
        public NfeSefazICMSSN102 ICMSSN102 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN201
        /// </summary>
        [DataMember(Name = "ICMSSN201", EmitDefaultValue = false)]
        public NfeSefazICMSSN201 ICMSSN201 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN202
        /// </summary>
        [DataMember(Name = "ICMSSN202", EmitDefaultValue = false)]
        public NfeSefazICMSSN202 ICMSSN202 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN500
        /// </summary>
        [DataMember(Name = "ICMSSN500", EmitDefaultValue = false)]
        public NfeSefazICMSSN500 ICMSSN500 { get; set; }

        /// <summary>
        /// Gets or Sets ICMSSN900
        /// </summary>
        [DataMember(Name = "ICMSSN900", EmitDefaultValue = false)]
        public NfeSefazICMSSN900 ICMSSN900 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS {\n");
            sb.Append("  ICMS00: ").Append(ICMS00).Append("\n");
            sb.Append("  ICMS10: ").Append(ICMS10).Append("\n");
            sb.Append("  ICMS20: ").Append(ICMS20).Append("\n");
            sb.Append("  ICMS30: ").Append(ICMS30).Append("\n");
            sb.Append("  ICMS40: ").Append(ICMS40).Append("\n");
            sb.Append("  ICMS51: ").Append(ICMS51).Append("\n");
            sb.Append("  ICMS60: ").Append(ICMS60).Append("\n");
            sb.Append("  ICMS70: ").Append(ICMS70).Append("\n");
            sb.Append("  ICMS90: ").Append(ICMS90).Append("\n");
            sb.Append("  ICMSPart: ").Append(ICMSPart).Append("\n");
            sb.Append("  ICMSST: ").Append(ICMSST).Append("\n");
            sb.Append("  ICMSSN101: ").Append(ICMSSN101).Append("\n");
            sb.Append("  ICMSSN102: ").Append(ICMSSN102).Append("\n");
            sb.Append("  ICMSSN201: ").Append(ICMSSN201).Append("\n");
            sb.Append("  ICMSSN202: ").Append(ICMSSN202).Append("\n");
            sb.Append("  ICMSSN500: ").Append(ICMSSN500).Append("\n");
            sb.Append("  ICMSSN900: ").Append(ICMSSN900).Append("\n");
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
            return this.Equals(input as NfeSefazICMS);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS input)
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
                    this.ICMS10 == input.ICMS10 ||
                    (this.ICMS10 != null &&
                    this.ICMS10.Equals(input.ICMS10))
                ) && 
                (
                    this.ICMS20 == input.ICMS20 ||
                    (this.ICMS20 != null &&
                    this.ICMS20.Equals(input.ICMS20))
                ) && 
                (
                    this.ICMS30 == input.ICMS30 ||
                    (this.ICMS30 != null &&
                    this.ICMS30.Equals(input.ICMS30))
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
                    this.ICMS60 == input.ICMS60 ||
                    (this.ICMS60 != null &&
                    this.ICMS60.Equals(input.ICMS60))
                ) && 
                (
                    this.ICMS70 == input.ICMS70 ||
                    (this.ICMS70 != null &&
                    this.ICMS70.Equals(input.ICMS70))
                ) && 
                (
                    this.ICMS90 == input.ICMS90 ||
                    (this.ICMS90 != null &&
                    this.ICMS90.Equals(input.ICMS90))
                ) && 
                (
                    this.ICMSPart == input.ICMSPart ||
                    (this.ICMSPart != null &&
                    this.ICMSPart.Equals(input.ICMSPart))
                ) && 
                (
                    this.ICMSST == input.ICMSST ||
                    (this.ICMSST != null &&
                    this.ICMSST.Equals(input.ICMSST))
                ) && 
                (
                    this.ICMSSN101 == input.ICMSSN101 ||
                    (this.ICMSSN101 != null &&
                    this.ICMSSN101.Equals(input.ICMSSN101))
                ) && 
                (
                    this.ICMSSN102 == input.ICMSSN102 ||
                    (this.ICMSSN102 != null &&
                    this.ICMSSN102.Equals(input.ICMSSN102))
                ) && 
                (
                    this.ICMSSN201 == input.ICMSSN201 ||
                    (this.ICMSSN201 != null &&
                    this.ICMSSN201.Equals(input.ICMSSN201))
                ) && 
                (
                    this.ICMSSN202 == input.ICMSSN202 ||
                    (this.ICMSSN202 != null &&
                    this.ICMSSN202.Equals(input.ICMSSN202))
                ) && 
                (
                    this.ICMSSN500 == input.ICMSSN500 ||
                    (this.ICMSSN500 != null &&
                    this.ICMSSN500.Equals(input.ICMSSN500))
                ) && 
                (
                    this.ICMSSN900 == input.ICMSSN900 ||
                    (this.ICMSSN900 != null &&
                    this.ICMSSN900.Equals(input.ICMSSN900))
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
                if (this.ICMS10 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS10.GetHashCode();
                }
                if (this.ICMS20 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS20.GetHashCode();
                }
                if (this.ICMS30 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS30.GetHashCode();
                }
                if (this.ICMS40 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS40.GetHashCode();
                }
                if (this.ICMS51 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS51.GetHashCode();
                }
                if (this.ICMS60 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS60.GetHashCode();
                }
                if (this.ICMS70 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS70.GetHashCode();
                }
                if (this.ICMS90 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMS90.GetHashCode();
                }
                if (this.ICMSPart != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSPart.GetHashCode();
                }
                if (this.ICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSST.GetHashCode();
                }
                if (this.ICMSSN101 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN101.GetHashCode();
                }
                if (this.ICMSSN102 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN102.GetHashCode();
                }
                if (this.ICMSSN201 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN201.GetHashCode();
                }
                if (this.ICMSSN202 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN202.GetHashCode();
                }
                if (this.ICMSSN500 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN500.GetHashCode();
                }
                if (this.ICMSSN900 != null)
                {
                    hashCode = (hashCode * 59) + this.ICMSSN900.GetHashCode();
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
