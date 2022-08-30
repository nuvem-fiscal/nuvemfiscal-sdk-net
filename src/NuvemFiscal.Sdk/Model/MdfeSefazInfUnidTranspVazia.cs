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
    /// MdfeSefazInfUnidTranspVazia
    /// </summary>
    [DataContract(Name = "MdfeSefazInfUnidTranspVazia")]
    public partial class MdfeSefazInfUnidTranspVazia : IEquatable<MdfeSefazInfUnidTranspVazia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfUnidTranspVazia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfUnidTranspVazia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfUnidTranspVazia" /> class.
        /// </summary>
        /// <param name="idUnidTranspVazia">Identificação da unidades de transporte vazia. (required).</param>
        /// <param name="tpUnidTranspVazia">Tipo da unidade de transporte vazia.  Deve ser preenchido com “1” para Rodoviário Tração do tipo caminhão ou “2” para Rodoviário reboque do tipo carreta. (required).</param>
        public MdfeSefazInfUnidTranspVazia(string idUnidTranspVazia = default(string), int tpUnidTranspVazia = default(int))
        {
            // to ensure "idUnidTranspVazia" is required (not null)
            if (idUnidTranspVazia == null)
            {
                throw new ArgumentNullException("idUnidTranspVazia is a required property for MdfeSefazInfUnidTranspVazia and cannot be null");
            }
            this.idUnidTranspVazia = idUnidTranspVazia;
            this.tpUnidTranspVazia = tpUnidTranspVazia;
        }

        /// <summary>
        /// Identificação da unidades de transporte vazia.
        /// </summary>
        /// <value>Identificação da unidades de transporte vazia.</value>
        [DataMember(Name = "idUnidTranspVazia", IsRequired = true, EmitDefaultValue = false)]
        public string idUnidTranspVazia { get; set; }

        /// <summary>
        /// Tipo da unidade de transporte vazia.  Deve ser preenchido com “1” para Rodoviário Tração do tipo caminhão ou “2” para Rodoviário reboque do tipo carreta.
        /// </summary>
        /// <value>Tipo da unidade de transporte vazia.  Deve ser preenchido com “1” para Rodoviário Tração do tipo caminhão ou “2” para Rodoviário reboque do tipo carreta.</value>
        [DataMember(Name = "tpUnidTranspVazia", IsRequired = true, EmitDefaultValue = false)]
        public int tpUnidTranspVazia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfUnidTranspVazia {\n");
            sb.Append("  idUnidTranspVazia: ").Append(idUnidTranspVazia).Append("\n");
            sb.Append("  tpUnidTranspVazia: ").Append(tpUnidTranspVazia).Append("\n");
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
            return this.Equals(input as MdfeSefazInfUnidTranspVazia);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfUnidTranspVazia instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfUnidTranspVazia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfUnidTranspVazia input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.idUnidTranspVazia == input.idUnidTranspVazia ||
                    (this.idUnidTranspVazia != null &&
                    this.idUnidTranspVazia.Equals(input.idUnidTranspVazia))
                ) && 
                (
                    this.tpUnidTranspVazia == input.tpUnidTranspVazia ||
                    this.tpUnidTranspVazia.Equals(input.tpUnidTranspVazia)
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
                if (this.idUnidTranspVazia != null)
                {
                    hashCode = (hashCode * 59) + this.idUnidTranspVazia.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.tpUnidTranspVazia.GetHashCode();
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
