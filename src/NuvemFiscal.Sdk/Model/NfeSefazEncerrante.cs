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
    /// NfeSefazEncerrante
    /// </summary>
    [DataContract(Name = "NfeSefazEncerrante")]
    public partial class NfeSefazEncerrante : IEquatable<NfeSefazEncerrante>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazEncerrante" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazEncerrante() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazEncerrante" /> class.
        /// </summary>
        /// <param name="nBico">Numero de identificação do Bico utilizado no abastecimento. (required).</param>
        /// <param name="nBomba">Numero de identificação da bomba ao qual o bico está interligado..</param>
        /// <param name="nTanque">Numero de identificação do tanque ao qual o bico está interligado. (required).</param>
        /// <param name="vEncIni">Valor do Encerrante no ínicio do abastecimento. (required).</param>
        /// <param name="vEncFin">Valor do Encerrante no final do abastecimento. (required).</param>
        public NfeSefazEncerrante(int nBico = default(int), int nBomba = default(int), int nTanque = default(int), decimal vEncIni = default(decimal), decimal vEncFin = default(decimal))
        {
            this.nBico = nBico;
            this.nTanque = nTanque;
            this.vEncIni = vEncIni;
            this.vEncFin = vEncFin;
            this.nBomba = nBomba;
        }

        /// <summary>
        /// Numero de identificação do Bico utilizado no abastecimento.
        /// </summary>
        /// <value>Numero de identificação do Bico utilizado no abastecimento.</value>
        [DataMember(Name = "nBico", IsRequired = true, EmitDefaultValue = true)]
        public int nBico { get; set; }

        /// <summary>
        /// Numero de identificação da bomba ao qual o bico está interligado.
        /// </summary>
        /// <value>Numero de identificação da bomba ao qual o bico está interligado.</value>
        [DataMember(Name = "nBomba", EmitDefaultValue = false)]
        public int nBomba { get; set; }

        /// <summary>
        /// Numero de identificação do tanque ao qual o bico está interligado.
        /// </summary>
        /// <value>Numero de identificação do tanque ao qual o bico está interligado.</value>
        [DataMember(Name = "nTanque", IsRequired = true, EmitDefaultValue = true)]
        public int nTanque { get; set; }

        /// <summary>
        /// Valor do Encerrante no ínicio do abastecimento.
        /// </summary>
        /// <value>Valor do Encerrante no ínicio do abastecimento.</value>
        [DataMember(Name = "vEncIni", IsRequired = true, EmitDefaultValue = true)]
        public decimal vEncIni { get; set; }

        /// <summary>
        /// Valor do Encerrante no final do abastecimento.
        /// </summary>
        /// <value>Valor do Encerrante no final do abastecimento.</value>
        [DataMember(Name = "vEncFin", IsRequired = true, EmitDefaultValue = true)]
        public decimal vEncFin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazEncerrante {\n");
            sb.Append("  nBico: ").Append(nBico).Append("\n");
            sb.Append("  nBomba: ").Append(nBomba).Append("\n");
            sb.Append("  nTanque: ").Append(nTanque).Append("\n");
            sb.Append("  vEncIni: ").Append(vEncIni).Append("\n");
            sb.Append("  vEncFin: ").Append(vEncFin).Append("\n");
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
            return this.Equals(input as NfeSefazEncerrante);
        }

        /// <summary>
        /// Returns true if NfeSefazEncerrante instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazEncerrante to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazEncerrante input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nBico == input.nBico ||
                    this.nBico.Equals(input.nBico)
                ) && 
                (
                    this.nBomba == input.nBomba ||
                    this.nBomba.Equals(input.nBomba)
                ) && 
                (
                    this.nTanque == input.nTanque ||
                    this.nTanque.Equals(input.nTanque)
                ) && 
                (
                    this.vEncIni == input.vEncIni ||
                    this.vEncIni.Equals(input.vEncIni)
                ) && 
                (
                    this.vEncFin == input.vEncFin ||
                    this.vEncFin.Equals(input.vEncFin)
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
                hashCode = (hashCode * 59) + this.nBico.GetHashCode();
                hashCode = (hashCode * 59) + this.nBomba.GetHashCode();
                hashCode = (hashCode * 59) + this.nTanque.GetHashCode();
                hashCode = (hashCode * 59) + this.vEncIni.GetHashCode();
                hashCode = (hashCode * 59) + this.vEncFin.GetHashCode();
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
