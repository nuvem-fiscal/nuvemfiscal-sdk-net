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
    /// Grupo de informações complementares disponível para todos os serviços prestados.
    /// </summary>
    [DataContract(Name = "InfoCompl")]
    public partial class InfoCompl : IEquatable<InfoCompl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoCompl" /> class.
        /// </summary>
        /// <param name="idDocTec">Identificador de Documento de Responsabilidade Técnica: ART, RRT, DRT, Outros..</param>
        /// <param name="docRef">Chave da nota, número identificador da nota, número do contrato ou outro identificador de documento emitido pelo prestador de serviços, que subsidia a emissão dessa nota pelo tomador do serviço ou intermediário (preenchimento obrigatório caso a nota esteja sendo emitida pelo Tomador ou intermediário do serviço)..</param>
        /// <param name="xInfComp">Informações complementares..</param>
        public InfoCompl(string idDocTec = default(string), string docRef = default(string), string xInfComp = default(string))
        {
            this.idDocTec = idDocTec;
            this.docRef = docRef;
            this.xInfComp = xInfComp;
        }

        /// <summary>
        /// Identificador de Documento de Responsabilidade Técnica: ART, RRT, DRT, Outros.
        /// </summary>
        /// <value>Identificador de Documento de Responsabilidade Técnica: ART, RRT, DRT, Outros.</value>
        [DataMember(Name = "idDocTec", EmitDefaultValue = false)]
        public string idDocTec { get; set; }

        /// <summary>
        /// Chave da nota, número identificador da nota, número do contrato ou outro identificador de documento emitido pelo prestador de serviços, que subsidia a emissão dessa nota pelo tomador do serviço ou intermediário (preenchimento obrigatório caso a nota esteja sendo emitida pelo Tomador ou intermediário do serviço).
        /// </summary>
        /// <value>Chave da nota, número identificador da nota, número do contrato ou outro identificador de documento emitido pelo prestador de serviços, que subsidia a emissão dessa nota pelo tomador do serviço ou intermediário (preenchimento obrigatório caso a nota esteja sendo emitida pelo Tomador ou intermediário do serviço).</value>
        [DataMember(Name = "docRef", EmitDefaultValue = false)]
        public string docRef { get; set; }

        /// <summary>
        /// Informações complementares.
        /// </summary>
        /// <value>Informações complementares.</value>
        [DataMember(Name = "xInfComp", EmitDefaultValue = false)]
        public string xInfComp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoCompl {\n");
            sb.Append("  idDocTec: ").Append(idDocTec).Append("\n");
            sb.Append("  docRef: ").Append(docRef).Append("\n");
            sb.Append("  xInfComp: ").Append(xInfComp).Append("\n");
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
            return this.Equals(input as InfoCompl);
        }

        /// <summary>
        /// Returns true if InfoCompl instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoCompl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoCompl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.idDocTec == input.idDocTec ||
                    (this.idDocTec != null &&
                    this.idDocTec.Equals(input.idDocTec))
                ) && 
                (
                    this.docRef == input.docRef ||
                    (this.docRef != null &&
                    this.docRef.Equals(input.docRef))
                ) && 
                (
                    this.xInfComp == input.xInfComp ||
                    (this.xInfComp != null &&
                    this.xInfComp.Equals(input.xInfComp))
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
                if (this.idDocTec != null)
                {
                    hashCode = (hashCode * 59) + this.idDocTec.GetHashCode();
                }
                if (this.docRef != null)
                {
                    hashCode = (hashCode * 59) + this.docRef.GetHashCode();
                }
                if (this.xInfComp != null)
                {
                    hashCode = (hashCode * 59) + this.xInfComp.GetHashCode();
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
