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
    /// Detalhamento de Produtos e Serviços.
    /// </summary>
    [DataContract(Name = "NfcomSefazDet")]
    public partial class NfcomSefazDet : IEquatable<NfcomSefazDet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazDet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazDet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazDet" /> class.
        /// </summary>
        /// <param name="nItem">Número do item da NFCom. (required).</param>
        /// <param name="chNFComAnt">Chave de Acesso da NFCom anterior.  Informar chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA..</param>
        /// <param name="nItemAnt">Número do item da NFCom anterior.  Informar nro do item da chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA..</param>
        /// <param name="indNFComAntPapelFatCentral">Indicador de Nota anterior em papel no faturamento centralizado.  Informa que a NFCom Anterior de Faturamento centralizado não é eletrônica..</param>
        /// <param name="prod">prod (required).</param>
        /// <param name="imposto">imposto (required).</param>
        /// <param name="gProcRef">gProcRef.</param>
        /// <param name="gRessarc">gRessarc.</param>
        /// <param name="infAdProd">Informações adicionais do produto (norma referenciada, informações complementares, etc)..</param>
        public NfcomSefazDet(int? nItem = default(int?), string chNFComAnt = default(string), string nItemAnt = default(string), int? indNFComAntPapelFatCentral = default(int?), NfcomSefazProd prod = default(NfcomSefazProd), NfcomSefazImposto imposto = default(NfcomSefazImposto), NfcomSefazGProcRef gProcRef = default(NfcomSefazGProcRef), NfcomSefazGRessarc gRessarc = default(NfcomSefazGRessarc), string infAdProd = default(string))
        {
            // to ensure "nItem" is required (not null)
            if (nItem == null)
            {
                throw new ArgumentNullException("nItem is a required property for NfcomSefazDet and cannot be null");
            }
            this.nItem = nItem;
            // to ensure "prod" is required (not null)
            if (prod == null)
            {
                throw new ArgumentNullException("prod is a required property for NfcomSefazDet and cannot be null");
            }
            this.prod = prod;
            // to ensure "imposto" is required (not null)
            if (imposto == null)
            {
                throw new ArgumentNullException("imposto is a required property for NfcomSefazDet and cannot be null");
            }
            this.imposto = imposto;
            this.chNFComAnt = chNFComAnt;
            this.nItemAnt = nItemAnt;
            this.indNFComAntPapelFatCentral = indNFComAntPapelFatCentral;
            this.gProcRef = gProcRef;
            this.gRessarc = gRessarc;
            this.infAdProd = infAdProd;
        }

        /// <summary>
        /// Número do item da NFCom.
        /// </summary>
        /// <value>Número do item da NFCom.</value>
        [DataMember(Name = "nItem", IsRequired = true, EmitDefaultValue = true)]
        public int? nItem { get; set; }

        /// <summary>
        /// Chave de Acesso da NFCom anterior.  Informar chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA.
        /// </summary>
        /// <value>Chave de Acesso da NFCom anterior.  Informar chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA.</value>
        [DataMember(Name = "chNFComAnt", EmitDefaultValue = true)]
        public string chNFComAnt { get; set; }

        /// <summary>
        /// Número do item da NFCom anterior.  Informar nro do item da chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA.
        /// </summary>
        /// <value>Número do item da NFCom anterior.  Informar nro do item da chave de acesso de referencia anterior  TAG OPCIONAL, DEVE SER INFORMADA APENAS NOS CASOS PREVISTOS DE NOTA ANTERIOR REFERENCIADA.</value>
        [DataMember(Name = "nItemAnt", EmitDefaultValue = true)]
        public string nItemAnt { get; set; }

        /// <summary>
        /// Indicador de Nota anterior em papel no faturamento centralizado.  Informa que a NFCom Anterior de Faturamento centralizado não é eletrônica.
        /// </summary>
        /// <value>Indicador de Nota anterior em papel no faturamento centralizado.  Informa que a NFCom Anterior de Faturamento centralizado não é eletrônica.</value>
        [DataMember(Name = "indNFComAntPapelFatCentral", EmitDefaultValue = true)]
        public int? indNFComAntPapelFatCentral { get; set; }

        /// <summary>
        /// Gets or Sets prod
        /// </summary>
        [DataMember(Name = "prod", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazProd prod { get; set; }

        /// <summary>
        /// Gets or Sets imposto
        /// </summary>
        [DataMember(Name = "imposto", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazImposto imposto { get; set; }

        /// <summary>
        /// Gets or Sets gProcRef
        /// </summary>
        [DataMember(Name = "gProcRef", EmitDefaultValue = false)]
        public NfcomSefazGProcRef gProcRef { get; set; }

        /// <summary>
        /// Gets or Sets gRessarc
        /// </summary>
        [DataMember(Name = "gRessarc", EmitDefaultValue = false)]
        public NfcomSefazGRessarc gRessarc { get; set; }

        /// <summary>
        /// Informações adicionais do produto (norma referenciada, informações complementares, etc).
        /// </summary>
        /// <value>Informações adicionais do produto (norma referenciada, informações complementares, etc).</value>
        [DataMember(Name = "infAdProd", EmitDefaultValue = true)]
        public string infAdProd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazDet {\n");
            sb.Append("  nItem: ").Append(nItem).Append("\n");
            sb.Append("  chNFComAnt: ").Append(chNFComAnt).Append("\n");
            sb.Append("  nItemAnt: ").Append(nItemAnt).Append("\n");
            sb.Append("  indNFComAntPapelFatCentral: ").Append(indNFComAntPapelFatCentral).Append("\n");
            sb.Append("  prod: ").Append(prod).Append("\n");
            sb.Append("  imposto: ").Append(imposto).Append("\n");
            sb.Append("  gProcRef: ").Append(gProcRef).Append("\n");
            sb.Append("  gRessarc: ").Append(gRessarc).Append("\n");
            sb.Append("  infAdProd: ").Append(infAdProd).Append("\n");
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
            return this.Equals(input as NfcomSefazDet);
        }

        /// <summary>
        /// Returns true if NfcomSefazDet instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazDet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazDet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nItem == input.nItem ||
                    (this.nItem != null &&
                    this.nItem.Equals(input.nItem))
                ) && 
                (
                    this.chNFComAnt == input.chNFComAnt ||
                    (this.chNFComAnt != null &&
                    this.chNFComAnt.Equals(input.chNFComAnt))
                ) && 
                (
                    this.nItemAnt == input.nItemAnt ||
                    (this.nItemAnt != null &&
                    this.nItemAnt.Equals(input.nItemAnt))
                ) && 
                (
                    this.indNFComAntPapelFatCentral == input.indNFComAntPapelFatCentral ||
                    (this.indNFComAntPapelFatCentral != null &&
                    this.indNFComAntPapelFatCentral.Equals(input.indNFComAntPapelFatCentral))
                ) && 
                (
                    this.prod == input.prod ||
                    (this.prod != null &&
                    this.prod.Equals(input.prod))
                ) && 
                (
                    this.imposto == input.imposto ||
                    (this.imposto != null &&
                    this.imposto.Equals(input.imposto))
                ) && 
                (
                    this.gProcRef == input.gProcRef ||
                    (this.gProcRef != null &&
                    this.gProcRef.Equals(input.gProcRef))
                ) && 
                (
                    this.gRessarc == input.gRessarc ||
                    (this.gRessarc != null &&
                    this.gRessarc.Equals(input.gRessarc))
                ) && 
                (
                    this.infAdProd == input.infAdProd ||
                    (this.infAdProd != null &&
                    this.infAdProd.Equals(input.infAdProd))
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
                if (this.nItem != null)
                {
                    hashCode = (hashCode * 59) + this.nItem.GetHashCode();
                }
                if (this.chNFComAnt != null)
                {
                    hashCode = (hashCode * 59) + this.chNFComAnt.GetHashCode();
                }
                if (this.nItemAnt != null)
                {
                    hashCode = (hashCode * 59) + this.nItemAnt.GetHashCode();
                }
                if (this.indNFComAntPapelFatCentral != null)
                {
                    hashCode = (hashCode * 59) + this.indNFComAntPapelFatCentral.GetHashCode();
                }
                if (this.prod != null)
                {
                    hashCode = (hashCode * 59) + this.prod.GetHashCode();
                }
                if (this.imposto != null)
                {
                    hashCode = (hashCode * 59) + this.imposto.GetHashCode();
                }
                if (this.gProcRef != null)
                {
                    hashCode = (hashCode * 59) + this.gProcRef.GetHashCode();
                }
                if (this.gRessarc != null)
                {
                    hashCode = (hashCode * 59) + this.gRessarc.GetHashCode();
                }
                if (this.infAdProd != null)
                {
                    hashCode = (hashCode * 59) + this.infAdProd.GetHashCode();
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
            // nItem (int?) maximum
            if (this.nItem > (int?)9999)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value less than or equal to 9999.", new [] { "nItem" });
            }

            // nItem (int?) minimum
            if (this.nItem < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value greater than or equal to 1.", new [] { "nItem" });
            }

            // chNFComAnt (string) maxLength
            if (this.chNFComAnt != null && this.chNFComAnt.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chNFComAnt, length must be less than 44.", new [] { "chNFComAnt" });
            }

            // infAdProd (string) maxLength
            if (this.infAdProd != null && this.infAdProd.Length > 500)
            {
                yield return new ValidationResult("Invalid value for infAdProd, length must be less than 500.", new [] { "infAdProd" });
            }

            // infAdProd (string) minLength
            if (this.infAdProd != null && this.infAdProd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for infAdProd, length must be greater than 1.", new [] { "infAdProd" });
            }

            yield break;
        }
    }

}
