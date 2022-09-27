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
    /// MdfeSefazVeicReboqueProp
    /// </summary>
    [DataContract(Name = "MdfeSefazVeicReboque_Prop")]
    public partial class MdfeSefazVeicReboqueProp : IEquatable<MdfeSefazVeicReboqueProp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazVeicReboqueProp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazVeicReboqueProp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazVeicReboqueProp" /> class.
        /// </summary>
        /// <param name="cPF">Número do CPF.  Informar os zeros não significativos..</param>
        /// <param name="cNPJ">Número do CNPJ.  Informar os zeros não significativos..</param>
        /// <param name="rNTRC">Registro Nacional dos Transportadores Rodoviários de Carga.  Registro obrigatório do proprietário, co-proprietário ou arrendatário do veículo junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração. (required).</param>
        /// <param name="xNome">Razão Social ou Nome do proprietário. (required).</param>
        /// <param name="iE">Inscrição Estadual..</param>
        /// <param name="uF">UF..</param>
        /// <param name="tpProp">Tipo Proprietário ou possuidor.  Preencher com:              0-TAC Agregado;              1-TAC Independente;              2 – Outros. (required).</param>
        public MdfeSefazVeicReboqueProp(string cPF = default(string), string cNPJ = default(string), string rNTRC = default(string), string xNome = default(string), string iE = default(string), string uF = default(string), int tpProp = default(int))
        {
            // to ensure "rNTRC" is required (not null)
            if (rNTRC == null)
            {
                throw new ArgumentNullException("rNTRC is a required property for MdfeSefazVeicReboqueProp and cannot be null");
            }
            this.RNTRC = rNTRC;
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for MdfeSefazVeicReboqueProp and cannot be null");
            }
            this.xNome = xNome;
            this.tpProp = tpProp;
            this.CPF = cPF;
            this.CNPJ = cNPJ;
            this.IE = iE;
            this.UF = uF;
        }

        /// <summary>
        /// Número do CPF.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CPF.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = false)]
        public string CPF { get; set; }

        /// <summary>
        /// Número do CNPJ.  Informar os zeros não significativos.
        /// </summary>
        /// <value>Número do CNPJ.  Informar os zeros não significativos.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = false)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Registro Nacional dos Transportadores Rodoviários de Carga.  Registro obrigatório do proprietário, co-proprietário ou arrendatário do veículo junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração.
        /// </summary>
        /// <value>Registro Nacional dos Transportadores Rodoviários de Carga.  Registro obrigatório do proprietário, co-proprietário ou arrendatário do veículo junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração.</value>
        [DataMember(Name = "RNTRC", IsRequired = true, EmitDefaultValue = true)]
        public string RNTRC { get; set; }

        /// <summary>
        /// Razão Social ou Nome do proprietário.
        /// </summary>
        /// <value>Razão Social ou Nome do proprietário.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Inscrição Estadual.
        /// </summary>
        /// <value>Inscrição Estadual.</value>
        [DataMember(Name = "IE", EmitDefaultValue = false)]
        public string IE { get; set; }

        /// <summary>
        /// UF.
        /// </summary>
        /// <value>UF.</value>
        [DataMember(Name = "UF", EmitDefaultValue = false)]
        public string UF { get; set; }

        /// <summary>
        /// Tipo Proprietário ou possuidor.  Preencher com:              0-TAC Agregado;              1-TAC Independente;              2 – Outros.
        /// </summary>
        /// <value>Tipo Proprietário ou possuidor.  Preencher com:              0-TAC Agregado;              1-TAC Independente;              2 – Outros.</value>
        [DataMember(Name = "tpProp", IsRequired = true, EmitDefaultValue = true)]
        public int tpProp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazVeicReboqueProp {\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  RNTRC: ").Append(RNTRC).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
            sb.Append("  IE: ").Append(IE).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  tpProp: ").Append(tpProp).Append("\n");
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
            return this.Equals(input as MdfeSefazVeicReboqueProp);
        }

        /// <summary>
        /// Returns true if MdfeSefazVeicReboqueProp instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazVeicReboqueProp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazVeicReboqueProp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.RNTRC == input.RNTRC ||
                    (this.RNTRC != null &&
                    this.RNTRC.Equals(input.RNTRC))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
                ) && 
                (
                    this.IE == input.IE ||
                    (this.IE != null &&
                    this.IE.Equals(input.IE))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.tpProp == input.tpProp ||
                    this.tpProp.Equals(input.tpProp)
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
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.RNTRC != null)
                {
                    hashCode = (hashCode * 59) + this.RNTRC.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
                }
                if (this.IE != null)
                {
                    hashCode = (hashCode * 59) + this.IE.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpProp.GetHashCode();
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
