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
    /// CteSefazIdDocAntPap
    /// </summary>
    [DataContract(Name = "CteSefazIdDocAntPap")]
    public partial class CteSefazIdDocAntPap : IEquatable<CteSefazIdDocAntPap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazIdDocAntPap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazIdDocAntPap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazIdDocAntPap" /> class.
        /// </summary>
        /// <param name="tpDoc">Tipo do Documento de Transporte Anterior.  Preencher com:  07-ATRE;  08-DTA (Despacho de Transito Aduaneiro);  09-Conhecimento Aéreo Internacional;  10 – Conhecimento - Carta de Porte Internacional;  11 – Conhecimento Avulso;  12-TIF (Transporte Internacional Ferroviário); 13-BL (Bill of Lading). (required).</param>
        /// <param name="serie">Série do Documento Fiscal. (required).</param>
        /// <param name="subser">Série do Documento Fiscal..</param>
        /// <param name="nDoc">Número do Documento Fiscal. (required).</param>
        /// <param name="dEmi">Data de emissão (AAAA-MM-DD). (required).</param>
        public CteSefazIdDocAntPap(string tpDoc = default(string), string serie = default(string), string subser = default(string), string nDoc = default(string), DateTime dEmi = default(DateTime))
        {
            // to ensure "tpDoc" is required (not null)
            if (tpDoc == null)
            {
                throw new ArgumentNullException("tpDoc is a required property for CteSefazIdDocAntPap and cannot be null");
            }
            this.tpDoc = tpDoc;
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new ArgumentNullException("serie is a required property for CteSefazIdDocAntPap and cannot be null");
            }
            this.serie = serie;
            // to ensure "nDoc" is required (not null)
            if (nDoc == null)
            {
                throw new ArgumentNullException("nDoc is a required property for CteSefazIdDocAntPap and cannot be null");
            }
            this.nDoc = nDoc;
            this.dEmi = dEmi;
            this.subser = subser;
        }

        /// <summary>
        /// Tipo do Documento de Transporte Anterior.  Preencher com:  07-ATRE;  08-DTA (Despacho de Transito Aduaneiro);  09-Conhecimento Aéreo Internacional;  10 – Conhecimento - Carta de Porte Internacional;  11 – Conhecimento Avulso;  12-TIF (Transporte Internacional Ferroviário); 13-BL (Bill of Lading).
        /// </summary>
        /// <value>Tipo do Documento de Transporte Anterior.  Preencher com:  07-ATRE;  08-DTA (Despacho de Transito Aduaneiro);  09-Conhecimento Aéreo Internacional;  10 – Conhecimento - Carta de Porte Internacional;  11 – Conhecimento Avulso;  12-TIF (Transporte Internacional Ferroviário); 13-BL (Bill of Lading).</value>
        [DataMember(Name = "tpDoc", IsRequired = true, EmitDefaultValue = true)]
        public string tpDoc { get; set; }

        /// <summary>
        /// Série do Documento Fiscal.
        /// </summary>
        /// <value>Série do Documento Fiscal.</value>
        [DataMember(Name = "serie", IsRequired = true, EmitDefaultValue = true)]
        public string serie { get; set; }

        /// <summary>
        /// Série do Documento Fiscal.
        /// </summary>
        /// <value>Série do Documento Fiscal.</value>
        [DataMember(Name = "subser", EmitDefaultValue = false)]
        public string subser { get; set; }

        /// <summary>
        /// Número do Documento Fiscal.
        /// </summary>
        /// <value>Número do Documento Fiscal.</value>
        [DataMember(Name = "nDoc", IsRequired = true, EmitDefaultValue = true)]
        public string nDoc { get; set; }

        /// <summary>
        /// Data de emissão (AAAA-MM-DD).
        /// </summary>
        /// <value>Data de emissão (AAAA-MM-DD).</value>
        [DataMember(Name = "dEmi", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazIdDocAntPap {\n");
            sb.Append("  tpDoc: ").Append(tpDoc).Append("\n");
            sb.Append("  serie: ").Append(serie).Append("\n");
            sb.Append("  subser: ").Append(subser).Append("\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
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
            return this.Equals(input as CteSefazIdDocAntPap);
        }

        /// <summary>
        /// Returns true if CteSefazIdDocAntPap instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazIdDocAntPap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazIdDocAntPap input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpDoc == input.tpDoc ||
                    (this.tpDoc != null &&
                    this.tpDoc.Equals(input.tpDoc))
                ) && 
                (
                    this.serie == input.serie ||
                    (this.serie != null &&
                    this.serie.Equals(input.serie))
                ) && 
                (
                    this.subser == input.subser ||
                    (this.subser != null &&
                    this.subser.Equals(input.subser))
                ) && 
                (
                    this.nDoc == input.nDoc ||
                    (this.nDoc != null &&
                    this.nDoc.Equals(input.nDoc))
                ) && 
                (
                    this.dEmi == input.dEmi ||
                    (this.dEmi != null &&
                    this.dEmi.Equals(input.dEmi))
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
                if (this.tpDoc != null)
                {
                    hashCode = (hashCode * 59) + this.tpDoc.GetHashCode();
                }
                if (this.serie != null)
                {
                    hashCode = (hashCode * 59) + this.serie.GetHashCode();
                }
                if (this.subser != null)
                {
                    hashCode = (hashCode * 59) + this.subser.GetHashCode();
                }
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
                }
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
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
