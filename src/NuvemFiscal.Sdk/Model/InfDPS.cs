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
    /// Grupo de informações da DPS relativas ao serviço prestado.
    /// </summary>
    [DataContract(Name = "InfDPS")]
    public partial class InfDPS : IEquatable<InfDPS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfDPS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfDPS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfDPS" /> class.
        /// </summary>
        /// <param name="tpAmb">Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação.</param>
        /// <param name="dhEmi">Data e hora da emissão do DPS. Data e hora no formato UTC (Universal Coordinated Time): AAAA-MM-DDThh:mm:ssTZD. (required).</param>
        /// <param name="verAplic">Versão do aplicativo que gerou o DPS..</param>
        /// <param name="dCompet">Data em que se iniciou a prestação do serviço: Dia, mês e ano (AAAAMMDD). (required).</param>
        /// <param name="subst">subst.</param>
        /// <param name="prest">prest (required).</param>
        /// <param name="toma">toma.</param>
        /// <param name="interm">interm.</param>
        /// <param name="serv">serv (required).</param>
        /// <param name="valores">valores (required).</param>
        public InfDPS(int? tpAmb = default(int?), DateTime? dhEmi = default(DateTime?), string verAplic = default(string), DateTime? dCompet = default(DateTime?), Substituicao subst = default(Substituicao), InfoPrestador prest = default(InfoPrestador), InfoTomador toma = default(InfoTomador), InfoIntermediario interm = default(InfoIntermediario), Serv serv = default(Serv), InfoValores valores = default(InfoValores))
        {
            // to ensure "dhEmi" is required (not null)
            if (dhEmi == null)
            {
                throw new ArgumentNullException("dhEmi is a required property for InfDPS and cannot be null");
            }
            this.dhEmi = dhEmi;
            // to ensure "dCompet" is required (not null)
            if (dCompet == null)
            {
                throw new ArgumentNullException("dCompet is a required property for InfDPS and cannot be null");
            }
            this.dCompet = dCompet;
            // to ensure "prest" is required (not null)
            if (prest == null)
            {
                throw new ArgumentNullException("prest is a required property for InfDPS and cannot be null");
            }
            this.prest = prest;
            // to ensure "serv" is required (not null)
            if (serv == null)
            {
                throw new ArgumentNullException("serv is a required property for InfDPS and cannot be null");
            }
            this.serv = serv;
            // to ensure "valores" is required (not null)
            if (valores == null)
            {
                throw new ArgumentNullException("valores is a required property for InfDPS and cannot be null");
            }
            this.valores = valores;
            this.tpAmb = tpAmb;
            this.verAplic = verAplic;
            this.subst = subst;
            this.toma = toma;
            this.interm = interm;
        }

        /// <summary>
        /// Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação
        /// </summary>
        /// <value>Identificação do Ambiente:  * 1 - Produção  * 2 - Homologação</value>
        [DataMember(Name = "tpAmb", EmitDefaultValue = true)]
        public int? tpAmb { get; set; }

        /// <summary>
        /// Data e hora da emissão do DPS. Data e hora no formato UTC (Universal Coordinated Time): AAAA-MM-DDThh:mm:ssTZD.
        /// </summary>
        /// <value>Data e hora da emissão do DPS. Data e hora no formato UTC (Universal Coordinated Time): AAAA-MM-DDThh:mm:ssTZD.</value>
        [DataMember(Name = "dhEmi", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? dhEmi { get; set; }

        /// <summary>
        /// Versão do aplicativo que gerou o DPS.
        /// </summary>
        /// <value>Versão do aplicativo que gerou o DPS.</value>
        [DataMember(Name = "verAplic", EmitDefaultValue = true)]
        public string verAplic { get; set; }

        /// <summary>
        /// Data em que se iniciou a prestação do serviço: Dia, mês e ano (AAAAMMDD).
        /// </summary>
        /// <value>Data em que se iniciou a prestação do serviço: Dia, mês e ano (AAAAMMDD).</value>
        [DataMember(Name = "dCompet", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dCompet { get; set; }

        /// <summary>
        /// Gets or Sets subst
        /// </summary>
        [DataMember(Name = "subst", EmitDefaultValue = false)]
        public Substituicao subst { get; set; }

        /// <summary>
        /// Gets or Sets prest
        /// </summary>
        [DataMember(Name = "prest", IsRequired = true, EmitDefaultValue = true)]
        public InfoPrestador prest { get; set; }

        /// <summary>
        /// Gets or Sets toma
        /// </summary>
        [DataMember(Name = "toma", EmitDefaultValue = false)]
        public InfoTomador toma { get; set; }

        /// <summary>
        /// Gets or Sets interm
        /// </summary>
        [DataMember(Name = "interm", EmitDefaultValue = false)]
        public InfoIntermediario interm { get; set; }

        /// <summary>
        /// Gets or Sets serv
        /// </summary>
        [DataMember(Name = "serv", IsRequired = true, EmitDefaultValue = true)]
        public Serv serv { get; set; }

        /// <summary>
        /// Gets or Sets valores
        /// </summary>
        [DataMember(Name = "valores", IsRequired = true, EmitDefaultValue = true)]
        public InfoValores valores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfDPS {\n");
            sb.Append("  tpAmb: ").Append(tpAmb).Append("\n");
            sb.Append("  dhEmi: ").Append(dhEmi).Append("\n");
            sb.Append("  verAplic: ").Append(verAplic).Append("\n");
            sb.Append("  dCompet: ").Append(dCompet).Append("\n");
            sb.Append("  subst: ").Append(subst).Append("\n");
            sb.Append("  prest: ").Append(prest).Append("\n");
            sb.Append("  toma: ").Append(toma).Append("\n");
            sb.Append("  interm: ").Append(interm).Append("\n");
            sb.Append("  serv: ").Append(serv).Append("\n");
            sb.Append("  valores: ").Append(valores).Append("\n");
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
            return this.Equals(input as InfDPS);
        }

        /// <summary>
        /// Returns true if InfDPS instances are equal
        /// </summary>
        /// <param name="input">Instance of InfDPS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfDPS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpAmb == input.tpAmb ||
                    (this.tpAmb != null &&
                    this.tpAmb.Equals(input.tpAmb))
                ) && 
                (
                    this.dhEmi == input.dhEmi ||
                    (this.dhEmi != null &&
                    this.dhEmi.Equals(input.dhEmi))
                ) && 
                (
                    this.verAplic == input.verAplic ||
                    (this.verAplic != null &&
                    this.verAplic.Equals(input.verAplic))
                ) && 
                (
                    this.dCompet == input.dCompet ||
                    (this.dCompet != null &&
                    this.dCompet.Equals(input.dCompet))
                ) && 
                (
                    this.subst == input.subst ||
                    (this.subst != null &&
                    this.subst.Equals(input.subst))
                ) && 
                (
                    this.prest == input.prest ||
                    (this.prest != null &&
                    this.prest.Equals(input.prest))
                ) && 
                (
                    this.toma == input.toma ||
                    (this.toma != null &&
                    this.toma.Equals(input.toma))
                ) && 
                (
                    this.interm == input.interm ||
                    (this.interm != null &&
                    this.interm.Equals(input.interm))
                ) && 
                (
                    this.serv == input.serv ||
                    (this.serv != null &&
                    this.serv.Equals(input.serv))
                ) && 
                (
                    this.valores == input.valores ||
                    (this.valores != null &&
                    this.valores.Equals(input.valores))
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
                if (this.tpAmb != null)
                {
                    hashCode = (hashCode * 59) + this.tpAmb.GetHashCode();
                }
                if (this.dhEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dhEmi.GetHashCode();
                }
                if (this.verAplic != null)
                {
                    hashCode = (hashCode * 59) + this.verAplic.GetHashCode();
                }
                if (this.dCompet != null)
                {
                    hashCode = (hashCode * 59) + this.dCompet.GetHashCode();
                }
                if (this.subst != null)
                {
                    hashCode = (hashCode * 59) + this.subst.GetHashCode();
                }
                if (this.prest != null)
                {
                    hashCode = (hashCode * 59) + this.prest.GetHashCode();
                }
                if (this.toma != null)
                {
                    hashCode = (hashCode * 59) + this.toma.GetHashCode();
                }
                if (this.interm != null)
                {
                    hashCode = (hashCode * 59) + this.interm.GetHashCode();
                }
                if (this.serv != null)
                {
                    hashCode = (hashCode * 59) + this.serv.GetHashCode();
                }
                if (this.valores != null)
                {
                    hashCode = (hashCode * 59) + this.valores.GetHashCode();
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
            // verAplic (string) maxLength
            if (this.verAplic != null && this.verAplic.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for verAplic, length must be less than 20.", new [] { "verAplic" });
            }

            // verAplic (string) minLength
            if (this.verAplic != null && this.verAplic.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for verAplic, length must be greater than 1.", new [] { "verAplic" });
            }

            yield break;
        }
    }

}
