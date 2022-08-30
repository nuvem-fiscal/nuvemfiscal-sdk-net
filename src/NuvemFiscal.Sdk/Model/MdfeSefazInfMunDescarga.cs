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
    /// MdfeSefazInfMunDescarga
    /// </summary>
    [DataContract(Name = "MdfeSefazInfMunDescarga")]
    public partial class MdfeSefazInfMunDescarga : IEquatable<MdfeSefazInfMunDescarga>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMunDescarga" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfMunDescarga() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfMunDescarga" /> class.
        /// </summary>
        /// <param name="cMunDescarga">Código do Município de Descarregamento. (required).</param>
        /// <param name="xMunDescarga">Nome do Município de Descarregamento. (required).</param>
        /// <param name="infCTe">Conhecimentos de Tranporte - usar este grupo quando for prestador de serviço de transporte..</param>
        /// <param name="infNFe">Nota Fiscal Eletronica..</param>
        /// <param name="infMDFeTransp">Manifesto Eletrônico de Documentos Fiscais. Somente para modal Aquaviário (vide regras MOC)..</param>
        public MdfeSefazInfMunDescarga(int cMunDescarga = default(int), string xMunDescarga = default(string), List<MdfeSefazInfCTe> infCTe = default(List<MdfeSefazInfCTe>), List<MdfeSefazInfNFe> infNFe = default(List<MdfeSefazInfNFe>), List<MdfeSefazInfMDFeTransp> infMDFeTransp = default(List<MdfeSefazInfMDFeTransp>))
        {
            this.cMunDescarga = cMunDescarga;
            // to ensure "xMunDescarga" is required (not null)
            if (xMunDescarga == null)
            {
                throw new ArgumentNullException("xMunDescarga is a required property for MdfeSefazInfMunDescarga and cannot be null");
            }
            this.xMunDescarga = xMunDescarga;
            this.infCTe = infCTe;
            this.infNFe = infNFe;
            this.infMDFeTransp = infMDFeTransp;
        }

        /// <summary>
        /// Código do Município de Descarregamento.
        /// </summary>
        /// <value>Código do Município de Descarregamento.</value>
        [DataMember(Name = "cMunDescarga", IsRequired = true, EmitDefaultValue = false)]
        public int cMunDescarga { get; set; }

        /// <summary>
        /// Nome do Município de Descarregamento.
        /// </summary>
        /// <value>Nome do Município de Descarregamento.</value>
        [DataMember(Name = "xMunDescarga", IsRequired = true, EmitDefaultValue = false)]
        public string xMunDescarga { get; set; }

        /// <summary>
        /// Conhecimentos de Tranporte - usar este grupo quando for prestador de serviço de transporte.
        /// </summary>
        /// <value>Conhecimentos de Tranporte - usar este grupo quando for prestador de serviço de transporte.</value>
        [DataMember(Name = "infCTe", EmitDefaultValue = false)]
        public List<MdfeSefazInfCTe> infCTe { get; set; }

        /// <summary>
        /// Nota Fiscal Eletronica.
        /// </summary>
        /// <value>Nota Fiscal Eletronica.</value>
        [DataMember(Name = "infNFe", EmitDefaultValue = false)]
        public List<MdfeSefazInfNFe> infNFe { get; set; }

        /// <summary>
        /// Manifesto Eletrônico de Documentos Fiscais. Somente para modal Aquaviário (vide regras MOC).
        /// </summary>
        /// <value>Manifesto Eletrônico de Documentos Fiscais. Somente para modal Aquaviário (vide regras MOC).</value>
        [DataMember(Name = "infMDFeTransp", EmitDefaultValue = false)]
        public List<MdfeSefazInfMDFeTransp> infMDFeTransp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfMunDescarga {\n");
            sb.Append("  cMunDescarga: ").Append(cMunDescarga).Append("\n");
            sb.Append("  xMunDescarga: ").Append(xMunDescarga).Append("\n");
            sb.Append("  infCTe: ").Append(infCTe).Append("\n");
            sb.Append("  infNFe: ").Append(infNFe).Append("\n");
            sb.Append("  infMDFeTransp: ").Append(infMDFeTransp).Append("\n");
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
            return this.Equals(input as MdfeSefazInfMunDescarga);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfMunDescarga instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfMunDescarga to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfMunDescarga input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cMunDescarga == input.cMunDescarga ||
                    this.cMunDescarga.Equals(input.cMunDescarga)
                ) && 
                (
                    this.xMunDescarga == input.xMunDescarga ||
                    (this.xMunDescarga != null &&
                    this.xMunDescarga.Equals(input.xMunDescarga))
                ) && 
                (
                    this.infCTe == input.infCTe ||
                    this.infCTe != null &&
                    input.infCTe != null &&
                    this.infCTe.SequenceEqual(input.infCTe)
                ) && 
                (
                    this.infNFe == input.infNFe ||
                    this.infNFe != null &&
                    input.infNFe != null &&
                    this.infNFe.SequenceEqual(input.infNFe)
                ) && 
                (
                    this.infMDFeTransp == input.infMDFeTransp ||
                    this.infMDFeTransp != null &&
                    input.infMDFeTransp != null &&
                    this.infMDFeTransp.SequenceEqual(input.infMDFeTransp)
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
                hashCode = (hashCode * 59) + this.cMunDescarga.GetHashCode();
                if (this.xMunDescarga != null)
                {
                    hashCode = (hashCode * 59) + this.xMunDescarga.GetHashCode();
                }
                if (this.infCTe != null)
                {
                    hashCode = (hashCode * 59) + this.infCTe.GetHashCode();
                }
                if (this.infNFe != null)
                {
                    hashCode = (hashCode * 59) + this.infNFe.GetHashCode();
                }
                if (this.infMDFeTransp != null)
                {
                    hashCode = (hashCode * 59) + this.infMDFeTransp.GetHashCode();
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
