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
    /// MdfeSefazInfNFePeri
    /// </summary>
    [DataContract(Name = "MdfeSefazInfNFe_Peri")]
    public partial class MdfeSefazInfNFePeri : IEquatable<MdfeSefazInfNFePeri>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfNFePeri" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfNFePeri() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfNFePeri" /> class.
        /// </summary>
        /// <param name="nONU">Número ONU/UN.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal. (required).</param>
        /// <param name="xNomeAE">Nome apropriado para embarque do produto.  Ver a legislação de transporte de produtos perigosos aplicada ao modo de transporte..</param>
        /// <param name="xClaRisco">Classe ou subclasse/divisão, e risco subsidiário/risco secundário.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal..</param>
        /// <param name="grEmb">Grupo de Embalagem.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal                 Preenchimento obrigatório para o modal aéreo.                 A legislação para o modal rodoviário e ferroviário não atribui grupo de embalagem para todos os produtos, portanto haverá casos de não preenchimento desse campo..</param>
        /// <param name="qTotProd">Quantidade total por produto.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal. (required).</param>
        /// <param name="qVolTipo">Quantidade e Tipo de volumes.  Preencher conforme a legislação de transporte de produtos perigosos aplicada ao modal..</param>
        public MdfeSefazInfNFePeri(string nONU = default(string), string xNomeAE = default(string), string xClaRisco = default(string), string grEmb = default(string), string qTotProd = default(string), string qVolTipo = default(string))
        {
            // to ensure "nONU" is required (not null)
            if (nONU == null)
            {
                throw new ArgumentNullException("nONU is a required property for MdfeSefazInfNFePeri and cannot be null");
            }
            this.nONU = nONU;
            // to ensure "qTotProd" is required (not null)
            if (qTotProd == null)
            {
                throw new ArgumentNullException("qTotProd is a required property for MdfeSefazInfNFePeri and cannot be null");
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
        [DataMember(Name = "xNomeAE", EmitDefaultValue = false)]
        public string xNomeAE { get; set; }

        /// <summary>
        /// Classe ou subclasse/divisão, e risco subsidiário/risco secundário.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.
        /// </summary>
        /// <value>Classe ou subclasse/divisão, e risco subsidiário/risco secundário.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal.</value>
        [DataMember(Name = "xClaRisco", EmitDefaultValue = false)]
        public string xClaRisco { get; set; }

        /// <summary>
        /// Grupo de Embalagem.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal                 Preenchimento obrigatório para o modal aéreo.                 A legislação para o modal rodoviário e ferroviário não atribui grupo de embalagem para todos os produtos, portanto haverá casos de não preenchimento desse campo.
        /// </summary>
        /// <value>Grupo de Embalagem.  Ver a legislação de transporte de produtos perigosos aplicadas ao modal                 Preenchimento obrigatório para o modal aéreo.                 A legislação para o modal rodoviário e ferroviário não atribui grupo de embalagem para todos os produtos, portanto haverá casos de não preenchimento desse campo.</value>
        [DataMember(Name = "grEmb", EmitDefaultValue = false)]
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
        [DataMember(Name = "qVolTipo", EmitDefaultValue = false)]
        public string qVolTipo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfNFePeri {\n");
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
            return this.Equals(input as MdfeSefazInfNFePeri);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfNFePeri instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfNFePeri to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfNFePeri input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
