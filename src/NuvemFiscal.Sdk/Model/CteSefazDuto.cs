/*
 * API Nuvem Fiscal
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
    /// CteSefazDuto
    /// </summary>
    [DataContract(Name = "CteSefazDuto")]
    public partial class CteSefazDuto : IEquatable<CteSefazDuto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDuto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazDuto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazDuto" /> class.
        /// </summary>
        /// <param name="vTar">Valor da tarifa..</param>
        /// <param name="dIni">Data de Início da prestação do serviço. (required).</param>
        /// <param name="dFim">Data de Fim da prestação do serviço. (required).</param>
        public CteSefazDuto(decimal vTar = default(decimal), DateTime dIni = default(DateTime), DateTime dFim = default(DateTime))
        {
            this.dIni = dIni;
            this.dFim = dFim;
            this.vTar = vTar;
        }

        /// <summary>
        /// Valor da tarifa.
        /// </summary>
        /// <value>Valor da tarifa.</value>
        [DataMember(Name = "vTar", EmitDefaultValue = false)]
        public decimal vTar { get; set; }

        /// <summary>
        /// Data de Início da prestação do serviço.
        /// </summary>
        /// <value>Data de Início da prestação do serviço.</value>
        [DataMember(Name = "dIni", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dIni { get; set; }

        /// <summary>
        /// Data de Fim da prestação do serviço.
        /// </summary>
        /// <value>Data de Fim da prestação do serviço.</value>
        [DataMember(Name = "dFim", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dFim { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazDuto {\n");
            sb.Append("  vTar: ").Append(vTar).Append("\n");
            sb.Append("  dIni: ").Append(dIni).Append("\n");
            sb.Append("  dFim: ").Append(dFim).Append("\n");
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
            return this.Equals(input as CteSefazDuto);
        }

        /// <summary>
        /// Returns true if CteSefazDuto instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazDuto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazDuto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vTar == input.vTar ||
                    this.vTar.Equals(input.vTar)
                ) && 
                (
                    this.dIni == input.dIni ||
                    (this.dIni != null &&
                    this.dIni.Equals(input.dIni))
                ) && 
                (
                    this.dFim == input.dFim ||
                    (this.dFim != null &&
                    this.dFim.Equals(input.dFim))
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
                hashCode = (hashCode * 59) + this.vTar.GetHashCode();
                if (this.dIni != null)
                {
                    hashCode = (hashCode * 59) + this.dIni.GetHashCode();
                }
                if (this.dFim != null)
                {
                    hashCode = (hashCode * 59) + this.dFim.GetHashCode();
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