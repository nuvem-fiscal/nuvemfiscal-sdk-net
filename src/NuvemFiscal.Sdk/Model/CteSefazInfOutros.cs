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
    /// CteSefazInfOutros
    /// </summary>
    [DataContract(Name = "CteSefazInfOutros")]
    public partial class CteSefazInfOutros : IEquatable<CteSefazInfOutros>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfOutros" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfOutros() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfOutros" /> class.
        /// </summary>
        /// <param name="tpDoc">Tipo de documento originário.  Preencher com:                 00 - Declaração;                 10 - Dutoviário;      59 - CF-e SAT;    65 - NFC-e;          99 - Outros. (required).</param>
        /// <param name="descOutros">Descrição do documento..</param>
        /// <param name="nDoc">Número..</param>
        /// <param name="dEmi">Data de Emissão.  Formato AAAA-MM-DD..</param>
        /// <param name="vDocFisc">Valor do documento..</param>
        /// <param name="dPrev">Data prevista de entrega.  Formato AAAA-MM-DD..</param>
        /// <param name="infUnidCarga">Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu..</param>
        /// <param name="infUnidTransp">Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas..</param>
        public CteSefazInfOutros(string tpDoc = default(string), string descOutros = default(string), string nDoc = default(string), DateTime dEmi = default(DateTime), decimal vDocFisc = default(decimal), DateTime dPrev = default(DateTime), List<CteSefazUnidCarga> infUnidCarga = default(List<CteSefazUnidCarga>), List<CteSefazUnidadeTransp> infUnidTransp = default(List<CteSefazUnidadeTransp>))
        {
            // to ensure "tpDoc" is required (not null)
            if (tpDoc == null)
            {
                throw new ArgumentNullException("tpDoc is a required property for CteSefazInfOutros and cannot be null");
            }
            this.tpDoc = tpDoc;
            this.descOutros = descOutros;
            this.nDoc = nDoc;
            this.dEmi = dEmi;
            this.vDocFisc = vDocFisc;
            this.dPrev = dPrev;
            this.infUnidCarga = infUnidCarga;
            this.infUnidTransp = infUnidTransp;
        }

        /// <summary>
        /// Tipo de documento originário.  Preencher com:                 00 - Declaração;                 10 - Dutoviário;      59 - CF-e SAT;    65 - NFC-e;          99 - Outros.
        /// </summary>
        /// <value>Tipo de documento originário.  Preencher com:                 00 - Declaração;                 10 - Dutoviário;      59 - CF-e SAT;    65 - NFC-e;          99 - Outros.</value>
        [DataMember(Name = "tpDoc", IsRequired = true, EmitDefaultValue = false)]
        public string tpDoc { get; set; }

        /// <summary>
        /// Descrição do documento.
        /// </summary>
        /// <value>Descrição do documento.</value>
        [DataMember(Name = "descOutros", EmitDefaultValue = false)]
        public string descOutros { get; set; }

        /// <summary>
        /// Número.
        /// </summary>
        /// <value>Número.</value>
        [DataMember(Name = "nDoc", EmitDefaultValue = false)]
        public string nDoc { get; set; }

        /// <summary>
        /// Data de Emissão.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data de Emissão.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dEmi", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dEmi { get; set; }

        /// <summary>
        /// Valor do documento.
        /// </summary>
        /// <value>Valor do documento.</value>
        [DataMember(Name = "vDocFisc", EmitDefaultValue = false)]
        public decimal vDocFisc { get; set; }

        /// <summary>
        /// Data prevista de entrega.  Formato AAAA-MM-DD.
        /// </summary>
        /// <value>Data prevista de entrega.  Formato AAAA-MM-DD.</value>
        [DataMember(Name = "dPrev", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime dPrev { get; set; }

        /// <summary>
        /// Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu.
        /// </summary>
        /// <value>Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu.</value>
        [DataMember(Name = "infUnidCarga", EmitDefaultValue = false)]
        public List<CteSefazUnidCarga> infUnidCarga { get; set; }

        /// <summary>
        /// Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.
        /// </summary>
        /// <value>Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas.</value>
        [DataMember(Name = "infUnidTransp", EmitDefaultValue = false)]
        public List<CteSefazUnidadeTransp> infUnidTransp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfOutros {\n");
            sb.Append("  tpDoc: ").Append(tpDoc).Append("\n");
            sb.Append("  descOutros: ").Append(descOutros).Append("\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
            sb.Append("  dEmi: ").Append(dEmi).Append("\n");
            sb.Append("  vDocFisc: ").Append(vDocFisc).Append("\n");
            sb.Append("  dPrev: ").Append(dPrev).Append("\n");
            sb.Append("  infUnidCarga: ").Append(infUnidCarga).Append("\n");
            sb.Append("  infUnidTransp: ").Append(infUnidTransp).Append("\n");
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
            return this.Equals(input as CteSefazInfOutros);
        }

        /// <summary>
        /// Returns true if CteSefazInfOutros instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfOutros to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfOutros input)
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
                    this.descOutros == input.descOutros ||
                    (this.descOutros != null &&
                    this.descOutros.Equals(input.descOutros))
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
                ) && 
                (
                    this.vDocFisc == input.vDocFisc ||
                    this.vDocFisc.Equals(input.vDocFisc)
                ) && 
                (
                    this.dPrev == input.dPrev ||
                    (this.dPrev != null &&
                    this.dPrev.Equals(input.dPrev))
                ) && 
                (
                    this.infUnidCarga == input.infUnidCarga ||
                    this.infUnidCarga != null &&
                    input.infUnidCarga != null &&
                    this.infUnidCarga.SequenceEqual(input.infUnidCarga)
                ) && 
                (
                    this.infUnidTransp == input.infUnidTransp ||
                    this.infUnidTransp != null &&
                    input.infUnidTransp != null &&
                    this.infUnidTransp.SequenceEqual(input.infUnidTransp)
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
                if (this.descOutros != null)
                {
                    hashCode = (hashCode * 59) + this.descOutros.GetHashCode();
                }
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
                }
                if (this.dEmi != null)
                {
                    hashCode = (hashCode * 59) + this.dEmi.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.vDocFisc.GetHashCode();
                if (this.dPrev != null)
                {
                    hashCode = (hashCode * 59) + this.dPrev.GetHashCode();
                }
                if (this.infUnidCarga != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidCarga.GetHashCode();
                }
                if (this.infUnidTransp != null)
                {
                    hashCode = (hashCode * 59) + this.infUnidTransp.GetHashCode();
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
