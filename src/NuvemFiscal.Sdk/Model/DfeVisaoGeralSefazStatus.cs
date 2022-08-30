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
    /// DfeVisaoGeralSefazStatus
    /// </summary>
    [DataContract(Name = "DfeVisaoGeralSefazStatus")]
    public partial class DfeVisaoGeralSefazStatus : IEquatable<DfeVisaoGeralSefazStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DfeVisaoGeralSefazStatus" /> class.
        /// </summary>
        /// <param name="aC">aC.</param>
        /// <param name="aL">aL.</param>
        /// <param name="aP">aP.</param>
        /// <param name="aM">aM.</param>
        /// <param name="bA">bA.</param>
        /// <param name="cE">cE.</param>
        /// <param name="dF">dF.</param>
        /// <param name="eS">eS.</param>
        /// <param name="gO">gO.</param>
        /// <param name="mA">mA.</param>
        /// <param name="mT">mT.</param>
        /// <param name="mS">mS.</param>
        /// <param name="mG">mG.</param>
        /// <param name="pA">pA.</param>
        /// <param name="pB">pB.</param>
        /// <param name="pR">pR.</param>
        /// <param name="pE">pE.</param>
        /// <param name="pI">pI.</param>
        /// <param name="rJ">rJ.</param>
        /// <param name="rN">rN.</param>
        /// <param name="rS">rS.</param>
        /// <param name="rO">rO.</param>
        /// <param name="rR">rR.</param>
        /// <param name="sC">sC.</param>
        /// <param name="sP">sP.</param>
        /// <param name="sE">sE.</param>
        /// <param name="tO">tO.</param>
        public DfeVisaoGeralSefazStatus(DfeSefazStatus aC = default(DfeSefazStatus), DfeSefazStatus aL = default(DfeSefazStatus), DfeSefazStatus aP = default(DfeSefazStatus), DfeSefazStatus aM = default(DfeSefazStatus), DfeSefazStatus bA = default(DfeSefazStatus), DfeSefazStatus cE = default(DfeSefazStatus), DfeSefazStatus dF = default(DfeSefazStatus), DfeSefazStatus eS = default(DfeSefazStatus), DfeSefazStatus gO = default(DfeSefazStatus), DfeSefazStatus mA = default(DfeSefazStatus), DfeSefazStatus mT = default(DfeSefazStatus), DfeSefazStatus mS = default(DfeSefazStatus), DfeSefazStatus mG = default(DfeSefazStatus), DfeSefazStatus pA = default(DfeSefazStatus), DfeSefazStatus pB = default(DfeSefazStatus), DfeSefazStatus pR = default(DfeSefazStatus), DfeSefazStatus pE = default(DfeSefazStatus), DfeSefazStatus pI = default(DfeSefazStatus), DfeSefazStatus rJ = default(DfeSefazStatus), DfeSefazStatus rN = default(DfeSefazStatus), DfeSefazStatus rS = default(DfeSefazStatus), DfeSefazStatus rO = default(DfeSefazStatus), DfeSefazStatus rR = default(DfeSefazStatus), DfeSefazStatus sC = default(DfeSefazStatus), DfeSefazStatus sP = default(DfeSefazStatus), DfeSefazStatus sE = default(DfeSefazStatus), DfeSefazStatus tO = default(DfeSefazStatus))
        {
            this.AC = aC;
            this.AL = aL;
            this.AP = aP;
            this.AM = aM;
            this.BA = bA;
            this.CE = cE;
            this.DF = dF;
            this.ES = eS;
            this.GO = gO;
            this.MA = mA;
            this.MT = mT;
            this.MS = mS;
            this.MG = mG;
            this.PA = pA;
            this.PB = pB;
            this.PR = pR;
            this.PE = pE;
            this.PI = pI;
            this.RJ = rJ;
            this.RN = rN;
            this.RS = rS;
            this.RO = rO;
            this.RR = rR;
            this.SC = sC;
            this.SP = sP;
            this.SE = sE;
            this.TO = tO;
        }

        /// <summary>
        /// Gets or Sets AC
        /// </summary>
        [DataMember(Name = "AC", EmitDefaultValue = false)]
        public DfeSefazStatus AC { get; set; }

        /// <summary>
        /// Gets or Sets AL
        /// </summary>
        [DataMember(Name = "AL", EmitDefaultValue = false)]
        public DfeSefazStatus AL { get; set; }

        /// <summary>
        /// Gets or Sets AP
        /// </summary>
        [DataMember(Name = "AP", EmitDefaultValue = false)]
        public DfeSefazStatus AP { get; set; }

        /// <summary>
        /// Gets or Sets AM
        /// </summary>
        [DataMember(Name = "AM", EmitDefaultValue = false)]
        public DfeSefazStatus AM { get; set; }

        /// <summary>
        /// Gets or Sets BA
        /// </summary>
        [DataMember(Name = "BA", EmitDefaultValue = false)]
        public DfeSefazStatus BA { get; set; }

        /// <summary>
        /// Gets or Sets CE
        /// </summary>
        [DataMember(Name = "CE", EmitDefaultValue = false)]
        public DfeSefazStatus CE { get; set; }

        /// <summary>
        /// Gets or Sets DF
        /// </summary>
        [DataMember(Name = "DF", EmitDefaultValue = false)]
        public DfeSefazStatus DF { get; set; }

        /// <summary>
        /// Gets or Sets ES
        /// </summary>
        [DataMember(Name = "ES", EmitDefaultValue = false)]
        public DfeSefazStatus ES { get; set; }

        /// <summary>
        /// Gets or Sets GO
        /// </summary>
        [DataMember(Name = "GO", EmitDefaultValue = false)]
        public DfeSefazStatus GO { get; set; }

        /// <summary>
        /// Gets or Sets MA
        /// </summary>
        [DataMember(Name = "MA", EmitDefaultValue = false)]
        public DfeSefazStatus MA { get; set; }

        /// <summary>
        /// Gets or Sets MT
        /// </summary>
        [DataMember(Name = "MT", EmitDefaultValue = false)]
        public DfeSefazStatus MT { get; set; }

        /// <summary>
        /// Gets or Sets MS
        /// </summary>
        [DataMember(Name = "MS", EmitDefaultValue = false)]
        public DfeSefazStatus MS { get; set; }

        /// <summary>
        /// Gets or Sets MG
        /// </summary>
        [DataMember(Name = "MG", EmitDefaultValue = false)]
        public DfeSefazStatus MG { get; set; }

        /// <summary>
        /// Gets or Sets PA
        /// </summary>
        [DataMember(Name = "PA", EmitDefaultValue = false)]
        public DfeSefazStatus PA { get; set; }

        /// <summary>
        /// Gets or Sets PB
        /// </summary>
        [DataMember(Name = "PB", EmitDefaultValue = false)]
        public DfeSefazStatus PB { get; set; }

        /// <summary>
        /// Gets or Sets PR
        /// </summary>
        [DataMember(Name = "PR", EmitDefaultValue = false)]
        public DfeSefazStatus PR { get; set; }

        /// <summary>
        /// Gets or Sets PE
        /// </summary>
        [DataMember(Name = "PE", EmitDefaultValue = false)]
        public DfeSefazStatus PE { get; set; }

        /// <summary>
        /// Gets or Sets PI
        /// </summary>
        [DataMember(Name = "PI", EmitDefaultValue = false)]
        public DfeSefazStatus PI { get; set; }

        /// <summary>
        /// Gets or Sets RJ
        /// </summary>
        [DataMember(Name = "RJ", EmitDefaultValue = false)]
        public DfeSefazStatus RJ { get; set; }

        /// <summary>
        /// Gets or Sets RN
        /// </summary>
        [DataMember(Name = "RN", EmitDefaultValue = false)]
        public DfeSefazStatus RN { get; set; }

        /// <summary>
        /// Gets or Sets RS
        /// </summary>
        [DataMember(Name = "RS", EmitDefaultValue = false)]
        public DfeSefazStatus RS { get; set; }

        /// <summary>
        /// Gets or Sets RO
        /// </summary>
        [DataMember(Name = "RO", EmitDefaultValue = false)]
        public DfeSefazStatus RO { get; set; }

        /// <summary>
        /// Gets or Sets RR
        /// </summary>
        [DataMember(Name = "RR", EmitDefaultValue = false)]
        public DfeSefazStatus RR { get; set; }

        /// <summary>
        /// Gets or Sets SC
        /// </summary>
        [DataMember(Name = "SC", EmitDefaultValue = false)]
        public DfeSefazStatus SC { get; set; }

        /// <summary>
        /// Gets or Sets SP
        /// </summary>
        [DataMember(Name = "SP", EmitDefaultValue = false)]
        public DfeSefazStatus SP { get; set; }

        /// <summary>
        /// Gets or Sets SE
        /// </summary>
        [DataMember(Name = "SE", EmitDefaultValue = false)]
        public DfeSefazStatus SE { get; set; }

        /// <summary>
        /// Gets or Sets TO
        /// </summary>
        [DataMember(Name = "TO", EmitDefaultValue = false)]
        public DfeSefazStatus TO { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DfeVisaoGeralSefazStatus {\n");
            sb.Append("  AC: ").Append(AC).Append("\n");
            sb.Append("  AL: ").Append(AL).Append("\n");
            sb.Append("  AP: ").Append(AP).Append("\n");
            sb.Append("  AM: ").Append(AM).Append("\n");
            sb.Append("  BA: ").Append(BA).Append("\n");
            sb.Append("  CE: ").Append(CE).Append("\n");
            sb.Append("  DF: ").Append(DF).Append("\n");
            sb.Append("  ES: ").Append(ES).Append("\n");
            sb.Append("  GO: ").Append(GO).Append("\n");
            sb.Append("  MA: ").Append(MA).Append("\n");
            sb.Append("  MT: ").Append(MT).Append("\n");
            sb.Append("  MS: ").Append(MS).Append("\n");
            sb.Append("  MG: ").Append(MG).Append("\n");
            sb.Append("  PA: ").Append(PA).Append("\n");
            sb.Append("  PB: ").Append(PB).Append("\n");
            sb.Append("  PR: ").Append(PR).Append("\n");
            sb.Append("  PE: ").Append(PE).Append("\n");
            sb.Append("  PI: ").Append(PI).Append("\n");
            sb.Append("  RJ: ").Append(RJ).Append("\n");
            sb.Append("  RN: ").Append(RN).Append("\n");
            sb.Append("  RS: ").Append(RS).Append("\n");
            sb.Append("  RO: ").Append(RO).Append("\n");
            sb.Append("  RR: ").Append(RR).Append("\n");
            sb.Append("  SC: ").Append(SC).Append("\n");
            sb.Append("  SP: ").Append(SP).Append("\n");
            sb.Append("  SE: ").Append(SE).Append("\n");
            sb.Append("  TO: ").Append(TO).Append("\n");
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
            return this.Equals(input as DfeVisaoGeralSefazStatus);
        }

        /// <summary>
        /// Returns true if DfeVisaoGeralSefazStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of DfeVisaoGeralSefazStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DfeVisaoGeralSefazStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AC == input.AC ||
                    (this.AC != null &&
                    this.AC.Equals(input.AC))
                ) && 
                (
                    this.AL == input.AL ||
                    (this.AL != null &&
                    this.AL.Equals(input.AL))
                ) && 
                (
                    this.AP == input.AP ||
                    (this.AP != null &&
                    this.AP.Equals(input.AP))
                ) && 
                (
                    this.AM == input.AM ||
                    (this.AM != null &&
                    this.AM.Equals(input.AM))
                ) && 
                (
                    this.BA == input.BA ||
                    (this.BA != null &&
                    this.BA.Equals(input.BA))
                ) && 
                (
                    this.CE == input.CE ||
                    (this.CE != null &&
                    this.CE.Equals(input.CE))
                ) && 
                (
                    this.DF == input.DF ||
                    (this.DF != null &&
                    this.DF.Equals(input.DF))
                ) && 
                (
                    this.ES == input.ES ||
                    (this.ES != null &&
                    this.ES.Equals(input.ES))
                ) && 
                (
                    this.GO == input.GO ||
                    (this.GO != null &&
                    this.GO.Equals(input.GO))
                ) && 
                (
                    this.MA == input.MA ||
                    (this.MA != null &&
                    this.MA.Equals(input.MA))
                ) && 
                (
                    this.MT == input.MT ||
                    (this.MT != null &&
                    this.MT.Equals(input.MT))
                ) && 
                (
                    this.MS == input.MS ||
                    (this.MS != null &&
                    this.MS.Equals(input.MS))
                ) && 
                (
                    this.MG == input.MG ||
                    (this.MG != null &&
                    this.MG.Equals(input.MG))
                ) && 
                (
                    this.PA == input.PA ||
                    (this.PA != null &&
                    this.PA.Equals(input.PA))
                ) && 
                (
                    this.PB == input.PB ||
                    (this.PB != null &&
                    this.PB.Equals(input.PB))
                ) && 
                (
                    this.PR == input.PR ||
                    (this.PR != null &&
                    this.PR.Equals(input.PR))
                ) && 
                (
                    this.PE == input.PE ||
                    (this.PE != null &&
                    this.PE.Equals(input.PE))
                ) && 
                (
                    this.PI == input.PI ||
                    (this.PI != null &&
                    this.PI.Equals(input.PI))
                ) && 
                (
                    this.RJ == input.RJ ||
                    (this.RJ != null &&
                    this.RJ.Equals(input.RJ))
                ) && 
                (
                    this.RN == input.RN ||
                    (this.RN != null &&
                    this.RN.Equals(input.RN))
                ) && 
                (
                    this.RS == input.RS ||
                    (this.RS != null &&
                    this.RS.Equals(input.RS))
                ) && 
                (
                    this.RO == input.RO ||
                    (this.RO != null &&
                    this.RO.Equals(input.RO))
                ) && 
                (
                    this.RR == input.RR ||
                    (this.RR != null &&
                    this.RR.Equals(input.RR))
                ) && 
                (
                    this.SC == input.SC ||
                    (this.SC != null &&
                    this.SC.Equals(input.SC))
                ) && 
                (
                    this.SP == input.SP ||
                    (this.SP != null &&
                    this.SP.Equals(input.SP))
                ) && 
                (
                    this.SE == input.SE ||
                    (this.SE != null &&
                    this.SE.Equals(input.SE))
                ) && 
                (
                    this.TO == input.TO ||
                    (this.TO != null &&
                    this.TO.Equals(input.TO))
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
                if (this.AC != null)
                {
                    hashCode = (hashCode * 59) + this.AC.GetHashCode();
                }
                if (this.AL != null)
                {
                    hashCode = (hashCode * 59) + this.AL.GetHashCode();
                }
                if (this.AP != null)
                {
                    hashCode = (hashCode * 59) + this.AP.GetHashCode();
                }
                if (this.AM != null)
                {
                    hashCode = (hashCode * 59) + this.AM.GetHashCode();
                }
                if (this.BA != null)
                {
                    hashCode = (hashCode * 59) + this.BA.GetHashCode();
                }
                if (this.CE != null)
                {
                    hashCode = (hashCode * 59) + this.CE.GetHashCode();
                }
                if (this.DF != null)
                {
                    hashCode = (hashCode * 59) + this.DF.GetHashCode();
                }
                if (this.ES != null)
                {
                    hashCode = (hashCode * 59) + this.ES.GetHashCode();
                }
                if (this.GO != null)
                {
                    hashCode = (hashCode * 59) + this.GO.GetHashCode();
                }
                if (this.MA != null)
                {
                    hashCode = (hashCode * 59) + this.MA.GetHashCode();
                }
                if (this.MT != null)
                {
                    hashCode = (hashCode * 59) + this.MT.GetHashCode();
                }
                if (this.MS != null)
                {
                    hashCode = (hashCode * 59) + this.MS.GetHashCode();
                }
                if (this.MG != null)
                {
                    hashCode = (hashCode * 59) + this.MG.GetHashCode();
                }
                if (this.PA != null)
                {
                    hashCode = (hashCode * 59) + this.PA.GetHashCode();
                }
                if (this.PB != null)
                {
                    hashCode = (hashCode * 59) + this.PB.GetHashCode();
                }
                if (this.PR != null)
                {
                    hashCode = (hashCode * 59) + this.PR.GetHashCode();
                }
                if (this.PE != null)
                {
                    hashCode = (hashCode * 59) + this.PE.GetHashCode();
                }
                if (this.PI != null)
                {
                    hashCode = (hashCode * 59) + this.PI.GetHashCode();
                }
                if (this.RJ != null)
                {
                    hashCode = (hashCode * 59) + this.RJ.GetHashCode();
                }
                if (this.RN != null)
                {
                    hashCode = (hashCode * 59) + this.RN.GetHashCode();
                }
                if (this.RS != null)
                {
                    hashCode = (hashCode * 59) + this.RS.GetHashCode();
                }
                if (this.RO != null)
                {
                    hashCode = (hashCode * 59) + this.RO.GetHashCode();
                }
                if (this.RR != null)
                {
                    hashCode = (hashCode * 59) + this.RR.GetHashCode();
                }
                if (this.SC != null)
                {
                    hashCode = (hashCode * 59) + this.SC.GetHashCode();
                }
                if (this.SP != null)
                {
                    hashCode = (hashCode * 59) + this.SP.GetHashCode();
                }
                if (this.SE != null)
                {
                    hashCode = (hashCode * 59) + this.SE.GetHashCode();
                }
                if (this.TO != null)
                {
                    hashCode = (hashCode * 59) + this.TO.GetHashCode();
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
