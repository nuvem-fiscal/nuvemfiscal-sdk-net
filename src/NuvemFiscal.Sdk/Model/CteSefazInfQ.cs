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
    /// Informações de quantidades da Carga do CT-e.  Para o Aéreo é obrigatório o preenchimento desse campo da seguinte forma.  * 1 - Peso Bruto, sempre em quilogramas (obrigatório)  * 2 - Peso Cubado  sempre em quilogramas  * 3 - Quantidade de volumes, sempre em unidades (obrigatório)  * 4 - Cubagem, sempre em metros cúbicos (obrigatório apenas quando for impossível preencher as dimensões da(s) embalagem(ens) na tag xDime do leiaute do Aéreo)
    /// </summary>
    [DataContract(Name = "CteSefazInfQ")]
    public partial class CteSefazInfQ : IEquatable<CteSefazInfQ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfQ" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfQ() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfQ" /> class.
        /// </summary>
        /// <param name="cUnid">Código da Unidade de Medida.  Preencher com:  * 00 - M3  * 01 - KG  * 02 - TON  * 03 - UNIDADE  * 04 - LITROS  * 05 - MMBTU (required).</param>
        /// <param name="tpMed">Tipo da Medida.  Exemplos:  PESO BRUTO, PESO DECLARADO, PESO CUBADO, PESO AFORADO, PESO AFERIDO, PESO BASE DE CÁLCULO, LITRAGEM, CAIXAS e etc. (required).</param>
        /// <param name="qCarga">Quantidade. (required).</param>
        public CteSefazInfQ(string cUnid = default(string), string tpMed = default(string), decimal qCarga = default(decimal))
        {
            // to ensure "cUnid" is required (not null)
            if (cUnid == null)
            {
                throw new ArgumentNullException("cUnid is a required property for CteSefazInfQ and cannot be null");
            }
            this.cUnid = cUnid;
            // to ensure "tpMed" is required (not null)
            if (tpMed == null)
            {
                throw new ArgumentNullException("tpMed is a required property for CteSefazInfQ and cannot be null");
            }
            this.tpMed = tpMed;
            this.qCarga = qCarga;
        }

        /// <summary>
        /// Código da Unidade de Medida.  Preencher com:  * 00 - M3  * 01 - KG  * 02 - TON  * 03 - UNIDADE  * 04 - LITROS  * 05 - MMBTU
        /// </summary>
        /// <value>Código da Unidade de Medida.  Preencher com:  * 00 - M3  * 01 - KG  * 02 - TON  * 03 - UNIDADE  * 04 - LITROS  * 05 - MMBTU</value>
        [DataMember(Name = "cUnid", IsRequired = true, EmitDefaultValue = true)]
        public string cUnid { get; set; }

        /// <summary>
        /// Tipo da Medida.  Exemplos:  PESO BRUTO, PESO DECLARADO, PESO CUBADO, PESO AFORADO, PESO AFERIDO, PESO BASE DE CÁLCULO, LITRAGEM, CAIXAS e etc.
        /// </summary>
        /// <value>Tipo da Medida.  Exemplos:  PESO BRUTO, PESO DECLARADO, PESO CUBADO, PESO AFORADO, PESO AFERIDO, PESO BASE DE CÁLCULO, LITRAGEM, CAIXAS e etc.</value>
        [DataMember(Name = "tpMed", IsRequired = true, EmitDefaultValue = true)]
        public string tpMed { get; set; }

        /// <summary>
        /// Quantidade.
        /// </summary>
        /// <value>Quantidade.</value>
        [DataMember(Name = "qCarga", IsRequired = true, EmitDefaultValue = true)]
        public decimal qCarga { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfQ {\n");
            sb.Append("  cUnid: ").Append(cUnid).Append("\n");
            sb.Append("  tpMed: ").Append(tpMed).Append("\n");
            sb.Append("  qCarga: ").Append(qCarga).Append("\n");
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
            return this.Equals(input as CteSefazInfQ);
        }

        /// <summary>
        /// Returns true if CteSefazInfQ instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfQ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfQ input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cUnid == input.cUnid ||
                    (this.cUnid != null &&
                    this.cUnid.Equals(input.cUnid))
                ) && 
                (
                    this.tpMed == input.tpMed ||
                    (this.tpMed != null &&
                    this.tpMed.Equals(input.tpMed))
                ) && 
                (
                    this.qCarga == input.qCarga ||
                    this.qCarga.Equals(input.qCarga)
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
                if (this.cUnid != null)
                {
                    hashCode = (hashCode * 59) + this.cUnid.GetHashCode();
                }
                if (this.tpMed != null)
                {
                    hashCode = (hashCode * 59) + this.tpMed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.qCarga.GetHashCode();
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
