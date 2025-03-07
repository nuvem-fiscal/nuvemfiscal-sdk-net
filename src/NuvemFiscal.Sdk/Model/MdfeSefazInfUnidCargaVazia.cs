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
    /// Informações das Undades de Carga vazias.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfUnidCargaVazia")]
    public partial class MdfeSefazInfUnidCargaVazia : IEquatable<MdfeSefazInfUnidCargaVazia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfUnidCargaVazia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfUnidCargaVazia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfUnidCargaVazia" /> class.
        /// </summary>
        /// <param name="idUnidCargaVazia">Identificação da unidades de carga vazia. (required).</param>
        /// <param name="tpUnidCargaVazia">Tipo da unidade de carga vazia.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros (required).</param>
        public MdfeSefazInfUnidCargaVazia(string idUnidCargaVazia = default(string), int? tpUnidCargaVazia = default(int?))
        {
            // to ensure "idUnidCargaVazia" is required (not null)
            if (idUnidCargaVazia == null)
            {
                throw new ArgumentNullException("idUnidCargaVazia is a required property for MdfeSefazInfUnidCargaVazia and cannot be null");
            }
            this.idUnidCargaVazia = idUnidCargaVazia;
            // to ensure "tpUnidCargaVazia" is required (not null)
            if (tpUnidCargaVazia == null)
            {
                throw new ArgumentNullException("tpUnidCargaVazia is a required property for MdfeSefazInfUnidCargaVazia and cannot be null");
            }
            this.tpUnidCargaVazia = tpUnidCargaVazia;
        }

        /// <summary>
        /// Identificação da unidades de carga vazia.
        /// </summary>
        /// <value>Identificação da unidades de carga vazia.</value>
        [DataMember(Name = "idUnidCargaVazia", IsRequired = true, EmitDefaultValue = true)]
        public string idUnidCargaVazia { get; set; }

        /// <summary>
        /// Tipo da unidade de carga vazia.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros
        /// </summary>
        /// <value>Tipo da unidade de carga vazia.  * 1 - Container  * 2 - ULD  * 3 - Pallet  * 4 - Outros</value>
        [DataMember(Name = "tpUnidCargaVazia", IsRequired = true, EmitDefaultValue = true)]
        public int? tpUnidCargaVazia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfUnidCargaVazia {\n");
            sb.Append("  idUnidCargaVazia: ").Append(idUnidCargaVazia).Append("\n");
            sb.Append("  tpUnidCargaVazia: ").Append(tpUnidCargaVazia).Append("\n");
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
            return this.Equals(input as MdfeSefazInfUnidCargaVazia);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfUnidCargaVazia instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfUnidCargaVazia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfUnidCargaVazia input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.idUnidCargaVazia == input.idUnidCargaVazia ||
                    (this.idUnidCargaVazia != null &&
                    this.idUnidCargaVazia.Equals(input.idUnidCargaVazia))
                ) && 
                (
                    this.tpUnidCargaVazia == input.tpUnidCargaVazia ||
                    (this.tpUnidCargaVazia != null &&
                    this.tpUnidCargaVazia.Equals(input.tpUnidCargaVazia))
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
                if (this.idUnidCargaVazia != null)
                {
                    hashCode = (hashCode * 59) + this.idUnidCargaVazia.GetHashCode();
                }
                if (this.tpUnidCargaVazia != null)
                {
                    hashCode = (hashCode * 59) + this.tpUnidCargaVazia.GetHashCode();
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
            // idUnidCargaVazia (string) maxLength
            if (this.idUnidCargaVazia != null && this.idUnidCargaVazia.Length > 20)
            {
                yield return new ValidationResult("Invalid value for idUnidCargaVazia, length must be less than 20.", new [] { "idUnidCargaVazia" });
            }

            // idUnidCargaVazia (string) minLength
            if (this.idUnidCargaVazia != null && this.idUnidCargaVazia.Length < 1)
            {
                yield return new ValidationResult("Invalid value for idUnidCargaVazia, length must be greater than 1.", new [] { "idUnidCargaVazia" });
            }

            yield break;
        }
    }

}
