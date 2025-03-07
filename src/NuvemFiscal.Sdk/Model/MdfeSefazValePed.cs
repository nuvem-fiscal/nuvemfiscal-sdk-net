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
    /// Informações de Vale Pedágio.  Outras informações sobre Vale-Pedágio obrigatório que não tenham campos específicos devem ser informadas no campo de observações gerais de uso livre pelo contribuinte, visando atender as determinações legais vigentes.
    /// </summary>
    [DataContract(Name = "MdfeSefazValePed")]
    public partial class MdfeSefazValePed : IEquatable<MdfeSefazValePed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazValePed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazValePed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazValePed" /> class.
        /// </summary>
        /// <param name="disp">disp (required).</param>
        /// <param name="categCombVeic">Categoria de Combinação Veicular.  Preencher com:  02 Veículo Comercial 2 eixos  0  4 Veículo Comercial 3 eixos  06 Veículo Comercial 4 eixos  0  7 Veículo Comercial 5 eixos  0  8 Veículo Comercial 6 eixos  10 Veículo Comercial 7 eixos  11 Veículo Comercial 8 eixos  12 Veículo Comercial 9 eixos  13 Veículo Comercial 10 eixos  14 Veículo Comercial Acima de 10 eixos..</param>
        public MdfeSefazValePed(List<MdfeSefazDisp> disp = default(List<MdfeSefazDisp>), string categCombVeic = default(string))
        {
            // to ensure "disp" is required (not null)
            if (disp == null)
            {
                throw new ArgumentNullException("disp is a required property for MdfeSefazValePed and cannot be null");
            }
            this.disp = disp;
            this.categCombVeic = categCombVeic;
        }

        /// <summary>
        /// Gets or Sets disp
        /// </summary>
        [DataMember(Name = "disp", IsRequired = true, EmitDefaultValue = true)]
        public List<MdfeSefazDisp> disp { get; set; }

        /// <summary>
        /// Categoria de Combinação Veicular.  Preencher com:  02 Veículo Comercial 2 eixos  0  4 Veículo Comercial 3 eixos  06 Veículo Comercial 4 eixos  0  7 Veículo Comercial 5 eixos  0  8 Veículo Comercial 6 eixos  10 Veículo Comercial 7 eixos  11 Veículo Comercial 8 eixos  12 Veículo Comercial 9 eixos  13 Veículo Comercial 10 eixos  14 Veículo Comercial Acima de 10 eixos.
        /// </summary>
        /// <value>Categoria de Combinação Veicular.  Preencher com:  02 Veículo Comercial 2 eixos  0  4 Veículo Comercial 3 eixos  06 Veículo Comercial 4 eixos  0  7 Veículo Comercial 5 eixos  0  8 Veículo Comercial 6 eixos  10 Veículo Comercial 7 eixos  11 Veículo Comercial 8 eixos  12 Veículo Comercial 9 eixos  13 Veículo Comercial 10 eixos  14 Veículo Comercial Acima de 10 eixos.</value>
        [DataMember(Name = "categCombVeic", EmitDefaultValue = true)]
        public string categCombVeic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazValePed {\n");
            sb.Append("  disp: ").Append(disp).Append("\n");
            sb.Append("  categCombVeic: ").Append(categCombVeic).Append("\n");
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
            return this.Equals(input as MdfeSefazValePed);
        }

        /// <summary>
        /// Returns true if MdfeSefazValePed instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazValePed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazValePed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.disp == input.disp ||
                    this.disp != null &&
                    input.disp != null &&
                    this.disp.SequenceEqual(input.disp)
                ) && 
                (
                    this.categCombVeic == input.categCombVeic ||
                    (this.categCombVeic != null &&
                    this.categCombVeic.Equals(input.categCombVeic))
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
                if (this.disp != null)
                {
                    hashCode = (hashCode * 59) + this.disp.GetHashCode();
                }
                if (this.categCombVeic != null)
                {
                    hashCode = (hashCode * 59) + this.categCombVeic.GetHashCode();
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
            yield break;
        }
    }

}
