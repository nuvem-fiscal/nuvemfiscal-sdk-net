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
    /// CteSefazInfNFe
    /// </summary>
    [DataContract(Name = "CteSefazInfNFe")]
    public partial class CteSefazInfNFe : IEquatable<CteSefazInfNFe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfNFe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfNFe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfNFe" /> class.
        /// </summary>
        /// <param name="chave">Chave de acesso da NF-e. (required).</param>
        /// <param name="pIN">PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação..</param>
        /// <param name="dPrev">Data prevista de entrega.  Formato AAAA-MM-DD..</param>
        /// <param name="infUnidCarga">Informações das Unidades de Carga (Containeres/ULD/Outros).  Dispositivo de carga utilizada (Unit Load Device - ULD) significa todo tipo de contêiner de carga, vagão, contêiner de avião, palete de aeronave com rede ou palete de aeronave com rede sobre um iglu..</param>
        /// <param name="infUnidTransp">Informações das Unidades de Transporte (Carreta/Reboque/Vagão).  Deve ser preenchido com as informações das unidades de transporte utilizadas..</param>
        public CteSefazInfNFe(string chave = default(string), string pIN = default(string), DateTime dPrev = default(DateTime), List<CteSefazUnidCarga> infUnidCarga = default(List<CteSefazUnidCarga>), List<CteSefazUnidadeTransp> infUnidTransp = default(List<CteSefazUnidadeTransp>))
        {
            // to ensure "chave" is required (not null)
            if (chave == null)
            {
                throw new ArgumentNullException("chave is a required property for CteSefazInfNFe and cannot be null");
            }
            this.chave = chave;
            this.PIN = pIN;
            this.dPrev = dPrev;
            this.infUnidCarga = infUnidCarga;
            this.infUnidTransp = infUnidTransp;
        }

        /// <summary>
        /// Chave de acesso da NF-e.
        /// </summary>
        /// <value>Chave de acesso da NF-e.</value>
        [DataMember(Name = "chave", IsRequired = true, EmitDefaultValue = true)]
        public string chave { get; set; }

        /// <summary>
        /// PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação.
        /// </summary>
        /// <value>PIN SUFRAMA.  PIN atribuído pela SUFRAMA para a operação.</value>
        [DataMember(Name = "PIN", EmitDefaultValue = false)]
        public string PIN { get; set; }

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
            sb.Append("class CteSefazInfNFe {\n");
            sb.Append("  chave: ").Append(chave).Append("\n");
            sb.Append("  PIN: ").Append(PIN).Append("\n");
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
            return this.Equals(input as CteSefazInfNFe);
        }

        /// <summary>
        /// Returns true if CteSefazInfNFe instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfNFe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfNFe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chave == input.chave ||
                    (this.chave != null &&
                    this.chave.Equals(input.chave))
                ) && 
                (
                    this.PIN == input.PIN ||
                    (this.PIN != null &&
                    this.PIN.Equals(input.PIN))
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
                if (this.chave != null)
                {
                    hashCode = (hashCode * 59) + this.chave.GetHashCode();
                }
                if (this.PIN != null)
                {
                    hashCode = (hashCode * 59) + this.PIN.GetHashCode();
                }
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
