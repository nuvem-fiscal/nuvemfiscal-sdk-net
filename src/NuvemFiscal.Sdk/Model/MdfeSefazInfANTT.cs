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
    /// Grupo de informações para Agência Reguladora.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfANTT")]
    public partial class MdfeSefazInfANTT : IEquatable<MdfeSefazInfANTT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfANTT" /> class.
        /// </summary>
        /// <param name="rNTRC">Registro Nacional de Transportadores Rodoviários de Carga.  Registro obrigatório do emitente do MDF-e junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração..</param>
        /// <param name="infCIOT">infCIOT.</param>
        /// <param name="valePed">valePed.</param>
        /// <param name="infContratante">infContratante.</param>
        /// <param name="infPag">infPag.</param>
        public MdfeSefazInfANTT(string rNTRC = default(string), List<MdfeSefazInfCIOT> infCIOT = default(List<MdfeSefazInfCIOT>), MdfeSefazValePed valePed = default(MdfeSefazValePed), List<MdfeSefazInfContratante> infContratante = default(List<MdfeSefazInfContratante>), List<MdfeSefazInfPag> infPag = default(List<MdfeSefazInfPag>))
        {
            this.RNTRC = rNTRC;
            this.infCIOT = infCIOT;
            this.valePed = valePed;
            this.infContratante = infContratante;
            this.infPag = infPag;
        }

        /// <summary>
        /// Registro Nacional de Transportadores Rodoviários de Carga.  Registro obrigatório do emitente do MDF-e junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração.
        /// </summary>
        /// <value>Registro Nacional de Transportadores Rodoviários de Carga.  Registro obrigatório do emitente do MDF-e junto à ANTT para exercer a atividade de transportador rodoviário de cargas por conta de terceiros e mediante remuneração.</value>
        [DataMember(Name = "RNTRC", EmitDefaultValue = true)]
        public string RNTRC { get; set; }

        /// <summary>
        /// Gets or Sets infCIOT
        /// </summary>
        [DataMember(Name = "infCIOT", EmitDefaultValue = false)]
        public List<MdfeSefazInfCIOT> infCIOT { get; set; }

        /// <summary>
        /// Gets or Sets valePed
        /// </summary>
        [DataMember(Name = "valePed", EmitDefaultValue = false)]
        public MdfeSefazValePed valePed { get; set; }

        /// <summary>
        /// Gets or Sets infContratante
        /// </summary>
        [DataMember(Name = "infContratante", EmitDefaultValue = false)]
        public List<MdfeSefazInfContratante> infContratante { get; set; }

        /// <summary>
        /// Gets or Sets infPag
        /// </summary>
        [DataMember(Name = "infPag", EmitDefaultValue = false)]
        public List<MdfeSefazInfPag> infPag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfANTT {\n");
            sb.Append("  RNTRC: ").Append(RNTRC).Append("\n");
            sb.Append("  infCIOT: ").Append(infCIOT).Append("\n");
            sb.Append("  valePed: ").Append(valePed).Append("\n");
            sb.Append("  infContratante: ").Append(infContratante).Append("\n");
            sb.Append("  infPag: ").Append(infPag).Append("\n");
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
            return this.Equals(input as MdfeSefazInfANTT);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfANTT instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfANTT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfANTT input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RNTRC == input.RNTRC ||
                    (this.RNTRC != null &&
                    this.RNTRC.Equals(input.RNTRC))
                ) && 
                (
                    this.infCIOT == input.infCIOT ||
                    this.infCIOT != null &&
                    input.infCIOT != null &&
                    this.infCIOT.SequenceEqual(input.infCIOT)
                ) && 
                (
                    this.valePed == input.valePed ||
                    (this.valePed != null &&
                    this.valePed.Equals(input.valePed))
                ) && 
                (
                    this.infContratante == input.infContratante ||
                    this.infContratante != null &&
                    input.infContratante != null &&
                    this.infContratante.SequenceEqual(input.infContratante)
                ) && 
                (
                    this.infPag == input.infPag ||
                    this.infPag != null &&
                    input.infPag != null &&
                    this.infPag.SequenceEqual(input.infPag)
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
                if (this.RNTRC != null)
                {
                    hashCode = (hashCode * 59) + this.RNTRC.GetHashCode();
                }
                if (this.infCIOT != null)
                {
                    hashCode = (hashCode * 59) + this.infCIOT.GetHashCode();
                }
                if (this.valePed != null)
                {
                    hashCode = (hashCode * 59) + this.valePed.GetHashCode();
                }
                if (this.infContratante != null)
                {
                    hashCode = (hashCode * 59) + this.infContratante.GetHashCode();
                }
                if (this.infPag != null)
                {
                    hashCode = (hashCode * 59) + this.infPag.GetHashCode();
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
