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
    /// CteSefazEndeEmi
    /// </summary>
    [DataContract(Name = "CteSefazEndeEmi")]
    public partial class CteSefazEndeEmi : IEquatable<CteSefazEndeEmi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEndeEmi" /> class.
        /// </summary>
        /// <param name="xLgr">Logradouro.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="nro">Número.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="xCpl">Complemento.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="xBairro">Bairro.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="cMun">Código do município (utilizar a tabela do IBGE).  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="xMun">Nome do município.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="cEP">CEP.  Informar zeros não significativos.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="uF">Sigla da UF.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        /// <param name="fone">Telefone.  Caso não seja informado, será utilizado o do cadastro da empresa..</param>
        public CteSefazEndeEmi(string xLgr = default(string), string nro = default(string), string xCpl = default(string), string xBairro = default(string), string cMun = default(string), string xMun = default(string), string cEP = default(string), string uF = default(string), string fone = default(string))
        {
            this.xLgr = xLgr;
            this.nro = nro;
            this.xCpl = xCpl;
            this.xBairro = xBairro;
            this.cMun = cMun;
            this.xMun = xMun;
            this.CEP = cEP;
            this.UF = uF;
            this.fone = fone;
        }

        /// <summary>
        /// Logradouro.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Logradouro.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xLgr", EmitDefaultValue = false)]
        public string xLgr { get; set; }

        /// <summary>
        /// Número.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Número.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "nro", EmitDefaultValue = false)]
        public string nro { get; set; }

        /// <summary>
        /// Complemento.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Complemento.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xCpl", EmitDefaultValue = false)]
        public string xCpl { get; set; }

        /// <summary>
        /// Bairro.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Bairro.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xBairro", EmitDefaultValue = false)]
        public string xBairro { get; set; }

        /// <summary>
        /// Código do município (utilizar a tabela do IBGE).  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Código do município (utilizar a tabela do IBGE).  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "cMun", EmitDefaultValue = false)]
        public string cMun { get; set; }

        /// <summary>
        /// Nome do município.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Nome do município.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "xMun", EmitDefaultValue = false)]
        public string xMun { get; set; }

        /// <summary>
        /// CEP.  Informar zeros não significativos.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>CEP.  Informar zeros não significativos.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "CEP", EmitDefaultValue = false)]
        public string CEP { get; set; }

        /// <summary>
        /// Sigla da UF.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Sigla da UF.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "UF", EmitDefaultValue = false)]
        public string UF { get; set; }

        /// <summary>
        /// Telefone.  Caso não seja informado, será utilizado o do cadastro da empresa.
        /// </summary>
        /// <value>Telefone.  Caso não seja informado, será utilizado o do cadastro da empresa.</value>
        [DataMember(Name = "fone", EmitDefaultValue = false)]
        public string fone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazEndeEmi {\n");
            sb.Append("  xLgr: ").Append(xLgr).Append("\n");
            sb.Append("  nro: ").Append(nro).Append("\n");
            sb.Append("  xCpl: ").Append(xCpl).Append("\n");
            sb.Append("  xBairro: ").Append(xBairro).Append("\n");
            sb.Append("  cMun: ").Append(cMun).Append("\n");
            sb.Append("  xMun: ").Append(xMun).Append("\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
            sb.Append("  UF: ").Append(UF).Append("\n");
            sb.Append("  fone: ").Append(fone).Append("\n");
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
            return this.Equals(input as CteSefazEndeEmi);
        }

        /// <summary>
        /// Returns true if CteSefazEndeEmi instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazEndeEmi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazEndeEmi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xLgr == input.xLgr ||
                    (this.xLgr != null &&
                    this.xLgr.Equals(input.xLgr))
                ) && 
                (
                    this.nro == input.nro ||
                    (this.nro != null &&
                    this.nro.Equals(input.nro))
                ) && 
                (
                    this.xCpl == input.xCpl ||
                    (this.xCpl != null &&
                    this.xCpl.Equals(input.xCpl))
                ) && 
                (
                    this.xBairro == input.xBairro ||
                    (this.xBairro != null &&
                    this.xBairro.Equals(input.xBairro))
                ) && 
                (
                    this.cMun == input.cMun ||
                    (this.cMun != null &&
                    this.cMun.Equals(input.cMun))
                ) && 
                (
                    this.xMun == input.xMun ||
                    (this.xMun != null &&
                    this.xMun.Equals(input.xMun))
                ) && 
                (
                    this.CEP == input.CEP ||
                    (this.CEP != null &&
                    this.CEP.Equals(input.CEP))
                ) && 
                (
                    this.UF == input.UF ||
                    (this.UF != null &&
                    this.UF.Equals(input.UF))
                ) && 
                (
                    this.fone == input.fone ||
                    (this.fone != null &&
                    this.fone.Equals(input.fone))
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
                if (this.xLgr != null)
                {
                    hashCode = (hashCode * 59) + this.xLgr.GetHashCode();
                }
                if (this.nro != null)
                {
                    hashCode = (hashCode * 59) + this.nro.GetHashCode();
                }
                if (this.xCpl != null)
                {
                    hashCode = (hashCode * 59) + this.xCpl.GetHashCode();
                }
                if (this.xBairro != null)
                {
                    hashCode = (hashCode * 59) + this.xBairro.GetHashCode();
                }
                if (this.cMun != null)
                {
                    hashCode = (hashCode * 59) + this.cMun.GetHashCode();
                }
                if (this.xMun != null)
                {
                    hashCode = (hashCode * 59) + this.xMun.GetHashCode();
                }
                if (this.CEP != null)
                {
                    hashCode = (hashCode * 59) + this.CEP.GetHashCode();
                }
                if (this.UF != null)
                {
                    hashCode = (hashCode * 59) + this.UF.GetHashCode();
                }
                if (this.fone != null)
                {
                    hashCode = (hashCode * 59) + this.fone.GetHashCode();
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
