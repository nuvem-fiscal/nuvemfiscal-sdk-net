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
    /// CteSefazFerrov
    /// </summary>
    [DataContract(Name = "CteSefazFerrov")]
    public partial class CteSefazFerrov : IEquatable<CteSefazFerrov>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazFerrov" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazFerrov() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazFerrov" /> class.
        /// </summary>
        /// <param name="tpTraf">Tipo de Tráfego.  Preencher com:        0-Próprio;        1-Mútuo;        2-Rodoferroviário;        3-Rodoviário. (required).</param>
        /// <param name="trafMut">trafMut.</param>
        /// <param name="fluxo">Fluxo Ferroviário.  Trata-se de um número identificador do contrato firmado com o cliente. (required).</param>
        public CteSefazFerrov(int tpTraf = default(int), CteSefazTrafMut trafMut = default(CteSefazTrafMut), string fluxo = default(string))
        {
            this.tpTraf = tpTraf;
            // to ensure "fluxo" is required (not null)
            if (fluxo == null)
            {
                throw new ArgumentNullException("fluxo is a required property for CteSefazFerrov and cannot be null");
            }
            this.fluxo = fluxo;
            this.trafMut = trafMut;
        }

        /// <summary>
        /// Tipo de Tráfego.  Preencher com:        0-Próprio;        1-Mútuo;        2-Rodoferroviário;        3-Rodoviário.
        /// </summary>
        /// <value>Tipo de Tráfego.  Preencher com:        0-Próprio;        1-Mútuo;        2-Rodoferroviário;        3-Rodoviário.</value>
        [DataMember(Name = "tpTraf", IsRequired = true, EmitDefaultValue = false)]
        public int tpTraf { get; set; }

        /// <summary>
        /// Gets or Sets trafMut
        /// </summary>
        [DataMember(Name = "trafMut", EmitDefaultValue = false)]
        public CteSefazTrafMut trafMut { get; set; }

        /// <summary>
        /// Fluxo Ferroviário.  Trata-se de um número identificador do contrato firmado com o cliente.
        /// </summary>
        /// <value>Fluxo Ferroviário.  Trata-se de um número identificador do contrato firmado com o cliente.</value>
        [DataMember(Name = "fluxo", IsRequired = true, EmitDefaultValue = false)]
        public string fluxo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazFerrov {\n");
            sb.Append("  tpTraf: ").Append(tpTraf).Append("\n");
            sb.Append("  trafMut: ").Append(trafMut).Append("\n");
            sb.Append("  fluxo: ").Append(fluxo).Append("\n");
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
            return this.Equals(input as CteSefazFerrov);
        }

        /// <summary>
        /// Returns true if CteSefazFerrov instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazFerrov to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazFerrov input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpTraf == input.tpTraf ||
                    this.tpTraf.Equals(input.tpTraf)
                ) && 
                (
                    this.trafMut == input.trafMut ||
                    (this.trafMut != null &&
                    this.trafMut.Equals(input.trafMut))
                ) && 
                (
                    this.fluxo == input.fluxo ||
                    (this.fluxo != null &&
                    this.fluxo.Equals(input.fluxo))
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
                hashCode = (hashCode * 59) + this.tpTraf.GetHashCode();
                if (this.trafMut != null)
                {
                    hashCode = (hashCode * 59) + this.trafMut.GetHashCode();
                }
                if (this.fluxo != null)
                {
                    hashCode = (hashCode * 59) + this.fluxo.GetHashCode();
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
