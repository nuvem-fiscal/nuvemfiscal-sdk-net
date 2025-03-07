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
    /// Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMDFeTransp_Peri")]
    public partial class MdfeSefazInfMDFeTranspPeri : IEquatable<MdfeSefazInfMDFeTranspPeri>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFeTranspPeri" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfMDFeTranspPeri() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMDFeTranspPeri" /> class.
        /// </summary>
        /// <param name="nONU">Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal. (required).</param>
        /// <param name="xNomeAE">Nome apropriado para embarque do produto.  Ver a legislação de transporte de produtos perigosos aplicada ao modo de transporte..</param>
        /// <param name="xClaRisco">Classe ou subclasse/divisão, e risco subsidiário/risco secundário.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal..</param>
        /// <param name="grEmb">Grupo de Embalagem.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal  Preenchimento obrigatório para o modal aéreo.  A legislação para o modal rodoviário e ferroviário não atribui grupo de embalagem para todos os produtos, portanto haverá casos de não preenchimento desse campo..</param>
        /// <param name="qTotProd">Quantidade total por produto.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal. (required).</param>
        /// <param name="qVolTipo">Quantidade e Tipo de volumes.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal..</param>
        public MdfeSefazInfMDFeTranspPeri(string nONU = default(string), string xNomeAE = default(string), string xClaRisco = default(string), string grEmb = default(string), string qTotProd = default(string), string qVolTipo = default(string))
        {
            // to ensure "nONU" is required (not null)
            if (nONU == null)
            {
                throw new ArgumentNullException("nONU is a required property for MdfeSefazInfMDFeTranspPeri and cannot be null");
            }
            this.nONU = nONU;
            // to ensure "qTotProd" is required (not null)
            if (qTotProd == null)
            {
                throw new ArgumentNullException("qTotProd is a required property for MdfeSefazInfMDFeTranspPeri and cannot be null");
            }
            this.qTotProd = qTotProd;
            this.xNomeAE = xNomeAE;
            this.xClaRisco = xClaRisco;
            this.grEmb = grEmb;
            this.qVolTipo = qVolTipo;
        }

        /// <summary>
        /// Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.
        /// </summary>
        /// <value>Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.</value>
        [DataMember(Name = "nONU", IsRequired = true, EmitDefaultValue = true)]
        public string nONU { get; set; }

        /// <summary>
        /// Nome apropriado para embarque do produto.  Ver a legislação de transporte de produtos perigosos aplicada ao modo de transporte.
        /// </summary>
        /// <value>Nome apropriado para embarque do produto.  Ver a legislação de transporte de produtos perigosos aplicada ao modo de transporte.</value>
        [DataMember(Name = "xNomeAE", EmitDefaultValue = true)]
        public string xNomeAE { get; set; }

        /// <summary>
        /// Classe ou subclasse/divisão, e risco subsidiário/risco secundário.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.
        /// </summary>
        /// <value>Classe ou subclasse/divisão, e risco subsidiário/risco secundário.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.</value>
        [DataMember(Name = "xClaRisco", EmitDefaultValue = true)]
        public string xClaRisco { get; set; }

        /// <summary>
        /// Grupo de Embalagem.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal  Preenchimento obrigatório para o modal aéreo.  A legislação para o modal rodoviário e ferroviário não atribui grupo de embalagem para todos os produtos, portanto haverá casos de não preenchimento desse campo.
        /// </summary>
        /// <value>Grupo de Embalagem.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal  Preenchimento obrigatório para o modal aéreo.  A legislação para o modal rodoviário e ferroviário não atribui grupo de embalagem para todos os produtos, portanto haverá casos de não preenchimento desse campo.</value>
        [DataMember(Name = "grEmb", EmitDefaultValue = true)]
        public string grEmb { get; set; }

        /// <summary>
        /// Quantidade total por produto.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal.
        /// </summary>
        /// <value>Quantidade total por produto.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal.</value>
        [DataMember(Name = "qTotProd", IsRequired = true, EmitDefaultValue = true)]
        public string qTotProd { get; set; }

        /// <summary>
        /// Quantidade e Tipo de volumes.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal.
        /// </summary>
        /// <value>Quantidade e Tipo de volumes.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal.</value>
        [DataMember(Name = "qVolTipo", EmitDefaultValue = true)]
        public string qVolTipo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMDFeTranspPeri {\n");
            sb.Append("  nONU: ").Append(nONU).Append("\n");
            sb.Append("  xNomeAE: ").Append(xNomeAE).Append("\n");
            sb.Append("  xClaRisco: ").Append(xClaRisco).Append("\n");
            sb.Append("  grEmb: ").Append(grEmb).Append("\n");
            sb.Append("  qTotProd: ").Append(qTotProd).Append("\n");
            sb.Append("  qVolTipo: ").Append(qVolTipo).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMDFeTranspPeri);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMDFeTranspPeri instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMDFeTranspPeri to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMDFeTranspPeri input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nONU == input.nONU ||
                    (this.nONU != null &&
                    this.nONU.Equals(input.nONU))
                ) && 
                (
                    this.xNomeAE == input.xNomeAE ||
                    (this.xNomeAE != null &&
                    this.xNomeAE.Equals(input.xNomeAE))
                ) && 
                (
                    this.xClaRisco == input.xClaRisco ||
                    (this.xClaRisco != null &&
                    this.xClaRisco.Equals(input.xClaRisco))
                ) && 
                (
                    this.grEmb == input.grEmb ||
                    (this.grEmb != null &&
                    this.grEmb.Equals(input.grEmb))
                ) && 
                (
                    this.qTotProd == input.qTotProd ||
                    (this.qTotProd != null &&
                    this.qTotProd.Equals(input.qTotProd))
                ) && 
                (
                    this.qVolTipo == input.qVolTipo ||
                    (this.qVolTipo != null &&
                    this.qVolTipo.Equals(input.qVolTipo))
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
                if (this.nONU != null)
                {
                    hashCode = (hashCode * 59) + this.nONU.GetHashCode();
                }
                if (this.xNomeAE != null)
                {
                    hashCode = (hashCode * 59) + this.xNomeAE.GetHashCode();
                }
                if (this.xClaRisco != null)
                {
                    hashCode = (hashCode * 59) + this.xClaRisco.GetHashCode();
                }
                if (this.grEmb != null)
                {
                    hashCode = (hashCode * 59) + this.grEmb.GetHashCode();
                }
                if (this.qTotProd != null)
                {
                    hashCode = (hashCode * 59) + this.qTotProd.GetHashCode();
                }
                if (this.qVolTipo != null)
                {
                    hashCode = (hashCode * 59) + this.qVolTipo.GetHashCode();
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
            // xNomeAE (string) maxLength
            if (this.xNomeAE != null && this.xNomeAE.Length > 150)
            {
                yield return new ValidationResult("Invalid value for xNomeAE, length must be less than 150.", new [] { "xNomeAE" });
            }

            // xNomeAE (string) minLength
            if (this.xNomeAE != null && this.xNomeAE.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xNomeAE, length must be greater than 1.", new [] { "xNomeAE" });
            }

            // xClaRisco (string) maxLength
            if (this.xClaRisco != null && this.xClaRisco.Length > 40)
            {
                yield return new ValidationResult("Invalid value for xClaRisco, length must be less than 40.", new [] { "xClaRisco" });
            }

            // xClaRisco (string) minLength
            if (this.xClaRisco != null && this.xClaRisco.Length < 1)
            {
                yield return new ValidationResult("Invalid value for xClaRisco, length must be greater than 1.", new [] { "xClaRisco" });
            }

            // grEmb (string) maxLength
            if (this.grEmb != null && this.grEmb.Length > 6)
            {
                yield return new ValidationResult("Invalid value for grEmb, length must be less than 6.", new [] { "grEmb" });
            }

            // grEmb (string) minLength
            if (this.grEmb != null && this.grEmb.Length < 1)
            {
                yield return new ValidationResult("Invalid value for grEmb, length must be greater than 1.", new [] { "grEmb" });
            }

            // qTotProd (string) maxLength
            if (this.qTotProd != null && this.qTotProd.Length > 20)
            {
                yield return new ValidationResult("Invalid value for qTotProd, length must be less than 20.", new [] { "qTotProd" });
            }

            // qTotProd (string) minLength
            if (this.qTotProd != null && this.qTotProd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for qTotProd, length must be greater than 1.", new [] { "qTotProd" });
            }

            // qVolTipo (string) maxLength
            if (this.qVolTipo != null && this.qVolTipo.Length > 60)
            {
                yield return new ValidationResult("Invalid value for qVolTipo, length must be less than 60.", new [] { "qVolTipo" });
            }

            // qVolTipo (string) minLength
            if (this.qVolTipo != null && this.qVolTipo.Length < 1)
            {
                yield return new ValidationResult("Invalid value for qVolTipo, length must be greater than 1.", new [] { "qVolTipo" });
            }

            yield break;
        }
    }

}
