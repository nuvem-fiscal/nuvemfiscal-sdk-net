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
    /// CteSefazAereo
    /// </summary>
    [DataContract(Name = "CteSefazAereo")]
    public partial class CteSefazAereo : IEquatable<CteSefazAereo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazAereo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazAereo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazAereo" /> class.
        /// </summary>
        /// <param name="nMinu">Número da Minuta.  Documento que precede o CT-e, assinado pelo expedidor, espécie de pedido de serviço..</param>
        /// <param name="nOCA">Número Operacional do Conhecimento Aéreo.  Representa o número de controle comumente utilizado pelo conhecimento aéreo composto por uma sequência numérica de onze dígitos. Os três primeiros dígitos representam um código que os operadores de transporte aéreo associados à IATA possuem. Em seguida um número de série de sete dígitos determinados pelo operador de transporte aéreo. Para finalizar, um dígito verificador, que é um sistema de módulo sete imponderado o qual divide o número de série do conhecimento aéreo por sete e usa o resto como dígito de verificação..</param>
        /// <param name="dPrevAereo">Data prevista da entrega.  Formato AAAA-MM-DD. (required).</param>
        /// <param name="natCarga">natCarga (required).</param>
        /// <param name="tarifa">tarifa (required).</param>
        /// <param name="peri">Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.  O preenchimento desses campos não desobriga a empresa aérea de emitir os demais documentos que constam na legislação vigente..</param>
        public CteSefazAereo(int nMinu = default(int), string nOCA = default(string), DateTime dPrevAereo = default(DateTime), CteSefazNatCarga natCarga = default(CteSefazNatCarga), CteSefazTarifa tarifa = default(CteSefazTarifa), List<CteSefazPeri> peri = default(List<CteSefazPeri>))
        {
            this.dPrevAereo = dPrevAereo;
            // to ensure "natCarga" is required (not null)
            if (natCarga == null)
            {
                throw new ArgumentNullException("natCarga is a required property for CteSefazAereo and cannot be null");
            }
            this.natCarga = natCarga;
            // to ensure "tarifa" is required (not null)
            if (tarifa == null)
            {
                throw new ArgumentNullException("tarifa is a required property for CteSefazAereo and cannot be null");
            }
            this.tarifa = tarifa;
            this.nMinu = nMinu;
            this.nOCA = nOCA;
            this.peri = peri;
        }

        /// <summary>
        /// Número da Minuta.  Documento que precede o CT-e, assinado pelo expedidor, espécie de pedido de serviço.
        /// </summary>
        /// <value>Número da Minuta.  Documento que precede o CT-e, assinado pelo expedidor, espécie de pedido de serviço.</value>
        [DataMember(Name = "nMinu", EmitDefaultValue = false)]
        public int nMinu { get; set; }

        /// <summary>
        /// Número Operacional do Conhecimento Aéreo.  Representa o número de controle comumente utilizado pelo conhecimento aéreo composto por uma sequência numérica de onze dígitos. Os três primeiros dígitos representam um código que os operadores de transporte aéreo associados à IATA possuem. Em seguida um número de série de sete dígitos determinados pelo operador de transporte aéreo. Para finalizar, um dígito verificador, que é um sistema de módulo sete imponderado o qual divide o número de série do conhecimento aéreo por sete e usa o resto como dígito de verificação.
        /// </summary>
        /// <value>Número Operacional do Conhecimento Aéreo.  Representa o número de controle comumente utilizado pelo conhecimento aéreo composto por uma sequência numérica de onze dígitos. Os três primeiros dígitos representam um código que os operadores de transporte aéreo associados à IATA possuem. Em seguida um número de série de sete dígitos determinados pelo operador de transporte aéreo. Para finalizar, um dígito verificador, que é um sistema de módulo sete imponderado o qual divide o número de série do conhecimento aéreo por sete e usa o resto como dígito de verificação.</value>
        [DataMember(Name = "nOCA", EmitDefaultValue = false)]
        public string nOCA { get; set; }

        /// <summary>
        /// Data prevista da entrega.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data prevista da entrega.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dPrevAereo", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dPrevAereo { get; set; }

        /// <summary>
        /// Gets or Sets natCarga
        /// </summary>
        [DataMember(Name = "natCarga", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazNatCarga natCarga { get; set; }

        /// <summary>
        /// Gets or Sets tarifa
        /// </summary>
        [DataMember(Name = "tarifa", IsRequired = true, EmitDefaultValue = true)]
        public CteSefazTarifa tarifa { get; set; }

        /// <summary>
        /// Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.  O preenchimento desses campos não desobriga a empresa aérea de emitir os demais documentos que constam na legislação vigente.
        /// </summary>
        /// <value>Preenchido quando for  transporte de produtos classificados pela ONU como perigosos.  O preenchimento desses campos não desobriga a empresa aérea de emitir os demais documentos que constam na legislação vigente.</value>
        [DataMember(Name = "peri", EmitDefaultValue = false)]
        public List<CteSefazPeri> peri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazAereo {\n");
            sb.Append("  nMinu: ").Append(nMinu).Append("\n");
            sb.Append("  nOCA: ").Append(nOCA).Append("\n");
            sb.Append("  dPrevAereo: ").Append(dPrevAereo).Append("\n");
            sb.Append("  natCarga: ").Append(natCarga).Append("\n");
            sb.Append("  tarifa: ").Append(tarifa).Append("\n");
            sb.Append("  peri: ").Append(peri).Append("\n");
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
            return this.Equals(input as CteSefazAereo);
        }

        /// <summary>
        /// Returns true if CteSefazAereo instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazAereo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazAereo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nMinu == input.nMinu ||
                    this.nMinu.Equals(input.nMinu)
                ) && 
                (
                    this.nOCA == input.nOCA ||
                    (this.nOCA != null &&
                    this.nOCA.Equals(input.nOCA))
                ) && 
                (
                    this.dPrevAereo == input.dPrevAereo ||
                    (this.dPrevAereo != null &&
                    this.dPrevAereo.Equals(input.dPrevAereo))
                ) && 
                (
                    this.natCarga == input.natCarga ||
                    (this.natCarga != null &&
                    this.natCarga.Equals(input.natCarga))
                ) && 
                (
                    this.tarifa == input.tarifa ||
                    (this.tarifa != null &&
                    this.tarifa.Equals(input.tarifa))
                ) && 
                (
                    this.peri == input.peri ||
                    this.peri != null &&
                    input.peri != null &&
                    this.peri.SequenceEqual(input.peri)
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
                hashCode = (hashCode * 59) + this.nMinu.GetHashCode();
                if (this.nOCA != null)
                {
                    hashCode = (hashCode * 59) + this.nOCA.GetHashCode();
                }
                if (this.dPrevAereo != null)
                {
                    hashCode = (hashCode * 59) + this.dPrevAereo.GetHashCode();
                }
                if (this.natCarga != null)
                {
                    hashCode = (hashCode * 59) + this.natCarga.GetHashCode();
                }
                if (this.tarifa != null)
                {
                    hashCode = (hashCode * 59) + this.tarifa.GetHashCode();
                }
                if (this.peri != null)
                {
                    hashCode = (hashCode * 59) + this.peri.GetHashCode();
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
