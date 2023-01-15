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
    /// Informações da localização de descarregamento do MDF-e de carga lotação.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfLocalDescarrega")]
    public partial class MdfeSefazInfLocalDescarrega : IEquatable<MdfeSefazInfLocalDescarrega>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfLocalDescarrega" /> class.
        /// </summary>
        /// <param name="cEP">CEP onde foi descarregado o MDF-e.  Informar zeros não significativos..</param>
        /// <param name="latitude">Latitude do ponto geográfico onde foi descarregado o MDF-e..</param>
        /// <param name="longitude">Latitude do ponto geográfico onde foi descarregado o MDF-e..</param>
        public MdfeSefazInfLocalDescarrega(string cEP = default(string), string latitude = default(string), string longitude = default(string))
        {
            this.CEP = cEP;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        /// <summary>
        /// CEP onde foi descarregado o MDF-e.  Informar zeros não significativos.
        /// </summary>
        /// <value>CEP onde foi descarregado o MDF-e.  Informar zeros não significativos.</value>
        [DataMember(Name = "CEP", EmitDefaultValue = false)]
        public string CEP { get; set; }

        /// <summary>
        /// Latitude do ponto geográfico onde foi descarregado o MDF-e.
        /// </summary>
        /// <value>Latitude do ponto geográfico onde foi descarregado o MDF-e.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public string latitude { get; set; }

        /// <summary>
        /// Latitude do ponto geográfico onde foi descarregado o MDF-e.
        /// </summary>
        /// <value>Latitude do ponto geográfico onde foi descarregado o MDF-e.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public string longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfLocalDescarrega {\n");
            sb.Append("  CEP: ").Append(CEP).Append("\n");
            sb.Append("  latitude: ").Append(latitude).Append("\n");
            sb.Append("  longitude: ").Append(longitude).Append("\n");
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
            return this.Equals(input as MdfeSefazInfLocalDescarrega);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfLocalDescarrega instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfLocalDescarrega to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfLocalDescarrega input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CEP == input.CEP ||
                    (this.CEP != null &&
                    this.CEP.Equals(input.CEP))
                ) && 
                (
                    this.latitude == input.latitude ||
                    (this.latitude != null &&
                    this.latitude.Equals(input.latitude))
                ) && 
                (
                    this.longitude == input.longitude ||
                    (this.longitude != null &&
                    this.longitude.Equals(input.longitude))
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
                if (this.CEP != null)
                {
                    hashCode = (hashCode * 59) + this.CEP.GetHashCode();
                }
                if (this.latitude != null)
                {
                    hashCode = (hashCode * 59) + this.latitude.GetHashCode();
                }
                if (this.longitude != null)
                {
                    hashCode = (hashCode * 59) + this.longitude.GetHashCode();
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
