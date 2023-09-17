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
    /// grupo do detalhamento de Medicamentos e de matérias-primas farmacêuticas.
    /// </summary>
    [DataContract(Name = "NfeSefazMed")]
    public partial class NfeSefazMed : IEquatable<NfeSefazMed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazMed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazMed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazMed" /> class.
        /// </summary>
        /// <param name="cProdANVISA">Utilizar o número do registro ANVISA  ou preencher com o literal “ISENTO”, no caso de medicamento isento de registro na ANVISA. (required).</param>
        /// <param name="xMotivoIsencao">Obs.: Para medicamento isento de registro na ANVISA, informar o número da decisão que o isenta, como por exemplo o número da Resolução da Diretoria Colegiada da ANVISA (RDC)..</param>
        /// <param name="vPMC">Preço Máximo ao Consumidor. (required).</param>
        public NfeSefazMed(string cProdANVISA = default(string), string xMotivoIsencao = default(string), decimal? vPMC = default(decimal?))
        {
            // to ensure "cProdANVISA" is required (not null)
            if (cProdANVISA == null)
            {
                throw new ArgumentNullException("cProdANVISA is a required property for NfeSefazMed and cannot be null");
            }
            this.cProdANVISA = cProdANVISA;
            // to ensure "vPMC" is required (not null)
            if (vPMC == null)
            {
                throw new ArgumentNullException("vPMC is a required property for NfeSefazMed and cannot be null");
            }
            this.vPMC = vPMC;
            this.xMotivoIsencao = xMotivoIsencao;
        }

        /// <summary>
        /// Utilizar o número do registro ANVISA  ou preencher com o literal “ISENTO”, no caso de medicamento isento de registro na ANVISA.
        /// </summary>
        /// <value>Utilizar o número do registro ANVISA  ou preencher com o literal “ISENTO”, no caso de medicamento isento de registro na ANVISA.</value>
        [DataMember(Name = "cProdANVISA", IsRequired = true, EmitDefaultValue = true)]
        public string cProdANVISA { get; set; }

        /// <summary>
        /// Obs.: Para medicamento isento de registro na ANVISA, informar o número da decisão que o isenta, como por exemplo o número da Resolução da Diretoria Colegiada da ANVISA (RDC).
        /// </summary>
        /// <value>Obs.: Para medicamento isento de registro na ANVISA, informar o número da decisão que o isenta, como por exemplo o número da Resolução da Diretoria Colegiada da ANVISA (RDC).</value>
        [DataMember(Name = "xMotivoIsencao", EmitDefaultValue = true)]
        public string xMotivoIsencao { get; set; }

        /// <summary>
        /// Preço Máximo ao Consumidor.
        /// </summary>
        /// <value>Preço Máximo ao Consumidor.</value>
        [DataMember(Name = "vPMC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vPMC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazMed {\n");
            sb.Append("  cProdANVISA: ").Append(cProdANVISA).Append("\n");
            sb.Append("  xMotivoIsencao: ").Append(xMotivoIsencao).Append("\n");
            sb.Append("  vPMC: ").Append(vPMC).Append("\n");
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
            return this.Equals(input as NfeSefazMed);
        }

        /// <summary>
        /// Returns true if NfeSefazMed instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazMed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazMed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cProdANVISA == input.cProdANVISA ||
                    (this.cProdANVISA != null &&
                    this.cProdANVISA.Equals(input.cProdANVISA))
                ) && 
                (
                    this.xMotivoIsencao == input.xMotivoIsencao ||
                    (this.xMotivoIsencao != null &&
                    this.xMotivoIsencao.Equals(input.xMotivoIsencao))
                ) && 
                (
                    this.vPMC == input.vPMC ||
                    (this.vPMC != null &&
                    this.vPMC.Equals(input.vPMC))
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
                if (this.cProdANVISA != null)
                {
                    hashCode = (hashCode * 59) + this.cProdANVISA.GetHashCode();
                }
                if (this.xMotivoIsencao != null)
                {
                    hashCode = (hashCode * 59) + this.xMotivoIsencao.GetHashCode();
                }
                if (this.vPMC != null)
                {
                    hashCode = (hashCode * 59) + this.vPMC.GetHashCode();
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
