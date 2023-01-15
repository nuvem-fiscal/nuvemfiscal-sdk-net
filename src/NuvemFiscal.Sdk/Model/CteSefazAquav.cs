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
    /// CteSefazAquav
    /// </summary>
    [DataContract(Name = "CteSefazAquav")]
    public partial class CteSefazAquav : IEquatable<CteSefazAquav>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazAquav" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazAquav() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazAquav" /> class.
        /// </summary>
        /// <param name="vPrest">Valor da Prestação Base de Cálculo do AFRMM. (required).</param>
        /// <param name="vAFRMM">AFRMM (Adicional de Frete para Renovação da Marinha Mercante). (required).</param>
        /// <param name="xNavio">Identificação do Navio. (required).</param>
        /// <param name="balsa">balsa.</param>
        /// <param name="nViag">Número da Viagem..</param>
        /// <param name="direc">Direção.  Preencher com: N-Norte, L-Leste, S-Sul, O-Oeste. (required).</param>
        /// <param name="irin">Irin do navio sempre deverá ser informado. (required).</param>
        /// <param name="detCont">detCont.</param>
        /// <param name="tpNav">Tipo de Navegação.  Preencher com:  * 0 - Interior  * 1 - Cabotagem.</param>
        public CteSefazAquav(decimal vPrest = default(decimal), decimal vAFRMM = default(decimal), string xNavio = default(string), List<CteSefazBalsa> balsa = default(List<CteSefazBalsa>), string nViag = default(string), string direc = default(string), string irin = default(string), List<CteSefazDetCont> detCont = default(List<CteSefazDetCont>), int tpNav = default(int))
        {
            this.vPrest = vPrest;
            this.vAFRMM = vAFRMM;
            // to ensure "xNavio" is required (not null)
            if (xNavio == null)
            {
                throw new ArgumentNullException("xNavio is a required property for CteSefazAquav and cannot be null");
            }
            this.xNavio = xNavio;
            // to ensure "direc" is required (not null)
            if (direc == null)
            {
                throw new ArgumentNullException("direc is a required property for CteSefazAquav and cannot be null");
            }
            this.direc = direc;
            // to ensure "irin" is required (not null)
            if (irin == null)
            {
                throw new ArgumentNullException("irin is a required property for CteSefazAquav and cannot be null");
            }
            this.irin = irin;
            this.balsa = balsa;
            this.nViag = nViag;
            this.detCont = detCont;
            this.tpNav = tpNav;
        }

        /// <summary>
        /// Valor da Prestação Base de Cálculo do AFRMM.
        /// </summary>
        /// <value>Valor da Prestação Base de Cálculo do AFRMM.</value>
        [DataMember(Name = "vPrest", IsRequired = true, EmitDefaultValue = true)]
        public decimal vPrest { get; set; }

        /// <summary>
        /// AFRMM (Adicional de Frete para Renovação da Marinha Mercante).
        /// </summary>
        /// <value>AFRMM (Adicional de Frete para Renovação da Marinha Mercante).</value>
        [DataMember(Name = "vAFRMM", IsRequired = true, EmitDefaultValue = true)]
        public decimal vAFRMM { get; set; }

        /// <summary>
        /// Identificação do Navio.
        /// </summary>
        /// <value>Identificação do Navio.</value>
        [DataMember(Name = "xNavio", IsRequired = true, EmitDefaultValue = true)]
        public string xNavio { get; set; }

        /// <summary>
        /// Gets or Sets balsa
        /// </summary>
        [DataMember(Name = "balsa", EmitDefaultValue = false)]
        public List<CteSefazBalsa> balsa { get; set; }

        /// <summary>
        /// Número da Viagem.
        /// </summary>
        /// <value>Número da Viagem.</value>
        [DataMember(Name = "nViag", EmitDefaultValue = false)]
        public string nViag { get; set; }

        /// <summary>
        /// Direção.  Preencher com: N-Norte, L-Leste, S-Sul, O-Oeste.
        /// </summary>
        /// <value>Direção.  Preencher com: N-Norte, L-Leste, S-Sul, O-Oeste.</value>
        [DataMember(Name = "direc", IsRequired = true, EmitDefaultValue = true)]
        public string direc { get; set; }

        /// <summary>
        /// Irin do navio sempre deverá ser informado.
        /// </summary>
        /// <value>Irin do navio sempre deverá ser informado.</value>
        [DataMember(Name = "irin", IsRequired = true, EmitDefaultValue = true)]
        public string irin { get; set; }

        /// <summary>
        /// Gets or Sets detCont
        /// </summary>
        [DataMember(Name = "detCont", EmitDefaultValue = false)]
        public List<CteSefazDetCont> detCont { get; set; }

        /// <summary>
        /// Tipo de Navegação.  Preencher com:  * 0 - Interior  * 1 - Cabotagem
        /// </summary>
        /// <value>Tipo de Navegação.  Preencher com:  * 0 - Interior  * 1 - Cabotagem</value>
        [DataMember(Name = "tpNav", EmitDefaultValue = false)]
        public int tpNav { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazAquav {\n");
            sb.Append("  vPrest: ").Append(vPrest).Append("\n");
            sb.Append("  vAFRMM: ").Append(vAFRMM).Append("\n");
            sb.Append("  xNavio: ").Append(xNavio).Append("\n");
            sb.Append("  balsa: ").Append(balsa).Append("\n");
            sb.Append("  nViag: ").Append(nViag).Append("\n");
            sb.Append("  direc: ").Append(direc).Append("\n");
            sb.Append("  irin: ").Append(irin).Append("\n");
            sb.Append("  detCont: ").Append(detCont).Append("\n");
            sb.Append("  tpNav: ").Append(tpNav).Append("\n");
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
            return this.Equals(input as CteSefazAquav);
        }

        /// <summary>
        /// Returns true if CteSefazAquav instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazAquav to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazAquav input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vPrest == input.vPrest ||
                    this.vPrest.Equals(input.vPrest)
                ) && 
                (
                    this.vAFRMM == input.vAFRMM ||
                    this.vAFRMM.Equals(input.vAFRMM)
                ) && 
                (
                    this.xNavio == input.xNavio ||
                    (this.xNavio != null &&
                    this.xNavio.Equals(input.xNavio))
                ) && 
                (
                    this.balsa == input.balsa ||
                    this.balsa != null &&
                    input.balsa != null &&
                    this.balsa.SequenceEqual(input.balsa)
                ) && 
                (
                    this.nViag == input.nViag ||
                    (this.nViag != null &&
                    this.nViag.Equals(input.nViag))
                ) && 
                (
                    this.direc == input.direc ||
                    (this.direc != null &&
                    this.direc.Equals(input.direc))
                ) && 
                (
                    this.irin == input.irin ||
                    (this.irin != null &&
                    this.irin.Equals(input.irin))
                ) && 
                (
                    this.detCont == input.detCont ||
                    this.detCont != null &&
                    input.detCont != null &&
                    this.detCont.SequenceEqual(input.detCont)
                ) && 
                (
                    this.tpNav == input.tpNav ||
                    this.tpNav.Equals(input.tpNav)
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
                hashCode = (hashCode * 59) + this.vPrest.GetHashCode();
                hashCode = (hashCode * 59) + this.vAFRMM.GetHashCode();
                if (this.xNavio != null)
                {
                    hashCode = (hashCode * 59) + this.xNavio.GetHashCode();
                }
                if (this.balsa != null)
                {
                    hashCode = (hashCode * 59) + this.balsa.GetHashCode();
                }
                if (this.nViag != null)
                {
                    hashCode = (hashCode * 59) + this.nViag.GetHashCode();
                }
                if (this.direc != null)
                {
                    hashCode = (hashCode * 59) + this.direc.GetHashCode();
                }
                if (this.irin != null)
                {
                    hashCode = (hashCode * 59) + this.irin.GetHashCode();
                }
                if (this.detCont != null)
                {
                    hashCode = (hashCode * 59) + this.detCont.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpNav.GetHashCode();
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
